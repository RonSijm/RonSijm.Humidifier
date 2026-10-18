namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMediaLiveClusterTypesClusterNetworkSettingsNetworkSettings, IHaveInstanceRoleArn, IHaveClusterType, IHaveListOfMediaLiveClusterTypesTagsTags, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string ChannelIds =  "ChannelIds" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Cluster; }
        /// <summary>
        /// NetworkSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cluster.html#cfn-medialive-cluster-networksettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClusterNetworkSettings
        /// </summary>
        public Union<Humidifier.MediaLive.ClusterTypes.ClusterNetworkSettings, BaseFunction>? NetworkSettings { get; set; }
        /// <summary>
        /// InstanceRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cluster.html#cfn-medialive-cluster-instancerolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceRoleArn { get; set; }
        /// <summary>
        /// ClusterType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cluster.html#cfn-medialive-cluster-clustertype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClusterType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-cluster.html#cfn-medialive-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.ClusterTypes.Tags>, IReadOnlyList<Union<Humidifier.MediaLive.ClusterTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ClusterTypes
    {
        public class ClusterNetworkSettings : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveClusterTypesInterfaceMappingInterfaceMappings, IHaveDefaultRoute
        {
            /// <summary>
            /// InterfaceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-cluster-clusternetworksettings.html#cfn-medialive-cluster-clusternetworksettings-interfacemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InterfaceMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.ClusterTypes.InterfaceMapping>, IReadOnlyList<Union<Humidifier.MediaLive.ClusterTypes.InterfaceMapping, BaseFunction>>, BaseFunction>? InterfaceMappings { get; set; }
            /// <summary>
            /// DefaultRoute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-cluster-clusternetworksettings.html#cfn-medialive-cluster-clusternetworksettings-defaultroute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultRoute { get; set; }
        }

        public class InterfaceMapping : Humidifier.Base.BaseSubResource, IHaveNetworkId, IHaveLogicalInterfaceName
        {
            /// <summary>
            /// NetworkId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-cluster-interfacemapping.html#cfn-medialive-cluster-interfacemapping-networkid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkId { get; set; }
            /// <summary>
            /// LogicalInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-cluster-interfacemapping.html#cfn-medialive-cluster-interfacemapping-logicalinterfacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalInterfaceName { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-cluster-tags.html#cfn-medialive-cluster-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-cluster-tags.html#cfn-medialive-cluster-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}