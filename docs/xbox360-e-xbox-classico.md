# Xbox 360 & Xbox Clássico no PC (`XenonRecomp`, `ReXGlue` e `xboxrecomp`)

> **Navegação:** [Catálogo Principal](../README.md) · [Catálogo Web](../index.html) · [Guia PT-BR](guia-traducoes-ptbr.md)

Entre 2025 e 2026, a cena de **Recompilação Estática** explodiu no **Xbox 360** (graças ao [**XenonRecomp**](https://github.com/hedge-dev/XenonRecomp) e ao [**ReXGlue SDK**](https://github.com/1274014/ReXGlue)) e no **Xbox Clássico** (graças ao [**xboxrecomp**](https://github.com/sp00nznet/xboxrecomp) / `XBERecomp`). Dezenas de exclusivos que estavam presos nos consoles da Microsoft agora rodam **nativamente como executáveis de Windows e Linux** em 60 a 240+ FPS, 4K, Ultrawide e com suporte a mods!

---

## Ferramentas e Hubs Base
* [**hedge-dev/XenonRecomp**](https://github.com/hedge-dev/XenonRecomp): Tradutor estático de executáveis PowerPC (`.xex`) do Xbox 360 para C++ nativo.
* [**ReXGlue SDK** (`1274014/ReXGlue`)](https://github.com/1274014/ReXGlue): SDK e runtime de recompilação estática de Xbox 360 com renderizadores Direct3D 12 e Vulkan nativos.
* [**CrownParkComputing/Xbox360-Native-Ports**](https://github.com/CrownParkComputing/Xbox360-Native-Ports): Monorepo com ports nativos de *Midnight Club: LA*, *Burnout Revenge*, *Split/Second*, *Daytona USA*, *OutRun Online Arcade*, *SoulCalibur II HD* e *Ridge Racer Unbounded*.
* [**sp00nznet/xboxrecomp**](https://github.com/sp00nznet/xboxrecomp): Tradutor de executáveis `.xbe` (x86 32-bit) do Xbox Clássico para código C x86-64 nativo no Windows/Linux.

---

## Parte 1: Xbox 360 — Todos os Ports Nativos e Recompilações (`XenonRecomp` / `ReXGlue`)

| Jogo (Xbox 360) | Nome do Projeto & Link GitHub | Status Atual | Suporte a PT-BR (Legenda / Dublagem) |
| :--- | :--- | :--- | :--- |
| **Sonic Unleashed** | [**UnleashedRecomp** (`hedge-dev/UnleashedRecomp`)](https://github.com/hedge-dev/UnleashedRecomp) | `Jogável` **100% Completo e Perfeito (Release v1.0.3+)** — Até 240+ FPS, Ultrawide, D3D12/Vulkan, HedgeModManager | `Nativo PT-BR` **Mod PT-BR + Dublagem!** Mod *Sonic Braleashed* (legendas/menus PT-BR) + *Projeto Lobão* (dublagem PT-BR) no GameBanana |
| **Sonic the Hedgehog (2006)** | [**MarathonRecomp** (`sonicnext-dev/MarathonRecomp`)](https://github.com/sonicnext-dev/MarathonRecomp)<br>*(Veja também o remake nativo **Sonic P-06**)* | `Jogável` **/ Em dev ativo** — Port nativo via XenonRecomp para Windows/Linux | `Nativo PT-BR` **Mod PT-BR** disponível no GameBanana |
| **Sonic Free Riders** | [**Free-Riders-Recompiled** (`YuutaTsubasa/Free-Riders-Recompiled`)](https://github.com/YuutaTsubasa/Free-Riders-Recompiled) | `Jogável` **(Release v0.9.0)** — **Remove a exigência do Kinect** e adiciona controle tradicional! | `Inglês / Arcade` Em inglês |
| **Forza Horizon 1** | [**pinyon-shift** (`arcanite24/pinyon-shift`)](https://github.com/arcanite24/pinyon-shift) | `Jogável` **(Release v0.5.1)** — 120/144 FPS, Free Roam Online, Vulkan | `Nativo PT-BR` **100% Nativo Oficial (Dublagem e Legendas em PT-BR no disco!)** |
| **Forza Horizon 2 (360)** | [**fh2-recompiled** (`Gabrick75/fh2-recompiled`)](https://github.com/Gabrick75/fh2-recompiled) | `Em dev` | `Nativo PT-BR` **100% Nativo Oficial (Dublagem e Legendas em PT-BR no disco!)** |
| **Forza Motorsport 4** | [**fm4-recomp** (`Alexbeav/fm4-recomp`)](https://github.com/Alexbeav/fm4-recomp) | `Em dev` | `Patch PT-BR` Tradução de menus da comunidade |
| **Skate 3** | [**skate3recomp** (`mchughalex/skate3recomp`)](https://github.com/mchughalex/skate3recomp) | `Jogável` **(Release v2.0.2)** — D3D12/Vulkan, Windows/Linux/Deck | `Inglês / Arcade` Em inglês |
| **Skate 2** | [**skate2-recompile-pc** (`christianortel/skate2-recompile-pc`)](https://github.com/christianortel/skate2-recompile-pc) | `Jogável` **(Release v0.1.1)** | `Inglês / Arcade` Em inglês |
| **Blue Dragon** | [**re:Blue** (`zolaware/reblue`)](https://github.com/zolaware/reblue) | `Jogável` **(Release v1.3.1)** — 4K, 60 FPS, suporte aos 3 discos | `Nativo PT-BR` **Tradução PT-BR 100% Completa!** (*LeandroCiC*) |
| **Lost Odyssey** | [**LostOdysseyRecomp** (`freefrank/LostOdysseyRecomp`)](https://github.com/freefrank/LostOdysseyRecomp) | `Jogável` **(Release v0.9.65)** — Loadings instantâneos nos 4 discos, 60 FPS | `Nativo PT-BR` **Tradução PT-BR 100% Completa + Dublagem IA opcional!** |
| **Fable II** | [**Fable-2-Recomp** (`himdo/Fable-2-Recomp`)](https://github.com/himdo/Fable-2-Recomp) | `Jogável` **(Release v1.5.0)** — 60 FPS, altas resoluções | `Nativo PT-BR` **Tradução PT-BR Disponível!** (*Dio Carvalho*) |
| **Dante's Inferno** | [**hells-gate-recomp** (`florinp93/hells-gate-recomp`)](https://github.com/florinp93/hells-gate-recomp) | `Jogável` **(Release v0.8.3-beta)** | `Nativo PT-BR` **Tradução PT-BR 100% Completa!** (*Tribo Gamer*) |
| **Silent Hill: Downpour** | [**DownpourRecomp** (`LittleBitUA/DownpourRecomp`)](https://github.com/LittleBitUA/DownpourRecomp) | `Jogável` **100% Completo e Estável (Release v1.1.8)** — D3D12, 60+ FPS | `Nativo PT-BR` **Tradução PT-BR Completa!** (*Tribo Gamer*) |
| **Deadly Premonition** | [**DPRecomp** (`LittleBitUA/DPRecomp`)](https://github.com/LittleBitUA/DPRecomp) | `Jogável` **100% Completo (Release v2.0.14)** — D3D12, 60 FPS, FSR 3 | `Nativo PT-BR` **Tradução PT-BR Completa!** (Nexus Mods) |
| **Need for Speed: Most Wanted (Versão 360)** | [**nfsmw-nx** (`StevensND/nfsmw-nx`)](https://github.com/StevensND/nfsmw-nx) | `Jogável` **(Release v1.0.0)** — Gráficos next-gen do 360 no PC! | `Nativo PT-BR` **Tradução PT-BR Disponível!** |
| **Need for Speed: Carbon (360)** | [**nfs-carbon-recomp** (`Sampreeth004/nfs-carbon-recomp`)](https://github.com/Sampreeth004/nfs-carbon-recomp) | `Jogável` **(Release v0.3.12)** | `Nativo PT-BR` **Tradução PT-BR Disponível!** |
| **Midnight Club: Los Angeles** | [**mcla-recomp** (`holdmysocks/mcla-recomp`)](https://github.com/holdmysocks/mcla-recomp) | `Em dev` **Em desenvolvimento avançado (WIP)** | `Inglês / Arcade` Em inglês |
| **Gears of War 2** | [**gow2-recomp** (`santiquiroz/gow2-recomp`)](https://github.com/santiquiroz/gow2-recomp) | `Em dev` | `Nativo PT-BR` **Tradução PT-BR Completa** (Nexus Mods / João13 Traduções) |
| **Gears of War: Judgment** | [**gears-judgement-recomp** (`OverkillLabs3/gears-judgement-recomp`)](https://github.com/OverkillLabs3/gears-judgement-recomp) | `Jogável` **(Release v0.2.1)** | `Nativo PT-BR` **100% Nativo Oficial (Dublagem e Legendas em PT-BR no disco!)** |
| **Asura's Wrath** | [**asuras-wrath-recomp** (`PauloUbirajara/asuras-wrath-recomp`)](https://github.com/PauloUbirajara/asuras-wrath-recomp) | `Em dev` *(Criado por dev brasileiro!)* | `Nativo PT-BR` **Tradução PT-BR Completa** para os arquivos do Xbox 360 |
| **Naruto: Rise of a Ninja** | [**naruto-rise-recomp** (`jorjbarbosa/naruto-rise-recomp`)](https://github.com/jorjbarbosa/naruto-rise-recomp) | `Jogável` **Beta Jogável (Release v0.1.0-beta.3)** *(Criado por dev brasileiro!)* | `Patch PT-BR` Tradução PT-BR em andamento pela comunidade |
| **Crash of the Titans** | [**MojoRecomp** (`OAleex/MojoRecomp`)](https://github.com/OAleex/MojoRecomp) | `Jogável` **(Release v1.1.0)** *(Criado pelo lendário tradutor brasileiro **OAleex**!)* | `Nativo PT-BR` **Tradução PT-BR Completa pelo próprio autor (OAleex)!** |
| **Dragon Ball Z: Budokai HD Collection** | [**DBZ-Budokai-3-HD-Collection** (`novapowers0`)](https://github.com/novapowers0/DBZ-Budokai-3-HD-Collection) | `Jogável` **(Release v1.4.5.2)** | `Patch PT-BR` Possui tradução PT-BR da comunidade |
| **Dragon Ball Z: Burst Limit** | [**DBZ-Burst-Limit-Recompiled** (`iExplosiveRage`)](https://github.com/iExplosiveRage/DBZ-Burst-Limit-Recompiled) | `Jogável` **(Release v0.6.0-alpha)** — Vulkan, 60 FPS | `Inglês / Arcade` Em inglês |
| **GoldenEye 007 (XBLA Remaster Cancelado)** | [**GoldenEye-Recomp** (`SunJaycy/GoldenEye-Recomp`)](https://github.com/SunJaycy/GoldenEye-Recomp) | `Jogável` **(Release v1.2.4)** — Mouse/Teclado nativo, 60+ FPS | `Patch PT-BR` Tradução PT-BR em adaptação |
| **Perfect Dark Remaster & Perfect Dark Zero** | [**PerfectDarkRemasterRecomp** (`nikolaygorb/PerfectDarkRemasterRecomp`)](https://github.com/nikolaygorb/PerfectDarkRemasterRecomp) | `Jogável` **(Release v1.3)** | `Patch PT-BR` Possuem tradução PT-BR de textos |
| **Viva Piñata: Trouble in Paradise** | [**TiP-Recomp** (`SolarCookies/TiP-Recomp`)](https://github.com/SolarCookies/TiP-Recomp) | `Jogável` **(Release v1.13.0)** | `Nativo PT-BR` **100% Nativo Oficial (Dublagem e Textos em PT-BR no disco de Xbox 360!)** |
| **Banjo-Kazooie: Nuts & Bolts** | [**reNut** (`masterspike52/reNut`)](https://github.com/masterspike52/reNut) | `Em dev` | `Nativo PT-BR` **Tradução PT-BR** disponível na comunidade Xbox 360 |
| **Burnout Revenge (360)** | [**Xerenge** (`shipa-2/Xerenge`)](https://github.com/shipa-2/Xerenge) | `Jogável` **(Release v0.4.6)** | `Inglês / Arcade` Em inglês |
| **Condemned 2: Bloodshot** | [**Condemned2Recomp** (`psxrestore/Condemned2Recomp`)](https://github.com/psxrestore/Condemned2Recomp) | `Jogável` **(Release v0.2.1)** | `Nativo PT-BR` **Tradução PT-BR Completa** (*XEX Brasil / GameLab Traduções*) |
| **The Darkness (2007)** | [**The-Darkness-Recomp** (`portingpete/The-Darkness-Recomp`)](https://github.com/portingpete/The-Darkness-Recomp) | `Em dev` **Em desenvolvimento ativo** | `Patch PT-BR` Possui tradução PT-BR na comunidade |
| **Eternal Sonata** | [**EternalSonataReprise** (`birabittoh/EternalSonataReprise`)](https://github.com/birabittoh/EternalSonataReprise) | `Jogável` **(Release v1.2.6)** | `Inglês / Arcade` Em inglês |
| **Kameo: Elements of Power** | [**KameoRePowered** (`birabittoh/KameoRePowered`)](https://github.com/birabittoh/KameoRePowered) | `Jogável` | `Patch PT-BR` Possui tradução PT-BR na comunidade |
| **Project Gotham Racing 4** | [**PGR4-Recomp** (`beatrixzy/PGR4-Recomp`)](https://github.com/beatrixzy/PGR4-Recomp) | `Jogável` **(Release v1.2.1)** | `Inglês / Arcade` Corrida |
| **Ridge Racer 6** | [**RidgeRacer6-Recompilation** (`Sirhalo23`)](https://github.com/Sirhalo23/RidgeRacer6-Recompilation) | `Jogável` **(Release v0.1.5)** | `Inglês / Arcade` Corrida Arcade |
| **Ace Combat 6: Fires of Liberation** | [**AC6_recomp** (`sal063/AC6_recomp`)](https://github.com/sal063/AC6_recomp) | `Jogável` **(Release v0.1-alpha)** | `Inglês / Arcade` Em inglês |
| **Ninja Gaiden II (2008 Original)** | [**Ninja's Dawn** (`TheSaltTrader`)](https://github.com/TheSaltTrader/Ninja-s-Dawn---A-Ninja-Gaiden-2-Recompilation-Project) | `Em dev` | `Inglês / Arcade` Em espanhol/inglês (Sigma 2 PC tem PT-BR) |
| **Spider-Man: Edge of Time** | [**EdgeOfTimeRecomp** (`goliathret/EdgeOfTimeRecomp`)](https://github.com/goliathret/EdgeOfTimeRecomp) | `Jogável` **(Release v1.0.0)** | `Patch PT-BR` Tradução PT-BR disponível |
| **Peter Jackson's King Kong** | [**king-kong-recompiled** (`TekRantGaming/king-kong-recompiled`)](https://github.com/TekRantGaming/king-kong-recompiled) | `Jogável` **(Release v1.9.11)** | `Nativo PT-BR` Possui tradução PT-BR clássica |
| **Earthworm Jim HD** | [**earthworm-jim-hd-recompiled** (`TekRantGaming`)](https://github.com/TekRantGaming/earthworm-jim-hd-recompiled) | `Jogável` **(Release v0.9.5)** | `Inglês / Arcade` Em inglês |
| **Dead Rising 2: Case Zero & Case West** | [**Case Zero Recomp** (`wivi514`)](https://github.com/wivi514/Dead_Rising_2_Case_Zero_Xenon_Recomp) | `Jogável` **Jogáveis (Releases v1.1.3 / v1.1.2)** | `Patch PT-BR` Possuem tradução PT-BR |
| **Call of Duty 3** | [**project-1944** (`zenit2893-cmyk/project-1944`)](https://github.com/zenit2893-cmyk/project-1944) | `Jogável` **(`project-1944` v2.0)** | `Nativo PT-BR` Possui tradução PT-BR |
| **Army of Two** | [**ArmyOfTwoRecomp** (`nikolaygorb/ArmyOfTwoRecomp`)](https://github.com/nikolaygorb/ArmyOfTwoRecomp) | `Jogável` **(Release v1.2)** | `Patch PT-BR` Possui tradução PT-BR |
| **Wet** | [**wet-recomp** (`Supermedo/wet-recomp`)](https://github.com/Supermedo/wet-recomp) | `Jogável` **(Release v0.6.0)** | `Patch PT-BR` Possui tradução PT-BR na comunidade |
| **Crackdown** | [**crackdown-recomp** (`Unowa001/crackdown-recomp`)](https://github.com/Unowa001/crackdown-recomp) | `Jogável` **(Release v0.4.0)** | `Inglês / Arcade` Em inglês |
| **Hard Corps: Uprising** | [**hard-corps-uprising-recompiled** (`saulob`)](https://github.com/saulob/hard-corps-uprising-recompiled) | `Jogável` **(Release v0.5.3)** *(Por dev brasileiro Saulo!)* | `Inglês / Arcade` Arcade |
| **WWE SmackDown vs. Raw 2007** | [**SVR07-Recomp** (`HollywoodAkeem`)](https://github.com/HollywoodAkeem/SVR07-Recomp) | `Jogável` **(Release v1.0)** | `Inglês / Arcade` Luta Livre |
| **Fight Night Champion** | [**FNCReborn** (`whompay/FNCReborn`)](https://github.com/whompay/FNCReborn) | `Jogável` **(Release v1.0)** | `Inglês / Arcade` Luta |
| **Mortal Kombat vs. DC Universe** | [**MKVDCU-Recomp** (`KawaiiBunga/MKVDCU-Recomp`)](https://github.com/KawaiiBunga/MKVDCU-Recomp) | `Jogável` **(Release v0.2.1)** | `Patch PT-BR` Possui tradução PT-BR |
| **Tony Hawk's Project 8** | [**Project8Recomp** (`theokyr/Project8Recomp`)](https://github.com/theokyr/Project8Recomp) | `Jogável` **(Release v0.3.0)** | `Inglês / Arcade` Em inglês |
| **The Simpsons Game (2007)** | [**TheSimpsonsGameRecomp** (`YesterMester`)](https://github.com/YesterMester/TheSimpsonsGameRecomp) | `Em dev` | `Nativo PT-BR` Possui tradução PT-BR na comunidade Xbox 360 |
| **Grand Theft Auto V (Xbox 360 TU27)** | [**gtav-recomp** (`andrewnakas/gtav-recomp`)](https://github.com/andrewnakas/gtav-recomp) | `Jogável` **(`ReXGlue` v0.3.0)** — Windows, Linux, macOS | `Nativo PT-BR` **Legendas Oficiais em PT-BR** |
| **Ninja Gaiden II (2008)** | [**ng2recomp** (`gamboozino/ng2recomp`)](https://github.com/gamboozino/ng2recomp) | `Jogável` **(`v0.5.67` Vulkan)** — 60 FPS cravados, 8x, Mouse/Teclado | `Inglês / Arcade` Em inglês |
| **Dragon Age: Origins** | [**Dragon-Age-Origins-Recomp** (`96dot`)](https://github.com/96dot/Dragon-Age-Origins-Recomp) | `Jogável` **(`v1.0.0-dev.5`)** | `Patch PT-BR` **Tradução PT-BR** (*Avengers of Balduran / Nasher*) |
| **Marvel: Ultimate Alliance 1 & 2 / SSF2T HD Remix** | [**marvel-ultimate-alliance-bundle**](https://github.com/saulob/marvel-ultimate-alliance-bundle-recompiled) / [**ssf2t-hd-remix**](https://github.com/saulob/ssf2t-hd-remix-recompiled) | `Jogável` **Jogáveis (`saulob`)** — 4K, Ultrawide, Launcher TRG | `Inglês / Arcade` Em inglês (MUA tem PT-BR no PC) |
| **WWE 2K14, DOAX2 & Naruto: The Broken Bond** | [**wwe2k14-recomp**](https://github.com/PromethenDev/wwe2k14-recomp) / [**DOAX2-Recomp**](https://github.com/hibikifukui22/Dead-or-Alive-Xtreme-2-Recompilation) / [**broken-bond-recomp**](https://github.com/jorjbarbosa/broken-bond-recomp) | `Jogável` **Jogáveis (Releases Windows)** | `Inglês / Arcade` Em inglês |
| **Grand Theft Auto IV (360)** | [**Theft4** (`KoreanSeats1/Theft4`)](https://github.com/KoreanSeats1/Theft4) | `Em dev` | `Nativo PT-BR` Tradução PT-BR completa disponível |

---

## Parte 2: Xbox Clássico / Original — Ports Nativos (`xboxrecomp` / `XBERecomp`)

| Jogo (Xbox Clássico) | Nome do Projeto & Link GitHub | Status Atual | Suporte a PT-BR |
| :--- | :--- | :--- | :--- |
| **Halo: Combat Evolved** | [**OpenCE** (`OpenCommunityEdition/OpenCE`)](https://github.com/OpenCommunityEdition/OpenCE) | `Jogável` — Recompilação estática limpa C++20/CMake | `Nativo PT-BR` Possui tradução e dublagem PT-BR na comunidade |
| **Mercenaries: Playground of Destruction** | [**Mercenaries-Recompiled** (`KraftMacAndChee`)](https://github.com/KraftMacAndChee/Mercenaries-Recompiled) | `Jogável` **(Release)** — Controles modernos, altas resoluções | `Inglês / Arcade` Em inglês |
| **Burnout 3: Takedown** | [**burnout3** (`sp00nznet/burnout3`)](https://github.com/sp00nznet/burnout3) | `Jogável` — D3D11, Widescreen, 60+ FPS | `Patch PT-BR` Tradução PT-BR (versão PS2 por Valclark Junior) |
| **Burnout 2: Point of Impact** | [**burnout2-recompilation** (`timftw21/burnout2-recompilation`)](https://github.com/timftw21/burnout2-recompilation) | `Jogável` **(Release v1.5)** | `Inglês / Arcade` Corrida |
| **Black (2006)** | [**Black-2006-Recomp** (`portingpete/Black-2006-Recomp`)](https://github.com/portingpete/Black-2006-Recomp) | `Jogável` **(Release v0.9.1)** — Mouse e Teclado, FOV ajustável, D3D11/12 | `Nativo PT-BR` **Tradução e Dublagem PT-BR** disponíveis na comunidade |
| **Def Jam: Fight for NY** | [**DefJamFFNY-recomp** (`vyanhursky/DefJamFFNY-recomp`)](https://github.com/vyanhursky/DefJamFFNY-recomp) | `Jogável` **(Release v0.4.7)** — Windows, Linux e macOS | `Patch PT-BR` Possui tradução PT-BR da comunidade |
| **Jet Set Radio Future (JSRF)** | [**JSRF Unleashed** (`JuMatt/JetSetRadioFuture-Unleashed`)](https://github.com/JuMatt/JetSetRadioFuture-Unleashed) | `Jogável` **(Release v0.4.7)** — Port nativo x86-64 com D3D11 e XInput | `Inglês / Arcade` Em inglês |
| **Splinter Cell: Double Agent (Versão Original Xbox)** | [**SCDA-XBERecomp** (`TGP482/SCDA-XBERecomp`)](https://github.com/TGP482/SCDA-XBERecomp) | `Jogável` **(Release V1)** — Traz a aclamada versão da Montreal (superior à de PC/360) nativamente para Windows! | `Patch PT-BR` Tradução PT-BR em adaptação |
| **The Lord of the Rings: The Two Towers** | [**TooTawersRecomp** (`Gumpolas/TooTawersRecomp`)](https://github.com/Gumpolas/TooTawersRecomp) | `Jogável` **(Release v1.9.1)** | `Patch PT-BR` Possui tradução PT-BR |
| **Dead or Alive 3 & DOA Xtreme Beach Volleyball** | [**doa3-recomp** (`parkerallan/doa3-recomp`)](https://github.com/parkerallan/doa3-recomp)<br>[**doaxvb-re** (`NoRain211/doaxvb-re`)](https://github.com/NoRain211/doaxvb-re) | `Jogável` **Jogáveis (Releases v1.0.3 / v0.5.3)** | `Inglês / Arcade` Em inglês |
| **Midtown Madness 3** | [**midtown-madness-3-PC-Native** (`lakshya16157`)](https://github.com/lakshya16157/midtown-madness-3-PC-Native) | `Jogável` — D3D11 no Windows | `Inglês / Arcade` Em inglês |
| **RalliSport Challenge 2** | [**RallisportChallenge2-decomp** (`Mortify7612`)](https://github.com/Mortify7612/RallisportChallenge2-decomp) | `Jogável` — Vulkan no Windows/Linux | `Inglês / Arcade` Corrida |
| **X-Men Legends** | [**OpenXML1xbox** (`GTTeancum/OpenXML1xbox`)](https://github.com/GTTeancum/OpenXML1xbox) | `Jogável` **(Release v0.9.1b)** | `Patch PT-BR` Possui tradução PT-BR |
| **Conker: Live & Reloaded** | [**Conker-Recomped-and-Reloaded** (`Mabec-games`)](https://github.com/Mabec-games/Conker-Recomped-and-Reloaded) | `Jogável` **(`v1.4.2`)** — Até 240 FPS, Widescreen e Online | `Patch PT-BR` **Tradução e Dublagem PT-BR** (*joaohrs2*) |
| **Panzer Dragoon Orta & Futurama (2003)** | [**OrtaRecomp** (`wootbeer/ortarecomp`)](https://github.com/wootbeer/ortarecomp) / [**Futurama-Recomp** (`hiburn8`)](https://github.com/hiburn8/Futurama-The-Game-The-Recomp) | `Jogável` **Jogáveis (`v0.1.3` / `v1.8.0`)** | `Inglês / Arcade` Em inglês |
| **007: Nightfire, Everything or Nothing & Agent Under Fire** | [**nightfire-recomp**](https://github.com/hk21x/nightfire-recomp) / [**007eon-recomp**](https://github.com/hk21x/007eon-recomp) / [**007-agentunderfire**](https://github.com/hk21x/007-agentunderfire-recomp) | `Jogável` **Jogáveis (Releases Windows `hk21x`)** | `Inglês / Arcade` Em inglês |
| **Project Gotham Racing 1 & Forza Motorsport (2005)** | [**pgr1-recomp** (`hk21x`)](https://github.com/hk21x/pgr1-recomp) / [**redline-recompiled** (`DivxPlays`)](https://github.com/DivxPlays/redline-recompiled) | `Jogável` **Jogáveis (Forza 1 com até 144 FPS/DLSS)** | `Inglês / Arcade` Corrida |
| **Ninja Gaiden Black** | [**ngbrecomp** (`gamboozino/ngbrecomp`)](https://github.com/gamboozino/ngbrecomp) | `Em dev` | `Inglês / Arcade` Em inglês |
| **SSX Tricky** | [**OpenTricky** (`GiZcesi/OpenTricky`)](https://github.com/GiZcesi/OpenTricky) | `Em dev` | `Inglês / Arcade` Em inglês |
| **Spider-Man 2 (Console Version)** | [**SM2-Recomp** (`SirSymo/SM2-Recomp`)](https://github.com/SirSymo/SM2-Recomp) | `Em dev` (O verdadeiro Spider-Man 2 de consoles no PC!) | `Patch PT-BR` Possui tradução PT-BR na versão PS2/GC |
