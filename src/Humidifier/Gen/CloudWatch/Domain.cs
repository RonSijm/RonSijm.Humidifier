namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
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
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.Domain; }
        /// <summary>
        /// IdentityProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domain.html#cfn-cloudwatch-domain-identityproviderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityProviderConfiguration
        /// </summary>
        public Humidifier.CloudWatch.DomainTypes.IdentityProviderConfiguration IdentityProviderConfiguration { get; set; }

        /// <summary>
        /// IdentityProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domain.html#cfn-cloudwatch-domain-identityproviders
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic IdentityProviders { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-domain.html#cfn-cloudwatch-domain-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DomainTypes
    {
        public class IdentityCenterConfiguration : Humidifier.Base.BaseSubResource, IHaveIdentityCenterInstanceArn
        {
            /// <summary>
            /// IdentityCenterInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domain-identitycenterconfiguration.html#cfn-cloudwatch-domain-identitycenterconfiguration-identitycenterinstancearn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-domain-identityproviderconfiguration.html#cfn-cloudwatch-domain-identityproviderconfiguration-identitycenterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IdentityCenterConfiguration
            /// </summary>
            public Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration IdentityCenterConfiguration { get; set; }
        }
    }
}