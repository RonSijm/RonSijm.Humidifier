namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using AIWorkloadConfigTypes;

    public class AIWorkloadConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
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
        public Humidifier.SageMaker.AIWorkloadConfigTypes.AIDatasetConfig DatasetConfig { get; set; }
        public dynamic AIWorkloadConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AIWorkloadConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aiworkloadconfig.html#cfn-sagemaker-aiworkloadconfig-aiworkloadconfigs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AIWorkloadConfigs
        /// </summary>
        public Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadConfigs AIWorkloadConfigs { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-aiworkloadconfig.html#cfn-sagemaker-aiworkloadconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace AIWorkloadConfigTypes
    {
        public class AIDatasetConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InputDataConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aidatasetconfig.html#cfn-sagemaker-aiworkloadconfig-aidatasetconfig-inputdataconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AIWorkloadInputDataConfig
            /// </summary>
            public List<Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadInputDataConfig> InputDataConfig { get; set; }
        }

        public class AIWorkloadConfigs : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WorkloadSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloadconfigs.html#cfn-sagemaker-aiworkloadconfig-aiworkloadconfigs-workloadspec
            /// Required: True
            /// UpdateType: Immutable
            /// Type: WorkloadSpec
            /// </summary>
            public Humidifier.SageMaker.AIWorkloadConfigTypes.WorkloadSpec WorkloadSpec { get; set; }
        }

        public class AIWorkloadDataSource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloaddatasource.html#cfn-sagemaker-aiworkloadconfig-aiworkloaddatasource-s3datasource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AIWorkloadS3DataSource
            /// </summary>
            public Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadS3DataSource S3DataSource { get; set; }
        }

        public class AIWorkloadInputDataConfig : Humidifier.Base.BaseSubResource, IHaveChannelName
        {
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloadinputdataconfig.html#cfn-sagemaker-aiworkloadconfig-aiworkloadinputdataconfig-channelname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelName { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-aiworkloadconfig-aiworkloadinputdataconfig.html#cfn-sagemaker-aiworkloadconfig-aiworkloadinputdataconfig-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AIWorkloadDataSource
            /// </summary>
            public Humidifier.SageMaker.AIWorkloadConfigTypes.AIWorkloadDataSource DataSource { get; set; }
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
            public dynamic S3Uri { get; set; }
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
            public dynamic Inline { get; set; }
        }
    }
}