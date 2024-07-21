namespace Humidifier.EKS
{
    using System.Collections.Generic;
    using IdentityProviderConfigTypes;

    public class IdentityProviderConfig : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string IdentityProviderConfigArn =  "IdentityProviderConfigArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EKS::IdentityProviderConfig";
            }
        }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterName { get; set; }
        /// <summary>
        /// IdentityProviderConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-identityproviderconfigname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IdentityProviderConfigName { get; set; }
        /// <summary>
        /// Oidc
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-oidc
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OidcIdentityProviderConfig
        /// </summary>
        public OidcIdentityProviderConfig Oidc { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-identityproviderconfig.html#cfn-eks-identityproviderconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace IdentityProviderConfigTypes
    {
        public class OidcIdentityProviderConfig
        {
            /// <summary>
            /// UsernamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-usernameprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsernamePrefix { get; set; }
            /// <summary>
            /// GroupsPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-groupsprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupsPrefix { get; set; }
            /// <summary>
            /// IssuerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-issuerurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IssuerUrl { get; set; }
            /// <summary>
            /// RequiredClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-requiredclaims
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RequiredClaim
            /// </summary>
            public List<RequiredClaim> RequiredClaims { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-clientid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// GroupsClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-groupsclaim
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupsClaim { get; set; }
            /// <summary>
            /// UsernameClaim
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-oidcidentityproviderconfig.html#cfn-eks-identityproviderconfig-oidcidentityproviderconfig-usernameclaim
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsernameClaim { get; set; }
        }

        public class RequiredClaim
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-requiredclaim.html#cfn-eks-identityproviderconfig-requiredclaim-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-identityproviderconfig-requiredclaim.html#cfn-eks-identityproviderconfig-requiredclaim-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}