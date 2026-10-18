namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using LocationFSxOpenZFSTypes;

    public class LocationFSxOpenZFS : Humidifier.Base.BaseResource, IHaveTags, IHaveSubdirectory, IHaveFsxFilesystemArn, IHaveProtocolProtocol, IHaveStringListOfSecurityGroupArns
    {
        public class Attributes
        {
            public static string LocationUri =  "LocationUri" ;
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.LocationFSxOpenZFS; }
        /// <summary>
        /// Subdirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxopenzfs.html#cfn-datasync-locationfsxopenzfs-subdirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subdirectory { get; set; }
        /// <summary>
        /// FsxFilesystemArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxopenzfs.html#cfn-datasync-locationfsxopenzfs-fsxfilesystemarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FsxFilesystemArn { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxopenzfs.html#cfn-datasync-locationfsxopenzfs-protocol
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Protocol
        /// </summary>
        [Required]
        public Union<Humidifier.Transfer.Protocol, BaseFunction>? Protocol { get; set; }

        /// <summary>
        /// SecurityGroupArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxopenzfs.html#cfn-datasync-locationfsxopenzfs-securitygrouparns
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupArns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationfsxopenzfs.html#cfn-datasync-locationfsxopenzfs-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LocationFSxOpenZFSTypes
    {
        public class MountOptions : Humidifier.Base.BaseSubResource, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxopenzfs-mountoptions.html#cfn-datasync-locationfsxopenzfs-mountoptions-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }

        public class NFS : Humidifier.Base.BaseSubResource, IHaveDataSyncLocationFSxOpenZFSTypesMountOptionsMountOptions
        {
            /// <summary>
            /// MountOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxopenzfs-nfs.html#cfn-datasync-locationfsxopenzfs-nfs-mountoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MountOptions
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions, BaseFunction>? MountOptions { get; set; }
        }

        public class Protocol : Humidifier.Base.BaseSubResource, IHaveDataSyncLocationFSxOpenZFSTypesNFSNFS
        {
            /// <summary>
            /// NFS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationfsxopenzfs-protocol.html#cfn-datasync-locationfsxopenzfs-protocol-nfs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NFS
            /// </summary>
            public Union<Humidifier.DataSync.LocationFSxOpenZFSTypes.NFS, BaseFunction>? NFS { get; set; }
        }
    }
}