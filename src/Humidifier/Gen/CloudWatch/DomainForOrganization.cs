namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using DomainForOrganizationTypes;

    public class DomainForOrganization : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IdentityCenterApplicationArn =  "IdentityCenterApplicationArn" ;
            public static string DomainId =  "DomainId" ;
            public static string CustomEndpointUrls =  "CustomEndpointUrls" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Region =  "Region" ;
            public static string DomainEndpointUrl =  "DomainEndpointUrl" ;
            public static string OrganizationId =  "OrganizationId" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.DomainForOrganization; }

        /// <summary>
        /// DomainAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainfororganization.html#cfn-cloudwatch-domainfororganization-domainaccessrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainAccessRoleArn { get; set; }
        /// <summary>
        /// IdentityProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainfororganization.html#cfn-cloudwatch-domainfororganization-identityproviderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityProviderConfiguration
        /// </summary>
        public Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration IdentityProviderConfiguration { get; set; }

        /// <summary>
        /// IdentityProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainfororganization.html#cfn-cloudwatch-domainfororganization-identityproviders
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic IdentityProviders { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainfororganization.html#cfn-cloudwatch-domainfororganization-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DomainForOrganizationTypes
    {
        public class IdentityCenterConfiguration : Humidifier.Base.BaseSubResource, IHaveIdentityCenterInstanceArn
        {
            /// <summary>
            /// IdentityCenterInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domainfororganization-identitycenterconfiguration.html#cfn-cloudwatch-domainfororganization-identitycenterconfiguration-identitycenterinstancearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdentityCenterInstanceArn { get; set; }
        }

        public class IdentityProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdentityCenterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domainfororganization-identityproviderconfiguration.html#cfn-cloudwatch-domainfororganization-identityproviderconfiguration-identitycenterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdentityCenterConfiguration
            /// </summary>
            public Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration IdentityCenterConfiguration { get; set; }
        }
    }
}