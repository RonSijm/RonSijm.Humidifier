namespace Humidifier.EventsV2
{
    using global::System.Collections.Generic;
    using SubscriberTypes;

    public class Subscriber : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStartingPosition, IHaveEventsV2SubscriberTypesTransformerTransformer, IHaveDescription, IHaveEventsV2SubscriberTypesBatchConfigurationBatchConfiguration, IHaveEventsV2SubscriberTypesInvokeConfigurationInvokeConfiguration, IHaveEventsV2SubscriberTypesFilterConfigurationFilterConfiguration, IHaveEventsV2SubscriberTypesOnFailureConfigurationOnFailureConfiguration, IHaveEventsV2SubscriberTypesLogConfigurationLogConfiguration, IHaveName, IHaveEventBusArn, IHaveEventsV2SubscriberTypesPointInTimeConfigurationPointInTimeConfiguration, IHaveType, IHaveState, IHaveResumePosition, IHaveEventsV2SubscriberTypesRetryPolicyRetryPolicy
    {
        public class Attributes
        {
            public static string BusName =  "BusName" ;
            public static string SubscriberArn =  "SubscriberArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
        }

        public override string AWSTypeName { get => AWS.EventsV2.Subscriber; }
        /// <summary>
        /// StartingPosition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-startingposition
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StartingPosition { get; set; }
        /// <summary>
        /// Transformer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-transformer
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Transformer
        /// </summary>
        public Union<Humidifier.EventsV2.SubscriberTypes.Transformer, BaseFunction>? Transformer { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// BatchConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-batchconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BatchConfiguration
        /// </summary>
        public Union<Humidifier.EventsV2.SubscriberTypes.BatchConfiguration, BaseFunction>? BatchConfiguration { get; set; }

        /// <summary>
        /// InvokeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-invokeconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: InvokeConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.EventsV2.SubscriberTypes.InvokeConfiguration, BaseFunction>? InvokeConfiguration { get; set; }
        /// <summary>
        /// FilterConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-filterconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FilterConfiguration
        /// </summary>
        public Union<Humidifier.EventsV2.SubscriberTypes.FilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
        /// <summary>
        /// OnFailureConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-onfailureconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OnFailureConfiguration
        /// </summary>
        public Union<Humidifier.EventsV2.SubscriberTypes.OnFailureConfiguration, BaseFunction>? OnFailureConfiguration { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Union<Humidifier.EventsV2.SubscriberTypes.LogConfiguration, BaseFunction>? LogConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// EventBusArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-eventbusarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EventBusArn { get; set; }
        /// <summary>
        /// PointInTimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-pointintimeconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PointInTimeConfiguration
        /// </summary>
        public Union<Humidifier.EventsV2.SubscriberTypes.PointInTimeConfiguration, BaseFunction>? PointInTimeConfiguration { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }
        /// <summary>
        /// ResumePosition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-resumeposition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResumePosition { get; set; }
        /// <summary>
        /// RetryPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-retrypolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetryPolicy
        /// </summary>
        public Union<Humidifier.EventsV2.SubscriberTypes.RetryPolicy, BaseFunction>? RetryPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SubscriberTypes
    {
        public class BatchConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxBatchWindowInSeconds_Integer, IHaveMaxBatchSize_Integer
        {
            /// <summary>
            /// MaxBatchWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-batchconfiguration.html#cfn-eventsv2-subscriber-batchconfiguration-maxbatchwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxBatchWindowInSeconds { get; set; }
            /// <summary>
            /// MaxBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-batchconfiguration.html#cfn-eventsv2-subscriber-batchconfiguration-maxbatchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxBatchSize { get; set; }
        }

        public class DeduplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveDeduplicationType
        {
            /// <summary>
            /// DeduplicationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-deduplicationconfiguration.html#cfn-eventsv2-subscriber-deduplicationconfiguration-deduplicationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeduplicationType { get; set; }
        }

        public class EventBusV2Parameters : Humidifier.Base.BaseSubResource, IHaveEventsV2SubscriberTypesEventBusV2SystemMetadataSystemMetadata, IHaveStringDictionaryOfMetadata, IHaveEventsV2SubscriberTypesDeduplicationConfigurationDeduplicationConfiguration
        {
            /// <summary>
            /// SystemMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2parameters.html#cfn-eventsv2-subscriber-eventbusv2parameters-systemmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBusV2SystemMetadata
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.EventBusV2SystemMetadata, BaseFunction>? SystemMetadata { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2parameters.html#cfn-eventsv2-subscriber-eventbusv2parameters-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// DeduplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2parameters.html#cfn-eventsv2-subscriber-eventbusv2parameters-deduplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeduplicationConfiguration
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.DeduplicationConfiguration, BaseFunction>? DeduplicationConfiguration { get; set; }
        }

        public class EventBusV2SystemMetadata : Humidifier.Base.BaseSubResource, IHaveDeduplicationId, IHaveEventGroupId
        {
            /// <summary>
            /// DeduplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2systemmetadata.html#cfn-eventsv2-subscriber-eventbusv2systemmetadata-deduplicationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeduplicationId { get; set; }
            /// <summary>
            /// EventGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2systemmetadata.html#cfn-eventsv2-subscriber-eventbusv2systemmetadata-eventgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventGroupId { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHavePattern, IHaveScope
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-filter.html#cfn-eventsv2-subscriber-filter-pattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-filter.html#cfn-eventsv2-subscriber-filter-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
        }

        public class FilterConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfEventsV2SubscriberTypesFilterFilters, IHaveLanguage
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-filterconfiguration.html#cfn-eventsv2-subscriber-filterconfiguration-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EventsV2.SubscriberTypes.Filter>, IReadOnlyList<Union<Humidifier.EventsV2.SubscriberTypes.Filter, BaseFunction>>, BaseFunction>? Filters { get; set; }
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-filterconfiguration.html#cfn-eventsv2-subscriber-filterconfiguration-language
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Language { get; set; }
        }

        public class HttpParameters : Humidifier.Base.BaseSubResource, IHaveStringListOfPathParameterValues, IHaveStringDictionaryOfHeaderParameters, IHaveStringDictionaryOfQueryStringParameters, IHaveInvocationTimeoutSeconds
        {
            /// <summary>
            /// PathParameterValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-httpparameters.html#cfn-eventsv2-subscriber-httpparameters-pathparametervalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PathParameterValues { get; set; }
            /// <summary>
            /// HeaderParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-httpparameters.html#cfn-eventsv2-subscriber-httpparameters-headerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? HeaderParameters { get; set; }
            /// <summary>
            /// QueryStringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-httpparameters.html#cfn-eventsv2-subscriber-httpparameters-querystringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? QueryStringParameters { get; set; }
            /// <summary>
            /// InvocationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-httpparameters.html#cfn-eventsv2-subscriber-httpparameters-invocationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationTimeoutSeconds { get; set; }
        }

        public class InvokeConfiguration : Humidifier.Base.BaseSubResource, IHaveEventsV2SubscriberTypesStepFunctionsParametersStepFunctionsParameters, IHaveEventsV2SubscriberTypesSqsParametersSqsParameters, IHaveEventsV2SubscriberTypesSnsParametersSnsParameters, IHaveEventsV2SubscriberTypesHttpParametersHttpParameters, IHaveEventsV2SubscriberTypesEventBusV2ParametersEventBusV2Parameters, IHaveEventsV2SubscriberTypesUniversalTargetParametersUniversalTargetParameters, IHaveTargetArn, IHaveEventsV2SubscriberTypesKinesisParametersKinesisParameters, IHaveRoleArn, IHaveEventsV2SubscriberTypesLambdaParametersLambdaParameters
        {
            /// <summary>
            /// StepFunctionsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-stepfunctionsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StepFunctionsParameters
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.StepFunctionsParameters, BaseFunction>? StepFunctionsParameters { get; set; }
            /// <summary>
            /// SqsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-sqsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqsParameters
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.SqsParameters, BaseFunction>? SqsParameters { get; set; }
            /// <summary>
            /// SnsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-snsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnsParameters
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.SnsParameters, BaseFunction>? SnsParameters { get; set; }
            /// <summary>
            /// HttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-httpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpParameters
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.HttpParameters, BaseFunction>? HttpParameters { get; set; }
            /// <summary>
            /// EventBusV2Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-eventbusv2parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBusV2Parameters
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.EventBusV2Parameters, BaseFunction>? EventBusV2Parameters { get; set; }
            /// <summary>
            /// UniversalTargetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-universaltargetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UniversalTargetParameters
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.UniversalTargetParameters, BaseFunction>? UniversalTargetParameters { get; set; }
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-targetarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetArn { get; set; }
            /// <summary>
            /// KinesisParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-kinesisparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisParameters
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.KinesisParameters, BaseFunction>? KinesisParameters { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// LambdaParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-lambdaparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaParameters
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.LambdaParameters, BaseFunction>? LambdaParameters { get; set; }
        }

        public class JsonataConfiguration : Humidifier.Base.BaseSubResource, IHaveExpression
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-jsonataconfiguration.html#cfn-eventsv2-subscriber-jsonataconfiguration-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class KinesisParameters : Humidifier.Base.BaseSubResource, IHaveExplicitHashKey, IHavePartitionKey
        {
            /// <summary>
            /// ExplicitHashKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-kinesisparameters.html#cfn-eventsv2-subscriber-kinesisparameters-explicithashkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExplicitHashKey { get; set; }
            /// <summary>
            /// PartitionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-kinesisparameters.html#cfn-eventsv2-subscriber-kinesisparameters-partitionkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartitionKey { get; set; }
        }

        public class LambdaParameters : Humidifier.Base.BaseSubResource, IHaveDurableExecutionName, IHaveTenantId, IHaveInvocationTimeoutSeconds, IHaveInvocationType, IHaveQualifier
        {
            /// <summary>
            /// DurableExecutionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-durableexecutionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DurableExecutionName { get; set; }
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-tenantid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// InvocationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-invocationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationTimeoutSeconds { get; set; }
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-invocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationType { get; set; }
            /// <summary>
            /// Qualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-qualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Qualifier { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveIncludePayload, IHaveLevel
        {
            /// <summary>
            /// IncludePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-logconfiguration.html#cfn-eventsv2-subscriber-logconfiguration-includepayload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludePayload { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-logconfiguration.html#cfn-eventsv2-subscriber-logconfiguration-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Level { get; set; }
        }

        public class MessageAttributeValue : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveDataType, IHaveBinaryValue
        {
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-messageattributevalue.html#cfn-eventsv2-subscriber-messageattributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-messageattributevalue.html#cfn-eventsv2-subscriber-messageattributevalue-datatype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataType { get; set; }
            /// <summary>
            /// BinaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-messageattributevalue.html#cfn-eventsv2-subscriber-messageattributevalue-binaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BinaryValue { get; set; }
        }

        public class OnFailureConfiguration : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-onfailureconfiguration.html#cfn-eventsv2-subscriber-onfailureconfiguration-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class PointInTimeConfiguration : Humidifier.Base.BaseSubResource, IHavePointType, IHaveEndPoint_Long, IHaveStartingPoint_Long
        {
            /// <summary>
            /// PointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-pointintimeconfiguration.html#cfn-eventsv2-subscriber-pointintimeconfiguration-pointtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PointType { get; set; }
            /// <summary>
            /// EndPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-pointintimeconfiguration.html#cfn-eventsv2-subscriber-pointintimeconfiguration-endpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? EndPoint { get; set; }
            /// <summary>
            /// StartingPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-pointintimeconfiguration.html#cfn-eventsv2-subscriber-pointintimeconfiguration-startingpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? StartingPoint { get; set; }
        }

        public class RetryPolicy : Humidifier.Base.BaseSubResource, IHaveMaxEventAgeInSeconds_Integer, IHaveMaxRetryAttempts_Integer, IHaveRetryStrategy
        {
            /// <summary>
            /// MaxEventAgeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-retrypolicy.html#cfn-eventsv2-subscriber-retrypolicy-maxeventageinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxEventAgeInSeconds { get; set; }
            /// <summary>
            /// MaxRetryAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-retrypolicy.html#cfn-eventsv2-subscriber-retrypolicy-maxretryattempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRetryAttempts { get; set; }
            /// <summary>
            /// RetryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-retrypolicy.html#cfn-eventsv2-subscriber-retrypolicy-retrystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RetryStrategy { get; set; }
        }

        public class SnsParameters : Humidifier.Base.BaseSubResource, IHaveMapOfEventsV2SubscriberTypesMessageAttributeValueMessageAttributes, IHaveMessageStructure, IHaveMessageGroupId, IHaveMessageDeduplicationId, IHaveSubject
        {
            /// <summary>
            /// MessageAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-messageattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: MessageAttributeValue
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue>, IReadOnlyDictionary<string, Union<Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue, BaseFunction>>, BaseFunction>? MessageAttributes { get; set; }
            /// <summary>
            /// MessageStructure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-messagestructure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageStructure { get; set; }
            /// <summary>
            /// MessageGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-messagegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageGroupId { get; set; }
            /// <summary>
            /// MessageDeduplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-messagededuplicationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageDeduplicationId { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-subject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subject { get; set; }
        }

        public class SqsParameters : Humidifier.Base.BaseSubResource, IHaveMapOfEventsV2SubscriberTypesMessageAttributeValueMessageAttributes, IHaveDelaySeconds, IHaveMessageGroupId, IHaveMessageDeduplicationId, IHaveMapOfEventsV2SubscriberTypesMessageAttributeValueMessageSystemAttributes
        {
            /// <summary>
            /// MessageAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-messageattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: MessageAttributeValue
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue>, IReadOnlyDictionary<string, Union<Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue, BaseFunction>>, BaseFunction>? MessageAttributes { get; set; }
            /// <summary>
            /// DelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-delayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DelaySeconds { get; set; }
            /// <summary>
            /// MessageGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-messagegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageGroupId { get; set; }
            /// <summary>
            /// MessageDeduplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-messagededuplicationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageDeduplicationId { get; set; }
            /// <summary>
            /// MessageSystemAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-messagesystemattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: MessageAttributeValue
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue>, IReadOnlyDictionary<string, Union<Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue, BaseFunction>>, BaseFunction>? MessageSystemAttributes { get; set; }
        }

        public class StepFunctionsParameters : Humidifier.Base.BaseSubResource, IHaveTraceHeader, IHaveInvocationTimeoutSeconds, IHaveInvocationType, IHaveName
        {
            /// <summary>
            /// TraceHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-stepfunctionsparameters.html#cfn-eventsv2-subscriber-stepfunctionsparameters-traceheader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TraceHeader { get; set; }
            /// <summary>
            /// InvocationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-stepfunctionsparameters.html#cfn-eventsv2-subscriber-stepfunctionsparameters-invocationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationTimeoutSeconds { get; set; }
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-stepfunctionsparameters.html#cfn-eventsv2-subscriber-stepfunctionsparameters-invocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-stepfunctionsparameters.html#cfn-eventsv2-subscriber-stepfunctionsparameters-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Transformer : Humidifier.Base.BaseSubResource, IHaveType, IHaveEventsV2SubscriberTypesJsonataConfigurationJsonataConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-transformer.html#cfn-eventsv2-subscriber-transformer-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// JsonataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-transformer.html#cfn-eventsv2-subscriber-transformer-jsonataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonataConfiguration
            /// </summary>
            public Union<Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration, BaseFunction>? JsonataConfiguration { get; set; }
        }

        public class UniversalTargetParameters : Humidifier.Base.BaseSubResource, IHaveInput, IHaveInvocationTimeoutSeconds
        {
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-universaltargetparameters.html#cfn-eventsv2-subscriber-universaltargetparameters-input
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Input { get; set; }
            /// <summary>
            /// InvocationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-universaltargetparameters.html#cfn-eventsv2-subscriber-universaltargetparameters-invocationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationTimeoutSeconds { get; set; }
        }
    }
}