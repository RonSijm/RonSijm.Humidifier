namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using CallAnalyticsJobTypes;

    public class CallAnalyticsJob : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataAccessRoleArn
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
        public dynamic DataAccessRoleArn { get; set; }
        public dynamic CallAnalyticsJobName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Media
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticsjob.html#cfn-transcribe-callanalyticsjob-media
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Media
        /// </summary>
        [Required]
        public Humidifier.Transcribe.CallAnalyticsJobTypes.Media Media { get; set; }
        /// <summary>
        /// ChannelDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticsjob.html#cfn-transcribe-callanalyticsjob-channeldefinitions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ChannelDefinition
        /// </summary>
        public List<Humidifier.Transcribe.CallAnalyticsJobTypes.ChannelDefinition> ChannelDefinitions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticsjob.html#cfn-transcribe-callanalyticsjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace CallAnalyticsJobTypes
    {
        public class ChannelDefinition : Humidifier.Base.BaseSubResource, IHaveChannelId
        {
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticsjob-channeldefinition.html#cfn-transcribe-callanalyticsjob-channeldefinition-channelid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ChannelId { get; set; }
            /// <summary>
            /// ParticipantRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticsjob-channeldefinition.html#cfn-transcribe-callanalyticsjob-channeldefinition-participantrole
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParticipantRole { get; set; }
        }

        public class Media : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticsjob-media.html#cfn-transcribe-callanalyticsjob-media-mediafileuri
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaFileUri { get; set; }
        }

        public class Transcript : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TranscriptFileUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticsjob-transcript.html#cfn-transcribe-callanalyticsjob-transcript-transcriptfileuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TranscriptFileUri { get; set; }
        }
    }
}