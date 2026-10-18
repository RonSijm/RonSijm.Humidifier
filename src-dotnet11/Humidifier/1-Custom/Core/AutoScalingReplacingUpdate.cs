namespace Humidifier;

/// <summary>
/// AutoScalingReplacingUpdate
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-updatepolicy.html#cfn-attributes-updatepolicy-replacingupdate
/// </summary>
public class AutoScalingReplacingUpdate
{
    /// <summary>
    /// PrimitiveType: Boolean
    /// </summary>
    public Union<bool, BaseFunction>? WillReplace { get; set; }
}