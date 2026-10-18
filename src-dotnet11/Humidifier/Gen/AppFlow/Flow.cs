namespace Humidifier.AppFlow
{
    using global::System.Collections.Generic;
    using FlowTypes;

    public class Flow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKMSArn, IHaveListOfAppFlowFlowTypesTaskTasks, IHaveFlowName, IHaveAppFlowFlowTypesTriggerConfigTriggerConfig, IHaveListOfAppFlowFlowTypesDestinationFlowConfigDestinationFlowConfigList, IHaveAppFlowFlowTypesSourceFlowConfigSourceFlowConfig, IHaveFlowStatus, IHaveAppFlowFlowTypesMetadataCatalogConfigMetadataCatalogConfig
    {
        public class Attributes
        {
            public static string FlowArn =  "FlowArn" ;
        }

        public override string AWSTypeName { get => AWS.AppFlow.Flow; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KMSArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-kmsarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSArn { get; set; }

        /// <summary>
        /// Tasks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-tasks
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Task
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.AppFlow.FlowTypes.Task>, IReadOnlyList<Union<Humidifier.AppFlow.FlowTypes.Task, BaseFunction>>, BaseFunction>? Tasks { get; set; }
        public Union<string, BaseFunction>? FlowName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// TriggerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-triggerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TriggerConfig
        /// </summary>
        [Required]
        public Union<Humidifier.AppFlow.FlowTypes.TriggerConfig, BaseFunction>? TriggerConfig { get; set; }

        /// <summary>
        /// DestinationFlowConfigList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-destinationflowconfiglist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DestinationFlowConfig
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.AppFlow.FlowTypes.DestinationFlowConfig>, IReadOnlyList<Union<Humidifier.AppFlow.FlowTypes.DestinationFlowConfig, BaseFunction>>, BaseFunction>? DestinationFlowConfigList { get; set; }

        /// <summary>
        /// SourceFlowConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-sourceflowconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SourceFlowConfig
        /// </summary>
        [Required]
        public Union<Humidifier.AppFlow.FlowTypes.SourceFlowConfig, BaseFunction>? SourceFlowConfig { get; set; }
        /// <summary>
        /// FlowStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-flowstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FlowStatus { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MetadataCatalogConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-metadatacatalogconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetadataCatalogConfig
        /// </summary>
        public Union<Humidifier.AppFlow.FlowTypes.MetadataCatalogConfig, BaseFunction>? MetadataCatalogConfig { get; set; }
    }

    namespace FlowTypes
    {
        public class AggregationConfig : Humidifier.Base.BaseSubResource, IHaveAggregationType, IHaveTargetFileSize_Integer
        {
            /// <summary>
            /// AggregationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-aggregationconfig.html#cfn-appflow-flow-aggregationconfig-aggregationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AggregationType { get; set; }
            /// <summary>
            /// TargetFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-aggregationconfig.html#cfn-appflow-flow-aggregationconfig-targetfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetFileSize { get; set; }
        }

        public class AmplitudeSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-amplitudesourceproperties.html#cfn-appflow-flow-amplitudesourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class ConnectorOperator : Humidifier.Base.BaseSubResource, IHaveAmplitude, IHaveS3, IHaveGoogleAnalytics, IHaveServiceNow, IHaveCustomConnector, IHaveSAPOData, IHavePardot, IHaveVeeva, IHaveTrendmicro, IHaveDatadog, IHaveMarketo, IHaveSingular, IHaveSlack, IHaveDynatrace, IHaveZendesk, IHaveInforNexus, IHaveSalesforce
        {
            /// <summary>
            /// Amplitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-amplitude
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Amplitude { get; set; }
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-s3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// GoogleAnalytics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-googleanalytics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GoogleAnalytics { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// CustomConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-customconnector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomConnector { get; set; }
            /// <summary>
            /// SAPOData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-sapodata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAPOData { get; set; }
            /// <summary>
            /// Pardot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-pardot
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pardot { get; set; }
            /// <summary>
            /// Veeva
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-veeva
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Veeva { get; set; }
            /// <summary>
            /// Trendmicro
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-trendmicro
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Trendmicro { get; set; }
            /// <summary>
            /// Datadog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-datadog
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Datadog { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Marketo { get; set; }
            /// <summary>
            /// Singular
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-singular
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Singular { get; set; }
            /// <summary>
            /// Slack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-slack
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Slack { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Dynatrace { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Zendesk { get; set; }
            /// <summary>
            /// InforNexus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-infornexus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InforNexus { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Salesforce { get; set; }
        }

        public class CustomConnectorDestinationProperties : Humidifier.Base.BaseSubResource, IHaveStringListOfIdFieldNames, IHaveEntityName, IHaveWriteOperationType, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig, IHaveStringDictionaryOfCustomProperties
        {
            /// <summary>
            /// IdFieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-idfieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IdFieldNames { get; set; }
            /// <summary>
            /// EntityName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-entityname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityName { get; set; }
            /// <summary>
            /// WriteOperationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-writeoperationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WriteOperationType { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig, BaseFunction>? ErrorHandlingConfig { get; set; }
            /// <summary>
            /// CustomProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-customproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomProperties { get; set; }
        }

        public class CustomConnectorSourceProperties : Humidifier.Base.BaseSubResource, IHaveEntityName, IHaveAppFlowFlowTypesDataTransferApiDataTransferApi, IHaveStringDictionaryOfCustomProperties
        {
            /// <summary>
            /// EntityName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectorsourceproperties.html#cfn-appflow-flow-customconnectorsourceproperties-entityname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityName { get; set; }
            /// <summary>
            /// DataTransferApi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectorsourceproperties.html#cfn-appflow-flow-customconnectorsourceproperties-datatransferapi
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataTransferApi
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.DataTransferApi, BaseFunction>? DataTransferApi { get; set; }
            /// <summary>
            /// CustomProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectorsourceproperties.html#cfn-appflow-flow-customconnectorsourceproperties-customproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomProperties { get; set; }
        }

        public class DataTransferApi : Humidifier.Base.BaseSubResource, IHaveType, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-datatransferapi.html#cfn-appflow-flow-datatransferapi-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-datatransferapi.html#cfn-appflow-flow-datatransferapi-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DatadogSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-datadogsourceproperties.html#cfn-appflow-flow-datadogsourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class DestinationConnectorProperties : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesS3DestinationPropertiesS3, IHaveAppFlowFlowTypesCustomConnectorDestinationPropertiesCustomConnector, IHaveAppFlowFlowTypesUpsolverDestinationPropertiesUpsolver, IHaveAppFlowFlowTypesSAPODataDestinationPropertiesSAPOData, IHaveAppFlowFlowTypesSnowflakeDestinationPropertiesSnowflake, IHaveAppFlowFlowTypesLookoutMetricsDestinationPropertiesLookoutMetrics, IHaveAppFlowFlowTypesEventBridgeDestinationPropertiesEventBridge, IHaveAppFlowFlowTypesZendeskDestinationPropertiesZendesk, IHaveAppFlowFlowTypesMarketoDestinationPropertiesMarketo, IHaveAppFlowFlowTypesRedshiftDestinationPropertiesRedshift, IHaveAppFlowFlowTypesSalesforceDestinationPropertiesSalesforce
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.S3DestinationProperties, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// CustomConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-customconnector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomConnectorDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.CustomConnectorDestinationProperties, BaseFunction>? CustomConnector { get; set; }
            /// <summary>
            /// Upsolver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-upsolver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpsolverDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.UpsolverDestinationProperties, BaseFunction>? Upsolver { get; set; }
            /// <summary>
            /// SAPOData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-sapodata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SAPODataDestinationProperties, BaseFunction>? SAPOData { get; set; }
            /// <summary>
            /// Snowflake
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-snowflake
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnowflakeDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SnowflakeDestinationProperties, BaseFunction>? Snowflake { get; set; }
            /// <summary>
            /// LookoutMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-lookoutmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LookoutMetricsDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.LookoutMetricsDestinationProperties, BaseFunction>? LookoutMetrics { get; set; }
            /// <summary>
            /// EventBridge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-eventbridge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBridgeDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.EventBridgeDestinationProperties, BaseFunction>? EventBridge { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZendeskDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ZendeskDestinationProperties, BaseFunction>? Zendesk { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarketoDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.MarketoDestinationProperties, BaseFunction>? Marketo { get; set; }
            /// <summary>
            /// Redshift
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-redshift
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.RedshiftDestinationProperties, BaseFunction>? Redshift { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceDestinationProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SalesforceDestinationProperties, BaseFunction>? Salesforce { get; set; }
        }

        public class DestinationFlowConfig : Humidifier.Base.BaseSubResource, IHaveConnectorProfileName, IHaveApiVersion, IHaveConnectorType, IHaveAppFlowFlowTypesDestinationConnectorPropertiesDestinationConnectorProperties
        {
            /// <summary>
            /// ConnectorProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html#cfn-appflow-flow-destinationflowconfig-connectorprofilename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorProfileName { get; set; }
            /// <summary>
            /// ApiVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html#cfn-appflow-flow-destinationflowconfig-apiversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiVersion { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html#cfn-appflow-flow-destinationflowconfig-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorType { get; set; }
            /// <summary>
            /// DestinationConnectorProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html#cfn-appflow-flow-destinationflowconfig-destinationconnectorproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationConnectorProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties, BaseFunction>? DestinationConnectorProperties { get; set; }
        }

        public class DynatraceSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-dynatracesourceproperties.html#cfn-appflow-flow-dynatracesourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class ErrorHandlingConfig : Humidifier.Base.BaseSubResource, IHaveFailOnFirstError_Boolean, IHaveBucketPrefix, IHaveBucketName
        {
            /// <summary>
            /// FailOnFirstError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-errorhandlingconfig.html#cfn-appflow-flow-errorhandlingconfig-failonfirsterror
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FailOnFirstError { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-errorhandlingconfig.html#cfn-appflow-flow-errorhandlingconfig-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-errorhandlingconfig.html#cfn-appflow-flow-errorhandlingconfig-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }

        public class EventBridgeDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-eventbridgedestinationproperties.html#cfn-appflow-flow-eventbridgedestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-eventbridgedestinationproperties.html#cfn-appflow-flow-eventbridgedestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig, BaseFunction>? ErrorHandlingConfig { get; set; }
        }

        public class GlueDataCatalog : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveRoleArn, IHaveTablePrefix
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-gluedatacatalog.html#cfn-appflow-flow-gluedatacatalog-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-gluedatacatalog.html#cfn-appflow-flow-gluedatacatalog-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// TablePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-gluedatacatalog.html#cfn-appflow-flow-gluedatacatalog-tableprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TablePrefix { get; set; }
        }

        public class GoogleAnalyticsSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-googleanalyticssourceproperties.html#cfn-appflow-flow-googleanalyticssourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class IncrementalPullConfig : Humidifier.Base.BaseSubResource, IHaveDatetimeTypeFieldName
        {
            /// <summary>
            /// DatetimeTypeFieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-incrementalpullconfig.html#cfn-appflow-flow-incrementalpullconfig-datetimetypefieldname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatetimeTypeFieldName { get; set; }
        }

        public class InforNexusSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-infornexussourceproperties.html#cfn-appflow-flow-infornexussourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class LookoutMetricsDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-lookoutmetricsdestinationproperties.html#cfn-appflow-flow-lookoutmetricsdestinationproperties-object
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class MarketoDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-marketodestinationproperties.html#cfn-appflow-flow-marketodestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-marketodestinationproperties.html#cfn-appflow-flow-marketodestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig, BaseFunction>? ErrorHandlingConfig { get; set; }
        }

        public class MarketoSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-marketosourceproperties.html#cfn-appflow-flow-marketosourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class MetadataCatalogConfig : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesGlueDataCatalogGlueDataCatalog
        {
            /// <summary>
            /// GlueDataCatalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-metadatacatalogconfig.html#cfn-appflow-flow-metadatacatalogconfig-gluedatacatalog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueDataCatalog
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.GlueDataCatalog, BaseFunction>? GlueDataCatalog { get; set; }
        }

        public class PardotSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-pardotsourceproperties.html#cfn-appflow-flow-pardotsourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class PrefixConfig : Humidifier.Base.BaseSubResource, IHavePrefixFormat, IHavePrefixType, IHaveStringListOfPathPrefixHierarchy
        {
            /// <summary>
            /// PrefixFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-prefixconfig.html#cfn-appflow-flow-prefixconfig-prefixformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrefixFormat { get; set; }
            /// <summary>
            /// PrefixType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-prefixconfig.html#cfn-appflow-flow-prefixconfig-prefixtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrefixType { get; set; }
            /// <summary>
            /// PathPrefixHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-prefixconfig.html#cfn-appflow-flow-prefixconfig-pathprefixhierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PathPrefixHierarchy { get; set; }
        }

        public class RedshiftDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveBucketPrefix, IHaveIntermediateBucketName, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html#cfn-appflow-flow-redshiftdestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html#cfn-appflow-flow-redshiftdestinationproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
            /// <summary>
            /// IntermediateBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html#cfn-appflow-flow-redshiftdestinationproperties-intermediatebucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntermediateBucketName { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html#cfn-appflow-flow-redshiftdestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig, BaseFunction>? ErrorHandlingConfig { get; set; }
        }

        public class S3DestinationProperties : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix, IHaveAppFlowFlowTypesS3OutputFormatConfigS3OutputFormatConfig
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3destinationproperties.html#cfn-appflow-flow-s3destinationproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3destinationproperties.html#cfn-appflow-flow-s3destinationproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
            /// <summary>
            /// S3OutputFormatConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3destinationproperties.html#cfn-appflow-flow-s3destinationproperties-s3outputformatconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3OutputFormatConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig, BaseFunction>? S3OutputFormatConfig { get; set; }
        }

        public class S3InputFormatConfig : Humidifier.Base.BaseSubResource, IHaveS3InputFileType
        {
            /// <summary>
            /// S3InputFileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3inputformatconfig.html#cfn-appflow-flow-s3inputformatconfig-s3inputfiletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3InputFileType { get; set; }
        }

        public class S3OutputFormatConfig : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesPrefixConfigPrefixConfig, IHaveFileType, IHaveAppFlowFlowTypesAggregationConfigAggregationConfig, IHavePreserveSourceDataTyping_Boolean
        {
            /// <summary>
            /// PrefixConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html#cfn-appflow-flow-s3outputformatconfig-prefixconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrefixConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.PrefixConfig, BaseFunction>? PrefixConfig { get; set; }
            /// <summary>
            /// FileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html#cfn-appflow-flow-s3outputformatconfig-filetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileType { get; set; }
            /// <summary>
            /// AggregationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html#cfn-appflow-flow-s3outputformatconfig-aggregationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.AggregationConfig, BaseFunction>? AggregationConfig { get; set; }
            /// <summary>
            /// PreserveSourceDataTyping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html#cfn-appflow-flow-s3outputformatconfig-preservesourcedatatyping
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PreserveSourceDataTyping { get; set; }
        }

        public class S3SourceProperties : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesS3InputFormatConfigS3InputFormatConfig, IHaveBucketName, IHaveBucketPrefix
        {
            /// <summary>
            /// S3InputFormatConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3sourceproperties.html#cfn-appflow-flow-s3sourceproperties-s3inputformatconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3InputFormatConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.S3InputFormatConfig, BaseFunction>? S3InputFormatConfig { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3sourceproperties.html#cfn-appflow-flow-s3sourceproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3sourceproperties.html#cfn-appflow-flow-s3sourceproperties-bucketprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
        }

        public class SAPODataDestinationProperties : Humidifier.Base.BaseSubResource, IHaveStringListOfIdFieldNames, IHaveObjectPath, IHaveWriteOperationType, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig, IHaveAppFlowFlowTypesSuccessResponseHandlingConfigSuccessResponseHandlingConfig
        {
            /// <summary>
            /// IdFieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-idfieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IdFieldNames { get; set; }
            /// <summary>
            /// ObjectPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-objectpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectPath { get; set; }
            /// <summary>
            /// WriteOperationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-writeoperationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WriteOperationType { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig, BaseFunction>? ErrorHandlingConfig { get; set; }
            /// <summary>
            /// SuccessResponseHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-successresponsehandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SuccessResponseHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SuccessResponseHandlingConfig, BaseFunction>? SuccessResponseHandlingConfig { get; set; }
        }

        public class SAPODataPaginationConfig : Humidifier.Base.BaseSubResource, IHavemaxPageSize_Integer
        {
            /// <summary>
            /// maxPageSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatapaginationconfig.html#cfn-appflow-flow-sapodatapaginationconfig-maxpagesize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? maxPageSize { get; set; }
        }

        public class SAPODataParallelismConfig : Humidifier.Base.BaseSubResource, IHavemaxParallelism_Integer
        {
            /// <summary>
            /// maxParallelism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodataparallelismconfig.html#cfn-appflow-flow-sapodataparallelismconfig-maxparallelism
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? maxParallelism { get; set; }
        }

        public class SAPODataSourceProperties : Humidifier.Base.BaseSubResource, IHaveObjectPath, IHaveAppFlowFlowTypesSAPODataPaginationConfigpaginationConfig, IHaveAppFlowFlowTypesSAPODataParallelismConfigparallelismConfig
        {
            /// <summary>
            /// ObjectPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatasourceproperties.html#cfn-appflow-flow-sapodatasourceproperties-objectpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectPath { get; set; }
            /// <summary>
            /// paginationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatasourceproperties.html#cfn-appflow-flow-sapodatasourceproperties-paginationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataPaginationConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig, BaseFunction>? paginationConfig { get; set; }
            /// <summary>
            /// parallelismConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatasourceproperties.html#cfn-appflow-flow-sapodatasourceproperties-parallelismconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataParallelismConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig, BaseFunction>? parallelismConfig { get; set; }
        }

        public class SalesforceDestinationProperties : Humidifier.Base.BaseSubResource, IHaveStringListOfIdFieldNames, IHaveWriteOperationType, IHaveDataTransferApi, IHaveObject, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig
        {
            /// <summary>
            /// IdFieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-idfieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IdFieldNames { get; set; }
            /// <summary>
            /// WriteOperationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-writeoperationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WriteOperationType { get; set; }
            /// <summary>
            /// DataTransferApi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-datatransferapi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataTransferApi { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig, BaseFunction>? ErrorHandlingConfig { get; set; }
        }

        public class SalesforceSourceProperties : Humidifier.Base.BaseSubResource, IHaveIncludeDeletedRecords_Boolean, IHaveDataTransferApi, IHaveObject, IHaveEnableDynamicFieldUpdate_Boolean
        {
            /// <summary>
            /// IncludeDeletedRecords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html#cfn-appflow-flow-salesforcesourceproperties-includedeletedrecords
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeDeletedRecords { get; set; }
            /// <summary>
            /// DataTransferApi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html#cfn-appflow-flow-salesforcesourceproperties-datatransferapi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataTransferApi { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html#cfn-appflow-flow-salesforcesourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// EnableDynamicFieldUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html#cfn-appflow-flow-salesforcesourceproperties-enabledynamicfieldupdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableDynamicFieldUpdate { get; set; }
        }

        public class ScheduledTriggerProperties : Humidifier.Base.BaseSubResource, IHaveScheduleEndTime_Double, IHaveScheduleExpression, IHaveFirstExecutionFrom_Double, IHaveTimeZone, IHaveScheduleStartTime_Double, IHaveDataPullMode, IHaveScheduleOffset_Double, IHaveFlowErrorDeactivationThreshold_Integer
        {
            /// <summary>
            /// ScheduleEndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-scheduleendtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ScheduleEndTime { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-scheduleexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// FirstExecutionFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-firstexecutionfrom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? FirstExecutionFrom { get; set; }
            /// <summary>
            /// TimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeZone { get; set; }
            /// <summary>
            /// ScheduleStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-schedulestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ScheduleStartTime { get; set; }
            /// <summary>
            /// DataPullMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-datapullmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataPullMode { get; set; }
            /// <summary>
            /// ScheduleOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-scheduleoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ScheduleOffset { get; set; }
            /// <summary>
            /// FlowErrorDeactivationThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-flowerrordeactivationthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FlowErrorDeactivationThreshold { get; set; }
        }

        public class ServiceNowSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-servicenowsourceproperties.html#cfn-appflow-flow-servicenowsourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class SingularSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-singularsourceproperties.html#cfn-appflow-flow-singularsourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class SlackSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-slacksourceproperties.html#cfn-appflow-flow-slacksourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class SnowflakeDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveBucketPrefix, IHaveIntermediateBucketName, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-snowflakedestinationproperties.html#cfn-appflow-flow-snowflakedestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-snowflakedestinationproperties.html#cfn-appflow-flow-snowflakedestinationproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
            /// <summary>
            /// IntermediateBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-snowflakedestinationproperties.html#cfn-appflow-flow-snowflakedestinationproperties-intermediatebucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntermediateBucketName { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-snowflakedestinationproperties.html#cfn-appflow-flow-snowflakedestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig, BaseFunction>? ErrorHandlingConfig { get; set; }
        }

        public class SourceConnectorProperties : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesAmplitudeSourcePropertiesAmplitude, IHaveAppFlowFlowTypesS3SourcePropertiesS3, IHaveAppFlowFlowTypesGoogleAnalyticsSourcePropertiesGoogleAnalytics, IHaveAppFlowFlowTypesServiceNowSourcePropertiesServiceNow, IHaveAppFlowFlowTypesCustomConnectorSourcePropertiesCustomConnector, IHaveAppFlowFlowTypesSAPODataSourcePropertiesSAPOData, IHaveAppFlowFlowTypesPardotSourcePropertiesPardot, IHaveAppFlowFlowTypesVeevaSourcePropertiesVeeva, IHaveAppFlowFlowTypesTrendmicroSourcePropertiesTrendmicro, IHaveAppFlowFlowTypesDatadogSourcePropertiesDatadog, IHaveAppFlowFlowTypesMarketoSourcePropertiesMarketo, IHaveAppFlowFlowTypesSingularSourcePropertiesSingular, IHaveAppFlowFlowTypesSlackSourcePropertiesSlack, IHaveAppFlowFlowTypesDynatraceSourcePropertiesDynatrace, IHaveAppFlowFlowTypesZendeskSourcePropertiesZendesk, IHaveAppFlowFlowTypesInforNexusSourcePropertiesInforNexus, IHaveAppFlowFlowTypesSalesforceSourcePropertiesSalesforce
        {
            /// <summary>
            /// Amplitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-amplitude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmplitudeSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.AmplitudeSourceProperties, BaseFunction>? Amplitude { get; set; }
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3SourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.S3SourceProperties, BaseFunction>? S3 { get; set; }
            /// <summary>
            /// GoogleAnalytics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-googleanalytics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GoogleAnalyticsSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.GoogleAnalyticsSourceProperties, BaseFunction>? GoogleAnalytics { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ServiceNowSourceProperties, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// CustomConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-customconnector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomConnectorSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.CustomConnectorSourceProperties, BaseFunction>? CustomConnector { get; set; }
            /// <summary>
            /// SAPOData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-sapodata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SAPODataSourceProperties, BaseFunction>? SAPOData { get; set; }
            /// <summary>
            /// Pardot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-pardot
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PardotSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.PardotSourceProperties, BaseFunction>? Pardot { get; set; }
            /// <summary>
            /// Veeva
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-veeva
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VeevaSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.VeevaSourceProperties, BaseFunction>? Veeva { get; set; }
            /// <summary>
            /// Trendmicro
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-trendmicro
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrendmicroSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.TrendmicroSourceProperties, BaseFunction>? Trendmicro { get; set; }
            /// <summary>
            /// Datadog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-datadog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatadogSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.DatadogSourceProperties, BaseFunction>? Datadog { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarketoSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.MarketoSourceProperties, BaseFunction>? Marketo { get; set; }
            /// <summary>
            /// Singular
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-singular
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingularSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SingularSourceProperties, BaseFunction>? Singular { get; set; }
            /// <summary>
            /// Slack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-slack
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlackSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SlackSourceProperties, BaseFunction>? Slack { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynatraceSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.DynatraceSourceProperties, BaseFunction>? Dynatrace { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZendeskSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ZendeskSourceProperties, BaseFunction>? Zendesk { get; set; }
            /// <summary>
            /// InforNexus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-infornexus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InforNexusSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.InforNexusSourceProperties, BaseFunction>? InforNexus { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceSourceProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SalesforceSourceProperties, BaseFunction>? Salesforce { get; set; }
        }

        public class SourceFlowConfig : Humidifier.Base.BaseSubResource, IHaveConnectorProfileName, IHaveApiVersion, IHaveAppFlowFlowTypesSourceConnectorPropertiesSourceConnectorProperties, IHaveConnectorType, IHaveAppFlowFlowTypesIncrementalPullConfigIncrementalPullConfig
        {
            /// <summary>
            /// ConnectorProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-connectorprofilename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorProfileName { get; set; }
            /// <summary>
            /// ApiVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-apiversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiVersion { get; set; }
            /// <summary>
            /// SourceConnectorProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-sourceconnectorproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SourceConnectorProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.SourceConnectorProperties, BaseFunction>? SourceConnectorProperties { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorType { get; set; }
            /// <summary>
            /// IncrementalPullConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-incrementalpullconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IncrementalPullConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.IncrementalPullConfig, BaseFunction>? IncrementalPullConfig { get; set; }
        }

        public class SuccessResponseHandlingConfig : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-successresponsehandlingconfig.html#cfn-appflow-flow-successresponsehandlingconfig-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-successresponsehandlingconfig.html#cfn-appflow-flow-successresponsehandlingconfig-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
        }

        public class Task : Humidifier.Base.BaseSubResource, IHaveStringListOfSourceFields, IHaveDestinationField, IHaveAppFlowFlowTypesConnectorOperatorConnectorOperator, IHaveTaskType, IHaveListOfAppFlowFlowTypesTaskPropertiesObjectTaskProperties
        {
            /// <summary>
            /// SourceFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-sourcefields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceFields { get; set; }
            /// <summary>
            /// DestinationField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-destinationfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationField { get; set; }
            /// <summary>
            /// ConnectorOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-connectoroperator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOperator
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ConnectorOperator, BaseFunction>? ConnectorOperator { get; set; }
            /// <summary>
            /// TaskType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-tasktype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TaskType { get; set; }
            /// <summary>
            /// TaskProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-taskproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TaskPropertiesObject
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppFlow.FlowTypes.TaskPropertiesObject>, IReadOnlyList<Union<Humidifier.AppFlow.FlowTypes.TaskPropertiesObject, BaseFunction>>, BaseFunction>? TaskProperties { get; set; }
        }

        public class TaskPropertiesObject : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-taskpropertiesobject.html#cfn-appflow-flow-taskpropertiesobject-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-taskpropertiesobject.html#cfn-appflow-flow-taskpropertiesobject-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TrendmicroSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-trendmicrosourceproperties.html#cfn-appflow-flow-trendmicrosourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }

        public class TriggerConfig : Humidifier.Base.BaseSubResource, IHaveTriggerType, IHaveAppFlowFlowTypesScheduledTriggerPropertiesTriggerProperties
        {
            /// <summary>
            /// TriggerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-triggerconfig.html#cfn-appflow-flow-triggerconfig-triggertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TriggerType { get; set; }
            /// <summary>
            /// TriggerProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-triggerconfig.html#cfn-appflow-flow-triggerconfig-triggerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScheduledTriggerProperties
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties, BaseFunction>? TriggerProperties { get; set; }
        }

        public class UpsolverDestinationProperties : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix, IHaveAppFlowFlowTypesUpsolverS3OutputFormatConfigS3OutputFormatConfig
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolverdestinationproperties.html#cfn-appflow-flow-upsolverdestinationproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolverdestinationproperties.html#cfn-appflow-flow-upsolverdestinationproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
            /// <summary>
            /// S3OutputFormatConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolverdestinationproperties.html#cfn-appflow-flow-upsolverdestinationproperties-s3outputformatconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: UpsolverS3OutputFormatConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig, BaseFunction>? S3OutputFormatConfig { get; set; }
        }

        public class UpsolverS3OutputFormatConfig : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesPrefixConfigPrefixConfig, IHaveFileType, IHaveAppFlowFlowTypesAggregationConfigAggregationConfig
        {
            /// <summary>
            /// PrefixConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolvers3outputformatconfig.html#cfn-appflow-flow-upsolvers3outputformatconfig-prefixconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrefixConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.PrefixConfig, BaseFunction>? PrefixConfig { get; set; }
            /// <summary>
            /// FileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolvers3outputformatconfig.html#cfn-appflow-flow-upsolvers3outputformatconfig-filetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileType { get; set; }
            /// <summary>
            /// AggregationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolvers3outputformatconfig.html#cfn-appflow-flow-upsolvers3outputformatconfig-aggregationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.AggregationConfig, BaseFunction>? AggregationConfig { get; set; }
        }

        public class VeevaSourceProperties : Humidifier.Base.BaseSubResource, IHaveIncludeAllVersions_Boolean, IHaveIncludeRenditions_Boolean, IHaveDocumentType, IHaveObject, IHaveIncludeSourceFiles_Boolean
        {
            /// <summary>
            /// IncludeAllVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-includeallversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeAllVersions { get; set; }
            /// <summary>
            /// IncludeRenditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-includerenditions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeRenditions { get; set; }
            /// <summary>
            /// DocumentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-documenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentType { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// IncludeSourceFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-includesourcefiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeSourceFiles { get; set; }
        }

        public class ZendeskDestinationProperties : Humidifier.Base.BaseSubResource, IHaveStringListOfIdFieldNames, IHaveWriteOperationType, IHaveObject, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig
        {
            /// <summary>
            /// IdFieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html#cfn-appflow-flow-zendeskdestinationproperties-idfieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IdFieldNames { get; set; }
            /// <summary>
            /// WriteOperationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html#cfn-appflow-flow-zendeskdestinationproperties-writeoperationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WriteOperationType { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html#cfn-appflow-flow-zendeskdestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html#cfn-appflow-flow-zendeskdestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Union<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig, BaseFunction>? ErrorHandlingConfig { get; set; }
        }

        public class ZendeskSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendesksourceproperties.html#cfn-appflow-flow-zendesksourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Object { get; set; }
        }
    }
}