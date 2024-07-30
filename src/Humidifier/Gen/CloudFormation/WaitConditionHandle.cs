namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class WaitConditionHandle : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CloudFormation::WaitConditionHandle";
            }
        }
    }
}