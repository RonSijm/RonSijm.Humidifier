namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;
    using PublicVirtualInterfaceTypes;

    public class PublicVirtualInterface : Humidifier.Base.BaseResource, IHaveTags, IHaveRateLimit, IHaveListOfDirectConnectPublicVirtualInterfaceTypesBgpPeerBgpPeers, IHaveConnectionId, IHaveStringListOfRouteFilterPrefixes, IHaveVirtualInterfaceName, IHaveVlan_Integer, IHaveAllocatePublicVirtualInterfaceRoleArn
    {
        public class Attributes
        {
            public static string VirtualInterfaceId =  "VirtualInterfaceId" ;
            public static string VirtualInterfaceArn =  "VirtualInterfaceArn" ;
        }

        public override string AWSTypeName { get => AWS.DirectConnect.PublicVirtualInterface; }
        /// <summary>
        /// RateLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-ratelimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RateLimit { get; set; }

        /// <summary>
        /// BgpPeers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-bgppeers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BgpPeer
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer>, IReadOnlyList<Union<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer, BaseFunction>>, BaseFunction>? BgpPeers { get; set; }

        /// <summary>
        /// ConnectionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-connectionid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectionId { get; set; }
        /// <summary>
        /// RouteFilterPrefixes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-routefilterprefixes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RouteFilterPrefixes { get; set; }

        /// <summary>
        /// VirtualInterfaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-virtualinterfacename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VirtualInterfaceName { get; set; }

        /// <summary>
        /// Vlan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-vlan
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Vlan { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AllocatePublicVirtualInterfaceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-allocatepublicvirtualinterfacerolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AllocatePublicVirtualInterfaceRoleArn { get; set; }
    }

    namespace PublicVirtualInterfaceTypes
    {
        public class BgpPeer : Humidifier.Base.BaseSubResource, IHaveBgpPeerId, IHaveAuthKey, IHaveAddressFamily, IHaveAmazonAddress, IHaveAsn, IHaveCustomerAddress
        {
            /// <summary>
            /// BgpPeerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-bgppeerid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BgpPeerId { get; set; }
            /// <summary>
            /// AuthKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-authkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthKey { get; set; }
            /// <summary>
            /// AddressFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-addressfamily
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddressFamily { get; set; }
            /// <summary>
            /// AmazonAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-amazonaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonAddress { get; set; }
            /// <summary>
            /// Asn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-asn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Asn { get; set; }
            /// <summary>
            /// CustomerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-customeraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomerAddress { get; set; }
        }
    }
}