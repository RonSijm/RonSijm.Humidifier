namespace Humidifier.ElastiCache
{
    using global::System.Collections.Generic;
    using ReplicationGroupTypes;

    public class ReplicationGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfPreferredCacheClusterAZs, IHaveListOfElastiCacheReplicationGroupTypesNodeGroupConfigurationNodeGroupConfiguration, IHaveStringListOfSnapshotArns, IHaveClusterMode, IHavePort_Integer, IHaveNumNodeGroups_Integer, IHaveNotificationTopicArn, IHaveSnapshotName, IHaveAutomaticFailoverEnabled_Boolean, IHaveReplicasPerNodeGroup_Integer, IHaveReplicationGroupDescription, IHaveMultiAZEnabled_Boolean, IHaveTransitEncryptionEnabled_Boolean, IHaveNetworkType, IHaveReplicationGroupId, IHaveEngine, IHaveNumCacheClusters_Integer, IHaveGlobalReplicationGroupId, IHaveEngineVersion, IHaveKmsKeyId, IHaveCacheSubnetGroupName, IHaveCacheParameterGroupName, IHavePreferredMaintenanceWindow, IHavePrimaryClusterId, IHaveDurability, IHaveAtRestEncryptionEnabled_Boolean, IHaveAutoMinorVersionUpgrade_Boolean, IHaveStringListOfSecurityGroupIds, IHaveSnapshotWindow, IHaveTransitEncryptionMode, IHaveCacheNodeType, IHaveSnapshotRetentionLimit_Integer, IHaveStringListOfUserGroupIds, IHaveSnapshottingClusterId, IHaveIpDiscovery, IHaveAuthToken, IHaveDataTieringEnabled_Boolean, IHaveListOfElastiCacheReplicationGroupTypesLogDeliveryConfigurationRequestLogDeliveryConfigurations, IHaveDescription
    {
        public class Attributes
        {
            public static string ReadEndPoint =  "ReadEndPoint" ;
            public static string ConfigurationEndPoint =  "ConfigurationEndPoint" ;
            public static string ReaderEndPoint =  "ReaderEndPoint" ;
            public static string EffectiveDurability =  "EffectiveDurability" ;
            public static string PrimaryEndPoint =  "PrimaryEndPoint" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.ReplicationGroup; }
        /// <summary>
        /// PreferredCacheClusterAZs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-preferredcacheclusterazs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PreferredCacheClusterAZs { get; set; }
        /// <summary>
        /// NodeGroupConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-nodegroupconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: NodeGroupConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration>, IReadOnlyList<Union<Humidifier.ElastiCache.ReplicationGroupTypes.NodeGroupConfiguration, BaseFunction>>, BaseFunction>? NodeGroupConfiguration { get; set; }
        /// <summary>
        /// SnapshotArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SnapshotArns { get; set; }
        /// <summary>
        /// ClusterMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-clustermode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClusterMode { get; set; }
        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-port
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Port { get; set; }
        /// <summary>
        /// NumNodeGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-numnodegroups
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NumNodeGroups { get; set; }
        /// <summary>
        /// NotificationTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-notificationtopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotificationTopicArn { get; set; }
        /// <summary>
        /// SnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotName { get; set; }
        /// <summary>
        /// AutomaticFailoverEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-automaticfailoverenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutomaticFailoverEnabled { get; set; }
        /// <summary>
        /// ReplicasPerNodeGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicaspernodegroup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ReplicasPerNodeGroup { get; set; }

        /// <summary>
        /// ReplicationGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicationgroupdescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ReplicationGroupDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => ReplicationGroupDescription; set => ReplicationGroupDescription = value; }
        /// <summary>
        /// MultiAZEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-multiazenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? MultiAZEnabled { get; set; }
        /// <summary>
        /// TransitEncryptionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-transitencryptionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TransitEncryptionEnabled { get; set; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NetworkType { get; set; }
        /// <summary>
        /// ReplicationGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicationgroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReplicationGroupId { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-engine
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// NumCacheClusters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-numcacheclusters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NumCacheClusters { get; set; }
        /// <summary>
        /// GlobalReplicationGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-globalreplicationgroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GlobalReplicationGroupId { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-engineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// CacheSubnetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cachesubnetgroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheSubnetGroupName { get; set; }
        /// <summary>
        /// CacheParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cacheparametergroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheParameterGroupName { get; set; }
        /// <summary>
        /// PreferredMaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-preferredmaintenancewindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreferredMaintenanceWindow { get; set; }
        /// <summary>
        /// PrimaryClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-primaryclusterid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrimaryClusterId { get; set; }
        /// <summary>
        /// Durability
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-durability
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Durability { get; set; }
        /// <summary>
        /// AtRestEncryptionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-atrestencryptionenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AtRestEncryptionEnabled { get; set; }
        /// <summary>
        /// AutoMinorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-autominorversionupgrade
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoMinorVersionUpgrade { get; set; }
        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
        /// <summary>
        /// SnapshotWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotwindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshotWindow { get; set; }
        /// <summary>
        /// TransitEncryptionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-transitencryptionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TransitEncryptionMode { get; set; }
        /// <summary>
        /// CacheNodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cachenodetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheNodeType { get; set; }
        /// <summary>
        /// SnapshotRetentionLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotretentionlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? SnapshotRetentionLimit { get; set; }
        /// <summary>
        /// UserGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-usergroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? UserGroupIds { get; set; }
        /// <summary>
        /// SnapshottingClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshottingclusterid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SnapshottingClusterId { get; set; }
        /// <summary>
        /// IpDiscovery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-ipdiscovery
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IpDiscovery { get; set; }
        /// <summary>
        /// AuthToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-authtoken
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AuthToken { get; set; }
        /// <summary>
        /// DataTieringEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-datatieringenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DataTieringEnabled { get; set; }
        /// <summary>
        /// LogDeliveryConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-logdeliveryconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LogDeliveryConfigurationRequest
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest>, IReadOnlyList<Union<Humidifier.ElastiCache.ReplicationGroupTypes.LogDeliveryConfigurationRequest, BaseFunction>>, BaseFunction>? LogDeliveryConfigurations { get; set; }
    }

    namespace ReplicationGroupTypes
    {
        public class CloudWatchLogsDestinationDetails : Humidifier.Base.BaseSubResource, IHaveLogGroup
        {
            /// <summary>
            /// LogGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-cloudwatchlogsdestinationdetails.html#cfn-elasticache-replicationgroup-cloudwatchlogsdestinationdetails-loggroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroup { get; set; }
        }

        public class DestinationDetails : Humidifier.Base.BaseSubResource, IHaveElastiCacheReplicationGroupTypesCloudWatchLogsDestinationDetailsCloudWatchLogsDetails, IHaveElastiCacheReplicationGroupTypesKinesisFirehoseDestinationDetailsKinesisFirehoseDetails
        {
            /// <summary>
            /// CloudWatchLogsDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-destinationdetails.html#cfn-elasticache-replicationgroup-destinationdetails-cloudwatchlogsdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogsDestinationDetails
            /// </summary>
            public Union<Humidifier.ElastiCache.ReplicationGroupTypes.CloudWatchLogsDestinationDetails, BaseFunction>? CloudWatchLogsDetails { get; set; }
            /// <summary>
            /// KinesisFirehoseDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-destinationdetails.html#cfn-elasticache-replicationgroup-destinationdetails-kinesisfirehosedetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseDestinationDetails
            /// </summary>
            public Union<Humidifier.ElastiCache.ReplicationGroupTypes.KinesisFirehoseDestinationDetails, BaseFunction>? KinesisFirehoseDetails { get; set; }
        }

        public class Endpoint : Humidifier.Base.BaseSubResource, IHaveAddress, IHavePort
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-endpoint.html#cfn-elasticache-replicationgroup-endpoint-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-endpoint.html#cfn-elasticache-replicationgroup-endpoint-port
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-kinesisfirehosedestinationdetails.html#cfn-elasticache-replicationgroup-kinesisfirehosedestinationdetails-deliverystream
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStream { get; set; }
        }

        public class LogDeliveryConfigurationRequest : Humidifier.Base.BaseSubResource, IHaveLogFormat, IHaveLogType, IHaveDestinationType, IHaveElastiCacheReplicationGroupTypesDestinationDetailsDestinationDetails
        {
            /// <summary>
            /// LogFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-logdeliveryconfigurationrequest.html#cfn-elasticache-replicationgroup-logdeliveryconfigurationrequest-logformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogFormat { get; set; }
            /// <summary>
            /// LogType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-logdeliveryconfigurationrequest.html#cfn-elasticache-replicationgroup-logdeliveryconfigurationrequest-logtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogType { get; set; }
            /// <summary>
            /// DestinationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-logdeliveryconfigurationrequest.html#cfn-elasticache-replicationgroup-logdeliveryconfigurationrequest-destinationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationType { get; set; }
            /// <summary>
            /// DestinationDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-logdeliveryconfigurationrequest.html#cfn-elasticache-replicationgroup-logdeliveryconfigurationrequest-destinationdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DestinationDetails
            /// </summary>
            public Union<Humidifier.ElastiCache.ReplicationGroupTypes.DestinationDetails, BaseFunction>? DestinationDetails { get; set; }
        }

        public class NodeGroupConfiguration : Humidifier.Base.BaseSubResource, IHaveSlots, IHaveStringListOfReplicaAvailabilityZones, IHaveNodeGroupId, IHaveReplicaCount_Integer, IHavePrimaryAvailabilityZone
        {
            /// <summary>
            /// Slots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-slots
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Slots { get; set; }
            /// <summary>
            /// ReplicaAvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-replicaavailabilityzones
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReplicaAvailabilityZones { get; set; }
            /// <summary>
            /// NodeGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-nodegroupid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NodeGroupId { get; set; }
            /// <summary>
            /// ReplicaCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-replicacount
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReplicaCount { get; set; }
            /// <summary>
            /// PrimaryAvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-primaryavailabilityzone
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryAvailabilityZone { get; set; }
        }

        public class ReadEndPoint : Humidifier.Base.BaseSubResource, IHaveAddresses, IHaveStringListOfPortsList, IHaveStringListOfAddressesList, IHavePorts
        {
            /// <summary>
            /// Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-readendpoint.html#cfn-elasticache-replicationgroup-readendpoint-addresses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Addresses { get; set; }
            /// <summary>
            /// PortsList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-readendpoint.html#cfn-elasticache-replicationgroup-readendpoint-portslist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PortsList { get; set; }
            /// <summary>
            /// AddressesList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-readendpoint.html#cfn-elasticache-replicationgroup-readendpoint-addresseslist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AddressesList { get; set; }
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-readendpoint.html#cfn-elasticache-replicationgroup-readendpoint-ports
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ports { get; set; }
        }
    }
}