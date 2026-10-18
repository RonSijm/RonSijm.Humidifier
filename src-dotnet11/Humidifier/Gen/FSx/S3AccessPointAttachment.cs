namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using S3AccessPointAttachmentTypes;

    public class S3AccessPointAttachment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveFSxS3AccessPointAttachmentTypesS3AccessPointOpenZFSConfigurationOpenZFSConfiguration, IHaveType, IHaveFSxS3AccessPointAttachmentTypesS3AccessPointS3AccessPoint, IHaveFSxS3AccessPointAttachmentTypesS3AccessPointOntapConfigurationOntapConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string Lifecycle =  "Lifecycle" ;
        }

        public override string AWSTypeName { get => AWS.FSx.S3AccessPointAttachment; }
        /// <summary>
        /// OpenZFSConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-s3accesspointattachment.html#cfn-fsx-s3accesspointattachment-openzfsconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3AccessPointOpenZFSConfiguration
        /// </summary>
        public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOpenZFSConfiguration, BaseFunction>? OpenZFSConfiguration { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-s3accesspointattachment.html#cfn-fsx-s3accesspointattachment-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// S3AccessPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-s3accesspointattachment.html#cfn-fsx-s3accesspointattachment-s3accesspoint
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3AccessPoint
        /// </summary>
        public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPoint, BaseFunction>? S3AccessPoint { get; set; }
        /// <summary>
        /// OntapConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-s3accesspointattachment.html#cfn-fsx-s3accesspointattachment-ontapconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3AccessPointOntapConfiguration
        /// </summary>
        public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOntapConfiguration, BaseFunction>? OntapConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace S3AccessPointAttachmentTypes
    {
        public class FileSystemGID : Humidifier.Base.BaseSubResource, IHaveGid_Double
        {
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-filesystemgid.html#cfn-fsx-s3accesspointattachment-filesystemgid-gid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Gid { get; set; }
        }

        public class OntapFileSystemIdentity : Humidifier.Base.BaseSubResource, IHaveType, IHaveFSxS3AccessPointAttachmentTypesOntapUnixFileSystemUserUnixUser, IHaveFSxS3AccessPointAttachmentTypesOntapWindowsFileSystemUserWindowsUser
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-ontapfilesystemidentity.html#cfn-fsx-s3accesspointattachment-ontapfilesystemidentity-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// UnixUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-ontapfilesystemidentity.html#cfn-fsx-s3accesspointattachment-ontapfilesystemidentity-unixuser
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OntapUnixFileSystemUser
            /// </summary>
            public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapUnixFileSystemUser, BaseFunction>? UnixUser { get; set; }
            /// <summary>
            /// WindowsUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-ontapfilesystemidentity.html#cfn-fsx-s3accesspointattachment-ontapfilesystemidentity-windowsuser
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OntapWindowsFileSystemUser
            /// </summary>
            public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapWindowsFileSystemUser, BaseFunction>? WindowsUser { get; set; }
        }

        public class OntapUnixFileSystemUser : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-ontapunixfilesystemuser.html#cfn-fsx-s3accesspointattachment-ontapunixfilesystemuser-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OntapWindowsFileSystemUser : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-ontapwindowsfilesystemuser.html#cfn-fsx-s3accesspointattachment-ontapwindowsfilesystemuser-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OpenZFSFileSystemIdentity : Humidifier.Base.BaseSubResource, IHaveType, IHaveFSxS3AccessPointAttachmentTypesOpenZFSPosixFileSystemUserPosixUser
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsfilesystemidentity.html#cfn-fsx-s3accesspointattachment-openzfsfilesystemidentity-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// PosixUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsfilesystemidentity.html#cfn-fsx-s3accesspointattachment-openzfsfilesystemidentity-posixuser
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OpenZFSPosixFileSystemUser
            /// </summary>
            public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser, BaseFunction>? PosixUser { get; set; }
        }

        public class OpenZFSPosixFileSystemUser : Humidifier.Base.BaseSubResource, IHaveUid_Double, IHaveListOfFSxS3AccessPointAttachmentTypesFileSystemGIDSecondaryGids, IHaveGid_Double
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsposixfilesystemuser.html#cfn-fsx-s3accesspointattachment-openzfsposixfilesystemuser-uid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Uid { get; set; }
            /// <summary>
            /// SecondaryGids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsposixfilesystemuser.html#cfn-fsx-s3accesspointattachment-openzfsposixfilesystemuser-secondarygids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: FileSystemGID
            /// </summary>
            public Union<IReadOnlyList<Humidifier.FSx.S3AccessPointAttachmentTypes.FileSystemGID>, IReadOnlyList<Union<Humidifier.FSx.S3AccessPointAttachmentTypes.FileSystemGID, BaseFunction>>, BaseFunction>? SecondaryGids { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsposixfilesystemuser.html#cfn-fsx-s3accesspointattachment-openzfsposixfilesystemuser-gid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Gid { get; set; }
        }

        public class S3AccessPoint : Humidifier.Base.BaseSubResource, IHavePolicy_Json, IHaveResourceARN, IHaveAlias, IHaveFSxS3AccessPointAttachmentTypesS3AccessPointVpcConfigurationVpcConfiguration
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspoint.html#cfn-fsx-s3accesspointattachment-s3accesspoint-policy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Policy { get; set; }
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspoint.html#cfn-fsx-s3accesspointattachment-s3accesspoint-resourcearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceARN { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspoint.html#cfn-fsx-s3accesspointattachment-s3accesspoint-alias
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspoint.html#cfn-fsx-s3accesspointattachment-s3accesspoint-vpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3AccessPointVpcConfiguration
            /// </summary>
            public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration, BaseFunction>? VpcConfiguration { get; set; }
        }

        public class S3AccessPointOntapConfiguration : Humidifier.Base.BaseSubResource, IHaveVolumeId, IHaveFSxS3AccessPointAttachmentTypesOntapFileSystemIdentityFileSystemIdentity
        {
            /// <summary>
            /// VolumeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointontapconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointontapconfiguration-volumeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeId { get; set; }
            /// <summary>
            /// FileSystemIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointontapconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointontapconfiguration-filesystemidentity
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OntapFileSystemIdentity
            /// </summary>
            public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity, BaseFunction>? FileSystemIdentity { get; set; }
        }

        public class S3AccessPointOpenZFSConfiguration : Humidifier.Base.BaseSubResource, IHaveVolumeId, IHaveFSxS3AccessPointAttachmentTypesOpenZFSFileSystemIdentityFileSystemIdentity
        {
            /// <summary>
            /// VolumeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointopenzfsconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointopenzfsconfiguration-volumeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeId { get; set; }
            /// <summary>
            /// FileSystemIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointopenzfsconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointopenzfsconfiguration-filesystemidentity
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OpenZFSFileSystemIdentity
            /// </summary>
            public Union<Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity, BaseFunction>? FileSystemIdentity { get; set; }
        }

        public class S3AccessPointVpcConfiguration : Humidifier.Base.BaseSubResource, IHaveVpcId
        {
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointvpcconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointvpcconfiguration-vpcid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
        }
    }
}