namespace Humidifier.DMS
{
    using global::System.Collections.Generic;
    using ReplicationConfigTypes;

    public class ReplicationConfig : Humidifier.Base.BaseResource, IHaveTags, IHaveReplicationSettings_Json, IHaveResourceIdentifier, IHaveReplicationConfigIdentifier, IHaveDMSReplicationConfigTypesComputeConfigComputeConfig, IHaveReplicationType, IHaveTableMappings_Json, IHaveSourceEndpointArn, IHaveSupplementalSettings_Json, IHaveTargetEndpointArn
    {
        public class Attributes
        {
            public static string ReplicationConfigArn =  "ReplicationConfigArn" ;
        }

        public override string AWSTypeName { get => AWS.DMS.ReplicationConfig; }
        /// <summary>
        /// ReplicationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-replicationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? ReplicationSettings { get; set; }
        /// <summary>
        /// ResourceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-resourceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResourceIdentifier { get; set; }

        /// <summary>
        /// ReplicationConfigIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-replicationconfigidentifier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ReplicationConfigIdentifier { get; set; }

        /// <summary>
        /// ComputeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-computeconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ComputeConfig
        /// </summary>
        [Required]
        public Union<Humidifier.DMS.ReplicationConfigTypes.ComputeConfig, BaseFunction>? ComputeConfig { get; set; }

        /// <summary>
        /// ReplicationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-replicationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ReplicationType { get; set; }

        /// <summary>
        /// TableMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-tablemappings
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? TableMappings { get; set; }

        /// <summary>
        /// SourceEndpointArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-sourceendpointarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceEndpointArn { get; set; }
        /// <summary>
        /// SupplementalSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-supplementalsettings
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? SupplementalSettings { get; set; }

        /// <summary>
        /// TargetEndpointArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-targetendpointarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetEndpointArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationconfig.html#cfn-dms-replicationconfig-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ReplicationConfigTypes
    {
        public class ComputeConfig : Humidifier.Base.BaseSubResource, IHaveDnsNameServers, IHaveKmsKeyId, IHaveStringListOfVpcSecurityGroupIds, IHaveMaxCapacityUnits_Integer, IHaveReplicationSubnetGroupId, IHaveAvailabilityZone, IHavePreferredMaintenanceWindow, IHaveMinCapacityUnits_Integer, IHaveMultiAZ_Boolean
        {
            /// <summary>
            /// DnsNameServers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-dnsnameservers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DnsNameServers { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// VpcSecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-vpcsecuritygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpcSecurityGroupIds { get; set; }
            /// <summary>
            /// MaxCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-maxcapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacityUnits { get; set; }
            /// <summary>
            /// ReplicationSubnetGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-replicationsubnetgroupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplicationSubnetGroupId { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// PreferredMaintenanceWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-preferredmaintenancewindow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreferredMaintenanceWindow { get; set; }
            /// <summary>
            /// MinCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-mincapacityunits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinCapacityUnits { get; set; }
            /// <summary>
            /// MultiAZ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dms-replicationconfig-computeconfig.html#cfn-dms-replicationconfig-computeconfig-multiaz
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MultiAZ { get; set; }
        }
    }
}