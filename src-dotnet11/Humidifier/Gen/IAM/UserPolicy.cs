namespace Humidifier.IAM
{
    using global::System.Collections.Generic;

    public class UserPolicy : Humidifier.Base.BaseResource, IHaveUserName, IHavePolicyName, IHavePolicyDocument_Json
    {
        public override string AWSTypeName { get => AWS.IAM.UserPolicy; }

        /// <summary>
        /// UserName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-userpolicy.html#cfn-iam-userpolicy-username
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserName { get; set; }

        /// <summary>
        /// PolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-userpolicy.html#cfn-iam-userpolicy-policyname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyName { get; set; }
        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-userpolicy.html#cfn-iam-userpolicy-policydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
    }
}