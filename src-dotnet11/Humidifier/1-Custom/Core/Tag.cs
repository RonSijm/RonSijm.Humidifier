namespace Humidifier;

public class Tag
{
    public Union<string, BaseFunction>? Key { get; set; }
    public Union<string, BaseFunction>? Value { get; set; }
}
