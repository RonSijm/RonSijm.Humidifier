namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using GuardrailTypes;

    public class Guardrail : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveKmsKeyArn
    {
        public class Attributes
        {
            public static string FailureRecommendations =  "FailureRecommendations" ;
            public static string GuardrailId =  "GuardrailId" ;
            public static string Status =  "Status" ;
            public static string StatusReasons =  "StatusReasons" ;
            public static string GuardrailArn =  "GuardrailArn" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.Guardrail; }
        /// <summary>
        /// TopicPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-topicpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TopicPolicyConfig
        /// </summary>
        public Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig TopicPolicyConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// WordPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-wordpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WordPolicyConfig
        /// </summary>
        public Humidifier.Bedrock.GuardrailTypes.WordPolicyConfig WordPolicyConfig { get; set; }
        /// <summary>
        /// ContextualGroundingPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-contextualgroundingpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContextualGroundingPolicyConfig
        /// </summary>
        public Humidifier.Bedrock.GuardrailTypes.ContextualGroundingPolicyConfig ContextualGroundingPolicyConfig { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }

        /// <summary>
        /// BlockedInputMessaging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-blockedinputmessaging
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BlockedInputMessaging { get; set; }

        /// <summary>
        /// BlockedOutputsMessaging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-blockedoutputsmessaging
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BlockedOutputsMessaging { get; set; }
        /// <summary>
        /// SensitiveInformationPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-sensitiveinformationpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SensitiveInformationPolicyConfig
        /// </summary>
        public Humidifier.Bedrock.GuardrailTypes.SensitiveInformationPolicyConfig SensitiveInformationPolicyConfig { get; set; }
        /// <summary>
        /// ContentPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-contentpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContentPolicyConfig
        /// </summary>
        public Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig ContentPolicyConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace GuardrailTypes
    {
        public class ContentFilterConfig : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// OutputStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-outputstrength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputStrength { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// InputStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-inputstrength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputStrength { get; set; }
        }

        public class ContentPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FiltersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentpolicyconfig.html#cfn-bedrock-guardrail-contentpolicyconfig-filtersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentFilterConfig
            /// </summary>
            public List<Humidifier.Bedrock.GuardrailTypes.ContentFilterConfig> FiltersConfig { get; set; }
        }

        public class ContextualGroundingFilterConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveThreshold
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contextualgroundingfilterconfig.html#cfn-bedrock-guardrail-contextualgroundingfilterconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contextualgroundingfilterconfig.html#cfn-bedrock-guardrail-contextualgroundingfilterconfig-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Threshold { get; set; }
        }

        public class ContextualGroundingPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FiltersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contextualgroundingpolicyconfig.html#cfn-bedrock-guardrail-contextualgroundingpolicyconfig-filtersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContextualGroundingFilterConfig
            /// </summary>
            public List<Humidifier.Bedrock.GuardrailTypes.ContextualGroundingFilterConfig> FiltersConfig { get; set; }
        }

        public class ManagedWordsConfig : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-managedwordsconfig.html#cfn-bedrock-guardrail-managedwordsconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class PiiEntityConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveAction
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-piientityconfig.html#cfn-bedrock-guardrail-piientityconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-piientityconfig.html#cfn-bedrock-guardrail-piientityconfig-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
        }

        public class RegexConfig : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveAction, IHavePattern
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-pattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pattern { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SensitiveInformationPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RegexesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-sensitiveinformationpolicyconfig.html#cfn-bedrock-guardrail-sensitiveinformationpolicyconfig-regexesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RegexConfig
            /// </summary>
            public List<Humidifier.Bedrock.GuardrailTypes.RegexConfig> RegexesConfig { get; set; }
            /// <summary>
            /// PiiEntitiesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-sensitiveinformationpolicyconfig.html#cfn-bedrock-guardrail-sensitiveinformationpolicyconfig-piientitiesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PiiEntityConfig
            /// </summary>
            public List<Humidifier.Bedrock.GuardrailTypes.PiiEntityConfig> PiiEntitiesConfig { get; set; }
        }

        public class TopicConfig : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveDefinition
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Definition { get; set; }
            /// <summary>
            /// Examples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-examples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Examples { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class TopicPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TopicsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicpolicyconfig.html#cfn-bedrock-guardrail-topicpolicyconfig-topicsconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicConfig
            /// </summary>
            public List<Humidifier.Bedrock.GuardrailTypes.TopicConfig> TopicsConfig { get; set; }
        }

        public class WordConfig : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordconfig.html#cfn-bedrock-guardrail-wordconfig-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class WordPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ManagedWordListsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordpolicyconfig.html#cfn-bedrock-guardrail-wordpolicyconfig-managedwordlistsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedWordsConfig
            /// </summary>
            public List<Humidifier.Bedrock.GuardrailTypes.ManagedWordsConfig> ManagedWordListsConfig { get; set; }
            /// <summary>
            /// WordsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordpolicyconfig.html#cfn-bedrock-guardrail-wordpolicyconfig-wordsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WordConfig
            /// </summary>
            public List<Humidifier.Bedrock.GuardrailTypes.WordConfig> WordsConfig { get; set; }
        }
    }
}