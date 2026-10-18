namespace Humidifier;

/// <summary>
/// UpdatePolicy
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-updatepolicy.html
/// </summary>
public class UpdatePolicy
{
    public AutoScalingReplacingUpdate AutoScalingReplacingUpdate { get; set; }
    public AutoScalingRollingUpdate AutoScalingRollingUpdate { get; set; }
    public AutoScalingScheduledAction AutoScalingScheduledAction { get; set; }
}