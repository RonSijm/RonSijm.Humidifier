namespace Humidifier.Lambda
{
    using System.Collections.Generic;
    using EventSourceMappingTypes;

    public class EventSourceMapping : Humidifier.Base.BaseResource, IHaveTags, IHaveEnabled, IHaveKmsKeyArn, IHaveBatchSize, IHaveMaximumBatchingWindowInSeconds, IHaveFunctionName, IHaveMaximumRetryAttempts, IHaveStartingPosition, IHaveParallelizationFactor, IHaveMaximumRecordAgeInSeconds, IHaveTopics, IHaveStartingPositionTimestamp, IHaveQueues
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
        public dynamic StartingPosition { get; set; }
        /// <summary>
        /// SelfManagedEventSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-selfmanagedeventsource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SelfManagedEventSource
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.SelfManagedEventSource SelfManagedEventSource { get; set; }
        /// <summary>
        /// ParallelizationFactor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-parallelizationfactor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ParallelizationFactor { get; set; }
        /// <summary>
        /// FilterCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-filtercriteria
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FilterCriteria
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.FilterCriteria FilterCriteria { get; set; }
        /// <summary>
        /// ProvisionedPollerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-provisionedpollerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProvisionedPollerConfig
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.ProvisionedPollerConfig ProvisionedPollerConfig { get; set; }
        /// <summary>
        /// MetricsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-metricsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetricsConfig
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.MetricsConfig MetricsConfig { get; set; }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-functionname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FunctionName { get; set; }
        /// <summary>
        /// DestinationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-destinationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DestinationConfig
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.DestinationConfig DestinationConfig { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }
        /// <summary>
        /// AmazonManagedKafkaEventSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-amazonmanagedkafkaeventsourceconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AmazonManagedKafkaEventSourceConfig
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.AmazonManagedKafkaEventSourceConfig AmazonManagedKafkaEventSourceConfig { get; set; }
        /// <summary>
        /// SourceAccessConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-sourceaccessconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SourceAccessConfiguration
        /// </summary>
        public List<Humidifier.Lambda.EventSourceMappingTypes.SourceAccessConfiguration> SourceAccessConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// MaximumBatchingWindowInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-maximumbatchingwindowinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaximumBatchingWindowInSeconds { get; set; }
        /// <summary>
        /// BatchSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-batchsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic BatchSize { get; set; }
        /// <summary>
        /// MaximumRetryAttempts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-maximumretryattempts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaximumRetryAttempts { get; set; }
        /// <summary>
        /// Topics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-topics
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Topics { get; set; }
        /// <summary>
        /// ScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-scalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScalingConfig
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.ScalingConfig ScalingConfig { get; set; }
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Enabled { get; set; }
        /// <summary>
        /// EventSourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-eventsourcearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EventSourceArn { get; set; }
        /// <summary>
        /// SelfManagedKafkaEventSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SelfManagedKafkaEventSourceConfig
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.SelfManagedKafkaEventSourceConfig SelfManagedKafkaEventSourceConfig { get; set; }
        /// <summary>
        /// DocumentDBEventSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-documentdbeventsourceconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DocumentDBEventSourceConfig
        /// </summary>
        public Humidifier.Lambda.EventSourceMappingTypes.DocumentDBEventSourceConfig DocumentDBEventSourceConfig { get; set; }
        /// <summary>
        /// TumblingWindowInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-tumblingwindowinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TumblingWindowInSeconds { get; set; }
        /// <summary>
        /// BisectBatchOnFunctionError
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-bisectbatchonfunctionerror
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic BisectBatchOnFunctionError { get; set; }
        /// <summary>
        /// MaximumRecordAgeInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-maximumrecordageinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaximumRecordAgeInSeconds { get; set; }
        /// <summary>
        /// StartingPositionTimestamp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-startingpositiontimestamp
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic StartingPositionTimestamp { get; set; }
        /// <summary>
        /// Queues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-queues
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Queues { get; set; }
        /// <summary>
        /// FunctionResponseTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-functionresponsetypes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic FunctionResponseTypes { get; set; }
    }

    namespace EventSourceMappingTypes
    {
        public class AmazonManagedKafkaEventSourceConfig : Humidifier.Base.BaseSubResource, IHaveConsumerGroupId
        {
            /// <summary>
            /// ConsumerGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-amazonmanagedkafkaeventsourceconfig.html#cfn-lambda-eventsourcemapping-amazonmanagedkafkaeventsourceconfig-consumergroupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConsumerGroupId { get; set; }
        }

        public class DestinationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OnFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-destinationconfig.html#cfn-lambda-eventsourcemapping-destinationconfig-onfailure
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnFailure
            /// </summary>
            public Humidifier.Lambda.EventSourceMappingTypes.OnFailure OnFailure { get; set; }
        }

        public class DocumentDBEventSourceConfig : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveCollectionName
        {
            /// <summary>
            /// FullDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-documentdbeventsourceconfig.html#cfn-lambda-eventsourcemapping-documentdbeventsourceconfig-fulldocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FullDocument { get; set; }
            /// <summary>
            /// CollectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-documentdbeventsourceconfig.html#cfn-lambda-eventsourcemapping-documentdbeventsourceconfig-collectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollectionName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-documentdbeventsourceconfig.html#cfn-lambda-eventsourcemapping-documentdbeventsourceconfig-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
        }

        public class Endpoints : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KafkaBootstrapServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-endpoints.html#cfn-lambda-eventsourcemapping-endpoints-kafkabootstrapservers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic KafkaBootstrapServers { get; set; }
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
            public dynamic Pattern { get; set; }
        }

        public class FilterCriteria : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-filtercriteria.html#cfn-lambda-eventsourcemapping-filtercriteria-filters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Humidifier.Lambda.EventSourceMappingTypes.Filter> Filters { get; set; }
        }

        public class MetricsConfig : Humidifier.Base.BaseSubResource, IHaveMetrics
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-metricsconfig.html#cfn-lambda-eventsourcemapping-metricsconfig-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Metrics { get; set; }
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
            public dynamic Destination { get; set; }
        }

        public class ProvisionedPollerConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MinimumPollers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-provisionedpollerconfig.html#cfn-lambda-eventsourcemapping-provisionedpollerconfig-minimumpollers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinimumPollers { get; set; }
            /// <summary>
            /// MaximumPollers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-provisionedpollerconfig.html#cfn-lambda-eventsourcemapping-provisionedpollerconfig-maximumpollers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumPollers { get; set; }
        }

        public class ScalingConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumConcurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-scalingconfig.html#cfn-lambda-eventsourcemapping-scalingconfig-maximumconcurrency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumConcurrency { get; set; }
        }

        public class SelfManagedEventSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Endpoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-selfmanagedeventsource.html#cfn-lambda-eventsourcemapping-selfmanagedeventsource-endpoints
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Endpoints
            /// </summary>
            public Humidifier.Lambda.EventSourceMappingTypes.Endpoints Endpoints { get; set; }
        }

        public class SelfManagedKafkaEventSourceConfig : Humidifier.Base.BaseSubResource, IHaveConsumerGroupId
        {
            /// <summary>
            /// ConsumerGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig.html#cfn-lambda-eventsourcemapping-selfmanagedkafkaeventsourceconfig-consumergroupid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConsumerGroupId { get; set; }
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
            public dynamic Type { get; set; }
            /// <summary>
            /// URI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-eventsourcemapping-sourceaccessconfiguration.html#cfn-lambda-eventsourcemapping-sourceaccessconfiguration-uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic URI { get; set; }
        }
    }
}