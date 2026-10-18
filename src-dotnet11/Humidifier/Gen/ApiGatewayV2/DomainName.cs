namespace Humidifier.ApiGatewayV2
{
    using global::System.Collections.Generic;
    using DomainNameTypes;

    public class DomainName : Humidifier.Base.BaseResource, IHaveApiGatewayV2DomainNameTypesMutualTlsAuthenticationMutualTlsAuthentication, IHaveRoutingMode, IHaveDomainName_, IHaveListOfApiGatewayV2DomainNameTypesDomainNameConfigurationDomainNameConfigurations, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string RegionalHostedZoneId =  "RegionalHostedZoneId" ;
            public static string RegionalDomainName =  "RegionalDomainName" ;
            public static string DomainNameArn =  "DomainNameArn" ;
        }

        public override string AWSTypeName { get => AWS.ApiGatewayV2.DomainName; }
        /// <summary>
        /// MutualTlsAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-domainname.html#cfn-apigatewayv2-domainname-mutualtlsauthentication
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MutualTlsAuthentication
        /// </summary>
        public Union<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication, BaseFunction>? MutualTlsAuthentication { get; set; }
        /// <summary>
        /// RoutingMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-domainname.html#cfn-apigatewayv2-domainname-routingmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoutingMode { get; set; }

        /// <summary>
        /// DomainName_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-domainname.html#cfn-apigatewayv2-domainname-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName_ { get; set; }
        /// <summary>
        /// DomainNameConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-domainname.html#cfn-apigatewayv2-domainname-domainnameconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DomainNameConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration>, IReadOnlyList<Union<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration, BaseFunction>>, BaseFunction>? DomainNameConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-domainname.html#cfn-apigatewayv2-domainname-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DomainNameTypes
    {
        public class DomainNameConfiguration : Humidifier.Base.BaseSubResource, IHaveOwnershipVerificationCertificateArn, IHaveIpAddressType, IHaveSecurityPolicy, IHaveEndpointType, IHaveCertificateName, IHaveCertificateArn
        {
            /// <summary>
            /// OwnershipVerificationCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-domainnameconfiguration.html#cfn-apigatewayv2-domainname-domainnameconfiguration-ownershipverificationcertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnershipVerificationCertificateArn { get; set; }
            /// <summary>
            /// IpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-domainnameconfiguration.html#cfn-apigatewayv2-domainname-domainnameconfiguration-ipaddresstype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddressType { get; set; }
            /// <summary>
            /// SecurityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-domainnameconfiguration.html#cfn-apigatewayv2-domainname-domainnameconfiguration-securitypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityPolicy { get; set; }
            /// <summary>
            /// EndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-domainnameconfiguration.html#cfn-apigatewayv2-domainname-domainnameconfiguration-endpointtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointType { get; set; }
            /// <summary>
            /// CertificateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-domainnameconfiguration.html#cfn-apigatewayv2-domainname-domainnameconfiguration-certificatename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateName { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-domainnameconfiguration.html#cfn-apigatewayv2-domainname-domainnameconfiguration-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class MutualTlsAuthentication : Humidifier.Base.BaseSubResource, IHaveTruststoreVersion, IHaveTruststoreUri
        {
            /// <summary>
            /// TruststoreVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-mutualtlsauthentication.html#cfn-apigatewayv2-domainname-mutualtlsauthentication-truststoreversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TruststoreVersion { get; set; }
            /// <summary>
            /// TruststoreUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigatewayv2-domainname-mutualtlsauthentication.html#cfn-apigatewayv2-domainname-mutualtlsauthentication-truststoreuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TruststoreUri { get; set; }
        }
    }
}