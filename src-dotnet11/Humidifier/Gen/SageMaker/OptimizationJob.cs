namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using OptimizationJobTypes;

    public class OptimizationJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDeploymentInstanceType, IHaveSageMakerOptimizationJobTypesOptimizationJobOutputConfigOutputConfig, IHaveSageMakerOptimizationJobTypesStoppingConditionStoppingCondition, IHaveSageMakerOptimizationJobTypesOptimizationVpcConfigVpcConfig, IHaveStringDictionaryOfOptimizationEnvironment, IHaveListOfSageMakerOptimizationJobTypesOptimizationConfigOptimizationConfigs, IHaveOptimizationJobName, IHaveRoleArn, IHaveSageMakerOptimizationJobTypesOptimizationJobModelSourceModelSource
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
        public Union<string, BaseFunction>? DeploymentInstanceType { get; set; }

        /// <summary>
        /// OutputConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-outputconfig
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OptimizationJobOutputConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobOutputConfig, BaseFunction>? OutputConfig { get; set; }

        /// <summary>
        /// StoppingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-stoppingcondition
        /// Required: True
        /// UpdateType: Immutable
        /// Type: StoppingCondition
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.OptimizationJobTypes.StoppingCondition, BaseFunction>? StoppingCondition { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OptimizationVpcConfig
        /// </summary>
        public Union<Humidifier.SageMaker.OptimizationJobTypes.OptimizationVpcConfig, BaseFunction>? VpcConfig { get; set; }
        /// <summary>
        /// OptimizationEnvironment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-optimizationenvironment
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? OptimizationEnvironment { get; set; }

        /// <summary>
        /// OptimizationConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-optimizationconfigs
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: OptimizationConfig
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SageMaker.OptimizationJobTypes.OptimizationConfig>, IReadOnlyList<Union<Humidifier.SageMaker.OptimizationJobTypes.OptimizationConfig, BaseFunction>>, BaseFunction>? OptimizationConfigs { get; set; }
        public Union<string, BaseFunction>? OptimizationJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }

        /// <summary>
        /// ModelSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-modelsource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: OptimizationJobModelSource
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSource, BaseFunction>? ModelSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-optimizationjob.html#cfn-sagemaker-optimizationjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace OptimizationJobTypes
    {
        public class ModelCompilationConfig : Humidifier.Base.BaseSubResource, IHaveImage, IHaveStringDictionaryOfOverrideEnvironment
        {
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelcompilationconfig.html#cfn-sagemaker-optimizationjob-modelcompilationconfig-image
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// OverrideEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelcompilationconfig.html#cfn-sagemaker-optimizationjob-modelcompilationconfig-overrideenvironment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? OverrideEnvironment { get; set; }
        }

        public class ModelQuantizationConfig : Humidifier.Base.BaseSubResource, IHaveImage, IHaveStringDictionaryOfOverrideEnvironment
        {
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelquantizationconfig.html#cfn-sagemaker-optimizationjob-modelquantizationconfig-image
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// OverrideEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelquantizationconfig.html#cfn-sagemaker-optimizationjob-modelquantizationconfig-overrideenvironment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? OverrideEnvironment { get; set; }
        }

        public class ModelShardingConfig : Humidifier.Base.BaseSubResource, IHaveImage, IHaveStringDictionaryOfOverrideEnvironment
        {
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelshardingconfig.html#cfn-sagemaker-optimizationjob-modelshardingconfig-image
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Image { get; set; }
            /// <summary>
            /// OverrideEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-modelshardingconfig.html#cfn-sagemaker-optimizationjob-modelshardingconfig-overrideenvironment
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? OverrideEnvironment { get; set; }
        }

        public class OptimizationConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerOptimizationJobTypesModelShardingConfigModelShardingConfig, IHaveSageMakerOptimizationJobTypesModelQuantizationConfigModelQuantizationConfig, IHaveSageMakerOptimizationJobTypesModelCompilationConfigModelCompilationConfig
        {
            /// <summary>
            /// ModelShardingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationconfig.html#cfn-sagemaker-optimizationjob-optimizationconfig-modelshardingconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelShardingConfig
            /// </summary>
            public Union<Humidifier.SageMaker.OptimizationJobTypes.ModelShardingConfig, BaseFunction>? ModelShardingConfig { get; set; }
            /// <summary>
            /// ModelQuantizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationconfig.html#cfn-sagemaker-optimizationjob-optimizationconfig-modelquantizationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelQuantizationConfig
            /// </summary>
            public Union<Humidifier.SageMaker.OptimizationJobTypes.ModelQuantizationConfig, BaseFunction>? ModelQuantizationConfig { get; set; }
            /// <summary>
            /// ModelCompilationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationconfig.html#cfn-sagemaker-optimizationjob-optimizationconfig-modelcompilationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelCompilationConfig
            /// </summary>
            public Union<Humidifier.SageMaker.OptimizationJobTypes.ModelCompilationConfig, BaseFunction>? ModelCompilationConfig { get; set; }
        }

        public class OptimizationJobModelSource : Humidifier.Base.BaseSubResource, IHaveSageMakerOptimizationJobTypesOptimizationJobModelSourceS3S3
        {
            /// <summary>
            /// S3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationjobmodelsource.html#cfn-sagemaker-optimizationjob-optimizationjobmodelsource-s3
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OptimizationJobModelSourceS3
            /// </summary>
            public Union<Humidifier.SageMaker.OptimizationJobTypes.OptimizationJobModelSourceS3, BaseFunction>? S3 { get; set; }
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
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class OptimizationJobOutputConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyId, IHaveS3OutputLocation
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationjoboutputconfig.html#cfn-sagemaker-optimizationjob-optimizationjoboutputconfig-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// S3OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationjoboutputconfig.html#cfn-sagemaker-optimizationjob-optimizationjoboutputconfig-s3outputlocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3OutputLocation { get; set; }
        }

        public class OptimizationVpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnets, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationvpcconfig.html#cfn-sagemaker-optimizationjob-optimizationvpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-optimizationvpcconfig.html#cfn-sagemaker-optimizationjob-optimizationvpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }

        public class StoppingCondition : Humidifier.Base.BaseSubResource, IHaveMaxRuntimeInSeconds_Integer
        {
            /// <summary>
            /// MaxRuntimeInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-optimizationjob-stoppingcondition.html#cfn-sagemaker-optimizationjob-stoppingcondition-maxruntimeinseconds
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRuntimeInSeconds { get; set; }
        }
    }
}