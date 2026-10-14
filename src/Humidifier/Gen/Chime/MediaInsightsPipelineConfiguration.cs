namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaInsightsPipelineConfigurationTypes;

    public class MediaInsightsPipelineConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string MediaInsightsPipelineConfigurationId =  "MediaInsightsPipelineConfigurationId" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string MediaInsightsPipelineConfigurationArn =  "MediaInsightsPipelineConfigurationArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.MediaInsightsPipelineConfiguration; }
        /// <summary>
        /// RealTimeAlertConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipelineconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-realtimealertconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RealTimeAlertConfiguration
        /// </summary>
        public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.RealTimeAlertConfiguration RealTimeAlertConfiguration { get; set; }

        /// <summary>
        /// ResourceAccessRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipelineconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-resourceaccessrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceAccessRoleArn { get; set; }

        /// <summary>
        /// Elements
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipelineconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-elements
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MediaInsightsPipelineConfigurationElement
        /// </summary>
        [Required]
        public List<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.MediaInsightsPipelineConfigurationElement> Elements { get; set; }
        public dynamic MediaInsightsPipelineConfigurationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediainsightspipelineconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace MediaInsightsPipelineConfigurationTypes
    {
        public class AmazonTranscribeCallAnalyticsProcessorConfiguration : Humidifier.Base.BaseSubResource, IHaveLanguageCode
        {
            /// <summary>
            /// PostCallAnalyticsSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-postcallanalyticssettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PostCallAnalyticsSettings
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.PostCallAnalyticsSettings PostCallAnalyticsSettings { get; set; }
            /// <summary>
            /// LanguageModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-languagemodelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageModelName { get; set; }
            /// <summary>
            /// FilterPartialResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-filterpartialresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic FilterPartialResults { get; set; }
            /// <summary>
            /// VocabularyFilterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-vocabularyfiltername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VocabularyFilterName { get; set; }
            /// <summary>
            /// PartialResultsStability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-partialresultsstability
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PartialResultsStability { get; set; }
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-languagecode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode { get; set; }
            /// <summary>
            /// EnablePartialResultsStabilization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-enablepartialresultsstabilization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnablePartialResultsStabilization { get; set; }
            /// <summary>
            /// CallAnalyticsStreamCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-callanalyticsstreamcategories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CallAnalyticsStreamCategories { get; set; }
            /// <summary>
            /// VocabularyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-vocabularyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VocabularyName { get; set; }
            /// <summary>
            /// ContentRedactionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-contentredactiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentRedactionType { get; set; }
            /// <summary>
            /// ContentIdentificationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-contentidentificationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentIdentificationType { get; set; }
            /// <summary>
            /// PiiEntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-piientitytypes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PiiEntityTypes { get; set; }
            /// <summary>
            /// VocabularyFilterMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribecallanalyticsprocessorconfiguration-vocabularyfiltermethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VocabularyFilterMethod { get; set; }
        }

        public class AmazonTranscribeProcessorConfiguration : Humidifier.Base.BaseSubResource, IHaveLanguageCode
        {
            /// <summary>
            /// IdentifyMultipleLanguages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-identifymultiplelanguages
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IdentifyMultipleLanguages { get; set; }
            /// <summary>
            /// VocabularyNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-vocabularynames
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VocabularyNames { get; set; }
            /// <summary>
            /// LanguageModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-languagemodelname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageModelName { get; set; }
            /// <summary>
            /// FilterPartialResults
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-filterpartialresults
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic FilterPartialResults { get; set; }
            /// <summary>
            /// VocabularyFilterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-vocabularyfiltername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VocabularyFilterName { get; set; }
            /// <summary>
            /// IdentifyLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-identifylanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IdentifyLanguage { get; set; }
            /// <summary>
            /// PartialResultsStability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-partialresultsstability
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PartialResultsStability { get; set; }
            /// <summary>
            /// LanguageOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-languageoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageOptions { get; set; }
            /// <summary>
            /// VocabularyFilterNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-vocabularyfilternames
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VocabularyFilterNames { get; set; }
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode { get; set; }
            /// <summary>
            /// EnablePartialResultsStabilization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-enablepartialresultsstabilization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnablePartialResultsStabilization { get; set; }
            /// <summary>
            /// VocabularyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-vocabularyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VocabularyName { get; set; }
            /// <summary>
            /// ContentRedactionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-contentredactiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentRedactionType { get; set; }
            /// <summary>
            /// ShowSpeakerLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-showspeakerlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ShowSpeakerLabel { get; set; }
            /// <summary>
            /// ContentIdentificationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-contentidentificationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentIdentificationType { get; set; }
            /// <summary>
            /// PiiEntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-piientitytypes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PiiEntityTypes { get; set; }
            /// <summary>
            /// PreferredLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-preferredlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreferredLanguage { get; set; }
            /// <summary>
            /// VocabularyFilterMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-amazontranscribeprocessorconfiguration-vocabularyfiltermethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VocabularyFilterMethod { get; set; }
        }

        public class IssueDetectionConfiguration : Humidifier.Base.BaseSubResource, IHaveRuleName
        {
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-issuedetectionconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-issuedetectionconfiguration-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName { get; set; }
        }

        public class KeywordMatchConfiguration : Humidifier.Base.BaseSubResource, IHaveRuleName
        {
            /// <summary>
            /// Keywords
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-keywordmatchconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-keywordmatchconfiguration-keywords
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Keywords { get; set; }
            /// <summary>
            /// Negate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-keywordmatchconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-keywordmatchconfiguration-negate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Negate { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-keywordmatchconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-keywordmatchconfiguration-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName { get; set; }
        }

        public class KinesisDataStreamSinkConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InsightsTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-kinesisdatastreamsinkconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-kinesisdatastreamsinkconfiguration-insightstarget
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InsightsTarget { get; set; }
        }

        public class MediaInsightsPipelineConfigurationElement : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// AmazonTranscribeCallAnalyticsProcessorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement.html#cfn-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement-amazontranscribecallanalyticsprocessorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonTranscribeCallAnalyticsProcessorConfiguration
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.AmazonTranscribeCallAnalyticsProcessorConfiguration AmazonTranscribeCallAnalyticsProcessorConfiguration { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement.html#cfn-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// AmazonTranscribeProcessorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement.html#cfn-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement-amazontranscribeprocessorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonTranscribeProcessorConfiguration
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.AmazonTranscribeProcessorConfiguration AmazonTranscribeProcessorConfiguration { get; set; }
            /// <summary>
            /// KinesisDataStreamSinkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement.html#cfn-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement-kinesisdatastreamsinkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisDataStreamSinkConfiguration
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.KinesisDataStreamSinkConfiguration KinesisDataStreamSinkConfiguration { get; set; }
            /// <summary>
            /// S3RecordingSinkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement.html#cfn-chime-mediainsightspipelineconfiguration-mediainsightspipelineconfigurationelement-s3recordingsinkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3RecordingSinkConfiguration
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.S3RecordingSinkConfiguration S3RecordingSinkConfiguration { get; set; }
        }

        public class PostCallAnalyticsSettings : Humidifier.Base.BaseSubResource, IHaveDataAccessRoleArn, IHaveOutputLocation
        {
            /// <summary>
            /// DataAccessRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-postcallanalyticssettings.html#cfn-chime-mediainsightspipelineconfiguration-postcallanalyticssettings-dataaccessrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataAccessRoleArn { get; set; }
            /// <summary>
            /// ContentRedactionOutput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-postcallanalyticssettings.html#cfn-chime-mediainsightspipelineconfiguration-postcallanalyticssettings-contentredactionoutput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentRedactionOutput { get; set; }
            /// <summary>
            /// OutputLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-postcallanalyticssettings.html#cfn-chime-mediainsightspipelineconfiguration-postcallanalyticssettings-outputlocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputLocation { get; set; }
            /// <summary>
            /// OutputEncryptionKMSKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-postcallanalyticssettings.html#cfn-chime-mediainsightspipelineconfiguration-postcallanalyticssettings-outputencryptionkmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputEncryptionKMSKeyId { get; set; }
        }

        public class RealTimeAlertConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Disabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-realtimealertconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-realtimealertconfiguration-disabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Disabled { get; set; }
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-realtimealertconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-realtimealertconfiguration-rules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RealTimeAlertRule
            /// </summary>
            public List<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.RealTimeAlertRule> Rules { get; set; }
        }

        public class RealTimeAlertRule : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-realtimealertrule.html#cfn-chime-mediainsightspipelineconfiguration-realtimealertrule-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// KeywordMatchConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-realtimealertrule.html#cfn-chime-mediainsightspipelineconfiguration-realtimealertrule-keywordmatchconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KeywordMatchConfiguration
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.KeywordMatchConfiguration KeywordMatchConfiguration { get; set; }
            /// <summary>
            /// SentimentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-realtimealertrule.html#cfn-chime-mediainsightspipelineconfiguration-realtimealertrule-sentimentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SentimentConfiguration
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.SentimentConfiguration SentimentConfiguration { get; set; }
            /// <summary>
            /// IssueDetectionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-realtimealertrule.html#cfn-chime-mediainsightspipelineconfiguration-realtimealertrule-issuedetectionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IssueDetectionConfiguration
            /// </summary>
            public Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.IssueDetectionConfiguration IssueDetectionConfiguration { get; set; }
        }

        public class S3RecordingSinkConfiguration : Humidifier.Base.BaseSubResource, IHaveDestination
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-s3recordingsinkconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-s3recordingsinkconfiguration-destination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Destination { get; set; }
            /// <summary>
            /// RecordingFileFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-s3recordingsinkconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-s3recordingsinkconfiguration-recordingfileformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordingFileFormat { get; set; }
        }

        public class SentimentConfiguration : Humidifier.Base.BaseSubResource, IHaveRuleName
        {
            /// <summary>
            /// TimePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-sentimentconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-sentimentconfiguration-timeperiod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimePeriod { get; set; }
            /// <summary>
            /// SentimentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-sentimentconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-sentimentconfiguration-sentimenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SentimentType { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediainsightspipelineconfiguration-sentimentconfiguration.html#cfn-chime-mediainsightspipelineconfiguration-sentimentconfiguration-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName { get; set; }
        }
    }
}