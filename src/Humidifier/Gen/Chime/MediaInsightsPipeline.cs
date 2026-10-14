namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaInsightsPipelineTypes;

    public class MediaInsightsPipeline : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string MediaPipelineId =  "MediaPipelineId" ;
            public static string MediaPipelineArn =  "MediaPipelineArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.MediaInsightsPipeline; }
        /// <summary>
        /// KinesisVideoStreamSourceRuntimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: KinesisVideoStreamSourceRuntimeConfiguration
        /// </summary>
        public Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamSourceRuntimeConfiguration KinesisVideoStreamSourceRuntimeConfiguration { get; set; }
        /// <summary>
        /// S3RecordingSinkRuntimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3RecordingSinkRuntimeConfiguration
        /// </summary>
        public Humidifier.Chime.MediaInsightsPipelineTypes.S3RecordingSinkRuntimeConfiguration S3RecordingSinkRuntimeConfiguration { get; set; }
        /// <summary>
        /// MediaInsightsRuntimeMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-mediainsightsruntimemetadata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> MediaInsightsRuntimeMetadata { get; set; }
        /// <summary>
        /// KinesisVideoStreamRecordingSourceRuntimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: KinesisVideoStreamRecordingSourceRuntimeConfiguration
        /// </summary>
        public Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamRecordingSourceRuntimeConfiguration KinesisVideoStreamRecordingSourceRuntimeConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// MediaInsightsPipelineConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-mediainsightspipelineconfigurationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MediaInsightsPipelineConfigurationArn { get; set; }
    }

    namespace MediaInsightsPipelineTypes
    {
        public class ChannelDefinition : Humidifier.Base.BaseSubResource, IHaveChannelId
        {
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-channeldefinition.html#cfn-chime-mediainsightspipeline-channeldefinition-channelid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ChannelId { get; set; }
            /// <summary>
            /// ParticipantRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-channeldefinition.html#cfn-chime-mediainsightspipeline-channeldefinition-participantrole
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParticipantRole { get; set; }
        }

        public class FragmentSelector : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FragmentSelectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-fragmentselector.html#cfn-chime-mediainsightspipeline-fragmentselector-fragmentselectortype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FragmentSelectorType { get; set; }
            /// <summary>
            /// TimestampRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-fragmentselector.html#cfn-chime-mediainsightspipeline-fragmentselector-timestamprange
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TimestampRange
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange TimestampRange { get; set; }
        }

        public class KinesisVideoStreamRecordingSourceRuntimeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FragmentSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration-fragmentselector
            /// Required: True
            /// UpdateType: Immutable
            /// Type: FragmentSelector
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector FragmentSelector { get; set; }
            /// <summary>
            /// Streams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration-streams
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RecordingStreamConfiguration
            /// </summary>
            public List<Humidifier.Chime.MediaInsightsPipelineTypes.RecordingStreamConfiguration> Streams { get; set; }
        }

        public class KinesisVideoStreamSourceRuntimeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaSampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration-mediasamplerate
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MediaSampleRate { get; set; }
            /// <summary>
            /// MediaEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration-mediaencoding
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaEncoding { get; set; }
            /// <summary>
            /// Streams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration-streams
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: StreamConfiguration
            /// </summary>
            public List<Humidifier.Chime.MediaInsightsPipelineTypes.StreamConfiguration> Streams { get; set; }
        }

        public class RecordingStreamConfiguration : Humidifier.Base.BaseSubResource, IHaveStreamArn
        {
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-recordingstreamconfiguration.html#cfn-chime-mediainsightspipeline-recordingstreamconfiguration-streamarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamArn { get; set; }
        }

        public class S3RecordingSinkRuntimeConfiguration : Humidifier.Base.BaseSubResource, IHaveDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration.html#cfn-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration-destination
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Destination { get; set; }
            /// <summary>
            /// RecordingFileFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration.html#cfn-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration-recordingfileformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordingFileFormat { get; set; }
        }

        public class StreamChannelDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChannelDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamchanneldefinition.html#cfn-chime-mediainsightspipeline-streamchanneldefinition-channeldefinitions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ChannelDefinition
            /// </summary>
            public List<Humidifier.Chime.MediaInsightsPipelineTypes.ChannelDefinition> ChannelDefinitions { get; set; }
            /// <summary>
            /// NumberOfChannels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamchanneldefinition.html#cfn-chime-mediainsightspipeline-streamchanneldefinition-numberofchannels
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumberOfChannels { get; set; }
        }

        public class StreamConfiguration : Humidifier.Base.BaseSubResource, IHaveStreamArn
        {
            /// <summary>
            /// FragmentNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamconfiguration.html#cfn-chime-mediainsightspipeline-streamconfiguration-fragmentnumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FragmentNumber { get; set; }
            /// <summary>
            /// StreamChannelDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamconfiguration.html#cfn-chime-mediainsightspipeline-streamconfiguration-streamchanneldefinition
            /// Required: True
            /// UpdateType: Immutable
            /// Type: StreamChannelDefinition
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineTypes.StreamChannelDefinition StreamChannelDefinition { get; set; }
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamconfiguration.html#cfn-chime-mediainsightspipeline-streamconfiguration-streamarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamArn { get; set; }
        }

        public class TimestampRange : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StartTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-timestamprange.html#cfn-chime-mediainsightspipeline-timestamprange-starttimestamp
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTimestamp { get; set; }
            /// <summary>
            /// EndTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-timestamprange.html#cfn-chime-mediainsightspipeline-timestamprange-endtimestamp
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTimestamp { get; set; }
        }
    }
}