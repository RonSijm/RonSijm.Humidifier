namespace Humidifier.Budgets
{
    using global::System.Collections.Generic;
    using BudgetTypes;

    public class Budget : Humidifier.Base.BaseResource, IHaveListOfBudgetsBudgetTypesNotificationWithSubscribersNotificationsWithSubscribers, IHaveListOfBudgetsBudgetTypesResourceTagResourceTags, IHaveBudgetsBudgetTypesBudgetDataBudget_
    {
        public override string AWSTypeName { get => AWS.Budgets.Budget; }
        /// <summary>
        /// NotificationsWithSubscribers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html#cfn-budgets-budget-notificationswithsubscribers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: NotificationWithSubscribers
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers>, IReadOnlyList<Union<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers, BaseFunction>>, BaseFunction>? NotificationsWithSubscribers { get; set; }
        /// <summary>
        /// ResourceTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html#cfn-budgets-budget-resourcetags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Budgets.BudgetTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.Budgets.BudgetTypes.ResourceTag, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }

        /// <summary>
        /// Budget_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-budgets-budget.html#cfn-budgets-budget-budget
        /// Required: True
        /// UpdateType: Mutable
        /// Type: BudgetData
        /// </summary>
        [Required]
        public Union<Humidifier.Budgets.BudgetTypes.BudgetData, BaseFunction>? Budget_ { get; set; }
    }

    namespace BudgetTypes
    {
        public class AutoAdjustData : Humidifier.Base.BaseSubResource, IHaveAutoAdjustType, IHaveBudgetsBudgetTypesHistoricalOptionsHistoricalOptions
        {
            /// <summary>
            /// AutoAdjustType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-autoadjustdata.html#cfn-budgets-budget-autoadjustdata-autoadjusttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoAdjustType { get; set; }
            /// <summary>
            /// HistoricalOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-autoadjustdata.html#cfn-budgets-budget-autoadjustdata-historicaloptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HistoricalOptions
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.HistoricalOptions, BaseFunction>? HistoricalOptions { get; set; }
        }

        public class BudgetData : Humidifier.Base.BaseSubResource, IHaveStringListOfMetrics, IHaveBudgetsBudgetTypesSpendBudgetLimit, IHaveBudgetsBudgetTypesTimePeriodTimePeriod, IHaveBillingViewArn, IHaveBudgetsBudgetTypesAutoAdjustDataAutoAdjustData, IHaveTimeUnit, IHavePlannedBudgetLimits_Json, IHaveCostFilters_Json, IHaveBudgetsBudgetTypesExpressionFilterExpression, IHaveBudgetName, IHaveBudgetsBudgetTypesCostTypesCostTypes, IHaveBudgetType
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Metrics { get; set; }
            /// <summary>
            /// BudgetLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgetlimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Spend
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.Spend, BaseFunction>? BudgetLimit { get; set; }
            /// <summary>
            /// TimePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-timeperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimePeriod
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.TimePeriod, BaseFunction>? TimePeriod { get; set; }
            /// <summary>
            /// BillingViewArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-billingviewarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BillingViewArn { get; set; }
            /// <summary>
            /// AutoAdjustData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-autoadjustdata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoAdjustData
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.AutoAdjustData, BaseFunction>? AutoAdjustData { get; set; }
            /// <summary>
            /// TimeUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-timeunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeUnit { get; set; }
            /// <summary>
            /// PlannedBudgetLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-plannedbudgetlimits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? PlannedBudgetLimits { get; set; }
            /// <summary>
            /// CostFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-costfilters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? CostFilters { get; set; }
            /// <summary>
            /// FilterExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-filterexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.Expression, BaseFunction>? FilterExpression { get; set; }
            /// <summary>
            /// BudgetName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgetname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BudgetName { get; set; }
            /// <summary>
            /// CostTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-costtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostTypes
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.CostTypes, BaseFunction>? CostTypes { get; set; }
            /// <summary>
            /// BudgetType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-budgetdata.html#cfn-budgets-budget-budgetdata-budgettype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BudgetType { get; set; }
        }

        public class CostCategoryValues : Humidifier.Base.BaseSubResource, IHaveStringListOfMatchOptions, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costcategoryvalues.html#cfn-budgets-budget-costcategoryvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchOptions { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costcategoryvalues.html#cfn-budgets-budget-costcategoryvalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costcategoryvalues.html#cfn-budgets-budget-costcategoryvalues-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class CostTypes : Humidifier.Base.BaseSubResource, IHaveIncludeSupport_Boolean, IHaveIncludeOtherSubscription_Boolean, IHaveIncludeTax_Boolean, IHaveIncludeSubscription_Boolean, IHaveUseBlended_Boolean, IHaveIncludeUpfront_Boolean, IHaveIncludeDiscount_Boolean, IHaveIncludeCredit_Boolean, IHaveIncludeRecurring_Boolean, IHaveUseAmortized_Boolean, IHaveIncludeRefund_Boolean
        {
            /// <summary>
            /// IncludeSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includesupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeSupport { get; set; }
            /// <summary>
            /// IncludeOtherSubscription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includeothersubscription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeOtherSubscription { get; set; }
            /// <summary>
            /// IncludeTax
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includetax
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeTax { get; set; }
            /// <summary>
            /// IncludeSubscription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includesubscription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeSubscription { get; set; }
            /// <summary>
            /// UseBlended
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-useblended
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseBlended { get; set; }
            /// <summary>
            /// IncludeUpfront
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includeupfront
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeUpfront { get; set; }
            /// <summary>
            /// IncludeDiscount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includediscount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeDiscount { get; set; }
            /// <summary>
            /// IncludeCredit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includecredit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeCredit { get; set; }
            /// <summary>
            /// IncludeRecurring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includerecurring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeRecurring { get; set; }
            /// <summary>
            /// UseAmortized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-useamortized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseAmortized { get; set; }
            /// <summary>
            /// IncludeRefund
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-costtypes.html#cfn-budgets-budget-costtypes-includerefund
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IncludeRefund { get; set; }
        }

        public class Expression : Humidifier.Base.BaseSubResource, IHaveBudgetsBudgetTypesExpressionNot, IHaveListOfBudgetsBudgetTypesExpressionOr, IHaveListOfBudgetsBudgetTypesExpressionAnd, IHaveBudgetsBudgetTypesExpressionDimensionValuesDimensions, IHaveBudgetsBudgetTypesCostCategoryValuesCostCategories, IHaveBudgetsBudgetTypesTagValuesTags
        {
            /// <summary>
            /// Not
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-not
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.Expression, BaseFunction>? Not { get; set; }
            /// <summary>
            /// Or
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-or
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Expression
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Budgets.BudgetTypes.Expression>, IReadOnlyList<Union<Humidifier.Budgets.BudgetTypes.Expression, BaseFunction>>, BaseFunction>? Or { get; set; }
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Expression
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Budgets.BudgetTypes.Expression>, IReadOnlyList<Union<Humidifier.Budgets.BudgetTypes.Expression, BaseFunction>>, BaseFunction>? And { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExpressionDimensionValues
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.ExpressionDimensionValues, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// CostCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-costcategories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostCategoryValues
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.CostCategoryValues, BaseFunction>? CostCategories { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expression.html#cfn-budgets-budget-expression-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagValues
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.TagValues, BaseFunction>? Tags { get; set; }
        }

        public class ExpressionDimensionValues : Humidifier.Base.BaseSubResource, IHaveStringListOfMatchOptions, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expressiondimensionvalues.html#cfn-budgets-budget-expressiondimensionvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchOptions { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expressiondimensionvalues.html#cfn-budgets-budget-expressiondimensionvalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-expressiondimensionvalues.html#cfn-budgets-budget-expressiondimensionvalues-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class HistoricalOptions : Humidifier.Base.BaseSubResource, IHaveBudgetAdjustmentPeriod_Integer
        {
            /// <summary>
            /// BudgetAdjustmentPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-historicaloptions.html#cfn-budgets-budget-historicaloptions-budgetadjustmentperiod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BudgetAdjustmentPeriod { get; set; }
        }

        public class Notification : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveNotificationType, IHaveThreshold_Double, IHaveThresholdType
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// NotificationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-notificationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationType { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Threshold { get; set; }
            /// <summary>
            /// ThresholdType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notification.html#cfn-budgets-budget-notification-thresholdtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThresholdType { get; set; }
        }

        public class NotificationWithSubscribers : Humidifier.Base.BaseSubResource, IHaveListOfBudgetsBudgetTypesSubscriberSubscribers, IHaveBudgetsBudgetTypesNotificationNotification
        {
            /// <summary>
            /// Subscribers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notificationwithsubscribers.html#cfn-budgets-budget-notificationwithsubscribers-subscribers
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Subscriber
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Budgets.BudgetTypes.Subscriber>, IReadOnlyList<Union<Humidifier.Budgets.BudgetTypes.Subscriber, BaseFunction>>, BaseFunction>? Subscribers { get; set; }
            /// <summary>
            /// Notification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-notificationwithsubscribers.html#cfn-budgets-budget-notificationwithsubscribers-notification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Notification
            /// </summary>
            public Union<Humidifier.Budgets.BudgetTypes.Notification, BaseFunction>? Notification { get; set; }
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
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-resourcetag.html#cfn-budgets-budget-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Spend : Humidifier.Base.BaseSubResource, IHaveAmount_Double, IHaveUnit
        {
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-spend.html#cfn-budgets-budget-spend-amount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Amount { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-spend.html#cfn-budgets-budget-spend-unit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class Subscriber : Humidifier.Base.BaseSubResource, IHaveSubscriptionType, IHaveAddress
        {
            /// <summary>
            /// SubscriptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-subscriber.html#cfn-budgets-budget-subscriber-subscriptiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubscriptionType { get; set; }
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-subscriber.html#cfn-budgets-budget-subscriber-address
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
        }

        public class TagValues : Humidifier.Base.BaseSubResource, IHaveStringListOfMatchOptions, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-tagvalues.html#cfn-budgets-budget-tagvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchOptions { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-tagvalues.html#cfn-budgets-budget-tagvalues-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-tagvalues.html#cfn-budgets-budget-tagvalues-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TimePeriod : Humidifier.Base.BaseSubResource, IHaveStart, IHaveEnd
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-timeperiod.html#cfn-budgets-budget-timeperiod-start
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Start { get; set; }
            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-budgets-budget-timeperiod.html#cfn-budgets-budget-timeperiod-end
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? End { get; set; }
        }
    }
}