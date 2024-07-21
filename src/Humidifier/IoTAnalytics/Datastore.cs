namespace Humidifier.IoTAnalytics
{
    using System.Collections.Generic;
    using DatastoreTypes;

    public class Datastore : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoTAnalytics::Datastore";
            }
        }

        /// <summary>
        /// DatastoreStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorestorage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DatastoreStorage
        /// </summary>
        public DatastoreStorage DatastoreStorage { get; set; }
        /// <summary>
        /// FileFormatConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-fileformatconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FileFormatConfiguration
        /// </summary>
        public FileFormatConfiguration FileFormatConfiguration { get; set; }
        /// <summary>
        /// DatastorePartitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorepartitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DatastorePartitions
        /// </summary>
        public DatastorePartitions DatastorePartitions { get; set; }
        /// <summary>
        /// DatastoreName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatastoreName { get; set; }
        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetentionPeriod
        /// </summary>
        public RetentionPeriod RetentionPeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace DatastoreTypes
    {
        public class Column
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-column.html#cfn-iotanalytics-datastore-column-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-column.html#cfn-iotanalytics-datastore-column-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CustomerManagedS3
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3.html#cfn-iotanalytics-datastore-customermanageds3-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3.html#cfn-iotanalytics-datastore-customermanageds3-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3.html#cfn-iotanalytics-datastore-customermanageds3-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPrefix { get; set; }
        }

        public class CustomerManagedS3Storage
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3storage.html#cfn-iotanalytics-datastore-customermanageds3storage-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3storage.html#cfn-iotanalytics-datastore-customermanageds3storage-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPrefix { get; set; }
        }

        public class DatastorePartition
        {
            /// <summary>
            /// Partition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartition.html#cfn-iotanalytics-datastore-datastorepartition-partition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Partition
            /// </summary>
            public Partition Partition { get; set; }
            /// <summary>
            /// TimestampPartition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartition.html#cfn-iotanalytics-datastore-datastorepartition-timestamppartition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimestampPartition
            /// </summary>
            public TimestampPartition TimestampPartition { get; set; }
        }

        public class DatastorePartitions
        {
            /// <summary>
            /// Partitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartitions.html#cfn-iotanalytics-datastore-datastorepartitions-partitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DatastorePartition
            /// </summary>
            public List<DatastorePartition> Partitions { get; set; }
        }

        public class DatastoreStorage
        {
            /// <summary>
            /// CustomerManagedS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorestorage.html#cfn-iotanalytics-datastore-datastorestorage-customermanageds3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedS3
            /// </summary>
            public CustomerManagedS3 CustomerManagedS3 { get; set; }
            /// <summary>
            /// ServiceManagedS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorestorage.html#cfn-iotanalytics-datastore-datastorestorage-servicemanageds3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ServiceManagedS3 { get; set; }
            /// <summary>
            /// IotSiteWiseMultiLayerStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorestorage.html#cfn-iotanalytics-datastore-datastorestorage-iotsitewisemultilayerstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotSiteWiseMultiLayerStorage
            /// </summary>
            public IotSiteWiseMultiLayerStorage IotSiteWiseMultiLayerStorage { get; set; }
        }

        public class FileFormatConfiguration
        {
            /// <summary>
            /// ParquetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-fileformatconfiguration.html#cfn-iotanalytics-datastore-fileformatconfiguration-parquetconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParquetConfiguration
            /// </summary>
            public ParquetConfiguration ParquetConfiguration { get; set; }
            /// <summary>
            /// JsonConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-fileformatconfiguration.html#cfn-iotanalytics-datastore-fileformatconfiguration-jsonconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic JsonConfiguration { get; set; }
        }

        public class IotSiteWiseMultiLayerStorage
        {
            /// <summary>
            /// CustomerManagedS3Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-iotsitewisemultilayerstorage.html#cfn-iotanalytics-datastore-iotsitewisemultilayerstorage-customermanageds3storage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedS3Storage
            /// </summary>
            public CustomerManagedS3Storage CustomerManagedS3Storage { get; set; }
        }

        public class ParquetConfiguration
        {
            /// <summary>
            /// SchemaDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-parquetconfiguration.html#cfn-iotanalytics-datastore-parquetconfiguration-schemadefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public SchemaDefinition SchemaDefinition { get; set; }
        }

        public class Partition
        {
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-partition.html#cfn-iotanalytics-datastore-partition-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
        }

        public class RetentionPeriod
        {
            /// <summary>
            /// NumberOfDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-retentionperiod.html#cfn-iotanalytics-datastore-retentionperiod-numberofdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfDays { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-retentionperiod.html#cfn-iotanalytics-datastore-retentionperiod-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Unlimited { get; set; }
        }

        public class SchemaDefinition
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-schemadefinition.html#cfn-iotanalytics-datastore-schemadefinition-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Column
            /// </summary>
            public List<Column> Columns { get; set; }
        }

        public class TimestampPartition
        {
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-timestamppartition.html#cfn-iotanalytics-datastore-timestamppartition-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName { get; set; }
            /// <summary>
            /// TimestampFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-timestamppartition.html#cfn-iotanalytics-datastore-timestamppartition-timestampformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimestampFormat { get; set; }
        }
    }
}