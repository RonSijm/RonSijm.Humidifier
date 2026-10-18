namespace Humidifier.S3Files
{
    using global::System.Collections.Generic;
    using AccessPointTypes;

    public class AccessPoint : Humidifier.Base.BaseResource, IHaveFileSystemId, IHaveS3FilesAccessPointTypesRootDirectoryRootDirectory, IHaveClientToken, IHaveS3FilesAccessPointTypesPosixUserPosixUser, IHaveListOfS3FilesAccessPointTypesAccessPointTagTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string OwnerId =  "OwnerId" ;
            public static string AccessPointArn =  "AccessPointArn" ;
            public static string AccessPointId =  "AccessPointId" ;
        }

        public override string AWSTypeName { get => AWS.S3Files.AccessPoint; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileSystemId { get; set; }
        /// <summary>
        /// RootDirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-rootdirectory
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RootDirectory
        /// </summary>
        public Union<Humidifier.S3Files.AccessPointTypes.RootDirectory, BaseFunction>? RootDirectory { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// PosixUser
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-posixuser
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PosixUser
        /// </summary>
        public Union<Humidifier.S3Files.AccessPointTypes.PosixUser, BaseFunction>? PosixUser { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessPointTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.S3Files.AccessPointTypes.AccessPointTag>, IReadOnlyList<Union<Humidifier.S3Files.AccessPointTypes.AccessPointTag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AccessPointTypes
    {
        public class AccessPointTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-accesspointtag.html#cfn-s3files-accesspoint-accesspointtag-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-accesspointtag.html#cfn-s3files-accesspoint-accesspointtag-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class CreationPermissions : Humidifier.Base.BaseSubResource, IHaveOwnerGid, IHaveOwnerUid, IHavePermissions
        {
            /// <summary>
            /// OwnerGid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-creationpermissions.html#cfn-s3files-accesspoint-creationpermissions-ownergid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerGid { get; set; }
            /// <summary>
            /// OwnerUid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-creationpermissions.html#cfn-s3files-accesspoint-creationpermissions-owneruid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerUid { get; set; }
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-creationpermissions.html#cfn-s3files-accesspoint-creationpermissions-permissions
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permissions { get; set; }
        }

        public class PosixUser : Humidifier.Base.BaseSubResource, IHaveUid, IHaveStringListOfSecondaryGids, IHaveGid
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-posixuser.html#cfn-s3files-accesspoint-posixuser-uid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uid { get; set; }
            /// <summary>
            /// SecondaryGids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-posixuser.html#cfn-s3files-accesspoint-posixuser-secondarygids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecondaryGids { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-posixuser.html#cfn-s3files-accesspoint-posixuser-gid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gid { get; set; }
        }

        public class RootDirectory : Humidifier.Base.BaseSubResource, IHavePath, IHaveS3FilesAccessPointTypesCreationPermissionsCreationPermissions
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-rootdirectory.html#cfn-s3files-accesspoint-rootdirectory-path
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// CreationPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-rootdirectory.html#cfn-s3files-accesspoint-rootdirectory-creationpermissions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreationPermissions
            /// </summary>
            public Union<Humidifier.S3Files.AccessPointTypes.CreationPermissions, BaseFunction>? CreationPermissions { get; set; }
        }
    }
}