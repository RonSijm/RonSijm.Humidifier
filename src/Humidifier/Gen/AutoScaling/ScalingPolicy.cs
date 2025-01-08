namespace Humidifier.AutoScaling
{
    using System.Collections.Generic;
    using ScalingPolicyTypes;

    public class ScalingPolicy : Humidifier.Base.BaseResource, IHavePolicyType, IHaveScalingAdjustment, IHaveAutoScalingGroupName, IHaveAdjustmentType, IHaveCooldown, IHaveEstimatedInstanceWarmup, IHaveMetricAggregationType, IHaveMinAdjustmentMagnitude
    {
        public class Attributes
        {
            public static string PolicyName =  "PolicyName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AutoScaling.ScalingPolicy; }
        /// <summary>
        /// MetricAggregationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-metricaggregationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MetricAggregationType { get; set; }
        /// <summary>
        /// PolicyType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-policytype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PolicyType { get; set; }
        /// <summary>
        /// PredictiveScalingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-predictivescalingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PredictiveScalingConfiguration
        /// </summary>
        public Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingConfiguration PredictiveScalingConfiguration { get; set; }
        /// <summary>
        /// ScalingAdjustment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-scalingadjustment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ScalingAdjustment { get; set; }
        /// <summary>
        /// Cooldown
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-cooldown
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cooldown { get; set; }
        /// <summary>
        /// StepAdjustments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-stepadjustments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StepAdjustment
        /// </summary>
        public List<Humidifier.AutoScaling.ScalingPolicyTypes.StepAdjustment> StepAdjustments { get; set; }

        /// <summary>
        /// AutoScalingGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-autoscalinggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AutoScalingGroupName { get; set; }
        /// <summary>
        /// MinAdjustmentMagnitude
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-minadjustmentmagnitude
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinAdjustmentMagnitude { get; set; }
        /// <summary>
        /// TargetTrackingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TargetTrackingConfiguration
        /// </summary>
        public Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingConfiguration TargetTrackingConfiguration { get; set; }
        /// <summary>
        /// EstimatedInstanceWarmup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-estimatedinstancewarmup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic EstimatedInstanceWarmup { get; set; }
        /// <summary>
        /// AdjustmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-scalingpolicy.html#cfn-autoscaling-scalingpolicy-adjustmenttype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AdjustmentType { get; set; }
    }

    namespace ScalingPolicyTypes
    {
        public class CustomizedMetricSpecification : Humidifier.Base.BaseSubResource, IHaveUnit, IHaveMetricName, IHaveNamespace_, IHavePeriod, IHaveStatistic
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-customizedmetricspecification.html#cfn-autoscaling-scalingpolicy-customizedmetricspecification-metricname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-customizedmetricspecification.html#cfn-autoscaling-scalingpolicy-customizedmetricspecification-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrackingMetricDataQuery
            /// </summary>
            public List<Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingMetricDataQuery> Metrics { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-customizedmetricspecification.html#cfn-autoscaling-scalingpolicy-customizedmetricspecification-statistic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Statistic { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-customizedmetricspecification.html#cfn-autoscaling-scalingpolicy-customizedmetricspecification-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public List<Humidifier.AutoScaling.ScalingPolicyTypes.MetricDimension> Dimensions { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-customizedmetricspecification.html#cfn-autoscaling-scalingpolicy-customizedmetricspecification-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Period { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-customizedmetricspecification.html#cfn-autoscaling-scalingpolicy-customizedmetricspecification-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-customizedmetricspecification.html#cfn-autoscaling-scalingpolicy-customizedmetricspecification-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class Metric : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metric.html#cfn-autoscaling-scalingpolicy-metric-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metric.html#cfn-autoscaling-scalingpolicy-metric-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public List<Humidifier.AutoScaling.ScalingPolicyTypes.MetricDimension> Dimensions { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metric.html#cfn-autoscaling-scalingpolicy-metric-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class MetricDataQuery : Humidifier.Base.BaseSubResource, IHaveId, IHaveExpression, IHaveLabel, IHaveReturnData
        {
            /// <summary>
            /// ReturnData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricdataquery.html#cfn-autoscaling-scalingpolicy-metricdataquery-returndata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReturnData { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricdataquery.html#cfn-autoscaling-scalingpolicy-metricdataquery-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricdataquery.html#cfn-autoscaling-scalingpolicy-metricdataquery-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// MetricStat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricdataquery.html#cfn-autoscaling-scalingpolicy-metricdataquery-metricstat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricStat
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.MetricStat MetricStat { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricdataquery.html#cfn-autoscaling-scalingpolicy-metricdataquery-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class MetricDimension : Humidifier.Base.BaseSubResource, IHaveName, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricdimension.html#cfn-autoscaling-scalingpolicy-metricdimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricdimension.html#cfn-autoscaling-scalingpolicy-metricdimension-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MetricStat : Humidifier.Base.BaseSubResource, IHaveUnit, IHaveStat, IHaveAutoScalingScalingPolicyTypesMetricMetric
        {
            /// <summary>
            /// Stat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricstat.html#cfn-autoscaling-scalingpolicy-metricstat-stat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Stat { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricstat.html#cfn-autoscaling-scalingpolicy-metricstat-metric
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Metric
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.Metric Metric { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-metricstat.html#cfn-autoscaling-scalingpolicy-metricstat-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }

        public class PredefinedMetricSpecification : Humidifier.Base.BaseSubResource, IHaveResourceLabel, IHavePredefinedMetricType
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predefinedmetricspecification.html#cfn-autoscaling-scalingpolicy-predefinedmetricspecification-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PredefinedMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predefinedmetricspecification.html#cfn-autoscaling-scalingpolicy-predefinedmetricspecification-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceLabel { get; set; }
        }

        public class PredictiveScalingConfiguration : Humidifier.Base.BaseSubResource, IHaveMode, IHaveMaxCapacityBreachBehavior, IHaveMaxCapacityBuffer, IHaveSchedulingBufferTime
        {
            /// <summary>
            /// MaxCapacityBreachBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingconfiguration.html#cfn-autoscaling-scalingpolicy-predictivescalingconfiguration-maxcapacitybreachbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxCapacityBreachBehavior { get; set; }
            /// <summary>
            /// MaxCapacityBuffer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingconfiguration.html#cfn-autoscaling-scalingpolicy-predictivescalingconfiguration-maxcapacitybuffer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCapacityBuffer { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingconfiguration.html#cfn-autoscaling-scalingpolicy-predictivescalingconfiguration-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// MetricSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingconfiguration.html#cfn-autoscaling-scalingpolicy-predictivescalingconfiguration-metricspecifications
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PredictiveScalingMetricSpecification
            /// </summary>
            public List<Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingMetricSpecification> MetricSpecifications { get; set; }
            /// <summary>
            /// SchedulingBufferTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingconfiguration.html#cfn-autoscaling-scalingpolicy-predictivescalingconfiguration-schedulingbuffertime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SchedulingBufferTime { get; set; }
        }

        public class PredictiveScalingCustomizedCapacityMetric : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetricDataQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingcustomizedcapacitymetric.html#cfn-autoscaling-scalingpolicy-predictivescalingcustomizedcapacitymetric-metricdataqueries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDataQuery
            /// </summary>
            public List<Humidifier.AutoScaling.ScalingPolicyTypes.MetricDataQuery> MetricDataQueries { get; set; }
        }

        public class PredictiveScalingCustomizedLoadMetric : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetricDataQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingcustomizedloadmetric.html#cfn-autoscaling-scalingpolicy-predictivescalingcustomizedloadmetric-metricdataqueries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDataQuery
            /// </summary>
            public List<Humidifier.AutoScaling.ScalingPolicyTypes.MetricDataQuery> MetricDataQueries { get; set; }
        }

        public class PredictiveScalingCustomizedScalingMetric : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MetricDataQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingcustomizedscalingmetric.html#cfn-autoscaling-scalingpolicy-predictivescalingcustomizedscalingmetric-metricdataqueries
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDataQuery
            /// </summary>
            public List<Humidifier.AutoScaling.ScalingPolicyTypes.MetricDataQuery> MetricDataQueries { get; set; }
        }

        public class PredictiveScalingMetricSpecification : Humidifier.Base.BaseSubResource, IHaveTargetValue
        {
            /// <summary>
            /// CustomizedLoadMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-autoscaling-scalingpolicy-predictivescalingmetricspecification-customizedloadmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingCustomizedLoadMetric
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingCustomizedLoadMetric CustomizedLoadMetricSpecification { get; set; }
            /// <summary>
            /// PredefinedLoadMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-autoscaling-scalingpolicy-predictivescalingmetricspecification-predefinedloadmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingPredefinedLoadMetric
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingPredefinedLoadMetric PredefinedLoadMetricSpecification { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-autoscaling-scalingpolicy-predictivescalingmetricspecification-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetValue { get; set; }
            /// <summary>
            /// PredefinedScalingMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-autoscaling-scalingpolicy-predictivescalingmetricspecification-predefinedscalingmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingPredefinedScalingMetric
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingPredefinedScalingMetric PredefinedScalingMetricSpecification { get; set; }
            /// <summary>
            /// CustomizedCapacityMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-autoscaling-scalingpolicy-predictivescalingmetricspecification-customizedcapacitymetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingCustomizedCapacityMetric
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingCustomizedCapacityMetric CustomizedCapacityMetricSpecification { get; set; }
            /// <summary>
            /// CustomizedScalingMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-autoscaling-scalingpolicy-predictivescalingmetricspecification-customizedscalingmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingCustomizedScalingMetric
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingCustomizedScalingMetric CustomizedScalingMetricSpecification { get; set; }
            /// <summary>
            /// PredefinedMetricPairSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingmetricspecification.html#cfn-autoscaling-scalingpolicy-predictivescalingmetricspecification-predefinedmetricpairspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredictiveScalingPredefinedMetricPair
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.PredictiveScalingPredefinedMetricPair PredefinedMetricPairSpecification { get; set; }
        }

        public class PredictiveScalingPredefinedLoadMetric : Humidifier.Base.BaseSubResource, IHaveResourceLabel, IHavePredefinedMetricType
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingpredefinedloadmetric.html#cfn-autoscaling-scalingpolicy-predictivescalingpredefinedloadmetric-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PredefinedMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingpredefinedloadmetric.html#cfn-autoscaling-scalingpolicy-predictivescalingpredefinedloadmetric-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceLabel { get; set; }
        }

        public class PredictiveScalingPredefinedMetricPair : Humidifier.Base.BaseSubResource, IHaveResourceLabel, IHavePredefinedMetricType
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingpredefinedmetricpair.html#cfn-autoscaling-scalingpolicy-predictivescalingpredefinedmetricpair-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PredefinedMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingpredefinedmetricpair.html#cfn-autoscaling-scalingpolicy-predictivescalingpredefinedmetricpair-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceLabel { get; set; }
        }

        public class PredictiveScalingPredefinedScalingMetric : Humidifier.Base.BaseSubResource, IHaveResourceLabel, IHavePredefinedMetricType
        {
            /// <summary>
            /// PredefinedMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingpredefinedscalingmetric.html#cfn-autoscaling-scalingpolicy-predictivescalingpredefinedscalingmetric-predefinedmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PredefinedMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-predictivescalingpredefinedscalingmetric.html#cfn-autoscaling-scalingpolicy-predictivescalingpredefinedscalingmetric-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceLabel { get; set; }
        }

        public class StepAdjustment : Humidifier.Base.BaseSubResource, IHaveScalingAdjustment, IHaveMetricIntervalUpperBound, IHaveMetricIntervalLowerBound
        {
            /// <summary>
            /// MetricIntervalUpperBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-stepadjustment.html#cfn-autoscaling-scalingpolicy-stepadjustment-metricintervalupperbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MetricIntervalUpperBound { get; set; }
            /// <summary>
            /// MetricIntervalLowerBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-stepadjustment.html#cfn-autoscaling-scalingpolicy-stepadjustment-metricintervallowerbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MetricIntervalLowerBound { get; set; }
            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-stepadjustment.html#cfn-autoscaling-scalingpolicy-stepadjustment-scalingadjustment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ScalingAdjustment { get; set; }
        }

        public class TargetTrackingConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetValue, IHaveDisableScaleIn
        {
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetValue { get; set; }
            /// <summary>
            /// CustomizedMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration-customizedmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomizedMetricSpecification
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.CustomizedMetricSpecification CustomizedMetricSpecification { get; set; }
            /// <summary>
            /// DisableScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration-disablescalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DisableScaleIn { get; set; }
            /// <summary>
            /// PredefinedMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingconfiguration.html#cfn-autoscaling-scalingpolicy-targettrackingconfiguration-predefinedmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredefinedMetricSpecification
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.PredefinedMetricSpecification PredefinedMetricSpecification { get; set; }
        }

        public class TargetTrackingMetricDataQuery : Humidifier.Base.BaseSubResource, IHaveId, IHaveExpression, IHaveLabel, IHavePeriod, IHaveReturnData
        {
            /// <summary>
            /// ReturnData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-autoscaling-scalingpolicy-targettrackingmetricdataquery-returndata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReturnData { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-autoscaling-scalingpolicy-targettrackingmetricdataquery-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Label
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-autoscaling-scalingpolicy-targettrackingmetricdataquery-label
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Label { get; set; }
            /// <summary>
            /// MetricStat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-autoscaling-scalingpolicy-targettrackingmetricdataquery-metricstat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetTrackingMetricStat
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.TargetTrackingMetricStat MetricStat { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-autoscaling-scalingpolicy-targettrackingmetricdataquery-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Period { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricdataquery.html#cfn-autoscaling-scalingpolicy-targettrackingmetricdataquery-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class TargetTrackingMetricStat : Humidifier.Base.BaseSubResource, IHaveUnit, IHavePeriod, IHaveStat, IHaveAutoScalingScalingPolicyTypesMetricMetric
        {
            /// <summary>
            /// Stat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricstat.html#cfn-autoscaling-scalingpolicy-targettrackingmetricstat-stat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Stat { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricstat.html#cfn-autoscaling-scalingpolicy-targettrackingmetricstat-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Period { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricstat.html#cfn-autoscaling-scalingpolicy-targettrackingmetricstat-metric
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Metric
            /// </summary>
            public Humidifier.AutoScaling.ScalingPolicyTypes.Metric Metric { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-targettrackingmetricstat.html#cfn-autoscaling-scalingpolicy-targettrackingmetricstat-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit { get; set; }
        }
    }
}