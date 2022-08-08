namespace QuickRPC.Hotkeys
{
    public class GlobalHotkey
    {
        public ModifierKeys Modifier { get; set; }
        public Key Key { get; set; }
        public Action Callback { get; set; }
        public bool CanExecute { get; set; }

        public GlobalHotkey(ModifierKeys modifier, Key key, Action callback, bool canExecute = true)
        {
            Modifier = modifier;
            Key = key;
            Callback = callback;
            CanExecute = canExecute;
        }
    }
}
