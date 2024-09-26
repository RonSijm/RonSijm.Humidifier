using System;

namespace Humidifier;

/// <summary>
/// The intrinsic function Fn::Base64 returns the Base64 representation of the input string. This function is typically used to pass 
/// encoded data to Amazon EC2 instances by way of the UserData property.
/// 
/// Example:
/// 
/// { "Fn::Base64" : "AWS CloudFormation" }
/// 
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-base64.html
///  </summary>
public class FnBase64 : BaseFunction
{
    public dynamic ValueToEncode { get; }
    public FnBase64(dynamic valueToEncode) => ValueToEncode = valueToEncode ?? throw new ArgumentNullException(nameof(valueToEncode));
}