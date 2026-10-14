namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;

    public class Session : Humidifier.Base.BaseResource, IHaveTags, IHaveEncryptionKeyArn
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string SessionStatus =  "SessionStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string SessionArn =  "SessionArn" ;
            public static string SessionId =  "SessionId" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.Session; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-session.html#cfn-bedrock-session-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionKeyArn { get; set; }
        /// <summary>
        /// SessionMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-session.html#cfn-bedrock-session-sessionmetadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> SessionMetadata { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-session.html#cfn-bedrock-session-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}