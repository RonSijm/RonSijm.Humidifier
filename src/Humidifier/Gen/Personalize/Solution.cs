namespace Humidifier.Personalize
{
    using System.Collections.Generic;
    using SolutionTypes;

    public class Solution : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveEventType, IHaveDatasetGroupArn
    {
        public class Attributes
        {
            public static string SolutionArn =  "SolutionArn" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.Solution; }
        /// <summary>
        /// PerformAutoML
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-performautoml
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PerformAutoML { get; set; }
        /// <summary>
        /// PerformHPO
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-performhpo
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PerformHPO { get; set; }
        /// <summary>
        /// EventType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-eventtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EventType { get; set; }

        /// <summary>
        /// DatasetGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-datasetgrouparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DatasetGroupArn { get; set; }
        /// <summary>
        /// SolutionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-solutionconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SolutionConfig
        /// </summary>
        public Humidifier.Personalize.SolutionTypes.SolutionConfig SolutionConfig { get; set; }
        /// <summary>
        /// RecipeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-recipearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RecipeArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace SolutionTypes
    {
        public class AlgorithmHyperParameterRanges : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IntegerHyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-algorithmhyperparameterranges.html#cfn-personalize-solution-algorithmhyperparameterranges-integerhyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: IntegerHyperParameterRange
            /// </summary>
            public List<Humidifier.Personalize.SolutionTypes.IntegerHyperParameterRange> IntegerHyperParameterRanges { get; set; }
            /// <summary>
            /// CategoricalHyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-algorithmhyperparameterranges.html#cfn-personalize-solution-algorithmhyperparameterranges-categoricalhyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CategoricalHyperParameterRange
            /// </summary>
            public List<Humidifier.Personalize.SolutionTypes.CategoricalHyperParameterRange> CategoricalHyperParameterRanges { get; set; }
            /// <summary>
            /// ContinuousHyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-algorithmhyperparameterranges.html#cfn-personalize-solution-algorithmhyperparameterranges-continuoushyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ContinuousHyperParameterRange
            /// </summary>
            public List<Humidifier.Personalize.SolutionTypes.ContinuousHyperParameterRange> ContinuousHyperParameterRanges { get; set; }
        }

        public class AutoMLConfig : Humidifier.Base.BaseSubResource, IHaveMetricName
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-automlconfig.html#cfn-personalize-solution-automlconfig-metricname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// RecipeList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-automlconfig.html#cfn-personalize-solution-automlconfig-recipelist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RecipeList { get; set; }
        }

        public class CategoricalHyperParameterRange : Humidifier.Base.BaseSubResource, IHaveName, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-categoricalhyperparameterrange.html#cfn-personalize-solution-categoricalhyperparameterrange-values
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-categoricalhyperparameterrange.html#cfn-personalize-solution-categoricalhyperparameterrange-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ContinuousHyperParameterRange : Humidifier.Base.BaseSubResource, IHaveName, IHaveMaxValue, IHaveMinValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-continuoushyperparameterrange.html#cfn-personalize-solution-continuoushyperparameterrange-minvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-continuoushyperparameterrange.html#cfn-personalize-solution-continuoushyperparameterrange-maxvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-continuoushyperparameterrange.html#cfn-personalize-solution-continuoushyperparameterrange-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HpoConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HpoResourceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoconfig.html#cfn-personalize-solution-hpoconfig-hporesourceconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HpoResourceConfig
            /// </summary>
            public Humidifier.Personalize.SolutionTypes.HpoResourceConfig HpoResourceConfig { get; set; }
            /// <summary>
            /// AlgorithmHyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoconfig.html#cfn-personalize-solution-hpoconfig-algorithmhyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AlgorithmHyperParameterRanges
            /// </summary>
            public Humidifier.Personalize.SolutionTypes.AlgorithmHyperParameterRanges AlgorithmHyperParameterRanges { get; set; }
            /// <summary>
            /// HpoObjective
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoconfig.html#cfn-personalize-solution-hpoconfig-hpoobjective
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HpoObjective
            /// </summary>
            public Humidifier.Personalize.SolutionTypes.HpoObjective HpoObjective { get; set; }
        }

        public class HpoObjective : Humidifier.Base.BaseSubResource, IHaveType, IHaveMetricName
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoobjective.html#cfn-personalize-solution-hpoobjective-metricname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoobjective.html#cfn-personalize-solution-hpoobjective-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// MetricRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoobjective.html#cfn-personalize-solution-hpoobjective-metricregex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricRegex { get; set; }
        }

        public class HpoResourceConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxParallelTrainingJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hporesourceconfig.html#cfn-personalize-solution-hporesourceconfig-maxparalleltrainingjobs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxParallelTrainingJobs { get; set; }
            /// <summary>
            /// MaxNumberOfTrainingJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hporesourceconfig.html#cfn-personalize-solution-hporesourceconfig-maxnumberoftrainingjobs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxNumberOfTrainingJobs { get; set; }
        }

        public class IntegerHyperParameterRange : Humidifier.Base.BaseSubResource, IHaveName, IHaveMaxValue, IHaveMinValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-integerhyperparameterrange.html#cfn-personalize-solution-integerhyperparameterrange-minvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-integerhyperparameterrange.html#cfn-personalize-solution-integerhyperparameterrange-maxvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-integerhyperparameterrange.html#cfn-personalize-solution-integerhyperparameterrange-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SolutionConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EventValueThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-eventvaluethreshold
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventValueThreshold { get; set; }
            /// <summary>
            /// HpoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-hpoconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HpoConfig
            /// </summary>
            public Humidifier.Personalize.SolutionTypes.HpoConfig HpoConfig { get; set; }
            /// <summary>
            /// AlgorithmHyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-algorithmhyperparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> AlgorithmHyperParameters { get; set; }
            /// <summary>
            /// FeatureTransformationParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-featuretransformationparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> FeatureTransformationParameters { get; set; }
            /// <summary>
            /// AutoMLConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-automlconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLConfig
            /// </summary>
            public Humidifier.Personalize.SolutionTypes.AutoMLConfig AutoMLConfig { get; set; }
        }
    }
}