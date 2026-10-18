namespace Humidifier.Transcribe
{
    using global::System.Collections.Generic;
    using CallAnalyticsCategoryTypes;

    public class CallAnalyticsCategory : Humidifier.Base.BaseResource, IHaveTags, IHaveInputType, IHaveCategoryName, IHaveListOfTranscribeCallAnalyticsCategoryTypesRuleRules
    {
        public class Attributes
        {
            public static string LastUpdateTime =  "LastUpdateTime" ;
            public static string CreateTime =  "CreateTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Transcribe.CallAnalyticsCategory; }
        /// <summary>
        /// InputType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticscategory.html#cfn-transcribe-callanalyticscategory-inputtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InputType { get; set; }

        /// <summary>
        /// CategoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticscategory.html#cfn-transcribe-callanalyticscategory-categoryname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CategoryName { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticscategory.html#cfn-transcribe-callanalyticscategory-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule>, IReadOnlyList<Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-transcribe-callanalyticscategory.html#cfn-transcribe-callanalyticscategory-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CallAnalyticsCategoryTypes
    {
        public class AbsoluteTimeRange : Humidifier.Base.BaseSubResource, IHaveStartTime_Integer, IHaveLast_Integer, IHaveFirst_Integer, IHaveEndTime_Integer
        {
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-absolutetimerange.html#cfn-transcribe-callanalyticscategory-absolutetimerange-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// Last
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-absolutetimerange.html#cfn-transcribe-callanalyticscategory-absolutetimerange-last
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Last { get; set; }
            /// <summary>
            /// First
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-absolutetimerange.html#cfn-transcribe-callanalyticscategory-absolutetimerange-first
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? First { get; set; }
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-absolutetimerange.html#cfn-transcribe-callanalyticscategory-absolutetimerange-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndTime { get; set; }
        }

        public class InterruptionFilter : Humidifier.Base.BaseSubResource, IHaveTranscribeCallAnalyticsCategoryTypesRelativeTimeRangeRelativeTimeRange, IHaveNegate_Boolean, IHaveTranscribeCallAnalyticsCategoryTypesAbsoluteTimeRangeAbsoluteTimeRange, IHaveThreshold_Integer, IHaveParticipantRole
        {
            /// <summary>
            /// RelativeTimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-interruptionfilter.html#cfn-transcribe-callanalyticscategory-interruptionfilter-relativetimerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeTimeRange
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange, BaseFunction>? RelativeTimeRange { get; set; }
            /// <summary>
            /// Negate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-interruptionfilter.html#cfn-transcribe-callanalyticscategory-interruptionfilter-negate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Negate { get; set; }
            /// <summary>
            /// AbsoluteTimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-interruptionfilter.html#cfn-transcribe-callanalyticscategory-interruptionfilter-absolutetimerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbsoluteTimeRange
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange, BaseFunction>? AbsoluteTimeRange { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-interruptionfilter.html#cfn-transcribe-callanalyticscategory-interruptionfilter-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Threshold { get; set; }
            /// <summary>
            /// ParticipantRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-interruptionfilter.html#cfn-transcribe-callanalyticscategory-interruptionfilter-participantrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParticipantRole { get; set; }
        }

        public class NonTalkTimeFilter : Humidifier.Base.BaseSubResource, IHaveTranscribeCallAnalyticsCategoryTypesRelativeTimeRangeRelativeTimeRange, IHaveNegate_Boolean, IHaveTranscribeCallAnalyticsCategoryTypesAbsoluteTimeRangeAbsoluteTimeRange, IHaveThreshold_Integer
        {
            /// <summary>
            /// RelativeTimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-nontalktimefilter.html#cfn-transcribe-callanalyticscategory-nontalktimefilter-relativetimerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeTimeRange
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange, BaseFunction>? RelativeTimeRange { get; set; }
            /// <summary>
            /// Negate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-nontalktimefilter.html#cfn-transcribe-callanalyticscategory-nontalktimefilter-negate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Negate { get; set; }
            /// <summary>
            /// AbsoluteTimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-nontalktimefilter.html#cfn-transcribe-callanalyticscategory-nontalktimefilter-absolutetimerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbsoluteTimeRange
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange, BaseFunction>? AbsoluteTimeRange { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-nontalktimefilter.html#cfn-transcribe-callanalyticscategory-nontalktimefilter-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Threshold { get; set; }
        }

        public class RelativeTimeRange : Humidifier.Base.BaseSubResource, IHaveStartPercentage_Integer, IHaveLast_Integer, IHaveFirst_Integer, IHaveEndPercentage_Integer
        {
            /// <summary>
            /// StartPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-relativetimerange.html#cfn-transcribe-callanalyticscategory-relativetimerange-startpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartPercentage { get; set; }
            /// <summary>
            /// Last
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-relativetimerange.html#cfn-transcribe-callanalyticscategory-relativetimerange-last
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Last { get; set; }
            /// <summary>
            /// First
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-relativetimerange.html#cfn-transcribe-callanalyticscategory-relativetimerange-first
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? First { get; set; }
            /// <summary>
            /// EndPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-relativetimerange.html#cfn-transcribe-callanalyticscategory-relativetimerange-endpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndPercentage { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveTranscribeCallAnalyticsCategoryTypesNonTalkTimeFilterNonTalkTimeFilter, IHaveTranscribeCallAnalyticsCategoryTypesSentimentFilterSentimentFilter, IHaveTranscribeCallAnalyticsCategoryTypesTranscriptFilterTranscriptFilter, IHaveTranscribeCallAnalyticsCategoryTypesInterruptionFilterInterruptionFilter
        {
            /// <summary>
            /// NonTalkTimeFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-rule.html#cfn-transcribe-callanalyticscategory-rule-nontalktimefilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NonTalkTimeFilter
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.NonTalkTimeFilter, BaseFunction>? NonTalkTimeFilter { get; set; }
            /// <summary>
            /// SentimentFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-rule.html#cfn-transcribe-callanalyticscategory-rule-sentimentfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SentimentFilter
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.SentimentFilter, BaseFunction>? SentimentFilter { get; set; }
            /// <summary>
            /// TranscriptFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-rule.html#cfn-transcribe-callanalyticscategory-rule-transcriptfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TranscriptFilter
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.TranscriptFilter, BaseFunction>? TranscriptFilter { get; set; }
            /// <summary>
            /// InterruptionFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-rule.html#cfn-transcribe-callanalyticscategory-rule-interruptionfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InterruptionFilter
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.InterruptionFilter, BaseFunction>? InterruptionFilter { get; set; }
        }

        public class SentimentFilter : Humidifier.Base.BaseSubResource, IHaveStringListOfSentiments, IHaveTranscribeCallAnalyticsCategoryTypesRelativeTimeRangeRelativeTimeRange, IHaveNegate_Boolean, IHaveTranscribeCallAnalyticsCategoryTypesAbsoluteTimeRangeAbsoluteTimeRange, IHaveParticipantRole
        {
            /// <summary>
            /// Sentiments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-sentimentfilter.html#cfn-transcribe-callanalyticscategory-sentimentfilter-sentiments
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Sentiments { get; set; }
            /// <summary>
            /// RelativeTimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-sentimentfilter.html#cfn-transcribe-callanalyticscategory-sentimentfilter-relativetimerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeTimeRange
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange, BaseFunction>? RelativeTimeRange { get; set; }
            /// <summary>
            /// Negate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-sentimentfilter.html#cfn-transcribe-callanalyticscategory-sentimentfilter-negate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Negate { get; set; }
            /// <summary>
            /// AbsoluteTimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-sentimentfilter.html#cfn-transcribe-callanalyticscategory-sentimentfilter-absolutetimerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbsoluteTimeRange
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange, BaseFunction>? AbsoluteTimeRange { get; set; }
            /// <summary>
            /// ParticipantRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-sentimentfilter.html#cfn-transcribe-callanalyticscategory-sentimentfilter-participantrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParticipantRole { get; set; }
        }

        public class TranscriptFilter : Humidifier.Base.BaseSubResource, IHaveTranscriptFilterType, IHaveTranscribeCallAnalyticsCategoryTypesRelativeTimeRangeRelativeTimeRange, IHaveStringListOfTargets, IHaveNegate_Boolean, IHaveTranscribeCallAnalyticsCategoryTypesAbsoluteTimeRangeAbsoluteTimeRange, IHaveParticipantRole
        {
            /// <summary>
            /// TranscriptFilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-transcriptfilter.html#cfn-transcribe-callanalyticscategory-transcriptfilter-transcriptfiltertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TranscriptFilterType { get; set; }
            /// <summary>
            /// RelativeTimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-transcriptfilter.html#cfn-transcribe-callanalyticscategory-transcriptfilter-relativetimerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelativeTimeRange
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.RelativeTimeRange, BaseFunction>? RelativeTimeRange { get; set; }
            /// <summary>
            /// Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-transcriptfilter.html#cfn-transcribe-callanalyticscategory-transcriptfilter-targets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Targets { get; set; }
            /// <summary>
            /// Negate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-transcriptfilter.html#cfn-transcribe-callanalyticscategory-transcriptfilter-negate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Negate { get; set; }
            /// <summary>
            /// AbsoluteTimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-transcriptfilter.html#cfn-transcribe-callanalyticscategory-transcriptfilter-absolutetimerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbsoluteTimeRange
            /// </summary>
            public Union<Humidifier.Transcribe.CallAnalyticsCategoryTypes.AbsoluteTimeRange, BaseFunction>? AbsoluteTimeRange { get; set; }
            /// <summary>
            /// ParticipantRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-transcribe-callanalyticscategory-transcriptfilter.html#cfn-transcribe-callanalyticscategory-transcriptfilter-participantrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParticipantRole { get; set; }
        }
    }
}