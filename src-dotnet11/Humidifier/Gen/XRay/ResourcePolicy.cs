namespace Humidifier.XRay
{
    using global::System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Base.BaseResource, IHaveBypassPolicyLockoutCheck_Boolean, IHavePolicyName, IHavePolicyDocument
    {
        public override string AWSTypeName { get => AWS.XRay.ResourcePolicy; }
        /// <summary>
        /// BypassPolicyLockoutCheck
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-resourcepolicy.html#cfn-xray-resourcepolicy-bypasspolicylockoutcheck
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? BypassPolicyLockoutCheck { get; set; }

        /// <summary>
        /// PolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-resourcepolicy.html#cfn-xray-resourcepolicy-policyname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyName { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-xray-resourcepolicy.html#cfn-xray-resourcepolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyDocument { get; set; }
    }
}