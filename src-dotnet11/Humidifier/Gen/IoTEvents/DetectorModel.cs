namespace Humidifier.IoTEvents
{
    using global::System.Collections.Generic;
    using DetectorModelTypes;

    public class DetectorModel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIoTEventsDetectorModelTypesDetectorModelDefinitionDetectorModelDefinition, IHaveEvaluationMethod, IHaveDetectorModelName, IHaveDetectorModelDescription, IHaveKey, IHaveRoleArn, IHaveDescription
    {
        public override string AWSTypeName { get => AWS.IoTEvents.DetectorModel; }

        /// <summary>
        /// DetectorModelDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-detectormodel.html#cfn-iotevents-detectormodel-detectormodeldefinition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DetectorModelDefinition
        /// </summary>
        [Required]
        public Union<Humidifier.IoTEvents.DetectorModelTypes.DetectorModelDefinition, BaseFunction>? DetectorModelDefinition { get; set; }
        /// <summary>
        /// EvaluationMethod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-detectormodel.html#cfn-iotevents-detectormodel-evaluationmethod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EvaluationMethod { get; set; }
        public Union<string, BaseFunction>? DetectorModelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DetectorModelDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-detectormodel.html#cfn-iotevents-detectormodel-detectormodeldescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DetectorModelDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => DetectorModelDescription; set => DetectorModelDescription = value; }
        /// <summary>
        /// Key
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-detectormodel.html#cfn-iotevents-detectormodel-key
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Key { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-detectormodel.html#cfn-iotevents-detectormodel-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-detectormodel.html#cfn-iotevents-detectormodel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DetectorModelTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveIoTEventsDetectorModelTypesIotEventsIotEvents, IHaveIoTEventsDetectorModelTypesFirehoseFirehose, IHaveIoTEventsDetectorModelTypesDynamoDBDynamoDB, IHaveIoTEventsDetectorModelTypesIotTopicPublishIotTopicPublish, IHaveIoTEventsDetectorModelTypesDynamoDBv2DynamoDBv2, IHaveIoTEventsDetectorModelTypesIotSiteWiseIotSiteWise, IHaveIoTEventsDetectorModelTypesResetTimerResetTimer, IHaveIoTEventsDetectorModelTypesSqsSqs, IHaveIoTEventsDetectorModelTypesSetTimerSetTimer, IHaveIoTEventsDetectorModelTypesSnsSns, IHaveIoTEventsDetectorModelTypesClearTimerClearTimer, IHaveIoTEventsDetectorModelTypesLambdaLambda, IHaveIoTEventsDetectorModelTypesSetVariableSetVariable
        {
            /// <summary>
            /// IotEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-iotevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotEvents
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.IotEvents, BaseFunction>? IotEvents { get; set; }
            /// <summary>
            /// Firehose
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-firehose
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Firehose
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Firehose, BaseFunction>? Firehose { get; set; }
            /// <summary>
            /// DynamoDB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-dynamodb
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamoDB
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.DynamoDB, BaseFunction>? DynamoDB { get; set; }
            /// <summary>
            /// IotTopicPublish
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-iottopicpublish
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotTopicPublish
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.IotTopicPublish, BaseFunction>? IotTopicPublish { get; set; }
            /// <summary>
            /// DynamoDBv2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-dynamodbv2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynamoDBv2
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.DynamoDBv2, BaseFunction>? DynamoDBv2 { get; set; }
            /// <summary>
            /// IotSiteWise
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-iotsitewise
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotSiteWise
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.IotSiteWise, BaseFunction>? IotSiteWise { get; set; }
            /// <summary>
            /// ResetTimer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-resettimer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResetTimer
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.ResetTimer, BaseFunction>? ResetTimer { get; set; }
            /// <summary>
            /// Sqs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-sqs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Sqs
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Sqs, BaseFunction>? Sqs { get; set; }
            /// <summary>
            /// SetTimer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-settimer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetTimer
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.SetTimer, BaseFunction>? SetTimer { get; set; }
            /// <summary>
            /// Sns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-sns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Sns
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Sns, BaseFunction>? Sns { get; set; }
            /// <summary>
            /// ClearTimer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-cleartimer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClearTimer
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.ClearTimer, BaseFunction>? ClearTimer { get; set; }
            /// <summary>
            /// Lambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-lambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Lambda
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Lambda, BaseFunction>? Lambda { get; set; }
            /// <summary>
            /// SetVariable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-setvariable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetVariable
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.SetVariable, BaseFunction>? SetVariable { get; set; }
        }

        public class AssetPropertyTimestamp : Humidifier.Base.BaseSubResource, IHaveTimeInSeconds, IHaveOffsetInNanos
        {
            /// <summary>
            /// TimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertytimestamp.html#cfn-iotevents-detectormodel-assetpropertytimestamp-timeinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeInSeconds { get; set; }
            /// <summary>
            /// OffsetInNanos
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertytimestamp.html#cfn-iotevents-detectormodel-assetpropertytimestamp-offsetinnanos
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OffsetInNanos { get; set; }
        }

        public class AssetPropertyValue : Humidifier.Base.BaseSubResource, IHaveQuality, IHaveIoTEventsDetectorModelTypesAssetPropertyVariantValue, IHaveIoTEventsDetectorModelTypesAssetPropertyTimestampTimestamp
        {
            /// <summary>
            /// Quality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvalue.html#cfn-iotevents-detectormodel-assetpropertyvalue-quality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Quality { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvalue.html#cfn-iotevents-detectormodel-assetpropertyvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AssetPropertyVariant
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.AssetPropertyVariant, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Timestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvalue.html#cfn-iotevents-detectormodel-assetpropertyvalue-timestamp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AssetPropertyTimestamp
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.AssetPropertyTimestamp, BaseFunction>? Timestamp { get; set; }
        }

        public class AssetPropertyVariant : Humidifier.Base.BaseSubResource, IHaveDoubleValue, IHaveBooleanValue, IHaveIntegerValue, IHaveStringValue
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvariant.html#cfn-iotevents-detectormodel-assetpropertyvariant-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DoubleValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvariant.html#cfn-iotevents-detectormodel-assetpropertyvariant-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BooleanValue { get; set; }
            /// <summary>
            /// IntegerValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvariant.html#cfn-iotevents-detectormodel-assetpropertyvariant-integervalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntegerValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-assetpropertyvariant.html#cfn-iotevents-detectormodel-assetpropertyvariant-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
        }

        public class ClearTimer : Humidifier.Base.BaseSubResource, IHaveTimerName
        {
            /// <summary>
            /// TimerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-cleartimer.html#cfn-iotevents-detectormodel-cleartimer-timername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimerName { get; set; }
        }

        public class DetectorModelDefinition : Humidifier.Base.BaseSubResource, IHaveListOfIoTEventsDetectorModelTypesStateStates, IHaveInitialStateName
        {
            /// <summary>
            /// States
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-detectormodeldefinition.html#cfn-iotevents-detectormodel-detectormodeldefinition-states
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: State
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTEvents.DetectorModelTypes.State>, IReadOnlyList<Union<Humidifier.IoTEvents.DetectorModelTypes.State, BaseFunction>>, BaseFunction>? States { get; set; }
            /// <summary>
            /// InitialStateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-detectormodeldefinition.html#cfn-iotevents-detectormodel-detectormodeldefinition-initialstatename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InitialStateName { get; set; }
        }

        public class DynamoDB : Humidifier.Base.BaseSubResource, IHaveTableName, IHavePayloadField, IHaveRangeKeyField, IHaveHashKeyField, IHaveRangeKeyValue, IHaveRangeKeyType, IHaveHashKeyType, IHaveHashKeyValue, IHaveIoTEventsDetectorModelTypesPayloadPayload, IHaveOperation
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// PayloadField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-payloadfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadField { get; set; }
            /// <summary>
            /// RangeKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-rangekeyfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RangeKeyField { get; set; }
            /// <summary>
            /// HashKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-hashkeyfield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashKeyField { get; set; }
            /// <summary>
            /// RangeKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-rangekeyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RangeKeyValue { get; set; }
            /// <summary>
            /// RangeKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-rangekeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RangeKeyType { get; set; }
            /// <summary>
            /// HashKeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-hashkeytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashKeyType { get; set; }
            /// <summary>
            /// HashKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-hashkeyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HashKeyValue { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Payload, BaseFunction>? Payload { get; set; }
            /// <summary>
            /// Operation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-operation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operation { get; set; }
        }

        public class DynamoDBv2 : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveIoTEventsDetectorModelTypesPayloadPayload
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodbv2.html#cfn-iotevents-detectormodel-dynamodbv2-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodbv2.html#cfn-iotevents-detectormodel-dynamodbv2-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Payload, BaseFunction>? Payload { get; set; }
        }

        public class Event : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveListOfIoTEventsDetectorModelTypesActionActions, IHaveEventName
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-event.html#cfn-iotevents-detectormodel-event-condition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-event.html#cfn-iotevents-detectormodel-event-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Action
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTEvents.DetectorModelTypes.Action>, IReadOnlyList<Union<Humidifier.IoTEvents.DetectorModelTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// EventName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-event.html#cfn-iotevents-detectormodel-event-eventname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventName { get; set; }
        }

        public class Firehose : Humidifier.Base.BaseSubResource, IHaveDeliveryStreamName, IHaveIoTEventsDetectorModelTypesPayloadPayload, IHaveSeparator
        {
            /// <summary>
            /// DeliveryStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-firehose.html#cfn-iotevents-detectormodel-firehose-deliverystreamname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStreamName { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-firehose.html#cfn-iotevents-detectormodel-firehose-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Payload, BaseFunction>? Payload { get; set; }
            /// <summary>
            /// Separator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-firehose.html#cfn-iotevents-detectormodel-firehose-separator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Separator { get; set; }
        }

        public class IotEvents : Humidifier.Base.BaseSubResource, IHaveInputName, IHaveIoTEventsDetectorModelTypesPayloadPayload
        {
            /// <summary>
            /// InputName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotevents.html#cfn-iotevents-detectormodel-iotevents-inputname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputName { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotevents.html#cfn-iotevents-detectormodel-iotevents-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Payload, BaseFunction>? Payload { get; set; }
        }

        public class IotSiteWise : Humidifier.Base.BaseSubResource, IHaveEntryId, IHavePropertyAlias, IHaveIoTEventsDetectorModelTypesAssetPropertyValuePropertyValue, IHaveAssetId, IHavePropertyId
        {
            /// <summary>
            /// EntryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotsitewise.html#cfn-iotevents-detectormodel-iotsitewise-entryid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntryId { get; set; }
            /// <summary>
            /// PropertyAlias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotsitewise.html#cfn-iotevents-detectormodel-iotsitewise-propertyalias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyAlias { get; set; }
            /// <summary>
            /// PropertyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotsitewise.html#cfn-iotevents-detectormodel-iotsitewise-propertyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AssetPropertyValue
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.AssetPropertyValue, BaseFunction>? PropertyValue { get; set; }
            /// <summary>
            /// AssetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotsitewise.html#cfn-iotevents-detectormodel-iotsitewise-assetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssetId { get; set; }
            /// <summary>
            /// PropertyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iotsitewise.html#cfn-iotevents-detectormodel-iotsitewise-propertyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyId { get; set; }
        }

        public class IotTopicPublish : Humidifier.Base.BaseSubResource, IHaveMqttTopic, IHaveIoTEventsDetectorModelTypesPayloadPayload
        {
            /// <summary>
            /// MqttTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iottopicpublish.html#cfn-iotevents-detectormodel-iottopicpublish-mqtttopic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MqttTopic { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-iottopicpublish.html#cfn-iotevents-detectormodel-iottopicpublish-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Payload, BaseFunction>? Payload { get; set; }
        }

        public class Lambda : Humidifier.Base.BaseSubResource, IHaveFunctionArn, IHaveIoTEventsDetectorModelTypesPayloadPayload
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-lambda.html#cfn-iotevents-detectormodel-lambda-functionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionArn { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-lambda.html#cfn-iotevents-detectormodel-lambda-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Payload, BaseFunction>? Payload { get; set; }
        }

        public class OnEnter : Humidifier.Base.BaseSubResource, IHaveListOfIoTEventsDetectorModelTypesEventEvents
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-onenter.html#cfn-iotevents-detectormodel-onenter-events
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Event
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTEvents.DetectorModelTypes.Event>, IReadOnlyList<Union<Humidifier.IoTEvents.DetectorModelTypes.Event, BaseFunction>>, BaseFunction>? Events { get; set; }
        }

        public class OnExit : Humidifier.Base.BaseSubResource, IHaveListOfIoTEventsDetectorModelTypesEventEvents
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-onexit.html#cfn-iotevents-detectormodel-onexit-events
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Event
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTEvents.DetectorModelTypes.Event>, IReadOnlyList<Union<Humidifier.IoTEvents.DetectorModelTypes.Event, BaseFunction>>, BaseFunction>? Events { get; set; }
        }

        public class OnInput : Humidifier.Base.BaseSubResource, IHaveListOfIoTEventsDetectorModelTypesEventEvents, IHaveListOfIoTEventsDetectorModelTypesTransitionEventTransitionEvents
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-oninput.html#cfn-iotevents-detectormodel-oninput-events
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Event
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTEvents.DetectorModelTypes.Event>, IReadOnlyList<Union<Humidifier.IoTEvents.DetectorModelTypes.Event, BaseFunction>>, BaseFunction>? Events { get; set; }
            /// <summary>
            /// TransitionEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-oninput.html#cfn-iotevents-detectormodel-oninput-transitionevents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TransitionEvent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTEvents.DetectorModelTypes.TransitionEvent>, IReadOnlyList<Union<Humidifier.IoTEvents.DetectorModelTypes.TransitionEvent, BaseFunction>>, BaseFunction>? TransitionEvents { get; set; }
        }

        public class Payload : Humidifier.Base.BaseSubResource, IHaveContentExpression, IHaveType
        {
            /// <summary>
            /// ContentExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-payload.html#cfn-iotevents-detectormodel-payload-contentexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentExpression { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-payload.html#cfn-iotevents-detectormodel-payload-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class ResetTimer : Humidifier.Base.BaseSubResource, IHaveTimerName
        {
            /// <summary>
            /// TimerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-resettimer.html#cfn-iotevents-detectormodel-resettimer-timername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimerName { get; set; }
        }

        public class SetTimer : Humidifier.Base.BaseSubResource, IHaveSeconds_Integer, IHaveTimerName, IHaveDurationExpression
        {
            /// <summary>
            /// Seconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-settimer.html#cfn-iotevents-detectormodel-settimer-seconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Seconds { get; set; }
            /// <summary>
            /// TimerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-settimer.html#cfn-iotevents-detectormodel-settimer-timername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimerName { get; set; }
            /// <summary>
            /// DurationExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-settimer.html#cfn-iotevents-detectormodel-settimer-durationexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DurationExpression { get; set; }
        }

        public class SetVariable : Humidifier.Base.BaseSubResource, IHaveValue, IHaveVariableName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-setvariable.html#cfn-iotevents-detectormodel-setvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// VariableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-setvariable.html#cfn-iotevents-detectormodel-setvariable-variablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VariableName { get; set; }
        }

        public class Sns : Humidifier.Base.BaseSubResource, IHaveTargetArn, IHaveIoTEventsDetectorModelTypesPayloadPayload
        {
            /// <summary>
            /// TargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sns.html#cfn-iotevents-detectormodel-sns-targetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetArn { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sns.html#cfn-iotevents-detectormodel-sns-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Payload, BaseFunction>? Payload { get; set; }
        }

        public class Sqs : Humidifier.Base.BaseSubResource, IHaveUseBase64_Boolean, IHaveIoTEventsDetectorModelTypesPayloadPayload, IHaveQueueUrl
        {
            /// <summary>
            /// UseBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sqs.html#cfn-iotevents-detectormodel-sqs-usebase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseBase64 { get; set; }
            /// <summary>
            /// Payload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sqs.html#cfn-iotevents-detectormodel-sqs-payload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Payload
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.Payload, BaseFunction>? Payload { get; set; }
            /// <summary>
            /// QueueUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-sqs.html#cfn-iotevents-detectormodel-sqs-queueurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueueUrl { get; set; }
        }

        public class State : Humidifier.Base.BaseSubResource, IHaveIoTEventsDetectorModelTypesOnInputOnInput, IHaveIoTEventsDetectorModelTypesOnExitOnExit, IHaveStateName, IHaveIoTEventsDetectorModelTypesOnEnterOnEnter
        {
            /// <summary>
            /// OnInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-state.html#cfn-iotevents-detectormodel-state-oninput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnInput
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.OnInput, BaseFunction>? OnInput { get; set; }
            /// <summary>
            /// OnExit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-state.html#cfn-iotevents-detectormodel-state-onexit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnExit
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.OnExit, BaseFunction>? OnExit { get; set; }
            /// <summary>
            /// StateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-state.html#cfn-iotevents-detectormodel-state-statename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateName { get; set; }
            /// <summary>
            /// OnEnter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-state.html#cfn-iotevents-detectormodel-state-onenter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnEnter
            /// </summary>
            public Union<Humidifier.IoTEvents.DetectorModelTypes.OnEnter, BaseFunction>? OnEnter { get; set; }
        }

        public class TransitionEvent : Humidifier.Base.BaseSubResource, IHaveCondition, IHaveListOfIoTEventsDetectorModelTypesActionActions, IHaveNextState, IHaveEventName
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-transitionevent.html#cfn-iotevents-detectormodel-transitionevent-condition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-transitionevent.html#cfn-iotevents-detectormodel-transitionevent-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Action
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTEvents.DetectorModelTypes.Action>, IReadOnlyList<Union<Humidifier.IoTEvents.DetectorModelTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// NextState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-transitionevent.html#cfn-iotevents-detectormodel-transitionevent-nextstate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NextState { get; set; }
            /// <summary>
            /// EventName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-transitionevent.html#cfn-iotevents-detectormodel-transitionevent-eventname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventName { get; set; }
        }
    }
}