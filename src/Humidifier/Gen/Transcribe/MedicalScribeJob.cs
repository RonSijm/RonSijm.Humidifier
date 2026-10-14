namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using MedicalScribeJobTypes;

    public class MedicalScribeJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataAccessRoleArn
    {
        public class Attributes
        {
            public static string LanguageCode =  "LanguageCode" ;
            public static string MedicalScribeJobStatus =  "MedicalScribeJobStatus" ;
            public static string CompletionTime =  "CompletionTime" ;
            public static string MedicalScribeContextProvided =  "MedicalScribeContextProvided" ;
            public static string MedicalScribeOutput =  "MedicalScribeOutput" ;
            public static string StartTime =  "StartTime" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transcribe.MedicalScribeJob; }
        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicalscribejob.html#cfn-transcribe-medicalscribejob-dataaccessrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataAccessRoleArn { get; set; }
        public dynamic MedicalScribeJobName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Media
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicalscribejob.html#cfn-transcribe-medicalscribejob-media
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Media
        /// </summary>
        public Humidifier.Transcribe.MedicalScribeJobTypes.Media Media { get; set; }
        /// <summary>
        /// ChannelDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicalscribejob.html#cfn-transcribe-medicalscribejob-channeldefinitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MedicalScribeChannelDefinition
        /// </summary>
        public List<Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeChannelDefinition> ChannelDefinitions { get; set; }
        /// <summary>
        /// Settings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicalscribejob.html#cfn-transcribe-medicalscribejob-settings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MedicalScribeSettings
        /// </summary>
        public Humidifier.Transcribe.MedicalScribeJobTypes.MedicalScribeSettings Settings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-medicalscribejob.html#cfn-transcribe-medicalscribejob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace MedicalScribeJobTypes
    {
        public class ClinicalNoteGenerationSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NoteTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-clinicalnotegenerationsettings.html#cfn-transcribe-medicalscribejob-clinicalnotegenerationsettings-notetemplate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoteTemplate { get; set; }
        }

        public class Media : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-media.html#cfn-transcribe-medicalscribejob-media-mediafileuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaFileUri { get; set; }
        }

        public class MedicalScribeChannelDefinition : Humidifier.Base.BaseSubResource, IHaveChannelId
        {
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-medicalscribechanneldefinition.html#cfn-transcribe-medicalscribejob-medicalscribechanneldefinition-channelid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ChannelId { get; set; }
            /// <summary>
            /// ParticipantRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-medicalscribechanneldefinition.html#cfn-transcribe-medicalscribejob-medicalscribechanneldefinition-participantrole
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParticipantRole { get; set; }
        }

        public class MedicalScribeOutput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-medicalscribeoutput.html#cfn-transcribe-medicalscribejob-medicalscribeoutput-transcriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TranscriptFileUri { get; set; }
            /// <summary>
            /// ClinicalDocumentUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-medicalscribeoutput.html#cfn-transcribe-medicalscribejob-medicalscribeoutput-clinicaldocumenturi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClinicalDocumentUri { get; set; }
        }

        public class MedicalScribeSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxSpeakerLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-medicalscribesettings.html#cfn-transcribe-medicalscribejob-medicalscribesettings-maxspeakerlabels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxSpeakerLabels { get; set; }
            /// <summary>
            /// ChannelIdentification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-medicalscribesettings.html#cfn-transcribe-medicalscribejob-medicalscribesettings-channelidentification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ChannelIdentification { get; set; }
            /// <summary>
            /// ClinicalNoteGenerationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-medicalscribesettings.html#cfn-transcribe-medicalscribejob-medicalscribesettings-clinicalnotegenerationsettings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClinicalNoteGenerationSettings
            /// </summary>
            public Humidifier.Transcribe.MedicalScribeJobTypes.ClinicalNoteGenerationSettings ClinicalNoteGenerationSettings { get; set; }
            /// <summary>
            /// ShowSpeakerLabels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-medicalscribejob-medicalscribesettings.html#cfn-transcribe-medicalscribejob-medicalscribesettings-showspeakerlabels
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ShowSpeakerLabels { get; set; }
        }
    }
}