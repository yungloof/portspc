# 🎮 Guia: Descompilações e Ports Nativos de Console (PS1, PS2, N64, SNES, GBC, GC)

Estes projetos são frutos de engenharia reversa completa (descompilação manual do código de máquina original para C, C++ ou GOAL), gerando executáveis nativos de PC com desempenho superior a qualquer emulador.

---

## 📋 Tabela Completa de Descompilações e Ports Nativos

| Projeto | Jogo Original | Plataforma Base | Sistemas | Status PT-BR | Como ter PT-BR / Onde Baixar |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **[OpenGOAL (`jak-project`)](https://opengoal.dev/)** | *Jak & Daxter: The Precursor Legacy*, *Jak II* e *Jak 3* | PlayStation 2 | Windows, Linux, macOS | 🟢 **100% Nativo no Port!** | Já vem embutido oficialmente no OpenGOAL! Basta escolher **Português (Brasil)** nas opções do jogo. |
| **[sm64coopdx](https://github.com/coop-deluxe/sm64coopdx/releases)** / **[Render96ex](https://github.com/Render96/Render96ex)** | *Super Mario 64* | Nintendo 64 | Windows, Linux, macOS, Android | 🟡 **Mod de Texto e Dublagem PT-BR** | [Localização Brasileira SM64COOPDX (GameBanana)](https://gamebanana.com/mods/505265) + Mods de Dublagem PT-BR |
| **[TRX (`Tomb1Main` / `Tomb2Main`)](https://github.com/LostArtefacts/TRX/releases)** / **[OpenLara](https://github.com/XProger/OpenLara)** | *Tomb Raider I, II e III* | PS1 / PC | Windows, Linux, macOS | 🔵 **Compatível com Tradução/Dublagem PC** | Substitua os arquivos de texto/áudio na pasta `data/` e `audio/` pelas traduções clássicas de PC |
| **[Severed Chains](https://github.com/Legend-of-Dragoon-Modding/Severed-Chains/releases)** | *The Legend of Dragoon* (4 Discos) | PlayStation 1 | Windows, Linux, macOS | 🟡 **Mod em adaptação (Projeto Dragoon)** | Motor suporta scripts traduzidos sem limite de ponteiros do PS1 ([Site Oficial](https://legendofdragoon.org/projects/severed-chains/)) |
| **[REDRIVER2](https://github.com/OpenDriver2/REDRIVER2/releases)** | *Driver 2* (2 Discos) | PlayStation 1 | Windows, Linux | 🔵 **Compatível com arquivos PT-BR da ISO** | Extrai tabelas de texto e áudio das ISOs de PS1 |
| **[CTR-Native / CTR-ModSDK](https://github.com/CTR-tools/ctr-native)** | *Crash Team Racing* | PlayStation 1 | Windows, Linux | ⚪ **Requer ISO NTSC-U limpa** | Existem traduções/dublagens para a ISO de PS1, port nativo exige NTSC-U |
| **[WipEout Phantom Edition](https://github.com/wipeout-phantom-edition/wipeout-phantom-edition/releases)** | *WipEout (1995)* | PlayStation 1 | Windows, Linux, macOS | ⚪ **Não requer (Corrida Futurista)** | Requer arquivos `.bin`/`.cue` da versão PS1 USA |
| **[Perfect Dark PC Port](https://github.com/fgsfdsfgs/perfect_dark/releases)** | *Perfect Dark* | Nintendo 64 | Windows, Linux, macOS, Android | ⚪ **Sem PT-BR oficial no port** | Requer ROM `pd.ntsc-final.z64` (USA v1.1) na pasta `data/` |
| **[GoldenEye 007 PC Port](https://github.com/jkdansereau/goldeneye-pc-port)** | *GoldenEye 007* | Nintendo 64 | Windows, Linux, macOS | ⚪ **WIP (Decomp 100%)** | Baseado na descompilação `n64decomp/007` |
| **[Golden Balloon](https://github.com/akratch/goldenballoon)** | *Diddy Kong Racing* | Nintendo 64 | Windows, Linux, macOS, Web | ⚪ **Sem PT-BR no port** | Requer ROM USA v1.1 |
| **[Super Mario 64 DS PC (`tangOS`)](https://tangos.dev/)** | *Super Mario 64 DS* | Nintendo DS | Windows, Linux | ⚪ **Sem PT-BR no port** | Requer ROM USA `.nds` ([Repo mirror](https://github.com/tangosdev/sm64ds-decomp)) |
| **[Zelda 3 (`snesrev/zelda3`)](https://github.com/snesrev/zelda3)** | *The Legend of Zelda: A Link to the Past* | SNES | Windows, Linux, macOS, Switch, Android | 🟡 **Script `dialogue.txt` / Assets PT-BR** | Gere o port com a ROM USA limpa e use o arquivo `dialogue.txt` / `zelda3_assets.dat` traduzido pela comunidade BR nas [Discussions](https://github.com/snesrev/zelda3/discussions) |
| **[Super Metroid (`snesrev/sm`)](https://github.com/snesrev/sm)** | *Super Metroid* | SNES | Windows, Linux, macOS | ⚪ **Não requer (Apenas intro)** | Requer ROM limpa `sm.smc` (USA/JP) |
| **[Super Mario World (`snesrev/smw`)](https://github.com/snesrev/smw)** | *Super Mario World* | SNES | Windows, Linux, macOS | ⚪ **Não requer** | Requer ROM limpa `smw.sfc` (USA) |
| **[Zelda: Link's Awakening DX HD](https://github.com/BigheadSMZ/Zelda-LA-DX-HD-Updated/releases)** | *Zelda: Link's Awakening DX* | Game Boy Color | Windows, Linux (Proton), Android | 🔵 **Arquivos de Idioma Abertos** | Textos ficam em `Data/Languages/`, permitindo substituição direta pelo pacote PT-BR da comunidade |
| **[RSDKv5 (Sonic Mania Decomp)](https://github.com/RSDKModding/Sonic-Mania-Decompilation/releases)** | *Sonic Mania Plus* | PC / Consoles | Windows, Linux, macOS, Android, Switch | 🟡 **Mod Completo PT-BR** | **Sonic Mania Plus - PT-BR Translation Mod** na pasta `mods/` ([GameBanana](https://gamebanana.com/games/6059)) |
| **[RSDKv4 (Sonic 1 Forever / Sonic 2 Absolute)](https://github.com/RSDKModding/RSDKv4-Decompilation/releases)** | *Sonic the Hedgehog 1 & 2 (2013)* | Mobile -> PC | Windows, Linux, Android | 🟡 **Mod Completo PT-BR** | Requer `Data.rsdk` das versões mobile; mods PT-BR na pasta `mods/` |
| **[RSDKv3 (Sonic CD Restored)](https://github.com/RSDKModding/RSDKv3-Decompilation/releases)** | *Sonic CD (2011)* | Mobile/PC | Windows, Linux, Android | 🟡 **Mod Completo PT-BR** | Requer `Data.rsdk`; suporta mods PT-BR na pasta `mods/` |
| **[Open Nectar (`projectPiki`)](https://github.com/projectPiki/pikmin)** | *Pikmin* | GameCube | Windows, Linux | ⚪ **WIP (Decomp 100%)** | Port nativo experimental a partir da ISO USA de GameCube |
| **[Dusk (`zeldaret/tp`)](https://github.com/zeldaret/tp)** | *Zelda: Twilight Princess* | GameCube | Windows, Linux | 🔵 **Compatível com `.bmg` PT-BR de GC** | Decomp 100% concluída; port nativo lê os arquivos de mensagem `.bmg` extraídos da ISO |

---

## 🛠️ Destaques: Como Instalar e Ativar o PT-BR

### 1. OpenGOAL (*Jak & Daxter 1, Jak II e Jak 3*) — PT-BR 100% Nativo!
O **OpenGOAL** é um dos projetos mais impressionantes já feitos: a equipe recriou o compilador da linguagem *GOAL* (criada pelo fundador da Naughty Dog) para x86-64.
1. Baixe o **OpenGOAL Launcher** para Windows em [opengoal.dev](https://opengoal.dev/) (ou via nosso `Instalar-Ports.bat`).
2. Instale o Launcher, escolha *Jak and Daxter: The Precursor Legacy*, *Jak II* ou *Jak 3* e aponte para o seu arquivo `.iso` de PS2.
3. Depois que o OpenGOAL extrair e compilar o jogo (leva cerca de 1 a 2 minutos), **você pode apagar a `.iso` de PS2** para liberar vários GBs do seu disco `F:`!
4. **Como deixar em PT-BR:**
   - Não precisa baixar nada! Abra o jogo, vá em **Opções > Opções de Jogo > Idioma das Legendas / Idioma do Texto** e selecione **Português (Brasil)**.

### 2. Super Mario 64 (`sm64coopdx`) — Co-op Online + PT-BR + Dublagem
O **sm64coopdx** é o port nativo mais ativo e fácil de usar de *Super Mario 64* no Windows (funciona tanto single-player quanto co-op online para até 16 jogadores sem precisar abrir portas no roteador!).
1. Baixe o `sm64coopdx` para Windows em [coop-deluxe/sm64coopdx Releases](https://github.com/coop-deluxe/sm64coopdx/releases).
2. Ao abrir pela primeira vez, arraste sua ROM `Super Mario 64 (USA).z64` para a janela do jogo.
3. **Como deixar em PT-BR:**
   - Baixe a [Localização Brasileira para SM64COOPDX no GameBanana](https://gamebanana.com/mods/505265) e/ou mods de **Dublagem PT-BR**.
   - Coloque os arquivos na pasta `mods/` ou `lang/` dentro da pasta do `sm64coopdx` (ou em `%APPDATA%\sm64coopdx`).
