namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using VPNConnectionTypes;

    public class VPNConnection : Humidifier.Base.BaseResource, IHaveTags, IHaveRemoteIpv6NetworkCidr, IHaveRemoteIpv4NetworkCidr, IHaveListOfEC2VPNConnectionTypesVpnTunnelOptionsSpecificationVpnTunnelOptionsSpecifications, IHaveCustomerGatewayId, IHaveOutsideIpAddressType, IHaveStaticRoutesOnly_Boolean, IHaveEnableAcceleration_Boolean, IHaveTransitGatewayId, IHaveType, IHaveTunnelBandwidth, IHaveLocalIpv4NetworkCidr, IHaveVpnGatewayId, IHaveVpnConcentratorId, IHavePreSharedKeyStorage, IHaveTransportTransitGatewayAttachmentId, IHaveLocalIpv6NetworkCidr, IHaveTunnelInsideIpVersion
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
        public Union<string, BaseFunction>? RemoteIpv6NetworkCidr { get; set; }
        /// <summary>
        /// RemoteIpv4NetworkCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-remoteipv4networkcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RemoteIpv4NetworkCidr { get; set; }
        /// <summary>
        /// VpnTunnelOptionsSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-vpntunneloptionsspecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VpnTunnelOptionsSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification>, IReadOnlyList<Union<Humidifier.EC2.VPNConnectionTypes.VpnTunnelOptionsSpecification, BaseFunction>>, BaseFunction>? VpnTunnelOptionsSpecifications { get; set; }

        /// <summary>
        /// CustomerGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-customergatewayid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CustomerGatewayId { get; set; }
        /// <summary>
        /// OutsideIpAddressType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-outsideipaddresstype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OutsideIpAddressType { get; set; }
        /// <summary>
        /// StaticRoutesOnly
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-staticroutesonly
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? StaticRoutesOnly { get; set; }
        /// <summary>
        /// EnableAcceleration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-enableacceleration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableAcceleration { get; set; }
        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-transitgatewayid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TransitGatewayId { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// TunnelBandwidth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-tunnelbandwidth
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TunnelBandwidth { get; set; }
        /// <summary>
        /// LocalIpv4NetworkCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-localipv4networkcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LocalIpv4NetworkCidr { get; set; }
        /// <summary>
        /// VpnGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-vpngatewayid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpnGatewayId { get; set; }
        /// <summary>
        /// VpnConcentratorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-vpnconcentratorid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpnConcentratorId { get; set; }
        /// <summary>
        /// PreSharedKeyStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-presharedkeystorage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreSharedKeyStorage { get; set; }
        /// <summary>
        /// TransportTransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-transporttransitgatewayattachmentid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TransportTransitGatewayAttachmentId { get; set; }
        /// <summary>
        /// LocalIpv6NetworkCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-localipv6networkcidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LocalIpv6NetworkCidr { get; set; }
        /// <summary>
        /// TunnelInsideIpVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-tunnelinsideipversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TunnelInsideIpVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnection.html#cfn-ec2-vpnconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VPNConnectionTypes
    {
        public class CloudwatchLogOptionsSpecification : Humidifier.Base.BaseSubResource, IHaveBgpLogEnabled_Boolean, IHaveLogEnabled_Boolean, IHaveLogOutputFormat, IHaveBgpLogGroupArn, IHaveLogGroupArn, IHaveBgpLogOutputFormat
        {
            /// <summary>
            /// BgpLogEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-bgplogenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BgpLogEnabled { get; set; }
            /// <summary>
            /// LogEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-logenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? LogEnabled { get; set; }
            /// <summary>
            /// LogOutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-logoutputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogOutputFormat { get; set; }
            /// <summary>
            /// BgpLogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-bgploggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BgpLogGroupArn { get; set; }
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-loggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupArn { get; set; }
            /// <summary>
            /// BgpLogOutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-cloudwatchlogoptionsspecification.html#cfn-ec2-vpnconnection-cloudwatchlogoptionsspecification-bgplogoutputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BgpLogOutputFormat { get; set; }
        }

        public class IKEVersionsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-ikeversionsrequestlistvalue.html#cfn-ec2-vpnconnection-ikeversionsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class Phase1DHGroupNumbersRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue_Integer
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase1dhgroupnumbersrequestlistvalue.html#cfn-ec2-vpnconnection-phase1dhgroupnumbersrequestlistvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class Phase1EncryptionAlgorithmsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase1encryptionalgorithmsrequestlistvalue.html#cfn-ec2-vpnconnection-phase1encryptionalgorithmsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class Phase1IntegrityAlgorithmsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase1integrityalgorithmsrequestlistvalue.html#cfn-ec2-vpnconnection-phase1integrityalgorithmsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class Phase2DHGroupNumbersRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue_Integer
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase2dhgroupnumbersrequestlistvalue.html#cfn-ec2-vpnconnection-phase2dhgroupnumbersrequestlistvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Value { get; set; }
        }

        public class Phase2EncryptionAlgorithmsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase2encryptionalgorithmsrequestlistvalue.html#cfn-ec2-vpnconnection-phase2encryptionalgorithmsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class Phase2IntegrityAlgorithmsRequestListValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-phase2integrityalgorithmsrequestlistvalue.html#cfn-ec2-vpnconnection-phase2integrityalgorithmsrequestlistvalue-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class VpnTunnelLogOptionsSpecification : Humidifier.Base.BaseSubResource, IHaveEC2VPNConnectionTypesCloudwatchLogOptionsSpecificationCloudwatchLogOptions
        {
            /// <summary>
            /// CloudwatchLogOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunnellogoptionsspecification.html#cfn-ec2-vpnconnection-vpntunnellogoptionsspecification-cloudwatchlogoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudwatchLogOptionsSpecification
            /// </summary>
            public Union<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification, BaseFunction>? CloudwatchLogOptions { get; set; }
        }

        public class VpnTunnelOptionsSpecification : Humidifier.Base.BaseSubResource, IHaveListOfEC2VPNConnectionTypesPhase2EncryptionAlgorithmsRequestListValuePhase2EncryptionAlgorithms, IHaveListOfEC2VPNConnectionTypesPhase2DHGroupNumbersRequestListValuePhase2DHGroupNumbers, IHaveTunnelInsideIpv6Cidr, IHaveStartupAction, IHaveTunnelInsideCidr, IHaveListOfEC2VPNConnectionTypesIKEVersionsRequestListValueIKEVersions, IHaveEC2VPNConnectionTypesVpnTunnelLogOptionsSpecificationLogOptions, IHaveListOfEC2VPNConnectionTypesPhase1DHGroupNumbersRequestListValuePhase1DHGroupNumbers, IHaveReplayWindowSize_Integer, IHaveEnableTunnelLifecycleControl_Boolean, IHaveRekeyMarginTimeSeconds_Integer, IHaveDPDTimeoutAction, IHavePhase2LifetimeSeconds_Integer, IHaveListOfEC2VPNConnectionTypesPhase2IntegrityAlgorithmsRequestListValuePhase2IntegrityAlgorithms, IHaveListOfEC2VPNConnectionTypesPhase1IntegrityAlgorithmsRequestListValuePhase1IntegrityAlgorithms, IHavePreSharedKey, IHavePhase1LifetimeSeconds_Integer, IHaveRekeyFuzzPercentage_Integer, IHaveListOfEC2VPNConnectionTypesPhase1EncryptionAlgorithmsRequestListValuePhase1EncryptionAlgorithms, IHaveDPDTimeoutSeconds_Integer
        {
            /// <summary>
            /// Phase2EncryptionAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase2encryptionalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Phase2EncryptionAlgorithmsRequestListValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VPNConnectionTypes.Phase2EncryptionAlgorithmsRequestListValue>, IReadOnlyList<Union<Humidifier.EC2.VPNConnectionTypes.Phase2EncryptionAlgorithmsRequestListValue, BaseFunction>>, BaseFunction>? Phase2EncryptionAlgorithms { get; set; }
            /// <summary>
            /// Phase2DHGroupNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase2dhgroupnumbers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Phase2DHGroupNumbersRequestListValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VPNConnectionTypes.Phase2DHGroupNumbersRequestListValue>, IReadOnlyList<Union<Humidifier.EC2.VPNConnectionTypes.Phase2DHGroupNumbersRequestListValue, BaseFunction>>, BaseFunction>? Phase2DHGroupNumbers { get; set; }
            /// <summary>
            /// TunnelInsideIpv6Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-tunnelinsideipv6cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TunnelInsideIpv6Cidr { get; set; }
            /// <summary>
            /// StartupAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-startupaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartupAction { get; set; }
            /// <summary>
            /// TunnelInsideCidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-tunnelinsidecidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TunnelInsideCidr { get; set; }
            /// <summary>
            /// IKEVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-ikeversions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IKEVersionsRequestListValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VPNConnectionTypes.IKEVersionsRequestListValue>, IReadOnlyList<Union<Humidifier.EC2.VPNConnectionTypes.IKEVersionsRequestListValue, BaseFunction>>, BaseFunction>? IKEVersions { get; set; }
            /// <summary>
            /// LogOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-logoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpnTunnelLogOptionsSpecification
            /// </summary>
            public Union<Humidifier.EC2.VPNConnectionTypes.VpnTunnelLogOptionsSpecification, BaseFunction>? LogOptions { get; set; }
            /// <summary>
            /// Phase1DHGroupNumbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase1dhgroupnumbers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Phase1DHGroupNumbersRequestListValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VPNConnectionTypes.Phase1DHGroupNumbersRequestListValue>, IReadOnlyList<Union<Humidifier.EC2.VPNConnectionTypes.Phase1DHGroupNumbersRequestListValue, BaseFunction>>, BaseFunction>? Phase1DHGroupNumbers { get; set; }
            /// <summary>
            /// ReplayWindowSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-replaywindowsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReplayWindowSize { get; set; }
            /// <summary>
            /// EnableTunnelLifecycleControl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-enabletunnellifecyclecontrol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableTunnelLifecycleControl { get; set; }
            /// <summary>
            /// RekeyMarginTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-rekeymargintimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RekeyMarginTimeSeconds { get; set; }
            /// <summary>
            /// DPDTimeoutAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-dpdtimeoutaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DPDTimeoutAction { get; set; }
            /// <summary>
            /// Phase2LifetimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase2lifetimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Phase2LifetimeSeconds { get; set; }
            /// <summary>
            /// Phase2IntegrityAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase2integrityalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Phase2IntegrityAlgorithmsRequestListValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VPNConnectionTypes.Phase2IntegrityAlgorithmsRequestListValue>, IReadOnlyList<Union<Humidifier.EC2.VPNConnectionTypes.Phase2IntegrityAlgorithmsRequestListValue, BaseFunction>>, BaseFunction>? Phase2IntegrityAlgorithms { get; set; }
            /// <summary>
            /// Phase1IntegrityAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase1integrityalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Phase1IntegrityAlgorithmsRequestListValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VPNConnectionTypes.Phase1IntegrityAlgorithmsRequestListValue>, IReadOnlyList<Union<Humidifier.EC2.VPNConnectionTypes.Phase1IntegrityAlgorithmsRequestListValue, BaseFunction>>, BaseFunction>? Phase1IntegrityAlgorithms { get; set; }
            /// <summary>
            /// PreSharedKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-presharedkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreSharedKey { get; set; }
            /// <summary>
            /// Phase1LifetimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase1lifetimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Phase1LifetimeSeconds { get; set; }
            /// <summary>
            /// RekeyFuzzPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-rekeyfuzzpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RekeyFuzzPercentage { get; set; }
            /// <summary>
            /// Phase1EncryptionAlgorithms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-phase1encryptionalgorithms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Phase1EncryptionAlgorithmsRequestListValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.VPNConnectionTypes.Phase1EncryptionAlgorithmsRequestListValue>, IReadOnlyList<Union<Humidifier.EC2.VPNConnectionTypes.Phase1EncryptionAlgorithmsRequestListValue, BaseFunction>>, BaseFunction>? Phase1EncryptionAlgorithms { get; set; }
            /// <summary>
            /// DPDTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-vpnconnection-vpntunneloptionsspecification.html#cfn-ec2-vpnconnection-vpntunneloptionsspecification-dpdtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DPDTimeoutSeconds { get; set; }
        }
    }
}