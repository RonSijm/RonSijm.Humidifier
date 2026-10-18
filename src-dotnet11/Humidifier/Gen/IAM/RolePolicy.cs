namespace Humidifier.IAM
{
    using global::System.Collections.Generic;

    public class RolePolicy : Humidifier.Base.BaseResource, IHaveRoleName, IHavePolicyName, IHavePolicyDocument_Json
    {
        public override string AWSTypeName { get => AWS.IAM.RolePolicy; }

        /// <summary>
        /// RoleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-rolepolicy.html#cfn-iam-rolepolicy-rolename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleName { get; set; }

        /// <summary>
        /// PolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-rolepolicy.html#cfn-iam-rolepolicy-policyname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyName { get; set; }
        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-rolepolicy.html#cfn-iam-rolepolicy-policydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
    }
}