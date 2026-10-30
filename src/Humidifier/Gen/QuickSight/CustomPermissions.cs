namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using CustomPermissionsTypes;

    public class CustomPermissions : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAwsAccountId
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.CustomPermissions; }
        public dynamic CustomPermissionsName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Capabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-custompermissions.html#cfn-quicksight-custompermissions-capabilities
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Capabilities
        /// </summary>
        public Humidifier.QuickSight.CustomPermissionsTypes.Capabilities Capabilities { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-custompermissions.html#cfn-quicksight-custompermissions-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-custompermissions.html#cfn-quicksight-custompermissions-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace CustomPermissionsTypes
    {
        public class Capabilities : Humidifier.Base.BaseSubResource, IHaveAction, IHaveTrigger, IHaveTopic, IHaveExtension, IHaveSpace
        {
            /// <summary>
            /// PublishWithoutApproval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-publishwithoutapproval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PublishWithoutApproval { get; set; }
            /// <summary>
            /// InboundEmailTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-inboundemailtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InboundEmailTrigger { get; set; }
            /// <summary>
            /// ShareGoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegooglecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareGoogleCalendarAction { get; set; }
            /// <summary>
            /// UseBoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useboxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseBoxAgentAction { get; set; }
            /// <summary>
            /// UpdateRedshiftManualDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateredshiftmanualdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateRedshiftManualDataSource { get; set; }
            /// <summary>
            /// UseSAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSAPMaterialStockAction { get; set; }
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-s3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateIDCKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateidcknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateIDCKnowledgeBase { get; set; }
            /// <summary>
            /// UseBoxKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useboxknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseBoxKnowledgeBase { get; set; }
            /// <summary>
            /// MondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MondayAction { get; set; }
            /// <summary>
            /// UpdateServiceNowDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateservicenowdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateServiceNowDataSource { get; set; }
            /// <summary>
            /// Space
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-space
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Space { get; set; }
            /// <summary>
            /// UseHuggingFaceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usehuggingfaceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseHuggingFaceAction { get; set; }
            /// <summary>
            /// CreateAndUpdateCanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatecanvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateCanvaAgentAction { get; set; }
            /// <summary>
            /// ShareNewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharenewrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareNewRelicAction { get; set; }
            /// <summary>
            /// AdobeAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-adobeanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdobeAnalyticsDataSource { get; set; }
            /// <summary>
            /// SAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SAPMaterialStockAction { get; set; }
            /// <summary>
            /// ShareAmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareamazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAmazonBedrockARSAction { get; set; }
            /// <summary>
            /// CreateFileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createfiledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateFileDataSource { get; set; }
            /// <summary>
            /// ShareSapHanaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesaphanadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSapHanaDataSource { get; set; }
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-analysis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Analysis { get; set; }
            /// <summary>
            /// ChatAgent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-chatagent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChatAgent { get; set; }
            /// <summary>
            /// OpenSearchDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-opensearchdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OpenSearchDataSource { get; set; }
            /// <summary>
            /// ShareKnowledgeBases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareknowledgebases
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareKnowledgeBases { get; set; }
            /// <summary>
            /// HuggingFaceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-huggingfaceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HuggingFaceAction { get; set; }
            /// <summary>
            /// CreateAndUpdateDataSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatedatasources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateDataSources { get; set; }
            /// <summary>
            /// ShareOracleDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareoracledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareOracleDataSource { get; set; }
            /// <summary>
            /// CreateSPICEDataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createspicedataset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSPICEDataset { get; set; }
            /// <summary>
            /// ShareOneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareonedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareOneDriveAction { get; set; }
            /// <summary>
            /// UseFactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usefactsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseFactSetAction { get; set; }
            /// <summary>
            /// UpdateDremioDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedremiodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateDremioDataSource { get; set; }
            /// <summary>
            /// CreatePayPalDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createpaypaldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatePayPalDataSource { get; set; }
            /// <summary>
            /// ShareMondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareMondayAction { get; set; }
            /// <summary>
            /// CreateSquareDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsquaredatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSquareDataSource { get; set; }
            /// <summary>
            /// AmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AmazonBedrockARSAction { get; set; }
            /// <summary>
            /// UpdateMariaDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatemariadbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateMariaDbDataSource { get; set; }
            /// <summary>
            /// KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KnowledgeBase { get; set; }
            /// <summary>
            /// SharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SharePointAction { get; set; }
            /// <summary>
            /// CreateRedshiftManualDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createredshiftmanualdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateRedshiftManualDataSource { get; set; }
            /// <summary>
            /// UpdateSapHanaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesaphanadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateSapHanaDataSource { get; set; }
            /// <summary>
            /// SandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SandPGlobalEnergyAction { get; set; }
            /// <summary>
            /// CreateAndUpdateComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatecomprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateComprehendAction { get; set; }
            /// <summary>
            /// MongoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mongodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MongoDbDataSource { get; set; }
            /// <summary>
            /// CreateS3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creates3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateS3DataSource { get; set; }
            /// <summary>
            /// UseMCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseMCPAction { get; set; }
            /// <summary>
            /// UpdateS3TablesDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updates3tablesdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateS3TablesDataSource { get; set; }
            /// <summary>
            /// UpdateImpalaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateimpaladatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateImpalaDataSource { get; set; }
            /// <summary>
            /// UseNewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usenewrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseNewRelicAction { get; set; }
            /// <summary>
            /// ShareSAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// UseSharePointKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesharepointknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSharePointKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateOpenAPIAction { get; set; }
            /// <summary>
            /// ShareSqlServerDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesqlserverdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSqlServerDataSource { get; set; }
            /// <summary>
            /// UpdateDb2DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedb2datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateDb2DataSource { get; set; }
            /// <summary>
            /// UseSandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSandPGlobalEnergyAction { get; set; }
            /// <summary>
            /// ExportToPdfInScheduledReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttopdfinscheduledreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExportToPdfInScheduledReports { get; set; }
            /// <summary>
            /// ShareAmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareamazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAmazonBedrockKRSAction { get; set; }
            /// <summary>
            /// CreateRdsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createrdsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateRdsDataSource { get; set; }
            /// <summary>
            /// ShareAsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareasanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAsanaAction { get; set; }
            /// <summary>
            /// CreateAndUpdateDatasets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatedatasets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateDatasets { get; set; }
            /// <summary>
            /// ShareSAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSAPMaterialStockAction { get; set; }
            /// <summary>
            /// SandPGMIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sandpgmiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SandPGMIAction { get; set; }
            /// <summary>
            /// ShareTeradataDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareteradatadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareTeradataDataSource { get; set; }
            /// <summary>
            /// SharePrestoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareprestodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SharePrestoDataSource { get; set; }
            /// <summary>
            /// ShareConfluenceKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareconfluenceknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareConfluenceKnowledgeBase { get; set; }
            /// <summary>
            /// CreateTeradataDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createteradatadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateTeradataDataSource { get; set; }
            /// <summary>
            /// BuildCalculatedFieldWithQ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-buildcalculatedfieldwithq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BuildCalculatedFieldWithQ { get; set; }
            /// <summary>
            /// ShareDashboards
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedashboards
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDashboards { get; set; }
            /// <summary>
            /// ShareTrinoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetrinodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareTrinoDataSource { get; set; }
            /// <summary>
            /// UpdateExasolDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateexasoldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateExasolDataSource { get; set; }
            /// <summary>
            /// UseSAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSAPProductMasterDataAction { get; set; }
            /// <summary>
            /// UseConfluenceKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useconfluenceknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseConfluenceKnowledgeBase { get; set; }
            /// <summary>
            /// UsePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsePagerDutyAction { get; set; }
            /// <summary>
            /// CreateDatabricksDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdatabricksdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateDatabricksDataSource { get; set; }
            /// <summary>
            /// ShareGoogleAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegoogleanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareGoogleAnalyticsDataSource { get; set; }
            /// <summary>
            /// CreateTrinoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createtrinodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateTrinoDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateJiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatejiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateJiraAction { get; set; }
            /// <summary>
            /// CreateAndUpdateQBusinessKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateqbusinessknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateQBusinessKnowledgeBase { get; set; }
            /// <summary>
            /// UseBambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseBambooHRAction { get; set; }
            /// <summary>
            /// UpdateSnowflakeDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesnowflakedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateSnowflakeDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdatePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdatePagerDutyAction { get; set; }
            /// <summary>
            /// IDCKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-idcknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IDCKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateGoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategooglecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateGoogleCalendarAction { get; set; }
            /// <summary>
            /// CreateAndUpdateMCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateMCPAction { get; set; }
            /// <summary>
            /// ShareAmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareamazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAmazonSThreeAction { get; set; }
            /// <summary>
            /// ExportToCsvInScheduledReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttocsvinscheduledreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExportToCsvInScheduledReports { get; set; }
            /// <summary>
            /// SAPPhysicalInventoryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapphysicalinventoryaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SAPPhysicalInventoryAction { get; set; }
            /// <summary>
            /// CreateAndUpdateHuggingFaceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatehuggingfaceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateHuggingFaceAction { get; set; }
            /// <summary>
            /// UseSAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// JiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-jiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JiraAction { get; set; }
            /// <summary>
            /// UpdateFileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatefiledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateFileDataSource { get; set; }
            /// <summary>
            /// UpdatePostgreSqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatepostgresqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatePostgreSqlDataSource { get; set; }
            /// <summary>
            /// ShareMariaDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemariadbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareMariaDbDataSource { get; set; }
            /// <summary>
            /// UpdateTeradataDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateteradatadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateTeradataDataSource { get; set; }
            /// <summary>
            /// CreateDb2DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdb2datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateDb2DataSource { get; set; }
            /// <summary>
            /// GoogleAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googleanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GoogleAnalyticsDataSource { get; set; }
            /// <summary>
            /// ShareHubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharehubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareHubspotAction { get; set; }
            /// <summary>
            /// ShareSAPPhysicalInventoryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapphysicalinventoryaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSAPPhysicalInventoryAction { get; set; }
            /// <summary>
            /// UseQBusinessKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useqbusinessknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseQBusinessKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateOneDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateonedriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateOneDriveKnowledgeBase { get; set; }
            /// <summary>
            /// ExasolDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exasoldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExasolDataSource { get; set; }
            /// <summary>
            /// CreateMongoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createmongodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateMongoDbDataSource { get; set; }
            /// <summary>
            /// UseWebCrawlerKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usewebcrawlerknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseWebCrawlerKnowledgeBase { get; set; }
            /// <summary>
            /// CreateSharedFolders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsharedfolders
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSharedFolders { get; set; }
            /// <summary>
            /// ShareBambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharebamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareBambooHRAction { get; set; }
            /// <summary>
            /// CreateExasolDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createexasoldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateExasolDataSource { get; set; }
            /// <summary>
            /// ZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-zendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ZendeskAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateslackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSlackAction { get; set; }
            /// <summary>
            /// UseHubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usehubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseHubspotAction { get; set; }
            /// <summary>
            /// UpdateMongoAtlasDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatemongoatlasdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateMongoAtlasDataSource { get; set; }
            /// <summary>
            /// Automate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-automate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Automate { get; set; }
            /// <summary>
            /// ShareBoxKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareboxknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareBoxKnowledgeBase { get; set; }
            /// <summary>
            /// UseOutlookAddInExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useoutlookaddinextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseOutlookAddInExtension { get; set; }
            /// <summary>
            /// ExportToPdf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttopdf
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExportToPdf { get; set; }
            /// <summary>
            /// ShareOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareOpenAPIAction { get; set; }
            /// <summary>
            /// UpdateGoogleAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updategoogleanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateGoogleAnalyticsDataSource { get; set; }
            /// <summary>
            /// UseOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseOpenAPIAction { get; set; }
            /// <summary>
            /// SharePostgreSqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepostgresqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SharePostgreSqlDataSource { get; set; }
            /// <summary>
            /// ShareJiraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharejiradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareJiraDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateLinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatelinearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateLinearAction { get; set; }
            /// <summary>
            /// UseBedrockManagedKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebedrockmanagedknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseBedrockManagedKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateS3KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdates3knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateS3KnowledgeBase { get; set; }
            /// <summary>
            /// UseNotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usenotionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseNotionAction { get; set; }
            /// <summary>
            /// CreateAndUpdateFactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatefactsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateFactSetAction { get; set; }
            /// <summary>
            /// UpdateRedshiftAutoDiscoveredDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateredshiftautodiscovereddatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateRedshiftAutoDiscoveredDataSource { get; set; }
            /// <summary>
            /// CreateDremioDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdremiodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateDremioDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateMSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemsteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateMSTeamsAction { get; set; }
            /// <summary>
            /// ShareAthenaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareathenadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAthenaDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateSharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSharePointAction { get; set; }
            /// <summary>
            /// TimestreamDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-timestreamdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimestreamDataSource { get; set; }
            /// <summary>
            /// PrintReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-printreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrintReports { get; set; }
            /// <summary>
            /// CreateS3AnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creates3analyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateS3AnalyticsDataSource { get; set; }
            /// <summary>
            /// FileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-filedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileDataSource { get; set; }
            /// <summary>
            /// UpdateAdobeAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateadobeanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateAdobeAnalyticsDataSource { get; set; }
            /// <summary>
            /// ShareMongoAtlasDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemongoatlasdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareMongoAtlasDataSource { get; set; }
            /// <summary>
            /// CreateGitHubDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creategithubdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateGitHubDataSource { get; set; }
            /// <summary>
            /// SnowflakeDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-snowflakedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnowflakeDataSource { get; set; }
            /// <summary>
            /// CreateDocumentDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdocumentdbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateDocumentDbDataSource { get; set; }
            /// <summary>
            /// UsePowerpointAddInExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usepowerpointaddinextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsePowerpointAddInExtension { get; set; }
            /// <summary>
            /// UpdateRadiantDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateradiantdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateRadiantDataSource { get; set; }
            /// <summary>
            /// UseGoogleDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegoogledriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseGoogleDriveKnowledgeBase { get; set; }
            /// <summary>
            /// ShareSmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesmartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSmartsheetAction { get; set; }
            /// <summary>
            /// ShareHuggingFaceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharehuggingfaceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareHuggingFaceAction { get; set; }
            /// <summary>
            /// ShareConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareconfluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareConfluenceAction { get; set; }
            /// <summary>
            /// RenameSharedFolders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-renamesharedfolders
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RenameSharedFolders { get; set; }
            /// <summary>
            /// ComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-comprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComprehendMedicalAction { get; set; }
            /// <summary>
            /// CreateSparkDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsparkdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSparkDataSource { get; set; }
            /// <summary>
            /// ShareQBusinessKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareqbusinessknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareQBusinessKnowledgeBase { get; set; }
            /// <summary>
            /// GoogleBigQueryDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googlebigquerydatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GoogleBigQueryDataSource { get; set; }
            /// <summary>
            /// SparkDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sparkdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SparkDataSource { get; set; }
            /// <summary>
            /// ShareDocumentDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedocumentdbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDocumentDbDataSource { get; set; }
            /// <summary>
            /// ShareMSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemsteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareMSTeamsAction { get; set; }
            /// <summary>
            /// UseAmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseAmazonBedrockKRSAction { get; set; }
            /// <summary>
            /// ShareFactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharefactsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareFactSetAction { get; set; }
            /// <summary>
            /// ShareMCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareMCPAction { get; set; }
            /// <summary>
            /// RedshiftAutoDiscoveredDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-redshiftautodiscovereddatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedshiftAutoDiscoveredDataSource { get; set; }
            /// <summary>
            /// UseExcelAddInExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useexceladdinextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseExcelAddInExtension { get; set; }
            /// <summary>
            /// ShareSAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSAPProductMasterDataAction { get; set; }
            /// <summary>
            /// AmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AmazonBedrockKRSAction { get; set; }
            /// <summary>
            /// BoxKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-boxknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BoxKnowledgeBase { get; set; }
            /// <summary>
            /// AuroraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-auroradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuroraDataSource { get; set; }
            /// <summary>
            /// CreatePostgreSqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createpostgresqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatePostgreSqlDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateSandPGMIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesandpgmiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSandPGMIAction { get; set; }
            /// <summary>
            /// ShareAmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareamazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAmazonBedrockFSAction { get; set; }
            /// <summary>
            /// MCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MCPAction { get; set; }
            /// <summary>
            /// LinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-linearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LinearAction { get; set; }
            /// <summary>
            /// CreateAndUpdateNotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatenotionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateNotionAction { get; set; }
            /// <summary>
            /// MariaDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mariadbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MariaDbDataSource { get; set; }
            /// <summary>
            /// UpdateJiraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatejiradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateJiraDataSource { get; set; }
            /// <summary>
            /// DremioDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-dremiodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DremioDataSource { get; set; }
            /// <summary>
            /// Flow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-flow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Flow { get; set; }
            /// <summary>
            /// MSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-msexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MSExchangeAction { get; set; }
            /// <summary>
            /// UpdateMongoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatemongodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateMongoDbDataSource { get; set; }
            /// <summary>
            /// UseS3KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-uses3knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseS3KnowledgeBase { get; set; }
            /// <summary>
            /// ShareGitHubDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegithubdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareGitHubDataSource { get; set; }
            /// <summary>
            /// UseAsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useasanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseAsanaAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSandPGlobalEnergyAction { get; set; }
            /// <summary>
            /// UseSlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useslackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSlackAction { get; set; }
            /// <summary>
            /// BoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-boxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BoxAgentAction { get; set; }
            /// <summary>
            /// UseZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usezendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseZendeskAction { get; set; }
            /// <summary>
            /// CreateGoogleAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creategoogleanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateGoogleAnalyticsDataSource { get; set; }
            /// <summary>
            /// UseServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useservicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseServiceNowAction { get; set; }
            /// <summary>
            /// CreateSpaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createspaces
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSpaces { get; set; }
            /// <summary>
            /// CreateSnowflakeDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsnowflakedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSnowflakeDataSource { get; set; }
            /// <summary>
            /// UseAmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseAmazonSThreeAction { get; set; }
            /// <summary>
            /// SAPBusinessPartnerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapbusinesspartneraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SAPBusinessPartnerAction { get; set; }
            /// <summary>
            /// UseSAPPhysicalInventoryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapphysicalinventoryaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSAPPhysicalInventoryAction { get; set; }
            /// <summary>
            /// ShareRedshiftAutoDiscoveredDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareredshiftautodiscovereddatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareRedshiftAutoDiscoveredDataSource { get; set; }
            /// <summary>
            /// StarburstDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-starburstdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StarburstDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateAmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateAmazonSThreeAction { get; set; }
            /// <summary>
            /// UpdateDenodoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedenododatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateDenodoDataSource { get; set; }
            /// <summary>
            /// ShareCanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharecanvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareCanvaAgentAction { get; set; }
            /// <summary>
            /// CreateTwitterDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createtwitterdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateTwitterDataSource { get; set; }
            /// <summary>
            /// UpdateDocumentDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedocumentdbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateDocumentDbDataSource { get; set; }
            /// <summary>
            /// ShareAdobeAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareadobeanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAdobeAnalyticsDataSource { get; set; }
            /// <summary>
            /// S3AnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-s3analyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3AnalyticsDataSource { get; set; }
            /// <summary>
            /// UpdateTrinoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatetrinodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateTrinoDataSource { get; set; }
            /// <summary>
            /// CreateTimestreamDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createtimestreamdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateTimestreamDataSource { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-trigger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Trigger { get; set; }
            /// <summary>
            /// UpdateGoogleSheetsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updategooglesheetsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateGoogleSheetsDataSource { get; set; }
            /// <summary>
            /// ShareDb2DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedb2datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDb2DataSource { get; set; }
            /// <summary>
            /// UpdateSqlServerDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesqlserverdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateSqlServerDataSource { get; set; }
            /// <summary>
            /// UseOneDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useonedriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseOneDriveKnowledgeBase { get; set; }
            /// <summary>
            /// UseSmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesmartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSmartsheetAction { get; set; }
            /// <summary>
            /// CreateSqlServerDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsqlserverdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSqlServerDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateBambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatebamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateBambooHRAction { get; set; }
            /// <summary>
            /// SquareDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-squaredatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SquareDataSource { get; set; }
            /// <summary>
            /// ShareSandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSandPGlobalEnergyAction { get; set; }
            /// <summary>
            /// UseComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usecomprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseComprehendAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSAPMaterialStockAction { get; set; }
            /// <summary>
            /// OneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-onedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OneDriveAction { get; set; }
            /// <summary>
            /// CreateAndUpdateThemes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatethemes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateThemes { get; set; }
            /// <summary>
            /// UseSAPBusinessPartnerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapbusinesspartneraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSAPBusinessPartnerAction { get; set; }
            /// <summary>
            /// ShareMongoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemongodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareMongoDbDataSource { get; set; }
            /// <summary>
            /// ViewAccountSPICECapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-viewaccountspicecapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ViewAccountSPICECapacity { get; set; }
            /// <summary>
            /// CreateAndUpdateGenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategenerichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateGenericHTTPAction { get; set; }
            /// <summary>
            /// CreateAndUpdateAmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateAmazonBedrockFSAction { get; set; }
            /// <summary>
            /// NotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-notionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotionAction { get; set; }
            /// <summary>
            /// UpdateAthenaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateathenadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateAthenaDataSource { get; set; }
            /// <summary>
            /// GoogleDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googledriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GoogleDriveKnowledgeBase { get; set; }
            /// <summary>
            /// BedrockManagedKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-bedrockmanagedknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BedrockManagedKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateAsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateasanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateAsanaAction { get; set; }
            /// <summary>
            /// CreateMariaDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createmariadbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateMariaDbDataSource { get; set; }
            /// <summary>
            /// UpdateTimestreamDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatetimestreamdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateTimestreamDataSource { get; set; }
            /// <summary>
            /// PagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-pagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PagerDutyAction { get; set; }
            /// <summary>
            /// MongoAtlasDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mongoatlasdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MongoAtlasDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateMSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemsexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateMSExchangeAction { get; set; }
            /// <summary>
            /// Topic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-topic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Topic { get; set; }
            /// <summary>
            /// CreateAndUpdateTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateTextractAction { get; set; }
            /// <summary>
            /// ShareS3KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shares3knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareS3KnowledgeBase { get; set; }
            /// <summary>
            /// OracleDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-oracledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OracleDataSource { get; set; }
            /// <summary>
            /// TwitterDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-twitterdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TwitterDataSource { get; set; }
            /// <summary>
            /// UpdateRdsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updaterdsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateRdsDataSource { get; set; }
            /// <summary>
            /// ShareDataSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedatasources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDataSources { get; set; }
            /// <summary>
            /// ShareGithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegithubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareGithubAction { get; set; }
            /// <summary>
            /// ShareTimestreamDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetimestreamdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareTimestreamDataSource { get; set; }
            /// <summary>
            /// UseAmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseAmazonBedrockARSAction { get; set; }
            /// <summary>
            /// CreateChatAgents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createchatagents
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateChatAgents { get; set; }
            /// <summary>
            /// ShareS3AnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shares3analyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareS3AnalyticsDataSource { get; set; }
            /// <summary>
            /// RedshiftManualDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-redshiftmanualdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedshiftManualDataSource { get; set; }
            /// <summary>
            /// ShareOneDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareonedriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareOneDriveKnowledgeBase { get; set; }
            /// <summary>
            /// OneDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-onedriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OneDriveKnowledgeBase { get; set; }
            /// <summary>
            /// ShareBedrockManagedKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharebedrockmanagedknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareBedrockManagedKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateWebCrawlerKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatewebcrawlerknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateWebCrawlerKnowledgeBase { get; set; }
            /// <summary>
            /// UseIDCKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useidcknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseIDCKnowledgeBase { get; set; }
            /// <summary>
            /// ShareComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharecomprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareComprehendAction { get; set; }
            /// <summary>
            /// UpdateOpenSearchDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateopensearchdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateOpenSearchDataSource { get; set; }
            /// <summary>
            /// UseTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseTextractAction { get; set; }
            /// <summary>
            /// UseCanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usecanvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseCanvaAgentAction { get; set; }
            /// <summary>
            /// DynamoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-dynamodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DynamoDbDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateBoxKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateboxknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateBoxKnowledgeBase { get; set; }
            /// <summary>
            /// CreateDashboardExecutiveSummaryWithQ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdashboardexecutivesummarywithq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateDashboardExecutiveSummaryWithQ { get; set; }
            /// <summary>
            /// ShareComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharecomprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareComprehendMedicalAction { get; set; }
            /// <summary>
            /// ShareSalesforceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesalesforceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSalesforceAction { get; set; }
            /// <summary>
            /// UseAgentWebSearch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useagentwebsearch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseAgentWebSearch { get; set; }
            /// <summary>
            /// ManageSharedFolders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-managesharedfolders
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManageSharedFolders { get; set; }
            /// <summary>
            /// ShareGenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegenerichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareGenericHTTPAction { get; set; }
            /// <summary>
            /// ShareSpaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharespaces
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSpaces { get; set; }
            /// <summary>
            /// SlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-slackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlackAction { get; set; }
            /// <summary>
            /// UpdateGoogleBigQueryDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updategooglebigquerydatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateGoogleBigQueryDataSource { get; set; }
            /// <summary>
            /// PostgreSqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-postgresqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PostgreSqlDataSource { get; set; }
            /// <summary>
            /// TeradataDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-teradatadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TeradataDataSource { get; set; }
            /// <summary>
            /// ShareFileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharefiledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareFileDataSource { get; set; }
            /// <summary>
            /// ShareJiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharejiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareJiraAction { get; set; }
            /// <summary>
            /// CreateGoogleBigQueryDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creategooglebigquerydatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateGoogleBigQueryDataSource { get; set; }
            /// <summary>
            /// ConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-confluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfluenceAction { get; set; }
            /// <summary>
            /// UpdatePrestoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateprestodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatePrestoDataSource { get; set; }
            /// <summary>
            /// ServiceNowDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-servicenowdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceNowDataSource { get; set; }
            /// <summary>
            /// ShareSquareDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesquaredatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSquareDataSource { get; set; }
            /// <summary>
            /// PayPalDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-paypaldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PayPalDataSource { get; set; }
            /// <summary>
            /// OpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-openapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OpenAPIAction { get; set; }
            /// <summary>
            /// CreateSapHanaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsaphanadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSapHanaDataSource { get; set; }
            /// <summary>
            /// CreateOracleDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createoracledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateOracleDataSource { get; set; }
            /// <summary>
            /// ShareDatasets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedatasets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDatasets { get; set; }
            /// <summary>
            /// UseGoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegooglecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseGoogleCalendarAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSharePointKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesharepointknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSharePointKnowledgeBase { get; set; }
            /// <summary>
            /// UpdateAuroraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateauroradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateAuroraDataSource { get; set; }
            /// <summary>
            /// ShareLinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharelinearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareLinearAction { get; set; }
            /// <summary>
            /// ShareIDCKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareidcknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareIDCKnowledgeBase { get; set; }
            /// <summary>
            /// UseSalesforceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesalesforceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSalesforceAction { get; set; }
            /// <summary>
            /// UseLinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-uselinearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseLinearAction { get; set; }
            /// <summary>
            /// IntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-intercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntercomAction { get; set; }
            /// <summary>
            /// CreateAndUpdateNewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatenewrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateNewRelicAction { get; set; }
            /// <summary>
            /// UseComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usecomprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseComprehendMedicalAction { get; set; }
            /// <summary>
            /// AmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AmazonBedrockFSAction { get; set; }
            /// <summary>
            /// IncludeContentInScheduledReportsEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-includecontentinscheduledreportsemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IncludeContentInScheduledReportsEmail { get; set; }
            /// <summary>
            /// CreateAndUpdateConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateconfluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateConfluenceAction { get; set; }
            /// <summary>
            /// Dashboard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-dashboard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Dashboard { get; set; }
            /// <summary>
            /// Apps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-apps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Apps { get; set; }
            /// <summary>
            /// ShareSandPGMIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesandpgmiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSandPGMIAction { get; set; }
            /// <summary>
            /// SharePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SharePagerDutyAction { get; set; }
            /// <summary>
            /// UpdateMySqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatemysqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateMySqlDataSource { get; set; }
            /// <summary>
            /// CreateRedshiftAutoDiscoveredDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createredshiftautodiscovereddatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateRedshiftAutoDiscoveredDataSource { get; set; }
            /// <summary>
            /// WebCrawlerKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-webcrawlerknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebCrawlerKnowledgeBase { get; set; }
            /// <summary>
            /// JiraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-jiradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JiraDataSource { get; set; }
            /// <summary>
            /// AsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-asanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AsanaAction { get; set; }
            /// <summary>
            /// UseWordAddInExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usewordaddinextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseWordAddInExtension { get; set; }
            /// <summary>
            /// QuickEventTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-quickeventtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QuickEventTrigger { get; set; }
            /// <summary>
            /// CreateAndUpdateDashboardEmailReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatedashboardemailreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateDashboardEmailReports { get; set; }
            /// <summary>
            /// GitHubDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-githubdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GitHubDataSource { get; set; }
            /// <summary>
            /// ShareTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareTextractAction { get; set; }
            /// <summary>
            /// CreateAndUpdateZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatezendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateZendeskAction { get; set; }
            /// <summary>
            /// CreateServiceNowDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createservicenowdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateServiceNowDataSource { get; set; }
            /// <summary>
            /// ShareDenodoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedenododatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDenodoDataSource { get; set; }
            /// <summary>
            /// SubscribeDashboardEmailReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-subscribedashboardemailreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubscribeDashboardEmailReports { get; set; }
            /// <summary>
            /// ShareDatabricksDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedatabricksdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDatabricksDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateservicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateServiceNowAction { get; set; }
            /// <summary>
            /// TrinoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-trinodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrinoDataSource { get; set; }
            /// <summary>
            /// TextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-textractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextractAction { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// AccessAppsNativeDataStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-accessappsnativedatastore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccessAppsNativeDataStore { get; set; }
            /// <summary>
            /// S3TablesDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-s3tablesdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3TablesDataSource { get; set; }
            /// <summary>
            /// FactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-factsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FactSetAction { get; set; }
            /// <summary>
            /// GoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googlecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GoogleCalendarAction { get; set; }
            /// <summary>
            /// CreateAndUpdateBoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateboxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateBoxAgentAction { get; set; }
            /// <summary>
            /// UseMSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemsexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseMSExchangeAction { get; set; }
            /// <summary>
            /// GoogleSheetsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googlesheetsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GoogleSheetsDataSource { get; set; }
            /// <summary>
            /// UpdateS3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updates3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateS3DataSource { get; set; }
            /// <summary>
            /// ShareMySqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemysqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareMySqlDataSource { get; set; }
            /// <summary>
            /// MSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-msteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MSTeamsAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPBusinessPartnerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapbusinesspartneraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSAPBusinessPartnerAction { get; set; }
            /// <summary>
            /// ConfluenceKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-confluenceknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfluenceKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAuroraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createauroradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAuroraDataSource { get; set; }
            /// <summary>
            /// ShareRadiantDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareradiantdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareRadiantDataSource { get; set; }
            /// <summary>
            /// BambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-bamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BambooHRAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPPhysicalInventoryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapphysicalinventoryaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSAPPhysicalInventoryAction { get; set; }
            /// <summary>
            /// SalesforceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-salesforcedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SalesforceDataSource { get; set; }
            /// <summary>
            /// AddOrRunAnomalyDetectionForAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-addorrunanomalydetectionforanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AddOrRunAnomalyDetectionForAnalyses { get; set; }
            /// <summary>
            /// Extension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-extension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Extension { get; set; }
            /// <summary>
            /// ShareAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAnalyses { get; set; }
            /// <summary>
            /// UseGithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegithubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseGithubAction { get; set; }
            /// <summary>
            /// ServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-servicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceNowAction { get; set; }
            /// <summary>
            /// UpdateDatabricksDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedatabricksdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateDatabricksDataSource { get; set; }
            /// <summary>
            /// DocumentDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-documentdbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DocumentDbDataSource { get; set; }
            /// <summary>
            /// UseAmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseAmazonBedrockFSAction { get; set; }
            /// <summary>
            /// ShareImpalaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareimpaladatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareImpalaDataSource { get; set; }
            /// <summary>
            /// UpdateGitHubDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updategithubdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateGitHubDataSource { get; set; }
            /// <summary>
            /// Db2DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-db2datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Db2DataSource { get; set; }
            /// <summary>
            /// CreateSalesforceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsalesforcedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateSalesforceDataSource { get; set; }
            /// <summary>
            /// NewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-newrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NewRelicAction { get; set; }
            /// <summary>
            /// ShareTwitterDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetwitterdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareTwitterDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateIntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateintercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateIntercomAction { get; set; }
            /// <summary>
            /// UpdateStarburstDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatestarburstdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateStarburstDataSource { get; set; }
            /// <summary>
            /// SAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// UpdateSquareDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesquaredatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateSquareDataSource { get; set; }
            /// <summary>
            /// ShareChatAgents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharechatagents
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareChatAgents { get; set; }
            /// <summary>
            /// CreateImpalaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createimpaladatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateImpalaDataSource { get; set; }
            /// <summary>
            /// ShareStarburstDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharestarburstdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareStarburstDataSource { get; set; }
            /// <summary>
            /// ShareServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareservicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareServiceNowAction { get; set; }
            /// <summary>
            /// ApproveFlowShareRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-approveflowsharerequests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApproveFlowShareRequests { get; set; }
            /// <summary>
            /// ExportToExcelInScheduledReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttoexcelinscheduledreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExportToExcelInScheduledReports { get; set; }
            /// <summary>
            /// UseSharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSharePointAction { get; set; }
            /// <summary>
            /// ShareSalesforceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesalesforcedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSalesforceDataSource { get; set; }
            /// <summary>
            /// ShareSAPBusinessPartnerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapbusinesspartneraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSAPBusinessPartnerAction { get; set; }
            /// <summary>
            /// SAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SAPProductMasterDataAction { get; set; }
            /// <summary>
            /// ComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-comprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComprehendAction { get; set; }
            /// <summary>
            /// ShareGoogleSheetsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegooglesheetsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareGoogleSheetsDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateHubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatehubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateHubspotAction { get; set; }
            /// <summary>
            /// UseSandPGMIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesandpgmiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseSandPGMIAction { get; set; }
            /// <summary>
            /// UseIntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useintercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseIntercomAction { get; set; }
            /// <summary>
            /// CreatePrestoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createprestodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreatePrestoDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateMondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateMondayAction { get; set; }
            /// <summary>
            /// ShareSparkDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesparkdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSparkDataSource { get; set; }
            /// <summary>
            /// CreateMySqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createmysqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateMySqlDataSource { get; set; }
            /// <summary>
            /// CreateMongoAtlasDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createmongoatlasdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateMongoAtlasDataSource { get; set; }
            /// <summary>
            /// UseGenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegenerichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseGenericHTTPAction { get; set; }
            /// <summary>
            /// SqlServerDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sqlserverdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SqlServerDataSource { get; set; }
            /// <summary>
            /// EditVisualWithQ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-editvisualwithq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EditVisualWithQ { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSAPProductMasterDataAction { get; set; }
            /// <summary>
            /// SharePointKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepointknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SharePointKnowledgeBase { get; set; }
            /// <summary>
            /// InvokeAppsAIInference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-invokeappsaiinference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvokeAppsAIInference { get; set; }
            /// <summary>
            /// ShareZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharezendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareZendeskAction { get; set; }
            /// <summary>
            /// ShareIntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareintercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareIntercomAction { get; set; }
            /// <summary>
            /// ShareDynamoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedynamodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDynamoDbDataSource { get; set; }
            /// <summary>
            /// GenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-generichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GenericHTTPAction { get; set; }
            /// <summary>
            /// Research
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-research
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Research { get; set; }
            /// <summary>
            /// SapHanaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-saphanadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SapHanaDataSource { get; set; }
            /// <summary>
            /// UseBrowserExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebrowserextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseBrowserExtension { get; set; }
            /// <summary>
            /// QBusinessKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-qbusinessknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QBusinessKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateAmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateAmazonBedrockKRSAction { get; set; }
            /// <summary>
            /// CreateGoogleSheetsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creategooglesheetsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateGoogleSheetsDataSource { get; set; }
            /// <summary>
            /// UseBedrockModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebedrockmodels
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseBedrockModels { get; set; }
            /// <summary>
            /// CreateAndUpdateAmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateAmazonBedrockARSAction { get; set; }
            /// <summary>
            /// CreateAndUpdateThresholdAlerts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatethresholdalerts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateThresholdAlerts { get; set; }
            /// <summary>
            /// UpdateDynamoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedynamodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateDynamoDbDataSource { get; set; }
            /// <summary>
            /// S3KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-s3knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3KnowledgeBase { get; set; }
            /// <summary>
            /// HubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-hubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HubspotAction { get; set; }
            /// <summary>
            /// CreateStarburstDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createstarburstdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateStarburstDataSource { get; set; }
            /// <summary>
            /// RdsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-rdsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RdsDataSource { get; set; }
            /// <summary>
            /// PrestoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-prestodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrestoDataSource { get; set; }
            /// <summary>
            /// ShareSnowflakeDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesnowflakedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSnowflakeDataSource { get; set; }
            /// <summary>
            /// UseOneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useonedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseOneDriveAction { get; set; }
            /// <summary>
            /// ExportToExcel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttoexcel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExportToExcel { get; set; }
            /// <summary>
            /// ShareOpenSearchDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareopensearchdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareOpenSearchDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateGithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategithubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateGithubAction { get; set; }
            /// <summary>
            /// ShareS3TablesDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shares3tablesdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareS3TablesDataSource { get; set; }
            /// <summary>
            /// ShareSlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareslackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSlackAction { get; set; }
            /// <summary>
            /// CreateAndUpdateGoogleDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategoogledriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateGoogleDriveKnowledgeBase { get; set; }
            /// <summary>
            /// UpdateTwitterDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatetwitterdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateTwitterDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateSmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesmartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSmartsheetAction { get; set; }
            /// <summary>
            /// ShareBoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareboxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareBoxAgentAction { get; set; }
            /// <summary>
            /// ShareGoogleBigQueryDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegooglebigquerydatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareGoogleBigQueryDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateOneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateonedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateOneDriveAction { get; set; }
            /// <summary>
            /// UpdateS3AnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updates3analyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateS3AnalyticsDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateKnowledgeBases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateknowledgebases
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateKnowledgeBases { get; set; }
            /// <summary>
            /// UpdatePayPalDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatepaypaldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdatePayPalDataSource { get; set; }
            /// <summary>
            /// ShareServiceNowDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareservicenowdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareServiceNowDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateApps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateapps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateApps { get; set; }
            /// <summary>
            /// ShareDremioDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedremiodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareDremioDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateBedrockManagedKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatebedrockmanagedknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateBedrockManagedKnowledgeBase { get; set; }
            /// <summary>
            /// UseConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useconfluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseConfluenceAction { get; set; }
            /// <summary>
            /// ImpalaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-impaladatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImpalaDataSource { get; set; }
            /// <summary>
            /// CreateOpenSearchDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createopensearchdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateOpenSearchDataSource { get; set; }
            /// <summary>
            /// AmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AmazonSThreeAction { get; set; }
            /// <summary>
            /// ShareRedshiftManualDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareredshiftmanualdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareRedshiftManualDataSource { get; set; }
            /// <summary>
            /// SharePayPalDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepaypaldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SharePayPalDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// UseMondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseMondayAction { get; set; }
            /// <summary>
            /// UseJiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usejiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseJiraAction { get; set; }
            /// <summary>
            /// CreateAthenaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createathenadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAthenaDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatecomprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateComprehendMedicalAction { get; set; }
            /// <summary>
            /// UseMSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemsteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UseMSTeamsAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSalesforceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesalesforceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateSalesforceAction { get; set; }
            /// <summary>
            /// PerformFlowUiTask
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-performflowuitask
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PerformFlowUiTask { get; set; }
            /// <summary>
            /// ShareGoogleDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegoogledriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareGoogleDriveKnowledgeBase { get; set; }
            /// <summary>
            /// CreateS3TablesDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creates3tablesdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateS3TablesDataSource { get; set; }
            /// <summary>
            /// ShareSharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSharePointAction { get; set; }
            /// <summary>
            /// RadiantDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-radiantdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RadiantDataSource { get; set; }
            /// <summary>
            /// ShareWebCrawlerKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharewebcrawlerknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareWebCrawlerKnowledgeBase { get; set; }
            /// <summary>
            /// MySqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mysqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MySqlDataSource { get; set; }
            /// <summary>
            /// ShareExasolDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareexasoldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareExasolDataSource { get; set; }
            /// <summary>
            /// ShareS3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shares3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareS3DataSource { get; set; }
            /// <summary>
            /// SmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-smartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SmartsheetAction { get; set; }
            /// <summary>
            /// CreateDenodoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdenododatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateDenodoDataSource { get; set; }
            /// <summary>
            /// CreateDynamoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdynamodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateDynamoDbDataSource { get; set; }
            /// <summary>
            /// ShareRdsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharerdsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareRdsDataSource { get; set; }
            /// <summary>
            /// ShareApps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareapps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareApps { get; set; }
            /// <summary>
            /// ShareMSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemsexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareMSExchangeAction { get; set; }
            /// <summary>
            /// CreateAdobeAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createadobeanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAdobeAnalyticsDataSource { get; set; }
            /// <summary>
            /// DenodoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-denododatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DenodoDataSource { get; set; }
            /// <summary>
            /// CanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-canvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CanvaAgentAction { get; set; }
            /// <summary>
            /// GithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-githubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GithubAction { get; set; }
            /// <summary>
            /// ScheduleTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-scheduletrigger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleTrigger { get; set; }
            /// <summary>
            /// UpdateSalesforceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesalesforcedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateSalesforceDataSource { get; set; }
            /// <summary>
            /// UpdateSparkDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesparkdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateSparkDataSource { get; set; }
            /// <summary>
            /// CreateRadiantDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createradiantdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateRadiantDataSource { get; set; }
            /// <summary>
            /// AthenaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-athenadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AthenaDataSource { get; set; }
            /// <summary>
            /// UpdateOracleDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateoracledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateOracleDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateConfluenceKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateconfluenceknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateAndUpdateConfluenceKnowledgeBase { get; set; }
            /// <summary>
            /// ShareAuroraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareauroradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareAuroraDataSource { get; set; }
            /// <summary>
            /// ShareSharePointKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesharepointknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareSharePointKnowledgeBase { get; set; }
            /// <summary>
            /// ExportToCsv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttocsv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExportToCsv { get; set; }
            /// <summary>
            /// DatabricksDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-databricksdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabricksDataSource { get; set; }
            /// <summary>
            /// CreateJiraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createjiradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CreateJiraDataSource { get; set; }
            /// <summary>
            /// SalesforceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-salesforceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SalesforceAction { get; set; }
            /// <summary>
            /// ShareNotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharenotionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareNotionAction { get; set; }
        }
    }
}