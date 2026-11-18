# GameCube, Wii, Wii U & Switch no PC (Ports Nativos, `DolRecomp`, `Aurora` e Decomps)

> **Navegação:** [Catálogo Principal](../README.md) · [Catálogo Web](../index.html) · [Guia PT-BR](guia-traducoes-ptbr.md)

Este guia reúne **todos os projetos de Ports Nativos, Recompilações Estáticas (`DolRecomp`, `ModernGekko`, `NWiiRecomp`) e Descompilações** de **GameCube, Wii, Wii U e Nintendo Switch** para PC (Windows, Linux/Steam Deck e macOS), com status detalhado de **Tradução em Português Brasileiro (PT-BR)**.

---

## Ferramentas e Camadas Base
* [**Aurora** (`encounter/aurora`)](https://github.com/encounter/aurora): Camada de compatibilidade nativa que traduz chamadas gráficas GX e de sistema operacional do GameCube/Wii diretamente para **Vulkan, Direct3D 12, Metal e OpenGL**. É o coração de ports como *Dusklight (Zelda TP)*, *Metaforce (Metroid Prime)* e *melee-pc*.
* [**DolRecomp** (`ExpansionPak/DolRecomp`)](https://github.com/ExpansionPak/DolRecomp) & [**ModernGekko** (`ExpansionPak/ModernGekko`)](https://github.com/ExpansionPak/ModernGekko): Recompilador estático de binários PowerPC (`.dol`/`.rel`/`.rpx`) de GameCube, Wii e Wii U para C/LLVM nativo.

---

## Parte 1: Franquia The Legend of Zelda (GameCube, Wii U & Switch)

| Jogo | Nome do Projeto & Link GitHub | Plataforma Base | Status Atual | Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- |
| **The Legend of Zelda: Twilight Princess** | [**Dusklight (Dusk)** (`TwilitRealm/dusklight`)](https://github.com/TwilitRealm/dusklight) | GameCube (`GZ2E01`) | `Jogável` **100% Completo e Jogável (Release v2.0.3)** — 60+ FPS, Ultrawide 16:9/21:9, Texturas HD, Randomizer, Mods | `Nativo PT-BR` **Tradução PT-BR Completa Disponível!** Compatível com a tradução PT-BR de GameCube (Central de Traduções / Tribo Gamer) |
| **The Legend of Zelda: The Wind Waker HD** | [**ZeldaWWHDRecomp**](https://github.com/ZeldaWWHDRecomp/ZeldaWWHDRecomp) | Wii U | `Jogável` **(Release v0.4.7)** — Vulkan/Metal nativo, 60+ FPS, Ultrawide, Mod Manager | `Nativo PT-BR` **Tradução PT-BR 100% Completa!** Compatível diretamente com a tradução da equipe **Triforce Heroes Traduções** |
| **The Legend of Zelda: The Wind Waker (GC)** | [**BlueWake** (`chrissotraidis/bluewake`)](https://github.com/chrissotraidis/bluewake) | GameCube (`GZLE01`) | `Jogável` **(Release v0.7.0 pronta para Windows!)** | `Nativo PT-BR` **Tradução PT-BR Completa** disponível para a ISO de GameCube |
| **The Legend of Zelda: Link's Awakening (Remake)** | [**LASRecomp** (`peiikai/LASRecomp`)](https://github.com/peiikai/LASRecomp) | Nintendo Switch | `Jogável` **Beta Jogável (`beta_4`)** — Recompilação estática ARM64 -> x86-64 nativo no PC! | `Nativo PT-BR` **Tradução PT-BR Completa** disponível para os arquivos do Switch |
| **Hyrule Warriors: Definitive Edition** | [**HWDER** (`sonsegajp/HWDER`)](https://github.com/sonsegajp/HWDER) | Nintendo Switch | `Jogável` **(Release v0.1.1)** — Port nativo por recompilação estática | `Patch PT-BR` Possui tradução PT-BR da comunidade Switch |

---

## Parte 2: GameCube & Wii — Todos os Ports Nativos, Recomps e Decomps

| Jogo | Nome do Projeto & Link GitHub | Plataforma Base | Status Atual | Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- |
| **Super Mario Galaxy** | [**Nebula** (`keepvaibin/nebula`)](https://github.com/keepvaibin/nebula) | Wii | `Jogável` **(Release v1.0.0)** — Até 16x resolução, 60 FPS, Ultrawide 32:9, FSR 1, Mouse/Teclado ou Controle! | `Nativo PT-BR` **Tradução PT-BR 100% Completa!** Feita pelos grupos *Brazilian Warriors / Nintendo BR* (João13 Traduções) |
| **Super Mario Galaxy 2** | [**Garigari** (`SMGCommunity/Garigari`)](https://github.com/SMGCommunity/Garigari) | Wii | `Em dev` **Descompilação em andamento** | `Nativo PT-BR` **Tradução PT-BR Completa** disponível para a ISO de Wii |
| **Super Mario Sunshine** | [**sms-pc-port** (`chasem-dev/sms-pc-port`)](https://github.com/chasem-dev/sms-pc-port) | GameCube (`GMSE01`) | `Jogável` **(Release)** — Até 120 FPS, 8x resolução, Ultrawide, Câmera Livre, Co-op Online | `Nativo PT-BR` **Tradução PT-BR 100% Completa!** Disponível na Central de Traduções / RomsPortugues |
| **New Super Mario Bros. Wii** | [**NSMB-Wii-Multiplayer-Recompilation** (`WitherBlitz`)](https://github.com/WitherBlitz/NSMB-Wii-Multiplayer-Recompilation) | Wii | `Jogável` **(Release v0.1.1)** — Com suporte a Multiplayer Online! | `Nativo PT-BR` **Tradução e Dublagem PT-BR** disponíveis para a ISO de Wii |
| **Mario Kart Wii** | [**WiiCompiled** (`patchzyy/Wiicompiled`)](https://github.com/patchzyy/Wiicompiled) | Wii | `Jogável` — Recompilação estática nativa para PC e Mobile | `Nativo PT-BR` **Tradução PT-BR 100% Completa!** (*Guilherme Dias / Walter Leal*) |
| **Super Smash Bros. Melee** | [**melee-pc** (`999sian/melee-pc`)](https://github.com/999sian/melee-pc) | GameCube (`GALE01` v1.02) | `Jogável` — Vulkan/Metal/D3D12 via Aurora, SDL3 | `Inglês / Arcade` Luta Arcade / Netplay |
| **Metroid Prime 1, 2 e 3** | [**Metaforce** (`AxioDL/metaforce`)](https://github.com/AxioDL/metaforce) | GameCube / Wii | `Jogável` **(MP1)** — Vulkan/D3D12, Widescreen, DualStick/Mouse | `Nativo PT-BR` **Tradução PT-BR Completa (MP1)** feita por *MJay (BR Traduções)* |
| **Pikmin 1 & Pikmin 2** | [**Open Nectar** (`SSunnKing/Open-Nectar---Pikmin-Native-PC-Mobile-Port`)](https://github.com/SSunnKing/Open-Nectar---Pikmin-Native-PC-Mobile-Port) | GameCube | `Jogável` **(`Open Nectar`)** | `Nativo PT-BR` **Tradução PT-BR Disponível** para Pikmin 1 e 2 |
| **Skies of Arcadia Legends** | [**SkiesOfArcadiaLegends-Recomp** (`ogdanimal`)](https://github.com/ogdanimal/SkiesOfArcadiaLegends-Recomp) | GameCube | `Jogável` **100% Completo e Jogável!** — 16:9 Widescreen, 60 FPS, Fast-Forward 4x | `Inglês / Arcade` Em inglês |
| **SoulCalibur II (GC)** | [**RingOut** (`jackpoison-prog/RingOut`)](https://github.com/jackpoison-prog/RingOut) | GameCube | `Jogável` **(Release v1.6.9 — Inclui o Link de Zelda!)** | `Inglês / Arcade` Luta Arcade |
| **Eternal Darkness: Sanity's Requiem** | [**EternalDarknessRecomp** (`griches/EternalDarknessRecomp`)](https://github.com/griches/EternalDarknessRecomp) | GameCube | `Jogável` **/ Em dev ativo** — Windows, Linux e Steam Deck | `Inglês / Arcade` Em inglês |
| **Kirby's Return to Dream Land** | [**ModernGekko Kirby Wii Recomp** (`ExpansionPak/ModernGekko`)](https://github.com/ExpansionPak/ModernGekko/releases/tag/kirby) | Wii | `Jogável` **(Release disponível)** | `Nativo PT-BR` Possui tradução PT-BR para a ISO de Wii |
| **Animal Crossing (GameCube)** | [**ACGC-PC-Port** (`flyngmt/ACGC-PC-Port`)](https://github.com/flyngmt/ACGC-PC-Port) | GameCube | `Jogável` — Port nativo C++ | `Patch PT-BR` Projeto *Traducrossing* em andamento |
| **NBA Street V3 (Mario All-Stars)** | [**street-recomp-v3** (`recomp-code/street-recomp-v3`)](https://github.com/recomp-code/street-recomp-v3) | GameCube | `Jogável` **(Release v1.3.1)** | `Inglês / Arcade` Esporte Arcade |
| **Chibi-Robo! Plug Into Adventure!** | [**chibi-recompo** (`xXJSONDeruloXx/chibi-recompo`)](https://github.com/xXJSONDeruloXx/chibi-recompo) | GameCube | `Jogável` **/ Em dev ativo** | `Inglês / Arcade` Em inglês |
| **Wii Party & Muscle March** | [**wiiparty-recomp** (`arelkair/wiiparty-recomp`)](https://github.com/arelkair/wiiparty-recomp)<br>[**muscle-march-recomp** (`tmcleroy`)](https://github.com/tmcleroy/muscle-march-recomp) | Wii | `Jogável` **(`v0.1.13-alpha`)** | `Patch PT-BR` Wii Party possui tradução PT-BR na ISO |
| **Metroid Prime 3: Corruption** | [**Corruption_3-PC** (`bonllavier/Corruption_3-PC`)](https://github.com/bonllavier/Corruption_3-PC) | Wii | `Jogável` **sem emulador** — Mira em Mouse/Teclado + RetroAchievements | `Patch PT-BR` **Tradução PT-BR Completa** (*Esaan Alencar*) |
| **Resident Evil: The Umbrella Chronicles** | [**reuc-recomp** (`solleo95/reuc-recomp`)](https://github.com/solleo95/reuc-recomp) | Wii | `Jogável` — DLSS/FSR 3.1, Ray-Traced Shadows, HDR, Co-op Online | `Patch PT-BR` **Tradução PT-BR** (*Lobo Nintendista*) |
| **Monster Hunter 3 Ultimate** | [**Cha-Cha** (`BoyClinton/Cha-Cha`)](https://github.com/BoyClinton/Cha-Cha) | Wii U | `Jogável` **(`v0.2.1`)** — Windows, Linux e Android | `Inglês / Arcade` Em inglês |
| **Luigi's Mansion** | [**lm-decomp** (`theplayerrolo/lm-decomp`)](https://github.com/theplayerrolo/lm-decomp) | GameCube | `Em dev` **Descompilação avançada / Port em dev** | `Nativo PT-BR` **Tradução PT-BR 100% Completa!** (*JumpManClub Brasil*) |
| **Paper Mario: The Thousand-Year Door** | [**doldecomp/ttyd**](https://github.com/doldecomp/ttyd) | GameCube | `Em dev` **Descompilação avançada** | `Nativo PT-BR` **Tradução PT-BR Completa** (GC por *SBraz Gamer* e Switch) |
| **Mario Kart: Double Dash!!** | [**doldecomp/mkdd**](https://github.com/doldecomp/mkdd) | GameCube | `Em dev` **Descompilação em andamento** | `Nativo PT-BR` Possui tradução PT-BR na ISO |
| **Star Fox Adventures** | [**SFA-Decomp**](https://github.com/zcanann/SFA-Decomp) | GameCube | `Em dev` **Descompilação em andamento** | `Nativo PT-BR` Possui tradução PT-BR na ISO |

---

## Parte 3: Franquia Super Smash Bros. no PC (Ultimate, Melee, Brawl, Smash 4 e 64)

Todos os projetos de ports nativos, recompilações estáticas, descompilações e pacotes standalone para a franquia **Super Smash Bros.** no PC, com suporte a **Português Brasileiro (PT-BR)**:

| Jogo | Projeto & Links Oficiais | Plataforma Base | Tipo de Port / Tecnologia | Status Atual | Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **The Legend of Zelda: Ocarina of Time Remake** | [**Hookshot** (`NotRexed/Hookshot`)](https://github.com/NotRexed/Hookshot) | Nintendo Switch 2 | Recompilação Estática Nativa x64 / Vulkan | `Nativo PT-BR` **100% Jogável no PC** — Port nativo real com widescreen, mods e instalador PT-BR | `Nativo PT-BR` **100% Oficial Nativo + Instalador em PT-BR!** |
| **Mario Kart World** | [**MKW-Recomp** (`adriadam10/mkw-recomp`)](https://github.com/adriadam10/mkw-recomp) | Nintendo Switch 2 | Recompilação Estática Nativa x64 / Vulkan | `Nativo PT-BR` **Jogável no PC** — Port nativo sem emulador | `Nativo PT-BR` **100% Oficial Nativo (Menus e Dublagem em PT-BR!)** |
| **Donkey Kong Bananza** | [**DKB-PC-Recomp** (`Lucas-blip-png/dkb-pc-recomp`)](https://github.com/Lucas-blip-png/dkb-pc-recomp) | Nintendo Switch 2 | Recompilação Estática Nativa x64 / Vulkan | `Nativo PT-BR` **Jogável no PC** — Port nativo Windows/Linux/macOS | `Nativo PT-BR` **100% Oficial Nativo em PT-BR!** |
| **Pokémon Pokopia** | [**Recompia** (`Dittobyte/Recompia`)](https://github.com/Dittobyte/Recompia) | Nintendo Switch 2 | Recompilação Estática Nativa x64 / Vulkan | `Nativo PT-BR` **Jogável no PC** — Multiplayer e suporte a mods | `Nativo PT-BR` **100% Oficial Nativo em PT-BR!** |
| **Pokémon Sword & Shield** | [**SwSh Recomp** (`raulzrrs/swsh-recomp`)](https://github.com/raulzrrs/swsh-recomp) | Nintendo Switch (v1.3.2) | Recompilação Estática AArch64 -> x64 nativo no Windows (Vulkan 1.3 / SDL3 / FSR 1 / DLAA) | `Jogável` **Ativo / Jogável** — 60 FPS estáveis, precache de shaders, suporte a mouse e controles | `Mod PT-BR` **Mod PT-BR Completo (LayeredFS)** via pasta `mods/Traducao PT-BR/romfs` |
| **Star Fox (Switch 2)** | [**SpaceAnimalsRecomp** (`SerenityG4K/SpaceAnimalsRecomp`)](https://github.com/SerenityG4K/SpaceAnimalsRecomp) | Nintendo Switch 2 | Recompilação Estática Nativa Windows | `Nativo PT-BR` **Jogável no PC** — Compilação nativa local | `Nativo PT-BR` **100% Oficial Nativo em PT-BR!** |
| **Fire Emblem: Fortune's Weave & Hyrule Warriors: Age of Imprisonment** | [**fefw-recomp** (`Goldoire`)](https://github.com/Goldoire/fefw-recomp) / [**hwaoi-recomp** (`Alano6678`)](https://github.com/Alano6678/hwaoi-recomp) | Nintendo Switch 2 | Recompilações Estáticas Nativas x64 | `Jogável` **Jogáveis / Experimentais no Windows** | `Inglês / Arcade` Sem PT-BR oficial |
| **Xenoblade Chronicles X, 2 & 3** | [**xcx-recomp**](https://github.com/jmars125/xcx-recomp) / [**xc2-recomp**](https://github.com/AksharDP/xc2-recomp) / [**xc3-recomp**](https://github.com/jmars125/xc3-recomp) | Nintendo Switch | Recompilações Estáticas Nativas Vulkan | `Jogável` **Jogáveis no Windows e Linux** | `Mod PT-BR` **Mods PT-BR (LayeredFS)** disponíveis para X, 2 e 3! |
| **Mario Kart 8 Deluxe & Tomodachi Life: Living the Dream** | [**Racing-8-DX-Recomp**](https://github.com/galarianpikachu2021-hue/Racing-8-DX-Recomp) / [**TomodachiLife-recomp**](https://github.com/josiahg2502-glitch/TomodachiLife-recomp) | Nintendo Switch | Recompilações Estáticas Nativas x64 | `Jogável` **Jogáveis (MK8DX com FSR 3.1/HDR10)** | `Nativo PT-BR` **MK8DX 100% PT-BR Oficial** |
| **Super Smash Bros. Ultimate** | [**ssbu-recomp** (`Denkishi/ssbu-recomp`)](https://github.com/Denkishi/ssbu-recomp)<br>[**WindowSmash** (`SNO2207/WindowSmash`)](https://github.com/SNO2207/WindowSmash)<br>[**ssbu-decomp** (`sbergeron42/ssbu-decomp`)](https://github.com/sbergeron42/ssbu-decomp) | Nintendo Switch (v13.0.4) | Recompilação Estática AArch64 -> x64 nativo no Windows (Vulkan / D3D11 / SDL) & Decomp C++ | `Jogável` **Ativo / Jogável** — Execução nativa x64 direta, sem overhead de interpretador/JIT de emulador, suporte a scripts de lutadores editáveis em C++ | `Nativo PT-BR` **Mod PT-BR Completo (Textos + Dublagem do Narrador!)**:<br>• Mod [*SSBU Traduzido pra PT-BR*](https://gamebanana.com/mods/402324) (Menus, Espíritos, Regras)<br>• Mod [*Brazilian Dub (Dublagem PT-BR)*](https://gamebanana.com/sounds/58580) (Narrador e anúncios de vitória!) |
| **Super Smash Bros. Ultimate (HDR)** | [**HewDraw Remix (HDR)** (`HDR-Development/HewDraw-Remix`)](https://github.com/HDR-Development/HewDraw-Remix)<br>[**HDR Releases**](https://github.com/HDR-Development/HDR-Releases) | Nintendo Switch (PC Standalone) | Overhaul Competitivo Standalone para PC com Rollback Netcode | `Jogável` — Wavedash, L-cancel, novos movimentos, rollback netcode online no PC | `Nativo PT-BR` Compatível com pacotes de tradução PT-BR via Arcropolis |
| **Super Smash Bros. Melee** | [**melee-pc** (`999sian/melee-pc`)](https://github.com/999sian/melee-pc)<br>[**Melee Unlocked** (`Hero88go/melee-unlocked`)](https://github.com/Hero88go/melee-unlocked)<br>[**Project Slippi** (`project-slippi/slippi-launcher`)](https://slippi.gg/)<br>[**doldecomp/melee**](https://github.com/doldecomp/melee) | GameCube (`GALE01` v1.02) | Port Nativo via `Aurora` (Vulkan/Metal/D3D12/SDL3) e Standalone Rollback Netcode | `Jogável` **e Competitivo** — Matchmaking global instantâneo, 60 FPS cravados, input lag menor que o console original | `Patch PT-BR` Menus e troféus em português via patches na ISO |
| **Super Smash Bros. Brawl / Project+** | [**Project+ (P+)** (`projectplusgame.com`)](https://projectplusgame.com/)<br>[**Project-Plus Repo**](https://github.com/projectplus/Project-Plus) | Wii (`RSBE01`) | Standalone PC Launcher com Rollback Netcode integrado | `Jogável` — Equilíbrio competitivo profissional, física aprimorada, online rollback | `Patch PT-BR` Jogo arcade de luta focado em gameplay |
| **Super Smash Bros. for Wii U (Smash 4)** | [**Smash 4 PC Standalone Setup**](https://github.com/cemu-project/Cemu) | Wii U | Standalone x64 com Async Shaders, 4K/Ultrawide e Mods | `Jogável` — 60 FPS 4K, suporte completo a controles de GameCube | `Nativo PT-BR` Menus e nomes de lutadores traduzidos |
| **Super Smash Bros. 64** | [**BattleShip** (`JRickey/BattleShip`)](https://github.com/JRickey/BattleShip)<br>[**smash64r** (`zestydevy/smash64r`)](https://github.com/zestydevy/smash64r)<br>[**ssb-decomp-re**](https://github.com/VetriTheRetri/ssb-decomp-re) | Nintendo 64 | Port Nativo via `libultraship` (`BattleShip`) e Recompilação Estática `N64Recomp` + `RT64` | `Jogável` — Widescreen 16:9/21:9, 60+ FPS, Ray Tracing opcional, input nativo | `Nativo PT-BR` Compatível com a tradução PT-BR da ROM de N64 |

---

### Como Rodar Super Smash Bros. Ultimate com Tradução e Dublagem PT-BR no PC

1. **Dump dos Arquivos Originais:**
   * Obtenha o dump legal do jogo base atualizado para a versão **13.0.4** (`01006A800016E000`).
2. **Execução no PC:**
   * **Via `ssbu-recomp` / `WindowSmash`:** Coloque os binários descompactados e os assets na pasta do executável do `ssbu-recomp`.
   * **Via Standalone HDR / Arcropolis:** Se estiver usando o launcher competitivo do **HewDraw Remix (HDR)**, o jogo roda direto com rollback netcode.
3. **Instalação do Mod PT-BR (Textos + Dublagem do Narrador):**
   * Baixe o mod de tradução [**SSBU Traduzido pra PT-BR** no GameBanana](https://gamebanana.com/mods/402324).
   * Baixe o mod de dublagem [**Brazilian Dub (Dublagem PT-BR)** no GameBanana](https://gamebanana.com/sounds/58580).
   * Extraia os arquivos para a pasta `ultimate/mods/` (ou `atmosphere/contents/01006A800016E000/romfs/`).
   * Ao abrir o jogo, todos os menus, nomes de espíritos, regras e **a voz do Narrador ao anunciar os personagens e a vitória** estarão 100% em **Português do Brasil**!
