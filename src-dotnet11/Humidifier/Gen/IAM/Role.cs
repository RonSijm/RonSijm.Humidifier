namespace Humidifier.IAM
{
    using global::System.Collections.Generic;
    using RoleTypes;

    public class Role : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePath, IHaveStringListOfManagedPolicyArns, IHaveMaxSessionDuration_Integer, IHaveRoleName, IHaveDescription, IHaveListOfIAMRoleTypesPolicyPolicies, IHaveAssumeRolePolicyDocument_Json, IHavePermissionsBoundary
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string RoleId =  "RoleId" ;
        }

        public override string AWSTypeName { get => AWS.IAM.Role; }
        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-path
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Path { get; set; }
        /// <summary>
        /// ManagedPolicyArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-managedpolicyarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ManagedPolicyArns { get; set; }
        /// <summary>
        /// MaxSessionDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-maxsessionduration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxSessionDuration { get; set; }
        public Union<string, BaseFunction>? RoleName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-policies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Policy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IAM.RoleTypes.Policy>, IReadOnlyList<Union<Humidifier.IAM.RoleTypes.Policy, BaseFunction>>, BaseFunction>? Policies { get; set; }

        /// <summary>
        /// AssumeRolePolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-assumerolepolicydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? AssumeRolePolicyDocument { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// PermissionsBoundary
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-permissionsboundary
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PermissionsBoundary { get; set; }
    }

    namespace RoleTypes
    {
        public class Policy : Humidifier.Base.BaseSubResource, IHavePolicyName, IHavePolicyDocument_Json
        {
            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-role-policy.html#cfn-iam-role-policy-policyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyName { get; set; }
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-role-policy.html#cfn-iam-role-policy-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? PolicyDocument { get; set; }
        }
    }
}