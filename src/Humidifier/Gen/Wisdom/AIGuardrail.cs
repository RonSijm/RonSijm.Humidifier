namespace Humidifier.Wisdom
{
    using System.Collections.Generic;
    using AIGuardrailTypes;

    public class AIGuardrail : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveAssistantId, IHaveBlockedInputMessaging, IHaveBlockedOutputsMessaging
    {
        public class Attributes
        {
            public static string AIGuardrailId =  "AIGuardrailId" ;
            public static string AssistantArn =  "AssistantArn" ;
            public static string AIGuardrailArn =  "AIGuardrailArn" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.AIGuardrail; }
        /// <summary>
        /// TopicPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-topicpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AIGuardrailTopicPolicyConfig
        /// </summary>
        public Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailTopicPolicyConfig TopicPolicyConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// WordPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-wordpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AIGuardrailWordPolicyConfig
        /// </summary>
        public Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailWordPolicyConfig WordPolicyConfig { get; set; }
        /// <summary>
        /// ContextualGroundingPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-contextualgroundingpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AIGuardrailContextualGroundingPolicyConfig
        /// </summary>
        public Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContextualGroundingPolicyConfig ContextualGroundingPolicyConfig { get; set; }

        /// <summary>
        /// BlockedInputMessaging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-blockedinputmessaging
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BlockedInputMessaging { get; set; }

        /// <summary>
        /// AssistantId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-assistantid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssistantId { get; set; }

        /// <summary>
        /// BlockedOutputsMessaging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-blockedoutputsmessaging
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BlockedOutputsMessaging { get; set; }
        /// <summary>
        /// SensitiveInformationPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-sensitiveinformationpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AIGuardrailSensitiveInformationPolicyConfig
        /// </summary>
        public Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailSensitiveInformationPolicyConfig SensitiveInformationPolicyConfig { get; set; }
        /// <summary>
        /// ContentPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-contentpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AIGuardrailContentPolicyConfig
        /// </summary>
        public Humidifier.Wisdom.AIGuardrailTypes.AIGuardrailContentPolicyConfig ContentPolicyConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-aiguardrail.html#cfn-wisdom-aiguardrail-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AIGuardrailTypes
    {
        public class AIGuardrailContentPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FiltersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-aiguardrailcontentpolicyconfig.html#cfn-wisdom-aiguardrail-aiguardrailcontentpolicyconfig-filtersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GuardrailContentFilterConfig
            /// </summary>
            public List<Humidifier.Wisdom.AIGuardrailTypes.GuardrailContentFilterConfig> FiltersConfig { get; set; }
        }

        public class AIGuardrailContextualGroundingPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FiltersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-aiguardrailcontextualgroundingpolicyconfig.html#cfn-wisdom-aiguardrail-aiguardrailcontextualgroundingpolicyconfig-filtersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GuardrailContextualGroundingFilterConfig
            /// </summary>
            public List<Humidifier.Wisdom.AIGuardrailTypes.GuardrailContextualGroundingFilterConfig> FiltersConfig { get; set; }
        }

        public class AIGuardrailSensitiveInformationPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RegexesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-aiguardrailsensitiveinformationpolicyconfig.html#cfn-wisdom-aiguardrail-aiguardrailsensitiveinformationpolicyconfig-regexesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GuardrailRegexConfig
            /// </summary>
            public List<Humidifier.Wisdom.AIGuardrailTypes.GuardrailRegexConfig> RegexesConfig { get; set; }
            /// <summary>
            /// PiiEntitiesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-aiguardrailsensitiveinformationpolicyconfig.html#cfn-wisdom-aiguardrail-aiguardrailsensitiveinformationpolicyconfig-piientitiesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GuardrailPiiEntityConfig
            /// </summary>
            public List<Humidifier.Wisdom.AIGuardrailTypes.GuardrailPiiEntityConfig> PiiEntitiesConfig { get; set; }
        }

        public class AIGuardrailTopicPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TopicsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-aiguardrailtopicpolicyconfig.html#cfn-wisdom-aiguardrail-aiguardrailtopicpolicyconfig-topicsconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GuardrailTopicConfig
            /// </summary>
            public List<Humidifier.Wisdom.AIGuardrailTypes.GuardrailTopicConfig> TopicsConfig { get; set; }
        }

        public class AIGuardrailWordPolicyConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ManagedWordListsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-aiguardrailwordpolicyconfig.html#cfn-wisdom-aiguardrail-aiguardrailwordpolicyconfig-managedwordlistsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GuardrailManagedWordsConfig
            /// </summary>
            public List<Humidifier.Wisdom.AIGuardrailTypes.GuardrailManagedWordsConfig> ManagedWordListsConfig { get; set; }
            /// <summary>
            /// WordsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-aiguardrailwordpolicyconfig.html#cfn-wisdom-aiguardrail-aiguardrailwordpolicyconfig-wordsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GuardrailWordConfig
            /// </summary>
            public List<Humidifier.Wisdom.AIGuardrailTypes.GuardrailWordConfig> WordsConfig { get; set; }
        }

        public class GuardrailContentFilterConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveOutputStrength, IHaveInputStrength
        {
            /// <summary>
            /// OutputStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailcontentfilterconfig.html#cfn-wisdom-aiguardrail-guardrailcontentfilterconfig-outputstrength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OutputStrength { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailcontentfilterconfig.html#cfn-wisdom-aiguardrail-guardrailcontentfilterconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// InputStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailcontentfilterconfig.html#cfn-wisdom-aiguardrail-guardrailcontentfilterconfig-inputstrength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputStrength { get; set; }
        }

        public class GuardrailContextualGroundingFilterConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveThreshold
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailcontextualgroundingfilterconfig.html#cfn-wisdom-aiguardrail-guardrailcontextualgroundingfilterconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailcontextualgroundingfilterconfig.html#cfn-wisdom-aiguardrail-guardrailcontextualgroundingfilterconfig-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Threshold { get; set; }
        }

        public class GuardrailManagedWordsConfig : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailmanagedwordsconfig.html#cfn-wisdom-aiguardrail-guardrailmanagedwordsconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class GuardrailPiiEntityConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveAction
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailpiientityconfig.html#cfn-wisdom-aiguardrail-guardrailpiientityconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailpiientityconfig.html#cfn-wisdom-aiguardrail-guardrailpiientityconfig-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
        }

        public class GuardrailRegexConfig : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveAction, IHavePattern
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailregexconfig.html#cfn-wisdom-aiguardrail-guardrailregexconfig-pattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Pattern { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailregexconfig.html#cfn-wisdom-aiguardrail-guardrailregexconfig-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailregexconfig.html#cfn-wisdom-aiguardrail-guardrailregexconfig-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailregexconfig.html#cfn-wisdom-aiguardrail-guardrailregexconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class GuardrailTopicConfig : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveDefinition, IHaveExamples
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailtopicconfig.html#cfn-wisdom-aiguardrail-guardrailtopicconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailtopicconfig.html#cfn-wisdom-aiguardrail-guardrailtopicconfig-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Definition { get; set; }
            /// <summary>
            /// Examples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailtopicconfig.html#cfn-wisdom-aiguardrail-guardrailtopicconfig-examples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Examples { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailtopicconfig.html#cfn-wisdom-aiguardrail-guardrailtopicconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class GuardrailWordConfig : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-aiguardrail-guardrailwordconfig.html#cfn-wisdom-aiguardrail-guardrailwordconfig-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }
    }
}