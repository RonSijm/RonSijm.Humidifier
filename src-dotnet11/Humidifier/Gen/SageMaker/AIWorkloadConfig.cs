namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AIWorkloadConfigTypes;

    public class AIWorkloadConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSageMakerAIWorkloadConfigTypesAIDatasetConfigDatasetConfig, IHaveAIWorkloadConfigName, IHaveSageMakerAIWorkloadConfigTypesAIWorkloadConfigsAIWorkloadConfigs
    {
        public class Attributes
        {
            public static string CreationTime =  "CreationTime" ;
            public static string AIWorkloadConfigArn =  "AIWorkloadConfigArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.AIWorkloadConfig; }
        /// <summary>
        /// DatasetConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aiworkloadconfig.html#cfn-sagemaker-aiworkloadconfig-datasetconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AIDatasetConfig
        /// </summary>
        public Union<Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig, BaseFunction>? DatasetConfig { get; set; }
        public Union<string, BaseFunction>? AIWorkloadConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AIWorkloadConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aiworkloadconfig.html#cfn-sagemaker-aiworkloadconfig-aiworkloadconfigs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AIWorkloadConfigs
        /// </summary>
        public Union<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs, BaseFunction>? AIWorkloadConfigs { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aiworkloadconfig.html#cfn-sagemaker-aiworkloadconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AIWorkloadConfigTypes
    {
        public class AIDatasetConfig : Humidifier.Base.BaseSubResource, IHaveListOfSageMakerAIWorkloadConfigTypesAIWorkloadInputDataConfigInputDataConfig
        {
            /// <summary>
            /// InputDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aidatasetconfig.html#cfn-sagemaker-aiworkloadconfig-aidatasetconfig-inputdataconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AIWorkloadInputDataConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadInputDataConfig>, IReadOnlyList<Union<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadInputDataConfig, BaseFunction>>, BaseFunction>? InputDataConfig { get; set; }
        }

        public class AIWorkloadConfigs : Humidifier.Base.BaseSubResource, IHaveSageMakerAIWorkloadConfigTypesWorkloadSpecWorkloadSpec
        {
            /// <summary>
            /// WorkloadSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloadconfigs.html#cfn-sagemaker-aiworkloadconfig-aiworkloadconfigs-workloadspec
            /// Required: True
            /// UpdateType: Immutable
            /// Type: WorkloadSpec
            /// </summary>
            public Union<Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec, BaseFunction>? WorkloadSpec { get; set; }
        }

        public class AIWorkloadDataSource : Humidifier.Base.BaseSubResource, IHaveSageMakerAIWorkloadConfigTypesAIWorkloadS3DataSourceS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloaddatasource.html#cfn-sagemaker-aiworkloadconfig-aiworkloaddatasource-s3datasource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AIWorkloadS3DataSource
            /// </summary>
            public Union<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadS3DataSource, BaseFunction>? S3DataSource { get; set; }
        }

        public class AIWorkloadInputDataConfig : Humidifier.Base.BaseSubResource, IHaveChannelName, IHaveSageMakerAIWorkloadConfigTypesAIWorkloadDataSourceDataSource
        {
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloadinputdataconfig.html#cfn-sagemaker-aiworkloadconfig-aiworkloadinputdataconfig-channelname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelName { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloadinputdataconfig.html#cfn-sagemaker-aiworkloadconfig-aiworkloadinputdataconfig-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AIWorkloadDataSource
            /// </summary>
            public Union<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadDataSource, BaseFunction>? DataSource { get; set; }
        }

        public class AIWorkloadS3DataSource : Humidifier.Base.BaseSubResource, IHaveS3Uri
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloads3datasource.html#cfn-sagemaker-aiworkloadconfig-aiworkloads3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class WorkloadSpec : Humidifier.Base.BaseSubResource, IHaveInline
        {
            /// <summary>
            /// Inline
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-workloadspec.html#cfn-sagemaker-aiworkloadconfig-workloadspec-inline
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Inline { get; set; }
        }
    }
}