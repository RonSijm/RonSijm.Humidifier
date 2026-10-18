namespace Humidifier.DRS
{
    using global::System.Collections.Generic;
    using ReplicationConfigurationTemplateTypes;

    public class ReplicationConfigurationTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveBandwidthThrottling_Integer, IHaveAutoReplicateNewDisks_Boolean, IHaveReplicationServerInstanceType, IHaveInternetProtocol, IHaveEbsEncryptionKeyArn, IHaveStringListOfReplicationServersSecurityGroupsIDs, IHaveEbsEncryption, IHaveListOfDRSReplicationConfigurationTemplateTypesPITPolicyRulePitPolicy, IHaveUseDedicatedReplicationServer_Boolean, IHaveStringDictionaryOfStagingAreaTags, IHaveCreatePublicIP_Boolean, IHaveStagingAreaSubnetId, IHaveDataPlaneRouting, IHaveDefaultLargeStagingDiskType, IHaveAssociateDefaultSecurityGroup_Boolean
    {
        public class Attributes
        {
            public static string ReplicationConfigurationTemplateID =  "ReplicationConfigurationTemplateID" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.DRS.ReplicationConfigurationTemplate; }

        /// <summary>
        /// BandwidthThrottling
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-bandwidththrottling
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? BandwidthThrottling { get; set; }
        /// <summary>
        /// AutoReplicateNewDisks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-autoreplicatenewdisks
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoReplicateNewDisks { get; set; }
        /// <summary>
        /// ReplicationServerInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-replicationserverinstancetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReplicationServerInstanceType { get; set; }
        /// <summary>
        /// InternetProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-internetprotocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InternetProtocol { get; set; }
        /// <summary>
        /// EbsEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-ebsencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EbsEncryptionKeyArn { get; set; }

        /// <summary>
        /// ReplicationServersSecurityGroupsIDs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-replicationserverssecuritygroupsids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReplicationServersSecurityGroupsIDs { get; set; }

        /// <summary>
        /// EbsEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-ebsencryption
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EbsEncryption { get; set; }

        /// <summary>
        /// PitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-pitpolicy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PITPolicyRule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule>, IReadOnlyList<Union<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule, BaseFunction>>, BaseFunction>? PitPolicy { get; set; }
        /// <summary>
        /// UseDedicatedReplicationServer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-usededicatedreplicationserver
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseDedicatedReplicationServer { get; set; }

        /// <summary>
        /// StagingAreaTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-stagingareatags
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? StagingAreaTags { get; set; }
        /// <summary>
        /// CreatePublicIP
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-createpublicip
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CreatePublicIP { get; set; }

        /// <summary>
        /// StagingAreaSubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-stagingareasubnetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StagingAreaSubnetId { get; set; }
        /// <summary>
        /// DataPlaneRouting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-dataplanerouting
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataPlaneRouting { get; set; }
        /// <summary>
        /// DefaultLargeStagingDiskType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-defaultlargestagingdisktype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultLargeStagingDiskType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AssociateDefaultSecurityGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-associatedefaultsecuritygroup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AssociateDefaultSecurityGroup { get; set; }
    }

    namespace ReplicationConfigurationTemplateTypes
    {
        public class PITPolicyRule : Humidifier.Base.BaseSubResource, IHaveRuleID_Integer, IHaveEnabled_Boolean, IHaveRetentionDuration_Integer, IHaveUnits, IHaveInterval_Integer
        {
            /// <summary>
            /// RuleID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-ruleid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RuleID { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// RetentionDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-retentionduration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetentionDuration { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-units
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Units { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-interval
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
        }
    }
}