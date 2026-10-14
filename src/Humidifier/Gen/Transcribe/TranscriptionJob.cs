namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using TranscriptionJobTypes;

    public class TranscriptionJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLanguageCode
    {
        public class Attributes
        {
            public static string Transcript =  "Transcript" ;
            public static string TranscriptionJobStatus =  "TranscriptionJobStatus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transcribe.TranscriptionJob; }
        /// <summary>
        /// MediaFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-mediaformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MediaFormat { get; set; }
        /// <summary>
        /// ContentRedaction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-contentredaction
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ContentRedaction
        /// </summary>
        public Humidifier.Transcribe.TranscriptionJobTypes.ContentRedaction ContentRedaction { get; set; }
        public dynamic TranscriptionJobName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-languagecode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LanguageCode { get; set; }
        /// <summary>
        /// Subtitles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-subtitles
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Subtitles
        /// </summary>
        public Humidifier.Transcribe.TranscriptionJobTypes.Subtitles Subtitles { get; set; }

        /// <summary>
        /// Media
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-media
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Media
        /// </summary>
        [Required]
        public Humidifier.Transcribe.TranscriptionJobTypes.Media Media { get; set; }
        /// <summary>
        /// ToxicityDetection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-toxicitydetection
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ToxicityDetectionSettings
        /// </summary>
        public List<Humidifier.Transcribe.TranscriptionJobTypes.ToxicityDetectionSettings> ToxicityDetection { get; set; }
        /// <summary>
        /// MediaSampleRateHertz
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-mediasampleratehertz
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MediaSampleRateHertz { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-settings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Settings
        /// </summary>
        public Humidifier.Transcribe.TranscriptionJobTypes.Settings Settings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace TranscriptionJobTypes
    {
        public class ContentRedaction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RedactionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-contentredaction.html#cfn-transcribe-transcriptionjob-contentredaction-redactiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedactionType { get; set; }
            /// <summary>
            /// PiiEntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-contentredaction.html#cfn-transcribe-transcriptionjob-contentredaction-piientitytypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PiiEntityTypes { get; set; }
            /// <summary>
            /// RedactionOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-contentredaction.html#cfn-transcribe-transcriptionjob-contentredaction-redactionoutput
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedactionOutput { get; set; }
        }

        public class Media : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-media.html#cfn-transcribe-transcriptionjob-media-mediafileuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaFileUri { get; set; }
        }

        public class Settings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxSpeakerLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-maxspeakerlabels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxSpeakerLabels { get; set; }
            /// <summary>
            /// MaxAlternatives
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-maxalternatives
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAlternatives { get; set; }
            /// <summary>
            /// ChannelIdentification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-channelidentification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ChannelIdentification { get; set; }
            /// <summary>
            /// ShowAlternatives
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-showalternatives
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ShowAlternatives { get; set; }
            /// <summary>
            /// ShowSpeakerLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-showspeakerlabels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ShowSpeakerLabels { get; set; }
        }

        public class Subtitles : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Formats
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-subtitles.html#cfn-transcribe-transcriptionjob-subtitles-formats
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Formats { get; set; }
        }

        public class ToxicityDetectionSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ToxicityCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-toxicitydetectionsettings.html#cfn-transcribe-transcriptionjob-toxicitydetectionsettings-toxicitycategories
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ToxicityCategories { get; set; }
        }

        public class Transcript : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-transcript.html#cfn-transcribe-transcriptionjob-transcript-transcriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TranscriptFileUri { get; set; }
            /// <summary>
            /// RedactedTranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-transcript.html#cfn-transcribe-transcriptionjob-transcript-redactedtranscriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedactedTranscriptFileUri { get; set; }
        }
    }
}