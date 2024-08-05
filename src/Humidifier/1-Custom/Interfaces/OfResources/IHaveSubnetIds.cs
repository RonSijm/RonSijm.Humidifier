namespace Humidifier.Interfaces;

public interface IHaveSubnetIds : IResourceInterface
{
    public dynamic SubnetIds { get; set; }
}