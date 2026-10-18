namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using SolutionTypes;

    public class Solution : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePerformAutoML_Boolean, IHavePerformHPO_Boolean, IHaveEventType, IHaveDatasetGroupArn, IHavePersonalizeSolutionTypesSolutionConfigSolutionConfig, IHaveRecipeArn, IHaveName
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
        public Union<bool, BaseFunction>? PerformAutoML { get; set; }
        /// <summary>
        /// PerformHPO
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-performhpo
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PerformHPO { get; set; }
        /// <summary>
        /// EventType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-eventtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EventType { get; set; }

        /// <summary>
        /// DatasetGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-datasetgrouparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatasetGroupArn { get; set; }
        /// <summary>
        /// SolutionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-solutionconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SolutionConfig
        /// </summary>
        public Union<Humidifier.Personalize.SolutionTypes.SolutionConfig, BaseFunction>? SolutionConfig { get; set; }
        /// <summary>
        /// RecipeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-recipearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RecipeArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-solution.html#cfn-personalize-solution-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SolutionTypes
    {
        public class AlgorithmHyperParameterRanges : Humidifier.Base.BaseSubResource, IHaveListOfPersonalizeSolutionTypesIntegerHyperParameterRangeIntegerHyperParameterRanges, IHaveListOfPersonalizeSolutionTypesCategoricalHyperParameterRangeCategoricalHyperParameterRanges, IHaveListOfPersonalizeSolutionTypesContinuousHyperParameterRangeContinuousHyperParameterRanges
        {
            /// <summary>
            /// IntegerHyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-algorithmhyperparameterranges.html#cfn-personalize-solution-algorithmhyperparameterranges-integerhyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: IntegerHyperParameterRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Personalize.SolutionTypes.IntegerHyperParameterRange>, IReadOnlyList<Union<Humidifier.Personalize.SolutionTypes.IntegerHyperParameterRange, BaseFunction>>, BaseFunction>? IntegerHyperParameterRanges { get; set; }
            /// <summary>
            /// CategoricalHyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-algorithmhyperparameterranges.html#cfn-personalize-solution-algorithmhyperparameterranges-categoricalhyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: CategoricalHyperParameterRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Personalize.SolutionTypes.CategoricalHyperParameterRange>, IReadOnlyList<Union<Humidifier.Personalize.SolutionTypes.CategoricalHyperParameterRange, BaseFunction>>, BaseFunction>? CategoricalHyperParameterRanges { get; set; }
            /// <summary>
            /// ContinuousHyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-algorithmhyperparameterranges.html#cfn-personalize-solution-algorithmhyperparameterranges-continuoushyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ContinuousHyperParameterRange
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Personalize.SolutionTypes.ContinuousHyperParameterRange>, IReadOnlyList<Union<Humidifier.Personalize.SolutionTypes.ContinuousHyperParameterRange, BaseFunction>>, BaseFunction>? ContinuousHyperParameterRanges { get; set; }
        }

        public class AutoMLConfig : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveStringListOfRecipeList
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-automlconfig.html#cfn-personalize-solution-automlconfig-metricname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// RecipeList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-automlconfig.html#cfn-personalize-solution-automlconfig-recipelist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RecipeList { get; set; }
        }

        public class CategoricalHyperParameterRange : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-categoricalhyperparameterrange.html#cfn-personalize-solution-categoricalhyperparameterrange-values
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-categoricalhyperparameterrange.html#cfn-personalize-solution-categoricalhyperparameterrange-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ContinuousHyperParameterRange : Humidifier.Base.BaseSubResource, IHaveMinValue_Double, IHaveMaxValue_Double, IHaveName
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-continuoushyperparameterrange.html#cfn-personalize-solution-continuoushyperparameterrange-minvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-continuoushyperparameterrange.html#cfn-personalize-solution-continuoushyperparameterrange-maxvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-continuoushyperparameterrange.html#cfn-personalize-solution-continuoushyperparameterrange-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class HpoConfig : Humidifier.Base.BaseSubResource, IHavePersonalizeSolutionTypesHpoResourceConfigHpoResourceConfig, IHavePersonalizeSolutionTypesAlgorithmHyperParameterRangesAlgorithmHyperParameterRanges, IHavePersonalizeSolutionTypesHpoObjectiveHpoObjective
        {
            /// <summary>
            /// HpoResourceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoconfig.html#cfn-personalize-solution-hpoconfig-hporesourceconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HpoResourceConfig
            /// </summary>
            public Union<Humidifier.Personalize.SolutionTypes.HpoResourceConfig, BaseFunction>? HpoResourceConfig { get; set; }
            /// <summary>
            /// AlgorithmHyperParameterRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoconfig.html#cfn-personalize-solution-hpoconfig-algorithmhyperparameterranges
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AlgorithmHyperParameterRanges
            /// </summary>
            public Union<Humidifier.Personalize.SolutionTypes.AlgorithmHyperParameterRanges, BaseFunction>? AlgorithmHyperParameterRanges { get; set; }
            /// <summary>
            /// HpoObjective
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoconfig.html#cfn-personalize-solution-hpoconfig-hpoobjective
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HpoObjective
            /// </summary>
            public Union<Humidifier.Personalize.SolutionTypes.HpoObjective, BaseFunction>? HpoObjective { get; set; }
        }

        public class HpoObjective : Humidifier.Base.BaseSubResource, IHaveMetricName, IHaveType, IHaveMetricRegex
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoobjective.html#cfn-personalize-solution-hpoobjective-metricname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoobjective.html#cfn-personalize-solution-hpoobjective-type
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// MetricRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hpoobjective.html#cfn-personalize-solution-hpoobjective-metricregex
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricRegex { get; set; }
        }

        public class HpoResourceConfig : Humidifier.Base.BaseSubResource, IHaveMaxParallelTrainingJobs, IHaveMaxNumberOfTrainingJobs
        {
            /// <summary>
            /// MaxParallelTrainingJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hporesourceconfig.html#cfn-personalize-solution-hporesourceconfig-maxparalleltrainingjobs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxParallelTrainingJobs { get; set; }
            /// <summary>
            /// MaxNumberOfTrainingJobs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-hporesourceconfig.html#cfn-personalize-solution-hporesourceconfig-maxnumberoftrainingjobs
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxNumberOfTrainingJobs { get; set; }
        }

        public class IntegerHyperParameterRange : Humidifier.Base.BaseSubResource, IHaveMinValue_Integer, IHaveMaxValue_Integer, IHaveName
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-integerhyperparameterrange.html#cfn-personalize-solution-integerhyperparameterrange-minvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-integerhyperparameterrange.html#cfn-personalize-solution-integerhyperparameterrange-maxvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxValue { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-integerhyperparameterrange.html#cfn-personalize-solution-integerhyperparameterrange-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SolutionConfig : Humidifier.Base.BaseSubResource, IHaveEventValueThreshold, IHavePersonalizeSolutionTypesHpoConfigHpoConfig, IHaveStringDictionaryOfAlgorithmHyperParameters, IHaveStringDictionaryOfFeatureTransformationParameters, IHavePersonalizeSolutionTypesAutoMLConfigAutoMLConfig
        {
            /// <summary>
            /// EventValueThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-eventvaluethreshold
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventValueThreshold { get; set; }
            /// <summary>
            /// HpoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-hpoconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HpoConfig
            /// </summary>
            public Union<Humidifier.Personalize.SolutionTypes.HpoConfig, BaseFunction>? HpoConfig { get; set; }
            /// <summary>
            /// AlgorithmHyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-algorithmhyperparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AlgorithmHyperParameters { get; set; }
            /// <summary>
            /// FeatureTransformationParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-featuretransformationparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? FeatureTransformationParameters { get; set; }
            /// <summary>
            /// AutoMLConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-solution-solutionconfig.html#cfn-personalize-solution-solutionconfig-automlconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AutoMLConfig
            /// </summary>
            public Union<Humidifier.Personalize.SolutionTypes.AutoMLConfig, BaseFunction>? AutoMLConfig { get; set; }
        }
    }
}