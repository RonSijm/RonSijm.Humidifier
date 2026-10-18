namespace Humidifier.ApiGateway
{
    using global::System.Collections.Generic;
    using DomainNameTypes;

    public class DomainName : Humidifier.Base.BaseResource, IHaveTags, IHaveOwnershipVerificationCertificateArn, IHaveApiGatewayDomainNameTypesMutualTlsAuthenticationMutualTlsAuthentication, IHaveRoutingMode, IHaveDomainName_, IHaveSecurityPolicy, IHaveApiGatewayDomainNameTypesEndpointConfigurationEndpointConfiguration, IHaveRegionalCertificateArn, IHaveCertificateArn, IHaveEndpointAccessMode
    {
        public class Attributes
        {
            public static string RegionalHostedZoneId =  "RegionalHostedZoneId" ;
            public static string RegionalDomainName =  "RegionalDomainName" ;
            public static string DomainNameArn =  "DomainNameArn" ;
            public static string DistributionHostedZoneId =  "DistributionHostedZoneId" ;
            public static string DistributionDomainName =  "DistributionDomainName" ;
        }

        public override string AWSTypeName { get => AWS.ApiGateway.DomainName; }
        /// <summary>
        /// OwnershipVerificationCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-ownershipverificationcertificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OwnershipVerificationCertificateArn { get; set; }
        /// <summary>
        /// MutualTlsAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-mutualtlsauthentication
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MutualTlsAuthentication
        /// </summary>
        public Union<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication, BaseFunction>? MutualTlsAuthentication { get; set; }
        /// <summary>
        /// RoutingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-routingmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoutingMode { get; set; }
        /// <summary>
        /// DomainName_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-domainname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DomainName_ { get; set; }
        /// <summary>
        /// SecurityPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-securitypolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityPolicy { get; set; }
        /// <summary>
        /// EndpointConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-endpointconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EndpointConfiguration
        /// </summary>
        public Union<Humidifier.ApiGateway.DomainNameTypes.EndpointConfiguration, BaseFunction>? EndpointConfiguration { get; set; }
        /// <summary>
        /// RegionalCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-regionalcertificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RegionalCertificateArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-certificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CertificateArn { get; set; }
        /// <summary>
        /// EndpointAccessMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-endpointaccessmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EndpointAccessMode { get; set; }
    }

    namespace DomainNameTypes
    {
        public class EndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveIpAddressType, IHaveStringListOfTypes
        {
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-endpointconfiguration.html#cfn-apigateway-domainname-endpointconfiguration-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-endpointconfiguration.html#cfn-apigateway-domainname-endpointconfiguration-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
        }

        public class MutualTlsAuthentication : Humidifier.Base.BaseSubResource, IHaveTruststoreVersion, IHaveTruststoreUri
        {
            /// <summary>
            /// TruststoreVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-mutualtlsauthentication.html#cfn-apigateway-domainname-mutualtlsauthentication-truststoreversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TruststoreVersion { get; set; }
            /// <summary>
            /// TruststoreUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-mutualtlsauthentication.html#cfn-apigateway-domainname-mutualtlsauthentication-truststoreuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TruststoreUri { get; set; }
        }
    }
}