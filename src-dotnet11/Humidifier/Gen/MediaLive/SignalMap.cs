namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using SignalMapTypes;

    public class SignalMap : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveStringListOfEventBridgeRuleTemplateGroupIdentifiers, IHaveDiscoveryEntryPointArn, IHaveStringListOfCloudWatchAlarmTemplateGroupIdentifiers, IHaveForceRediscovery_Boolean, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CloudWatchAlarmTemplateGroupIds =  "CloudWatchAlarmTemplateGroupIds" ;
            public static string LastDiscoveredAt =  "LastDiscoveredAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string LastSuccessfulMonitorDeployment =  "LastSuccessfulMonitorDeployment" ;
            public static string EventBridgeRuleTemplateGroupIds =  "EventBridgeRuleTemplateGroupIds" ;
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string Identifier =  "Identifier" ;
            public static string MediaResourceMap =  "MediaResourceMap" ;
            public static string FailedMediaResourceMap =  "FailedMediaResourceMap" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string ErrorMessage =  "ErrorMessage" ;
            public static string MonitorChangesPendingDeployment =  "MonitorChangesPendingDeployment" ;
            public static string MonitorDeployment =  "MonitorDeployment" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.SignalMap; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-signalmap.html#cfn-medialive-signalmap-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EventBridgeRuleTemplateGroupIdentifiers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-signalmap.html#cfn-medialive-signalmap-eventbridgeruletemplategroupidentifiers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EventBridgeRuleTemplateGroupIdentifiers { get; set; }

        /// <summary>
        /// DiscoveryEntryPointArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-signalmap.html#cfn-medialive-signalmap-discoveryentrypointarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DiscoveryEntryPointArn { get; set; }
        /// <summary>
        /// CloudWatchAlarmTemplateGroupIdentifiers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-signalmap.html#cfn-medialive-signalmap-cloudwatchalarmtemplategroupidentifiers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CloudWatchAlarmTemplateGroupIdentifiers { get; set; }
        /// <summary>
        /// ForceRediscovery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-signalmap.html#cfn-medialive-signalmap-forcerediscovery
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ForceRediscovery { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-signalmap.html#cfn-medialive-signalmap-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SignalMapTypes
    {
        public class MediaResource : Humidifier.Base.BaseSubResource, IHaveListOfMediaLiveSignalMapTypesMediaResourceNeighborDestinations, IHaveListOfMediaLiveSignalMapTypesMediaResourceNeighborSources, IHaveName
        {
            /// <summary>
            /// Destinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-mediaresource.html#cfn-medialive-signalmap-mediaresource-destinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MediaResourceNeighbor
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.SignalMapTypes.MediaResourceNeighbor>, IReadOnlyList<Union<Humidifier.MediaLive.SignalMapTypes.MediaResourceNeighbor, BaseFunction>>, BaseFunction>? Destinations { get; set; }
            /// <summary>
            /// Sources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-mediaresource.html#cfn-medialive-signalmap-mediaresource-sources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MediaResourceNeighbor
            /// </summary>
            public Union<IReadOnlyList<Humidifier.MediaLive.SignalMapTypes.MediaResourceNeighbor>, IReadOnlyList<Union<Humidifier.MediaLive.SignalMapTypes.MediaResourceNeighbor, BaseFunction>>, BaseFunction>? Sources { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-mediaresource.html#cfn-medialive-signalmap-mediaresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MediaResourceNeighbor : Humidifier.Base.BaseSubResource, IHaveArn, IHaveName
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-mediaresourceneighbor.html#cfn-medialive-signalmap-mediaresourceneighbor-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-mediaresourceneighbor.html#cfn-medialive-signalmap-mediaresourceneighbor-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MonitorDeployment : Humidifier.Base.BaseSubResource, IHaveDetailsUri, IHaveStatus, IHaveErrorMessage
        {
            /// <summary>
            /// DetailsUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-monitordeployment.html#cfn-medialive-signalmap-monitordeployment-detailsuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DetailsUri { get; set; }
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-monitordeployment.html#cfn-medialive-signalmap-monitordeployment-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// ErrorMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-monitordeployment.html#cfn-medialive-signalmap-monitordeployment-errormessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ErrorMessage { get; set; }
        }

        public class SuccessfulMonitorDeployment : Humidifier.Base.BaseSubResource, IHaveDetailsUri, IHaveStatus
        {
            /// <summary>
            /// DetailsUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-successfulmonitordeployment.html#cfn-medialive-signalmap-successfulmonitordeployment-detailsuri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DetailsUri { get; set; }
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-signalmap-successfulmonitordeployment.html#cfn-medialive-signalmap-successfulmonitordeployment-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
        }
    }
}