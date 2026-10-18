namespace Humidifier;

public class ResourceSignal
{
    /// <summary>
    /// PrimitiveType: Integer
    /// </summary>
    public Union<int, BaseFunction>? Count { get; set; }

    /// <summary>
    /// PrimitiveType: String
    /// </summary>
    public Union<string, BaseFunction>? Timeout { get; set; }
}