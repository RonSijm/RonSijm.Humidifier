namespace Humidifier.CloudTrail
{
    using global::System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHaveResourceArn, IHaveResourcePolicy__Json
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
        public Union<string, BaseFunction>? ResourceArn { get; set; }

        /// <summary>
        /// ResourcePolicy_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-resourcepolicy.html#cfn-cloudtrail-resourcepolicy-resourcepolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? ResourcePolicy_ { get; set; }
    }
}