param(
    [ValidateSet("menu", "list", "install", "info", "verify-rom")]
    [string]$Action = "menu",
    [string]$PortId = "",
    [string]$InstallBaseDir = "F:\Jogos\PortsPC"
)

$ErrorActionPreference = "Stop"
[Console]::OutputEncoding = [System.Text.Encoding]::UTF8

$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$RepoRoot = Split-Path -Parent $ScriptDir
$CatalogPath = Join-Path $RepoRoot "catalog.json"

if (-not (Test-Path $CatalogPath)) {
    Write-Host "[ERRO] Arquivo catalog.json nao encontrado em: $CatalogPath" -ForegroundColor Red
    exit 1
}

$CatalogRaw = Get-Content -Path $CatalogPath -Raw -Encoding UTF8
$Catalog = $CatalogRaw | ConvertFrom-Json

function Show-Header {
    Clear-Host
    Write-Host "==========================================================================" -ForegroundColor Cyan
    Write-Host "   PORTSPC - GERENCIADOR & INSTALADOR SOB DEMANDA (WINDOWS / PT-BR)       " -ForegroundColor Yellow
    Write-Host "   Economia maxima de disco: baixa apenas o jogo escolhido e limpa o temp " -ForegroundColor Gray
    Write-Host "==========================================================================" -ForegroundColor Cyan
    Write-Host ""
}

function Show-PortInfo {
    param($Item)
    Write-Host "--------------------------------------------------------------------------" -ForegroundColor DarkGray
    Write-Host " Nome do Projeto : " -NoNewline -ForegroundColor Cyan; Write-Host $Item.name -ForegroundColor White
    Write-Host " Jogo Original   : " -NoNewline -ForegroundColor Cyan; Write-Host "$($Item.game) ($($Item.platform))" -ForegroundColor White
    Write-Host " Categoria       : " -NoNewline -ForegroundColor Cyan; Write-Host $Item.category -ForegroundColor White
    Write-Host " Repositorio     : " -NoNewline -ForegroundColor Cyan; Write-Host "https://github.com/$($Item.github_repo)" -ForegroundColor Blue
    Write-Host " Site Oficial    : " -NoNewline -ForegroundColor Cyan; Write-Host $Item.website -ForegroundColor Blue
    Write-Host " O que precisa   : " -NoNewline -ForegroundColor Cyan; Write-Host $Item.requires -ForegroundColor Yellow
    Write-Host " Status PT-BR    : " -NoNewline -ForegroundColor Green; Write-Host $Item.ptbr_status -ForegroundColor Green
    Write-Host " Como ter PT-BR  : " -NoNewline -ForegroundColor Green; Write-Host $Item.ptbr_details -ForegroundColor White
    if ($Item.ptbr_url) {
        Write-Host " Link PT-BR/Mod  : " -NoNewline -ForegroundColor Green; Write-Host $Item.ptbr_url -ForegroundColor Magenta
    }
    Write-Host "--------------------------------------------------------------------------" -ForegroundColor DarkGray
}

function Invoke-RomVerifier {
    Show-Header
    Write-Host "=== VERIFICADOR DE HASH (SHA-1 / MD5) DE ROM / ISO ===" -ForegroundColor Yellow
    Write-Host "Selecione o arquivo da sua ROM ou ISO para calcular o SHA-1 e MD5." -ForegroundColor Gray
    Write-Host ""

    Add-Type -AssemblyName System.Windows.Forms
    $Dialog = New-Object System.Windows.Forms.OpenFileDialog
    $Dialog.Title = "Selecione sua ROM ou ISO para verificar"
    $Dialog.Filter = "Arquivos de Jogo (*.z64;*.n64;*.v64;*.sfc;*.smc;*.iso;*.bin;*.cue;*.gba;*.gbc;*.nds;*.rvz)|*.z64;*.n64;*.v64;*.sfc;*.smc;*.iso;*.bin;*.cue;*.gba;*.gbc;*.nds;*.rvz|Todos os arquivos (*.*)|*.*"

    if ($Dialog.ShowDialog() -eq [System.Windows.Forms.DialogResult]::OK) {
        $FilePath = $Dialog.FileName
        Write-Host "Arquivo selecionado: $FilePath" -ForegroundColor Cyan
        Write-Host "Calculando hashes (aguarde)..." -ForegroundColor Gray
        $Sha1 = (Get-FileHash -Path $FilePath -Algorithm SHA1).Hash.ToLower()
        $Md5  = (Get-FileHash -Path $FilePath -Algorithm MD5).Hash.ToLower()
        Write-Host ""
        Write-Host "  SHA-1 : $Sha1" -ForegroundColor Green
        Write-Host "  MD5   : $Md5" -ForegroundColor Green
        Write-Host ""
        $KnownHashes = @{
            "adde2581d692f38562b21c6a094f6e2708f90f51" = "Super Mario 64 (US) .z64 [Perfeito para sm64coopdx / Render96 / Ghostship]"
            "d6133ace5afaa0882cf214cf88daba39e266c078" = "Zelda: Majora's Mask (US 1.0) .z64 [Perfeito para 2Ship2Harkinian / Zelda64Recomp]"
            "57a9719ad547c516342e1a15d5c28c3d21b08a19" = "Zelda: Ocarina of Time (US 1.0) .z64 [Perfeito para Ship of Harkinian]"
            "09f0d105f476b00efa5303a3ebc42e60a7753b7a" = "Star Fox 64 (US 1.1) .z64 [Perfeito para Starship / Starfox64Recomp]"
            "579c48e211ae952530ffc8738709f078d5dd215e" = "Mario Kart 64 (US) .z64 [Perfeito para SpaghettiKart / MarioKart64Recomp]"
            "ded6ee14ef17c6ad123f9ffde3d2f2b0fb68e294" = "Banjo-Kazooie (US 1.0) .z64 [Perfeito para BanjoRecomp / Lighthouse]"
            "6d0f2b0a94f3a13b15c8225750f03e4b2b6a8b84" = "Zelda: A Link to the Past (US) .sfc [Perfeito para zelda3]"
            "da957f0d63d14b533239b036c27f601164192b13" = "Super Metroid (JU) .sfc [Perfeito para SuperMetroidRecomp]"
        }
        if ($KnownHashes.ContainsKey($Sha1)) {
            Write-Host "[OK] ROM Reconhecida: $($KnownHashes[$Sha1])" -ForegroundColor Yellow
        } else {
            Write-Host "[INFO] Compare o SHA-1 acima com a documentacao do port desejado." -ForegroundColor Gray
        }
    } else {
        Write-Host "Operacao cancelada." -ForegroundColor Yellow
    }
}

function Install-Port {
    param($Item)
    Show-PortInfo -Item $Item

    $TargetDir = Join-Path $InstallBaseDir $Item.id
    Write-Host ""
    Write-Host "Pasta de destino: $TargetDir" -ForegroundColor Yellow

    $DriveRoot = [System.IO.Path]::GetPathRoot($TargetDir)
    if (Test-Path $DriveRoot) {
        $DriveInfo = Get-PSDrive -Name ($DriveRoot.Substring(0,1)) -ErrorAction SilentlyContinue
        if ($DriveInfo) {
            $FreeGB = [math]::Round($DriveInfo.Free / 1GB, 2)
            Write-Host "Espaco livre em $DriveRoot : $FreeGB GB" -ForegroundColor Gray
        }
    }

    $ApiUrl = "https://api.github.com/repos/$($Item.github_repo)/releases/latest"
    Write-Host "Consultando ultima versao no GitHub ($($Item.github_repo))..." -ForegroundColor Cyan

    try {
        $Headers = @{ "User-Agent" = "PortsPC-Installer/2.0" }
        $Release = Invoke-RestMethod -Uri $ApiUrl -Headers $Headers -Method Get
    } catch {
        Write-Host "[AVISO] Nao foi possivel obter release via /releases/latest. Tentando lista de releases..." -ForegroundColor Yellow
        try {
            $ReleasesList = Invoke-RestMethod -Uri "https://api.github.com/repos/$($Item.github_repo)/releases" -Headers $Headers -Method Get
            if ($ReleasesList -and $ReleasesList.Count -gt 0) {
                $Release = $ReleasesList[0]
            } else {
                Write-Host "[INFO] Este projeto ainda nao possui binarios pre-compilados na aba Releases ou distribui pelo site oficial." -ForegroundColor Yellow
                Write-Host "Abrindo pagina oficial no navegador: $($Item.website)" -ForegroundColor Cyan
                Start-Process $Item.website
                return
            }
        } catch {
            Write-Host "[ERRO] Falha ao consultar a API do GitHub. Abrindo pagina oficial: $($Item.website)" -ForegroundColor Red
            Start-Process $Item.website
            return
        }
    }

    $Asset = $Release.assets | Where-Object { $_.name -match $Item.asset_regex } | Select-Object -First 1
    if (-not $Asset) {
        $Asset = $Release.assets | Where-Object { $_.name -match "(win|windows|x64|msvc).*\.(zip|7z|exe|msi)$" } | Select-Object -First 1
    }
    if (-not $Asset) {
        $Asset = $Release.assets | Where-Object { $_.name -match "\.(zip|7z)$" } | Select-Object -First 1
    }

    if (-not $Asset) {
        Write-Host "[AVISO] Nenhum arquivo .zip/.exe automatico identificado na release $($Release.tag_name)." -ForegroundColor Yellow
        Write-Host "Abrindo a pagina de Releases no navegador para escolha manual..." -ForegroundColor Cyan
        Start-Process $Release.html_url
        return
    }

    $SizeMB = [math]::Round($Asset.size / 1MB, 2)
    Write-Host ("Versao encontrada: {0} -> {1} ({2} MB)" -f $Release.tag_name, $Asset.name, $SizeMB) -ForegroundColor Green

    if (-not (Test-Path $TargetDir)) {
        New-Item -ItemType Directory -Path $TargetDir -Force | Out-Null
    }

    $TempFile = Join-Path $TargetDir $Asset.name
    Write-Host ("Baixando {0}..." -f $Asset.name) -ForegroundColor Cyan
    Invoke-WebRequest -Uri $Asset.browser_download_url -OutFile $TempFile -UseBasicParsing

    if ($Asset.name -match "\.zip$") {
        Write-Host "Extraindo arquivos para $TargetDir ..." -ForegroundColor Cyan
        Expand-Archive -Path $TempFile -DestinationPath $TargetDir -Force
        Write-Host "Removendo arquivo .zip temporario para economizar espaco em disco..." -ForegroundColor Gray
        Remove-Item -Path $TempFile -Force
    } elseif ($Asset.name -match "\.7z$") {
        $7zCmd = Get-Command "7z" -ErrorAction SilentlyContinue
        if ($7zCmd) {
            Write-Host "Extraindo arquivo .7z com 7-Zip..." -ForegroundColor Cyan
            & 7z x $TempFile "-o$TargetDir" -y | Out-Null
            Remove-Item -Path $TempFile -Force
        } else {
            Write-Host "[INFO] Arquivo .7z salvo em: $TempFile (Extraia com 7-Zip ou WinRAR e apague o .7z depois)." -ForegroundColor Yellow
        }
    } else {
        Write-Host "[INFO] Instalador salvo em: $TempFile" -ForegroundColor Green
    }

    $LeiamePath = Join-Path $TargetDir "LEIAME-PTBR.txt"
    $LeiameContent = @"
======================================================================
 $($Item.name) - Guia Rapido PortsPC
======================================================================
Jogo Original : $($Item.game) ($($Item.platform))
Versao Baixada: $($Release.tag_name)
Site Oficial  : $($Item.website)
GitHub        : https://github.com/$($Item.github_repo)

O QUE VOCE PRECISA PARA JOGAR:
$($Item.requires)

SUPORTE A PORTUGUES BRASILEIRO (PT-BR):
Status : $($Item.ptbr_status)
Detalhes: $($Item.ptbr_details)
Link da Traducao / Mod: $($Item.ptbr_url)
======================================================================
"@
    Set-Content -Path $LeiamePath -Value $LeiameContent -Encoding UTF8

    Write-Host ""
    Write-Host "[SUCESSO] $($Item.name) instalado em: $TargetDir" -ForegroundColor Green
    Write-Host "Criamos tambem o arquivo LEIAME-PTBR.txt dentro da pasta com as instrucoes e links da traducao!" -ForegroundColor Yellow

    $OpenFolder = Read-Host "Deseja abrir a pasta do jogo agora? (S/N)"
    if ($OpenFolder -match "^[sS]") {
        Start-Process explorer.exe $TargetDir
    }
    if ($Item.ptbr_url) {
        $OpenPtBr = Read-Host "Deseja abrir a pagina da traducao/mod PT-BR no navegador? (S/N)"
        if ($OpenPtBr -match "^[sS]") {
            Start-Process $Item.ptbr_url
        }
    }
}

if ($Action -eq "list") {
    $Index = 1
    foreach ($Item in $Catalog) {
        Write-Host ("[{0:D2}] {1} ({2}) - PT-BR: {3}" -f $Index, $Item.name, $Item.platform, $Item.ptbr_status)
        $Index++
    }
    exit 0
}

if ($Action -eq "info") {
    $Found = $Catalog | Where-Object { $_.id -eq $PortId }
    if ($Found) { Show-PortInfo -Item $Found } else { Write-Host "Port '$PortId' nao encontrado." -ForegroundColor Red }
    exit 0
}

if ($Action -eq "install") {
    $Found = $Catalog | Where-Object { $_.id -eq $PortId }
    if ($Found) { Install-Port -Item $Found } else { Write-Host "Port '$PortId' nao encontrado." -ForegroundColor Red }
    exit 0
}

if ($Action -eq "verify-rom") {
    Invoke-RomVerifier
    exit 0
}

# Menu Interativo Principal
while ($true) {
    Show-Header
    Write-Host "Pasta padrao de instalacao: " -NoNewline -ForegroundColor Gray
    Write-Host $InstallBaseDir -ForegroundColor Yellow
    Write-Host ("Total de Ports no Catalogo : {0} jogos prontos para instalar sob demanda" -f $Catalog.Count) -ForegroundColor Green
    Write-Host ""

    $Categories = $Catalog | Select-Object -ExpandProperty category -Unique
    $Index = 1
    $Map = @{}

    foreach ($Cat in $Categories) {
        Write-Host "=== $Cat ===" -ForegroundColor Magenta
        $CatItems = $Catalog | Where-Object { $_.category -eq $Cat }
        foreach ($Item in $CatItems) {
            $Map[$Index] = $Item
            $NumStr = "{0:D2}" -f $Index
            Write-Host ("  [{0}] " -f $NumStr) -NoNewline -ForegroundColor Cyan
            $NamePad = $Item.name.PadRight(52, [char]32)
            Write-Host $NamePad -NoNewline -ForegroundColor White
            Write-Host (" | PT-BR: {0}" -f $Item.ptbr_status) -ForegroundColor Green
            $Index++
        }
        Write-Host ""
    }

    Write-Host "  [V]  Verificar Hash (SHA-1 / MD5) de uma ROM ou ISO" -ForegroundColor Yellow
    Write-Host "  [P]  Alterar pasta de instalacao (atual: $InstallBaseDir)" -ForegroundColor Yellow
    Write-Host "  [0]  Sair" -ForegroundColor Red
    Write-Host ""
    $Choice = Read-Host "Digite o numero do jogo para ver detalhes/instalar (ou V / P / 0)"

    if ($Choice -eq "0" -or $Choice -eq "sair") {
        break
    } elseif ($Choice -match "^[vV]$") {
        Invoke-RomVerifier
        Read-Host "Pressione ENTER para voltar ao menu"
    } elseif ($Choice -match "^[pP]$") {
        $NewDir = Read-Host "Digite o novo caminho (ex: F:\MeusPorts)"
        if (-not [string]::IsNullOrWhiteSpace($NewDir)) {
            $InstallBaseDir = $NewDir
        }
    } elseif ($Choice -match "^\d+$") {
        $Num = [int]$Choice
        if ($Map.ContainsKey($Num)) {
            Clear-Host
            $Selected = $Map[$Num]
            Show-PortInfo -Item $Selected
            Write-Host ""
            Write-Host "O que deseja fazer?" -ForegroundColor Yellow
            Write-Host "  [1] Baixar e Instalar agora em $InstallBaseDir\$($Selected.id)" -ForegroundColor Green
            Write-Host "  [2] Abrir pagina oficial do projeto no navegador" -ForegroundColor Cyan
            Write-Host "  [3] Abrir link da Traducao / Mod PT-BR no navegador" -ForegroundColor Magenta
            Write-Host "  [0] Voltar ao menu principal" -ForegroundColor Gray
            $SubChoice = Read-Host "Escolha uma opcao"
            if ($SubChoice -eq "1") {
                Install-Port -Item $Selected
                Read-Host "Pressione ENTER para voltar ao menu"
            } elseif ($SubChoice -eq "2") {
                Start-Process $Selected.website
            } elseif ($SubChoice -eq "3" -and $Selected.ptbr_url) {
                Start-Process $Selected.ptbr_url
            }
        }
    }
}
