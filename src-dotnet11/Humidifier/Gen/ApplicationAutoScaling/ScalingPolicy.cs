namespace Humidifier.ApplicationAutoScaling
{
    using global::System.Collections.Generic;
    using ScalingPolicyTypes;

    public class ScalingPolicy : Humidifier.Base.BaseResource, IHavePolicyType, IHaveResourceId, IHaveScalingTargetId, IHavePolicyName, IHaveServiceNamespace, IHaveScalableDimension, IHaveApplicationAutoScalingScalingPolicyTypesTargetTrackingScalingPolicyConfigurationTargetTrackingScalingPolicyConfiguration, IHaveApplicationAutoScalingScalingPolicyTypesStepScalingPolicyConfigurationStepScalingPolicyConfiguration, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingPolicyConfigurationPredictiveScalingPolicyConfiguration
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ApplicationAutoScaling.ScalingPolicy; }

        /// <summary>
        /// PolicyType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-policytype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyType { get; set; }
        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-resourceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceId { get; set; }
        /// <summary>
        /// ScalingTargetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-scalingtargetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScalingTargetId { get; set; }

        /// <summary>
        /// PolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-policyname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PolicyName { get; set; }
        /// <summary>
        /// ServiceNamespace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-servicenamespace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceNamespace { get; set; }
        /// <summary>
        /// ScalableDimension
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-scalabledimension
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ScalableDimension { get; set; }
        /// <summary>
        /// TargetTrackingScalingPolicyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetTrackingScalingPolicyConfiguration
        /// </summary>
        public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.TargetTrackingScalingPolicyConfiguration, BaseFunction>? TargetTrackingScalingPolicyConfiguration { get; set; }
        /// <summary>
        /// StepScalingPolicyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StepScalingPolicyConfiguration
        /// </summary>
        public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.StepScalingPolicyConfiguration, BaseFunction>? StepScalingPolicyConfiguration { get; set; }
        /// <summary>
        /// PredictiveScalingPolicyConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalingpolicy.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PredictiveScalingPolicyConfiguration
        /// </summary>
        public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPolicyConfiguration, BaseFunction>? PredictiveScalingPolicyConfiguration { get; set; }
    }

    namespace ScalingPolicyTypes
    {
        public class CustomizedMetricSpecification : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveListOfApplicationAutoScalingScalingPolicyTypesTargetTrackingMetricDataQueryMetrics, IHaveStatistic, IHaveListOfApplicationAutoScalingScalingPolicyTypesMetricDimensionDimensions, IHaveUnit, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-customizedmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-customizedmetricspecification-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-customizedmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-customizedmetricspecification-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrackingMetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.TargetTrackingMetricDataQuery>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.TargetTrackingMetricDataQuery, BaseFunction>>, BaseFunction>? Metrics { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-customizedmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-customizedmetricspecification-statistic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statistic { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-customizedmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-customizedmetricspecification-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.MetricDimension>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.MetricDimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-customizedmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-customizedmetricspecification-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-customizedmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-customizedmetricspecification-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class MetricDimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-metricdimension.html#cfn-applicationautoscaling-scalingpolicy-metricdimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-metricdimension.html#cfn-applicationautoscaling-scalingpolicy-metricdimension-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PredefinedMetricSpecification : Humidifier.Base.BaseSubResource, IHavePredefinedMetricType, IHaveResourceLabel
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predefinedmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predefinedmetricspecification-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredefinedMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predefinedmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predefinedmetricspecification-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceLabel { get; set; }
        }

        public class PredictiveScalingCustomizedCapacityMetric : Humidifier.Base.BaseSubResource, IHaveListOfApplicationAutoScalingScalingPolicyTypesPredictiveScalingMetricDataQueryMetricDataQueries
        {
            /// <summary>
            /// MetricDataQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingcustomizedcapacitymetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingcustomizedcapacitymetric-metricdataqueries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PredictiveScalingMetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDataQuery>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDataQuery, BaseFunction>>, BaseFunction>? MetricDataQueries { get; set; }
        }

        public class PredictiveScalingCustomizedLoadMetric : Humidifier.Base.BaseSubResource, IHaveListOfApplicationAutoScalingScalingPolicyTypesPredictiveScalingMetricDataQueryMetricDataQueries
        {
            /// <summary>
            /// MetricDataQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingcustomizedloadmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingcustomizedloadmetric-metricdataqueries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PredictiveScalingMetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDataQuery>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDataQuery, BaseFunction>>, BaseFunction>? MetricDataQueries { get; set; }
        }

        public class PredictiveScalingCustomizedScalingMetric : Humidifier.Base.BaseSubResource, IHaveListOfApplicationAutoScalingScalingPolicyTypesPredictiveScalingMetricDataQueryMetricDataQueries
        {
            /// <summary>
            /// MetricDataQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingcustomizedscalingmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingcustomizedscalingmetric-metricdataqueries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PredictiveScalingMetricDataQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDataQuery>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDataQuery, BaseFunction>>, BaseFunction>? MetricDataQueries { get; set; }
        }

        public class PredictiveScalingMetric : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveListOfApplicationAutoScalingScalingPolicyTypesPredictiveScalingMetricDimensionDimensions, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetric-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetric-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PredictiveScalingMetricDimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDimension>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricDimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetric-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class PredictiveScalingMetricDataQuery : Humidifier.Base.BaseSubResource, IHaveLabel, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingMetricStatMetricStat, IHaveId, IHaveReturnData_Boolean, IHaveExpression
        {
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Label { get; set; }
            /// <summary>
            /// MetricStat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery-metricstat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingMetricStat
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricStat, BaseFunction>? MetricStat { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// ReturnData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery-returndata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReturnData { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricdataquery-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }

        public class PredictiveScalingMetricDimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricdimension.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricdimension-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricdimension.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricdimension-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PredictiveScalingMetricSpecification : Humidifier.Base.BaseSubResource, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingCustomizedLoadMetricCustomizedLoadMetricSpecification, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingPredefinedLoadMetricPredefinedLoadMetricSpecification, IHaveTargetValue_Double, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingPredefinedScalingMetricPredefinedScalingMetricSpecification, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingCustomizedCapacityMetricCustomizedCapacityMetricSpecification, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingCustomizedScalingMetricCustomizedScalingMetricSpecification, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingPredefinedMetricPairPredefinedMetricPairSpecification
        {
            /// <summary>
            /// CustomizedLoadMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification-customizedloadmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingCustomizedLoadMetric
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingCustomizedLoadMetric, BaseFunction>? CustomizedLoadMetricSpecification { get; set; }
            /// <summary>
            /// PredefinedLoadMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification-predefinedloadmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingPredefinedLoadMetric
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPredefinedLoadMetric, BaseFunction>? PredefinedLoadMetricSpecification { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
            /// <summary>
            /// PredefinedScalingMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification-predefinedscalingmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingPredefinedScalingMetric
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPredefinedScalingMetric, BaseFunction>? PredefinedScalingMetricSpecification { get; set; }
            /// <summary>
            /// CustomizedCapacityMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification-customizedcapacitymetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingCustomizedCapacityMetric
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingCustomizedCapacityMetric, BaseFunction>? CustomizedCapacityMetricSpecification { get; set; }
            /// <summary>
            /// CustomizedScalingMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification-customizedscalingmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingCustomizedScalingMetric
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingCustomizedScalingMetric, BaseFunction>? CustomizedScalingMetricSpecification { get; set; }
            /// <summary>
            /// PredefinedMetricPairSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricspecification-predefinedmetricpairspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingPredefinedMetricPair
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingPredefinedMetricPair, BaseFunction>? PredefinedMetricPairSpecification { get; set; }
        }

        public class PredictiveScalingMetricStat : Humidifier.Base.BaseSubResource, IHaveStat, IHaveApplicationAutoScalingScalingPolicyTypesPredictiveScalingMetricMetric, IHaveUnit
        {
            /// <summary>
            /// Stat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricstat.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricstat-stat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stat { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricstat.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricstat-metric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingMetric
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetric, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingmetricstat.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingmetricstat-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class PredictiveScalingPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxCapacityBreachBehavior, IHaveMaxCapacityBuffer_Integer, IHaveMode, IHaveListOfApplicationAutoScalingScalingPolicyTypesPredictiveScalingMetricSpecificationMetricSpecifications, IHaveSchedulingBufferTime_Integer
        {
            /// <summary>
            /// MaxCapacityBreachBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration-maxcapacitybreachbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxCapacityBreachBehavior { get; set; }
            /// <summary>
            /// MaxCapacityBuffer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration-maxcapacitybuffer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacityBuffer { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
            /// <summary>
            /// MetricSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration-metricspecifications
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PredictiveScalingMetricSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricSpecification>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredictiveScalingMetricSpecification, BaseFunction>>, BaseFunction>? MetricSpecifications { get; set; }
            /// <summary>
            /// SchedulingBufferTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpolicyconfiguration-schedulingbuffertime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SchedulingBufferTime { get; set; }
        }

        public class PredictiveScalingPredefinedLoadMetric : Humidifier.Base.BaseSubResource, IHavePredefinedMetricType, IHaveResourceLabel
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpredefinedloadmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpredefinedloadmetric-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredefinedMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpredefinedloadmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpredefinedloadmetric-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceLabel { get; set; }
        }

        public class PredictiveScalingPredefinedMetricPair : Humidifier.Base.BaseSubResource, IHavePredefinedMetricType, IHaveResourceLabel
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpredefinedmetricpair.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpredefinedmetricpair-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredefinedMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpredefinedmetricpair.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpredefinedmetricpair-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceLabel { get; set; }
        }

        public class PredictiveScalingPredefinedScalingMetric : Humidifier.Base.BaseSubResource, IHavePredefinedMetricType, IHaveResourceLabel
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpredefinedscalingmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpredefinedscalingmetric-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredefinedMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-predictivescalingpredefinedscalingmetric.html#cfn-applicationautoscaling-scalingpolicy-predictivescalingpredefinedscalingmetric-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceLabel { get; set; }
        }

        public class StepAdjustment : Humidifier.Base.BaseSubResource, IHaveMetricIntervalUpperBound_Double, IHaveMetricIntervalLowerBound_Double, IHaveScalingAdjustment_Integer
        {
            /// <summary>
            /// MetricIntervalUpperBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepadjustment.html#cfn-applicationautoscaling-scalingpolicy-stepadjustment-metricintervalupperbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MetricIntervalUpperBound { get; set; }
            /// <summary>
            /// MetricIntervalLowerBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepadjustment.html#cfn-applicationautoscaling-scalingpolicy-stepadjustment-metricintervallowerbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MetricIntervalLowerBound { get; set; }
            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepadjustment.html#cfn-applicationautoscaling-scalingpolicy-stepadjustment-scalingadjustment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScalingAdjustment { get; set; }
        }

        public class StepScalingPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveMetricAggregationType, IHaveCooldown_Integer, IHaveListOfApplicationAutoScalingScalingPolicyTypesStepAdjustmentStepAdjustments, IHaveMinAdjustmentMagnitude_Integer, IHaveAdjustmentType
        {
            /// <summary>
            /// MetricAggregationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration-metricaggregationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricAggregationType { get; set; }
            /// <summary>
            /// Cooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration-cooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Cooldown { get; set; }
            /// <summary>
            /// StepAdjustments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration-stepadjustments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StepAdjustment
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.StepAdjustment>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.StepAdjustment, BaseFunction>>, BaseFunction>? StepAdjustments { get; set; }
            /// <summary>
            /// MinAdjustmentMagnitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration-minadjustmentmagnitude
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinAdjustmentMagnitude { get; set; }
            /// <summary>
            /// AdjustmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-stepscalingpolicyconfiguration-adjustmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdjustmentType { get; set; }
        }

        public class TargetTrackingMetric : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveListOfApplicationAutoScalingScalingPolicyTypesTargetTrackingMetricDimensionDimensions, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetric.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetric-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetric.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetric-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrackingMetricDimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.TargetTrackingMetricDimension>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.TargetTrackingMetricDimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetric.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetric-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class TargetTrackingMetricDataQuery : Humidifier.Base.BaseSubResource, IHaveReturnData_Boolean, IHaveExpression, IHaveLabel, IHaveApplicationAutoScalingScalingPolicyTypesTargetTrackingMetricStatMetricStat, IHaveId
        {
            /// <summary>
            /// ReturnData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery-returndata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReturnData { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Label { get; set; }
            /// <summary>
            /// MetricStat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery-metricstat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetTrackingMetricStat
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.TargetTrackingMetricStat, BaseFunction>? MetricStat { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricdataquery-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class TargetTrackingMetricDimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricdimension.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricdimension-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricdimension.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricdimension-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TargetTrackingMetricStat : Humidifier.Base.BaseSubResource, IHaveStat, IHaveApplicationAutoScalingScalingPolicyTypesTargetTrackingMetricMetric, IHaveUnit
        {
            /// <summary>
            /// Stat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricstat.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricstat-stat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stat { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricstat.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricstat-metric
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetTrackingMetric
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.TargetTrackingMetric, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingmetricstat.html#cfn-applicationautoscaling-scalingpolicy-targettrackingmetricstat-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }

        public class TargetTrackingScalingPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveScaleOutCooldown_Integer, IHaveTargetValue_Double, IHaveApplicationAutoScalingScalingPolicyTypesCustomizedMetricSpecificationCustomizedMetricSpecification, IHaveDisableScaleIn_Boolean, IHaveScaleInCooldown_Integer, IHaveApplicationAutoScalingScalingPolicyTypesPredefinedMetricSpecificationPredefinedMetricSpecification
        {
            /// <summary>
            /// ScaleOutCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration-scaleoutcooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleOutCooldown { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
            /// <summary>
            /// CustomizedMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration-customizedmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomizedMetricSpecification
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification, BaseFunction>? CustomizedMetricSpecification { get; set; }
            /// <summary>
            /// DisableScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration-disablescalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableScaleIn { get; set; }
            /// <summary>
            /// ScaleInCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration-scaleincooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleInCooldown { get; set; }
            /// <summary>
            /// PredefinedMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration.html#cfn-applicationautoscaling-scalingpolicy-targettrackingscalingpolicyconfiguration-predefinedmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredefinedMetricSpecification
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification, BaseFunction>? PredefinedMetricSpecification { get; set; }
        }
    }
}