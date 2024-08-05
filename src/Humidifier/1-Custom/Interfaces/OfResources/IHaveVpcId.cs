namespace Humidifier.Interfaces;

public interface IHaveVpcId : IResourceInterface
{
    public dynamic VpcId { get; set; }
}