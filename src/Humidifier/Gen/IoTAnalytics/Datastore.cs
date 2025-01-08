namespace Humidifier.IoTAnalytics
{
    using System.Collections.Generic;
    using DatastoreTypes;

    public class Datastore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDatastoreName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.IoTAnalytics.Datastore; }
        /// <summary>
        /// DatastoreStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorestorage
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DatastoreStorage
        /// </summary>
        public Humidifier.IoTAnalytics.DatastoreTypes.DatastoreStorage DatastoreStorage { get; set; }
        /// <summary>
        /// FileFormatConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-fileformatconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FileFormatConfiguration
        /// </summary>
        public Humidifier.IoTAnalytics.DatastoreTypes.FileFormatConfiguration FileFormatConfiguration { get; set; }
        /// <summary>
        /// DatastorePartitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorepartitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DatastorePartitions
        /// </summary>
        public Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartitions DatastorePartitions { get; set; }
        public dynamic DatastoreName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetentionPeriod
        /// </summary>
        public Humidifier.IoTAnalytics.DatastoreTypes.RetentionPeriod RetentionPeriod { get; set; }
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
        public class Column : Humidifier.Base.BaseSubResource, IHaveName, IHaveType
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

        public class CustomerManagedS3 : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveBucket, IHaveKeyPrefix
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

        public class CustomerManagedS3Storage : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveKeyPrefix
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

        public class DatastorePartition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Partition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartition.html#cfn-iotanalytics-datastore-datastorepartition-partition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Partition
            /// </summary>
            public Humidifier.IoTAnalytics.DatastoreTypes.Partition Partition { get; set; }
            /// <summary>
            /// TimestampPartition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartition.html#cfn-iotanalytics-datastore-datastorepartition-timestamppartition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimestampPartition
            /// </summary>
            public Humidifier.IoTAnalytics.DatastoreTypes.TimestampPartition TimestampPartition { get; set; }
        }

        public class DatastorePartitions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Partitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartitions.html#cfn-iotanalytics-datastore-datastorepartitions-partitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DatastorePartition
            /// </summary>
            public List<Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartition> Partitions { get; set; }
        }

        public class DatastoreStorage : Humidifier.Base.BaseSubResource, IHaveServiceManagedS3
        {
            /// <summary>
            /// CustomerManagedS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorestorage.html#cfn-iotanalytics-datastore-datastorestorage-customermanageds3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedS3
            /// </summary>
            public Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3 CustomerManagedS3 { get; set; }
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
            public Humidifier.IoTAnalytics.DatastoreTypes.IotSiteWiseMultiLayerStorage IotSiteWiseMultiLayerStorage { get; set; }
        }

        public class FileFormatConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParquetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-fileformatconfiguration.html#cfn-iotanalytics-datastore-fileformatconfiguration-parquetconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParquetConfiguration
            /// </summary>
            public Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration ParquetConfiguration { get; set; }
            /// <summary>
            /// JsonConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-fileformatconfiguration.html#cfn-iotanalytics-datastore-fileformatconfiguration-jsonconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic JsonConfiguration { get; set; }
        }

        public class IotSiteWiseMultiLayerStorage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomerManagedS3Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-iotsitewisemultilayerstorage.html#cfn-iotanalytics-datastore-iotsitewisemultilayerstorage-customermanageds3storage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedS3Storage
            /// </summary>
            public Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage CustomerManagedS3Storage { get; set; }
        }

        public class ParquetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SchemaDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-parquetconfiguration.html#cfn-iotanalytics-datastore-parquetconfiguration-schemadefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition SchemaDefinition { get; set; }
        }

        public class Partition : Humidifier.Base.BaseSubResource, IHaveAttributeName
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

        public class RetentionPeriod : Humidifier.Base.BaseSubResource, IHaveUnlimited, IHaveNumberOfDays
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

        public class SchemaDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-schemadefinition.html#cfn-iotanalytics-datastore-schemadefinition-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Column
            /// </summary>
            public List<Humidifier.IoTAnalytics.DatastoreTypes.Column> Columns { get; set; }
        }

        public class TimestampPartition : Humidifier.Base.BaseSubResource, IHaveAttributeName, IHaveTimestampFormat
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