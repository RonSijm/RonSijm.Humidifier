namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;
    using ConnectPeerTypes;

    public class ConnectPeer : Humidifier.Base.BaseResource, IHaveTags, IHaveConnectAttachmentId, IHavePeerAddress, IHaveSubnetArn, IHaveCoreNetworkAddress, IHaveNetworkManagerConnectPeerTypesBgpOptionsBgpOptions, IHaveStringListOfInsideCidrBlocks
    {
        public class Attributes
        {
            public static string CoreNetworkId =  "CoreNetworkId" ;
            public static string Configuration =  "Configuration" ;
            public static string State =  "State" ;
            public static string LastModificationErrors =  "LastModificationErrors" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ConnectPeerId =  "ConnectPeerId" ;
            public static string EdgeLocation =  "EdgeLocation" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.ConnectPeer; }

        /// <summary>
        /// ConnectAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectpeer.html#cfn-networkmanager-connectpeer-connectattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectAttachmentId { get; set; }

        /// <summary>
        /// PeerAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectpeer.html#cfn-networkmanager-connectpeer-peeraddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PeerAddress { get; set; }
        /// <summary>
        /// SubnetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectpeer.html#cfn-networkmanager-connectpeer-subnetarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SubnetArn { get; set; }
        /// <summary>
        /// CoreNetworkAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectpeer.html#cfn-networkmanager-connectpeer-corenetworkaddress
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CoreNetworkAddress { get; set; }
        /// <summary>
        /// BgpOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectpeer.html#cfn-networkmanager-connectpeer-bgpoptions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: BgpOptions
        /// </summary>
        public Union<Humidifier.NetworkManager.ConnectPeerTypes.BgpOptions, BaseFunction>? BgpOptions { get; set; }
        /// <summary>
        /// InsideCidrBlocks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectpeer.html#cfn-networkmanager-connectpeer-insidecidrblocks
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InsideCidrBlocks { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connectpeer.html#cfn-networkmanager-connectpeer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ConnectPeerTypes
    {
        public class BgpOptions : Humidifier.Base.BaseSubResource, IHavePeerAsn_Double
        {
            /// <summary>
            /// PeerAsn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-bgpoptions.html#cfn-networkmanager-connectpeer-bgpoptions-peerasn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PeerAsn { get; set; }
        }

        public class ConnectPeerBgpConfiguration : Humidifier.Base.BaseSubResource, IHavePeerAddress, IHaveCoreNetworkAddress, IHavePeerAsn_Double, IHaveCoreNetworkAsn_Double
        {
            /// <summary>
            /// PeerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerbgpconfiguration.html#cfn-networkmanager-connectpeer-connectpeerbgpconfiguration-peeraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PeerAddress { get; set; }
            /// <summary>
            /// CoreNetworkAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerbgpconfiguration.html#cfn-networkmanager-connectpeer-connectpeerbgpconfiguration-corenetworkaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CoreNetworkAddress { get; set; }
            /// <summary>
            /// PeerAsn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerbgpconfiguration.html#cfn-networkmanager-connectpeer-connectpeerbgpconfiguration-peerasn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PeerAsn { get; set; }
            /// <summary>
            /// CoreNetworkAsn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerbgpconfiguration.html#cfn-networkmanager-connectpeer-connectpeerbgpconfiguration-corenetworkasn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? CoreNetworkAsn { get; set; }
        }

        public class ConnectPeerConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfNetworkManagerConnectPeerTypesConnectPeerBgpConfigurationBgpConfigurations, IHavePeerAddress, IHaveCoreNetworkAddress, IHaveStringListOfInsideCidrBlocks, IHaveProtocol
        {
            /// <summary>
            /// BgpConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerconfiguration.html#cfn-networkmanager-connectpeer-connectpeerconfiguration-bgpconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConnectPeerBgpConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.NetworkManager.ConnectPeerTypes.ConnectPeerBgpConfiguration>, IReadOnlyList<Union<Humidifier.NetworkManager.ConnectPeerTypes.ConnectPeerBgpConfiguration, BaseFunction>>, BaseFunction>? BgpConfigurations { get; set; }
            /// <summary>
            /// PeerAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerconfiguration.html#cfn-networkmanager-connectpeer-connectpeerconfiguration-peeraddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PeerAddress { get; set; }
            /// <summary>
            /// CoreNetworkAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerconfiguration.html#cfn-networkmanager-connectpeer-connectpeerconfiguration-corenetworkaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CoreNetworkAddress { get; set; }
            /// <summary>
            /// InsideCidrBlocks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerconfiguration.html#cfn-networkmanager-connectpeer-connectpeerconfiguration-insidecidrblocks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InsideCidrBlocks { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-connectpeer-connectpeerconfiguration.html#cfn-networkmanager-connectpeer-connectpeerconfiguration-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }
    }
}