# 🟣 GameCube, Wii, Wii U & Switch no PC (Ports Nativos, `DolRecomp`, `Aurora` e Decomps)

Este guia reúne **todos os projetos de Ports Nativos, Recompilações Estáticas (`DolRecomp`, `ModernGekko`, `NWiiRecomp`) e Descompilações** de **GameCube, Wii, Wii U e Nintendo Switch** para PC (Windows, Linux/Steam Deck e macOS), com status detalhado de **Tradução em Português Brasileiro (PT-BR)**.

---

## 🛠️ Ferramentas e Camadas Base
* [**Aurora** (`encounter/aurora`)](https://github.com/encounter/aurora): Camada de compatibilidade nativa que traduz chamadas gráficas GX e de sistema operacional do GameCube/Wii diretamente para **Vulkan, Direct3D 12, Metal e OpenGL**. É o coração de ports como *Dusklight (Zelda TP)*, *Metaforce (Metroid Prime)* e *melee-pc*.
* [**DolRecomp** (`ExpansionPak/DolRecomp`)](https://github.com/ExpansionPak/DolRecomp) & [**ModernGekko** (`ExpansionPak/ModernGekko`)](https://github.com/ExpansionPak/ModernGekko): Recompilador estático de binários PowerPC (`.dol`/`.rel`/`.rpx`) de GameCube, Wii e Wii U para C/LLVM nativo.

---

## 🗡️ Parte 1: Franquia The Legend of Zelda (GameCube, Wii U & Switch)

| Jogo | Nome do Projeto & Link GitHub | Plataforma Base | Status Atual | 🇧🇷 Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- |
| **The Legend of Zelda: Twilight Princess** | [**Dusklight (Dusk)** (`TwilitRealm/dusklight`)](https://github.com/TwilitRealm/dusklight) | GameCube (`GZ2E01`) | ✅ **100% Completo e Jogável (Release v2.0.3)** — 60+ FPS, Ultrawide 16:9/21:9, Texturas HD, Randomizer, Mods | 🟢 **Tradução PT-BR Completa Disponível!** Compatível com a tradução PT-BR de GameCube (Central de Traduções / Tribo Gamer) |
| **The Legend of Zelda: The Wind Waker HD** | [**ZeldaWWHDRecomp**](https://github.com/ZeldaWWHDRecomp/ZeldaWWHDRecomp) | Wii U | ✅ **Jogável (Release v0.4.7)** — Vulkan/Metal nativo, 60+ FPS, Ultrawide, Mod Manager | 🟢 **Tradução PT-BR 100% Completa!** Compatível diretamente com a tradução da equipe **Triforce Heroes Traduções** |
| **The Legend of Zelda: The Wind Waker (GC)** | [**BlueWake** (`chrissotraidis/bluewake`)](https://github.com/chrissotraidis/bluewake) | GameCube (`GZLE01`) | ✅ **Jogável (Release v0.7.0 pronta para Windows!)** | 🟢 **Tradução PT-BR Completa** disponível para a ISO de GameCube |
| **The Legend of Zelda: Link's Awakening (Remake)** | [**LASRecomp** (`peiikai/LASRecomp`)](https://github.com/peiikai/LASRecomp) | Nintendo Switch | ✅ **Beta Jogável (`beta_4`)** — Recompilação estática ARM64 -> x86-64 nativo no PC! | 🟢 **Tradução PT-BR Completa** disponível para os arquivos do Switch |
| **Hyrule Warriors: Definitive Edition** | [**HWDER** (`sonsegajp/HWDER`)](https://github.com/sonsegajp/HWDER) | Nintendo Switch | ✅ **Jogável (Release v0.1.1)** — Port nativo por recompilação estática | 🟡 Possui tradução PT-BR da comunidade Switch |

---

## 🍄 Parte 2: GameCube & Wii — Todos os Ports Nativos, Recomps e Decomps

| Jogo | Nome do Projeto & Link GitHub | Plataforma Base | Status Atual | 🇧🇷 Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- |
| **Super Mario Galaxy** | [**Nebula** (`keepvaibin/nebula`)](https://github.com/keepvaibin/nebula) | Wii | ✅ **100% Jogável (Release v1.0.0)** — Até 16x resolução, 60 FPS, Ultrawide 32:9, FSR 1, Mouse/Teclado ou Controle! | 🟢 **Tradução PT-BR 100% Completa!** Feita pelos grupos *Brazilian Warriors / Nintendo BR* (João13 Traduções) |
| **Super Mario Galaxy 2** | [**Garigari** (`SMGCommunity/Garigari`)](https://github.com/SMGCommunity/Garigari) | Wii | 🚧 **Descompilação em andamento** | 🟢 **Tradução PT-BR Completa** disponível para a ISO de Wii |
| **Super Mario Sunshine** | [**sms-pc-port** (`chasem-dev/sms-pc-port`)](https://github.com/chasem-dev/sms-pc-port) | GameCube (`GMSE01`) | ✅ **100% Jogável (Release)** — Até 120 FPS, 8x resolução, Ultrawide, Câmera Livre, Co-op Online | 🟢 **Tradução PT-BR 100% Completa!** Disponível na Central de Traduções / RomsPortugues |
| **New Super Mario Bros. Wii** | [**NSMB-Wii-Multiplayer-Recompilation** (`WitherBlitz`)](https://github.com/WitherBlitz/NSMB-Wii-Multiplayer-Recompilation) | Wii | ✅ **Jogável (Release v0.1.1)** — Com suporte a Multiplayer Online! | 🟢 **Tradução e Dublagem PT-BR** disponíveis para a ISO de Wii |
| **Mario Kart Wii** | [**WiiCompiled** (`patchzyy/Wiicompiled`)](https://github.com/patchzyy/Wiicompiled) | Wii | ✅ **Jogável** — Recompilação estática nativa para PC e Mobile | 🟢 **Tradução PT-BR 100% Completa!** (*Guilherme Dias / Walter Leal*) |
| **Super Smash Bros. Melee** | [**melee-pc** (`999sian/melee-pc`)](https://github.com/999sian/melee-pc) | GameCube (`GALE01` v1.02) | ✅ **100% Jogável** — Vulkan/Metal/D3D12 via Aurora, SDL3 | ⚪ Luta Arcade / Netplay |
| **Metroid Prime 1, 2 e 3** | [**Metaforce** (`AxioDL/metaforce`)](https://github.com/AxioDL/metaforce) | GameCube / Wii | ✅ **Jogável (MP1)** — Vulkan/D3D12, Widescreen, DualStick/Mouse | 🟢 **Tradução PT-BR Completa (MP1)** feita por *MJay (BR Traduções)* |
| **Pikmin 1 & Pikmin 2** | [**Open Nectar** (`SSunnKing/Open-Nectar---Pikmin-Native-PC-Mobile-Port`)](https://github.com/SSunnKing/Open-Nectar---Pikmin-Native-PC-Mobile-Port) | GameCube | ✅ **Jogável (`Open Nectar`)** | 🟢 **Tradução PT-BR Disponível** para Pikmin 1 e 2 |
| **Skies of Arcadia Legends** | [**SkiesOfArcadiaLegends-Recomp** (`ogdanimal`)](https://github.com/ogdanimal/SkiesOfArcadiaLegends-Recomp) | GameCube | ✅ **100% Completo e Jogável!** — 16:9 Widescreen, 60 FPS, Fast-Forward 4x | ⚪ Em inglês |
| **SoulCalibur II (GC)** | [**RingOut** (`jackpoison-prog/RingOut`)](https://github.com/jackpoison-prog/RingOut) | GameCube | ✅ **Jogável (Release v1.6.9 — Inclui o Link de Zelda!)** | ⚪ Luta Arcade |
| **Eternal Darkness: Sanity's Requiem** | [**EternalDarknessRecomp** (`griches/EternalDarknessRecomp`)](https://github.com/griches/EternalDarknessRecomp) | GameCube | ✅ **Jogável / Em dev ativo** — Windows, Linux e Steam Deck | ⚪ Em inglês |
| **Kirby's Return to Dream Land** | [**ModernGekko Kirby Wii Recomp** (`ExpansionPak/ModernGekko`)](https://github.com/ExpansionPak/ModernGekko/releases/tag/kirby) | Wii | ✅ **Jogável (Release disponível)** | 🟢 Possui tradução PT-BR para a ISO de Wii |
| **Animal Crossing (GameCube)** | [**ACGC-PC-Port** (`flyngmt/ACGC-PC-Port`)](https://github.com/flyngmt/ACGC-PC-Port) | GameCube | ✅ **Jogável** — Port nativo C++ | 🟡 Projeto *Traducrossing* em andamento |
| **NBA Street V3 (Mario All-Stars)** | [**street-recomp-v3** (`recomp-code/street-recomp-v3`)](https://github.com/recomp-code/street-recomp-v3) | GameCube | ✅ **Jogável (Release v1.3.1)** | ⚪ Esporte Arcade |
| **Chibi-Robo! Plug Into Adventure!** | [**chibi-recompo** (`xXJSONDeruloXx/chibi-recompo`)](https://github.com/xXJSONDeruloXx/chibi-recompo) | GameCube | ✅ **Jogável / Em dev ativo** | ⚪ Em inglês |
| **Wii Party & Muscle March** | [**wiiparty-recomp** (`arelkair/wiiparty-recomp`)](https://github.com/arelkair/wiiparty-recomp)<br>[**muscle-march-recomp** (`tmcleroy`)](https://github.com/tmcleroy/muscle-march-recomp) | Wii | ✅ **Jogável (`v0.1.13-alpha`)** | 🟡 Wii Party possui tradução PT-BR na ISO |
| **Luigi's Mansion** | [**lm-decomp** (`theplayerrolo/lm-decomp`)](https://github.com/theplayerrolo/lm-decomp) | GameCube | 🚧 **Descompilação avançada / Port em dev** | 🟢 **Tradução PT-BR 100% Completa!** (*JumpManClub Brasil*) |
| **Paper Mario: The Thousand-Year Door** | [**doldecomp/ttyd**](https://github.com/doldecomp/ttyd) | GameCube | 🚧 **Descompilação avançada** | 🟢 **Tradução PT-BR Completa** (GC por *SBraz Gamer* e Switch) |
| **Mario Kart: Double Dash!!** | [**doldecomp/mkdd**](https://github.com/doldecomp/mkdd) | GameCube | 🚧 **Descompilação em andamento** | 🟢 Possui tradução PT-BR na ISO |
| **Star Fox Adventures** | [**SFA-Decomp**](https://github.com/zcanann/SFA-Decomp) | GameCube | 🚧 **Descompilação em andamento** | 🟢 Possui tradução PT-BR na ISO |

---

## 🥊 Parte 3: Franquia Super Smash Bros. no PC (Ultimate, Melee, Brawl, Smash 4 e 64)

Todos os projetos de ports nativos, recompilações estáticas, descompilações e pacotes standalone para a franquia **Super Smash Bros.** no PC, com suporte a **Português Brasileiro (PT-BR)**:

| Jogo | Projeto & Links Oficiais | Plataforma Base | Tipo de Port / Tecnologia | Status Atual | 🇧🇷 Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **Super Smash Bros. Ultimate** | [**ssbu-recomp** (`Denkishi/ssbu-recomp`)](https://github.com/Denkishi/ssbu-recomp)<br>[**WindowSmash** (`SNO2207/WindowSmash`)](https://github.com/SNO2207/WindowSmash)<br>[**ssbu-decomp** (`sbergeron42/ssbu-decomp`)](https://github.com/sbergeron42/ssbu-decomp) | Nintendo Switch (v13.0.4) | Recompilação Estática AArch64 -> x64 nativo no Windows (Vulkan / D3D11 / SDL) & Decomp C++ | ✅ **Ativo / Jogável** — Execução nativa x64 direta, sem overhead de interpretador/JIT de emulador, suporte a scripts de lutadores editáveis em C++ | 🟢 **Mod PT-BR Completo (Textos + Dublagem do Narrador!)**:<br>• Mod [*SSBU Traduzido pra PT-BR*](https://gamebanana.com/mods/402324) (Menus, Espíritos, Regras)<br>• Mod [*Brazilian Dub (Dublagem PT-BR)*](https://gamebanana.com/sounds/58580) (Narrador e anúncios de vitória!) |
| **Super Smash Bros. Ultimate (HDR)** | [**HewDraw Remix (HDR)** (`HDR-Development/HewDraw-Remix`)](https://github.com/HDR-Development/HewDraw-Remix)<br>[**HDR Releases**](https://github.com/HDR-Development/HDR-Releases) | Nintendo Switch (PC Standalone) | Overhaul Competitivo Standalone para PC com Rollback Netcode | ✅ **100% Jogável** — Wavedash, L-cancel, novos movimentos, rollback netcode online no PC | 🟢 Compatível com pacotes de tradução PT-BR via Arcropolis |
| **Super Smash Bros. Melee** | [**melee-pc** (`999sian/melee-pc`)](https://github.com/999sian/melee-pc)<br>[**Melee Unlocked** (`Hero88go/melee-unlocked`)](https://github.com/Hero88go/melee-unlocked)<br>[**Project Slippi** (`project-slippi/slippi-launcher`)](https://slippi.gg/)<br>[**doldecomp/melee**](https://github.com/doldecomp/melee) | GameCube (`GALE01` v1.02) | Port Nativo via `Aurora` (Vulkan/Metal/D3D12/SDL3) e Standalone Rollback Netcode | ✅ **100% Jogável e Competitivo** — Matchmaking global instantâneo, 60 FPS cravados, input lag menor que o console original | 🟡 Menus e troféus em português via patches na ISO |
| **Super Smash Bros. Brawl / Project+** | [**Project+ (P+)** (`projectplusgame.com`)](https://projectplusgame.com/)<br>[**Project-Plus Repo**](https://github.com/projectplus/Project-Plus) | Wii (`RSBE01`) | Standalone PC Launcher com Rollback Netcode integrado | ✅ **100% Jogável** — Equilíbrio competitivo profissional, física aprimorada, online rollback | 🟡 Jogo arcade de luta focado em gameplay |
| **Super Smash Bros. for Wii U (Smash 4)** | [**Smash 4 PC Standalone Setup**](https://github.com/cemu-project/Cemu) | Wii U | Standalone x64 com Async Shaders, 4K/Ultrawide e Mods | ✅ **100% Jogável** — 60 FPS 4K, suporte completo a controles de GameCube | 🟢 Menus e nomes de lutadores traduzidos |
| **Super Smash Bros. 64** | [**BattleShip** (`JRickey/BattleShip`)](https://github.com/JRickey/BattleShip)<br>[**smash64r** (`zestydevy/smash64r`)](https://github.com/zestydevy/smash64r)<br>[**ssb-decomp-re**](https://github.com/VetriTheRetri/ssb-decomp-re) | Nintendo 64 | Port Nativo via `libultraship` (`BattleShip`) e Recompilação Estática `N64Recomp` + `RT64` | ✅ **100% Jogável** — Widescreen 16:9/21:9, 60+ FPS, Ray Tracing opcional, input nativo | 🟢 Compatível com a tradução PT-BR da ROM de N64 |

---

### 📦 Como Rodar Super Smash Bros. Ultimate com Tradução e Dublagem PT-BR no PC

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

