namespace QuickRPC.Pages
{
    /// <summary>
    /// Interaction logic for KeybindsPage.xaml
    /// </summary>
    public partial class KeybindsPage : Page
    {
        public KeybindsPage()
        {
            InitializeComponent();
            HotkeysManager.SetupSystemHook();

            GlobalHotkey p1Hotkey = new GlobalHotkey(ModifierKeys.Control, Key.F1, null);
            GlobalHotkey p2Hotkey = new GlobalHotkey(ModifierKeys.Control, Key.F1, null);
            GlobalHotkey p3Hotkey = new GlobalHotkey(ModifierKeys.Control, Key.F1, null);
            GlobalHotkey p4Hotkey = new GlobalHotkey(ModifierKeys.Control, Key.F1, null);
            GlobalHotkey p5Hotkey = new GlobalHotkey(ModifierKeys.Control, Key.F1, null);
            GlobalHotkey p6Hotkey = new GlobalHotkey(ModifierKeys.Control, Key.F1, null);

            HotkeysManager.AddHotkey(p1Hotkey);
            HotkeysManager.AddHotkey(p2Hotkey);
            HotkeysManager.AddHotkey(p3Hotkey);
            HotkeysManager.AddHotkey(p4Hotkey);
            HotkeysManager.AddHotkey(p5Hotkey);
            HotkeysManager.AddHotkey(p6Hotkey);

            string[] baseKeys = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] modifierKeys = new string[] { "CTRL", "Alt", "Windows", "Shift", "None" };
            foreach (var modifierkey in modifierKeys)
            {
                P1_ModifierBox.Items.Add(modifierkey);
                P2_ModifierBox.Items.Add(modifierkey);
                P3_ModifierBox.Items.Add(modifierkey);
                P4_ModifierBox.Items.Add(modifierkey);
                P5_ModifierBox.Items.Add(modifierkey);
                P6_ModifierBox.Items.Add(modifierkey);
            }
            foreach (var key in baseKeys)
            {
                P1_KeyBox.Items.Add(key);
                P2_KeyBox.Items.Add(key);
                P3_KeyBox.Items.Add(key);
                P4_KeyBox.Items.Add(key);
                P5_KeyBox.Items.Add(key);
                P6_KeyBox.Items.Add(key);
            }
        }

        private void P1_ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            P1_ModifierBox.IsEnabled = true;
            P1_KeyBox.IsEnabled = true;
        }
    }
}
