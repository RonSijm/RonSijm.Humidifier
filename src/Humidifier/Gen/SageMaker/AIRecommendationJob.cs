namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AIRecommendationJobTypes;

    public class AIRecommendationJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoleArn
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
        public Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationOutputConfig OutputConfig { get; set; }
        /// <summary>
        /// OptimizeModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-optimizemodel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic OptimizeModel { get; set; }
        /// <summary>
        /// InferenceSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-inferencespecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AIRecommendationInferenceSpecification
        /// </summary>
        public Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationInferenceSpecification InferenceSpecification { get; set; }

        /// <summary>
        /// AIWorkloadConfigIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-aiworkloadconfigidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AIWorkloadConfigIdentifier { get; set; }
        public dynamic AIRecommendationJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// PerformanceTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-performancetarget
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AIRecommendationPerformanceTarget
        /// </summary>
        [Required]
        public Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationPerformanceTarget PerformanceTarget { get; set; }
        /// <summary>
        /// ComputeSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-computespec
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AIRecommendationComputeSpec
        /// </summary>
        public Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationComputeSpec ComputeSpec { get; set; }

        /// <summary>
        /// ModelSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-modelsource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AIModelSource
        /// </summary>
        [Required]
        public Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSource ModelSource { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-airecommendationjob.html#cfn-sagemaker-airecommendationjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace AIRecommendationJobTypes
    {
        public class AICapacityReservationConfig : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-aicapacityreservationconfig.html#cfn-sagemaker-airecommendationjob-aicapacityreservationconfig-capacityreservationpreference
            /// Required: False
            /// UpdateType: Immutable
            /// Type: dynamic
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityReservationPreference { get; set; }
            /// <summary>
            /// MlReservationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-aicapacityreservationconfig.html#cfn-sagemaker-airecommendationjob-aicapacityreservationconfig-mlreservationarns
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MlReservationArns { get; set; }
        }

        public class AIModelSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-aimodelsource.html#cfn-sagemaker-airecommendationjob-aimodelsource-s3
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AIModelSourceS3
            /// </summary>
            public Humidifier.SageMaker.AIRecommendationJobTypes.AIModelSourceS3 S3 { get; set; }
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
            public dynamic S3Uri { get; set; }
        }

        public class AIRecommendationComputeSpec : Humidifier.Base.BaseSubResource, IHaveInstanceTypes
        {
            /// <summary>
            /// CapacityReservationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationcomputespec.html#cfn-sagemaker-airecommendationjob-airecommendationcomputespec-capacityreservationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AICapacityReservationConfig
            /// </summary>
            public Humidifier.SageMaker.AIRecommendationJobTypes.AICapacityReservationConfig CapacityReservationConfig { get; set; }
            /// <summary>
            /// InstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationcomputespec.html#cfn-sagemaker-airecommendationjob-airecommendationcomputespec-instancetypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InstanceTypes { get; set; }
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
            public dynamic Metric { get; set; }
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
            public dynamic Framework { get; set; }
        }

        public class AIRecommendationOutputConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationoutputconfig.html#cfn-sagemaker-airecommendationjob-airecommendationoutputconfig-s3outputlocation
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputLocation { get; set; }
            /// <summary>
            /// ModelPackageGroupIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationoutputconfig.html#cfn-sagemaker-airecommendationjob-airecommendationoutputconfig-modelpackagegroupidentifier
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelPackageGroupIdentifier { get; set; }
        }

        public class AIRecommendationPerformanceTarget : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-airecommendationjob-airecommendationperformancetarget.html#cfn-sagemaker-airecommendationjob-airecommendationperformancetarget-constraints
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AIRecommendationConstraint
            /// </summary>
            public List<Humidifier.SageMaker.AIRecommendationJobTypes.AIRecommendationConstraint> Constraints { get; set; }
        }
    }
}