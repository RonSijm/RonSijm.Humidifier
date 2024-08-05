namespace Humidifier.Interfaces;

public interface IHaveDescription : IResourceInterface
{
    public dynamic Description { get; set; }
}