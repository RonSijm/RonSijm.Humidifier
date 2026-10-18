namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using RoutingProfileTypes;

    public class RoutingProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfConnectRoutingProfileTypesRoutingProfileManualAssignmentQueueConfigManualAssignmentQueueConfigs, IHaveDescription, IHaveListOfConnectRoutingProfileTypesMediaConcurrencyMediaConcurrencies, IHaveInstanceArn, IHaveAgentAvailabilityTimer, IHaveListOfConnectRoutingProfileTypesRoutingProfileQueueConfigQueueConfigs, IHaveDefaultOutboundQueueArn, IHaveName
    {
        public class Attributes
        {
            public static string RoutingProfileArn =  "RoutingProfileArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.RoutingProfile; }
        /// <summary>
        /// ManualAssignmentQueueConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-manualassignmentqueueconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RoutingProfileManualAssignmentQueueConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.RoutingProfileTypes.RoutingProfileManualAssignmentQueueConfig>, IReadOnlyList<Union<Humidifier.Connect.RoutingProfileTypes.RoutingProfileManualAssignmentQueueConfig, BaseFunction>>, BaseFunction>? ManualAssignmentQueueConfigs { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// MediaConcurrencies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-mediaconcurrencies
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaConcurrency
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency>, IReadOnlyList<Union<Humidifier.Connect.RoutingProfileTypes.MediaConcurrency, BaseFunction>>, BaseFunction>? MediaConcurrencies { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// AgentAvailabilityTimer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-agentavailabilitytimer
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AgentAvailabilityTimer { get; set; }
        /// <summary>
        /// QueueConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-queueconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RoutingProfileQueueConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig>, IReadOnlyList<Union<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueConfig, BaseFunction>>, BaseFunction>? QueueConfigs { get; set; }

        /// <summary>
        /// DefaultOutboundQueueArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-defaultoutboundqueuearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DefaultOutboundQueueArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-routingprofile.html#cfn-connect-routingprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RoutingProfileTypes
    {
        public class CrossChannelBehavior : Humidifier.Base.BaseSubResource, IHaveBehaviorType
        {
            /// <summary>
            /// BehaviorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-crosschannelbehavior.html#cfn-connect-routingprofile-crosschannelbehavior-behaviortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BehaviorType { get; set; }
        }

        public class MediaConcurrency : Humidifier.Base.BaseSubResource, IHaveConcurrency_Integer, IHaveChannel, IHaveConnectRoutingProfileTypesCrossChannelBehaviorCrossChannelBehavior
        {
            /// <summary>
            /// Concurrency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-mediaconcurrency.html#cfn-connect-routingprofile-mediaconcurrency-concurrency
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Concurrency { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-mediaconcurrency.html#cfn-connect-routingprofile-mediaconcurrency-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Channel { get; set; }
            /// <summary>
            /// CrossChannelBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-mediaconcurrency.html#cfn-connect-routingprofile-mediaconcurrency-crosschannelbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrossChannelBehavior
            /// </summary>
            public Union<Humidifier.Connect.RoutingProfileTypes.CrossChannelBehavior, BaseFunction>? CrossChannelBehavior { get; set; }
        }

        public class RoutingProfileManualAssignmentQueueConfig : Humidifier.Base.BaseSubResource, IHaveConnectRoutingProfileTypesRoutingProfileQueueReferenceQueueReference
        {
            /// <summary>
            /// QueueReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilemanualassignmentqueueconfig.html#cfn-connect-routingprofile-routingprofilemanualassignmentqueueconfig-queuereference
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RoutingProfileQueueReference
            /// </summary>
            public Union<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference, BaseFunction>? QueueReference { get; set; }
        }

        public class RoutingProfileQueueConfig : Humidifier.Base.BaseSubResource, IHavePriority_Integer, IHaveConnectRoutingProfileTypesRoutingProfileQueueReferenceQueueReference, IHaveDelay_Integer
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeueconfig.html#cfn-connect-routingprofile-routingprofilequeueconfig-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// QueueReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeueconfig.html#cfn-connect-routingprofile-routingprofilequeueconfig-queuereference
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RoutingProfileQueueReference
            /// </summary>
            public Union<Humidifier.Connect.RoutingProfileTypes.RoutingProfileQueueReference, BaseFunction>? QueueReference { get; set; }
            /// <summary>
            /// Delay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeueconfig.html#cfn-connect-routingprofile-routingprofilequeueconfig-delay
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Delay { get; set; }
        }

        public class RoutingProfileQueueReference : Humidifier.Base.BaseSubResource, IHaveQueueArn, IHaveChannel
        {
            /// <summary>
            /// QueueArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeuereference.html#cfn-connect-routingprofile-routingprofilequeuereference-queuearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueueArn { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-routingprofile-routingprofilequeuereference.html#cfn-connect-routingprofile-routingprofilequeuereference-channel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Channel { get; set; }
        }
    }
}