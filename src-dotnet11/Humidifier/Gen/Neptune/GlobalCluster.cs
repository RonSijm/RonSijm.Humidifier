namespace Humidifier.Neptune
{
    using global::System.Collections.Generic;

    public class GlobalCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveStorageEncrypted_Boolean, IHaveEngineVersion, IHaveSourceDBClusterIdentifier, IHaveDeletionProtection_Boolean, IHaveGlobalClusterIdentifier, IHaveEngine
    {
        public override string AWSTypeName { get => AWS.Neptune.GlobalCluster; }
        /// <summary>
        /// StorageEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-globalcluster.html#cfn-neptune-globalcluster-storageencrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? StorageEncrypted { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-globalcluster.html#cfn-neptune-globalcluster-engineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// SourceDBClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-globalcluster.html#cfn-neptune-globalcluster-sourcedbclusteridentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceDBClusterIdentifier { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-globalcluster.html#cfn-neptune-globalcluster-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// GlobalClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-globalcluster.html#cfn-neptune-globalcluster-globalclusteridentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GlobalClusterIdentifier { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-globalcluster.html#cfn-neptune-globalcluster-engine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-globalcluster.html#cfn-neptune-globalcluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}