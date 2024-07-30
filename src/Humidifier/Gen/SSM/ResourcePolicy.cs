namespace Humidifier.SSM
{
    using System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string PolicyHash =  "PolicyHash" ;
            public static string PolicyId =  "PolicyId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SSM::ResourcePolicy";
            }
        }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcepolicy.html#cfn-ssm-resourcepolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Policy { get; set; }
        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcepolicy.html#cfn-ssm-resourcepolicy-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceArn { get; set; }
    }
}