namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;
    using SMBFileShareTypes;

    public class SMBFileShare : Humidifier.Base.BaseResource, IHaveTags, IHaveRole, IHaveEncryptionType, IHaveReadOnly, IHaveAuthentication, IHaveBucketRegion
    {
        public class Attributes
        {
            public static string Path =  "Path" ;
            public static string FileShareId =  "FileShareId" ;
            public static string FileShareARN =  "FileShareARN" ;
            public static string FileShareStatus =  "FileShareStatus" ;
        }

        public override string AWSTypeName { get => AWS.StorageGateway.SMBFileShare; }
        /// <summary>
        /// GuessMIMETypeEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-guessmimetypeenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic GuessMIMETypeEnabled { get; set; }
        /// <summary>
        /// ObjectACL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-objectacl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ObjectACL { get; set; }
        /// <summary>
        /// AccessBasedEnumeration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-accessbasedenumeration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AccessBasedEnumeration { get; set; }
        /// <summary>
        /// FileShareName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-filesharename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FileShareName { get; set; }
        /// <summary>
        /// DefaultStorageClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-defaultstorageclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultStorageClass { get; set; }
        /// <summary>
        /// SMBACLEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-smbaclenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SMBACLEnabled { get; set; }

        /// <summary>
        /// GatewayARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-gatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GatewayARN { get; set; }
        /// <summary>
        /// KMSEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-kmsencrypted
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic KMSEncrypted { get; set; }
        /// <summary>
        /// RequesterPays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-requesterpays
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RequesterPays { get; set; }
        /// <summary>
        /// CaseSensitivity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-casesensitivity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CaseSensitivity { get; set; }
        /// <summary>
        /// ValidUserList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-validuserlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ValidUserList { get; set; }

        /// <summary>
        /// LocationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-locationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocationARN { get; set; }
        /// <summary>
        /// AdminUserList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-adminuserlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AdminUserList { get; set; }
        /// <summary>
        /// InvalidUserList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-invaliduserlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic InvalidUserList { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// CacheAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-cacheattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CacheAttributes
        /// </summary>
        public Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes CacheAttributes { get; set; }
        /// <summary>
        /// ReadOnly
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-readonly
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ReadOnly { get; set; }
        /// <summary>
        /// EncryptionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-encryptiontype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionType { get; set; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-role
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Role { get; set; }
        /// <summary>
        /// KMSKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-kmskey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KMSKey { get; set; }
        /// <summary>
        /// AuditDestinationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-auditdestinationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuditDestinationARN { get; set; }
        /// <summary>
        /// BucketRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-bucketregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BucketRegion { get; set; }
        /// <summary>
        /// OplocksEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-oplocksenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic OplocksEnabled { get; set; }
        /// <summary>
        /// Authentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-authentication
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Authentication { get; set; }
        /// <summary>
        /// VPCEndpointDNSName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-vpcendpointdnsname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VPCEndpointDNSName { get; set; }
        /// <summary>
        /// NotificationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-notificationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NotificationPolicy { get; set; }
    }

    namespace SMBFileShareTypes
    {
        public class CacheAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CacheStaleTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-smbfileshare-cacheattributes.html#cfn-storagegateway-smbfileshare-cacheattributes-cachestaletimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CacheStaleTimeoutInSeconds { get; set; }
        }
    }
}