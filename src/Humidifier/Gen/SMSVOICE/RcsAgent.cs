namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using RcsAgentTypes;

    public class RcsAgent : Humidifier.Base.BaseResource, IHaveTags, IHaveDeletionProtectionEnabled
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TestingAgent =  "TestingAgent" ;
            public static string RcsAgentId =  "RcsAgentId" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string PoolId =  "PoolId" ;
            public static string RcsAgentArn =  "RcsAgentArn" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.RcsAgent; }
        /// <summary>
        /// OptOutListName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-optoutlistname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OptOutListName { get; set; }
        /// <summary>
        /// SelfManagedOptOutsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-selfmanagedoptoutsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SelfManagedOptOutsEnabled { get; set; }
        /// <summary>
        /// TwoWayMediaS3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaymedias3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TwoWayMediaS3KeyPrefix { get; set; }
        /// <summary>
        /// TwoWayRcsEventsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowayrcseventsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic TwoWayRcsEventsEnabled { get; set; }
        /// <summary>
        /// TwoWayEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowayenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic TwoWayEnabled { get; set; }
        /// <summary>
        /// TwoWayChannelRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaychannelrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TwoWayChannelRole { get; set; }
        /// <summary>
        /// TwoWayMediaS3BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaymedias3bucketname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TwoWayMediaS3BucketName { get; set; }
        /// <summary>
        /// TwoWayChannelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaychannelarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TwoWayChannelArn { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// TwoWayMediaS3Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaymedias3role
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TwoWayMediaS3Role { get; set; }
    }

    namespace RcsAgentTypes
    {
        public class TestingAgentInformation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TestingAgentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-rcsagent-testingagentinformation.html#cfn-smsvoice-rcsagent-testingagentinformation-testingagentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TestingAgentId { get; set; }
            /// <summary>
            /// RegistrationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-rcsagent-testingagentinformation.html#cfn-smsvoice-rcsagent-testingagentinformation-registrationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegistrationId { get; set; }
            /// <summary>
            /// TestingAgentStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-rcsagent-testingagentinformation.html#cfn-smsvoice-rcsagent-testingagentinformation-testingagentstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TestingAgentStatus { get; set; }
        }
    }
}