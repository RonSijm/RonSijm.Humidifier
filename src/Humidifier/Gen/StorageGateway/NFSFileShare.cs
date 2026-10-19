namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;
    using NFSFileShareTypes;

    public class NFSFileShare : Humidifier.Base.BaseResource, IHaveTags, IHaveRole, IHaveEncryptionType, IHaveReadOnly, IHaveBucketRegion
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
        public dynamic ReadOnly { get; set; }
        /// <summary>
        /// GuessMIMETypeEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-guessmimetypeenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic GuessMIMETypeEnabled { get; set; }
        /// <summary>
        /// EncryptionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-encryptiontype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionType { get; set; }
        /// <summary>
        /// ObjectACL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-objectacl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ObjectACL { get; set; }
        /// <summary>
        /// FileShareName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-filesharename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FileShareName { get; set; }
        /// <summary>
        /// DefaultStorageClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-defaultstorageclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultStorageClass { get; set; }
        /// <summary>
        /// ClientList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-clientlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ClientList { get; set; }
        /// <summary>
        /// Squash
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-squash
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Squash { get; set; }

        /// <summary>
        /// GatewayARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-gatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GatewayARN { get; set; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-role
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Role { get; set; }
        /// <summary>
        /// KMSKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-kmskey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KMSKey { get; set; }
        /// <summary>
        /// AuditDestinationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-auditdestinationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuditDestinationARN { get; set; }
        /// <summary>
        /// KMSEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-kmsencrypted
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic KMSEncrypted { get; set; }
        /// <summary>
        /// BucketRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-bucketregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BucketRegion { get; set; }
        /// <summary>
        /// RequesterPays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-requesterpays
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RequesterPays { get; set; }
        /// <summary>
        /// NFSFileShareDefaults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NFSFileShareDefaults
        /// </summary>
        public Humidifier.StorageGateway.NFSFileShareTypes.NFSFileShareDefaults NFSFileShareDefaults { get; set; }
        /// <summary>
        /// VPCEndpointDNSName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-vpcendpointdnsname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VPCEndpointDNSName { get; set; }

        /// <summary>
        /// LocationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-locationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocationARN { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// NotificationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-notificationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NotificationPolicy { get; set; }
        /// <summary>
        /// CacheAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-nfsfileshare.html#cfn-storagegateway-nfsfileshare-cacheattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CacheAttributes
        /// </summary>
        public Humidifier.StorageGateway.NFSFileShareTypes.CacheAttributes CacheAttributes { get; set; }
    }

    namespace NFSFileShareTypes
    {
        public class CacheAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CacheStaleTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-cacheattributes.html#cfn-storagegateway-nfsfileshare-cacheattributes-cachestaletimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CacheStaleTimeoutInSeconds { get; set; }
        }

        public class NFSFileShareDefaults : Humidifier.Base.BaseSubResource, IHaveGroupId
        {
            /// <summary>
            /// FileMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-nfsfilesharedefaults.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults-filemode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileMode { get; set; }
            /// <summary>
            /// DirectoryMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-nfsfilesharedefaults.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults-directorymode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DirectoryMode { get; set; }
            /// <summary>
            /// OwnerId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-nfsfilesharedefaults.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults-ownerid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OwnerId { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-nfsfileshare-nfsfilesharedefaults.html#cfn-storagegateway-nfsfileshare-nfsfilesharedefaults-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic GroupId { get; set; }
        }
    }
}