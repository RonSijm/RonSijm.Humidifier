namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using CustomPermissionsTypes;

    public class CustomPermissions : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCustomPermissionsName, IHaveQuickSightCustomPermissionsTypesCapabilitiesCapabilities, IHaveAwsAccountId
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.CustomPermissions; }
        public Union<string, BaseFunction>? CustomPermissionsName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Capabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-custompermissions.html#cfn-quicksight-custompermissions-capabilities
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Capabilities
        /// </summary>
        public Union<Humidifier.QuickSight.CustomPermissionsTypes.Capabilities, BaseFunction>? Capabilities { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-custompermissions.html#cfn-quicksight-custompermissions-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-custompermissions.html#cfn-quicksight-custompermissions-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CustomPermissionsTypes
    {
        public class Capabilities : Humidifier.Base.BaseSubResource, IHavePublishWithoutApproval, IHaveInboundEmailTrigger, IHaveShareGoogleCalendarAction, IHaveUseBoxAgentAction, IHaveUpdateRedshiftManualDataSource, IHaveUseSAPMaterialStockAction, IHaveS3DataSource, IHaveCreateAndUpdateIDCKnowledgeBase, IHaveUseBoxKnowledgeBase, IHaveMondayAction, IHaveUpdateServiceNowDataSource, IHaveSpace, IHaveUseHuggingFaceAction, IHaveCreateAndUpdateCanvaAgentAction, IHaveShareNewRelicAction, IHaveAdobeAnalyticsDataSource, IHaveSAPMaterialStockAction, IHaveShareAmazonBedrockARSAction, IHaveCreateFileDataSource, IHaveShareSapHanaDataSource, IHaveAnalysis, IHaveChatAgent, IHaveOpenSearchDataSource, IHaveShareKnowledgeBases, IHaveHuggingFaceAction, IHaveCreateAndUpdateDataSources, IHaveShareOracleDataSource, IHaveCreateSPICEDataset, IHaveShareOneDriveAction, IHaveUseFactSetAction, IHaveUpdateDremioDataSource, IHaveCreatePayPalDataSource, IHaveShareMondayAction, IHaveCreateSquareDataSource, IHaveAmazonBedrockARSAction, IHaveUpdateMariaDbDataSource, IHaveKnowledgeBase, IHaveSharePointAction, IHaveCreateRedshiftManualDataSource, IHaveUpdateSapHanaDataSource, IHaveSandPGlobalEnergyAction, IHaveCreateAndUpdateComprehendAction, IHaveMongoDbDataSource, IHaveCreateS3DataSource, IHaveUseMCPAction, IHaveUpdateS3TablesDataSource, IHaveUpdateImpalaDataSource, IHaveUseNewRelicAction, IHaveShareSAPBillOfMaterialAction, IHaveUseSharePointKnowledgeBase, IHaveCreateAndUpdateOpenAPIAction, IHaveShareSqlServerDataSource, IHaveUpdateDb2DataSource, IHaveUseSandPGlobalEnergyAction, IHaveExportToPdfInScheduledReports, IHaveShareAmazonBedrockKRSAction, IHaveCreateRdsDataSource, IHaveShareAsanaAction, IHaveCreateAndUpdateDatasets, IHaveShareSAPMaterialStockAction, IHaveSandPGMIAction, IHaveShareTeradataDataSource, IHaveSharePrestoDataSource, IHaveShareConfluenceKnowledgeBase, IHaveCreateTeradataDataSource, IHaveBuildCalculatedFieldWithQ, IHaveShareDashboards, IHaveShareTrinoDataSource, IHaveUpdateExasolDataSource, IHaveUseSAPProductMasterDataAction, IHaveUseConfluenceKnowledgeBase, IHaveUsePagerDutyAction, IHaveCreateDatabricksDataSource, IHaveShareGoogleAnalyticsDataSource, IHaveCreateTrinoDataSource, IHaveCreateAndUpdateJiraAction, IHaveCreateAndUpdateQBusinessKnowledgeBase, IHaveUseBambooHRAction, IHaveUpdateSnowflakeDataSource, IHaveCreateAndUpdatePagerDutyAction, IHaveIDCKnowledgeBase, IHaveCreateAndUpdateGoogleCalendarAction, IHaveCreateAndUpdateMCPAction, IHaveShareAmazonSThreeAction, IHaveExportToCsvInScheduledReports, IHaveSAPPhysicalInventoryAction, IHaveCreateAndUpdateHuggingFaceAction, IHaveUseSAPBillOfMaterialAction, IHaveJiraAction, IHaveUpdateFileDataSource, IHaveUpdatePostgreSqlDataSource, IHaveShareMariaDbDataSource, IHaveUpdateTeradataDataSource, IHaveCreateDb2DataSource, IHaveGoogleAnalyticsDataSource, IHaveShareHubspotAction, IHaveShareSAPPhysicalInventoryAction, IHaveUseQBusinessKnowledgeBase, IHaveCreateAndUpdateOneDriveKnowledgeBase, IHaveExasolDataSource, IHaveCreateMongoDbDataSource, IHaveUseWebCrawlerKnowledgeBase, IHaveCreateSharedFolders, IHaveShareBambooHRAction, IHaveCreateExasolDataSource, IHaveZendeskAction, IHaveCreateAndUpdateSlackAction, IHaveUseHubspotAction, IHaveUpdateMongoAtlasDataSource, IHaveAutomate, IHaveShareBoxKnowledgeBase, IHaveUseOutlookAddInExtension, IHaveExportToPdf, IHaveShareOpenAPIAction, IHaveUpdateGoogleAnalyticsDataSource, IHaveUseOpenAPIAction, IHaveSharePostgreSqlDataSource, IHaveShareJiraDataSource, IHaveCreateAndUpdateLinearAction, IHaveUseBedrockManagedKnowledgeBase, IHaveCreateAndUpdateS3KnowledgeBase, IHaveUseNotionAction, IHaveCreateAndUpdateFactSetAction, IHaveUpdateRedshiftAutoDiscoveredDataSource, IHaveCreateDremioDataSource, IHaveCreateAndUpdateMSTeamsAction, IHaveShareAthenaDataSource, IHaveCreateAndUpdateSharePointAction, IHaveTimestreamDataSource, IHavePrintReports, IHaveCreateS3AnalyticsDataSource, IHaveFileDataSource, IHaveUpdateAdobeAnalyticsDataSource, IHaveShareMongoAtlasDataSource, IHaveCreateGitHubDataSource, IHaveSnowflakeDataSource, IHaveCreateDocumentDbDataSource, IHaveUsePowerpointAddInExtension, IHaveUpdateRadiantDataSource, IHaveUseGoogleDriveKnowledgeBase, IHaveShareSmartsheetAction, IHaveShareHuggingFaceAction, IHaveShareConfluenceAction, IHaveRenameSharedFolders, IHaveComprehendMedicalAction, IHaveCreateSparkDataSource, IHaveShareQBusinessKnowledgeBase, IHaveGoogleBigQueryDataSource, IHaveSparkDataSource, IHaveShareDocumentDbDataSource, IHaveShareMSTeamsAction, IHaveUseAmazonBedrockKRSAction, IHaveShareFactSetAction, IHaveShareMCPAction, IHaveRedshiftAutoDiscoveredDataSource, IHaveUseExcelAddInExtension, IHaveShareSAPProductMasterDataAction, IHaveAmazonBedrockKRSAction, IHaveBoxKnowledgeBase, IHaveAuroraDataSource, IHaveCreatePostgreSqlDataSource, IHaveCreateAndUpdateSandPGMIAction, IHaveShareAmazonBedrockFSAction, IHaveMCPAction, IHaveLinearAction, IHaveCreateAndUpdateNotionAction, IHaveMariaDbDataSource, IHaveUpdateJiraDataSource, IHaveDremioDataSource, IHaveFlow, IHaveMSExchangeAction, IHaveUpdateMongoDbDataSource, IHaveUseS3KnowledgeBase, IHaveShareGitHubDataSource, IHaveUseAsanaAction, IHaveCreateAndUpdateSandPGlobalEnergyAction, IHaveUseSlackAction, IHaveBoxAgentAction, IHaveUseZendeskAction, IHaveCreateGoogleAnalyticsDataSource, IHaveUseServiceNowAction, IHaveCreateSpaces, IHaveCreateSnowflakeDataSource, IHaveUseAmazonSThreeAction, IHaveSAPBusinessPartnerAction, IHaveUseSAPPhysicalInventoryAction, IHaveShareRedshiftAutoDiscoveredDataSource, IHaveStarburstDataSource, IHaveCreateAndUpdateAmazonSThreeAction, IHaveUpdateDenodoDataSource, IHaveShareCanvaAgentAction, IHaveCreateTwitterDataSource, IHaveUpdateDocumentDbDataSource, IHaveShareAdobeAnalyticsDataSource, IHaveS3AnalyticsDataSource, IHaveUpdateTrinoDataSource, IHaveCreateTimestreamDataSource, IHaveTrigger, IHaveUpdateGoogleSheetsDataSource, IHaveShareDb2DataSource, IHaveUpdateSqlServerDataSource, IHaveUseOneDriveKnowledgeBase, IHaveUseSmartsheetAction, IHaveCreateSqlServerDataSource, IHaveCreateAndUpdateBambooHRAction, IHaveSquareDataSource, IHaveShareSandPGlobalEnergyAction, IHaveUseComprehendAction, IHaveCreateAndUpdateSAPMaterialStockAction, IHaveOneDriveAction, IHaveCreateAndUpdateThemes, IHaveUseSAPBusinessPartnerAction, IHaveShareMongoDbDataSource, IHaveViewAccountSPICECapacity, IHaveCreateAndUpdateGenericHTTPAction, IHaveCreateAndUpdateAmazonBedrockFSAction, IHaveNotionAction, IHaveUpdateAthenaDataSource, IHaveGoogleDriveKnowledgeBase, IHaveBedrockManagedKnowledgeBase, IHaveCreateAndUpdateAsanaAction, IHaveCreateMariaDbDataSource, IHaveUpdateTimestreamDataSource, IHavePagerDutyAction, IHaveMongoAtlasDataSource, IHaveCreateAndUpdateMSExchangeAction, IHaveTopic, IHaveCreateAndUpdateTextractAction, IHaveShareS3KnowledgeBase, IHaveOracleDataSource, IHaveTwitterDataSource, IHaveUpdateRdsDataSource, IHaveShareDataSources, IHaveShareGithubAction, IHaveShareTimestreamDataSource, IHaveUseAmazonBedrockARSAction, IHaveCreateChatAgents, IHaveShareS3AnalyticsDataSource, IHaveRedshiftManualDataSource, IHaveShareOneDriveKnowledgeBase, IHaveOneDriveKnowledgeBase, IHaveShareBedrockManagedKnowledgeBase, IHaveCreateAndUpdateWebCrawlerKnowledgeBase, IHaveUseIDCKnowledgeBase, IHaveShareComprehendAction, IHaveUpdateOpenSearchDataSource, IHaveUseTextractAction, IHaveUseCanvaAgentAction, IHaveDynamoDbDataSource, IHaveCreateAndUpdateBoxKnowledgeBase, IHaveCreateDashboardExecutiveSummaryWithQ, IHaveShareComprehendMedicalAction, IHaveShareSalesforceAction, IHaveUseAgentWebSearch, IHaveManageSharedFolders, IHaveShareGenericHTTPAction, IHaveShareSpaces, IHaveSlackAction, IHaveUpdateGoogleBigQueryDataSource, IHavePostgreSqlDataSource, IHaveTeradataDataSource, IHaveShareFileDataSource, IHaveShareJiraAction, IHaveCreateGoogleBigQueryDataSource, IHaveConfluenceAction, IHaveUpdatePrestoDataSource, IHaveServiceNowDataSource, IHaveShareSquareDataSource, IHavePayPalDataSource, IHaveOpenAPIAction, IHaveCreateSapHanaDataSource, IHaveCreateOracleDataSource, IHaveShareDatasets, IHaveUseGoogleCalendarAction, IHaveCreateAndUpdateSharePointKnowledgeBase, IHaveUpdateAuroraDataSource, IHaveShareLinearAction, IHaveShareIDCKnowledgeBase, IHaveUseSalesforceAction, IHaveUseLinearAction, IHaveIntercomAction, IHaveCreateAndUpdateNewRelicAction, IHaveUseComprehendMedicalAction, IHaveAmazonBedrockFSAction, IHaveIncludeContentInScheduledReportsEmail, IHaveCreateAndUpdateConfluenceAction, IHaveDashboard, IHaveApps, IHaveShareSandPGMIAction, IHaveSharePagerDutyAction, IHaveUpdateMySqlDataSource, IHaveCreateRedshiftAutoDiscoveredDataSource, IHaveWebCrawlerKnowledgeBase, IHaveJiraDataSource, IHaveAsanaAction, IHaveUseWordAddInExtension, IHaveQuickEventTrigger, IHaveCreateAndUpdateDashboardEmailReports, IHaveGitHubDataSource, IHaveShareTextractAction, IHaveCreateAndUpdateZendeskAction, IHaveCreateServiceNowDataSource, IHaveShareDenodoDataSource, IHaveSubscribeDashboardEmailReports, IHaveShareDatabricksDataSource, IHaveCreateAndUpdateServiceNowAction, IHaveTrinoDataSource, IHaveTextractAction, IHaveAction, IHaveAccessAppsNativeDataStore, IHaveS3TablesDataSource, IHaveFactSetAction, IHaveGoogleCalendarAction, IHaveCreateAndUpdateBoxAgentAction, IHaveUseMSExchangeAction, IHaveGoogleSheetsDataSource, IHaveUpdateS3DataSource, IHaveShareMySqlDataSource, IHaveMSTeamsAction, IHaveCreateAndUpdateSAPBusinessPartnerAction, IHaveConfluenceKnowledgeBase, IHaveCreateAuroraDataSource, IHaveShareRadiantDataSource, IHaveBambooHRAction, IHaveCreateAndUpdateSAPPhysicalInventoryAction, IHaveSalesforceDataSource, IHaveAddOrRunAnomalyDetectionForAnalyses, IHaveExtension, IHaveShareAnalyses, IHaveUseGithubAction, IHaveServiceNowAction, IHaveUpdateDatabricksDataSource, IHaveDocumentDbDataSource, IHaveUseAmazonBedrockFSAction, IHaveShareImpalaDataSource, IHaveUpdateGitHubDataSource, IHaveDb2DataSource, IHaveCreateSalesforceDataSource, IHaveNewRelicAction, IHaveShareTwitterDataSource, IHaveCreateAndUpdateIntercomAction, IHaveUpdateStarburstDataSource, IHaveSAPBillOfMaterialAction, IHaveUpdateSquareDataSource, IHaveShareChatAgents, IHaveCreateImpalaDataSource, IHaveShareStarburstDataSource, IHaveShareServiceNowAction, IHaveApproveFlowShareRequests, IHaveExportToExcelInScheduledReports, IHaveUseSharePointAction, IHaveShareSalesforceDataSource, IHaveShareSAPBusinessPartnerAction, IHaveSAPProductMasterDataAction, IHaveComprehendAction, IHaveShareGoogleSheetsDataSource, IHaveCreateAndUpdateHubspotAction, IHaveUseSandPGMIAction, IHaveUseIntercomAction, IHaveCreatePrestoDataSource, IHaveCreateAndUpdateMondayAction, IHaveShareSparkDataSource, IHaveCreateMySqlDataSource, IHaveCreateMongoAtlasDataSource, IHaveUseGenericHTTPAction, IHaveSqlServerDataSource, IHaveEditVisualWithQ, IHaveCreateAndUpdateSAPProductMasterDataAction, IHaveSharePointKnowledgeBase, IHaveInvokeAppsAIInference, IHaveShareZendeskAction, IHaveShareIntercomAction, IHaveShareDynamoDbDataSource, IHaveGenericHTTPAction, IHaveResearch, IHaveSapHanaDataSource, IHaveUseBrowserExtension, IHaveQBusinessKnowledgeBase, IHaveCreateAndUpdateAmazonBedrockKRSAction, IHaveCreateGoogleSheetsDataSource, IHaveUseBedrockModels, IHaveCreateAndUpdateAmazonBedrockARSAction, IHaveCreateAndUpdateThresholdAlerts, IHaveUpdateDynamoDbDataSource, IHaveS3KnowledgeBase, IHaveHubspotAction, IHaveCreateStarburstDataSource, IHaveRdsDataSource, IHavePrestoDataSource, IHaveShareSnowflakeDataSource, IHaveUseOneDriveAction, IHaveExportToExcel, IHaveShareOpenSearchDataSource, IHaveCreateAndUpdateGithubAction, IHaveShareS3TablesDataSource, IHaveShareSlackAction, IHaveCreateAndUpdateGoogleDriveKnowledgeBase, IHaveUpdateTwitterDataSource, IHaveCreateAndUpdateSmartsheetAction, IHaveShareBoxAgentAction, IHaveShareGoogleBigQueryDataSource, IHaveCreateAndUpdateOneDriveAction, IHaveUpdateS3AnalyticsDataSource, IHaveCreateAndUpdateKnowledgeBases, IHaveUpdatePayPalDataSource, IHaveShareServiceNowDataSource, IHaveCreateAndUpdateApps, IHaveShareDremioDataSource, IHaveCreateAndUpdateBedrockManagedKnowledgeBase, IHaveUseConfluenceAction, IHaveImpalaDataSource, IHaveCreateOpenSearchDataSource, IHaveAmazonSThreeAction, IHaveShareRedshiftManualDataSource, IHaveSharePayPalDataSource, IHaveCreateAndUpdateSAPBillOfMaterialAction, IHaveUseMondayAction, IHaveUseJiraAction, IHaveCreateAthenaDataSource, IHaveCreateAndUpdateComprehendMedicalAction, IHaveUseMSTeamsAction, IHaveCreateAndUpdateSalesforceAction, IHavePerformFlowUiTask, IHaveShareGoogleDriveKnowledgeBase, IHaveCreateS3TablesDataSource, IHaveShareSharePointAction, IHaveRadiantDataSource, IHaveShareWebCrawlerKnowledgeBase, IHaveMySqlDataSource, IHaveShareExasolDataSource, IHaveShareS3DataSource, IHaveSmartsheetAction, IHaveCreateDenodoDataSource, IHaveCreateDynamoDbDataSource, IHaveShareRdsDataSource, IHaveShareApps, IHaveShareMSExchangeAction, IHaveCreateAdobeAnalyticsDataSource, IHaveDenodoDataSource, IHaveCanvaAgentAction, IHaveGithubAction, IHaveScheduleTrigger, IHaveUpdateSalesforceDataSource, IHaveUpdateSparkDataSource, IHaveCreateRadiantDataSource, IHaveAthenaDataSource, IHaveUpdateOracleDataSource, IHaveCreateAndUpdateConfluenceKnowledgeBase, IHaveShareAuroraDataSource, IHaveShareSharePointKnowledgeBase, IHaveExportToCsv, IHaveDatabricksDataSource, IHaveCreateJiraDataSource, IHaveSalesforceAction, IHaveShareNotionAction
        {
            /// <summary>
            /// PublishWithoutApproval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-publishwithoutapproval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PublishWithoutApproval { get; set; }
            /// <summary>
            /// InboundEmailTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-inboundemailtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InboundEmailTrigger { get; set; }
            /// <summary>
            /// ShareGoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegooglecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGoogleCalendarAction { get; set; }
            /// <summary>
            /// UseBoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useboxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBoxAgentAction { get; set; }
            /// <summary>
            /// UpdateRedshiftManualDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateredshiftmanualdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateRedshiftManualDataSource { get; set; }
            /// <summary>
            /// UseSAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSAPMaterialStockAction { get; set; }
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-s3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3DataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateIDCKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateidcknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateIDCKnowledgeBase { get; set; }
            /// <summary>
            /// UseBoxKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useboxknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBoxKnowledgeBase { get; set; }
            /// <summary>
            /// MondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MondayAction { get; set; }
            /// <summary>
            /// UpdateServiceNowDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateservicenowdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateServiceNowDataSource { get; set; }
            /// <summary>
            /// Space
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-space
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Space { get; set; }
            /// <summary>
            /// UseHuggingFaceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usehuggingfaceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseHuggingFaceAction { get; set; }
            /// <summary>
            /// CreateAndUpdateCanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatecanvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateCanvaAgentAction { get; set; }
            /// <summary>
            /// ShareNewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharenewrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareNewRelicAction { get; set; }
            /// <summary>
            /// AdobeAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-adobeanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdobeAnalyticsDataSource { get; set; }
            /// <summary>
            /// SAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAPMaterialStockAction { get; set; }
            /// <summary>
            /// ShareAmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareamazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAmazonBedrockARSAction { get; set; }
            /// <summary>
            /// CreateFileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createfiledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateFileDataSource { get; set; }
            /// <summary>
            /// ShareSapHanaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesaphanadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSapHanaDataSource { get; set; }
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-analysis
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Analysis { get; set; }
            /// <summary>
            /// ChatAgent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-chatagent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChatAgent { get; set; }
            /// <summary>
            /// OpenSearchDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-opensearchdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OpenSearchDataSource { get; set; }
            /// <summary>
            /// ShareKnowledgeBases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareknowledgebases
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareKnowledgeBases { get; set; }
            /// <summary>
            /// HuggingFaceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-huggingfaceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HuggingFaceAction { get; set; }
            /// <summary>
            /// CreateAndUpdateDataSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatedatasources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateDataSources { get; set; }
            /// <summary>
            /// ShareOracleDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareoracledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareOracleDataSource { get; set; }
            /// <summary>
            /// CreateSPICEDataset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createspicedataset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSPICEDataset { get; set; }
            /// <summary>
            /// ShareOneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareonedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareOneDriveAction { get; set; }
            /// <summary>
            /// UseFactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usefactsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseFactSetAction { get; set; }
            /// <summary>
            /// UpdateDremioDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedremiodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateDremioDataSource { get; set; }
            /// <summary>
            /// CreatePayPalDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createpaypaldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatePayPalDataSource { get; set; }
            /// <summary>
            /// ShareMondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMondayAction { get; set; }
            /// <summary>
            /// CreateSquareDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsquaredatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSquareDataSource { get; set; }
            /// <summary>
            /// AmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonBedrockARSAction { get; set; }
            /// <summary>
            /// UpdateMariaDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatemariadbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateMariaDbDataSource { get; set; }
            /// <summary>
            /// KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBase { get; set; }
            /// <summary>
            /// SharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharePointAction { get; set; }
            /// <summary>
            /// CreateRedshiftManualDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createredshiftmanualdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateRedshiftManualDataSource { get; set; }
            /// <summary>
            /// UpdateSapHanaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesaphanadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateSapHanaDataSource { get; set; }
            /// <summary>
            /// SandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SandPGlobalEnergyAction { get; set; }
            /// <summary>
            /// CreateAndUpdateComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatecomprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateComprehendAction { get; set; }
            /// <summary>
            /// MongoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mongodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MongoDbDataSource { get; set; }
            /// <summary>
            /// CreateS3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creates3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateS3DataSource { get; set; }
            /// <summary>
            /// UseMCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseMCPAction { get; set; }
            /// <summary>
            /// UpdateS3TablesDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updates3tablesdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateS3TablesDataSource { get; set; }
            /// <summary>
            /// UpdateImpalaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateimpaladatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateImpalaDataSource { get; set; }
            /// <summary>
            /// UseNewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usenewrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseNewRelicAction { get; set; }
            /// <summary>
            /// ShareSAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// UseSharePointKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesharepointknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSharePointKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateOpenAPIAction { get; set; }
            /// <summary>
            /// ShareSqlServerDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesqlserverdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSqlServerDataSource { get; set; }
            /// <summary>
            /// UpdateDb2DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedb2datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateDb2DataSource { get; set; }
            /// <summary>
            /// UseSandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSandPGlobalEnergyAction { get; set; }
            /// <summary>
            /// ExportToPdfInScheduledReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttopdfinscheduledreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToPdfInScheduledReports { get; set; }
            /// <summary>
            /// ShareAmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareamazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAmazonBedrockKRSAction { get; set; }
            /// <summary>
            /// CreateRdsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createrdsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateRdsDataSource { get; set; }
            /// <summary>
            /// ShareAsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareasanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAsanaAction { get; set; }
            /// <summary>
            /// CreateAndUpdateDatasets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatedatasets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateDatasets { get; set; }
            /// <summary>
            /// ShareSAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSAPMaterialStockAction { get; set; }
            /// <summary>
            /// SandPGMIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sandpgmiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SandPGMIAction { get; set; }
            /// <summary>
            /// ShareTeradataDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareteradatadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareTeradataDataSource { get; set; }
            /// <summary>
            /// SharePrestoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareprestodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharePrestoDataSource { get; set; }
            /// <summary>
            /// ShareConfluenceKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareconfluenceknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareConfluenceKnowledgeBase { get; set; }
            /// <summary>
            /// CreateTeradataDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createteradatadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateTeradataDataSource { get; set; }
            /// <summary>
            /// BuildCalculatedFieldWithQ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-buildcalculatedfieldwithq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuildCalculatedFieldWithQ { get; set; }
            /// <summary>
            /// ShareDashboards
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedashboards
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDashboards { get; set; }
            /// <summary>
            /// ShareTrinoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetrinodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareTrinoDataSource { get; set; }
            /// <summary>
            /// UpdateExasolDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateexasoldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateExasolDataSource { get; set; }
            /// <summary>
            /// UseSAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSAPProductMasterDataAction { get; set; }
            /// <summary>
            /// UseConfluenceKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useconfluenceknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseConfluenceKnowledgeBase { get; set; }
            /// <summary>
            /// UsePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsePagerDutyAction { get; set; }
            /// <summary>
            /// CreateDatabricksDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdatabricksdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateDatabricksDataSource { get; set; }
            /// <summary>
            /// ShareGoogleAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegoogleanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGoogleAnalyticsDataSource { get; set; }
            /// <summary>
            /// CreateTrinoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createtrinodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateTrinoDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateJiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatejiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateJiraAction { get; set; }
            /// <summary>
            /// CreateAndUpdateQBusinessKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateqbusinessknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateQBusinessKnowledgeBase { get; set; }
            /// <summary>
            /// UseBambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBambooHRAction { get; set; }
            /// <summary>
            /// UpdateSnowflakeDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesnowflakedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateSnowflakeDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdatePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdatePagerDutyAction { get; set; }
            /// <summary>
            /// IDCKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-idcknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IDCKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateGoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategooglecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateGoogleCalendarAction { get; set; }
            /// <summary>
            /// CreateAndUpdateMCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateMCPAction { get; set; }
            /// <summary>
            /// ShareAmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareamazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAmazonSThreeAction { get; set; }
            /// <summary>
            /// ExportToCsvInScheduledReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttocsvinscheduledreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToCsvInScheduledReports { get; set; }
            /// <summary>
            /// SAPPhysicalInventoryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapphysicalinventoryaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAPPhysicalInventoryAction { get; set; }
            /// <summary>
            /// CreateAndUpdateHuggingFaceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatehuggingfaceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateHuggingFaceAction { get; set; }
            /// <summary>
            /// UseSAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// JiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-jiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JiraAction { get; set; }
            /// <summary>
            /// UpdateFileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatefiledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateFileDataSource { get; set; }
            /// <summary>
            /// UpdatePostgreSqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatepostgresqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatePostgreSqlDataSource { get; set; }
            /// <summary>
            /// ShareMariaDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemariadbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMariaDbDataSource { get; set; }
            /// <summary>
            /// UpdateTeradataDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateteradatadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateTeradataDataSource { get; set; }
            /// <summary>
            /// CreateDb2DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdb2datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateDb2DataSource { get; set; }
            /// <summary>
            /// GoogleAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googleanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GoogleAnalyticsDataSource { get; set; }
            /// <summary>
            /// ShareHubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharehubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareHubspotAction { get; set; }
            /// <summary>
            /// ShareSAPPhysicalInventoryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapphysicalinventoryaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSAPPhysicalInventoryAction { get; set; }
            /// <summary>
            /// UseQBusinessKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useqbusinessknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseQBusinessKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateOneDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateonedriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateOneDriveKnowledgeBase { get; set; }
            /// <summary>
            /// ExasolDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exasoldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExasolDataSource { get; set; }
            /// <summary>
            /// CreateMongoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createmongodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateMongoDbDataSource { get; set; }
            /// <summary>
            /// UseWebCrawlerKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usewebcrawlerknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseWebCrawlerKnowledgeBase { get; set; }
            /// <summary>
            /// CreateSharedFolders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsharedfolders
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSharedFolders { get; set; }
            /// <summary>
            /// ShareBambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharebamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareBambooHRAction { get; set; }
            /// <summary>
            /// CreateExasolDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createexasoldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateExasolDataSource { get; set; }
            /// <summary>
            /// ZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-zendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZendeskAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateslackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSlackAction { get; set; }
            /// <summary>
            /// UseHubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usehubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseHubspotAction { get; set; }
            /// <summary>
            /// UpdateMongoAtlasDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatemongoatlasdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateMongoAtlasDataSource { get; set; }
            /// <summary>
            /// Automate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-automate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Automate { get; set; }
            /// <summary>
            /// ShareBoxKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareboxknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareBoxKnowledgeBase { get; set; }
            /// <summary>
            /// UseOutlookAddInExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useoutlookaddinextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseOutlookAddInExtension { get; set; }
            /// <summary>
            /// ExportToPdf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttopdf
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToPdf { get; set; }
            /// <summary>
            /// ShareOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareOpenAPIAction { get; set; }
            /// <summary>
            /// UpdateGoogleAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updategoogleanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateGoogleAnalyticsDataSource { get; set; }
            /// <summary>
            /// UseOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseOpenAPIAction { get; set; }
            /// <summary>
            /// SharePostgreSqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepostgresqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharePostgreSqlDataSource { get; set; }
            /// <summary>
            /// ShareJiraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharejiradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareJiraDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateLinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatelinearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateLinearAction { get; set; }
            /// <summary>
            /// UseBedrockManagedKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebedrockmanagedknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBedrockManagedKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateS3KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdates3knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateS3KnowledgeBase { get; set; }
            /// <summary>
            /// UseNotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usenotionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseNotionAction { get; set; }
            /// <summary>
            /// CreateAndUpdateFactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatefactsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateFactSetAction { get; set; }
            /// <summary>
            /// UpdateRedshiftAutoDiscoveredDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateredshiftautodiscovereddatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateRedshiftAutoDiscoveredDataSource { get; set; }
            /// <summary>
            /// CreateDremioDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdremiodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateDremioDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateMSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemsteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateMSTeamsAction { get; set; }
            /// <summary>
            /// ShareAthenaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareathenadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAthenaDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateSharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSharePointAction { get; set; }
            /// <summary>
            /// TimestreamDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-timestreamdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestreamDataSource { get; set; }
            /// <summary>
            /// PrintReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-printreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrintReports { get; set; }
            /// <summary>
            /// CreateS3AnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creates3analyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateS3AnalyticsDataSource { get; set; }
            /// <summary>
            /// FileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-filedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileDataSource { get; set; }
            /// <summary>
            /// UpdateAdobeAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateadobeanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateAdobeAnalyticsDataSource { get; set; }
            /// <summary>
            /// ShareMongoAtlasDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemongoatlasdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMongoAtlasDataSource { get; set; }
            /// <summary>
            /// CreateGitHubDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creategithubdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateGitHubDataSource { get; set; }
            /// <summary>
            /// SnowflakeDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-snowflakedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnowflakeDataSource { get; set; }
            /// <summary>
            /// CreateDocumentDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdocumentdbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateDocumentDbDataSource { get; set; }
            /// <summary>
            /// UsePowerpointAddInExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usepowerpointaddinextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsePowerpointAddInExtension { get; set; }
            /// <summary>
            /// UpdateRadiantDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateradiantdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateRadiantDataSource { get; set; }
            /// <summary>
            /// UseGoogleDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegoogledriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseGoogleDriveKnowledgeBase { get; set; }
            /// <summary>
            /// ShareSmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesmartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSmartsheetAction { get; set; }
            /// <summary>
            /// ShareHuggingFaceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharehuggingfaceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareHuggingFaceAction { get; set; }
            /// <summary>
            /// ShareConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareconfluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareConfluenceAction { get; set; }
            /// <summary>
            /// RenameSharedFolders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-renamesharedfolders
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RenameSharedFolders { get; set; }
            /// <summary>
            /// ComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-comprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComprehendMedicalAction { get; set; }
            /// <summary>
            /// CreateSparkDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsparkdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSparkDataSource { get; set; }
            /// <summary>
            /// ShareQBusinessKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareqbusinessknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareQBusinessKnowledgeBase { get; set; }
            /// <summary>
            /// GoogleBigQueryDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googlebigquerydatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GoogleBigQueryDataSource { get; set; }
            /// <summary>
            /// SparkDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sparkdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SparkDataSource { get; set; }
            /// <summary>
            /// ShareDocumentDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedocumentdbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDocumentDbDataSource { get; set; }
            /// <summary>
            /// ShareMSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemsteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMSTeamsAction { get; set; }
            /// <summary>
            /// UseAmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseAmazonBedrockKRSAction { get; set; }
            /// <summary>
            /// ShareFactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharefactsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareFactSetAction { get; set; }
            /// <summary>
            /// ShareMCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMCPAction { get; set; }
            /// <summary>
            /// RedshiftAutoDiscoveredDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-redshiftautodiscovereddatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedshiftAutoDiscoveredDataSource { get; set; }
            /// <summary>
            /// UseExcelAddInExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useexceladdinextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseExcelAddInExtension { get; set; }
            /// <summary>
            /// ShareSAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSAPProductMasterDataAction { get; set; }
            /// <summary>
            /// AmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonBedrockKRSAction { get; set; }
            /// <summary>
            /// BoxKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-boxknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BoxKnowledgeBase { get; set; }
            /// <summary>
            /// AuroraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-auroradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuroraDataSource { get; set; }
            /// <summary>
            /// CreatePostgreSqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createpostgresqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatePostgreSqlDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateSandPGMIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesandpgmiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSandPGMIAction { get; set; }
            /// <summary>
            /// ShareAmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareamazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAmazonBedrockFSAction { get; set; }
            /// <summary>
            /// MCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MCPAction { get; set; }
            /// <summary>
            /// LinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-linearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LinearAction { get; set; }
            /// <summary>
            /// CreateAndUpdateNotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatenotionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateNotionAction { get; set; }
            /// <summary>
            /// MariaDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mariadbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MariaDbDataSource { get; set; }
            /// <summary>
            /// UpdateJiraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatejiradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateJiraDataSource { get; set; }
            /// <summary>
            /// DremioDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-dremiodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DremioDataSource { get; set; }
            /// <summary>
            /// Flow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-flow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Flow { get; set; }
            /// <summary>
            /// MSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-msexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MSExchangeAction { get; set; }
            /// <summary>
            /// UpdateMongoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatemongodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateMongoDbDataSource { get; set; }
            /// <summary>
            /// UseS3KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-uses3knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseS3KnowledgeBase { get; set; }
            /// <summary>
            /// ShareGitHubDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegithubdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGitHubDataSource { get; set; }
            /// <summary>
            /// UseAsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useasanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseAsanaAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSandPGlobalEnergyAction { get; set; }
            /// <summary>
            /// UseSlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useslackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSlackAction { get; set; }
            /// <summary>
            /// BoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-boxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BoxAgentAction { get; set; }
            /// <summary>
            /// UseZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usezendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseZendeskAction { get; set; }
            /// <summary>
            /// CreateGoogleAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creategoogleanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateGoogleAnalyticsDataSource { get; set; }
            /// <summary>
            /// UseServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useservicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseServiceNowAction { get; set; }
            /// <summary>
            /// CreateSpaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createspaces
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSpaces { get; set; }
            /// <summary>
            /// CreateSnowflakeDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsnowflakedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSnowflakeDataSource { get; set; }
            /// <summary>
            /// UseAmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseAmazonSThreeAction { get; set; }
            /// <summary>
            /// SAPBusinessPartnerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapbusinesspartneraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAPBusinessPartnerAction { get; set; }
            /// <summary>
            /// UseSAPPhysicalInventoryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapphysicalinventoryaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSAPPhysicalInventoryAction { get; set; }
            /// <summary>
            /// ShareRedshiftAutoDiscoveredDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareredshiftautodiscovereddatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareRedshiftAutoDiscoveredDataSource { get; set; }
            /// <summary>
            /// StarburstDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-starburstdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StarburstDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateAmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateAmazonSThreeAction { get; set; }
            /// <summary>
            /// UpdateDenodoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedenododatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateDenodoDataSource { get; set; }
            /// <summary>
            /// ShareCanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharecanvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareCanvaAgentAction { get; set; }
            /// <summary>
            /// CreateTwitterDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createtwitterdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateTwitterDataSource { get; set; }
            /// <summary>
            /// UpdateDocumentDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedocumentdbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateDocumentDbDataSource { get; set; }
            /// <summary>
            /// ShareAdobeAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareadobeanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAdobeAnalyticsDataSource { get; set; }
            /// <summary>
            /// S3AnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-s3analyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3AnalyticsDataSource { get; set; }
            /// <summary>
            /// UpdateTrinoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatetrinodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateTrinoDataSource { get; set; }
            /// <summary>
            /// CreateTimestreamDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createtimestreamdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateTimestreamDataSource { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-trigger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Trigger { get; set; }
            /// <summary>
            /// UpdateGoogleSheetsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updategooglesheetsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateGoogleSheetsDataSource { get; set; }
            /// <summary>
            /// ShareDb2DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedb2datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDb2DataSource { get; set; }
            /// <summary>
            /// UpdateSqlServerDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesqlserverdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateSqlServerDataSource { get; set; }
            /// <summary>
            /// UseOneDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useonedriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseOneDriveKnowledgeBase { get; set; }
            /// <summary>
            /// UseSmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesmartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSmartsheetAction { get; set; }
            /// <summary>
            /// CreateSqlServerDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsqlserverdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSqlServerDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateBambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatebamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateBambooHRAction { get; set; }
            /// <summary>
            /// SquareDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-squaredatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SquareDataSource { get; set; }
            /// <summary>
            /// ShareSandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSandPGlobalEnergyAction { get; set; }
            /// <summary>
            /// UseComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usecomprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseComprehendAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSAPMaterialStockAction { get; set; }
            /// <summary>
            /// OneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-onedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OneDriveAction { get; set; }
            /// <summary>
            /// CreateAndUpdateThemes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatethemes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateThemes { get; set; }
            /// <summary>
            /// UseSAPBusinessPartnerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapbusinesspartneraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSAPBusinessPartnerAction { get; set; }
            /// <summary>
            /// ShareMongoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemongodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMongoDbDataSource { get; set; }
            /// <summary>
            /// ViewAccountSPICECapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-viewaccountspicecapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewAccountSPICECapacity { get; set; }
            /// <summary>
            /// CreateAndUpdateGenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategenerichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateGenericHTTPAction { get; set; }
            /// <summary>
            /// CreateAndUpdateAmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateAmazonBedrockFSAction { get; set; }
            /// <summary>
            /// NotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-notionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotionAction { get; set; }
            /// <summary>
            /// UpdateAthenaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateathenadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateAthenaDataSource { get; set; }
            /// <summary>
            /// GoogleDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googledriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GoogleDriveKnowledgeBase { get; set; }
            /// <summary>
            /// BedrockManagedKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-bedrockmanagedknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockManagedKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateAsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateasanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateAsanaAction { get; set; }
            /// <summary>
            /// CreateMariaDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createmariadbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateMariaDbDataSource { get; set; }
            /// <summary>
            /// UpdateTimestreamDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatetimestreamdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateTimestreamDataSource { get; set; }
            /// <summary>
            /// PagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-pagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PagerDutyAction { get; set; }
            /// <summary>
            /// MongoAtlasDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mongoatlasdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MongoAtlasDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateMSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemsexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateMSExchangeAction { get; set; }
            /// <summary>
            /// Topic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-topic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Topic { get; set; }
            /// <summary>
            /// CreateAndUpdateTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateTextractAction { get; set; }
            /// <summary>
            /// ShareS3KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shares3knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareS3KnowledgeBase { get; set; }
            /// <summary>
            /// OracleDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-oracledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OracleDataSource { get; set; }
            /// <summary>
            /// TwitterDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-twitterdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TwitterDataSource { get; set; }
            /// <summary>
            /// UpdateRdsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updaterdsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateRdsDataSource { get; set; }
            /// <summary>
            /// ShareDataSources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedatasources
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDataSources { get; set; }
            /// <summary>
            /// ShareGithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegithubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGithubAction { get; set; }
            /// <summary>
            /// ShareTimestreamDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetimestreamdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareTimestreamDataSource { get; set; }
            /// <summary>
            /// UseAmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseAmazonBedrockARSAction { get; set; }
            /// <summary>
            /// CreateChatAgents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createchatagents
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateChatAgents { get; set; }
            /// <summary>
            /// ShareS3AnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shares3analyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareS3AnalyticsDataSource { get; set; }
            /// <summary>
            /// RedshiftManualDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-redshiftmanualdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedshiftManualDataSource { get; set; }
            /// <summary>
            /// ShareOneDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareonedriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareOneDriveKnowledgeBase { get; set; }
            /// <summary>
            /// OneDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-onedriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OneDriveKnowledgeBase { get; set; }
            /// <summary>
            /// ShareBedrockManagedKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharebedrockmanagedknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareBedrockManagedKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateWebCrawlerKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatewebcrawlerknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateWebCrawlerKnowledgeBase { get; set; }
            /// <summary>
            /// UseIDCKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useidcknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseIDCKnowledgeBase { get; set; }
            /// <summary>
            /// ShareComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharecomprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareComprehendAction { get; set; }
            /// <summary>
            /// UpdateOpenSearchDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateopensearchdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateOpenSearchDataSource { get; set; }
            /// <summary>
            /// UseTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseTextractAction { get; set; }
            /// <summary>
            /// UseCanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usecanvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseCanvaAgentAction { get; set; }
            /// <summary>
            /// DynamoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-dynamodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DynamoDbDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateBoxKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateboxknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateBoxKnowledgeBase { get; set; }
            /// <summary>
            /// CreateDashboardExecutiveSummaryWithQ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdashboardexecutivesummarywithq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateDashboardExecutiveSummaryWithQ { get; set; }
            /// <summary>
            /// ShareComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharecomprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareComprehendMedicalAction { get; set; }
            /// <summary>
            /// ShareSalesforceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesalesforceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSalesforceAction { get; set; }
            /// <summary>
            /// UseAgentWebSearch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useagentwebsearch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseAgentWebSearch { get; set; }
            /// <summary>
            /// ManageSharedFolders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-managesharedfolders
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManageSharedFolders { get; set; }
            /// <summary>
            /// ShareGenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegenerichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGenericHTTPAction { get; set; }
            /// <summary>
            /// ShareSpaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharespaces
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSpaces { get; set; }
            /// <summary>
            /// SlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-slackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlackAction { get; set; }
            /// <summary>
            /// UpdateGoogleBigQueryDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updategooglebigquerydatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateGoogleBigQueryDataSource { get; set; }
            /// <summary>
            /// PostgreSqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-postgresqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PostgreSqlDataSource { get; set; }
            /// <summary>
            /// TeradataDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-teradatadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TeradataDataSource { get; set; }
            /// <summary>
            /// ShareFileDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharefiledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareFileDataSource { get; set; }
            /// <summary>
            /// ShareJiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharejiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareJiraAction { get; set; }
            /// <summary>
            /// CreateGoogleBigQueryDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creategooglebigquerydatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateGoogleBigQueryDataSource { get; set; }
            /// <summary>
            /// ConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-confluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfluenceAction { get; set; }
            /// <summary>
            /// UpdatePrestoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateprestodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatePrestoDataSource { get; set; }
            /// <summary>
            /// ServiceNowDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-servicenowdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceNowDataSource { get; set; }
            /// <summary>
            /// ShareSquareDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesquaredatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSquareDataSource { get; set; }
            /// <summary>
            /// PayPalDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-paypaldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayPalDataSource { get; set; }
            /// <summary>
            /// OpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-openapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OpenAPIAction { get; set; }
            /// <summary>
            /// CreateSapHanaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsaphanadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSapHanaDataSource { get; set; }
            /// <summary>
            /// CreateOracleDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createoracledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateOracleDataSource { get; set; }
            /// <summary>
            /// ShareDatasets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedatasets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDatasets { get; set; }
            /// <summary>
            /// UseGoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegooglecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseGoogleCalendarAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSharePointKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesharepointknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSharePointKnowledgeBase { get; set; }
            /// <summary>
            /// UpdateAuroraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateauroradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateAuroraDataSource { get; set; }
            /// <summary>
            /// ShareLinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharelinearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareLinearAction { get; set; }
            /// <summary>
            /// ShareIDCKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareidcknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareIDCKnowledgeBase { get; set; }
            /// <summary>
            /// UseSalesforceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesalesforceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSalesforceAction { get; set; }
            /// <summary>
            /// UseLinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-uselinearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseLinearAction { get; set; }
            /// <summary>
            /// IntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-intercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntercomAction { get; set; }
            /// <summary>
            /// CreateAndUpdateNewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatenewrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateNewRelicAction { get; set; }
            /// <summary>
            /// UseComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usecomprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseComprehendMedicalAction { get; set; }
            /// <summary>
            /// AmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonBedrockFSAction { get; set; }
            /// <summary>
            /// IncludeContentInScheduledReportsEmail
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-includecontentinscheduledreportsemail
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IncludeContentInScheduledReportsEmail { get; set; }
            /// <summary>
            /// CreateAndUpdateConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateconfluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateConfluenceAction { get; set; }
            /// <summary>
            /// Dashboard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-dashboard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Dashboard { get; set; }
            /// <summary>
            /// Apps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-apps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Apps { get; set; }
            /// <summary>
            /// ShareSandPGMIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesandpgmiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSandPGMIAction { get; set; }
            /// <summary>
            /// SharePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharePagerDutyAction { get; set; }
            /// <summary>
            /// UpdateMySqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatemysqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateMySqlDataSource { get; set; }
            /// <summary>
            /// CreateRedshiftAutoDiscoveredDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createredshiftautodiscovereddatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateRedshiftAutoDiscoveredDataSource { get; set; }
            /// <summary>
            /// WebCrawlerKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-webcrawlerknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WebCrawlerKnowledgeBase { get; set; }
            /// <summary>
            /// JiraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-jiradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JiraDataSource { get; set; }
            /// <summary>
            /// AsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-asanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AsanaAction { get; set; }
            /// <summary>
            /// UseWordAddInExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usewordaddinextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseWordAddInExtension { get; set; }
            /// <summary>
            /// QuickEventTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-quickeventtrigger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QuickEventTrigger { get; set; }
            /// <summary>
            /// CreateAndUpdateDashboardEmailReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatedashboardemailreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateDashboardEmailReports { get; set; }
            /// <summary>
            /// GitHubDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-githubdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GitHubDataSource { get; set; }
            /// <summary>
            /// ShareTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareTextractAction { get; set; }
            /// <summary>
            /// CreateAndUpdateZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatezendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateZendeskAction { get; set; }
            /// <summary>
            /// CreateServiceNowDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createservicenowdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateServiceNowDataSource { get; set; }
            /// <summary>
            /// ShareDenodoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedenododatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDenodoDataSource { get; set; }
            /// <summary>
            /// SubscribeDashboardEmailReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-subscribedashboardemailreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubscribeDashboardEmailReports { get; set; }
            /// <summary>
            /// ShareDatabricksDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedatabricksdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDatabricksDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateservicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateServiceNowAction { get; set; }
            /// <summary>
            /// TrinoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-trinodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrinoDataSource { get; set; }
            /// <summary>
            /// TextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-textractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextractAction { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// AccessAppsNativeDataStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-accessappsnativedatastore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessAppsNativeDataStore { get; set; }
            /// <summary>
            /// S3TablesDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-s3tablesdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3TablesDataSource { get; set; }
            /// <summary>
            /// FactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-factsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FactSetAction { get; set; }
            /// <summary>
            /// GoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googlecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GoogleCalendarAction { get; set; }
            /// <summary>
            /// CreateAndUpdateBoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateboxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateBoxAgentAction { get; set; }
            /// <summary>
            /// UseMSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemsexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseMSExchangeAction { get; set; }
            /// <summary>
            /// GoogleSheetsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-googlesheetsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GoogleSheetsDataSource { get; set; }
            /// <summary>
            /// UpdateS3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updates3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateS3DataSource { get; set; }
            /// <summary>
            /// ShareMySqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemysqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMySqlDataSource { get; set; }
            /// <summary>
            /// MSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-msteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MSTeamsAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPBusinessPartnerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapbusinesspartneraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSAPBusinessPartnerAction { get; set; }
            /// <summary>
            /// ConfluenceKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-confluenceknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfluenceKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAuroraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createauroradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAuroraDataSource { get; set; }
            /// <summary>
            /// ShareRadiantDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareradiantdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareRadiantDataSource { get; set; }
            /// <summary>
            /// BambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-bamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BambooHRAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPPhysicalInventoryAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapphysicalinventoryaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSAPPhysicalInventoryAction { get; set; }
            /// <summary>
            /// SalesforceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-salesforcedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SalesforceDataSource { get; set; }
            /// <summary>
            /// AddOrRunAnomalyDetectionForAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-addorrunanomalydetectionforanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddOrRunAnomalyDetectionForAnalyses { get; set; }
            /// <summary>
            /// Extension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-extension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Extension { get; set; }
            /// <summary>
            /// ShareAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAnalyses { get; set; }
            /// <summary>
            /// UseGithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegithubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseGithubAction { get; set; }
            /// <summary>
            /// ServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-servicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceNowAction { get; set; }
            /// <summary>
            /// UpdateDatabricksDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedatabricksdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateDatabricksDataSource { get; set; }
            /// <summary>
            /// DocumentDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-documentdbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DocumentDbDataSource { get; set; }
            /// <summary>
            /// UseAmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseAmazonBedrockFSAction { get; set; }
            /// <summary>
            /// ShareImpalaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareimpaladatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareImpalaDataSource { get; set; }
            /// <summary>
            /// UpdateGitHubDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updategithubdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateGitHubDataSource { get; set; }
            /// <summary>
            /// Db2DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-db2datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Db2DataSource { get; set; }
            /// <summary>
            /// CreateSalesforceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createsalesforcedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateSalesforceDataSource { get; set; }
            /// <summary>
            /// NewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-newrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewRelicAction { get; set; }
            /// <summary>
            /// ShareTwitterDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetwitterdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareTwitterDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateIntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateintercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateIntercomAction { get; set; }
            /// <summary>
            /// UpdateStarburstDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatestarburstdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateStarburstDataSource { get; set; }
            /// <summary>
            /// SAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// UpdateSquareDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesquaredatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateSquareDataSource { get; set; }
            /// <summary>
            /// ShareChatAgents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharechatagents
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareChatAgents { get; set; }
            /// <summary>
            /// CreateImpalaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createimpaladatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateImpalaDataSource { get; set; }
            /// <summary>
            /// ShareStarburstDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharestarburstdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareStarburstDataSource { get; set; }
            /// <summary>
            /// ShareServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareservicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareServiceNowAction { get; set; }
            /// <summary>
            /// ApproveFlowShareRequests
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-approveflowsharerequests
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApproveFlowShareRequests { get; set; }
            /// <summary>
            /// ExportToExcelInScheduledReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttoexcelinscheduledreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToExcelInScheduledReports { get; set; }
            /// <summary>
            /// UseSharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSharePointAction { get; set; }
            /// <summary>
            /// ShareSalesforceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesalesforcedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSalesforceDataSource { get; set; }
            /// <summary>
            /// ShareSAPBusinessPartnerAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesapbusinesspartneraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSAPBusinessPartnerAction { get; set; }
            /// <summary>
            /// SAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAPProductMasterDataAction { get; set; }
            /// <summary>
            /// ComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-comprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComprehendAction { get; set; }
            /// <summary>
            /// ShareGoogleSheetsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegooglesheetsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGoogleSheetsDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateHubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatehubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateHubspotAction { get; set; }
            /// <summary>
            /// UseSandPGMIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesandpgmiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSandPGMIAction { get; set; }
            /// <summary>
            /// UseIntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useintercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseIntercomAction { get; set; }
            /// <summary>
            /// CreatePrestoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createprestodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreatePrestoDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateMondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateMondayAction { get; set; }
            /// <summary>
            /// ShareSparkDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesparkdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSparkDataSource { get; set; }
            /// <summary>
            /// CreateMySqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createmysqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateMySqlDataSource { get; set; }
            /// <summary>
            /// CreateMongoAtlasDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createmongoatlasdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateMongoAtlasDataSource { get; set; }
            /// <summary>
            /// UseGenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegenerichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseGenericHTTPAction { get; set; }
            /// <summary>
            /// SqlServerDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sqlserverdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SqlServerDataSource { get; set; }
            /// <summary>
            /// EditVisualWithQ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-editvisualwithq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EditVisualWithQ { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSAPProductMasterDataAction { get; set; }
            /// <summary>
            /// SharePointKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepointknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharePointKnowledgeBase { get; set; }
            /// <summary>
            /// InvokeAppsAIInference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-invokeappsaiinference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvokeAppsAIInference { get; set; }
            /// <summary>
            /// ShareZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharezendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareZendeskAction { get; set; }
            /// <summary>
            /// ShareIntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareintercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareIntercomAction { get; set; }
            /// <summary>
            /// ShareDynamoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedynamodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDynamoDbDataSource { get; set; }
            /// <summary>
            /// GenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-generichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GenericHTTPAction { get; set; }
            /// <summary>
            /// Research
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-research
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Research { get; set; }
            /// <summary>
            /// SapHanaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-saphanadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SapHanaDataSource { get; set; }
            /// <summary>
            /// UseBrowserExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebrowserextension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBrowserExtension { get; set; }
            /// <summary>
            /// QBusinessKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-qbusinessknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QBusinessKnowledgeBase { get; set; }
            /// <summary>
            /// CreateAndUpdateAmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateAmazonBedrockKRSAction { get; set; }
            /// <summary>
            /// CreateGoogleSheetsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creategooglesheetsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateGoogleSheetsDataSource { get; set; }
            /// <summary>
            /// UseBedrockModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebedrockmodels
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBedrockModels { get; set; }
            /// <summary>
            /// CreateAndUpdateAmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateAmazonBedrockARSAction { get; set; }
            /// <summary>
            /// CreateAndUpdateThresholdAlerts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatethresholdalerts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateThresholdAlerts { get; set; }
            /// <summary>
            /// UpdateDynamoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatedynamodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateDynamoDbDataSource { get; set; }
            /// <summary>
            /// S3KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-s3knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3KnowledgeBase { get; set; }
            /// <summary>
            /// HubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-hubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HubspotAction { get; set; }
            /// <summary>
            /// CreateStarburstDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createstarburstdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateStarburstDataSource { get; set; }
            /// <summary>
            /// RdsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-rdsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RdsDataSource { get; set; }
            /// <summary>
            /// PrestoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-prestodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrestoDataSource { get; set; }
            /// <summary>
            /// ShareSnowflakeDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesnowflakedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSnowflakeDataSource { get; set; }
            /// <summary>
            /// UseOneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useonedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseOneDriveAction { get; set; }
            /// <summary>
            /// ExportToExcel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttoexcel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToExcel { get; set; }
            /// <summary>
            /// ShareOpenSearchDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareopensearchdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareOpenSearchDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateGithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategithubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateGithubAction { get; set; }
            /// <summary>
            /// ShareS3TablesDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shares3tablesdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareS3TablesDataSource { get; set; }
            /// <summary>
            /// ShareSlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareslackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSlackAction { get; set; }
            /// <summary>
            /// CreateAndUpdateGoogleDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategoogledriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateGoogleDriveKnowledgeBase { get; set; }
            /// <summary>
            /// UpdateTwitterDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatetwitterdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateTwitterDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateSmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesmartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSmartsheetAction { get; set; }
            /// <summary>
            /// ShareBoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareboxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareBoxAgentAction { get; set; }
            /// <summary>
            /// ShareGoogleBigQueryDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegooglebigquerydatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGoogleBigQueryDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateOneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateonedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateOneDriveAction { get; set; }
            /// <summary>
            /// UpdateS3AnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updates3analyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateS3AnalyticsDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateKnowledgeBases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateknowledgebases
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateKnowledgeBases { get; set; }
            /// <summary>
            /// UpdatePayPalDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatepaypaldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdatePayPalDataSource { get; set; }
            /// <summary>
            /// ShareServiceNowDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareservicenowdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareServiceNowDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateApps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateapps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateApps { get; set; }
            /// <summary>
            /// ShareDremioDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedremiodatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDremioDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateBedrockManagedKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatebedrockmanagedknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateBedrockManagedKnowledgeBase { get; set; }
            /// <summary>
            /// UseConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useconfluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseConfluenceAction { get; set; }
            /// <summary>
            /// ImpalaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-impaladatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImpalaDataSource { get; set; }
            /// <summary>
            /// CreateOpenSearchDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createopensearchdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateOpenSearchDataSource { get; set; }
            /// <summary>
            /// AmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonSThreeAction { get; set; }
            /// <summary>
            /// ShareRedshiftManualDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareredshiftmanualdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareRedshiftManualDataSource { get; set; }
            /// <summary>
            /// SharePayPalDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepaypaldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharePayPalDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateSAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// UseMondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseMondayAction { get; set; }
            /// <summary>
            /// UseJiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usejiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseJiraAction { get; set; }
            /// <summary>
            /// CreateAthenaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createathenadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAthenaDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatecomprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateComprehendMedicalAction { get; set; }
            /// <summary>
            /// UseMSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemsteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseMSTeamsAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSalesforceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesalesforceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSalesforceAction { get; set; }
            /// <summary>
            /// PerformFlowUiTask
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-performflowuitask
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PerformFlowUiTask { get; set; }
            /// <summary>
            /// ShareGoogleDriveKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegoogledriveknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGoogleDriveKnowledgeBase { get; set; }
            /// <summary>
            /// CreateS3TablesDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-creates3tablesdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateS3TablesDataSource { get; set; }
            /// <summary>
            /// ShareSharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSharePointAction { get; set; }
            /// <summary>
            /// RadiantDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-radiantdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RadiantDataSource { get; set; }
            /// <summary>
            /// ShareWebCrawlerKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharewebcrawlerknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareWebCrawlerKnowledgeBase { get; set; }
            /// <summary>
            /// MySqlDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mysqldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MySqlDataSource { get; set; }
            /// <summary>
            /// ShareExasolDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareexasoldatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareExasolDataSource { get; set; }
            /// <summary>
            /// ShareS3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shares3datasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareS3DataSource { get; set; }
            /// <summary>
            /// SmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-smartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SmartsheetAction { get; set; }
            /// <summary>
            /// CreateDenodoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdenododatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateDenodoDataSource { get; set; }
            /// <summary>
            /// CreateDynamoDbDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdynamodbdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateDynamoDbDataSource { get; set; }
            /// <summary>
            /// ShareRdsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharerdsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareRdsDataSource { get; set; }
            /// <summary>
            /// ShareApps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareapps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareApps { get; set; }
            /// <summary>
            /// ShareMSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemsexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMSExchangeAction { get; set; }
            /// <summary>
            /// CreateAdobeAnalyticsDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createadobeanalyticsdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAdobeAnalyticsDataSource { get; set; }
            /// <summary>
            /// DenodoDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-denododatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DenodoDataSource { get; set; }
            /// <summary>
            /// CanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-canvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CanvaAgentAction { get; set; }
            /// <summary>
            /// GithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-githubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GithubAction { get; set; }
            /// <summary>
            /// ScheduleTrigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-scheduletrigger
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleTrigger { get; set; }
            /// <summary>
            /// UpdateSalesforceDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesalesforcedatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateSalesforceDataSource { get; set; }
            /// <summary>
            /// UpdateSparkDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updatesparkdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateSparkDataSource { get; set; }
            /// <summary>
            /// CreateRadiantDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createradiantdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateRadiantDataSource { get; set; }
            /// <summary>
            /// AthenaDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-athenadatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AthenaDataSource { get; set; }
            /// <summary>
            /// UpdateOracleDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-updateoracledatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UpdateOracleDataSource { get; set; }
            /// <summary>
            /// CreateAndUpdateConfluenceKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateconfluenceknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateConfluenceKnowledgeBase { get; set; }
            /// <summary>
            /// ShareAuroraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareauroradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAuroraDataSource { get; set; }
            /// <summary>
            /// ShareSharePointKnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesharepointknowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSharePointKnowledgeBase { get; set; }
            /// <summary>
            /// ExportToCsv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttocsv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToCsv { get; set; }
            /// <summary>
            /// DatabricksDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-databricksdatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabricksDataSource { get; set; }
            /// <summary>
            /// CreateJiraDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createjiradatasource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateJiraDataSource { get; set; }
            /// <summary>
            /// SalesforceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-salesforceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SalesforceAction { get; set; }
            /// <summary>
            /// ShareNotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharenotionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareNotionAction { get; set; }
        }
    }
}