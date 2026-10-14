namespace Humidifier.ElastiCache
{
    using global::System.Collections.Generic;
    using SnapshotTypes;

    public class Snapshot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveSnapshotName, IHaveReplicationGroupId
    {
        public class Attributes
        {
            public static string EngineVersion =  "EngineVersion" ;
            public static string TopicArn =  "TopicArn" ;
            public static string CacheSubnetGroupName =  "CacheSubnetGroupName" ;
            public static string Port =  "Port" ;
            public static string AutomaticFailover =  "AutomaticFailover" ;
            public static string PreferredMaintenanceWindow =  "PreferredMaintenanceWindow" ;
            public static string CacheParameterGroupName =  "CacheParameterGroupName" ;
            public static string NumNodeGroups =  "NumNodeGroups" ;
            public static string AutoMinorVersionUpgrade =  "AutoMinorVersionUpgrade" ;
            public static string NumCacheNodes =  "NumCacheNodes" ;
            public static string PreferredAvailabilityZone =  "PreferredAvailabilityZone" ;
            public static string ReplicationGroupDescription =  "ReplicationGroupDescription" ;
            public static string SnapshotWindow =  "SnapshotWindow" ;
            public static string CacheNodeType =  "CacheNodeType" ;
            public static string SnapshotRetentionLimit =  "SnapshotRetentionLimit" ;
            public static string DataTiering =  "DataTiering" ;
            public static string CacheClusterCreateTime =  "CacheClusterCreateTime" ;
            public static string SnapshotStatus =  "SnapshotStatus" ;
            public static string VpcId =  "VpcId" ;
            public static string SnapshotSource =  "SnapshotSource" ;
            public static string NodeSnapshots =  "NodeSnapshots" ;
            public static string Arn =  "Arn" ;
            public static string Engine =  "Engine" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.Snapshot; }
        /// <summary>
        /// CacheClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-snapshot.html#cfn-elasticache-snapshot-cacheclusterid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheClusterId { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-snapshot.html#cfn-elasticache-snapshot-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }
        /// <summary>
        /// ReplicationGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-snapshot.html#cfn-elasticache-snapshot-replicationgroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReplicationGroupId { get; set; }
        public dynamic SnapshotName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-snapshot.html#cfn-elasticache-snapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace SnapshotTypes
    {
        public class NodeSnapshot : Humidifier.Base.BaseSubResource, IHaveNodeGroupId
        {
            /// <summary>
            /// CacheSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-snapshot-nodesnapshot.html#cfn-elasticache-snapshot-nodesnapshot-cachesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CacheSize { get; set; }
            /// <summary>
            /// SnapshotCreateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-snapshot-nodesnapshot.html#cfn-elasticache-snapshot-nodesnapshot-snapshotcreatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotCreateTime { get; set; }
            /// <summary>
            /// CacheClusterId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-snapshot-nodesnapshot.html#cfn-elasticache-snapshot-nodesnapshot-cacheclusterid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CacheClusterId { get; set; }
            /// <summary>
            /// CacheNodeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-snapshot-nodesnapshot.html#cfn-elasticache-snapshot-nodesnapshot-cachenodeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CacheNodeId { get; set; }
            /// <summary>
            /// NodeGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-snapshot-nodesnapshot.html#cfn-elasticache-snapshot-nodesnapshot-nodegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NodeGroupId { get; set; }
            /// <summary>
            /// CacheNodeCreateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-snapshot-nodesnapshot.html#cfn-elasticache-snapshot-nodesnapshot-cachenodecreatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CacheNodeCreateTime { get; set; }
        }
    }
}