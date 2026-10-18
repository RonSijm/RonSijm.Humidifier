namespace Humidifier.MediaTailor
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaTailorChannelTypesSlateSourceFillerSlate, IHaveChannelName, IHaveTier, IHaveStringListOfAudiences, IHaveListOfMediaTailorChannelTypesRequestOutputItemOutputs, IHaveMediaTailorChannelTypesLogConfigurationForChannelLogConfiguration, IHavePlaybackMode, IHaveMediaTailorChannelTypesTimeShiftConfigurationTimeShiftConfiguration
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaTailor.Channel; }
        /// <summary>
        /// FillerSlate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-fillerslate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SlateSource
        /// </summary>
        public Union<Humidifier.MediaTailor.ChannelTypes.SlateSource, BaseFunction>? FillerSlate { get; set; }
        public Union<string, BaseFunction>? ChannelName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-tier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Tier { get; set; }
        /// <summary>
        /// Audiences
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-audiences
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Audiences { get; set; }

        /// <summary>
        /// Outputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-outputs
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RequestOutputItem
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem>, IReadOnlyList<Union<Humidifier.MediaTailor.ChannelTypes.RequestOutputItem, BaseFunction>>, BaseFunction>? Outputs { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfigurationForChannel
        /// </summary>
        public Union<Humidifier.MediaTailor.ChannelTypes.LogConfigurationForChannel, BaseFunction>? LogConfiguration { get; set; }

        /// <summary>
        /// PlaybackMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-playbackmode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PlaybackMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// TimeShiftConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-timeshiftconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeShiftConfiguration
        /// </summary>
        public Union<Humidifier.MediaTailor.ChannelTypes.TimeShiftConfiguration, BaseFunction>? TimeShiftConfiguration { get; set; }
    }

    namespace ChannelTypes
    {
        public class DashPlaylistSettings : Humidifier.Base.BaseSubResource, IHaveManifestWindowSeconds_Double, IHaveSuggestedPresentationDelaySeconds_Double, IHaveMinBufferTimeSeconds_Double, IHaveMinUpdatePeriodSeconds_Double
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-dashplaylistsettings.html#cfn-mediatailor-channel-dashplaylistsettings-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ManifestWindowSeconds { get; set; }
            /// <summary>
            /// SuggestedPresentationDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-dashplaylistsettings.html#cfn-mediatailor-channel-dashplaylistsettings-suggestedpresentationdelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? SuggestedPresentationDelaySeconds { get; set; }
            /// <summary>
            /// MinBufferTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-dashplaylistsettings.html#cfn-mediatailor-channel-dashplaylistsettings-minbuffertimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinBufferTimeSeconds { get; set; }
            /// <summary>
            /// MinUpdatePeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-dashplaylistsettings.html#cfn-mediatailor-channel-dashplaylistsettings-minupdateperiodseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MinUpdatePeriodSeconds { get; set; }
        }

        public class HlsPlaylistSettings : Humidifier.Base.BaseSubResource, IHaveManifestWindowSeconds_Double, IHaveStringListOfAdMarkupType
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-hlsplaylistsettings.html#cfn-mediatailor-channel-hlsplaylistsettings-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ManifestWindowSeconds { get; set; }
            /// <summary>
            /// AdMarkupType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-hlsplaylistsettings.html#cfn-mediatailor-channel-hlsplaylistsettings-admarkuptype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AdMarkupType { get; set; }
        }

        public class LogConfigurationForChannel : Humidifier.Base.BaseSubResource, IHaveStringListOfLogTypes
        {
            /// <summary>
            /// LogTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-logconfigurationforchannel.html#cfn-mediatailor-channel-logconfigurationforchannel-logtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogTypes { get; set; }
        }

        public class RequestOutputItem : Humidifier.Base.BaseSubResource, IHaveManifestName, IHaveMediaTailorChannelTypesDashPlaylistSettingsDashPlaylistSettings, IHaveMediaTailorChannelTypesHlsPlaylistSettingsHlsPlaylistSettings, IHaveSourceGroup
        {
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-requestoutputitem.html#cfn-mediatailor-channel-requestoutputitem-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManifestName { get; set; }
            /// <summary>
            /// DashPlaylistSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-requestoutputitem.html#cfn-mediatailor-channel-requestoutputitem-dashplaylistsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashPlaylistSettings
            /// </summary>
            public Union<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings, BaseFunction>? DashPlaylistSettings { get; set; }
            /// <summary>
            /// HlsPlaylistSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-requestoutputitem.html#cfn-mediatailor-channel-requestoutputitem-hlsplaylistsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsPlaylistSettings
            /// </summary>
            public Union<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings, BaseFunction>? HlsPlaylistSettings { get; set; }
            /// <summary>
            /// SourceGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-requestoutputitem.html#cfn-mediatailor-channel-requestoutputitem-sourcegroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceGroup { get; set; }
        }

        public class SlateSource : Humidifier.Base.BaseSubResource, IHaveVodSourceName, IHaveSourceLocationName
        {
            /// <summary>
            /// VodSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-slatesource.html#cfn-mediatailor-channel-slatesource-vodsourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VodSourceName { get; set; }
            /// <summary>
            /// SourceLocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-slatesource.html#cfn-mediatailor-channel-slatesource-sourcelocationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceLocationName { get; set; }
        }

        public class TimeShiftConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTimeDelaySeconds_Double
        {
            /// <summary>
            /// MaxTimeDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-timeshiftconfiguration.html#cfn-mediatailor-channel-timeshiftconfiguration-maxtimedelayseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTimeDelaySeconds { get; set; }
        }
    }
}