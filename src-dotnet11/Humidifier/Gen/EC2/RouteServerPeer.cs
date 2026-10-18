namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using RouteServerPeerTypes;

    public class RouteServerPeer : Humidifier.Base.BaseResource, IHaveTags, IHavePeerAddress, IHaveEC2RouteServerPeerTypesBgpOptionsBgpOptions, IHaveRouteServerEndpointId
    {
        public class Attributes
        {
            public static string EndpointEniId =  "EndpointEniId" ;
            public static string VpcId =  "VpcId" ;
            public static string Id =  "Id" ;
            public static string SubnetId =  "SubnetId" ;
            public static string Arn =  "Arn" ;
            public static string EndpointEniAddress =  "EndpointEniAddress" ;
            public static string RouteServerId =  "RouteServerId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.RouteServerPeer; }

        /// <summary>
        /// PeerAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserverpeer.html#cfn-ec2-routeserverpeer-peeraddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PeerAddress { get; set; }

        /// <summary>
        /// BgpOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserverpeer.html#cfn-ec2-routeserverpeer-bgpoptions
        /// Required: True
        /// UpdateType: Immutable
        /// Type: BgpOptions
        /// </summary>
        [Required]
        public Union<Humidifier.EC2.RouteServerPeerTypes.BgpOptions, BaseFunction>? BgpOptions { get; set; }

        /// <summary>
        /// RouteServerEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserverpeer.html#cfn-ec2-routeserverpeer-routeserverendpointid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RouteServerEndpointId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-routeserverpeer.html#cfn-ec2-routeserverpeer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace RouteServerPeerTypes
    {
        public class BgpOptions : Humidifier.Base.BaseSubResource, IHavePeerLivenessDetection, IHavePeerAsn_Long
        {
            /// <summary>
            /// PeerLivenessDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-routeserverpeer-bgpoptions.html#cfn-ec2-routeserverpeer-bgpoptions-peerlivenessdetection
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PeerLivenessDetection { get; set; }
            /// <summary>
            /// PeerAsn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-routeserverpeer-bgpoptions.html#cfn-ec2-routeserverpeer-bgpoptions-peerasn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? PeerAsn { get; set; }
        }
    }
}