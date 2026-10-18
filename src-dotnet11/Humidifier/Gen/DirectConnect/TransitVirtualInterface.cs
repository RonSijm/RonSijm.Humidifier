namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;
    using TransitVirtualInterfaceTypes;

    public class TransitVirtualInterface : Humidifier.Base.BaseResource, IHaveTags, IHaveRateLimit, IHaveListOfDirectConnectTransitVirtualInterfaceTypesBgpPeerBgpPeers, IHaveConnectionId, IHaveDirectConnectGatewayId, IHaveEnableSiteLink_Boolean, IHaveVirtualInterfaceName, IHaveVlan_Integer, IHaveAllocateTransitVirtualInterfaceRoleArn, IHaveMtu_Integer
    {
        public class Attributes
        {
            public static string VirtualInterfaceId =  "VirtualInterfaceId" ;
            public static string VirtualInterfaceArn =  "VirtualInterfaceArn" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.TransitVirtualInterface; }
        /// <summary>
        /// RateLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-ratelimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RateLimit { get; set; }

        /// <summary>
        /// BgpPeers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-bgppeers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BgpPeer
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer>, IReadOnlyList<Union<Humidifier.DirectConnect.TransitVirtualInterfaceTypes.BgpPeer, BaseFunction>>, BaseFunction>? BgpPeers { get; set; }

        /// <summary>
        /// ConnectionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-connectionid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectionId { get; set; }

        /// <summary>
        /// DirectConnectGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-directconnectgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DirectConnectGatewayId { get; set; }
        /// <summary>
        /// EnableSiteLink
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-enablesitelink
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableSiteLink { get; set; }

        /// <summary>
        /// VirtualInterfaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-virtualinterfacename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VirtualInterfaceName { get; set; }

        /// <summary>
        /// Vlan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-vlan
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Vlan { get; set; }
        /// <summary>
        /// AllocateTransitVirtualInterfaceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-allocatetransitvirtualinterfacerolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AllocateTransitVirtualInterfaceRoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Mtu
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-transitvirtualinterface.html#cfn-directconnect-transitvirtualinterface-mtu
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Mtu { get; set; }
    }

    namespace TransitVirtualInterfaceTypes
    {
        public class BgpPeer : Humidifier.Base.BaseSubResource, IHaveBgpPeerId, IHaveAuthKey, IHaveAddressFamily, IHaveAmazonAddress, IHaveAsn, IHaveCustomerAddress
        {
            /// <summary>
            /// BgpPeerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-transitvirtualinterface-bgppeer.html#cfn-directconnect-transitvirtualinterface-bgppeer-bgppeerid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BgpPeerId { get; set; }
            /// <summary>
            /// AuthKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-transitvirtualinterface-bgppeer.html#cfn-directconnect-transitvirtualinterface-bgppeer-authkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthKey { get; set; }
            /// <summary>
            /// AddressFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-transitvirtualinterface-bgppeer.html#cfn-directconnect-transitvirtualinterface-bgppeer-addressfamily
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressFamily { get; set; }
            /// <summary>
            /// AmazonAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-transitvirtualinterface-bgppeer.html#cfn-directconnect-transitvirtualinterface-bgppeer-amazonaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonAddress { get; set; }
            /// <summary>
            /// Asn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-transitvirtualinterface-bgppeer.html#cfn-directconnect-transitvirtualinterface-bgppeer-asn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Asn { get; set; }
            /// <summary>
            /// CustomerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-transitvirtualinterface-bgppeer.html#cfn-directconnect-transitvirtualinterface-bgppeer-customeraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerAddress { get; set; }
        }
    }
}