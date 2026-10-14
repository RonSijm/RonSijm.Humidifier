namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using TransitGatewayConnectPeerTypes;

    public class TransitGatewayConnectPeer : Humidifier.Base.BaseResource, IHaveTags, IHaveTransitGatewayAttachmentId
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string TransitGatewayConnectPeerId =  "TransitGatewayConnectPeerId" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayConnectPeer; }

        /// <summary>
        /// ConnectPeerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayconnectpeer.html#cfn-ec2-transitgatewayconnectpeer-connectpeerconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: TransitGatewayConnectPeerConfiguration
        /// </summary>
        [Required]
        public Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayConnectPeerConfiguration ConnectPeerConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayconnectpeer.html#cfn-ec2-transitgatewayconnectpeer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// TransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayconnectpeer.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayAttachmentId { get; set; }
    }

    namespace TransitGatewayConnectPeerTypes
    {
        public class TransitGatewayAttachmentBgpConfiguration : Humidifier.Base.BaseSubResource, IHavePeerAddress, IHavePeerAsn
        {
            /// <summary>
            /// TransitGatewayAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration-transitgatewayaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransitGatewayAddress { get; set; }
            /// <summary>
            /// PeerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration-peeraddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PeerAddress { get; set; }
            /// <summary>
            /// BgpStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration-bgpstatus
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BgpStatus { get; set; }
            /// <summary>
            /// PeerAsn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration-peerasn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PeerAsn { get; set; }
            /// <summary>
            /// TransitGatewayAsn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayattachmentbgpconfiguration-transitgatewayasn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TransitGatewayAsn { get; set; }
        }

        public class TransitGatewayConnectPeerConfiguration : Humidifier.Base.BaseSubResource, IHaveProtocol, IHavePeerAddress, IHaveInsideCidrBlocks
        {
            /// <summary>
            /// TransitGatewayAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration-transitgatewayaddress
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransitGatewayAddress { get; set; }
            /// <summary>
            /// BgpConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration-bgpconfigurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: TransitGatewayAttachmentBgpConfiguration
            /// </summary>
            public List<Humidifier.EC2.TransitGatewayConnectPeerTypes.TransitGatewayAttachmentBgpConfiguration> BgpConfigurations { get; set; }
            /// <summary>
            /// PeerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration-peeraddress
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PeerAddress { get; set; }
            /// <summary>
            /// InsideCidrBlocks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration-insidecidrblocks
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InsideCidrBlocks { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration.html#cfn-ec2-transitgatewayconnectpeer-transitgatewayconnectpeerconfiguration-protocol
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol { get; set; }
        }
    }
}