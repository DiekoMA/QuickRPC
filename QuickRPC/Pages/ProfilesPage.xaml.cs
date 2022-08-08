namespace QuickRPC.Pages
{
    /// <summary>
    /// Interaction logic for ProfilesPage.xaml
    /// </summary>
    public partial class ProfilesPage 
    {
        public ProfilesPage()
        {
            InitializeComponent();
            foreach (var item in SerialisationHandler.Instance.GetProfiles())
            {
                ProfilesBox.Items.Add(item.Name);
            }
        }

        private void SearchBar_SearchStarted(object sender, HandyControl.Data.FunctionEventArgs<string> e)
        {
            
        }

        

        private void ProfilesSearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ProfilesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
