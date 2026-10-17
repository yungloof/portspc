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
| **The Legend of Zelda: Twilight Princess** | [**Dusklight (Dusk)** (`TwilitRealm/dusklight`)](https://github.com/TwilitRealm/dusklight)<br>[**zeldaret/tp** (Decomp 100%)](https://github.com/zeldaret/tp) | GameCube (`GZ2E01`) | ✅ **100% Completo e Jogável (Release v2.0.3)** — 60+ FPS, Ultrawide 16:9/21:9, Texturas HD, Randomizer, Mods | 🟢 **Tradução PT-BR Completa Disponível!** Compatível com a tradução PT-BR de GameCube (Central de Traduções / Tribo Gamer) e pacotes de localização |
| **The Legend of Zelda: The Wind Waker HD** | [**ZeldaWWHDRecomp**](https://github.com/ZeldaWWHDRecomp/ZeldaWWHDRecomp)<br>[**SwitchWakerHD** (`centollOS/SwitchWakerHD`)](https://github.com/centollOS/SwitchWakerHD) | Wii U | ✅ **Jogável (Releases ativas v0.4.7+)** — Vulkan/Metal nativo, 60+ FPS, Ultrawide, Mod Manager | 🟢 **Tradução PT-BR 100% Completa!** Compatível diretamente com a tradução da equipe **Triforce Heroes Traduções** (`content` do Wii U) |
| **The Legend of Zelda: The Wind Waker (GC)** | [**BlueWake** (`chrissotraidis/bluewake`)](https://github.com/chrissotraidis/bluewake)<br>[**zeldaret/tww** (Decomp 100%)](https://github.com/zeldaret/tww) | GameCube (`GZLE01`) | ✅ **Jogável (Release v0.7.0 pronta para Windows!)** — Construído sobre a descompilação 100% do código de GameCube | 🟢 **Tradução PT-BR Completa** disponível para a ISO de GameCube |
| **The Legend of Zelda: Link's Awakening (Remake)** | [**LASRecomp** (`peiikai/LASRecomp`)](https://github.com/peiikai/LASRecomp) | Nintendo Switch | ✅ **Beta Jogável (`beta_4`)** — Recompilação estática ARM64 -> x86-64 nativo no PC! | 🟢 **Tradução PT-BR Completa** disponível para os arquivos do Switch |
| **Hyrule Warriors: Definitive Edition** | [**HWDER** (`sonsegajp/HWDER`)](https://github.com/sonsegajp/HWDER) | Nintendo Switch | ✅ **Jogável (Release v0.1.1)** — Port nativo por recompilação estática | 🟡 Possui tradução PT-BR da comunidade Switch |

---

## 🍄 Parte 2: GameCube & Wii — Todos os Ports Nativos, Recomps e Decomps

| Jogo | Nome do Projeto & Link GitHub | Plataforma Base | Status Atual | 🇧🇷 Suporte a PT-BR |
| :--- | :--- | :--- | :--- | :--- |
| **Super Mario Galaxy** | [**Nebula** (`keepvaibin/nebula`)](https://github.com/keepvaibin/nebula)<br>[**GalaxyPad** (`chrissotraidis/galaxypad`)](https://github.com/chrissotraidis/galaxypad)<br>[**Petari** (`SMGCommunity/Petari` - 100% Decomp)](https://github.com/SMGCommunity/Petari) | Wii | ✅ **100% Jogável (`Nebula` v1.0.0 & `GalaxyPad` v0.2.2)** — Até 16x resolução, 60 FPS, Ultrawide 32:9, FSR 1, Mouse/Teclado ou Controle! | 🟢 **Tradução PT-BR 100% Completa!** Feita pelos grupos *Brazilian Warriors / Nintendo BR* (João13 Traduções) |
| **Super Mario Galaxy 2** | [**Garigari** (`SMGCommunity/Garigari`)](https://github.com/SMGCommunity/Garigari) | Wii | 🚧 **Descompilação em andamento** | 🟢 **Tradução PT-BR Completa** disponível para a ISO de Wii |
| **Super Mario Sunshine** | [**sms-pc-port** (`chasem-dev/sms-pc-port`)](https://github.com/chasem-dev/sms-pc-port)<br>[**SunPad** (`chrissotraidis/sunpad`)](https://github.com/chrissotraidis/sunpad) | GameCube (`GMSE01`) | ✅ **100% Jogável (Releases disponíveis)** — Até 120 FPS, 8x resolução, Ultrawide, Câmera Livre, Co-op Online | 🟢 **Tradução PT-BR 100% Completa!** Disponível na Central de Traduções / RomsPortugues |
| **New Super Mario Bros. Wii** | [**NSMB-Wii-Multiplayer-Recompilation** (`WitherBlitz`)](https://github.com/WitherBlitz/NSMB-Wii-Multiplayer-Recompilation) | Wii | ✅ **Jogável (Release v0.1.1)** — Com suporte a Multiplayer Online! | 🟢 **Tradução e Dublagem PT-BR** disponíveis para a ISO de Wii |
| **Mario Kart Wii** | [**WiiCompiled** (`patchzyy/Wiicompiled`)](https://github.com/patchzyy/Wiicompiled)<br>[**KartPad** (`chrissotraidis/kartpad`)](https://github.com/chrissotraidis/kartpad)<br>[**driftdroid** (`dorPXP/driftdroid`)](https://github.com/dorPXP/driftdroid)<br>[**mkw decomp** (`riidefi/mkw`)](https://github.com/riidefi/mkw) | Wii | ✅ **Jogável** — Recompilação estática nativa para PC e Mobile | 🟢 **Tradução PT-BR 100% Completa!** (*Guilherme Dias / Walter Leal*) |
| **Super Smash Bros. Melee** | [**melee-pc** (`999sian/melee-pc`)](https://github.com/999sian/melee-pc)<br>[**Melee Unlocked** (`Hero88go/melee-unlocked`)](https://github.com/Hero88go/melee-unlocked)<br>[**doldecomp/melee**](https://github.com/doldecomp/melee) | GameCube (`GALE01` v1.02) | ✅ **Jogável (`melee-unlocked` v0.8.98 & `melee-pc`)** — Vulkan/Metal/D3D12 via Aurora, SDL3 | 🟡 Tradução parcial de menus/troféus |
| **Metroid Prime 1, 2 e 3** | [**Metaforce** (`AxioDL/metaforce`)](https://github.com/AxioDL/metaforce)<br>[**prime-decomp** (`PrimeDecomp/prime`)](https://github.com/PrimeDecomp/prime) | GameCube / Wii | ✅ **Jogável (MP1) / Em dev ativo (MP2/MP3)** — Vulkan/D3D12, Widescreen, DualStick/Mouse | 🟢 **Tradução PT-BR Completa (MP1)** feita por *MJay (BR Traduções)* |
| **Pikmin 1 & Pikmin 2** | [**Open Nectar** (`SSunnKing/Open-Nectar---Pikmin-Native-PC-Mobile-Port`)](https://github.com/SSunnKing/Open-Nectar---Pikmin-Native-PC-Mobile-Port)<br>[**projectPiki/pikmin2**](https://github.com/projectPiki/pikmin2) | GameCube | ✅ **Jogável (`Open Nectar`) & Decomp 100% (`pikmin2`)** | 🟢 **Tradução PT-BR Disponível** para Pikmin 1 e 2 |
| **Skies of Arcadia Legends** | [**SkiesOfArcadiaLegends-Recomp** (`ogdanimal`)](https://github.com/ogdanimal/SkiesOfArcadiaLegends-Recomp) | GameCube | ✅ **100% Completo e Jogável!** — 16:9 Widescreen, 60 FPS, Fast-Forward 4x, Sliders de Encontros/EXP | ⚪ Em inglês |
| **SoulCalibur II (GC)** | [**RingOut** (`jackpoison-prog/RingOut`)](https://github.com/jackpoison-prog/RingOut) | GameCube | ✅ **Jogável (Release v1.6.9 —Inclui o Link de Zelda!)** | ⚪ Luta Arcade |
| **Eternal Darkness: Sanity's Requiem** | [**EternalDarknessRecomp** (`griches/EternalDarknessRecomp`)](https://github.com/griches/EternalDarknessRecomp) | GameCube | ✅ **Jogável / Em dev ativo** — Windows, Linux e Steam Deck | ⚪ Em inglês |
| **Kirby's Return to Dream Land** | [**ModernGekko Kirby Wii Recomp** (`ExpansionPak/ModernGekko`)](https://github.com/ExpansionPak/ModernGekko/releases/tag/kirby) | Wii | ✅ **Jogável (Release disponível)** | 🟢 Possui tradução PT-BR para a ISO de Wii |
| **Animal Crossing (GameCube)** | [**ACGC-PC-Port** (`flyngmt/ACGC-PC-Port`)](https://github.com/flyngmt/ACGC-PC-Port)<br>[**ac-decomp** (`ACreTeam/ac-decomp` - 100%)](https://github.com/ACreTeam/ac-decomp) | GameCube | ✅ **Jogável** — Construído sobre a descompilação 100% concluída | 🟡 Projeto *Traducrossing* em andamento |
| **NBA Street V3 (Mario All-Stars)** | [**street-recomp-v3** (`recomp-code/street-recomp-v3`)](https://github.com/recomp-code/street-recomp-v3) | GameCube | ✅ **Jogável (Release v1.3.1)** | ⚪ Esporte Arcade |
| **Chibi-Robo! Plug Into Adventure!** | [**chibi-recompo** (`xXJSONDeruloXx/chibi-recompo`)](https://github.com/xXJSONDeruloXx/chibi-recompo) | GameCube | ✅ **Jogável / Em dev ativo** | ⚪ Em inglês |
| **Wii Party & Muscle March** | [**wiiparty-recomp** (`arelkair/wiiparty-recomp`)](https://github.com/arelkair/wiiparty-recomp)<br>[**muscle-march-recomp** (`tmcleroy`)](https://github.com/tmcleroy/muscle-march-recomp) | Wii | ✅ **Jogável (`v0.1.13-alpha`)** | 🟡 Wii Party possui tradução PT-BR na ISO |
| **Luigi's Mansion** | [**lm-decomp** (`theplayerrolo/lm-decomp`)](https://github.com/theplayerrolo/lm-decomp) | GameCube | 🚧 **Descompilação avançada / Port em dev** | 🟢 **Tradução PT-BR 100% Completa!** (*JumpManClub Brasil*) |
| **Paper Mario: The Thousand-Year Door** | [**doldecomp/ttyd**](https://github.com/doldecomp/ttyd) | GameCube | 🚧 **Descompilação avançada** | 🟢 **Tradução PT-BR Completa** (GC por *SBraz Gamer* e Switch) |
| **Mario Kart: Double Dash!!** | [**doldecomp/mkdd**](https://github.com/doldecomp/mkdd) | GameCube | 🚧 **Descompilação em andamento** | 🟢 Possui tradução PT-BR na ISO |
| **Star Fox Adventures** | [**SFA-Decomp** (`zcanann/SFA-Decomp`)](https://github.com/zcanann/SFA-Decomp) | GameCube | 🚧 **Descompilação em andamento** | 🟢 Possui tradução PT-BR na ISO |
