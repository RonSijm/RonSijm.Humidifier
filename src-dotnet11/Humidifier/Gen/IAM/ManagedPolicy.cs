namespace Humidifier.IAM
{
    using global::System.Collections.Generic;

    public class ManagedPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveManagedPolicyName, IHavePath, IHaveDescription, IHaveStringListOfGroups, IHavePolicyDocument_Json, IHaveStringListOfRoles, IHaveStringListOfUsers
    {
        public class Attributes
        {
            public static string IsAttachable =  "IsAttachable" ;
            public static string UpdateDate =  "UpdateDate" ;
            public static string PermissionsBoundaryUsageCount =  "PermissionsBoundaryUsageCount" ;
            public static string AttachmentCount =  "AttachmentCount" ;
            public static string PolicyArn =  "PolicyArn" ;
            public static string DefaultVersionId =  "DefaultVersionId" ;
            public static string CreateDate =  "CreateDate" ;
            public static string PolicyId =  "PolicyId" ;
        }

        public override string AWSTypeName { get => AWS.IAM.ManagedPolicy; }
        public Union<string, BaseFunction>? ManagedPolicyName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-managedpolicy.html#cfn-iam-managedpolicy-path
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Path { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-managedpolicy.html#cfn-iam-managedpolicy-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Groups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-managedpolicy.html#cfn-iam-managedpolicy-groups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Groups { get; set; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-managedpolicy.html#cfn-iam-managedpolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyDocument { get; set; }
        /// <summary>
        /// Roles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-managedpolicy.html#cfn-iam-managedpolicy-roles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Roles { get; set; }
        /// <summary>
        /// Users
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-managedpolicy.html#cfn-iam-managedpolicy-users
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Users { get; set; }
    }
}