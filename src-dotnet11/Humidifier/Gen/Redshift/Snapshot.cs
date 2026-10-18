namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;

    public class Snapshot : Humidifier.Base.BaseResource, IHaveTags, IHaveSnapshotIdentifier, IHaveClusterIdentifier, IHaveManualSnapshotRetentionPeriod_Integer
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ClusterCreateTime =  "ClusterCreateTime" ;
            public static string ClusterVersion =  "ClusterVersion" ;
            public static string KmsKeyId =  "KmsKeyId" ;
            public static string SnapshotArn =  "SnapshotArn" ;
            public static string Encrypted =  "Encrypted" ;
            public static string Port =  "Port" ;
            public static string NumberOfNodes =  "NumberOfNodes" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string EnhancedVpcRouting =  "EnhancedVpcRouting" ;
            public static string EncryptedWithHSM =  "EncryptedWithHSM" ;
            public static string SnapshotCreateTime =  "SnapshotCreateTime" ;
            public static string VpcId =  "VpcId" ;
            public static string NodeType =  "NodeType" ;
            public static string MasterUsername =  "MasterUsername" ;
            public static string DBName =  "DBName" ;
            public static string MaintenanceTrackName =  "MaintenanceTrackName" ;
            public static string EngineFullVersion =  "EngineFullVersion" ;
            public static string SnapshotType =  "SnapshotType" ;
            public static string OwnerAccount =  "OwnerAccount" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.Snapshot; }

        /// <summary>
        /// SnapshotIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-snapshot.html#cfn-redshift-snapshot-snapshotidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SnapshotIdentifier { get; set; }

        /// <summary>
        /// ClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-snapshot.html#cfn-redshift-snapshot-clusteridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterIdentifier { get; set; }
        /// <summary>
        /// ManualSnapshotRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-snapshot.html#cfn-redshift-snapshot-manualsnapshotretentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ManualSnapshotRetentionPeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-snapshot.html#cfn-redshift-snapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}