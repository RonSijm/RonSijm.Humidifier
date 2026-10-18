namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaLiveConnectorPipelineTypes;

    public class MediaLiveConnectorPipeline : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfChimeMediaLiveConnectorPipelineTypesLiveConnectorSinkConfigurationSinks, IHaveListOfChimeMediaLiveConnectorPipelineTypesLiveConnectorSourceConfigurationSources
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
        public Union<IReadOnlyList<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration>, IReadOnlyList<Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSinkConfiguration, BaseFunction>>, BaseFunction>? Sinks { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-medialiveconnectorpipeline.html#cfn-chime-medialiveconnectorpipeline-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LiveConnectorSourceConfiguration
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSourceConfiguration>, IReadOnlyList<Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorSourceConfiguration, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-medialiveconnectorpipeline.html#cfn-chime-medialiveconnectorpipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MediaLiveConnectorPipelineTypes
    {
        public class ActiveSpeakerOnlyConfiguration : Humidifier.Base.BaseSubResource, IHaveActiveSpeakerPosition
        {
            /// <summary>
            /// ActiveSpeakerPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-activespeakeronlyconfiguration.html#cfn-chime-medialiveconnectorpipeline-activespeakeronlyconfiguration-activespeakerposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActiveSpeakerPosition { get; set; }
        }

        public class ChimeSdkMeetingLiveConnectorConfiguration : Humidifier.Base.BaseSubResource, IHaveMuxType, IHaveChimeMediaLiveConnectorPipelineTypesSourceConfigurationSourceConfiguration, IHaveArn, IHaveChimeMediaLiveConnectorPipelineTypesCompositedVideoArtifactsConfigurationCompositedVideo
        {
            /// <summary>
            /// MuxType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration.html#cfn-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration-muxtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MuxType { get; set; }
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration.html#cfn-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration-sourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration.html#cfn-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration-arn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// CompositedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration.html#cfn-chime-medialiveconnectorpipeline-chimesdkmeetingliveconnectorconfiguration-compositedvideo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CompositedVideoArtifactsConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.CompositedVideoArtifactsConfiguration, BaseFunction>? CompositedVideo { get; set; }
        }

        public class CompositedVideoArtifactsConfiguration : Humidifier.Base.BaseSubResource, IHaveLayout, IHaveChimeMediaLiveConnectorPipelineTypesGridViewConfigurationGridViewConfiguration, IHaveResolution
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration.html#cfn-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration-layout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Layout { get; set; }
            /// <summary>
            /// GridViewConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration.html#cfn-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration-gridviewconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: GridViewConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.GridViewConfiguration, BaseFunction>? GridViewConfiguration { get; set; }
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration.html#cfn-chime-medialiveconnectorpipeline-compositedvideoartifactsconfiguration-resolution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resolution { get; set; }
        }

        public class GridViewConfiguration : Humidifier.Base.BaseSubResource, IHaveContentShareLayout, IHaveChimeMediaLiveConnectorPipelineTypesPresenterOnlyConfigurationPresenterOnlyConfiguration, IHaveChimeMediaLiveConnectorPipelineTypesVideoAttributeVideoAttribute, IHaveChimeMediaLiveConnectorPipelineTypesHorizontalLayoutConfigurationHorizontalLayoutConfiguration, IHaveCanvasOrientation, IHaveChimeMediaLiveConnectorPipelineTypesActiveSpeakerOnlyConfigurationActiveSpeakerOnlyConfiguration, IHaveChimeMediaLiveConnectorPipelineTypesVerticalLayoutConfigurationVerticalLayoutConfiguration
        {
            /// <summary>
            /// ContentShareLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-contentsharelayout
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentShareLayout { get; set; }
            /// <summary>
            /// PresenterOnlyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-presenteronlyconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PresenterOnlyConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.PresenterOnlyConfiguration, BaseFunction>? PresenterOnlyConfiguration { get; set; }
            /// <summary>
            /// VideoAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-videoattribute
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VideoAttribute
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.VideoAttribute, BaseFunction>? VideoAttribute { get; set; }
            /// <summary>
            /// HorizontalLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-horizontallayoutconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HorizontalLayoutConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.HorizontalLayoutConfiguration, BaseFunction>? HorizontalLayoutConfiguration { get; set; }
            /// <summary>
            /// CanvasOrientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-canvasorientation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CanvasOrientation { get; set; }
            /// <summary>
            /// ActiveSpeakerOnlyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-activespeakeronlyconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ActiveSpeakerOnlyConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.ActiveSpeakerOnlyConfiguration, BaseFunction>? ActiveSpeakerOnlyConfiguration { get; set; }
            /// <summary>
            /// VerticalLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-gridviewconfiguration.html#cfn-chime-medialiveconnectorpipeline-gridviewconfiguration-verticallayoutconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VerticalLayoutConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.VerticalLayoutConfiguration, BaseFunction>? VerticalLayoutConfiguration { get; set; }
        }

        public class HorizontalLayoutConfiguration : Humidifier.Base.BaseSubResource, IHaveTileAspectRatio, IHaveTilePosition, IHaveTileOrder, IHaveTileCount_Integer
        {
            /// <summary>
            /// TileAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-horizontallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-horizontallayoutconfiguration-tileaspectratio
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TileAspectRatio { get; set; }
            /// <summary>
            /// TilePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-horizontallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-horizontallayoutconfiguration-tileposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TilePosition { get; set; }
            /// <summary>
            /// TileOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-horizontallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-horizontallayoutconfiguration-tileorder
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TileOrder { get; set; }
            /// <summary>
            /// TileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-horizontallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-horizontallayoutconfiguration-tilecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TileCount { get; set; }
        }

        public class LiveConnectorRTMPConfiguration : Humidifier.Base.BaseSubResource, IHaveAudioSampleRate, IHaveAudioChannels, IHaveUrl
        {
            /// <summary>
            /// AudioSampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration-audiosamplerate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioSampleRate { get; set; }
            /// <summary>
            /// AudioChannels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration-audiochannels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioChannels { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorrtmpconfiguration-url
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class LiveConnectorSinkConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaLiveConnectorPipelineTypesLiveConnectorRTMPConfigurationRTMPConfiguration, IHaveSinkType
        {
            /// <summary>
            /// RTMPConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorsinkconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorsinkconfiguration-rtmpconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: LiveConnectorRTMPConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.LiveConnectorRTMPConfiguration, BaseFunction>? RTMPConfiguration { get; set; }
            /// <summary>
            /// SinkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorsinkconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorsinkconfiguration-sinktype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SinkType { get; set; }
        }

        public class LiveConnectorSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceType, IHaveChimeMediaLiveConnectorPipelineTypesChimeSdkMeetingLiveConnectorConfigurationChimeSdkMeetingLiveConnectorConfiguration
        {
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorsourceconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorsourceconfiguration-sourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
            /// <summary>
            /// ChimeSdkMeetingLiveConnectorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-liveconnectorsourceconfiguration.html#cfn-chime-medialiveconnectorpipeline-liveconnectorsourceconfiguration-chimesdkmeetingliveconnectorconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ChimeSdkMeetingLiveConnectorConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.ChimeSdkMeetingLiveConnectorConfiguration, BaseFunction>? ChimeSdkMeetingLiveConnectorConfiguration { get; set; }
        }

        public class PresenterOnlyConfiguration : Humidifier.Base.BaseSubResource, IHavePresenterPosition
        {
            /// <summary>
            /// PresenterPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-presenteronlyconfiguration.html#cfn-chime-medialiveconnectorpipeline-presenteronlyconfiguration-presenterposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PresenterPosition { get; set; }
        }

        public class SelectedVideoStreams : Humidifier.Base.BaseSubResource, IHaveStringListOfExternalUserIds, IHaveStringListOfAttendeeIds
        {
            /// <summary>
            /// ExternalUserIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-selectedvideostreams.html#cfn-chime-medialiveconnectorpipeline-selectedvideostreams-externaluserids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExternalUserIds { get; set; }
            /// <summary>
            /// AttendeeIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-selectedvideostreams.html#cfn-chime-medialiveconnectorpipeline-selectedvideostreams-attendeeids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttendeeIds { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaLiveConnectorPipelineTypesSelectedVideoStreamsSelectedVideoStreams
        {
            /// <summary>
            /// SelectedVideoStreams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-sourceconfiguration.html#cfn-chime-medialiveconnectorpipeline-sourceconfiguration-selectedvideostreams
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SelectedVideoStreams
            /// </summary>
            public Union<Humidifier.Chime.MediaLiveConnectorPipelineTypes.SelectedVideoStreams, BaseFunction>? SelectedVideoStreams { get; set; }
        }

        public class VerticalLayoutConfiguration : Humidifier.Base.BaseSubResource, IHaveTileAspectRatio, IHaveTilePosition, IHaveTileOrder, IHaveTileCount_Integer
        {
            /// <summary>
            /// TileAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-verticallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-verticallayoutconfiguration-tileaspectratio
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TileAspectRatio { get; set; }
            /// <summary>
            /// TilePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-verticallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-verticallayoutconfiguration-tileposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TilePosition { get; set; }
            /// <summary>
            /// TileOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-verticallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-verticallayoutconfiguration-tileorder
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TileOrder { get; set; }
            /// <summary>
            /// TileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-verticallayoutconfiguration.html#cfn-chime-medialiveconnectorpipeline-verticallayoutconfiguration-tilecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TileCount { get; set; }
        }

        public class VideoAttribute : Humidifier.Base.BaseSubResource, IHaveCornerRadius_Integer, IHaveBorderThickness_Integer, IHaveBorderColor, IHaveHighlightColor
        {
            /// <summary>
            /// CornerRadius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-videoattribute.html#cfn-chime-medialiveconnectorpipeline-videoattribute-cornerradius
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CornerRadius { get; set; }
            /// <summary>
            /// BorderThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-videoattribute.html#cfn-chime-medialiveconnectorpipeline-videoattribute-borderthickness
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BorderThickness { get; set; }
            /// <summary>
            /// BorderColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-videoattribute.html#cfn-chime-medialiveconnectorpipeline-videoattribute-bordercolor
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BorderColor { get; set; }
            /// <summary>
            /// HighlightColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-medialiveconnectorpipeline-videoattribute.html#cfn-chime-medialiveconnectorpipeline-videoattribute-highlightcolor
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HighlightColor { get; set; }
        }
    }
}