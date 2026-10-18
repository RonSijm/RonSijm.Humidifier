namespace Humidifier.SCN
{
    using global::System.Collections.Generic;
    using DataIntegrationFlowTypes;

    public class DataIntegrationFlow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSCNDataIntegrationFlowTypesDataIntegrationFlowTransformationTransformation, IHaveSCNDataIntegrationFlowTypesDataIntegrationFlowTargetTarget, IHaveInstanceId, IHaveListOfSCNDataIntegrationFlowTypesDataIntegrationFlowSourceSources, IHaveName
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
        public Union<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTransformation, BaseFunction>? Transformation { get; set; }

        /// <summary>
        /// Target
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-target
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataIntegrationFlowTarget
        /// </summary>
        [Required]
        public Union<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTarget, BaseFunction>? Target { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceId { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-sources
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataIntegrationFlowSource
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowSource>, IReadOnlyList<Union<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowSource, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataintegrationflow.html#cfn-scn-dataintegrationflow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataIntegrationFlowTypes
    {
        public class DataIntegrationFlowSource : Humidifier.Base.BaseSubResource, IHaveSourceType, IHaveSourceName, IHaveSCNDataIntegrationFlowTypesDatasetSourceConfigurationDatasetSource, IHaveSCNDataIntegrationFlowTypesS3SourceConfigurationS3Source
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowsource.html#cfn-scn-dataintegrationflow-dataintegrationflowsource-sourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
            /// <summary>
            /// SourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowsource.html#cfn-scn-dataintegrationflow-dataintegrationflowsource-sourcename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceName { get; set; }
            /// <summary>
            /// DatasetSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowsource.html#cfn-scn-dataintegrationflow-dataintegrationflowsource-datasetsource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetSourceConfiguration
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.DatasetSourceConfiguration, BaseFunction>? DatasetSource { get; set; }
            /// <summary>
            /// S3Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowsource.html#cfn-scn-dataintegrationflow-dataintegrationflowsource-s3source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3SourceConfiguration
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.S3SourceConfiguration, BaseFunction>? S3Source { get; set; }
        }

        public class DataIntegrationFlowTarget : Humidifier.Base.BaseSubResource, IHaveSCNDataIntegrationFlowTypesDatasetTargetConfigurationDatasetTarget, IHaveTargetType
        {
            /// <summary>
            /// DatasetTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowtarget.html#cfn-scn-dataintegrationflow-dataintegrationflowtarget-datasettarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetTargetConfiguration
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.DatasetTargetConfiguration, BaseFunction>? DatasetTarget { get; set; }
            /// <summary>
            /// TargetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowtarget.html#cfn-scn-dataintegrationflow-dataintegrationflowtarget-targettype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetType { get; set; }
        }

        public class DataIntegrationFlowTransformation : Humidifier.Base.BaseSubResource, IHaveSCNDataIntegrationFlowTypesSqlTransformationConfigurationSqlTransformation, IHaveTransformationType
        {
            /// <summary>
            /// SqlTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowtransformation.html#cfn-scn-dataintegrationflow-dataintegrationflowtransformation-sqltransformation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqlTransformationConfiguration
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration, BaseFunction>? SqlTransformation { get; set; }
            /// <summary>
            /// TransformationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dataintegrationflowtransformation.html#cfn-scn-dataintegrationflow-dataintegrationflowtransformation-transformationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TransformationType { get; set; }
        }

        public class DatasetOptions : Humidifier.Base.BaseSubResource, IHaveLoadType, IHaveDedupeRecords_Boolean, IHaveSCNDataIntegrationFlowTypesDedupeStrategyDedupeStrategy
        {
            /// <summary>
            /// LoadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetoptions.html#cfn-scn-dataintegrationflow-datasetoptions-loadtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LoadType { get; set; }
            /// <summary>
            /// DedupeRecords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetoptions.html#cfn-scn-dataintegrationflow-datasetoptions-deduperecords
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DedupeRecords { get; set; }
            /// <summary>
            /// DedupeStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetoptions.html#cfn-scn-dataintegrationflow-datasetoptions-dedupestrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DedupeStrategy
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.DedupeStrategy, BaseFunction>? DedupeStrategy { get; set; }
        }

        public class DatasetSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveSCNDataIntegrationFlowTypesDatasetOptionsOptions, IHaveDatasetIdentifier
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetsourceconfiguration.html#cfn-scn-dataintegrationflow-datasetsourceconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetOptions
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions, BaseFunction>? Options { get; set; }
            /// <summary>
            /// DatasetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasetsourceconfiguration.html#cfn-scn-dataintegrationflow-datasetsourceconfiguration-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetIdentifier { get; set; }
        }

        public class DatasetTargetConfiguration : Humidifier.Base.BaseSubResource, IHaveSCNDataIntegrationFlowTypesDatasetOptionsOptions, IHaveDatasetIdentifier
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasettargetconfiguration.html#cfn-scn-dataintegrationflow-datasettargetconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatasetOptions
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.DatasetOptions, BaseFunction>? Options { get; set; }
            /// <summary>
            /// DatasetIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-datasettargetconfiguration.html#cfn-scn-dataintegrationflow-datasettargetconfiguration-datasetidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetIdentifier { get; set; }
        }

        public class DedupeStrategy : Humidifier.Base.BaseSubResource, IHaveType, IHaveSCNDataIntegrationFlowTypesFieldPriorityDedupeStrategyConfigurationFieldPriority
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dedupestrategy.html#cfn-scn-dataintegrationflow-dedupestrategy-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// FieldPriority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-dedupestrategy.html#cfn-scn-dataintegrationflow-dedupestrategy-fieldpriority
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FieldPriorityDedupeStrategyConfiguration
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeStrategyConfiguration, BaseFunction>? FieldPriority { get; set; }
        }

        public class FieldPriorityDedupeField : Humidifier.Base.BaseSubResource, IHaveSortOrder, IHaveName
        {
            /// <summary>
            /// SortOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-fieldprioritydedupefield.html#cfn-scn-dataintegrationflow-fieldprioritydedupefield-sortorder
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SortOrder { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-fieldprioritydedupefield.html#cfn-scn-dataintegrationflow-fieldprioritydedupefield-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FieldPriorityDedupeStrategyConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfSCNDataIntegrationFlowTypesFieldPriorityDedupeFieldFields
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-fieldprioritydedupestrategyconfiguration.html#cfn-scn-dataintegrationflow-fieldprioritydedupestrategyconfiguration-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FieldPriorityDedupeField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeField>, IReadOnlyList<Union<Humidifier.SCN.DataIntegrationFlowTypes.FieldPriorityDedupeField, BaseFunction>>, BaseFunction>? Fields { get; set; }
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
            public Union<string, BaseFunction>? FileType { get; set; }
        }

        public class S3SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveSCNDataIntegrationFlowTypesS3OptionsOptions, IHaveBucketName, IHavePrefix
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-s3sourceconfiguration.html#cfn-scn-dataintegrationflow-s3sourceconfiguration-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Options
            /// </summary>
            public Union<Humidifier.SCN.DataIntegrationFlowTypes.S3Options, BaseFunction>? Options { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-s3sourceconfiguration.html#cfn-scn-dataintegrationflow-s3sourceconfiguration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataintegrationflow-s3sourceconfiguration.html#cfn-scn-dataintegrationflow-s3sourceconfiguration-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Prefix { get; set; }
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
            public Union<string, BaseFunction>? Query { get; set; }
        }
    }
}