namespace Humidifier.ComputeOptimizer
{
    using global::System.Collections.Generic;
    using AutomationRuleTypes;

    public class AutomationRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveStatus, IHavePriority
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
        public dynamic Status { get; set; }

        /// <summary>
        /// RecommendedActionTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-recommendedactiontypes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic RecommendedActionTypes { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-priority
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Priority { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        [Required]
        public Humidifier.ComputeOptimizer.AutomationRuleTypes.Schedule Schedule { get; set; }

        /// <summary>
        /// RuleType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-ruletype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuleType { get; set; }
        /// <summary>
        /// Criteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-criteria
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Criteria
        /// </summary>
        public Humidifier.ComputeOptimizer.AutomationRuleTypes.Criteria Criteria { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// OrganizationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-computeoptimizer-automationrule.html#cfn-computeoptimizer-automationrule-organizationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OrganizationConfiguration
        /// </summary>
        public Humidifier.ComputeOptimizer.AutomationRuleTypes.OrganizationConfiguration OrganizationConfiguration { get; set; }
    }

    namespace AutomationRuleTypes
    {
        public class Criteria : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EstimatedMonthlySavings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-estimatedmonthlysavings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DoubleCriteriaCondition
            /// </summary>
            public List<Humidifier.ComputeOptimizer.AutomationRuleTypes.DoubleCriteriaCondition> EstimatedMonthlySavings { get; set; }
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-resourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringCriteriaCondition
            /// </summary>
            public List<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition> ResourceArn { get; set; }
            /// <summary>
            /// ResourceTag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-resourcetag
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourceTagsCriteriaCondition
            /// </summary>
            public List<Humidifier.ComputeOptimizer.AutomationRuleTypes.ResourceTagsCriteriaCondition> ResourceTag { get; set; }
            /// <summary>
            /// RestartNeeded
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-restartneeded
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringCriteriaCondition
            /// </summary>
            public List<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition> RestartNeeded { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-region
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringCriteriaCondition
            /// </summary>
            public List<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition> Region { get; set; }
            /// <summary>
            /// LookBackPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-lookbackperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegerCriteriaCondition
            /// </summary>
            public List<Humidifier.ComputeOptimizer.AutomationRuleTypes.IntegerCriteriaCondition> LookBackPeriodInDays { get; set; }
            /// <summary>
            /// EbsVolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-ebsvolumetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringCriteriaCondition
            /// </summary>
            public List<Humidifier.ComputeOptimizer.AutomationRuleTypes.StringCriteriaCondition> EbsVolumeType { get; set; }
            /// <summary>
            /// EbsVolumeSizeInGib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-criteria.html#cfn-computeoptimizer-automationrule-criteria-ebsvolumesizeingib
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IntegerCriteriaCondition
            /// </summary>
            public List<Humidifier.ComputeOptimizer.AutomationRuleTypes.IntegerCriteriaCondition> EbsVolumeSizeInGib { get; set; }
        }

        public class DoubleCriteriaCondition : Humidifier.Base.BaseSubResource, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-doublecriteriacondition.html#cfn-computeoptimizer-automationrule-doublecriteriacondition-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-doublecriteriacondition.html#cfn-computeoptimizer-automationrule-doublecriteriacondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> Values { get; set; }
        }

        public class IntegerCriteriaCondition : Humidifier.Base.BaseSubResource, IHaveComparison
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-integercriteriacondition.html#cfn-computeoptimizer-automationrule-integercriteriacondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> Values { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-integercriteriacondition.html#cfn-computeoptimizer-automationrule-integercriteriacondition-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
        }

        public class OrganizationConfiguration : Humidifier.Base.BaseSubResource, IHaveAccountIds
        {
            /// <summary>
            /// RuleApplyOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-organizationconfiguration.html#cfn-computeoptimizer-automationrule-organizationconfiguration-ruleapplyorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleApplyOrder { get; set; }
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-organizationconfiguration.html#cfn-computeoptimizer-automationrule-organizationconfiguration-accountids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AccountIds { get; set; }
        }

        public class ResourceTagsCriteriaCondition : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-resourcetagscriteriacondition.html#cfn-computeoptimizer-automationrule-resourcetagscriteriacondition-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-resourcetagscriteriacondition.html#cfn-computeoptimizer-automationrule-resourcetagscriteriacondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-resourcetagscriteriacondition.html#cfn-computeoptimizer-automationrule-resourcetagscriteriacondition-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveScheduleExpression, IHaveScheduleExpressionTimezone
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-schedule.html#cfn-computeoptimizer-automationrule-schedule-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression { get; set; }
            /// <summary>
            /// ExecutionWindowInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-schedule.html#cfn-computeoptimizer-automationrule-schedule-executionwindowinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExecutionWindowInMinutes { get; set; }
            /// <summary>
            /// ScheduleExpressionTimezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-schedule.html#cfn-computeoptimizer-automationrule-schedule-scheduleexpressiontimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpressionTimezone { get; set; }
        }

        public class StringCriteriaCondition : Humidifier.Base.BaseSubResource, IHaveValues, IHaveComparison
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-stringcriteriacondition.html#cfn-computeoptimizer-automationrule-stringcriteriacondition-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-computeoptimizer-automationrule-stringcriteriacondition.html#cfn-computeoptimizer-automationrule-stringcriteriacondition-comparison
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
        }
    }
}