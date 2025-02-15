namespace Ask.NET.Models;

public class User
{
    public string Id { get; set; }
    public string Username { get; set; }

    public string Prompt { get; set; }
    public string SyncMethods { get; set; }

    public string Image { get; set; }
    public string ImageAlt { get; set; }

    public string CreatedAt { get; set; }
}