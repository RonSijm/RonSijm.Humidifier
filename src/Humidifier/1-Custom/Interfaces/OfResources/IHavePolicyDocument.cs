namespace Humidifier.Interfaces;

public interface IHavePolicyDocument : IResourceInterface
{
    public dynamic PolicyDocument { get; set; }
}