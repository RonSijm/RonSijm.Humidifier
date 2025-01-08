namespace Humidifier.Cassandra
{
    using System.Collections.Generic;
    using KeyspaceTypes;

    public class Keyspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKeyspaceName, IHaveClientSideTimestampsEnabled
    {
        public override string AWSTypeName { get => AWS.Cassandra.Keyspace; }
        /// <summary>
        /// ClientSideTimestampsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-clientsidetimestampsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ClientSideTimestampsEnabled { get; set; }
        public dynamic KeyspaceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ReplicationSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-replicationspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationSpecification
        /// </summary>
        public Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification ReplicationSpecification { get; set; }
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
        public class ReplicationSpecification : Humidifier.Base.BaseSubResource, IHaveRegionList
        {
            /// <summary>
            /// ReplicationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-keyspace-replicationspecification.html#cfn-cassandra-keyspace-replicationspecification-replicationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplicationStrategy { get; set; }
            /// <summary>
            /// RegionList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-keyspace-replicationspecification.html#cfn-cassandra-keyspace-replicationspecification-regionlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic RegionList { get; set; }
        }
    }
}