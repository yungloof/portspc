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
using System.Windows.Threading;

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
        private Dictionary<string, Border> cardBorders = new Dictionary<string, Border>();
        private GameItem selectedGame = null;
        private DispatcherTimer searchTimer;

        private TextBox searchBox;
        private TextBlock searchPlaceholder;
        private StackPanel cardsPanel;
        private TextBlock statsText;
        private Border detailPanel;
        private ScrollViewer detailScroll;

        // Detail elements
        private TextBlock detailTitle;
        private TextBlock detailCategory;
        private TextBlock detailRequires;
        private Border detailPtbrBadge;
        private Ellipse detailPtbrDot;
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

        // Linear / GitHub Neutral Dark Palette
        private static readonly Color BgPrimary = Color.FromRgb(9, 9, 11);         // #09090B
        private static readonly Color BgSurface = Color.FromRgb(18, 18, 20);       // #121214
        private static readonly Color BgControl = Color.FromRgb(24, 24, 27);       // #18181B
        private static readonly Color BgElevated = Color.FromRgb(32, 32, 36);      // #202024
        private static readonly Color BorderSubtle = Color.FromRgb(39, 39, 42);    // #27272A
        private static readonly Color BorderHover = Color.FromRgb(63, 63, 70);     // #3F3F46
        private static readonly Color TextPrimary = Color.FromRgb(244, 244, 245);  // #F4F4F5
        private static readonly Color TextSecondary = Color.FromRgb(161, 161, 170);// #A1A1AA
        private static readonly Color TextMuted = Color.FromRgb(113, 113, 122);    // #71717A
        private static readonly Color AccentGreen = Color.FromRgb(16, 185, 129);   // #10B981
        private static readonly Color AccentAmber = Color.FromRgb(245, 158, 11);   // #F59E0B
        private static readonly Color AccentSky = Color.FromRgb(56, 189, 248);     // #38BDF8

        public MainWindow() {
            Title = "PortsPC Launcher — Catálogo de Recomps & Source Ports";
            Width = 1200;
            Height = 760;
            MinWidth = 980;
            MinHeight = 600;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Background = new SolidColorBrush(BgPrimary);

            searchTimer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(90) };
            searchTimer.Tick += (s, e) => {
                searchTimer.Stop();
                ApplyFilter();
            };

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
            bodyGrid.Margin = new Thickness(18, 0, 18, 18);
            bodyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            bodyGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(430) });

            // Left side: Cards List inside ScrollViewer
            var leftStack = new Grid();
            leftStack.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            leftStack.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            statsText = new TextBlock {
                Text = "Carregando catálogo...",
                Foreground = new SolidColorBrush(TextMuted),
                FontSize = 12,
                FontWeight = FontWeights.Medium,
                Margin = new Thickness(2, 0, 0, 10)
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
                Background = new SolidColorBrush(BgSurface),
                BorderBrush = new SolidColorBrush(BorderSubtle),
                BorderThickness = new Thickness(0, 0, 0, 1),
                Padding = new Thickness(18, 14, 18, 14),
                Margin = new Thickness(0, 0, 0, 14)
            };

            var headerStack = new StackPanel { Orientation = Orientation.Vertical };

            // Top Row: Vector Mark + Title & Search
            var topRow = new Grid();
            topRow.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            topRow.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var logoStack = new StackPanel { Orientation = Orientation.Horizontal, VerticalAlignment = VerticalAlignment.Center };

            // Clean Vector Logo Box
            var logoBox = new Border {
                Width = 28,
                Height = 28,
                CornerRadius = new CornerRadius(6),
                Background = new SolidColorBrush(BgControl),
                BorderBrush = new SolidColorBrush(BorderHover),
                BorderThickness = new Thickness(1),
                Margin = new Thickness(0, 0, 10, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Child = new System.Windows.Shapes.Path {
                    Data = Geometry.Parse("M6,9 H18 A3,3 0 0 1 21,12 V15 A3,3 0 0 1 18,18 H6 A3,3 0 0 1 3,15 V12 A3,3 0 0 1 6,9 Z M8,12 V15 M6.5,13.5 H9.5 M15,12.5 A0.8,0.8 0 1 0 15,14.1 A0.8,0.8 0 1 0 15,12.5 Z M17.5,13.5 A0.8,0.8 0 1 0 17.5,15.1 A0.8,0.8 0 1 0 17.5,13.5 Z"),
                    Stroke = new SolidColorBrush(TextPrimary),
                    StrokeThickness = 1.5,
                    Width = 18,
                    Height = 18,
                    Stretch = Stretch.Uniform,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                }
            };
            logoStack.Children.Add(logoBox);

            var title = new TextBlock {
                Text = "PortsPC",
                Foreground = new SolidColorBrush(TextPrimary),
                FontSize = 18,
                FontWeight = FontWeights.SemiBold,
                VerticalAlignment = VerticalAlignment.Center
            };
            var badge = new Border {
                Background = new SolidColorBrush(BgControl),
                BorderBrush = new SolidColorBrush(BorderSubtle),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(7, 2, 7, 2),
                Margin = new Thickness(10, 1, 16, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Child = new TextBlock {
                    Text = "CATÁLOGO DE PORTS",
                    Foreground = new SolidColorBrush(TextSecondary),
                    FontSize = 10,
                    FontWeight = FontWeights.SemiBold
                }
            };
            logoStack.Children.Add(title);
            logoStack.Children.Add(badge);
            topRow.Children.Add(logoStack);
            Grid.SetColumn(logoStack, 0);

            // Search Box
            var searchBorder = new Border {
                Background = new SolidColorBrush(BgPrimary),
                BorderBrush = new SolidColorBrush(BorderSubtle),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(6),
                Padding = new Thickness(10, 6, 10, 6),
                VerticalAlignment = VerticalAlignment.Center,
                MaxWidth = 540,
                HorizontalAlignment = HorizontalAlignment.Right
            };

            var searchGrid = new Grid();
            searchGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            searchGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var searchIcon = new System.Windows.Shapes.Path {
                Data = Geometry.Parse("M11,4 A7,7 0 1 0 11,18 A7,7 0 1 0 11,4 Z M20,20 L16,16"),
                Stroke = new SolidColorBrush(TextMuted),
                StrokeThickness = 1.6,
                Width = 14,
                Height = 14,
                Stretch = Stretch.Uniform,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 8, 0)
            };
            searchGrid.Children.Add(searchIcon);
            Grid.SetColumn(searchIcon, 0);

            var searchInputHost = new Grid { MinWidth = 360 };
            searchPlaceholder = new TextBlock {
                Text = "Buscar por título, console ou idioma...",
                Foreground = new SolidColorBrush(TextMuted),
                FontSize = 13,
                VerticalAlignment = VerticalAlignment.Center,
                IsHitTestVisible = false
            };
            searchBox = new TextBox {
                Background = Brushes.Transparent,
                Foreground = new SolidColorBrush(TextPrimary),
                BorderThickness = new Thickness(0),
                FontSize = 13,
                VerticalAlignment = VerticalAlignment.Center,
                CaretBrush = new SolidColorBrush(TextPrimary)
            };
            searchBox.TextChanged += (s, e) => {
                searchPlaceholder.Visibility = string.IsNullOrEmpty(searchBox.Text) ? Visibility.Visible : Visibility.Collapsed;
                searchTimer.Stop();
                searchTimer.Start();
            };
            searchInputHost.Children.Add(searchPlaceholder);
            searchInputHost.Children.Add(searchBox);
            searchGrid.Children.Add(searchInputHost);
            Grid.SetColumn(searchInputHost, 1);

            searchBorder.Child = searchGrid;
            topRow.Children.Add(searchBorder);
            Grid.SetColumn(searchBorder, 1);

            headerStack.Children.Add(topRow);

            // Bottom Row: Category Chips + PT-BR checkbox + Sync button
            var filterRow = new WrapPanel { Margin = new Thickness(0, 12, 0, 0) };

            string[] categories = new string[] { "Todos", "PlayStation", "Xbox", "Nintendo & Sega", "PC & Outros", "Fangames" };
            foreach (var cat in categories) {
                var btn = CreateCategoryButton(cat);
                filterRow.Children.Add(btn);
            }

            var chkPtbr = new CheckBox {
                Content = "Somente com PT-BR",
                Foreground = new SolidColorBrush(TextSecondary),
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(14, 2, 14, 2),
                FontSize = 12,
                FontWeight = FontWeights.Medium,
                Cursor = Cursors.Hand
            };
            chkPtbr.Checked += (s, e) => {
                onlyPtbr = true;
                chkPtbr.Foreground = new SolidColorBrush(AccentGreen);
                ApplyFilter();
            };
            chkPtbr.Unchecked += (s, e) => {
                onlyPtbr = false;
                chkPtbr.Foreground = new SolidColorBrush(TextSecondary);
                ApplyFilter();
            };
            filterRow.Children.Add(chkPtbr);

            var btnSync = new Button {
                Content = "Sincronizar GitHub",
                Margin = new Thickness(6, 0, 0, 4),
                Padding = new Thickness(12, 5, 12, 5),
                Background = new SolidColorBrush(BgControl),
                Foreground = new SolidColorBrush(TextPrimary),
                BorderBrush = new SolidColorBrush(BorderHover),
                BorderThickness = new Thickness(1),
                Cursor = Cursors.Hand,
                FontSize = 12,
                FontWeight = FontWeights.Medium
            };
            btnSync.Click += BtnUpdateCatalog_Click;
            filterRow.Children.Add(btnSync);

            headerStack.Children.Add(filterRow);
            headerBorder.Child = headerStack;

            return headerBorder;
        }

        private Button CreateCategoryButton(string catName) {
            bool isActive = (catName == currentFilter);
            var btn = new Button {
                Content = catName,
                Margin = new Thickness(0, 0, 6, 4),
                Padding = new Thickness(11, 5, 11, 5),
                Background = new SolidColorBrush(isActive ? TextPrimary : BgControl),
                Foreground = new SolidColorBrush(isActive ? BgPrimary : TextSecondary),
                BorderBrush = new SolidColorBrush(isActive ? TextPrimary : BorderSubtle),
                BorderThickness = new Thickness(1),
                Cursor = Cursors.Hand,
                FontSize = 12,
                FontWeight = isActive ? FontWeights.SemiBold : FontWeights.Medium
            };

            btn.Click += (s, e) => {
                currentFilter = catName;
                ApplyFilter();
                var parent = btn.Parent as Panel;
                if (parent != null) {
                    foreach (var child in parent.Children) {
                        var b = child as Button;
                        if (b != null && b.Content != null && b.Content.ToString() != "Sincronizar GitHub" && b.Content.ToString() != "Sincronizando...") {
                            bool active = (b.Content.ToString() == currentFilter);
                            b.Background = new SolidColorBrush(active ? TextPrimary : BgControl);
                            b.Foreground = new SolidColorBrush(active ? BgPrimary : TextSecondary);
                            b.BorderBrush = new SolidColorBrush(active ? TextPrimary : BorderSubtle);
                            b.FontWeight = active ? FontWeights.SemiBold : FontWeights.Medium;
                        }
                    }
                }
            };
            return btn;
        }

        private UIElement CreateDetailPanel() {
            detailPanel = new Border {
                Background = new SolidColorBrush(BgSurface),
                BorderBrush = new SolidColorBrush(BorderSubtle),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(8),
                Padding = new Thickness(20),
                Margin = new Thickness(14, 0, 0, 0)
            };

            detailScroll = new ScrollViewer {
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled
            };

            var stack = new StackPanel();

            detailTitle = new TextBlock {
                Text = "Selecione um jogo",
                Foreground = new SolidColorBrush(TextPrimary),
                FontSize = 18,
                FontWeight = FontWeights.SemiBold,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 4)
            };
            stack.Children.Add(detailTitle);

            detailCategory = new TextBlock {
                Text = "Clique em qualquer item da lista para ver os requisitos e instalar.",
                Foreground = new SolidColorBrush(TextMuted),
                FontSize = 12,
                Margin = new Thickness(0, 0, 0, 14)
            };
            stack.Children.Add(detailCategory);

            // Divider
            stack.Children.Add(new Rectangle {
                Height = 1,
                Fill = new SolidColorBrush(BorderSubtle),
                Margin = new Thickness(0, 0, 0, 16)
            });

            // Requirements Section
            stack.Children.Add(new TextBlock {
                Text = "REQUISITOS (ROM / ISO / DUMP)",
                Foreground = new SolidColorBrush(TextMuted),
                FontSize = 10,
                FontWeight = FontWeights.SemiBold,
                Margin = new Thickness(0, 0, 0, 6)
            });

            detailRequires = new TextBlock {
                Text = "---",
                Foreground = new SolidColorBrush(TextPrimary),
                FontSize = 13,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 16)
            };
            stack.Children.Add(detailRequires);

            // PT-BR Section
            stack.Children.Add(new TextBlock {
                Text = "LOCALIZAÇÃO & STATUS PT-BR",
                Foreground = new SolidColorBrush(TextMuted),
                FontSize = 10,
                FontWeight = FontWeights.SemiBold,
                Margin = new Thickness(0, 0, 0, 6)
            });

            detailPtbrBadge = new Border {
                Background = new SolidColorBrush(BgControl),
                BorderBrush = new SolidColorBrush(BorderSubtle),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(8, 4, 8, 4),
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(0, 0, 0, 8)
            };
            var badgeRow = new StackPanel { Orientation = Orientation.Horizontal };
            detailPtbrDot = new Ellipse {
                Width = 7,
                Height = 7,
                Fill = new SolidColorBrush(TextMuted),
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 6, 0)
            };
            detailPtbrBadgeText = new TextBlock {
                Text = "---",
                Foreground = new SolidColorBrush(TextSecondary),
                FontWeight = FontWeights.SemiBold,
                FontSize = 11,
                VerticalAlignment = VerticalAlignment.Center
            };
            badgeRow.Children.Add(detailPtbrDot);
            badgeRow.Children.Add(detailPtbrBadgeText);
            detailPtbrBadge.Child = badgeRow;
            stack.Children.Add(detailPtbrBadge);

            detailPtbrText = new TextBlock {
                Text = "---",
                Foreground = new SolidColorBrush(TextSecondary),
                FontSize = 12,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 18)
            };
            stack.Children.Add(detailPtbrText);

            // Live Progress Section
            progressBar = new ProgressBar {
                Height = 6,
                Foreground = new SolidColorBrush(TextPrimary),
                Background = new SolidColorBrush(BgControl),
                BorderThickness = new Thickness(0),
                Visibility = Visibility.Collapsed,
                Margin = new Thickness(0, 0, 0, 6)
            };
            stack.Children.Add(progressBar);

            progressStatus = new TextBlock {
                Text = "",
                Foreground = new SolidColorBrush(TextSecondary),
                FontSize = 11,
                TextWrapping = TextWrapping.Wrap,
                Visibility = Visibility.Collapsed,
                Margin = new Thickness(0, 0, 0, 14)
            };
            stack.Children.Add(progressStatus);

            // Action Buttons
            btnInstall = new Button {
                Content = "Instalar Jogo no PC",
                Background = new SolidColorBrush(TextPrimary),
                Foreground = new SolidColorBrush(BgPrimary),
                FontWeight = FontWeights.SemiBold,
                FontSize = 13,
                Padding = new Thickness(0, 10, 0, 10),
                BorderThickness = new Thickness(0),
                Cursor = Cursors.Hand,
                IsEnabled = false,
                Margin = new Thickness(0, 0, 0, 8)
            };
            btnInstall.Click += BtnInstall_Click;
            stack.Children.Add(btnInstall);

            btnOpenFolder = new Button {
                Content = "Abrir Pasta do Jogo",
                Background = new SolidColorBrush(BgControl),
                Foreground = new SolidColorBrush(TextPrimary),
                FontWeight = FontWeights.Medium,
                FontSize = 12,
                Padding = new Thickness(0, 8, 0, 8),
                BorderBrush = new SolidColorBrush(BorderSubtle),
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
                Content = "Abrir no GitHub / Site Oficial",
                Background = new SolidColorBrush(BgControl),
                Foreground = new SolidColorBrush(TextPrimary),
                FontWeight = FontWeights.Medium,
                FontSize = 12,
                Padding = new Thickness(0, 8, 0, 8),
                BorderBrush = new SolidColorBrush(BorderSubtle),
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
                Content = "Baixar Tradução / Mod PT-BR",
                Background = new SolidColorBrush(Color.FromRgb(6, 78, 59)),
                Foreground = new SolidColorBrush(Color.FromRgb(167, 243, 208)),
                FontWeight = FontWeights.SemiBold,
                FontSize = 12,
                Padding = new Thickness(0, 8, 0, 8),
                BorderBrush = new SolidColorBrush(Color.FromRgb(16, 185, 129)),
                BorderThickness = new Thickness(1),
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

        private string GetCatalogPath() {
            string catalogPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "catalog.json");
            if (!File.Exists(catalogPath)) {
                string parentPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "catalog.json");
                if (File.Exists(parentPath)) {
                    catalogPath = System.IO.Path.GetFullPath(parentPath);
                }
            }
            return catalogPath;
        }

        private void LoadCatalog() {
            string catalogPath = GetCatalogPath();
            if (!File.Exists(catalogPath)) {
                statsText.Text = "Erro: catalog.json não encontrado!";
                statsText.Foreground = Brushes.Red;
                return;
            }

            try {
                string json = File.ReadAllText(catalogPath, System.Text.Encoding.UTF8);
                var serializer = new JavaScriptSerializer();
                serializer.MaxJsonLength = int.MaxValue;
                allGames = serializer.Deserialize<List<GameItem>>(json);
                ApplyFilter();
            } catch (Exception ex) {
                statsText.Text = "Erro ao carregar catálogo: " + ex.Message;
                statsText.Foreground = Brushes.Red;
            }
        }

        private async void BtnUpdateCatalog_Click(object sender, RoutedEventArgs e) {
            var btn = sender as Button;
            if (btn != null) {
                btn.IsEnabled = false;
                btn.Content = "Sincronizando...";
            }
            statsText.Text = "Sincronizando catálogo online e varrendo novos ports no GitHub...";

            int addedCount = 0;
            try {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
                var serializer = new JavaScriptSerializer();
                serializer.MaxJsonLength = int.MaxValue;

                var knownIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                var knownRepos = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                foreach (var g in allGames) {
                    if (!string.IsNullOrEmpty(g.id)) knownIds.Add(g.id);
                    if (!string.IsNullOrEmpty(g.github_repo)) knownRepos.Add(g.github_repo);
                }

                // 1. Sync with official yungloof/portspc repository catalog.json
                using (var web = new WebClient()) {
                    web.Encoding = System.Text.Encoding.UTF8;
                    web.Headers["User-Agent"] = "PortsPC-Launcher";
                    try {
                        string remoteJson = await web.DownloadStringTaskAsync("https://raw.githubusercontent.com/yungloof/portspc/main/catalog.json");
                        var remoteList = serializer.Deserialize<List<GameItem>>(remoteJson);
                        if (remoteList != null) {
                            foreach (var rg in remoteList) {
                                if (!knownIds.Contains(rg.id) && (string.IsNullOrEmpty(rg.github_repo) || !knownRepos.Contains(rg.github_repo))) {
                                    allGames.Add(rg);
                                    knownIds.Add(rg.id);
                                    if (!string.IsNullOrEmpty(rg.github_repo)) knownRepos.Add(rg.github_repo);
                                    addedCount++;
                                }
                            }
                        }
                    } catch { }
                }

                // 2. Discover brand-new playable ports from awesome-decomp-games (updated daily)
                using (var web = new WebClient()) {
                    web.Encoding = System.Text.Encoding.UTF8;
                    web.Headers["User-Agent"] = "PortsPC-Launcher";
                    try {
                        string md = await web.DownloadStringTaskAsync("https://raw.githubusercontent.com/SubmitGame/awesome-decomp-games/main/README.md");
                        string currentCat = "Nintendo & Sega Recomps";
                        string[] lines = md.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                        // Linha de tabela: | [Titulo](https://github.com/o/r) | Plataforma | Nota | estrelas | data | ... | [release](...)
                        var rx = new Regex(@"^\|\s*\[([^\]]+)\]\(https://github\.com/([^/\)]+/[^/\)]+)\)[^|]*\|\s*([^|]+?)\s*\|\s*([\d\.]+)\s*\|.*\[release\]", RegexOptions.IgnoreCase);
                        string section = "";

                        foreach (string line in lines) {
                            if (line.StartsWith("## ")) { section = line.Substring(3).Trim(); continue; }
                            if (section != "Static recompilations" && section != "Source ports" &&
                                section != "Engine remakes & reimplementations" && section != "Decompilations") continue;
                            var m = rx.Match(line);
                            if (m.Success) {
                                string title = m.Groups[1].Value.Trim();
                                string repo = m.Groups[2].Value.Trim();
                                string plat = m.Groups[3].Value.Trim();
                                double score = 0;
                                double.TryParse(m.Groups[4].Value, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out score);
                                bool isStatic = section == "Static recompilations";
                                if (score < (isStatic ? 3.8 : 4.3)) continue;
                                if (Regex.IsMatch(repo + " " + title, "android|3ds|vita|mobile|godot", RegexOptions.IgnoreCase)) continue;
                                if (plat.StartsWith("PS")) currentCat = "PlayStation (PS4/PS2/PS1)";
                                else if (plat.IndexOf("xbox", StringComparison.OrdinalIgnoreCase) >= 0) currentCat = "Xbox 360 & Xbox Clássico";
                                else if (plat == "Wii" || plat == "GameCube" || plat == "Wii U" || plat == "Switch") currentCat = "GameCube, Wii, Wii U & Switch";
                                else if (plat == "PC" || plat == "DOS" || plat == "Mac") currentCat = "Source Ports de Clássicos";
                                else currentCat = "Nintendo & Sega Recomps";
                                if (!knownRepos.Contains(repo)) {
                                    string idSlug = Regex.Replace(title.ToLower(), @"[^a-z0-9]+", "-").Trim('-');
                                    if (knownIds.Contains(idSlug)) idSlug = idSlug + "-port";
                                    var newGame = new GameItem {
                                        id = idSlug,
                                        name = title + " (Port Nativo PC)",
                                        game = title,
                                        platform = "Console / PC",
                                        category = currentCat,
                                        github_repo = repo,
                                        website = "https://github.com/" + repo + "/releases",
                                        asset_regex = ".*(win|windows|x64|msvc).*\\.(zip|7z|exe)$",
                                        windows = true,
                                        linux = true,
                                        requires = "Arquivos / ROM original do jogo (veja instruções no GitHub oficial)",
                                        ptbr_status = "Verifique tradução da comunidade / ROM PT-BR",
                                        ptbr_details = "Projeto descoberto automaticamente pelo buscador online do PortsPC! Compatível com patches de tradução na ROM/ISO base.",
                                        ptbr_url = "https://github.com/" + repo
                                    };
                                    allGames.Add(newGame);
                                    knownRepos.Add(repo);
                                    knownIds.Add(idSlug);
                                    addedCount++;
                                }
                            }
                        }
                    } catch { }
                }

                if (addedCount > 0) {
                    string catalogPath = GetCatalogPath();
                    string updatedJson = serializer.Serialize(allGames);
                    File.WriteAllText(catalogPath, updatedJson, System.Text.Encoding.UTF8);
                }

                ApplyFilter();
                if (addedCount > 0) {
                    MessageBox.Show(
                        string.Format("Foram encontrados e adicionados {0} novos ports ao seu catálogo!\nTotal atual: {1} jogos.", addedCount, allGames.Count),
                        "Catálogo Atualizado!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                    );
                } else {
                    MessageBox.Show(
                        string.Format("Seu catálogo já está 100% atualizado com os últimos lançamentos!\nTotal atual: {0} jogos catalogados.", allGames.Count),
                        "Catálogo em Dia",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                    );
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro ao buscar atualizações: " + ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
            } finally {
                if (btn != null) {
                    btn.IsEnabled = true;
                    btn.Content = "Sincronizar GitHub";
                }
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
                } else if (currentFilter == "Nintendo & Sega" || currentFilter == "Nintendo") {
                    catMatch = game.category.IndexOf("Nintendo", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               game.category.IndexOf("GameCube", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               game.category.IndexOf("Harbour Masters", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               game.category.IndexOf("Sega", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               game.platform.IndexOf("Dreamcast", StringComparison.OrdinalIgnoreCase) >= 0 ||
                               game.platform.IndexOf("Mega Drive", StringComparison.OrdinalIgnoreCase) >= 0;
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
            cardBorders.Clear();

            foreach (var item in filteredGames) {
                var card = CreateGameCard(item);
                if (!string.IsNullOrEmpty(item.id) && !cardBorders.ContainsKey(item.id)) {
                    cardBorders[item.id] = card;
                }
                cardsPanel.Children.Add(card);
            }

            if (filteredGames.Count == 0) {
                cardsPanel.Children.Add(new TextBlock {
                    Text = "Nenhum jogo encontrado para os filtros selecionados.",
                    Foreground = new SolidColorBrush(TextMuted),
                    FontSize = 13,
                    Margin = new Thickness(12, 24, 12, 24)
                });
            }
        }

        private Border CreateGameCard(GameItem item) {
            bool isSelected = (selectedGame != null && selectedGame.id == item.id);
            var border = new Border {
                Background = new SolidColorBrush(isSelected ? BgElevated : BgSurface),
                BorderBrush = new SolidColorBrush(isSelected ? TextPrimary : BorderSubtle),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(6),
                Padding = new Thickness(14, 11, 14, 11),
                Margin = new Thickness(0, 0, 0, 6),
                Cursor = Cursors.Hand
            };

            var stack = new StackPanel();

            // Top Line: Platform Pill + Game Name
            var topLine = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 0, 0, 6) };

            var platBadge = new Border {
                Background = GetPlatformColor(item.platform),
                BorderBrush = new SolidColorBrush(BorderHover),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(6, 2, 6, 2),
                Margin = new Thickness(0, 0, 8, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Child = new TextBlock {
                    Text = item.platform,
                    Foreground = new SolidColorBrush(TextPrimary),
                    FontSize = 10,
                    FontWeight = FontWeights.SemiBold
                }
            };
            topLine.Children.Add(platBadge);

            var nameText = new TextBlock {
                Text = item.name,
                Foreground = new SolidColorBrush(TextPrimary),
                FontSize = 14,
                FontWeight = FontWeights.SemiBold,
                VerticalAlignment = VerticalAlignment.Center
            };
            topLine.Children.Add(nameText);
            stack.Children.Add(topLine);

            // Middle Line: PT-BR Badge + Installed Badge
            var badgeLine = new WrapPanel { Margin = new Thickness(0, 0, 0, 5) };

            var ptBadge = CreatePtbrBadge(item.ptbr_status);
            badgeLine.Children.Add(ptBadge);

            if (item.IsInstalled()) {
                var instBadge = new Border {
                    Background = new SolidColorBrush(Color.FromRgb(6, 78, 59)),
                    BorderBrush = new SolidColorBrush(AccentGreen),
                    BorderThickness = new Thickness(1),
                    CornerRadius = new CornerRadius(4),
                    Padding = new Thickness(6, 2, 6, 2),
                    Margin = new Thickness(6, 0, 0, 0),
                    Child = new TextBlock {
                        Text = "INSTALADO",
                        Foreground = new SolidColorBrush(Color.FromRgb(167, 243, 208)),
                        FontSize = 10,
                        FontWeight = FontWeights.SemiBold
                    }
                };
                badgeLine.Children.Add(instBadge);
            }

            stack.Children.Add(badgeLine);

            // Bottom snippet
            var reqSnippet = new TextBlock {
                Text = item.requires,
                Foreground = new SolidColorBrush(TextMuted),
                FontSize = 11,
                TextTrimming = TextTrimming.CharacterEllipsis,
                MaxHeight = 16
            };
            stack.Children.Add(reqSnippet);

            border.Child = stack;

            // Hover & Selection handlers
            border.MouseEnter += (s, e) => {
                if (selectedGame == null || selectedGame.id != item.id) {
                    border.BorderBrush = new SolidColorBrush(BorderHover);
                    border.Background = new SolidColorBrush(BgControl);
                }
            };
            border.MouseLeave += (s, e) => {
                if (selectedGame == null || selectedGame.id != item.id) {
                    border.BorderBrush = new SolidColorBrush(BorderSubtle);
                    border.Background = new SolidColorBrush(BgSurface);
                }
            };
            border.MouseLeftButtonUp += (s, e) => {
                SelectGame(item);
            };

            return border;
        }

        private Color GetPtbrDotColor(string ptStatus) {
            ptStatus = ptStatus ?? "";
            if (ptStatus.IndexOf("Dublad", StringComparison.OrdinalIgnoreCase) >= 0) return AccentGreen;
            if (ptStatus.IndexOf("Nativo", StringComparison.OrdinalIgnoreCase) >= 0) return AccentGreen;
            if (ptStatus.IndexOf("Mod", StringComparison.OrdinalIgnoreCase) >= 0) return AccentSky;
            if (ptStatus.IndexOf("Tradução", StringComparison.OrdinalIgnoreCase) >= 0 || ptStatus.IndexOf("ISO", StringComparison.OrdinalIgnoreCase) >= 0) return AccentAmber;
            return TextMuted;
        }

        private Border CreatePtbrBadge(string ptStatus) {
            ptStatus = ptStatus ?? "";
            Color dotColor = GetPtbrDotColor(ptStatus);
            Color fg = (dotColor == TextMuted) ? TextSecondary : TextPrimary;

            var row = new StackPanel { Orientation = Orientation.Horizontal };
            row.Children.Add(new Ellipse {
                Width = 6,
                Height = 6,
                Fill = new SolidColorBrush(dotColor),
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 6, 0)
            });
            row.Children.Add(new TextBlock {
                Text = ptStatus,
                Foreground = new SolidColorBrush(fg),
                FontSize = 10,
                FontWeight = FontWeights.Medium,
                VerticalAlignment = VerticalAlignment.Center
            });

            return new Border {
                Background = new SolidColorBrush(BgControl),
                BorderBrush = new SolidColorBrush(BorderSubtle),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(4),
                Padding = new Thickness(7, 2, 7, 2),
                Margin = new Thickness(0, 0, 4, 0),
                Child = row
            };
        }

        private SolidColorBrush GetPlatformColor(string platform) {
            platform = platform ?? "";
            if (platform.IndexOf("PS", StringComparison.OrdinalIgnoreCase) >= 0) {
                return new SolidColorBrush(Color.FromRgb(23, 37, 84)); // Muted Deep Navy
            }
            if (platform.IndexOf("Xbox", StringComparison.OrdinalIgnoreCase) >= 0) {
                return new SolidColorBrush(Color.FromRgb(6, 78, 59)); // Muted Deep Emerald
            }
            if (platform.IndexOf("Switch", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("Wii", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("GameCube", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("N64", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("SNES", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("NES", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("GBA", StringComparison.OrdinalIgnoreCase) >= 0 ||
                platform.IndexOf("DS", StringComparison.OrdinalIgnoreCase) >= 0) {
                return new SolidColorBrush(Color.FromRgb(69, 10, 10)); // Muted Crimson
            }
            return new SolidColorBrush(BgControl);
        }

        private void SelectGame(GameItem game) {
            GameItem previous = selectedGame;
            selectedGame = game;

            if (previous != null && !string.IsNullOrEmpty(previous.id) && cardBorders.ContainsKey(previous.id)) {
                var prevBorder = cardBorders[previous.id];
                prevBorder.Background = new SolidColorBrush(BgSurface);
                prevBorder.BorderBrush = new SolidColorBrush(BorderSubtle);
            }
            if (game != null && !string.IsNullOrEmpty(game.id) && cardBorders.ContainsKey(game.id)) {
                var currBorder = cardBorders[game.id];
                currBorder.Background = new SolidColorBrush(BgElevated);
                currBorder.BorderBrush = new SolidColorBrush(TextPrimary);
            }

            detailTitle.Text = game.name;
            detailCategory.Text = string.Format("Plataforma: {0}  |  Categoria: {1}", game.platform, game.category);
            detailRequires.Text = game.requires;
            detailPtbrText.Text = game.ptbr_details;

            // PT-BR badge
            string pt = game.ptbr_status ?? "";
            detailPtbrBadgeText.Text = pt;
            detailPtbrDot.Fill = new SolidColorBrush(GetPtbrDotColor(pt));

            btnInstall.IsEnabled = true;
            btnWebsite.IsEnabled = !string.IsNullOrEmpty(game.website);
            btnOpenFolder.IsEnabled = game.IsInstalled();

            if (!string.IsNullOrEmpty(game.ptbr_url)) {
                btnPtbr.Visibility = Visibility.Visible;
                btnPtbr.Content = "Baixar Tradução / Mod PT-BR";
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
                var serializer = new JavaScriptSerializer();
                Dictionary<string, object> release = null;

                using (var web = new WebClient()) {
                    web.Headers["User-Agent"] = "PortsPC-Launcher";
                    bool tryPreRelease = false;
                    try {
                        string json = await web.DownloadStringTaskAsync(apiUrl);
                        release = serializer.Deserialize<Dictionary<string, object>>(json);
                    } catch {
                        tryPreRelease = true;
                    }
                    if (tryPreRelease) {
                        try {
                            string preUrl = string.Format("https://api.github.com/repos/{0}/releases?per_page=1", selectedGame.github_repo);
                            string preJson = await web.DownloadStringTaskAsync(preUrl);
                            var preList = serializer.Deserialize<System.Collections.ArrayList>(preJson);
                            if (preList != null && preList.Count > 0) {
                                release = preList[0] as Dictionary<string, object>;
                            }
                        } catch { }
                    }
                }

                if (release == null || !release.ContainsKey("assets")) {
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
                progressStatus.Text = string.Format("Instalação concluída em: {0}. Arquivo temporário removido.", targetDir);
                progressStatus.Foreground = new SolidColorBrush(AccentGreen);

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
