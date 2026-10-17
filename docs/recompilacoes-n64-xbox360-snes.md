# ⚡ Guia: Recompilações Estáticas (`N64Recomp`, `XenonRecomp`, `snesrecomp`)

A **Recompilação Estática** é a revolução mais recente na preservação de jogos: em vez de levar anos descompilando manualmente um jogo linha por linha, ferramentas como o **N64Recomp** (criado por *Mr-Wiseguy*) e o **XenonRecomp** (criado pela equipe *hedge-dev* para Xbox 360) convertem o binário original do console diretamente em código C++ nativo de PC, com renderizadores modernos em **Direct3D 12 / Vulkan** (como o **RT64**, com suporte até a Ray Tracing).

---

## 📋 Tabela Completa de Jogos Recompilados

| Projeto | Jogo Original | Plataforma Base | Sistemas | Status PT-BR | Onde Baixar Mod PT-BR / Detalhes |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **[Unleashed Recompiled](https://github.com/hedge-dev/UnleashedRecomp/releases)** | *Sonic Unleashed* | Xbox 360 | Windows, Linux | 🟢 **UI Nativa PT-BR** + 🟡 **Mod Texto/Dublagem** | Mod **Sonic Braleashed** (Legenda + Dublagem PT-BR via HedgeModManager) no [GameBanana](https://gamebanana.com/games/6465) |
| **[Zelda 64: Recompiled](https://github.com/Zelda64Recomp/Zelda64Recomp/releases)** | *Zelda: Majora's Mask* (e *OoT* em expansão) | Nintendo 64 | Windows, Linux, macOS | 🟡 **Mod `.nrm` Completo** | **Tradução Pt-Br Majora's Mask Recompiled** (por *EduardoA*) no [GameBanana](https://gamebanana.com/games/20420) / [Thunderstore](https://thunderstore.io/c/zelda-64-recompiled/) |
| **[Banjo: Recompiled](https://github.com/BanjoRecomp/BanjoRecomp/releases)** | *Banjo-Kazooie* | Nintendo 64 | Windows, Linux, macOS | 🟡 **Mod `.nrm` Completo** | **Banjo-Kazooie: Recomp PtBr** no [GameBanana](https://gamebanana.com/games/21188) / [Thunderstore](https://thunderstore.io/c/banjo-recompiled/) |
| **[Dinosaur Planet: Recompiled](https://github.com/DinosaurPlanetRecomp/dino-recomp/releases)** | *Dinosaur Planet* (Protótipo Rare 2000) | Nintendo 64 | Windows, Linux, macOS | ⚪ **Sem PT-BR** (Suporta mods `.nrm`) | Mods de restauração no [Thunderstore](https://thunderstore.io/c/dinosaur-planet-recompiled/) |
| **[Goemon 64: Recompiled](https://github.com/klorfmorf/Goemon64Recomp/releases)** | *Mystical Ninja Starring Goemon* | Nintendo 64 | Windows, Linux, macOS, Android | ⚪ **Sem mod `.nrm` PT-BR ainda** | Requer ROM USA v1.0 limpa |
| **[GoldenEye 007 Recompiled](https://github.com/cblock85/GoldenEye64Recomp)** | *GoldenEye 007* | Nintendo 64 | Windows, Linux | ⚪ **Sem PT-BR no port** | Recomp N64 + RT64 |
| **[Conker's Bad Fur Day: Recompiled](https://github.com/sciaschi/CBFD-Recompiled/releases)** | *Conker's Bad Fur Day* | Nintendo 64 | Windows, Linux, Android | ⚪ **Sem mod `.nrm` PT-BR ainda** | Existe tradução de ROM N64, aguardando port para mod `.nrm` |
| **[DKR-R (Diddy Kong Racing Recomp)](https://github.com/ThatGuyMcd/DKR-R/releases)** | *Diddy Kong Racing* | Nintendo 64 | Windows, Linux | ⚪ **Sem PT-BR** | Recomp N64 + RT64 |
| **[Donkey Kong 64 Recompiled](https://github.com/Rainchus/Donkey-Kong-64-Recompiled/releases)** | *Donkey Kong 64* | Nintendo 64 | Windows, Linux | ⚪ **Sem PT-BR** | Recomp N64 + RT64 |
| **[Wave Race 64: Recompiled](https://github.com/danielgomesvieira2000/wave-race-64-recomp/releases)** | *Wave Race 64* | Nintendo 64 | Windows, Linux, macOS | ⚪ **Não requer (Corrida Arcade)** | Mantido pelo dev brasileiro Daniel Gomes Vieira; usa ROM USA Rev A (v1.1) |
| **[Pilotwings 64: Recompiled](https://github.com/danielgomesvieira2000/pilotwings-64-recomp/releases)** | *Pilotwings 64* | Nintendo 64 | Windows, Linux, macOS | ⚪ **Sem PT-BR** | Requer ROM USA v1.0 |
| **[Beetle Adventure Racing! Recomp](https://github.com/danielgomesvieira2000/beetle-adventure-racing-recomp/releases)** | *Beetle Adventure Racing!* | Nintendo 64 | Windows | ⚪ **Não requer (Corrida Arcade)** | Requer ROM USA |
| **[Road Rash 64 Recompiled](https://github.com/linkssy2/RoadRash64Recompiled/releases)** | *Road Rash 64* | Nintendo 64 | Windows, Linux | ⚪ **Não requer (Corrida Arcade)** | Requer ROM USA |
| **[Banjo-Tooie Recompiled](https://github.com/some-scurvy-dog/BanjoTooieRecompiled/releases)** | *Banjo-Tooie* | Nintendo 64 | Windows (Alpha) | ⚪ **WIP (Alpha)** | Requer ROM USA |
| **[DKC 1 / 2 / 3 Recompiled](https://github.com/elliotttate/DKC1Recomp)** | *Donkey Kong Country 1, 2 e 3* | SNES | Windows, Linux, macOS | ⚪ **Não requer (Plataforma)** | Links: [DKC1](https://github.com/elliotttate/DKC1Recomp) · [DKC2](https://github.com/elliotttate/DKC2Recomp) · [DKC3](https://github.com/elliotttate/DKC3Recomp) |
| **[F-Zero SNES Recompiled](https://github.com/mstan/FZeroSNESRecomp/releases)** | *F-Zero* | SNES | Windows, Linux, macOS | ⚪ **Não requer (Corrida Arcade)** | Widescreen + Mode 7 em HD |
| **[Wind Waker HD Recompiled](https://github.com/ZeldaWWHDRecomp/ZeldaWWHDRecomp)** | *The Legend of Zelda: The Wind Waker HD* | Wii U | Windows, Linux | 🔵 **Compatível com Tradução Wii U** | Substitua os arquivos `.bmg` da tradução PT-BR de Cemu/Wii U na pasta `content/` |
| **[Nebula (Super Mario Galaxy)](https://github.com/keepvaibin/nebula)** | *Super Mario Galaxy* | Wii | Windows (D3D12) | 🔵 **Compatível com arquivos PT-BR de Wii** | Usa dump extraído da ISO de Wii |
| **[Fukami (Ridge Racer V)](https://github.com/danisandoval/fukami)** | *Ridge Racer V* | PlayStation 2 | Windows, Linux, macOS | ⚪ **Não requer (Corrida Arcade)** | Requer ISO USA de PS2 |
| **[Midnight Club: LA Recompiled](https://github.com/holdmysocks/mcla-recomp)** | *Midnight Club: Los Angeles Complete Edition* | Xbox 360 | Windows | ⚪ **Em desenvolvimento (WIP)** | Também veja [Xbox360-Native-Ports](https://github.com/CrownParkComputing/Xbox360-Native-Ports) |
| **[Metroid Prime Hunters Recomp](https://github.com/mstan/MetroidPrimeHuntersRecomp/releases)** | *Metroid Prime Hunters* | Nintendo DS | Windows, Linux | ⚪ **Sem PT-BR no port** | Mira no mouse + Tela única Widescreen + Online Wiimmfi |
| **[TriAevum (Ocarina of Time 3D)](https://github.com/coccofresco/TriAevum/releases)** | *Zelda: Ocarina of Time 3D* | Nintendo 3DS | Windows (Vulkan) | 🔵 **Compatível com RomFS PT-BR** | Aceita a tradução PT-BR de OoT 3D aplicada na pasta RomFS extraída |

---

## 🛠️ Como Instalar os Principais Recomps e suas Traduções PT-BR

### 1. Unleashed Recompiled (*Sonic Unleashed*) + Dublagem/Legenda PT-BR
O *Unleashed Recompiled* transforma a versão de Xbox 360 de *Sonic Unleashed* em um jogo nativo de PC com suporte a 60–240+ FPS, Ultrawide, resolução 4K e carregamento instantâneo.
1. Baixe o instalador `UnleashedRecomp-Windows.zip` em [hedge-dev/UnleashedRecomp Releases](https://github.com/hedge-dev/UnleashedRecomp/releases).
2. Abra o executável: o assistente de instalação **já possui interface em Português**!
3. Aponte para a sua ISO/arquivos de *Sonic Unleashed* (Xbox 360) + o arquivo de **Title Update (TU)** (e DLCs, se quiser). Depois que o instalador copiar os arquivos necessários para a pasta do jogo, **você pode apagar a ISO original** para economizar espaço no seu disco de 200GB!
4. **Como instalar a Tradução e Dublagem PT-BR (*Sonic Braleashed*):**
   - Baixe o [HedgeModManager](https://github.com/thesupersonic16/HedgeModManager/releases) (versão compatível com Unleashed Recompiled).
   - No GameBanana ([seção Sonic Unleashed](https://gamebanana.com/games/6465)), baixe o mod **Sonic Braleashed** (da equipe *Cultura Sonic*, com legendas adaptadas e dublagem em português) e/ou o **UnleasHD PTBR**.
   - Ative o mod no HedgeModManager e inicie o jogo!

### 2. Zelda 64: Recompiled (*Majora's Mask*) & Banjo: Recompiled (*Banjo-Kazooie*)
Ambos usam o motor **N64Recomp + RT64** e possuem o sistema de mods `.nrm` (que permite instalar traduções e texturas HD apenas arrastando o arquivo para a janela do jogo!).
1. Baixe a versão Windows de [Zelda64Recomp](https://github.com/Zelda64Recomp/Zelda64Recomp/releases) ou [BanjoRecomp](https://github.com/BanjoRecomp/BanjoRecomp/releases).
2. Ao abrir pela primeira vez, selecione a sua ROM **USA v1.0 limpa** (`.z64`).
3. **Como deixar em PT-BR:**
   - Para **Majora's Mask**: Baixe a **Tradução Pt-Br Majora's Mask Recompiled** (por *EduardoA*) no [GameBanana](https://gamebanana.com/games/20420) ou [Thunderstore](https://thunderstore.io/c/zelda-64-recompiled/).
   - Para **Banjo-Kazooie**: Baixe o **Banjo-Kazooie: Recomp PtBr** no [GameBanana](https://gamebanana.com/games/21188) ou [Thunderstore](https://thunderstore.io/c/banjo-recompiled/).
   - Na tela inicial do jogo, clique na aba **Mods** e arraste o arquivo `.nrm` da tradução para dentro da janela (ou copie para a pasta `mods/` dentro de `%LOCALAPPDATA%\Zelda64Recompiled\mods` / `%LOCALAPPDATA%\BanjoRecompiled\mods`).
   - Ambos os mods PT-BR são totalmente compatíveis com os pacotes de texturas HD (*MM Reloaded* e *BK Reloaded*)!
