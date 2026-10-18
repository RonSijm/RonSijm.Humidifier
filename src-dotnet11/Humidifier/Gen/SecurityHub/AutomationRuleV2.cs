namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;
    using AutomationRuleV2Types;

    public class AutomationRuleV2 : Humidifier.Base.BaseResource, IHaveDescription, IHaveListOfSecurityHubAutomationRuleV2TypesAutomationRulesActionV2Actions, IHaveRuleStatus, IHaveSecurityHubAutomationRuleV2TypesCriteriaCriteria, IHaveRuleOrder_Double, IHaveRuleName, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string RuleArn =  "RuleArn" ;
            public static string RuleId =  "RuleId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.AutomationRuleV2; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrulev2.html#cfn-securityhub-automationrulev2-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrulev2.html#cfn-securityhub-automationrulev2-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AutomationRulesActionV2
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesActionV2, BaseFunction>>, BaseFunction>? Actions { get; set; }
        /// <summary>
        /// RuleStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrulev2.html#cfn-securityhub-automationrulev2-rulestatus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RuleStatus { get; set; }

        /// <summary>
        /// Criteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrulev2.html#cfn-securityhub-automationrulev2-criteria
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Criteria
        /// </summary>
        [Required]
        public Union<Humidifier.SecurityHub.AutomationRuleV2Types.Criteria, BaseFunction>? Criteria { get; set; }

        /// <summary>
        /// RuleOrder
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrulev2.html#cfn-securityhub-automationrulev2-ruleorder
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? RuleOrder { get; set; }

        /// <summary>
        /// RuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrulev2.html#cfn-securityhub-automationrulev2-rulename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-automationrulev2.html#cfn-securityhub-automationrulev2-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AutomationRuleV2Types
    {
        public class AutomationRulesActionV2 : Humidifier.Base.BaseSubResource, IHaveType, IHaveSecurityHubAutomationRuleV2TypesExternalIntegrationConfigurationExternalIntegrationConfiguration, IHaveSecurityHubAutomationRuleV2TypesAutomationRulesFindingFieldsUpdateV2FindingFieldsUpdate
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-automationrulesactionv2.html#cfn-securityhub-automationrulev2-automationrulesactionv2-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ExternalIntegrationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-automationrulesactionv2.html#cfn-securityhub-automationrulev2-automationrulesactionv2-externalintegrationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExternalIntegrationConfiguration
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.ExternalIntegrationConfiguration, BaseFunction>? ExternalIntegrationConfiguration { get; set; }
            /// <summary>
            /// FindingFieldsUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-automationrulesactionv2.html#cfn-securityhub-automationrulev2-automationrulesactionv2-findingfieldsupdate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutomationRulesFindingFieldsUpdateV2
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesFindingFieldsUpdateV2, BaseFunction>? FindingFieldsUpdate { get; set; }
        }

        public class AutomationRulesFindingFieldsUpdateV2 : Humidifier.Base.BaseSubResource, IHaveComment, IHaveStatusId_Integer, IHaveSeverityId_Integer
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-automationrulesfindingfieldsupdatev2.html#cfn-securityhub-automationrulev2-automationrulesfindingfieldsupdatev2-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// StatusId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-automationrulesfindingfieldsupdatev2.html#cfn-securityhub-automationrulev2-automationrulesfindingfieldsupdatev2-statusid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StatusId { get; set; }
            /// <summary>
            /// SeverityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-automationrulesfindingfieldsupdatev2.html#cfn-securityhub-automationrulev2-automationrulesfindingfieldsupdatev2-severityid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SeverityId { get; set; }
        }

        public class BooleanFilter : Humidifier.Base.BaseSubResource, IHaveValue_Boolean
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-booleanfilter.html#cfn-securityhub-automationrulev2-booleanfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Value { get; set; }
        }

        public class CompositeFilter : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveListOfSecurityHubAutomationRuleV2TypesOcsfStringFilterStringFilters, IHaveListOfSecurityHubAutomationRuleV2TypesOcsfBooleanFilterBooleanFilters, IHaveListOfSecurityHubAutomationRuleV2TypesOcsfDateFilterDateFilters, IHaveListOfSecurityHubAutomationRuleV2TypesOcsfNumberFilterNumberFilters, IHaveListOfSecurityHubAutomationRuleV2TypesOcsfMapFilterMapFilters
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-compositefilter.html#cfn-securityhub-automationrulev2-compositefilter-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// StringFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-compositefilter.html#cfn-securityhub-automationrulev2-compositefilter-stringfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OcsfStringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfStringFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfStringFilter, BaseFunction>>, BaseFunction>? StringFilters { get; set; }
            /// <summary>
            /// BooleanFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-compositefilter.html#cfn-securityhub-automationrulev2-compositefilter-booleanfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OcsfBooleanFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfBooleanFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfBooleanFilter, BaseFunction>>, BaseFunction>? BooleanFilters { get; set; }
            /// <summary>
            /// DateFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-compositefilter.html#cfn-securityhub-automationrulev2-compositefilter-datefilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OcsfDateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfDateFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfDateFilter, BaseFunction>>, BaseFunction>? DateFilters { get; set; }
            /// <summary>
            /// NumberFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-compositefilter.html#cfn-securityhub-automationrulev2-compositefilter-numberfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OcsfNumberFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfNumberFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfNumberFilter, BaseFunction>>, BaseFunction>? NumberFilters { get; set; }
            /// <summary>
            /// MapFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-compositefilter.html#cfn-securityhub-automationrulev2-compositefilter-mapfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OcsfMapFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfMapFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfMapFilter, BaseFunction>>, BaseFunction>? MapFilters { get; set; }
        }

        public class Criteria : Humidifier.Base.BaseSubResource, IHaveSecurityHubAutomationRuleV2TypesOcsfFindingFiltersOcsfFindingCriteria
        {
            /// <summary>
            /// OcsfFindingCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-criteria.html#cfn-securityhub-automationrulev2-criteria-ocsffindingcriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OcsfFindingFilters
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.OcsfFindingFilters, BaseFunction>? OcsfFindingCriteria { get; set; }
        }

        public class DateFilter : Humidifier.Base.BaseSubResource, IHaveSecurityHubAutomationRuleV2TypesDateRangeDateRange, IHaveStart, IHaveEnd
        {
            /// <summary>
            /// DateRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-datefilter.html#cfn-securityhub-automationrulev2-datefilter-daterange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DateRange
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.DateRange, BaseFunction>? DateRange { get; set; }
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-datefilter.html#cfn-securityhub-automationrulev2-datefilter-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-datefilter.html#cfn-securityhub-automationrulev2-datefilter-end
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-daterange.html#cfn-securityhub-automationrulev2-daterange-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-daterange.html#cfn-securityhub-automationrulev2-daterange-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class ExternalIntegrationConfiguration : Humidifier.Base.BaseSubResource, IHaveConnectorArn
        {
            /// <summary>
            /// ConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-externalintegrationconfiguration.html#cfn-securityhub-automationrulev2-externalintegrationconfiguration-connectorarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorArn { get; set; }
        }

        public class MapFilter : Humidifier.Base.BaseSubResource, IHaveComparison, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-mapfilter.html#cfn-securityhub-automationrulev2-mapfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-mapfilter.html#cfn-securityhub-automationrulev2-mapfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-mapfilter.html#cfn-securityhub-automationrulev2-mapfilter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class NumberFilter : Humidifier.Base.BaseSubResource, IHaveGte_Double, IHaveEq_Double, IHaveLte_Double
        {
            /// <summary>
            /// Gte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-numberfilter.html#cfn-securityhub-automationrulev2-numberfilter-gte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Gte { get; set; }
            /// <summary>
            /// Eq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-numberfilter.html#cfn-securityhub-automationrulev2-numberfilter-eq
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Eq { get; set; }
            /// <summary>
            /// Lte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-numberfilter.html#cfn-securityhub-automationrulev2-numberfilter-lte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Lte { get; set; }
        }

        public class OcsfBooleanFilter : Humidifier.Base.BaseSubResource, IHaveSecurityHubAutomationRuleV2TypesBooleanFilterFilter, IHaveFieldName
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfbooleanfilter.html#cfn-securityhub-automationrulev2-ocsfbooleanfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BooleanFilter
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.BooleanFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfbooleanfilter.html#cfn-securityhub-automationrulev2-ocsfbooleanfilter-fieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
        }

        public class OcsfDateFilter : Humidifier.Base.BaseSubResource, IHaveSecurityHubAutomationRuleV2TypesDateFilterFilter, IHaveFieldName
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfdatefilter.html#cfn-securityhub-automationrulev2-ocsfdatefilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateFilter
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.DateFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfdatefilter.html#cfn-securityhub-automationrulev2-ocsfdatefilter-fieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
        }

        public class OcsfFindingFilters : Humidifier.Base.BaseSubResource, IHaveListOfSecurityHubAutomationRuleV2TypesCompositeFilterCompositeFilters, IHaveCompositeOperator
        {
            /// <summary>
            /// CompositeFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsffindingfilters.html#cfn-securityhub-automationrulev2-ocsffindingfilters-compositefilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CompositeFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SecurityHub.AutomationRuleV2Types.CompositeFilter>, IReadOnlyList<Union<Humidifier.SecurityHub.AutomationRuleV2Types.CompositeFilter, BaseFunction>>, BaseFunction>? CompositeFilters { get; set; }
            /// <summary>
            /// CompositeOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsffindingfilters.html#cfn-securityhub-automationrulev2-ocsffindingfilters-compositeoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompositeOperator { get; set; }
        }

        public class OcsfMapFilter : Humidifier.Base.BaseSubResource, IHaveSecurityHubAutomationRuleV2TypesMapFilterFilter, IHaveFieldName
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfmapfilter.html#cfn-securityhub-automationrulev2-ocsfmapfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MapFilter
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.MapFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfmapfilter.html#cfn-securityhub-automationrulev2-ocsfmapfilter-fieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
        }

        public class OcsfNumberFilter : Humidifier.Base.BaseSubResource, IHaveSecurityHubAutomationRuleV2TypesNumberFilterFilter, IHaveFieldName
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfnumberfilter.html#cfn-securityhub-automationrulev2-ocsfnumberfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NumberFilter
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.NumberFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfnumberfilter.html#cfn-securityhub-automationrulev2-ocsfnumberfilter-fieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
        }

        public class OcsfStringFilter : Humidifier.Base.BaseSubResource, IHaveSecurityHubAutomationRuleV2TypesStringFilterFilter, IHaveFieldName
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfstringfilter.html#cfn-securityhub-automationrulev2-ocsfstringfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Union<Humidifier.SecurityHub.AutomationRuleV2Types.StringFilter, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-ocsfstringfilter.html#cfn-securityhub-automationrulev2-ocsfstringfilter-fieldname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
        }

        public class StringFilter : Humidifier.Base.BaseSubResource, IHaveComparison, IHaveValue
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-stringfilter.html#cfn-securityhub-automationrulev2-stringfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-automationrulev2-stringfilter.html#cfn-securityhub-automationrulev2-stringfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }
    }
}