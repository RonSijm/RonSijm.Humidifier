namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using QuickResponseTypes;

    public class QuickResponse : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveContentType, IHaveLanguage, IHaveIsActive_Boolean, IHaveWisdomQuickResponseTypesQuickResponseContentProviderContent, IHaveWisdomQuickResponseTypesGroupingConfigurationGroupingConfiguration, IHaveKnowledgeBaseArn, IHaveStringListOfChannels, IHaveShortcutKey, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Contents =  "Contents" ;
            public static string QuickResponseArn =  "QuickResponseArn" ;
            public static string QuickResponseId =  "QuickResponseId" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.QuickResponse; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ContentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-contenttype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ContentType { get; set; }
        /// <summary>
        /// Language
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-language
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Language { get; set; }
        /// <summary>
        /// IsActive
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-isactive
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsActive { get; set; }

        /// <summary>
        /// Content
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-content
        /// Required: True
        /// UpdateType: Mutable
        /// Type: QuickResponseContentProvider
        /// </summary>
        [Required]
        public Union<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider, BaseFunction>? Content { get; set; }
        /// <summary>
        /// GroupingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-groupingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GroupingConfiguration
        /// </summary>
        public Union<Humidifier.Wisdom.QuickResponseTypes.GroupingConfiguration, BaseFunction>? GroupingConfiguration { get; set; }

        /// <summary>
        /// KnowledgeBaseArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-knowledgebasearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KnowledgeBaseArn { get; set; }
        /// <summary>
        /// Channels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-channels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Channels { get; set; }
        /// <summary>
        /// ShortcutKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-shortcutkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ShortcutKey { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-quickresponse.html#cfn-wisdom-quickresponse-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace QuickResponseTypes
    {
        public class GroupingConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveCriteria
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-quickresponse-groupingconfiguration.html#cfn-wisdom-quickresponse-groupingconfiguration-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Criteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-quickresponse-groupingconfiguration.html#cfn-wisdom-quickresponse-groupingconfiguration-criteria
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Criteria { get; set; }
        }

        public class QuickResponseContentProvider : Humidifier.Base.BaseSubResource, IHaveContent
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-quickresponse-quickresponsecontentprovider.html#cfn-wisdom-quickresponse-quickresponsecontentprovider-content
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
        }

        public class QuickResponseContents : Humidifier.Base.BaseSubResource, IHaveWisdomQuickResponseTypesQuickResponseContentProviderPlainText, IHaveWisdomQuickResponseTypesQuickResponseContentProviderMarkdown
        {
            /// <summary>
            /// PlainText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-quickresponse-quickresponsecontents.html#cfn-wisdom-quickresponse-quickresponsecontents-plaintext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuickResponseContentProvider
            /// </summary>
            public Union<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider, BaseFunction>? PlainText { get; set; }
            /// <summary>
            /// Markdown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-quickresponse-quickresponsecontents.html#cfn-wisdom-quickresponse-quickresponsecontents-markdown
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QuickResponseContentProvider
            /// </summary>
            public Union<Humidifier.Wisdom.QuickResponseTypes.QuickResponseContentProvider, BaseFunction>? Markdown { get; set; }
        }
    }
}