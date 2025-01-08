namespace Humidifier.AppFlow
{
    using System.Collections.Generic;
    using FlowTypes;

    public class Flow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKMSArn, IHaveFlowName
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
        public dynamic Description { get; set; }
        /// <summary>
        /// KMSArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-kmsarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KMSArn { get; set; }

        /// <summary>
        /// Tasks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-tasks
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Task
        /// </summary>
        [Required]
        public List<Humidifier.AppFlow.FlowTypes.Task> Tasks { get; set; }
        public dynamic FlowName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// TriggerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-triggerconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: TriggerConfig
        /// </summary>
        [Required]
        public Humidifier.AppFlow.FlowTypes.TriggerConfig TriggerConfig { get; set; }

        /// <summary>
        /// DestinationFlowConfigList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-destinationflowconfiglist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DestinationFlowConfig
        /// </summary>
        [Required]
        public List<Humidifier.AppFlow.FlowTypes.DestinationFlowConfig> DestinationFlowConfigList { get; set; }

        /// <summary>
        /// SourceFlowConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-sourceflowconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SourceFlowConfig
        /// </summary>
        [Required]
        public Humidifier.AppFlow.FlowTypes.SourceFlowConfig SourceFlowConfig { get; set; }
        /// <summary>
        /// FlowStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-flowstatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FlowStatus { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// MetadataCatalogConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-flow.html#cfn-appflow-flow-metadatacatalogconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetadataCatalogConfig
        /// </summary>
        public Humidifier.AppFlow.FlowTypes.MetadataCatalogConfig MetadataCatalogConfig { get; set; }
    }

    namespace FlowTypes
    {
        public class AggregationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetFileSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-aggregationconfig.html#cfn-appflow-flow-aggregationconfig-targetfilesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetFileSize { get; set; }
            /// <summary>
            /// AggregationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-aggregationconfig.html#cfn-appflow-flow-aggregationconfig-aggregationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AggregationType { get; set; }
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
            public dynamic Object { get; set; }
        }

        public class ConnectorOperator : Humidifier.Base.BaseSubResource, IHaveS3, IHaveServiceNow, IHaveMarketo, IHaveZendesk, IHaveSalesforce
        {
            /// <summary>
            /// Amplitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-amplitude
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Amplitude { get; set; }
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-s3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3 { get; set; }
            /// <summary>
            /// GoogleAnalytics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-googleanalytics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GoogleAnalytics { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceNow { get; set; }
            /// <summary>
            /// CustomConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-customconnector
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomConnector { get; set; }
            /// <summary>
            /// SAPOData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-sapodata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SAPOData { get; set; }
            /// <summary>
            /// Pardot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-pardot
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pardot { get; set; }
            /// <summary>
            /// Veeva
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-veeva
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Veeva { get; set; }
            /// <summary>
            /// Trendmicro
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-trendmicro
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trendmicro { get; set; }
            /// <summary>
            /// Datadog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-datadog
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Datadog { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Marketo { get; set; }
            /// <summary>
            /// Singular
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-singular
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Singular { get; set; }
            /// <summary>
            /// Slack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-slack
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Slack { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Dynatrace { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Zendesk { get; set; }
            /// <summary>
            /// InforNexus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-infornexus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InforNexus { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-connectoroperator.html#cfn-appflow-flow-connectoroperator-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Salesforce { get; set; }
        }

        public class CustomConnectorDestinationProperties : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig, IHaveEntityName, IHaveIdFieldNames, IHaveWriteOperationType
        {
            /// <summary>
            /// IdFieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-idfieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IdFieldNames { get; set; }
            /// <summary>
            /// EntityName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-entityname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntityName { get; set; }
            /// <summary>
            /// WriteOperationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-writeoperationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WriteOperationType { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
            /// <summary>
            /// CustomProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectordestinationproperties.html#cfn-appflow-flow-customconnectordestinationproperties-customproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomProperties { get; set; }
        }

        public class CustomConnectorSourceProperties : Humidifier.Base.BaseSubResource, IHaveEntityName
        {
            /// <summary>
            /// EntityName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectorsourceproperties.html#cfn-appflow-flow-customconnectorsourceproperties-entityname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntityName { get; set; }
            /// <summary>
            /// DataTransferApi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectorsourceproperties.html#cfn-appflow-flow-customconnectorsourceproperties-datatransferapi
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataTransferApi
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.DataTransferApi DataTransferApi { get; set; }
            /// <summary>
            /// CustomProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-customconnectorsourceproperties.html#cfn-appflow-flow-customconnectorsourceproperties-customproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomProperties { get; set; }
        }

        public class DataTransferApi : Humidifier.Base.BaseSubResource, IHaveName, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-datatransferapi.html#cfn-appflow-flow-datatransferapi-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-datatransferapi.html#cfn-appflow-flow-datatransferapi-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic Object { get; set; }
        }

        public class DestinationConnectorProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.S3DestinationProperties S3 { get; set; }
            /// <summary>
            /// CustomConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-customconnector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomConnectorDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.CustomConnectorDestinationProperties CustomConnector { get; set; }
            /// <summary>
            /// Upsolver
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-upsolver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UpsolverDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.UpsolverDestinationProperties Upsolver { get; set; }
            /// <summary>
            /// SAPOData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-sapodata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SAPODataDestinationProperties SAPOData { get; set; }
            /// <summary>
            /// Snowflake
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-snowflake
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnowflakeDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SnowflakeDestinationProperties Snowflake { get; set; }
            /// <summary>
            /// LookoutMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-lookoutmetrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LookoutMetricsDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.LookoutMetricsDestinationProperties LookoutMetrics { get; set; }
            /// <summary>
            /// EventBridge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-eventbridge
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventBridgeDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.EventBridgeDestinationProperties EventBridge { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZendeskDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ZendeskDestinationProperties Zendesk { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarketoDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.MarketoDestinationProperties Marketo { get; set; }
            /// <summary>
            /// Redshift
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-redshift
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.RedshiftDestinationProperties Redshift { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationconnectorproperties.html#cfn-appflow-flow-destinationconnectorproperties-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceDestinationProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SalesforceDestinationProperties Salesforce { get; set; }
        }

        public class DestinationFlowConfig : Humidifier.Base.BaseSubResource, IHaveConnectorType, IHaveConnectorProfileName, IHaveApiVersion
        {
            /// <summary>
            /// ConnectorProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html#cfn-appflow-flow-destinationflowconfig-connectorprofilename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorProfileName { get; set; }
            /// <summary>
            /// ApiVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html#cfn-appflow-flow-destinationflowconfig-apiversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiVersion { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html#cfn-appflow-flow-destinationflowconfig-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorType { get; set; }
            /// <summary>
            /// DestinationConnectorProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-destinationflowconfig.html#cfn-appflow-flow-destinationflowconfig-destinationconnectorproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationConnectorProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.DestinationConnectorProperties DestinationConnectorProperties { get; set; }
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
            public dynamic Object { get; set; }
        }

        public class ErrorHandlingConfig : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-errorhandlingconfig.html#cfn-appflow-flow-errorhandlingconfig-bucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-errorhandlingconfig.html#cfn-appflow-flow-errorhandlingconfig-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPrefix { get; set; }
            /// <summary>
            /// FailOnFirstError
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-errorhandlingconfig.html#cfn-appflow-flow-errorhandlingconfig-failonfirsterror
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic FailOnFirstError { get; set; }
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
            public dynamic Object { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-eventbridgedestinationproperties.html#cfn-appflow-flow-eventbridgedestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
        }

        public class GlueDataCatalog : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveDatabaseName, IHaveTablePrefix
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-gluedatacatalog.html#cfn-appflow-flow-gluedatacatalog-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-gluedatacatalog.html#cfn-appflow-flow-gluedatacatalog-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
            /// <summary>
            /// TablePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-gluedatacatalog.html#cfn-appflow-flow-gluedatacatalog-tableprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TablePrefix { get; set; }
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
            public dynamic Object { get; set; }
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
            public dynamic DatetimeTypeFieldName { get; set; }
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
            public dynamic Object { get; set; }
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
            public dynamic Object { get; set; }
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
            public dynamic Object { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-marketodestinationproperties.html#cfn-appflow-flow-marketodestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
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
            public dynamic Object { get; set; }
        }

        public class MetadataCatalogConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GlueDataCatalog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-metadatacatalogconfig.html#cfn-appflow-flow-metadatacatalogconfig-gluedatacatalog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueDataCatalog
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.GlueDataCatalog GlueDataCatalog { get; set; }
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
            public dynamic Object { get; set; }
        }

        public class PrefixConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PrefixType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-prefixconfig.html#cfn-appflow-flow-prefixconfig-prefixtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrefixType { get; set; }
            /// <summary>
            /// PathPrefixHierarchy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-prefixconfig.html#cfn-appflow-flow-prefixconfig-pathprefixhierarchy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PathPrefixHierarchy { get; set; }
            /// <summary>
            /// PrefixFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-prefixconfig.html#cfn-appflow-flow-prefixconfig-prefixformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrefixFormat { get; set; }
        }

        public class RedshiftDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveBucketPrefix, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig, IHaveIntermediateBucketName
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html#cfn-appflow-flow-redshiftdestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Object { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html#cfn-appflow-flow-redshiftdestinationproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPrefix { get; set; }
            /// <summary>
            /// IntermediateBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html#cfn-appflow-flow-redshiftdestinationproperties-intermediatebucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntermediateBucketName { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-redshiftdestinationproperties.html#cfn-appflow-flow-redshiftdestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
        }

        public class S3DestinationProperties : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3destinationproperties.html#cfn-appflow-flow-s3destinationproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3destinationproperties.html#cfn-appflow-flow-s3destinationproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPrefix { get; set; }
            /// <summary>
            /// S3OutputFormatConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3destinationproperties.html#cfn-appflow-flow-s3destinationproperties-s3outputformatconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3OutputFormatConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig S3OutputFormatConfig { get; set; }
        }

        public class S3InputFormatConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3InputFileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3inputformatconfig.html#cfn-appflow-flow-s3inputformatconfig-s3inputfiletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3InputFileType { get; set; }
        }

        public class S3OutputFormatConfig : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesPrefixConfigPrefixConfig, IHaveFileType, IHaveAppFlowFlowTypesAggregationConfigAggregationConfig
        {
            /// <summary>
            /// PrefixConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html#cfn-appflow-flow-s3outputformatconfig-prefixconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrefixConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.PrefixConfig PrefixConfig { get; set; }
            /// <summary>
            /// FileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html#cfn-appflow-flow-s3outputformatconfig-filetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileType { get; set; }
            /// <summary>
            /// AggregationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html#cfn-appflow-flow-s3outputformatconfig-aggregationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.AggregationConfig AggregationConfig { get; set; }
            /// <summary>
            /// PreserveSourceDataTyping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3outputformatconfig.html#cfn-appflow-flow-s3outputformatconfig-preservesourcedatatyping
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PreserveSourceDataTyping { get; set; }
        }

        public class S3SourceProperties : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix
        {
            /// <summary>
            /// S3InputFormatConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3sourceproperties.html#cfn-appflow-flow-s3sourceproperties-s3inputformatconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3InputFormatConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.S3InputFormatConfig S3InputFormatConfig { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3sourceproperties.html#cfn-appflow-flow-s3sourceproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-s3sourceproperties.html#cfn-appflow-flow-s3sourceproperties-bucketprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPrefix { get; set; }
        }

        public class SAPODataDestinationProperties : Humidifier.Base.BaseSubResource, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig, IHaveIdFieldNames, IHaveWriteOperationType, IHaveObjectPath
        {
            /// <summary>
            /// IdFieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-idfieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IdFieldNames { get; set; }
            /// <summary>
            /// ObjectPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-objectpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectPath { get; set; }
            /// <summary>
            /// WriteOperationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-writeoperationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WriteOperationType { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
            /// <summary>
            /// SuccessResponseHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatadestinationproperties.html#cfn-appflow-flow-sapodatadestinationproperties-successresponsehandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SuccessResponseHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SuccessResponseHandlingConfig SuccessResponseHandlingConfig { get; set; }
        }

        public class SAPODataPaginationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// maxPageSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatapaginationconfig.html#cfn-appflow-flow-sapodatapaginationconfig-maxpagesize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic maxPageSize { get; set; }
        }

        public class SAPODataParallelismConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// maxParallelism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodataparallelismconfig.html#cfn-appflow-flow-sapodataparallelismconfig-maxparallelism
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic maxParallelism { get; set; }
        }

        public class SAPODataSourceProperties : Humidifier.Base.BaseSubResource, IHaveObjectPath
        {
            /// <summary>
            /// ObjectPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatasourceproperties.html#cfn-appflow-flow-sapodatasourceproperties-objectpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectPath { get; set; }
            /// <summary>
            /// paginationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatasourceproperties.html#cfn-appflow-flow-sapodatasourceproperties-paginationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataPaginationConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig paginationConfig { get; set; }
            /// <summary>
            /// parallelismConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sapodatasourceproperties.html#cfn-appflow-flow-sapodatasourceproperties-parallelismconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataParallelismConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig parallelismConfig { get; set; }
        }

        public class SalesforceDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig, IHaveIdFieldNames, IHaveWriteOperationType, IHaveDataTransferApi
        {
            /// <summary>
            /// IdFieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-idfieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IdFieldNames { get; set; }
            /// <summary>
            /// WriteOperationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-writeoperationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WriteOperationType { get; set; }
            /// <summary>
            /// DataTransferApi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-datatransferapi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataTransferApi { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Object { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcedestinationproperties.html#cfn-appflow-flow-salesforcedestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
        }

        public class SalesforceSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveDataTransferApi, IHaveIncludeDeletedRecords, IHaveEnableDynamicFieldUpdate
        {
            /// <summary>
            /// IncludeDeletedRecords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html#cfn-appflow-flow-salesforcesourceproperties-includedeletedrecords
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeDeletedRecords { get; set; }
            /// <summary>
            /// DataTransferApi
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html#cfn-appflow-flow-salesforcesourceproperties-datatransferapi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataTransferApi { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html#cfn-appflow-flow-salesforcesourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Object { get; set; }
            /// <summary>
            /// EnableDynamicFieldUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-salesforcesourceproperties.html#cfn-appflow-flow-salesforcesourceproperties-enabledynamicfieldupdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableDynamicFieldUpdate { get; set; }
        }

        public class ScheduledTriggerProperties : Humidifier.Base.BaseSubResource, IHaveScheduleExpression, IHaveTimeZone, IHaveScheduleOffset, IHaveFirstExecutionFrom, IHaveScheduleEndTime, IHaveScheduleStartTime, IHaveDataPullMode
        {
            /// <summary>
            /// ScheduleEndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-scheduleendtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ScheduleEndTime { get; set; }
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-scheduleexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression { get; set; }
            /// <summary>
            /// FirstExecutionFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-firstexecutionfrom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic FirstExecutionFrom { get; set; }
            /// <summary>
            /// TimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeZone { get; set; }
            /// <summary>
            /// ScheduleStartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-schedulestarttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ScheduleStartTime { get; set; }
            /// <summary>
            /// DataPullMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-datapullmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataPullMode { get; set; }
            /// <summary>
            /// ScheduleOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-scheduleoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ScheduleOffset { get; set; }
            /// <summary>
            /// FlowErrorDeactivationThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-scheduledtriggerproperties.html#cfn-appflow-flow-scheduledtriggerproperties-flowerrordeactivationthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FlowErrorDeactivationThreshold { get; set; }
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
            public dynamic Object { get; set; }
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
            public dynamic Object { get; set; }
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
            public dynamic Object { get; set; }
        }

        public class SnowflakeDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveBucketPrefix, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig, IHaveIntermediateBucketName
        {
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-snowflakedestinationproperties.html#cfn-appflow-flow-snowflakedestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Object { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-snowflakedestinationproperties.html#cfn-appflow-flow-snowflakedestinationproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPrefix { get; set; }
            /// <summary>
            /// IntermediateBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-snowflakedestinationproperties.html#cfn-appflow-flow-snowflakedestinationproperties-intermediatebucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntermediateBucketName { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-snowflakedestinationproperties.html#cfn-appflow-flow-snowflakedestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
        }

        public class SourceConnectorProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Amplitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-amplitude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmplitudeSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.AmplitudeSourceProperties Amplitude { get; set; }
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-s3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3SourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.S3SourceProperties S3 { get; set; }
            /// <summary>
            /// GoogleAnalytics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-googleanalytics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GoogleAnalyticsSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.GoogleAnalyticsSourceProperties GoogleAnalytics { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ServiceNowSourceProperties ServiceNow { get; set; }
            /// <summary>
            /// CustomConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-customconnector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomConnectorSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.CustomConnectorSourceProperties CustomConnector { get; set; }
            /// <summary>
            /// SAPOData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-sapodata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SAPODataSourceProperties SAPOData { get; set; }
            /// <summary>
            /// Pardot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-pardot
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PardotSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.PardotSourceProperties Pardot { get; set; }
            /// <summary>
            /// Veeva
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-veeva
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VeevaSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.VeevaSourceProperties Veeva { get; set; }
            /// <summary>
            /// Trendmicro
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-trendmicro
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrendmicroSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.TrendmicroSourceProperties Trendmicro { get; set; }
            /// <summary>
            /// Datadog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-datadog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatadogSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.DatadogSourceProperties Datadog { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarketoSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.MarketoSourceProperties Marketo { get; set; }
            /// <summary>
            /// Singular
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-singular
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingularSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SingularSourceProperties Singular { get; set; }
            /// <summary>
            /// Slack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-slack
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlackSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SlackSourceProperties Slack { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynatraceSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.DynatraceSourceProperties Dynatrace { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZendeskSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ZendeskSourceProperties Zendesk { get; set; }
            /// <summary>
            /// InforNexus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-infornexus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InforNexusSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.InforNexusSourceProperties InforNexus { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceconnectorproperties.html#cfn-appflow-flow-sourceconnectorproperties-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceSourceProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SalesforceSourceProperties Salesforce { get; set; }
        }

        public class SourceFlowConfig : Humidifier.Base.BaseSubResource, IHaveConnectorType, IHaveConnectorProfileName, IHaveApiVersion
        {
            /// <summary>
            /// ConnectorProfileName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-connectorprofilename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorProfileName { get; set; }
            /// <summary>
            /// ApiVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-apiversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiVersion { get; set; }
            /// <summary>
            /// SourceConnectorProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-sourceconnectorproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SourceConnectorProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.SourceConnectorProperties SourceConnectorProperties { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorType { get; set; }
            /// <summary>
            /// IncrementalPullConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-sourceflowconfig.html#cfn-appflow-flow-sourceflowconfig-incrementalpullconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IncrementalPullConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.IncrementalPullConfig IncrementalPullConfig { get; set; }
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
            public dynamic BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-successresponsehandlingconfig.html#cfn-appflow-flow-successresponsehandlingconfig-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPrefix { get; set; }
        }

        public class Task : Humidifier.Base.BaseSubResource, IHaveTaskType, IHaveSourceFields, IHaveDestinationField
        {
            /// <summary>
            /// SourceFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-sourcefields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SourceFields { get; set; }
            /// <summary>
            /// DestinationField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-destinationfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationField { get; set; }
            /// <summary>
            /// ConnectorOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-connectoroperator
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOperator
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ConnectorOperator ConnectorOperator { get; set; }
            /// <summary>
            /// TaskType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-tasktype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskType { get; set; }
            /// <summary>
            /// TaskProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-task.html#cfn-appflow-flow-task-taskproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TaskPropertiesObject
            /// </summary>
            public List<Humidifier.AppFlow.FlowTypes.TaskPropertiesObject> TaskProperties { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-taskpropertiesobject.html#cfn-appflow-flow-taskpropertiesobject-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
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
            public dynamic Object { get; set; }
        }

        public class TriggerConfig : Humidifier.Base.BaseSubResource, IHaveTriggerType
        {
            /// <summary>
            /// TriggerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-triggerconfig.html#cfn-appflow-flow-triggerconfig-triggertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TriggerType { get; set; }
            /// <summary>
            /// TriggerProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-triggerconfig.html#cfn-appflow-flow-triggerconfig-triggerproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScheduledTriggerProperties
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ScheduledTriggerProperties TriggerProperties { get; set; }
        }

        public class UpsolverDestinationProperties : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolverdestinationproperties.html#cfn-appflow-flow-upsolverdestinationproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolverdestinationproperties.html#cfn-appflow-flow-upsolverdestinationproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPrefix { get; set; }
            /// <summary>
            /// S3OutputFormatConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolverdestinationproperties.html#cfn-appflow-flow-upsolverdestinationproperties-s3outputformatconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: UpsolverS3OutputFormatConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig S3OutputFormatConfig { get; set; }
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
            public Humidifier.AppFlow.FlowTypes.PrefixConfig PrefixConfig { get; set; }
            /// <summary>
            /// FileType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolvers3outputformatconfig.html#cfn-appflow-flow-upsolvers3outputformatconfig-filetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileType { get; set; }
            /// <summary>
            /// AggregationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-upsolvers3outputformatconfig.html#cfn-appflow-flow-upsolvers3outputformatconfig-aggregationconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AggregationConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.AggregationConfig AggregationConfig { get; set; }
        }

        public class VeevaSourceProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveDocumentType
        {
            /// <summary>
            /// IncludeAllVersions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-includeallversions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeAllVersions { get; set; }
            /// <summary>
            /// IncludeRenditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-includerenditions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeRenditions { get; set; }
            /// <summary>
            /// DocumentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-documenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentType { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Object { get; set; }
            /// <summary>
            /// IncludeSourceFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-veevasourceproperties.html#cfn-appflow-flow-veevasourceproperties-includesourcefiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeSourceFiles { get; set; }
        }

        public class ZendeskDestinationProperties : Humidifier.Base.BaseSubResource, IHaveObject, IHaveAppFlowFlowTypesErrorHandlingConfigErrorHandlingConfig, IHaveIdFieldNames, IHaveWriteOperationType
        {
            /// <summary>
            /// IdFieldNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html#cfn-appflow-flow-zendeskdestinationproperties-idfieldnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IdFieldNames { get; set; }
            /// <summary>
            /// WriteOperationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html#cfn-appflow-flow-zendeskdestinationproperties-writeoperationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WriteOperationType { get; set; }
            /// <summary>
            /// Object
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html#cfn-appflow-flow-zendeskdestinationproperties-object
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Object { get; set; }
            /// <summary>
            /// ErrorHandlingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-flow-zendeskdestinationproperties.html#cfn-appflow-flow-zendeskdestinationproperties-errorhandlingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ErrorHandlingConfig
            /// </summary>
            public Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig ErrorHandlingConfig { get; set; }
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
            public dynamic Object { get; set; }
        }
    }
}