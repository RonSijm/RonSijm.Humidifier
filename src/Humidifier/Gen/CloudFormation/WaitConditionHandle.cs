namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class WaitConditionHandle : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName { get => AWS.CloudFormation.WaitConditionHandle; }
    }
}