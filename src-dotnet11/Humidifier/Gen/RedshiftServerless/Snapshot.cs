namespace Humidifier.RedshiftServerless
{
    using global::System.Collections.Generic;
    using SnapshotTypes;

    public class Snapshot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveNamespaceName, IHaveRetentionPeriod_Integer, IHaveSnapshotName
    {
        public class Attributes
        {
            public static string Snapshot =  "Snapshot" ;
            public static string OwnerAccount =  "OwnerAccount" ;
        }

        public override string AWSTypeName { get => AWS.RedshiftServerless.Snapshot; }
        /// <summary>
        /// NamespaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-snapshot.html#cfn-redshiftserverless-snapshot-namespacename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NamespaceName { get; set; }
        /// <summary>
        /// RetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-snapshot.html#cfn-redshiftserverless-snapshot-retentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RetentionPeriod { get; set; }
        public Union<string, BaseFunction>? SnapshotName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-snapshot.html#cfn-redshiftserverless-snapshot-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SnapshotTypes
    {
        public class Snapshot : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveNamespaceName, IHaveAdminUsername, IHaveSnapshotCreateTime, IHaveNamespaceArn, IHaveKmsKeyId, IHaveSnapshotArn, IHaveOwnerAccount, IHaveRetentionPeriod_Integer, IHaveSnapshotName
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// NamespaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-namespacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceName { get; set; }
            /// <summary>
            /// AdminUsername
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-adminusername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdminUsername { get; set; }
            /// <summary>
            /// SnapshotCreateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-snapshotcreatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotCreateTime { get; set; }
            /// <summary>
            /// NamespaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-namespacearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceArn { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// SnapshotArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-snapshotarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotArn { get; set; }
            /// <summary>
            /// OwnerAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-owneraccount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerAccount { get; set; }
            /// <summary>
            /// RetentionPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-retentionperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetentionPeriod { get; set; }
            /// <summary>
            /// SnapshotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-snapshot-snapshot.html#cfn-redshiftserverless-snapshot-snapshot-snapshotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotName { get; set; }
        }
    }
}