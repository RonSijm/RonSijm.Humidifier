namespace Humidifier.Connect
{
    using System.Collections.Generic;
    using InstanceStorageConfigTypes;

    public class InstanceStorageConfig : Humidifier.Base.BaseResource, IHaveInstanceArn, IHaveResourceType, IHaveStorageType
    {
        public class Attributes
        {
            public static string AssociationId =  "AssociationId" ;
        }

        public override string AWSTypeName { get => AWS.Connect.InstanceStorageConfig; }
        /// <summary>
        /// KinesisStreamConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instancestorageconfig.html#cfn-connect-instancestorageconfig-kinesisstreamconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KinesisStreamConfig
        /// </summary>
        public Humidifier.Connect.InstanceStorageConfigTypes.KinesisStreamConfig KinesisStreamConfig { get; set; }
        /// <summary>
        /// S3Config
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instancestorageconfig.html#cfn-connect-instancestorageconfig-s3config
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3Config
        /// </summary>
        public Humidifier.Connect.InstanceStorageConfigTypes.S3Config S3Config { get; set; }

        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instancestorageconfig.html#cfn-connect-instancestorageconfig-storagetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StorageType { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instancestorageconfig.html#cfn-connect-instancestorageconfig-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }

        /// <summary>
        /// ResourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instancestorageconfig.html#cfn-connect-instancestorageconfig-resourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceType { get; set; }
        /// <summary>
        /// KinesisVideoStreamConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instancestorageconfig.html#cfn-connect-instancestorageconfig-kinesisvideostreamconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KinesisVideoStreamConfig
        /// </summary>
        public Humidifier.Connect.InstanceStorageConfigTypes.KinesisVideoStreamConfig KinesisVideoStreamConfig { get; set; }
        /// <summary>
        /// KinesisFirehoseConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-instancestorageconfig.html#cfn-connect-instancestorageconfig-kinesisfirehoseconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KinesisFirehoseConfig
        /// </summary>
        public Humidifier.Connect.InstanceStorageConfigTypes.KinesisFirehoseConfig KinesisFirehoseConfig { get; set; }
    }

    namespace InstanceStorageConfigTypes
    {
        public class EncryptionConfig : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveKeyId
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-encryptionconfig.html#cfn-connect-instancestorageconfig-encryptionconfig-encryptiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EncryptionType { get; set; }
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-encryptionconfig.html#cfn-connect-instancestorageconfig-encryptionconfig-keyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyId { get; set; }
        }

        public class KinesisFirehoseConfig : Humidifier.Base.BaseSubResource, IHaveFirehoseArn
        {
            /// <summary>
            /// FirehoseArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-kinesisfirehoseconfig.html#cfn-connect-instancestorageconfig-kinesisfirehoseconfig-firehosearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FirehoseArn { get; set; }
        }

        public class KinesisStreamConfig : Humidifier.Base.BaseSubResource, IHaveStreamArn
        {
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-kinesisstreamconfig.html#cfn-connect-instancestorageconfig-kinesisstreamconfig-streamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamArn { get; set; }
        }

        public class KinesisVideoStreamConfig : Humidifier.Base.BaseSubResource, IHavePrefix, IHaveRetentionPeriodHours, IHaveConnectInstanceStorageConfigTypesEncryptionConfigEncryptionConfig
        {
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-kinesisvideostreamconfig.html#cfn-connect-instancestorageconfig-kinesisvideostreamconfig-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix { get; set; }
            /// <summary>
            /// RetentionPeriodHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-kinesisvideostreamconfig.html#cfn-connect-instancestorageconfig-kinesisvideostreamconfig-retentionperiodhours
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RetentionPeriodHours { get; set; }
            /// <summary>
            /// EncryptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-kinesisvideostreamconfig.html#cfn-connect-instancestorageconfig-kinesisvideostreamconfig-encryptionconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EncryptionConfig
            /// </summary>
            public Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig EncryptionConfig { get; set; }
        }

        public class S3Config : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveBucketPrefix, IHaveConnectInstanceStorageConfigTypesEncryptionConfigEncryptionConfig
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-s3config.html#cfn-connect-instancestorageconfig-s3config-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-s3config.html#cfn-connect-instancestorageconfig-s3config-bucketprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketPrefix { get; set; }
            /// <summary>
            /// EncryptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-instancestorageconfig-s3config.html#cfn-connect-instancestorageconfig-s3config-encryptionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionConfig
            /// </summary>
            public Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig EncryptionConfig { get; set; }
        }
    }
}