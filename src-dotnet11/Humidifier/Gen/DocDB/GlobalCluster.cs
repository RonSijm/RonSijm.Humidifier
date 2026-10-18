namespace Humidifier.DocDB
{
    using global::System.Collections.Generic;

    public class GlobalCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveStorageEncrypted_Boolean, IHaveEngineVersion, IHaveSourceDBClusterIdentifier, IHaveDeletionProtection_Boolean, IHaveGlobalClusterIdentifier, IHaveEngine
    {
        public class Attributes
        {
            public static string GlobalClusterArn =  "GlobalClusterArn" ;
            public static string GlobalClusterResourceId =  "GlobalClusterResourceId" ;
        }

        public override string AWSTypeName { get => AWS.DocDB.GlobalCluster; }
        /// <summary>
        /// StorageEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-globalcluster.html#cfn-docdb-globalcluster-storageencrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? StorageEncrypted { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-globalcluster.html#cfn-docdb-globalcluster-engineversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// SourceDBClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-globalcluster.html#cfn-docdb-globalcluster-sourcedbclusteridentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceDBClusterIdentifier { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-globalcluster.html#cfn-docdb-globalcluster-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtection { get; set; }

        /// <summary>
        /// GlobalClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-globalcluster.html#cfn-docdb-globalcluster-globalclusteridentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GlobalClusterIdentifier { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-globalcluster.html#cfn-docdb-globalcluster-engine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-docdb-globalcluster.html#cfn-docdb-globalcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}