namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;
    using SMBFileShareTypes;

    public class SMBFileShare : Humidifier.Base.BaseResource, IHaveTags, IHaveGuessMIMETypeEnabled_Boolean, IHaveObjectACL, IHaveAccessBasedEnumeration_Boolean, IHaveFileShareName, IHaveDefaultStorageClass, IHaveSMBACLEnabled_Boolean, IHaveGatewayARN, IHaveKMSEncrypted_Boolean, IHaveRequesterPays_Boolean, IHaveCaseSensitivity, IHaveStringListOfValidUserList, IHaveLocationARN, IHaveStringListOfAdminUserList, IHaveStringListOfInvalidUserList, IHaveStorageGatewaySMBFileShareTypesCacheAttributesCacheAttributes, IHaveReadOnly_Boolean, IHaveEncryptionType, IHaveRole, IHaveKMSKey, IHaveAuditDestinationARN, IHaveBucketRegion, IHaveOplocksEnabled_Boolean, IHaveAuthentication, IHaveVPCEndpointDNSName, IHaveNotificationPolicy
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
        public Union<bool, BaseFunction>? GuessMIMETypeEnabled { get; set; }
        /// <summary>
        /// ObjectACL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-objectacl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ObjectACL { get; set; }
        /// <summary>
        /// AccessBasedEnumeration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-accessbasedenumeration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AccessBasedEnumeration { get; set; }
        /// <summary>
        /// FileShareName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-filesharename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FileShareName { get; set; }
        /// <summary>
        /// DefaultStorageClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-defaultstorageclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultStorageClass { get; set; }
        /// <summary>
        /// SMBACLEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-smbaclenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SMBACLEnabled { get; set; }

        /// <summary>
        /// GatewayARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-gatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GatewayARN { get; set; }
        /// <summary>
        /// KMSEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-kmsencrypted
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? KMSEncrypted { get; set; }
        /// <summary>
        /// RequesterPays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-requesterpays
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? RequesterPays { get; set; }
        /// <summary>
        /// CaseSensitivity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-casesensitivity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CaseSensitivity { get; set; }
        /// <summary>
        /// ValidUserList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-validuserlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ValidUserList { get; set; }

        /// <summary>
        /// LocationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-locationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LocationARN { get; set; }
        /// <summary>
        /// AdminUserList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-adminuserlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdminUserList { get; set; }
        /// <summary>
        /// InvalidUserList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-invaliduserlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InvalidUserList { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// CacheAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-cacheattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CacheAttributes
        /// </summary>
        public Union<Humidifier.StorageGateway.SMBFileShareTypes.CacheAttributes, BaseFunction>? CacheAttributes { get; set; }
        /// <summary>
        /// ReadOnly
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-readonly
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ReadOnly { get; set; }
        /// <summary>
        /// EncryptionType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-encryptiontype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionType { get; set; }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-role
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Role { get; set; }
        /// <summary>
        /// KMSKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-kmskey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSKey { get; set; }
        /// <summary>
        /// AuditDestinationARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-auditdestinationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuditDestinationARN { get; set; }
        /// <summary>
        /// BucketRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-bucketregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BucketRegion { get; set; }
        /// <summary>
        /// OplocksEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-oplocksenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? OplocksEnabled { get; set; }
        /// <summary>
        /// Authentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-authentication
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Authentication { get; set; }
        /// <summary>
        /// VPCEndpointDNSName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-vpcendpointdnsname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VPCEndpointDNSName { get; set; }
        /// <summary>
        /// NotificationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-smbfileshare.html#cfn-storagegateway-smbfileshare-notificationpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotificationPolicy { get; set; }
    }

    namespace SMBFileShareTypes
    {
        public class CacheAttributes : Humidifier.Base.BaseSubResource, IHaveCacheStaleTimeoutInSeconds_Integer
        {
            /// <summary>
            /// CacheStaleTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-smbfileshare-cacheattributes.html#cfn-storagegateway-smbfileshare-cacheattributes-cachestaletimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CacheStaleTimeoutInSeconds { get; set; }
        }
    }
}