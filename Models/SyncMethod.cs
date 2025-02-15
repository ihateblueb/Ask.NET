namespace Ask.NET.Models;

public class SyncMethod
{
    public string Id { get; set; }
    public User User { get; set; }
    public string Type { get; set; } // Mastodon
    public string MastodonOauth { get; set; }
}