namespace Humidifier;

public class Output
{
    public Union<string, BaseFunction>? Value { get; set; }
    public Union<OutputExport, BaseFunction>? Export { get; set; }
    public Union<string, BaseFunction>? Description { get; set; }
    public Union<string, BaseFunction>? Condition { get; set; }
}

public class OutputExport
{
    public Union<string, BaseFunction>? Name { get; set; }
}
