# 🎮 PORTSPC — Catálogo Brasileiro de Ports Nativos, Recompilações e Clássicos para PC

Um repositório comunitário, atualizado (2026) e livre de gatekeeping com todas as fontes oficiais de **Ports Nativos de Console, Recompilações Estáticas (`N64Recomp` / `XenonRecomp` / `snesrecomp`), Descompilações, Source Ports de Clássicos e Fangames/Remakes Nativos para PC**.

Pensado para **Windows** (com notas para **Linux / Steam Deck**), **economia de espaço em disco** e **mapeamento completo de Traduções e Dublagens em Português do Brasil (PT-BR)**.

> [!NOTE]
> **Aviso Legal:** Este repositório **não** hospeda nem distribui ROMs, ISOs, BIOS ou arquivos protegidos por direitos autorais. Todos os ports, recompilações e descompilações listados são projetos de código aberto/comunitários que exigem a sua própria cópia legal do jogo original para extrair os assets.

---

## 💾 Pensado para Pouco Espaço em Disco: Instalador Sob Demanda (`Instalar-Ports.bat`)

Para quem tem SSD/HD com espaço limitado (ex: 200 GB), este repositório pesa **menos de 1 MB** e inclui o gerenciador interativo **[`Instalar-Ports.bat`](Instalar-Ports.bat)** (alimentado por [`scripts/portspc.ps1`](scripts/portspc.ps1) e [`catalog.json`](catalog.json)):

1. **Baixa sob demanda:** Consulta a API do GitHub em tempo real e baixa apenas o port que você escolher jogar naquele momento.
2. **Zero lixo temporário:** Extrai o jogo automaticamente em `Jogos_Instalados/<jogo>` e **apaga o `.zip` temporário na hora** para não ocupar espaço dobrado.
3. **Filtro PT-BR e Links Diretos:** Filtra apenas os jogos que têm suporte a Português Brasileiro e abre direto a página do mod/tradução correspondente.
4. **Verificador de Hash SHA-1 de ROMs integrado (`[V]`):** Aponte sua ROM (`.z64`, `.sfc`, `.bin`) e o script confirma na hora se ela é a versão `USA v1.0` limpa exigida pelos ports!

### Como usar o Instalador no Windows:
```powershell
git clone https://github.com/yungloof/portspc.git
cd portspc
.\Instalar-Ports.bat
```

---

## 📚 Guias Detalhados (Pasta `docs/`)

- 🇧🇷 **[Guia Mestre de Traduções PT-BR & Tabela de Hashes SHA-1 de ROMs](docs/guia-traducoes-ptbr.md)** *(Leia antes de usar ROMs traduzidas!)*
- 🚢 **[Ecossistema HarbourMasters (`libultraship`) — Zelda OoT, Majora's Mask, Star Fox 64, Mario Kart 64](docs/harbourmasters-zelda-mario-starfox.md)**
- ⚡ **[Recompilações Estáticas — Sonic Unleashed, Zelda 64 Recomp, Banjo Recomp, DKC 1/2/3, Wind Waker HD](docs/recompilacoes-n64-xbox360-snes.md)**
- 🎮 **[Descompilações e Ports Nativos — OpenGOAL (Jak 1/2/3), Super Mario 64, Tomb Raider TRX, Zelda 3, Sonic Mania](docs/decomps-ps1-ps2-n64-snes.md)**
- 🖥️ **[Source Ports de Clássicos de PC — Diablo 1 (DevilutionX), Morrowind, Doom, RollerCoaster Tycoon 2, Caesar III, Half-Life](docs/source-ports-classicos-pc.md)**
- 🕹️ **[Fangames, Remakes Nativos & Ports de Arcade — AM2R, Sonic 3 A.I.R., Sonic P-06, SMB/SMW Remastered, Sega Model 1/2/3](docs/fangames-e-arcade.md)**

---

## 🏷️ Legenda de Suporte a Português Brasileiro (PT-BR)

| Badge | Significado |
| :--- | :--- |
| 🟢 **PT-BR Nativo** | O próprio port já vem traduzido em Português do Brasil! Basta selecionar nas opções do jogo. |
| 🟡 **Mod no Port** | Tradução de texto e/ou Dublagem PT-BR instalada na pasta `mods/` (`.o2r`, `.otr`, `.nrm`, HedgeModManager, `.esp`). **Use a ROM original em inglês (`USA v1.0`) para gerar o port!** |
| 🔵 **Tradução nos Arquivos Base** | Funciona substituindo os arquivos de texto/áudio na pasta `data/` / `content/` / `RomFS` (ou traduções/dublagens clássicas oficiais da Brasoft / ScummBR / Tribo Gamer). |
| ⚪ **Sem PT-BR / Não requer** | Jogo de corrida/arcade com mínimo de texto, ou tradução específica para o port ainda em desenvolvimento. |

---

## 1. 🚢 Ecossistema HarbourMasters (`libultraship` — Nintendo 64 no PC)

Todos os projetos **HarbourMasters** empacotam os dados da ROM em arquivos `.o2r` / `.otr`, rodam a 60–240+ FPS em Widescreen e possuem pasta `mods/` nativa. **Sempre use a ROM americana limpa (`.z64`) e coloque a tradução PT-BR na pasta `mods/`!**

| Projeto | Jogo Original | Sistemas | Status PT-BR | Detalhes da Tradução PT-BR & Links Oficiais |
| :--- | :--- | :--- | :--- | :--- |
| **Ship of Harkinian (SoH)** | *The Legend of Zelda: Ocarina of Time* | Win, Linux, macOS, Android, Switch | 🟡 **Mod `.o2r`/`.otr` Completo** | • **PT-BR Translation** (*LordeJabiraca*) e **Pt-Br OoT HD / Djipi 3DS** (*EduardoA*)<br>• [GitHub Releases](https://github.com/HarbourMasters/Shipwright/releases) · [Mods PT-BR (GameBanana)](https://gamebanana.com/mods/cats/17165) |
| **2 Ship 2 Harkinian (2S2H)** | *The Legend of Zelda: Majora's Mask* | Win, Linux, macOS, Android | 🟡 **Mod `.o2r`/`.otr` Completo** | • **Brazilian Portuguese translation mod** (*Srchronotrigger / GhostlyDark / Projeto BR*) + **Reloaded PT-BR HUD**<br>• [GitHub Releases](https://github.com/HarbourMasters/2ship2harkinian/releases) · [Mods PT-BR (GameBanana)](https://gamebanana.com/games/20369) |
| **Starship** | *Star Fox 64* | Win, Linux, macOS | 🟡 **Mod Texto + Dublagem PT-BR** | • Mods `.o2r` de legendas/menus e **Dublagem PT-BR** para as vozes do rádio<br>• [GitHub Releases](https://github.com/HarbourMasters/Starship/releases) · [Mods (GameBanana)](https://gamebanana.com/games/21291) |
| **SpaghettiKart** | *Mario Kart 64* | Win, Linux, macOS | ⚪ **Não requer (Corrida)** | • Corrida arcade com mínimo de texto; aceita mods `.o2r` de texturas e UI<br>• [GitHub Releases](https://github.com/HarbourMasters/SpaghettiKart/releases) · [GameBanana](https://gamebanana.com/games/21847) |
| **Ghostship** | *Super Mario 64* | Win, Linux, macOS | 🟡 **Mods `.o2r`** | • Suporta pacotes `.o2r` *(para PT-BR + Dublagem + Co-op, veja também `sm64coopdx` abaixo)*<br>• [GitHub Releases](https://github.com/HarbourMasters/Ghostship/releases) · [GameBanana](https://gamebanana.com/games/21290) |
| **Lighthouse** | *Banjo-Kazooie* | Win, Linux, macOS | 🟡 **Suporta Mods `.o2r`** | • Port no motor libultraship *(para jogar em PT-BR hoje, recomendamos o `Banjo: Recompiled` abaixo!)*<br>• [GitHub Releases](https://github.com/HarbourMasters/Lighthouse/releases) · [GameBanana](https://gamebanana.com/games/21848) |
| **PaperBoat** | *Paper Mario* | Win, Linux, macOS | ⚪ **Em desenvolvimento** | • Baseado na decomp *Paper Mario DX*<br>• [GitHub](https://github.com/HarbourMasters/PaperBoat) · [GameBanana](https://gamebanana.com/games/21849) |

---

## 2. ⚡ Recompilações Estáticas (`N64Recomp`, `XenonRecomp`, `snesrecomp`, Wii/Wii U/PS2/NDS/3DS)

Binários de console convertidos diretamente em código C++ nativo de PC com renderizadores modernos (**RT64** D3D12/Vulkan, Ray Tracing, Ultrawide e 60–240+ FPS).

| Projeto | Jogo Original (Console) | Sistemas | Status PT-BR | Detalhes da Tradução PT-BR & Links Oficiais |
| :--- | :--- | :--- | :--- | :--- |
| **Unleashed Recompiled** | *Sonic Unleashed* (Xbox 360) | Win, Linux | 🟢 **UI Nativa** + 🟡 **Mod Texto & Dublagem** | • Instalador nativo em PT-BR + Mod **Sonic Braleashed** (Legenda + Dublagem PT-BR via HedgeModManager) e **UnleasHD PTBR**<br>• [GitHub Releases](https://github.com/hedge-dev/UnleashedRecomp/releases) · [Mods (GameBanana)](https://gamebanana.com/games/6465) |
| **Zelda 64: Recompiled** | *Zelda: Majora's Mask* (N64) | Win, Linux, macOS | 🟡 **Mod `.nrm` Completo** | • **Tradução Pt-Br Majora's Mask Recompiled** (*EduardoA*, compatível com *MM Reloaded HD*) — basta arrastar o `.nrm` para a aba Mods!<br>• [GitHub Releases](https://github.com/Zelda64Recomp/Zelda64Recomp/releases) · [GameBanana](https://gamebanana.com/games/20420) · [Thunderstore](https://thunderstore.io/c/zelda-64-recompiled/) |
| **Banjo: Recompiled** | *Banjo-Kazooie* (N64) | Win, Linux, macOS | 🟡 **Mod `.nrm` Completo** | • **Banjo-Kazooie: Recomp PtBr** (`.nrm`, compatível com *BK Reloaded HD*)<br>• [GitHub Releases](https://github.com/BanjoRecomp/BanjoRecomp/releases) · [GameBanana](https://gamebanana.com/games/21188) · [Thunderstore](https://thunderstore.io/c/banjo-recompiled/) |
| **Dinosaur Planet: Recompiled** | *Dinosaur Planet* (Protótipo Rare N64) | Win, Linux, macOS | ⚪ **Sem PT-BR** | • Suporta mods `.nrm` (*DinomodEnhanced*)<br>• [GitHub Releases](https://github.com/DinosaurPlanetRecomp/dino-recomp/releases) · [Thunderstore](https://thunderstore.io/c/dinosaur-planet-recompiled/) |
| **Goemon 64: Recompiled** | *Mystical Ninja Starring Goemon* (N64) | Win, Linux, macOS, Android | ⚪ **Sem mod `.nrm` PT-BR** | • Requer ROM USA v1.0 limpa<br>• [GitHub Releases](https://github.com/klorfmorf/Goemon64Recomp/releases) |
| **GoldenEye 007 Recompiled** | *GoldenEye 007* (N64) | Win, Linux | ⚪ **Sem PT-BR no port** | • Recomp N64 + RT64<br>• [GitHub](https://github.com/cblock85/GoldenEye64Recomp) |
| **Conker's Bad Fur Day: Recomp** | *Conker's Bad Fur Day* (N64) | Win, Linux, Android | ⚪ **Sem mod `.nrm` PT-BR** | • Recomp N64 + RT64<br>• [GitHub Releases](https://github.com/sciaschi/CBFD-Recompiled/releases) |
| **DKR-R** | *Diddy Kong Racing* (N64) | Win, Linux | ⚪ **Sem PT-BR** | • Recomp N64 + RT64<br>• [GitHub Releases](https://github.com/ThatGuyMcd/DKR-R/releases) |
| **DK64 Recompiled** | *Donkey Kong 64* (N64) | Win, Linux | ⚪ **Sem PT-BR** | • Recomp N64 + RT64<br>• [GitHub Releases](https://github.com/Rainchus/Donkey-Kong-64-Recompiled/releases) |
| **Wave Race 64: Recompiled** | *Wave Race 64* (N64) | Win, Linux, macOS | ⚪ **Não requer (Corrida)** | • Mantido pelo dev brasileiro Daniel Gomes Vieira; requer ROM USA v1.1 (Rev A)<br>• [GitHub Releases](https://github.com/danielgomesvieira2000/wave-race-64-recomp/releases) |
| **Pilotwings 64: Recompiled** | *Pilotwings 64* (N64) | Win, Linux, macOS | ⚪ **Sem PT-BR** | • Requer ROM USA v1.0<br>• [GitHub Releases](https://github.com/danielgomesvieira2000/pilotwings-64-recomp/releases) |
| **Beetle Adventure Racing! Recomp** | *Beetle Adventure Racing!* (N64) | Windows | ⚪ **Não requer (Corrida)** | • Requer ROM USA<br>• [GitHub Releases](https://github.com/danielgomesvieira2000/beetle-adventure-racing-recomp/releases) |
| **Road Rash 64 Recompiled** | *Road Rash 64* (N64) | Win, Linux | ⚪ **Não requer (Corrida)** | • Requer ROM USA<br>• [GitHub Releases](https://github.com/linkssy2/RoadRash64Recompiled/releases) |
| **Banjo-Tooie Recompiled** | *Banjo-Tooie* (N64) | Windows (Alpha) | ⚪ **WIP (Alpha)** | • Requer ROM USA<br>• [GitHub](https://github.com/some-scurvy-dog/BanjoTooieRecompiled) |
| **DKC 1 / 2 / 3 Recompiled** | *Donkey Kong Country 1, 2 e 3* (SNES) | Win, Linux, macOS | ⚪ **Não requer (Plataforma)** | • Widescreen nativo via `snesrecomp`<br>• [DKC1](https://github.com/elliotttate/DKC1Recomp) · [DKC2](https://github.com/elliotttate/DKC2Recomp) · [DKC3](https://github.com/elliotttate/DKC3Recomp) |
| **F-Zero SNES Recompiled** | *F-Zero* (SNES) | Win, Linux, macOS | ⚪ **Não requer (Corrida)** | • Widescreen + Mode 7 em HD + 60+ FPS<br>• [GitHub Releases](https://github.com/mstan/FZeroSNESRecomp/releases) |
| **Wind Waker HD Recompiled** | *Zelda: The Wind Waker HD* (Wii U) | Win, Linux | 🔵 **Tradução na pasta `content/`** | • Compatível com a tradução PT-BR de Wii U/Cemu substituindo os arquivos `.bmg` na pasta `content/`<br>• [GitHub](https://github.com/ZeldaWWHDRecomp/ZeldaWWHDRecomp) |
| **Nebula** | *Super Mario Galaxy* (Wii) | Windows (D3D12) | 🔵 **Compatível com dump PT-BR** | • Lê os arquivos extraídos da ISO de Wii<br>• [GitHub](https://github.com/keepvaibin/nebula) |
| **Fukami** | *Ridge Racer V* (PS2) | Win, Linux, macOS | ⚪ **Não requer (Corrida)** | • Recompilação estática de PS2<br>• [GitHub](https://github.com/danisandoval/fukami) |
| **Midnight Club: LA Recompiled** | *Midnight Club: Los Angeles* (Xbox 360) | Windows | ⚪ **Em desenvolvimento** | • Recompilação estática de Xbox 360<br>• [mcla-recomp](https://github.com/holdmysocks/mcla-recomp) · [Xbox360-Native-Ports](https://github.com/CrownParkComputing/Xbox360-Native-Ports) |
| **Metroid Prime Hunters Recomp** | *Metroid Prime Hunters* (NDS) | Win, Linux | ⚪ **Sem PT-BR no port** | • Tela única Widescreen + Mira no mouse + Online Wiimmfi<br>• [GitHub Releases](https://github.com/mstan/MetroidPrimeHuntersRecomp/releases) |
| **TriAevum** | *Zelda: Ocarina of Time 3D* (3DS) | Windows (Vulkan) | 🔵 **Compatível com RomFS PT-BR** | • Aceita a tradução PT-BR de OoT 3D aplicada na RomFS extraída<br>• [GitHub Releases](https://github.com/coccofresco/TriAevum/releases) |

---

## 3. 🎮 Descompilações e Ports Nativos de Console (PS1, PS2, N64, SNES, GBC, GC, NDS)

Engenharia reversa completa convertida para C/C++/GOAL nativo de PC.

| Projeto | Jogo Original (Console) | Sistemas | Status PT-BR | Detalhes da Tradução PT-BR & Links Oficiais |
| :--- | :--- | :--- | :--- | :--- |
| **OpenGOAL (`jak-project`)** | *Jak & Daxter 1*, *Jak II* e *Jak 3* (PS2) | Win, Linux, macOS | 🟢 **100% Nativo no Port!** | • **Português (Brasil) já vem incluído oficialmente!** Basta ativar no menu de Opções do jogo.<br>• [Site Oficial / Launcher](https://opengoal.dev/) · [GitHub](https://github.com/open-goal/jak-project) |
| **sm64coopdx** & **Render96ex** | *Super Mario 64* (N64) | Win, Linux, macOS, Android | 🟡 **Mod Texto + Dublagem PT-BR** | • **Localização Brasileira para SM64COOPDX** + pacotes de Dublagem PT-BR + Co-op Online até 16 jogadores<br>• [sm64coopdx Releases](https://github.com/coop-deluxe/sm64coopdx/releases) · [Render96ex](https://github.com/Render96/Render96ex) · [Mod PT-BR (GameBanana)](https://gamebanana.com/mods/505265) |
| **TRX (`Tomb1Main` / `Tomb2Main`)** & **OpenLara** | *Tomb Raider I, II e III* (PS1 / PC) | Win, Linux, macOS | 🔵 **Tradução e Dublagem Clássica PC** | • Compatível com as traduções e dublagens PT-BR substituindo os arquivos nas pastas `data/` e `audio/`<br>• [TRX Releases](https://github.com/LostArtefacts/TRX/releases) · [OpenLara](https://github.com/XProger/OpenLara) |
| **Severed Chains** | *The Legend of Dragoon* (PS1) | Win, Linux, macOS | 🟡 **Mod em adaptação (Projeto Dragoon)** | • Motor sem limite de ponteiros de texto do PS1<br>• [GitHub Releases](https://github.com/Legend-of-Dragoon-Modding/Severed-Chains/releases) · [Site Oficial](https://legendofdragoon.org/projects/severed-chains/) |
| **REDRIVER2** | *Driver 2* (PS1) | Win, Linux | 🔵 **Compatível com arquivos PT-BR** | • Lê as tabelas de texto e áudio extraídas das ISOs dos Discos 1 e 2<br>• [GitHub Releases](https://github.com/OpenDriver2/REDRIVER2/releases) |
| **CTR-Native / CTR-ModSDK** | *Crash Team Racing* (PS1) | Win, Linux | ⚪ **Requer ISO NTSC-U limpa** | • Port nativo de PS1 para PC<br>• [GitHub](https://github.com/CTR-tools/ctr-native) |
| **WipEout Phantom Edition** | *WipEout (1995)* (PS1) | Win, Linux, macOS | ⚪ **Não requer (Corrida)** | • Port nativo com alta taxa de quadros e iluminação aprimorada<br>• [GitHub Releases](https://github.com/wipeout-phantom-edition/wipeout-phantom-edition/releases) |
| **Perfect Dark PC Port** | *Perfect Dark* (N64) | Win, Linux, macOS, Android | ⚪ **Sem PT-BR oficial no port** | • Mira no mouse (60+ FPS) e widescreen; requer `pd.ntsc-final.z64` em `data/`<br>• [GitHub Releases](https://github.com/fgsfdsfgs/perfect_dark/releases) |
| **GoldenEye 007 PC Port** | *GoldenEye 007* (N64) | Win, Linux, macOS | ⚪ **WIP (Decomp 100%)** | • Port nativo baseado na decomp `n64decomp/007`<br>• [GitHub](https://github.com/jkdansereau/goldeneye-pc-port) |
| **Golden Balloon** | *Diddy Kong Racing* (N64) | Win, Linux, macOS, Web | ⚪ **Sem PT-BR no port** | • Port nativo multiplataforma<br>• [GitHub](https://github.com/akratch/goldenballoon) |
| **Super Mario 64 DS PC (`tangOS`)** | *Super Mario 64 DS* (NDS) | Win, Linux | ⚪ **Sem PT-BR no port** | • Descompilação nativa de Nintendo DS<br>• [Site Oficial](https://tangos.dev/) · [GitHub Mirror](https://github.com/tangosdev/sm64ds-decomp) |
| **Zelda 3 (`snesrev/zelda3`)** | *Zelda: A Link to the Past* (SNES) | Win, Linux, macOS, Switch, Android | 🟡 **Script `dialogue.txt` PT-BR** | • Gere com a ROM USA limpa (`zelda3.sfc`) e use o `dialogue.txt` / `zelda3_assets.dat` traduzido pela comunidade BR nas Discussions<br>• [GitHub](https://github.com/snesrev/zelda3) · [Discussions](https://github.com/snesrev/zelda3/discussions) |
| **Super Metroid (`snesrev/sm`)** | *Super Metroid* (SNES) | Win, Linux, macOS | ⚪ **Não requer** | • Requer ROM limpa `sm.smc`<br>• [GitHub](https://github.com/snesrev/sm) |
| **Super Mario World (`snesrev/smw`)** | *Super Mario World* (SNES) | Win, Linux, macOS | ⚪ **Não requer** | • Requer ROM limpa `smw.sfc`<br>• [GitHub](https://github.com/snesrev/smw) |
| **Zelda: Link's Awakening DX HD** | *Zelda: Link's Awakening DX* (GBC) | Win, Linux (Proton), Android | 🔵 **Arquivos Abertos (`Data/Languages/`)** | • Tela inteira do mapa sem transição + Widescreen; textos editáveis em `Data/Languages/`<br>• [GitHub Releases](https://github.com/BigheadSMZ/Zelda-LA-DX-HD-Updated/releases) |
| **RSDK Decompilations (v5 / v4 / v3)** | *Sonic Mania Plus*, *Sonic 1 & 2 (2013)*, *Sonic CD (2011)* | Win, Linux, macOS, Android, Switch | 🟡 **Mod Completo PT-BR** | • **Sonic Mania Plus - PT-BR Translation Mod** e traduções para *Sonic 1 Forever / Sonic 2 Absolute* na pasta `mods/`<br>• [Sonic Mania](https://github.com/RSDKModding/Sonic-Mania-Decompilation/releases) · [Sonic 1/2](https://github.com/RSDKModding/RSDKv4-Decompilation/releases) · [Sonic CD](https://github.com/RSDKModding/RSDKv3-Decompilation/releases) · [Mods PT-BR](https://gamebanana.com/games/6059) |

---

## 4. 🖥️ Source Ports de Clássicos de PC

Engines modernas e abertas para rodar clássicos de PC em Windows 10/11, Linux, 4K, 144Hz+ e com suporte a PT-BR.

| Source Port | Jogo(s) | Sistemas | Status PT-BR | Detalhes da Tradução PT-BR & Links Oficiais |
| :--- | :--- | :--- | :--- | :--- |
| **DevilutionX** | *Diablo 1 + Hellfire* | Win, Linux, macOS, Android, Switch | 🟢 **100% Nativo** + 🟡 **Mod Dublagem** | • **Texto 100% nativo em Português (Brasil)** nas opções! Possui também mod de **Dublagem PT-BR** (`.mpq`) no Nexus Mods.<br>• [GitHub Releases](https://github.com/diasurgical/DevilutionX/releases) · [Dublagem PT-BR (Nexus)](https://www.nexusmods.com/diablo/mods) |
| **OpenRCT2** | *RollerCoaster Tycoon 2 (+ RCT1)* | Win, Linux, macOS, Android | 🟢 **100% Nativo no Port** | • Selecione **Português (BR)** nas opções do jogo.<br>• [Site Oficial](https://openrct2.io/) · [GitHub Releases](https://github.com/OpenRCT2/OpenRCT2/releases) |
| **OpenTTD** | *Transport Tycoon Deluxe* (Grátis!) | Win, Linux, macOS, Android | 🟢 **100% Nativo no Port** | • Standalone 100% gratuito e em **Português (Brasil)**.<br>• [Site Oficial](https://www.openttd.org/) · [GitHub Releases](https://github.com/OpenTTD/OpenTTD/releases) |
| **CorsixTH** | *Theme Hospital* | Win, Linux, macOS | 🟢 **100% Nativo no Port** | • Inclui `brazilian_portuguese.lua` nativamente.<br>• [GitHub Releases](https://github.com/CorsixTH/CorsixTH/releases) |
| **fheroes2** | *Heroes of Might and Magic II* | Win, Linux, macOS, Android, Switch | 🟢 **100% Nativo no Port** | • **Português (Brasil)** integrado nas opções (suporta até a versão Demo gratuita).<br>• [GitHub Releases](https://github.com/ihhub/fheroes2/releases) |
| **VCMI** | *Heroes of Might and Magic III* | Win, Linux, macOS, Android, iOS | 🟢 **Launcher PT-BR + Mod 1-Clique** | • Instale com 1 clique o pacote oficial **[Portuguese Translation](https://github.com/vcmi-mods/portuguese-translation)** direto na aba *Mods* do VCMI Launcher!<br>• [GitHub Releases](https://github.com/vcmi/vcmi/releases) · [vcmi.eu](https://vcmi.eu/) |
| **RVGL** | *Re-Volt* | Win, Linux, macOS, Android | 🟢 **100% Nativo no Port** | • Inclui `portuguese.txt` nativamente em *Options > Language*.<br>• [Site Oficial](https://rvgl.org/) |
| **Julius** & **Augustus** | *Caesar III* | Win, Linux, macOS, Android | 🔵 **Oficial Clássico Dublado (Brasoft)** | • Pacote oficial **Portuguese (Brazilian)** (Textos + Dublagem clássica da Brasoft) disponível na Wiki do Julius!<br>• [Julius](https://github.com/bvschaik/julius/releases) · [Augustus](https://github.com/Keriew/augustus/releases) · [Baixar Patch PT-BR](https://github.com/bvschaik/julius/wiki/Language-patches) |
| **ScummVM** | *Grim Fandango, Full Throttle, Monkey Island 1-3, The Dig, Day of the Tentacle* | Win, Linux, macOS, Android | 🟢 **UI Nativa + Dublagens Brasoft / ScummBR** | • Roda a lendária **Dublagem PT-BR da Brasoft** de *Grim Fandango* e todas as traduções do **Grupo ScummBR**.<br>• [ScummVM Oficial](https://www.scummvm.org/) · [ScummBR Traduções](http://www.scummbr.org/) |
| **OpenMW** | *The Elder Scrolls III: Morrowind* | Win, Linux, macOS, Android | 🟡 **Mod Texto + Placas + Dublagem PT-BR** | • **Morrowind Traduzido Completo em PT-BR com Placas** (e Dublagem opcional) no Nexus Mods.<br>• [GitHub Releases](https://github.com/OpenMW/openmw/releases) · [Nexus Mods Morrowind](https://www.nexusmods.com/morrowind) |
| **Daggerfall Unity** | *The Elder Scrolls II: Daggerfall* (Grátis!) | Win, Linux, macOS | 🟡 **Mod Completo PT-BR** | • **[Tradução de Daggerfall Unity (Mod #565)](https://www.nexusmods.com/daggerfallunity/mods/565)** no Nexus Mods.<br>• [GitHub Releases](https://github.com/Interkarma/daggerfall-unity/releases) |
| **GZDoom** / **UZDoom** / **Raze** | *Doom I & II, Heretic, Hexen, Duke Nukem 3D, Blood, Shadow Warrior* | Win, Linux, macOS | 🟢 **Menus e Mensagens Nativos em PT-BR** | • Localização oficial em Português Brasileiro (`pt`) integrada nos menus e avisos de sistema.<br>• [GZDoom](https://github.com/ZDoom/gzdoom/releases) · [UZDoom](https://github.com/UZDoom/UZDoom/releases) · [Raze](https://github.com/ZDoom/Raze/releases) |
| **Doom 64 EX+** / **Doom 64 RT** / **PrBoom-Plus RT** | *Doom 64* & *Doom I/II Ray Traced* | Win, Linux | 🟡 **Mod PT-BR (Doom 64)** | • [Doom 64 EX+](https://github.com/atsb/Doom64EX-Plus/releases) · [Doom 64 RT](https://github.com/sultim-t/doom64-rt/releases) · [PrBoom-Plus RT](https://github.com/sultim-t/prboom-plus-rt/releases) · [Mod PT-BR Doom 64](https://www.nexusmods.com/doom64) |
| **dhewm3** | *Doom 3 (+ Resurrection of Evil)* | Win, Linux, macOS | 🔵 **Tradução + Dublagem Completa PT-BR** | • Compatível com a **Dublagem + Tradução Completa em PT-BR** (WannaNow Productions) na pasta `base/`.<br>• [GitHub Releases](https://github.com/dhewm/dhewm3/releases) · [ModDB Doom 3](https://www.moddb.com/games/doom-iii/mods) |
| **Ironwail** / **vkQuake** / **Yamagi Quake II** / **Q2RTX** | *Quake 1* & *Quake II (Clássico e RTX)* | Win, Linux | 🔵 **Pacotes `.pak` PT-BR** | • [Ironwail](https://github.com/andrei-drexler/ironwail/releases) · [vkQuake](https://github.com/Novum/vkQuake/releases) · [Yamagi Q2](https://github.com/yquake2/yquake2/releases) · [Q2RTX](https://github.com/NVIDIA/Q2RTX/releases) |
| **fallout1-ce** & **fallout2-ce** | *Fallout 1* e *Fallout 2* | Win, Linux, macOS, Android | 🟡 **Tradução Completa PT-BR Aberta** | • [fallout1-ce](https://github.com/alexbatalov/fallout1-ce/releases) · [fallout2-ce](https://github.com/alexbatalov/fallout2-ce/releases) · [Tradução Fallout 1 (GitHub)](https://github.com/fpaganini/Fallout_ptbr) · [Tradução Fallout 2 (Nexus)](https://www.nexusmods.com/fallout2/mods) |
| **Xash3D FWGS** | *Half-Life 1, Opposing Force, Blue Shift* | Win, Linux, macOS, Android | 🟡 **Dublagem + Tradução Completa PT-BR** | • **[Dublagem PT-BR da Mesa Preta Dubs](https://www.moddb.com/mods/half-life-dublado-pt-br)** (vozes de cientistas, guardas, traje HEV e textos 100% em português!).<br>• [GitHub Releases](https://github.com/FWGS/xash3d-fwgs/releases) |
| **re3** & **reVC** | *GTA III* e *GTA Vice City* | Win, Linux, Switch, Vita | 🟡 **Tradução PT-BR Revisada (MixMods)** | • Traduções de texto e fontes acentuadas feitas especificamente para `re3`/`reVC` no **[MixMods](https://www.mixmods.com.br/)**.<br>• [Internet Archive Mirror](https://archive.org/details/gtamodding-re3) |
| **OpenRA** | *Command & Conquer, Red Alert, Dune 2000* (Grátis!) | Win, Linux, macOS | 🟡 **Interface Parcial PT-BR** | • Baixa automaticamente os pacotes gratuitos dos 3 clássicos de RTS.<br>• [Site Oficial](https://www.openra.net/) · [GitHub Releases](https://github.com/OpenRA/OpenRA/releases) |

---

## 5. 🕹️ Fangames, Remakes Nativos para PC e Ports de Arcade

| Projeto | O que é | Sistemas | Status PT-BR | Detalhes e Links Oficiais |
| :--- | :--- | :--- | :--- | :--- |
| **AM2R (Another Metroid 2 Remake)** | Remake definitivo de *Metroid II* (v1.5.5+ Widescreen & Randomizer) | Win, Linux, Android | 🟢 **100% Nativo em PT-BR!** | • Idioma **Português** incluso nativamente em *Options > Language* (menus + todos os *Metroid Logs*).<br>• [AM2RLauncher Releases](https://github.com/AM2R-Community-Developers/AM2RLauncher/releases) |
| **Sonic 3 A.I.R.** | Remaster nativo de *Sonic 3 & Knuckles* | Win, Linux, macOS, Android, Switch | 🟡 **Mod PT-BR na pasta `mods/`** | • Mods *Brasonic 3 A.I.R. / HUD em Português* no GameBanana.<br>• [GitHub Releases](https://github.com/Eukaryot/sonic3air/releases) · [Mods (GameBanana)](https://gamebanana.com/games/7342) |
| **Sonic Project '06 (P-06)** | Remake de *Sonic the Hedgehog (2006)* por *ChaosX* (Standalone Grátis) | Windows (e Linux via Wine/Proton) | 🟡 **Mod Legenda + Dublagem PT-BR** | • Mods de tradução e dublagem PT-BR via *P-06 Mod Loader*.<br>• [Hub Oficial e Mods (GameBanana)](https://gamebanana.com/games/8169) |
| **Sonic SMS Remake 1, 2 & 3** | Remakes Widescreen dos Sonics 8-bits (Standalone Grátis) | Windows, Android | 🟢 **Projeto Brasileiro!** | • Criado pelo desenvolvedor brasileiro **Creative Araya**!<br>• [itch.io Oficial](https://creativearaya.itch.io/) · [GameJolt](https://gamejolt.com/@CreativeAraya) |
| **Sonic Time Twisted** | Fangame clássico no estilo *Sonic CD* (Standalone Grátis) | Win, Linux, Android | 🟢 **100% Nativo em PT-BR!** | • Selecione **Português** nas opções do jogo.<br>• [GitHub Releases](https://github.com/overbound/SonicTimeTwisted/releases) · [GameJolt](https://gamejolt.com/games/sonictimetwisted/24775) |
| **Sonic Triple Trouble 16-Bit** | Remake de *Sonic Triple Trouble* no estilo Mega Drive (Grátis) | Windows (e Linux via Wine) | ⚪ **Não requer** | • [GameJolt Oficial](https://gamejolt.com/games/sonictripletrouble16bit/322794) |
| **Sonic and the Fallen Star** & **Sonic Galactic** | Fangames 2D inéditos de Sonic (Standalone Grátis) | Windows, Linux | ⚪ **Não requer** | • [Fallen Star](https://stardropsmh.github.io/sonic-and-the-fallen-star/) · [Sonic Galactic](https://sonicgalactic.github.io/) |
| **Super Mario Bros. Remastered** | Remake em Godot 4 de *SMB1, Lost Levels, Special* + Editor | Win, Linux | 🟢 **Localização PT-BR** | • [GitHub Releases](https://github.com/JHDev2006/Super-Mario-Bros.-Remastered-Public/releases) |
| **Super Mario World Remastered** | Remake em Godot 4 de *Super Mario World* + Editor | Win, Linux | 🟢 **Localização PT-BR** | • [GitHub Releases](https://github.com/JHDev2006/Super-Mario-World-Remastered-Public/releases) |
| **Mega Man X8 16-Bit Demake** | Demake de *Mega Man X8* no estilo SNES (Standalone Grátis) | Windows | 🟢 **Projeto Brasileiro!** | • Criado pelo dev brasileiro **Alysson da Paz**!<br>• [itch.io Oficial](https://alyssondapaz.itch.io/mega-man-x8-16-bit) |
| **Mega Man Maker** | Criador e plataforma online de fases de *Mega Man 1–11* (Grátis) | Windows | 🟢 **100% Nativo em PT-BR!** | • [Site Oficial](https://megamanmaker.com/) |
| **Mega Man X Regenesis** | Remake moderno de *Mega Man X* na Godot 4 (Grátis) | Win, Linux, Android | ⚪ **Menus em inglês** | • [itch.io Oficial](https://mmxregenesis.itch.io/mega-man-x-regenesis) |
| **Streets of Rage Remake v5.2** | O remake clássico definitivo da BomberGames (Grátis) | Win, Linux | 🟡 **Pacote de Tradução PT-BR** | • [Internet Archive](https://archive.org/details/sorrv-52-rev-550_202401) |
| **PokéMMO** | MMO que integra 5 gerações de Pokémon no PC/Mobile | Win, Linux, macOS, Android | 🟢 **Cliente Nativo PT-BR + ROMs PT-BR** | • [Site Oficial em PT-BR](https://pokemmo.com/pt/) |
| **CannonBall / CannonBall-DX** | Engine reescrita de *OutRun (Arcade)* em 60/120 FPS Widescreen | Win, Linux, macOS | ⚪ **Não requer (Arcade)** | • [CannonBall](https://github.com/djyt/cannonball/releases) · [CannonBall-DX](https://github.com/Endprodukt/cannonball-dx/releases) |
| **Wanszai Arcade Ports** | *Virtua Racing, Virtua Fighter, Sega Rally HD, Ridge Racer Collection* | Windows | ⚪ **Não requer (Arcade)** | • Widescreen, 60 FPS, 4K e Online!<br>• [Virtua Racing](https://github.com/wanszai/Virtua-Racing---XBOXONE-Windows/releases) · [Virtua Fighter](https://github.com/wanszai/Virtua-Fighter---XboxOne-Windows/releases) · [Sega Rally](https://github.com/wanszai/Sega-Rally-Championship-PC-Xbox360-Series-X-/releases) · [Ridge Racer](https://github.com/wanszai/Ridge-Racer-Collection/releases) |
| **ProjectR** | *San Francisco Rush: The Rock* & *SF Rush 2049* (Arcade Vulkan) | Win, Linux | ⚪ **Não requer (Arcade)** | • [Site Oficial](https://t3hd0gg.com/project-r/) |
| **Supermodel (Sega Model 3)** | *Daytona USA 2, Scud Race, Sega Rally 2, Star Wars Arcade, VF3* | Win, Linux, macOS | ⚪ **Não requer (Arcade)** | • [GitHub Releases](https://github.com/trzy/Supermodel/releases) · [supermodel3.com](https://www.supermodel3.com/) |

---

## 🤝 Como Contribuir

Encontrou um port novo, uma recompilação recém-lançada ou uma nova tradução/dublagem em PT-BR?
Abra uma *Issue* ou mande um *Pull Request* atualizando o [`README.md`](README.md) e o [`catalog.json`](catalog.json)!
