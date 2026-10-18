namespace Humidifier.Timestream
{
    using global::System.Collections.Generic;
    using InfluxDBInstanceTypes;

    public class InfluxDBInstance : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDbParameterGroupIdentifier, IHaveOrganization, IHavePort_Integer, IHaveDbInstanceType, IHaveStringListOfVpcSubnetIds, IHaveDeploymentType, IHaveName, IHaveAllocatedStorage_Integer, IHaveDbStorageType, IHaveTimestreamInfluxDBInstanceTypesLogDeliveryConfigurationLogDeliveryConfiguration, IHaveUsername, IHaveBucket, IHaveStringListOfVpcSecurityGroupIds, IHaveNetworkType, IHavePubliclyAccessible_Boolean, IHaveTimestreamInfluxDBInstanceTypesMaintenanceScheduleMaintenanceSchedule, IHavePassword
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Endpoint =  "Endpoint" ;
            public static string InfluxAuthParametersSecretArn =  "InfluxAuthParametersSecretArn" ;
            public static string NextMaintenanceTime =  "NextMaintenanceTime" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string SecondaryAvailabilityZone =  "SecondaryAvailabilityZone" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Timestream.InfluxDBInstance; }
        /// <summary>
        /// DbParameterGroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-dbparametergroupidentifier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DbParameterGroupIdentifier { get; set; }
        /// <summary>
        /// Organization
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-organization
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Organization { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-port
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// DbInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-dbinstancetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DbInstanceType { get; set; }
        /// <summary>
        /// VpcSubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-vpcsubnetids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSubnetIds { get; set; }
        /// <summary>
        /// DeploymentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-deploymenttype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeploymentType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AllocatedStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-allocatedstorage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AllocatedStorage { get; set; }
        /// <summary>
        /// DbStorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-dbstoragetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DbStorageType { get; set; }
        /// <summary>
        /// LogDeliveryConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-logdeliveryconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogDeliveryConfiguration
        /// </summary>
        public Union<Humidifier.Timestream.InfluxDBInstanceTypes.LogDeliveryConfiguration, BaseFunction>? LogDeliveryConfiguration { get; set; }
        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-username
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Username { get; set; }
        /// <summary>
        /// Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-bucket
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Bucket { get; set; }
        /// <summary>
        /// VpcSecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-vpcsecuritygroupids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroupIds { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// PubliclyAccessible
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-publiclyaccessible
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PubliclyAccessible { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MaintenanceSchedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-maintenanceschedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MaintenanceSchedule
        /// </summary>
        public Union<Humidifier.Timestream.InfluxDBInstanceTypes.MaintenanceSchedule, BaseFunction>? MaintenanceSchedule { get; set; }
        /// <summary>
        /// Password
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-influxdbinstance.html#cfn-timestream-influxdbinstance-password
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Password { get; set; }
    }

    namespace InfluxDBInstanceTypes
    {
        public class LogDeliveryConfiguration : Humidifier.Base.BaseSubResource, IHaveTimestreamInfluxDBInstanceTypesS3ConfigurationS3Configuration
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbinstance-logdeliveryconfiguration.html#cfn-timestream-influxdbinstance-logdeliveryconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.Timestream.InfluxDBInstanceTypes.S3Configuration, BaseFunction>? S3Configuration { get; set; }
        }

        public class MaintenanceSchedule : Humidifier.Base.BaseSubResource, IHaveTimezone, IHavePreferredMaintenanceWindow
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbinstance-maintenanceschedule.html#cfn-timestream-influxdbinstance-maintenanceschedule-timezone
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timezone { get; set; }
            /// <summary>
            /// PreferredMaintenanceWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbinstance-maintenanceschedule.html#cfn-timestream-influxdbinstance-maintenanceschedule-preferredmaintenancewindow
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbinstance-s3configuration.html#cfn-timestream-influxdbinstance-s3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-influxdbinstance-s3configuration.html#cfn-timestream-influxdbinstance-s3configuration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}