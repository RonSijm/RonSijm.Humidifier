namespace Humidifier.DocDBElastic
{
    using global::System.Collections.Generic;

    public class ClusterSnapshot : Humidifier.Base.BaseResource, IHaveTags, IHaveClusterArn, IHaveSnapshotName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string AdminUserName =  "AdminUserName" ;
            public static string ClusterCreationTime =  "ClusterCreationTime" ;
            public static string KmsKeyId =  "KmsKeyId" ;
            public static string SnapshotArn =  "SnapshotArn" ;
            public static string VpcSecurityGroupIds =  "VpcSecurityGroupIds" ;
            public static string SnapshotType =  "SnapshotType" ;
            public static string SnapshotCreationTime =  "SnapshotCreationTime" ;
            public static string SubnetIds =  "SubnetIds" ;
        }

        public override string AWSTypeName { get => AWS.DocDBElastic.ClusterSnapshot; }

        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-clustersnapshot.html#cfn-docdbelastic-clustersnapshot-clusterarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterArn { get; set; }

        /// <summary>
        /// SnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-clustersnapshot.html#cfn-docdbelastic-clustersnapshot-snapshotname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SnapshotName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdbelastic-clustersnapshot.html#cfn-docdbelastic-clustersnapshot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}