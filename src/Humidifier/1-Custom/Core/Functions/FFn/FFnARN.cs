namespace Humidifier;

public interface IHaveResultFactory
{
    public IResultFactory Result { get; set; }
}

public class FFnARN(IResultFactory result) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}

public class FFnGetAtt(IResultFactory result, string attributeName) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
    public string AttributeName { get; set; } = attributeName;
}