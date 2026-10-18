namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using MedicalTranscriptionJobTypes;

    public class MedicalTranscriptionJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMediaFormat, IHaveSpecialty, IHaveLanguageCode, IHaveType, IHaveTranscribeMedicalTranscriptionJobTypesMediaMedia, IHaveMediaSampleRateHertz_Integer, IHaveMedicalTranscriptionJobName, IHaveTranscribeMedicalTranscriptionJobTypesMedicalTranscriptionSettingSettings
    {
        public class Attributes
        {
            public static string Transcript =  "Transcript" ;
            public static string TranscriptionJobStatus =  "TranscriptionJobStatus" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transcribe.MedicalTranscriptionJob; }
        /// <summary>
        /// MediaFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-mediaformat
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MediaFormat { get; set; }

        /// <summary>
        /// Specialty
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-specialty
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Specialty { get; set; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LanguageCode { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// Media
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-media
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Media
        /// </summary>
        [Required]
        public Union<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media, BaseFunction>? Media { get; set; }
        /// <summary>
        /// MediaSampleRateHertz
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-mediasampleratehertz
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MediaSampleRateHertz { get; set; }
        public Union<string, BaseFunction>? MedicalTranscriptionJobName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-settings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MedicalTranscriptionSetting
        /// </summary>
        public Union<Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting, BaseFunction>? Settings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MedicalTranscriptionJobTypes
    {
        public class Media : Humidifier.Base.BaseSubResource, IHaveMediaFileUri
        {
            /// <summary>
            /// MediaFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicaltranscriptionjob-media.html#cfn-transcribe-medicaltranscriptionjob-media-mediafileuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaFileUri { get; set; }
        }

        public class MedicalTranscript : Humidifier.Base.BaseSubResource, IHaveTranscriptFileUri
        {
            /// <summary>
            /// TranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicaltranscriptionjob-medicaltranscript.html#cfn-transcribe-medicaltranscriptionjob-medicaltranscript-transcriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TranscriptFileUri { get; set; }
        }

        public class MedicalTranscriptionSetting : Humidifier.Base.BaseSubResource, IHaveChannelIdentification_Boolean, IHaveShowAlternatives_Boolean
        {
            /// <summary>
            /// ChannelIdentification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicaltranscriptionjob-medicaltranscriptionsetting.html#cfn-transcribe-medicaltranscriptionjob-medicaltranscriptionsetting-channelidentification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ChannelIdentification { get; set; }
            /// <summary>
            /// ShowAlternatives
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicaltranscriptionjob-medicaltranscriptionsetting.html#cfn-transcribe-medicaltranscriptionjob-medicaltranscriptionsetting-showalternatives
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ShowAlternatives { get; set; }
        }
    }
}