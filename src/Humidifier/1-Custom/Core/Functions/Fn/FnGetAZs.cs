using System;

namespace Humidifier;

/// <summary>
/// The intrinsic function Fn::GetAZs returns an array that lists Availability Zones for a specified region. 
/// Because customers have access to different Availability Zones, the intrinsic function Fn::GetAZs enables template authors to write templates that adapt to 
/// the calling user's access. That way you don't have to hard-code a full list of Availability Zones for a specified region.
/// 
/// Example:
/// 
/// { "Fn::GetAZs" : "" }
/// { "Fn::GetAZs" : { "Ref" : "AWS::Region" } }
/// { "Fn::GetAZs" : "us-east-2" }
/// 
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getavailabilityzones.html
/// </summary>
public class FnGetAZs
{
    public dynamic Region { get; }

    public FnGetAZs(dynamic region)
    {
        Region = region ?? throw new ArgumentNullException(nameof(region));
    }
}