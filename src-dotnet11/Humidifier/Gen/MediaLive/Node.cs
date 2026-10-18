namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using NodeTypes;

    public class Node : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRole, IHaveListOfMediaLiveNodeTypesNodeInterfaceMappingNodeInterfaceMappings, IHaveClusterId, IHaveListOfMediaLiveNodeTypesSdiSourceMappingSdiSourceMappings, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string InstanceArn =  "InstanceArn" ;
            public static string ConnectionState =  "ConnectionState" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string ChannelPlacementGroups =  "ChannelPlacementGroups" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Node; }
        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-node.html#cfn-medialive-node-role
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// NodeInterfaceMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-node.html#cfn-medialive-node-nodeinterfacemappings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: NodeInterfaceMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping>, IReadOnlyList<Union<Humidifier.MediaLive.NodeTypes.NodeInterfaceMapping, BaseFunction>>, BaseFunction>? NodeInterfaceMappings { get; set; }

        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-node.html#cfn-medialive-node-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterId { get; set; }
        /// <summary>
        /// SdiSourceMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-node.html#cfn-medialive-node-sdisourcemappings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SdiSourceMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.NodeTypes.SdiSourceMapping>, IReadOnlyList<Union<Humidifier.MediaLive.NodeTypes.SdiSourceMapping, BaseFunction>>, BaseFunction>? SdiSourceMappings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-node.html#cfn-medialive-node-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace NodeTypes
    {
        public class NodeInterfaceMapping : Humidifier.Base.BaseSubResource, IHaveNetworkInterfaceMode, IHavePhysicalInterfaceName, IHaveLogicalInterfaceName
        {
            /// <summary>
            /// NetworkInterfaceMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-node-nodeinterfacemapping.html#cfn-medialive-node-nodeinterfacemapping-networkinterfacemode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceMode { get; set; }
            /// <summary>
            /// PhysicalInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-node-nodeinterfacemapping.html#cfn-medialive-node-nodeinterfacemapping-physicalinterfacename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PhysicalInterfaceName { get; set; }
            /// <summary>
            /// LogicalInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-node-nodeinterfacemapping.html#cfn-medialive-node-nodeinterfacemapping-logicalinterfacename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalInterfaceName { get; set; }
        }

        public class SdiSourceMapping : Humidifier.Base.BaseSubResource, IHaveCardNumber_Integer, IHaveChannelNumber_Integer, IHaveSdiSource
        {
            /// <summary>
            /// CardNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-node-sdisourcemapping.html#cfn-medialive-node-sdisourcemapping-cardnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CardNumber { get; set; }
            /// <summary>
            /// ChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-node-sdisourcemapping.html#cfn-medialive-node-sdisourcemapping-channelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ChannelNumber { get; set; }
            /// <summary>
            /// SdiSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-node-sdisourcemapping.html#cfn-medialive-node-sdisourcemapping-sdisource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SdiSource { get; set; }
        }
    }
}