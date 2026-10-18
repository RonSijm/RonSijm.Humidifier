namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;
    using AutomationRuleTypes;

    public class AutomationRule : Humidifier.Base.BaseResource, IHaveDescription, IHaveListOfSecurityHubAutomationRuleTypesAutomationRulesActionActions, IHaveIsTerminal_Boolean, IHaveRuleStatus, IHaveSecurityHubAutomationRuleTypesAutomationRulesFindingFiltersCriteria, IHaveRuleOrder_Integer, IHaveRuleName, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string CreatedBy =  "CreatedBy" ;
            public static string RuleArn =  "RuleArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.AutomationRule; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrule.html#cfn-securityhub-automationrule-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrule.html#cfn-securityhub-automationrule-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AutomationRulesAction
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesAction, BaseFunction>>, BaseFunction>? Actions { get; set; }
        /// <summary>
        /// IsTerminal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrule.html#cfn-securityhub-automationrule-isterminal
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsTerminal { get; set; }
        /// <summary>
        /// RuleStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrule.html#cfn-securityhub-automationrule-rulestatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RuleStatus { get; set; }

        /// <summary>
        /// Criteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrule.html#cfn-securityhub-automationrule-criteria
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AutomationRulesFindingFilters
        /// </summary>
        [Required]
        public Union<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters, BaseFunction>? Criteria { get; set; }

        /// <summary>
        /// RuleOrder
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrule.html#cfn-securityhub-automationrule-ruleorder
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? RuleOrder { get; set; }

        /// <summary>
        /// RuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrule.html#cfn-securityhub-automationrule-rulename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrule.html#cfn-securityhub-automationrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AutomationRuleTypes
    {
        public class AutomationRulesAction : Humidifier.Base.BaseSubResource, IHaveType, IHaveSecurityHubAutomationRuleTypesAutomationRulesFindingFieldsUpdateFindingFieldsUpdate
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesaction.html#cfn-securityhub-automationrule-automationrulesaction-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// FindingFieldsUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesaction.html#cfn-securityhub-automationrule-automationrulesaction-findingfieldsupdate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AutomationRulesFindingFieldsUpdate
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFieldsUpdate, BaseFunction>? FindingFieldsUpdate { get; set; }
        }

        public class AutomationRulesFindingFieldsUpdate : Humidifier.Base.BaseSubResource, IHaveStringListOfTypes, IHaveConfidence_Integer, IHaveSecurityHubAutomationRuleTypesNoteUpdateNote, IHaveVerificationState, IHaveListOfSecurityHubAutomationRuleTypesRelatedFindingRelatedFindings, IHaveSecurityHubAutomationRuleTypesWorkflowUpdateWorkflow, IHaveSecurityHubAutomationRuleTypesSeverityUpdateSeverity, IHaveStringDictionaryOfUserDefinedFields, IHaveCriticality_Integer
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Types { get; set; }
            /// <summary>
            /// Confidence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-confidence
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Confidence { get; set; }
            /// <summary>
            /// Note
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-note
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoteUpdate
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleTypes.NoteUpdate, BaseFunction>? Note { get; set; }
            /// <summary>
            /// VerificationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-verificationstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VerificationState { get; set; }
            /// <summary>
            /// RelatedFindings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-relatedfindings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RelatedFinding
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.RelatedFinding>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.RelatedFinding, BaseFunction>>, BaseFunction>? RelatedFindings { get; set; }
            /// <summary>
            /// Workflow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-workflow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkflowUpdate
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleTypes.WorkflowUpdate, BaseFunction>? Workflow { get; set; }
            /// <summary>
            /// Severity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-severity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SeverityUpdate
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleTypes.SeverityUpdate, BaseFunction>? Severity { get; set; }
            /// <summary>
            /// UserDefinedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-userdefinedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? UserDefinedFields { get; set; }
            /// <summary>
            /// Criticality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfieldsupdate.html#cfn-securityhub-automationrule-automationrulesfindingfieldsupdate-criticality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Criticality { get; set; }
        }

        public class AutomationRulesFindingFilters : Humidifier.Base.BaseSubResource, IHaveListOfSecurityHubAutomationRuleTypesStringFilterProductArn, IHaveListOfSecurityHubAutomationRuleTypesStringFilterSourceUrl, IHaveListOfSecurityHubAutomationRuleTypesMapFilterResourceDetailsOther, IHaveListOfSecurityHubAutomationRuleTypesStringFilterDescription, IHaveListOfSecurityHubAutomationRuleTypesStringFilterProductName, IHaveListOfSecurityHubAutomationRuleTypesMapFilterResourceTags, IHaveListOfSecurityHubAutomationRuleTypesDateFilterFirstObservedAt, IHaveListOfSecurityHubAutomationRuleTypesDateFilterCreatedAt, IHaveListOfSecurityHubAutomationRuleTypesStringFilterNoteText, IHaveListOfSecurityHubAutomationRuleTypesDateFilterLastObservedAt, IHaveListOfSecurityHubAutomationRuleTypesMapFilterUserDefinedFields, IHaveListOfSecurityHubAutomationRuleTypesDateFilterNoteUpdatedAt, IHaveListOfSecurityHubAutomationRuleTypesStringFilterComplianceSecurityControlId, IHaveListOfSecurityHubAutomationRuleTypesStringFilterCompanyName, IHaveListOfSecurityHubAutomationRuleTypesStringFilterResourceRegion, IHaveListOfSecurityHubAutomationRuleTypesStringFilterNoteUpdatedBy, IHaveListOfSecurityHubAutomationRuleTypesNumberFilterConfidence, IHaveListOfSecurityHubAutomationRuleTypesStringFilterResourcePartition, IHaveListOfSecurityHubAutomationRuleTypesStringFilterVerificationState, IHaveListOfSecurityHubAutomationRuleTypesNumberFilterCriticality, IHaveListOfSecurityHubAutomationRuleTypesStringFilterSeverityLabel, IHaveListOfSecurityHubAutomationRuleTypesStringFilterRelatedFindingsProductArn, IHaveListOfSecurityHubAutomationRuleTypesStringFilterComplianceStatus, IHaveListOfSecurityHubAutomationRuleTypesStringFilterGeneratorId, IHaveListOfSecurityHubAutomationRuleTypesStringFilterRecordState, IHaveListOfSecurityHubAutomationRuleTypesStringFilterTitle, IHaveListOfSecurityHubAutomationRuleTypesStringFilterResourceType, IHaveListOfSecurityHubAutomationRuleTypesStringFilterComplianceAssociatedStandardsId, IHaveListOfSecurityHubAutomationRuleTypesDateFilterUpdatedAt, IHaveListOfSecurityHubAutomationRuleTypesStringFilterRelatedFindingsId, IHaveListOfSecurityHubAutomationRuleTypesStringFilterWorkflowStatus, IHaveListOfSecurityHubAutomationRuleTypesStringFilterType, IHaveListOfSecurityHubAutomationRuleTypesStringFilterResourceId, IHaveListOfSecurityHubAutomationRuleTypesStringFilterAwsAccountId, IHaveListOfSecurityHubAutomationRuleTypesStringFilterId
        {
            /// <summary>
            /// ProductArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-productarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ProductArn { get; set; }
            /// <summary>
            /// SourceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-sourceurl
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? SourceUrl { get; set; }
            /// <summary>
            /// ResourceDetailsOther
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-resourcedetailsother
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.MapFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.MapFilter, BaseFunction>>, BaseFunction>? ResourceDetailsOther { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-description
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ProductName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-productname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ProductName { get; set; }
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-resourcetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.MapFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.MapFilter, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }
            /// <summary>
            /// FirstObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-firstobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter, BaseFunction>>, BaseFunction>? FirstObservedAt { get; set; }
            /// <summary>
            /// CreatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-createdat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter, BaseFunction>>, BaseFunction>? CreatedAt { get; set; }
            /// <summary>
            /// NoteText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-notetext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? NoteText { get; set; }
            /// <summary>
            /// LastObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-lastobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter, BaseFunction>>, BaseFunction>? LastObservedAt { get; set; }
            /// <summary>
            /// UserDefinedFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-userdefinedfields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.MapFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.MapFilter, BaseFunction>>, BaseFunction>? UserDefinedFields { get; set; }
            /// <summary>
            /// NoteUpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-noteupdatedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter, BaseFunction>>, BaseFunction>? NoteUpdatedAt { get; set; }
            /// <summary>
            /// ComplianceSecurityControlId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-compliancesecuritycontrolid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ComplianceSecurityControlId { get; set; }
            /// <summary>
            /// CompanyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-companyname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? CompanyName { get; set; }
            /// <summary>
            /// ResourceRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-resourceregion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ResourceRegion { get; set; }
            /// <summary>
            /// NoteUpdatedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-noteupdatedby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? NoteUpdatedBy { get; set; }
            /// <summary>
            /// Confidence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-confidence
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.NumberFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.NumberFilter, BaseFunction>>, BaseFunction>? Confidence { get; set; }
            /// <summary>
            /// ResourcePartition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-resourcepartition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ResourcePartition { get; set; }
            /// <summary>
            /// VerificationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-verificationstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? VerificationState { get; set; }
            /// <summary>
            /// Criticality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-criticality
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.NumberFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.NumberFilter, BaseFunction>>, BaseFunction>? Criticality { get; set; }
            /// <summary>
            /// SeverityLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-severitylabel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? SeverityLabel { get; set; }
            /// <summary>
            /// RelatedFindingsProductArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-relatedfindingsproductarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? RelatedFindingsProductArn { get; set; }
            /// <summary>
            /// ComplianceStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-compliancestatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ComplianceStatus { get; set; }
            /// <summary>
            /// GeneratorId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-generatorid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? GeneratorId { get; set; }
            /// <summary>
            /// RecordState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-recordstate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? RecordState { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? Title { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// ComplianceAssociatedStandardsId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-complianceassociatedstandardsid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ComplianceAssociatedStandardsId { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.DateFilter, BaseFunction>>, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// RelatedFindingsId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-relatedfindingsid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? RelatedFindingsId { get; set; }
            /// <summary>
            /// WorkflowStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-workflowstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? WorkflowStatus { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-type
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-resourceid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// AwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-awsaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? AwsAccountId { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-automationrulesfindingfilters.html#cfn-securityhub-automationrule-automationrulesfindingfilters-id
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleTypes.StringFilter, BaseFunction>>, BaseFunction>? Id { get; set; }
        }

        public class DateFilter : Humidifier.Base.BaseSubResource, IHaveStart, IHaveSecurityHubAutomationRuleTypesDateRangeDateRange, IHaveEnd
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-datefilter.html#cfn-securityhub-automationrule-datefilter-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// DateRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-datefilter.html#cfn-securityhub-automationrule-datefilter-daterange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateRange
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleTypes.DateRange, BaseFunction>? DateRange { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-datefilter.html#cfn-securityhub-automationrule-datefilter-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
        }

        public class DateRange : Humidifier.Base.BaseSubResource, IHaveValue_Double, IHaveUnit
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-daterange.html#cfn-securityhub-automationrule-daterange-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-daterange.html#cfn-securityhub-automationrule-daterange-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class MapFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveComparison, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-mapfilter.html#cfn-securityhub-automationrule-mapfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-mapfilter.html#cfn-securityhub-automationrule-mapfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-mapfilter.html#cfn-securityhub-automationrule-mapfilter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class NoteUpdate : Humidifier.Base.BaseSubResource, IHaveUpdatedBy_Json, IHaveText
        {
            /// <summary>
            /// UpdatedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-noteupdate.html#cfn-securityhub-automationrule-noteupdate-updatedby
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? UpdatedBy { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-noteupdate.html#cfn-securityhub-automationrule-noteupdate-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class NumberFilter : Humidifier.Base.BaseSubResource, IHaveEq_Double, IHaveLte_Double, IHaveGte_Double
        {
            /// <summary>
            /// Eq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-numberfilter.html#cfn-securityhub-automationrule-numberfilter-eq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Eq { get; set; }
            /// <summary>
            /// Lte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-numberfilter.html#cfn-securityhub-automationrule-numberfilter-lte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Lte { get; set; }
            /// <summary>
            /// Gte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-numberfilter.html#cfn-securityhub-automationrule-numberfilter-gte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Gte { get; set; }
        }

        public class RelatedFinding : Humidifier.Base.BaseSubResource, IHaveProductArn, IHaveId_Json
        {
            /// <summary>
            /// ProductArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-relatedfinding.html#cfn-securityhub-automationrule-relatedfinding-productarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProductArn { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-relatedfinding.html#cfn-securityhub-automationrule-relatedfinding-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Id { get; set; }
        }

        public class SeverityUpdate : Humidifier.Base.BaseSubResource, IHaveNormalized_Integer, IHaveLabel, IHaveProduct_Double
        {
            /// <summary>
            /// Normalized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-severityupdate.html#cfn-securityhub-automationrule-severityupdate-normalized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Normalized { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-severityupdate.html#cfn-securityhub-automationrule-severityupdate-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Label { get; set; }
            /// <summary>
            /// Product
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-severityupdate.html#cfn-securityhub-automationrule-severityupdate-product
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Product { get; set; }
        }

        public class StringFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveComparison
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-stringfilter.html#cfn-securityhub-automationrule-stringfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-stringfilter.html#cfn-securityhub-automationrule-stringfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
        }

        public class WorkflowUpdate : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrule-workflowupdate.html#cfn-securityhub-automationrule-workflowupdate-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }
    }
}