using IniParser;
using IniParser.Model;

namespace Ask.NET.Core;

public class Config
{
    public static IniData? get()
    {
        // todo: bad!! rewrite
        var parser = new FileIniDataParser();
        return parser.ReadFile(Environment.GetEnvironmentVariable("ASKNET_CONFIG") ?? "configuration.ini");
    }
}