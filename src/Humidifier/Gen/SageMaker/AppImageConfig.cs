namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using AppImageConfigTypes;

    public class AppImageConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAppImageConfigName
    {
        public class Attributes
        {
            public static string AppImageConfigArn =  "AppImageConfigArn" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.AppImageConfig; }
        /// <summary>
        /// KernelGatewayImageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-appimageconfig.html#cfn-sagemaker-appimageconfig-kernelgatewayimageconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KernelGatewayImageConfig
        /// </summary>
        public Humidifier.SageMaker.AppImageConfigTypes.KernelGatewayImageConfig KernelGatewayImageConfig { get; set; }
        /// <summary>
        /// CodeEditorAppImageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-appimageconfig.html#cfn-sagemaker-appimageconfig-codeeditorappimageconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CodeEditorAppImageConfig
        /// </summary>
        public Humidifier.SageMaker.AppImageConfigTypes.CodeEditorAppImageConfig CodeEditorAppImageConfig { get; set; }
        public dynamic AppImageConfigName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// JupyterLabAppImageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-appimageconfig.html#cfn-sagemaker-appimageconfig-jupyterlabappimageconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JupyterLabAppImageConfig
        /// </summary>
        public Humidifier.SageMaker.AppImageConfigTypes.JupyterLabAppImageConfig JupyterLabAppImageConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-appimageconfig.html#cfn-sagemaker-appimageconfig-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace AppImageConfigTypes
    {
        public class CodeEditorAppImageConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-codeeditorappimageconfig.html#cfn-sagemaker-appimageconfig-codeeditorappimageconfig-containerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerConfig
            /// </summary>
            public Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig ContainerConfig { get; set; }
        }

        public class ContainerConfig : Humidifier.Base.BaseSubResource, IHaveContainerEntrypoint, IHaveContainerArguments
        {
            /// <summary>
            /// ContainerEntrypoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-containerconfig.html#cfn-sagemaker-appimageconfig-containerconfig-containerentrypoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ContainerEntrypoint { get; set; }
            /// <summary>
            /// ContainerEnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-containerconfig.html#cfn-sagemaker-appimageconfig-containerconfig-containerenvironmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomImageContainerEnvironmentVariable
            /// </summary>
            public List<Humidifier.SageMaker.AppImageConfigTypes.CustomImageContainerEnvironmentVariable> ContainerEnvironmentVariables { get; set; }
            /// <summary>
            /// ContainerArguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-containerconfig.html#cfn-sagemaker-appimageconfig-containerconfig-containerarguments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ContainerArguments { get; set; }
        }

        public class CustomImageContainerEnvironmentVariable : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-customimagecontainerenvironmentvariable.html#cfn-sagemaker-appimageconfig-customimagecontainerenvironmentvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-customimagecontainerenvironmentvariable.html#cfn-sagemaker-appimageconfig-customimagecontainerenvironmentvariable-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class FileSystemConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-filesystemconfig.html#cfn-sagemaker-appimageconfig-filesystemconfig-mountpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MountPath { get; set; }
            /// <summary>
            /// DefaultGid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-filesystemconfig.html#cfn-sagemaker-appimageconfig-filesystemconfig-defaultgid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DefaultGid { get; set; }
            /// <summary>
            /// DefaultUid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-filesystemconfig.html#cfn-sagemaker-appimageconfig-filesystemconfig-defaultuid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DefaultUid { get; set; }
        }

        public class JupyterLabAppImageConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContainerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-jupyterlabappimageconfig.html#cfn-sagemaker-appimageconfig-jupyterlabappimageconfig-containerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerConfig
            /// </summary>
            public Humidifier.SageMaker.AppImageConfigTypes.ContainerConfig ContainerConfig { get; set; }
        }

        public class KernelGatewayImageConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KernelSpecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-kernelgatewayimageconfig.html#cfn-sagemaker-appimageconfig-kernelgatewayimageconfig-kernelspecs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KernelSpec
            /// </summary>
            public List<Humidifier.SageMaker.AppImageConfigTypes.KernelSpec> KernelSpecs { get; set; }
            /// <summary>
            /// FileSystemConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-kernelgatewayimageconfig.html#cfn-sagemaker-appimageconfig-kernelgatewayimageconfig-filesystemconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FileSystemConfig
            /// </summary>
            public Humidifier.SageMaker.AppImageConfigTypes.FileSystemConfig FileSystemConfig { get; set; }
        }

        public class KernelSpec : Humidifier.Base.BaseSubResource, IHaveName, IHaveDisplayName
        {
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-kernelspec.html#cfn-sagemaker-appimageconfig-kernelspec-displayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayName { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-appimageconfig-kernelspec.html#cfn-sagemaker-appimageconfig-kernelspec-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}