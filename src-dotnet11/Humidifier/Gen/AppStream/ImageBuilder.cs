namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;
    using ImageBuilderTypes;

    public class ImageBuilder : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveAppStreamImageBuilderTypesVpcConfigVpcConfig, IHaveAppStreamImageBuilderTypesVolumeConfigRootVolumeConfig, IHaveDisableIMDSV1_Boolean, IHaveEnableDefaultInternetAccess_Boolean, IHaveAppStreamImageBuilderTypesDomainJoinInfoDomainJoinInfo, IHaveAppstreamAgentVersion, IHaveStringListOfSoftwaresToUninstall, IHaveName, IHaveImageName, IHaveAppStreamImageBuilderTypesAgentAccessConfigAgentAccessConfig, IHaveDisplayName, IHaveStringListOfSoftwaresToInstall, IHaveIamRoleArn, IHaveInstanceType, IHaveImageArn, IHaveListOfAppStreamImageBuilderTypesAccessEndpointAccessEndpoints
    {
        public class Attributes
        {
            public static string StreamingUrl =  "StreamingUrl" ;
        }

        public override string AWSTypeName { get => AWS.AppStream.ImageBuilder; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Union<Humidifier.AppStream.ImageBuilderTypes.VpcConfig, BaseFunction>? VpcConfig { get; set; }
        /// <summary>
        /// RootVolumeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-rootvolumeconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VolumeConfig
        /// </summary>
        public Union<Humidifier.AppStream.ImageBuilderTypes.VolumeConfig, BaseFunction>? RootVolumeConfig { get; set; }
        /// <summary>
        /// DisableIMDSV1
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-disableimdsv1
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DisableIMDSV1 { get; set; }
        /// <summary>
        /// EnableDefaultInternetAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-enabledefaultinternetaccess
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableDefaultInternetAccess { get; set; }
        /// <summary>
        /// DomainJoinInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-domainjoininfo
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DomainJoinInfo
        /// </summary>
        public Union<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo, BaseFunction>? DomainJoinInfo { get; set; }
        /// <summary>
        /// AppstreamAgentVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-appstreamagentversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AppstreamAgentVersion { get; set; }
        /// <summary>
        /// SoftwaresToUninstall
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-softwarestouninstall
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SoftwaresToUninstall { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ImageName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-imagename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageName { get; set; }
        /// <summary>
        /// AgentAccessConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-agentaccessconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AgentAccessConfig
        /// </summary>
        public Union<Humidifier.AppStream.ImageBuilderTypes.AgentAccessConfig, BaseFunction>? AgentAccessConfig { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// SoftwaresToInstall
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-softwarestoinstall
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SoftwaresToInstall { get; set; }
        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-iamrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IamRoleArn { get; set; }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-instancetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ImageArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-imagearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageArn { get; set; }
        /// <summary>
        /// AccessEndpoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-accessendpoints
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AccessEndpoint
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint>, IReadOnlyList<Union<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint, BaseFunction>>, BaseFunction>? AccessEndpoints { get; set; }
    }

    namespace ImageBuilderTypes
    {
        public class AccessEndpoint : Humidifier.Base.BaseSubResource, IHaveEndpointType, IHaveVpceId
        {
            /// <summary>
            /// EndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-accessendpoint.html#cfn-appstream-imagebuilder-accessendpoint-endpointtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointType { get; set; }
            /// <summary>
            /// VpceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-accessendpoint.html#cfn-appstream-imagebuilder-accessendpoint-vpceid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpceId { get; set; }
        }

        public class AgentAccessConfig : Humidifier.Base.BaseSubResource, IHaveScreenResolution, IHaveScreenImageFormat, IHaveScreenshotsUploadEnabled_Boolean, IHaveUserControlMode, IHaveS3BucketArn, IHaveListOfAppStreamImageBuilderTypesAgentAccessSettingSettings
        {
            /// <summary>
            /// ScreenResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-agentaccessconfig.html#cfn-appstream-imagebuilder-agentaccessconfig-screenresolution
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScreenResolution { get; set; }
            /// <summary>
            /// ScreenImageFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-agentaccessconfig.html#cfn-appstream-imagebuilder-agentaccessconfig-screenimageformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScreenImageFormat { get; set; }
            /// <summary>
            /// ScreenshotsUploadEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-agentaccessconfig.html#cfn-appstream-imagebuilder-agentaccessconfig-screenshotsuploadenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ScreenshotsUploadEnabled { get; set; }
            /// <summary>
            /// UserControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-agentaccessconfig.html#cfn-appstream-imagebuilder-agentaccessconfig-usercontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserControlMode { get; set; }
            /// <summary>
            /// S3BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-agentaccessconfig.html#cfn-appstream-imagebuilder-agentaccessconfig-s3bucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketArn { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-agentaccessconfig.html#cfn-appstream-imagebuilder-agentaccessconfig-settings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AgentAccessSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppStream.ImageBuilderTypes.AgentAccessSetting>, IReadOnlyList<Union<Humidifier.AppStream.ImageBuilderTypes.AgentAccessSetting, BaseFunction>>, BaseFunction>? Settings { get; set; }
        }

        public class AgentAccessSetting : Humidifier.Base.BaseSubResource, IHavePermission, IHaveAgentAction
        {
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-agentaccesssetting.html#cfn-appstream-imagebuilder-agentaccesssetting-permission
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permission { get; set; }
            /// <summary>
            /// AgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-agentaccesssetting.html#cfn-appstream-imagebuilder-agentaccesssetting-agentaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentAction { get; set; }
        }

        public class DomainJoinInfo : Humidifier.Base.BaseSubResource, IHaveOrganizationalUnitDistinguishedName, IHaveDirectoryName
        {
            /// <summary>
            /// OrganizationalUnitDistinguishedName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-domainjoininfo.html#cfn-appstream-imagebuilder-domainjoininfo-organizationalunitdistinguishedname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationalUnitDistinguishedName { get; set; }
            /// <summary>
            /// DirectoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-domainjoininfo.html#cfn-appstream-imagebuilder-domainjoininfo-directoryname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DirectoryName { get; set; }
        }

        public class VolumeConfig : Humidifier.Base.BaseSubResource, IHaveVolumeSizeInGb_Integer
        {
            /// <summary>
            /// VolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-volumeconfig.html#cfn-appstream-imagebuilder-volumeconfig-volumesizeingb
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSizeInGb { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIds, IHaveStringListOfSecurityGroupIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-vpcconfig.html#cfn-appstream-imagebuilder-vpcconfig-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-vpcconfig.html#cfn-appstream-imagebuilder-vpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        }
    }
}