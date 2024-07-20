namespace Humidifier.Cassandra
{
    using System.Collections.Generic;
    using KeyspaceTypes;

    public class Keyspace : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Cassandra::Keyspace";
            }
        }

        /// <summary>
        /// KeyspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-keyspacename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyspaceName { get; set; }
        /// <summary>
        /// ReplicationSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-replicationspecification
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ReplicationSpecification
        /// </summary>
        public ReplicationSpecification ReplicationSpecification { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace KeyspaceTypes
    {
        public class ReplicationSpecification
        {
            /// <summary>
            /// ReplicationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-keyspace-replicationspecification.html#cfn-cassandra-keyspace-replicationspecification-replicationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplicationStrategy { get; set; }
            /// <summary>
            /// RegionList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-keyspace-replicationspecification.html#cfn-cassandra-keyspace-replicationspecification-regionlist
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RegionList { get; set; }
        }
    }
}