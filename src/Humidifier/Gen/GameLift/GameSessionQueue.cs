namespace Humidifier.GameLift
{
    using System.Collections.Generic;
    using GameSessionQueueTypes;

    public class GameSessionQueue : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveTimeoutInSeconds
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.GameLift.GameSessionQueue; }
        /// <summary>
        /// TimeoutInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-timeoutinseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TimeoutInSeconds { get; set; }
        /// <summary>
        /// PlayerLatencyPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-playerlatencypolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PlayerLatencyPolicy
        /// </summary>
        public List<Humidifier.GameLift.GameSessionQueueTypes.PlayerLatencyPolicy> PlayerLatencyPolicies { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GameSessionQueueDestination
        /// </summary>
        public List<Humidifier.GameLift.GameSessionQueueTypes.GameSessionQueueDestination> Destinations { get; set; }
        /// <summary>
        /// NotificationTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-notificationtarget
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NotificationTarget { get; set; }
        /// <summary>
        /// FilterConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-filterconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FilterConfiguration
        /// </summary>
        public Humidifier.GameLift.GameSessionQueueTypes.FilterConfiguration FilterConfiguration { get; set; }
        /// <summary>
        /// CustomEventData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-customeventdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomEventData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PriorityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-priorityconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PriorityConfiguration
        /// </summary>
        public Humidifier.GameLift.GameSessionQueueTypes.PriorityConfiguration PriorityConfiguration { get; set; }
    }

    namespace GameSessionQueueTypes
    {
        public class FilterConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowedLocations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-filterconfiguration.html#cfn-gamelift-gamesessionqueue-filterconfiguration-allowedlocations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedLocations { get; set; }
        }

        public class GameSessionQueueDestination : Humidifier.Base.BaseSubResource, IHaveDestinationArn
        {
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-gamesessionqueuedestination.html#cfn-gamelift-gamesessionqueue-gamesessionqueuedestination-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationArn { get; set; }
        }

        public class PlayerLatencyPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PolicyDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-playerlatencypolicy.html#cfn-gamelift-gamesessionqueue-playerlatencypolicy-policydurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PolicyDurationSeconds { get; set; }
            /// <summary>
            /// MaximumIndividualPlayerLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-playerlatencypolicy.html#cfn-gamelift-gamesessionqueue-playerlatencypolicy-maximumindividualplayerlatencymilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumIndividualPlayerLatencyMilliseconds { get; set; }
        }

        public class PriorityConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PriorityOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-priorityconfiguration.html#cfn-gamelift-gamesessionqueue-priorityconfiguration-priorityorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PriorityOrder { get; set; }
            /// <summary>
            /// LocationOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-priorityconfiguration.html#cfn-gamelift-gamesessionqueue-priorityconfiguration-locationorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LocationOrder { get; set; }
        }
    }
}