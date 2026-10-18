namespace Humidifier.IoTAnalytics
{
    using global::System.Collections.Generic;
    using DatastoreTypes;

    public class Datastore : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIoTAnalyticsDatastoreTypesDatastoreStorageDatastoreStorage, IHaveIoTAnalyticsDatastoreTypesFileFormatConfigurationFileFormatConfiguration, IHaveIoTAnalyticsDatastoreTypesDatastorePartitionsDatastorePartitions, IHaveDatastoreName, IHaveIoTAnalyticsDatastoreTypesRetentionPeriodRetentionPeriod
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
        public Union<Humidifier.IoTAnalytics.DatastoreTypes.DatastoreStorage, BaseFunction>? DatastoreStorage { get; set; }
        /// <summary>
        /// FileFormatConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-fileformatconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FileFormatConfiguration
        /// </summary>
        public Union<Humidifier.IoTAnalytics.DatastoreTypes.FileFormatConfiguration, BaseFunction>? FileFormatConfiguration { get; set; }
        /// <summary>
        /// DatastorePartitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-datastorepartitions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DatastorePartitions
        /// </summary>
        public Union<Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartitions, BaseFunction>? DatastorePartitions { get; set; }
        public Union<string, BaseFunction>? DatastoreName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetentionPeriod
        /// </summary>
        public Union<Humidifier.IoTAnalytics.DatastoreTypes.RetentionPeriod, BaseFunction>? RetentionPeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotanalytics-datastore.html#cfn-iotanalytics-datastore-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DatastoreTypes
    {
        public class Column : Humidifier.Base.BaseSubResource, IHaveType, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-column.html#cfn-iotanalytics-datastore-column-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-column.html#cfn-iotanalytics-datastore-column-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CustomerManagedS3 : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveRoleArn, IHaveKeyPrefix
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3.html#cfn-iotanalytics-datastore-customermanageds3-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3.html#cfn-iotanalytics-datastore-customermanageds3-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3.html#cfn-iotanalytics-datastore-customermanageds3-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPrefix { get; set; }
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
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// KeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-customermanageds3storage.html#cfn-iotanalytics-datastore-customermanageds3storage-keyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyPrefix { get; set; }
        }

        public class DatastorePartition : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatastoreTypesPartitionPartition, IHaveIoTAnalyticsDatastoreTypesTimestampPartitionTimestampPartition
        {
            /// <summary>
            /// Partition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartition.html#cfn-iotanalytics-datastore-datastorepartition-partition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Partition
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatastoreTypes.Partition, BaseFunction>? Partition { get; set; }
            /// <summary>
            /// TimestampPartition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartition.html#cfn-iotanalytics-datastore-datastorepartition-timestamppartition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimestampPartition
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatastoreTypes.TimestampPartition, BaseFunction>? TimestampPartition { get; set; }
        }

        public class DatastorePartitions : Humidifier.Base.BaseSubResource, IHaveListOfIoTAnalyticsDatastoreTypesDatastorePartitionPartitions
        {
            /// <summary>
            /// Partitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorepartitions.html#cfn-iotanalytics-datastore-datastorepartitions-partitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DatastorePartition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartition>, IReadOnlyList<Union<Humidifier.IoTAnalytics.DatastoreTypes.DatastorePartition, BaseFunction>>, BaseFunction>? Partitions { get; set; }
        }

        public class DatastoreStorage : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatastoreTypesCustomerManagedS3CustomerManagedS3, IHaveServiceManagedS3_Json, IHaveIoTAnalyticsDatastoreTypesIotSiteWiseMultiLayerStorageIotSiteWiseMultiLayerStorage
        {
            /// <summary>
            /// CustomerManagedS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorestorage.html#cfn-iotanalytics-datastore-datastorestorage-customermanageds3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedS3
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3, BaseFunction>? CustomerManagedS3 { get; set; }
            /// <summary>
            /// ServiceManagedS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorestorage.html#cfn-iotanalytics-datastore-datastorestorage-servicemanageds3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ServiceManagedS3 { get; set; }
            /// <summary>
            /// IotSiteWiseMultiLayerStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-datastorestorage.html#cfn-iotanalytics-datastore-datastorestorage-iotsitewisemultilayerstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IotSiteWiseMultiLayerStorage
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatastoreTypes.IotSiteWiseMultiLayerStorage, BaseFunction>? IotSiteWiseMultiLayerStorage { get; set; }
        }

        public class FileFormatConfiguration : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatastoreTypesParquetConfigurationParquetConfiguration, IHaveJsonConfiguration_Json
        {
            /// <summary>
            /// ParquetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-fileformatconfiguration.html#cfn-iotanalytics-datastore-fileformatconfiguration-parquetconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParquetConfiguration
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatastoreTypes.ParquetConfiguration, BaseFunction>? ParquetConfiguration { get; set; }
            /// <summary>
            /// JsonConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-fileformatconfiguration.html#cfn-iotanalytics-datastore-fileformatconfiguration-jsonconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? JsonConfiguration { get; set; }
        }

        public class IotSiteWiseMultiLayerStorage : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatastoreTypesCustomerManagedS3StorageCustomerManagedS3Storage
        {
            /// <summary>
            /// CustomerManagedS3Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-iotsitewisemultilayerstorage.html#cfn-iotanalytics-datastore-iotsitewisemultilayerstorage-customermanageds3storage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomerManagedS3Storage
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatastoreTypes.CustomerManagedS3Storage, BaseFunction>? CustomerManagedS3Storage { get; set; }
        }

        public class ParquetConfiguration : Humidifier.Base.BaseSubResource, IHaveIoTAnalyticsDatastoreTypesSchemaDefinitionSchemaDefinition
        {
            /// <summary>
            /// SchemaDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-parquetconfiguration.html#cfn-iotanalytics-datastore-parquetconfiguration-schemadefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaDefinition
            /// </summary>
            public Union<Humidifier.IoTAnalytics.DatastoreTypes.SchemaDefinition, BaseFunction>? SchemaDefinition { get; set; }
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
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }

        public class RetentionPeriod : Humidifier.Base.BaseSubResource, IHaveNumberOfDays_Integer, IHaveUnlimited_Boolean
        {
            /// <summary>
            /// NumberOfDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-retentionperiod.html#cfn-iotanalytics-datastore-retentionperiod-numberofdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfDays { get; set; }
            /// <summary>
            /// Unlimited
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-retentionperiod.html#cfn-iotanalytics-datastore-retentionperiod-unlimited
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Unlimited { get; set; }
        }

        public class SchemaDefinition : Humidifier.Base.BaseSubResource, IHaveListOfIoTAnalyticsDatastoreTypesColumnColumns
        {
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-schemadefinition.html#cfn-iotanalytics-datastore-schemadefinition-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Column
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTAnalytics.DatastoreTypes.Column>, IReadOnlyList<Union<Humidifier.IoTAnalytics.DatastoreTypes.Column, BaseFunction>>, BaseFunction>? Columns { get; set; }
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
            public Union<string, BaseFunction>? AttributeName { get; set; }
            /// <summary>
            /// TimestampFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotanalytics-datastore-timestamppartition.html#cfn-iotanalytics-datastore-timestamppartition-timestampformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimestampFormat { get; set; }
        }
    }
}