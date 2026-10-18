namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using CallAnalyticsJobTypes;

    public class CallAnalyticsJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataAccessRoleArn, IHaveCallAnalyticsJobName, IHaveTranscribeCallAnalyticsJobTypesMediaMedia, IHaveListOfTranscribeCallAnalyticsJobTypesChannelDefinitionChannelDefinitions
    {
        public class Attributes
        {
            public static string MediaFormat =  "MediaFormat" ;
            public static string LanguageCode =  "LanguageCode" ;
            public static string Transcript =  "Transcript" ;
            public static string CreationTime =  "CreationTime" ;
            public static string MediaSampleRateHertz =  "MediaSampleRateHertz" ;
            public static string Arn =  "Arn" ;
            public static string CallAnalyticsJobStatus =  "CallAnalyticsJobStatus" ;
        }

        public override string AWSTypeName { get => AWS.Transcribe.CallAnalyticsJob; }
        /// <summary>
        /// DataAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticsjob.html#cfn-transcribe-callanalyticsjob-dataaccessrolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataAccessRoleArn { get; set; }
        public Union<string, BaseFunction>? CallAnalyticsJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Media
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticsjob.html#cfn-transcribe-callanalyticsjob-media
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Media
        /// </summary>
        [Required]
        public Union<Humidifier.Transcribe.CallAnalyticsJobTypes.Media, BaseFunction>? Media { get; set; }
        /// <summary>
        /// ChannelDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticsjob.html#cfn-transcribe-callanalyticsjob-channeldefinitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ChannelDefinition
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition>, IReadOnlyList<Union<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition, BaseFunction>>, BaseFunction>? ChannelDefinitions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticsjob.html#cfn-transcribe-callanalyticsjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CallAnalyticsJobTypes
    {
        public class ChannelDefinition : Humidifier.Base.BaseSubResource, IHaveChannelId_Integer, IHaveParticipantRole
        {
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticsjob-channeldefinition.html#cfn-transcribe-callanalyticsjob-channeldefinition-channelid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ChannelId { get; set; }
            /// <summary>
            /// ParticipantRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticsjob-channeldefinition.html#cfn-transcribe-callanalyticsjob-channeldefinition-participantrole
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParticipantRole { get; set; }
        }

        public class Media : Humidifier.Base.BaseSubResource, IHaveMediaFileUri
        {
            /// <summary>
            /// MediaFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticsjob-media.html#cfn-transcribe-callanalyticsjob-media-mediafileuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaFileUri { get; set; }
        }

        public class Transcript : Humidifier.Base.BaseSubResource, IHaveTranscriptFileUri
        {
            /// <summary>
            /// TranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticsjob-transcript.html#cfn-transcribe-callanalyticsjob-transcript-transcriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TranscriptFileUri { get; set; }
        }
    }
}