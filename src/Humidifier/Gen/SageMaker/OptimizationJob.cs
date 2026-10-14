namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using OptimizationJobTypes;

    public class OptimizationJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRoleArn
    {
        public class Attributes
        {
            public static string OptimizationJobStatus =  "OptimizationJobStatus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string OptimizationJobArn =  "OptimizationJobArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.OptimizationJob; }

        /// <summary>
        /// DeploymentInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-deploymentinstancetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeploymentInstanceType { get; set; }

        /// <summary>
        /// OutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-outputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OptimizationJobOutputConfig
        /// </summary>
        [Required]
        public Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-stoppingcondition
        /// Required: True
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        [Required]
        public Humidifier.SageMaker.OptimizationJobTypes.StoppingCondition StoppingCondition { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OptimizationVpcConfig
        /// </summary>
        public Humidifier.SageMaker.OptimizationJobTypes.OptimizationVpcConfig VpcConfig { get; set; }
        /// <summary>
        /// OptimizationEnvironment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-optimizationenvironment
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> OptimizationEnvironment { get; set; }

        /// <summary>
        /// OptimizationConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-optimizationconfigs
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: OptimizationConfig
        /// </summary>
        [Required]
        public List<Humidifier.SageMaker.OptimizationJobTypes.OptimizationConfig> OptimizationConfigs { get; set; }
        public dynamic OptimizationJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }

        /// <summary>
        /// ModelSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-modelsource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OptimizationJobModelSource
        /// </summary>
        [Required]
        public Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSource ModelSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace OptimizationJobTypes
    {
        public class ModelCompilationConfig : Humidifier.Base.BaseSubResource, IHaveImage
        {
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelcompilationconfig.html#cfn-sagemaker-optimizationjob-modelcompilationconfig-image
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// OverrideEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelcompilationconfig.html#cfn-sagemaker-optimizationjob-modelcompilationconfig-overrideenvironment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> OverrideEnvironment { get; set; }
        }

        public class ModelQuantizationConfig : Humidifier.Base.BaseSubResource, IHaveImage
        {
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelquantizationconfig.html#cfn-sagemaker-optimizationjob-modelquantizationconfig-image
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// OverrideEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelquantizationconfig.html#cfn-sagemaker-optimizationjob-modelquantizationconfig-overrideenvironment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> OverrideEnvironment { get; set; }
        }

        public class ModelShardingConfig : Humidifier.Base.BaseSubResource, IHaveImage
        {
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelshardingconfig.html#cfn-sagemaker-optimizationjob-modelshardingconfig-image
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// OverrideEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelshardingconfig.html#cfn-sagemaker-optimizationjob-modelshardingconfig-overrideenvironment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> OverrideEnvironment { get; set; }
        }

        public class OptimizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelShardingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationconfig.html#cfn-sagemaker-optimizationjob-optimizationconfig-modelshardingconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelShardingConfig
            /// </summary>
            public Humidifier.SageMaker.OptimizationJobTypes.ModelShardingConfig ModelShardingConfig { get; set; }
            /// <summary>
            /// ModelQuantizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationconfig.html#cfn-sagemaker-optimizationjob-optimizationconfig-modelquantizationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelQuantizationConfig
            /// </summary>
            public Humidifier.SageMaker.OptimizationJobTypes.ModelQuantizationConfig ModelQuantizationConfig { get; set; }
            /// <summary>
            /// ModelCompilationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationconfig.html#cfn-sagemaker-optimizationjob-optimizationconfig-modelcompilationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelCompilationConfig
            /// </summary>
            public Humidifier.SageMaker.OptimizationJobTypes.ModelCompilationConfig ModelCompilationConfig { get; set; }
        }

        public class OptimizationJobModelSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationjobmodelsource.html#cfn-sagemaker-optimizationjob-optimizationjobmodelsource-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OptimizationJobModelSourceS3
            /// </summary>
            public Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3 S3 { get; set; }
        }

        public class OptimizationJobModelSourceS3 : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationjobmodelsources3.html#cfn-sagemaker-optimizationjob-optimizationjobmodelsources3-s3uri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }

        public class OptimizationJobOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationjoboutputconfig.html#cfn-sagemaker-optimizationjob-optimizationjoboutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationjoboutputconfig.html#cfn-sagemaker-optimizationjob-optimizationjoboutputconfig-s3outputlocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3OutputLocation { get; set; }
        }

        public class OptimizationVpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnets
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationvpcconfig.html#cfn-sagemaker-optimizationjob-optimizationvpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationvpcconfig.html#cfn-sagemaker-optimizationjob-optimizationvpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-stoppingcondition.html#cfn-sagemaker-optimizationjob-stoppingcondition-maxruntimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRuntimeInSeconds { get; set; }
        }
    }
}