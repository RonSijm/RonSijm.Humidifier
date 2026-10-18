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
        public class Capabilities : Humidifier.Base.BaseSubResource, IHavePublishWithoutApproval, IHaveShareComprehendAction, IHaveShareGoogleCalendarAction, IHaveUseTextractAction, IHaveUseBoxAgentAction, IHaveUseCanvaAgentAction, IHaveCreateDashboardExecutiveSummaryWithQ, IHaveUseSAPMaterialStockAction, IHaveShareComprehendMedicalAction, IHaveShareSalesforceAction, IHaveUseAgentWebSearch, IHaveMondayAction, IHaveManageSharedFolders, IHaveSpace, IHaveUseHuggingFaceAction, IHaveCreateAndUpdateCanvaAgentAction, IHaveShareNewRelicAction, IHaveShareGenericHTTPAction, IHaveSAPMaterialStockAction, IHaveShareAmazonBedrockARSAction, IHaveShareSpaces, IHaveSlackAction, IHaveAnalysis, IHaveChatAgent, IHaveShareKnowledgeBases, IHaveShareJiraAction, IHaveHuggingFaceAction, IHaveCreateAndUpdateDataSources, IHaveConfluenceAction, IHaveCreateSPICEDataset, IHaveShareOneDriveAction, IHaveUseFactSetAction, IHaveOpenAPIAction, IHaveShareMondayAction, IHaveAmazonBedrockARSAction, IHaveKnowledgeBase, IHaveShareDatasets, IHaveSharePointAction, IHaveUseGoogleCalendarAction, IHaveSandPGlobalEnergyAction, IHaveCreateAndUpdateComprehendAction, IHaveShareLinearAction, IHaveUseSalesforceAction, IHaveUseLinearAction, IHaveUseMCPAction, IHaveIntercomAction, IHaveCreateAndUpdateNewRelicAction, IHaveUseNewRelicAction, IHaveShareSAPBillOfMaterialAction, IHaveUseComprehendMedicalAction, IHaveAmazonBedrockFSAction, IHaveIncludeContentInScheduledReportsEmail, IHaveCreateAndUpdateConfluenceAction, IHaveCreateAndUpdateOpenAPIAction, IHaveDashboard, IHaveUseSandPGlobalEnergyAction, IHaveExportToPdfInScheduledReports, IHaveShareAmazonBedrockKRSAction, IHaveApps, IHaveShareSandPGMIAction, IHaveShareAsanaAction, IHaveSharePagerDutyAction, IHaveCreateAndUpdateDatasets, IHaveShareSAPMaterialStockAction, IHaveSandPGMIAction, IHaveAsanaAction, IHaveCreateAndUpdateDashboardEmailReports, IHaveBuildCalculatedFieldWithQ, IHaveShareTextractAction, IHaveShareDashboards, IHaveUseSAPProductMasterDataAction, IHaveCreateAndUpdateZendeskAction, IHaveUsePagerDutyAction, IHaveCreateAndUpdateJiraAction, IHaveSubscribeDashboardEmailReports, IHaveUseBambooHRAction, IHaveCreateAndUpdateServiceNowAction, IHaveCreateAndUpdatePagerDutyAction, IHaveTextractAction, IHaveCreateAndUpdateGoogleCalendarAction, IHaveCreateAndUpdateMCPAction, IHaveShareAmazonSThreeAction, IHaveAction, IHaveExportToCsvInScheduledReports, IHaveAccessAppsNativeDataStore, IHaveSAPPhysicalInventoryAction, IHaveCreateAndUpdateHuggingFaceAction, IHaveFactSetAction, IHaveGoogleCalendarAction, IHaveUseSAPBillOfMaterialAction, IHaveJiraAction, IHaveCreateAndUpdateBoxAgentAction, IHaveUseMSExchangeAction, IHaveMSTeamsAction, IHaveCreateAndUpdateSAPBusinessPartnerAction, IHaveShareHubspotAction, IHaveShareSAPPhysicalInventoryAction, IHaveBambooHRAction, IHaveCreateAndUpdateSAPPhysicalInventoryAction, IHaveCreateSharedFolders, IHaveShareBambooHRAction, IHaveZendeskAction, IHaveAddOrRunAnomalyDetectionForAnalyses, IHaveCreateAndUpdateSlackAction, IHaveUseHubspotAction, IHaveExtension, IHaveAutomate, IHaveExportToPdf, IHaveShareAnalyses, IHaveShareOpenAPIAction, IHaveUseGithubAction, IHaveServiceNowAction, IHaveUseOpenAPIAction, IHaveUseAmazonBedrockFSAction, IHaveCreateAndUpdateLinearAction, IHaveNewRelicAction, IHaveUseNotionAction, IHaveCreateAndUpdateIntercomAction, IHaveCreateAndUpdateFactSetAction, IHaveSAPBillOfMaterialAction, IHaveShareChatAgents, IHaveCreateAndUpdateMSTeamsAction, IHaveCreateAndUpdateSharePointAction, IHavePrintReports, IHaveShareServiceNowAction, IHaveApproveFlowShareRequests, IHaveExportToExcelInScheduledReports, IHaveUseSharePointAction, IHaveShareSmartsheetAction, IHaveShareHuggingFaceAction, IHaveShareConfluenceAction, IHaveRenameSharedFolders, IHaveShareSAPBusinessPartnerAction, IHaveSAPProductMasterDataAction, IHaveComprehendAction, IHaveComprehendMedicalAction, IHaveCreateAndUpdateHubspotAction, IHaveUseSandPGMIAction, IHaveUseIntercomAction, IHaveCreateAndUpdateMondayAction, IHaveShareMSTeamsAction, IHaveUseAmazonBedrockKRSAction, IHaveUseGenericHTTPAction, IHaveShareFactSetAction, IHaveShareMCPAction, IHaveEditVisualWithQ, IHaveCreateAndUpdateSAPProductMasterDataAction, IHaveInvokeAppsAIInference, IHaveShareZendeskAction, IHaveShareIntercomAction, IHaveGenericHTTPAction, IHaveResearch, IHaveShareSAPProductMasterDataAction, IHaveAmazonBedrockKRSAction, IHaveCreateAndUpdateAmazonBedrockKRSAction, IHaveCreateAndUpdateSandPGMIAction, IHaveShareAmazonBedrockFSAction, IHaveUseBedrockModels, IHaveMCPAction, IHaveCreateAndUpdateAmazonBedrockARSAction, IHaveCreateAndUpdateThresholdAlerts, IHaveLinearAction, IHaveHubspotAction, IHaveCreateAndUpdateNotionAction, IHaveUseOneDriveAction, IHaveFlow, IHaveExportToExcel, IHaveMSExchangeAction, IHaveUseAsanaAction, IHaveCreateAndUpdateSandPGlobalEnergyAction, IHaveUseSlackAction, IHaveCreateAndUpdateGithubAction, IHaveBoxAgentAction, IHaveUseZendeskAction, IHaveUseServiceNowAction, IHaveCreateSpaces, IHaveShareSlackAction, IHaveUseAmazonSThreeAction, IHaveCreateAndUpdateSmartsheetAction, IHaveShareBoxAgentAction, IHaveSAPBusinessPartnerAction, IHaveUseSAPPhysicalInventoryAction, IHaveCreateAndUpdateAmazonSThreeAction, IHaveCreateAndUpdateOneDriveAction, IHaveShareCanvaAgentAction, IHaveCreateAndUpdateKnowledgeBases, IHaveCreateAndUpdateApps, IHaveUseConfluenceAction, IHaveUseSmartsheetAction, IHaveAmazonSThreeAction, IHaveCreateAndUpdateBambooHRAction, IHaveCreateAndUpdateSAPBillOfMaterialAction, IHaveUseMondayAction, IHaveUseJiraAction, IHaveCreateAndUpdateComprehendMedicalAction, IHaveUseMSTeamsAction, IHaveShareSandPGlobalEnergyAction, IHaveCreateAndUpdateSalesforceAction, IHavePerformFlowUiTask, IHaveUseComprehendAction, IHaveCreateAndUpdateSAPMaterialStockAction, IHaveOneDriveAction, IHaveShareSharePointAction, IHaveCreateAndUpdateThemes, IHaveUseSAPBusinessPartnerAction, IHaveSmartsheetAction, IHaveViewAccountSPICECapacity, IHaveCreateAndUpdateGenericHTTPAction, IHaveCreateAndUpdateAmazonBedrockFSAction, IHaveShareApps, IHaveNotionAction, IHaveShareMSExchangeAction, IHaveCreateAndUpdateAsanaAction, IHaveCanvaAgentAction, IHavePagerDutyAction, IHaveCreateAndUpdateMSExchangeAction, IHaveTopic, IHaveGithubAction, IHaveCreateAndUpdateTextractAction, IHaveShareDataSources, IHaveShareGithubAction, IHaveUseAmazonBedrockARSAction, IHaveCreateChatAgents, IHaveExportToCsv, IHaveSalesforceAction, IHaveShareNotionAction
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
            /// ShareComprehendAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharecomprehendaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareComprehendAction { get; set; }
            /// <summary>
            /// ShareGoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegooglecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGoogleCalendarAction { get; set; }
            /// <summary>
            /// UseTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseTextractAction { get; set; }
            /// <summary>
            /// UseBoxAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useboxagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBoxAgentAction { get; set; }
            /// <summary>
            /// UseCanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usecanvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseCanvaAgentAction { get; set; }
            /// <summary>
            /// CreateDashboardExecutiveSummaryWithQ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createdashboardexecutivesummarywithq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateDashboardExecutiveSummaryWithQ { get; set; }
            /// <summary>
            /// UseSAPMaterialStockAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapmaterialstockaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSAPMaterialStockAction { get; set; }
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
            /// MondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MondayAction { get; set; }
            /// <summary>
            /// ManageSharedFolders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-managesharedfolders
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManageSharedFolders { get; set; }
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
            /// ShareGenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharegenerichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareGenericHTTPAction { get; set; }
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
            /// ShareKnowledgeBases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareknowledgebases
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareKnowledgeBases { get; set; }
            /// <summary>
            /// ShareJiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharejiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareJiraAction { get; set; }
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
            /// ConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-confluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfluenceAction { get; set; }
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
            /// OpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-openapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OpenAPIAction { get; set; }
            /// <summary>
            /// ShareMondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMondayAction { get; set; }
            /// <summary>
            /// AmazonBedrockARSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonbedrockarsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonBedrockARSAction { get; set; }
            /// <summary>
            /// KnowledgeBase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-knowledgebase
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KnowledgeBase { get; set; }
            /// <summary>
            /// ShareDatasets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedatasets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDatasets { get; set; }
            /// <summary>
            /// SharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharePointAction { get; set; }
            /// <summary>
            /// UseGoogleCalendarAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegooglecalendaraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseGoogleCalendarAction { get; set; }
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
            /// ShareLinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharelinearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareLinearAction { get; set; }
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
            /// UseMCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usemcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseMCPAction { get; set; }
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
            /// CreateAndUpdateOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateOpenAPIAction { get; set; }
            /// <summary>
            /// Dashboard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-dashboard
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Dashboard { get; set; }
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
            /// ShareAsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareasanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAsanaAction { get; set; }
            /// <summary>
            /// SharePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SharePagerDutyAction { get; set; }
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
            /// AsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-asanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AsanaAction { get; set; }
            /// <summary>
            /// CreateAndUpdateDashboardEmailReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatedashboardemailreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateDashboardEmailReports { get; set; }
            /// <summary>
            /// BuildCalculatedFieldWithQ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-buildcalculatedfieldwithq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BuildCalculatedFieldWithQ { get; set; }
            /// <summary>
            /// ShareTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareTextractAction { get; set; }
            /// <summary>
            /// ShareDashboards
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharedashboards
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareDashboards { get; set; }
            /// <summary>
            /// UseSAPProductMasterDataAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesapproductmasterdataaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSAPProductMasterDataAction { get; set; }
            /// <summary>
            /// CreateAndUpdateZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatezendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateZendeskAction { get; set; }
            /// <summary>
            /// UsePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsePagerDutyAction { get; set; }
            /// <summary>
            /// CreateAndUpdateJiraAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatejiraaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateJiraAction { get; set; }
            /// <summary>
            /// SubscribeDashboardEmailReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-subscribedashboardemailreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubscribeDashboardEmailReports { get; set; }
            /// <summary>
            /// UseBambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBambooHRAction { get; set; }
            /// <summary>
            /// CreateAndUpdateServiceNowAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateservicenowaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateServiceNowAction { get; set; }
            /// <summary>
            /// CreateAndUpdatePagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatepagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdatePagerDutyAction { get; set; }
            /// <summary>
            /// TextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-textractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextractAction { get; set; }
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
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// ExportToCsvInScheduledReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttocsvinscheduledreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToCsvInScheduledReports { get; set; }
            /// <summary>
            /// AccessAppsNativeDataStore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-accessappsnativedatastore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessAppsNativeDataStore { get; set; }
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
            /// ZendeskAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-zendeskaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ZendeskAction { get; set; }
            /// <summary>
            /// AddOrRunAnomalyDetectionForAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-addorrunanomalydetectionforanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AddOrRunAnomalyDetectionForAnalyses { get; set; }
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
            /// Extension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-extension
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Extension { get; set; }
            /// <summary>
            /// Automate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-automate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Automate { get; set; }
            /// <summary>
            /// ExportToPdf
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttopdf
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToPdf { get; set; }
            /// <summary>
            /// ShareAnalyses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareanalyses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareAnalyses { get; set; }
            /// <summary>
            /// ShareOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareOpenAPIAction { get; set; }
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
            /// UseOpenAPIAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useopenapiaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseOpenAPIAction { get; set; }
            /// <summary>
            /// UseAmazonBedrockFSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonbedrockfsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseAmazonBedrockFSAction { get; set; }
            /// <summary>
            /// CreateAndUpdateLinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatelinearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateLinearAction { get; set; }
            /// <summary>
            /// NewRelicAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-newrelicaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NewRelicAction { get; set; }
            /// <summary>
            /// UseNotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usenotionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseNotionAction { get; set; }
            /// <summary>
            /// CreateAndUpdateIntercomAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateintercomaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateIntercomAction { get; set; }
            /// <summary>
            /// CreateAndUpdateFactSetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatefactsetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateFactSetAction { get; set; }
            /// <summary>
            /// SAPBillOfMaterialAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sapbillofmaterialaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SAPBillOfMaterialAction { get; set; }
            /// <summary>
            /// ShareChatAgents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharechatagents
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareChatAgents { get; set; }
            /// <summary>
            /// CreateAndUpdateMSTeamsAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemsteamsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateMSTeamsAction { get; set; }
            /// <summary>
            /// CreateAndUpdateSharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatesharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateSharePointAction { get; set; }
            /// <summary>
            /// PrintReports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-printreports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrintReports { get; set; }
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
            /// ComprehendMedicalAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-comprehendmedicalaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComprehendMedicalAction { get; set; }
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
            /// CreateAndUpdateMondayAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatemondayaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateMondayAction { get; set; }
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
            /// UseGenericHTTPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usegenerichttpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseGenericHTTPAction { get; set; }
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
            /// CreateAndUpdateAmazonBedrockKRSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonbedrockkrsaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateAmazonBedrockKRSAction { get; set; }
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
            /// UseBedrockModels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usebedrockmodels
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseBedrockModels { get; set; }
            /// <summary>
            /// MCPAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-mcpaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MCPAction { get; set; }
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
            /// LinearAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-linearaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LinearAction { get; set; }
            /// <summary>
            /// HubspotAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-hubspotaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HubspotAction { get; set; }
            /// <summary>
            /// CreateAndUpdateNotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatenotionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateNotionAction { get; set; }
            /// <summary>
            /// UseOneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useonedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseOneDriveAction { get; set; }
            /// <summary>
            /// Flow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-flow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Flow { get; set; }
            /// <summary>
            /// ExportToExcel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttoexcel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToExcel { get; set; }
            /// <summary>
            /// MSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-msexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MSExchangeAction { get; set; }
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
            /// CreateAndUpdateGithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdategithubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateGithubAction { get; set; }
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
            /// ShareSlackAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareslackaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSlackAction { get; set; }
            /// <summary>
            /// UseAmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useamazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseAmazonSThreeAction { get; set; }
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
            /// CreateAndUpdateAmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateamazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateAmazonSThreeAction { get; set; }
            /// <summary>
            /// CreateAndUpdateOneDriveAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateonedriveaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateOneDriveAction { get; set; }
            /// <summary>
            /// ShareCanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharecanvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareCanvaAgentAction { get; set; }
            /// <summary>
            /// CreateAndUpdateKnowledgeBases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateknowledgebases
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateKnowledgeBases { get; set; }
            /// <summary>
            /// CreateAndUpdateApps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateapps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateApps { get; set; }
            /// <summary>
            /// UseConfluenceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-useconfluenceaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseConfluenceAction { get; set; }
            /// <summary>
            /// UseSmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-usesmartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UseSmartsheetAction { get; set; }
            /// <summary>
            /// AmazonSThreeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-amazonsthreeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmazonSThreeAction { get; set; }
            /// <summary>
            /// CreateAndUpdateBambooHRAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatebamboohraction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateBambooHRAction { get; set; }
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
            /// ShareSandPGlobalEnergyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesandpglobalenergyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSandPGlobalEnergyAction { get; set; }
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
            /// ShareSharePointAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharesharepointaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareSharePointAction { get; set; }
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
            /// SmartsheetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-smartsheetaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SmartsheetAction { get; set; }
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
            /// ShareApps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-shareapps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareApps { get; set; }
            /// <summary>
            /// NotionAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-notionaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotionAction { get; set; }
            /// <summary>
            /// ShareMSExchangeAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-sharemsexchangeaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareMSExchangeAction { get; set; }
            /// <summary>
            /// CreateAndUpdateAsanaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdateasanaaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateAsanaAction { get; set; }
            /// <summary>
            /// CanvaAgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-canvaagentaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CanvaAgentAction { get; set; }
            /// <summary>
            /// PagerDutyAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-pagerdutyaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PagerDutyAction { get; set; }
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
            /// GithubAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-githubaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GithubAction { get; set; }
            /// <summary>
            /// CreateAndUpdateTextractAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-createandupdatetextractaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreateAndUpdateTextractAction { get; set; }
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
            /// ExportToCsv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-custompermissions-capabilities.html#cfn-quicksight-custompermissions-capabilities-exporttocsv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExportToCsv { get; set; }
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