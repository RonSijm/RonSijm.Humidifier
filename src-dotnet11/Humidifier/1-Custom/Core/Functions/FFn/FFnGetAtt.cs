namespace Humidifier;

public class FFnGetAtt(IResultFactory result, string attributeName) : BaseFunction, IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
    public string AttributeName { get; set; } = attributeName;
}