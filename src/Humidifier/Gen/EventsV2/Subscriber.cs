namespace Humidifier.EventsV2
{
    using global::System.Collections.Generic;
    using SubscriberTypes;

    public class Subscriber : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveType, IHaveState, IHaveStartingPosition, IHaveEventBusArn
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
        public dynamic StartingPosition { get; set; }
        /// <summary>
        /// Transformer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-transformer
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Transformer
        /// </summary>
        public Humidifier.EventsV2.SubscriberTypes.Transformer Transformer { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// BatchConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-batchconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BatchConfiguration
        /// </summary>
        public Humidifier.EventsV2.SubscriberTypes.BatchConfiguration BatchConfiguration { get; set; }

        /// <summary>
        /// InvokeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-invokeconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: InvokeConfiguration
        /// </summary>
        [Required]
        public Humidifier.EventsV2.SubscriberTypes.InvokeConfiguration InvokeConfiguration { get; set; }
        /// <summary>
        /// FilterConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-filterconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FilterConfiguration
        /// </summary>
        public Humidifier.EventsV2.SubscriberTypes.FilterConfiguration FilterConfiguration { get; set; }
        /// <summary>
        /// OnFailureConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-onfailureconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OnFailureConfiguration
        /// </summary>
        public Humidifier.EventsV2.SubscriberTypes.OnFailureConfiguration OnFailureConfiguration { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfiguration
        /// </summary>
        public Humidifier.EventsV2.SubscriberTypes.LogConfiguration LogConfiguration { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// EventBusArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-eventbusarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EventBusArn { get; set; }
        /// <summary>
        /// PointInTimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-pointintimeconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PointInTimeConfiguration
        /// </summary>
        public Humidifier.EventsV2.SubscriberTypes.PointInTimeConfiguration PointInTimeConfiguration { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic State { get; set; }
        /// <summary>
        /// ResumePosition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-resumeposition
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResumePosition { get; set; }
        /// <summary>
        /// RetryPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-retrypolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetryPolicy
        /// </summary>
        public Humidifier.EventsV2.SubscriberTypes.RetryPolicy RetryPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-subscriber.html#cfn-eventsv2-subscriber-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace SubscriberTypes
    {
        public class BatchConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxBatchSize
        {
            /// <summary>
            /// MaxBatchWindowInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-batchconfiguration.html#cfn-eventsv2-subscriber-batchconfiguration-maxbatchwindowinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxBatchWindowInSeconds { get; set; }
            /// <summary>
            /// MaxBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-batchconfiguration.html#cfn-eventsv2-subscriber-batchconfiguration-maxbatchsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxBatchSize { get; set; }
        }

        public class DeduplicationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeduplicationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-deduplicationconfiguration.html#cfn-eventsv2-subscriber-deduplicationconfiguration-deduplicationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeduplicationType { get; set; }
        }

        public class EventBusV2Parameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SystemMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2parameters.html#cfn-eventsv2-subscriber-eventbusv2parameters-systemmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBusV2SystemMetadata
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.EventBusV2SystemMetadata SystemMetadata { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2parameters.html#cfn-eventsv2-subscriber-eventbusv2parameters-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Metadata { get; set; }
            /// <summary>
            /// DeduplicationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2parameters.html#cfn-eventsv2-subscriber-eventbusv2parameters-deduplicationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeduplicationConfiguration
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.DeduplicationConfiguration DeduplicationConfiguration { get; set; }
        }

        public class EventBusV2SystemMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeduplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2systemmetadata.html#cfn-eventsv2-subscriber-eventbusv2systemmetadata-deduplicationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeduplicationId { get; set; }
            /// <summary>
            /// EventGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-eventbusv2systemmetadata.html#cfn-eventsv2-subscriber-eventbusv2systemmetadata-eventgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventGroupId { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveScope, IHavePattern
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-filter.html#cfn-eventsv2-subscriber-filter-pattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pattern { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-filter.html#cfn-eventsv2-subscriber-filter-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
        }

        public class FilterConfiguration : Humidifier.Base.BaseSubResource, IHaveLanguage
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-filterconfiguration.html#cfn-eventsv2-subscriber-filterconfiguration-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Humidifier.EventsV2.SubscriberTypes.Filter> Filters { get; set; }
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-filterconfiguration.html#cfn-eventsv2-subscriber-filterconfiguration-language
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Language { get; set; }
        }

        public class HttpParameters : Humidifier.Base.BaseSubResource, IHavePathParameterValues
        {
            /// <summary>
            /// PathParameterValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-httpparameters.html#cfn-eventsv2-subscriber-httpparameters-pathparametervalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PathParameterValues { get; set; }
            /// <summary>
            /// HeaderParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-httpparameters.html#cfn-eventsv2-subscriber-httpparameters-headerparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> HeaderParameters { get; set; }
            /// <summary>
            /// QueryStringParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-httpparameters.html#cfn-eventsv2-subscriber-httpparameters-querystringparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> QueryStringParameters { get; set; }
            /// <summary>
            /// InvocationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-httpparameters.html#cfn-eventsv2-subscriber-httpparameters-invocationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationTimeoutSeconds { get; set; }
        }

        public class InvokeConfiguration : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveTargetArn
        {
            /// <summary>
            /// StepFunctionsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-stepfunctionsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StepFunctionsParameters
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.StepFunctionsParameters StepFunctionsParameters { get; set; }
            /// <summary>
            /// SqsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-sqsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqsParameters
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.SqsParameters SqsParameters { get; set; }
            /// <summary>
            /// SnsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-snsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnsParameters
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.SnsParameters SnsParameters { get; set; }
            /// <summary>
            /// HttpParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-httpparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpParameters
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.HttpParameters HttpParameters { get; set; }
            /// <summary>
            /// EventBusV2Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-eventbusv2parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBusV2Parameters
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.EventBusV2Parameters EventBusV2Parameters { get; set; }
            /// <summary>
            /// UniversalTargetParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-universaltargetparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UniversalTargetParameters
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.UniversalTargetParameters UniversalTargetParameters { get; set; }
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-targetarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetArn { get; set; }
            /// <summary>
            /// KinesisParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-kinesisparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisParameters
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.KinesisParameters KinesisParameters { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
            /// <summary>
            /// LambdaParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-invokeconfiguration.html#cfn-eventsv2-subscriber-invokeconfiguration-lambdaparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaParameters
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.LambdaParameters LambdaParameters { get; set; }
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
            public dynamic Expression { get; set; }
        }

        public class KinesisParameters : Humidifier.Base.BaseSubResource, IHavePartitionKey
        {
            /// <summary>
            /// ExplicitHashKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-kinesisparameters.html#cfn-eventsv2-subscriber-kinesisparameters-explicithashkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExplicitHashKey { get; set; }
            /// <summary>
            /// PartitionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-kinesisparameters.html#cfn-eventsv2-subscriber-kinesisparameters-partitionkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PartitionKey { get; set; }
        }

        public class LambdaParameters : Humidifier.Base.BaseSubResource, IHaveQualifier, IHaveInvocationType, IHaveTenantId
        {
            /// <summary>
            /// DurableExecutionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-durableexecutionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DurableExecutionName { get; set; }
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-tenantid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// InvocationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-invocationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationTimeoutSeconds { get; set; }
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-invocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationType { get; set; }
            /// <summary>
            /// Qualifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-lambdaparameters.html#cfn-eventsv2-subscriber-lambdaparameters-qualifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Qualifier { get; set; }
        }

        public class LogConfiguration : Humidifier.Base.BaseSubResource, IHaveLevel
        {
            /// <summary>
            /// IncludePayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-logconfiguration.html#cfn-eventsv2-subscriber-logconfiguration-includepayload
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IncludePayload { get; set; }
            /// <summary>
            /// Level
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-logconfiguration.html#cfn-eventsv2-subscriber-logconfiguration-level
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Level { get; set; }
        }

        public class MessageAttributeValue : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveDataType
        {
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-messageattributevalue.html#cfn-eventsv2-subscriber-messageattributevalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
            /// <summary>
            /// DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-messageattributevalue.html#cfn-eventsv2-subscriber-messageattributevalue-datatype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataType { get; set; }
            /// <summary>
            /// BinaryValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-messageattributevalue.html#cfn-eventsv2-subscriber-messageattributevalue-binaryvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BinaryValue { get; set; }
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
            public dynamic Arn { get; set; }
        }

        public class PointInTimeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-pointintimeconfiguration.html#cfn-eventsv2-subscriber-pointintimeconfiguration-pointtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PointType { get; set; }
            /// <summary>
            /// EndPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-pointintimeconfiguration.html#cfn-eventsv2-subscriber-pointintimeconfiguration-endpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic EndPoint { get; set; }
            /// <summary>
            /// StartingPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-pointintimeconfiguration.html#cfn-eventsv2-subscriber-pointintimeconfiguration-startingpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic StartingPoint { get; set; }
        }

        public class RetryPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxEventAgeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-retrypolicy.html#cfn-eventsv2-subscriber-retrypolicy-maxeventageinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxEventAgeInSeconds { get; set; }
            /// <summary>
            /// MaxRetryAttempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-retrypolicy.html#cfn-eventsv2-subscriber-retrypolicy-maxretryattempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRetryAttempts { get; set; }
            /// <summary>
            /// RetryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-retrypolicy.html#cfn-eventsv2-subscriber-retrypolicy-retrystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RetryStrategy { get; set; }
        }

        public class SnsParameters : Humidifier.Base.BaseSubResource, IHaveSubject, IHaveMessageGroupId
        {
            /// <summary>
            /// MessageAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-messageattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: MessageAttributeValue
            /// </summary>
            public Dictionary<string, Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue> MessageAttributes { get; set; }
            /// <summary>
            /// MessageStructure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-messagestructure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageStructure { get; set; }
            /// <summary>
            /// MessageGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-messagegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageGroupId { get; set; }
            /// <summary>
            /// MessageDeduplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-messagededuplicationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageDeduplicationId { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-snsparameters.html#cfn-eventsv2-subscriber-snsparameters-subject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Subject { get; set; }
        }

        public class SqsParameters : Humidifier.Base.BaseSubResource, IHaveMessageGroupId
        {
            /// <summary>
            /// MessageAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-messageattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: MessageAttributeValue
            /// </summary>
            public Dictionary<string, Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue> MessageAttributes { get; set; }
            /// <summary>
            /// DelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-delayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DelaySeconds { get; set; }
            /// <summary>
            /// MessageGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-messagegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageGroupId { get; set; }
            /// <summary>
            /// MessageDeduplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-messagededuplicationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageDeduplicationId { get; set; }
            /// <summary>
            /// MessageSystemAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-sqsparameters.html#cfn-eventsv2-subscriber-sqsparameters-messagesystemattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: MessageAttributeValue
            /// </summary>
            public Dictionary<string, Humidifier.EventsV2.SubscriberTypes.MessageAttributeValue> MessageSystemAttributes { get; set; }
        }

        public class StepFunctionsParameters : Humidifier.Base.BaseSubResource, IHaveName, IHaveInvocationType
        {
            /// <summary>
            /// TraceHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-stepfunctionsparameters.html#cfn-eventsv2-subscriber-stepfunctionsparameters-traceheader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TraceHeader { get; set; }
            /// <summary>
            /// InvocationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-stepfunctionsparameters.html#cfn-eventsv2-subscriber-stepfunctionsparameters-invocationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationTimeoutSeconds { get; set; }
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-stepfunctionsparameters.html#cfn-eventsv2-subscriber-stepfunctionsparameters-invocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-stepfunctionsparameters.html#cfn-eventsv2-subscriber-stepfunctionsparameters-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Transformer : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-transformer.html#cfn-eventsv2-subscriber-transformer-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// JsonataConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-transformer.html#cfn-eventsv2-subscriber-transformer-jsonataconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonataConfiguration
            /// </summary>
            public Humidifier.EventsV2.SubscriberTypes.JsonataConfiguration JsonataConfiguration { get; set; }
        }

        public class UniversalTargetParameters : Humidifier.Base.BaseSubResource, IHaveInput
        {
            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-universaltargetparameters.html#cfn-eventsv2-subscriber-universaltargetparameters-input
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Input { get; set; }
            /// <summary>
            /// InvocationTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-subscriber-universaltargetparameters.html#cfn-eventsv2-subscriber-universaltargetparameters-invocationtimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationTimeoutSeconds { get; set; }
        }
    }
}