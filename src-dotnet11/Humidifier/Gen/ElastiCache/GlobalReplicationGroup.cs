namespace Humidifier.ElastiCache
{
    using global::System.Collections.Generic;
    using GlobalReplicationGroupTypes;

    public class GlobalReplicationGroup : Humidifier.Base.BaseResource, IHaveTags, IHaveGlobalReplicationGroupIdSuffix, IHaveCacheNodeType, IHaveEngineVersion, IHaveGlobalReplicationGroupDescription, IHaveListOfElastiCacheGlobalReplicationGroupTypesRegionalConfigurationRegionalConfigurations, IHaveCacheParameterGroupName, IHaveEngine, IHaveListOfElastiCacheGlobalReplicationGroupTypesGlobalReplicationGroupMemberMembers, IHaveAutomaticFailoverEnabled_Boolean, IHaveGlobalNodeGroupCount_Integer, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string GlobalReplicationGroupId =  "GlobalReplicationGroupId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.GlobalReplicationGroup; }
        /// <summary>
        /// GlobalReplicationGroupIdSuffix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupidsuffix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GlobalReplicationGroupIdSuffix { get; set; }
        /// <summary>
        /// CacheNodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-cachenodetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheNodeType { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-engineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EngineVersion { get; set; }
        /// <summary>
        /// GlobalReplicationGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GlobalReplicationGroupDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => GlobalReplicationGroupDescription; set => GlobalReplicationGroupDescription = value; }
        /// <summary>
        /// RegionalConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-regionalconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RegionalConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration>, IReadOnlyList<Union<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration, BaseFunction>>, BaseFunction>? RegionalConfigurations { get; set; }
        /// <summary>
        /// CacheParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-cacheparametergroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CacheParameterGroupName { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-engine
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Engine { get; set; }

        /// <summary>
        /// Members
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-members
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GlobalReplicationGroupMember
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember>, IReadOnlyList<Union<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember, BaseFunction>>, BaseFunction>? Members { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AutomaticFailoverEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-automaticfailoverenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutomaticFailoverEnabled { get; set; }
        /// <summary>
        /// GlobalNodeGroupCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-globalnodegroupcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? GlobalNodeGroupCount { get; set; }
    }

    namespace GlobalReplicationGroupTypes
    {
        public class GlobalReplicationGroupMember : Humidifier.Base.BaseSubResource, IHaveRole, IHaveReplicationGroupRegion, IHaveReplicationGroupId
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-globalreplicationgroupmember.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupmember-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// ReplicationGroupRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-globalreplicationgroupmember.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupmember-replicationgroupregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplicationGroupRegion { get; set; }
            /// <summary>
            /// ReplicationGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-globalreplicationgroupmember.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupmember-replicationgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplicationGroupId { get; set; }
        }

        public class RegionalConfiguration : Humidifier.Base.BaseSubResource, IHaveReplicationGroupRegion, IHaveReplicationGroupId, IHaveListOfElastiCacheGlobalReplicationGroupTypesReshardingConfigurationReshardingConfigurations
        {
            /// <summary>
            /// ReplicationGroupRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-regionalconfiguration.html#cfn-elasticache-globalreplicationgroup-regionalconfiguration-replicationgroupregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplicationGroupRegion { get; set; }
            /// <summary>
            /// ReplicationGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-regionalconfiguration.html#cfn-elasticache-globalreplicationgroup-regionalconfiguration-replicationgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplicationGroupId { get; set; }
            /// <summary>
            /// ReshardingConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-regionalconfiguration.html#cfn-elasticache-globalreplicationgroup-regionalconfiguration-reshardingconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReshardingConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.ElastiCache.GlobalReplicationGroupTypes.ReshardingConfiguration>, IReadOnlyList<Union<Humidifier.ElastiCache.GlobalReplicationGroupTypes.ReshardingConfiguration, BaseFunction>>, BaseFunction>? ReshardingConfigurations { get; set; }
        }

        public class ReshardingConfiguration : Humidifier.Base.BaseSubResource, IHaveNodeGroupId, IHaveStringListOfPreferredAvailabilityZones
        {
            /// <summary>
            /// NodeGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-reshardingconfiguration.html#cfn-elasticache-globalreplicationgroup-reshardingconfiguration-nodegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NodeGroupId { get; set; }
            /// <summary>
            /// PreferredAvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-reshardingconfiguration.html#cfn-elasticache-globalreplicationgroup-reshardingconfiguration-preferredavailabilityzones
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PreferredAvailabilityZones { get; set; }
        }
    }
}