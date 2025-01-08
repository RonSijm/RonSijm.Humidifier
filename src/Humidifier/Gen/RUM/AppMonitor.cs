namespace Humidifier.RUM
{
    using System.Collections.Generic;
    using AppMonitorTypes;

    public class AppMonitor : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDomain
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.RUM.AppMonitor; }
        /// <summary>
        /// CustomEvents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-customevents
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomEvents
        /// </summary>
        public Humidifier.RUM.AppMonitorTypes.CustomEvents CustomEvents { get; set; }
        /// <summary>
        /// CwLogEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-cwlogenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CwLogEnabled { get; set; }

        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-domain
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Domain { get; set; }
        /// <summary>
        /// AppMonitorConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-appmonitorconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AppMonitorConfiguration
        /// </summary>
        public Humidifier.RUM.AppMonitorTypes.AppMonitorConfiguration AppMonitorConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rum-appmonitor.html#cfn-rum-appmonitor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AppMonitorTypes
    {
        public class AppMonitorConfiguration : Humidifier.Base.BaseSubResource, IHaveIdentityPoolId
        {
            /// <summary>
            /// MetricDestinations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-metricdestinations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDestination
            /// </summary>
            public List<Humidifier.RUM.AppMonitorTypes.MetricDestination> MetricDestinations { get; set; }
            /// <summary>
            /// IncludedPages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-includedpages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedPages { get; set; }
            /// <summary>
            /// ExcludedPages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-excludedpages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedPages { get; set; }
            /// <summary>
            /// FavoritePages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-favoritepages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic FavoritePages { get; set; }
            /// <summary>
            /// SessionSampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-sessionsamplerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SessionSampleRate { get; set; }
            /// <summary>
            /// AllowCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-allowcookies
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowCookies { get; set; }
            /// <summary>
            /// Telemetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-telemetries
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Telemetries { get; set; }
            /// <summary>
            /// IdentityPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-identitypoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdentityPoolId { get; set; }
            /// <summary>
            /// GuestRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-guestrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GuestRoleArn { get; set; }
            /// <summary>
            /// EnableXRay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-appmonitorconfiguration.html#cfn-rum-appmonitor-appmonitorconfiguration-enablexray
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableXRay { get; set; }
        }

        public class CustomEvents : Humidifier.Base.BaseSubResource, IHaveStatus
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-customevents.html#cfn-rum-appmonitor-customevents-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status { get; set; }
        }

        public class MetricDefinition : Humidifier.Base.BaseSubResource, IHaveName, IHaveNamespace_, IHaveEventPattern, IHaveValueKey, IHaveUnitLabel
        {
            /// <summary>
            /// EventPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-eventpattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventPattern { get; set; }
            /// <summary>
            /// ValueKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-valuekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueKey { get; set; }
            /// <summary>
            /// UnitLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-unitlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UnitLabel { get; set; }
            /// <summary>
            /// DimensionKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-dimensionkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> DimensionKeys { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdefinition.html#cfn-rum-appmonitor-metricdefinition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MetricDestination : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveIamRoleArn, IHaveDestinationArn
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdestination.html#cfn-rum-appmonitor-metricdestination-destination
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Destination { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdestination.html#cfn-rum-appmonitor-metricdestination-iamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamRoleArn { get; set; }
            /// <summary>
            /// MetricDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdestination.html#cfn-rum-appmonitor-metricdestination-metricdefinitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDefinition
            /// </summary>
            public List<Humidifier.RUM.AppMonitorTypes.MetricDefinition> MetricDefinitions { get; set; }
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rum-appmonitor-metricdestination.html#cfn-rum-appmonitor-metricdestination-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationArn { get; set; }
        }
    }
}