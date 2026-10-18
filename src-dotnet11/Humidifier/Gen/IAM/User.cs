namespace Humidifier.IAM
{
    using global::System.Collections.Generic;
    using UserTypes;

    public class User : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePath, IHaveStringListOfManagedPolicyArns, IHaveListOfIAMUserTypesPolicyPolicies, IHaveUserName, IHaveStringListOfGroups, IHaveIAMUserTypesLoginProfileLoginProfile, IHavePermissionsBoundary
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IAM.User; }
        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-user.html#cfn-iam-user-path
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Path { get; set; }
        /// <summary>
        /// ManagedPolicyArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-user.html#cfn-iam-user-managedpolicyarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ManagedPolicyArns { get; set; }
        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-user.html#cfn-iam-user-policies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Policy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IAM.UserTypes.Policy>, IReadOnlyList<Union<Humidifier.IAM.UserTypes.Policy, BaseFunction>>, BaseFunction>? Policies { get; set; }
        public Union<string, BaseFunction>? UserName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Groups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-user.html#cfn-iam-user-groups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Groups { get; set; }
        /// <summary>
        /// LoginProfile
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-user.html#cfn-iam-user-loginprofile
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoginProfile
        /// </summary>
        public Union<Humidifier.IAM.UserTypes.LoginProfile, BaseFunction>? LoginProfile { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-user.html#cfn-iam-user-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// PermissionsBoundary
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-user.html#cfn-iam-user-permissionsboundary
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PermissionsBoundary { get; set; }
    }

    namespace UserTypes
    {
        public class LoginProfile : Humidifier.Base.BaseSubResource, IHavePasswordResetRequired_Boolean, IHavePassword
        {
            /// <summary>
            /// PasswordResetRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user-loginprofile.html#cfn-iam-user-loginprofile-passwordresetrequired
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PasswordResetRequired { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user-loginprofile.html#cfn-iam-user-loginprofile-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class Policy : Humidifier.Base.BaseSubResource, IHavePolicyName, IHavePolicyDocument_Json
        {
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user-policy.html#cfn-iam-user-policy-policyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-user-policy.html#cfn-iam-user-policy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? PolicyDocument { get; set; }
        }
    }
}