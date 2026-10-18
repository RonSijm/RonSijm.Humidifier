namespace Humidifier.CustomerProfiles
{
    using global::System.Collections.Generic;
    using IntegrationTypes;

    public class Integration : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfEventTriggerNames, IHaveListOfCustomerProfilesIntegrationTypesObjectTypeMappingObjectTypeNames, IHaveScope, IHaveDomainName, IHaveObjectTypeName, IHaveUri, IHaveCustomerProfilesIntegrationTypesFlowDefinitionFlowDefinition
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.CustomerProfiles.Integration; }
        /// <summary>
        /// EventTriggerNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html#cfn-customerprofiles-integration-eventtriggernames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EventTriggerNames { get; set; }
        /// <summary>
        /// ObjectTypeNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html#cfn-customerprofiles-integration-objecttypenames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ObjectTypeMapping
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping>, IReadOnlyList<Union<Humidifier.CustomerProfiles.IntegrationTypes.ObjectTypeMapping, BaseFunction>>, BaseFunction>? ObjectTypeNames { get; set; }
        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html#cfn-customerprofiles-integration-scope
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Scope { get; set; }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html#cfn-customerprofiles-integration-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainName { get; set; }
        /// <summary>
        /// ObjectTypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html#cfn-customerprofiles-integration-objecttypename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ObjectTypeName { get; set; }
        /// <summary>
        /// Uri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html#cfn-customerprofiles-integration-uri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Uri { get; set; }
        /// <summary>
        /// FlowDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html#cfn-customerprofiles-integration-flowdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FlowDefinition
        /// </summary>
        public Union<Humidifier.CustomerProfiles.IntegrationTypes.FlowDefinition, BaseFunction>? FlowDefinition { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-customerprofiles-integration.html#cfn-customerprofiles-integration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IntegrationTypes
    {
        public class ConnectorOperator : Humidifier.Base.BaseSubResource, IHaveS3, IHaveServiceNow, IHaveZendesk, IHaveMarketo, IHaveSalesforce
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-connectoroperator.html#cfn-customerprofiles-integration-connectoroperator-s3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-connectoroperator.html#cfn-customerprofiles-integration-connectoroperator-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-connectoroperator.html#cfn-customerprofiles-integration-connectoroperator-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Zendesk { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-connectoroperator.html#cfn-customerprofiles-integration-connectoroperator-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Marketo { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-connectoroperator.html#cfn-customerprofiles-integration-connectoroperator-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Salesforce { get; set; }
        }

        public class FlowDefinition : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveListOfCustomerProfilesIntegrationTypesTaskTasks, IHaveFlowName, IHaveCustomerProfilesIntegrationTypesTriggerConfigTriggerConfig, IHaveCustomerProfilesIntegrationTypesSourceFlowConfigSourceFlowConfig, IHaveKmsArn
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-flowdefinition.html#cfn-customerprofiles-integration-flowdefinition-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Tasks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-flowdefinition.html#cfn-customerprofiles-integration-flowdefinition-tasks
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Task
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.IntegrationTypes.Task>, IReadOnlyList<Union<Humidifier.CustomerProfiles.IntegrationTypes.Task, BaseFunction>>, BaseFunction>? Tasks { get; set; }
            /// <summary>
            /// FlowName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-flowdefinition.html#cfn-customerprofiles-integration-flowdefinition-flowname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowName { get; set; }
            /// <summary>
            /// TriggerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-flowdefinition.html#cfn-customerprofiles-integration-flowdefinition-triggerconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TriggerConfig
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.TriggerConfig, BaseFunction>? TriggerConfig { get; set; }
            /// <summary>
            /// SourceFlowConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-flowdefinition.html#cfn-customerprofiles-integration-flowdefinition-sourceflowconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SourceFlowConfig
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.SourceFlowConfig, BaseFunction>? SourceFlowConfig { get; set; }
            /// <summary>
            /// KmsArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-flowdefinition.html#cfn-customerprofiles-integration-flowdefinition-kmsarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsArn { get; set; }
        }

        public class IncrementalPullConfig : Humidifier.Base.BaseSubResource, IHaveDatetimeTypeFieldName
        {
            /// <summary>
            /// DatetimeTypeFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-incrementalpullconfig.html#cfn-customerprofiles-integration-incrementalpullconfig-datetimetypefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatetimeTypeFieldName { get; set; }
        }

        public class MarketoSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-marketosourceproperties.html#cfn-customerprofiles-integration-marketosourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class ObjectTypeMapping : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-objecttypemapping.html#cfn-customerprofiles-integration-objecttypemapping-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-objecttypemapping.html#cfn-customerprofiles-integration-objecttypemapping-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class S3SourceProperties : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-s3sourceproperties.html#cfn-customerprofiles-integration-s3sourceproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-s3sourceproperties.html#cfn-customerprofiles-integration-s3sourceproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
        }

        public class SalesforceSourceProperties : Humidifier.Base.BaseSubResource, IHaveIncludeDeletedRecords_Boolean, IHaveObject, IHaveEnableDynamicFieldUpdate_Boolean
        {
            /// <summary>
            /// IncludeDeletedRecords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-salesforcesourceproperties.html#cfn-customerprofiles-integration-salesforcesourceproperties-includedeletedrecords
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeDeletedRecords { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-salesforcesourceproperties.html#cfn-customerprofiles-integration-salesforcesourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// EnableDynamicFieldUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-salesforcesourceproperties.html#cfn-customerprofiles-integration-salesforcesourceproperties-enabledynamicfieldupdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableDynamicFieldUpdate { get; set; }
        }

        public class ScheduledTriggerProperties : Humidifier.Base.BaseSubResource, IHaveScheduleEndTime_Double, IHaveTimezone, IHaveScheduleExpression, IHaveFirstExecutionFrom_Double, IHaveScheduleStartTime_Double, IHaveDataPullMode, IHaveScheduleOffset_Integer
        {
            /// <summary>
            /// ScheduleEndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-scheduledtriggerproperties.html#cfn-customerprofiles-integration-scheduledtriggerproperties-scheduleendtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ScheduleEndTime { get; set; }
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-scheduledtriggerproperties.html#cfn-customerprofiles-integration-scheduledtriggerproperties-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timezone { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-scheduledtriggerproperties.html#cfn-customerprofiles-integration-scheduledtriggerproperties-scheduleexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// FirstExecutionFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-scheduledtriggerproperties.html#cfn-customerprofiles-integration-scheduledtriggerproperties-firstexecutionfrom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FirstExecutionFrom { get; set; }
            /// <summary>
            /// ScheduleStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-scheduledtriggerproperties.html#cfn-customerprofiles-integration-scheduledtriggerproperties-schedulestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ScheduleStartTime { get; set; }
            /// <summary>
            /// DataPullMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-scheduledtriggerproperties.html#cfn-customerprofiles-integration-scheduledtriggerproperties-datapullmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataPullMode { get; set; }
            /// <summary>
            /// ScheduleOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-scheduledtriggerproperties.html#cfn-customerprofiles-integration-scheduledtriggerproperties-scheduleoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScheduleOffset { get; set; }
        }

        public class ServiceNowSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-servicenowsourceproperties.html#cfn-customerprofiles-integration-servicenowsourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class SourceConnectorProperties : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesIntegrationTypesS3SourcePropertiesS3, IHaveCustomerProfilesIntegrationTypesServiceNowSourcePropertiesServiceNow, IHaveCustomerProfilesIntegrationTypesZendeskSourcePropertiesZendesk, IHaveCustomerProfilesIntegrationTypesMarketoSourcePropertiesMarketo, IHaveCustomerProfilesIntegrationTypesSalesforceSourcePropertiesSalesforce
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceconnectorproperties.html#cfn-customerprofiles-integration-sourceconnectorproperties-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3SourceProperties
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.S3SourceProperties, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceconnectorproperties.html#cfn-customerprofiles-integration-sourceconnectorproperties-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowSourceProperties
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.ServiceNowSourceProperties, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceconnectorproperties.html#cfn-customerprofiles-integration-sourceconnectorproperties-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZendeskSourceProperties
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.ZendeskSourceProperties, BaseFunction>? Zendesk { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceconnectorproperties.html#cfn-customerprofiles-integration-sourceconnectorproperties-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarketoSourceProperties
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.MarketoSourceProperties, BaseFunction>? Marketo { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceconnectorproperties.html#cfn-customerprofiles-integration-sourceconnectorproperties-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceSourceProperties
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.SalesforceSourceProperties, BaseFunction>? Salesforce { get; set; }
        }

        public class SourceFlowConfig : Humidifier.Base.BaseSubResource, IHaveConnectorProfileName, IHaveCustomerProfilesIntegrationTypesSourceConnectorPropertiesSourceConnectorProperties, IHaveConnectorType, IHaveCustomerProfilesIntegrationTypesIncrementalPullConfigIncrementalPullConfig
        {
            /// <summary>
            /// ConnectorProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceflowconfig.html#cfn-customerprofiles-integration-sourceflowconfig-connectorprofilename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorProfileName { get; set; }
            /// <summary>
            /// SourceConnectorProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceflowconfig.html#cfn-customerprofiles-integration-sourceflowconfig-sourceconnectorproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SourceConnectorProperties
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.SourceConnectorProperties, BaseFunction>? SourceConnectorProperties { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceflowconfig.html#cfn-customerprofiles-integration-sourceflowconfig-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorType { get; set; }
            /// <summary>
            /// IncrementalPullConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-sourceflowconfig.html#cfn-customerprofiles-integration-sourceflowconfig-incrementalpullconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IncrementalPullConfig
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.IncrementalPullConfig, BaseFunction>? IncrementalPullConfig { get; set; }
        }

        public class Task : Humidifier.Base.BaseSubResource, IHaveStringListOfSourceFields, IHaveDestinationField, IHaveCustomerProfilesIntegrationTypesConnectorOperatorConnectorOperator, IHaveTaskType, IHaveListOfCustomerProfilesIntegrationTypesTaskPropertiesMapTaskProperties
        {
            /// <summary>
            /// SourceFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-task.html#cfn-customerprofiles-integration-task-sourcefields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceFields { get; set; }
            /// <summary>
            /// DestinationField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-task.html#cfn-customerprofiles-integration-task-destinationfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationField { get; set; }
            /// <summary>
            /// ConnectorOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-task.html#cfn-customerprofiles-integration-task-connectoroperator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOperator
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.ConnectorOperator, BaseFunction>? ConnectorOperator { get; set; }
            /// <summary>
            /// TaskType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-task.html#cfn-customerprofiles-integration-task-tasktype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskType { get; set; }
            /// <summary>
            /// TaskProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-task.html#cfn-customerprofiles-integration-task-taskproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TaskPropertiesMap
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CustomerProfiles.IntegrationTypes.TaskPropertiesMap>, IReadOnlyList<Union<Humidifier.CustomerProfiles.IntegrationTypes.TaskPropertiesMap, BaseFunction>>, BaseFunction>? TaskProperties { get; set; }
        }

        public class TaskPropertiesMap : Humidifier.Base.BaseSubResource, IHaveOperatorPropertyKey, IHaveProperty
        {
            /// <summary>
            /// OperatorPropertyKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-taskpropertiesmap.html#cfn-customerprofiles-integration-taskpropertiesmap-operatorpropertykey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperatorPropertyKey { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-taskpropertiesmap.html#cfn-customerprofiles-integration-taskpropertiesmap-property
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Property { get; set; }
        }

        public class TriggerConfig : Humidifier.Base.BaseSubResource, IHaveTriggerType, IHaveCustomerProfilesIntegrationTypesTriggerPropertiesTriggerProperties
        {
            /// <summary>
            /// TriggerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-triggerconfig.html#cfn-customerprofiles-integration-triggerconfig-triggertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TriggerType { get; set; }
            /// <summary>
            /// TriggerProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-triggerconfig.html#cfn-customerprofiles-integration-triggerconfig-triggerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TriggerProperties
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.TriggerProperties, BaseFunction>? TriggerProperties { get; set; }
        }

        public class TriggerProperties : Humidifier.Base.BaseSubResource, IHaveCustomerProfilesIntegrationTypesScheduledTriggerPropertiesScheduled
        {
            /// <summary>
            /// Scheduled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-triggerproperties.html#cfn-customerprofiles-integration-triggerproperties-scheduled
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScheduledTriggerProperties
            /// </summary>
            public Union<Humidifier.CustomerProfiles.IntegrationTypes.ScheduledTriggerProperties, BaseFunction>? Scheduled { get; set; }
        }

        public class ZendeskSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-customerprofiles-integration-zendesksourceproperties.html#cfn-customerprofiles-integration-zendesksourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }
    }
}