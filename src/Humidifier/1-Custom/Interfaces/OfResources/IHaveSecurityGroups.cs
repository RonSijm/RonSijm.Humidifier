namespace Humidifier.Interfaces;

public interface IHaveSecurityGroups : IResourceInterface
{
    public dynamic SecurityGroups { get; set; }
}