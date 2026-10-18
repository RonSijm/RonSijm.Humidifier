namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;
    using BudgetTypes;

    public class Budget : Humidifier.Base.BaseResource, IHaveTags, IHaveDeadlineBudgetTypesUsageTrackingResourceUsageTrackingResource, IHaveDescription, IHaveListOfDeadlineBudgetTypesBudgetActionToAddActions, IHaveDeadlineBudgetTypesBudgetScheduleSchedule, IHaveDisplayName, IHaveApproximateDollarLimit_Double, IHaveFarmId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string BudgetId =  "BudgetId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Budget; }

        /// <summary>
        /// UsageTrackingResource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-usagetrackingresource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: UsageTrackingResource
        /// </summary>
        [Required]
        public Union<Humidifier.Deadline.BudgetTypes.UsageTrackingResource, BaseFunction>? UsageTrackingResource { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BudgetActionToAdd
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd>, IReadOnlyList<Union<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd, BaseFunction>>, BaseFunction>? Actions { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: BudgetSchedule
        /// </summary>
        [Required]
        public Union<Humidifier.Deadline.BudgetTypes.BudgetSchedule, BaseFunction>? Schedule { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// ApproximateDollarLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-approximatedollarlimit
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? ApproximateDollarLimit { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FarmId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BudgetTypes
    {
        public class BudgetActionToAdd : Humidifier.Base.BaseSubResource, IHaveType, IHaveDescription, IHaveThresholdPercentage_Double
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-budgetactiontoadd.html#cfn-deadline-budget-budgetactiontoadd-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-budgetactiontoadd.html#cfn-deadline-budget-budgetactiontoadd-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-budgetactiontoadd.html#cfn-deadline-budget-budgetactiontoadd-thresholdpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ThresholdPercentage { get; set; }
        }

        public class BudgetSchedule : Humidifier.Base.BaseSubResource, IHaveDeadlineBudgetTypesFixedBudgetScheduleFixed
        {
            /// <summary>
            /// Fixed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-budgetschedule.html#cfn-deadline-budget-budgetschedule-fixed
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FixedBudgetSchedule
            /// </summary>
            public Union<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule, BaseFunction>? Fixed { get; set; }
        }

        public class FixedBudgetSchedule : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-fixedbudgetschedule.html#cfn-deadline-budget-fixedbudgetschedule-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-fixedbudgetschedule.html#cfn-deadline-budget-fixedbudgetschedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class UsageTrackingResource : Humidifier.Base.BaseSubResource, IHaveQueueId
        {
            /// <summary>
            /// QueueId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-usagetrackingresource.html#cfn-deadline-budget-usagetrackingresource-queueid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueueId { get; set; }
        }
    }
}