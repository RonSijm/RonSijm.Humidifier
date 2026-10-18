namespace Humidifier.Cassandra
{
    using global::System.Collections.Generic;
    using KeyspaceTypes;

    public class Keyspace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveClientSideTimestampsEnabled_Boolean, IHaveKeyspaceName, IHaveCassandraKeyspaceTypesReplicationSpecificationReplicationSpecification
    {
        public override string AWSTypeName { get => AWS.Cassandra.Keyspace; }
        /// <summary>
        /// ClientSideTimestampsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-clientsidetimestampsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ClientSideTimestampsEnabled { get; set; }
        public Union<string, BaseFunction>? KeyspaceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ReplicationSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-replicationspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationSpecification
        /// </summary>
        public Union<Humidifier.Cassandra.KeyspaceTypes.ReplicationSpecification, BaseFunction>? ReplicationSpecification { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace KeyspaceTypes
    {
        public class ReplicationSpecification : Humidifier.Base.BaseSubResource, IHaveReplicationStrategy, IHaveStringListOfRegionList
        {
            /// <summary>
            /// ReplicationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-keyspace-replicationspecification.html#cfn-cassandra-keyspace-replicationspecification-replicationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReplicationStrategy { get; set; }
            /// <summary>
            /// RegionList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cassandra-keyspace-replicationspecification.html#cfn-cassandra-keyspace-replicationspecification-regionlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RegionList { get; set; }
        }
    }
}