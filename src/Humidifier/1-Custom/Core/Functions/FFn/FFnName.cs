namespace Humidifier;

public class FFnName(IResultFactory result) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}