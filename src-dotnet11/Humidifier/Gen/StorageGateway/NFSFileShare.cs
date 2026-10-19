namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;
    using NFSFileShareTypes;

    public class NFSFileShare : Humidifier.Base.BaseResource, IHaveTags, IHaveReadOnly_Boolean, IHaveGuessMIMETypeEnabled_Boolean, IHaveEncryptionType, IHaveObjectACL, IHaveFileShareName, IHaveDefaultStorageClass, IHaveStringListOfClientList, IHaveSquash, IHaveGatewayARN, IHaveRole, IHaveKMSKey, IHaveAuditDestinationARN, IHaveKMSEncrypted_Boolean, IHaveBucketRegion, IHaveRequesterPays_Boolean, IHaveStorageGatewayNFSFileShareTypesNFSFileShareDefaultsNFSFileShareDefaults, IHaveVPCEndpointDNSName, IHaveLocationARN, IHaveNotificationPolicy, IHaveStorageGatewayNFSFileShareTypesCacheAttributesCacheAttributes
    {
        public class Attributes
        {
            public static string Path =  "Path" ;
            public static string FileShareId =  "FileShareId" ;
            public static string FileShareARN =  "FileShareARN" ;
            public static string FileShareStatus =  "FileShareStatus" ;
        }

        public override string AWSTypeName { get => AWS.StorageGateway.NFSFileShare; }
        /// <summary>
        /// ReadOnly
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-readonly
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ReadOnly { get; set; }
        /// <summary>
        /// GuessMIMETypeEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-guessmimetypeenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? GuessMIMETypeEnabled { get; set; }
        /// <summary>
        /// EncryptionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-encryptiontype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionType { get; set; }
        /// <summary>
        /// ObjectACL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-objectacl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ObjectACL { get; set; }
        /// <summary>
        /// FileShareName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-filesharename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FileShareName { get; set; }
        /// <summary>
        /// DefaultStorageClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-defaultstorageclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultStorageClass { get; set; }
        /// <summary>
        /// ClientList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-clientlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ClientList { get; set; }
        /// <summary>
        /// Squash
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-squash
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Squash { get; set; }

        /// <summary>
        /// GatewayARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-gatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GatewayARN { get; set; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-role
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// KMSKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-kmskey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKey { get; set; }
        /// <summary>
        /// AuditDestinationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-auditdestinationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuditDestinationARN { get; set; }
        /// <summary>
        /// KMSEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-kmsencrypted
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? KMSEncrypted { get; set; }
        /// <summary>
        /// BucketRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-bucketregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketRegion { get; set; }
        /// <summary>
        /// RequesterPays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-requesterpays
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RequesterPays { get; set; }
        /// <summary>
        /// NFSFileShareDefaults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NFSFileShareDefaults
        /// </summary>
        public Union<Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults, BaseFunction>? NFSFileShareDefaults { get; set; }
        /// <summary>
        /// VPCEndpointDNSName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-vpcendpointdnsname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VPCEndpointDNSName { get; set; }

        /// <summary>
        /// LocationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-locationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LocationARN { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// NotificationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-notificationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotificationPolicy { get; set; }
        /// <summary>
        /// CacheAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-cacheattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CacheAttributes
        /// </summary>
        public Union<Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes, BaseFunction>? CacheAttributes { get; set; }
    }

    namespace NFSFileShareTypes
    {
        public class CacheAttributes : Humidifier.Base.BaseSubResource, IHaveCacheStaleTimeoutInSeconds_Integer
        {
            /// <summary>
            /// CacheStaleTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-cacheattributes.html#cfn-storagegateway-nfsfileshare-cacheattributes-cachestaletimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CacheStaleTimeoutInSeconds { get; set; }
        }

        public class NFSFileShareDefaults : Humidifier.Base.BaseSubResource, IHaveFileMode, IHaveDirectoryMode, IHaveOwnerId_Integer, IHaveGroupId_Integer
        {
            /// <summary>
            /// FileMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-nfsfilesharedefaults.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults-filemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FileMode { get; set; }
            /// <summary>
            /// DirectoryMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-nfsfilesharedefaults.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults-directorymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DirectoryMode { get; set; }
            /// <summary>
            /// OwnerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-nfsfilesharedefaults.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults-ownerid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OwnerId { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-nfsfilesharedefaults.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? GroupId { get; set; }
        }
    }
}