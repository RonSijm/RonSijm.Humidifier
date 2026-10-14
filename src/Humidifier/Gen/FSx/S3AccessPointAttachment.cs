namespace Humidifier.FSx
{
    using global::System.Collections.Generic;
    using S3AccessPointAttachmentTypes;

    public class S3AccessPointAttachment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveType
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
        public Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOpenZFSConfiguration OpenZFSConfiguration { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-s3accesspointattachment.html#cfn-fsx-s3accesspointattachment-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// S3AccessPoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-s3accesspointattachment.html#cfn-fsx-s3accesspointattachment-s3accesspoint
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3AccessPoint
        /// </summary>
        public Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPoint S3AccessPoint { get; set; }
        /// <summary>
        /// OntapConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fsx-s3accesspointattachment.html#cfn-fsx-s3accesspointattachment-ontapconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3AccessPointOntapConfiguration
        /// </summary>
        public Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointOntapConfiguration OntapConfiguration { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace S3AccessPointAttachmentTypes
    {
        public class FileSystemGID : Humidifier.Base.BaseSubResource, IHaveGid
        {
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-filesystemgid.html#cfn-fsx-s3accesspointattachment-filesystemgid-gid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Gid { get; set; }
        }

        public class OntapFileSystemIdentity : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-ontapfilesystemidentity.html#cfn-fsx-s3accesspointattachment-ontapfilesystemidentity-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// UnixUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-ontapfilesystemidentity.html#cfn-fsx-s3accesspointattachment-ontapfilesystemidentity-unixuser
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OntapUnixFileSystemUser
            /// </summary>
            public Humidifier.FSx.S3AccessPointAttachmentTypes.OntapUnixFileSystemUser UnixUser { get; set; }
            /// <summary>
            /// WindowsUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-ontapfilesystemidentity.html#cfn-fsx-s3accesspointattachment-ontapfilesystemidentity-windowsuser
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OntapWindowsFileSystemUser
            /// </summary>
            public Humidifier.FSx.S3AccessPointAttachmentTypes.OntapWindowsFileSystemUser WindowsUser { get; set; }
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
            public dynamic Name { get; set; }
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
            public dynamic Name { get; set; }
        }

        public class OpenZFSFileSystemIdentity : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsfilesystemidentity.html#cfn-fsx-s3accesspointattachment-openzfsfilesystemidentity-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// PosixUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsfilesystemidentity.html#cfn-fsx-s3accesspointattachment-openzfsfilesystemidentity-posixuser
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OpenZFSPosixFileSystemUser
            /// </summary>
            public Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSPosixFileSystemUser PosixUser { get; set; }
        }

        public class OpenZFSPosixFileSystemUser : Humidifier.Base.BaseSubResource, IHaveGid, IHaveUid
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsposixfilesystemuser.html#cfn-fsx-s3accesspointattachment-openzfsposixfilesystemuser-uid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Uid { get; set; }
            /// <summary>
            /// SecondaryGids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsposixfilesystemuser.html#cfn-fsx-s3accesspointattachment-openzfsposixfilesystemuser-secondarygids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: FileSystemGID
            /// </summary>
            public List<Humidifier.FSx.S3AccessPointAttachmentTypes.FileSystemGID> SecondaryGids { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-openzfsposixfilesystemuser.html#cfn-fsx-s3accesspointattachment-openzfsposixfilesystemuser-gid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Gid { get; set; }
        }

        public class S3AccessPoint : Humidifier.Base.BaseSubResource, IHavePolicy, IHaveResourceARN, IHaveAlias
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspoint.html#cfn-fsx-s3accesspointattachment-s3accesspoint-policy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Policy { get; set; }
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspoint.html#cfn-fsx-s3accesspointattachment-s3accesspoint-resourcearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceARN { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspoint.html#cfn-fsx-s3accesspointattachment-s3accesspoint-alias
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Alias { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspoint.html#cfn-fsx-s3accesspointattachment-s3accesspoint-vpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3AccessPointVpcConfiguration
            /// </summary>
            public Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration VpcConfiguration { get; set; }
        }

        public class S3AccessPointOntapConfiguration : Humidifier.Base.BaseSubResource, IHaveVolumeId
        {
            /// <summary>
            /// VolumeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointontapconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointontapconfiguration-volumeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeId { get; set; }
            /// <summary>
            /// FileSystemIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointontapconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointontapconfiguration-filesystemidentity
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OntapFileSystemIdentity
            /// </summary>
            public Humidifier.FSx.S3AccessPointAttachmentTypes.OntapFileSystemIdentity FileSystemIdentity { get; set; }
        }

        public class S3AccessPointOpenZFSConfiguration : Humidifier.Base.BaseSubResource, IHaveVolumeId
        {
            /// <summary>
            /// VolumeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointopenzfsconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointopenzfsconfiguration-volumeid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeId { get; set; }
            /// <summary>
            /// FileSystemIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-fsx-s3accesspointattachment-s3accesspointopenzfsconfiguration.html#cfn-fsx-s3accesspointattachment-s3accesspointopenzfsconfiguration-filesystemidentity
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OpenZFSFileSystemIdentity
            /// </summary>
            public Humidifier.FSx.S3AccessPointAttachmentTypes.OpenZFSFileSystemIdentity FileSystemIdentity { get; set; }
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
            public dynamic VpcId { get; set; }
        }
    }
}