namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using GuardrailTypes;

    public class Guardrail : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveBedrockGuardrailTypesTopicPolicyConfigTopicPolicyConfig, IHaveDescription, IHaveBedrockGuardrailTypesGuardrailCrossRegionConfigCrossRegionConfig, IHaveName, IHaveBedrockGuardrailTypesWordPolicyConfigWordPolicyConfig, IHaveBedrockGuardrailTypesContextualGroundingPolicyConfigContextualGroundingPolicyConfig, IHaveKmsKeyArn, IHaveBlockedInputMessaging, IHaveBlockedOutputsMessaging, IHaveBedrockGuardrailTypesSensitiveInformationPolicyConfigSensitiveInformationPolicyConfig, IHaveBedrockGuardrailTypesContentPolicyConfigContentPolicyConfig, IHaveBedrockGuardrailTypesAutomatedReasoningPolicyConfigAutomatedReasoningPolicyConfig
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
        public Union<Humidifier.Bedrock.GuardrailTypes.TopicPolicyConfig, BaseFunction>? TopicPolicyConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// CrossRegionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-crossregionconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: GuardrailCrossRegionConfig
        /// </summary>
        public Union<Humidifier.Bedrock.GuardrailTypes.GuardrailCrossRegionConfig, BaseFunction>? CrossRegionConfig { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// WordPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-wordpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WordPolicyConfig
        /// </summary>
        public Union<Humidifier.Bedrock.GuardrailTypes.WordPolicyConfig, BaseFunction>? WordPolicyConfig { get; set; }
        /// <summary>
        /// ContextualGroundingPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-contextualgroundingpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContextualGroundingPolicyConfig
        /// </summary>
        public Union<Humidifier.Bedrock.GuardrailTypes.ContextualGroundingPolicyConfig, BaseFunction>? ContextualGroundingPolicyConfig { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-kmskeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }

        /// <summary>
        /// BlockedInputMessaging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-blockedinputmessaging
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BlockedInputMessaging { get; set; }

        /// <summary>
        /// BlockedOutputsMessaging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-blockedoutputsmessaging
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BlockedOutputsMessaging { get; set; }
        /// <summary>
        /// SensitiveInformationPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-sensitiveinformationpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SensitiveInformationPolicyConfig
        /// </summary>
        public Union<Humidifier.Bedrock.GuardrailTypes.SensitiveInformationPolicyConfig, BaseFunction>? SensitiveInformationPolicyConfig { get; set; }
        /// <summary>
        /// ContentPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-contentpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContentPolicyConfig
        /// </summary>
        public Union<Humidifier.Bedrock.GuardrailTypes.ContentPolicyConfig, BaseFunction>? ContentPolicyConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AutomatedReasoningPolicyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-guardrail.html#cfn-bedrock-guardrail-automatedreasoningpolicyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutomatedReasoningPolicyConfig
        /// </summary>
        public Union<Humidifier.Bedrock.GuardrailTypes.AutomatedReasoningPolicyConfig, BaseFunction>? AutomatedReasoningPolicyConfig { get; set; }
    }

    namespace GuardrailTypes
    {
        public class AutomatedReasoningPolicyConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfPolicies, IHaveConfidenceThreshold_Double
        {
            /// <summary>
            /// Policies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-automatedreasoningpolicyconfig.html#cfn-bedrock-guardrail-automatedreasoningpolicyconfig-policies
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Policies { get; set; }
            /// <summary>
            /// ConfidenceThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-automatedreasoningpolicyconfig.html#cfn-bedrock-guardrail-automatedreasoningpolicyconfig-confidencethreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ConfidenceThreshold { get; set; }
        }

        public class ContentFilterConfig : Humidifier.Base.BaseSubResource, IHaveOutputStrength, IHaveType, IHaveInputEnabled_Boolean, IHaveInputAction, IHaveOutputAction, IHaveInputStrength, IHaveStringListOfInputModalities, IHaveOutputEnabled_Boolean, IHaveStringListOfOutputModalities
        {
            /// <summary>
            /// OutputStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-outputstrength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputStrength { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// InputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-inputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InputEnabled { get; set; }
            /// <summary>
            /// InputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-inputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputAction { get; set; }
            /// <summary>
            /// OutputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-outputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputAction { get; set; }
            /// <summary>
            /// InputStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-inputstrength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputStrength { get; set; }
            /// <summary>
            /// InputModalities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-inputmodalities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InputModalities { get; set; }
            /// <summary>
            /// OutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-outputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OutputEnabled { get; set; }
            /// <summary>
            /// OutputModalities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterconfig.html#cfn-bedrock-guardrail-contentfilterconfig-outputmodalities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OutputModalities { get; set; }
        }

        public class ContentFiltersTierConfig : Humidifier.Base.BaseSubResource, IHaveTierName
        {
            /// <summary>
            /// TierName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentfilterstierconfig.html#cfn-bedrock-guardrail-contentfilterstierconfig-tiername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TierName { get; set; }
        }

        public class ContentPolicyConfig : Humidifier.Base.BaseSubResource, IHaveBedrockGuardrailTypesContentFiltersTierConfigContentFiltersTierConfig, IHaveListOfBedrockGuardrailTypesContentFilterConfigFiltersConfig
        {
            /// <summary>
            /// ContentFiltersTierConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentpolicyconfig.html#cfn-bedrock-guardrail-contentpolicyconfig-contentfilterstierconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContentFiltersTierConfig
            /// </summary>
            public Union<Humidifier.Bedrock.GuardrailTypes.ContentFiltersTierConfig, BaseFunction>? ContentFiltersTierConfig { get; set; }
            /// <summary>
            /// FiltersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contentpolicyconfig.html#cfn-bedrock-guardrail-contentpolicyconfig-filtersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContentFilterConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.GuardrailTypes.ContentFilterConfig>, IReadOnlyList<Union<Humidifier.Bedrock.GuardrailTypes.ContentFilterConfig, BaseFunction>>, BaseFunction>? FiltersConfig { get; set; }
        }

        public class ContextualGroundingFilterConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveAction, IHaveEnabled_Boolean, IHaveThreshold_Double
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contextualgroundingfilterconfig.html#cfn-bedrock-guardrail-contextualgroundingfilterconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contextualgroundingfilterconfig.html#cfn-bedrock-guardrail-contextualgroundingfilterconfig-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contextualgroundingfilterconfig.html#cfn-bedrock-guardrail-contextualgroundingfilterconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contextualgroundingfilterconfig.html#cfn-bedrock-guardrail-contextualgroundingfilterconfig-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Threshold { get; set; }
        }

        public class ContextualGroundingPolicyConfig : Humidifier.Base.BaseSubResource, IHaveListOfBedrockGuardrailTypesContextualGroundingFilterConfigFiltersConfig
        {
            /// <summary>
            /// FiltersConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-contextualgroundingpolicyconfig.html#cfn-bedrock-guardrail-contextualgroundingpolicyconfig-filtersconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ContextualGroundingFilterConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.GuardrailTypes.ContextualGroundingFilterConfig>, IReadOnlyList<Union<Humidifier.Bedrock.GuardrailTypes.ContextualGroundingFilterConfig, BaseFunction>>, BaseFunction>? FiltersConfig { get; set; }
        }

        public class GuardrailCrossRegionConfig : Humidifier.Base.BaseSubResource, IHaveGuardrailProfileArn
        {
            /// <summary>
            /// GuardrailProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-guardrailcrossregionconfig.html#cfn-bedrock-guardrail-guardrailcrossregionconfig-guardrailprofilearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GuardrailProfileArn { get; set; }
        }

        public class ManagedWordsConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveInputEnabled_Boolean, IHaveInputAction, IHaveOutputAction, IHaveOutputEnabled_Boolean
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-managedwordsconfig.html#cfn-bedrock-guardrail-managedwordsconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// InputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-managedwordsconfig.html#cfn-bedrock-guardrail-managedwordsconfig-inputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InputEnabled { get; set; }
            /// <summary>
            /// InputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-managedwordsconfig.html#cfn-bedrock-guardrail-managedwordsconfig-inputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputAction { get; set; }
            /// <summary>
            /// OutputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-managedwordsconfig.html#cfn-bedrock-guardrail-managedwordsconfig-outputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputAction { get; set; }
            /// <summary>
            /// OutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-managedwordsconfig.html#cfn-bedrock-guardrail-managedwordsconfig-outputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OutputEnabled { get; set; }
        }

        public class PiiEntityConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveAction, IHaveInputEnabled_Boolean, IHaveInputAction, IHaveOutputAction, IHaveOutputEnabled_Boolean
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-piientityconfig.html#cfn-bedrock-guardrail-piientityconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-piientityconfig.html#cfn-bedrock-guardrail-piientityconfig-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// InputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-piientityconfig.html#cfn-bedrock-guardrail-piientityconfig-inputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InputEnabled { get; set; }
            /// <summary>
            /// InputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-piientityconfig.html#cfn-bedrock-guardrail-piientityconfig-inputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputAction { get; set; }
            /// <summary>
            /// OutputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-piientityconfig.html#cfn-bedrock-guardrail-piientityconfig-outputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputAction { get; set; }
            /// <summary>
            /// OutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-piientityconfig.html#cfn-bedrock-guardrail-piientityconfig-outputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OutputEnabled { get; set; }
        }

        public class RegexConfig : Humidifier.Base.BaseSubResource, IHavePattern, IHaveAction, IHaveInputEnabled_Boolean, IHaveDescription, IHaveInputAction, IHaveOutputAction, IHaveOutputEnabled_Boolean, IHaveName
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-pattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// InputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-inputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InputEnabled { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// InputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-inputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputAction { get; set; }
            /// <summary>
            /// OutputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-outputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputAction { get; set; }
            /// <summary>
            /// OutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-outputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OutputEnabled { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-regexconfig.html#cfn-bedrock-guardrail-regexconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SensitiveInformationPolicyConfig : Humidifier.Base.BaseSubResource, IHaveListOfBedrockGuardrailTypesRegexConfigRegexesConfig, IHaveListOfBedrockGuardrailTypesPiiEntityConfigPiiEntitiesConfig
        {
            /// <summary>
            /// RegexesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-sensitiveinformationpolicyconfig.html#cfn-bedrock-guardrail-sensitiveinformationpolicyconfig-regexesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RegexConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.GuardrailTypes.RegexConfig>, IReadOnlyList<Union<Humidifier.Bedrock.GuardrailTypes.RegexConfig, BaseFunction>>, BaseFunction>? RegexesConfig { get; set; }
            /// <summary>
            /// PiiEntitiesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-sensitiveinformationpolicyconfig.html#cfn-bedrock-guardrail-sensitiveinformationpolicyconfig-piientitiesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PiiEntityConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.GuardrailTypes.PiiEntityConfig>, IReadOnlyList<Union<Humidifier.Bedrock.GuardrailTypes.PiiEntityConfig, BaseFunction>>, BaseFunction>? PiiEntitiesConfig { get; set; }
        }

        public class TopicConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveInputEnabled_Boolean, IHaveInputAction, IHaveOutputAction, IHaveDefinition, IHaveOutputEnabled_Boolean, IHaveStringListOfExamples, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// InputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-inputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InputEnabled { get; set; }
            /// <summary>
            /// InputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-inputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputAction { get; set; }
            /// <summary>
            /// OutputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-outputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputAction { get; set; }
            /// <summary>
            /// Definition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-definition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Definition { get; set; }
            /// <summary>
            /// OutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-outputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OutputEnabled { get; set; }
            /// <summary>
            /// Examples
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-examples
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Examples { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicconfig.html#cfn-bedrock-guardrail-topicconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TopicPolicyConfig : Humidifier.Base.BaseSubResource, IHaveBedrockGuardrailTypesTopicsTierConfigTopicsTierConfig, IHaveListOfBedrockGuardrailTypesTopicConfigTopicsConfig
        {
            /// <summary>
            /// TopicsTierConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicpolicyconfig.html#cfn-bedrock-guardrail-topicpolicyconfig-topicstierconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TopicsTierConfig
            /// </summary>
            public Union<Humidifier.Bedrock.GuardrailTypes.TopicsTierConfig, BaseFunction>? TopicsTierConfig { get; set; }
            /// <summary>
            /// TopicsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicpolicyconfig.html#cfn-bedrock-guardrail-topicpolicyconfig-topicsconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.GuardrailTypes.TopicConfig>, IReadOnlyList<Union<Humidifier.Bedrock.GuardrailTypes.TopicConfig, BaseFunction>>, BaseFunction>? TopicsConfig { get; set; }
        }

        public class TopicsTierConfig : Humidifier.Base.BaseSubResource, IHaveTierName
        {
            /// <summary>
            /// TierName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-topicstierconfig.html#cfn-bedrock-guardrail-topicstierconfig-tiername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TierName { get; set; }
        }

        public class WordConfig : Humidifier.Base.BaseSubResource, IHaveInputEnabled_Boolean, IHaveInputAction, IHaveOutputAction, IHaveOutputEnabled_Boolean, IHaveText
        {
            /// <summary>
            /// InputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordconfig.html#cfn-bedrock-guardrail-wordconfig-inputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InputEnabled { get; set; }
            /// <summary>
            /// InputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordconfig.html#cfn-bedrock-guardrail-wordconfig-inputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputAction { get; set; }
            /// <summary>
            /// OutputAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordconfig.html#cfn-bedrock-guardrail-wordconfig-outputaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputAction { get; set; }
            /// <summary>
            /// OutputEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordconfig.html#cfn-bedrock-guardrail-wordconfig-outputenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? OutputEnabled { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordconfig.html#cfn-bedrock-guardrail-wordconfig-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class WordPolicyConfig : Humidifier.Base.BaseSubResource, IHaveListOfBedrockGuardrailTypesManagedWordsConfigManagedWordListsConfig, IHaveListOfBedrockGuardrailTypesWordConfigWordsConfig
        {
            /// <summary>
            /// ManagedWordListsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordpolicyconfig.html#cfn-bedrock-guardrail-wordpolicyconfig-managedwordlistsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ManagedWordsConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.GuardrailTypes.ManagedWordsConfig>, IReadOnlyList<Union<Humidifier.Bedrock.GuardrailTypes.ManagedWordsConfig, BaseFunction>>, BaseFunction>? ManagedWordListsConfig { get; set; }
            /// <summary>
            /// WordsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-guardrail-wordpolicyconfig.html#cfn-bedrock-guardrail-wordpolicyconfig-wordsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WordConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.GuardrailTypes.WordConfig>, IReadOnlyList<Union<Humidifier.Bedrock.GuardrailTypes.WordConfig, BaseFunction>>, BaseFunction>? WordsConfig { get; set; }
        }
    }
}