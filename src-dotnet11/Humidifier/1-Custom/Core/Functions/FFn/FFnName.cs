namespace Humidifier;

public class FFnName(IResultFactory result) : BaseFunction, IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}