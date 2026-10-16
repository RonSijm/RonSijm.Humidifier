namespace Humidifier.Budgets
{
    using global::System.Collections.Generic;
    using BudgetTypes;

    public class Budget : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.Budgets.Budget; }
        /// <summary>
        /// NotificationsWithSubscribers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html#cfn-budgets-budget-notificationswithsubscribers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: NotificationWithSubscribers
        /// </summary>
        public List<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> NotificationsWithSubscribers { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html#cfn-budgets-budget-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public List<Humidifier.Budgets.BudgetTypes.ResourceTag> ResourceTags { get; set; }

        /// <summary>
        /// Budget_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html#cfn-budgets-budget-budget
        /// Required: True
        /// UpdateType: Mutable
        /// Type: BudgetData
        /// </summary>
        [Required]
        public Humidifier.Budgets.BudgetTypes.BudgetData Budget_ { get; set; }
    }

    namespace BudgetTypes
    {
        public class AutoAdjustData : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AutoAdjustType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-autoadjustdata.html#cfn-budgets-budget-autoadjustdata-autoadjusttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AutoAdjustType { get; set; }
            /// <summary>
            /// HistoricalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-autoadjustdata.html#cfn-budgets-budget-autoadjustdata-historicaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistoricalOptions
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.HistoricalOptions HistoricalOptions { get; set; }
        }

        public class BudgetData : Humidifier.Base.BaseSubResource, IHaveMetrics, IHaveBudgetName, IHaveTimeUnit
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Metrics { get; set; }
            /// <summary>
            /// BudgetLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgetlimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spend
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.Spend BudgetLimit { get; set; }
            /// <summary>
            /// TimePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-timeperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimePeriod
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.TimePeriod TimePeriod { get; set; }
            /// <summary>
            /// BillingViewArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-billingviewarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BillingViewArn { get; set; }
            /// <summary>
            /// AutoAdjustData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-autoadjustdata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoAdjustData
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.AutoAdjustData AutoAdjustData { get; set; }
            /// <summary>
            /// TimeUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-timeunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeUnit { get; set; }
            /// <summary>
            /// PlannedBudgetLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-plannedbudgetlimits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic PlannedBudgetLimits { get; set; }
            /// <summary>
            /// CostFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-costfilters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic CostFilters { get; set; }
            /// <summary>
            /// FilterExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-filterexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.Expression FilterExpression { get; set; }
            /// <summary>
            /// CostTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-costtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostTypes
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.CostTypes CostTypes { get; set; }
            /// <summary>
            /// BudgetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgettype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BudgetType { get; set; }
            /// <summary>
            /// BudgetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgetname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BudgetName { get; set; }
        }

        public class CostCategoryValues : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costcategoryvalues.html#cfn-budgets-budget-costcategoryvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchOptions { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costcategoryvalues.html#cfn-budgets-budget-costcategoryvalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costcategoryvalues.html#cfn-budgets-budget-costcategoryvalues-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class CostTypes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IncludeSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includesupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeSupport { get; set; }
            /// <summary>
            /// IncludeOtherSubscription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includeothersubscription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeOtherSubscription { get; set; }
            /// <summary>
            /// IncludeTax
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includetax
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeTax { get; set; }
            /// <summary>
            /// IncludeSubscription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includesubscription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeSubscription { get; set; }
            /// <summary>
            /// UseBlended
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-useblended
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UseBlended { get; set; }
            /// <summary>
            /// IncludeUpfront
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includeupfront
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeUpfront { get; set; }
            /// <summary>
            /// IncludeDiscount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includediscount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeDiscount { get; set; }
            /// <summary>
            /// IncludeCredit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includecredit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeCredit { get; set; }
            /// <summary>
            /// IncludeRecurring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includerecurring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeRecurring { get; set; }
            /// <summary>
            /// UseAmortized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-useamortized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UseAmortized { get; set; }
            /// <summary>
            /// IncludeRefund
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includerefund
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeRefund { get; set; }
        }

        public class Expression : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressionDimensionValues
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.ExpressionDimensionValues Dimensions { get; set; }
            /// <summary>
            /// Not
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-not
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.Expression Not { get; set; }
            /// <summary>
            /// CostCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-costcategories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostCategoryValues
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.CostCategoryValues CostCategories { get; set; }
            /// <summary>
            /// Or
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-or
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Expression
            /// </summary>
            public List<Humidifier.Budgets.BudgetTypes.Expression> Or { get; set; }
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Expression
            /// </summary>
            public List<Humidifier.Budgets.BudgetTypes.Expression> And { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagValues
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.TagValues Tags { get; set; }
        }

        public class ExpressionDimensionValues : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expressiondimensionvalues.html#cfn-budgets-budget-expressiondimensionvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchOptions { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expressiondimensionvalues.html#cfn-budgets-budget-expressiondimensionvalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expressiondimensionvalues.html#cfn-budgets-budget-expressiondimensionvalues-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class HistoricalOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BudgetAdjustmentPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-historicaloptions.html#cfn-budgets-budget-historicaloptions-budgetadjustmentperiod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BudgetAdjustmentPeriod { get; set; }
        }

        public class Notification : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveThreshold, IHaveNotificationType
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-comparisonoperator
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator { get; set; }
            /// <summary>
            /// NotificationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-notificationtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotificationType { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-threshold
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Threshold { get; set; }
            /// <summary>
            /// ThresholdType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-thresholdtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThresholdType { get; set; }
        }

        public class NotificationWithSubscribers : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Subscribers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notificationwithsubscribers.html#cfn-budgets-budget-notificationwithsubscribers-subscribers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Subscriber
            /// </summary>
            public List<Humidifier.Budgets.BudgetTypes.Subscriber> Subscribers { get; set; }
            /// <summary>
            /// Notification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notificationwithsubscribers.html#cfn-budgets-budget-notificationwithsubscribers-notification
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Notification
            /// </summary>
            public Humidifier.Budgets.BudgetTypes.Notification Notification { get; set; }
        }

        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-resourcetag.html#cfn-budgets-budget-resourcetag-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-resourcetag.html#cfn-budgets-budget-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class Spend : Humidifier.Base.BaseSubResource, IHaveUnit, IHaveAmount
        {
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-spend.html#cfn-budgets-budget-spend-amount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Amount { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-spend.html#cfn-budgets-budget-spend-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class Subscriber : Humidifier.Base.BaseSubResource, IHaveAddress
        {
            /// <summary>
            /// SubscriptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-subscriber.html#cfn-budgets-budget-subscriber-subscriptiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubscriptionType { get; set; }
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-subscriber.html#cfn-budgets-budget-subscriber-address
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Address { get; set; }
        }

        public class TagValues : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-tagvalues.html#cfn-budgets-budget-tagvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchOptions { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-tagvalues.html#cfn-budgets-budget-tagvalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-tagvalues.html#cfn-budgets-budget-tagvalues-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class TimePeriod : Humidifier.Base.BaseSubResource, IHaveEnd, IHaveStart
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-timeperiod.html#cfn-budgets-budget-timeperiod-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-timeperiod.html#cfn-budgets-budget-timeperiod-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic End { get; set; }
        }
    }
}