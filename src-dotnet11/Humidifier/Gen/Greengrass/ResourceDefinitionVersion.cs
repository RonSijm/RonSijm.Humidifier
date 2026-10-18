namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using ResourceDefinitionVersionTypes;

    public class ResourceDefinitionVersion : Humidifier.Base.BaseResource, IHaveListOfGreengrassResourceDefinitionVersionTypesResourceInstanceResources, IHaveResourceDefinitionId
    {
        public override string AWSTypeName { get => AWS.Greengrass.ResourceDefinitionVersion; }

        /// <summary>
        /// Resources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinitionversion.html#cfn-greengrass-resourcedefinitionversion-resources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ResourceInstance
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance>, IReadOnlyList<Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance, BaseFunction>>, BaseFunction>? Resources { get; set; }

        /// <summary>
        /// ResourceDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinitionversion.html#cfn-greengrass-resourcedefinitionversion-resourcedefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceDefinitionId { get; set; }
    }

    namespace ResourceDefinitionVersionTypes
    {
        public class GroupOwnerSetting : Humidifier.Base.BaseSubResource, IHaveAutoAddGroupOwner_Boolean, IHaveGroupOwner
        {
            /// <summary>
            /// AutoAddGroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-groupownersetting.html#cfn-greengrass-resourcedefinitionversion-groupownersetting-autoaddgroupowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoAddGroupOwner { get; set; }
            /// <summary>
            /// GroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-groupownersetting.html#cfn-greengrass-resourcedefinitionversion-groupownersetting-groupowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupOwner { get; set; }
        }

        public class LocalDeviceResourceData : Humidifier.Base.BaseSubResource, IHaveSourcePath, IHaveGreengrassResourceDefinitionVersionTypesGroupOwnerSettingGroupOwnerSetting
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localdeviceresourcedata.html#cfn-greengrass-resourcedefinitionversion-localdeviceresourcedata-sourcepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePath { get; set; }
            /// <summary>
            /// GroupOwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localdeviceresourcedata.html#cfn-greengrass-resourcedefinitionversion-localdeviceresourcedata-groupownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupOwnerSetting
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting, BaseFunction>? GroupOwnerSetting { get; set; }
        }

        public class LocalVolumeResourceData : Humidifier.Base.BaseSubResource, IHaveSourcePath, IHaveDestinationPath, IHaveGreengrassResourceDefinitionVersionTypesGroupOwnerSettingGroupOwnerSetting
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localvolumeresourcedata.html#cfn-greengrass-resourcedefinitionversion-localvolumeresourcedata-sourcepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourcePath { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localvolumeresourcedata.html#cfn-greengrass-resourcedefinitionversion-localvolumeresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPath { get; set; }
            /// <summary>
            /// GroupOwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localvolumeresourcedata.html#cfn-greengrass-resourcedefinitionversion-localvolumeresourcedata-groupownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupOwnerSetting
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting, BaseFunction>? GroupOwnerSetting { get; set; }
        }

        public class ResourceDataContainer : Humidifier.Base.BaseSubResource, IHaveGreengrassResourceDefinitionVersionTypesSecretsManagerSecretResourceDataSecretsManagerSecretResourceData, IHaveGreengrassResourceDefinitionVersionTypesSageMakerMachineLearningModelResourceDataSageMakerMachineLearningModelResourceData, IHaveGreengrassResourceDefinitionVersionTypesLocalVolumeResourceDataLocalVolumeResourceData, IHaveGreengrassResourceDefinitionVersionTypesLocalDeviceResourceDataLocalDeviceResourceData, IHaveGreengrassResourceDefinitionVersionTypesS3MachineLearningModelResourceDataS3MachineLearningModelResourceData
        {
            /// <summary>
            /// SecretsManagerSecretResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-secretsmanagersecretresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretsManagerSecretResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.SecretsManagerSecretResourceData, BaseFunction>? SecretsManagerSecretResourceData { get; set; }
            /// <summary>
            /// SageMakerMachineLearningModelResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-sagemakermachinelearningmodelresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SageMakerMachineLearningModelResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.SageMakerMachineLearningModelResourceData, BaseFunction>? SageMakerMachineLearningModelResourceData { get; set; }
            /// <summary>
            /// LocalVolumeResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-localvolumeresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalVolumeResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalVolumeResourceData, BaseFunction>? LocalVolumeResourceData { get; set; }
            /// <summary>
            /// LocalDeviceResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-localdeviceresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalDeviceResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalDeviceResourceData, BaseFunction>? LocalDeviceResourceData { get; set; }
            /// <summary>
            /// S3MachineLearningModelResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-s3machinelearningmodelresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3MachineLearningModelResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.S3MachineLearningModelResourceData, BaseFunction>? S3MachineLearningModelResourceData { get; set; }
        }

        public class ResourceDownloadOwnerSetting : Humidifier.Base.BaseSubResource, IHaveGroupOwner, IHaveGroupPermission
        {
            /// <summary>
            /// GroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedownloadownersetting.html#cfn-greengrass-resourcedefinitionversion-resourcedownloadownersetting-groupowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupOwner { get; set; }
            /// <summary>
            /// GroupPermission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedownloadownersetting.html#cfn-greengrass-resourcedefinitionversion-resourcedownloadownersetting-grouppermission
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupPermission { get; set; }
        }

        public class ResourceInstance : Humidifier.Base.BaseSubResource, IHaveGreengrassResourceDefinitionVersionTypesResourceDataContainerResourceDataContainer, IHaveId, IHaveName
        {
            /// <summary>
            /// ResourceDataContainer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourceinstance.html#cfn-greengrass-resourcedefinitionversion-resourceinstance-resourcedatacontainer
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ResourceDataContainer
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer, BaseFunction>? ResourceDataContainer { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourceinstance.html#cfn-greengrass-resourcedefinitionversion-resourceinstance-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourceinstance.html#cfn-greengrass-resourcedefinitionversion-resourceinstance-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class S3MachineLearningModelResourceData : Humidifier.Base.BaseSubResource, IHaveGreengrassResourceDefinitionVersionTypesResourceDownloadOwnerSettingOwnerSetting, IHaveDestinationPath, IHaveS3Uri
        {
            /// <summary>
            /// OwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata-ownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceDownloadOwnerSetting
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting, BaseFunction>? OwnerSetting { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPath { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class SageMakerMachineLearningModelResourceData : Humidifier.Base.BaseSubResource, IHaveGreengrassResourceDefinitionVersionTypesResourceDownloadOwnerSettingOwnerSetting, IHaveDestinationPath, IHaveSageMakerJobArn
        {
            /// <summary>
            /// OwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata-ownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceDownloadOwnerSetting
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting, BaseFunction>? OwnerSetting { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPath { get; set; }
            /// <summary>
            /// SageMakerJobArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata-sagemakerjobarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SageMakerJobArn { get; set; }
        }

        public class SecretsManagerSecretResourceData : Humidifier.Base.BaseSubResource, IHaveARN, IHaveStringListOfAdditionalStagingLabelsToDownload
        {
            /// <summary>
            /// ARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ARN { get; set; }
            /// <summary>
            /// AdditionalStagingLabelsToDownload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata-additionalstaginglabelstodownload
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalStagingLabelsToDownload { get; set; }
        }
    }
}