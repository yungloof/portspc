# 🇧🇷 Guia Mestre de Traduções PT-BR & Verificação de ROMs (Hashes)

Este guia reúne tudo o que você precisa saber para colocar seus ports nativos e recompilações em **Português do Brasil (PT-BR)** sem erros de instalação, além da tabela de **Hashes SHA-1** para confirmar se a sua ROM é a versão exata exigida por cada projeto.

---

## ⚠️ Por que o meu Port rejeitou uma ROM que já estava traduzida em PT-BR?

Essa é a dúvida número 1 de quem começa a usar ports nativos de PC (como *Ship of Harkinian*, *Zelda 64 Recompiled*, *Starship*, *Zelda 3*, *BanjoRecomp*):

1. **Como funcionam as traduções antigas de Emulador:** No emulador, você aplicava um patch `.ips` ou `.bps` direto na ROM (alterando os bytes e ponteiros do arquivo `.z64` ou `.sfc`).
2. **Como funcionam os Ports Nativos e Recompilações:** O gerador do port precisa extrair funções de código e assets de posições exatas da memória da ROM original americana (`USA v1.0`). Se você fornecer uma ROM modificada com patch `.ips`, o **hash SHA-1 muda** e os ponteiros mudam de lugar, fazendo o port recusar a ROM ou travar.
3. **A Solução Moderna (Muito Melhor!):**
   - Sempre use a **ROM original americana limpa (`USA`)** para gerar/instalar o port.
   - Depois de gerado, coloque o **Mod de Tradução PT-BR** (`.o2r`, `.otr`, `.nrm`, etc.) dentro da pasta `mods/` do port!
   - Vantagens: Você pode ativar/desativar a tradução quando quiser, usar fontes em alta definição com acentuação perfeita (`ã`, `ç`, `é`) e combinar a tradução PT-BR com pacotes de texturas HD (*Reloaded*, *Djipi 3DS*) sem conflito!

---

## 🔑 Tabela de Hashes SHA-1 das ROMs Mais Usadas

Você pode verificar se a sua ROM é a correta usando a opção **`[V] Verificar Hash de ROM`** no nosso script `Instalar-Ports.bat` (ou rodando `Get-FileHash -Algorithm SHA1 "sua_rom.z64"` no PowerShell):

| Jogo Original | Port(s) que utilizam | Versão Exigida da ROM | Hash SHA-1 Oficial (ROM Limpa) |
| :--- | :--- | :--- | :--- |
| **Zelda: Ocarina of Time** | *Ship of Harkinian (SoH)* | NTSC-U 1.0 (`z64` Big Endian) ou PAL Debug | `5bd1fe107bf8106b2ab6650abecd54d6ace95755` *(USA 1.0)*<br>`cee6bc3c2a634b41728f2af8da54d9bf8cc14099` *(PAL GC MQ Debug)* |
| **Zelda: Majora's Mask** | *2 Ship 2 Harkinian* & *Zelda 64: Recompiled* | USA v1.0 (`baserom.us.rev0.z64`) | `d6133ace5afaa0882cf214cf88daba39e266c078` |
| **Super Mario 64** | *sm64coopdx*, *Render96ex*, *Ghostship* | USA v1.0 (`baserom.us.z64`) | `9bef1128717f958171a4afac3ed78ee2bb4e86ce` |
| **Star Fox 64** | *Starship* | USA v1.1 / Rev A (`.z64`) | `09f0d105f476b00efa5303a3ebc42e60a7753b7a` |
| **Mario Kart 64** | *SpaghettiKart* | USA v1.0 (`.z64`) | `579c48e211ae952530ffc8738709f078d5dd215e` |
| **Banjo-Kazooie** | *Banjo: Recompiled* & *Lighthouse* | USA v1.0 (`.z64`) | `ded6ee166e740ad1bc810fd678a84b48e245ab80` |
| **Perfect Dark** | *Perfect Dark PC Port* | USA v1.1 / Rev A (`pd.ntsc-final.z64`) | `af8ae8a2fb7885de2f4ed9f0b2f35f54a6c1a9f1` |
| **Wave Race 64** | *Wave Race 64: Recompiled* | USA v1.1 / Rev A (`.z64`) | `5f4eb2e4fb27bc2e6e1eb8627a57cb35629a5fa0` |
| **Zelda: A Link to the Past** | *Zelda 3 (`snesrev/zelda3`)* | USA (`zelda3.sfc` sem cabeçalho, 1 MB) | `6d4f10a8b10e10dbe624cb23cf03b88bb8252973` |
| **Super Metroid** | *Super Metroid (`snesrev/sm`)* | JU / USA (`sm.smc` sem cabeçalho, 3 MB) | `da957f0d63d14cb441d215462904c4fa8519c613` |
| **Super Mario World** | *Super Mario World (`snesrev/smw`)* | USA (`smw.sfc` sem cabeçalho, 512 KB) | `6b47bb75d16514b6a476aa0c73a683a2a4c18765` |
| **Sonic 3 & Knuckles** | *Sonic 3 A.I.R.* | Mega Drive (`Sonic_Knuckles_wSonic3.bin`) | `fa52a9ef828bfa17fa8f9e2f20b709c3b20097a2` |

> [!TIP]
> **E se minha ROM de N64 estiver em formato `.n64` ou `.v64` (Byte-swapped)?**
> A maioria dos ports modernos (como *Zelda64Recomp*, *Ship of Harkinian* e *BanjoRecomp*) converte ou aceita automaticamente, ou você pode converter gratuitamente no navegador usando o [Marc Robledo ROM Patcher JS / N64 Swapper](https://www.marcrobledo.com/rom-patcher-js/) para o formato **`.z64` (Big Endian)**.

---

## 🗂️ Resumo Rápido: Onde Baixar as Principais Traduções PT-BR

### 1. Jogos que JÁ VÊM em PT-BR (Não precisa baixar nada externo!)
- **Jak & Daxter 1, Jak II e Jak 3** ([OpenGOAL](https://opengoal.dev/)) -> Menu de Opções > Idioma > *Português (Brasil)*.
- **Diablo 1 + Hellfire** ([DevilutionX](https://github.com/diasurgical/DevilutionX/releases)) -> Settings > Language > *Português (Brasil)*.
- **Another Metroid 2 Remake** ([AM2RLauncher](https://github.com/AM2R-Community-Developers/AM2RLauncher/releases)) -> Options > Language > *Português*.
- **RollerCoaster Tycoon 1 & 2** ([OpenRCT2](https://openrct2.io/)) -> Opções > Idioma > *Português (BR)*.
- **Transport Tycoon Deluxe** ([OpenTTD](https://www.openttd.org/)) -> Opções > *Português (Brasil)*.
- **Theme Hospital** ([CorsixTH](https://github.com/CorsixTH/CorsixTH/releases)) -> Settings > *Português (Brasil)*.
- **Heroes of Might and Magic II** ([fheroes2](https://github.com/ihhub/fheroes2/releases)) -> Configurações > *Português*.
- **Re-Volt** ([RVGL](https://rvgl.org/)) -> Options > Language > *Portuguese*.
- **Doom I & II / Heretic / Hexen / Duke 3D** ([GZDoom](https://github.com/ZDoom/gzdoom/releases) / [UZDoom](https://github.com/UZDoom/UZDoom/releases) / [Raze](https://github.com/ZDoom/Raze/releases)) -> Menus e textos de sistema nativos em PT-BR.
- **Sonic Time Twisted**, **Mega Man Maker**, **PokéMMO** -> Nativos em PT-BR nas opções.

### 2. Mods `.o2r` / `.otr` / `.nrm` (Arrastar para a pasta `mods/`)
- **Zelda: Ocarina of Time (*Ship of Harkinian*)**: [GameBanana - SoH Complete Translations](https://gamebanana.com/mods/cats/17165) (*PT-BR Translation* por LordeJabiraca / *Pt-Br OoT HD & Djipi 3DS* por EduardoA).
- **Zelda: Majora's Mask (*2 Ship 2 Harkinian*)**: [GameBanana - 2S2H Mods](https://gamebanana.com/games/20369) (*Brazilian Portuguese translation mod* por Srchronotrigger & GhostlyDark).
- **Zelda: Majora's Mask (*Zelda 64: Recompiled*)**: [GameBanana - Zelda 64 Recompiled](https://gamebanana.com/games/20420) / [Thunderstore](https://thunderstore.io/c/zelda-64-recompiled/) (*Tradução Pt-Br Majora's Mask Recompiled* `.nrm` por EduardoA).
- **Banjo-Kazooie (*Banjo: Recompiled*)**: [GameBanana - Banjo Recompiled](https://gamebanana.com/games/21188) / [Thunderstore](https://thunderstore.io/c/banjo-recompiled/) (*Banjo-Kazooie: Recomp PtBr* `.nrm`).
- **Star Fox 64 (*Starship*)**: [GameBanana - Starship](https://gamebanana.com/games/21291) (Tradução e Dublagem PT-BR `.o2r`).
- **Super Mario 64 (*sm64coopdx*)**: [GameBanana - Localização Brasileira SM64COOPDX](https://gamebanana.com/mods/505265).
- **Sonic Unleashed (*Unleashed Recompiled*)**: [GameBanana - Sonic Unleashed](https://gamebanana.com/games/6465) (*Sonic Braleashed* — Legenda + Dublagem PT-BR via [HedgeModManager](https://github.com/thesupersonic16/HedgeModManager/releases)).
- **Sonic Mania Plus (*RSDKv5*)**: [GameBanana - Sonic Mania](https://gamebanana.com/games/6059) (*Sonic Mania Plus - PT-BR Translation Mod*).
- **Sonic 3 & Knuckles (*Sonic 3 A.I.R.*)**: [GameBanana - Sonic 3 A.I.R.](https://gamebanana.com/games/7342) (*[PT-BR] HUD em Português / Brasonic 3 A.I.R.*).

### 3. Traduções e Dublagens Clássicas / Nexus Mods / ModDB
- **Caesar III (*Julius & Augustus*)**: [Wiki Oficial do Julius - Language Patches](https://github.com/bvschaik/julius/wiki/Language-patches) (Tradução e Dublagem clássica PT-BR da Brasoft!).
- **Half-Life 1 (*Xash3D FWGS*)**: [ModDB - Half-Life Dublado PT-BR (Mesa Preta Dubs)](https://www.moddb.com/mods/half-life-dublado-pt-br).
- **Grim Fandango, Full Throttle, Monkey Island 1-3, The Dig, Day of the Tentacle (*ScummVM*)**: [Grupo ScummBR](http://www.scummbr.org/).
- **Morrowind (*OpenMW*)**: [Nexus Mods - Morrowind PT-BR](https://www.nexusmods.com/morrowind).
- **Daggerfall (*Daggerfall Unity*)**: [Nexus Mods - Tradução Daggerfall Unity #565](https://www.nexusmods.com/daggerfallunity/mods/565).
- **Fallout 1 & 2 (*fallout1-ce / fallout2-ce*)**: [GitHub fpaganini/Fallout_ptbr](https://github.com/fpaganini/Fallout_ptbr) e [Nexus Mods Fallout 2](https://www.nexusmods.com/fallout2/mods).
- **GTA III & Vice City (*re3 / reVC*)**: [MixMods - Traduções PT-BR re3/reVC](https://www.mixmods.com.br/).
