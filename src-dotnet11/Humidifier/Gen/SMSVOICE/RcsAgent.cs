namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using RcsAgentTypes;

    public class RcsAgent : Humidifier.Base.BaseResource, IHaveTags, IHaveOptOutListName, IHaveSelfManagedOptOutsEnabled_Boolean, IHaveTwoWayMediaS3KeyPrefix, IHaveStringListOfTwoWayRcsEventsEnabled, IHaveTwoWayEnabled_Boolean, IHaveTwoWayChannelRole, IHaveTwoWayMediaS3BucketName, IHaveTwoWayChannelArn, IHaveDeletionProtectionEnabled_Boolean, IHaveTwoWayMediaS3Role
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
        public Union<string, BaseFunction>? OptOutListName { get; set; }
        /// <summary>
        /// SelfManagedOptOutsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-selfmanagedoptoutsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SelfManagedOptOutsEnabled { get; set; }
        /// <summary>
        /// TwoWayMediaS3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaymedias3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TwoWayMediaS3KeyPrefix { get; set; }
        /// <summary>
        /// TwoWayRcsEventsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowayrcseventsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TwoWayRcsEventsEnabled { get; set; }
        /// <summary>
        /// TwoWayEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowayenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? TwoWayEnabled { get; set; }
        /// <summary>
        /// TwoWayChannelRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaychannelrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TwoWayChannelRole { get; set; }
        /// <summary>
        /// TwoWayMediaS3BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaymedias3bucketname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TwoWayMediaS3BucketName { get; set; }
        /// <summary>
        /// TwoWayChannelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaychannelarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TwoWayChannelArn { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TwoWayMediaS3Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-rcsagent.html#cfn-smsvoice-rcsagent-twowaymedias3role
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TwoWayMediaS3Role { get; set; }
    }

    namespace RcsAgentTypes
    {
        public class TestingAgentInformation : Humidifier.Base.BaseSubResource, IHaveTestingAgentId, IHaveRegistrationId, IHaveTestingAgentStatus
        {
            /// <summary>
            /// TestingAgentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-rcsagent-testingagentinformation.html#cfn-smsvoice-rcsagent-testingagentinformation-testingagentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestingAgentId { get; set; }
            /// <summary>
            /// RegistrationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-rcsagent-testingagentinformation.html#cfn-smsvoice-rcsagent-testingagentinformation-registrationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistrationId { get; set; }
            /// <summary>
            /// TestingAgentStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-rcsagent-testingagentinformation.html#cfn-smsvoice-rcsagent-testingagentinformation-testingagentstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TestingAgentStatus { get; set; }
        }
    }
}