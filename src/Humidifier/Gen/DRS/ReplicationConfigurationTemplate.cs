namespace Humidifier.DRS
{
    using global::System.Collections.Generic;
    using ReplicationConfigurationTemplateTypes;

    public class ReplicationConfigurationTemplate : Humidifier.Base.BaseResource, IHaveTags
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
        public dynamic BandwidthThrottling { get; set; }
        /// <summary>
        /// AutoReplicateNewDisks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-autoreplicatenewdisks
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoReplicateNewDisks { get; set; }
        /// <summary>
        /// ReplicationServerInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-replicationserverinstancetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReplicationServerInstanceType { get; set; }
        /// <summary>
        /// InternetProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-internetprotocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InternetProtocol { get; set; }
        /// <summary>
        /// EbsEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-ebsencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EbsEncryptionKeyArn { get; set; }

        /// <summary>
        /// ReplicationServersSecurityGroupsIDs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-replicationserverssecuritygroupsids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ReplicationServersSecurityGroupsIDs { get; set; }

        /// <summary>
        /// EbsEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-ebsencryption
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EbsEncryption { get; set; }

        /// <summary>
        /// PitPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-pitpolicy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PITPolicyRule
        /// </summary>
        [Required]
        public List<Humidifier.DRS.ReplicationConfigurationTemplateTypes.PITPolicyRule> PitPolicy { get; set; }
        /// <summary>
        /// UseDedicatedReplicationServer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-usededicatedreplicationserver
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic UseDedicatedReplicationServer { get; set; }

        /// <summary>
        /// StagingAreaTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-stagingareatags
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Dictionary<string, dynamic> StagingAreaTags { get; set; }
        /// <summary>
        /// CreatePublicIP
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-createpublicip
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CreatePublicIP { get; set; }

        /// <summary>
        /// StagingAreaSubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-stagingareasubnetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StagingAreaSubnetId { get; set; }
        /// <summary>
        /// DataPlaneRouting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-dataplanerouting
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataPlaneRouting { get; set; }
        /// <summary>
        /// DefaultLargeStagingDiskType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-defaultlargestagingdisktype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultLargeStagingDiskType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// AssociateDefaultSecurityGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-drs-replicationconfigurationtemplate.html#cfn-drs-replicationconfigurationtemplate-associatedefaultsecuritygroup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AssociateDefaultSecurityGroup { get; set; }
    }

    namespace ReplicationConfigurationTemplateTypes
    {
        public class PITPolicyRule : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveInterval, IHaveUnits
        {
            /// <summary>
            /// RuleID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-ruleid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RuleID { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// RetentionDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-retentionduration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RetentionDuration { get; set; }
            /// <summary>
            /// Units
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-units
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Units { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-drs-replicationconfigurationtemplate-pitpolicyrule.html#cfn-drs-replicationconfigurationtemplate-pitpolicyrule-interval
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Interval { get; set; }
        }
    }
}