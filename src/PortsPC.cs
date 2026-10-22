using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PortsPCLauncher {
    public class GameItem {
        public string id { get; set; }
        public string name { get; set; }
        public string game { get; set; }
        public string platform { get; set; }
        public string category { get; set; }
        public string github_repo { get; set; }
        public string website { get; set; }
        public string asset_regex { get; set; }
        public bool windows { get; set; }
        public bool linux { get; set; }
        public string requires { get; set; }
        public string ptbr_status { get; set; }
        public string ptbr_details { get; set; }
        public string ptbr_url { get; set; }

        public bool IsInstalled() {
            string basePath = @"F:\Jogos\PortsPC";
            if (!Directory.Exists(@"F:\")) {
                basePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Jogos");
            }
            string gamePath = System.IO.Path.Combine(basePath, id);
            return Directory.Exists(gamePath);
        }

        public string GetInstallDir() {
            string basePath = @"F:\Jogos\PortsPC";
            if (!Directory.Exists(@"F:\")) {
                basePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Jogos");
            }
            return System.IO.Path.Combine(basePath, id);
        }
    }

    public class MainWindow : Window {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private List<GameItem> allGames = new List<GameItem>();
        private List<GameItem> filteredGames = new List<GameItem>();
        private GameItem selectedGame = null;

        private TextBox searchBox;
        private StackPanel cardsPanel;
        private TextBlock statsText;
        private Border detailPanel;
        private ScrollViewer detailScroll;

        // Detail elements
        private TextBlock detailTitle;
        private TextBlock detailCategory;
        private TextBlock detailRequires;
        private Border detailPtbrBadge;
        private TextBlock detailPtbrBadgeText;
        private TextBlock detailPtbrText;
        private Button btnInstall;
        private Button btnOpenFolder;
        private Button btnWebsite;
        private Button btnPtbr;
        private ProgressBar progressBar;
        private TextBlock progressStatus;

        private string currentFilter = "Todos";
        private bool onlyPtbr = false;

        public MainWindow() {
            Title = "PortsPC Launcher — O Catálogo Definitivo de Ports para PC";
            Width = 1180;
            Height = 740;
            MinWidth = 980;
            MinHeight = 600;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Background = new SolidColorBrush(Color.FromRgb(11, 15, 25)); // #0B0F19

            SourceInitialized += (s, e) => {
                try {
                    IntPtr hwnd = new WindowInteropHelper(this).Handle;
                    int darkMode = 1;
                    DwmSetWindowAttribute(hwnd, 20, ref darkMode, sizeof(int));
                    DwmSetWindowAttribute(hwnd, 19, ref darkMode, sizeof(int));
                } catch { }
            };

            BuildUI();
            LoadCatalog();
        }

        private void BuildUI() {
            var mainGrid = new Grid();
            mainGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto }); // Header
            mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // Content

            // 1. Header & Filters
            mainGrid.Children.Add(CreateHeaderBar());
            Grid.SetRow(mainGrid.Children[0], 0);

            // 2. Body Grid (Cards List on Left, Details on Right)
            var bodyGrid = new Grid();
            bodyGrid.Margin = new Thickness(16, 0, 16, 16);
            bodyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            bodyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(420) });

            // Left side: Cards List inside ScrollViewer
            var leftStack = new Grid();
            leftStack.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            leftStack.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            statsText = new TextBlock {
                Text = "Carregando catálogo...",
                Foreground = new SolidColorBrush(Color.FromRgb(148, 163, 184)), // #94A3B8
                FontSize = 13,
                Margin = new Thickness(4, 0, 0, 8)
            };
            leftStack.Children.Add(statsText);
            Grid.SetRow(statsText, 0);

            var scroll = new ScrollViewer {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled
            };
            cardsPanel = new StackPanel();
            scroll.Content = cardsPanel;
            leftStack.Children.Add(scroll);
            Grid.SetRow(scroll, 1);

            bodyGrid.Children.Add(leftStack);
            Grid.SetColumn(leftStack, 0);

            // Right side: Details Panel
            bodyGrid.Children.Add(CreateDetailPanel());
            Grid.SetColumn(bodyGrid.Children[1], 1);

            mainGrid.Children.Add(bodyGrid);
            Grid.SetRow(bodyGrid, 1);

            Content = mainGrid;
        }

        private UIElement CreateHeaderBar() {
            var headerBorder = new Border {
                Background = new SolidColorBrush(Color.FromRgb(17, 24, 39)), // #111827
                BorderBrush = new SolidColorBrush(Color.FromRgb(31, 41, 55)), // #1F2937
                BorderThickness = new Thickness(0, 0, 0, 1),
                Padding = new Thickness(16, 12, 16, 12),
                Margin = new Thickness(0, 0, 0, 14)
            };

            var headerStack = new StackPanel { Orientation = Orientation.Vertical };

            // Top Row: Logo & Search
            var topRow = new Grid();
            topRow.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            topRow.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var logoStack = new StackPanel { Orientation = Orientation.Horizontal, VerticalAlignment = VerticalAlignment.Center };
            var title = new TextBlock {
                Text = "🎮 PortsPC",
                Foreground = Brushes.White,
                FontSize = 20,
                FontWeight = FontWeights.Bold,
                VerticalAlignment = VerticalAlignment.Center
            };
            var badge = new Border {
                Background = new SolidColorBrush(Color.FromRgb(79, 70, 229)), // Indigo #4F46E5
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(6, 2, 6, 2),
                Margin = new Thickness(8, 0, 16, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Child = new TextBlock {
                    Text = "LAUNCHER",
                    Foreground = Brushes.White,
                    FontSize = 10,
                    FontWeight = FontWeights.Bold
                }
            };
            logoStack.Children.Add(title);
            logoStack.Children.Add(badge);
            topRow.Children.Add(logoStack);
            Grid.SetColumn(logoStack, 0);

            // Search Box
            var searchBorder = new Border {
                Background = new SolidColorBrush(Color.FromRgb(30, 41, 59)), // #1E293B
                BorderBrush = new SolidColorBrush(Color.FromRgb(51, 65, 85)), // #334155
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(6),
                Padding = new Thickness(10, 4, 10, 4),
                VerticalAlignment = VerticalAlignment.Center,
                MaxWidth = 550,
                HorizontalAlignment = HorizontalAlignment.Right
            };

            var searchGrid = new Grid();
            searchGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            searchGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var searchIcon = new TextBlock {
                Text = "🔍",
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 8, 0),
                Foreground = new SolidColorBrush(Color.FromRgb(148, 163, 184))
            };
            searchGrid.Children.Add(searchIcon);
            Grid.SetColumn(searchIcon, 0);

            searchBox = new TextBox {
                Background = Brushes.Transparent,
                Foreground = Brushes.White,
                BorderThickness = new Thickness(0),
                FontSize = 14,
                VerticalAlignment = VerticalAlignment.Center,
                CaretBrush = Brushes.White,
                MinWidth = 360
            };
            searchBox.TextChanged += (s, e) => ApplyFilter();
            searchGrid.Children.Add(searchBox);
            Grid.SetColumn(searchBox, 1);

            searchBorder.Child = searchGrid;
            topRow.Children.Add(searchBorder);
            Grid.SetColumn(searchBorder, 1);

            headerStack.Children.Add(topRow);

            // Bottom Row: Category Chips + PT-BR checkbox
            var filterRow = new WrapPanel { Margin = new Thickness(0, 12, 0, 0) };

            string[] categories = new string[] { "Todos", "PlayStation", "Xbox", "Nintendo", "PC & Outros", "Fangames" };
            foreach (var cat in categories) {
                var btn = CreateCategoryButton(cat);
                filterRow.Children.Add(btn);
            }

            var chkPtbr = new CheckBox {
                Content = "🇧🇷 Somente com PT-BR",
                Foreground = new SolidColorBrush(Color.FromRgb(52, 211, 153)), // Emerald #34D399
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(16, 4, 0, 0),
                FontWeight = FontWeights.SemiBold
            };
            chkPtbr.Checked += (s, e) => { onlyPtbr = true; ApplyFilter(); };
            chkPtbr.Unchecked += (s, e) => { onlyPtbr = false; ApplyFilter(); };
            filterRow.Children.Add(chkPtbr);

            headerStack.Children.Add(filterRow);
            headerBorder.Child = headerStack;

            return headerBorder;
        }

        private Button CreateCategoryButton(string catName) {
            var btn = new Button {
                Content = catName,
                Margin = new Thickness(0, 0, 8, 4),
                Padding = new Thickness(12, 5, 12, 5),
                Background = (catName == currentFilter)
                    ? new SolidColorBrush(Color.FromRgb(79, 70, 229))
                    : new SolidColorBrush(Color.FromRgb(30, 41, 59)),
                Foreground = Brushes.White,
                BorderBrush = new SolidColorBrush(Color.FromRgb(51, 65, 85)),
                BorderThickness = new Thickness(1),
                Cursor = Cursors.Hand,
                FontSize = 12,
                FontWeight = FontWeights.SemiBold
            };

            btn.Click += (s, e) => {
                currentFilter = catName;
                ApplyFilter();
                // Update visuals of all sibling buttons
                var parent = btn.Parent as Panel;
                if (parent != null) {
                    foreach (var child in parent.Children) {
                        var b = child as Button;
                        if (b != null) {
                            b.Background = (b.Content.ToString() == currentFilter)
                                ? new SolidColorBrush(Color.FromRgb(79, 70, 229))
                                : new SolidColorBrush(Color.FromRgb(30, 41, 59));
                        }
                    }
                }
            };
            return btn;
        }

        private UIElement CreateDetailPanel() {
            detailPanel = new Border {
                Background = new SolidColorBrush(Color.FromRgb(17, 24, 39)), // #111827
                BorderBrush = new SolidColorBrush(Color.FromRgb(31, 41, 55)), // #1F2937
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(18),
                Margin = new Thickness(12, 0, 0, 0)
            };

            detailScroll = new ScrollViewer {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled
            };

            var stack = new StackPanel();

            detailTitle = new TextBlock {
                Text = "Selecione um jogo",
                Foreground = Brushes.White,
                FontSize = 18,
                FontWeight = FontWeights.Bold,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 4)
            };
            stack.Children.Add(detailTitle);

            detailCategory = new TextBlock {
                Text = "Clique em um card ao lado para visualizar os detalhes e instalar.",
                Foreground = new SolidColorBrush(Color.FromRgb(148, 163, 184)),
                FontSize = 12,
                Margin = new Thickness(0, 0, 0, 14)
            };
            stack.Children.Add(detailCategory);

            // Divider
            stack.Children.Add(new Rectangle {
                Height = 1,
                Fill = new SolidColorBrush(Color.FromRgb(31, 41, 55)),
                Margin = new Thickness(0, 0, 0, 14)
            });

            // Requirements Section
            stack.Children.Add(new TextBlock {
                Text = "📋 O QUE VOCÊ PRECISA (ROM / ISO / DUMP):",
                Foreground = new SolidColorBrush(Color.FromRgb(245, 158, 11)), // Amber #F59E0B
                FontSize = 11,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 4)
            });

            detailRequires = new TextBlock {
                Text = "---",
                Foreground = new SolidColorBrush(Color.FromRgb(226, 232, 240)),
                FontSize = 13,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 14)
            };
            stack.Children.Add(detailRequires);

            // PT-BR Section
            stack.Children.Add(new TextBlock {
                Text = "🇧🇷 STATUS & INSTRUÇÕES DE PORTUGUÊS BRASILEIRO:",
                Foreground = new SolidColorBrush(Color.FromRgb(52, 211, 153)), // Emerald #34D399
                FontSize = 11,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 6)
            });

            detailPtbrBadge = new Border {
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(8, 4, 8, 4),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 6)
            };
            detailPtbrBadgeText = new TextBlock {
                Text = "---",
                FontWeight = FontWeights.Bold,
                FontSize = 11
            };
            detailPtbrBadge.Child = detailPtbrBadgeText;
            stack.Children.Add(detailPtbrBadge);

            detailPtbrText = new TextBlock {
                Text = "---",
                Foreground = new SolidColorBrush(Color.FromRgb(203, 213, 225)),
                FontSize = 12,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 16)
            };
            stack.Children.Add(detailPtbrText);

            // Live Progress Section
            progressBar = new ProgressBar {
                Height = 8,
                Foreground = new SolidColorBrush(Color.FromRgb(79, 70, 229)),
                Background = new SolidColorBrush(Color.FromRgb(30, 41, 59)),
                BorderThickness = new Thickness(0),
                Visibility = Visibility.Collapsed,
                Margin = new Thickness(0, 0, 0, 6)
            };
            stack.Children.Add(progressBar);

            progressStatus = new TextBlock {
                Text = "",
                Foreground = new SolidColorBrush(Color.FromRgb(148, 163, 184)),
                FontSize = 11,
                TextWrapping = TextWrapping.Wrap,
                Visibility = Visibility.Collapsed,
                Margin = new Thickness(0, 0, 0, 14)
            };
            stack.Children.Add(progressStatus);

            // Action Buttons
            btnInstall = new Button {
                Content = "📥 Instalar Jogo no PC",
                Background = new SolidColorBrush(Color.FromRgb(79, 70, 229)), // Indigo
                Foreground = Brushes.White,
                FontWeight = FontWeights.Bold,
                FontSize = 14,
                Padding = new Thickness(0, 10, 0, 10),
                BorderThickness = new Thickness(0),
                Cursor = Cursors.Hand,
                IsEnabled = false,
                Margin = new Thickness(0, 0, 0, 8)
            };
            btnInstall.Click += BtnInstall_Click;
            stack.Children.Add(btnInstall);

            btnOpenFolder = new Button {
                Content = "📁 Abrir Pasta do Jogo",
                Background = new SolidColorBrush(Color.FromRgb(30, 41, 59)),
                Foreground = Brushes.White,
                FontWeight = FontWeights.SemiBold,
                FontSize = 12,
                Padding = new Thickness(0, 8, 0, 8),
                BorderBrush = new SolidColorBrush(Color.FromRgb(51, 65, 85)),
                BorderThickness = new Thickness(1),
                Cursor = Cursors.Hand,
                IsEnabled = false,
                Margin = new Thickness(0, 0, 0, 8)
            };
            btnOpenFolder.Click += (s, e) => {
                if (selectedGame != null && selectedGame.IsInstalled()) {
                    Process.Start("explorer.exe", selectedGame.GetInstallDir());
                }
            };
            stack.Children.Add(btnOpenFolder);

            btnWebsite = new Button {
                Content = "🌐 Ver no GitHub / Site Oficial",
                Background = new SolidColorBrush(Color.FromRgb(30, 41, 59)),
                Foreground = Brushes.White,
                FontWeight = FontWeights.SemiBold,
                FontSize = 12,
                Padding = new Thickness(0, 8, 0, 8),
                BorderBrush = new SolidColorBrush(Color.FromRgb(51, 65, 85)),
                BorderThickness = new Thickness(1),
                Cursor = Cursors.Hand,
                IsEnabled = false,
                Margin = new Thickness(0, 0, 0, 8)
            };
            btnWebsite.Click += (s, e) => {
                if (selectedGame != null && !string.IsNullOrEmpty(selectedGame.website)) {
                    Process.Start(selectedGame.website);
                }
            };
            stack.Children.Add(btnWebsite);

            btnPtbr = new Button {
                Content = "🇧🇷 Baixar Tradução / Mod PT-BR",
                Background = new SolidColorBrush(Color.FromRgb(6, 95, 70)), // Dark Emerald
                Foreground = Brushes.White,
                FontWeight = FontWeights.SemiBold,
                FontSize = 12,
                Padding = new Thickness(0, 8, 0, 8),
                BorderThickness = new Thickness(0),
                Cursor = Cursors.Hand,
                Visibility = Visibility.Collapsed,
                Margin = new Thickness(0, 0, 0, 8)
            };
            btnPtbr.Click += (s, e) => {
                if (selectedGame != null && !string.IsNullOrEmpty(selectedGame.ptbr_url)) {
                    Process.Start(selectedGame.ptbr_url);
                }
            };
            stack.Children.Add(btnPtbr);

            detailScroll.Content = stack;
            detailPanel.Child = detailScroll;

            return detailPanel;
        }

        private void LoadCatalog() {
            string catalogPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "catalog.json");
            if (!File.Exists(catalogPath)) {
                string parentPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "catalog.json");
                if (File.Exists(parentPath)) {
                    catalogPath = System.IO.Path.GetFullPath(parentPath);
                }
            }

            if (!File.Exists(catalogPath)) {
                statsText.Text = "Erro: catalog.json não encontrado!";
                statsText.Foreground = Brushes.Red;
                return;
            }

            try {
                string json = File.ReadAllText(catalogPath);
                var serializer = new JavaScriptSerializer();
                allGames = serializer.Deserialize<List<GameItem>>(json);
                ApplyFilter();
            } catch (Exception ex) {
                statsText.Text = "Erro ao carregar catálogo: " + ex.Message;
                statsText.Foreground = Brushes.Red;
            }
        }

        private void ApplyFilter() {
            string query = (searchBox != null) ? searchBox.Text.Trim().ToLower() : "";
            filteredGames = new List<GameItem>();

            foreach (var game in allGames) {
                // Category filter
                bool catMatch = true;
                if (currentFilter == "PlayStation") {
                    catMatch = game.category.IndexOf("PlayStation", StringComparison.OrdinalIgnoreCase) >= 0;
                } else if (currentFilter == "Xbox") {
                    catMatch = game.category.IndexOf("Xbox", StringComparison.OrdinalIgnoreCase) >= 0;
                } else if (currentFilter == "Nintendo") {
                    catMatch = game.category.IndexOf("Nintendo", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               game.category.IndexOf("GameCube", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               game.category.IndexOf("Harbour Masters", StringComparison.OrdinalIgnoreCase) >= 0;
                } else if (currentFilter == "PC & Outros") {
                    catMatch = game.category.IndexOf("Source Ports", StringComparison.OrdinalIgnoreCase) >= 0;
                } else if (currentFilter == "Fangames") {
                    catMatch = game.category.IndexOf("Fangames", StringComparison.OrdinalIgnoreCase) >= 0;
                }

                if (!catMatch) continue;

                // PT-BR filter
                if (onlyPtbr) {
                    string pt = (game.ptbr_status ?? "").ToLower();
                    if (pt.Contains("em inglês") || pt.Contains("textos mínimos") || pt.Contains("luta arcade") || pt.Contains("corrida simulação")) {
                        continue;
                    }
                }

                // Search query
                if (!string.IsNullOrEmpty(query)) {
                    string fullText = (game.name + " " + game.game + " " + game.platform + " " + game.category + " " + game.ptbr_status).ToLower();
                    if (!fullText.Contains(query)) continue;
                }

                filteredGames.Add(game);
            }

            statsText.Text = string.Format("Exibindo {0} de {1} jogos catalogados", filteredGames.Count, allGames.Count);
            RenderCards();
        }

        private void RenderCards() {
            cardsPanel.Children.Clear();

            foreach (var item in filteredGames) {
                var card = CreateGameCard(item);
                cardsPanel.Children.Add(card);
            }

            if (filteredGames.Count == 0) {
                cardsPanel.Children.Add(new TextBlock {
                    Text = "Nenhum jogo encontrado para os filtros selecionados.",
                    Foreground = new SolidColorBrush(Color.FromRgb(148, 163, 184)),
                    FontSize = 14,
                    Margin = new Thickness(20)
                });
            }
        }

        private Border CreateGameCard(GameItem item) {
            var border = new Border {
                Background = new SolidColorBrush(Color.FromRgb(17, 24, 39)), // #111827
                BorderBrush = (selectedGame != null && selectedGame.id == item.id)
                    ? new SolidColorBrush(Color.FromRgb(99, 102, 241)) // Active border #6366F1
                    : new SolidColorBrush(Color.FromRgb(31, 41, 55)), // Normal border #1F2937
                BorderThickness = new Thickness((selectedGame != null && selectedGame.id == item.id) ? 2 : 1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(14),
                Margin = new Thickness(0, 0, 0, 8),
                Cursor = Cursors.Hand
            };

            var stack = new StackPanel();

            // Top Line: Platform Pill + Game Name
            var topLine = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 0, 0, 6) };

            var platBadge = new Border {
                Background = GetPlatformColor(item.platform),
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(6, 2, 6, 2),
                Margin = new Thickness(0, 0, 8, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Child = new TextBlock {
                    Text = item.platform,
                    Foreground = Brushes.White,
                    FontSize = 10,
                    FontWeight = FontWeights.Bold
                }
            };
            topLine.Children.Add(platBadge);

            var nameText = new TextBlock {
                Text = item.name,
                Foreground = Brushes.White,
                FontSize = 14,
                FontWeight = FontWeights.Bold,
                VerticalAlignment = VerticalAlignment.Center
            };
            topLine.Children.Add(nameText);
            stack.Children.Add(topLine);

            // Middle Line: PT-BR Badge + Installed Badge
            var badgeLine = new WrapPanel { Margin = new Thickness(0, 0, 0, 4) };

            var ptBadge = CreatePtbrBadge(item.ptbr_status);
            badgeLine.Children.Add(ptBadge);

            if (item.IsInstalled()) {
                var instBadge = new Border {
                    Background = new SolidColorBrush(Color.FromRgb(21, 128, 61)), // Green #15803D
                    CornerRadius = new CornerRadius(4),
                    Padding = new Thickness(6, 2, 6, 2),
                    Margin = new Thickness(6, 0, 0, 0),
                    Child = new TextBlock {
                        Text = "📁 INSTALADO",
                        Foreground = Brushes.White,
                        FontSize = 10,
                        FontWeight = FontWeights.Bold
                    }
                };
                badgeLine.Children.Add(instBadge);
            }

            stack.Children.Add(badgeLine);

            // Bottom snippet
            var reqSnippet = new TextBlock {
                Text = item.requires,
                Foreground = new SolidColorBrush(Color.FromRgb(148, 163, 184)),
                FontSize = 11,
                TextTrimming = TextTrimming.CharacterEllipsis,
                MaxHeight = 16
            };
            stack.Children.Add(reqSnippet);

            border.Child = stack;

            // Hover & Selection handlers
            border.MouseEnter += (s, e) => {
                if (selectedGame == null || selectedGame.id != item.id) {
                    border.BorderBrush = new SolidColorBrush(Color.FromRgb(79, 70, 229));
                    border.Background = new SolidColorBrush(Color.FromRgb(24, 32, 47));
                }
            };
            border.MouseLeave += (s, e) => {
                if (selectedGame == null || selectedGame.id != item.id) {
                    border.BorderBrush = new SolidColorBrush(Color.FromRgb(31, 41, 55));
                    border.Background = new SolidColorBrush(Color.FromRgb(17, 24, 39));
                }
            };
            border.MouseLeftButtonUp += (s, e) => {
                SelectGame(item);
            };

            return border;
        }

        private Border CreatePtbrBadge(string ptStatus) {
            ptStatus = ptStatus ?? "";
            Color bg = Color.FromRgb(51, 65, 85); // Slate fallback
            Color fg = Colors.White;
            string text = ptStatus;

            if (ptStatus.IndexOf("Dublad", StringComparison.OrdinalIgnoreCase) >= 0) {
                bg = Color.FromRgb(5, 150, 105); // Emerald Green
                text = "🎙️ " + ptStatus;
            } else if (ptStatus.IndexOf("Nativo", StringComparison.OrdinalIgnoreCase) >= 0) {
                bg = Color.FromRgb(16, 185, 129);
                text = "🟢 " + ptStatus;
            } else if (ptStatus.IndexOf("Mod", StringComparison.OrdinalIgnoreCase) >= 0) {
                bg = Color.FromRgb(2, 132, 199); // Sky Blue
                text = "🧩 " + ptStatus;
            } else if (ptStatus.IndexOf("Tradução", StringComparison.OrdinalIgnoreCase) >= 0 || ptStatus.IndexOf("ISO", StringComparison.OrdinalIgnoreCase) >= 0) {
                bg = Color.FromRgb(217, 119, 6); // Amber
                text = "🛠️ " + ptStatus;
            }

            return new Border {
                Background = new SolidColorBrush(bg),
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(6, 2, 6, 2),
                Margin = new Thickness(0, 0, 4, 0),
                Child = new TextBlock {
                    Text = text,
                    Foreground = new SolidColorBrush(fg),
                    FontSize = 10,
                    FontWeight = FontWeights.Bold
                }
            };
        }

        private SolidColorBrush GetPlatformColor(string platform) {
            platform = platform ?? "";
            if (platform.IndexOf("PS", StringComparison.OrdinalIgnoreCase) >= 0) {
                return new SolidColorBrush(Color.FromRgb(0, 67, 156)); // PlayStation Blue
            }
            if (platform.IndexOf("Xbox", StringComparison.OrdinalIgnoreCase) >= 0) {
                return new SolidColorBrush(Color.FromRgb(16, 124, 16)); // Xbox Green
            }
            if (platform.IndexOf("Switch", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("Wii", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("GameCube", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("N64", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("SNES", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("NES", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("GBA", StringComparison.OrdinalIgnoreCase) >= 0) {
                return new SolidColorBrush(Color.FromRgb(220, 38, 38)); // Nintendo Red
            }
            return new SolidColorBrush(Color.FromRgb(124, 58, 237)); // Purple
        }

        private void SelectGame(GameItem game) {
            selectedGame = game;
            RenderCards();

            detailTitle.Text = game.name;
            detailCategory.Text = string.Format("Plataforma: {0} | Categoria: {1}", game.platform, game.category);
            detailRequires.Text = game.requires;
            detailPtbrText.Text = game.ptbr_details;

            // PT-BR badge
            string pt = game.ptbr_status ?? "";
            detailPtbrBadgeText.Text = pt;
            if (pt.IndexOf("Dublad", StringComparison.OrdinalIgnoreCase) >= 0) {
                detailPtbrBadge.Background = new SolidColorBrush(Color.FromRgb(5, 150, 105));
            } else if (pt.IndexOf("Nativo", StringComparison.OrdinalIgnoreCase) >= 0) {
                detailPtbrBadge.Background = new SolidColorBrush(Color.FromRgb(16, 185, 129));
            } else {
                detailPtbrBadge.Background = new SolidColorBrush(Color.FromRgb(2, 132, 199));
            }

            btnInstall.IsEnabled = true;
            btnWebsite.IsEnabled = !string.IsNullOrEmpty(game.website);
            btnOpenFolder.IsEnabled = game.IsInstalled();

            if (!string.IsNullOrEmpty(game.ptbr_url)) {
                btnPtbr.Visibility = Visibility.Visible;
                btnPtbr.Content = "🇧🇷 Baixar Tradução / Mod PT-BR";
            } else {
                btnPtbr.Visibility = Visibility.Collapsed;
            }

            progressBar.Visibility = Visibility.Collapsed;
            progressStatus.Visibility = Visibility.Collapsed;
        }

        private async void BtnInstall_Click(object sender, RoutedEventArgs e) {
            if (selectedGame == null) return;

            btnInstall.IsEnabled = false;
            btnOpenFolder.IsEnabled = false;
            progressBar.Visibility = Visibility.Visible;
            progressStatus.Visibility = Visibility.Visible;
            progressBar.Value = 0;
            progressStatus.Text = "Consultando GitHub API para obter a versão oficial mais recente...";

            string targetDir = selectedGame.GetInstallDir();

            try {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

                string apiUrl = string.Format("https://api.github.com/repos/{0}/releases/latest", selectedGame.github_repo);
                string json = "";

                using (var web = new WebClient()) {
                    web.Headers["User-Agent"] = "PortsPC-Launcher";
                    try {
                        json = await web.DownloadStringTaskAsync(apiUrl);
                    } catch {
                        // fallback to website
                        progressStatus.Text = "Este projeto não possui binários automáticos no GitHub. Abrindo o site oficial no navegador...";
                        Process.Start(selectedGame.website);
                        btnInstall.IsEnabled = true;
                        return;
                    }
                }

                var serializer = new JavaScriptSerializer();
                var release = serializer.Deserialize<Dictionary<string, object>>(json);

                if (!release.ContainsKey("assets")) {
                    progressStatus.Text = "Nenhuma release pronta identificada. Abrindo página oficial no navegador...";
                    Process.Start(selectedGame.website);
                    btnInstall.IsEnabled = true;
                    return;
                }

                var assets = release["assets"] as System.Collections.ArrayList;
                if (assets == null || assets.Count == 0) {
                    progressStatus.Text = "Nenhum arquivo executável na release. Abrindo site oficial...";
                    Process.Start(selectedGame.website);
                    btnInstall.IsEnabled = true;
                    return;
                }

                // Match asset by regex or fallback
                Dictionary<string, object> chosenAsset = null;
                string regex = selectedGame.asset_regex ?? ".*(win|windows|x64).*\\.(zip|7z|exe)$";

                foreach (Dictionary<string, object> asset in assets) {
                    string aName = asset["name"].ToString();
                    if (Regex.IsMatch(aName, regex, RegexOptions.IgnoreCase)) {
                        chosenAsset = asset;
                        break;
                    }
                }

                if (chosenAsset == null) {
                    // Fallback to any win/zip
                    foreach (Dictionary<string, object> asset in assets) {
                        string aName = asset["name"].ToString();
                        if (Regex.IsMatch(aName, ".*(win|windows|x64).*\\.(zip|7z)$", RegexOptions.IgnoreCase)) {
                            chosenAsset = asset;
                            break;
                        }
                    }
                }

                if (chosenAsset == null && assets.Count > 0) {
                    chosenAsset = assets[0] as Dictionary<string, object>;
                }

                if (chosenAsset == null) {
                    progressStatus.Text = "Não foi possível identificar o download. Abrindo página de releases...";
                    Process.Start(selectedGame.website);
                    btnInstall.IsEnabled = true;
                    return;
                }

                string assetName = chosenAsset["name"].ToString();
                string downloadUrl = chosenAsset["browser_download_url"].ToString();
                long assetSize = Convert.ToInt64(chosenAsset["size"]);
                double sizeMb = Math.Round((double)assetSize / (1024 * 1024), 2);

                if (!Directory.Exists(targetDir)) {
                    Directory.CreateDirectory(targetDir);
                }

                string tempFile = System.IO.Path.Combine(targetDir, assetName);
                progressStatus.Text = string.Format("Baixando {0} ({1} MB)...", assetName, sizeMb);

                using (var downloader = new WebClient()) {
                    downloader.Headers["User-Agent"] = "PortsPC-Launcher";
                    downloader.DownloadProgressChanged += (dlSender, dlArgs) => {
                        Dispatcher.Invoke(new Action(() => {
                            progressBar.Value = dlArgs.ProgressPercentage;
                            progressStatus.Text = string.Format("Baixando {0} ({1}%)...", assetName, dlArgs.ProgressPercentage);
                        }));
                    };

                    await downloader.DownloadFileTaskAsync(new Uri(downloadUrl), tempFile);
                }

                // Extract if ZIP
                if (assetName.EndsWith(".zip", StringComparison.OrdinalIgnoreCase)) {
                    progressStatus.Text = "Extraindo arquivos do jogo...";
                    progressBar.IsIndeterminate = true;

                    await Task.Run(new Action(() => {
                        using (var zip = ZipFile.OpenRead(tempFile)) {
                            foreach (var entry in zip.Entries) {
                                if (string.IsNullOrEmpty(entry.Name)) {
                                    string dir = System.IO.Path.Combine(targetDir, entry.FullName);
                                    if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                                    continue;
                                }
                                string destFile = System.IO.Path.Combine(targetDir, entry.FullName);
                                string parentDir = System.IO.Path.GetDirectoryName(destFile);
                                if (!Directory.Exists(parentDir)) Directory.CreateDirectory(parentDir);
                                entry.ExtractToFile(destFile, true);
                            }
                        }

                        // Remove temp file immediately to save disk
                        if (File.Exists(tempFile)) {
                            File.Delete(tempFile);
                        }

                        // Create LEIAME-PTBR.txt
                        string leiamePath = System.IO.Path.Combine(targetDir, "LEIAME-PTBR.txt");
                        string leiame = string.Format(
                            "======================================================================\r\n" +
                            " {0} — Guia Rápido PortsPC\r\n" +
                            "======================================================================\r\n\r\n" +
                            "O QUE VOCÊ PRECISA PARA JOGAR:\r\n" +
                            "{1}\r\n\r\n" +
                            "STATUS DE TRADUÇÃO / DUBLAGEM PT-BR:\r\n" +
                            "{2}\r\n\r\n" +
                            "COMO ATIVAR O PORTUGUÊS BRASILEIRO:\r\n" +
                            "{3}\r\n\r\n" +
                            "LINK OFICIAL / MOD:\r\n" +
                            "{4}\r\n\r\n" +
                            "======================================================================\r\n",
                            selectedGame.name,
                            selectedGame.requires,
                            selectedGame.ptbr_status,
                            selectedGame.ptbr_details,
                            selectedGame.ptbr_url ?? selectedGame.website
                        );
                        File.WriteAllText(leiamePath, leiame);
                    }));
                }

                progressBar.IsIndeterminate = false;
                progressBar.Value = 100;
                progressStatus.Text = string.Format("✅ Instalação concluída com sucesso em: {0}! Arquivo temporário apagado.", targetDir);
                progressStatus.Foreground = new SolidColorBrush(Color.FromRgb(52, 211, 153));

                btnOpenFolder.IsEnabled = true;
                btnInstall.IsEnabled = true;

                // Open directory
                Process.Start("explorer.exe", targetDir);

                // Update UI state
                RenderCards();
            } catch (Exception ex) {
                progressBar.IsIndeterminate = false;
                progressStatus.Text = "Erro na instalação: " + ex.Message;
                progressStatus.Foreground = Brushes.Red;
                btnInstall.IsEnabled = true;
            }
        }

        [STAThread]
        public static void Main() {
            var app = new Application();
            var window = new MainWindow();
            app.Run(window);
        }
    }
}
