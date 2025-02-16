namespace Ask.NET.Models;

public enum Visibility {
    Public, Limited, Private
}

public class Ask
{
    public string Id { get; set; }
    public User To { get; set; }

    public Visibility Visibility { get; set; }
    public string Warning { get; set; }
    public string Content { get; set; }
    public string Nickname { get; set; }

    public string Response { get; set; }

    public string CreatedAt { get; set; }
}