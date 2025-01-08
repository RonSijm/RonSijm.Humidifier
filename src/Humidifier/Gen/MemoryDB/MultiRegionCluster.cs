namespace Humidifier.MemoryDB
{
    using System.Collections.Generic;

    public class MultiRegionCluster : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveEngineVersion, IHaveEngine, IHaveNodeType, IHaveNumShards, IHaveTLSEnabled
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
        public dynamic MultiRegionParameterGroupName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-engineversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EngineVersion { get; set; }
        /// <summary>
        /// MultiRegionClusterNameSuffix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-multiregionclusternamesuffix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MultiRegionClusterNameSuffix { get; set; }
        /// <summary>
        /// TLSEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-tlsenabled
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic TLSEnabled { get; set; }

        /// <summary>
        /// NodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-nodetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NodeType { get; set; }
        /// <summary>
        /// UpdateStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-updatestrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UpdateStrategy { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-engine
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Engine { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// NumShards
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-memorydb-multiregioncluster.html#cfn-memorydb-multiregioncluster-numshards
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic NumShards { get; set; }
    }
}