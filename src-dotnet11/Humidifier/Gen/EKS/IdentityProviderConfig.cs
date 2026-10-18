namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using IdentityProviderConfigTypes;

    public class IdentityProviderConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveClusterName, IHaveIdentityProviderConfigName, IHaveEKSIdentityProviderConfigTypesOidcIdentityProviderConfigOidc
    {
        public class Attributes
        {
            public static string IdentityProviderConfigArn =  "IdentityProviderConfigArn" ;
        }

        public override string AWSTypeName { get => AWS.EKS.IdentityProviderConfig; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterName { get; set; }
        public Union<string, BaseFunction>? IdentityProviderConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Oidc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-oidc
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OidcIdentityProviderConfig
        /// </summary>
        public Union<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig, BaseFunction>? Oidc { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IdentityProviderConfigTypes
    {
        public class OidcIdentityProviderConfig : Humidifier.Base.BaseSubResource, IHaveUsernamePrefix, IHaveGroupsPrefix, IHaveIssuerUrl, IHaveListOfEKSIdentityProviderConfigTypesRequiredClaimRequiredClaims, IHaveClientId, IHaveGroupsClaim, IHaveUsernameClaim
        {
            /// <summary>
            /// UsernamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-usernameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsernamePrefix { get; set; }
            /// <summary>
            /// GroupsPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-groupsprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupsPrefix { get; set; }
            /// <summary>
            /// IssuerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-issuerurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IssuerUrl { get; set; }
            /// <summary>
            /// RequiredClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-requiredclaims
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RequiredClaim
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.IdentityProviderConfigTypes.RequiredClaim>, IReadOnlyList<Union<Humidifier.EKS.IdentityProviderConfigTypes.RequiredClaim, BaseFunction>>, BaseFunction>? RequiredClaims { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-clientid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// GroupsClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-groupsclaim
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupsClaim { get; set; }
            /// <summary>
            /// UsernameClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-usernameclaim
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsernameClaim { get; set; }
        }

        public class RequiredClaim : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-requiredclaim.html#cfn-eks-identityproviderconfig-requiredclaim-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-requiredclaim.html#cfn-eks-identityproviderconfig-requiredclaim-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}