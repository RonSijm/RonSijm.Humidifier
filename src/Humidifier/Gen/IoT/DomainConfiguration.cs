namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using DomainConfigurationTypes;

    public class DomainConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDomainName, IHaveAuthenticationType
    {
        public class Attributes
        {
            public static string DomainType =  "DomainType" ;
            public static string ServerCertificates =  "ServerCertificates" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.DomainConfiguration; }
        /// <summary>
        /// ApplicationProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-applicationprotocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationProtocol { get; set; }
        /// <summary>
        /// ClientCertificateConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-clientcertificateconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClientCertificateConfig
        /// </summary>
        public Humidifier.IoT.DomainConfigurationTypes.ClientCertificateConfig ClientCertificateConfig { get; set; }
        public dynamic DomainConfigurationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-domainname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainName { get; set; }
        /// <summary>
        /// DomainConfigurationStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-domainconfigurationstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainConfigurationStatus { get; set; }
        /// <summary>
        /// ServerCertificateArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-servercertificatearns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ServerCertificateArns { get; set; }
        /// <summary>
        /// ServerCertificateConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-servercertificateconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServerCertificateConfig
        /// </summary>
        public Humidifier.IoT.DomainConfigurationTypes.ServerCertificateConfig ServerCertificateConfig { get; set; }
        /// <summary>
        /// AuthorizerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-authorizerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AuthorizerConfig
        /// </summary>
        public Humidifier.IoT.DomainConfigurationTypes.AuthorizerConfig AuthorizerConfig { get; set; }
        /// <summary>
        /// ServiceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-servicetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceType { get; set; }
        /// <summary>
        /// ValidationCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-validationcertificatearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ValidationCertificateArn { get; set; }
        /// <summary>
        /// TlsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-tlsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TlsConfig
        /// </summary>
        public Humidifier.IoT.DomainConfigurationTypes.TlsConfig TlsConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// AuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-domainconfiguration.html#cfn-iot-domainconfiguration-authenticationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthenticationType { get; set; }
    }

    namespace DomainConfigurationTypes
    {
        public class AuthorizerConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultAuthorizerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-authorizerconfig.html#cfn-iot-domainconfiguration-authorizerconfig-defaultauthorizername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultAuthorizerName { get; set; }
            /// <summary>
            /// AllowAuthorizerOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-authorizerconfig.html#cfn-iot-domainconfiguration-authorizerconfig-allowauthorizeroverride
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowAuthorizerOverride { get; set; }
        }

        public class ClientCertificateConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClientCertificateCallbackArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-clientcertificateconfig.html#cfn-iot-domainconfiguration-clientcertificateconfig-clientcertificatecallbackarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientCertificateCallbackArn { get; set; }
        }

        public class ServerCertificateConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnableOCSPCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-servercertificateconfig.html#cfn-iot-domainconfiguration-servercertificateconfig-enableocspcheck
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableOCSPCheck { get; set; }
            /// <summary>
            /// OcspLambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-servercertificateconfig.html#cfn-iot-domainconfiguration-servercertificateconfig-ocsplambdaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OcspLambdaArn { get; set; }
            /// <summary>
            /// OcspAuthorizedResponderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-servercertificateconfig.html#cfn-iot-domainconfiguration-servercertificateconfig-ocspauthorizedresponderarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OcspAuthorizedResponderArn { get; set; }
        }

        public class ServerCertificateSummary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServerCertificateStatusDetail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-servercertificatesummary.html#cfn-iot-domainconfiguration-servercertificatesummary-servercertificatestatusdetail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerCertificateStatusDetail { get; set; }
            /// <summary>
            /// ServerCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-servercertificatesummary.html#cfn-iot-domainconfiguration-servercertificatesummary-servercertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerCertificateArn { get; set; }
            /// <summary>
            /// ServerCertificateStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-servercertificatesummary.html#cfn-iot-domainconfiguration-servercertificatesummary-servercertificatestatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerCertificateStatus { get; set; }
        }

        public class TlsConfig : Humidifier.Base.BaseSubResource, IHaveSecurityPolicy
        {
            /// <summary>
            /// SecurityPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-domainconfiguration-tlsconfig.html#cfn-iot-domainconfiguration-tlsconfig-securitypolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecurityPolicy { get; set; }
        }
    }
}