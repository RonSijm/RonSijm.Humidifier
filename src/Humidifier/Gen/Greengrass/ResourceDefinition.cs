namespace Humidifier.Greengrass
{
    using System.Collections.Generic;
    using ResourceDefinitionTypes;

    public class ResourceDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDynamicTags
    {
        public class Attributes
        {
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Greengrass.ResourceDefinition; }
        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinition.html#cfn-greengrass-resourcedefinition-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ResourceDefinitionVersion
        /// </summary>
        public Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinition.html#cfn-greengrass-resourcedefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResourceDefinitionTypes
    {
        public class GroupOwnerSetting : Humidifier.Base.BaseSubResource, IHaveGroupOwner, IHaveAutoAddGroupOwner
        {
            /// <summary>
            /// AutoAddGroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-groupownersetting.html#cfn-greengrass-resourcedefinition-groupownersetting-autoaddgroupowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoAddGroupOwner { get; set; }
            /// <summary>
            /// GroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-groupownersetting.html#cfn-greengrass-resourcedefinition-groupownersetting-groupowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupOwner { get; set; }
        }

        public class LocalDeviceResourceData : Humidifier.Base.BaseSubResource, IHaveSourcePath, IHaveGreengrassResourceDefinitionTypesGroupOwnerSettingGroupOwnerSetting
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localdeviceresourcedata.html#cfn-greengrass-resourcedefinition-localdeviceresourcedata-sourcepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePath { get; set; }
            /// <summary>
            /// GroupOwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localdeviceresourcedata.html#cfn-greengrass-resourcedefinition-localdeviceresourcedata-groupownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupOwnerSetting
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting GroupOwnerSetting { get; set; }
        }

        public class LocalVolumeResourceData : Humidifier.Base.BaseSubResource, IHaveSourcePath, IHaveDestinationPath, IHaveGreengrassResourceDefinitionTypesGroupOwnerSettingGroupOwnerSetting
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localvolumeresourcedata.html#cfn-greengrass-resourcedefinition-localvolumeresourcedata-sourcepath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePath { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localvolumeresourcedata.html#cfn-greengrass-resourcedefinition-localvolumeresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPath { get; set; }
            /// <summary>
            /// GroupOwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localvolumeresourcedata.html#cfn-greengrass-resourcedefinition-localvolumeresourcedata-groupownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupOwnerSetting
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting GroupOwnerSetting { get; set; }
        }

        public class ResourceDataContainer : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SecretsManagerSecretResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-secretsmanagersecretresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretsManagerSecretResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.SecretsManagerSecretResourceData SecretsManagerSecretResourceData { get; set; }
            /// <summary>
            /// SageMakerMachineLearningModelResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-sagemakermachinelearningmodelresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SageMakerMachineLearningModelResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.SageMakerMachineLearningModelResourceData SageMakerMachineLearningModelResourceData { get; set; }
            /// <summary>
            /// LocalVolumeResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-localvolumeresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalVolumeResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.LocalVolumeResourceData LocalVolumeResourceData { get; set; }
            /// <summary>
            /// LocalDeviceResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-localdeviceresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalDeviceResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.LocalDeviceResourceData LocalDeviceResourceData { get; set; }
            /// <summary>
            /// S3MachineLearningModelResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-s3machinelearningmodelresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3MachineLearningModelResourceData
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.S3MachineLearningModelResourceData S3MachineLearningModelResourceData { get; set; }
        }

        public class ResourceDefinitionVersion : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedefinitionversion.html#cfn-greengrass-resourcedefinition-resourcedefinitionversion-resources
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ResourceInstance
            /// </summary>
            public List<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance> Resources { get; set; }
        }

        public class ResourceDownloadOwnerSetting : Humidifier.Base.BaseSubResource, IHaveGroupOwner, IHaveGroupPermission
        {
            /// <summary>
            /// GroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedownloadownersetting.html#cfn-greengrass-resourcedefinition-resourcedownloadownersetting-groupowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupOwner { get; set; }
            /// <summary>
            /// GroupPermission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedownloadownersetting.html#cfn-greengrass-resourcedefinition-resourcedownloadownersetting-grouppermission
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourceinstance.html#cfn-greengrass-resourcedefinition-resourceinstance-resourcedatacontainer
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ResourceDataContainer
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer ResourceDataContainer { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourceinstance.html#cfn-greengrass-resourcedefinition-resourceinstance-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourceinstance.html#cfn-greengrass-resourcedefinition-resourceinstance-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class S3MachineLearningModelResourceData : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveDestinationPath, IHaveGreengrassResourceDefinitionTypesResourceDownloadOwnerSettingOwnerSetting
        {
            /// <summary>
            /// OwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-s3machinelearningmodelresourcedata-ownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceDownloadOwnerSetting
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting OwnerSetting { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-s3machinelearningmodelresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPath { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-s3machinelearningmodelresourcedata-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Uri { get; set; }
        }

        public class SageMakerMachineLearningModelResourceData : Humidifier.Base.BaseSubResource, IHaveDestinationPath, IHaveGreengrassResourceDefinitionTypesResourceDownloadOwnerSettingOwnerSetting, IHaveSageMakerJobArn
        {
            /// <summary>
            /// OwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata-ownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceDownloadOwnerSetting
            /// </summary>
            public Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting OwnerSetting { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationPath { get; set; }
            /// <summary>
            /// SageMakerJobArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata-sagemakerjobarn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinition-secretsmanagersecretresourcedata-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ARN { get; set; }
            /// <summary>
            /// AdditionalStagingLabelsToDownload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinition-secretsmanagersecretresourcedata-additionalstaginglabelstodownload
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdditionalStagingLabelsToDownload { get; set; }
        }
    }
}