# 🇧🇷 Guia Completo de Traduções e Dublagens PT-BR para Ports de PC

Este guia reúne o passo a passo exato e os links de onde baixar e instalar as **traduções e dublagens em Português Brasileiro (PT-BR)** para os ports nativos de console, recompilações estáticas (`PS2Recomp`, `XenonRecomp`, `ReXGlue`, `N64Recomp`, `libultraship`, `DolRecomp`) e source ports listados neste repositório.

---

## 📊 Legenda dos 4 Tipos de Suporte a PT-BR

1. 🟢 **PT-BR Nativo / Oficial no Port:** O próprio executável do port ou a mídia original (como os discos brasileiros de PS4 e Xbox 360) já vem com Português Brasileiro integrado (basta escolher `Português (Brasil)` nas configurações).
2. 🧩 **Mod Direto no Port (`.otr`, `.o2r`, `.nrm`, Mod Manager):** A tradução é um arquivo leve que você coloca na pasta `mods/` do port (ou ativa no Mod Manager próprio) **sem precisar alterar sua ROM/ISO original**.
3. 🛠️ **Patch na ROM / ISO (`.bps`, `.xdelta`, `.ips`, `.pak`):** Você aplica a tradução na ROM/ISO (ou substitui os arquivos `.PAK`/`.WAD`) antes de o port extrair os assets.
4. ⚪ **Sem Tradução Conhecida / Textos Mínimos:** Jogos de corrida/luta arcade com pouquíssimo texto ou projetos recentes cuja tradução ainda está em andamento.

---

## 1. 🟢 Jogos com PT-BR 100% Nativo (Zero Configuração Extra!)

Estes projetos já trazem **Português Brasileiro** (muitos inclusive com **Dublagem Oficial Brasileira!**) direto de fábrica:

| Jogo / Projeto | O que está em PT-BR? | Como ativar |
| :--- | :--- | :--- |
| **God of War III Remastered (`gow3_pc`)** | 🎙️ **Dublagem Oficial Brasileira + Legendas e Menus PT-BR** | Use o dump da edição brasileira/latina (`CUSA01623`). O idioma já inicia em PT-BR nativamente! |
| **Shadow of the Colossus Remake (`ShadowOfTheColossus-PC`)** | 📝 **Legendas e Menus Oficiais em PT-BR** | Já incluso nativamente nos arquivos do Remake (`CUSA08809`). |
| **Bloodborne (`bloodborne_pc`)** | 🎙️ **Dublagem Oficial Brasileira + Legendas e Menus PT-BR** | Já incluso nativamente no dump de *Bloodborne GOTY* (`CUSA03173` / `CUSA00900`). |
| **MediEvil Remake (`medievil_2019_pc_port`)** | 🎙️ **Dublagem Oficial Brasileira + Legendas PT-BR** | Já incluso nativamente nos arquivos do jogo. |
| **Forza Horizon 1 (`pinyon-shift` / `FH1-ReImagined`) & Forza Horizon 2 (`fh2-recompiled`)** | 🎙️ **Dublagem Oficial Brasileira + Legendas e Menus PT-BR** | Já incluso no disco original de Xbox 360. |
| **Gears of War: Judgment (`gears-judgement-recomp`)** | 🎙️ **Dublagem Oficial Brasileira + Legendas PT-BR** | Já incluso no disco original de Xbox 360. |
| **Viva Piñata: Trouble in Paradise (`TiP-Recomp`)** | 🎙️ **Dublagem Oficial Brasileira + Textos PT-BR** | Já incluso no disco original de Xbox 360. |
| **Jak and Daxter 1, Jak II e Jak 3 (`OpenGOAL`)** | 📝 **Menus, Diálogos e Legendas 100% em PT-BR** | No menu de opções do jogo no **OpenGOAL**, mude o idioma de texto/legenda para **Português (Brasil)**. |
| **Silent Hill 2 (`Enhanced Edition`)** | 📝 **Menus, Cartas, Enigmas e Legendas 100% em PT-BR** | Durante o instalador oficial (`SH2EE Setup`), marque o pacote de idioma **Brazilian Portuguese**. |
| **The Legend of Dragoon (`Severed Chains`)** | 📝 **Tradução PT-BR Completa (+ Projeto de Dublagem)** | Parceria oficial com a equipe brasileira **Projeto Dragoon** (`projeto-dragoon.com.br`). |
| **Crash of the Titans (`MojoRecomp`)** | 📝 **Menus e Legendas 100% em PT-BR** | Criado pelo próprio tradutor brasileiro **OAleex**, com suporte nativo à sua tradução PT-BR! |
| **Diablo 1 + Hellfire (`DevilutionX`)** | 📝 **100% em PT-BR** (+ pacote de dublagem PT-BR opcional) | Selecione `Português (Brasil)` em *Settings > Language*. |
| **AM2R (Another Metroid 2 Remake)** | 📝 **Menus e Logs 100% em PT-BR** | Selecione `Português` nas opções de idioma do jogo. |
| **OpenRCT2 / OpenTTD / CorsixTH / fheroes2 / VCMI** | 📝 **100% em PT-BR** | Selecione `Portuguese (Brazilian)` nas opções do launcher/jogo. |
| **Grim Fandango / Full Throttle / The Dig (`ScummVM`)** | 🎙️ **Dublagem Clássica Oficial da Brasoft em PT-BR!** | Use os CDs brasileiros originais distribuídos pela Brasoft nos anos 90. |

---

## 2. 🧩 Como Instalar Mods PT-BR nos Ports de N64, Xbox 360 e GameCube/Wii U

### A. Ship of Harkinian (Ocarina of Time) & 2Ship2Harkinian (Majora's Mask)
1. Gere o seu arquivo base normalmente com uma ROM original (**sem patch**) do jogo.
2. Baixe o pacote de tradução PT-BR no **GameBanana**:
   * **Ocarina of Time (SoH):** [Tradução PT-BR `.otr` / `.o2r`](https://gamebanana.com/mods/473895)
   * **Majora's Mask (2S2H):** [Tradução PT-BR `.o2r`](https://gamebanana.com/mods/542278)
3. Coloque o arquivo `.otr` ou `.o2r` baixado dentro da pasta `mods/` (localizada junto ao executável do port).
4. Abra o jogo, pressione `Esc` (ou `F1`) para abrir a barra superior -> *Settings* -> **Languages** e ative a opção do mod PT-BR (ou reinicie o jogo com o mod ativo).

### B. Zelda64: Recompiled & Banjo: Recompiled (`N64Recomp`)
Os projetos baseados no `N64Recomp` suportam mods nativos no formato **`.nrm`** (basta arrastar e soltar na tela de Mods do jogo!):
* **Zelda64: Recompiled (Majora's Mask):** Baixe o [Mod `.nrm` PT-BR no GameBanana (#678789)](https://gamebanana.com/mods/678789) e clique em **Mods -> Install Mod** no menu inicial.
* **Banjo: Recompiled (Banjo-Kazooie):** Baixe o [Mod `.nrm` PT-BR no GameBanana (#678790)](https://gamebanana.com/mods/678790) e instale pelo menu **Mods** do jogo.

### C. Xbox 360 Recomps (`UnleashedRecomp`, `re:Blue`, `LostOdysseyRecomp`, `Fable2Recomp`, `DownpourRecomp`)
* **Sonic Unleashed (`UnleashedRecomp`):** Use o **HedgeModManager** para instalar o mod **Sonic Braleashed (Tradução PT-BR)** e a **Dublagem Projeto Lobão** disponíveis na seção [Sonic Unleashed do GameBanana](https://gamebanana.com/games/6475).
* **Blue Dragon (`re:Blue`):** Compatível com a tradução 100% PT-BR feita por **LeandroCiC** (disponível no *Romhacking.net.br* e *João13 Traduções*).
* **Lost Odyssey (`LostOdysseyRecomp`):** Possui pacote completo de tradução PT-BR (incluindo os contos "Mil Anos de Sonhos" e dublagem IA opcional) feito especificamente para o *LostOdysseyRecomp*.
* **Fable II (`Fable-2-Recomp`):** Compatível com a localização PT-BR da edição GOTY liderada por **Dio Carvalho** (GitHub / Romhacking.net.br).
* **Silent Hill: Downpour (`DownpourRecomp`), Dante's Inferno (`hells-gate-recomp`) & Condemned 2 (`Condemned2Recomp`):** Compatíveis com as traduções de Xbox 360 disponíveis na **Tribo Gamer** e **João13 Traduções**.

### D. GameCube & Wii U Ports (`ZeldaWWHDRecomp`, `Dusklight`, `Nebula`, `sms-pc-port`)
* **The Wind Waker HD (`ZeldaWWHDRecomp` / `SwitchWakerHD`):** Baixe a tradução PT-BR de Wii U da equipe **Triforce Heroes Traduções** e aplique na pasta `content/` do seu dump do Wii U.
* **Twilight Princess (`Dusklight`):** Compatível com pacotes de localização e com a tradução PT-BR de GameCube (Central de Traduções / Tribo Gamer).
* **Super Mario Galaxy (`Nebula`) & Mario Kart Wii (`WiiCompiled`):** Compatíveis com as traduções PT-BR de Wii dos grupos *Brazilian Warriors / Nintendo BR* e *Guilherme Dias* (*João13 Traduções*).
* **Super Mario Sunshine (`sms-pc-port`):** Compatível com a tradução PT-BR de GameCube (geralmente selecionando o idioma Espanhol nas opções do jogo após aplicar o patch).

---

## 3. 🛠️ Como Usar ISOs e ROMs Traduzidas no PS2, PS1 e SNES

### A. Recompilações de PS2 (`PS2Recomp`) — *God of War 1 & 2, Shadow of the Colossus, Urban Reign, Burnout 3*
Como os projetos baseados em `PS2Recomp` traduzem o executável principal (`SCUS`/`SLUS`) para C++ nativo, mas **carregam os arquivos de dados (`.PAK`, `.WAD`, `.DAT`, `.STR`) diretamente da ISO**:
* **God of War 1 (`god-of-war-recomp`) & God of War II (`gow2-recomp`):** Você pode substituir os arquivos `GOW1.PAK` / `GOW2.PAK` (ou usar a ISO `SCUS-97399` / `SCUS-97481` modificada) pela **Tradução PT-BR v4.4 do OAleex Traduções** ou pela **Dublagem PT-BR da STR Brasil**!
* **Burnout 3 (`burnout3-pc`), Urban Reign (`urban-reign-recomp`), Castlevania: Curse of Darkness (`noble-archimedes`) e Resident Evil Code: Veronica X (`recvx-decomp`):** Compatíveis com as ISOs traduzidas em PT-BR disponíveis no *João13 Traduções*, *Romhacking.net.br* e *Central de Traduções*.

### B. Recompilações e Ports de PS1 (`PSXRecomp`, `SymphonyRecomp`, `REDRIVER2`, `Classic REbirth`)
* **Castlevania: Symphony of the Night (`SymphonyRecomp`):** Aceita a imagem `.bin/.cue` americana (`SLUS-00067`) com as clássicas traduções e dublagens PT-BR aplicadas!
* **Driver 2 (`REDRIVER2`) & Legacy of Kain: Soul Reaver (`soul-reaver-recomp`):** Aceitam os CDs com as lendárias **Dublagens Brasileiras de PS1**!
* **Resident Evil 1, 2, 3 & Dino Crisis 1, 2 (`Classic REbirth` / `Project-RE-Visited-RE3`):** Possuem pacotes completos de legendas PT-BR e dublagens brasileiras.

### C. Ports Nativos de SNES (`zelda3`, `smw`, `snesrecomp`)
* **Zelda: A Link to the Past (`snesrev/zelda3`):** Ao rodar o extrator de assets, você pode passar uma ROM já traduzida em PT-BR ou configurar o `zelda3.ini` para carregar o pacote de diálogos traduzidos!
* **Super Mario World (`snesrev/smw`), Super Metroid (`SuperMetroidRecomp`), DKC 1/2/3 (`DKCRecomp`) e International Superstar Soccer Deluxe (`issd-native`):** Compatíveis com patches de tradução PT-BR na ROM.

---

## 🌐 Onde Encontrar Traduções e Dublagens Confiáveis no Brasil
* [**GameBanana**](https://gamebanana.com/) — Principal hub de mods `.otr`, `.o2r` e `.nrm` para ports de N64, Xbox 360 e Sonic.
* [**Fórum Unificado de Romhacking e Tradução (FURT / Romhacking.net.br)**](https://www.romhacking.net.br/) — Maior arquivo histórico de patches `.ips`, `.bps` e `.xdelta` para ROMs e ISOs no Brasil.
* [**Central de Traduções**](https://www.centraldetraducoes.net.br/) & [**Tribo Gamer**](https://tribogamer.com/traducoes/) — Principais portais para traduções de PC, PS2, PS3, Xbox 360 e GameCube.
* [**OAleex Traduções**](https://oaleex.blogspot.com/) — Referência em traduções de *God of War 1 & 2*, *Crash* e criador do *MojoRecomp*.
