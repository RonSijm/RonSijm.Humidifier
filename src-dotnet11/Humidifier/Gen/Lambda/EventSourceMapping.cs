namespace Humidifier.Lambda
{
    using global::System.Collections.Generic;
    using EventSourceMappingTypes;

    public class EventSourceMapping : Humidifier.Base.BaseResource, IHaveTags, IHaveStartingPosition, IHaveLambdaEventSourceMappingTypesSelfManagedEventSourceSelfManagedEventSource, IHaveParallelizationFactor_Integer, IHaveLambdaEventSourceMappingTypesFilterCriteriaFilterCriteria, IHaveLambdaEventSourceMappingTypesProvisionedPollerConfigProvisionedPollerConfig, IHaveLambdaEventSourceMappingTypesMetricsConfigMetricsConfig, IHaveFunctionName, IHaveLambdaEventSourceMappingTypesDestinationConfigDestinationConfig, IHaveKmsKeyArn, IHaveLambdaEventSourceMappingTypesAmazonManagedKafkaEventSourceConfigAmazonManagedKafkaEventSourceConfig, IHaveListOfLambdaEventSourceMappingTypesSourceAccessConfigurationSourceAccessConfigurations, IHaveMaximumBatchingWindowInSeconds_Integer, IHaveBatchSize_Integer, IHaveMaximumRetryAttempts_Integer, IHaveStringListOfTopics, IHaveLambdaEventSourceMappingTypesScalingConfigScalingConfig, IHaveEnabled_Boolean, IHaveEventSourceArn, IHaveLambdaEventSourceMappingTypesSelfManagedKafkaEventSourceConfigSelfManagedKafkaEventSourceConfig, IHaveLambdaEventSourceMappingTypesDocumentDBEventSourceConfigDocumentDBEventSourceConfig, IHaveTumblingWindowInSeconds_Integer, IHaveBisectBatchOnFunctionError_Boolean, IHaveMaximumRecordAgeInSeconds_Integer, IHaveStartingPositionTimestamp_Double, IHaveLambdaEventSourceMappingTypesLoggingConfigLoggingConfig, IHaveStringListOfQueues, IHaveStringListOfFunctionResponseTypes
    {
        public class Attributes
        {
            public static string EventSourceMappingArn =  "EventSourceMappingArn" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.Lambda.EventSourceMapping; }
        /// <summary>
        /// StartingPosition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-startingposition
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StartingPosition { get; set; }
        /// <summary>
        /// SelfManagedEventSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-selfmanagedeventsource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SelfManagedEventSource
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.SelfManagedEventSource, BaseFunction>? SelfManagedEventSource { get; set; }
        /// <summary>
        /// ParallelizationFactor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-parallelizationfactor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ParallelizationFactor { get; set; }
        /// <summary>
        /// FilterCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-filtercriteria
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FilterCriteria
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.FilterCriteria, BaseFunction>? FilterCriteria { get; set; }
        /// <summary>
        /// ProvisionedPollerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-provisionedpollerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProvisionedPollerConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.ProvisionedPollerConfig, BaseFunction>? ProvisionedPollerConfig { get; set; }
        /// <summary>
        /// MetricsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-metricsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetricsConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.MetricsConfig, BaseFunction>? MetricsConfig { get; set; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-functionname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FunctionName { get; set; }
        /// <summary>
        /// DestinationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-destinationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DestinationConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.DestinationConfig, BaseFunction>? DestinationConfig { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// AmazonManagedKafkaEventSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-amazonmanagedkafkaeventsourceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AmazonManagedKafkaEventSourceConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig, BaseFunction>? AmazonManagedKafkaEventSourceConfig { get; set; }
        /// <summary>
        /// SourceAccessConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-sourceaccessconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SourceAccessConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lambda.EventSourceMappingTypes.SourceAccessConfiguration>, IReadOnlyList<Union<Humidifier.Lambda.EventSourceMappingTypes.SourceAccessConfiguration, BaseFunction>>, BaseFunction>? SourceAccessConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MaximumBatchingWindowInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-maximumbatchingwindowinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumBatchingWindowInSeconds { get; set; }
        /// <summary>
        /// BatchSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-batchsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? BatchSize { get; set; }
        /// <summary>
        /// MaximumRetryAttempts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-maximumretryattempts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumRetryAttempts { get; set; }
        /// <summary>
        /// Topics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-topics
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Topics { get; set; }
        /// <summary>
        /// ScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-scalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScalingConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.ScalingConfig, BaseFunction>? ScalingConfig { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Enabled { get; set; }
        /// <summary>
        /// EventSourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-eventsourcearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EventSourceArn { get; set; }
        /// <summary>
        /// SelfManagedKafkaEventSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SelfManagedKafkaEventSourceConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig, BaseFunction>? SelfManagedKafkaEventSourceConfig { get; set; }
        /// <summary>
        /// DocumentDBEventSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-documentdbeventsourceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DocumentDBEventSourceConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.DocumentDBEventSourceConfig, BaseFunction>? DocumentDBEventSourceConfig { get; set; }
        /// <summary>
        /// TumblingWindowInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-tumblingwindowinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TumblingWindowInSeconds { get; set; }
        /// <summary>
        /// BisectBatchOnFunctionError
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-bisectbatchonfunctionerror
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? BisectBatchOnFunctionError { get; set; }
        /// <summary>
        /// MaximumRecordAgeInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-maximumrecordageinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumRecordAgeInSeconds { get; set; }
        /// <summary>
        /// StartingPositionTimestamp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-startingpositiontimestamp
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public Union<double, BaseFunction>? StartingPositionTimestamp { get; set; }
        /// <summary>
        /// LoggingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-loggingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfig
        /// </summary>
        public Union<Humidifier.Lambda.EventSourceMappingTypes.LoggingConfig, BaseFunction>? LoggingConfig { get; set; }
        /// <summary>
        /// Queues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-queues
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Queues { get; set; }
        /// <summary>
        /// FunctionResponseTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-functionresponsetypes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? FunctionResponseTypes { get; set; }
    }

    namespace EventSourceMappingTypes
    {
        public class AmazonManagedKafkaEventSourceConfig : Humidifier.Base.BaseSubResource, IHaveConsumerGroupId, IHaveLambdaEventSourceMappingTypesSchemaRegistryConfigSchemaRegistryConfig
        {
            /// <summary>
            /// ConsumerGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-amazonmanagedkafkaeventsourceconfig.html#cfn-lambda-eventsourcemapping-amazonmanagedkafkaeventsourceconfig-consumergroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConsumerGroupId { get; set; }
            /// <summary>
            /// SchemaRegistryConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-amazonmanagedkafkaeventsourceconfig.html#cfn-lambda-eventsourcemapping-amazonmanagedkafkaeventsourceconfig-schemaregistryconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaRegistryConfig
            /// </summary>
            public Union<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig, BaseFunction>? SchemaRegistryConfig { get; set; }
        }

        public class DestinationConfig : Humidifier.Base.BaseSubResource, IHaveLambdaEventSourceMappingTypesOnFailureOnFailure
        {
            /// <summary>
            /// OnFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-destinationconfig.html#cfn-lambda-eventsourcemapping-destinationconfig-onfailure
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnFailure
            /// </summary>
            public Union<Humidifier.Lambda.EventSourceMappingTypes.OnFailure, BaseFunction>? OnFailure { get; set; }
        }

        public class DocumentDBEventSourceConfig : Humidifier.Base.BaseSubResource, IHaveFullDocument, IHaveCollectionName, IHaveDatabaseName
        {
            /// <summary>
            /// FullDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-documentdbeventsourceconfig.html#cfn-lambda-eventsourcemapping-documentdbeventsourceconfig-fulldocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FullDocument { get; set; }
            /// <summary>
            /// CollectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-documentdbeventsourceconfig.html#cfn-lambda-eventsourcemapping-documentdbeventsourceconfig-collectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollectionName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-documentdbeventsourceconfig.html#cfn-lambda-eventsourcemapping-documentdbeventsourceconfig-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
        }

        public class Endpoints : Humidifier.Base.BaseSubResource, IHaveStringListOfKafkaBootstrapServers
        {
            /// <summary>
            /// KafkaBootstrapServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-endpoints.html#cfn-lambda-eventsourcemapping-endpoints-kafkabootstrapservers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? KafkaBootstrapServers { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHavePattern
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-filter.html#cfn-lambda-eventsourcemapping-filter-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
        }

        public class FilterCriteria : Humidifier.Base.BaseSubResource, IHaveListOfLambdaEventSourceMappingTypesFilterFilters
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-filtercriteria.html#cfn-lambda-eventsourcemapping-filtercriteria-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lambda.EventSourceMappingTypes.Filter>, IReadOnlyList<Union<Humidifier.Lambda.EventSourceMappingTypes.Filter, BaseFunction>>, BaseFunction>? Filters { get; set; }
        }

        public class LoggingConfig : Humidifier.Base.BaseSubResource, IHaveSystemLogLevel
        {
            /// <summary>
            /// SystemLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-loggingconfig.html#cfn-lambda-eventsourcemapping-loggingconfig-systemloglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SystemLogLevel { get; set; }
        }

        public class MetricsConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfMetrics
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-metricsconfig.html#cfn-lambda-eventsourcemapping-metricsconfig-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Metrics { get; set; }
        }

        public class OnFailure : Humidifier.Base.BaseSubResource, IHaveDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-onfailure.html#cfn-lambda-eventsourcemapping-onfailure-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
        }

        public class ProvisionedPollerConfig : Humidifier.Base.BaseSubResource, IHavePollerGroupName, IHaveMinimumPollers_Integer, IHaveMaximumPollers_Integer
        {
            /// <summary>
            /// PollerGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-provisionedpollerconfig.html#cfn-lambda-eventsourcemapping-provisionedpollerconfig-pollergroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PollerGroupName { get; set; }
            /// <summary>
            /// MinimumPollers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-provisionedpollerconfig.html#cfn-lambda-eventsourcemapping-provisionedpollerconfig-minimumpollers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumPollers { get; set; }
            /// <summary>
            /// MaximumPollers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-provisionedpollerconfig.html#cfn-lambda-eventsourcemapping-provisionedpollerconfig-maximumpollers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumPollers { get; set; }
        }

        public class ScalingConfig : Humidifier.Base.BaseSubResource, IHaveMaximumConcurrency_Integer
        {
            /// <summary>
            /// MaximumConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-scalingconfig.html#cfn-lambda-eventsourcemapping-scalingconfig-maximumconcurrency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumConcurrency { get; set; }
        }

        public class SchemaRegistryAccessConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveURI
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-schemaregistryaccessconfig.html#cfn-lambda-eventsourcemapping-schemaregistryaccessconfig-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// URI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-schemaregistryaccessconfig.html#cfn-lambda-eventsourcemapping-schemaregistryaccessconfig-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? URI { get; set; }
        }

        public class SchemaRegistryConfig : Humidifier.Base.BaseSubResource, IHaveListOfLambdaEventSourceMappingTypesSchemaValidationConfigSchemaValidationConfigs, IHaveSchemaRegistryURI, IHaveEventRecordFormat, IHaveListOfLambdaEventSourceMappingTypesSchemaRegistryAccessConfigAccessConfigs
        {
            /// <summary>
            /// SchemaValidationConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-schemaregistryconfig.html#cfn-lambda-eventsourcemapping-schemaregistryconfig-schemavalidationconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SchemaValidationConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lambda.EventSourceMappingTypes.SchemaValidationConfig>, IReadOnlyList<Union<Humidifier.Lambda.EventSourceMappingTypes.SchemaValidationConfig, BaseFunction>>, BaseFunction>? SchemaValidationConfigs { get; set; }
            /// <summary>
            /// SchemaRegistryURI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-schemaregistryconfig.html#cfn-lambda-eventsourcemapping-schemaregistryconfig-schemaregistryuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaRegistryURI { get; set; }
            /// <summary>
            /// EventRecordFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-schemaregistryconfig.html#cfn-lambda-eventsourcemapping-schemaregistryconfig-eventrecordformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventRecordFormat { get; set; }
            /// <summary>
            /// AccessConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-schemaregistryconfig.html#cfn-lambda-eventsourcemapping-schemaregistryconfig-accessconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SchemaRegistryAccessConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryAccessConfig>, IReadOnlyList<Union<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryAccessConfig, BaseFunction>>, BaseFunction>? AccessConfigs { get; set; }
        }

        public class SchemaValidationConfig : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-schemavalidationconfig.html#cfn-lambda-eventsourcemapping-schemavalidationconfig-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
        }

        public class SelfManagedEventSource : Humidifier.Base.BaseSubResource, IHaveLambdaEventSourceMappingTypesEndpointsEndpoints
        {
            /// <summary>
            /// Endpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-selfmanagedeventsource.html#cfn-lambda-eventsourcemapping-selfmanagedeventsource-endpoints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Endpoints
            /// </summary>
            public Union<Humidifier.Lambda.EventSourceMappingTypes.Endpoints, BaseFunction>? Endpoints { get; set; }
        }

        public class SelfManagedKafkaEventSourceConfig : Humidifier.Base.BaseSubResource, IHaveConsumerGroupId, IHaveLambdaEventSourceMappingTypesSchemaRegistryConfigSchemaRegistryConfig, IHaveConsumptionMode
        {
            /// <summary>
            /// ConsumerGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig.html#cfn-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig-consumergroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConsumerGroupId { get; set; }
            /// <summary>
            /// SchemaRegistryConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig.html#cfn-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig-schemaregistryconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaRegistryConfig
            /// </summary>
            public Union<Humidifier.Lambda.EventSourceMappingTypes.SchemaRegistryConfig, BaseFunction>? SchemaRegistryConfig { get; set; }
            /// <summary>
            /// ConsumptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig.html#cfn-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig-consumptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConsumptionMode { get; set; }
        }

        public class SourceAccessConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveURI
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-sourceaccessconfiguration.html#cfn-lambda-eventsourcemapping-sourceaccessconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// URI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-sourceaccessconfiguration.html#cfn-lambda-eventsourcemapping-sourceaccessconfiguration-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? URI { get; set; }
        }
    }
}