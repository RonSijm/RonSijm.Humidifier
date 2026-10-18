namespace Humidifier.MSK
{
    using global::System.Collections.Generic;

    public class Topic : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveClusterArn, IHaveReplicationFactor_Integer, IHaveConfigs, IHavePartitionCount_Integer, IHaveTopicName
    {
        public class Attributes
        {
            public static string TopicArn =  "TopicArn" ;
        }

        public override string AWSTypeName { get => AWS.MSK.Topic; }

        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-topic.html#cfn-msk-topic-clusterarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterArn { get; set; }

        /// <summary>
        /// ReplicationFactor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-topic.html#cfn-msk-topic-replicationfactor
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? ReplicationFactor { get; set; }
        /// <summary>
        /// Configs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-topic.html#cfn-msk-topic-configs
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Configs { get; set; }

        /// <summary>
        /// PartitionCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-topic.html#cfn-msk-topic-partitioncount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? PartitionCount { get; set; }
        public Union<string, BaseFunction>? TopicName { get => GivenName; set => GivenName = value; }
    }
}