namespace Humidifier;

public class FFnREF(IResultFactory result) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}

public class FFnName(IResultFactory result) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}