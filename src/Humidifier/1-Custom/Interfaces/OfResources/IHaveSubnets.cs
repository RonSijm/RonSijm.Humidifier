namespace Humidifier.Interfaces;

public interface IHaveSubnets : IResourceInterface
{
    public dynamic Subnets { get; set; }
}