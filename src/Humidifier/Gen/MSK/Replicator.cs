namespace Humidifier.MSK
{
    using System.Collections.Generic;
    using ReplicatorTypes;

    public class Replicator : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveCurrentVersion
    {
        public class Attributes
        {
            public static string ReplicatorArn =  "ReplicatorArn" ;
        }

        public override string AWSTypeName { get => AWS.MSK.Replicator; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// CurrentVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-currentversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CurrentVersion { get; set; }

        /// <summary>
        /// ServiceExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-serviceexecutionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceExecutionRoleArn { get; set; }
        public dynamic ReplicatorName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ReplicationInfoList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-replicationinfolist
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ReplicationInfo
        /// </summary>
        [Required]
        public List<Humidifier.MSK.ReplicatorTypes.ReplicationInfo> ReplicationInfoList { get; set; }

        /// <summary>
        /// KafkaClusters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-kafkaclusters
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: KafkaCluster
        /// </summary>
        [Required]
        public List<Humidifier.MSK.ReplicatorTypes.KafkaCluster> KafkaClusters { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-replicator.html#cfn-msk-replicator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ReplicatorTypes
    {
        public class AmazonMskCluster : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MskClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-amazonmskcluster.html#cfn-msk-replicator-amazonmskcluster-mskclusterarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MskClusterArn { get; set; }
        }

        public class ConsumerGroupReplication : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConsumerGroupsToReplicate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-consumergroupstoreplicate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ConsumerGroupsToReplicate { get; set; }
            /// <summary>
            /// ConsumerGroupsToExclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-consumergroupstoexclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ConsumerGroupsToExclude { get; set; }
            /// <summary>
            /// SynchroniseConsumerGroupOffsets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-synchroniseconsumergroupoffsets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SynchroniseConsumerGroupOffsets { get; set; }
            /// <summary>
            /// DetectAndCopyNewConsumerGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-consumergroupreplication.html#cfn-msk-replicator-consumergroupreplication-detectandcopynewconsumergroups
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DetectAndCopyNewConsumerGroups { get; set; }
        }

        public class KafkaCluster : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkacluster.html#cfn-msk-replicator-kafkacluster-vpcconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: KafkaClusterClientVpcConfig
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.KafkaClusterClientVpcConfig VpcConfig { get; set; }
            /// <summary>
            /// AmazonMskCluster
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkacluster.html#cfn-msk-replicator-kafkacluster-amazonmskcluster
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AmazonMskCluster
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.AmazonMskCluster AmazonMskCluster { get; set; }
        }

        public class KafkaClusterClientVpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterclientvpcconfig.html#cfn-msk-replicator-kafkaclusterclientvpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-kafkaclusterclientvpcconfig.html#cfn-msk-replicator-kafkaclusterclientvpcconfig-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }

        public class ReplicationInfo : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetCompressionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-targetcompressiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetCompressionType { get; set; }
            /// <summary>
            /// TopicReplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-topicreplication
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TopicReplication
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.TopicReplication TopicReplication { get; set; }
            /// <summary>
            /// ConsumerGroupReplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-consumergroupreplication
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConsumerGroupReplication
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.ConsumerGroupReplication ConsumerGroupReplication { get; set; }
            /// <summary>
            /// SourceKafkaClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-sourcekafkaclusterarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceKafkaClusterArn { get; set; }
            /// <summary>
            /// TargetKafkaClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationinfo.html#cfn-msk-replicator-replicationinfo-targetkafkaclusterarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetKafkaClusterArn { get; set; }
        }

        public class ReplicationStartingPosition : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationstartingposition.html#cfn-msk-replicator-replicationstartingposition-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class ReplicationTopicNameConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-replicationtopicnameconfiguration.html#cfn-msk-replicator-replicationtopicnameconfiguration-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class TopicReplication : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StartingPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-startingposition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationStartingPosition
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.ReplicationStartingPosition StartingPosition { get; set; }
            /// <summary>
            /// TopicsToReplicate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-topicstoreplicate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TopicsToReplicate { get; set; }
            /// <summary>
            /// TopicsToExclude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-topicstoexclude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TopicsToExclude { get; set; }
            /// <summary>
            /// TopicNameConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-topicnameconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplicationTopicNameConfiguration
            /// </summary>
            public Humidifier.MSK.ReplicatorTypes.ReplicationTopicNameConfiguration TopicNameConfiguration { get; set; }
            /// <summary>
            /// CopyTopicConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-copytopicconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CopyTopicConfigurations { get; set; }
            /// <summary>
            /// DetectAndCopyNewTopics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-detectandcopynewtopics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DetectAndCopyNewTopics { get; set; }
            /// <summary>
            /// CopyAccessControlListsForTopics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-msk-replicator-topicreplication.html#cfn-msk-replicator-topicreplication-copyaccesscontrollistsfortopics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CopyAccessControlListsForTopics { get; set; }
        }
    }
}