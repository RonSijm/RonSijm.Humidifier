namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using MetricTypes;

    public class Metric : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveConnectMetricTypesMetricCalculationMetricCalculation, IHaveDescription, IHaveInstanceArn, IHavePositiveTrendIndicator, IHaveUnit, IHaveName
    {
        public class Attributes
        {
            public static string RefreshRate =  "RefreshRate" ;
            public static string Category =  "Category" ;
            public static string PrimaryEventSourceEffectiveTimestampType =  "PrimaryEventSourceEffectiveTimestampType" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string EffectiveTime =  "EffectiveTime" ;
            public static string CreatedUser =  "CreatedUser" ;
            public static string Groupings =  "Groupings" ;
            public static string LastModifiedRegion =  "LastModifiedRegion" ;
            public static string PrimaryEventSource =  "PrimaryEventSource" ;
            public static string MetricArn =  "MetricArn" ;
            public static string Filters =  "Filters" ;
            public static string Type =  "Type" ;
            public static string CreationMethod =  "CreationMethod" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string SupportsPreaggregateCalculation =  "SupportsPreaggregateCalculation" ;
            public static string SupportedStats =  "SupportedStats" ;
            public static string LastModifiedUser =  "LastModifiedUser" ;
            public static string SupportsCustomCalculation =  "SupportsCustomCalculation" ;
        }

        public override string AWSTypeName { get => AWS.Connect.Metric; }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-status
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// MetricCalculation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-metriccalculation
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MetricCalculation
        /// </summary>
        [Required]
        public Union<Humidifier.Connect.MetricTypes.MetricCalculation, BaseFunction>? MetricCalculation { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// PositiveTrendIndicator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-positivetrendindicator
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PositiveTrendIndicator { get; set; }

        /// <summary>
        /// Unit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-unit
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Unit { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace MetricTypes
    {
        public class AvailableFilter : Humidifier.Base.BaseSubResource, IHaveType, IHaveId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-availablefilter.html#cfn-connect-metric-availablefilter-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-availablefilter.html#cfn-connect-metric-availablefilter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class CalculationComponent : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveMetricId, IHaveAlias, IHaveListOfConnectMetricTypesMetricFilterMetricFilters
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-calculationcomponent.html#cfn-connect-metric-calculationcomponent-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// MetricId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-calculationcomponent.html#cfn-connect-metric-calculationcomponent-metricid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricId { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-calculationcomponent.html#cfn-connect-metric-calculationcomponent-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// MetricFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-calculationcomponent.html#cfn-connect-metric-calculationcomponent-metricfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.MetricTypes.MetricFilter>, IReadOnlyList<Union<Humidifier.Connect.MetricTypes.MetricFilter, BaseFunction>>, BaseFunction>? MetricFilters { get; set; }
        }

        public class CreatedByInfo : Humidifier.Base.BaseSubResource, IHaveAWSIdentityArn, IHaveConnectUserArn
        {
            /// <summary>
            /// AWSIdentityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-createdbyinfo.html#cfn-connect-metric-createdbyinfo-awsidentityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AWSIdentityArn { get; set; }
            /// <summary>
            /// ConnectUserArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-createdbyinfo.html#cfn-connect-metric-createdbyinfo-connectuserarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectUserArn { get; set; }
        }

        public class MetricCalculation : Humidifier.Base.BaseSubResource, IHaveCalculation, IHaveListOfConnectMetricTypesCalculationComponentCalculationComponents
        {
            /// <summary>
            /// Calculation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metriccalculation.html#cfn-connect-metric-metriccalculation-calculation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Calculation { get; set; }
            /// <summary>
            /// CalculationComponents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metriccalculation.html#cfn-connect-metric-metriccalculation-calculationcomponents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculationComponent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.MetricTypes.CalculationComponent>, IReadOnlyList<Union<Humidifier.Connect.MetricTypes.CalculationComponent, BaseFunction>>, BaseFunction>? CalculationComponents { get; set; }
        }

        public class MetricFilter : Humidifier.Base.BaseSubResource, IHaveMetricFilterKey, IHaveConnectMetricTypesMetricFilterBooleanConditionBooleanCondition, IHaveNegate_Boolean, IHaveConnectMetricTypesMetricFilterNumberConditionNumberCondition, IHaveConnectMetricTypesMetricFilterStringConditionStringCondition
        {
            /// <summary>
            /// MetricFilterKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-metricfilterkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricFilterKey { get; set; }
            /// <summary>
            /// BooleanCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-booleancondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricFilterBooleanCondition
            /// </summary>
            public Union<Humidifier.Connect.MetricTypes.MetricFilterBooleanCondition, BaseFunction>? BooleanCondition { get; set; }
            /// <summary>
            /// Negate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-negate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Negate { get; set; }
            /// <summary>
            /// NumberCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-numbercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricFilterNumberCondition
            /// </summary>
            public Union<Humidifier.Connect.MetricTypes.MetricFilterNumberCondition, BaseFunction>? NumberCondition { get; set; }
            /// <summary>
            /// StringCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-stringcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricFilterStringCondition
            /// </summary>
            public Union<Humidifier.Connect.MetricTypes.MetricFilterStringCondition, BaseFunction>? StringCondition { get; set; }
        }

        public class MetricFilterBooleanCondition : Humidifier.Base.BaseSubResource, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilterbooleancondition.html#cfn-connect-metric-metricfilterbooleancondition-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
        }

        public class MetricFilterNumberCondition : Humidifier.Base.BaseSubResource, IHaveComparison, IHaveDoubleListOfValues
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilternumbercondition.html#cfn-connect-metric-metricfilternumbercondition-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilternumbercondition.html#cfn-connect-metric-metricfilternumbercondition-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public Union<IReadOnlyList<double>, IReadOnlyList<Union<double, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class MetricFilterStringCondition : Humidifier.Base.BaseSubResource, IHaveComparison, IHaveStringListOfValues
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilterstringcondition.html#cfn-connect-metric-metricfilterstringcondition-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilterstringcondition.html#cfn-connect-metric-metricfilterstringcondition-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }
    }
}