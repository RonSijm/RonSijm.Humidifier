namespace Humidifier.EFS
{
    using global::System.Collections.Generic;
    using AccessPointTypes;

    public class AccessPoint : Humidifier.Base.BaseResource, IHaveFileSystemId, IHaveEFSAccessPointTypesRootDirectoryRootDirectory, IHaveClientToken, IHaveListOfEFSAccessPointTypesAccessPointTagAccessPointTags, IHaveEFSAccessPointTypesPosixUserPosixUser
    {
        public class Attributes
        {
            public static string AccessPointId =  "AccessPointId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EFS.AccessPoint; }

        /// <summary>
        /// FileSystemId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-accesspoint.html#cfn-efs-accesspoint-filesystemid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FileSystemId { get; set; }
        /// <summary>
        /// RootDirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-accesspoint.html#cfn-efs-accesspoint-rootdirectory
        /// Required: False
        /// UpdateType: Immutable
        /// Type: RootDirectory
        /// </summary>
        public Union<Humidifier.EFS.AccessPointTypes.RootDirectory, BaseFunction>? RootDirectory { get; set; }
        /// <summary>
        /// ClientToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-accesspoint.html#cfn-efs-accesspoint-clienttoken
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientToken { get; set; }
        /// <summary>
        /// AccessPointTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-accesspoint.html#cfn-efs-accesspoint-accesspointtags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessPointTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EFS.AccessPointTypes.AccessPointTag>, IReadOnlyList<Union<Humidifier.EFS.AccessPointTypes.AccessPointTag, BaseFunction>>, BaseFunction>? AccessPointTags { get; set; }
        /// <summary>
        /// PosixUser
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-efs-accesspoint.html#cfn-efs-accesspoint-posixuser
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PosixUser
        /// </summary>
        public Union<Humidifier.EFS.AccessPointTypes.PosixUser, BaseFunction>? PosixUser { get; set; }
    }

    namespace AccessPointTypes
    {
        public class AccessPointTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-accesspointtag.html#cfn-efs-accesspoint-accesspointtag-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-accesspointtag.html#cfn-efs-accesspoint-accesspointtag-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class CreationInfo : Humidifier.Base.BaseSubResource, IHaveOwnerGid, IHaveOwnerUid, IHavePermissions
        {
            /// <summary>
            /// OwnerGid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-creationinfo.html#cfn-efs-accesspoint-creationinfo-ownergid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerGid { get; set; }
            /// <summary>
            /// OwnerUid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-creationinfo.html#cfn-efs-accesspoint-creationinfo-owneruid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerUid { get; set; }
            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-creationinfo.html#cfn-efs-accesspoint-creationinfo-permissions
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-posixuser.html#cfn-efs-accesspoint-posixuser-uid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Uid { get; set; }
            /// <summary>
            /// SecondaryGids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-posixuser.html#cfn-efs-accesspoint-posixuser-secondarygids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecondaryGids { get; set; }
            /// <summary>
            /// Gid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-posixuser.html#cfn-efs-accesspoint-posixuser-gid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Gid { get; set; }
        }

        public class RootDirectory : Humidifier.Base.BaseSubResource, IHavePath, IHaveEFSAccessPointTypesCreationInfoCreationInfo
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-rootdirectory.html#cfn-efs-accesspoint-rootdirectory-path
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
            /// <summary>
            /// CreationInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-efs-accesspoint-rootdirectory.html#cfn-efs-accesspoint-rootdirectory-creationinfo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CreationInfo
            /// </summary>
            public Union<Humidifier.EFS.AccessPointTypes.CreationInfo, BaseFunction>? CreationInfo { get; set; }
        }
    }
}