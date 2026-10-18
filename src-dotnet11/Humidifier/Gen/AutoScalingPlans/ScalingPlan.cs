namespace Humidifier.AutoScalingPlans
{
    using global::System.Collections.Generic;
    using ScalingPlanTypes;

    public class ScalingPlan : Humidifier.Base.BaseResource, IHaveAutoScalingPlansScalingPlanTypesApplicationSourceApplicationSource, IHaveListOfAutoScalingPlansScalingPlanTypesScalingInstructionScalingInstructions
    {
        public class Attributes
        {
            public static string ScalingPlanName =  "ScalingPlanName" ;
            public static string ScalingPlanVersion =  "ScalingPlanVersion" ;
        }

        public override string AWSTypeName { get => AWS.AutoScalingPlans.ScalingPlan; }

        /// <summary>
        /// ApplicationSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscalingplans-scalingplan.html#cfn-autoscalingplans-scalingplan-applicationsource
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ApplicationSource
        /// </summary>
        [Required]
        public Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.ApplicationSource, BaseFunction>? ApplicationSource { get; set; }

        /// <summary>
        /// ScalingInstructions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscalingplans-scalingplan.html#cfn-autoscalingplans-scalingplan-scalinginstructions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ScalingInstruction
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction>, IReadOnlyList<Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.ScalingInstruction, BaseFunction>>, BaseFunction>? ScalingInstructions { get; set; }
    }

    namespace ScalingPlanTypes
    {
        public class ApplicationSource : Humidifier.Base.BaseSubResource, IHaveCloudFormationStackARN, IHaveListOfAutoScalingPlansScalingPlanTypesTagFilterTagFilters
        {
            /// <summary>
            /// CloudFormationStackARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-applicationsource.html#cfn-autoscalingplans-scalingplan-applicationsource-cloudformationstackarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudFormationStackARN { get; set; }
            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-applicationsource.html#cfn-autoscalingplans-scalingplan-applicationsource-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AutoScalingPlans.ScalingPlanTypes.TagFilter>, IReadOnlyList<Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.TagFilter, BaseFunction>>, BaseFunction>? TagFilters { get; set; }
        }

        public class CustomizedLoadMetricSpecification : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveStatistic, IHaveListOfAutoScalingPlansScalingPlanTypesMetricDimensionDimensions, IHaveUnit, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedloadmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedloadmetricspecification-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedloadmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedloadmetricspecification-statistic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statistic { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedloadmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedloadmetricspecification-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AutoScalingPlans.ScalingPlanTypes.MetricDimension>, IReadOnlyList<Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.MetricDimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedloadmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedloadmetricspecification-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedloadmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedloadmetricspecification-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class CustomizedScalingMetricSpecification : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveStatistic, IHaveListOfAutoScalingPlansScalingPlanTypesMetricDimensionDimensions, IHaveUnit, IHaveNamespace_
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-statistic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statistic { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AutoScalingPlans.ScalingPlanTypes.MetricDimension>, IReadOnlyList<Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.MetricDimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-customizedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-customizedscalingmetricspecification-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class MetricDimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-metricdimension.html#cfn-autoscalingplans-scalingplan-metricdimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-metricdimension.html#cfn-autoscalingplans-scalingplan-metricdimension-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PredefinedLoadMetricSpecification : Humidifier.Base.BaseSubResource, IHavePredefinedLoadMetricType, IHaveResourceLabel
        {
            /// <summary>
            /// PredefinedLoadMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedloadmetricspecification.html#cfn-autoscalingplans-scalingplan-predefinedloadmetricspecification-predefinedloadmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredefinedLoadMetricType { get; set; }
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedloadmetricspecification.html#cfn-autoscalingplans-scalingplan-predefinedloadmetricspecification-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceLabel { get; set; }
        }

        public class PredefinedScalingMetricSpecification : Humidifier.Base.BaseSubResource, IHaveResourceLabel, IHavePredefinedScalingMetricType
        {
            /// <summary>
            /// ResourceLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-predefinedscalingmetricspecification-resourcelabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceLabel { get; set; }
            /// <summary>
            /// PredefinedScalingMetricType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-predefinedscalingmetricspecification.html#cfn-autoscalingplans-scalingplan-predefinedscalingmetricspecification-predefinedscalingmetrictype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredefinedScalingMetricType { get; set; }
        }

        public class ScalingInstruction : Humidifier.Base.BaseSubResource, IHaveDisableDynamicScaling_Boolean, IHaveServiceNamespace, IHavePredictiveScalingMaxCapacityBehavior, IHaveScalableDimension, IHaveScalingPolicyUpdateBehavior, IHaveMinCapacity_Integer, IHaveListOfAutoScalingPlansScalingPlanTypesTargetTrackingConfigurationTargetTrackingConfigurations, IHavePredictiveScalingMaxCapacityBuffer_Integer, IHaveAutoScalingPlansScalingPlanTypesCustomizedLoadMetricSpecificationCustomizedLoadMetricSpecification, IHaveAutoScalingPlansScalingPlanTypesPredefinedLoadMetricSpecificationPredefinedLoadMetricSpecification, IHaveResourceId, IHaveScheduledActionBufferTime_Integer, IHaveMaxCapacity_Integer, IHavePredictiveScalingMode
        {
            /// <summary>
            /// DisableDynamicScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-disabledynamicscaling
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableDynamicScaling { get; set; }
            /// <summary>
            /// ServiceNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-servicenamespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceNamespace { get; set; }
            /// <summary>
            /// PredictiveScalingMaxCapacityBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-predictivescalingmaxcapacitybehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredictiveScalingMaxCapacityBehavior { get; set; }
            /// <summary>
            /// ScalableDimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-scalabledimension
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalableDimension { get; set; }
            /// <summary>
            /// ScalingPolicyUpdateBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-scalingpolicyupdatebehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScalingPolicyUpdateBehavior { get; set; }
            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinCapacity { get; set; }
            /// <summary>
            /// TargetTrackingConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-targettrackingconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TargetTrackingConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AutoScalingPlans.ScalingPlanTypes.TargetTrackingConfiguration>, IReadOnlyList<Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.TargetTrackingConfiguration, BaseFunction>>, BaseFunction>? TargetTrackingConfigurations { get; set; }
            /// <summary>
            /// PredictiveScalingMaxCapacityBuffer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-predictivescalingmaxcapacitybuffer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PredictiveScalingMaxCapacityBuffer { get; set; }
            /// <summary>
            /// CustomizedLoadMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-customizedloadmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomizedLoadMetricSpecification
            /// </summary>
            public Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.CustomizedLoadMetricSpecification, BaseFunction>? CustomizedLoadMetricSpecification { get; set; }
            /// <summary>
            /// PredefinedLoadMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-predefinedloadmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredefinedLoadMetricSpecification
            /// </summary>
            public Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.PredefinedLoadMetricSpecification, BaseFunction>? PredefinedLoadMetricSpecification { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-resourceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// ScheduledActionBufferTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-scheduledactionbuffertime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScheduledActionBufferTime { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
            /// <summary>
            /// PredictiveScalingMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-scalinginstruction.html#cfn-autoscalingplans-scalingplan-scalinginstruction-predictivescalingmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PredictiveScalingMode { get; set; }
        }

        public class TagFilter : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-tagfilter.html#cfn-autoscalingplans-scalingplan-tagfilter-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-tagfilter.html#cfn-autoscalingplans-scalingplan-tagfilter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TargetTrackingConfiguration : Humidifier.Base.BaseSubResource, IHaveScaleOutCooldown_Integer, IHaveTargetValue_Double, IHaveAutoScalingPlansScalingPlanTypesPredefinedScalingMetricSpecificationPredefinedScalingMetricSpecification, IHaveDisableScaleIn_Boolean, IHaveScaleInCooldown_Integer, IHaveEstimatedInstanceWarmup_Integer, IHaveAutoScalingPlansScalingPlanTypesCustomizedScalingMetricSpecificationCustomizedScalingMetricSpecification
        {
            /// <summary>
            /// ScaleOutCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-targettrackingconfiguration.html#cfn-autoscalingplans-scalingplan-targettrackingconfiguration-scaleoutcooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleOutCooldown { get; set; }
            /// <summary>
            /// TargetValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-targettrackingconfiguration.html#cfn-autoscalingplans-scalingplan-targettrackingconfiguration-targetvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetValue { get; set; }
            /// <summary>
            /// PredefinedScalingMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-targettrackingconfiguration.html#cfn-autoscalingplans-scalingplan-targettrackingconfiguration-predefinedscalingmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PredefinedScalingMetricSpecification
            /// </summary>
            public Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.PredefinedScalingMetricSpecification, BaseFunction>? PredefinedScalingMetricSpecification { get; set; }
            /// <summary>
            /// DisableScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-targettrackingconfiguration.html#cfn-autoscalingplans-scalingplan-targettrackingconfiguration-disablescalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableScaleIn { get; set; }
            /// <summary>
            /// ScaleInCooldown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-targettrackingconfiguration.html#cfn-autoscalingplans-scalingplan-targettrackingconfiguration-scaleincooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleInCooldown { get; set; }
            /// <summary>
            /// EstimatedInstanceWarmup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-targettrackingconfiguration.html#cfn-autoscalingplans-scalingplan-targettrackingconfiguration-estimatedinstancewarmup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EstimatedInstanceWarmup { get; set; }
            /// <summary>
            /// CustomizedScalingMetricSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscalingplans-scalingplan-targettrackingconfiguration.html#cfn-autoscalingplans-scalingplan-targettrackingconfiguration-customizedscalingmetricspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomizedScalingMetricSpecification
            /// </summary>
            public Union<Humidifier.AutoScalingPlans.ScalingPlanTypes.CustomizedScalingMetricSpecification, BaseFunction>? CustomizedScalingMetricSpecification { get; set; }
        }
    }
}