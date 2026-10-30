namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using DomainForOrganizationTypes;

    public class DomainForOrganization : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainAccessRoleArn, IHaveCloudWatchDomainForOrganizationTypesIdentityProviderConfigurationIdentityProviderConfiguration, IHaveStringListOfIdentityProviders, IHaveName
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
        public Union<string, BaseFunction>? DomainAccessRoleArn { get; set; }
        /// <summary>
        /// IdentityProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainfororganization.html#cfn-cloudwatch-domainfororganization-identityproviderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityProviderConfiguration
        /// </summary>
        public Union<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityProviderConfiguration, BaseFunction>? IdentityProviderConfiguration { get; set; }

        /// <summary>
        /// IdentityProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainfororganization.html#cfn-cloudwatch-domainfororganization-identityproviders
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IdentityProviders { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domainfororganization.html#cfn-cloudwatch-domainfororganization-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
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
            public Union<string, BaseFunction>? IdentityCenterInstanceArn { get; set; }
        }

        public class IdentityProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveCloudWatchDomainForOrganizationTypesIdentityCenterConfigurationIdentityCenterConfiguration
        {
            /// <summary>
            /// IdentityCenterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domainfororganization-identityproviderconfiguration.html#cfn-cloudwatch-domainfororganization-identityproviderconfiguration-identitycenterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdentityCenterConfiguration
            /// </summary>
            public Union<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration, BaseFunction>? IdentityCenterConfiguration { get; set; }
        }
    }
}