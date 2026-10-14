namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaLiveConnectorPipelineTypes;

    public class MediaLiveConnectorPipeline : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string MediaPipelineId =  "MediaPipelineId" ;
            public static string MediaPipelineArn =  "MediaPipelineArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.MediaLiveConnectorPipeline; }

        /// <summary>
        /// Sinks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-medialiveconnectorpipeline.html#cfn-chime-medialiveconnectorpipeline-sinks
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LiveConnectorSinkConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration> Sinks { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-medialiveconnectorpipeline.html#cfn-chime-medialiveconnectorpipeline-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LiveConnectorSourceConfiguration
        /// </summary>
        [Required]
        public List<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSourceConfiguration> Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-medialiveconnectorpipeline.html#cfn-chime-medialiveconnectorpipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace MediaLiveConnectorPipelineTypes
    {
        public class ActiveSpeakerOnlyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ActiveSpeakerPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-activespeakeronlyconfiguration.html#cfn-chime-medialiveconnectorpipeline-activespeakeronlyconfiguration-activespeakerposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActiveSpeakerPosition { get; set; }
        }

        public class ChimeSdkMeetingLiveConnectorConfiguration : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// MuxType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration.html#cfn-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration-muxtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MuxType { get; set; }
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration.html#cfn-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration-sourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.SourceConfiguration SourceConfiguration { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration.html#cfn-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
            /// <summary>
            /// CompositedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration.html#cfn-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration-compositedvideo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CompositedVideoArtifactsConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.CompositedVideoArtifactsConfiguration CompositedVideo { get; set; }
        }

        public class CompositedVideoArtifactsConfiguration : Humidifier.Base.BaseSubResource, IHaveResolution, IHaveLayout
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration.html#cfn-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration-layout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Layout { get; set; }
            /// <summary>
            /// GridViewConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration.html#cfn-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration-gridviewconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: GridViewConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration GridViewConfiguration { get; set; }
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration.html#cfn-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration-resolution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resolution { get; set; }
        }

        public class GridViewConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ContentShareLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-contentsharelayout
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentShareLayout { get; set; }
            /// <summary>
            /// PresenterOnlyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-presenteronlyconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PresenterOnlyConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.PresenterOnlyConfiguration PresenterOnlyConfiguration { get; set; }
            /// <summary>
            /// VideoAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-videoattribute
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VideoAttribute
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.VideoAttribute VideoAttribute { get; set; }
            /// <summary>
            /// HorizontalLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-horizontallayoutconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HorizontalLayoutConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.HorizontalLayoutConfiguration HorizontalLayoutConfiguration { get; set; }
            /// <summary>
            /// CanvasOrientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-canvasorientation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CanvasOrientation { get; set; }
            /// <summary>
            /// ActiveSpeakerOnlyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-activespeakeronlyconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ActiveSpeakerOnlyConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.ActiveSpeakerOnlyConfiguration ActiveSpeakerOnlyConfiguration { get; set; }
            /// <summary>
            /// VerticalLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-verticallayoutconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VerticalLayoutConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.VerticalLayoutConfiguration VerticalLayoutConfiguration { get; set; }
        }

        public class HorizontalLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TileAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-horizontallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-horizontallayoutconfiguration-tileaspectratio
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TileAspectRatio { get; set; }
            /// <summary>
            /// TilePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-horizontallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-horizontallayoutconfiguration-tileposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TilePosition { get; set; }
            /// <summary>
            /// TileOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-horizontallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-horizontallayoutconfiguration-tileorder
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TileOrder { get; set; }
            /// <summary>
            /// TileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-horizontallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-horizontallayoutconfiguration-tilecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TileCount { get; set; }
        }

        public class LiveConnectorRTMPConfiguration : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// AudioSampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration-audiosamplerate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioSampleRate { get; set; }
            /// <summary>
            /// AudioChannels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration-audiochannels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioChannels { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration-url
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class LiveConnectorSinkConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RTMPConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorsinkconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorsinkconfiguration-rtmpconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: LiveConnectorRTMPConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration RTMPConfiguration { get; set; }
            /// <summary>
            /// SinkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorsinkconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorsinkconfiguration-sinktype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SinkType { get; set; }
        }

        public class LiveConnectorSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceType
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorsourceconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorsourceconfiguration-sourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
            /// <summary>
            /// ChimeSdkMeetingLiveConnectorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorsourceconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorsourceconfiguration-chimesdkmeetingliveconnectorconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ChimeSdkMeetingLiveConnectorConfiguration
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.ChimeSdkMeetingLiveConnectorConfiguration ChimeSdkMeetingLiveConnectorConfiguration { get; set; }
        }

        public class PresenterOnlyConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PresenterPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-presenteronlyconfiguration.html#cfn-chime-medialiveconnectorpipeline-presenteronlyconfiguration-presenterposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PresenterPosition { get; set; }
        }

        public class SelectedVideoStreams : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExternalUserIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-selectedvideostreams.html#cfn-chime-medialiveconnectorpipeline-selectedvideostreams-externaluserids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExternalUserIds { get; set; }
            /// <summary>
            /// AttendeeIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-selectedvideostreams.html#cfn-chime-medialiveconnectorpipeline-selectedvideostreams-attendeeids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AttendeeIds { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelectedVideoStreams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-sourceconfiguration.html#cfn-chime-medialiveconnectorpipeline-sourceconfiguration-selectedvideostreams
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SelectedVideoStreams
            /// </summary>
            public Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams SelectedVideoStreams { get; set; }
        }

        public class VerticalLayoutConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TileAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-verticallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-verticallayoutconfiguration-tileaspectratio
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TileAspectRatio { get; set; }
            /// <summary>
            /// TilePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-verticallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-verticallayoutconfiguration-tileposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TilePosition { get; set; }
            /// <summary>
            /// TileOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-verticallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-verticallayoutconfiguration-tileorder
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TileOrder { get; set; }
            /// <summary>
            /// TileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-verticallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-verticallayoutconfiguration-tilecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TileCount { get; set; }
        }

        public class VideoAttribute : Humidifier.Base.BaseSubResource, IHaveBorderThickness, IHaveBorderColor
        {
            /// <summary>
            /// CornerRadius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-videoattribute.html#cfn-chime-medialiveconnectorpipeline-videoattribute-cornerradius
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CornerRadius { get; set; }
            /// <summary>
            /// BorderThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-videoattribute.html#cfn-chime-medialiveconnectorpipeline-videoattribute-borderthickness
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BorderThickness { get; set; }
            /// <summary>
            /// BorderColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-videoattribute.html#cfn-chime-medialiveconnectorpipeline-videoattribute-bordercolor
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BorderColor { get; set; }
            /// <summary>
            /// HighlightColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-videoattribute.html#cfn-chime-medialiveconnectorpipeline-videoattribute-highlightcolor
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HighlightColor { get; set; }
        }
    }
}