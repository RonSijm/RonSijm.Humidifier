using System.Collections.Generic;
using Humidifier.Base;

namespace Humidifier;

public class PolicyDocument : BaseResource
{
    public override string AWSTypeName
    {
        get
        {
            return @"AWS::PolicyDocument";
        }
    }

    public string Version { get; set; }
    public string Id { get; set; }
    public List<Statement> Statement { get; set; }
}