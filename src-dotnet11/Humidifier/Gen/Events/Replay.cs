namespace Humidifier.Events
{
    using global::System.Collections.Generic;
    using ReplayTypes;

    public class Replay : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveEventsReplayTypesDestinationDestination, IHaveEventStartTime, IHaveReplayName, IHaveEventSourceArn, IHaveEventEndTime
    {
        public class Attributes
        {
            public static string ReplayArn =  "ReplayArn" ;
            public static string State =  "State" ;
            public static string ReplayStartTime =  "ReplayStartTime" ;
        }

        public override string AWSTypeName { get => AWS.Events.Replay; }

        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-replay.html#cfn-events-replay-destination
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Destination
        /// </summary>
        [Required]
        public Union<Humidifier.Events.ReplayTypes.Destination, BaseFunction>? Destination { get; set; }

        /// <summary>
        /// EventStartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-replay.html#cfn-events-replay-eventstarttime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EventStartTime { get; set; }
        public Union<string, BaseFunction>? ReplayName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// EventSourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-replay.html#cfn-events-replay-eventsourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EventSourceArn { get; set; }

        /// <summary>
        /// EventEndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-replay.html#cfn-events-replay-eventendtime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EventEndTime { get; set; }
    }

    namespace ReplayTypes
    {
        public class Destination : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-replay-destination.html#cfn-events-replay-destination-arn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }
    }
}