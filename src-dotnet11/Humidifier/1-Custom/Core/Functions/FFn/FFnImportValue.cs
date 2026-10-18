namespace Humidifier;

public class FFnImportValue(IResultFactory result) : BaseFunction, IHaveResultFactory
{
    public IResultFactory Result { get; set; } = result;
}