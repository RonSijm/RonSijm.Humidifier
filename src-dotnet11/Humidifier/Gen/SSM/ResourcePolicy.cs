namespace Humidifier.SSM
{
    using global::System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHavePolicy_Json, IHaveResourceArn
    {
        public class Attributes
        {
            public static string PolicyHash =  "PolicyHash" ;
            public static string PolicyId =  "PolicyId" ;
        }

        public override string AWSTypeName { get => AWS.SSM.ResourcePolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcepolicy.html#cfn-ssm-resourcepolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Policy { get; set; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcepolicy.html#cfn-ssm-resourcepolicy-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceArn { get; set; }
    }
}