namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using FlowSourceTypes;

    public class FlowSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStreamId, IHaveDescription, IHaveIngestPort_Integer, IHaveMediaConnectFlowSourceTypesEncryptionDecryption, IHaveMediaConnectFlowSourceTypesGatewayBridgeSourceGatewayBridgeSource, IHaveSourceListenerAddress, IHaveSourceListenerPort_Integer, IHaveName, IHaveWhitelistCidr, IHaveMinLatency_Integer, IHaveVpcInterfaceName, IHaveMaxBitrate_Integer, IHaveProtocol, IHaveFlowArn, IHaveMaxLatency_Integer
    {
        public class Attributes
        {
            public static string IngestIp =  "IngestIp" ;
            public static string SourceArn =  "SourceArn" ;
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
        public Union<string, BaseFunction>? StreamId { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// IngestPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-ingestport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? IngestPort { get; set; }
        /// <summary>
        /// Decryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-decryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Encryption
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowSourceTypes.Encryption, BaseFunction>? Decryption { get; set; }
        /// <summary>
        /// GatewayBridgeSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-gatewaybridgesource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GatewayBridgeSource
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource, BaseFunction>? GatewayBridgeSource { get; set; }
        /// <summary>
        /// SourceListenerAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-sourcelisteneraddress
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceListenerAddress { get; set; }
        /// <summary>
        /// SourceListenerPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-sourcelistenerport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SourceListenerPort { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// WhitelistCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-whitelistcidr
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WhitelistCidr { get; set; }
        /// <summary>
        /// MinLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-minlatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinLatency { get; set; }
        /// <summary>
        /// VpcInterfaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-vpcinterfacename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcInterfaceName { get; set; }
        /// <summary>
        /// MaxBitrate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-maxbitrate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxBitrate { get; set; }
        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-protocol
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Protocol { get; set; }

        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-flowarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FlowArn { get; set; }
        /// <summary>
        /// MaxLatency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-maxlatency
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxLatency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowsource.html#cfn-mediaconnect-flowsource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FlowSourceTypes
    {
        public class Encryption : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKeyType, IHaveAlgorithm, IHaveRoleArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html#cfn-mediaconnect-flowsource-encryption-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html#cfn-mediaconnect-flowsource-encryption-keytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// Algorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html#cfn-mediaconnect-flowsource-encryption-algorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Algorithm { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-encryption.html#cfn-mediaconnect-flowsource-encryption-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class GatewayBridgeSource : Humidifier.Base.BaseSubResource, IHaveBridgeArn, IHaveMediaConnectFlowSourceTypesVpcInterfaceAttachmentVpcInterfaceAttachment
        {
            /// <summary>
            /// BridgeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-gatewaybridgesource.html#cfn-mediaconnect-flowsource-gatewaybridgesource-bridgearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BridgeArn { get; set; }
            /// <summary>
            /// VpcInterfaceAttachment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowsource-gatewaybridgesource.html#cfn-mediaconnect-flowsource-gatewaybridgesource-vpcinterfaceattachment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcInterfaceAttachment
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment, BaseFunction>? VpcInterfaceAttachment { get; set; }
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
            public Union<string, BaseFunction>? VpcInterfaceName { get; set; }
        }
    }
}