namespace Humidifier.Cassandra
{
    using global::System.Collections.Generic;

    public class Stream : Humidifier.Base.BaseResource, IHaveTableName, IHaveKeyspaceName, IHaveStreamViewType
    {
        public class Attributes
        {
            public static string StreamLabel =  "StreamLabel" ;
            public static string CreationRequestDateTime =  "CreationRequestDateTime" ;
            public static string StreamStatus =  "StreamStatus" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Cassandra.Stream; }
        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-stream.html#cfn-cassandra-stream-tablename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TableName { get; set; }
        /// <summary>
        /// StreamViewType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-stream.html#cfn-cassandra-stream-streamviewtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StreamViewType { get; set; }
        /// <summary>
        /// KeyspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-stream.html#cfn-cassandra-stream-keyspacename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyspaceName { get; set; }
    }
}