namespace Humidifier.Evidently
{
    using global::System.Collections.Generic;
    using LaunchTypes;

    public class Launch : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProject, IHaveDescription, IHaveEvidentlyLaunchTypesExecutionStatusObjectExecutionStatus, IHaveListOfEvidentlyLaunchTypesLaunchGroupObjectGroups, IHaveRandomizationSalt, IHaveListOfEvidentlyLaunchTypesMetricDefinitionObjectMetricMonitors, IHaveListOfEvidentlyLaunchTypesStepConfigScheduledSplitsConfig, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Evidently.Launch; }

        /// <summary>
        /// Project
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-launch.html#cfn-evidently-launch-project
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Project { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-launch.html#cfn-evidently-launch-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ExecutionStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-launch.html#cfn-evidently-launch-executionstatus
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExecutionStatusObject
        /// </summary>
        public Union<Humidifier.Evidently.LaunchTypes.ExecutionStatusObject, BaseFunction>? ExecutionStatus { get; set; }

        /// <summary>
        /// Groups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-launch.html#cfn-evidently-launch-groups
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LaunchGroupObject
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Evidently.LaunchTypes.LaunchGroupObject>, IReadOnlyList<Union<Humidifier.Evidently.LaunchTypes.LaunchGroupObject, BaseFunction>>, BaseFunction>? Groups { get; set; }
        /// <summary>
        /// RandomizationSalt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-launch.html#cfn-evidently-launch-randomizationsalt
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RandomizationSalt { get; set; }
        /// <summary>
        /// MetricMonitors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-launch.html#cfn-evidently-launch-metricmonitors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricDefinitionObject
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Evidently.LaunchTypes.MetricDefinitionObject>, IReadOnlyList<Union<Humidifier.Evidently.LaunchTypes.MetricDefinitionObject, BaseFunction>>, BaseFunction>? MetricMonitors { get; set; }

        /// <summary>
        /// ScheduledSplitsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-launch.html#cfn-evidently-launch-scheduledsplitsconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StepConfig
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Evidently.LaunchTypes.StepConfig>, IReadOnlyList<Union<Humidifier.Evidently.LaunchTypes.StepConfig, BaseFunction>>, BaseFunction>? ScheduledSplitsConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-launch.html#cfn-evidently-launch-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace LaunchTypes
    {
        public class ExecutionStatusObject : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveDesiredState, IHaveReason
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-executionstatusobject.html#cfn-evidently-launch-executionstatusobject-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// DesiredState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-executionstatusobject.html#cfn-evidently-launch-executionstatusobject-desiredstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DesiredState { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-executionstatusobject.html#cfn-evidently-launch-executionstatusobject-reason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Reason { get; set; }
        }

        public class GroupToWeight : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveSplitWeight_Integer
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-grouptoweight.html#cfn-evidently-launch-grouptoweight-groupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// SplitWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-grouptoweight.html#cfn-evidently-launch-grouptoweight-splitweight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SplitWeight { get; set; }
        }

        public class LaunchGroupObject : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveDescription, IHaveVariation, IHaveFeature
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-launchgroupobject.html#cfn-evidently-launch-launchgroupobject-groupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-launchgroupobject.html#cfn-evidently-launch-launchgroupobject-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Variation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-launchgroupobject.html#cfn-evidently-launch-launchgroupobject-variation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Variation { get; set; }
            /// <summary>
            /// Feature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-launchgroupobject.html#cfn-evidently-launch-launchgroupobject-feature
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Feature { get; set; }
        }

        public class MetricDefinitionObject : Humidifier.Base.BaseSubResource, IHaveEntityIdKey, IHaveMetricName, IHaveEventPattern, IHaveValueKey, IHaveUnitLabel
        {
            /// <summary>
            /// EntityIdKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-metricdefinitionobject.html#cfn-evidently-launch-metricdefinitionobject-entityidkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityIdKey { get; set; }
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-metricdefinitionobject.html#cfn-evidently-launch-metricdefinitionobject-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// EventPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-metricdefinitionobject.html#cfn-evidently-launch-metricdefinitionobject-eventpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventPattern { get; set; }
            /// <summary>
            /// ValueKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-metricdefinitionobject.html#cfn-evidently-launch-metricdefinitionobject-valuekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueKey { get; set; }
            /// <summary>
            /// UnitLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-metricdefinitionobject.html#cfn-evidently-launch-metricdefinitionobject-unitlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnitLabel { get; set; }
        }

        public class SegmentOverride : Humidifier.Base.BaseSubResource, IHaveListOfEvidentlyLaunchTypesGroupToWeightWeights, IHaveEvaluationOrder_Integer, IHaveSegment
        {
            /// <summary>
            /// Weights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-segmentoverride.html#cfn-evidently-launch-segmentoverride-weights
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GroupToWeight
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Evidently.LaunchTypes.GroupToWeight>, IReadOnlyList<Union<Humidifier.Evidently.LaunchTypes.GroupToWeight, BaseFunction>>, BaseFunction>? Weights { get; set; }
            /// <summary>
            /// EvaluationOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-segmentoverride.html#cfn-evidently-launch-segmentoverride-evaluationorder
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EvaluationOrder { get; set; }
            /// <summary>
            /// Segment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-segmentoverride.html#cfn-evidently-launch-segmentoverride-segment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Segment { get; set; }
        }

        public class StepConfig : Humidifier.Base.BaseSubResource, IHaveListOfEvidentlyLaunchTypesGroupToWeightGroupWeights, IHaveListOfEvidentlyLaunchTypesSegmentOverrideSegmentOverrides, IHaveStartTime
        {
            /// <summary>
            /// GroupWeights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-stepconfig.html#cfn-evidently-launch-stepconfig-groupweights
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GroupToWeight
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Evidently.LaunchTypes.GroupToWeight>, IReadOnlyList<Union<Humidifier.Evidently.LaunchTypes.GroupToWeight, BaseFunction>>, BaseFunction>? GroupWeights { get; set; }
            /// <summary>
            /// SegmentOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-stepconfig.html#cfn-evidently-launch-stepconfig-segmentoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SegmentOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Evidently.LaunchTypes.SegmentOverride>, IReadOnlyList<Union<Humidifier.Evidently.LaunchTypes.SegmentOverride, BaseFunction>>, BaseFunction>? SegmentOverrides { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-launch-stepconfig.html#cfn-evidently-launch-stepconfig-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }
    }
}