namespace Humidifier.Interfaces;

public interface IHaveExecutionRole : IResourceInterface
{
    public dynamic ExecutionRole { get; set; }
}