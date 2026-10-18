namespace Humidifier.GameLift
{
    using global::System.Collections.Generic;
    using GameSessionQueueTypes;

    public class GameSessionQueue : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTimeoutInSeconds_Integer, IHaveListOfGameLiftGameSessionQueueTypesPlayerLatencyPolicyPlayerLatencyPolicies, IHaveListOfGameLiftGameSessionQueueTypesGameSessionQueueDestinationDestinations, IHaveNotificationTarget, IHaveGameLiftGameSessionQueueTypesFilterConfigurationFilterConfiguration, IHaveCustomEventData, IHaveName, IHaveGameLiftGameSessionQueueTypesPriorityConfigurationPriorityConfiguration
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
        public Union<int, BaseFunction>? TimeoutInSeconds { get; set; }
        /// <summary>
        /// PlayerLatencyPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-playerlatencypolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PlayerLatencyPolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.GameSessionQueueTypes.PlayerLatencyPolicy>, IReadOnlyList<Union<Humidifier.GameLift.GameSessionQueueTypes.PlayerLatencyPolicy, BaseFunction>>, BaseFunction>? PlayerLatencyPolicies { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GameSessionQueueDestination
        /// </summary>
        public Union<IReadOnlyList<Humidifier.GameLift.GameSessionQueueTypes.GameSessionQueueDestination>, IReadOnlyList<Union<Humidifier.GameLift.GameSessionQueueTypes.GameSessionQueueDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        /// <summary>
        /// NotificationTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-notificationtarget
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotificationTarget { get; set; }
        /// <summary>
        /// FilterConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-filterconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FilterConfiguration
        /// </summary>
        public Union<Humidifier.GameLift.GameSessionQueueTypes.FilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
        /// <summary>
        /// CustomEventData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-customeventdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomEventData { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PriorityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-gamelift-gamesessionqueue.html#cfn-gamelift-gamesessionqueue-priorityconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PriorityConfiguration
        /// </summary>
        public Union<Humidifier.GameLift.GameSessionQueueTypes.PriorityConfiguration, BaseFunction>? PriorityConfiguration { get; set; }
    }

    namespace GameSessionQueueTypes
    {
        public class FilterConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedLocations
        {
            /// <summary>
            /// AllowedLocations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-filterconfiguration.html#cfn-gamelift-gamesessionqueue-filterconfiguration-allowedlocations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedLocations { get; set; }
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
            public Union<string, BaseFunction>? DestinationArn { get; set; }
        }

        public class PlayerLatencyPolicy : Humidifier.Base.BaseSubResource, IHavePolicyDurationSeconds_Integer, IHaveMaximumIndividualPlayerLatencyMilliseconds_Integer
        {
            /// <summary>
            /// PolicyDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-playerlatencypolicy.html#cfn-gamelift-gamesessionqueue-playerlatencypolicy-policydurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PolicyDurationSeconds { get; set; }
            /// <summary>
            /// MaximumIndividualPlayerLatencyMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-playerlatencypolicy.html#cfn-gamelift-gamesessionqueue-playerlatencypolicy-maximumindividualplayerlatencymilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumIndividualPlayerLatencyMilliseconds { get; set; }
        }

        public class PriorityConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfPriorityOrder, IHaveStringListOfLocationOrder
        {
            /// <summary>
            /// PriorityOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-priorityconfiguration.html#cfn-gamelift-gamesessionqueue-priorityconfiguration-priorityorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PriorityOrder { get; set; }
            /// <summary>
            /// LocationOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-priorityconfiguration.html#cfn-gamelift-gamesessionqueue-priorityconfiguration-locationorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LocationOrder { get; set; }
        }
    }
}