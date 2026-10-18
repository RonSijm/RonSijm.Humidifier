namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using MailManagerIngressPointTypes;

    public class MailManagerIngressPoint : Humidifier.Base.BaseResource, IHaveTags, IHaveRuleSetId, IHaveType, IHaveTrafficPolicyId, IHaveIngressPointName, IHaveStatusToUpdate, IHaveSESMailManagerIngressPointTypesNetworkConfigurationNetworkConfiguration, IHaveSESMailManagerIngressPointTypesIngressPointConfigurationIngressPointConfiguration, IHaveTlsPolicy
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ARecord =  "ARecord" ;
            public static string IngressPointId =  "IngressPointId" ;
            public static string IngressPointArn =  "IngressPointArn" ;
        }

        public override string AWSTypeName { get => AWS.SES.MailManagerIngressPoint; }

        /// <summary>
        /// RuleSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-rulesetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleSetId { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// TrafficPolicyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-trafficpolicyid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TrafficPolicyId { get; set; }
        /// <summary>
        /// IngressPointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-ingresspointname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IngressPointName { get; set; }
        /// <summary>
        /// StatusToUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-statustoupdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StatusToUpdate { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-networkconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Union<Humidifier.SES.MailManagerIngressPointTypes.NetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// IngressPointConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-ingresspointconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IngressPointConfiguration
        /// </summary>
        public Union<Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration, BaseFunction>? IngressPointConfiguration { get; set; }
        /// <summary>
        /// TlsPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-tlspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TlsPolicy { get; set; }
    }

    namespace MailManagerIngressPointTypes
    {
        public class IngressPointConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveSmtpPassword, IHaveSESMailManagerIngressPointTypesTlsAuthConfigurationTlsAuthConfiguration
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-ingresspointconfiguration.html#cfn-ses-mailmanageringresspoint-ingresspointconfiguration-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// SmtpPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-ingresspointconfiguration.html#cfn-ses-mailmanageringresspoint-ingresspointconfiguration-smtppassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SmtpPassword { get; set; }
            /// <summary>
            /// TlsAuthConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-ingresspointconfiguration.html#cfn-ses-mailmanageringresspoint-ingresspointconfiguration-tlsauthconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsAuthConfiguration
            /// </summary>
            public Union<Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration, BaseFunction>? TlsAuthConfiguration { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveSESMailManagerIngressPointTypesPublicNetworkConfigurationPublicNetworkConfiguration, IHaveSESMailManagerIngressPointTypesPrivateNetworkConfigurationPrivateNetworkConfiguration
        {
            /// <summary>
            /// PublicNetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-networkconfiguration.html#cfn-ses-mailmanageringresspoint-networkconfiguration-publicnetworkconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PublicNetworkConfiguration
            /// </summary>
            public Union<Humidifier.SES.MailManagerIngressPointTypes.PublicNetworkConfiguration, BaseFunction>? PublicNetworkConfiguration { get; set; }
            /// <summary>
            /// PrivateNetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-networkconfiguration.html#cfn-ses-mailmanageringresspoint-networkconfiguration-privatenetworkconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PrivateNetworkConfiguration
            /// </summary>
            public Union<Humidifier.SES.MailManagerIngressPointTypes.PrivateNetworkConfiguration, BaseFunction>? PrivateNetworkConfiguration { get; set; }
        }

        public class PrivateNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveVpcEndpointId
        {
            /// <summary>
            /// VpcEndpointId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-privatenetworkconfiguration.html#cfn-ses-mailmanageringresspoint-privatenetworkconfiguration-vpcendpointid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcEndpointId { get; set; }
        }

        public class PublicNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveIpType_Json
        {
            /// <summary>
            /// IpType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-publicnetworkconfiguration.html#cfn-ses-mailmanageringresspoint-publicnetworkconfiguration-iptype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? IpType { get; set; }
        }

        public class TlsAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveSESMailManagerIngressPointTypesTrustStoreTrustStore
        {
            /// <summary>
            /// TrustStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-tlsauthconfiguration.html#cfn-ses-mailmanageringresspoint-tlsauthconfiguration-truststore
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TrustStore
            /// </summary>
            public Union<Humidifier.SES.MailManagerIngressPointTypes.TrustStore, BaseFunction>? TrustStore { get; set; }
        }

        public class TrustStore : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveCrlContent, IHaveCAContent
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-truststore.html#cfn-ses-mailmanageringresspoint-truststore-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// CrlContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-truststore.html#cfn-ses-mailmanageringresspoint-truststore-crlcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrlContent { get; set; }
            /// <summary>
            /// CAContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-truststore.html#cfn-ses-mailmanageringresspoint-truststore-cacontent
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CAContent { get; set; }
        }
    }
}