namespace Humidifier.MemoryDB
{
    using global::System.Collections.Generic;
    using SnapshotTypes;

    public class Snapshot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKmsKeyId, IHaveClusterName, IHaveSnapshotName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ClusterConfiguration =  "ClusterConfiguration" ;
            public static string Source =  "Source" ;
            public static string DataTiering =  "DataTiering" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MemoryDB.Snapshot; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-snapshot.html#cfn-memorydb-snapshot-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId { get; set; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-snapshot.html#cfn-memorydb-snapshot-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterName { get; set; }
        public dynamic SnapshotName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-snapshot.html#cfn-memorydb-snapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace SnapshotTypes
    {
        public class ClusterConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHavePort, IHaveVpcId, IHaveEngineVersion, IHaveEngine, IHaveTopicArn, IHaveNodeType, IHaveParameterGroupName, IHaveSubnetGroupName, IHaveSnapshotRetentionLimit, IHaveSnapshotWindow, IHaveMaintenanceWindow, IHaveNumShards
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// EngineVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-engineversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EngineVersion { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicArn { get; set; }
            /// <summary>
            /// ParameterGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-parametergroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterGroupName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// SubnetGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-subnetgroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetGroupName { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// NumShards
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-numshards
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumShards { get; set; }
            /// <summary>
            /// SnapshotWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-snapshotwindow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SnapshotWindow { get; set; }
            /// <summary>
            /// SnapshotRetentionLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-snapshotretentionlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SnapshotRetentionLimit { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-vpcid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// NodeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-nodetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NodeType { get; set; }
            /// <summary>
            /// MaintenanceWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-maintenancewindow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaintenanceWindow { get; set; }
            /// <summary>
            /// Engine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-memorydb-snapshot-clusterconfiguration.html#cfn-memorydb-snapshot-clusterconfiguration-engine
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Engine { get; set; }
        }
    }
}