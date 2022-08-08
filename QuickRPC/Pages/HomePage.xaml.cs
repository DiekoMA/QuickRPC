namespace QuickRPC.Pages
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public RichPresence? presence;
        List<DiscordRPC.Button>? _buttons;
        Timestamps? _timestamps;
        Party _party;

        public HomePage()
        {
            InitializeComponent();
        }

        #region RPC_Controls
        private void CustomTimeStampRB_Click(object sender, RoutedEventArgs e)
        {
            HandyControl.Controls.TimePicker timePicker = new HandyControl.Controls.TimePicker();
            timePicker.BringIntoView();
        }

        private async void StartMenuItem_Click(object sender, RoutedEventArgs e)
        {
            _buttons = new List<DiscordRPC.Button>();
            _party = new Party();
            _timestamps = new Timestamps();

            try
            {
                if (Button1Text.Text != "" && Button1Url.Text != "")
                    _buttons.Add(new DiscordRPC.Button() { Label = Button1Text.Text, Url = Button1Url.Text });
            }
            catch (Exception bEx)
            {
                Growl.Error(bEx.Message.ToString());
                return;
            }

            try
            {
                if (Button2Text.Text != "" && Button2Url.Text != "")
                    _buttons.Add(new DiscordRPC.Button() { Label = Button2Text.Text, Url = Button2Url.Text });
            }
            catch (Exception bEx)
            {
                Growl.Error(bEx.Message.ToString());
                return;
            }

            try
            {
                if (TimeStampRb.IsChecked == true)
                    _timestamps = Timestamps.Now;

                if (NoneTimeStampRb.IsChecked == true)
                    _timestamps = null;
            }
            catch (Exception timeException)
            {
                Growl.Error(timeException.Message.ToString());
                return;
            }

            try
            {
                _party.ID = ClientIdBox.Text;
                if (PartySizeBox.Value is not 0 or 0)
                    _party.Size = ((int)PartySizeBox.Value);
                if (MaxPartySizeBox.Value is not 0 or 0)
                    _party.Max = ((int)MaxPartySizeBox.Value);
            }
            catch (Exception partyException)
            {
                Growl.Error(partyException.Message.ToString());
                throw;
            }

            try
            {
                presence = new RichPresence()
                {
                    Details = DetailsBox.Text,
                    State = StateBox.Text,
                    Assets = new Assets()
                    {
                        LargeImageKey = LargeKey.Text,
                        LargeImageText = LargeText.Text,
                        SmallImageKey = SmallKey.Text,
                        SmallImageText = SmallText.Text,
                    },
                    Buttons = _buttons.ToArray(),
                    Party = _party,
                    Timestamps = _timestamps
                };

                await RpcHandler.Instance.StartPresence(ClientIdBox.Text, presence);
                //UserIcon.Source = new BitmapImage(new Uri(RpcHandler.Instance.rpcClient.CurrentUser.GetAvatarURL(User.AvatarFormat.PNG, User.AvatarSize.x256)));
            }
            catch (Exception ex)
            {
                Growl.Error(ex.Message.ToString());
                return;
                //throw;
            }
        }

        private async void PauseMenuItem_Click(object sender, RoutedEventArgs e)
        {
            await RpcHandler.Instance.PausePresence();
        }

        private async void StopMenuItem_Click(object sender, RoutedEventArgs e)
        {
            await RpcHandler.Instance.EndPresence();
        }

        private async void RestartMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion

        private async void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            /*ProfileCreationDialog profileCreationDialog = new ProfileCreationDialog();
            profileCreationDialog.ShowDialog();*/
            try
            {
                RichPresence richPresence = new RichPresence()
                {
                    State = StateBox.Text,
                    Details = DetailsBox.Text,
                    Assets = new Assets()
                    {
                        SmallImageKey = SmallKey.Text,
                        SmallImageText = SmallText.Text,
                        LargeImageKey = LargeKey.Text,
                        LargeImageText = LargeText.Text
                    },
                    Party = _party,
                    Buttons = _buttons.ToArray()
                };
                
                Profile profile = new Profile
                {
                    Name = ProfileNameBox.Text,
                    Presence = richPresence
                };
                SerialisationHandler.Instance.SaveProfile(profile);
            }
            catch (Exception ex)
            {
                Growl.Error(ex.Message);
            }
            //if (RpcHandler.Instance.rpcClient.IsInitialized)
                
        }
    }
}
