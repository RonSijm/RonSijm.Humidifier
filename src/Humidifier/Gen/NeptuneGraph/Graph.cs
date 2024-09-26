namespace Humidifier.NeptuneGraph
{
    using System.Collections.Generic;
    using GraphTypes;

    public class Graph : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDeletionProtection
    {
        public class Attributes
        {
            public static string Endpoint =  "Endpoint" ;
            public static string GraphArn =  "GraphArn" ;
            public static string GraphId =  "GraphId" ;
        }

        public override string AWSTypeName { get => AWS.NeptuneGraph.Graph; }
        /// <summary>
        /// PublicConnectivity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-publicconnectivity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PublicConnectivity { get; set; }
        public dynamic GraphName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ReplicaCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-replicacount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ReplicaCount { get; set; }

        /// <summary>
        /// ProvisionedMemory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-provisionedmemory
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic ProvisionedMemory { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtection { get; set; }
        /// <summary>
        /// VectorSearchConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-vectorsearchconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VectorSearchConfiguration
        /// </summary>
        public Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration VectorSearchConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace GraphTypes
    {
        public class VectorSearchConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VectorSearchDimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-vectorsearchconfiguration.html#cfn-neptunegraph-graph-vectorsearchconfiguration-vectorsearchdimension
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VectorSearchDimension { get; set; }
        }
    }
}