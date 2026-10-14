namespace Humidifier.BCM
{
    using global::System.Collections.Generic;
    using DashboardTypes;

    public class Dashboard : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BCM.Dashboard; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-dashboard.html#cfn-bcm-dashboard-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Widgets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-dashboard.html#cfn-bcm-dashboard-widgets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Widget
        /// </summary>
        [Required]
        public List<Humidifier.BCM.DashboardTypes.Widget> Widgets { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-dashboard.html#cfn-bcm-dashboard-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DashboardTypes
    {
        public class CostAndUsageExpression : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusageexpression.html#cfn-bcm-dashboard-costandusageexpression-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionValues
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DimensionValues Dimensions { get; set; }
            /// <summary>
            /// Not
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusageexpression.html#cfn-bcm-dashboard-costandusageexpression-not
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostAndUsageExpression
            /// </summary>
            public Humidifier.BCM.DashboardTypes.CostAndUsageExpression Not { get; set; }
            /// <summary>
            /// CostCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusageexpression.html#cfn-bcm-dashboard-costandusageexpression-costcategories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostCategoryValues
            /// </summary>
            public Humidifier.BCM.DashboardTypes.CostCategoryValues CostCategories { get; set; }
            /// <summary>
            /// Or
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusageexpression.html#cfn-bcm-dashboard-costandusageexpression-or
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CostAndUsageExpression
            /// </summary>
            public List<Humidifier.BCM.DashboardTypes.CostAndUsageExpression> Or { get; set; }
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusageexpression.html#cfn-bcm-dashboard-costandusageexpression-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CostAndUsageExpression
            /// </summary>
            public List<Humidifier.BCM.DashboardTypes.CostAndUsageExpression> And { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusageexpression.html#cfn-bcm-dashboard-costandusageexpression-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagValues
            /// </summary>
            public Humidifier.BCM.DashboardTypes.TagValues Tags { get; set; }
        }

        public class CostAndUsageQuery : Humidifier.Base.BaseSubResource, IHaveGranularity, IHaveMetrics
        {
            /// <summary>
            /// TimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusagequery.html#cfn-bcm-dashboard-costandusagequery-timerange
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeRange
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DateTimeRange TimeRange { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusagequery.html#cfn-bcm-dashboard-costandusagequery-metrics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Metrics { get; set; }
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusagequery.html#cfn-bcm-dashboard-costandusagequery-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GroupDefinition
            /// </summary>
            public List<Humidifier.BCM.DashboardTypes.GroupDefinition> GroupBy { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusagequery.html#cfn-bcm-dashboard-costandusagequery-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostAndUsageExpression
            /// </summary>
            public Humidifier.BCM.DashboardTypes.CostAndUsageExpression Filter { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costandusagequery.html#cfn-bcm-dashboard-costandusagequery-granularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class CostCategoryValues : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costcategoryvalues.html#cfn-bcm-dashboard-costcategoryvalues-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costcategoryvalues.html#cfn-bcm-dashboard-costcategoryvalues-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-costcategoryvalues.html#cfn-bcm-dashboard-costcategoryvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchOptions { get; set; }
        }

        public class DateTimeRange : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-datetimerange.html#cfn-bcm-dashboard-datetimerange-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeValue
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DateTimeValue EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-datetimerange.html#cfn-bcm-dashboard-datetimerange-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeValue
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DateTimeValue StartTime { get; set; }
        }

        public class DateTimeValue : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-datetimevalue.html#cfn-bcm-dashboard-datetimevalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-datetimevalue.html#cfn-bcm-dashboard-datetimevalue-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class DimensionValues : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-dimensionvalues.html#cfn-bcm-dashboard-dimensionvalues-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-dimensionvalues.html#cfn-bcm-dashboard-dimensionvalues-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-dimensionvalues.html#cfn-bcm-dashboard-dimensionvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchOptions { get; set; }
        }

        public class DisplayConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Graph
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-displayconfig.html#cfn-bcm-dashboard-displayconfig-graph
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: GraphDisplayConfig
            /// </summary>
            public Dictionary<string, Humidifier.BCM.DashboardTypes.GraphDisplayConfig> Graph { get; set; }
            /// <summary>
            /// Table
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-displayconfig.html#cfn-bcm-dashboard-displayconfig-table
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Table { get; set; }
        }

        public class Expression : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-expression.html#cfn-bcm-dashboard-expression-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DimensionValues
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DimensionValues Dimensions { get; set; }
            /// <summary>
            /// Not
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-expression.html#cfn-bcm-dashboard-expression-not
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Humidifier.BCM.DashboardTypes.Expression Not { get; set; }
            /// <summary>
            /// CostCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-expression.html#cfn-bcm-dashboard-expression-costcategories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostCategoryValues
            /// </summary>
            public Humidifier.BCM.DashboardTypes.CostCategoryValues CostCategories { get; set; }
            /// <summary>
            /// And
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-expression.html#cfn-bcm-dashboard-expression-and
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Expression
            /// </summary>
            public List<Humidifier.BCM.DashboardTypes.Expression> And { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-expression.html#cfn-bcm-dashboard-expression-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagValues
            /// </summary>
            public Humidifier.BCM.DashboardTypes.TagValues Tags { get; set; }
        }

        public class GraphDisplayConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VisualType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-graphdisplayconfig.html#cfn-bcm-dashboard-graphdisplayconfig-visualtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualType { get; set; }
        }

        public class GroupDefinition : Humidifier.Base.BaseSubResource, IHaveType, IHaveKey
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-groupdefinition.html#cfn-bcm-dashboard-groupdefinition-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-groupdefinition.html#cfn-bcm-dashboard-groupdefinition-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class QueryParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SavingsPlansUtilization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-queryparameters.html#cfn-bcm-dashboard-queryparameters-savingsplansutilization
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SavingsPlansUtilizationQuery
            /// </summary>
            public Humidifier.BCM.DashboardTypes.SavingsPlansUtilizationQuery SavingsPlansUtilization { get; set; }
            /// <summary>
            /// ReservationCoverage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-queryparameters.html#cfn-bcm-dashboard-queryparameters-reservationcoverage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReservationCoverageQuery
            /// </summary>
            public Humidifier.BCM.DashboardTypes.ReservationCoverageQuery ReservationCoverage { get; set; }
            /// <summary>
            /// SavingsPlansCoverage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-queryparameters.html#cfn-bcm-dashboard-queryparameters-savingsplanscoverage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SavingsPlansCoverageQuery
            /// </summary>
            public Humidifier.BCM.DashboardTypes.SavingsPlansCoverageQuery SavingsPlansCoverage { get; set; }
            /// <summary>
            /// ReservationUtilization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-queryparameters.html#cfn-bcm-dashboard-queryparameters-reservationutilization
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReservationUtilizationQuery
            /// </summary>
            public Humidifier.BCM.DashboardTypes.ReservationUtilizationQuery ReservationUtilization { get; set; }
            /// <summary>
            /// CostAndUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-queryparameters.html#cfn-bcm-dashboard-queryparameters-costandusage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CostAndUsageQuery
            /// </summary>
            public Humidifier.BCM.DashboardTypes.CostAndUsageQuery CostAndUsage { get; set; }
        }

        public class ReservationCoverageQuery : Humidifier.Base.BaseSubResource, IHaveGranularity, IHaveMetrics
        {
            /// <summary>
            /// TimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationcoveragequery.html#cfn-bcm-dashboard-reservationcoveragequery-timerange
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeRange
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DateTimeRange TimeRange { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationcoveragequery.html#cfn-bcm-dashboard-reservationcoveragequery-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Metrics { get; set; }
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationcoveragequery.html#cfn-bcm-dashboard-reservationcoveragequery-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GroupDefinition
            /// </summary>
            public List<Humidifier.BCM.DashboardTypes.GroupDefinition> GroupBy { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationcoveragequery.html#cfn-bcm-dashboard-reservationcoveragequery-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Humidifier.BCM.DashboardTypes.Expression Filter { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationcoveragequery.html#cfn-bcm-dashboard-reservationcoveragequery-granularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class ReservationUtilizationQuery : Humidifier.Base.BaseSubResource, IHaveGranularity
        {
            /// <summary>
            /// TimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationutilizationquery.html#cfn-bcm-dashboard-reservationutilizationquery-timerange
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeRange
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DateTimeRange TimeRange { get; set; }
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationutilizationquery.html#cfn-bcm-dashboard-reservationutilizationquery-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GroupDefinition
            /// </summary>
            public List<Humidifier.BCM.DashboardTypes.GroupDefinition> GroupBy { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationutilizationquery.html#cfn-bcm-dashboard-reservationutilizationquery-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Humidifier.BCM.DashboardTypes.Expression Filter { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-reservationutilizationquery.html#cfn-bcm-dashboard-reservationutilizationquery-granularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class SavingsPlansCoverageQuery : Humidifier.Base.BaseSubResource, IHaveGranularity, IHaveMetrics
        {
            /// <summary>
            /// TimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-savingsplanscoveragequery.html#cfn-bcm-dashboard-savingsplanscoveragequery-timerange
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeRange
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DateTimeRange TimeRange { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-savingsplanscoveragequery.html#cfn-bcm-dashboard-savingsplanscoveragequery-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Metrics { get; set; }
            /// <summary>
            /// GroupBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-savingsplanscoveragequery.html#cfn-bcm-dashboard-savingsplanscoveragequery-groupby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GroupDefinition
            /// </summary>
            public List<Humidifier.BCM.DashboardTypes.GroupDefinition> GroupBy { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-savingsplanscoveragequery.html#cfn-bcm-dashboard-savingsplanscoveragequery-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Humidifier.BCM.DashboardTypes.Expression Filter { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-savingsplanscoveragequery.html#cfn-bcm-dashboard-savingsplanscoveragequery-granularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class SavingsPlansUtilizationQuery : Humidifier.Base.BaseSubResource, IHaveGranularity
        {
            /// <summary>
            /// TimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-savingsplansutilizationquery.html#cfn-bcm-dashboard-savingsplansutilizationquery-timerange
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeRange
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DateTimeRange TimeRange { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-savingsplansutilizationquery.html#cfn-bcm-dashboard-savingsplansutilizationquery-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Expression
            /// </summary>
            public Humidifier.BCM.DashboardTypes.Expression Filter { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-savingsplansutilizationquery.html#cfn-bcm-dashboard-savingsplansutilizationquery-granularity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class TagValues : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-tagvalues.html#cfn-bcm-dashboard-tagvalues-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-tagvalues.html#cfn-bcm-dashboard-tagvalues-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
            /// <summary>
            /// MatchOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-tagvalues.html#cfn-bcm-dashboard-tagvalues-matchoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchOptions { get; set; }
        }

        public class Widget : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveTitle, IHaveHeight, IHaveWidth
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-widget.html#cfn-bcm-dashboard-widget-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Configs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-widget.html#cfn-bcm-dashboard-widget-configs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WidgetConfig
            /// </summary>
            public List<Humidifier.BCM.DashboardTypes.WidgetConfig> Configs { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-widget.html#cfn-bcm-dashboard-widget-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-widget.html#cfn-bcm-dashboard-widget-height
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Height { get; set; }
            /// <summary>
            /// HorizontalOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-widget.html#cfn-bcm-dashboard-widget-horizontaloffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HorizontalOffset { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-widget.html#cfn-bcm-dashboard-widget-width
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Width { get; set; }
        }

        public class WidgetConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueryParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-widgetconfig.html#cfn-bcm-dashboard-widgetconfig-queryparameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: QueryParameters
            /// </summary>
            public Humidifier.BCM.DashboardTypes.QueryParameters QueryParameters { get; set; }
            /// <summary>
            /// DisplayConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-dashboard-widgetconfig.html#cfn-bcm-dashboard-widgetconfig-displayconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DisplayConfig
            /// </summary>
            public Humidifier.BCM.DashboardTypes.DisplayConfig DisplayConfig { get; set; }
        }
    }
}