namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;
    using BudgetTypes;

    public class Budget : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveDisplayName, IHaveFarmId
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
        public Humidifier.Deadline.BudgetTypes.UsageTrackingResource UsageTrackingResource { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BudgetActionToAdd
        /// </summary>
        [Required]
        public List<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> Actions { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: BudgetSchedule
        /// </summary>
        [Required]
        public Humidifier.Deadline.BudgetTypes.BudgetSchedule Schedule { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }

        /// <summary>
        /// ApproximateDollarLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-approximatedollarlimit
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public dynamic ApproximateDollarLimit { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FarmId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-budget.html#cfn-deadline-budget-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace BudgetTypes
    {
        public class BudgetActionToAdd : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveType, IHaveThresholdPercentage
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-budgetactiontoadd.html#cfn-deadline-budget-budgetactiontoadd-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-budgetactiontoadd.html#cfn-deadline-budget-budgetactiontoadd-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-budgetactiontoadd.html#cfn-deadline-budget-budgetactiontoadd-thresholdpercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ThresholdPercentage { get; set; }
        }

        public class BudgetSchedule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Fixed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-budgetschedule.html#cfn-deadline-budget-budgetschedule-fixed
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FixedBudgetSchedule
            /// </summary>
            public Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule Fixed { get; set; }
        }

        public class FixedBudgetSchedule : Humidifier.Base.BaseSubResource, IHaveStartTime, IHaveEndTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-fixedbudgetschedule.html#cfn-deadline-budget-fixedbudgetschedule-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-deadline-budget-fixedbudgetschedule.html#cfn-deadline-budget-fixedbudgetschedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
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
            public dynamic QueueId { get; set; }
        }
    }
}