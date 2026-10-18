namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaCapturePipelineTypes;

    public class MediaCapturePipeline : Humidifier.Base.BaseResource, IHaveTags, IHaveChimeMediaCapturePipelineTypesSseAwsKeyManagementParamsSseAwsKeyManagementParams, IHaveChimeMediaCapturePipelineTypesChimeSdkMeetingConfigurationChimeSdkMeetingConfiguration, IHaveSourceType, IHaveSinkArn, IHaveSinkType, IHaveSinkIamRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string SourceArn =  "SourceArn" ;
            public static string MediaPipelineId =  "MediaPipelineId" ;
            public static string MediaPipelineArn =  "MediaPipelineArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.MediaCapturePipeline; }
        /// <summary>
        /// SseAwsKeyManagementParams
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediacapturepipeline.html#cfn-chime-mediacapturepipeline-sseawskeymanagementparams
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SseAwsKeyManagementParams
        /// </summary>
        public Union<Humidifier.Chime.MediaCapturePipelineTypes.SseAwsKeyManagementParams, BaseFunction>? SseAwsKeyManagementParams { get; set; }
        /// <summary>
        /// ChimeSdkMeetingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediacapturepipeline.html#cfn-chime-mediacapturepipeline-chimesdkmeetingconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ChimeSdkMeetingConfiguration
        /// </summary>
        public Union<Humidifier.Chime.MediaCapturePipelineTypes.ChimeSdkMeetingConfiguration, BaseFunction>? ChimeSdkMeetingConfiguration { get; set; }

        /// <summary>
        /// SourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediacapturepipeline.html#cfn-chime-mediacapturepipeline-sourcetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceType { get; set; }

        /// <summary>
        /// SinkArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediacapturepipeline.html#cfn-chime-mediacapturepipeline-sinkarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SinkArn { get; set; }

        /// <summary>
        /// SinkType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediacapturepipeline.html#cfn-chime-mediacapturepipeline-sinktype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SinkType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediacapturepipeline.html#cfn-chime-mediacapturepipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// SinkIamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediacapturepipeline.html#cfn-chime-mediacapturepipeline-sinkiamrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SinkIamRoleArn { get; set; }
    }

    namespace MediaCapturePipelineTypes
    {
        public class ActiveSpeakerOnlyConfiguration : Humidifier.Base.BaseSubResource, IHaveActiveSpeakerPosition
        {
            /// <summary>
            /// ActiveSpeakerPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-activespeakeronlyconfiguration.html#cfn-chime-mediacapturepipeline-activespeakeronlyconfiguration-activespeakerposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActiveSpeakerPosition { get; set; }
        }

        public class ArtifactsConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaCapturePipelineTypesVideoArtifactsConfigurationVideo, IHaveChimeMediaCapturePipelineTypesContentArtifactsConfigurationContent, IHaveChimeMediaCapturePipelineTypesAudioArtifactsConfigurationAudio, IHaveChimeMediaCapturePipelineTypesCompositedVideoArtifactsConfigurationCompositedVideo
        {
            /// <summary>
            /// Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-artifactsconfiguration.html#cfn-chime-mediacapturepipeline-artifactsconfiguration-video
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VideoArtifactsConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.VideoArtifactsConfiguration, BaseFunction>? Video { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-artifactsconfiguration.html#cfn-chime-mediacapturepipeline-artifactsconfiguration-content
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ContentArtifactsConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.ContentArtifactsConfiguration, BaseFunction>? Content { get; set; }
            /// <summary>
            /// Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-artifactsconfiguration.html#cfn-chime-mediacapturepipeline-artifactsconfiguration-audio
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AudioArtifactsConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.AudioArtifactsConfiguration, BaseFunction>? Audio { get; set; }
            /// <summary>
            /// CompositedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-artifactsconfiguration.html#cfn-chime-mediacapturepipeline-artifactsconfiguration-compositedvideo
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CompositedVideoArtifactsConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.CompositedVideoArtifactsConfiguration, BaseFunction>? CompositedVideo { get; set; }
        }

        public class AudioArtifactsConfiguration : Humidifier.Base.BaseSubResource, IHaveMuxType
        {
            /// <summary>
            /// MuxType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-audioartifactsconfiguration.html#cfn-chime-mediacapturepipeline-audioartifactsconfiguration-muxtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MuxType { get; set; }
        }

        public class ChimeSdkMeetingConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaCapturePipelineTypesSourceConfigurationSourceConfiguration, IHaveChimeMediaCapturePipelineTypesArtifactsConfigurationArtifactsConfiguration
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-chimesdkmeetingconfiguration.html#cfn-chime-mediacapturepipeline-chimesdkmeetingconfiguration-sourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.SourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
            /// <summary>
            /// ArtifactsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-chimesdkmeetingconfiguration.html#cfn-chime-mediacapturepipeline-chimesdkmeetingconfiguration-artifactsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ArtifactsConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.ArtifactsConfiguration, BaseFunction>? ArtifactsConfiguration { get; set; }
        }

        public class CompositedVideoArtifactsConfiguration : Humidifier.Base.BaseSubResource, IHaveLayout, IHaveChimeMediaCapturePipelineTypesGridViewConfigurationGridViewConfiguration, IHaveResolution
        {
            /// <summary>
            /// Layout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-compositedvideoartifactsconfiguration.html#cfn-chime-mediacapturepipeline-compositedvideoartifactsconfiguration-layout
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Layout { get; set; }
            /// <summary>
            /// GridViewConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-compositedvideoartifactsconfiguration.html#cfn-chime-mediacapturepipeline-compositedvideoartifactsconfiguration-gridviewconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: GridViewConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.GridViewConfiguration, BaseFunction>? GridViewConfiguration { get; set; }
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-compositedvideoartifactsconfiguration.html#cfn-chime-mediacapturepipeline-compositedvideoartifactsconfiguration-resolution
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resolution { get; set; }
        }

        public class ContentArtifactsConfiguration : Humidifier.Base.BaseSubResource, IHaveMuxType, IHaveState
        {
            /// <summary>
            /// MuxType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-contentartifactsconfiguration.html#cfn-chime-mediacapturepipeline-contentartifactsconfiguration-muxtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MuxType { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-contentartifactsconfiguration.html#cfn-chime-mediacapturepipeline-contentartifactsconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class GridViewConfiguration : Humidifier.Base.BaseSubResource, IHaveContentShareLayout, IHaveChimeMediaCapturePipelineTypesPresenterOnlyConfigurationPresenterOnlyConfiguration, IHaveChimeMediaCapturePipelineTypesVideoAttributeVideoAttribute, IHaveChimeMediaCapturePipelineTypesHorizontalLayoutConfigurationHorizontalLayoutConfiguration, IHaveCanvasOrientation, IHaveChimeMediaCapturePipelineTypesActiveSpeakerOnlyConfigurationActiveSpeakerOnlyConfiguration, IHaveChimeMediaCapturePipelineTypesVerticalLayoutConfigurationVerticalLayoutConfiguration
        {
            /// <summary>
            /// ContentShareLayout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-gridviewconfiguration.html#cfn-chime-mediacapturepipeline-gridviewconfiguration-contentsharelayout
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentShareLayout { get; set; }
            /// <summary>
            /// PresenterOnlyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-gridviewconfiguration.html#cfn-chime-mediacapturepipeline-gridviewconfiguration-presenteronlyconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PresenterOnlyConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.PresenterOnlyConfiguration, BaseFunction>? PresenterOnlyConfiguration { get; set; }
            /// <summary>
            /// VideoAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-gridviewconfiguration.html#cfn-chime-mediacapturepipeline-gridviewconfiguration-videoattribute
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VideoAttribute
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.VideoAttribute, BaseFunction>? VideoAttribute { get; set; }
            /// <summary>
            /// HorizontalLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-gridviewconfiguration.html#cfn-chime-mediacapturepipeline-gridviewconfiguration-horizontallayoutconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HorizontalLayoutConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.HorizontalLayoutConfiguration, BaseFunction>? HorizontalLayoutConfiguration { get; set; }
            /// <summary>
            /// CanvasOrientation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-gridviewconfiguration.html#cfn-chime-mediacapturepipeline-gridviewconfiguration-canvasorientation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CanvasOrientation { get; set; }
            /// <summary>
            /// ActiveSpeakerOnlyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-gridviewconfiguration.html#cfn-chime-mediacapturepipeline-gridviewconfiguration-activespeakeronlyconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ActiveSpeakerOnlyConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.ActiveSpeakerOnlyConfiguration, BaseFunction>? ActiveSpeakerOnlyConfiguration { get; set; }
            /// <summary>
            /// VerticalLayoutConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-gridviewconfiguration.html#cfn-chime-mediacapturepipeline-gridviewconfiguration-verticallayoutconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VerticalLayoutConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.VerticalLayoutConfiguration, BaseFunction>? VerticalLayoutConfiguration { get; set; }
        }

        public class HorizontalLayoutConfiguration : Humidifier.Base.BaseSubResource, IHaveTileAspectRatio, IHaveTilePosition, IHaveTileOrder, IHaveTileCount_Integer
        {
            /// <summary>
            /// TileAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-horizontallayoutconfiguration.html#cfn-chime-mediacapturepipeline-horizontallayoutconfiguration-tileaspectratio
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TileAspectRatio { get; set; }
            /// <summary>
            /// TilePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-horizontallayoutconfiguration.html#cfn-chime-mediacapturepipeline-horizontallayoutconfiguration-tileposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TilePosition { get; set; }
            /// <summary>
            /// TileOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-horizontallayoutconfiguration.html#cfn-chime-mediacapturepipeline-horizontallayoutconfiguration-tileorder
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TileOrder { get; set; }
            /// <summary>
            /// TileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-horizontallayoutconfiguration.html#cfn-chime-mediacapturepipeline-horizontallayoutconfiguration-tilecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TileCount { get; set; }
        }

        public class PresenterOnlyConfiguration : Humidifier.Base.BaseSubResource, IHavePresenterPosition
        {
            /// <summary>
            /// PresenterPosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-presenteronlyconfiguration.html#cfn-chime-mediacapturepipeline-presenteronlyconfiguration-presenterposition
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-selectedvideostreams.html#cfn-chime-mediacapturepipeline-selectedvideostreams-externaluserids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExternalUserIds { get; set; }
            /// <summary>
            /// AttendeeIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-selectedvideostreams.html#cfn-chime-mediacapturepipeline-selectedvideostreams-attendeeids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttendeeIds { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaCapturePipelineTypesSelectedVideoStreamsSelectedVideoStreams
        {
            /// <summary>
            /// SelectedVideoStreams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-sourceconfiguration.html#cfn-chime-mediacapturepipeline-sourceconfiguration-selectedvideostreams
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SelectedVideoStreams
            /// </summary>
            public Union<Humidifier.Chime.MediaCapturePipelineTypes.SelectedVideoStreams, BaseFunction>? SelectedVideoStreams { get; set; }
        }

        public class SseAwsKeyManagementParams : Humidifier.Base.BaseSubResource, IHaveAwsKmsKeyId, IHaveAwsKmsEncryptionContext
        {
            /// <summary>
            /// AwsKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-sseawskeymanagementparams.html#cfn-chime-mediacapturepipeline-sseawskeymanagementparams-awskmskeyid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsKmsKeyId { get; set; }
            /// <summary>
            /// AwsKmsEncryptionContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-sseawskeymanagementparams.html#cfn-chime-mediacapturepipeline-sseawskeymanagementparams-awskmsencryptioncontext
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsKmsEncryptionContext { get; set; }
        }

        public class VerticalLayoutConfiguration : Humidifier.Base.BaseSubResource, IHaveTileAspectRatio, IHaveTilePosition, IHaveTileOrder, IHaveTileCount_Integer
        {
            /// <summary>
            /// TileAspectRatio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-verticallayoutconfiguration.html#cfn-chime-mediacapturepipeline-verticallayoutconfiguration-tileaspectratio
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TileAspectRatio { get; set; }
            /// <summary>
            /// TilePosition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-verticallayoutconfiguration.html#cfn-chime-mediacapturepipeline-verticallayoutconfiguration-tileposition
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TilePosition { get; set; }
            /// <summary>
            /// TileOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-verticallayoutconfiguration.html#cfn-chime-mediacapturepipeline-verticallayoutconfiguration-tileorder
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TileOrder { get; set; }
            /// <summary>
            /// TileCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-verticallayoutconfiguration.html#cfn-chime-mediacapturepipeline-verticallayoutconfiguration-tilecount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TileCount { get; set; }
        }

        public class VideoArtifactsConfiguration : Humidifier.Base.BaseSubResource, IHaveMuxType, IHaveState
        {
            /// <summary>
            /// MuxType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-videoartifactsconfiguration.html#cfn-chime-mediacapturepipeline-videoartifactsconfiguration-muxtype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MuxType { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-videoartifactsconfiguration.html#cfn-chime-mediacapturepipeline-videoartifactsconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class VideoAttribute : Humidifier.Base.BaseSubResource, IHaveCornerRadius_Integer, IHaveBorderThickness_Integer, IHaveBorderColor, IHaveHighlightColor
        {
            /// <summary>
            /// CornerRadius
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-videoattribute.html#cfn-chime-mediacapturepipeline-videoattribute-cornerradius
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CornerRadius { get; set; }
            /// <summary>
            /// BorderThickness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-videoattribute.html#cfn-chime-mediacapturepipeline-videoattribute-borderthickness
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BorderThickness { get; set; }
            /// <summary>
            /// BorderColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-videoattribute.html#cfn-chime-mediacapturepipeline-videoattribute-bordercolor
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BorderColor { get; set; }
            /// <summary>
            /// HighlightColor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediacapturepipeline-videoattribute.html#cfn-chime-mediacapturepipeline-videoattribute-highlightcolor
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HighlightColor { get; set; }
        }
    }
}