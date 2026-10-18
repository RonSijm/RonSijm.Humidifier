namespace Humidifier.Logs
{
    using global::System.Collections.Generic;
    using MetricFilterTypes;

    public class MetricFilter : Humidifier.Base.BaseResource, IHaveFieldSelectionCriteria, IHaveListOfLogsMetricFilterTypesMetricTransformationMetricTransformations, IHaveFilterPattern, IHaveStringListOfEmitSystemFieldDimensions, IHaveLogGroupName, IHaveApplyOnTransformedLogs_Boolean, IHaveFilterName
    {
        public override string AWSTypeName { get => AWS.Logs.MetricFilter; }
        /// <summary>
        /// FieldSelectionCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-logs-metricfilter-fieldselectioncriteria
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FieldSelectionCriteria { get; set; }

        /// <summary>
        /// MetricTransformations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-logs-metricfilter-metrictransformations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricTransformation
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Logs.MetricFilterTypes.MetricTransformation>, IReadOnlyList<Union<Humidifier.Logs.MetricFilterTypes.MetricTransformation, BaseFunction>>, BaseFunction>? MetricTransformations { get; set; }

        /// <summary>
        /// FilterPattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-logs-metricfilter-filterpattern
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FilterPattern { get; set; }
        /// <summary>
        /// EmitSystemFieldDimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-logs-metricfilter-emitsystemfielddimensions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EmitSystemFieldDimensions { get; set; }

        /// <summary>
        /// LogGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-logs-metricfilter-loggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LogGroupName { get; set; }
        /// <summary>
        /// ApplyOnTransformedLogs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-logs-metricfilter-applyontransformedlogs
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ApplyOnTransformedLogs { get; set; }
        /// <summary>
        /// FilterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-logs-metricfilter-filtername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FilterName { get; set; }
    }

    namespace MetricFilterTypes
    {
        public class Dimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-dimension.html#cfn-logs-metricfilter-dimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-dimension.html#cfn-logs-metricfilter-dimension-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class MetricTransformation : Humidifier.Base.BaseSubResource, IHaveDefaultValue_Double, IHaveMetricName, IHaveMetricValue, IHaveMetricNamespace, IHaveListOfLogsMetricFilterTypesDimensionDimensions, IHaveUnit
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-logs-metricfilter-metrictransformation-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-logs-metricfilter-metrictransformation-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// MetricValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-logs-metricfilter-metrictransformation-metricvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricValue { get; set; }
            /// <summary>
            /// MetricNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-logs-metricfilter-metrictransformation-metricnamespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricNamespace { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-logs-metricfilter-metrictransformation-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Dimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Logs.MetricFilterTypes.Dimension>, IReadOnlyList<Union<Humidifier.Logs.MetricFilterTypes.Dimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-logs-metricfilter-metrictransformation-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }
    }
}