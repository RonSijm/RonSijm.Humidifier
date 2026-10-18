namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using TopicRuleTypes;

    public class TopicRule : Humidifier.Base.BaseResource, IHaveRuleName, IHaveIoTTopicRuleTypesTopicRulePayloadTopicRulePayload
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.TopicRule; }
        /// <summary>
        /// RuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html#cfn-iot-topicrule-rulename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RuleName { get; set; }

        /// <summary>
        /// TopicRulePayload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicrule.html#cfn-iot-topicrule-topicrulepayload
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TopicRulePayload
        /// </summary>
        [Required]
        public Union<Humidifier.IoT.TopicRuleTypes.TopicRulePayload, BaseFunction>? TopicRulePayload { get; set; }
    }

    namespace TopicRuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveIoTTopicRuleTypesCloudwatchAlarmActionCloudwatchAlarm, IHaveIoTTopicRuleTypesCloudwatchMetricActionCloudwatchMetric, IHaveIoTTopicRuleTypesDynamoDBActionDynamoDB, IHaveIoTTopicRuleTypesDynamoDBv2ActionDynamoDBv2, IHaveIoTTopicRuleTypesElasticsearchActionElasticsearch, IHaveIoTTopicRuleTypesFirehoseActionFirehose, IHaveIoTTopicRuleTypesHttpActionHttp, IHaveIoTTopicRuleTypesIotAnalyticsActionIotAnalytics, IHaveIoTTopicRuleTypesIotEventsActionIotEvents, IHaveIoTTopicRuleTypesIotSiteWiseActionIotSiteWise, IHaveIoTTopicRuleTypesKinesisActionKinesis, IHaveIoTTopicRuleTypesLambdaActionLambda, IHaveIoTTopicRuleTypesRepublishActionRepublish, IHaveIoTTopicRuleTypesS3ActionS3, IHaveIoTTopicRuleTypesSnsActionSns, IHaveIoTTopicRuleTypesSqsActionSqs, IHaveIoTTopicRuleTypesStepFunctionsActionStepFunctions
        {
            /// <summary>
            /// CloudwatchAlarm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-cloudwatchalarm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudwatchAlarmAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.CloudwatchAlarmAction, BaseFunction>? CloudwatchAlarm { get; set; }
            /// <summary>
            /// CloudwatchMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-cloudwatchmetric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudwatchMetricAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.CloudwatchMetricAction, BaseFunction>? CloudwatchMetric { get; set; }
            /// <summary>
            /// DynamoDB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-dynamodb
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamoDBAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.DynamoDBAction, BaseFunction>? DynamoDB { get; set; }
            /// <summary>
            /// DynamoDBv2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-dynamodbv2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamoDBv2Action
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.DynamoDBv2Action, BaseFunction>? DynamoDBv2 { get; set; }
            /// <summary>
            /// Elasticsearch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-elasticsearch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ElasticsearchAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.ElasticsearchAction, BaseFunction>? Elasticsearch { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-firehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FirehoseAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.FirehoseAction, BaseFunction>? Firehose { get; set; }
            /// <summary>
            /// Http
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-http
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.HttpAction, BaseFunction>? Http { get; set; }
            /// <summary>
            /// IotAnalytics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-iotanalytics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotAnalyticsAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.IotAnalyticsAction, BaseFunction>? IotAnalytics { get; set; }
            /// <summary>
            /// IotEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-iotevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotEventsAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.IotEventsAction, BaseFunction>? IotEvents { get; set; }
            /// <summary>
            /// IotSiteWise
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-iotsitewise
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotSiteWiseAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.IotSiteWiseAction, BaseFunction>? IotSiteWise { get; set; }
            /// <summary>
            /// Kinesis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-kinesis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.KinesisAction, BaseFunction>? Kinesis { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.LambdaAction, BaseFunction>? Lambda { get; set; }
            /// <summary>
            /// Republish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-republish
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RepublishAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.RepublishAction, BaseFunction>? Republish { get; set; }
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Action
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.S3Action, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-sns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnsAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.SnsAction, BaseFunction>? Sns { get; set; }
            /// <summary>
            /// Sqs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-sqs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqsAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.SqsAction, BaseFunction>? Sqs { get; set; }
            /// <summary>
            /// StepFunctions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-action.html#cfn-iot-topicrule-action-stepfunctions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StepFunctionsAction
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.StepFunctionsAction, BaseFunction>? StepFunctions { get; set; }
        }

        public class AssetPropertyTimestamp : Humidifier.Base.BaseSubResource, IHaveOffsetInNanos, IHaveTimeInSeconds
        {
            /// <summary>
            /// OffsetInNanos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertytimestamp.html#cfn-iot-topicrule-assetpropertytimestamp-offsetinnanos
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OffsetInNanos { get; set; }
            /// <summary>
            /// TimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertytimestamp.html#cfn-iot-topicrule-assetpropertytimestamp-timeinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeInSeconds { get; set; }
        }

        public class AssetPropertyValue : Humidifier.Base.BaseSubResource, IHaveQuality, IHaveIoTTopicRuleTypesAssetPropertyTimestampTimestamp, IHaveIoTTopicRuleTypesAssetPropertyVariantValue
        {
            /// <summary>
            /// Quality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvalue.html#cfn-iot-topicrule-assetpropertyvalue-quality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Quality { get; set; }
            /// <summary>
            /// Timestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvalue.html#cfn-iot-topicrule-assetpropertyvalue-timestamp
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AssetPropertyTimestamp
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.AssetPropertyTimestamp, BaseFunction>? Timestamp { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvalue.html#cfn-iot-topicrule-assetpropertyvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AssetPropertyVariant
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.AssetPropertyVariant, BaseFunction>? Value { get; set; }
        }

        public class AssetPropertyVariant : Humidifier.Base.BaseSubResource, IHaveBooleanValue, IHaveDoubleValue, IHaveIntegerValue, IHaveStringValue
        {
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvariant.html#cfn-iot-topicrule-assetpropertyvariant-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BooleanValue { get; set; }
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvariant.html#cfn-iot-topicrule-assetpropertyvariant-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DoubleValue { get; set; }
            /// <summary>
            /// IntegerValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvariant.html#cfn-iot-topicrule-assetpropertyvariant-integervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntegerValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-assetpropertyvariant.html#cfn-iot-topicrule-assetpropertyvariant-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
        }

        public class CloudwatchAlarmAction : Humidifier.Base.BaseSubResource, IHaveAlarmName, IHaveRoleArn, IHaveStateReason, IHaveStateValue
        {
            /// <summary>
            /// AlarmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchalarmaction.html#cfn-iot-topicrule-cloudwatchalarmaction-alarmname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlarmName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchalarmaction.html#cfn-iot-topicrule-cloudwatchalarmaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// StateReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchalarmaction.html#cfn-iot-topicrule-cloudwatchalarmaction-statereason
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateReason { get; set; }
            /// <summary>
            /// StateValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchalarmaction.html#cfn-iot-topicrule-cloudwatchalarmaction-statevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateValue { get; set; }
        }

        public class CloudwatchMetricAction : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveMetricNamespace, IHaveMetricTimestamp, IHaveMetricUnit, IHaveMetricValue, IHaveRoleArn
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchmetricaction.html#cfn-iot-topicrule-cloudwatchmetricaction-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// MetricNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchmetricaction.html#cfn-iot-topicrule-cloudwatchmetricaction-metricnamespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricNamespace { get; set; }
            /// <summary>
            /// MetricTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchmetricaction.html#cfn-iot-topicrule-cloudwatchmetricaction-metrictimestamp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricTimestamp { get; set; }
            /// <summary>
            /// MetricUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchmetricaction.html#cfn-iot-topicrule-cloudwatchmetricaction-metricunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricUnit { get; set; }
            /// <summary>
            /// MetricValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchmetricaction.html#cfn-iot-topicrule-cloudwatchmetricaction-metricvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricValue { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-cloudwatchmetricaction.html#cfn-iot-topicrule-cloudwatchmetricaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class DynamoDBAction : Humidifier.Base.BaseSubResource, IHaveHashKeyField, IHaveHashKeyType, IHaveHashKeyValue, IHavePayloadField, IHaveRangeKeyField, IHaveRangeKeyType, IHaveRangeKeyValue, IHaveRoleArn, IHaveTableName
        {
            /// <summary>
            /// HashKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-hashkeyfield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashKeyField { get; set; }
            /// <summary>
            /// HashKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-hashkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashKeyType { get; set; }
            /// <summary>
            /// HashKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-hashkeyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashKeyValue { get; set; }
            /// <summary>
            /// PayloadField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-payloadfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadField { get; set; }
            /// <summary>
            /// RangeKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-rangekeyfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RangeKeyField { get; set; }
            /// <summary>
            /// RangeKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-rangekeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RangeKeyType { get; set; }
            /// <summary>
            /// RangeKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-rangekeyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RangeKeyValue { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbaction.html#cfn-iot-topicrule-dynamodbaction-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
        }

        public class DynamoDBv2Action : Humidifier.Base.BaseSubResource, IHaveIoTTopicRuleTypesPutItemInputPutItem, IHaveRoleArn
        {
            /// <summary>
            /// PutItem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbv2action.html#cfn-iot-topicrule-dynamodbv2action-putitem
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PutItemInput
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.PutItemInput, BaseFunction>? PutItem { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-dynamodbv2action.html#cfn-iot-topicrule-dynamodbv2action-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class ElasticsearchAction : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveId, IHaveIndex, IHaveRoleArn, IHaveType
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Index
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-index
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Index { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-elasticsearchaction.html#cfn-iot-topicrule-elasticsearchaction-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class FirehoseAction : Humidifier.Base.BaseSubResource, IHaveDeliveryStreamName, IHaveRoleArn, IHaveSeparator
        {
            /// <summary>
            /// DeliveryStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-firehoseaction.html#cfn-iot-topicrule-firehoseaction-deliverystreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStreamName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-firehoseaction.html#cfn-iot-topicrule-firehoseaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// Separator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-firehoseaction.html#cfn-iot-topicrule-firehoseaction-separator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Separator { get; set; }
        }

        public class HttpAction : Humidifier.Base.BaseSubResource, IHaveIoTTopicRuleTypesHttpAuthorizationAuth, IHaveConfirmationUrl, IHaveListOfIoTTopicRuleTypesHttpActionHeaderHeaders, IHaveUrl
        {
            /// <summary>
            /// Auth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html#cfn-iot-topicrule-httpaction-auth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HttpAuthorization
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.HttpAuthorization, BaseFunction>? Auth { get; set; }
            /// <summary>
            /// ConfirmationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html#cfn-iot-topicrule-httpaction-confirmationurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfirmationUrl { get; set; }
            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html#cfn-iot-topicrule-httpaction-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HttpActionHeader
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.TopicRuleTypes.HttpActionHeader>, IReadOnlyList<Union<Humidifier.IoT.TopicRuleTypes.HttpActionHeader, BaseFunction>>, BaseFunction>? Headers { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpaction.html#cfn-iot-topicrule-httpaction-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class HttpActionHeader : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValue
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpactionheader.html#cfn-iot-topicrule-httpactionheader-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpactionheader.html#cfn-iot-topicrule-httpactionheader-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class HttpAuthorization : Humidifier.Base.BaseSubResource, IHaveIoTTopicRuleTypesSigV4AuthorizationSigv4
        {
            /// <summary>
            /// Sigv4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-httpauthorization.html#cfn-iot-topicrule-httpauthorization-sigv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SigV4Authorization
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.SigV4Authorization, BaseFunction>? Sigv4 { get; set; }
        }

        public class IotAnalyticsAction : Humidifier.Base.BaseSubResource, IHaveChannelName, IHaveRoleArn
        {
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-iotanalyticsaction.html#cfn-iot-topicrule-iotanalyticsaction-channelname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-iotanalyticsaction.html#cfn-iot-topicrule-iotanalyticsaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class IotEventsAction : Humidifier.Base.BaseSubResource, IHaveInputName, IHaveMessageId, IHaveRoleArn
        {
            /// <summary>
            /// InputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-ioteventsaction.html#cfn-iot-topicrule-ioteventsaction-inputname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputName { get; set; }
            /// <summary>
            /// MessageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-ioteventsaction.html#cfn-iot-topicrule-ioteventsaction-messageid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageId { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-ioteventsaction.html#cfn-iot-topicrule-ioteventsaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class IotSiteWiseAction : Humidifier.Base.BaseSubResource, IHaveListOfIoTTopicRuleTypesPutAssetPropertyValueEntryPutAssetPropertyValueEntries, IHaveRoleArn
        {
            /// <summary>
            /// PutAssetPropertyValueEntries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-iotsitewiseaction.html#cfn-iot-topicrule-iotsitewiseaction-putassetpropertyvalueentries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PutAssetPropertyValueEntry
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.TopicRuleTypes.PutAssetPropertyValueEntry>, IReadOnlyList<Union<Humidifier.IoT.TopicRuleTypes.PutAssetPropertyValueEntry, BaseFunction>>, BaseFunction>? PutAssetPropertyValueEntries { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-iotsitewiseaction.html#cfn-iot-topicrule-iotsitewiseaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class KinesisAction : Humidifier.Base.BaseSubResource, IHavePartitionKey, IHaveRoleArn, IHaveStreamName
        {
            /// <summary>
            /// PartitionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-kinesisaction.html#cfn-iot-topicrule-kinesisaction-partitionkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartitionKey { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-kinesisaction.html#cfn-iot-topicrule-kinesisaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-kinesisaction.html#cfn-iot-topicrule-kinesisaction-streamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamName { get; set; }
        }

        public class LambdaAction : Humidifier.Base.BaseSubResource, IHaveFunctionArn
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-lambdaaction.html#cfn-iot-topicrule-lambdaaction-functionarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionArn { get; set; }
        }

        public class PutAssetPropertyValueEntry : Humidifier.Base.BaseSubResource, IHaveAssetId, IHaveEntryId, IHavePropertyAlias, IHavePropertyId, IHaveListOfIoTTopicRuleTypesAssetPropertyValuePropertyValues
        {
            /// <summary>
            /// AssetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-assetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssetId { get; set; }
            /// <summary>
            /// EntryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-entryid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntryId { get; set; }
            /// <summary>
            /// PropertyAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-propertyalias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyAlias { get; set; }
            /// <summary>
            /// PropertyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-propertyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyId { get; set; }
            /// <summary>
            /// PropertyValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-propertyvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssetPropertyValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.TopicRuleTypes.AssetPropertyValue>, IReadOnlyList<Union<Humidifier.IoT.TopicRuleTypes.AssetPropertyValue, BaseFunction>>, BaseFunction>? PropertyValues { get; set; }
        }

        public class PutItemInput : Humidifier.Base.BaseSubResource, IHaveTableName
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putiteminput.html#cfn-iot-topicrule-putiteminput-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
        }

        public class RepublishAction : Humidifier.Base.BaseSubResource, IHaveQos_Integer, IHaveRoleArn, IHaveTopic
        {
            /// <summary>
            /// Qos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-republishaction.html#cfn-iot-topicrule-republishaction-qos
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Qos { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-republishaction.html#cfn-iot-topicrule-republishaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// Topic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-republishaction.html#cfn-iot-topicrule-republishaction-topic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Topic { get; set; }
        }

        public class S3Action : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveKey, IHaveRoleArn
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-s3action.html#cfn-iot-topicrule-s3action-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-s3action.html#cfn-iot-topicrule-s3action-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-s3action.html#cfn-iot-topicrule-s3action-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SigV4Authorization : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveServiceName, IHaveSigningRegion
        {
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sigv4authorization.html#cfn-iot-topicrule-sigv4authorization-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// ServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sigv4authorization.html#cfn-iot-topicrule-sigv4authorization-servicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceName { get; set; }
            /// <summary>
            /// SigningRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sigv4authorization.html#cfn-iot-topicrule-sigv4authorization-signingregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningRegion { get; set; }
        }

        public class SnsAction : Humidifier.Base.BaseSubResource, IHaveMessageFormat, IHaveRoleArn, IHaveTargetArn
        {
            /// <summary>
            /// MessageFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-snsaction.html#cfn-iot-topicrule-snsaction-messageformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageFormat { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-snsaction.html#cfn-iot-topicrule-snsaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-snsaction.html#cfn-iot-topicrule-snsaction-targetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetArn { get; set; }
        }

        public class SqsAction : Humidifier.Base.BaseSubResource, IHaveQueueUrl, IHaveRoleArn, IHaveUseBase64_Boolean
        {
            /// <summary>
            /// QueueUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sqsaction.html#cfn-iot-topicrule-sqsaction-queueurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueueUrl { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sqsaction.html#cfn-iot-topicrule-sqsaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// UseBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-sqsaction.html#cfn-iot-topicrule-sqsaction-usebase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseBase64 { get; set; }
        }

        public class StepFunctionsAction : Humidifier.Base.BaseSubResource, IHaveExecutionNamePrefix, IHaveRoleArn, IHaveStateMachineName
        {
            /// <summary>
            /// ExecutionNamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-stepfunctionsaction.html#cfn-iot-topicrule-stepfunctionsaction-executionnameprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionNamePrefix { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-stepfunctionsaction.html#cfn-iot-topicrule-stepfunctionsaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// StateMachineName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-stepfunctionsaction.html#cfn-iot-topicrule-stepfunctionsaction-statemachinename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateMachineName { get; set; }
        }

        public class TopicRulePayload : Humidifier.Base.BaseSubResource, IHaveListOfIoTTopicRuleTypesActionActions, IHaveAwsIotSqlVersion, IHaveDescription, IHaveIoTTopicRuleTypesActionErrorAction, IHaveRuleDisabled_Boolean, IHaveSql
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-topicrulepayload.html#cfn-iot-topicrule-topicrulepayload-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Action
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoT.TopicRuleTypes.Action>, IReadOnlyList<Union<Humidifier.IoT.TopicRuleTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// AwsIotSqlVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-topicrulepayload.html#cfn-iot-topicrule-topicrulepayload-awsiotsqlversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsIotSqlVersion { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-topicrulepayload.html#cfn-iot-topicrule-topicrulepayload-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ErrorAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-topicrulepayload.html#cfn-iot-topicrule-topicrulepayload-erroraction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Action
            /// </summary>
            public Union<Humidifier.IoT.TopicRuleTypes.Action, BaseFunction>? ErrorAction { get; set; }
            /// <summary>
            /// RuleDisabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-topicrulepayload.html#cfn-iot-topicrule-topicrulepayload-ruledisabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RuleDisabled { get; set; }
            /// <summary>
            /// Sql
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-topicrulepayload.html#cfn-iot-topicrule-topicrulepayload-sql
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Sql { get; set; }
        }
    }
}