namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AlgorithmTypes;

    public class Algorithm : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAlgorithmName, IHaveDescription
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string AlgorithmArn =  "AlgorithmArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Algorithm; }
        /// <summary>
        /// InferenceSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-inferencespecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceSpecification
        /// </summary>
        public Humidifier.SageMaker.AlgorithmTypes.InferenceSpecification InferenceSpecification { get; set; }
        /// <summary>
        /// AlgorithmDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-algorithmdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AlgorithmDescription { get; set; }

        [Ignore]
        public dynamic Description { get => AlgorithmDescription; set => AlgorithmDescription = value; }

        /// <summary>
        /// TrainingSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-trainingspecification
        /// Required: True
        /// UpdateType: Immutable
        /// Type: TrainingSpecification
        /// </summary>
        [Required]
        public Humidifier.SageMaker.AlgorithmTypes.TrainingSpecification TrainingSpecification { get; set; }
        public dynamic AlgorithmName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// CertifyForMarketplace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-algorithm.html#cfn-sagemaker-algorithm-certifyformarketplace
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CertifyForMarketplace { get; set; }
    }

    namespace AlgorithmTypes
    {
        public class CategoricalParameterRangeSpecification : Humidifier.Base.BaseSubResource, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-categoricalparameterrangespecification.html#cfn-sagemaker-algorithm-categoricalparameterrangespecification-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class ChannelSpecification : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveSupportedContentTypes
        {
            /// <summary>
            /// SupportedInputModes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-supportedinputmodes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedInputModes { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// IsRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-isrequired
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsRequired { get; set; }
            /// <summary>
            /// SupportedContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-supportedcontenttypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedContentTypes { get; set; }
            /// <summary>
            /// SupportedCompressionTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-supportedcompressiontypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedCompressionTypes { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-channelspecification.html#cfn-sagemaker-algorithm-channelspecification-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ContinuousParameterRangeSpecification : Humidifier.Base.BaseSubResource, IHaveMaxValue, IHaveMinValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-continuousparameterrangespecification.html#cfn-sagemaker-algorithm-continuousparameterrangespecification-minvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-continuousparameterrangespecification.html#cfn-sagemaker-algorithm-continuousparameterrangespecification-maxvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxValue { get; set; }
        }

        public class HyperParameterSpecification : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveType, IHaveDefaultValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// IsRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-isrequired
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsRequired { get; set; }
            /// <summary>
            /// IsTunable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-istunable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsTunable { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-range
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParameterRange
            /// </summary>
            public Humidifier.SageMaker.AlgorithmTypes.ParameterRange Range { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparameterspecification.html#cfn-sagemaker-algorithm-hyperparameterspecification-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class HyperParameterTuningJobObjective : Humidifier.Base.BaseSubResource, IHaveType, IHaveMetricName
        {
            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparametertuningjobobjective.html#cfn-sagemaker-algorithm-hyperparametertuningjobobjective-metricname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-hyperparametertuningjobobjective.html#cfn-sagemaker-algorithm-hyperparametertuningjobobjective-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class InferenceSpecification : Humidifier.Base.BaseSubResource, IHaveSupportedContentTypes, IHaveSupportedRealtimeInferenceInstanceTypes, IHaveSupportedTransformInstanceTypes, IHaveSupportedResponseMIMETypes
        {
            /// <summary>
            /// SupportedContentTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-supportedcontenttypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedContentTypes { get; set; }
            /// <summary>
            /// SupportedRealtimeInferenceInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-supportedrealtimeinferenceinstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedRealtimeInferenceInstanceTypes { get; set; }
            /// <summary>
            /// Containers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-containers
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ModelPackageContainerDefinition
            /// </summary>
            public List<Humidifier.SageMaker.AlgorithmTypes.ModelPackageContainerDefinition> Containers { get; set; }
            /// <summary>
            /// SupportedTransformInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-supportedtransforminstancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedTransformInstanceTypes { get; set; }
            /// <summary>
            /// SupportedResponseMIMETypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-inferencespecification.html#cfn-sagemaker-algorithm-inferencespecification-supportedresponsemimetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedResponseMIMETypes { get; set; }
        }

        public class IntegerParameterRangeSpecification : Humidifier.Base.BaseSubResource, IHaveMaxValue, IHaveMinValue
        {
            /// <summary>
            /// MinValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-integerparameterrangespecification.html#cfn-sagemaker-algorithm-integerparameterrangespecification-minvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinValue { get; set; }
            /// <summary>
            /// MaxValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-integerparameterrangespecification.html#cfn-sagemaker-algorithm-integerparameterrangespecification-maxvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxValue { get; set; }
        }

        public class MetricDefinition : Humidifier.Base.BaseSubResource, IHaveName, IHaveRegex
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-metricdefinition.html#cfn-sagemaker-algorithm-metricdefinition-regex
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-metricdefinition.html#cfn-sagemaker-algorithm-metricdefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ModelInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataInputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelinput.html#cfn-sagemaker-algorithm-modelinput-datainputconfig
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataInputConfig { get; set; }
        }

        public class ModelPackageContainerDefinition : Humidifier.Base.BaseSubResource, IHaveImage, IHaveFramework, IHaveFrameworkVersion, IHaveContainerHostname, IHaveNearestModelName
        {
            /// <summary>
            /// ModelInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-modelinput
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelInput
            /// </summary>
            public Humidifier.SageMaker.AlgorithmTypes.ModelInput ModelInput { get; set; }
            /// <summary>
            /// NearestModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-nearestmodelname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NearestModelName { get; set; }
            /// <summary>
            /// ContainerHostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-containerhostname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerHostname { get; set; }
            /// <summary>
            /// ImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-imagedigest
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageDigest { get; set; }
            /// <summary>
            /// FrameworkVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-frameworkversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FrameworkVersion { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Environment { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-image
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// IsCheckpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-ischeckpoint
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsCheckpoint { get; set; }
            /// <summary>
            /// Framework
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-modelpackagecontainerdefinition.html#cfn-sagemaker-algorithm-modelpackagecontainerdefinition-framework
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Framework { get; set; }
        }

        public class ParameterRange : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IntegerParameterRangeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-parameterrange.html#cfn-sagemaker-algorithm-parameterrange-integerparameterrangespecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IntegerParameterRangeSpecification
            /// </summary>
            public Humidifier.SageMaker.AlgorithmTypes.IntegerParameterRangeSpecification IntegerParameterRangeSpecification { get; set; }
            /// <summary>
            /// CategoricalParameterRangeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-parameterrange.html#cfn-sagemaker-algorithm-parameterrange-categoricalparameterrangespecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CategoricalParameterRangeSpecification
            /// </summary>
            public Humidifier.SageMaker.AlgorithmTypes.CategoricalParameterRangeSpecification CategoricalParameterRangeSpecification { get; set; }
            /// <summary>
            /// ContinuousParameterRangeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-parameterrange.html#cfn-sagemaker-algorithm-parameterrange-continuousparameterrangespecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ContinuousParameterRangeSpecification
            /// </summary>
            public Humidifier.SageMaker.AlgorithmTypes.ContinuousParameterRangeSpecification ContinuousParameterRangeSpecification { get; set; }
        }

        public class TrainingSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SupportedTrainingInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-supportedtraininginstancetypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SupportedTrainingInstanceTypes { get; set; }
            /// <summary>
            /// TrainingImageDigest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-trainingimagedigest
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrainingImageDigest { get; set; }
            /// <summary>
            /// SupportedHyperParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-supportedhyperparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HyperParameterSpecification
            /// </summary>
            public List<Humidifier.SageMaker.AlgorithmTypes.HyperParameterSpecification> SupportedHyperParameters { get; set; }
            /// <summary>
            /// SupportsDistributedTraining
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-supportsdistributedtraining
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SupportsDistributedTraining { get; set; }
            /// <summary>
            /// MetricDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-metricdefinitions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: MetricDefinition
            /// </summary>
            public List<Humidifier.SageMaker.AlgorithmTypes.MetricDefinition> MetricDefinitions { get; set; }
            /// <summary>
            /// TrainingChannels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-trainingchannels
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ChannelSpecification
            /// </summary>
            public List<Humidifier.SageMaker.AlgorithmTypes.ChannelSpecification> TrainingChannels { get; set; }
            /// <summary>
            /// TrainingImage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-trainingimage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrainingImage { get; set; }
            /// <summary>
            /// SupportedTuningJobObjectiveMetrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-algorithm-trainingspecification.html#cfn-sagemaker-algorithm-trainingspecification-supportedtuningjobobjectivemetrics
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HyperParameterTuningJobObjective
            /// </summary>
            public List<Humidifier.SageMaker.AlgorithmTypes.HyperParameterTuningJobObjective> SupportedTuningJobObjectiveMetrics { get; set; }
        }
    }
}