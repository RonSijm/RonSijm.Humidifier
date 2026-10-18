namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AIRecommendationJobTypes;

    public class AIRecommendationJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerAIRecommendationJobTypesAIRecommendationOutputConfigOutputConfig, IHaveOptimizeModel_Boolean, IHaveSageMakerAIRecommendationJobTypesAIRecommendationInferenceSpecificationInferenceSpecification, IHaveAIWorkloadConfigIdentifier, IHaveAIRecommendationJobName, IHaveSageMakerAIRecommendationJobTypesAIRecommendationPerformanceTargetPerformanceTarget, IHaveSageMakerAIRecommendationJobTypesAIRecommendationComputeSpecComputeSpec, IHaveSageMakerAIRecommendationJobTypesAIModelSourceModelSource, IHaveRoleArn
    {
        public class Attributes
        {
            public static string EndTime =  "EndTime" ;
            public static string AIRecommendationJobStatus =  "AIRecommendationJobStatus" ;
            public static string StartTime =  "StartTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string AIRecommendationJobArn =  "AIRecommendationJobArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.AIRecommendationJob; }

        /// <summary>
        /// OutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-outputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AIRecommendationOutputConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationOutputConfig, BaseFunction>? OutputConfig { get; set; }
        /// <summary>
        /// OptimizeModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-optimizemodel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? OptimizeModel { get; set; }
        /// <summary>
        /// InferenceSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-inferencespecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AIRecommendationInferenceSpecification
        /// </summary>
        public Union<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationInferenceSpecification, BaseFunction>? InferenceSpecification { get; set; }

        /// <summary>
        /// AIWorkloadConfigIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-aiworkloadconfigidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AIWorkloadConfigIdentifier { get; set; }
        public Union<string, BaseFunction>? AIRecommendationJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// PerformanceTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-performancetarget
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AIRecommendationPerformanceTarget
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationPerformanceTarget, BaseFunction>? PerformanceTarget { get; set; }
        /// <summary>
        /// ComputeSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-computespec
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AIRecommendationComputeSpec
        /// </summary>
        public Union<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationComputeSpec, BaseFunction>? ComputeSpec { get; set; }

        /// <summary>
        /// ModelSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-modelsource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AIModelSource
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSource, BaseFunction>? ModelSource { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AIRecommendationJobTypes
    {
        public class AICapacityReservationConfig : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference, IHaveStringListOfMlReservationArns
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-aicapacityreservationconfig.html#cfn-sagemaker-airecommendationjob-aicapacityreservationconfig-capacityreservationpreference
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
            /// <summary>
            /// MlReservationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-aicapacityreservationconfig.html#cfn-sagemaker-airecommendationjob-aicapacityreservationconfig-mlreservationarns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MlReservationArns { get; set; }
        }

        public class AIModelSource : Humidifier.Base.BaseSubResource, IHaveSageMakerAIRecommendationJobTypesAIModelSourceS3S3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-aimodelsource.html#cfn-sagemaker-airecommendationjob-aimodelsource-s3
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AIModelSourceS3
            /// </summary>
            public Union<Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3, BaseFunction>? S3 { get; set; }
        }

        public class AIModelSourceS3 : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-aimodelsources3.html#cfn-sagemaker-airecommendationjob-aimodelsources3-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class AIRecommendationComputeSpec : Humidifier.Base.BaseSubResource, IHaveSageMakerAIRecommendationJobTypesAICapacityReservationConfigCapacityReservationConfig, IHaveStringListOfInstanceTypes
        {
            /// <summary>
            /// CapacityReservationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationcomputespec.html#cfn-sagemaker-airecommendationjob-airecommendationcomputespec-capacityreservationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AICapacityReservationConfig
            /// </summary>
            public Union<Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig, BaseFunction>? CapacityReservationConfig { get; set; }
            /// <summary>
            /// InstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationcomputespec.html#cfn-sagemaker-airecommendationjob-airecommendationcomputespec-instancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceTypes { get; set; }
        }

        public class AIRecommendationConstraint : Humidifier.Base.BaseSubResource, IHaveMetric
        {
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationconstraint.html#cfn-sagemaker-airecommendationjob-airecommendationconstraint-metric
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Metric { get; set; }
        }

        public class AIRecommendationInferenceSpecification : Humidifier.Base.BaseSubResource, IHaveFramework
        {
            /// <summary>
            /// Framework
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationinferencespecification.html#cfn-sagemaker-airecommendationjob-airecommendationinferencespecification-framework
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Framework { get; set; }
        }

        public class AIRecommendationOutputConfig : Humidifier.Base.BaseSubResource, IHaveS3OutputLocation, IHaveModelPackageGroupIdentifier
        {
            /// <summary>
            /// S3OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationoutputconfig.html#cfn-sagemaker-airecommendationjob-airecommendationoutputconfig-s3outputlocation
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputLocation { get; set; }
            /// <summary>
            /// ModelPackageGroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationoutputconfig.html#cfn-sagemaker-airecommendationjob-airecommendationoutputconfig-modelpackagegroupidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelPackageGroupIdentifier { get; set; }
        }

        public class AIRecommendationPerformanceTarget : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerAIRecommendationJobTypesAIRecommendationConstraintConstraints
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationperformancetarget.html#cfn-sagemaker-airecommendationjob-airecommendationperformancetarget-constraints
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AIRecommendationConstraint
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationConstraint>, IReadOnlyList<Union<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationConstraint, BaseFunction>>, BaseFunction>? Constraints { get; set; }
        }
    }
}