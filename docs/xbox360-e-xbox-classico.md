# 🟢 Xbox 360 & Xbox Clássico no PC (`XenonRecomp`, `ReXGlue` e `xboxrecomp`)

Entre 2025 e 2026, a cena de **Recompilação Estática** explodiu no **Xbox 360** (graças ao [**XenonRecomp**](https://github.com/hedge-dev/XenonRecomp) e ao [**ReXGlue SDK**](https://github.com/1274014/ReXGlue)) e no **Xbox Clássico** (graças ao [**xboxrecomp**](https://github.com/sp00nznet/xboxrecomp) / `XBERecomp`). Dezenas de exclusivos que estavam presos nos consoles da Microsoft agora rodam **nativamente como executáveis de Windows e Linux** em 60 a 240+ FPS, 4K, Ultrawide e com suporte a mods!

---

## 🛠️ Ferramentas e Hubs Base
* [**hedge-dev/XenonRecomp**](https://github.com/hedge-dev/XenonRecomp): Tradutor estático de executáveis PowerPC (`.xex`) do Xbox 360 para C++ nativo.
* [**ReXGlue SDK** (`1274014/ReXGlue`)](https://github.com/1274014/ReXGlue): SDK e runtime de recompilação estática de Xbox 360 com renderizadores Direct3D 12 e Vulkan nativos.
* [**CrownParkComputing/Xbox360-Native-Ports**](https://github.com/CrownParkComputing/Xbox360-Native-Ports): Monorepo com ports nativos de *Midnight Club: LA*, *Burnout Revenge*, *Split/Second*, *Daytona USA*, *OutRun Online Arcade*, *SoulCalibur II HD* e *Ridge Racer Unbounded*.
* [**sp00nznet/xboxrecomp**](https://github.com/sp00nznet/xboxrecomp): Tradutor de executáveis `.xbe` (x86 32-bit) do Xbox Clássico para código C x86-64 nativo no Windows/Linux.

---

## 🔥 Parte 1: Xbox 360 — Todos os Ports Nativos e Recompilações (`XenonRecomp` / `ReXGlue`)

| Jogo (Xbox 360) | Nome do Projeto & Link GitHub | Status Atual | 🇧🇷 Suporte a PT-BR (Legenda / Dublagem) |
| :--- | :--- | :--- | :--- |
| **Sonic Unleashed** | [**UnleashedRecomp** (`hedge-dev/UnleashedRecomp`)](https://github.com/hedge-dev/UnleashedRecomp) | ✅ **100% Completo e Perfeito (Release v1.0.3+)** — Até 240+ FPS, Ultrawide, D3D12/Vulkan, HedgeModManager | 🟢 **Mod PT-BR + Dublagem!** Mod *Sonic Braleashed* (legendas/menus PT-BR) + *Projeto Lobão* (dublagem PT-BR) no GameBanana |
| **Sonic the Hedgehog (2006)** | [**MarathonRecomp** (`sonicnext-dev/MarathonRecomp`)](https://github.com/sonicnext-dev/MarathonRecomp)<br>*(Veja também o remake nativo **Sonic P-06**)* | ✅ **Jogável / Em dev ativo** — Port nativo via XenonRecomp para Windows/Linux | 🟢 **Mod PT-BR** disponível no GameBanana |
| **Sonic Free Riders** | [**Free-Riders-Recompiled** (`YuutaTsubasa/Free-Riders-Recompiled`)](https://github.com/YuutaTsubasa/Free-Riders-Recompiled) | ✅ **Jogável (Release v0.9.0)** — **Remove a exigência do Kinect** e adiciona controle tradicional! | ⚪ Em inglês |
| **Forza Horizon 1** | [**pinyon-shift** (`arcanite24/pinyon-shift`)](https://github.com/arcanite24/pinyon-shift) | ✅ **Jogável (Release v0.5.1)** — 120/144 FPS, Free Roam Online, Vulkan | 🟢 **100% Nativo Oficial (Dublagem e Legendas em PT-BR no disco!)** |
| **Forza Horizon 2 (360)** | [**fh2-recompiled** (`Gabrick75/fh2-recompiled`)](https://github.com/Gabrick75/fh2-recompiled) | 🚧 **Em desenvolvimento (WIP)** | 🟢 **100% Nativo Oficial (Dublagem e Legendas em PT-BR no disco!)** |
| **Forza Motorsport 4** | [**fm4-recomp** (`Alexbeav/fm4-recomp`)](https://github.com/Alexbeav/fm4-recomp) | 🚧 **Em desenvolvimento (WIP)** | 🟡 Tradução de menus da comunidade |
| **Skate 3** | [**skate3recomp** (`mchughalex/skate3recomp`)](https://github.com/mchughalex/skate3recomp) | ✅ **Jogável (Release v2.0.2)** — D3D12/Vulkan, Windows/Linux/Deck | ⚪ Em inglês |
| **Skate 2** | [**skate2-recompile-pc** (`christianortel/skate2-recompile-pc`)](https://github.com/christianortel/skate2-recompile-pc) | ✅ **Jogável (Release v0.1.1)** | ⚪ Em inglês |
| **Blue Dragon** | [**re:Blue** (`zolaware/reblue`)](https://github.com/zolaware/reblue) | ✅ **Jogável (Release v1.3.1)** — 4K, 60 FPS, suporte aos 3 discos | 🟢 **Tradução PT-BR 100% Completa!** (*LeandroCiC*) |
| **Lost Odyssey** | [**LostOdysseyRecomp** (`freefrank/LostOdysseyRecomp`)](https://github.com/freefrank/LostOdysseyRecomp) | ✅ **Jogável (Release v0.9.65)** — Loadings instantâneos nos 4 discos, 60 FPS | 🟢 **Tradução PT-BR 100% Completa + Dublagem IA opcional!** |
| **Fable II** | [**Fable-2-Recomp** (`himdo/Fable-2-Recomp`)](https://github.com/himdo/Fable-2-Recomp) | ✅ **Jogável (Release v1.5.0)** — 60 FPS, altas resoluções | 🟢 **Tradução PT-BR Disponível!** (*Dio Carvalho*) |
| **Dante's Inferno** | [**hells-gate-recomp** (`florinp93/hells-gate-recomp`)](https://github.com/florinp93/hells-gate-recomp) | ✅ **Jogável (Release v0.8.3-beta)** | 🟢 **Tradução PT-BR 100% Completa!** (*Tribo Gamer*) |
| **Silent Hill: Downpour** | [**DownpourRecomp** (`LittleBitUA/DownpourRecomp`)](https://github.com/LittleBitUA/DownpourRecomp) | ✅ **100% Completo e Estável (Release v1.1.8)** — D3D12, 60+ FPS | 🟢 **Tradução PT-BR Completa!** (*Tribo Gamer*) |
| **Deadly Premonition** | [**DPRecomp** (`LittleBitUA/DPRecomp`)](https://github.com/LittleBitUA/DPRecomp) | ✅ **100% Completo (Release v2.0.14)** — D3D12, 60 FPS, FSR 3 | 🟢 **Tradução PT-BR Completa!** (Nexus Mods) |
| **Need for Speed: Most Wanted (Versão 360)** | [**nfsmw-nx** (`StevensND/nfsmw-nx`)](https://github.com/StevensND/nfsmw-nx) | ✅ **Jogável (Release v1.0.0)** — Gráficos next-gen do 360 no PC! | 🟢 **Tradução PT-BR Disponível!** |
| **Need for Speed: Carbon (360)** | [**nfs-carbon-recomp** (`Sampreeth004/nfs-carbon-recomp`)](https://github.com/Sampreeth004/nfs-carbon-recomp) | ✅ **Jogável (Release v0.3.12)** | 🟢 **Tradução PT-BR Disponível!** |
| **Midnight Club: Los Angeles** | [**mcla-recomp** (`holdmysocks/mcla-recomp`)](https://github.com/holdmysocks/mcla-recomp) | 🚧 **Em desenvolvimento avançado (WIP)** | ⚪ Em inglês |
| **Gears of War 2** | [**gow2-recomp** (`santiquiroz/gow2-recomp`)](https://github.com/santiquiroz/gow2-recomp) | 🚧 **Em desenvolvimento (WIP)** | 🟢 **Tradução PT-BR Completa** (Nexus Mods / João13 Traduções) |
| **Gears of War: Judgment** | [**gears-judgement-recomp** (`OverkillLabs3/gears-judgement-recomp`)](https://github.com/OverkillLabs3/gears-judgement-recomp) | ✅ **Jogável (Release v0.2.1)** | 🟢 **100% Nativo Oficial (Dublagem e Legendas em PT-BR no disco!)** |
| **Asura's Wrath** | [**asuras-wrath-recomp** (`PauloUbirajara/asuras-wrath-recomp`)](https://github.com/PauloUbirajara/asuras-wrath-recomp) | 🚧 **Em desenvolvimento** *(Criado por dev brasileiro!)* | 🟢 **Tradução PT-BR Completa** para os arquivos do Xbox 360 |
| **Naruto: Rise of a Ninja** | [**naruto-rise-recomp** (`jorjbarbosa/naruto-rise-recomp`)](https://github.com/jorjbarbosa/naruto-rise-recomp) | ✅ **Beta Jogável (Release v0.1.0-beta.3)** *(Criado por dev brasileiro!)* | 🟡 Tradução PT-BR em andamento pela comunidade |
| **Crash of the Titans** | [**MojoRecomp** (`OAleex/MojoRecomp`)](https://github.com/OAleex/MojoRecomp) | ✅ **Jogável (Release v1.1.0)** *(Criado pelo lendário tradutor brasileiro **OAleex**!)* | 🟢 **Tradução PT-BR Completa pelo próprio autor (OAleex)!** |
| **Dragon Ball Z: Budokai HD Collection** | [**DBZ-Budokai-3-HD-Collection** (`novapowers0`)](https://github.com/novapowers0/DBZ-Budokai-3-HD-Collection) | ✅ **Jogável (Release v1.4.5.2)** | 🟡 Possui tradução PT-BR da comunidade |
| **Dragon Ball Z: Burst Limit** | [**DBZ-Burst-Limit-Recompiled** (`iExplosiveRage`)](https://github.com/iExplosiveRage/DBZ-Burst-Limit-Recompiled) | ✅ **Jogável (Release v0.6.0-alpha)** — Vulkan, 60 FPS | ⚪ Em inglês |
| **GoldenEye 007 (XBLA Remaster Cancelado)** | [**GoldenEye-Recomp** (`SunJaycy/GoldenEye-Recomp`)](https://github.com/SunJaycy/GoldenEye-Recomp) | ✅ **100% Jogável (Release v1.2.4)** — Mouse/Teclado nativo, 60+ FPS | 🟡 Tradução PT-BR em adaptação |
| **Perfect Dark Remaster & Perfect Dark Zero** | [**PerfectDarkRemasterRecomp** (`nikolaygorb/PerfectDarkRemasterRecomp`)](https://github.com/nikolaygorb/PerfectDarkRemasterRecomp) | ✅ **Jogável (Release v1.3)** | 🟡 Possuem tradução PT-BR de textos |
| **Viva Piñata: Trouble in Paradise** | [**TiP-Recomp** (`SolarCookies/TiP-Recomp`)](https://github.com/SolarCookies/TiP-Recomp) | ✅ **Jogável (Release v1.13.0)** | 🟢 **100% Nativo Oficial (Dublagem e Textos em PT-BR no disco de Xbox 360!)** |
| **Banjo-Kazooie: Nuts & Bolts** | [**reNut** (`masterspike52/reNut`)](https://github.com/masterspike52/reNut) | 🚧 **Em desenvolvimento** | 🟢 **Tradução PT-BR** disponível na comunidade Xbox 360 |
| **Burnout Revenge (360)** | [**Xerenge** (`shipa-2/Xerenge`)](https://github.com/shipa-2/Xerenge) | ✅ **Jogável (Release v0.4.6)** | ⚪ Em inglês |
| **Condemned 2: Bloodshot** | [**Condemned2Recomp** (`psxrestore/Condemned2Recomp`)](https://github.com/psxrestore/Condemned2Recomp) | ✅ **Jogável (Release v0.2.1)** | 🟢 **Tradução PT-BR Completa** (*XEX Brasil / GameLab Traduções*) |
| **The Darkness (2007)** | [**The-Darkness-Recomp** (`portingpete/The-Darkness-Recomp`)](https://github.com/portingpete/The-Darkness-Recomp) | 🚧 **Em desenvolvimento ativo** | 🟡 Possui tradução PT-BR na comunidade |
| **Eternal Sonata** | [**EternalSonataReprise** (`birabittoh/EternalSonataReprise`)](https://github.com/birabittoh/EternalSonataReprise) | ✅ **Jogável (Release v1.2.6)** | ⚪ Em inglês |
| **Kameo: Elements of Power** | [**KameoRePowered** (`birabittoh/KameoRePowered`)](https://github.com/birabittoh/KameoRePowered) | ✅ **Jogável** | 🟡 Possui tradução PT-BR na comunidade |
| **Project Gotham Racing 4** | [**PGR4-Recomp** (`beatrixzy/PGR4-Recomp`)](https://github.com/beatrixzy/PGR4-Recomp) | ✅ **Jogável (Release v1.2.1)** | ⚪ Corrida |
| **Ridge Racer 6** | [**RidgeRacer6-Recompilation** (`Sirhalo23`)](https://github.com/Sirhalo23/RidgeRacer6-Recompilation) | ✅ **Jogável (Release v0.1.5)** | ⚪ Corrida Arcade |
| **Ace Combat 6: Fires of Liberation** | [**AC6_recomp** (`sal063/AC6_recomp`)](https://github.com/sal063/AC6_recomp) | ✅ **Jogável (Release v0.1-alpha)** | ⚪ Em inglês |
| **Ninja Gaiden II (2008 Original)** | [**Ninja's Dawn** (`TheSaltTrader`)](https://github.com/TheSaltTrader/Ninja-s-Dawn---A-Ninja-Gaiden-2-Recompilation-Project) | 🚧 **Em desenvolvimento** | ⚪ Em espanhol/inglês (Sigma 2 PC tem PT-BR) |
| **Spider-Man: Edge of Time** | [**EdgeOfTimeRecomp** (`goliathret/EdgeOfTimeRecomp`)](https://github.com/goliathret/EdgeOfTimeRecomp) | ✅ **Jogável (Release v1.0.0)** | 🟡 Tradução PT-BR disponível |
| **Peter Jackson's King Kong** | [**king-kong-recompiled** (`TekRantGaming/king-kong-recompiled`)](https://github.com/TekRantGaming/king-kong-recompiled) | ✅ **Jogável (Release v1.9.11)** | 🟢 Possui tradução PT-BR clássica |
| **Earthworm Jim HD** | [**earthworm-jim-hd-recompiled** (`TekRantGaming`)](https://github.com/TekRantGaming/earthworm-jim-hd-recompiled) | ✅ **Jogável (Release v0.9.5)** | ⚪ Em inglês |
| **Dead Rising 2: Case Zero & Case West** | [**Case Zero Recomp** (`wivi514`)](https://github.com/wivi514/Dead_Rising_2_Case_Zero_Xenon_Recomp) | ✅ **Jogáveis (Releases v1.1.3 / v1.1.2)** | 🟡 Possuem tradução PT-BR |
| **Call of Duty 3** | [**project-1944** (`zenit2893-cmyk/project-1944`)](https://github.com/zenit2893-cmyk/project-1944) | ✅ **Jogável (`project-1944` v2.0)** | 🟢 Possui tradução PT-BR |
| **Army of Two** | [**ArmyOfTwoRecomp** (`nikolaygorb/ArmyOfTwoRecomp`)](https://github.com/nikolaygorb/ArmyOfTwoRecomp) | ✅ **Jogável (Release v1.2)** | 🟡 Possui tradução PT-BR |
| **Wet** | [**wet-recomp** (`Supermedo/wet-recomp`)](https://github.com/Supermedo/wet-recomp) | ✅ **Jogável (Release v0.6.0)** | 🟡 Possui tradução PT-BR na comunidade |
| **Crackdown** | [**crackdown-recomp** (`Unowa001/crackdown-recomp`)](https://github.com/Unowa001/crackdown-recomp) | ✅ **Jogável (Release v0.4.0)** | ⚪ Em inglês |
| **Hard Corps: Uprising** | [**hard-corps-uprising-recompiled** (`saulob`)](https://github.com/saulob/hard-corps-uprising-recompiled) | ✅ **Jogável (Release v0.5.3)** *(Por dev brasileiro Saulo!)* | ⚪ Arcade |
| **WWE SmackDown vs. Raw 2007** | [**SVR07-Recomp** (`HollywoodAkeem`)](https://github.com/HollywoodAkeem/SVR07-Recomp) | ✅ **Jogável (Release v1.0)** | ⚪ Luta Livre |
| **Fight Night Champion** | [**FNCReborn** (`whompay/FNCReborn`)](https://github.com/whompay/FNCReborn) | ✅ **Jogável (Release v1.0)** | ⚪ Luta |
| **Mortal Kombat vs. DC Universe** | [**MKVDCU-Recomp** (`KawaiiBunga/MKVDCU-Recomp`)](https://github.com/KawaiiBunga/MKVDCU-Recomp) | ✅ **Jogável (Release v0.2.1)** | 🟡 Possui tradução PT-BR |
| **Tony Hawk's Project 8** | [**Project8Recomp** (`theokyr/Project8Recomp`)](https://github.com/theokyr/Project8Recomp) | ✅ **Jogável (Release v0.3.0)** | ⚪ Em inglês |
| **The Simpsons Game (2007)** | [**TheSimpsonsGameRecomp** (`YesterMester`)](https://github.com/YesterMester/TheSimpsonsGameRecomp) | 🚧 **Em desenvolvimento** | 🟢 Possui tradução PT-BR na comunidade Xbox 360 |
| **Grand Theft Auto IV (360)** | [**Theft4** (`KoreanSeats1/Theft4`)](https://github.com/KoreanSeats1/Theft4) | 🚧 **Em desenvolvimento** | 🟢 Tradução PT-BR completa disponível |

---

## ❎ Parte 2: Xbox Clássico / Original — Ports Nativos (`xboxrecomp` / `XBERecomp`)

| Jogo (Xbox Clássico) | Nome do Projeto & Link GitHub | Status Atual | 🇧🇷 Suporte a PT-BR |
| :--- | :--- | :--- | :--- |
| **Halo: Combat Evolved** | [**OpenCE** (`OpenCommunityEdition/OpenCE`)](https://github.com/OpenCommunityEdition/OpenCE) | ✅ **Jogável** — Recompilação estática limpa C++20/CMake | 🟢 Possui tradução e dublagem PT-BR na comunidade |
| **Mercenaries: Playground of Destruction** | [**Mercenaries-Recompiled** (`KraftMacAndChee`)](https://github.com/KraftMacAndChee/Mercenaries-Recompiled) | ✅ **100% Jogável (Release)** — Controles modernos, altas resoluções | ⚪ Em inglês |
| **Burnout 3: Takedown** | [**burnout3** (`sp00nznet/burnout3`)](https://github.com/sp00nznet/burnout3) | ✅ **Jogável** — D3D11, Widescreen, 60+ FPS | 🟡 Tradução PT-BR (versão PS2 por Valclark Junior) |
| **Burnout 2: Point of Impact** | [**burnout2-recompilation** (`timftw21/burnout2-recompilation`)](https://github.com/timftw21/burnout2-recompilation) | ✅ **Jogável (Release v1.5)** | ⚪ Corrida |
| **Black (2006)** | [**Black-2006-Recomp** (`portingpete/Black-2006-Recomp`)](https://github.com/portingpete/Black-2006-Recomp) | ✅ **Jogável (Release v0.9.1)** — Mouse e Teclado, FOV ajustável, D3D11/12 | 🟢 **Tradução e Dublagem PT-BR** disponíveis na comunidade |
| **Def Jam: Fight for NY** | [**DefJamFFNY-recomp** (`vyanhursky/DefJamFFNY-recomp`)](https://github.com/vyanhursky/DefJamFFNY-recomp) | ✅ **Jogável (Release v0.4.7)** — Windows, Linux e macOS | 🟡 Possui tradução PT-BR da comunidade |
| **Jet Set Radio Future (JSRF)** | [**JSRF Unleashed** (`JuMatt/JetSetRadioFuture-Unleashed`)](https://github.com/JuMatt/JetSetRadioFuture-Unleashed) | ✅ **Jogável (Release v0.4.7)** — Port nativo x86-64 com D3D11 e XInput | ⚪ Em inglês |
| **Splinter Cell: Double Agent (Versão Original Xbox)** | [**SCDA-XBERecomp** (`TGP482/SCDA-XBERecomp`)](https://github.com/TGP482/SCDA-XBERecomp) | ✅ **Jogável (Release V1)** — Traz a aclamada versão da Montreal (superior à de PC/360) nativamente para Windows! | 🟡 Tradução PT-BR em adaptação |
| **The Lord of the Rings: The Two Towers** | [**TooTawersRecomp** (`Gumpolas/TooTawersRecomp`)](https://github.com/Gumpolas/TooTawersRecomp) | ✅ **Jogável (Release v1.9.1)** | 🟡 Possui tradução PT-BR |
| **Dead or Alive 3 & DOA Xtreme Beach Volleyball** | [**doa3-recomp** (`parkerallan/doa3-recomp`)](https://github.com/parkerallan/doa3-recomp)<br>[**doaxvb-re** (`NoRain211/doaxvb-re`)](https://github.com/NoRain211/doaxvb-re) | ✅ **Jogáveis (Releases v1.0.3 / v0.5.3)** | ⚪ Em inglês |
| **Midtown Madness 3** | [**midtown-madness-3-PC-Native** (`lakshya16157`)](https://github.com/lakshya16157/midtown-madness-3-PC-Native) | ✅ **Jogável** — D3D11 no Windows | ⚪ Em inglês |
| **RalliSport Challenge 2** | [**RallisportChallenge2-decomp** (`Mortify7612`)](https://github.com/Mortify7612/RallisportChallenge2-decomp) | ✅ **Jogável** — Vulkan no Windows/Linux | ⚪ Corrida |
| **X-Men Legends** | [**OpenXML1xbox** (`GTTeancum/OpenXML1xbox`)](https://github.com/GTTeancum/OpenXML1xbox) | ✅ **Jogável (Release v0.9.1b)** | 🟡 Possui tradução PT-BR |
| **Ninja Gaiden Black** | [**ngbrecomp** (`gamboozino/ngbrecomp`)](https://github.com/gamboozino/ngbrecomp) | 🚧 **Em desenvolvimento** | ⚪ Em inglês |
| **SSX Tricky** | [**OpenTricky** (`GiZcesi/OpenTricky`)](https://github.com/GiZcesi/OpenTricky) | 🚧 **Em desenvolvimento** | ⚪ Em inglês |
| **Spider-Man 2 (Console Version)** | [**SM2-Recomp** (`SirSymo/SM2-Recomp`)](https://github.com/SirSymo/SM2-Recomp) | 🚧 **Em desenvolvimento** (O verdadeiro Spider-Man 2 de consoles no PC!) | 🟡 Possui tradução PT-BR na versão PS2/GC |
