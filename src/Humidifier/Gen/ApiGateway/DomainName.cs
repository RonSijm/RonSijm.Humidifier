namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;
    using DomainNameTypes;

    public class DomainName : Humidifier.Base.BaseResource, IHaveTags, IHaveCertificateArn, IHaveDomainName_, IHaveSecurityPolicy
    {
        public class Attributes
        {
            public static string RegionalHostedZoneId =  "RegionalHostedZoneId" ;
            public static string RegionalDomainName =  "RegionalDomainName" ;
            public static string DistributionHostedZoneId =  "DistributionHostedZoneId" ;
            public static string DistributionDomainName =  "DistributionDomainName" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.DomainName; }
        /// <summary>
        /// MutualTlsAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-mutualtlsauthentication
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MutualTlsAuthentication
        /// </summary>
        public Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication MutualTlsAuthentication { get; set; }
        /// <summary>
        /// OwnershipVerificationCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-ownershipverificationcertificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OwnershipVerificationCertificateArn { get; set; }
        /// <summary>
        /// DomainName_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-domainname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainName_ { get; set; }
        /// <summary>
        /// SecurityPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-securitypolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SecurityPolicy { get; set; }
        /// <summary>
        /// EndpointConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-endpointconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EndpointConfiguration
        /// </summary>
        public Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration EndpointConfiguration { get; set; }
        /// <summary>
        /// RegionalCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-regionalcertificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RegionalCertificateArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-certificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateArn { get; set; }
    }

    namespace DomainNameTypes
    {
        public class EndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveTypes
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-endpointconfiguration.html#cfn-apigateway-domainname-endpointconfiguration-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types { get; set; }
        }

        public class MutualTlsAuthentication : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TruststoreVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-mutualtlsauthentication.html#cfn-apigateway-domainname-mutualtlsauthentication-truststoreversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TruststoreVersion { get; set; }
            /// <summary>
            /// TruststoreUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-mutualtlsauthentication.html#cfn-apigateway-domainname-mutualtlsauthentication-truststoreuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TruststoreUri { get; set; }
        }
    }
}