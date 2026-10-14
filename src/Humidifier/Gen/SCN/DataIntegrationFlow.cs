namespace Humidifier.SCN
{
    using global::System.Collections.Generic;
    using DataIntegrationFlowTypes;

    public class DataIntegrationFlow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveInstanceId
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SCN.DataIntegrationFlow; }

        /// <summary>
        /// Transformation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-transformation
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataIntegrationFlowTransformation
        /// </summary>
        [Required]
        public Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTransformation Transformation { get; set; }

        /// <summary>
        /// Target
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-target
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataIntegrationFlowTarget
        /// </summary>
        [Required]
        public Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTarget Target { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceId { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-sources
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataIntegrationFlowSource
        /// </summary>
        [Required]
        public List<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowSource> Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataIntegrationFlowTypes
    {
        public class DataIntegrationFlowSource : Humidifier.Base.BaseSubResource, IHaveSourceType, IHaveSourceName
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowsource.html#cfn-scn-dataintegrationflow-dataintegrationflowsource-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowsource.html#cfn-scn-dataintegrationflow-dataintegrationflowsource-sourcename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceName { get; set; }
            /// <summary>
            /// DatasetSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowsource.html#cfn-scn-dataintegrationflow-dataintegrationflowsource-datasetsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetSourceConfiguration
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.DatasetSourceConfiguration DatasetSource { get; set; }
            /// <summary>
            /// S3Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowsource.html#cfn-scn-dataintegrationflow-dataintegrationflowsource-s3source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3SourceConfiguration
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.S3SourceConfiguration S3Source { get; set; }
        }

        public class DataIntegrationFlowTarget : Humidifier.Base.BaseSubResource, IHaveTargetType
        {
            /// <summary>
            /// DatasetTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowtarget.html#cfn-scn-dataintegrationflow-dataintegrationflowtarget-datasettarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetTargetConfiguration
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration DatasetTarget { get; set; }
            /// <summary>
            /// TargetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowtarget.html#cfn-scn-dataintegrationflow-dataintegrationflowtarget-targettype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetType { get; set; }
        }

        public class DataIntegrationFlowTransformation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SqlTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowtransformation.html#cfn-scn-dataintegrationflow-dataintegrationflowtransformation-sqltransformation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqlTransformationConfiguration
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration SqlTransformation { get; set; }
            /// <summary>
            /// TransformationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowtransformation.html#cfn-scn-dataintegrationflow-dataintegrationflowtransformation-transformationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TransformationType { get; set; }
        }

        public class DatasetOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LoadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetoptions.html#cfn-scn-dataintegrationflow-datasetoptions-loadtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoadType { get; set; }
            /// <summary>
            /// DedupeRecords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetoptions.html#cfn-scn-dataintegrationflow-datasetoptions-deduperecords
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DedupeRecords { get; set; }
            /// <summary>
            /// DedupeStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetoptions.html#cfn-scn-dataintegrationflow-datasetoptions-dedupestrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DedupeStrategy
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy DedupeStrategy { get; set; }
        }

        public class DatasetSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetsourceconfiguration.html#cfn-scn-dataintegrationflow-datasetsourceconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetOptions
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions Options { get; set; }
            /// <summary>
            /// DatasetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetsourceconfiguration.html#cfn-scn-dataintegrationflow-datasetsourceconfiguration-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatasetIdentifier { get; set; }
        }

        public class DatasetTargetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasettargetconfiguration.html#cfn-scn-dataintegrationflow-datasettargetconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetOptions
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions Options { get; set; }
            /// <summary>
            /// DatasetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasettargetconfiguration.html#cfn-scn-dataintegrationflow-datasettargetconfiguration-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatasetIdentifier { get; set; }
        }

        public class DedupeStrategy : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dedupestrategy.html#cfn-scn-dataintegrationflow-dedupestrategy-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// FieldPriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dedupestrategy.html#cfn-scn-dataintegrationflow-dedupestrategy-fieldpriority
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldPriorityDedupeStrategyConfiguration
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration FieldPriority { get; set; }
        }

        public class FieldPriorityDedupeField : Humidifier.Base.BaseSubResource, IHaveName, IHaveSortOrder
        {
            /// <summary>
            /// SortOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-fieldprioritydedupefield.html#cfn-scn-dataintegrationflow-fieldprioritydedupefield-sortorder
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SortOrder { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-fieldprioritydedupefield.html#cfn-scn-dataintegrationflow-fieldprioritydedupefield-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FieldPriorityDedupeStrategyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-fieldprioritydedupestrategyconfiguration.html#cfn-scn-dataintegrationflow-fieldprioritydedupestrategyconfiguration-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldPriorityDedupeField
            /// </summary>
            public List<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeField> Fields { get; set; }
        }

        public class S3Options : Humidifier.Base.BaseSubResource, IHaveFileType
        {
            /// <summary>
            /// FileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-s3options.html#cfn-scn-dataintegrationflow-s3options-filetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileType { get; set; }
        }

        public class S3SourceConfiguration : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveBucketName
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-s3sourceconfiguration.html#cfn-scn-dataintegrationflow-s3sourceconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Options
            /// </summary>
            public Humidifier.SCN.DataIntegrationFlowTypes.S3Options Options { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-s3sourceconfiguration.html#cfn-scn-dataintegrationflow-s3sourceconfiguration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-s3sourceconfiguration.html#cfn-scn-dataintegrationflow-s3sourceconfiguration-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
        }

        public class SqlTransformationConfiguration : Humidifier.Base.BaseSubResource, IHaveQuery
        {
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-sqltransformationconfiguration.html#cfn-scn-dataintegrationflow-sqltransformationconfiguration-query
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Query { get; set; }
        }
    }
}