namespace Humidifier.ElastiCache
{
    using global::System.Collections.Generic;
    using CacheClusterTypes;

    public class CacheCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveEngineVersion, IHaveStringListOfSnapshotArns, IHaveCacheSubnetGroupName, IHavePort_Integer, IHaveCacheParameterGroupName, IHavePreferredMaintenanceWindow, IHaveAutoMinorVersionUpgrade_Boolean, IHaveNotificationTopicArn, IHaveNumCacheNodes_Integer, IHaveSnapshotName, IHavePreferredAvailabilityZone, IHaveSnapshotWindow, IHaveCacheNodeType, IHaveSnapshotRetentionLimit_Integer, IHaveTransitEncryptionEnabled_Boolean, IHaveStringListOfPreferredAvailabilityZones, IHaveStringListOfVpcSecurityGroupIds, IHaveNetworkType, IHaveIpDiscovery, IHaveClusterName, IHaveListOfElastiCacheCacheClusterTypesLogDeliveryConfigurationRequestLogDeliveryConfigurations, IHaveEngine, IHaveAZMode
    {
        public class Attributes
        {
            public static string RedisEndpoint =  "RedisEndpoint" ;
            public static string ConfigurationEndpoint =  "ConfigurationEndpoint" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.CacheCluster; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-engineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// SnapshotArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-snapshotarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SnapshotArns { get; set; }
        /// <summary>
        /// CacheSubnetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-cachesubnetgroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheSubnetGroupName { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-port
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// CacheParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-cacheparametergroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheParameterGroupName { get; set; }
        /// <summary>
        /// PreferredMaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-preferredmaintenancewindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreferredMaintenanceWindow { get; set; }
        /// <summary>
        /// AutoMinorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-autominorversionupgrade
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoMinorVersionUpgrade { get; set; }
        /// <summary>
        /// NotificationTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-notificationtopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotificationTopicArn { get; set; }

        /// <summary>
        /// NumCacheNodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-numcachenodes
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? NumCacheNodes { get; set; }
        /// <summary>
        /// SnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-snapshotname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotName { get; set; }
        /// <summary>
        /// PreferredAvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-preferredavailabilityzone
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreferredAvailabilityZone { get; set; }
        /// <summary>
        /// SnapshotWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-snapshotwindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotWindow { get; set; }

        /// <summary>
        /// CacheNodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-cachenodetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CacheNodeType { get; set; }
        /// <summary>
        /// SnapshotRetentionLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-snapshotretentionlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SnapshotRetentionLimit { get; set; }
        /// <summary>
        /// TransitEncryptionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-transitencryptionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TransitEncryptionEnabled { get; set; }
        /// <summary>
        /// PreferredAvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-preferredavailabilityzones
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PreferredAvailabilityZones { get; set; }
        /// <summary>
        /// VpcSecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-vpcsecuritygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroupIds { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// IpDiscovery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-ipdiscovery
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpDiscovery { get; set; }
        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-clustername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClusterName { get; set; }
        /// <summary>
        /// LogDeliveryConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-logdeliveryconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LogDeliveryConfigurationRequest
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest>, IReadOnlyList<Union<Humidifier.ElastiCache.CacheClusterTypes.LogDeliveryConfigurationRequest, BaseFunction>>, BaseFunction>? LogDeliveryConfigurations { get; set; }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-engine
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AZMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-cachecluster.html#cfn-elasticache-cachecluster-azmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AZMode { get; set; }
    }

    namespace CacheClusterTypes
    {
        public class CloudWatchLogsDestinationDetails : Humidifier.Base.BaseSubResource, IHaveLogGroup
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-cloudwatchlogsdestinationdetails.html#cfn-elasticache-cachecluster-cloudwatchlogsdestinationdetails-loggroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
        }

        public class DestinationDetails : Humidifier.Base.BaseSubResource, IHaveElastiCacheCacheClusterTypesCloudWatchLogsDestinationDetailsCloudWatchLogsDetails, IHaveElastiCacheCacheClusterTypesKinesisFirehoseDestinationDetailsKinesisFirehoseDetails
        {
            /// <summary>
            /// CloudWatchLogsDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-destinationdetails.html#cfn-elasticache-cachecluster-destinationdetails-cloudwatchlogsdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsDestinationDetails
            /// </summary>
            public Union<Humidifier.ElastiCache.CacheClusterTypes.CloudWatchLogsDestinationDetails, BaseFunction>? CloudWatchLogsDetails { get; set; }
            /// <summary>
            /// KinesisFirehoseDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-destinationdetails.html#cfn-elasticache-cachecluster-destinationdetails-kinesisfirehosedetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseDestinationDetails
            /// </summary>
            public Union<Humidifier.ElastiCache.CacheClusterTypes.KinesisFirehoseDestinationDetails, BaseFunction>? KinesisFirehoseDetails { get; set; }
        }

        public class Endpoint : Humidifier.Base.BaseSubResource, IHaveAddress, IHavePort
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-endpoint.html#cfn-elasticache-cachecluster-endpoint-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-endpoint.html#cfn-elasticache-cachecluster-endpoint-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Port { get; set; }
        }

        public class KinesisFirehoseDestinationDetails : Humidifier.Base.BaseSubResource, IHaveDeliveryStream
        {
            /// <summary>
            /// DeliveryStream
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-kinesisfirehosedestinationdetails.html#cfn-elasticache-cachecluster-kinesisfirehosedestinationdetails-deliverystream
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStream { get; set; }
        }

        public class LogDeliveryConfigurationRequest : Humidifier.Base.BaseSubResource, IHaveLogFormat, IHaveLogType, IHaveDestinationType, IHaveElastiCacheCacheClusterTypesDestinationDetailsDestinationDetails
        {
            /// <summary>
            /// LogFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-logdeliveryconfigurationrequest.html#cfn-elasticache-cachecluster-logdeliveryconfigurationrequest-logformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFormat { get; set; }
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-logdeliveryconfigurationrequest.html#cfn-elasticache-cachecluster-logdeliveryconfigurationrequest-logtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogType { get; set; }
            /// <summary>
            /// DestinationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-logdeliveryconfigurationrequest.html#cfn-elasticache-cachecluster-logdeliveryconfigurationrequest-destinationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationType { get; set; }
            /// <summary>
            /// DestinationDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cachecluster-logdeliveryconfigurationrequest.html#cfn-elasticache-cachecluster-logdeliveryconfigurationrequest-destinationdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationDetails
            /// </summary>
            public Union<Humidifier.ElastiCache.CacheClusterTypes.DestinationDetails, BaseFunction>? DestinationDetails { get; set; }
        }
    }
}