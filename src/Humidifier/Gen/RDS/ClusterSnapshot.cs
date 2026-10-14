namespace Humidifier.RDS
{
    using global::System.Collections.Generic;

    public class ClusterSnapshot : Humidifier.Base.BaseResource, IHaveTags, IHaveDBClusterIdentifier
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ClusterCreateTime =  "ClusterCreateTime" ;
            public static string StorageEncrypted =  "StorageEncrypted" ;
            public static string LicenseModel =  "LicenseModel" ;
            public static string IAMDatabaseAuthenticationEnabled =  "IAMDatabaseAuthenticationEnabled" ;
            public static string EngineVersion =  "EngineVersion" ;
            public static string KmsKeyId =  "KmsKeyId" ;
            public static string AvailabilityZones =  "AvailabilityZones" ;
            public static string EngineMode =  "EngineMode" ;
            public static string Port =  "Port" ;
            public static string DbClusterResourceId =  "DbClusterResourceId" ;
            public static string AllocatedStorage =  "AllocatedStorage" ;
            public static string SnapshotCreateTime =  "SnapshotCreateTime" ;
            public static string VpcId =  "VpcId" ;
            public static string MasterUsername =  "MasterUsername" ;
            public static string DBClusterSnapshotArn =  "DBClusterSnapshotArn" ;
            public static string SnapshotType =  "SnapshotType" ;
            public static string Engine =  "Engine" ;
        }

        public override string AWSTypeName { get => AWS.RDS.ClusterSnapshot; }

        /// <summary>
        /// DBClusterSnapshotIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-clustersnapshot.html#cfn-rds-clustersnapshot-dbclustersnapshotidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DBClusterSnapshotIdentifier { get; set; }

        /// <summary>
        /// DBClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-clustersnapshot.html#cfn-rds-clustersnapshot-dbclusteridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DBClusterIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-clustersnapshot.html#cfn-rds-clustersnapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}