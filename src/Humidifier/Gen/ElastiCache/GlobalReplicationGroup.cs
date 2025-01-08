namespace Humidifier.ElastiCache
{
    using System.Collections.Generic;
    using GlobalReplicationGroupTypes;

    public class GlobalReplicationGroup : Humidifier.Base.BaseResource, IHaveEngineVersion, IHaveEngine, IHaveCacheNodeType, IHaveCacheParameterGroupName, IHaveAutomaticFailoverEnabled, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string GlobalReplicationGroupId =  "GlobalReplicationGroupId" ;
        }

        public override string AWSTypeName { get => AWS.ElastiCache.GlobalReplicationGroup; }
        /// <summary>
        /// GlobalReplicationGroupIdSuffix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupidsuffix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GlobalReplicationGroupIdSuffix { get; set; }
        /// <summary>
        /// CacheNodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-cachenodetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheNodeType { get; set; }
        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-engineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EngineVersion { get; set; }
        /// <summary>
        /// GlobalReplicationGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GlobalReplicationGroupDescription { get; set; }

        [Ignore]
        public dynamic Description { get => GlobalReplicationGroupDescription; set => GlobalReplicationGroupDescription = value; }
        /// <summary>
        /// RegionalConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-regionalconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RegionalConfiguration
        /// </summary>
        public List<Humidifier.ElastiCache.GlobalReplicationGroupTypes.RegionalConfiguration> RegionalConfigurations { get; set; }
        /// <summary>
        /// CacheParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-cacheparametergroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheParameterGroupName { get; set; }
        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-engine
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Engine { get; set; }

        /// <summary>
        /// Members
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-members
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GlobalReplicationGroupMember
        /// </summary>
        [Required]
        public List<Humidifier.ElastiCache.GlobalReplicationGroupTypes.GlobalReplicationGroupMember> Members { get; set; }
        /// <summary>
        /// AutomaticFailoverEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-automaticfailoverenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutomaticFailoverEnabled { get; set; }
        /// <summary>
        /// GlobalNodeGroupCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-globalreplicationgroup.html#cfn-elasticache-globalreplicationgroup-globalnodegroupcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic GlobalNodeGroupCount { get; set; }
    }

    namespace GlobalReplicationGroupTypes
    {
        public class GlobalReplicationGroupMember : Humidifier.Base.BaseSubResource, IHaveRole, IHaveReplicationGroupId, IHaveReplicationGroupRegion
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-globalreplicationgroupmember.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupmember-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// ReplicationGroupRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-globalreplicationgroupmember.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupmember-replicationgroupregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplicationGroupRegion { get; set; }
            /// <summary>
            /// ReplicationGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-globalreplicationgroupmember.html#cfn-elasticache-globalreplicationgroup-globalreplicationgroupmember-replicationgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplicationGroupId { get; set; }
        }

        public class RegionalConfiguration : Humidifier.Base.BaseSubResource, IHaveReplicationGroupId, IHaveReplicationGroupRegion
        {
            /// <summary>
            /// ReplicationGroupRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-regionalconfiguration.html#cfn-elasticache-globalreplicationgroup-regionalconfiguration-replicationgroupregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplicationGroupRegion { get; set; }
            /// <summary>
            /// ReplicationGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-regionalconfiguration.html#cfn-elasticache-globalreplicationgroup-regionalconfiguration-replicationgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplicationGroupId { get; set; }
            /// <summary>
            /// ReshardingConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-regionalconfiguration.html#cfn-elasticache-globalreplicationgroup-regionalconfiguration-reshardingconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReshardingConfiguration
            /// </summary>
            public List<Humidifier.ElastiCache.GlobalReplicationGroupTypes.ReshardingConfiguration> ReshardingConfigurations { get; set; }
        }

        public class ReshardingConfiguration : Humidifier.Base.BaseSubResource, IHavePreferredAvailabilityZones, IHaveNodeGroupId
        {
            /// <summary>
            /// NodeGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-reshardingconfiguration.html#cfn-elasticache-globalreplicationgroup-reshardingconfiguration-nodegroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NodeGroupId { get; set; }
            /// <summary>
            /// PreferredAvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-globalreplicationgroup-reshardingconfiguration.html#cfn-elasticache-globalreplicationgroup-reshardingconfiguration-preferredavailabilityzones
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PreferredAvailabilityZones { get; set; }
        }
    }
}