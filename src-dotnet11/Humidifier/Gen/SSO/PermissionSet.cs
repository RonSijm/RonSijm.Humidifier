namespace Humidifier.SSO
{
    using global::System.Collections.Generic;
    using PermissionSetTypes;

    public class PermissionSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRelayStateType, IHaveListOfSSOPermissionSetTypesCustomerManagedPolicyReferenceCustomerManagedPolicyReferences, IHaveSessionDuration, IHaveDescription, IHaveInstanceArn, IHaveInlinePolicy_Json, IHaveStringListOfManagedPolicies, IHaveName, IHaveSSOPermissionSetTypesPermissionsBoundaryPermissionsBoundary
    {
        public class Attributes
        {
            public static string PermissionSetArn =  "PermissionSetArn" ;
        }

        public override string AWSTypeName { get => AWS.SSO.PermissionSet; }
        /// <summary>
        /// RelayStateType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-relaystatetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RelayStateType { get; set; }
        /// <summary>
        /// CustomerManagedPolicyReferences
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-customermanagedpolicyreferences
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CustomerManagedPolicyReference
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference>, IReadOnlyList<Union<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference, BaseFunction>>, BaseFunction>? CustomerManagedPolicyReferences { get; set; }
        /// <summary>
        /// SessionDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-sessionduration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SessionDuration { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// InlinePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-inlinepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? InlinePolicy { get; set; }
        /// <summary>
        /// ManagedPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-managedpolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ManagedPolicies { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PermissionsBoundary
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-permissionset.html#cfn-sso-permissionset-permissionsboundary
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PermissionsBoundary
        /// </summary>
        public Union<Humidifier.SSO.PermissionSetTypes.PermissionsBoundary, BaseFunction>? PermissionsBoundary { get; set; }
    }

    namespace PermissionSetTypes
    {
        public class CustomerManagedPolicyReference : Humidifier.Base.BaseSubResource, IHavePath, IHaveName
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-permissionset-customermanagedpolicyreference.html#cfn-sso-permissionset-customermanagedpolicyreference-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-permissionset-customermanagedpolicyreference.html#cfn-sso-permissionset-customermanagedpolicyreference-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PermissionsBoundary : Humidifier.Base.BaseSubResource, IHaveSSOPermissionSetTypesCustomerManagedPolicyReferenceCustomerManagedPolicyReference, IHaveManagedPolicyArn
        {
            /// <summary>
            /// CustomerManagedPolicyReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-permissionset-permissionsboundary.html#cfn-sso-permissionset-permissionsboundary-customermanagedpolicyreference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedPolicyReference
            /// </summary>
            public Union<Humidifier.SSO.PermissionSetTypes.CustomerManagedPolicyReference, BaseFunction>? CustomerManagedPolicyReference { get; set; }
            /// <summary>
            /// ManagedPolicyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-permissionset-permissionsboundary.html#cfn-sso-permissionset-permissionsboundary-managedpolicyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedPolicyArn { get; set; }
        }
    }
}