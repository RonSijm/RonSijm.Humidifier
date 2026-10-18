namespace Humidifier.Evidently
{
    using global::System.Collections.Generic;
    using ExperimentTypes;

    public class Experiment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveProject, IHaveEvidentlyExperimentTypesRunningStatusObjectRunningStatus, IHaveDescription, IHaveListOfEvidentlyExperimentTypesMetricGoalObjectMetricGoals, IHaveEvidentlyExperimentTypesOnlineAbConfigObjectOnlineAbConfig, IHaveRemoveSegment_Boolean, IHaveRandomizationSalt, IHaveListOfEvidentlyExperimentTypesTreatmentObjectTreatments, IHaveSamplingRate_Integer, IHaveSegment, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Evidently.Experiment; }

        /// <summary>
        /// Project
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-project
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Project { get; set; }
        /// <summary>
        /// RunningStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-runningstatus
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RunningStatusObject
        /// </summary>
        public Union<Humidifier.Evidently.ExperimentTypes.RunningStatusObject, BaseFunction>? RunningStatus { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// MetricGoals
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-metricgoals
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricGoalObject
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Evidently.ExperimentTypes.MetricGoalObject>, IReadOnlyList<Union<Humidifier.Evidently.ExperimentTypes.MetricGoalObject, BaseFunction>>, BaseFunction>? MetricGoals { get; set; }

        /// <summary>
        /// OnlineAbConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-onlineabconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: OnlineAbConfigObject
        /// </summary>
        [Required]
        public Union<Humidifier.Evidently.ExperimentTypes.OnlineAbConfigObject, BaseFunction>? OnlineAbConfig { get; set; }
        /// <summary>
        /// RemoveSegment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-removesegment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RemoveSegment { get; set; }
        /// <summary>
        /// RandomizationSalt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-randomizationsalt
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RandomizationSalt { get; set; }

        /// <summary>
        /// Treatments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-treatments
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TreatmentObject
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Evidently.ExperimentTypes.TreatmentObject>, IReadOnlyList<Union<Humidifier.Evidently.ExperimentTypes.TreatmentObject, BaseFunction>>, BaseFunction>? Treatments { get; set; }
        /// <summary>
        /// SamplingRate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-samplingrate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SamplingRate { get; set; }
        /// <summary>
        /// Segment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-segment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Segment { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-evidently-experiment.html#cfn-evidently-experiment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ExperimentTypes
    {
        public class MetricGoalObject : Humidifier.Base.BaseSubResource, IHaveEntityIdKey, IHaveDesiredChange, IHaveMetricName, IHaveEventPattern, IHaveValueKey, IHaveUnitLabel
        {
            /// <summary>
            /// EntityIdKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-metricgoalobject.html#cfn-evidently-experiment-metricgoalobject-entityidkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntityIdKey { get; set; }
            /// <summary>
            /// DesiredChange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-metricgoalobject.html#cfn-evidently-experiment-metricgoalobject-desiredchange
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DesiredChange { get; set; }
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-metricgoalobject.html#cfn-evidently-experiment-metricgoalobject-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// EventPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-metricgoalobject.html#cfn-evidently-experiment-metricgoalobject-eventpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventPattern { get; set; }
            /// <summary>
            /// ValueKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-metricgoalobject.html#cfn-evidently-experiment-metricgoalobject-valuekey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueKey { get; set; }
            /// <summary>
            /// UnitLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-metricgoalobject.html#cfn-evidently-experiment-metricgoalobject-unitlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UnitLabel { get; set; }
        }

        public class OnlineAbConfigObject : Humidifier.Base.BaseSubResource, IHaveListOfEvidentlyExperimentTypesTreatmentToWeightTreatmentWeights, IHaveControlTreatmentName
        {
            /// <summary>
            /// TreatmentWeights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-onlineabconfigobject.html#cfn-evidently-experiment-onlineabconfigobject-treatmentweights
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TreatmentToWeight
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Evidently.ExperimentTypes.TreatmentToWeight>, IReadOnlyList<Union<Humidifier.Evidently.ExperimentTypes.TreatmentToWeight, BaseFunction>>, BaseFunction>? TreatmentWeights { get; set; }
            /// <summary>
            /// ControlTreatmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-onlineabconfigobject.html#cfn-evidently-experiment-onlineabconfigobject-controltreatmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ControlTreatmentName { get; set; }
        }

        public class RunningStatusObject : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveDesiredState, IHaveAnalysisCompleteTime, IHaveReason
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-runningstatusobject.html#cfn-evidently-experiment-runningstatusobject-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// DesiredState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-runningstatusobject.html#cfn-evidently-experiment-runningstatusobject-desiredstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DesiredState { get; set; }
            /// <summary>
            /// AnalysisCompleteTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-runningstatusobject.html#cfn-evidently-experiment-runningstatusobject-analysiscompletetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnalysisCompleteTime { get; set; }
            /// <summary>
            /// Reason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-runningstatusobject.html#cfn-evidently-experiment-runningstatusobject-reason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Reason { get; set; }
        }

        public class TreatmentObject : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveVariation, IHaveFeature, IHaveTreatmentName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-treatmentobject.html#cfn-evidently-experiment-treatmentobject-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Variation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-treatmentobject.html#cfn-evidently-experiment-treatmentobject-variation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Variation { get; set; }
            /// <summary>
            /// Feature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-treatmentobject.html#cfn-evidently-experiment-treatmentobject-feature
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Feature { get; set; }
            /// <summary>
            /// TreatmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-treatmentobject.html#cfn-evidently-experiment-treatmentobject-treatmentname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TreatmentName { get; set; }
        }

        public class TreatmentToWeight : Humidifier.Base.BaseSubResource, IHaveTreatment, IHaveSplitWeight_Integer
        {
            /// <summary>
            /// Treatment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-treatmenttoweight.html#cfn-evidently-experiment-treatmenttoweight-treatment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Treatment { get; set; }
            /// <summary>
            /// SplitWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-evidently-experiment-treatmenttoweight.html#cfn-evidently-experiment-treatmenttoweight-splitweight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SplitWeight { get; set; }
        }
    }
}