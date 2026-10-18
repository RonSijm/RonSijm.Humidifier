namespace Humidifier.IAM
{
    using global::System.Collections.Generic;

    public class GroupPolicy : Humidifier.Base.BaseResource, IHaveGroupName, IHavePolicyName, IHavePolicyDocument_Json
    {
        public override string AWSTypeName { get => AWS.IAM.GroupPolicy; }

        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-grouppolicy.html#cfn-iam-grouppolicy-groupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GroupName { get; set; }

        /// <summary>
        /// PolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-grouppolicy.html#cfn-iam-grouppolicy-policyname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyName { get; set; }
        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-grouppolicy.html#cfn-iam-grouppolicy-policydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
    }
}