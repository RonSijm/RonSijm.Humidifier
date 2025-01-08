namespace Humidifier.Connect
{
    using System.Collections.Generic;
    using RoutingProfileTypes;

    public class RoutingProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveInstanceArn
    {
        public class Attributes
        {
            public static string RoutingProfileArn =  "RoutingProfileArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.RoutingProfile; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Description { get; set; }

        /// <summary>
        /// MediaConcurrencies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-mediaconcurrencies
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaConcurrency
        /// </summary>
        [Required]
        public List<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency> MediaConcurrencies { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// AgentAvailabilityTimer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-agentavailabilitytimer
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AgentAvailabilityTimer { get; set; }
        /// <summary>
        /// QueueConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-queueconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RoutingProfileQueueConfig
        /// </summary>
        public List<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig> QueueConfigs { get; set; }

        /// <summary>
        /// DefaultOutboundQueueArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-defaultoutboundqueuearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DefaultOutboundQueueArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace RoutingProfileTypes
    {
        public class CrossChannelBehavior : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BehaviorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-crosschannelbehavior.html#cfn-connect-routingprofile-crosschannelbehavior-behaviortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BehaviorType { get; set; }
        }

        public class MediaConcurrency : Humidifier.Base.BaseSubResource, IHaveChannel
        {
            /// <summary>
            /// Concurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-mediaconcurrency.html#cfn-connect-routingprofile-mediaconcurrency-concurrency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Concurrency { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-mediaconcurrency.html#cfn-connect-routingprofile-mediaconcurrency-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Channel { get; set; }
            /// <summary>
            /// CrossChannelBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-mediaconcurrency.html#cfn-connect-routingprofile-mediaconcurrency-crosschannelbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrossChannelBehavior
            /// </summary>
            public Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior CrossChannelBehavior { get; set; }
        }

        public class RoutingProfileQueueConfig : Humidifier.Base.BaseSubResource, IHavePriority
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeueconfig.html#cfn-connect-routingprofile-routingprofilequeueconfig-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// QueueReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeueconfig.html#cfn-connect-routingprofile-routingprofilequeueconfig-queuereference
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RoutingProfileQueueReference
            /// </summary>
            public Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference QueueReference { get; set; }
            /// <summary>
            /// Delay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeueconfig.html#cfn-connect-routingprofile-routingprofilequeueconfig-delay
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Delay { get; set; }
        }

        public class RoutingProfileQueueReference : Humidifier.Base.BaseSubResource, IHaveChannel, IHaveQueueArn
        {
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeuereference.html#cfn-connect-routingprofile-routingprofilequeuereference-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Channel { get; set; }
            /// <summary>
            /// QueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeuereference.html#cfn-connect-routingprofile-routingprofilequeuereference-queuearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueueArn { get; set; }
        }
    }
}