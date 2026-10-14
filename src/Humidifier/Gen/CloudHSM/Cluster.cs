namespace Humidifier.CloudHSM
{
    using global::System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveSubnetIds, IHaveMode, IHaveNetworkType
    {
        public class Attributes
        {
            public static string SubnetMapping =  "SubnetMapping" ;
            public static string VpcId =  "VpcId" ;
            public static string ClusterId =  "ClusterId" ;
            public static string State =  "State" ;
            public static string SecurityGroup =  "SecurityGroup" ;
            public static string Arn =  "Arn" ;
            public static string BackupPolicy =  "BackupPolicy" ;
        }

        public override string AWSTypeName { get => AWS.CloudHSM.Cluster; }
        /// <summary>
        /// NetworkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudhsm-cluster.html#cfn-cloudhsm-cluster-networktype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkType { get; set; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudhsm-cluster.html#cfn-cloudhsm-cluster-mode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Mode { get; set; }

        /// <summary>
        /// HsmType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudhsm-cluster.html#cfn-cloudhsm-cluster-hsmtype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic HsmType { get; set; }
        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudhsm-cluster.html#cfn-cloudhsm-cluster-subnetids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SubnetIds { get; set; }
        /// <summary>
        /// BackupRetentionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudhsm-cluster.html#cfn-cloudhsm-cluster-backupretentionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BackupRetentionPolicy
        /// </summary>
        public Humidifier.CloudHSM.ClusterTypes.BackupRetentionPolicy BackupRetentionPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudhsm-cluster.html#cfn-cloudhsm-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.CloudHSM.ClusterTypes.TagsItems> Tags { get; set; }
    }

    namespace ClusterTypes
    {
        public class BackupRetentionPolicy : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudhsm-cluster-backupretentionpolicy.html#cfn-cloudhsm-cluster-backupretentionpolicy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudhsm-cluster-backupretentionpolicy.html#cfn-cloudhsm-cluster-backupretentionpolicy-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudhsm-cluster-tagsitems.html#cfn-cloudhsm-cluster-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudhsm-cluster-tagsitems.html#cfn-cloudhsm-cluster-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}