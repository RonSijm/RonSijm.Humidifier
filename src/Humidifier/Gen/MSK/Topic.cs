namespace Humidifier.MSK
{
    using global::System.Collections.Generic;

    public class Topic : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveClusterArn, IHaveTopicName, IHaveReplicationFactor
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
        public dynamic ClusterArn { get; set; }

        /// <summary>
        /// ReplicationFactor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-topic.html#cfn-msk-topic-replicationfactor
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic ReplicationFactor { get; set; }
        /// <summary>
        /// Configs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-topic.html#cfn-msk-topic-configs
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Configs { get; set; }

        /// <summary>
        /// PartitionCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-topic.html#cfn-msk-topic-partitioncount
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic PartitionCount { get; set; }
        public dynamic TopicName { get => GivenName; set => GivenName = value; }
    }
}