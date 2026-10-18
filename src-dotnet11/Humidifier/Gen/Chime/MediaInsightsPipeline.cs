namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaInsightsPipelineTypes;

    public class MediaInsightsPipeline : Humidifier.Base.BaseResource, IHaveTags, IHaveChimeMediaInsightsPipelineTypesKinesisVideoStreamSourceRuntimeConfigurationKinesisVideoStreamSourceRuntimeConfiguration, IHaveChimeMediaInsightsPipelineTypesS3RecordingSinkRuntimeConfigurationS3RecordingSinkRuntimeConfiguration, IHaveStringDictionaryOfMediaInsightsRuntimeMetadata, IHaveChimeMediaInsightsPipelineTypesKinesisVideoStreamRecordingSourceRuntimeConfigurationKinesisVideoStreamRecordingSourceRuntimeConfiguration, IHaveMediaInsightsPipelineConfigurationArn
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
        public Union<Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamSourceRuntimeConfiguration, BaseFunction>? KinesisVideoStreamSourceRuntimeConfiguration { get; set; }
        /// <summary>
        /// S3RecordingSinkRuntimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: S3RecordingSinkRuntimeConfiguration
        /// </summary>
        public Union<Humidifier.Chime.MediaInsightsPipelineTypes.S3RecordingSinkRuntimeConfiguration, BaseFunction>? S3RecordingSinkRuntimeConfiguration { get; set; }
        /// <summary>
        /// MediaInsightsRuntimeMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-mediainsightsruntimemetadata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? MediaInsightsRuntimeMetadata { get; set; }
        /// <summary>
        /// KinesisVideoStreamRecordingSourceRuntimeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: KinesisVideoStreamRecordingSourceRuntimeConfiguration
        /// </summary>
        public Union<Humidifier.Chime.MediaInsightsPipelineTypes.KinesisVideoStreamRecordingSourceRuntimeConfiguration, BaseFunction>? KinesisVideoStreamRecordingSourceRuntimeConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// MediaInsightsPipelineConfigurationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipeline.html#cfn-chime-mediainsightspipeline-mediainsightspipelineconfigurationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MediaInsightsPipelineConfigurationArn { get; set; }
    }

    namespace MediaInsightsPipelineTypes
    {
        public class ChannelDefinition : Humidifier.Base.BaseSubResource, IHaveChannelId_Integer, IHaveParticipantRole
        {
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-channeldefinition.html#cfn-chime-mediainsightspipeline-channeldefinition-channelid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ChannelId { get; set; }
            /// <summary>
            /// ParticipantRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-channeldefinition.html#cfn-chime-mediainsightspipeline-channeldefinition-participantrole
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParticipantRole { get; set; }
        }

        public class FragmentSelector : Humidifier.Base.BaseSubResource, IHaveFragmentSelectorType, IHaveChimeMediaInsightsPipelineTypesTimestampRangeTimestampRange
        {
            /// <summary>
            /// FragmentSelectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-fragmentselector.html#cfn-chime-mediainsightspipeline-fragmentselector-fragmentselectortype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FragmentSelectorType { get; set; }
            /// <summary>
            /// TimestampRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-fragmentselector.html#cfn-chime-mediainsightspipeline-fragmentselector-timestamprange
            /// Required: True
            /// UpdateType: Immutable
            /// Type: TimestampRange
            /// </summary>
            public Union<Humidifier.Chime.MediaInsightsPipelineTypes.TimestampRange, BaseFunction>? TimestampRange { get; set; }
        }

        public class KinesisVideoStreamRecordingSourceRuntimeConfiguration : Humidifier.Base.BaseSubResource, IHaveChimeMediaInsightsPipelineTypesFragmentSelectorFragmentSelector, IHaveListOfChimeMediaInsightsPipelineTypesRecordingStreamConfigurationStreams
        {
            /// <summary>
            /// FragmentSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration-fragmentselector
            /// Required: True
            /// UpdateType: Immutable
            /// Type: FragmentSelector
            /// </summary>
            public Union<Humidifier.Chime.MediaInsightsPipelineTypes.FragmentSelector, BaseFunction>? FragmentSelector { get; set; }
            /// <summary>
            /// Streams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamrecordingsourceruntimeconfiguration-streams
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RecordingStreamConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Chime.MediaInsightsPipelineTypes.RecordingStreamConfiguration>, IReadOnlyList<Union<Humidifier.Chime.MediaInsightsPipelineTypes.RecordingStreamConfiguration, BaseFunction>>, BaseFunction>? Streams { get; set; }
        }

        public class KinesisVideoStreamSourceRuntimeConfiguration : Humidifier.Base.BaseSubResource, IHaveMediaSampleRate_Integer, IHaveMediaEncoding, IHaveListOfChimeMediaInsightsPipelineTypesStreamConfigurationStreams
        {
            /// <summary>
            /// MediaSampleRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration-mediasamplerate
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MediaSampleRate { get; set; }
            /// <summary>
            /// MediaEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration-mediaencoding
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaEncoding { get; set; }
            /// <summary>
            /// Streams
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration.html#cfn-chime-mediainsightspipeline-kinesisvideostreamsourceruntimeconfiguration-streams
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: StreamConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Chime.MediaInsightsPipelineTypes.StreamConfiguration>, IReadOnlyList<Union<Humidifier.Chime.MediaInsightsPipelineTypes.StreamConfiguration, BaseFunction>>, BaseFunction>? Streams { get; set; }
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
            public Union<string, BaseFunction>? StreamArn { get; set; }
        }

        public class S3RecordingSinkRuntimeConfiguration : Humidifier.Base.BaseSubResource, IHaveDestination, IHaveRecordingFileFormat
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration.html#cfn-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration-destination
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// RecordingFileFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration.html#cfn-chime-mediainsightspipeline-s3recordingsinkruntimeconfiguration-recordingfileformat
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecordingFileFormat { get; set; }
        }

        public class StreamChannelDefinition : Humidifier.Base.BaseSubResource, IHaveListOfChimeMediaInsightsPipelineTypesChannelDefinitionChannelDefinitions, IHaveNumberOfChannels_Integer
        {
            /// <summary>
            /// ChannelDefinitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamchanneldefinition.html#cfn-chime-mediainsightspipeline-streamchanneldefinition-channeldefinitions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ChannelDefinition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Chime.MediaInsightsPipelineTypes.ChannelDefinition>, IReadOnlyList<Union<Humidifier.Chime.MediaInsightsPipelineTypes.ChannelDefinition, BaseFunction>>, BaseFunction>? ChannelDefinitions { get; set; }
            /// <summary>
            /// NumberOfChannels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamchanneldefinition.html#cfn-chime-mediainsightspipeline-streamchanneldefinition-numberofchannels
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfChannels { get; set; }
        }

        public class StreamConfiguration : Humidifier.Base.BaseSubResource, IHaveFragmentNumber, IHaveChimeMediaInsightsPipelineTypesStreamChannelDefinitionStreamChannelDefinition, IHaveStreamArn
        {
            /// <summary>
            /// FragmentNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamconfiguration.html#cfn-chime-mediainsightspipeline-streamconfiguration-fragmentnumber
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FragmentNumber { get; set; }
            /// <summary>
            /// StreamChannelDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamconfiguration.html#cfn-chime-mediainsightspipeline-streamconfiguration-streamchanneldefinition
            /// Required: True
            /// UpdateType: Immutable
            /// Type: StreamChannelDefinition
            /// </summary>
            public Union<Humidifier.Chime.MediaInsightsPipelineTypes.StreamChannelDefinition, BaseFunction>? StreamChannelDefinition { get; set; }
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-streamconfiguration.html#cfn-chime-mediainsightspipeline-streamconfiguration-streamarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamArn { get; set; }
        }

        public class TimestampRange : Humidifier.Base.BaseSubResource, IHaveStartTimestamp, IHaveEndTimestamp
        {
            /// <summary>
            /// StartTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-timestamprange.html#cfn-chime-mediainsightspipeline-timestamprange-starttimestamp
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTimestamp { get; set; }
            /// <summary>
            /// EndTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipeline-timestamprange.html#cfn-chime-mediainsightspipeline-timestamprange-endtimestamp
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTimestamp { get; set; }
        }
    }
}