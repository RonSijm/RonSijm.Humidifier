namespace Humidifier;

public class FFnARN(IResultFactory result) : BaseFunction, IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}