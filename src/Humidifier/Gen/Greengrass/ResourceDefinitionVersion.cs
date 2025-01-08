namespace Humidifier.Greengrass
{
    using System.Collections.Generic;
    using ResourceDefinitionVersionTypes;

    public class ResourceDefinitionVersion : Humidifier.Base.BaseResource
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
        public List<Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceInstance> Resources { get; set; }

        /// <summary>
        /// ResourceDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinitionversion.html#cfn-greengrass-resourcedefinitionversion-resourcedefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceDefinitionId { get; set; }
    }

    namespace ResourceDefinitionVersionTypes
    {
        public class GroupOwnerSetting : Humidifier.Base.BaseSubResource, IHaveGroupOwner, IHaveAutoAddGroupOwner
        {
            /// <summary>
            /// AutoAddGroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-groupownersetting.html#cfn-greengrass-resourcedefinitionversion-groupownersetting-autoaddgroupowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoAddGroupOwner { get; set; }
            /// <summary>
            /// GroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-groupownersetting.html#cfn-greengrass-resourcedefinitionversion-groupownersetting-groupowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupOwner { get; set; }
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
            public dynamic SourcePath { get; set; }
            /// <summary>
            /// GroupOwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localdeviceresourcedata.html#cfn-greengrass-resourcedefinitionversion-localdeviceresourcedata-groupownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupOwnerSetting
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting GroupOwnerSetting { get; set; }
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
            public dynamic SourcePath { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localvolumeresourcedata.html#cfn-greengrass-resourcedefinitionversion-localvolumeresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPath { get; set; }
            /// <summary>
            /// GroupOwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-localvolumeresourcedata.html#cfn-greengrass-resourcedefinitionversion-localvolumeresourcedata-groupownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupOwnerSetting
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.GroupOwnerSetting GroupOwnerSetting { get; set; }
        }

        public class ResourceDataContainer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretsManagerSecretResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-secretsmanagersecretresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretsManagerSecretResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.SecretsManagerSecretResourceData SecretsManagerSecretResourceData { get; set; }
            /// <summary>
            /// SageMakerMachineLearningModelResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-sagemakermachinelearningmodelresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SageMakerMachineLearningModelResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.SageMakerMachineLearningModelResourceData SageMakerMachineLearningModelResourceData { get; set; }
            /// <summary>
            /// LocalVolumeResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-localvolumeresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalVolumeResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalVolumeResourceData LocalVolumeResourceData { get; set; }
            /// <summary>
            /// LocalDeviceResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-localdeviceresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalDeviceResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.LocalDeviceResourceData LocalDeviceResourceData { get; set; }
            /// <summary>
            /// S3MachineLearningModelResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedatacontainer.html#cfn-greengrass-resourcedefinitionversion-resourcedatacontainer-s3machinelearningmodelresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3MachineLearningModelResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.S3MachineLearningModelResourceData S3MachineLearningModelResourceData { get; set; }
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
            public dynamic GroupOwner { get; set; }
            /// <summary>
            /// GroupPermission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourcedownloadownersetting.html#cfn-greengrass-resourcedefinitionversion-resourcedownloadownersetting-grouppermission
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupPermission { get; set; }
        }

        public class ResourceInstance : Humidifier.Base.BaseSubResource, IHaveName, IHaveId
        {
            /// <summary>
            /// ResourceDataContainer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourceinstance.html#cfn-greengrass-resourcedefinitionversion-resourceinstance-resourcedatacontainer
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ResourceDataContainer
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDataContainer ResourceDataContainer { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourceinstance.html#cfn-greengrass-resourcedefinitionversion-resourceinstance-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-resourceinstance.html#cfn-greengrass-resourcedefinitionversion-resourceinstance-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class S3MachineLearningModelResourceData : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveDestinationPath, IHaveGreengrassResourceDefinitionVersionTypesResourceDownloadOwnerSettingOwnerSetting
        {
            /// <summary>
            /// OwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata-ownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceDownloadOwnerSetting
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting OwnerSetting { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPath { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-s3machinelearningmodelresourcedata-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }

        public class SageMakerMachineLearningModelResourceData : Humidifier.Base.BaseSubResource, IHaveDestinationPath, IHaveSageMakerJobArn, IHaveGreengrassResourceDefinitionVersionTypesResourceDownloadOwnerSettingOwnerSetting
        {
            /// <summary>
            /// OwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata-ownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceDownloadOwnerSetting
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionVersionTypes.ResourceDownloadOwnerSetting OwnerSetting { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPath { get; set; }
            /// <summary>
            /// SageMakerJobArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinitionversion-sagemakermachinelearningmodelresourcedata-sagemakerjobarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SageMakerJobArn { get; set; }
        }

        public class SecretsManagerSecretResourceData : Humidifier.Base.BaseSubResource, IHaveARN, IHaveAdditionalStagingLabelsToDownload
        {
            /// <summary>
            /// ARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ARN { get; set; }
            /// <summary>
            /// AdditionalStagingLabelsToDownload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinitionversion-secretsmanagersecretresourcedata-additionalstaginglabelstodownload
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdditionalStagingLabelsToDownload { get; set; }
        }
    }
}