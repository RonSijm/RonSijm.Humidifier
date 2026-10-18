namespace Humidifier.S3Tables
{
    using global::System.Collections.Generic;
    using TableBucketTypes;

    public class TableBucket : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTableBucketName, IHaveS3TablesTableBucketTypesStorageClassConfigurationStorageClassConfiguration, IHaveS3TablesTableBucketTypesMetricsConfigurationMetricsConfiguration, IHaveS3TablesTableBucketTypesEncryptionConfigurationEncryptionConfiguration, IHaveS3TablesTableBucketTypesUnreferencedFileRemovalUnreferencedFileRemoval, IHaveS3TablesTableBucketTypesReplicationConfigurationReplicationConfiguration
    {
        public class Attributes
        {
            public static string TableBucketARN =  "TableBucketARN" ;
        }

        public override string AWSTypeName { get => AWS.S3Tables.TableBucket; }
        public Union<string, BaseFunction>? TableBucketName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// StorageClassConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucket.html#cfn-s3tables-tablebucket-storageclassconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StorageClassConfiguration
        /// </summary>
        public Union<Humidifier.S3Tables.TableBucketTypes.StorageClassConfiguration, BaseFunction>? StorageClassConfiguration { get; set; }
        /// <summary>
        /// MetricsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucket.html#cfn-s3tables-tablebucket-metricsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetricsConfiguration
        /// </summary>
        public Union<Humidifier.S3Tables.TableBucketTypes.MetricsConfiguration, BaseFunction>? MetricsConfiguration { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucket.html#cfn-s3tables-tablebucket-encryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.S3Tables.TableBucketTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// UnreferencedFileRemoval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucket.html#cfn-s3tables-tablebucket-unreferencedfileremoval
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UnreferencedFileRemoval
        /// </summary>
        public Union<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval, BaseFunction>? UnreferencedFileRemoval { get; set; }
        /// <summary>
        /// ReplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucket.html#cfn-s3tables-tablebucket-replicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationConfiguration
        /// </summary>
        public Union<Humidifier.S3Tables.TableBucketTypes.ReplicationConfiguration, BaseFunction>? ReplicationConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-tablebucket.html#cfn-s3tables-tablebucket-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TableBucketTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKMSKeyArn, IHaveSSEAlgorithm
        {
            /// <summary>
            /// KMSKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-encryptionconfiguration.html#cfn-s3tables-tablebucket-encryptionconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KMSKeyArn { get; set; }
            /// <summary>
            /// SSEAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-encryptionconfiguration.html#cfn-s3tables-tablebucket-encryptionconfiguration-ssealgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SSEAlgorithm { get; set; }
        }

        public class MetricsConfiguration : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-metricsconfiguration.html#cfn-s3tables-tablebucket-metricsconfiguration-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }

        public class ReplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveRole, IHaveListOfS3TablesTableBucketTypesReplicationRuleRules
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-replicationconfiguration.html#cfn-s3tables-tablebucket-replicationconfiguration-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-replicationconfiguration.html#cfn-s3tables-tablebucket-replicationconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Tables.TableBucketTypes.ReplicationRule>, IReadOnlyList<Union<Humidifier.S3Tables.TableBucketTypes.ReplicationRule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        }

        public class ReplicationDestination : Humidifier.Base.BaseSubResource, IHaveDestinationTableBucketARN
        {
            /// <summary>
            /// DestinationTableBucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-replicationdestination.html#cfn-s3tables-tablebucket-replicationdestination-destinationtablebucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationTableBucketARN { get; set; }
        }

        public class ReplicationRule : Humidifier.Base.BaseSubResource, IHaveListOfS3TablesTableBucketTypesReplicationDestinationDestinations
        {
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-replicationrule.html#cfn-s3tables-tablebucket-replicationrule-destinations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationDestination
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Tables.TableBucketTypes.ReplicationDestination>, IReadOnlyList<Union<Humidifier.S3Tables.TableBucketTypes.ReplicationDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        }

        public class StorageClassConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageClass
        {
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-storageclassconfiguration.html#cfn-s3tables-tablebucket-storageclassconfiguration-storageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
        }

        public class UnreferencedFileRemoval : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveNoncurrentDays_Integer, IHaveUnreferencedDays_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-unreferencedfileremoval.html#cfn-s3tables-tablebucket-unreferencedfileremoval-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// NoncurrentDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-unreferencedfileremoval.html#cfn-s3tables-tablebucket-unreferencedfileremoval-noncurrentdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NoncurrentDays { get; set; }
            /// <summary>
            /// UnreferencedDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-tablebucket-unreferencedfileremoval.html#cfn-s3tables-tablebucket-unreferencedfileremoval-unreferenceddays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnreferencedDays { get; set; }
        }
    }
}