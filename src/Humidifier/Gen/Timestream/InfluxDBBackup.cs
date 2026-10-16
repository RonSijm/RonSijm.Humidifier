namespace Humidifier.Timestream
{
    using global::System.Collections.Generic;
    using InfluxDBBackupTypes;

    public class InfluxDBBackup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveRetentionDays
    {
        public class Attributes
        {
            public static string DbParameterGroupId =  "DbParameterGroupId" ;
            public static string InfluxAuthParametersSecretArn =  "InfluxAuthParametersSecretArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Port =  "Port" ;
            public static string DbInstanceType =  "DbInstanceType" ;
            public static string VpcSubnetIds =  "VpcSubnetIds" ;
            public static string DeploymentType =  "DeploymentType" ;
            public static string ClusterConfiguration =  "ClusterConfiguration" ;
            public static string ExpiresAfter =  "ExpiresAfter" ;
            public static string VpcSecurityGroupIds =  "VpcSecurityGroupIds" ;
            public static string NetworkType =  "NetworkType" ;
            public static string EngineType =  "EngineType" ;
            public static string Status =  "Status" ;
            public static string KmsKeyId =  "KmsKeyId" ;
            public static string FailoverMode =  "FailoverMode" ;
            public static string AllocatedStorage =  "AllocatedStorage" ;
            public static string Type =  "Type" ;
            public static string LogDeliveryConfiguration =  "LogDeliveryConfiguration" ;
            public static string DbStorageType =  "DbStorageType" ;
            public static string Id =  "Id" ;
            public static string PubliclyAccessible =  "PubliclyAccessible" ;
            public static string Arn =  "Arn" ;
            public static string MaintenanceSchedule =  "MaintenanceSchedule" ;
        }

        public override string AWSTypeName { get => AWS.Timestream.InfluxDBBackup; }
        /// <summary>
        /// RetentionDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbbackup.html#cfn-timestream-influxdbbackup-retentiondays
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic RetentionDays { get; set; }

        /// <summary>
        /// DbResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbbackup.html#cfn-timestream-influxdbbackup-dbresourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DbResourceId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbbackup.html#cfn-timestream-influxdbbackup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace InfluxDBBackupTypes
    {
        public class ClusterConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IngestQueryInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbbackup-clusterconfiguration.html#cfn-timestream-influxdbbackup-clusterconfiguration-ingestqueryinstances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IngestQueryInstances { get; set; }
            /// <summary>
            /// DedicatedCompactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbbackup-clusterconfiguration.html#cfn-timestream-influxdbbackup-clusterconfiguration-dedicatedcompactor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DedicatedCompactor { get; set; }
            /// <summary>
            /// QueryOnlyInstances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbbackup-clusterconfiguration.html#cfn-timestream-influxdbbackup-clusterconfiguration-queryonlyinstances
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic QueryOnlyInstances { get; set; }
        }

        public class LogDeliveryConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbbackup-logdeliveryconfiguration.html#cfn-timestream-influxdbbackup-logdeliveryconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Humidifier.Timestream.InfluxDBBackupTypes.S3Configuration S3Configuration { get; set; }
        }

        public class MaintenanceSchedule : Humidifier.Base.BaseSubResource, IHavePreferredMaintenanceWindow, IHaveTimezone
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbbackup-maintenanceschedule.html#cfn-timestream-influxdbbackup-maintenanceschedule-timezone
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Timezone { get; set; }
            /// <summary>
            /// PreferredMaintenanceWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbbackup-maintenanceschedule.html#cfn-timestream-influxdbbackup-maintenanceschedule-preferredmaintenancewindow
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreferredMaintenanceWindow { get; set; }
        }

        public class S3Configuration : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbbackup-s3configuration.html#cfn-timestream-influxdbbackup-s3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbbackup-s3configuration.html#cfn-timestream-influxdbbackup-s3configuration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }
    }
}