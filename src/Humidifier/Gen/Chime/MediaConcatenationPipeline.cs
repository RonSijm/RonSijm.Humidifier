namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaConcatenationPipelineTypes;

    public class MediaConcatenationPipeline : Humidifier.Base.BaseResource, IHaveTags
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
        public List<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> Sinks { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediaconcatenationpipeline.html#cfn-chime-mediaconcatenationpipeline-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ConcatenationSource
        /// </summary>
        [Required]
        public List<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediaconcatenationpipeline.html#cfn-chime-mediaconcatenationpipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace MediaConcatenationPipelineTypes
    {
        public class ArtifactsConcatenationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DataChannel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-datachannel
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataChannelConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.DataChannelConcatenationConfiguration DataChannel { get; set; }
            /// <summary>
            /// Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-video
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VideoConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.VideoConcatenationConfiguration Video { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-content
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ContentConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.ContentConcatenationConfiguration Content { get; set; }
            /// <summary>
            /// MeetingEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-meetingevents
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MeetingEventsConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.MeetingEventsConcatenationConfiguration MeetingEvents { get; set; }
            /// <summary>
            /// Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-audio
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AudioConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.AudioConcatenationConfiguration Audio { get; set; }
            /// <summary>
            /// TranscriptionMessages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-transcriptionmessages
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TranscriptionMessagesConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.TranscriptionMessagesConcatenationConfiguration TranscriptionMessages { get; set; }
            /// <summary>
            /// CompositedVideo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-artifactsconcatenationconfiguration-compositedvideo
            /// Required: True
            /// UpdateType: Immutable
            /// Type: CompositedVideoConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.CompositedVideoConcatenationConfiguration CompositedVideo { get; set; }
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
            public dynamic State { get; set; }
        }

        public class ChimeSdkMeetingConcatenationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ArtifactsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-chimesdkmeetingconcatenationconfiguration.html#cfn-chime-mediaconcatenationpipeline-chimesdkmeetingconcatenationconfiguration-artifactsconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ArtifactsConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.ArtifactsConcatenationConfiguration ArtifactsConfiguration { get; set; }
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
            public dynamic State { get; set; }
        }

        public class ConcatenationSink : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-concatenationsink.html#cfn-chime-mediaconcatenationpipeline-concatenationsink-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// S3BucketSinkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-concatenationsink.html#cfn-chime-mediaconcatenationpipeline-concatenationsink-s3bucketsinkconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3BucketSinkConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration S3BucketSinkConfiguration { get; set; }
        }

        public class ConcatenationSource : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-concatenationsource.html#cfn-chime-mediaconcatenationpipeline-concatenationsource-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// MediaCapturePipelineSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-concatenationsource.html#cfn-chime-mediaconcatenationpipeline-concatenationsource-mediacapturepipelinesourceconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MediaCapturePipelineSourceConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.MediaCapturePipelineSourceConfiguration MediaCapturePipelineSourceConfiguration { get; set; }
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
            public dynamic State { get; set; }
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
            public dynamic State { get; set; }
        }

        public class MediaCapturePipelineSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChimeSdkMeetingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-mediacapturepipelinesourceconfiguration.html#cfn-chime-mediaconcatenationpipeline-mediacapturepipelinesourceconfiguration-chimesdkmeetingconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ChimeSdkMeetingConcatenationConfiguration
            /// </summary>
            public Humidifier.Chime.MediaConcatenationPipelineTypes.ChimeSdkMeetingConcatenationConfiguration ChimeSdkMeetingConfiguration { get; set; }
            /// <summary>
            /// MediaPipelineArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediaconcatenationpipeline-mediacapturepipelinesourceconfiguration.html#cfn-chime-mediaconcatenationpipeline-mediacapturepipelinesourceconfiguration-mediapipelinearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaPipelineArn { get; set; }
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
            public dynamic State { get; set; }
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
            public dynamic Destination { get; set; }
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
            public dynamic State { get; set; }
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
            public dynamic State { get; set; }
        }
    }
}