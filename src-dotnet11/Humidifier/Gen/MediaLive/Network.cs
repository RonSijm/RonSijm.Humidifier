namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using NetworkTypes;

    public class Network : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfMediaLiveNetworkTypesIpPoolIpPools, IHaveListOfMediaLiveNetworkTypesRouteRoutes, IHaveListOfMediaLiveNetworkTypesTagsTags, IHaveName
    {
        public class Attributes
        {
            public static string AssociatedClusterIds =  "AssociatedClusterIds" ;
            public static string State =  "State" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Network; }

        /// <summary>
        /// IpPools
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-network.html#cfn-medialive-network-ippools
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpPool
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MediaLive.NetworkTypes.IpPool>, IReadOnlyList<Union<Humidifier.MediaLive.NetworkTypes.IpPool, BaseFunction>>, BaseFunction>? IpPools { get; set; }
        /// <summary>
        /// Routes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-network.html#cfn-medialive-network-routes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Route
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.NetworkTypes.Route>, IReadOnlyList<Union<Humidifier.MediaLive.NetworkTypes.Route, BaseFunction>>, BaseFunction>? Routes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-network.html#cfn-medialive-network-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.NetworkTypes.Tags>, IReadOnlyList<Union<Humidifier.MediaLive.NetworkTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace NetworkTypes
    {
        public class IpPool : Humidifier.Base.BaseSubResource, IHaveCidr
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-network-ippool.html#cfn-medialive-network-ippool-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
        }

        public class Route : Humidifier.Base.BaseSubResource, IHaveCidr, IHaveGateway
        {
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-network-route.html#cfn-medialive-network-route-cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
            /// <summary>
            /// Gateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-network-route.html#cfn-medialive-network-route-gateway
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gateway { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-network-tags.html#cfn-medialive-network-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-network-tags.html#cfn-medialive-network-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}