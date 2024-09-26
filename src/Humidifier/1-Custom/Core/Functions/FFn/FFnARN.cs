namespace Humidifier;

public class FFnARN(IResultFactory result) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}