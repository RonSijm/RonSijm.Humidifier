namespace Humidifier.CertificateManager
{
    using global::System.Collections.Generic;
    using AcmeDomainValidationTypes;

    public class AcmeDomainValidation : Humidifier.Base.BaseResource, IHaveDomainName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CertificateManager.AcmeDomainValidation; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmedomainvalidation.html#cfn-certificatemanager-acmedomainvalidation-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DomainName { get; set; }

        /// <summary>
        /// PrevalidationOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmedomainvalidation.html#cfn-certificatemanager-acmedomainvalidation-prevalidationoptions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PrevalidationOptions
        /// </summary>
        [Required]
        public Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions PrevalidationOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmedomainvalidation.html#cfn-certificatemanager-acmedomainvalidation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.CertificateManager.AcmeDomainValidationTypes.TagsItems> Tags { get; set; }

        /// <summary>
        /// AcmeEndpointArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-certificatemanager-acmedomainvalidation.html#cfn-certificatemanager-acmedomainvalidation-acmeendpointarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AcmeEndpointArn { get; set; }
    }

    namespace AcmeDomainValidationTypes
    {
        public class DnsPrevalidationOptions : Humidifier.Base.BaseSubResource, IHaveHostedZoneId
        {
            /// <summary>
            /// DomainScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmedomainvalidation-dnsprevalidationoptions.html#cfn-certificatemanager-acmedomainvalidation-dnsprevalidationoptions-domainscope
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DomainScope
            /// </summary>
            public Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope DomainScope { get; set; }
            /// <summary>
            /// HostedZoneId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmedomainvalidation-dnsprevalidationoptions.html#cfn-certificatemanager-acmedomainvalidation-dnsprevalidationoptions-hostedzoneid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostedZoneId { get; set; }
        }

        public class DomainScope : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Wildcards
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmedomainvalidation-domainscope.html#cfn-certificatemanager-acmedomainvalidation-domainscope-wildcards
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Wildcards { get; set; }
            /// <summary>
            /// ExactDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmedomainvalidation-domainscope.html#cfn-certificatemanager-acmedomainvalidation-domainscope-exactdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExactDomain { get; set; }
            /// <summary>
            /// Subdomains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmedomainvalidation-domainscope.html#cfn-certificatemanager-acmedomainvalidation-domainscope-subdomains
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Subdomains { get; set; }
        }

        public class PrevalidationOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DnsPrevalidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmedomainvalidation-prevalidationoptions.html#cfn-certificatemanager-acmedomainvalidation-prevalidationoptions-dnsprevalidation
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DnsPrevalidationOptions
            /// </summary>
            public Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions DnsPrevalidation { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmedomainvalidation-tagsitems.html#cfn-certificatemanager-acmedomainvalidation-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-certificatemanager-acmedomainvalidation-tagsitems.html#cfn-certificatemanager-acmedomainvalidation-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}