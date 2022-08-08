namespace QuickRPC.Utils
{
    public sealed class SerialisationHandler
    {
        public List<Profile> profiles;
        public string appDataLocation;
        string _finalLocation;

        private static readonly SerialisationHandler _instance = new SerialisationHandler();

        static SerialisationHandler() { }

        private SerialisationHandler()
        {
            profiles = new List<Profile>();
            var p1 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var p2 = "Quick RPC";
            appDataLocation = System.IO.Path.Combine(p1, p2);
            _finalLocation = System.IO.Path.Combine(appDataLocation, "profiles.json");
            Directory.CreateDirectory(appDataLocation);
        }

        public static SerialisationHandler Instance { get { return _instance; } }


        public void SaveProfile(Profile profile)
        {
            try
            {
                using (StreamWriter file = File.CreateText(_finalLocation))
                {
                    profiles.Add(profile);
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.Serialize(file, profiles);
                }
            }
            catch (Exception ex)
            {
                Growl.Error(ex.Message);
            }
        }

        public List<Profile> GetProfiles()
        {
            if (File.Exists(_finalLocation))
            {
                profiles = JsonConvert.DeserializeObject<List<Profile>>(File.ReadAllText(_finalLocation));

                using (StreamReader file = File.OpenText(_finalLocation))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    profiles = (List<Profile>)serializer.Deserialize(file, typeof(List<Profile>));
                }                
            }
            else
            {

            }
            return profiles;
        }

    }
}
