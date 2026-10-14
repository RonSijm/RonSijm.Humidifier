namespace Humidifier.DirectConnect
{
    using global::System.Collections.Generic;
    using PublicVirtualInterfaceTypes;

    public class PublicVirtualInterface : Humidifier.Base.BaseResource, IHaveTags, IHaveRateLimit, IHaveConnectionId
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
        public dynamic RateLimit { get; set; }

        /// <summary>
        /// BgpPeers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-bgppeers
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BgpPeer
        /// </summary>
        [Required]
        public List<Humidifier.DirectConnect.PublicVirtualInterfaceTypes.BgpPeer> BgpPeers { get; set; }

        /// <summary>
        /// ConnectionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-connectionid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectionId { get; set; }
        /// <summary>
        /// RouteFilterPrefixes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-routefilterprefixes
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic RouteFilterPrefixes { get; set; }

        /// <summary>
        /// VirtualInterfaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-virtualinterfacename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VirtualInterfaceName { get; set; }

        /// <summary>
        /// Vlan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-vlan
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic Vlan { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// AllocatePublicVirtualInterfaceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directconnect-publicvirtualinterface.html#cfn-directconnect-publicvirtualinterface-allocatepublicvirtualinterfacerolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AllocatePublicVirtualInterfaceRoleArn { get; set; }
    }

    namespace PublicVirtualInterfaceTypes
    {
        public class BgpPeer : Humidifier.Base.BaseSubResource, IHaveAddressFamily
        {
            /// <summary>
            /// BgpPeerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-bgppeerid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BgpPeerId { get; set; }
            /// <summary>
            /// AuthKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-authkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthKey { get; set; }
            /// <summary>
            /// AddressFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-addressfamily
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddressFamily { get; set; }
            /// <summary>
            /// AmazonAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-amazonaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AmazonAddress { get; set; }
            /// <summary>
            /// Asn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-asn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Asn { get; set; }
            /// <summary>
            /// CustomerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directconnect-publicvirtualinterface-bgppeer.html#cfn-directconnect-publicvirtualinterface-bgppeer-customeraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomerAddress { get; set; }
        }
    }
}