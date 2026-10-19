namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;
    using ImageBuilderTypes;

    public class ImageBuilder : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveInstanceType, IHaveDisplayName, IHaveIamRoleArn, IHaveImageName, IHaveEnableDefaultInternetAccess, IHaveImageArn
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
        public dynamic Description { get; set; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-vpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConfig
        /// </summary>
        public Humidifier.AppStream.ImageBuilderTypes.VpcConfig VpcConfig { get; set; }
        /// <summary>
        /// RootVolumeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-rootvolumeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VolumeConfig
        /// </summary>
        public Humidifier.AppStream.ImageBuilderTypes.VolumeConfig RootVolumeConfig { get; set; }
        /// <summary>
        /// DisableIMDSV1
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-disableimdsv1
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DisableIMDSV1 { get; set; }
        /// <summary>
        /// EnableDefaultInternetAccess
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-enabledefaultinternetaccess
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableDefaultInternetAccess { get; set; }
        /// <summary>
        /// DomainJoinInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-domainjoininfo
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DomainJoinInfo
        /// </summary>
        public Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo DomainJoinInfo { get; set; }
        /// <summary>
        /// AppstreamAgentVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-appstreamagentversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AppstreamAgentVersion { get; set; }
        /// <summary>
        /// SoftwaresToUninstall
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-softwarestouninstall
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SoftwaresToUninstall { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ImageName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-imagename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageName { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// SoftwaresToInstall
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-softwarestoinstall
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SoftwaresToInstall { get; set; }
        /// <summary>
        /// IamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-iamrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IamRoleArn { get; set; }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-instancetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// ImageArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-imagearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageArn { get; set; }
        /// <summary>
        /// AccessEndpoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-imagebuilder.html#cfn-appstream-imagebuilder-accessendpoints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessEndpoint
        /// </summary>
        public List<Humidifier.AppStream.ImageBuilderTypes.AccessEndpoint> AccessEndpoints { get; set; }
    }

    namespace ImageBuilderTypes
    {
        public class AccessEndpoint : Humidifier.Base.BaseSubResource, IHaveEndpointType, IHaveVpceId
        {
            /// <summary>
            /// EndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-accessendpoint.html#cfn-appstream-imagebuilder-accessendpoint-endpointtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndpointType { get; set; }
            /// <summary>
            /// VpceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-accessendpoint.html#cfn-appstream-imagebuilder-accessendpoint-vpceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpceId { get; set; }
        }

        public class DomainJoinInfo : Humidifier.Base.BaseSubResource, IHaveOrganizationalUnitDistinguishedName, IHaveDirectoryName
        {
            /// <summary>
            /// OrganizationalUnitDistinguishedName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-domainjoininfo.html#cfn-appstream-imagebuilder-domainjoininfo-organizationalunitdistinguishedname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OrganizationalUnitDistinguishedName { get; set; }
            /// <summary>
            /// DirectoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-domainjoininfo.html#cfn-appstream-imagebuilder-domainjoininfo-directoryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DirectoryName { get; set; }
        }

        public class VolumeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VolumeSizeInGb
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-volumeconfig.html#cfn-appstream-imagebuilder-volumeconfig-volumesizeingb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGb { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-vpcconfig.html#cfn-appstream-imagebuilder-vpcconfig-subnetids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-vpcconfig.html#cfn-appstream-imagebuilder-vpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
        }
    }
}