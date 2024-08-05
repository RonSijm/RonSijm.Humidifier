namespace Humidifier.Interfaces;

public interface IHaveKmsKeyId : IResourceInterface
{
    public dynamic KmsKeyId { get; set; }
}