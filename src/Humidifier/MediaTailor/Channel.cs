namespace Humidifier.MediaTailor
{
    using System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::MediaTailor::Channel";
            }
        }

        /// <summary>
        /// FillerSlate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-fillerslate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SlateSource
        /// </summary>
        public SlateSource FillerSlate { get; set; }
        /// <summary>
        /// ChannelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-channelname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ChannelName { get; set; }
        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-tier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Tier { get; set; }
        /// <summary>
        /// Audiences
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-audiences
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Audiences { get; set; }
        /// <summary>
        /// Outputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-outputs
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: RequestOutputItem
        /// </summary>
        public List<RequestOutputItem> Outputs { get; set; }
        /// <summary>
        /// LogConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-logconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfigurationForChannel
        /// </summary>
        public LogConfigurationForChannel LogConfiguration { get; set; }
        /// <summary>
        /// PlaybackMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-playbackmode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PlaybackMode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// TimeShiftConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediatailor-channel.html#cfn-mediatailor-channel-timeshiftconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeShiftConfiguration
        /// </summary>
        public TimeShiftConfiguration TimeShiftConfiguration { get; set; }
    }

    namespace ChannelTypes
    {
        public class DashPlaylistSettings
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-dashplaylistsettings.html#cfn-mediatailor-channel-dashplaylistsettings-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ManifestWindowSeconds { get; set; }
            /// <summary>
            /// SuggestedPresentationDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-dashplaylistsettings.html#cfn-mediatailor-channel-dashplaylistsettings-suggestedpresentationdelayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic SuggestedPresentationDelaySeconds { get; set; }
            /// <summary>
            /// MinBufferTimeSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-dashplaylistsettings.html#cfn-mediatailor-channel-dashplaylistsettings-minbuffertimeseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinBufferTimeSeconds { get; set; }
            /// <summary>
            /// MinUpdatePeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-dashplaylistsettings.html#cfn-mediatailor-channel-dashplaylistsettings-minupdateperiodseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MinUpdatePeriodSeconds { get; set; }
        }

        public class HlsPlaylistSettings
        {
            /// <summary>
            /// ManifestWindowSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-hlsplaylistsettings.html#cfn-mediatailor-channel-hlsplaylistsettings-manifestwindowseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ManifestWindowSeconds { get; set; }
            /// <summary>
            /// AdMarkupType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-hlsplaylistsettings.html#cfn-mediatailor-channel-hlsplaylistsettings-admarkuptype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdMarkupType { get; set; }
        }

        public class LogConfigurationForChannel
        {
            /// <summary>
            /// LogTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-logconfigurationforchannel.html#cfn-mediatailor-channel-logconfigurationforchannel-logtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LogTypes { get; set; }
        }

        public class RequestOutputItem
        {
            /// <summary>
            /// ManifestName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-requestoutputitem.html#cfn-mediatailor-channel-requestoutputitem-manifestname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ManifestName { get; set; }
            /// <summary>
            /// DashPlaylistSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-requestoutputitem.html#cfn-mediatailor-channel-requestoutputitem-dashplaylistsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DashPlaylistSettings
            /// </summary>
            public DashPlaylistSettings DashPlaylistSettings { get; set; }
            /// <summary>
            /// HlsPlaylistSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-requestoutputitem.html#cfn-mediatailor-channel-requestoutputitem-hlsplaylistsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsPlaylistSettings
            /// </summary>
            public HlsPlaylistSettings HlsPlaylistSettings { get; set; }
            /// <summary>
            /// SourceGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-requestoutputitem.html#cfn-mediatailor-channel-requestoutputitem-sourcegroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceGroup { get; set; }
        }

        public class SlateSource
        {
            /// <summary>
            /// VodSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-slatesource.html#cfn-mediatailor-channel-slatesource-vodsourcename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VodSourceName { get; set; }
            /// <summary>
            /// SourceLocationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-slatesource.html#cfn-mediatailor-channel-slatesource-sourcelocationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceLocationName { get; set; }
        }

        public class TimeShiftConfiguration
        {
            /// <summary>
            /// MaxTimeDelaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediatailor-channel-timeshiftconfiguration.html#cfn-mediatailor-channel-timeshiftconfiguration-maxtimedelayseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxTimeDelaySeconds { get; set; }
        }
    }
}