namespace Humidifier.IoTEvents
{
    using System.Collections.Generic;
    using AlarmModelTypes;

    public class AlarmModel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoleArn, IHaveKey, IHaveSeverity, IHaveDescription
    {
        public override string AWSTypeName { get => AWS.IoTEvents.AlarmModel; }

        /// <summary>
        /// AlarmRule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-alarmmodel.html#cfn-iotevents-alarmmodel-alarmrule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AlarmRule
        /// </summary>
        [Required]
        public Humidifier.IoTEvents.AlarmModelTypes.AlarmRule AlarmRule { get; set; }
        public dynamic AlarmModelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AlarmModelDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-alarmmodel.html#cfn-iotevents-alarmmodel-alarmmodeldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AlarmModelDescription { get; set; }

        [Ignore]
        public dynamic Description { get => AlarmModelDescription; set => AlarmModelDescription = value; }
        /// <summary>
        /// Severity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-alarmmodel.html#cfn-iotevents-alarmmodel-severity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Severity { get; set; }
        /// <summary>
        /// AlarmCapabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-alarmmodel.html#cfn-iotevents-alarmmodel-alarmcapabilities
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AlarmCapabilities
        /// </summary>
        public Humidifier.IoTEvents.AlarmModelTypes.AlarmCapabilities AlarmCapabilities { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-alarmmodel.html#cfn-iotevents-alarmmodel-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Key
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-alarmmodel.html#cfn-iotevents-alarmmodel-key
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Key { get; set; }
        /// <summary>
        /// AlarmEventActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-alarmmodel.html#cfn-iotevents-alarmmodel-alarmeventactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AlarmEventActions
        /// </summary>
        public Humidifier.IoTEvents.AlarmModelTypes.AlarmEventActions AlarmEventActions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-alarmmodel.html#cfn-iotevents-alarmmodel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace AlarmModelTypes
    {
        public class AcknowledgeFlow : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-acknowledgeflow.html#cfn-iotevents-alarmmodel-acknowledgeflow-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class AlarmAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DynamoDBv2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-dynamodbv2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamoDBv2
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.DynamoDBv2 DynamoDBv2 { get; set; }
            /// <summary>
            /// IotEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-iotevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotEvents
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.IotEvents IotEvents { get; set; }
            /// <summary>
            /// IotSiteWise
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-iotsitewise
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotSiteWise
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.IotSiteWise IotSiteWise { get; set; }
            /// <summary>
            /// Sqs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-sqs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Sqs
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Sqs Sqs { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-firehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Firehose
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Firehose Firehose { get; set; }
            /// <summary>
            /// DynamoDB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-dynamodb
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamoDB
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.DynamoDB DynamoDB { get; set; }
            /// <summary>
            /// IotTopicPublish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-iottopicpublish
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotTopicPublish
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.IotTopicPublish IotTopicPublish { get; set; }
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-sns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Sns
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Sns Sns { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmaction.html#cfn-iotevents-alarmmodel-alarmaction-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Lambda
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Lambda Lambda { get; set; }
        }

        public class AlarmCapabilities : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AcknowledgeFlow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmcapabilities.html#cfn-iotevents-alarmmodel-alarmcapabilities-acknowledgeflow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcknowledgeFlow
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.AcknowledgeFlow AcknowledgeFlow { get; set; }
            /// <summary>
            /// InitializationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmcapabilities.html#cfn-iotevents-alarmmodel-alarmcapabilities-initializationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InitializationConfiguration
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.InitializationConfiguration InitializationConfiguration { get; set; }
        }

        public class AlarmEventActions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AlarmActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmeventactions.html#cfn-iotevents-alarmmodel-alarmeventactions-alarmactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlarmAction
            /// </summary>
            public List<Humidifier.IoTEvents.AlarmModelTypes.AlarmAction> AlarmActions { get; set; }
        }

        public class AlarmRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SimpleRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-alarmrule.html#cfn-iotevents-alarmmodel-alarmrule-simplerule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SimpleRule
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.SimpleRule SimpleRule { get; set; }
        }

        public class AssetPropertyTimestamp : Humidifier.Base.BaseSubResource, IHaveTimeInSeconds, IHaveOffsetInNanos
        {
            /// <summary>
            /// TimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertytimestamp.html#cfn-iotevents-alarmmodel-assetpropertytimestamp-timeinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeInSeconds { get; set; }
            /// <summary>
            /// OffsetInNanos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertytimestamp.html#cfn-iotevents-alarmmodel-assetpropertytimestamp-offsetinnanos
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OffsetInNanos { get; set; }
        }

        public class AssetPropertyValue : Humidifier.Base.BaseSubResource, IHaveQuality
        {
            /// <summary>
            /// Quality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertyvalue.html#cfn-iotevents-alarmmodel-assetpropertyvalue-quality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Quality { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertyvalue.html#cfn-iotevents-alarmmodel-assetpropertyvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AssetPropertyVariant
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.AssetPropertyVariant Value { get; set; }
            /// <summary>
            /// Timestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertyvalue.html#cfn-iotevents-alarmmodel-assetpropertyvalue-timestamp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetPropertyTimestamp
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.AssetPropertyTimestamp Timestamp { get; set; }
        }

        public class AssetPropertyVariant : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveDoubleValue, IHaveBooleanValue, IHaveIntegerValue
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertyvariant.html#cfn-iotevents-alarmmodel-assetpropertyvariant-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DoubleValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertyvariant.html#cfn-iotevents-alarmmodel-assetpropertyvariant-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BooleanValue { get; set; }
            /// <summary>
            /// IntegerValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertyvariant.html#cfn-iotevents-alarmmodel-assetpropertyvariant-integervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntegerValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-assetpropertyvariant.html#cfn-iotevents-alarmmodel-assetpropertyvariant-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
        }

        public class DynamoDB : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveIoTEventsAlarmModelTypesPayloadPayload, IHaveOperation, IHavePayloadField, IHaveRangeKeyField, IHaveHashKeyField, IHaveRangeKeyValue, IHaveRangeKeyType, IHaveHashKeyType, IHaveHashKeyValue
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// PayloadField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-payloadfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PayloadField { get; set; }
            /// <summary>
            /// RangeKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-rangekeyfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RangeKeyField { get; set; }
            /// <summary>
            /// HashKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-hashkeyfield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HashKeyField { get; set; }
            /// <summary>
            /// RangeKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-rangekeyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RangeKeyValue { get; set; }
            /// <summary>
            /// RangeKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-rangekeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RangeKeyType { get; set; }
            /// <summary>
            /// HashKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-hashkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HashKeyType { get; set; }
            /// <summary>
            /// HashKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-hashkeyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HashKeyValue { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
            /// <summary>
            /// Operation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodb.html#cfn-iotevents-alarmmodel-dynamodb-operation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operation { get; set; }
        }

        public class DynamoDBv2 : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveIoTEventsAlarmModelTypesPayloadPayload
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodbv2.html#cfn-iotevents-alarmmodel-dynamodbv2-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-dynamodbv2.html#cfn-iotevents-alarmmodel-dynamodbv2-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
        }

        public class Firehose : Humidifier.Base.BaseSubResource, IHaveIoTEventsAlarmModelTypesPayloadPayload, IHaveDeliveryStreamName, IHaveSeparator
        {
            /// <summary>
            /// DeliveryStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-firehose.html#cfn-iotevents-alarmmodel-firehose-deliverystreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeliveryStreamName { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-firehose.html#cfn-iotevents-alarmmodel-firehose-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
            /// <summary>
            /// Separator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-firehose.html#cfn-iotevents-alarmmodel-firehose-separator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Separator { get; set; }
        }

        public class InitializationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DisabledOnInitialization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-initializationconfiguration.html#cfn-iotevents-alarmmodel-initializationconfiguration-disabledoninitialization
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisabledOnInitialization { get; set; }
        }

        public class IotEvents : Humidifier.Base.BaseSubResource, IHaveIoTEventsAlarmModelTypesPayloadPayload, IHaveInputName
        {
            /// <summary>
            /// InputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iotevents.html#cfn-iotevents-alarmmodel-iotevents-inputname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputName { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iotevents.html#cfn-iotevents-alarmmodel-iotevents-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
        }

        public class IotSiteWise : Humidifier.Base.BaseSubResource, IHaveAssetId, IHavePropertyId, IHaveEntryId, IHavePropertyAlias
        {
            /// <summary>
            /// EntryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iotsitewise.html#cfn-iotevents-alarmmodel-iotsitewise-entryid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntryId { get; set; }
            /// <summary>
            /// PropertyAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iotsitewise.html#cfn-iotevents-alarmmodel-iotsitewise-propertyalias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyAlias { get; set; }
            /// <summary>
            /// PropertyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iotsitewise.html#cfn-iotevents-alarmmodel-iotsitewise-propertyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetPropertyValue
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.AssetPropertyValue PropertyValue { get; set; }
            /// <summary>
            /// AssetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iotsitewise.html#cfn-iotevents-alarmmodel-iotsitewise-assetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssetId { get; set; }
            /// <summary>
            /// PropertyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iotsitewise.html#cfn-iotevents-alarmmodel-iotsitewise-propertyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyId { get; set; }
        }

        public class IotTopicPublish : Humidifier.Base.BaseSubResource, IHaveIoTEventsAlarmModelTypesPayloadPayload, IHaveMqttTopic
        {
            /// <summary>
            /// MqttTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iottopicpublish.html#cfn-iotevents-alarmmodel-iottopicpublish-mqtttopic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MqttTopic { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-iottopicpublish.html#cfn-iotevents-alarmmodel-iottopicpublish-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
        }

        public class Lambda : Humidifier.Base.BaseSubResource, IHaveIoTEventsAlarmModelTypesPayloadPayload, IHaveFunctionArn
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-lambda.html#cfn-iotevents-alarmmodel-lambda-functionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionArn { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-lambda.html#cfn-iotevents-alarmmodel-lambda-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
        }

        public class Payload : Humidifier.Base.BaseSubResource, IHaveType, IHaveContentExpression
        {
            /// <summary>
            /// ContentExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-payload.html#cfn-iotevents-alarmmodel-payload-contentexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentExpression { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-payload.html#cfn-iotevents-alarmmodel-payload-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class SimpleRule : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveThreshold
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-simplerule.html#cfn-iotevents-alarmmodel-simplerule-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator { get; set; }
            /// <summary>
            /// InputProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-simplerule.html#cfn-iotevents-alarmmodel-simplerule-inputproperty
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputProperty { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-simplerule.html#cfn-iotevents-alarmmodel-simplerule-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Threshold { get; set; }
        }

        public class Sns : Humidifier.Base.BaseSubResource, IHaveTargetArn, IHaveIoTEventsAlarmModelTypesPayloadPayload
        {
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-sns.html#cfn-iotevents-alarmmodel-sns-targetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetArn { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-sns.html#cfn-iotevents-alarmmodel-sns-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
        }

        public class Sqs : Humidifier.Base.BaseSubResource, IHaveIoTEventsAlarmModelTypesPayloadPayload, IHaveUseBase64, IHaveQueueUrl
        {
            /// <summary>
            /// UseBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-sqs.html#cfn-iotevents-alarmmodel-sqs-usebase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UseBase64 { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-sqs.html#cfn-iotevents-alarmmodel-sqs-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Humidifier.IoTEvents.AlarmModelTypes.Payload Payload { get; set; }
            /// <summary>
            /// QueueUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-alarmmodel-sqs.html#cfn-iotevents-alarmmodel-sqs-queueurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueueUrl { get; set; }
        }
    }
}