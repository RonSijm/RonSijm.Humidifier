namespace Humidifier.Timestream
{
    using global::System.Collections.Generic;
    using InfluxDBClusterTypes;

    public class InfluxDBCluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDbParameterGroupIdentifier, IHaveOrganization, IHavePort_Integer, IHaveDbInstanceType, IHaveStringListOfVpcSubnetIds, IHaveFailoverMode, IHaveDeploymentType, IHaveName, IHaveAllocatedStorage_Integer, IHaveDbStorageType, IHaveTimestreamInfluxDBClusterTypesLogDeliveryConfigurationLogDeliveryConfiguration, IHaveUsername, IHaveBucket, IHaveStringListOfVpcSecurityGroupIds, IHaveNetworkType, IHavePubliclyAccessible_Boolean, IHaveTimestreamInfluxDBClusterTypesMaintenanceScheduleMaintenanceSchedule, IHavePassword
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Endpoint =  "Endpoint" ;
            public static string InfluxAuthParametersSecretArn =  "InfluxAuthParametersSecretArn" ;
            public static string NextMaintenanceTime =  "NextMaintenanceTime" ;
            public static string EngineType =  "EngineType" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string ReaderEndpoint =  "ReaderEndpoint" ;
        }

        public override string AWSTypeName { get => AWS.Timestream.InfluxDBCluster; }
        /// <summary>
        /// DbParameterGroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-dbparametergroupidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DbParameterGroupIdentifier { get; set; }
        /// <summary>
        /// Organization
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-organization
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Organization { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-port
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// DbInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-dbinstancetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DbInstanceType { get; set; }
        /// <summary>
        /// VpcSubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-vpcsubnetids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSubnetIds { get; set; }
        /// <summary>
        /// FailoverMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-failovermode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FailoverMode { get; set; }
        /// <summary>
        /// DeploymentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-deploymenttype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeploymentType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AllocatedStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-allocatedstorage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AllocatedStorage { get; set; }
        /// <summary>
        /// DbStorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-dbstoragetype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DbStorageType { get; set; }
        /// <summary>
        /// LogDeliveryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-logdeliveryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogDeliveryConfiguration
        /// </summary>
        public Union<Humidifier.Timestream.InfluxDBClusterTypes.LogDeliveryConfiguration, BaseFunction>? LogDeliveryConfiguration { get; set; }
        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-username
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Username { get; set; }
        /// <summary>
        /// Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-bucket
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Bucket { get; set; }
        /// <summary>
        /// VpcSecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-vpcsecuritygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroupIds { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// PubliclyAccessible
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-publiclyaccessible
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PubliclyAccessible { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MaintenanceSchedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-maintenanceschedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceSchedule
        /// </summary>
        public Union<Humidifier.Timestream.InfluxDBClusterTypes.MaintenanceSchedule, BaseFunction>? MaintenanceSchedule { get; set; }
        /// <summary>
        /// Password
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbcluster.html#cfn-timestream-influxdbcluster-password
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Password { get; set; }
    }

    namespace InfluxDBClusterTypes
    {
        public class LogDeliveryConfiguration : Humidifier.Base.BaseSubResource, IHaveTimestreamInfluxDBClusterTypesS3ConfigurationS3Configuration
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbcluster-logdeliveryconfiguration.html#cfn-timestream-influxdbcluster-logdeliveryconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBClusterTypes.S3Configuration, BaseFunction>? S3Configuration { get; set; }
        }

        public class MaintenanceSchedule : Humidifier.Base.BaseSubResource, IHaveTimezone, IHavePreferredMaintenanceWindow
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbcluster-maintenanceschedule.html#cfn-timestream-influxdbcluster-maintenanceschedule-timezone
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timezone { get; set; }
            /// <summary>
            /// PreferredMaintenanceWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbcluster-maintenanceschedule.html#cfn-timestream-influxdbcluster-maintenanceschedule-preferredmaintenancewindow
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreferredMaintenanceWindow { get; set; }
        }

        public class S3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveEnabled_Boolean
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbcluster-s3configuration.html#cfn-timestream-influxdbcluster-s3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbcluster-s3configuration.html#cfn-timestream-influxdbcluster-s3configuration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}