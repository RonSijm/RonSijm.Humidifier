namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using MetricTypes;

    public class Metric : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveStatus, IHaveUnit, IHaveInstanceArn
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
        public dynamic Status { get; set; }

        /// <summary>
        /// MetricCalculation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-metriccalculation
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MetricCalculation
        /// </summary>
        [Required]
        public Humidifier.Connect.MetricTypes.MetricCalculation MetricCalculation { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// PositiveTrendIndicator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-positivetrendindicator
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PositiveTrendIndicator { get; set; }

        /// <summary>
        /// Unit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-unit
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Unit { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-metric.html#cfn-connect-metric-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-availablefilter.html#cfn-connect-metric-availablefilter-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class CalculationComponent : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveAlias
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-calculationcomponent.html#cfn-connect-metric-calculationcomponent-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// MetricId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-calculationcomponent.html#cfn-connect-metric-calculationcomponent-metricid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricId { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-calculationcomponent.html#cfn-connect-metric-calculationcomponent-alias
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// MetricFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-calculationcomponent.html#cfn-connect-metric-calculationcomponent-metricfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricFilter
            /// </summary>
            public List<Humidifier.Connect.MetricTypes.MetricFilter> MetricFilters { get; set; }
        }

        public class CreatedByInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AWSIdentityArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-createdbyinfo.html#cfn-connect-metric-createdbyinfo-awsidentityarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AWSIdentityArn { get; set; }
            /// <summary>
            /// ConnectUserArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-createdbyinfo.html#cfn-connect-metric-createdbyinfo-connectuserarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectUserArn { get; set; }
        }

        public class MetricCalculation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Calculation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metriccalculation.html#cfn-connect-metric-metriccalculation-calculation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Calculation { get; set; }
            /// <summary>
            /// CalculationComponents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metriccalculation.html#cfn-connect-metric-metriccalculation-calculationcomponents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CalculationComponent
            /// </summary>
            public List<Humidifier.Connect.MetricTypes.CalculationComponent> CalculationComponents { get; set; }
        }

        public class MetricFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetricFilterKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-metricfilterkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricFilterKey { get; set; }
            /// <summary>
            /// BooleanCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-booleancondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricFilterBooleanCondition
            /// </summary>
            public Humidifier.Connect.MetricTypes.MetricFilterBooleanCondition BooleanCondition { get; set; }
            /// <summary>
            /// Negate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-negate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Negate { get; set; }
            /// <summary>
            /// NumberCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-numbercondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricFilterNumberCondition
            /// </summary>
            public Humidifier.Connect.MetricTypes.MetricFilterNumberCondition NumberCondition { get; set; }
            /// <summary>
            /// StringCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilter.html#cfn-connect-metric-metricfilter-stringcondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricFilterStringCondition
            /// </summary>
            public Humidifier.Connect.MetricTypes.MetricFilterStringCondition StringCondition { get; set; }
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
            public dynamic Comparison { get; set; }
        }

        public class MetricFilterNumberCondition : Humidifier.Base.BaseSubResource, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilternumbercondition.html#cfn-connect-metric-metricfilternumbercondition-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilternumbercondition.html#cfn-connect-metric-metricfilternumbercondition-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public List<double> Values { get; set; }
        }

        public class MetricFilterStringCondition : Humidifier.Base.BaseSubResource, IHaveValues, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilterstringcondition.html#cfn-connect-metric-metricfilterstringcondition-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-metric-metricfilterstringcondition.html#cfn-connect-metric-metricfilterstringcondition-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }
    }
}