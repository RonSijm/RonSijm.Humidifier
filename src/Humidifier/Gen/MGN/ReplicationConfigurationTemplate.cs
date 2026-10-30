namespace Humidifier.MGN
{
    using global::System.Collections.Generic;

    public class ReplicationConfigurationTemplate : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ReplicationConfigurationTemplateID =  "ReplicationConfigurationTemplateID" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MGN.ReplicationConfigurationTemplate; }

        /// <summary>
        /// BandwidthThrottling
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-bandwidththrottling
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic BandwidthThrottling { get; set; }

        /// <summary>
        /// ReplicationServerInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-replicationserverinstancetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ReplicationServerInstanceType { get; set; }
        /// <summary>
        /// InternetProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-internetprotocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InternetProtocol { get; set; }
        /// <summary>
        /// UseFipsEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-usefipsendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic UseFipsEndpoint { get; set; }
        /// <summary>
        /// EbsEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-ebsencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EbsEncryptionKeyArn { get; set; }

        /// <summary>
        /// ReplicationServersSecurityGroupsIDs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-replicationserverssecuritygroupsids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ReplicationServersSecurityGroupsIDs { get; set; }

        /// <summary>
        /// EbsEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-ebsencryption
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EbsEncryption { get; set; }

        /// <summary>
        /// UseDedicatedReplicationServer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-usededicatedreplicationserver
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic UseDedicatedReplicationServer { get; set; }

        /// <summary>
        /// StagingAreaTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-stagingareatags
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Dictionary<string, dynamic> StagingAreaTags { get; set; }
        /// <summary>
        /// StoreSnapshotOnLocalZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-storesnapshotonlocalzone
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic StoreSnapshotOnLocalZone { get; set; }

        /// <summary>
        /// CreatePublicIP
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-createpublicip
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic CreatePublicIP { get; set; }

        /// <summary>
        /// StagingAreaSubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-stagingareasubnetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic StagingAreaSubnetId { get; set; }

        /// <summary>
        /// DataPlaneRouting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-dataplanerouting
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DataPlaneRouting { get; set; }

        /// <summary>
        /// DefaultLargeStagingDiskType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-defaultlargestagingdisktype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DefaultLargeStagingDiskType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// AssociateDefaultSecurityGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-associatedefaultsecuritygroup
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic AssociateDefaultSecurityGroup { get; set; }
    }
}