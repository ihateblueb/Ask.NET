using IniParser;
using IniParser.Model;

namespace Ask.NET.Core;


public enum RegistrationOption
{
    Open, Invite, Closed
}

public class Config
{
    public string Host { get; set; }
    public int Port { get; set; }
    public RegistrationOption Registrations { get; set; }
    public DatabaseSection Database { get; set; }
    public LimitsSection Limits { get; set; }
}

public class DatabaseSection
{
    public int Port { get; set; }
    public string Host { get; set; }
    public string Name { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
}

public class LimitsSection
{
    public int Username { get; set; }
    public int Password { get; set; }
    public int Prompt { get; set; }
    public int ContentWarning { get; set; }
    public int Ask { get; set; }
    public int Url { get; set; }
    public int Alt { get; set; }
}