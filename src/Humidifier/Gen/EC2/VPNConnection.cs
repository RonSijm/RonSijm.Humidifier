namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using VPNConnectionTypes;

    public class VPNConnection : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveTransitGatewayId, IHaveVpnGatewayId, IHaveTransportTransitGatewayAttachmentId
    {
        public class Attributes
        {
            public static string VpnConnectionId =  "VpnConnectionId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPNConnection; }
        /// <summary>
        /// RemoteIpv6NetworkCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-remoteipv6networkcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RemoteIpv6NetworkCidr { get; set; }
        /// <summary>
        /// RemoteIpv4NetworkCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-remoteipv4networkcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RemoteIpv4NetworkCidr { get; set; }
        /// <summary>
        /// VpnTunnelOptionsSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-vpntunneloptionsspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: VpnTunnelOptionsSpecification
        /// </summary>
        public List<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification> VpnTunnelOptionsSpecifications { get; set; }

        /// <summary>
        /// CustomerGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-customergatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CustomerGatewayId { get; set; }
        /// <summary>
        /// OutsideIpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-outsideipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OutsideIpAddressType { get; set; }
        /// <summary>
        /// StaticRoutesOnly
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-staticroutesonly
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic StaticRoutesOnly { get; set; }
        /// <summary>
        /// EnableAcceleration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-enableacceleration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableAcceleration { get; set; }
        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-transitgatewayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransitGatewayId { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// LocalIpv4NetworkCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-localipv4networkcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LocalIpv4NetworkCidr { get; set; }
        /// <summary>
        /// VpnGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-vpngatewayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpnGatewayId { get; set; }
        /// <summary>
        /// TransportTransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-transporttransitgatewayattachmentid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransportTransitGatewayAttachmentId { get; set; }
        /// <summary>
        /// LocalIpv6NetworkCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-localipv6networkcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LocalIpv6NetworkCidr { get; set; }
        /// <summary>
        /// TunnelInsideIpVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-tunnelinsideipversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TunnelInsideIpVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace VPNConnectionTypes
    {
        public class CloudwatchLogOptionsSpecification : Humidifier.Base.BaseSubResource, IHaveLogGroupArn
        {
            /// <summary>
            /// LogEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-logenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic LogEnabled { get; set; }
            /// <summary>
            /// LogOutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-logoutputformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogOutputFormat { get; set; }
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-loggrouparn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupArn { get; set; }
        }

        public class IKEVersionsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-ikeversionsrequestlistvalue.html#cfn-ec2-vpnconnection-ikeversionsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class Phase1DHGroupNumbersRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase1dhgroupnumbersrequestlistvalue.html#cfn-ec2-vpnconnection-phase1dhgroupnumbersrequestlistvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class Phase1EncryptionAlgorithmsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase1encryptionalgorithmsrequestlistvalue.html#cfn-ec2-vpnconnection-phase1encryptionalgorithmsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class Phase1IntegrityAlgorithmsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase1integrityalgorithmsrequestlistvalue.html#cfn-ec2-vpnconnection-phase1integrityalgorithmsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class Phase2DHGroupNumbersRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase2dhgroupnumbersrequestlistvalue.html#cfn-ec2-vpnconnection-phase2dhgroupnumbersrequestlistvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class Phase2EncryptionAlgorithmsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase2encryptionalgorithmsrequestlistvalue.html#cfn-ec2-vpnconnection-phase2encryptionalgorithmsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class Phase2IntegrityAlgorithmsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase2integrityalgorithmsrequestlistvalue.html#cfn-ec2-vpnconnection-phase2integrityalgorithmsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class VpnTunnelLogOptionsSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudwatchLogOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunnellogoptionsspecification.html#cfn-ec2-vpnconnection-vpntunnellogoptionsspecification-cloudwatchlogoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CloudwatchLogOptionsSpecification
            /// </summary>
            public Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification CloudwatchLogOptions { get; set; }
        }

        public class VpnTunnelOptionsSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Phase2EncryptionAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase2encryptionalgorithms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Phase2EncryptionAlgorithmsRequestListValue
            /// </summary>
            public List<Humidifier.EC2.VPNConnectionTypes.Phase2EncryptionAlgorithmsRequestListValue> Phase2EncryptionAlgorithms { get; set; }
            /// <summary>
            /// Phase2DHGroupNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase2dhgroupnumbers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Phase2DHGroupNumbersRequestListValue
            /// </summary>
            public List<Humidifier.EC2.VPNConnectionTypes.Phase2DHGroupNumbersRequestListValue> Phase2DHGroupNumbers { get; set; }
            /// <summary>
            /// TunnelInsideIpv6Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-tunnelinsideipv6cidr
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TunnelInsideIpv6Cidr { get; set; }
            /// <summary>
            /// StartupAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-startupaction
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartupAction { get; set; }
            /// <summary>
            /// TunnelInsideCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-tunnelinsidecidr
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TunnelInsideCidr { get; set; }
            /// <summary>
            /// IKEVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-ikeversions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: IKEVersionsRequestListValue
            /// </summary>
            public List<Humidifier.EC2.VPNConnectionTypes.IKEVersionsRequestListValue> IKEVersions { get; set; }
            /// <summary>
            /// LogOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-logoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpnTunnelLogOptionsSpecification
            /// </summary>
            public Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification LogOptions { get; set; }
            /// <summary>
            /// Phase1DHGroupNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase1dhgroupnumbers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Phase1DHGroupNumbersRequestListValue
            /// </summary>
            public List<Humidifier.EC2.VPNConnectionTypes.Phase1DHGroupNumbersRequestListValue> Phase1DHGroupNumbers { get; set; }
            /// <summary>
            /// ReplayWindowSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-replaywindowsize
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReplayWindowSize { get; set; }
            /// <summary>
            /// EnableTunnelLifecycleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-enabletunnellifecyclecontrol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableTunnelLifecycleControl { get; set; }
            /// <summary>
            /// RekeyMarginTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-rekeymargintimeseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RekeyMarginTimeSeconds { get; set; }
            /// <summary>
            /// DPDTimeoutAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-dpdtimeoutaction
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DPDTimeoutAction { get; set; }
            /// <summary>
            /// Phase2LifetimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase2lifetimeseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Phase2LifetimeSeconds { get; set; }
            /// <summary>
            /// Phase2IntegrityAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase2integrityalgorithms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Phase2IntegrityAlgorithmsRequestListValue
            /// </summary>
            public List<Humidifier.EC2.VPNConnectionTypes.Phase2IntegrityAlgorithmsRequestListValue> Phase2IntegrityAlgorithms { get; set; }
            /// <summary>
            /// Phase1IntegrityAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase1integrityalgorithms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Phase1IntegrityAlgorithmsRequestListValue
            /// </summary>
            public List<Humidifier.EC2.VPNConnectionTypes.Phase1IntegrityAlgorithmsRequestListValue> Phase1IntegrityAlgorithms { get; set; }
            /// <summary>
            /// PreSharedKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-presharedkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreSharedKey { get; set; }
            /// <summary>
            /// Phase1LifetimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase1lifetimeseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Phase1LifetimeSeconds { get; set; }
            /// <summary>
            /// RekeyFuzzPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-rekeyfuzzpercentage
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RekeyFuzzPercentage { get; set; }
            /// <summary>
            /// Phase1EncryptionAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase1encryptionalgorithms
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Phase1EncryptionAlgorithmsRequestListValue
            /// </summary>
            public List<Humidifier.EC2.VPNConnectionTypes.Phase1EncryptionAlgorithmsRequestListValue> Phase1EncryptionAlgorithms { get; set; }
            /// <summary>
            /// DPDTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-dpdtimeoutseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DPDTimeoutSeconds { get; set; }
        }
    }
}