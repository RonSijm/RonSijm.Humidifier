namespace Humidifier.MemoryDB
{
    using global::System.Collections.Generic;

    public class MultiRegionCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveMultiRegionParameterGroupName, IHaveDescription, IHaveEngineVersion, IHaveMultiRegionClusterNameSuffix, IHaveTLSEnabled_Boolean, IHaveNodeType, IHaveUpdateStrategy, IHaveEngine, IHaveNumShards_Integer
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ARN =  "ARN" ;
            public static string MultiRegionClusterName =  "MultiRegionClusterName" ;
        }

        public override string AWSTypeName { get => AWS.MemoryDB.MultiRegionCluster; }
        /// <summary>
        /// MultiRegionParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-multiregionparametergroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MultiRegionParameterGroupName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-engineversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// MultiRegionClusterNameSuffix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-multiregionclusternamesuffix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MultiRegionClusterNameSuffix { get; set; }
        /// <summary>
        /// TLSEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-tlsenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TLSEnabled { get; set; }

        /// <summary>
        /// NodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-nodetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NodeType { get; set; }
        /// <summary>
        /// UpdateStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-updatestrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? UpdateStrategy { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-engine
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// NumShards
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-numshards
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NumShards { get; set; }
    }
}