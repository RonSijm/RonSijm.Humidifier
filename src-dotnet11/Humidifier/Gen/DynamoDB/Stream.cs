namespace Humidifier.DynamoDB
{
    using global::System.Collections.Generic;
    using StreamTypes;

    public class Stream : Humidifier.Base.BaseResource, IHaveTableName, IHaveStreamViewType
    {
        public class Attributes
        {
            public static string StreamLabel =  "StreamLabel" ;
            public static string CreationRequestDateTime =  "CreationRequestDateTime" ;
            public static string StreamStatus =  "StreamStatus" ;
            public static string KeySchema =  "KeySchema" ;
            public static string StreamArn =  "StreamArn" ;
        }

        public override string AWSTypeName { get => AWS.DynamoDB.Stream; }
        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-stream.html#cfn-dynamodb-stream-tablename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TableName { get; set; }
        /// <summary>
        /// StreamViewType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-stream.html#cfn-dynamodb-stream-streamviewtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StreamViewType { get; set; }
    }

    namespace StreamTypes
    {
        public class KeySchemaItems : Humidifier.Base.BaseSubResource, IHaveKeyType, IHaveAttributeName
        {
            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-stream-keyschemaitems.html#cfn-dynamodb-stream-keyschemaitems-keytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyType { get; set; }
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-stream-keyschemaitems.html#cfn-dynamodb-stream-keyschemaitems-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeName { get; set; }
        }
    }
}