namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using MailManagerIngressPointTypes;

    public class MailManagerIngressPoint : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveTlsPolicy
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
        public dynamic RuleSetId { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }

        /// <summary>
        /// TrafficPolicyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-trafficpolicyid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TrafficPolicyId { get; set; }
        /// <summary>
        /// IngressPointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-ingresspointname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IngressPointName { get; set; }
        /// <summary>
        /// StatusToUpdate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-statustoupdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StatusToUpdate { get; set; }
        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-networkconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NetworkConfiguration
        /// </summary>
        public Humidifier.SES.MailManagerIngressPointTypes.NetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// IngressPointConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-ingresspointconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IngressPointConfiguration
        /// </summary>
        public Humidifier.SES.MailManagerIngressPointTypes.IngressPointConfiguration IngressPointConfiguration { get; set; }
        /// <summary>
        /// TlsPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanageringresspoint.html#cfn-ses-mailmanageringresspoint-tlspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TlsPolicy { get; set; }
    }

    namespace MailManagerIngressPointTypes
    {
        public class IngressPointConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-ingresspointconfiguration.html#cfn-ses-mailmanageringresspoint-ingresspointconfiguration-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// SmtpPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-ingresspointconfiguration.html#cfn-ses-mailmanageringresspoint-ingresspointconfiguration-smtppassword
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SmtpPassword { get; set; }
            /// <summary>
            /// TlsAuthConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-ingresspointconfiguration.html#cfn-ses-mailmanageringresspoint-ingresspointconfiguration-tlsauthconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TlsAuthConfiguration
            /// </summary>
            public Humidifier.SES.MailManagerIngressPointTypes.TlsAuthConfiguration TlsAuthConfiguration { get; set; }
        }

        public class NetworkConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PublicNetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-networkconfiguration.html#cfn-ses-mailmanageringresspoint-networkconfiguration-publicnetworkconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PublicNetworkConfiguration
            /// </summary>
            public Humidifier.SES.MailManagerIngressPointTypes.PublicNetworkConfiguration PublicNetworkConfiguration { get; set; }
            /// <summary>
            /// PrivateNetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-networkconfiguration.html#cfn-ses-mailmanageringresspoint-networkconfiguration-privatenetworkconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PrivateNetworkConfiguration
            /// </summary>
            public Humidifier.SES.MailManagerIngressPointTypes.PrivateNetworkConfiguration PrivateNetworkConfiguration { get; set; }
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
            public dynamic VpcEndpointId { get; set; }
        }

        public class PublicNetworkConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IpType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-publicnetworkconfiguration.html#cfn-ses-mailmanageringresspoint-publicnetworkconfiguration-iptype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic IpType { get; set; }
        }

        public class TlsAuthConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TrustStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-tlsauthconfiguration.html#cfn-ses-mailmanageringresspoint-tlsauthconfiguration-truststore
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TrustStore
            /// </summary>
            public Humidifier.SES.MailManagerIngressPointTypes.TrustStore TrustStore { get; set; }
        }

        public class TrustStore : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-truststore.html#cfn-ses-mailmanageringresspoint-truststore-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
            /// <summary>
            /// CrlContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-truststore.html#cfn-ses-mailmanageringresspoint-truststore-crlcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CrlContent { get; set; }
            /// <summary>
            /// CAContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanageringresspoint-truststore.html#cfn-ses-mailmanageringresspoint-truststore-cacontent
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CAContent { get; set; }
        }
    }
}