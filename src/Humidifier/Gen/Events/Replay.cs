namespace Humidifier.Events
{
    using global::System.Collections.Generic;
    using ReplayTypes;

    public class Replay : Humidifier.Base.BaseResource, IHaveImpliedResourceName
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
        public Humidifier.Events.ReplayTypes.Destination Destination { get; set; }

        /// <summary>
        /// EventStartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-replay.html#cfn-events-replay-eventstarttime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EventStartTime { get; set; }
        public dynamic ReplayName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// EventSourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-replay.html#cfn-events-replay-eventsourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EventSourceArn { get; set; }

        /// <summary>
        /// EventEndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-replay.html#cfn-events-replay-eventendtime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic EventEndTime { get; set; }
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
            public dynamic Arn { get; set; }
        }
    }
}