namespace QuickRPC
{
    public partial class MainWindow
    {
        public HomePage homePage;
        public ProfilesPage profilesPage;
        public KeybindsPage keybindsPage;
        public SettingsPage settingsPage;
        public ConsolePage consolePage;
        public MainWindow()
        {
            InitializeComponent();
            AppCenter.Start("26d1c741-041d-47b9-acc4-461739016013", typeof(Analytics), typeof(Crashes));
            homePage = new HomePage();
            profilesPage = new ProfilesPage();
            keybindsPage = new KeybindsPage();
            settingsPage = new SettingsPage();
            consolePage = new ConsolePage();
        }

        #region Sidebar Logic
        private void HomeItem_Selected(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = homePage;
        }

        private void ProfilesItem_Selected(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = profilesPage;
        }

        private void KeybindsItem_Selected(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = keybindsPage;
        }

        private void SettingsItem_Selected(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = settingsPage;
        }

        private void ConsoleItem_Selected(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = consolePage;
        }

        private void ExitItem_Selected(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #endregion

        //Menu Item Logic
        #region MenuItem Logic

        private void NewProfile_MI_Click(object sender, RoutedEventArgs e)
        {
            ProfileCreationDialog profileCreationDialog = new ProfileCreationDialog();
            profileCreationDialog.ShowDialog();
        }

        private void SaveProfile_MI_Click(object sender, RoutedEventArgs e)
        {
            /*var exportDialog = new SaveFileDialog();
            exportDialog.FileName = "QuickRPC";
            exportDialog.DefaultExt = ".qrc";
            exportDialog.Filter = "Quick RPC Profile (.qrc)|*.qrc";
            bool? result = exportDialog.ShowDialog();
            Profile prof = new Profile();
            prof.Name = homePage.presence.State;*/
            /*Profile profile = new Profile();
            profile.AppId = homePage.presence.Details;
            FileHandler.Instance.SaveData(profile);*/
        }

        private void ImportProfile_MI_Click(object sender, RoutedEventArgs e)
        {
            var importDialog = new OpenFileDialog();
            importDialog.FileName = "QuickRPC";
            importDialog.DefaultExt = ".qrc";
            importDialog.Filter = "Quick RPC Profile (.qrc)|*.qrc";
            bool? result = importDialog.ShowDialog();
        }

        private void ExportProfile_MI_Click(object sender, RoutedEventArgs e)
        {
            var exportDialog = new SaveFileDialog();
            exportDialog.FileName = "QuickRPC";
            exportDialog.DefaultExt = ".qrc";
            exportDialog.Filter = "Quick RPC Profile (.qrc)|*.qrc";
            bool? result = exportDialog.ShowDialog();
        }

        #endregion
    }
}
