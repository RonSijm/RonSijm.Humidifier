namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using FlowSourceTypes;

    public class FlowSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveProtocol, IHaveFlowArn, IHaveVpcInterfaceName, IHaveMaxBitrate, IHaveStreamId, IHaveMinLatency, IHaveMaxLatency, IHaveIngestPort, IHaveSourceListenerAddress, IHaveSourceListenerPort, IHaveWhitelistCidr
    {
        public class Attributes
        {
            public static string IngestIp =  "IngestIp" ;
            public static string SourceArn =  "SourceArn" ;
            public static string RtmpPushDetails =  "RtmpPushDetails" ;
            public static string SourceIngestPort =  "SourceIngestPort" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.FlowSource; }
        /// <summary>
        /// StreamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-streamid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StreamId { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Description { get; set; }
        /// <summary>
        /// IngestPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-ingestport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic IngestPort { get; set; }
        /// <summary>
        /// Decryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-decryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Encryption
        /// </summary>
        public Humidifier.MediaConnect.FlowSourceTypes.Encryption Decryption { get; set; }
        /// <summary>
        /// GatewayBridgeSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-gatewaybridgesource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GatewayBridgeSource
        /// </summary>
        public Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource GatewayBridgeSource { get; set; }
        /// <summary>
        /// SourceListenerAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-sourcelisteneraddress
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceListenerAddress { get; set; }
        /// <summary>
        /// SourceListenerPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-sourcelistenerport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SourceListenerPort { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// WhitelistCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-whitelistcidr
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WhitelistCidr { get; set; }
        /// <summary>
        /// MinLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-minlatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinLatency { get; set; }
        /// <summary>
        /// VpcInterfaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-vpcinterfacename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcInterfaceName { get; set; }
        /// <summary>
        /// RtmpPushSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-rtmppushsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RtmpPushSettings
        /// </summary>
        public Humidifier.MediaConnect.FlowSourceTypes.RtmpPushSettings RtmpPushSettings { get; set; }
        /// <summary>
        /// MaxBitrate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-maxbitrate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxBitrate { get; set; }
        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-protocol
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Protocol { get; set; }

        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-flowarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FlowArn { get; set; }
        /// <summary>
        /// MaxLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-maxlatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxLatency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace FlowSourceTypes
    {
        public class Encryption : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSecretArn, IHaveKeyType, IHaveAlgorithm
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html#cfn-mediaconnect-flowsource-encryption-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html#cfn-mediaconnect-flowsource-encryption-keytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html#cfn-mediaconnect-flowsource-encryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Algorithm { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html#cfn-mediaconnect-flowsource-encryption-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class GatewayBridgeSource : Humidifier.Base.BaseSubResource, IHaveBridgeArn
        {
            /// <summary>
            /// BridgeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-gatewaybridgesource.html#cfn-mediaconnect-flowsource-gatewaybridgesource-bridgearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BridgeArn { get; set; }
            /// <summary>
            /// VpcInterfaceAttachment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-gatewaybridgesource.html#cfn-mediaconnect-flowsource-gatewaybridgesource-vpcinterfaceattachment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcInterfaceAttachment
            /// </summary>
            public Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment VpcInterfaceAttachment { get; set; }
        }

        public class ManualRtmpPushNamingConfiguration : Humidifier.Base.BaseSubResource, IHaveApplicationName, IHaveStreamName
        {
            /// <summary>
            /// ApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-manualrtmppushnamingconfiguration.html#cfn-mediaconnect-flowsource-manualrtmppushnamingconfiguration-applicationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationName { get; set; }
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-manualrtmppushnamingconfiguration.html#cfn-mediaconnect-flowsource-manualrtmppushnamingconfiguration-streamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamName { get; set; }
        }

        public class RtmpPushDetails : Humidifier.Base.BaseSubResource, IHaveApplicationName, IHaveStreamName
        {
            /// <summary>
            /// ApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-rtmppushdetails.html#cfn-mediaconnect-flowsource-rtmppushdetails-applicationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationName { get; set; }
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-rtmppushdetails.html#cfn-mediaconnect-flowsource-rtmppushdetails-streamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamName { get; set; }
        }

        public class RtmpPushNamingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Manual
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-rtmppushnamingconfiguration.html#cfn-mediaconnect-flowsource-rtmppushnamingconfiguration-manual
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManualRtmpPushNamingConfiguration
            /// </summary>
            public Humidifier.MediaConnect.FlowSourceTypes.ManualRtmpPushNamingConfiguration Manual { get; set; }
            /// <summary>
            /// Automatic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-rtmppushnamingconfiguration.html#cfn-mediaconnect-flowsource-rtmppushnamingconfiguration-automatic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Automatic { get; set; }
        }

        public class RtmpPushSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NamingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-rtmppushsettings.html#cfn-mediaconnect-flowsource-rtmppushsettings-namingconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RtmpPushNamingConfiguration
            /// </summary>
            public Humidifier.MediaConnect.FlowSourceTypes.RtmpPushNamingConfiguration NamingConfiguration { get; set; }
        }

        public class VpcInterfaceAttachment : Humidifier.Base.BaseSubResource, IHaveVpcInterfaceName
        {
            /// <summary>
            /// VpcInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-vpcinterfaceattachment.html#cfn-mediaconnect-flowsource-vpcinterfaceattachment-vpcinterfacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcInterfaceName { get; set; }
        }
    }
}