namespace Ask.NET.Models;

public class Ask
{
    public string Id { get; set; }
    public string To { get; set; } // Username

    public string Visibility { get; set; } // Public, Limited, Private
    public string Warning { get; set; }
    public string Content { get; set; }
    public string Nickname { get; set; }

    public string Response { get; set; }

    public string CreatedAt { get; set; }
}