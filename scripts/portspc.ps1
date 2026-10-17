#Requires -Version 5.1
[Console]::OutputEncoding = [System.Text.Encoding]::UTF8
$OutputEncoding = [System.Text.Encoding]::UTF8

$RepoRoot = Split-Path -Parent $PSScriptRoot
$CatalogPath = Join-Path $RepoRoot "catalog.json"
$DefaultInstallRoot = Join-Path $RepoRoot "Jogos_Instalados"

if (-not (Test-Path $CatalogPath)) {
    Write-Host "Erro: catalog.json não encontrado em $CatalogPath" -ForegroundColor Red
    Read-Host "Pressione Enter para sair"
    exit 1
}

$Catalog = Get-Content -Path $CatalogPath -Raw -Encoding UTF8 | ConvertFrom-Json

$KnownRomHashes = @{
    "5bd1fe107bf8106b2ab6650abecd54d6ace95755" = "Zelda: Ocarina of Time (USA v1.0 .z64) -> Compatível com Ship of Harkinian!"
    "cee6bc3c2a634b41728f2af8da54d9bf8cc14099" = "Zelda: Ocarina of Time Master Quest Debug (PAL) -> Compatível com Ship of Harkinian!"
    "d6133ace5afaa0882cf214cf88daba39e266c078" = "Zelda: Majora's Mask (USA v1.0 .z64) -> Compatível com 2 Ship 2 Harkinian e Zelda 64: Recompiled!"
    "9bef1128717f958171a4afac3ed78ee2bb4e86ce" = "Super Mario 64 (USA v1.0 .z64) -> Compatível com sm64coopdx, Render96ex e Ghostship!"
    "09f0d105f476b00efa5303a3ebc42e60a7753b7a" = "Star Fox 64 (USA v1.1 Rev A .z64) -> Compatível com Starship!"
    "579c48e211ae952530ffc8738709f078d5dd215e" = "Mario Kart 64 (USA v1.0 .z64) -> Compatível com SpaghettiKart!"
    "ded6ee166e740ad1bc810fd678a84b48e245ab80" = "Banjo-Kazooie (USA v1.0 .z64) -> Compatível com Banjo: Recompiled e Lighthouse!"
    "af8ae8a2fb7885de2f4ed9f0b2f35f54a6c1a9f1" = "Perfect Dark (USA v1.1 Final .z64) -> Compatível com Perfect Dark PC Port!"
    "5f4eb2e4fb27bc2e6e1eb8627a57cb35629a5fa0" = "Wave Race 64 (USA v1.1 Rev A .z64) -> Compatível com Wave Race 64: Recompiled!"
    "6d4f10a8b10e10dbe624cb23cf03b88bb8252973" = "Zelda: A Link to the Past (USA .sfc) -> Compatível com Zelda 3 (snesrev/zelda3)!"
    "da957f0d63d14cb441d215462904c4fa8519c613" = "Super Metroid (JU .smc) -> Compatível com Super Metroid PC (snesrev/sm)!"
    "6b47bb75d16514b6a476aa0c73a683a2a4c18765" = "Super Mario World (USA .sfc) -> Compatível com SMW (snesrev/smw) e SMW Remastered!"
    "fa52a9ef828bfa17fa8f9e2f20b709c3b20097a2" = "Sonic 3 & Knuckles (.bin Mega Drive) -> Compatível com Sonic 3 A.I.R.!"
}

function Get-DriveFreeSpaceGB {
    param([string]$PathToCheck)
    try {
        $DriveLetter = (Split-Path -Qualifier $PathToCheck).TrimEnd(':')
        $Drive = Get-PSDrive -Name $DriveLetter -ErrorAction Stop
        return [math]::Round($Drive.Free / 1GB, 2)
    } catch {
        return "N/A"
    }
}

function Show-Header {
    Clear-Host
    $FreeGB = Get-DriveFreeSpaceGB -PathToCheck $RepoRoot
    $DriveQual = Split-Path -Qualifier $RepoRoot
    Write-Host "================================================================================" -ForegroundColor Cyan
    Write-Host "   🎮 PORTSPC - CATÁLOGO E INSTALADOR SOB DEMANDA DE PORTS NATIVOS (PT-BR)     " -ForegroundColor White
    Write-Host "   💾 Espaço Livre no Disco ($DriveQual): $FreeGB GB | Modo Econômico (Sem Lixo Temporário)" -ForegroundColor Green
    Write-Host "================================================================================" -ForegroundColor Cyan
}

function Invoke-RomVerifier {
    Show-Header
    Write-Host "`n🔍 VERIFICADOR DE HASH SHA-1 DE ROMs (LIMPA vs MODIFICADA)" -ForegroundColor Yellow
    Write-Host "Selecione o arquivo da sua ROM (.z64, .n64, .v64, .sfc, .smc, .bin) para verificar se ela"
    Write-Host "é a versão exata exigida pelos ports nativos e recompilações.`n"

    $FilePath = $null
    try {
        Add-Type -AssemblyName System.Windows.Forms -ErrorAction Stop
        $Dialog = New-Object System.Windows.Forms.OpenFileDialog
        $Dialog.Title = "Selecione a ROM para verificar o Hash SHA-1"
        $Dialog.Filter = "Arquivos de ROM (*.z64;*.n64;*.v64;*.sfc;*.smc;*.bin;*.nes;*.nds)|*.z64;*.n64;*.v64;*.sfc;*.smc;*.bin;*.nes;*.nds|Todos os arquivos (*.*)|*.*"
        if ($Dialog.ShowDialog() -eq [System.Windows.Forms.DialogResult]::OK) {
            $FilePath = $Dialog.FileName
        }
    } catch {
        # Fallback para digitação no console
    }

    if (-not $FilePath) {
        $FilePath = Read-Host "Digite ou arraste o caminho da ROM aqui (ou Enter para voltar)"
        $FilePath = $FilePath.Trim('"')
    }

    if ([string]::IsNullOrWhiteSpace($FilePath) -or -not (Test-Path $FilePath)) {
        return
    }

    Write-Host "`nCalculando SHA-1 de: $FilePath ..." -ForegroundColor Cyan
    $HashObj = Get-FileHash -Path $FilePath -Algorithm SHA1
    $Sha1 = $HashObj.Hash.ToLower()

    Write-Host "SHA-1 Encontrado: " -NoNewline
    Write-Host $Sha1 -ForegroundColor White

    if ($KnownRomHashes.ContainsKey($Sha1)) {
        Write-Host "`n✅ ROM 100% VÁLIDA E OFICIAL!" -ForegroundColor Green
        Write-Host "   -> $($KnownRomHashes[$Sha1])" -ForegroundColor Green
    } else {
        Write-Host "`n⚠️ Este SHA-1 não corresponde às ROMs USA v1.0 limpas da nossa tabela principal." -ForegroundColor Yellow
        Write-Host "   Possíveis motivos:"
        Write-Host "   1. Sua ROM de N64 está no formato .n64/.v64 (Byte-swapped) em vez de .z64 (Big Endian)."
        Write-Host "   2. Sua ROM já possui um patch de tradução (.ips/.bps) aplicado — lembre-se: gere o port com a ROM USA limpa e use o mod PT-BR na pasta mods/!"
        Write-Host "   3. É uma ROM de outro jogo ou revisão (ex: Ocarina of Time v1.1/v1.2 que também funcionam no Ship of Harkinian)."
    }

    Write-Host ""
    Read-Host "Pressione Enter para voltar ao menu"
}

function Install-PortFromGitHub {
    param($Item)

    Show-Header
    Write-Host "`n⬇️ INSTALAÇÃO SOB DEMANDA: $($Item.name)" -ForegroundColor Cyan
    Write-Host "Jogo: $($Item.game)" -ForegroundColor Gray
    Write-Host "Repositório Oficial: https://github.com/$($Item.github_repo)" -ForegroundColor Gray

    $TargetDir = Join-Path $DefaultInstallRoot $Item.id
    Write-Host "`nPasta de destino padrão: $TargetDir" -ForegroundColor Yellow
    $CustomDir = Read-Host "Pressione Enter para confirmar ou digite outro caminho"
    if (-not [string]::IsNullOrWhiteSpace($CustomDir)) {
        $TargetDir = $CustomDir.Trim('"')
    }

    if (-not (Test-Path $TargetDir)) {
        New-Item -ItemType Directory -Path $TargetDir -Force | Out-Null
    }

    $ApiUrl = "https://api.github.com/repos/$($Item.github_repo)/releases/latest"
    Write-Host "`nConsultando última versão oficial no GitHub ($($Item.github_repo))..." -ForegroundColor Cyan

    try {
        [Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
        $Release = Invoke-RestMethod -Uri $ApiUrl -Headers @{ "User-Agent" = "portspc-installer" } -ErrorAction Stop
    } catch {
        Write-Host "Não foi possível consultar a release automática (ou o repositório usa tags customizadas)." -ForegroundColor Yellow
        Write-Host "Abrindo a página de Releases no seu navegador: https://github.com/$($Item.github_repo)/releases" -ForegroundColor Cyan
        Start-Process "https://github.com/$($Item.github_repo)/releases"
        Read-Host "Pressione Enter para voltar"
        return
    }

    $Asset = $Release.assets | Where-Object { $_.name -match $Item.asset_pattern } | Select-Object -First 1
    if (-not $Asset) {
        $Asset = $Release.assets | Where-Object { $_.name -match "(?i)(win|windows|x64|msvc)" } | Select-Object -First 1
    }

    if (-not $Asset) {
        Write-Host "Nenhum pacote Windows (.zip/.7z/.exe) identificado automaticamente na release $($Release.tag_name)." -ForegroundColor Yellow
        Write-Host "Abrindo a página oficial de Releases no navegador..." -ForegroundColor Cyan
        Start-Process $Release.html_url
        Read-Host "Pressione Enter para voltar"
        return
    }

    $SizeMB = [math]::Round($Asset.size / 1MB, 2)
    Write-Host "Versão encontrada: $($Release.tag_name) -> $($Asset.name) ($SizeMB MB)" -ForegroundColor Green
    $TempFile = Join-Path $TargetDir $Asset.name

    Write-Host "Baixando $($Asset.name)..." -ForegroundColor Cyan
    try {
        Invoke-WebRequest -Uri $Asset.browser_download_url -OutFile $TempFile -UseBasicParsing
    } catch {
        Write-Host "Erro durante o download: $_" -ForegroundColor Red
        Read-Host "Pressione Enter para voltar"
        return
    }

    if ($TempFile -match "\.zip$") {
        Write-Host "Extraindo arquivos em $TargetDir ..." -ForegroundColor Cyan
        Expand-Archive -Path $TempFile -DestinationPath $TargetDir -Force
        Remove-Item -Path $TempFile -Force
        Write-Host "🗑️ Arquivo .zip temporário removido para economizar espaço no disco!" -ForegroundColor Green
    } else {
        Write-Host "Arquivo salvo em: $TempFile" -ForegroundColor Green
    }

    Write-Host "`n================================================================================" -ForegroundColor Green
    Write-Host "✅ $($Item.name) baixado com sucesso em: $TargetDir" -ForegroundColor Green
    Write-Host "📌 O que você precisa fazer agora:" -ForegroundColor Yellow
    Write-Host "   1. Requisito: $($Item.requirements)"
    Write-Host "   2. PT-BR ($($Item.ptbr_badge)): $($Item.ptbr_instructions)"
    Write-Host "================================================================================" -ForegroundColor Green

    $OpenFolder = Read-Host "`nDeseja abrir a pasta do jogo agora? (S/N)"
    if ($OpenFolder -match "^[sS]") {
        Invoke-Item $TargetDir
    }
    $OpenPtBr = Read-Host "Deseja abrir o link da Tradução / Mod PT-BR no navegador? (S/N)"
    if ($OpenPtBr -match "^[sS]" -and $Item.ptbr_url) {
        Start-Process $Item.ptbr_url
    }
}

function Show-PortDetails {
    param($Item)
    while ($true) {
        Show-Header
        Write-Host "`n🎯 $($Item.name)" -ForegroundColor Yellow
        Write-Host "--------------------------------------------------------------------------------" -ForegroundColor DarkGray
        Write-Host "Jogo Original     : $($Item.game) ($($Item.platform))"
        Write-Host "Categoria         : $($Item.category)"
        Write-Host "Requisitos        : $($Item.requirements)"
        Write-Host "Status PT-BR      : $($Item.ptbr_badge) - $($Item.ptbr_status)" -ForegroundColor Green
        Write-Host "Como ter PT-BR    : $($Item.ptbr_instructions)" -ForegroundColor Cyan
        Write-Host "Site / Repo       : $($Item.site_url)"
        Write-Host "Link PT-BR        : $($Item.ptbr_url)"
        Write-Host "--------------------------------------------------------------------------------" -ForegroundColor DarkGray
        Write-Host "[1] ⬇️ Baixar e Instalar Última Versão de Windows (Sob Demanda)" -ForegroundColor Green
        Write-Host "[2] 🇧🇷 Abrir Link da Tradução / Mod PT-BR no Navegador" -ForegroundColor Yellow
        Write-Host "[3] 🌐 Abrir Repositório / Site Oficial no Navegador" -ForegroundColor Cyan
        Write-Host "[0] ⬅️ Voltar à Lista"

        $Choice = Read-Host "`nEscolha uma opção"
        switch ($Choice) {
            "1" { Install-PortFromGitHub -Item $Item }
            "2" { Start-Process $Item.ptbr_url }
            "3" { Start-Process $Item.site_url }
            "0" { return }
            default { }
        }
    }
}

$FilterPtBrOnly = $false
$SearchTerm = ""

while ($true) {
    Show-Header
    $Filtered = $Catalog
    if ($FilterPtBrOnly) {
        $Filtered = $Filtered | Where-Object { $_.ptbr_badge -match "🟢|🟡|🔵" }
        Write-Host "   [Filtro Ativo: Apenas Jogos com Tradução / Suporte PT-BR 🇧🇷]" -ForegroundColor Yellow
    }
    if (-not [string]::IsNullOrWhiteSpace($SearchTerm)) {
        $Filtered = $Filtered | Where-Object {
            $_.name -match $SearchTerm -or $_.game -match $SearchTerm -or $_.category -match $SearchTerm
        }
        Write-Host "   [Busca Ativa: '$SearchTerm']" -ForegroundColor Yellow
    }

    Write-Host ""
    $Index = 1
    $IndexMap = @{}
    $CurrentCategory = ""

    foreach ($Item in $Filtered) {
        if ($Item.category -ne $CurrentCategory) {
            $CurrentCategory = $Item.category
            Write-Host "  === $CurrentCategory ===" -ForegroundColor Magenta
        }
        $IndexMap["$Index"] = $Item
        $NumStr = $Index.ToString().PadLeft(2, ' ')
        $NamePad = $Item.name.PadRight(38, ' ')
        Write-Host ("  [{0}] {1} | {2}" -f $NumStr, $NamePad, $Item.ptbr_badge)
        $Index++
    }

    Write-Host "`n--------------------------------------------------------------------------------" -ForegroundColor DarkGray
    Write-Host "  [P] Alternar Filtro Apenas com PT-BR   [B] Buscar por Nome   [V] Verificar Hash de ROM" -ForegroundColor Cyan
    Write-Host "  [L] Limpar Filtros                     [G] Abrir Pasta Jogos [S] Sair" -ForegroundColor Cyan
    Write-Host "--------------------------------------------------------------------------------" -ForegroundColor DarkGray

    $InputVal = Read-Host "Digite o número do jogo ou uma letra de comando"
    $InputVal = $InputVal.Trim()

    if ($InputVal -match "^[sS]$") {
        break
    } elseif ($InputVal -match "^[pP]$") {
        $FilterPtBrOnly = -not $FilterPtBrOnly
    } elseif ($InputVal -match "^[bB]$") {
        $SearchTerm = Read-Host "Digite o nome do jogo ou série (ex: Zelda, Sonic, Mario, Jak, Diablo)"
    } elseif ($InputVal -match "^[lL]$") {
        $FilterPtBrOnly = $false
        $SearchTerm = ""
    } elseif ($InputVal -match "^[vV]$") {
        Invoke-RomVerifier
    } elseif ($InputVal -match "^[gG]$") {
        if (-not (Test-Path $DefaultInstallRoot)) {
            New-Item -ItemType Directory -Path $DefaultInstallRoot -Force | Out-Null
        }
        Invoke-Item $DefaultInstallRoot
    } elseif ($IndexMap.ContainsKey($InputVal)) {
        Show-PortDetails -Item $IndexMap[$InputVal]
    }
}
