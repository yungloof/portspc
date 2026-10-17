# 🚢 Guia: Ecossistema HarbourMasters (`libultraship`) no PC

Os projetos da equipe **HarbourMasters** são ports nativos de Nintendo 64 para PC (Windows, Linux/Steam Deck, macOS, Android e Switch) construídos sobre o motor **libultraship**. Eles oferecem:
- Taxa de quadros destravada (**60 FPS a 240+ FPS** com interpolação nativa)
- **Widescreen / Ultrawide** nativo (16:9, 21:9, 32:9)
- Suporte a controles modernos (Xbox, DualShock/DualSense com giroscópio, Switch Pro)
- Carregador de **Mods e Pacotes de Texturas HD** em formato `.o2r` / `.otr` (sem substituir arquivos do jogo!)
- Melhorias de qualidade de vida (QoL), Randomizers integrados e câmera livre no analógico direito.

> [!IMPORTANT]
> **Regra de Ouro para Tradução PT-BR:**
> **NÃO** use uma ROM de Nintendo 64 já traduzida (com patch `.ips`/`.bps`) para gerar o jogo! O extrator do HarbourMasters verifica o hash (SHA-1) da ROM original limpa. Gere o jogo usando a **ROM original limpa** e depois coloque o arquivo `.o2r` ou `.otr` da **Tradução PT-BR** dentro da pasta `mods/`!

---

## 📋 Tabela Resumo dos Ports HarbourMasters

| Port | Jogo Original | ROM Necessária (Limpa) | Status PT-BR | Onde Baixar a Tradução PT-BR |
| :--- | :--- | :--- | :--- | :--- |
| **[Ship of Harkinian](https://github.com/HarbourMasters/Shipwright/releases)** | *The Legend of Zelda: Ocarina of Time* | `USA v1.0` / `v1.1` / `v1.2` ou `PAL Debug MQ` (`.z64`) | 🟡 **Mod `.o2r`/`.otr` Completo** | [GameBanana - SoH Translations](https://gamebanana.com/mods/cats/17165) |
| **[2 Ship 2 Harkinian](https://github.com/HarbourMasters/2ship2harkinian/releases)** | *The Legend of Zelda: Majora's Mask* | `USA v1.0` (`baserom.us.rev0.z64`) | 🟡 **Mod `.o2r`/`.otr` Completo** | [GameBanana - 2S2H Mods](https://gamebanana.com/games/20369) |
| **[Starship](https://github.com/HarbourMasters/Starship/releases)** | *Star Fox 64* | `USA v1.1 (Rev A)` (`.z64`) | 🟡 **Mod de Texto e Dublagem PT-BR** | [GameBanana - Starship Mods](https://gamebanana.com/games/21291) |
| **[SpaghettiKart](https://github.com/HarbourMasters/SpaghettiKart/releases)** | *Mario Kart 64* | `USA v1.0` (`.z64`) | ⚪ **Mínimo de texto / Mods de UI** | [GameBanana - SpaghettiKart](https://gamebanana.com/games/21847) |
| **[Ghostship](https://github.com/HarbourMasters/Ghostship/releases)** | *Super Mario 64* | `USA v1.0` (`baserom.us.z64`) | 🟡 **Mods `.o2r`** *(ou use `sm64coopdx`)* | [GameBanana - Ghostship](https://gamebanana.com/games/21290) |
| **[Lighthouse](https://github.com/HarbourMasters/Lighthouse/releases)** | *Banjo-Kazooie* | `USA v1.0` (`.z64`) | 🟡 **Suporte a Mods `.o2r`** *(ou use `BanjoRecomp`)* | [GameBanana - Lighthouse](https://gamebanana.com/games/21848) |
| **[PaperBoat](https://github.com/HarbourMasters/PaperBoat/releases)** | *Paper Mario* | `USA v1.0` (`.z64`) | ⚪ **Em desenvolvimento (WIP)** | [GameBanana - PaperBoat](https://gamebanana.com/games/21849) |

---

## 🛠️ Passo a Passo de Instalação (Windows)

### 1. Ship of Harkinian (*Zelda: Ocarina of Time*)
1. Baixe a última versão para Windows (`SoH-*-Win64.zip`) em [HarbourMasters/Shipwright Releases](https://github.com/HarbourMasters/Shipwright/releases) (ou use o nosso script `Instalar-Ports.bat`).
2. Extraia o `.zip` em uma pasta dedicada (ex: `F:\Jogos\ShipOfHarkinian`).
3. Coloque a sua ROM limpa de *Ocarina of Time* (formato `.z64`) na mesma pasta do `soh.exe`.
4. Abra o `soh.exe`: ele vai extrair os assets da ROM e gerar o arquivo `oot.o2r` (ou `oot.otr`). Depois disso, você pode até apagar a ROM `.z64` para economizar espaço!
5. **Como deixar em PT-BR:**
   - Acesse a categoria de traduções no GameBanana: [SoH Complete Translations](https://gamebanana.com/mods/cats/17165).
   - Baixe o mod **PT-BR Translation** (por *LordeJabiraca*) ou **Pt-Br Ocarina of Time HD / Djipi's 3DS Experience** (por *EduardoA*, caso você use pacotes de texturas HD como *OoT Reloaded* ou *Djipi 3DS*).
   - Coloque o arquivo `.otr` ou `.o2r` baixado dentro da pasta `mods/` do seu Ship of Harkinian.
   - No jogo, pressione `Esc` (ou `F1`) para abrir a barra superior: em **Settings > Languages** (ou **Enhancements > Mods**), certifique-se de que o mod/idioma está ativo!

### 2. 2 Ship 2 Harkinian (*Zelda: Majora's Mask*)
1. Baixe a versão Windows (`2Ship-*-Win64.zip`) em [HarbourMasters/2ship2harkinian Releases](https://github.com/HarbourMasters/2ship2harkinian/releases).
2. Extraia em uma pasta e coloque sua ROM **USA v1.0** de *Majora's Mask* (SHA-1: `d6133ace5afaa0882cf214cf88daba39e266c078`).
3. Execute o `2ship.exe` para gerar o arquivo `mm.o2r`.
4. **Como deixar em PT-BR:**
   - Baixe o **Brazilian Portuguese translation mod** (portado por *Srchronotrigger* e *GhostlyDark* a partir da tradução do *Projeto BR*) ou o **Reloaded PT-BR HUD** em [GameBanana - 2S2H](https://gamebanana.com/games/20369).
   - Coloque o arquivo `.o2r`/`.otr` dentro da pasta `mods/` e reinicie o jogo.

### 3. Starship (*Star Fox 64*)
1. Baixe a release Windows em [HarbourMasters/Starship Releases](https://github.com/HarbourMasters/Starship/releases).
2. Coloque a ROM **Star Fox 64 USA v1.1 (Rev A)** (SHA-1: `09f0d105f476b00efa5303a3ebc42e60a7753b7a`) na pasta do jogo.
3. Clique em **Generate O2R** (ou execute o `starship.exe`).
4. **Como deixar em PT-BR (Legenda e Dublagem):**
   - Acesse [GameBanana - Starship](https://gamebanana.com/games/21291) e procure pelos mods de **Tradução PT-BR** e **Dublagem PT-BR**.
   - Jogue os arquivos `.o2r` na pasta `mods/`.

### 4. SpaghettiKart (*Mario Kart 64*) & Ghostship (*Super Mario 64*)
1. Baixe as builds oficiais nos respectivos repositórios ([SpaghettiKart](https://github.com/HarbourMasters/SpaghettiKart/releases) / [Ghostship](https://github.com/HarbourMasters/Ghostship/releases)).
2. Gere o arquivo `.o2r` usando a ROM **USA v1.0** limpa de cada jogo (`Mario Kart 64 (USA).z64` / `Super Mario 64 (USA).z64`).
3. Para mods de texturas HD, personagens e traduções de UI, coloque os pacotes `.o2r` na pasta `mods/`.

---

## 🐧 Notas para Linux e Steam Deck
- Todos os jogos da HarbourMasters possuem builds nativas para Linux em formato **AppImage** ou **Flatpak** nos links de Releases oficiais.
- No Steam Deck, basta baixar o `.AppImage`, marcar como executável (`chmod +x`) e adicionar como Jogo Não-Steam. A pasta `mods/` funciona exatamente da mesma maneira que no Windows!
