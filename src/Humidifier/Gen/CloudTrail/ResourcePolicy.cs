namespace Humidifier.CloudTrail
{
    using System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHaveResourceArn
    {
        public override string AWSTypeName { get => AWS.CloudTrail.ResourcePolicy; }

        /// <summary>
        /// ResourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-resourcepolicy.html#cfn-cloudtrail-resourcepolicy-resourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceArn { get; set; }

        /// <summary>
        /// ResourcePolicy_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-resourcepolicy.html#cfn-cloudtrail-resourcepolicy-resourcepolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic ResourcePolicy_ { get; set; }
    }
}