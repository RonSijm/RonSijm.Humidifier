namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using MedicalTranscriptionJobTypes;

    public class MedicalTranscriptionJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveLanguageCode
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
        public dynamic MediaFormat { get; set; }

        /// <summary>
        /// Specialty
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-specialty
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Specialty { get; set; }

        /// <summary>
        /// LanguageCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-languagecode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LanguageCode { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }

        /// <summary>
        /// Media
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-media
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Media
        /// </summary>
        [Required]
        public Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media Media { get; set; }
        /// <summary>
        /// MediaSampleRateHertz
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-mediasampleratehertz
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MediaSampleRateHertz { get; set; }
        public dynamic MedicalTranscriptionJobName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-settings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MedicalTranscriptionSetting
        /// </summary>
        public Humidifier.Transcribe.MedicalTranscriptionJobTypes.MedicalTranscriptionSetting Settings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicaltranscriptionjob.html#cfn-transcribe-medicaltranscriptionjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace MedicalTranscriptionJobTypes
    {
        public class Media : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicaltranscriptionjob-media.html#cfn-transcribe-medicaltranscriptionjob-media-mediafileuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaFileUri { get; set; }
        }

        public class MedicalTranscript : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicaltranscriptionjob-medicaltranscript.html#cfn-transcribe-medicaltranscriptionjob-medicaltranscript-transcriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TranscriptFileUri { get; set; }
        }

        public class MedicalTranscriptionSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChannelIdentification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicaltranscriptionjob-medicaltranscriptionsetting.html#cfn-transcribe-medicaltranscriptionjob-medicaltranscriptionsetting-channelidentification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ChannelIdentification { get; set; }
            /// <summary>
            /// ShowAlternatives
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicaltranscriptionjob-medicaltranscriptionsetting.html#cfn-transcribe-medicaltranscriptionjob-medicaltranscriptionsetting-showalternatives
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ShowAlternatives { get; set; }
        }
    }
}