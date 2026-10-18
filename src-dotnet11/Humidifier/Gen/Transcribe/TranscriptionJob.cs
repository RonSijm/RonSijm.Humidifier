namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using TranscriptionJobTypes;

    public class TranscriptionJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaFormat, IHaveTranscribeTranscriptionJobTypesContentRedactionContentRedaction, IHaveTranscriptionJobName, IHaveLanguageCode, IHaveTranscribeTranscriptionJobTypesSubtitlesSubtitles, IHaveTranscribeTranscriptionJobTypesMediaMedia, IHaveListOfTranscribeTranscriptionJobTypesToxicityDetectionSettingsToxicityDetection, IHaveMediaSampleRateHertz_Integer, IHaveTranscribeTranscriptionJobTypesSettingsSettings
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
        public Union<string, BaseFunction>? MediaFormat { get; set; }
        /// <summary>
        /// ContentRedaction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-contentredaction
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ContentRedaction
        /// </summary>
        public Union<Humidifier.Transcribe.TranscriptionJobTypes.ContentRedaction, BaseFunction>? ContentRedaction { get; set; }
        public Union<string, BaseFunction>? TranscriptionJobName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-languagecode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LanguageCode { get; set; }
        /// <summary>
        /// Subtitles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-subtitles
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Subtitles
        /// </summary>
        public Union<Humidifier.Transcribe.TranscriptionJobTypes.Subtitles, BaseFunction>? Subtitles { get; set; }

        /// <summary>
        /// Media
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-media
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Media
        /// </summary>
        [Required]
        public Union<Humidifier.Transcribe.TranscriptionJobTypes.Media, BaseFunction>? Media { get; set; }
        /// <summary>
        /// ToxicityDetection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-toxicitydetection
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ToxicityDetectionSettings
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Transcribe.TranscriptionJobTypes.ToxicityDetectionSettings>, IReadOnlyList<Union<Humidifier.Transcribe.TranscriptionJobTypes.ToxicityDetectionSettings, BaseFunction>>, BaseFunction>? ToxicityDetection { get; set; }
        /// <summary>
        /// MediaSampleRateHertz
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-mediasampleratehertz
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MediaSampleRateHertz { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-settings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Settings
        /// </summary>
        public Union<Humidifier.Transcribe.TranscriptionJobTypes.Settings, BaseFunction>? Settings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-transcriptionjob.html#cfn-transcribe-transcriptionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TranscriptionJobTypes
    {
        public class ContentRedaction : Humidifier.Base.BaseSubResource, IHaveRedactionType, IHaveStringListOfPiiEntityTypes, IHaveRedactionOutput
        {
            /// <summary>
            /// RedactionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-contentredaction.html#cfn-transcribe-transcriptionjob-contentredaction-redactiontype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedactionType { get; set; }
            /// <summary>
            /// PiiEntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-contentredaction.html#cfn-transcribe-transcriptionjob-contentredaction-piientitytypes
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PiiEntityTypes { get; set; }
            /// <summary>
            /// RedactionOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-contentredaction.html#cfn-transcribe-transcriptionjob-contentredaction-redactionoutput
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedactionOutput { get; set; }
        }

        public class Media : Humidifier.Base.BaseSubResource, IHaveMediaFileUri
        {
            /// <summary>
            /// MediaFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-media.html#cfn-transcribe-transcriptionjob-media-mediafileuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaFileUri { get; set; }
        }

        public class Settings : Humidifier.Base.BaseSubResource, IHaveMaxSpeakerLabels_Integer, IHaveMaxAlternatives_Integer, IHaveChannelIdentification_Boolean, IHaveShowAlternatives_Boolean, IHaveShowSpeakerLabels_Boolean
        {
            /// <summary>
            /// MaxSpeakerLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-maxspeakerlabels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSpeakerLabels { get; set; }
            /// <summary>
            /// MaxAlternatives
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-maxalternatives
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxAlternatives { get; set; }
            /// <summary>
            /// ChannelIdentification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-channelidentification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ChannelIdentification { get; set; }
            /// <summary>
            /// ShowAlternatives
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-showalternatives
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ShowAlternatives { get; set; }
            /// <summary>
            /// ShowSpeakerLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-settings.html#cfn-transcribe-transcriptionjob-settings-showspeakerlabels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ShowSpeakerLabels { get; set; }
        }

        public class Subtitles : Humidifier.Base.BaseSubResource, IHaveStringListOfFormats
        {
            /// <summary>
            /// Formats
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-subtitles.html#cfn-transcribe-transcriptionjob-subtitles-formats
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Formats { get; set; }
        }

        public class ToxicityDetectionSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfToxicityCategories
        {
            /// <summary>
            /// ToxicityCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-toxicitydetectionsettings.html#cfn-transcribe-transcriptionjob-toxicitydetectionsettings-toxicitycategories
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ToxicityCategories { get; set; }
        }

        public class Transcript : Humidifier.Base.BaseSubResource, IHaveTranscriptFileUri, IHaveRedactedTranscriptFileUri
        {
            /// <summary>
            /// TranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-transcript.html#cfn-transcribe-transcriptionjob-transcript-transcriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TranscriptFileUri { get; set; }
            /// <summary>
            /// RedactedTranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-transcriptionjob-transcript.html#cfn-transcribe-transcriptionjob-transcript-redactedtranscriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedactedTranscriptFileUri { get; set; }
        }
    }
}