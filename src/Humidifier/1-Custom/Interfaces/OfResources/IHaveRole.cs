namespace Humidifier.Interfaces;

public interface IHaveRole : IResourceInterface
{
    public dynamic Role { get; set; }
}