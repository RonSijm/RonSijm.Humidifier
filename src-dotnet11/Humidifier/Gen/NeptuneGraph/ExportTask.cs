namespace Humidifier.NeptuneGraph
{
    using global::System.Collections.Generic;
    using ExportTaskTypes;

    public class ExportTask : Humidifier.Base.BaseResource, IHaveTags, IHaveDestination, IHaveKmsKeyIdentifier, IHaveFormat, IHaveNeptuneGraphExportTaskTypesExportFilterExportFilter, IHaveGraphIdentifier, IHaveParquetType, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TaskId =  "TaskId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.NeptuneGraph.ExportTask; }

        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-destination
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Destination { get; set; }

        /// <summary>
        /// KmsKeyIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-kmskeyidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Format { get; set; }
        /// <summary>
        /// ExportFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-exportfilter
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExportFilter
        /// </summary>
        public Union<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter, BaseFunction>? ExportFilter { get; set; }

        /// <summary>
        /// GraphIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-graphidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GraphIdentifier { get; set; }
        /// <summary>
        /// ParquetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-parquettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ParquetType { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ExportTaskTypes
    {
        public class ExportFilter : Humidifier.Base.BaseSubResource, IHaveMapOfNeptuneGraphExportTaskTypesExportFilterElementVertexFilter, IHaveMapOfNeptuneGraphExportTaskTypesExportFilterElementEdgeFilter
        {
            /// <summary>
            /// VertexFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilter.html#cfn-neptunegraph-exporttask-exportfilter-vertexfilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: ExportFilterElement
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterElement>, IReadOnlyDictionary<string, Union<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterElement, BaseFunction>>, BaseFunction>? VertexFilter { get; set; }
            /// <summary>
            /// EdgeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilter.html#cfn-neptunegraph-exporttask-exportfilter-edgefilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: ExportFilterElement
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterElement>, IReadOnlyDictionary<string, Union<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterElement, BaseFunction>>, BaseFunction>? EdgeFilter { get; set; }
        }

        public class ExportFilterElement : Humidifier.Base.BaseSubResource, IHaveMapOfNeptuneGraphExportTaskTypesExportFilterPropertyAttributesProperties
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilterelement.html#cfn-neptunegraph-exporttask-exportfilterelement-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: ExportFilterPropertyAttributes
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterPropertyAttributes>, IReadOnlyDictionary<string, Union<Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterPropertyAttributes, BaseFunction>>, BaseFunction>? Properties { get; set; }
        }

        public class ExportFilterPropertyAttributes : Humidifier.Base.BaseSubResource, IHaveSourcePropertyName, IHaveMultiValueHandling, IHaveOutputType
        {
            /// <summary>
            /// SourcePropertyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilterpropertyattributes.html#cfn-neptunegraph-exporttask-exportfilterpropertyattributes-sourcepropertyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePropertyName { get; set; }
            /// <summary>
            /// MultiValueHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilterpropertyattributes.html#cfn-neptunegraph-exporttask-exportfilterpropertyattributes-multivaluehandling
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MultiValueHandling { get; set; }
            /// <summary>
            /// OutputType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilterpropertyattributes.html#cfn-neptunegraph-exporttask-exportfilterpropertyattributes-outputtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputType { get; set; }
        }
    }
}