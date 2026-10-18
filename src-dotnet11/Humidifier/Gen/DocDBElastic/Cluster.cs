namespace Humidifier.DocDBElastic
{
    using global::System.Collections.Generic;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAdminUserName, IHaveKmsKeyId, IHaveAdminUserPassword, IHavePreferredMaintenanceWindow, IHaveShardInstanceCount_Integer, IHaveStringListOfSubnetIds, IHavePreferredBackupWindow, IHaveShardCount_Integer, IHaveShardCapacity_Integer, IHaveStringListOfVpcSecurityGroupIds, IHaveClusterName, IHaveBackupRetentionPeriod_Integer, IHaveAuthType
    {
        public class Attributes
        {
            public static string ClusterArn =  "ClusterArn" ;
            public static string ClusterEndpoint =  "ClusterEndpoint" ;
        }

        public override string AWSTypeName { get => AWS.DocDBElastic.Cluster; }

        /// <summary>
        /// AdminUserName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-adminusername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AdminUserName { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// AdminUserPassword
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-adminuserpassword
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AdminUserPassword { get; set; }
        /// <summary>
        /// PreferredMaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-preferredmaintenancewindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreferredMaintenanceWindow { get; set; }
        /// <summary>
        /// ShardInstanceCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-shardinstancecount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ShardInstanceCount { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-subnetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        /// <summary>
        /// PreferredBackupWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-preferredbackupwindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreferredBackupWindow { get; set; }

        /// <summary>
        /// ShardCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-shardcount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? ShardCount { get; set; }

        /// <summary>
        /// ShardCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-shardcapacity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? ShardCapacity { get; set; }
        /// <summary>
        /// VpcSecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-vpcsecuritygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroupIds { get; set; }
        public Union<string, BaseFunction>? ClusterName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// BackupRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-backupretentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-authtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-cluster.html#cfn-docdbelastic-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}