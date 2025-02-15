namespace Ask.NET.Models;

public class Auth
{
    public string Id { get; set; }
    public User User { get; set; }
    public string Token { get; set; }
    public string CreatedAt { get; set; }
}