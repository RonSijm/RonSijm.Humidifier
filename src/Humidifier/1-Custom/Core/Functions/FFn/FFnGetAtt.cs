namespace Humidifier;

public class FFnGetAtt(IResultFactory result, string attributeName) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
    public string AttributeName { get; set; } = attributeName;
}