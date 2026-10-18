namespace Humidifier.ComputeOptimizer
{
    using global::System.Collections.Generic;
    using AutomationRuleTypes;

    public class AutomationRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveStringListOfRecommendedActionTypes, IHaveDescription, IHavePriority, IHaveComputeOptimizerAutomationRuleTypesScheduleSchedule, IHaveRuleType, IHaveComputeOptimizerAutomationRuleTypesCriteriaCriteria, IHaveName, IHaveComputeOptimizerAutomationRuleTypesOrganizationConfigurationOrganizationConfiguration
    {
        public class Attributes
        {
            public static string RuleRevision =  "RuleRevision" ;
            public static string AccountId =  "AccountId" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string RuleArn =  "RuleArn" ;
            public static string RuleId =  "RuleId" ;
            public static string LastUpdatedTimestamp =  "LastUpdatedTimestamp" ;
        }

        public override string AWSTypeName { get => AWS.ComputeOptimizer.AutomationRule; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// RecommendedActionTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-recommendedactiontypes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RecommendedActionTypes { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-priority
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Priority { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        [Required]
        public Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.Schedule, BaseFunction>? Schedule { get; set; }

        /// <summary>
        /// RuleType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-ruletype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleType { get; set; }
        /// <summary>
        /// Criteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-criteria
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Criteria
        /// </summary>
        public Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.Criteria, BaseFunction>? Criteria { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OrganizationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-organizationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OrganizationConfiguration
        /// </summary>
        public Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.OrganizationConfiguration, BaseFunction>? OrganizationConfiguration { get; set; }
    }

    namespace AutomationRuleTypes
    {
        public class Criteria : Humidifier.Base.BaseSubResource, IHaveListOfComputeOptimizerAutomationRuleTypesDoubleCriteriaConditionEstimatedMonthlySavings, IHaveListOfComputeOptimizerAutomationRuleTypesStringCriteriaConditionResourceArn, IHaveListOfComputeOptimizerAutomationRuleTypesResourceTagsCriteriaConditionResourceTag, IHaveListOfComputeOptimizerAutomationRuleTypesStringCriteriaConditionRestartNeeded, IHaveListOfComputeOptimizerAutomationRuleTypesStringCriteriaConditionRegion, IHaveListOfComputeOptimizerAutomationRuleTypesIntegerCriteriaConditionLookBackPeriodInDays, IHaveListOfComputeOptimizerAutomationRuleTypesStringCriteriaConditionEbsVolumeType, IHaveListOfComputeOptimizerAutomationRuleTypesIntegerCriteriaConditionEbsVolumeSizeInGib
        {
            /// <summary>
            /// EstimatedMonthlySavings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-estimatedmonthlysavings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DoubleCriteriaCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ComputeOptimizer.AutomationRuleTypes.DoubleCriteriaCondition>, IReadOnlyList<Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.DoubleCriteriaCondition, BaseFunction>>, BaseFunction>? EstimatedMonthlySavings { get; set; }
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-resourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringCriteriaCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition>, IReadOnlyList<Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition, BaseFunction>>, BaseFunction>? ResourceArn { get; set; }
            /// <summary>
            /// ResourceTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-resourcetag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourceTagsCriteriaCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ComputeOptimizer.AutomationRuleTypes.ResourceTagsCriteriaCondition>, IReadOnlyList<Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.ResourceTagsCriteriaCondition, BaseFunction>>, BaseFunction>? ResourceTag { get; set; }
            /// <summary>
            /// RestartNeeded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-restartneeded
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringCriteriaCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition>, IReadOnlyList<Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition, BaseFunction>>, BaseFunction>? RestartNeeded { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-region
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringCriteriaCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition>, IReadOnlyList<Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition, BaseFunction>>, BaseFunction>? Region { get; set; }
            /// <summary>
            /// LookBackPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-lookbackperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegerCriteriaCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ComputeOptimizer.AutomationRuleTypes.IntegerCriteriaCondition>, IReadOnlyList<Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.IntegerCriteriaCondition, BaseFunction>>, BaseFunction>? LookBackPeriodInDays { get; set; }
            /// <summary>
            /// EbsVolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-ebsvolumetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringCriteriaCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition>, IReadOnlyList<Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition, BaseFunction>>, BaseFunction>? EbsVolumeType { get; set; }
            /// <summary>
            /// EbsVolumeSizeInGib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-ebsvolumesizeingib
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegerCriteriaCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ComputeOptimizer.AutomationRuleTypes.IntegerCriteriaCondition>, IReadOnlyList<Union<Humidifier.ComputeOptimizer.AutomationRuleTypes.IntegerCriteriaCondition, BaseFunction>>, BaseFunction>? EbsVolumeSizeInGib { get; set; }
        }

        public class DoubleCriteriaCondition : Humidifier.Base.BaseSubResource, IHaveComparison, IHaveDoubleListOfValues
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-doublecriteriacondition.html#cfn-computeoptimizer-automationrule-doublecriteriacondition-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-doublecriteriacondition.html#cfn-computeoptimizer-automationrule-doublecriteriacondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public Union<IReadOnlyList<double>, IReadOnlyList<Union<double, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class IntegerCriteriaCondition : Humidifier.Base.BaseSubResource, IHaveIntegerListOfValues, IHaveComparison
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-integercriteriacondition.html#cfn-computeoptimizer-automationrule-integercriteriacondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-integercriteriacondition.html#cfn-computeoptimizer-automationrule-integercriteriacondition-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
        }

        public class OrganizationConfiguration : Humidifier.Base.BaseSubResource, IHaveRuleApplyOrder, IHaveStringListOfAccountIds
        {
            /// <summary>
            /// RuleApplyOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-organizationconfiguration.html#cfn-computeoptimizer-automationrule-organizationconfiguration-ruleapplyorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleApplyOrder { get; set; }
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-organizationconfiguration.html#cfn-computeoptimizer-automationrule-organizationconfiguration-accountids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccountIds { get; set; }
        }

        public class ResourceTagsCriteriaCondition : Humidifier.Base.BaseSubResource, IHaveComparison, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-resourcetagscriteriacondition.html#cfn-computeoptimizer-automationrule-resourcetagscriteriacondition-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-resourcetagscriteriacondition.html#cfn-computeoptimizer-automationrule-resourcetagscriteriacondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-resourcetagscriteriacondition.html#cfn-computeoptimizer-automationrule-resourcetagscriteriacondition-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveScheduleExpression, IHaveExecutionWindowInMinutes_Integer, IHaveScheduleExpressionTimezone
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-schedule.html#cfn-computeoptimizer-automationrule-schedule-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// ExecutionWindowInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-schedule.html#cfn-computeoptimizer-automationrule-schedule-executionwindowinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExecutionWindowInMinutes { get; set; }
            /// <summary>
            /// ScheduleExpressionTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-schedule.html#cfn-computeoptimizer-automationrule-schedule-scheduleexpressiontimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpressionTimezone { get; set; }
        }

        public class StringCriteriaCondition : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveComparison
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-stringcriteriacondition.html#cfn-computeoptimizer-automationrule-stringcriteriacondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-stringcriteriacondition.html#cfn-computeoptimizer-automationrule-stringcriteriacondition-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
        }
    }
}