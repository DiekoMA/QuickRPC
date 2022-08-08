namespace QuickRPC.Models
{
    public class DiscordApplication
    {
        public string? Id { get; set; }
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public AppType? Type { get; set; }
        public Tag? AppTag { get; set; }
    }

    public enum AppType
    {
        Imported,
        Created
    }
}
