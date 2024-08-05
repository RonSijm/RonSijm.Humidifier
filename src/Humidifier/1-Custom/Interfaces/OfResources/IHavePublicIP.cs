namespace Humidifier.Interfaces;

public interface IHavePublicIP : IResourceInterface
{
    public dynamic AssignPublicIp { get; set; }
}