namespace Humidifier.RDS
{
    using global::System.Collections.Generic;

    public class DBSnapshot : Humidifier.Base.BaseResource, IHaveTags, IHaveDBInstanceIdentifier, IHaveDBSnapshotIdentifier
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string IAMDatabaseAuthenticationEnabled =  "IAMDatabaseAuthenticationEnabled" ;
            public static string LicenseModel =  "LicenseModel" ;
            public static string EngineVersion =  "EngineVersion" ;
            public static string StorageType =  "StorageType" ;
            public static string KmsKeyId =  "KmsKeyId" ;
            public static string InstanceCreateTime =  "InstanceCreateTime" ;
            public static string Encrypted =  "Encrypted" ;
            public static string Port =  "Port" ;
            public static string AvailabilityZone =  "AvailabilityZone" ;
            public static string OptionGroupName =  "OptionGroupName" ;
            public static string StorageThroughput =  "StorageThroughput" ;
            public static string Iops =  "Iops" ;
            public static string DBSnapshotArn =  "DBSnapshotArn" ;
            public static string DbiResourceId =  "DbiResourceId" ;
            public static string AllocatedStorage =  "AllocatedStorage" ;
            public static string OriginalSnapshotCreateTime =  "OriginalSnapshotCreateTime" ;
            public static string SnapshotCreateTime =  "SnapshotCreateTime" ;
            public static string VpcId =  "VpcId" ;
            public static string MasterUsername =  "MasterUsername" ;
            public static string SnapshotType =  "SnapshotType" ;
            public static string Engine =  "Engine" ;
        }

        public override string AWSTypeName { get => AWS.RDS.DBSnapshot; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsnapshot.html#cfn-rds-dbsnapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// DBInstanceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsnapshot.html#cfn-rds-dbsnapshot-dbinstanceidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DBInstanceIdentifier { get; set; }

        /// <summary>
        /// DBSnapshotIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-dbsnapshot.html#cfn-rds-dbsnapshot-dbsnapshotidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DBSnapshotIdentifier { get; set; }
    }
}