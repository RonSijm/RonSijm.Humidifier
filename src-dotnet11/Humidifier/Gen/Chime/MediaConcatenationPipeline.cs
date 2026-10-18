namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaConcatenationPipelineTypes;

    public class MediaConcatenationPipeline : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfChimeMediaConcatenationPipelineTypesConcatenationSinkSinks, IHaveListOfChimeMediaConcatenationPipelineTypesConcatenationSourceSources
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string MediaPipelineId =  "MediaPipelineId" ;
            public static string MediaPipelineArn =  "MediaPipelineArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.MediaConcatenationPipeline; }

        /// <summary>
        /// Sinks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediaconcatenationpipeline.html#cfn-chime-mediaconcatenationpipeline-sinks
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ConcatenationSink
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink>, IReadOnlyList<Union<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink, BaseFunction>>, BaseFunction>? Sinks { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediaconcatenationpipeline.html#cfn-chime-mediaconcatenationpipeline-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ConcatenationSource
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource>, IReadOnlyList<Union<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediaconcatenationpipeline.html#cfn-chime-mediaconcatenationpipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MediaConcatenationPipelineTypes
    {
        public class ArtifactsConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaConcatenationPipelineTypesDataChannelConcatenationConfigurationDataChannel, IHaveChimeMediaConcatenationPipelineTypesVideoConcatenationConfigurationVideo, IHaveChimeMediaConcatenationPipelineTypesContentConcatenationConfigurationContent, IHaveChimeMediaConcatenationPipelineTypesMeetingEventsConcatenationConfigurationMeetingEvents, IHaveChimeMediaConcatenationPipelineTypesAudioConcatenationConfigurationAudio, IHaveChimeMediaConcatenationPipelineTypesTranscriptionMessagesConcatenationConfigurationTranscriptionMessages, IHaveChimeMediaConcatenationPipelineTypesCompositedVideoConcatenationConfigurationCompositedVideo
        {
            /// <summary>
            /// DataChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-datachannel
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataChannelConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.DataChannelConcatenationConfiguration, BaseFunction>? DataChannel { get; set; }
            /// <summary>
            /// Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-video
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VideoConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.VideoConcatenationConfiguration, BaseFunction>? Video { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-content
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ContentConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.ContentConcatenationConfiguration, BaseFunction>? Content { get; set; }
            /// <summary>
            /// MeetingEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-meetingevents
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MeetingEventsConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.MeetingEventsConcatenationConfiguration, BaseFunction>? MeetingEvents { get; set; }
            /// <summary>
            /// Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-audio
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AudioConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.AudioConcatenationConfiguration, BaseFunction>? Audio { get; set; }
            /// <summary>
            /// TranscriptionMessages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-transcriptionmessages
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TranscriptionMessagesConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.TranscriptionMessagesConcatenationConfiguration, BaseFunction>? TranscriptionMessages { get; set; }
            /// <summary>
            /// CompositedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-compositedvideo
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CompositedVideoConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.CompositedVideoConcatenationConfiguration, BaseFunction>? CompositedVideo { get; set; }
        }

        public class AudioConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-audioconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-audioconcatenationconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class ChimeSdkMeetingConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaConcatenationPipelineTypesArtifactsConcatenationConfigurationArtifactsConfiguration
        {
            /// <summary>
            /// ArtifactsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-chimesdkmeetingconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-chimesdkmeetingconcatenationconfiguration-artifactsconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ArtifactsConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration, BaseFunction>? ArtifactsConfiguration { get; set; }
        }

        public class CompositedVideoConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-compositedvideoconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-compositedvideoconcatenationconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class ConcatenationSink : Humidifier.Base.BaseSubResource, IHaveType, IHaveChimeMediaConcatenationPipelineTypesS3BucketSinkConfigurationS3BucketSinkConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-concatenationsink.html#cfn-chime-mediaconcatenationpipeline-concatenationsink-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// S3BucketSinkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-concatenationsink.html#cfn-chime-mediaconcatenationpipeline-concatenationsink-s3bucketsinkconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3BucketSinkConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration, BaseFunction>? S3BucketSinkConfiguration { get; set; }
        }

        public class ConcatenationSource : Humidifier.Base.BaseSubResource, IHaveType, IHaveChimeMediaConcatenationPipelineTypesMediaCapturePipelineSourceConfigurationMediaCapturePipelineSourceConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-concatenationsource.html#cfn-chime-mediaconcatenationpipeline-concatenationsource-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// MediaCapturePipelineSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-concatenationsource.html#cfn-chime-mediaconcatenationpipeline-concatenationsource-mediacapturepipelinesourceconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MediaCapturePipelineSourceConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration, BaseFunction>? MediaCapturePipelineSourceConfiguration { get; set; }
        }

        public class ContentConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-contentconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-contentconcatenationconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class DataChannelConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-datachannelconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-datachannelconcatenationconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class MediaCapturePipelineSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaConcatenationPipelineTypesChimeSdkMeetingConcatenationConfigurationChimeSdkMeetingConfiguration, IHaveMediaPipelineArn
        {
            /// <summary>
            /// ChimeSdkMeetingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-mediacapturepipelinesourceconfiguration.html#cfn-chime-mediaconcatenationpipeline-mediacapturepipelinesourceconfiguration-chimesdkmeetingconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ChimeSdkMeetingConcatenationConfiguration
            /// </summary>
            public Union<Humidifier.Chime.MediaConcatenationPipelineTypes.ChimeSdkMeetingConcatenationConfiguration, BaseFunction>? ChimeSdkMeetingConfiguration { get; set; }
            /// <summary>
            /// MediaPipelineArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-mediacapturepipelinesourceconfiguration.html#cfn-chime-mediaconcatenationpipeline-mediacapturepipelinesourceconfiguration-mediapipelinearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaPipelineArn { get; set; }
        }

        public class MeetingEventsConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-meetingeventsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-meetingeventsconcatenationconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class S3BucketSinkConfiguration : Humidifier.Base.BaseSubResource, IHaveDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-s3bucketsinkconfiguration.html#cfn-chime-mediaconcatenationpipeline-s3bucketsinkconfiguration-destination
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
        }

        public class TranscriptionMessagesConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-transcriptionmessagesconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-transcriptionmessagesconcatenationconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }

        public class VideoConcatenationConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-videoconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-videoconcatenationconfiguration-state
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
        }
    }
}