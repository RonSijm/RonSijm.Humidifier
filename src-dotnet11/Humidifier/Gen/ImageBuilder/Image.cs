namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;
    using ImageTypes;

    public class Image : Humidifier.Base.BaseResource, IHaveImageBuilderImageTypesImageScanningConfigurationImageScanningConfiguration, IHaveContainerRecipeArn, IHaveListOfImageBuilderImageTypesWorkflowConfigurationWorkflows, IHaveImageBuilderImageTypesImagePipelineExecutionSettingsImagePipelineExecutionSettings, IHaveImageBuilderImageTypesDeletionSettingsDeletionSettings, IHaveInfrastructureConfigurationArn, IHaveImageRecipeArn, IHaveDistributionConfigurationArn, IHaveImageBuilderImageTypesImageLoggingConfigurationLoggingConfiguration, IHaveImageBuilderImageTypesImageTestsConfigurationImageTestsConfiguration, IHaveEnhancedImageMetadataEnabled_Boolean, IHaveExecutionRole, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string LatestVersion =  "LatestVersion" ;
            public static string ImageId =  "ImageId" ;
            public static string ImageUri =  "ImageUri" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.Image; }
        /// <summary>
        /// ImageScanningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-imagescanningconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ImageScanningConfiguration
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImageTypes.ImageScanningConfiguration, BaseFunction>? ImageScanningConfiguration { get; set; }
        /// <summary>
        /// ContainerRecipeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-containerrecipearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContainerRecipeArn { get; set; }
        /// <summary>
        /// Workflows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-workflows
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: WorkflowConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration>, IReadOnlyList<Union<Humidifier.ImageBuilder.ImageTypes.WorkflowConfiguration, BaseFunction>>, BaseFunction>? Workflows { get; set; }
        /// <summary>
        /// ImagePipelineExecutionSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-imagepipelineexecutionsettings
        /// Required: False
        /// UpdateType: Conditional
        /// Type: ImagePipelineExecutionSettings
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImageTypes.ImagePipelineExecutionSettings, BaseFunction>? ImagePipelineExecutionSettings { get; set; }
        /// <summary>
        /// DeletionSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-deletionsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DeletionSettings
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImageTypes.DeletionSettings, BaseFunction>? DeletionSettings { get; set; }
        /// <summary>
        /// InfrastructureConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-infrastructureconfigurationarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InfrastructureConfigurationArn { get; set; }
        /// <summary>
        /// ImageRecipeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-imagerecipearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageRecipeArn { get; set; }
        /// <summary>
        /// DistributionConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-distributionconfigurationarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DistributionConfigurationArn { get; set; }
        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-loggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ImageLoggingConfiguration
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImageTypes.ImageLoggingConfiguration, BaseFunction>? LoggingConfiguration { get; set; }
        /// <summary>
        /// ImageTestsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-imagetestsconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ImageTestsConfiguration
        /// </summary>
        public Union<Humidifier.ImageBuilder.ImageTypes.ImageTestsConfiguration, BaseFunction>? ImageTestsConfiguration { get; set; }
        /// <summary>
        /// EnhancedImageMetadataEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-enhancedimagemetadataenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnhancedImageMetadataEnabled { get; set; }
        /// <summary>
        /// ExecutionRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-executionrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExecutionRole { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-image.html#cfn-imagebuilder-image-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ImageTypes
    {
        public class DeletionSettings : Humidifier.Base.BaseSubResource, IHaveExecutionRole
        {
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-deletionsettings.html#cfn-imagebuilder-image-deletionsettings-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExecutionRole { get; set; }
        }

        public class EcrConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfContainerTags, IHaveRepositoryName
        {
            /// <summary>
            /// ContainerTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-ecrconfiguration.html#cfn-imagebuilder-image-ecrconfiguration-containertags
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContainerTags { get; set; }
            /// <summary>
            /// RepositoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-ecrconfiguration.html#cfn-imagebuilder-image-ecrconfiguration-repositoryname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RepositoryName { get; set; }
        }

        public class ImageLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupName
        {
            /// <summary>
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-imageloggingconfiguration.html#cfn-imagebuilder-image-imageloggingconfiguration-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupName { get; set; }
        }

        public class ImagePipelineExecutionSettings : Humidifier.Base.BaseSubResource, IHaveDeploymentId, IHaveOnUpdate_Boolean
        {
            /// <summary>
            /// DeploymentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-imagepipelineexecutionsettings.html#cfn-imagebuilder-image-imagepipelineexecutionsettings-deploymentid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeploymentId { get; set; }
            /// <summary>
            /// OnUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-imagepipelineexecutionsettings.html#cfn-imagebuilder-image-imagepipelineexecutionsettings-onupdate
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OnUpdate { get; set; }
        }

        public class ImageScanningConfiguration : Humidifier.Base.BaseSubResource, IHaveImageBuilderImageTypesEcrConfigurationEcrConfiguration, IHaveImageScanningEnabled_Boolean
        {
            /// <summary>
            /// EcrConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-imagescanningconfiguration.html#cfn-imagebuilder-image-imagescanningconfiguration-ecrconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EcrConfiguration
            /// </summary>
            public Union<Humidifier.ImageBuilder.ImageTypes.EcrConfiguration, BaseFunction>? EcrConfiguration { get; set; }
            /// <summary>
            /// ImageScanningEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-imagescanningconfiguration.html#cfn-imagebuilder-image-imagescanningconfiguration-imagescanningenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ImageScanningEnabled { get; set; }
        }

        public class ImageTestsConfiguration : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes_Integer, IHaveImageTestsEnabled_Boolean
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-imagetestsconfiguration.html#cfn-imagebuilder-image-imagetestsconfiguration-timeoutminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutMinutes { get; set; }
            /// <summary>
            /// ImageTestsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-imagetestsconfiguration.html#cfn-imagebuilder-image-imagetestsconfiguration-imagetestsenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ImageTestsEnabled { get; set; }
        }

        public class LatestVersion : Humidifier.Base.BaseSubResource, IHaveMajor, IHaveMinor, IHaveArn, IHavePatch
        {
            /// <summary>
            /// Major
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-latestversion.html#cfn-imagebuilder-image-latestversion-major
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Major { get; set; }
            /// <summary>
            /// Minor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-latestversion.html#cfn-imagebuilder-image-latestversion-minor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Minor { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-latestversion.html#cfn-imagebuilder-image-latestversion-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Patch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-latestversion.html#cfn-imagebuilder-image-latestversion-patch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Patch { get; set; }
        }

        public class WorkflowConfiguration : Humidifier.Base.BaseSubResource, IHaveParallelGroup, IHaveListOfImageBuilderImageTypesWorkflowParameterParameters, IHaveWorkflowArn, IHaveOnFailure
        {
            /// <summary>
            /// ParallelGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-workflowconfiguration.html#cfn-imagebuilder-image-workflowconfiguration-parallelgroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParallelGroup { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-workflowconfiguration.html#cfn-imagebuilder-image-workflowconfiguration-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: WorkflowParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ImageBuilder.ImageTypes.WorkflowParameter>, IReadOnlyList<Union<Humidifier.ImageBuilder.ImageTypes.WorkflowParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// WorkflowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-workflowconfiguration.html#cfn-imagebuilder-image-workflowconfiguration-workflowarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkflowArn { get; set; }
            /// <summary>
            /// OnFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-workflowconfiguration.html#cfn-imagebuilder-image-workflowconfiguration-onfailure
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnFailure { get; set; }
        }

        public class WorkflowParameter : Humidifier.Base.BaseSubResource, IHaveStringListOfValue, IHaveName
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-workflowparameter.html#cfn-imagebuilder-image-workflowparameter-value
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-image-workflowparameter.html#cfn-imagebuilder-image-workflowparameter-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}