namespace Humidifier.KinesisAnalyticsV2
{
    using global::System.Collections.Generic;
    using SnapshotTypes;

    public class Snapshot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveApplicationName, IHaveSnapshotName, IHaveDescription
    {
        public class Attributes
        {
            public static string RuntimeEnvironment =  "RuntimeEnvironment" ;
            public static string SnapshotArn =  "SnapshotArn" ;
            public static string SnapshotSizeInBytes =  "SnapshotSizeInBytes" ;
            public static string SnapshotInitiatorOperation =  "SnapshotInitiatorOperation" ;
            public static string SnapshotSourceDescription =  "SnapshotSourceDescription" ;
            public static string SnapshotStatus =  "SnapshotStatus" ;
            public static string SnapshotInitiator =  "SnapshotInitiator" ;
            public static string SnapshotCreationTimestamp =  "SnapshotCreationTimestamp" ;
        }

        public override string AWSTypeName { get => AWS.KinesisAnalyticsV2.Snapshot; }
        /// <summary>
        /// ImportSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-snapshot.html#cfn-kinesisanalyticsv2-snapshot-importsourceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ImportSourceConfiguration
        /// </summary>
        public Humidifier.KinesisAnalyticsV2.SnapshotTypes.ImportSourceConfiguration ImportSourceConfiguration { get; set; }
        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-snapshot.html#cfn-kinesisanalyticsv2-snapshot-applicationname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationName { get; set; }
        /// <summary>
        /// SnapshotFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-snapshot.html#cfn-kinesisanalyticsv2-snapshot-snapshotformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnapshotFormat { get; set; }
        /// <summary>
        /// SnapshotEncryptionConfigurationDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-snapshot.html#cfn-kinesisanalyticsv2-snapshot-snapshotencryptionconfigurationdescription
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SnapshotEncryptionConfigurationDescription
        /// </summary>
        public Humidifier.KinesisAnalyticsV2.SnapshotTypes.SnapshotEncryptionConfigurationDescription SnapshotEncryptionConfigurationDescription { get; set; }
        /// <summary>
        /// SnapshotDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-snapshot.html#cfn-kinesisanalyticsv2-snapshot-snapshotdescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnapshotDescription { get; set; }

        [Ignore]
        public dynamic Description { get => SnapshotDescription; set => SnapshotDescription = value; }
        public dynamic SnapshotName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-snapshot.html#cfn-kinesisanalyticsv2-snapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace SnapshotTypes
    {
        public class ImportSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceType
        {
            /// <summary>
            /// ImportRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-importsourceconfiguration.html#cfn-kinesisanalyticsv2-snapshot-importsourceconfiguration-importrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImportRoleArn { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-importsourceconfiguration.html#cfn-kinesisanalyticsv2-snapshot-importsourceconfiguration-sourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
            /// <summary>
            /// SourceEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-importsourceconfiguration.html#cfn-kinesisanalyticsv2-snapshot-importsourceconfiguration-sourceencryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SnapshotEncryptionConfigurationDescription
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.SnapshotTypes.SnapshotEncryptionConfigurationDescription SourceEncryptionConfiguration { get; set; }
            /// <summary>
            /// SourceS3PrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-importsourceconfiguration.html#cfn-kinesisanalyticsv2-snapshot-importsourceconfiguration-sources3prefixlocation
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3PrefixLocation
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.SnapshotTypes.S3PrefixLocation SourceS3PrefixLocation { get; set; }
        }

        public class S3PrefixLocation : Humidifier.Base.BaseSubResource, IHaveBucketARN, IHaveKeyPrefix
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-s3prefixlocation.html#cfn-kinesisanalyticsv2-snapshot-s3prefixlocation-bucketarn
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketARN { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-s3prefixlocation.html#cfn-kinesisanalyticsv2-snapshot-s3prefixlocation-keyprefix
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPrefix { get; set; }
        }

        public class SnapshotEncryptionConfigurationDescription : Humidifier.Base.BaseSubResource, IHaveKeyType, IHaveKeyId
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-snapshotencryptionconfigurationdescription.html#cfn-kinesisanalyticsv2-snapshot-snapshotencryptionconfigurationdescription-keytype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType { get; set; }
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-snapshotencryptionconfigurationdescription.html#cfn-kinesisanalyticsv2-snapshot-snapshotencryptionconfigurationdescription-keyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyId { get; set; }
        }

        public class SnapshotSourceDescription : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceApplicationDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-snapshotsourcedescription.html#cfn-kinesisanalyticsv2-snapshot-snapshotsourcedescription-sourceapplicationdescription
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceApplicationDescription
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.SnapshotTypes.SourceApplicationDescription SourceApplicationDescription { get; set; }
            /// <summary>
            /// S3PrefixLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-snapshotsourcedescription.html#cfn-kinesisanalyticsv2-snapshot-snapshotsourcedescription-s3prefixlocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3PrefixLocation
            /// </summary>
            public Humidifier.KinesisAnalyticsV2.SnapshotTypes.S3PrefixLocation S3PrefixLocation { get; set; }
        }

        public class SourceApplicationDescription : Humidifier.Base.BaseSubResource, IHaveApplicationName
        {
            /// <summary>
            /// ApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-sourceapplicationdescription.html#cfn-kinesisanalyticsv2-snapshot-sourceapplicationdescription-applicationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationName { get; set; }
            /// <summary>
            /// ApplicationCreationTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-sourceapplicationdescription.html#cfn-kinesisanalyticsv2-snapshot-sourceapplicationdescription-applicationcreationtimestamp
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationCreationTimestamp { get; set; }
            /// <summary>
            /// ApplicationVersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-snapshot-sourceapplicationdescription.html#cfn-kinesisanalyticsv2-snapshot-sourceapplicationdescription-applicationversionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ApplicationVersionId { get; set; }
        }
    }
}