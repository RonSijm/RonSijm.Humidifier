namespace Humidifier.NeptuneGraph
{
    using global::System.Collections.Generic;
    using ExportTaskTypes;

    public class ExportTask : Humidifier.Base.BaseResource, IHaveTags, IHaveRoleArn, IHaveFormat, IHaveDestination, IHaveKmsKeyIdentifier
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
        public dynamic Destination { get; set; }

        /// <summary>
        /// KmsKeyIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-kmskeyidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Format { get; set; }
        /// <summary>
        /// ExportFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-exportfilter
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ExportFilter
        /// </summary>
        public Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilter ExportFilter { get; set; }

        /// <summary>
        /// GraphIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-graphidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GraphIdentifier { get; set; }
        /// <summary>
        /// ParquetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-parquettype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ParquetType { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptunegraph-exporttask.html#cfn-neptunegraph-exporttask-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ExportTaskTypes
    {
        public class ExportFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VertexFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilter.html#cfn-neptunegraph-exporttask-exportfilter-vertexfilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: ExportFilterElement
            /// </summary>
            public Dictionary<string, Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterElement> VertexFilter { get; set; }
            /// <summary>
            /// EdgeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilter.html#cfn-neptunegraph-exporttask-exportfilter-edgefilter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: ExportFilterElement
            /// </summary>
            public Dictionary<string, Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterElement> EdgeFilter { get; set; }
        }

        public class ExportFilterElement : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilterelement.html#cfn-neptunegraph-exporttask-exportfilterelement-properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: ExportFilterPropertyAttributes
            /// </summary>
            public Dictionary<string, Humidifier.NeptuneGraph.ExportTaskTypes.ExportFilterPropertyAttributes> Properties { get; set; }
        }

        public class ExportFilterPropertyAttributes : Humidifier.Base.BaseSubResource, IHaveOutputType
        {
            /// <summary>
            /// SourcePropertyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilterpropertyattributes.html#cfn-neptunegraph-exporttask-exportfilterpropertyattributes-sourcepropertyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePropertyName { get; set; }
            /// <summary>
            /// MultiValueHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilterpropertyattributes.html#cfn-neptunegraph-exporttask-exportfilterpropertyattributes-multivaluehandling
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MultiValueHandling { get; set; }
            /// <summary>
            /// OutputType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-neptunegraph-exporttask-exportfilterpropertyattributes.html#cfn-neptunegraph-exporttask-exportfilterpropertyattributes-outputtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputType { get; set; }
        }
    }
}