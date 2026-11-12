# PlayStation no PC: PS4, PS3, PS2, PS1 e PSP (Ports Nativos, PS2Recomp, PSXRecomp e Decomps)

> **Navegação:** [Catálogo Principal](../README.md) · [Catálogo Web](../index.html) · [Guia PT-BR](guia-traducoes-ptbr.md)

Este guia reúne **todos os projetos de Ports Nativos, Recompilações Estáticas (`PS2Recomp`, `PSXRecomp`, `RecompOne`, `Yakumo`) e Descompilações** das plataformas PlayStation para PC (Windows e Linux/Steam Deck), com foco especial nos novos ports de **God of War (1, 2 e 3)**, **Shadow of the Colossus (PS4 Remake & PS2)**, **Bloodborne**, **Jak & Daxter**, **Silent Hill**, **Resident Evil** e **Castlevania**, além do mapeamento completo de **Traduções e Dublagens em Português Brasileiro (PT-BR)**.

---

## Destaques Especiais: God of War & Shadow of the Colossus no PC

### 1. Franquia God of War (Ports Nativos & Recompilações)

| Jogo | Projeto / Repositório Oficial | Plataforma Base | Status Atual | Suporte a PT-BR (Legenda / Dublagem) |
| :--- | :--- | :--- | :--- | :--- |
| **God of War III Remastered** | [**gow3_pc** (`FelipePrado0/gow3_pc`)](https://github.com/FelipePrado0/gow3_pc) | PS4 (`CUSA01623` / `CUSA01715`) | `Jogável` **do início ao fim!** (Executa o código x86-64 nativamente na CPU do Windows + Vulkan via camada shadPS4, até 240 FPS, FSR e escala de resolução) | `Nativo PT-BR` **100% Nativo Oficial (Dublado e Legendado em PT-BR!)** — Basta usar o dump da versão brasileira/latina (`CUSA01623`). |
| **God of War (2005 - GOW 1)** | [**god-of-war-recomp** (`KIexster/god-of-war-recomp`)](https://github.com/KIexster/god-of-war-recomp) | PS2 (`SCUS-97399`) | `Em dev` **Alpha / Em desenvolvimento ativo** (Recompilação estática de MIPS R5900 + microprogramas VU1 para C++ nativo via `PS2Recomp`) | `Patch PT-BR` **Tradução PT-BR (OAleex v4.4) + Dublagem PT-BR (STR Brasil)** via ISO `SCUS-97399` |
| **God of War II (2007)** | [**gow2-recomp** (`andrebrumdev/gow2-recomp`)](https://github.com/andrebrumdev/gow2-recomp) | PS3 HD / PS2 (`SCUS-97481`) | `Em dev` **Experimental / Em desenvolvimento (WIP)** | `Patch PT-BR` **Tradução PT-BR (OAleex) + Dublagem PT-BR (STR Brasil)** via ISO `SCUS-97481` |
| **Monster Hunter Freedom Unite** | [**FreedomUniteRecomp** (`PateeerQ/FreedomUniteRecomp`)](https://github.com/PateeerQ/FreedomUniteRecomp) | `Jogável` **(`v0.4.7`)** — Cross-platform Multiplayer Windows/Android | `Patch PT-BR` **Tradução PT-BR Completa** na ISO de PSP |
| **God of War: Chains of Olympus & Ghost of Sparta** | [**Yakumo PSP Recompiler** (`TeamGDB/Yakumo`)](https://github.com/TeamGDB/Yakumo) | PSP | `Experimental` **Experimental / WIP** (Traduz executáveis MIPS Allegrex para C++) | `Patch PT-BR` **Tradução e Dublagem PT-BR** na ISO de PSP |
| **Shadow of the Colossus (Remake 2018)** | [**ShadowOfTheColossus-PC** (`AjncSystem`)](https://github.com/AjncSystem/ShadowOfTheColossus-PC) | PS4 (`CUSA08809`) | `Jogável` **(Beta Avançado)** — Roda nativamente no Windows com Vulkan 1.3 e FPS desbloqueado | `Nativo PT-BR` **100% Nativo Oficial (Legendas e Menus em PT-BR!)** — Já incluso no dump `CUSA08809`. |
| **Shadow of the Colossus (Clássico 2005)** | [**Celosia** (`HenryKun55/celosia`)](https://github.com/HenryKun55/celosia) | PS2 (`SCUS-97472`) | `Em dev` **Alpha Experimental** — Recompilação estática MIPS -> C++ com Vulkan | `Patch PT-BR` **Tradução e Dublagem PT-BR** na ISO PAL/NTSC |
| **Ico (2001)** | [**ico-pc** (`nathanialf/ico-pc`)](https://github.com/nathanialf/ico-pc) | PS2 (`SCUS-97113`) | `Jogável` **(Release v0.7.7)** — Port nativo C++ com widescreen e alta resolução | `Patch PT-BR` **Tradução PT-BR** na ISO de PS2 |

---

## Parte 1: PlayStation 4 (PS4) -> Ports Nativos para Windows

Como o PS4 utiliza arquitetura **x86-64** (a mesma dos PCs modernos), projetos recentes criaram camadas de execução direta que rodam o binário original do jogo diretamente na CPU do Windows com tradução gráfica Vulkan nativa (sem emulação de CPU):

| Jogo | Projeto / Repositório Oficial | Status Atual | Requisitos | Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- |
| **Bloodborne** | [**Bloodborne for Windows** (`Supermedo/bloodborne_pc`)](https://github.com/Supermedo/bloodborne_pc) | `Jogável` **(Release `windows-v1.8.2` disponível!)** — 60+ FPS, resoluções customizadas, Vulkan, suporte a mods | Dump legal de *Bloodborne GOTY* (PS4) | `Nativo PT-BR` **100% Nativo Oficial (Dublagem e Legendas em PT-BR!)** |
| **God of War III Remastered** | [**gow3_pc** (`FelipePrado0/gow3_pc`)](https://github.com/FelipePrado0/gow3_pc) | `Jogável` **do início ao fim!** — Até 240 FPS, FSR, escala de resolução, áudio 7.1 | Dump legal `CUSA01623` / `CUSA01715` | `Nativo PT-BR` **100% Nativo Oficial (Dublagem e Legendas em PT-BR!)** |
| **Shadow of the Colossus (Remake)** | [**ShadowOfTheColossus-PC** (`AjncSystem/ShadowOfTheColossus-PC`)](https://github.com/AjncSystem/ShadowOfTheColossus-PC) | `Jogável` **(Beta)** — Vulkan 1.3 nativo no Windows 10/11 | Dump legal `CUSA08809` v1.00 | `Nativo PT-BR` **100% Nativo Oficial (Legendas e Menus em PT-BR!)** |
| **Deception IV: The Nightmare Princess** | [**Deception-IV-Recomp** (`rcostanza`)](https://github.com/rcostanza/Deception-IV-NightmarePrincess-recomp) | `Jogável` **(`v0.1` Windows/Linux)** | Dump legal de PS4 | `Inglês / Arcade` Em inglês/japonês |
| **MediEvil (Remake 2019)** | [**medievil_2019_pc_port** (`bc160201983/medievil_2019_pc_port`)](https://github.com/bc160201983/medievil_2019_pc_port) | `Jogável` — Port para PC do remake de 2019 | Dump legal do jogo de PS4 | `Nativo PT-BR` **100% Nativo Oficial (Dublagem e Legendas em PT-BR!)** |

---

## Parte 2: PlayStation 2 (PS2) — Todos os Ports Nativos, Recomps (`PS2Recomp`) e Decomps

### Ferramenta Base: `PS2Recomp`
* [**ran-j/PS2Recomp**](https://github.com/ran-j/PS2Recomp): O recompilador estático criado por Ranieri (`ran-j`) que analisa executáveis ELF de PS2 (MIPS R5900 Emotion Engine + VU0/VU1) e os traduz para código C++ nativo de PC.

### Catálogo Completo de PS2 no PC

| Jogo (PS2) | Nome do Projeto & Link GitHub | Tipo | Status Atual | Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- |
| **Jak and Daxter: The Precursor Legacy** | [**OpenGOAL** (`open-goal/jak-project`)](https://github.com/open-goal/jak-project) | Decomp / Port Nativo | `Jogável` **100% Completo (Release)** — 60/120+ FPS, 4K, Ultrawide, Mods | `Nativo PT-BR` **PT-BR Nativo Oficial no Port!** (Basta selecionar Português Brasileiro nas opções) |
| **Jak II** | [**OpenGOAL** (`open-goal/jak-project`)](https://github.com/open-goal/jak-project) | Decomp / Port Nativo | `Jogável` **100% Completo (Release)** | `Nativo PT-BR` **PT-BR Nativo Oficial no Port!** |
| **Jak 3** | [**OpenGOAL** (`open-goal/jak-project`)](https://github.com/open-goal/jak-project) | Decomp / Port Nativo | `Jogável` **Beta Avançado / Jogável** | `Nativo PT-BR` **PT-BR Nativo Oficial no Port!** |
| **Silent Hill 2** | [**Silent Hill 2: Enhanced Edition**](https://github.com/elishacloud/Silent-Hill-2-Enhancements) | Overhaul Nativo PC | `Jogável` **100% Completo (Release)** — 60 FPS, 4K, áudio PS2, FMVs IA | `Nativo PT-BR` **PT-BR Integrado no Instalador!** (O Setup do Enhanced Edition baixa a tradução PT-BR automaticamente) |
| **Sly Cooper and the Thievius Raccoonus** | [**ProjectCane** (`theclub654/ProjectCane`)](https://github.com/theclub654/ProjectCane) | Port Nativo PC (`v0.4.1-beta`) | `Jogável` — D3D11/OpenGL, 60 FPS | `Patch PT-BR` **Tradução PT-BR** na ISO `SCUS-97198` |
| **Urban Reign** | [**urban-reign-recomp** (`thiagordsfx/urban-reign-recomp`)](https://github.com/thiagordsfx/urban-reign-recomp) | Recomp (`PS2Recomp`) | `Jogável` **(Release v1.3.0)** — 60 FPS, Widescreen, 8x resolução, até 8 jogadores! *(Feito por dev brasileiro!)* | `Patch PT-BR` **ISO PT-BR + Texturas HD** |
| **Burnout 3: Takedown** | [**burnout3-pc** (`danielgomesvieira2000/burnout3-pc`)](https://github.com/danielgomesvieira2000/burnout3-pc) | Port Nativo / Recomp | `Jogável` **/ Em dev ativo** — 60 FPS, Vulkan 1.3 / D3D11 *(Port PS2 por dev brasileiro!)* | `Patch PT-BR` **Tradução PT-BR** (*Valclark Junior*) |
| **Burnout Dominator** | [**BurnoutDominatorReversed** (`literalynn`)](https://github.com/literalynn/BurnoutDominatorReversed) | Recomp C++/Vulkan | `Em dev` | `Patch PT-BR` **Tradução PT-BR** na ISO de PS2 |
| **Def Jam: Vendetta** | [**def-jam-vendetta-recomp** (`jcsix694`)](https://github.com/jcsix694/def-jam-vendetta-recomp) | Recomp (`PS2Recomp`) | `Jogável` **(Release v0.4.0)** — Vulkan, 60+ FPS | `Inglês / Arcade` Em inglês *(veja também Def Jam: FFNY no guia de Xbox)* |
| **Killzone (2004)** | [**KillzoneRecomp** (`drakolordx7/KillzoneRecomp`)](https://github.com/drakolordx7/KillzoneRecomp) | Recomp (`PS2Recomp`) | `Jogável` **Builds de Teste Jogáveis** — Mira no Mouse/Teclado, 120+ FPS, 8x resolução | `Patch PT-BR` **Tradução PT-BR** na ISO |
| **Dark Cloud 1 & Dark Cloud 2** | [**DC2-PS2RECOMP** (`Red-tv141/DC2-PS2RECOMP`)](https://github.com/Red-tv141/DC2-PS2RECOMP) | Recomp (`v0.9.5`) | `Jogável` **(`DC2-PS2RECOMP` v0.9.5)** | `Patch PT-BR` **Tradução PT-BR** para Dark Cloud 1 na ISO |
| **Kingdom Hearts I & II** | [**OpenKH** (`OpenKH/OpenKh`)](https://github.com/OpenKH/OpenKh) | Engine / Mod Manager | `Jogável` **(KH2 Engine / PC Tools)** | `Nativo PT-BR` **Mod PT-BR Completo!** Instalável direto via *OpenKH Mod Manager* (*Equipe KH Brasil*) |
| **Ratchet & Clank (1 & 3)** | [**rac1-native-game** (`daino-selvatico`)](https://github.com/daino-selvatico/rac1-native-game) | Port Nativo (`v0.1.3`) | `Jogável` — Execução nativa no PC | `Patch PT-BR` Compatível com tradução de textos da ISO |
| **Devil May Cry (2001)** | [**dmc-recomp** (`Gui-Tora/dmc-recomp`)](https://github.com/Gui-Tora/dmc-recomp) | Recomp (`PS2Recomp`) | `Em dev` **Experimental / WIP** *(Feito por dev brasileiro!)* | `Nativo PT-BR` **Tradução PT-BR** disponível para PS2 e PC |
| **Dragon Quest VIII** | [**DQ8-Recompiled** (`Sinan-Karakaya/DQ8-Recompiled`)](https://github.com/Sinan-Karakaya/DQ8-Recompiled) | Recomp (`PS2Recomp`) | `Em dev` | `Patch PT-BR` **Tradução PT-BR** completa na ISO de PS2 |
| **Haunting Ground** | [**OpenHuey** (`ArnautDaniel/OpenHuey`)](https://github.com/ArnautDaniel/OpenHuey) | Reimplementação C++ | `Em dev` **Em desenvolvimento ativo** | `Patch PT-BR` **Tradução PT-BR** completa na ISO de PS2 |
| **Castlevania: Curse of Darkness** | [**Noble Archimedes** (`sergiomanzur/noble-archimedes`)](https://github.com/sergiomanzur/noble-archimedes) | Recomp (`PS2Recomp`) | `Em dev` **Em desenvolvimento ativo** | `Patch PT-BR` **Tradução PT-BR** disponível na ISO `SLUS-21168` |
| **Resident Evil Code: Veronica X** | [**recvx-decomp** (`AshfordFamily/recvx-decomp`)](https://github.com/AshfordFamily/recvx-decomp) | Decomp (**100% Concluída!**) | `Jogável` **Código 100% Descompilado** | `Patch PT-BR` **Tradução PT-BR** clássica na ISO `SLUS-20184` |
| **Resident Evil Outbreak (File #1 & #2)** | [**REOF2** (`caprado/REOF2`)](https://github.com/caprado/REOF2) | Port Nativo | `Em dev` **Alpha / Em desenvolvimento** | `Patch PT-BR` **Tradução PT-BR** completa na ISO |
| **Resident Evil: Dead Aim** | [**Bullseye** (`cakehonolulu/Bullseye`)](https://github.com/cakehonolulu/Bullseye) | Decomp PS2 | `Em dev` | `Patch PT-BR` **Tradução PT-BR** na ISO |
| **God Hand** | [**god-hand-decomp** (`LucasPicoli/god-hand-decomp`)](https://github.com/LucasPicoli/god-hand-decomp) | Decomp PS2 | `Em dev` *(Por dev brasileiro!)* | `Patch PT-BR` **Tradução PT-BR** completa na ISO |
| **Dragon Ball Z: Budokai Tenkaichi 3** | [**BT3-Decompiled** (`z3xox/BT3-Decompiled`)](https://github.com/z3xox/BT3-Decompiled) | Decomp PS2 (**99.92% Concluída!**) | `Jogável` **Código 99.92% Reconstruído** | `Nativo PT-BR` **Dublagem Clássica PT-BR (Álamo)** e tradução completa na comunidade! |
| **Downhill Domination** | [**Recomp_Domination** (`pedrohenrique505`)](https://github.com/pedrohenrique505/Recomp_Domination) | Recomp (`PS2Recomp`) | `Em dev` **Experimental / WIP** *(Por dev brasileiro!)* | `Patch PT-BR` **Tradução PT-BR** na ISO |
| **Ace Combat 5: The Unsung War** | [**Ace-Combat-5** (`sal063`)](https://github.com/sal063/Ace-Combat-5-Static-recompilation) | Recomp (`PS2Recomp`) | `Jogável` **(Release v2.1 disponível)** | `Inglês / Arcade` Em inglês |
| **Ridge Racer V** | [**Fukami** (`danisandoval/fukami`)](https://github.com/danisandoval/fukami) | Recomp (`PS2Recomp`) | `Jogável` **(Release v1.1.0 disponível)** | `Inglês / Arcade` Textos mínimos (Arcade) |
| **Road Trip Adventure (Choro Q HG2)** | [**RoadTripAdventure-recomp** (`silentsudin`)](https://github.com/silentsudin/RoadTripAdventure-recomp) | Recomp (`PS2Recomp`) | `Jogável` **(Release v0.2.3)** | `Inglês / Arcade` Em inglês |
| **Way of the Samurai 2** | [**decomp_wots2** (`acklavidian/decomp_wots2`)](https://github.com/acklavidian/decomp_wots2) | Decomp + Port PC | `Jogável` **do início ao fim!** | `Inglês / Arcade` Em inglês |
| **Metropolismania** | [**Metropolismania-PC** (`koaque/Metropolismania-PC`)](https://github.com/koaque/Metropolismania-PC) | Port Nativo PC | `Jogável` — 60 FPS, Widescreen | `Inglês / Arcade` Em inglês |
| **Hot Shots Tennis** | [**OpenTennis** (`FIZL0/opentennis`)](https://github.com/FIZL0/opentennis) | Decomp + Port PC | `Jogável` — 119.88 FPS, Rollback Netcode! | `Inglês / Arcade` Textos mínimos |
| **Gran Turismo 4** | [**gt4-decomp** (`gustavocanepa/gt4-decomp`)](https://github.com/gustavocanepa/gt4-decomp) | Decomp PS2 | `Em dev` | `Patch PT-BR` **Tradução PT-BR** na ISO de PS2 |
| **GTA: Vice City Stories** | [**gta-vcs-recomp** (`gothamor/gta-vcs-recomp`)](https://github.com/gothamor/gta-vcs-recomp) | Recomp (`PS2Recomp`) | `Jogável` **(`v0.2.4` Windows D3D11/Linux)** | `Patch PT-BR` **Tradução PT-BR** (*SlowSoldier21 / WanntedReneggade*) |
| **Shadow of Rome, Rogue Galaxy & Zone of the Enders** | [**shadow-of-rome-recompiled**](https://github.com/Korvonordico/shadow-of-rome-recompiled) / [**rogue-galaxy-recomp**](https://github.com/victor-takai/rogue-galaxy-recomp) / [**ZOE-Recompiled**](https://github.com/Yaz-Myst/ZOE-Recompiled) | Recomp (`PS2Recomp`) | `Jogável` **Jogáveis (Releases Windows)** — Até 8x, 60 FPS | `Inglês / Arcade` Em inglês/multi-idioma |
| **Ratchet & Clank: Tools of Destruction & inFAMOUS 2 (PS3)** | [**ratchet-tod-recomp**](https://github.com/Re-TeRo17/ratchet-tod-recomp) / [**infamous2-recomp**](https://github.com/bhuiyah/infamous2-recomp) | Recomp (`PS3Recomp`) | `Jogável` **Jogáveis (Windows x64)** — 4K, 60 FPS | `Nativo PT-BR` **inFAMOUS 2: Dublagem e Legendas Oficiais PT-BR!** |
| **GTA III, Vice City & San Andreas** | [**re3 / reVC** (`Cai1Hsu/re3`)](https://github.com/Cai1Hsu/re3) | Ports Nativos | `Jogável` **100% Jogáveis** | `Nativo PT-BR` **Traduções e Dublagens PT-BR** completas! |
| **The Simpsons: Hit & Run** | [**Donut Team Mod Launcher**](https://donutteam.com/downloads/4/) | Engine Rewrite | `Jogável` | `Nativo PT-BR` **Tradução e Dublagem PT-BR** completas! |
| **Tony Hawk's Underground / Wasteland** | [**THUG Pro**](https://thugpro.com) | Overhaul Nativo PC | `Jogável` **(Online, 60+ FPS, 4K)** | `Patch PT-BR` Compatível com traduções PT-BR de PC |

---

## Parte 3: PlayStation 1 (PS1 / PSX) — Ports Nativos, `PSXRecomp` e Decomps

### Ferramentas Base: `PSXRecomp` & `RecompOne`
* [**RetroPortingToolKit/psxrecomp**](https://github.com/RetroPortingToolKit/psxrecomp) e [**alexbeavs-ps1-ports/psxrecomp-ports**](https://github.com/alexbeavs-ps1-ports/psxrecomp-ports) (mais de **70 jogos de PS1** com kits de recompilação estática AOT `.bin/.cue` -> `.exe` nativo com widescreen, PGXP e 60+ FPS!).
* [**BlackLabelHQ/RecompOne**](https://github.com/BlackLabelHQ/RecompOne): Recompilador estático de PS1 para C#/.NET nativo.

### Catálogo Completo de PS1 no PC

| Jogo (PS1) | Nome do Projeto & Link GitHub | Status Atual | Suporte a PT-BR |
| :--- | :--- | :--- | :--- |
| **Castlevania: Symphony of the Night** | [**SymphonyRecomp** (`BlackLabelHQ/SymphonyRecomp`)](https://github.com/BlackLabelHQ/SymphonyRecomp) | `Jogável` **(`v0.5.1b`)** — 60 FPS, Widescreen | `Nativo PT-BR` **Tradução e Dublagem PT-BR!** Aceita as lendárias ISOs traduzidas/dubladas em PT-BR (`SLUS-00067`) |
| **Silent Hill (1999)** | [**silent-hill-decomp** (`SlickAmogus/silent-hill-decomp`)](https://github.com/SlickAmogus/silent-hill-decomp) | `Jogável` **no Windows/Linux!** — Widescreen, 60 FPS | `Patch PT-BR` **Tradução PT-BR** na ISO `SLUS-00707` |
| **The Legend of Dragoon** | [**Severed Chains** (`Legend-of-Dragoon-Modding/Severed-Chains`)](https://github.com/Legend-of-Dragoon-Modding/Severed-Chains) | `Jogável` **(Release 3+)** — 60 FPS, 4K, Widescreen | `Nativo PT-BR` **Tradução e Dublagem PT-BR Integradas!** (*Projeto Dragoon*) |
| **Driver 2** | [**REDRIVER2** (`OpenDriver2/REDRIVER2`)](https://github.com/OpenDriver2/REDRIVER2) | `Jogável` **(Release)** — 60 FPS, Widescreen | `Nativo PT-BR` **Dublagem e Legendas PT-BR Clássicas** na ISO |
| **Tomb Raider I, II e III** | [**TRX (TR1X / TR2X / TR3X)** (`LostArtefacts/TRX`)](https://github.com/LostArtefacts/TRX) | `Jogável` **100% Jogáveis (Release)** — 60+ FPS, 4K | `Nativo PT-BR` **Tradução e Dublagem PT-BR** disponíveis |
| **Resident Evil 1, 2 e 3: Nemesis** | [**Classic REbirth**](https://classicrebirth.com) | `Jogável` **100% Jogáveis** — 60 FPS, Suporte a mods | `Nativo PT-BR` **Tradução e Dublagem PT-BR completas!** |
| **Dino Crisis 1 & 2** | [**Classic REbirth**](https://classicrebirth.com) | `Jogável` **100% Jogáveis** | `Nativo PT-BR` **Tradução PT-BR completa** no instalador e na ISO |
| **Crash Team Racing (CTR)** | [**ctr-native** (`CTR-tools/ctr-native`)](https://github.com/CTR-tools/ctr-native) | `Jogável` — 60 FPS, Widescreen, Online | `Patch PT-BR` **Tradução e Dublagem PT-BR** na ISO |
| **Crash Bandicoot 2: Cortex Strikes Back** | [**Crash2Recomp** (`Zumbo06/Crash2Recomp`)](https://github.com/Zumbo06/Crash2Recomp) | `Jogável` **(Release v0.9.6)** | `Patch PT-BR` **Tradução e Dublagem PT-BR** na ISO |
| **Gran Turismo 2** | [**GT2Recomp** (`alexbeavs-ps1-ports`)](https://github.com/alexbeavs-ps1-ports/gran-turismo-2-recomp) | `Jogável` — 60 FPS, Widescreen nativo | `Inglês / Arcade` Corrida Simulação |
| **Disney's Hercules** | [**hercules-recompiled** (`obaidr1/hercules-recompiled`)](https://github.com/obaidr1/hercules-recompiled) | `Jogável` **(Release)** — `PSXRecomp` nativo | `Nativo PT-BR` **100% Dublado em PT-BR** com os dubladores originais do filme no CD brasileiro! |
| **Legacy of Kain: Soul Reaver** | [**legacy-of-kain-soul-reaver-recomp** (`alexbeavs-ps1-ports`)](https://github.com/alexbeavs-ps1-ports/legacy-of-kain-soul-reaver-recomp) | `Jogável` **(Windows/Linux)** | `Nativo PT-BR` **Dublagem Clássica Oficial PT-BR!** (CD clássico da Brasoft) |
| **Yu-Gi-Oh! Forbidden Memories** | [**YuGiOhForbiddenMemoriesRecomp** (`Unchiga`)](https://github.com/Unchiga/YuGiOhForbiddenMemoriesRecomp) | `Jogável` **(Release v0.6.2)** — Fast-forward até 8x, 60 FPS | `Patch PT-BR` **Compatível com ISOs e Mods PT-BR** |
| **Mega Man X4, X5 e X6** | [**MegaManX4Recomp** (`mstan/MegaManX4Recomp`)](https://github.com/mstan/MegaManX4Recomp) | `Jogável` **Jogáveis (X4 inclui Co-op!)** | `Patch PT-BR` **Tradução PT-BR e Fandubs** na ISO |
| **Tekken 3** | [**Tekken3Recomp** (`fabioap-cpu/Tekken3Recomp`)](https://github.com/fabioap-cpu/Tekken3Recomp) | `Jogável` **(Release v2.1 disponível)** | `Inglês / Arcade` Textos mínimos (Luta) |
| **Parasite Eve 1 & Parasite Eve II** | [**parasite-eve-recomp** (`alexbeavs-ps1-ports`)](https://github.com/alexbeavs-ps1-ports/parasite-eve-recomp) | `Jogável` **Jogáveis (`v0.4.0`)** | `Patch PT-BR` **Tradução PT-BR** completa nos 2 CDs de PS1 |
| **Xenogears** | [**xenogears-recomp** (`OpokXeno/xenogears-recomp`)](https://github.com/OpokXeno/xenogears-recomp) | `Jogável` **/ Em dev avançado** | `Patch PT-BR` **Tradução PT-BR** completa para os 2 CDs |
| **Syphon Filter 1 & 2** | [**SF-pc-port** (`Madxbio97/SF-pc-port`)](https://github.com/Madxbio97/SF-pc-port) | `Jogável` **Jogáveis (`v0.2.0`)** | `Patch PT-BR` **Tradução PT-BR** na ISO |
| **MediEvil 1 & 2** | [**MediEvilRecomp** (`BlackLabelHQ/MediEvilRecomp`)](https://github.com/BlackLabelHQ/MediEvilRecomp) | `Jogável` **Jogáveis (`v0.2b`)** | `Patch PT-BR` **Tradução PT-BR** na ISO |
| **Pepsiman** | [**RepsiMan** (`FermataRest/RepsiMan`)](https://github.com/FermataRest/RepsiMan) | `Jogável` **(Release)** | `Patch PT-BR` Possui mod PT-BR da comunidade |
| **Ape Escape** | [**ApeEscapeRecomp** (`mstan/ApeEscapeRecomp`)](https://github.com/mstan/ApeEscapeRecomp) | `Jogável` **(Release v0.5.2)** | `Patch PT-BR` Compatível com texturas traduzidas |
| **Tomba! 1 & Tomba! 2** | [**TombaRecomp** (`mstan/TombaRecomp`)](https://github.com/mstan/TombaRecomp) | `Jogável` **Jogáveis (Releases v0.20.0 / v0.2.1)** | `Patch PT-BR` **Tradução PT-BR** na ISO |
| **Mega Man X5, Mega Man X6 & Battle Arena Toshinden** | [**MegaManX5Recomp**](https://github.com/mstan/MegaManX5Recomp) / [**MegaManX6Recomp**](https://github.com/mstan/MegaManX6Recomp) / [**BattleArenaToshindenRecomp**](https://github.com/mstan/BattleArenaToshindenRecomp) | `Jogável` **Jogáveis (R.A.I.D.)** — Netplay Rollback no Toshinden! | `Patch PT-BR` **Mega Man X5 tem Tradução PT-BR 100%!** (*Brazilian Warriors*) |
| **Bloody Roar 2** | [**BloodyRoar2Recomp** (`novapowers0/BloodyRoar2Recomp`)](https://github.com/novapowers0/BloodyRoar2Recomp) | `Jogável` | `Inglês / Arcade` Luta Arcade |
| **Street Fighter Alpha 3 / EX Plus Alpha / Marvel vs. Capcom** | [**Street-Fighter-Alpha-3-Recomp** (`TechnicallyComputers`)](https://github.com/TechnicallyComputers/Street-Fighter-Alpha-3-Recomp)<br>[**Marvel-vs.-Capcom-Recomp** (`TechnicallyComputers`)](https://github.com/TechnicallyComputers/Marvel-vs.-Capcom-Clash-of-Super-Heroes-Recomp)<br>[**plusalpha-recomp** (`guimaraf/plusalpha-recomp`)](https://github.com/guimaraf/plusalpha-recomp) | `Jogável` **Jogáveis (Releases disponíveis)** | `Inglês / Arcade` Luta Arcade |
| **Metal Slug X / Twisted Metal 4 / Bomberman World & Party** | [**Metal-Slug-X-Recomp**](https://github.com/TechnicallyComputers/Metal-Slug-X-Recomp)<br>[**TwistedMetal4Recomp**](https://github.com/TechnicallyComputers/TwistedMetal4Recomp)<br>[**Bomberman-World-Recomp**](https://github.com/TechnicallyComputers/Bomberman-World-Recomp) | `Jogável` **Jogáveis (Releases disponíveis)** | `Inglês / Arcade` Ação Arcade |
| **Digimon World 2003** | [**dw2003recomp** (`gascarcella/dw2003recomp`)](https://github.com/gascarcella/dw2003recomp) | `Jogável` **(Release v0.4.0)** | `Patch PT-BR` Possui tradução PT-BR na ISO |
| **Spider-Man (2000)** | [**OpenSpideyPS1** (`GTTeancum/SpideyPS1recomp`)](https://github.com/GTTeancum/SpideyPS1recomp) | `Jogável` **(Release v1.1)** | `Patch PT-BR` Possui tradução PT-BR na ISO |
| **King's Field (US)** | [**verdite2** (`Voicedrew11/verdite2`)](https://github.com/Voicedrew11/verdite2) | `Jogável` **(Release v0.5.0)** | `Patch PT-BR` Possui tradução PT-BR na ISO |
| **Vandal Hearts** | [**VandalHearts-PcPort** (`NicholasDominici/VandalHearts-PcPort`)](https://github.com/NicholasDominici/VandalHearts-PcPort) | `Jogável` **(Release disponível)** | `Patch PT-BR` Possui tradução PT-BR na ISO |
| **Klonoa: Door to Phantomile** | [**Klonoa-Door-to-Phantomile** (`TechnicallyComputers`)](https://github.com/TechnicallyComputers/Klonoa-Door-to-Phantomile) | `Jogável` **(Release v0.1.4)** | `Patch PT-BR` Possui tradução PT-BR |
| **Alundra / Alone in the Dark / Ace Combat 3 / Diablo PS1 / Die Hard Trilogy** | [**alexbeavs-ps1-ports Hub** (`psxrecomp-ports`)](https://github.com/alexbeavs-ps1-ports/psxrecomp-ports) | `Jogável` **Jogáveis (Releases v0.3.6)** | `Patch PT-BR` Todos possuem tradução PT-BR (e dublagem em *Alone in the Dark* e *Diablo*) |
| **WipEout (1995)** | [**wipeout-rewrite** (`phoboslab/wipeout-rewrite`)](https://github.com/phoboslab/wipeout-rewrite) | `Jogável` **100% Completo (Release)** | `Inglês / Arcade` Corrida Arcade |
| **Metal Gear Solid (MGS 1)** | [**mgs_reversing** (`FoxdieTeam/mgs_reversing`)](https://github.com/FoxdieTeam/mgs_reversing) | `Em dev` **Quase 100% Descompilado** | `Nativo PT-BR` Possui tradução e dublagem PT-BR (PS1 e PC) |
| **Final Fantasy VII, VIII e IX** | [**FFNx** (`julianxhokaxhiu/FFNx`)](https://github.com/julianxhokaxhiu/FFNx) & [**Memoria** (`Albeoris/Memoria`)](https://github.com/Albeoris/Memoria) | `Jogável` **100% Completos (60/120 FPS, 4K, Widescreen)** | `Nativo PT-BR` **Traduções PT-BR completas** via *7th Heaven* e *Memoria Mod Manager* |

---

## Parte 4: PlayStation Portable (PSP) — Recompilações e Ports Nativos

| Jogo (PSP) | Nome do Projeto & Link GitHub | Status Atual | Suporte a PT-BR |
| :--- | :--- | :--- | :--- |
| **GTA: Liberty City Stories** | [**lcs-recomp** (`elmasas/lcs-recomp`)](https://github.com/elmasas/lcs-recomp) + **reLCS** | `Jogável` **(`v0.1.6` Recomp & `reLCS` completo)** — Widescreen, 60 FPS, Mouse/Teclado | `Nativo PT-BR` **Tradução PT-BR completa** disponível para PC e PSP |
| **GTA: Vice City Stories** | [**PSPRecomp-VCS** (`codepdbh/PSPRecomp-VCS-Android`)](https://github.com/codepdbh/PSPRecomp-VCS-Android) + **reVCS** | `Em dev` **Em desenvolvimento / Builds Comunitárias** | `Nativo PT-BR` **Tradução PT-BR completa** disponível |
| **Ace Combat X: Skies of Deception** | [**Ace-Combat-X-Recompilation** (`sal063`)](https://github.com/sal063/Ace-Combat-X-Recompilation) | `Jogável` **(Release v1.5 disponível)** | `Inglês / Arcade` Em inglês |
| **Fate/unlimited codes** | [**fuc-recomp** (`elprogramadorloco-arch/fuc-recomp`)](https://github.com/elprogramadorloco-arch/fuc-recomp) | `Jogável` **(Release v0.0.5)** | `Inglês / Arcade` Em inglês |
| **Monster Hunter Freedom Unite** | [**FreedomUniteRecomp** (`PateeerQ/FreedomUniteRecomp`)](https://github.com/PateeerQ/FreedomUniteRecomp) | `Jogável` **(`v0.4.7`)** — Cross-platform Multiplayer Windows/Android | `Patch PT-BR` **Tradução PT-BR Completa** na ISO de PSP |
| **God of War: Chains of Olympus & Ghost of Sparta** | [**psp-web-recomp** (`snuri00/psp-web-recomp`)](https://github.com/snuri00/psp-web-recomp) / [**Yakumo** (`TeamGDB/Yakumo`)](https://github.com/TeamGDB/Yakumo) | `Experimental` **Experimental / Em progresso** | `Patch PT-BR` **ISO PT-BR** — Ambos possuem tradução e dublagem PT-BR na ISO de PSP |
