namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;
    using PrivateVirtualInterfaceTypes;

    public class PrivateVirtualInterface : Humidifier.Base.BaseResource, IHaveTags, IHaveRateLimit, IHaveListOfDirectConnectPrivateVirtualInterfaceTypesBgpPeerBgpPeers, IHaveConnectionId, IHaveAllocatePrivateVirtualInterfaceRoleArn, IHaveDirectConnectGatewayId, IHaveEnableSiteLink_Boolean, IHaveVirtualInterfaceName, IHaveVlan_Integer, IHaveVirtualGatewayId, IHaveMtu_Integer
    {
        public class Attributes
        {
            public static string VirtualInterfaceId =  "VirtualInterfaceId" ;
            public static string VirtualInterfaceArn =  "VirtualInterfaceArn" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.PrivateVirtualInterface; }
        /// <summary>
        /// RateLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-ratelimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RateLimit { get; set; }

        /// <summary>
        /// BgpPeers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-bgppeers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BgpPeer
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer>, IReadOnlyList<Union<Humidifier.DirectConnect.PrivateVirtualInterfaceTypes.BgpPeer, BaseFunction>>, BaseFunction>? BgpPeers { get; set; }

        /// <summary>
        /// ConnectionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-connectionid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectionId { get; set; }
        /// <summary>
        /// AllocatePrivateVirtualInterfaceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-allocateprivatevirtualinterfacerolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AllocatePrivateVirtualInterfaceRoleArn { get; set; }
        /// <summary>
        /// DirectConnectGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-directconnectgatewayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DirectConnectGatewayId { get; set; }
        /// <summary>
        /// EnableSiteLink
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-enablesitelink
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableSiteLink { get; set; }

        /// <summary>
        /// VirtualInterfaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-virtualinterfacename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VirtualInterfaceName { get; set; }

        /// <summary>
        /// Vlan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-vlan
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Vlan { get; set; }
        /// <summary>
        /// VirtualGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-virtualgatewayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VirtualGatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Mtu
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-privatevirtualinterface.html#cfn-directconnect-privatevirtualinterface-mtu
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Mtu { get; set; }
    }

    namespace PrivateVirtualInterfaceTypes
    {
        public class BgpPeer : Humidifier.Base.BaseSubResource, IHaveBgpPeerId, IHaveAuthKey, IHaveAddressFamily, IHaveAmazonAddress, IHaveAsn, IHaveCustomerAddress
        {
            /// <summary>
            /// BgpPeerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-privatevirtualinterface-bgppeer.html#cfn-directconnect-privatevirtualinterface-bgppeer-bgppeerid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BgpPeerId { get; set; }
            /// <summary>
            /// AuthKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-privatevirtualinterface-bgppeer.html#cfn-directconnect-privatevirtualinterface-bgppeer-authkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthKey { get; set; }
            /// <summary>
            /// AddressFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-privatevirtualinterface-bgppeer.html#cfn-directconnect-privatevirtualinterface-bgppeer-addressfamily
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressFamily { get; set; }
            /// <summary>
            /// AmazonAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-privatevirtualinterface-bgppeer.html#cfn-directconnect-privatevirtualinterface-bgppeer-amazonaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonAddress { get; set; }
            /// <summary>
            /// Asn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-privatevirtualinterface-bgppeer.html#cfn-directconnect-privatevirtualinterface-bgppeer-asn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Asn { get; set; }
            /// <summary>
            /// CustomerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-privatevirtualinterface-bgppeer.html#cfn-directconnect-privatevirtualinterface-bgppeer-customeraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerAddress { get; set; }
        }
    }
}