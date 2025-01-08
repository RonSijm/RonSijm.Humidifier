namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using ModelTypes;

    public class Model : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveExecutionRoleArn, IHaveEnableNetworkIsolation, IHaveModelName
    {
        public class Attributes
        {
            public static string ModelName =  "ModelName" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Model; }
        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-executionrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRoleArn { get; set; }
        /// <summary>
        /// EnableNetworkIsolation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-enablenetworkisolation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableNetworkIsolation { get; set; }
        /// <summary>
        /// PrimaryContainer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-primarycontainer
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ContainerDefinition
        /// </summary>
        public Humidifier.SageMaker.ModelTypes.ContainerDefinition PrimaryContainer { get; set; }
        public dynamic ModelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Humidifier.SageMaker.ModelTypes.VpcConfig VpcConfig { get; set; }
        /// <summary>
        /// Containers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-containers
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ContainerDefinition
        /// </summary>
        public List<Humidifier.SageMaker.ModelTypes.ContainerDefinition> Containers { get; set; }
        /// <summary>
        /// InferenceExecutionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-inferenceexecutionconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InferenceExecutionConfig
        /// </summary>
        public Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig InferenceExecutionConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ModelTypes
    {
        public class AdditionalModelDataSource : Humidifier.Base.BaseSubResource, IHaveChannelName, IHaveSageMakerModelTypesS3DataSourceS3DataSource
        {
            /// <summary>
            /// ChannelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-additionalmodeldatasource.html#cfn-sagemaker-model-additionalmodeldatasource-channelname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelName { get; set; }
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-additionalmodeldatasource.html#cfn-sagemaker-model-additionalmodeldatasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Humidifier.SageMaker.ModelTypes.S3DataSource S3DataSource { get; set; }
        }

        public class ContainerDefinition : Humidifier.Base.BaseSubResource, IHaveMode, IHaveImage, IHaveModelDataUrl, IHaveEnvironment, IHaveModelPackageName, IHaveContainerHostname
        {
            /// <summary>
            /// ImageConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-imageconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ImageConfig
            /// </summary>
            public Humidifier.SageMaker.ModelTypes.ImageConfig ImageConfig { get; set; }
            /// <summary>
            /// InferenceSpecificationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-inferencespecificationname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InferenceSpecificationName { get; set; }
            /// <summary>
            /// ContainerHostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-containerhostname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerHostname { get; set; }
            /// <summary>
            /// ModelPackageName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-modelpackagename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelPackageName { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-mode
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Environment { get; set; }
            /// <summary>
            /// ModelDataUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-modeldataurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelDataUrl { get; set; }
            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-image
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image { get; set; }
            /// <summary>
            /// ModelDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-modeldatasource
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelDataSource
            /// </summary>
            public Humidifier.SageMaker.ModelTypes.ModelDataSource ModelDataSource { get; set; }
            /// <summary>
            /// MultiModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-multimodelconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MultiModelConfig
            /// </summary>
            public Humidifier.SageMaker.ModelTypes.MultiModelConfig MultiModelConfig { get; set; }
        }

        public class HubAccessConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HubContentArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-s3datasource-hubaccessconfig.html#cfn-sagemaker-model-s3datasource-hubaccessconfig-hubcontentarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HubContentArn { get; set; }
        }

        public class ImageConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RepositoryAuthConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition-imageconfig.html#cfn-sagemaker-model-containerdefinition-imageconfig-repositoryauthconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RepositoryAuthConfig
            /// </summary>
            public Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig RepositoryAuthConfig { get; set; }
            /// <summary>
            /// RepositoryAccessMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition-imageconfig.html#cfn-sagemaker-model-containerdefinition-imageconfig-repositoryaccessmode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RepositoryAccessMode { get; set; }
        }

        public class InferenceExecutionConfig : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-inferenceexecutionconfig.html#cfn-sagemaker-model-inferenceexecutionconfig-mode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class ModelAccessConfig : Humidifier.Base.BaseSubResource, IHaveAcceptEula
        {
            /// <summary>
            /// AcceptEula
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-s3datasource-modelaccessconfig.html#cfn-sagemaker-model-s3datasource-modelaccessconfig-accepteula
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AcceptEula { get; set; }
        }

        public class ModelDataSource : Humidifier.Base.BaseSubResource, IHaveSageMakerModelTypesS3DataSourceS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition-modeldatasource.html#cfn-sagemaker-model-containerdefinition-modeldatasource-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataSource
            /// </summary>
            public Humidifier.SageMaker.ModelTypes.S3DataSource S3DataSource { get; set; }
        }

        public class MultiModelConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ModelCacheSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition-multimodelconfig.html#cfn-sagemaker-model-containerdefinition-multimodelconfig-modelcachesetting
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelCacheSetting { get; set; }
        }

        public class RepositoryAuthConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RepositoryCredentialsProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition-imageconfig-repositoryauthconfig.html#cfn-sagemaker-model-containerdefinition-imageconfig-repositoryauthconfig-repositorycredentialsproviderarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RepositoryCredentialsProviderArn { get; set; }
        }

        public class S3DataSource : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveCompressionType, IHaveS3DataType
        {
            /// <summary>
            /// ModelAccessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-s3datasource.html#cfn-sagemaker-model-s3datasource-modelaccessconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ModelAccessConfig
            /// </summary>
            public Humidifier.SageMaker.ModelTypes.ModelAccessConfig ModelAccessConfig { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-s3datasource.html#cfn-sagemaker-model-s3datasource-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
            /// <summary>
            /// S3DataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-s3datasource.html#cfn-sagemaker-model-s3datasource-s3datatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3DataType { get; set; }
            /// <summary>
            /// CompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-s3datasource.html#cfn-sagemaker-model-s3datasource-compressiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionType { get; set; }
            /// <summary>
            /// HubAccessConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-s3datasource.html#cfn-sagemaker-model-s3datasource-hubaccessconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HubAccessConfig
            /// </summary>
            public Humidifier.SageMaker.ModelTypes.HubAccessConfig HubAccessConfig { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnets
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-vpcconfig.html#cfn-sagemaker-model-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-vpcconfig.html#cfn-sagemaker-model-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}