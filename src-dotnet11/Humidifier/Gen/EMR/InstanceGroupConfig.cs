namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using InstanceGroupConfigTypes;

    public class InstanceGroupConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveJobFlowId, IHaveEMRInstanceGroupConfigTypesAutoScalingPolicyAutoScalingPolicy, IHaveBidPrice, IHaveInstanceCount_Integer, IHaveEMRInstanceGroupConfigTypesEbsConfigurationEbsConfiguration, IHaveInstanceRole, IHaveCustomAmiId, IHaveListOfEMRInstanceGroupConfigTypesAppConfigurationConfigurations, IHaveInstanceType, IHaveMarket, IHaveName
    {
        public class Attributes
        {
            public static string InstanceGroupId =  "InstanceGroupId" ;
        }

        public override string AWSTypeName { get => AWS.EMR.InstanceGroupConfig; }

        /// <summary>
        /// JobFlowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-jobflowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? JobFlowId { get; set; }
        /// <summary>
        /// AutoScalingPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-autoscalingpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoScalingPolicy
        /// </summary>
        public Union<Humidifier.EMR.InstanceGroupConfigTypes.AutoScalingPolicy, BaseFunction>? AutoScalingPolicy { get; set; }
        /// <summary>
        /// BidPrice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-bidprice
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BidPrice { get; set; }

        /// <summary>
        /// InstanceCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-instancecount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? InstanceCount { get; set; }
        /// <summary>
        /// EbsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-ebsconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EbsConfiguration
        /// </summary>
        public Union<Humidifier.EMR.InstanceGroupConfigTypes.EbsConfiguration, BaseFunction>? EbsConfiguration { get; set; }

        /// <summary>
        /// InstanceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-instancerole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceRole { get; set; }
        /// <summary>
        /// CustomAmiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-customamiid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomAmiId { get; set; }
        /// <summary>
        /// Configurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-configurations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AppConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration>, IReadOnlyList<Union<Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration, BaseFunction>>, BaseFunction>? Configurations { get; set; }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-instancetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceType { get; set; }
        /// <summary>
        /// Market
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-market
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Market { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace InstanceGroupConfigTypes
    {
        public class AppConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfEMRInstanceGroupConfigTypesAppConfigurationConfigurations, IHaveClassification, IHaveStringDictionaryOfConfigurationProperties
        {
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-appconfiguration.html#cfn-emr-instancegroupconfig-appconfiguration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AppConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration>, IReadOnlyList<Union<Humidifier.EMR.InstanceGroupConfigTypes.AppConfiguration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-appconfiguration.html#cfn-emr-instancegroupconfig-appconfiguration-classification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
            /// <summary>
            /// ConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-appconfiguration.html#cfn-emr-instancegroupconfig-appconfiguration-configurationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ConfigurationProperties { get; set; }
        }

        public class AutoScalingPolicy : Humidifier.Base.BaseSubResource, IHaveEMRInstanceGroupConfigTypesScalingConstraintsConstraints, IHaveListOfEMRInstanceGroupConfigTypesScalingRuleRules
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-autoscalingpolicy.html#cfn-emr-instancegroupconfig-autoscalingpolicy-constraints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingConstraints
            /// </summary>
            public Union<Humidifier.EMR.InstanceGroupConfigTypes.ScalingConstraints, BaseFunction>? Constraints { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-autoscalingpolicy.html#cfn-emr-instancegroupconfig-autoscalingpolicy-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScalingRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceGroupConfigTypes.ScalingRule>, IReadOnlyList<Union<Humidifier.EMR.InstanceGroupConfigTypes.ScalingRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class CloudWatchAlarmDefinition : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveComparisonOperator, IHaveStatistic, IHaveListOfEMRInstanceGroupConfigTypesMetricDimensionDimensions, IHavePeriod_Integer, IHaveEvaluationPeriods_Integer, IHaveUnit, IHaveNamespace_, IHaveThreshold_Double
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-statistic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statistic { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceGroupConfigTypes.MetricDimension>, IReadOnlyList<Union<Humidifier.EMR.InstanceGroupConfigTypes.MetricDimension, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Period { get; set; }
            /// <summary>
            /// EvaluationPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-evaluationperiods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EvaluationPeriods { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-emr-instancegroupconfig-cloudwatchalarmdefinition-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Threshold { get; set; }
        }

        public class EbsBlockDeviceConfig : Humidifier.Base.BaseSubResource, IHaveEMRInstanceGroupConfigTypesVolumeSpecificationVolumeSpecification, IHaveVolumesPerInstance_Integer
        {
            /// <summary>
            /// VolumeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-ebsblockdeviceconfig.html#cfn-emr-instancegroupconfig-ebsblockdeviceconfig-volumespecification
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VolumeSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceGroupConfigTypes.VolumeSpecification, BaseFunction>? VolumeSpecification { get; set; }
            /// <summary>
            /// VolumesPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-ebsblockdeviceconfig.html#cfn-emr-instancegroupconfig-ebsblockdeviceconfig-volumesperinstance
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumesPerInstance { get; set; }
        }

        public class EbsConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfEMRInstanceGroupConfigTypesEbsBlockDeviceConfigEbsBlockDeviceConfigs, IHaveEbsOptimized_Boolean
        {
            /// <summary>
            /// EbsBlockDeviceConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-ebsconfiguration.html#cfn-emr-instancegroupconfig-ebsconfiguration-ebsblockdeviceconfigs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EbsBlockDeviceConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceGroupConfigTypes.EbsBlockDeviceConfig>, IReadOnlyList<Union<Humidifier.EMR.InstanceGroupConfigTypes.EbsBlockDeviceConfig, BaseFunction>>, BaseFunction>? EbsBlockDeviceConfigs { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-ebsconfiguration.html#cfn-emr-instancegroupconfig-ebsconfiguration-ebsoptimized
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
        }

        public class MetricDimension : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-metricdimension.html#cfn-emr-instancegroupconfig-metricdimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-metricdimension.html#cfn-emr-instancegroupconfig-metricdimension-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ScalingAction : Humidifier.Base.BaseSubResource, IHaveEMRInstanceGroupConfigTypesSimpleScalingPolicyConfigurationSimpleScalingPolicyConfiguration, IHaveMarket
        {
            /// <summary>
            /// SimpleScalingPolicyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingaction.html#cfn-emr-instancegroupconfig-scalingaction-simplescalingpolicyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SimpleScalingPolicyConfiguration
            /// </summary>
            public Union<Humidifier.EMR.InstanceGroupConfigTypes.SimpleScalingPolicyConfiguration, BaseFunction>? SimpleScalingPolicyConfiguration { get; set; }
            /// <summary>
            /// Market
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingaction.html#cfn-emr-instancegroupconfig-scalingaction-market
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Market { get; set; }
        }

        public class ScalingConstraints : Humidifier.Base.BaseSubResource, IHaveMinCapacity_Integer, IHaveMaxCapacity_Integer
        {
            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingconstraints.html#cfn-emr-instancegroupconfig-scalingconstraints-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinCapacity { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingconstraints.html#cfn-emr-instancegroupconfig-scalingconstraints-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
        }

        public class ScalingRule : Humidifier.Base.BaseSubResource, IHaveEMRInstanceGroupConfigTypesScalingActionAction, IHaveDescription, IHaveEMRInstanceGroupConfigTypesScalingTriggerTrigger, IHaveName
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingrule.html#cfn-emr-instancegroupconfig-scalingrule-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingAction
            /// </summary>
            public Union<Humidifier.EMR.InstanceGroupConfigTypes.ScalingAction, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingrule.html#cfn-emr-instancegroupconfig-scalingrule-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingrule.html#cfn-emr-instancegroupconfig-scalingrule-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingTrigger
            /// </summary>
            public Union<Humidifier.EMR.InstanceGroupConfigTypes.ScalingTrigger, BaseFunction>? Trigger { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingrule.html#cfn-emr-instancegroupconfig-scalingrule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ScalingTrigger : Humidifier.Base.BaseSubResource, IHaveEMRInstanceGroupConfigTypesCloudWatchAlarmDefinitionCloudWatchAlarmDefinition
        {
            /// <summary>
            /// CloudWatchAlarmDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-scalingtrigger.html#cfn-emr-instancegroupconfig-scalingtrigger-cloudwatchalarmdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchAlarmDefinition
            /// </summary>
            public Union<Humidifier.EMR.InstanceGroupConfigTypes.CloudWatchAlarmDefinition, BaseFunction>? CloudWatchAlarmDefinition { get; set; }
        }

        public class SimpleScalingPolicyConfiguration : Humidifier.Base.BaseSubResource, IHaveScalingAdjustment_Integer, IHaveCoolDown_Integer, IHaveAdjustmentType
        {
            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-emr-instancegroupconfig-simplescalingpolicyconfiguration-scalingadjustment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScalingAdjustment { get; set; }
            /// <summary>
            /// CoolDown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-emr-instancegroupconfig-simplescalingpolicyconfiguration-cooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CoolDown { get; set; }
            /// <summary>
            /// AdjustmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-emr-instancegroupconfig-simplescalingpolicyconfiguration-adjustmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdjustmentType { get; set; }
        }

        public class VolumeSpecification : Humidifier.Base.BaseSubResource, IHaveSizeInGB_Integer, IHaveVolumeType, IHaveThroughput_Integer, IHaveIops_Integer
        {
            /// <summary>
            /// SizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-volumespecification.html#cfn-emr-instancegroupconfig-volumespecification-sizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGB { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-volumespecification.html#cfn-emr-instancegroupconfig-volumespecification-volumetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-volumespecification.html#cfn-emr-instancegroupconfig-volumespecification-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancegroupconfig-volumespecification.html#cfn-emr-instancegroupconfig-volumespecification-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
        }
    }
}