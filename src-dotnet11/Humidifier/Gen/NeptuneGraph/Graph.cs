namespace Humidifier.NeptuneGraph
{
    using global::System.Collections.Generic;
    using GraphTypes;

    public class Graph : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePublicConnectivity_Boolean, IHaveKmsKeyIdentifier, IHaveGraphName, IHaveNeptuneGraphGraphTypesImportTaskImportTask, IHaveReplicaCount_Integer, IHaveProvisionedMemory_Integer, IHaveDeletionProtection_Boolean, IHaveNeptuneGraphGraphTypesVectorSearchConfigurationVectorSearchConfiguration
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
        public Union<bool, BaseFunction>? PublicConnectivity { get; set; }
        /// <summary>
        /// KmsKeyIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-kmskeyidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyIdentifier { get; set; }
        public Union<string, BaseFunction>? GraphName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ImportTask
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-importtask
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ImportTask
        /// </summary>
        public Union<Humidifier.NeptuneGraph.GraphTypes.ImportTask, BaseFunction>? ImportTask { get; set; }
        /// <summary>
        /// ReplicaCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-replicacount
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ReplicaCount { get; set; }

        /// <summary>
        /// ProvisionedMemory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-provisionedmemory
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? ProvisionedMemory { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// VectorSearchConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-vectorsearchconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VectorSearchConfiguration
        /// </summary>
        public Union<Humidifier.NeptuneGraph.GraphTypes.VectorSearchConfiguration, BaseFunction>? VectorSearchConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-graph.html#cfn-neptunegraph-graph-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace GraphTypes
    {
        public class ImportOptions : Humidifier.Base.BaseSubResource, IHaveNeptuneGraphGraphTypesNeptuneImportOptionsNeptune
        {
            /// <summary>
            /// Neptune
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importoptions.html#cfn-neptunegraph-graph-importoptions-neptune
            /// Required: False
            /// UpdateType: Immutable
            /// Type: NeptuneImportOptions
            /// </summary>
            public Union<Humidifier.NeptuneGraph.GraphTypes.NeptuneImportOptions, BaseFunction>? Neptune { get; set; }
        }

        public class ImportTask : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveBlankNodeHandling, IHaveParquetType, IHaveFailOnError_Boolean, IHaveMaxProvisionedMemory_Integer, IHaveSource, IHaveRoleArn, IHaveNeptuneGraphGraphTypesImportOptionsImportOptions, IHaveMinProvisionedMemory_Integer
        {
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-format
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// BlankNodeHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-blanknodehandling
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BlankNodeHandling { get; set; }
            /// <summary>
            /// ParquetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-parquettype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParquetType { get; set; }
            /// <summary>
            /// FailOnError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-failonerror
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FailOnError { get; set; }
            /// <summary>
            /// MaxProvisionedMemory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-maxprovisionedmemory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxProvisionedMemory { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-source
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// ImportOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-importoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ImportOptions
            /// </summary>
            public Union<Humidifier.NeptuneGraph.GraphTypes.ImportOptions, BaseFunction>? ImportOptions { get; set; }
            /// <summary>
            /// MinProvisionedMemory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-importtask.html#cfn-neptunegraph-graph-importtask-minprovisionedmemory
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinProvisionedMemory { get; set; }
        }

        public class NeptuneImportOptions : Humidifier.Base.BaseSubResource, IHavePreserveDefaultVertexLabels_Boolean, IHaveS3ExportKmsKeyId, IHaveS3ExportPath, IHavePreserveEdgeIds_Boolean
        {
            /// <summary>
            /// PreserveDefaultVertexLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-neptuneimportoptions.html#cfn-neptunegraph-graph-neptuneimportoptions-preservedefaultvertexlabels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PreserveDefaultVertexLabels { get; set; }
            /// <summary>
            /// S3ExportKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-neptuneimportoptions.html#cfn-neptunegraph-graph-neptuneimportoptions-s3exportkmskeyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ExportKmsKeyId { get; set; }
            /// <summary>
            /// S3ExportPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-neptuneimportoptions.html#cfn-neptunegraph-graph-neptuneimportoptions-s3exportpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ExportPath { get; set; }
            /// <summary>
            /// PreserveEdgeIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-neptuneimportoptions.html#cfn-neptunegraph-graph-neptuneimportoptions-preserveedgeids
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PreserveEdgeIds { get; set; }
        }

        public class VectorSearchConfiguration : Humidifier.Base.BaseSubResource, IHaveVectorSearchDimension_Integer
        {
            /// <summary>
            /// VectorSearchDimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-graph-vectorsearchconfiguration.html#cfn-neptunegraph-graph-vectorsearchconfiguration-vectorsearchdimension
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VectorSearchDimension { get; set; }
        }
    }
}