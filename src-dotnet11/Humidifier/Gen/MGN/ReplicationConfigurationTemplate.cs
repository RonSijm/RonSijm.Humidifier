namespace Humidifier.MGN
{
    using global::System.Collections.Generic;

    public class ReplicationConfigurationTemplate : Humidifier.Base.BaseResource, IHaveTags, IHaveBandwidthThrottling_Integer, IHaveReplicationServerInstanceType, IHaveInternetProtocol, IHaveUseFipsEndpoint_Boolean, IHaveEbsEncryptionKeyArn, IHaveStringListOfReplicationServersSecurityGroupsIDs, IHaveEbsEncryption, IHaveUseDedicatedReplicationServer_Boolean, IHaveStringDictionaryOfStagingAreaTags, IHaveStoreSnapshotOnLocalZone_Boolean, IHaveCreatePublicIP_Boolean, IHaveStagingAreaSubnetId, IHaveDataPlaneRouting, IHaveDefaultLargeStagingDiskType, IHaveAssociateDefaultSecurityGroup_Boolean
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
        public Union<int, BaseFunction>? BandwidthThrottling { get; set; }

        /// <summary>
        /// ReplicationServerInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-replicationserverinstancetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ReplicationServerInstanceType { get; set; }
        /// <summary>
        /// InternetProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-internetprotocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InternetProtocol { get; set; }
        /// <summary>
        /// UseFipsEndpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-usefipsendpoint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? UseFipsEndpoint { get; set; }
        /// <summary>
        /// EbsEncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-ebsencryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EbsEncryptionKeyArn { get; set; }

        /// <summary>
        /// ReplicationServersSecurityGroupsIDs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-replicationserverssecuritygroupsids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReplicationServersSecurityGroupsIDs { get; set; }

        /// <summary>
        /// EbsEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-ebsencryption
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EbsEncryption { get; set; }

        /// <summary>
        /// UseDedicatedReplicationServer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-usededicatedreplicationserver
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? UseDedicatedReplicationServer { get; set; }

        /// <summary>
        /// StagingAreaTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-stagingareatags
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? StagingAreaTags { get; set; }
        /// <summary>
        /// StoreSnapshotOnLocalZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-storesnapshotonlocalzone
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? StoreSnapshotOnLocalZone { get; set; }

        /// <summary>
        /// CreatePublicIP
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-createpublicip
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? CreatePublicIP { get; set; }

        /// <summary>
        /// StagingAreaSubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-stagingareasubnetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StagingAreaSubnetId { get; set; }

        /// <summary>
        /// DataPlaneRouting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-dataplanerouting
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataPlaneRouting { get; set; }

        /// <summary>
        /// DefaultLargeStagingDiskType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-defaultlargestagingdisktype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DefaultLargeStagingDiskType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// AssociateDefaultSecurityGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mgn-replicationconfigurationtemplate.html#cfn-mgn-replicationconfigurationtemplate-associatedefaultsecuritygroup
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? AssociateDefaultSecurityGroup { get; set; }
    }
}