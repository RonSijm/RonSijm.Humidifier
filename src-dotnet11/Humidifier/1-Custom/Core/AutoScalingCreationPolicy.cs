namespace Humidifier;

public class AutoScalingCreationPolicy
{
    /// <summary>
    /// PrimitiveType: Integer
    /// </summary>
    public Union<int, BaseFunction>? MinSuccessfulInstancesPercent { get; set; }
}