namespace Humidifier.APS
{
    using global::System.Collections.Generic;
    using AnomalyDetectorTypes;

    public class AnomalyDetector : Humidifier.Base.BaseResource, IHaveTags, IHaveAPSAnomalyDetectorTypesAnomalyDetectorConfigurationConfiguration, IHaveAlias, IHaveAPSAnomalyDetectorTypesMissingDataActionMissingDataAction, IHaveListOfAPSAnomalyDetectorTypesLabelLabels, IHaveEvaluationIntervalInSeconds_Integer, IHaveWorkspace
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.APS.AnomalyDetector; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-anomalydetector.html#cfn-aps-anomalydetector-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AnomalyDetectorConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.APS.AnomalyDetectorTypes.AnomalyDetectorConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-anomalydetector.html#cfn-aps-anomalydetector-alias
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Alias { get; set; }
        /// <summary>
        /// MissingDataAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-anomalydetector.html#cfn-aps-anomalydetector-missingdataaction
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MissingDataAction
        /// </summary>
        public Union<Humidifier.APS.AnomalyDetectorTypes.MissingDataAction, BaseFunction>? MissingDataAction { get; set; }
        /// <summary>
        /// Labels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-anomalydetector.html#cfn-aps-anomalydetector-labels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Label
        /// </summary>
        public Union<IReadOnlyList<Humidifier.APS.AnomalyDetectorTypes.Label>, IReadOnlyList<Union<Humidifier.APS.AnomalyDetectorTypes.Label, BaseFunction>>, BaseFunction>? Labels { get; set; }
        /// <summary>
        /// EvaluationIntervalInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-anomalydetector.html#cfn-aps-anomalydetector-evaluationintervalinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? EvaluationIntervalInSeconds { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-anomalydetector.html#cfn-aps-anomalydetector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Workspace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-anomalydetector.html#cfn-aps-anomalydetector-workspace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Workspace { get; set; }
    }

    namespace AnomalyDetectorTypes
    {
        public class AnomalyDetectorConfiguration : Humidifier.Base.BaseSubResource, IHaveAPSAnomalyDetectorTypesRandomCutForestConfigurationRandomCutForest
        {
            /// <summary>
            /// RandomCutForest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-anomalydetectorconfiguration.html#cfn-aps-anomalydetector-anomalydetectorconfiguration-randomcutforest
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RandomCutForestConfiguration
            /// </summary>
            public Union<Humidifier.APS.AnomalyDetectorTypes.RandomCutForestConfiguration, BaseFunction>? RandomCutForest { get; set; }
        }

        public class IgnoreNearExpected : Humidifier.Base.BaseSubResource, IHaveRatio_Double, IHaveAmount_Double
        {
            /// <summary>
            /// Ratio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-ignorenearexpected.html#cfn-aps-anomalydetector-ignorenearexpected-ratio
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Ratio { get; set; }
            /// <summary>
            /// Amount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-ignorenearexpected.html#cfn-aps-anomalydetector-ignorenearexpected-amount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Amount { get; set; }
        }

        public class Label : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-label.html#cfn-aps-anomalydetector-label-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-label.html#cfn-aps-anomalydetector-label-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class MissingDataAction : Humidifier.Base.BaseSubResource, IHaveMarkAsAnomaly_Boolean, IHaveSkip_Boolean
        {
            /// <summary>
            /// MarkAsAnomaly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-missingdataaction.html#cfn-aps-anomalydetector-missingdataaction-markasanomaly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MarkAsAnomaly { get; set; }
            /// <summary>
            /// Skip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-missingdataaction.html#cfn-aps-anomalydetector-missingdataaction-skip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Skip { get; set; }
        }

        public class RandomCutForestConfiguration : Humidifier.Base.BaseSubResource, IHaveSampleSize_Integer, IHaveQuery, IHaveShingleSize_Integer, IHaveAPSAnomalyDetectorTypesIgnoreNearExpectedIgnoreNearExpectedFromBelow, IHaveAPSAnomalyDetectorTypesIgnoreNearExpectedIgnoreNearExpectedFromAbove
        {
            /// <summary>
            /// SampleSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-randomcutforestconfiguration.html#cfn-aps-anomalydetector-randomcutforestconfiguration-samplesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SampleSize { get; set; }
            /// <summary>
            /// Query
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-randomcutforestconfiguration.html#cfn-aps-anomalydetector-randomcutforestconfiguration-query
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Query { get; set; }
            /// <summary>
            /// ShingleSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-randomcutforestconfiguration.html#cfn-aps-anomalydetector-randomcutforestconfiguration-shinglesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ShingleSize { get; set; }
            /// <summary>
            /// IgnoreNearExpectedFromBelow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-randomcutforestconfiguration.html#cfn-aps-anomalydetector-randomcutforestconfiguration-ignorenearexpectedfrombelow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IgnoreNearExpected
            /// </summary>
            public Union<Humidifier.APS.AnomalyDetectorTypes.IgnoreNearExpected, BaseFunction>? IgnoreNearExpectedFromBelow { get; set; }
            /// <summary>
            /// IgnoreNearExpectedFromAbove
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-anomalydetector-randomcutforestconfiguration.html#cfn-aps-anomalydetector-randomcutforestconfiguration-ignorenearexpectedfromabove
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IgnoreNearExpected
            /// </summary>
            public Union<Humidifier.APS.AnomalyDetectorTypes.IgnoreNearExpected, BaseFunction>? IgnoreNearExpectedFromAbove { get; set; }
        }
    }
}