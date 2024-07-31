namespace Humidifier;

public interface IHaveResultFactory
{
    public IResultFactory Result { get; set; }
}

public class FFnARN(IResultFactory result) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}