using System;

namespace Humidifier;

/// <summary>
/// The Fn::GetAtt intrinsic function returns the value of an attribute from a resource in the template.
/// 
/// Example: This example snippet returns a string containing the DNS name of the load balancer with the logical name myELB.
/// 
/// { "Fn::GetAtt" : [ "myELB" , "DNSName" ] }
/// 
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-getatt.html
/// </summary>
public class FnGetAtt : BaseFunction
{
    public string LogicalNameOfResource { get; }
    public string AttributeName { get; }

    public FnGetAtt(string logicalNameOfResource, string attributeName)
    {
        LogicalNameOfResource = logicalNameOfResource ?? throw new ArgumentNullException(nameof(logicalNameOfResource));
        AttributeName = attributeName ?? throw new ArgumentNullException(nameof(attributeName));
    }
}