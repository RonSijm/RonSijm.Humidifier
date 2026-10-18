namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using ResourceDefinitionTypes;

    public class ResourceDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGreengrassResourceDefinitionTypesResourceDefinitionVersionInitialVersion, IHaveTags_Json, IHaveName
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
        public Union<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDefinitionVersion, BaseFunction>? InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-resourcedefinition.html#cfn-greengrass-resourcedefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ResourceDefinitionTypes
    {
        public class GroupOwnerSetting : Humidifier.Base.BaseSubResource, IHaveAutoAddGroupOwner_Boolean, IHaveGroupOwner
        {
            /// <summary>
            /// AutoAddGroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-groupownersetting.html#cfn-greengrass-resourcedefinition-groupownersetting-autoaddgroupowner
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoAddGroupOwner { get; set; }
            /// <summary>
            /// GroupOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-groupownersetting.html#cfn-greengrass-resourcedefinition-groupownersetting-groupowner
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupOwner { get; set; }
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
            public Union<string, BaseFunction>? SourcePath { get; set; }
            /// <summary>
            /// GroupOwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localdeviceresourcedata.html#cfn-greengrass-resourcedefinition-localdeviceresourcedata-groupownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupOwnerSetting
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting, BaseFunction>? GroupOwnerSetting { get; set; }
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
            public Union<string, BaseFunction>? SourcePath { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localvolumeresourcedata.html#cfn-greengrass-resourcedefinition-localvolumeresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPath { get; set; }
            /// <summary>
            /// GroupOwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-localvolumeresourcedata.html#cfn-greengrass-resourcedefinition-localvolumeresourcedata-groupownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GroupOwnerSetting
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.GroupOwnerSetting, BaseFunction>? GroupOwnerSetting { get; set; }
        }

        public class ResourceDataContainer : Humidifier.Base.BaseSubResource, IHaveGreengrassResourceDefinitionTypesSecretsManagerSecretResourceDataSecretsManagerSecretResourceData, IHaveGreengrassResourceDefinitionTypesSageMakerMachineLearningModelResourceDataSageMakerMachineLearningModelResourceData, IHaveGreengrassResourceDefinitionTypesLocalVolumeResourceDataLocalVolumeResourceData, IHaveGreengrassResourceDefinitionTypesLocalDeviceResourceDataLocalDeviceResourceData, IHaveGreengrassResourceDefinitionTypesS3MachineLearningModelResourceDataS3MachineLearningModelResourceData
        {
            /// <summary>
            /// SecretsManagerSecretResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-secretsmanagersecretresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretsManagerSecretResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.SecretsManagerSecretResourceData, BaseFunction>? SecretsManagerSecretResourceData { get; set; }
            /// <summary>
            /// SageMakerMachineLearningModelResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-sagemakermachinelearningmodelresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SageMakerMachineLearningModelResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.SageMakerMachineLearningModelResourceData, BaseFunction>? SageMakerMachineLearningModelResourceData { get; set; }
            /// <summary>
            /// LocalVolumeResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-localvolumeresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalVolumeResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.LocalVolumeResourceData, BaseFunction>? LocalVolumeResourceData { get; set; }
            /// <summary>
            /// LocalDeviceResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-localdeviceresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: LocalDeviceResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.LocalDeviceResourceData, BaseFunction>? LocalDeviceResourceData { get; set; }
            /// <summary>
            /// S3MachineLearningModelResourceData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedatacontainer.html#cfn-greengrass-resourcedefinition-resourcedatacontainer-s3machinelearningmodelresourcedata
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3MachineLearningModelResourceData
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.S3MachineLearningModelResourceData, BaseFunction>? S3MachineLearningModelResourceData { get; set; }
        }

        public class ResourceDefinitionVersion : Humidifier.Base.BaseSubResource, IHaveListOfGreengrassResourceDefinitionTypesResourceInstanceResources
        {
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedefinitionversion.html#cfn-greengrass-resourcedefinition-resourcedefinitionversion-resources
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ResourceInstance
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance>, IReadOnlyList<Union<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceInstance, BaseFunction>>, BaseFunction>? Resources { get; set; }
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
            public Union<string, BaseFunction>? GroupOwner { get; set; }
            /// <summary>
            /// GroupPermission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourcedownloadownersetting.html#cfn-greengrass-resourcedefinition-resourcedownloadownersetting-grouppermission
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupPermission { get; set; }
        }

        public class ResourceInstance : Humidifier.Base.BaseSubResource, IHaveGreengrassResourceDefinitionTypesResourceDataContainerResourceDataContainer, IHaveId, IHaveName
        {
            /// <summary>
            /// ResourceDataContainer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourceinstance.html#cfn-greengrass-resourcedefinition-resourceinstance-resourcedatacontainer
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ResourceDataContainer
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDataContainer, BaseFunction>? ResourceDataContainer { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourceinstance.html#cfn-greengrass-resourcedefinition-resourceinstance-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-resourceinstance.html#cfn-greengrass-resourcedefinition-resourceinstance-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class S3MachineLearningModelResourceData : Humidifier.Base.BaseSubResource, IHaveGreengrassResourceDefinitionTypesResourceDownloadOwnerSettingOwnerSetting, IHaveDestinationPath, IHaveS3Uri
        {
            /// <summary>
            /// OwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-s3machinelearningmodelresourcedata-ownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceDownloadOwnerSetting
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting, BaseFunction>? OwnerSetting { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-s3machinelearningmodelresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPath { get; set; }
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-s3machinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-s3machinelearningmodelresourcedata-s3uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
        }

        public class SageMakerMachineLearningModelResourceData : Humidifier.Base.BaseSubResource, IHaveGreengrassResourceDefinitionTypesResourceDownloadOwnerSettingOwnerSetting, IHaveDestinationPath, IHaveSageMakerJobArn
        {
            /// <summary>
            /// OwnerSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata-ownersetting
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResourceDownloadOwnerSetting
            /// </summary>
            public Union<Humidifier.Greengrass.ResourceDefinitionTypes.ResourceDownloadOwnerSetting, BaseFunction>? OwnerSetting { get; set; }
            /// <summary>
            /// DestinationPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata-destinationpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationPath { get; set; }
            /// <summary>
            /// SageMakerJobArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata.html#cfn-greengrass-resourcedefinition-sagemakermachinelearningmodelresourcedata-sagemakerjobarn
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinition-secretsmanagersecretresourcedata-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ARN { get; set; }
            /// <summary>
            /// AdditionalStagingLabelsToDownload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-resourcedefinition-secretsmanagersecretresourcedata.html#cfn-greengrass-resourcedefinition-secretsmanagersecretresourcedata-additionalstaginglabelstodownload
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdditionalStagingLabelsToDownload { get; set; }
        }
    }
}