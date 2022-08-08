namespace QuickRPC.Dialogs
{
    /// <summary>
    /// Interaction logic for ProfileCreationDialog.xaml
    /// </summary>
    public partial class ProfileCreationDialog : System.Windows.Window
    {
        public string profileName;
        public string profileTag;
        public ProfileCreationDialog()
        {
            InitializeComponent();
        }

        private void CreateButton_OnClick(object sender, RoutedEventArgs e)
        {
            profileName = ProfileNameBox.Text;
            profileTag = ProfileTagBox.SelectedItem.ToString();
        }
    }
}
