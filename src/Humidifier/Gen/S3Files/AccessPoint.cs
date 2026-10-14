namespace Humidifier.S3Files
{
    using global::System.Collections.Generic;
    using AccessPointTypes;

    public class AccessPoint : Humidifier.Base.BaseResource, IHaveFileSystemId, IHaveClientToken
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
        public dynamic FileSystemId { get; set; }
        /// <summary>
        /// RootDirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-rootdirectory
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RootDirectory
        /// </summary>
        public Humidifier.S3Files.AccessPointTypes.RootDirectory RootDirectory { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientToken { get; set; }
        /// <summary>
        /// PosixUser
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-posixuser
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PosixUser
        /// </summary>
        public Humidifier.S3Files.AccessPointTypes.PosixUser PosixUser { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3files-accesspoint.html#cfn-s3files-accesspoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessPointTag
        /// </summary>
        public List<Humidifier.S3Files.AccessPointTypes.AccessPointTag> Tags { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-accesspointtag.html#cfn-s3files-accesspoint-accesspointtag-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class CreationPermissions : Humidifier.Base.BaseSubResource, IHavePermissions
        {
            /// <summary>
            /// OwnerGid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-creationpermissions.html#cfn-s3files-accesspoint-creationpermissions-ownergid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OwnerGid { get; set; }
            /// <summary>
            /// OwnerUid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-creationpermissions.html#cfn-s3files-accesspoint-creationpermissions-owneruid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OwnerUid { get; set; }
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-creationpermissions.html#cfn-s3files-accesspoint-creationpermissions-permissions
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Permissions { get; set; }
        }

        public class PosixUser : Humidifier.Base.BaseSubResource, IHaveGid, IHaveUid
        {
            /// <summary>
            /// Uid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-posixuser.html#cfn-s3files-accesspoint-posixuser-uid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Uid { get; set; }
            /// <summary>
            /// SecondaryGids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-posixuser.html#cfn-s3files-accesspoint-posixuser-secondarygids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecondaryGids { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-posixuser.html#cfn-s3files-accesspoint-posixuser-gid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Gid { get; set; }
        }

        public class RootDirectory : Humidifier.Base.BaseSubResource, IHavePath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-rootdirectory.html#cfn-s3files-accesspoint-rootdirectory-path
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// CreationPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3files-accesspoint-rootdirectory.html#cfn-s3files-accesspoint-rootdirectory-creationpermissions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreationPermissions
            /// </summary>
            public Humidifier.S3Files.AccessPointTypes.CreationPermissions CreationPermissions { get; set; }
        }
    }
}