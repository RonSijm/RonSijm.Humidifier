namespace Humidifier;

public class FFnImportValue(IResultFactory result) : IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}