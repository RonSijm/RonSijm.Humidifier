namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using NetworkTypes;

    public class Network : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
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
        public List<Humidifier.MediaLive.NetworkTypes.IpPool> IpPools { get; set; }
        /// <summary>
        /// Routes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-network.html#cfn-medialive-network-routes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Route
        /// </summary>
        public List<Humidifier.MediaLive.NetworkTypes.Route> Routes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-network.html#cfn-medialive-network-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public List<Humidifier.MediaLive.NetworkTypes.Tags> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Cidr { get; set; }
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
            public dynamic Cidr { get; set; }
            /// <summary>
            /// Gateway
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-network-route.html#cfn-medialive-network-route-gateway
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gateway { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-network-tags.html#cfn-medialive-network-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}