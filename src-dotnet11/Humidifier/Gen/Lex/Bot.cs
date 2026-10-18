namespace Humidifier.Lex
{
    using global::System.Collections.Generic;
    using BotTypes;

    public class Bot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveLexBotTypesErrorLogSettingsErrorLogSettings, IHaveRoleArn, IHaveBotType, IHaveName, IHaveTagListOfBotTags, IHaveTagListOfTestBotAliasTags, IHaveAutoBuildBotLocales_Boolean, IHaveListOfLexBotTypesBotLocaleBotLocales, IHaveIdleSessionTTLInSeconds_Integer, IHaveLexBotTypesS3LocationBotFileS3Location, IHaveLexBotTypesReplicationReplication, IHaveListOfLexBotTypesBotMemberBotMembers, IHaveLexBotTypesTestBotAliasSettingsTestBotAliasSettings, IHaveLexBotTypesDataPrivacyDataPrivacy
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Lex.Bot; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ErrorLogSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-errorlogsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ErrorLogSettings
        /// </summary>
        public Union<Humidifier.Lex.BotTypes.ErrorLogSettings, BaseFunction>? ErrorLogSettings { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// BotType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-bottype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BotType { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// BotTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-bottags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? BotTags { get; set; }
        /// <summary>
        /// TestBotAliasTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-testbotaliastags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? TestBotAliasTags { get; set; }
        /// <summary>
        /// AutoBuildBotLocales
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-autobuildbotlocales
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AutoBuildBotLocales { get; set; }
        /// <summary>
        /// BotLocales
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-botlocales
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BotLocale
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lex.BotTypes.BotLocale>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.BotLocale, BaseFunction>>, BaseFunction>? BotLocales { get; set; }

        /// <summary>
        /// IdleSessionTTLInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-idlesessionttlinseconds
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? IdleSessionTTLInSeconds { get; set; }
        /// <summary>
        /// BotFileS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-botfiles3location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        public Union<Humidifier.Lex.BotTypes.S3Location, BaseFunction>? BotFileS3Location { get; set; }
        /// <summary>
        /// Replication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-replication
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Replication
        /// </summary>
        public Union<Humidifier.Lex.BotTypes.Replication, BaseFunction>? Replication { get; set; }
        /// <summary>
        /// BotMembers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-botmembers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BotMember
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Lex.BotTypes.BotMember>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.BotMember, BaseFunction>>, BaseFunction>? BotMembers { get; set; }
        /// <summary>
        /// TestBotAliasSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-testbotaliassettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TestBotAliasSettings
        /// </summary>
        public Union<Humidifier.Lex.BotTypes.TestBotAliasSettings, BaseFunction>? TestBotAliasSettings { get; set; }

        /// <summary>
        /// DataPrivacy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-dataprivacy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataPrivacy
        /// </summary>
        [Required]
        public Union<Humidifier.Lex.BotTypes.DataPrivacy, BaseFunction>? DataPrivacy { get; set; }
    }

    namespace BotTypes
    {
        public class AdvancedRecognitionSetting : Humidifier.Base.BaseSubResource, IHaveAudioRecognitionStrategy
        {
            /// <summary>
            /// AudioRecognitionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-advancedrecognitionsetting.html#cfn-lex-bot-advancedrecognitionsetting-audiorecognitionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioRecognitionStrategy { get; set; }
        }

        public class AllowedInputTypes : Humidifier.Base.BaseSubResource, IHaveAllowDTMFInput_Boolean, IHaveAllowAudioInput_Boolean
        {
            /// <summary>
            /// AllowDTMFInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-allowedinputtypes.html#cfn-lex-bot-allowedinputtypes-allowdtmfinput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowDTMFInput { get; set; }
            /// <summary>
            /// AllowAudioInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-allowedinputtypes.html#cfn-lex-bot-allowedinputtypes-allowaudioinput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowAudioInput { get; set; }
        }

        public class AudioAndDTMFInputSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesDTMFSpecificationDTMFSpecification, IHaveLexBotTypesAudioSpecificationAudioSpecification, IHaveStartTimeoutMs_Integer
        {
            /// <summary>
            /// DTMFSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audioanddtmfinputspecification.html#cfn-lex-bot-audioanddtmfinputspecification-dtmfspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DTMFSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DTMFSpecification, BaseFunction>? DTMFSpecification { get; set; }
            /// <summary>
            /// AudioSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audioanddtmfinputspecification.html#cfn-lex-bot-audioanddtmfinputspecification-audiospecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.AudioSpecification, BaseFunction>? AudioSpecification { get; set; }
            /// <summary>
            /// StartTimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audioanddtmfinputspecification.html#cfn-lex-bot-audioanddtmfinputspecification-starttimeoutms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTimeoutMs { get; set; }
        }

        public class AudioFillerSettings : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveAudioType, IHaveMinimumPlayDurationInMilliseconds_Integer, IHaveResponseDeliveryDelayInMilliseconds_Integer, IHaveStartDelayInMilliseconds_Integer
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiofillersettings.html#cfn-lex-bot-audiofillersettings-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// AudioType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiofillersettings.html#cfn-lex-bot-audiofillersettings-audiotype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioType { get; set; }
            /// <summary>
            /// MinimumPlayDurationInMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiofillersettings.html#cfn-lex-bot-audiofillersettings-minimumplaydurationinmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumPlayDurationInMilliseconds { get; set; }
            /// <summary>
            /// ResponseDeliveryDelayInMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiofillersettings.html#cfn-lex-bot-audiofillersettings-responsedeliverydelayinmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ResponseDeliveryDelayInMilliseconds { get; set; }
            /// <summary>
            /// StartDelayInMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiofillersettings.html#cfn-lex-bot-audiofillersettings-startdelayinmilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartDelayInMilliseconds { get; set; }
        }

        public class AudioLogDestination : Humidifier.Base.BaseSubResource, IHaveLexBotTypesS3BucketLogDestinationS3Bucket
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiologdestination.html#cfn-lex-bot-audiologdestination-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3BucketLogDestination
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.S3BucketLogDestination, BaseFunction>? S3Bucket { get; set; }
        }

        public class AudioLogSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesAudioLogDestinationDestination, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiologsetting.html#cfn-lex-bot-audiologsetting-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AudioLogDestination
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.AudioLogDestination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiologsetting.html#cfn-lex-bot-audiologsetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class AudioSpecification : Humidifier.Base.BaseSubResource, IHaveEndTimeoutMs_Integer, IHaveMaxLengthMs_Integer
        {
            /// <summary>
            /// EndTimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiospecification.html#cfn-lex-bot-audiospecification-endtimeoutms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndTimeoutMs { get; set; }
            /// <summary>
            /// MaxLengthMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiospecification.html#cfn-lex-bot-audiospecification-maxlengthms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxLengthMs { get; set; }
        }

        public class BKBExactResponseFields : Humidifier.Base.BaseSubResource, IHaveAnswerField
        {
            /// <summary>
            /// AnswerField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bkbexactresponsefields.html#cfn-lex-bot-bkbexactresponsefields-answerfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnswerField { get; set; }
        }

        public class BedrockAgentConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentId, IHaveBedrockAgentAliasId
        {
            /// <summary>
            /// BedrockAgentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockagentconfiguration.html#cfn-lex-bot-bedrockagentconfiguration-bedrockagentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockAgentId { get; set; }
            /// <summary>
            /// BedrockAgentAliasId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockagentconfiguration.html#cfn-lex-bot-bedrockagentconfiguration-bedrockagentaliasid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockAgentAliasId { get; set; }
        }

        public class BedrockAgentIntentConfiguration : Humidifier.Base.BaseSubResource, IHaveLexBotTypesBedrockAgentConfigurationBedrockAgentConfiguration, IHaveLexBotTypesBedrockAgentIntentKnowledgeBaseConfigurationBedrockAgentIntentKnowledgeBaseConfiguration
        {
            /// <summary>
            /// BedrockAgentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockagentintentconfiguration.html#cfn-lex-bot-bedrockagentintentconfiguration-bedrockagentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockAgentConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockAgentConfiguration, BaseFunction>? BedrockAgentConfiguration { get; set; }
            /// <summary>
            /// BedrockAgentIntentKnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockagentintentconfiguration.html#cfn-lex-bot-bedrockagentintentconfiguration-bedrockagentintentknowledgebaseconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockAgentIntentKnowledgeBaseConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockAgentIntentKnowledgeBaseConfiguration, BaseFunction>? BedrockAgentIntentKnowledgeBaseConfiguration { get; set; }
        }

        public class BedrockAgentIntentKnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource, IHaveLexBotTypesBedrockModelSpecificationBedrockModelConfiguration, IHaveBedrockKnowledgeBaseArn
        {
            /// <summary>
            /// BedrockModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockagentintentknowledgebaseconfiguration.html#cfn-lex-bot-bedrockagentintentknowledgebaseconfiguration-bedrockmodelconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BedrockModelSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockModelSpecification, BaseFunction>? BedrockModelConfiguration { get; set; }
            /// <summary>
            /// BedrockKnowledgeBaseArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockagentintentknowledgebaseconfiguration.html#cfn-lex-bot-bedrockagentintentknowledgebaseconfiguration-bedrockknowledgebasearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockKnowledgeBaseArn { get; set; }
        }

        public class BedrockGuardrailConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockGuardrailVersion, IHaveBedrockGuardrailIdentifier
        {
            /// <summary>
            /// BedrockGuardrailVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockguardrailconfiguration.html#cfn-lex-bot-bedrockguardrailconfiguration-bedrockguardrailversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockGuardrailVersion { get; set; }
            /// <summary>
            /// BedrockGuardrailIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockguardrailconfiguration.html#cfn-lex-bot-bedrockguardrailconfiguration-bedrockguardrailidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockGuardrailIdentifier { get; set; }
        }

        public class BedrockKnowledgeStoreConfiguration : Humidifier.Base.BaseSubResource, IHaveLexBotTypesBKBExactResponseFieldsBKBExactResponseFields, IHaveExactResponse_Boolean, IHaveBedrockKnowledgeBaseArn
        {
            /// <summary>
            /// BKBExactResponseFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockknowledgestoreconfiguration.html#cfn-lex-bot-bedrockknowledgestoreconfiguration-bkbexactresponsefields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BKBExactResponseFields
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BKBExactResponseFields, BaseFunction>? BKBExactResponseFields { get; set; }
            /// <summary>
            /// ExactResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockknowledgestoreconfiguration.html#cfn-lex-bot-bedrockknowledgestoreconfiguration-exactresponse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExactResponse { get; set; }
            /// <summary>
            /// BedrockKnowledgeBaseArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockknowledgestoreconfiguration.html#cfn-lex-bot-bedrockknowledgestoreconfiguration-bedrockknowledgebasearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockKnowledgeBaseArn { get; set; }
        }

        public class BedrockModelSpecification : Humidifier.Base.BaseSubResource, IHaveModelArn, IHaveBedrockTraceStatus, IHaveBedrockModelCustomPrompt, IHaveLexBotTypesBedrockGuardrailConfigurationBedrockGuardrailConfiguration
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockmodelspecification.html#cfn-lex-bot-bedrockmodelspecification-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelArn { get; set; }
            /// <summary>
            /// BedrockTraceStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockmodelspecification.html#cfn-lex-bot-bedrockmodelspecification-bedrocktracestatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockTraceStatus { get; set; }
            /// <summary>
            /// BedrockModelCustomPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockmodelspecification.html#cfn-lex-bot-bedrockmodelspecification-bedrockmodelcustomprompt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BedrockModelCustomPrompt { get; set; }
            /// <summary>
            /// BedrockGuardrailConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-bedrockmodelspecification.html#cfn-lex-bot-bedrockmodelspecification-bedrockguardrailconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockGuardrailConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockGuardrailConfiguration, BaseFunction>? BedrockGuardrailConfiguration { get; set; }
        }

        public class BotAliasLocaleSettings : Humidifier.Base.BaseSubResource, IHaveLexBotTypesCodeHookSpecificationCodeHookSpecification, IHaveEnabled_Boolean
        {
            /// <summary>
            /// CodeHookSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botaliaslocalesettings.html#cfn-lex-bot-botaliaslocalesettings-codehookspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeHookSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.CodeHookSpecification, BaseFunction>? CodeHookSpecification { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botaliaslocalesettings.html#cfn-lex-bot-botaliaslocalesettings-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class BotAliasLocaleSettingsItem : Humidifier.Base.BaseSubResource, IHaveLocaleId, IHaveLexBotTypesBotAliasLocaleSettingsBotAliasLocaleSetting
        {
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botaliaslocalesettingsitem.html#cfn-lex-bot-botaliaslocalesettingsitem-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocaleId { get; set; }
            /// <summary>
            /// BotAliasLocaleSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botaliaslocalesettingsitem.html#cfn-lex-bot-botaliaslocalesettingsitem-botaliaslocalesetting
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BotAliasLocaleSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BotAliasLocaleSettings, BaseFunction>? BotAliasLocaleSetting { get; set; }
        }

        public class BotLocale : Humidifier.Base.BaseSubResource, IHaveNluConfidenceThreshold_Double, IHaveLocaleId, IHaveDescription, IHaveLexBotTypesGenerativeAISettingsGenerativeAISettings, IHaveLexBotTypesCustomVocabularyCustomVocabulary, IHaveLexBotTypesSpeechRecognitionSettingsSpeechRecognitionSettings, IHaveListOfLexBotTypesSlotTypeSlotTypes, IHaveLexBotTypesUnifiedSpeechSettingsUnifiedSpeechSettings, IHaveLexBotTypesAudioFillerSettingsAudioFillerSettings, IHaveSpeechDetectionSensitivity, IHaveListOfLexBotTypesIntentIntents, IHaveLexBotTypesVoiceSettingsVoiceSettings
        {
            /// <summary>
            /// NluConfidenceThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-nluconfidencethreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NluConfidenceThreshold { get; set; }
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocaleId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// GenerativeAISettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-generativeaisettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GenerativeAISettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.GenerativeAISettings, BaseFunction>? GenerativeAISettings { get; set; }
            /// <summary>
            /// CustomVocabulary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-customvocabulary
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomVocabulary
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.CustomVocabulary, BaseFunction>? CustomVocabulary { get; set; }
            /// <summary>
            /// SpeechRecognitionSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-speechrecognitionsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpeechRecognitionSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SpeechRecognitionSettings, BaseFunction>? SpeechRecognitionSettings { get; set; }
            /// <summary>
            /// SlotTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-slottypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotType
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SlotType>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SlotType, BaseFunction>>, BaseFunction>? SlotTypes { get; set; }
            /// <summary>
            /// UnifiedSpeechSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-unifiedspeechsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UnifiedSpeechSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.UnifiedSpeechSettings, BaseFunction>? UnifiedSpeechSettings { get; set; }
            /// <summary>
            /// AudioFillerSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-audiofillersettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioFillerSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.AudioFillerSettings, BaseFunction>? AudioFillerSettings { get; set; }
            /// <summary>
            /// SpeechDetectionSensitivity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-speechdetectionsensitivity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpeechDetectionSensitivity { get; set; }
            /// <summary>
            /// Intents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-intents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Intent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.Intent>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.Intent, BaseFunction>>, BaseFunction>? Intents { get; set; }
            /// <summary>
            /// VoiceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-voicesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VoiceSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.VoiceSettings, BaseFunction>? VoiceSettings { get; set; }
        }

        public class BotMember : Humidifier.Base.BaseSubResource, IHaveBotMemberName, IHaveBotMemberAliasName, IHaveBotMemberId, IHaveBotMemberVersion, IHaveBotMemberAliasId
        {
            /// <summary>
            /// BotMemberName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botmember.html#cfn-lex-bot-botmember-botmembername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BotMemberName { get; set; }
            /// <summary>
            /// BotMemberAliasName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botmember.html#cfn-lex-bot-botmember-botmemberaliasname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BotMemberAliasName { get; set; }
            /// <summary>
            /// BotMemberId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botmember.html#cfn-lex-bot-botmember-botmemberid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BotMemberId { get; set; }
            /// <summary>
            /// BotMemberVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botmember.html#cfn-lex-bot-botmember-botmemberversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BotMemberVersion { get; set; }
            /// <summary>
            /// BotMemberAliasId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botmember.html#cfn-lex-bot-botmember-botmemberaliasid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BotMemberAliasId { get; set; }
        }

        public class BuildtimeSettings : Humidifier.Base.BaseSubResource, IHaveLexBotTypesDescriptiveBotBuilderSpecificationDescriptiveBotBuilderSpecification, IHaveLexBotTypesSampleUtteranceGenerationSpecificationSampleUtteranceGenerationSpecification
        {
            /// <summary>
            /// DescriptiveBotBuilderSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-buildtimesettings.html#cfn-lex-bot-buildtimesettings-descriptivebotbuilderspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DescriptiveBotBuilderSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DescriptiveBotBuilderSpecification, BaseFunction>? DescriptiveBotBuilderSpecification { get; set; }
            /// <summary>
            /// SampleUtteranceGenerationSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-buildtimesettings.html#cfn-lex-bot-buildtimesettings-sampleutterancegenerationspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SampleUtteranceGenerationSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SampleUtteranceGenerationSpecification, BaseFunction>? SampleUtteranceGenerationSpecification { get; set; }
        }

        public class Button : Humidifier.Base.BaseSubResource, IHaveValue, IHaveText
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-button.html#cfn-lex-bot-button-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-button.html#cfn-lex-bot-button-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Text { get; set; }
        }

        public class CloudWatchLogGroupLogDestination : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogGroupArn, IHaveLogPrefix
        {
            /// <summary>
            /// CloudWatchLogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-cloudwatchloggrouplogdestination.html#cfn-lex-bot-cloudwatchloggrouplogdestination-cloudwatchloggrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogGroupArn { get; set; }
            /// <summary>
            /// LogPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-cloudwatchloggrouplogdestination.html#cfn-lex-bot-cloudwatchloggrouplogdestination-logprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogPrefix { get; set; }
        }

        public class CodeHookSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesLambdaCodeHookLambdaCodeHook
        {
            /// <summary>
            /// LambdaCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-codehookspecification.html#cfn-lex-bot-codehookspecification-lambdacodehook
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LambdaCodeHook
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.LambdaCodeHook, BaseFunction>? LambdaCodeHook { get; set; }
        }

        public class CompositeSlotTypeSetting : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesSubSlotTypeCompositionSubSlots
        {
            /// <summary>
            /// SubSlots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-compositeslottypesetting.html#cfn-lex-bot-compositeslottypesetting-subslots
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SubSlotTypeComposition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SubSlotTypeComposition>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SubSlotTypeComposition, BaseFunction>>, BaseFunction>? SubSlots { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveExpressionString
        {
            /// <summary>
            /// ExpressionString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-condition.html#cfn-lex-bot-condition-expressionstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExpressionString { get; set; }
        }

        public class ConditionalBranch : Humidifier.Base.BaseSubResource, IHaveLexBotTypesConditionCondition, IHaveLexBotTypesResponseSpecificationResponse, IHaveName, IHaveLexBotTypesDialogStateNextStep
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalbranch.html#cfn-lex-bot-conditionalbranch-condition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Condition
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.Condition, BaseFunction>? Condition { get; set; }
            /// <summary>
            /// Response
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalbranch.html#cfn-lex-bot-conditionalbranch-response
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? Response { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalbranch.html#cfn-lex-bot-conditionalbranch-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// NextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalbranch.html#cfn-lex-bot-conditionalbranch-nextstep
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? NextStep { get; set; }
        }

        public class ConditionalSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesDefaultConditionalBranchDefaultBranch, IHaveIsActive_Boolean, IHaveListOfLexBotTypesConditionalBranchConditionalBranches
        {
            /// <summary>
            /// DefaultBranch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalspecification.html#cfn-lex-bot-conditionalspecification-defaultbranch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultConditionalBranch
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DefaultConditionalBranch, BaseFunction>? DefaultBranch { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalspecification.html#cfn-lex-bot-conditionalspecification-isactive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsActive { get; set; }
            /// <summary>
            /// ConditionalBranches
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalspecification.html#cfn-lex-bot-conditionalspecification-conditionalbranches
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConditionalBranch
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.ConditionalBranch>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.ConditionalBranch, BaseFunction>>, BaseFunction>? ConditionalBranches { get; set; }
        }

        public class ConversationLogSettings : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesTextLogSettingTextLogSettings, IHaveListOfLexBotTypesAudioLogSettingAudioLogSettings
        {
            /// <summary>
            /// TextLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conversationlogsettings.html#cfn-lex-bot-conversationlogsettings-textlogsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextLogSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.TextLogSetting>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.TextLogSetting, BaseFunction>>, BaseFunction>? TextLogSettings { get; set; }
            /// <summary>
            /// AudioLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conversationlogsettings.html#cfn-lex-bot-conversationlogsettings-audiologsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioLogSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.AudioLogSetting>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.AudioLogSetting, BaseFunction>>, BaseFunction>? AudioLogSettings { get; set; }
        }

        public class CustomPayload : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-custompayload.html#cfn-lex-bot-custompayload-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class CustomVocabulary : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesCustomVocabularyItemCustomVocabularyItems
        {
            /// <summary>
            /// CustomVocabularyItems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-customvocabulary.html#cfn-lex-bot-customvocabulary-customvocabularyitems
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomVocabularyItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.CustomVocabularyItem>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.CustomVocabularyItem, BaseFunction>>, BaseFunction>? CustomVocabularyItems { get; set; }
        }

        public class CustomVocabularyItem : Humidifier.Base.BaseSubResource, IHaveDisplayAs, IHavePhrase, IHaveWeight_Integer
        {
            /// <summary>
            /// DisplayAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-customvocabularyitem.html#cfn-lex-bot-customvocabularyitem-displayas
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayAs { get; set; }
            /// <summary>
            /// Phrase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-customvocabularyitem.html#cfn-lex-bot-customvocabularyitem-phrase
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Phrase { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-customvocabularyitem.html#cfn-lex-bot-customvocabularyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
        }

        public class DTMFSpecification : Humidifier.Base.BaseSubResource, IHaveDeletionCharacter, IHaveEndTimeoutMs_Integer, IHaveEndCharacter, IHaveMaxLength_Integer
        {
            /// <summary>
            /// DeletionCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dtmfspecification.html#cfn-lex-bot-dtmfspecification-deletioncharacter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeletionCharacter { get; set; }
            /// <summary>
            /// EndTimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dtmfspecification.html#cfn-lex-bot-dtmfspecification-endtimeoutms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndTimeoutMs { get; set; }
            /// <summary>
            /// EndCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dtmfspecification.html#cfn-lex-bot-dtmfspecification-endcharacter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndCharacter { get; set; }
            /// <summary>
            /// MaxLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dtmfspecification.html#cfn-lex-bot-dtmfspecification-maxlength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxLength { get; set; }
        }

        public class DataPrivacy : Humidifier.Base.BaseSubResource, IHaveChildDirected_Boolean
        {
            /// <summary>
            /// ChildDirected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dataprivacy.html#cfn-lex-bot-dataprivacy-childdirected
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ChildDirected { get; set; }
        }

        public class DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveLexBotTypesBedrockKnowledgeStoreConfigurationBedrockKnowledgeStoreConfiguration, IHaveLexBotTypesQnAKendraConfigurationKendraConfiguration, IHaveLexBotTypesOpensearchConfigurationOpensearchConfiguration
        {
            /// <summary>
            /// BedrockKnowledgeStoreConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-datasourceconfiguration.html#cfn-lex-bot-datasourceconfiguration-bedrockknowledgestoreconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockKnowledgeStoreConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockKnowledgeStoreConfiguration, BaseFunction>? BedrockKnowledgeStoreConfiguration { get; set; }
            /// <summary>
            /// KendraConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-datasourceconfiguration.html#cfn-lex-bot-datasourceconfiguration-kendraconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QnAKendraConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.QnAKendraConfiguration, BaseFunction>? KendraConfiguration { get; set; }
            /// <summary>
            /// OpensearchConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-datasourceconfiguration.html#cfn-lex-bot-datasourceconfiguration-opensearchconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpensearchConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.OpensearchConfiguration, BaseFunction>? OpensearchConfiguration { get; set; }
        }

        public class DeepgramSpeechModelConfig : Humidifier.Base.BaseSubResource, IHaveApiTokenSecretArn, IHaveModelId
        {
            /// <summary>
            /// ApiTokenSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-deepgramspeechmodelconfig.html#cfn-lex-bot-deepgramspeechmodelconfig-apitokensecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiTokenSecretArn { get; set; }
            /// <summary>
            /// ModelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-deepgramspeechmodelconfig.html#cfn-lex-bot-deepgramspeechmodelconfig-modelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelId { get; set; }
        }

        public class DefaultConditionalBranch : Humidifier.Base.BaseSubResource, IHaveLexBotTypesResponseSpecificationResponse, IHaveLexBotTypesDialogStateNextStep
        {
            /// <summary>
            /// Response
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-defaultconditionalbranch.html#cfn-lex-bot-defaultconditionalbranch-response
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? Response { get; set; }
            /// <summary>
            /// NextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-defaultconditionalbranch.html#cfn-lex-bot-defaultconditionalbranch-nextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? NextStep { get; set; }
        }

        public class DescriptiveBotBuilderSpecification : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveLexBotTypesBedrockModelSpecificationBedrockModelSpecification
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-descriptivebotbuilderspecification.html#cfn-lex-bot-descriptivebotbuilderspecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// BedrockModelSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-descriptivebotbuilderspecification.html#cfn-lex-bot-descriptivebotbuilderspecification-bedrockmodelspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockModelSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockModelSpecification, BaseFunction>? BedrockModelSpecification { get; set; }
        }

        public class DialogAction : Humidifier.Base.BaseSubResource, IHaveType, IHaveSlotToElicit, IHaveSuppressNextMessage_Boolean
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogaction.html#cfn-lex-bot-dialogaction-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SlotToElicit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogaction.html#cfn-lex-bot-dialogaction-slottoelicit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotToElicit { get; set; }
            /// <summary>
            /// SuppressNextMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogaction.html#cfn-lex-bot-dialogaction-suppressnextmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SuppressNextMessage { get; set; }
        }

        public class DialogCodeHookInvocationSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesPostDialogCodeHookInvocationSpecificationPostCodeHookSpecification, IHaveEnableCodeHookInvocation_Boolean, IHaveInvocationLabel, IHaveIsActive_Boolean
        {
            /// <summary>
            /// PostCodeHookSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehookinvocationsetting.html#cfn-lex-bot-dialogcodehookinvocationsetting-postcodehookspecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PostDialogCodeHookInvocationSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.PostDialogCodeHookInvocationSpecification, BaseFunction>? PostCodeHookSpecification { get; set; }
            /// <summary>
            /// EnableCodeHookInvocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehookinvocationsetting.html#cfn-lex-bot-dialogcodehookinvocationsetting-enablecodehookinvocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableCodeHookInvocation { get; set; }
            /// <summary>
            /// InvocationLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehookinvocationsetting.html#cfn-lex-bot-dialogcodehookinvocationsetting-invocationlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationLabel { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehookinvocationsetting.html#cfn-lex-bot-dialogcodehookinvocationsetting-isactive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsActive { get; set; }
        }

        public class DialogCodeHookSetting : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehooksetting.html#cfn-lex-bot-dialogcodehooksetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class DialogState : Humidifier.Base.BaseSubResource, IHaveLexBotTypesDialogActionDialogAction, IHaveLexBotTypesIntentOverrideIntent, IHaveListOfLexBotTypesSessionAttributeSessionAttributes
        {
            /// <summary>
            /// DialogAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogstate.html#cfn-lex-bot-dialogstate-dialogaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogAction
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogAction, BaseFunction>? DialogAction { get; set; }
            /// <summary>
            /// Intent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogstate.html#cfn-lex-bot-dialogstate-intent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntentOverride
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.IntentOverride, BaseFunction>? Intent { get; set; }
            /// <summary>
            /// SessionAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogstate.html#cfn-lex-bot-dialogstate-sessionattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SessionAttribute
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SessionAttribute>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SessionAttribute, BaseFunction>>, BaseFunction>? SessionAttributes { get; set; }
        }

        public class ElicitationCodeHookInvocationSetting : Humidifier.Base.BaseSubResource, IHaveEnableCodeHookInvocation_Boolean, IHaveInvocationLabel
        {
            /// <summary>
            /// EnableCodeHookInvocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-elicitationcodehookinvocationsetting.html#cfn-lex-bot-elicitationcodehookinvocationsetting-enablecodehookinvocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableCodeHookInvocation { get; set; }
            /// <summary>
            /// InvocationLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-elicitationcodehookinvocationsetting.html#cfn-lex-bot-elicitationcodehookinvocationsetting-invocationlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationLabel { get; set; }
        }

        public class ErrorLogSettings : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-errorlogsettings.html#cfn-lex-bot-errorlogsettings-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ExactResponseFields : Humidifier.Base.BaseSubResource, IHaveQuestionField, IHaveAnswerField
        {
            /// <summary>
            /// QuestionField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-exactresponsefields.html#cfn-lex-bot-exactresponsefields-questionfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QuestionField { get; set; }
            /// <summary>
            /// AnswerField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-exactresponsefields.html#cfn-lex-bot-exactresponsefields-answerfield
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AnswerField { get; set; }
        }

        public class ExternalSourceSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesGrammarSlotTypeSettingGrammarSlotTypeSetting
        {
            /// <summary>
            /// GrammarSlotTypeSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-externalsourcesetting.html#cfn-lex-bot-externalsourcesetting-grammarslottypesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrammarSlotTypeSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.GrammarSlotTypeSetting, BaseFunction>? GrammarSlotTypeSetting { get; set; }
        }

        public class FulfillmentCodeHookSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesPostFulfillmentStatusSpecificationPostFulfillmentStatusSpecification, IHaveLexBotTypesFulfillmentUpdatesSpecificationFulfillmentUpdatesSpecification, IHaveIsActive_Boolean, IHaveEnabled_Boolean
        {
            /// <summary>
            /// PostFulfillmentStatusSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentcodehooksetting.html#cfn-lex-bot-fulfillmentcodehooksetting-postfulfillmentstatusspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PostFulfillmentStatusSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.PostFulfillmentStatusSpecification, BaseFunction>? PostFulfillmentStatusSpecification { get; set; }
            /// <summary>
            /// FulfillmentUpdatesSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentcodehooksetting.html#cfn-lex-bot-fulfillmentcodehooksetting-fulfillmentupdatesspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FulfillmentUpdatesSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.FulfillmentUpdatesSpecification, BaseFunction>? FulfillmentUpdatesSpecification { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentcodehooksetting.html#cfn-lex-bot-fulfillmentcodehooksetting-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsActive { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentcodehooksetting.html#cfn-lex-bot-fulfillmentcodehooksetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class FulfillmentStartResponseSpecification : Humidifier.Base.BaseSubResource, IHaveDelayInSeconds_Integer, IHaveListOfLexBotTypesMessageGroupMessageGroups, IHaveAllowInterrupt_Boolean
        {
            /// <summary>
            /// DelayInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentstartresponsespecification.html#cfn-lex-bot-fulfillmentstartresponsespecification-delayinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DelayInSeconds { get; set; }
            /// <summary>
            /// MessageGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentstartresponsespecification.html#cfn-lex-bot-fulfillmentstartresponsespecification-messagegroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.MessageGroup>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.MessageGroup, BaseFunction>>, BaseFunction>? MessageGroups { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentstartresponsespecification.html#cfn-lex-bot-fulfillmentstartresponsespecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowInterrupt { get; set; }
        }

        public class FulfillmentUpdateResponseSpecification : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesMessageGroupMessageGroups, IHaveAllowInterrupt_Boolean, IHaveFrequencyInSeconds_Integer
        {
            /// <summary>
            /// MessageGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdateresponsespecification.html#cfn-lex-bot-fulfillmentupdateresponsespecification-messagegroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.MessageGroup>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.MessageGroup, BaseFunction>>, BaseFunction>? MessageGroups { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdateresponsespecification.html#cfn-lex-bot-fulfillmentupdateresponsespecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowInterrupt { get; set; }
            /// <summary>
            /// FrequencyInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdateresponsespecification.html#cfn-lex-bot-fulfillmentupdateresponsespecification-frequencyinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FrequencyInSeconds { get; set; }
        }

        public class FulfillmentUpdatesSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesFulfillmentUpdateResponseSpecificationUpdateResponse, IHaveActive_Boolean, IHaveTimeoutInSeconds_Integer, IHaveLexBotTypesFulfillmentStartResponseSpecificationStartResponse
        {
            /// <summary>
            /// UpdateResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdatesspecification.html#cfn-lex-bot-fulfillmentupdatesspecification-updateresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FulfillmentUpdateResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.FulfillmentUpdateResponseSpecification, BaseFunction>? UpdateResponse { get; set; }
            /// <summary>
            /// Active
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdatesspecification.html#cfn-lex-bot-fulfillmentupdatesspecification-active
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Active { get; set; }
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdatesspecification.html#cfn-lex-bot-fulfillmentupdatesspecification-timeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInSeconds { get; set; }
            /// <summary>
            /// StartResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdatesspecification.html#cfn-lex-bot-fulfillmentupdatesspecification-startresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FulfillmentStartResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.FulfillmentStartResponseSpecification, BaseFunction>? StartResponse { get; set; }
        }

        public class GenerativeAISettings : Humidifier.Base.BaseSubResource, IHaveLexBotTypesRuntimeSettingsRuntimeSettings, IHaveLexBotTypesBuildtimeSettingsBuildtimeSettings
        {
            /// <summary>
            /// RuntimeSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-generativeaisettings.html#cfn-lex-bot-generativeaisettings-runtimesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuntimeSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.RuntimeSettings, BaseFunction>? RuntimeSettings { get; set; }
            /// <summary>
            /// BuildtimeSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-generativeaisettings.html#cfn-lex-bot-generativeaisettings-buildtimesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BuildtimeSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BuildtimeSettings, BaseFunction>? BuildtimeSettings { get; set; }
        }

        public class GrammarSlotTypeSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesGrammarSlotTypeSourceSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-grammarslottypesetting.html#cfn-lex-bot-grammarslottypesetting-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrammarSlotTypeSource
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.GrammarSlotTypeSource, BaseFunction>? Source { get; set; }
        }

        public class GrammarSlotTypeSource : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveS3BucketName, IHaveS3ObjectKey
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-grammarslottypesource.html#cfn-lex-bot-grammarslottypesource-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-grammarslottypesource.html#cfn-lex-bot-grammarslottypesource-s3bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketName { get; set; }
            /// <summary>
            /// S3ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-grammarslottypesource.html#cfn-lex-bot-grammarslottypesource-s3objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectKey { get; set; }
        }

        public class ImageResponseCard : Humidifier.Base.BaseSubResource, IHaveSubtitle, IHaveTitle, IHaveImageUrl, IHaveListOfLexBotTypesButtonButtons
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-imageresponsecard.html#cfn-lex-bot-imageresponsecard-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subtitle { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-imageresponsecard.html#cfn-lex-bot-imageresponsecard-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Title { get; set; }
            /// <summary>
            /// ImageUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-imageresponsecard.html#cfn-lex-bot-imageresponsecard-imageurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageUrl { get; set; }
            /// <summary>
            /// Buttons
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-imageresponsecard.html#cfn-lex-bot-imageresponsecard-buttons
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Button
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.Button>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.Button, BaseFunction>>, BaseFunction>? Buttons { get; set; }
        }

        public class InitialResponseSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesDialogCodeHookInvocationSettingCodeHook, IHaveLexBotTypesResponseSpecificationInitialResponse, IHaveLexBotTypesConditionalSpecificationConditional, IHaveLexBotTypesDialogStateNextStep
        {
            /// <summary>
            /// CodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-initialresponsesetting.html#cfn-lex-bot-initialresponsesetting-codehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogCodeHookInvocationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogCodeHookInvocationSetting, BaseFunction>? CodeHook { get; set; }
            /// <summary>
            /// InitialResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-initialresponsesetting.html#cfn-lex-bot-initialresponsesetting-initialresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? InitialResponse { get; set; }
            /// <summary>
            /// Conditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-initialresponsesetting.html#cfn-lex-bot-initialresponsesetting-conditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? Conditional { get; set; }
            /// <summary>
            /// NextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-initialresponsesetting.html#cfn-lex-bot-initialresponsesetting-nextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? NextStep { get; set; }
        }

        public class InputContext : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-inputcontext.html#cfn-lex-bot-inputcontext-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Intent : Humidifier.Base.BaseSubResource, IHaveLexBotTypesQInConnectIntentConfigurationQInConnectIntentConfiguration, IHaveDescription, IHaveParentIntentSignature, IHaveLexBotTypesInitialResponseSettingInitialResponseSetting, IHaveLexBotTypesBedrockAgentIntentConfigurationBedrockAgentIntentConfiguration, IHaveLexBotTypesFulfillmentCodeHookSettingFulfillmentCodeHook, IHaveLexBotTypesIntentConfirmationSettingIntentConfirmationSetting, IHaveName, IHaveListOfLexBotTypesSlotSlots, IHaveLexBotTypesQnAIntentConfigurationQnAIntentConfiguration, IHaveLexBotTypesDialogCodeHookSettingDialogCodeHook, IHaveListOfLexBotTypesInputContextInputContexts, IHaveLexBotTypesKendraConfigurationKendraConfiguration, IHaveLexBotTypesIntentClosingSettingIntentClosingSetting, IHaveDisplayName, IHaveListOfLexBotTypesOutputContextOutputContexts, IHaveListOfLexBotTypesSlotPrioritySlotPriorities, IHaveListOfLexBotTypesSampleUtteranceSampleUtterances
        {
            /// <summary>
            /// QInConnectIntentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-qinconnectintentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QInConnectIntentConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.QInConnectIntentConfiguration, BaseFunction>? QInConnectIntentConfiguration { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ParentIntentSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-parentintentsignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParentIntentSignature { get; set; }
            /// <summary>
            /// InitialResponseSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-initialresponsesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InitialResponseSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.InitialResponseSetting, BaseFunction>? InitialResponseSetting { get; set; }
            /// <summary>
            /// BedrockAgentIntentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-bedrockagentintentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockAgentIntentConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockAgentIntentConfiguration, BaseFunction>? BedrockAgentIntentConfiguration { get; set; }
            /// <summary>
            /// FulfillmentCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-fulfillmentcodehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FulfillmentCodeHookSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.FulfillmentCodeHookSetting, BaseFunction>? FulfillmentCodeHook { get; set; }
            /// <summary>
            /// IntentConfirmationSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-intentconfirmationsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntentConfirmationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.IntentConfirmationSetting, BaseFunction>? IntentConfirmationSetting { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// Slots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-slots
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Slot
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.Slot>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.Slot, BaseFunction>>, BaseFunction>? Slots { get; set; }
            /// <summary>
            /// QnAIntentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-qnaintentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QnAIntentConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.QnAIntentConfiguration, BaseFunction>? QnAIntentConfiguration { get; set; }
            /// <summary>
            /// DialogCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-dialogcodehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogCodeHookSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogCodeHookSetting, BaseFunction>? DialogCodeHook { get; set; }
            /// <summary>
            /// InputContexts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-inputcontexts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputContext
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.InputContext>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.InputContext, BaseFunction>>, BaseFunction>? InputContexts { get; set; }
            /// <summary>
            /// KendraConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-kendraconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KendraConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.KendraConfiguration, BaseFunction>? KendraConfiguration { get; set; }
            /// <summary>
            /// IntentClosingSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-intentclosingsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntentClosingSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.IntentClosingSetting, BaseFunction>? IntentClosingSetting { get; set; }
            /// <summary>
            /// DisplayName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-displayname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DisplayName { get; set; }
            /// <summary>
            /// OutputContexts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-outputcontexts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputContext
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.OutputContext>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.OutputContext, BaseFunction>>, BaseFunction>? OutputContexts { get; set; }
            /// <summary>
            /// SlotPriorities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-slotpriorities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotPriority
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SlotPriority>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SlotPriority, BaseFunction>>, BaseFunction>? SlotPriorities { get; set; }
            /// <summary>
            /// SampleUtterances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-sampleutterances
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleUtterance
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SampleUtterance>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SampleUtterance, BaseFunction>>, BaseFunction>? SampleUtterances { get; set; }
        }

        public class IntentClosingSetting : Humidifier.Base.BaseSubResource, IHaveIsActive_Boolean, IHaveLexBotTypesResponseSpecificationClosingResponse, IHaveLexBotTypesConditionalSpecificationConditional, IHaveLexBotTypesDialogStateNextStep
        {
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentclosingsetting.html#cfn-lex-bot-intentclosingsetting-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsActive { get; set; }
            /// <summary>
            /// ClosingResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentclosingsetting.html#cfn-lex-bot-intentclosingsetting-closingresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? ClosingResponse { get; set; }
            /// <summary>
            /// Conditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentclosingsetting.html#cfn-lex-bot-intentclosingsetting-conditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? Conditional { get; set; }
            /// <summary>
            /// NextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentclosingsetting.html#cfn-lex-bot-intentclosingsetting-nextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? NextStep { get; set; }
        }

        public class IntentConfirmationSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesPromptSpecificationPromptSpecification, IHaveLexBotTypesResponseSpecificationConfirmationResponse, IHaveLexBotTypesConditionalSpecificationDeclinationConditional, IHaveLexBotTypesConditionalSpecificationFailureConditional, IHaveLexBotTypesConditionalSpecificationConfirmationConditional, IHaveIsActive_Boolean, IHaveLexBotTypesResponseSpecificationFailureResponse, IHaveLexBotTypesDialogCodeHookInvocationSettingCodeHook, IHaveLexBotTypesDialogStateDeclinationNextStep, IHaveLexBotTypesElicitationCodeHookInvocationSettingElicitationCodeHook, IHaveLexBotTypesDialogStateConfirmationNextStep, IHaveLexBotTypesDialogStateFailureNextStep, IHaveLexBotTypesResponseSpecificationDeclinationResponse
        {
            /// <summary>
            /// PromptSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-promptspecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.PromptSpecification, BaseFunction>? PromptSpecification { get; set; }
            /// <summary>
            /// ConfirmationResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-confirmationresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? ConfirmationResponse { get; set; }
            /// <summary>
            /// DeclinationConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-declinationconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? DeclinationConditional { get; set; }
            /// <summary>
            /// FailureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-failureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? FailureConditional { get; set; }
            /// <summary>
            /// ConfirmationConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-confirmationconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? ConfirmationConditional { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsActive { get; set; }
            /// <summary>
            /// FailureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-failureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? FailureResponse { get; set; }
            /// <summary>
            /// CodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-codehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogCodeHookInvocationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogCodeHookInvocationSetting, BaseFunction>? CodeHook { get; set; }
            /// <summary>
            /// DeclinationNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-declinationnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? DeclinationNextStep { get; set; }
            /// <summary>
            /// ElicitationCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-elicitationcodehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ElicitationCodeHookInvocationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ElicitationCodeHookInvocationSetting, BaseFunction>? ElicitationCodeHook { get; set; }
            /// <summary>
            /// ConfirmationNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-confirmationnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? ConfirmationNextStep { get; set; }
            /// <summary>
            /// FailureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-failurenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? FailureNextStep { get; set; }
            /// <summary>
            /// DeclinationResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-declinationresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? DeclinationResponse { get; set; }
        }

        public class IntentDisambiguationSettings : Humidifier.Base.BaseSubResource, IHaveMaxDisambiguationIntents_Integer, IHaveEnabled_Boolean, IHaveCustomDisambiguationMessage
        {
            /// <summary>
            /// MaxDisambiguationIntents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentdisambiguationsettings.html#cfn-lex-bot-intentdisambiguationsettings-maxdisambiguationintents
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxDisambiguationIntents { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentdisambiguationsettings.html#cfn-lex-bot-intentdisambiguationsettings-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// CustomDisambiguationMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentdisambiguationsettings.html#cfn-lex-bot-intentdisambiguationsettings-customdisambiguationmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomDisambiguationMessage { get; set; }
        }

        public class IntentOverride : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesSlotValueOverrideMapSlots, IHaveName
        {
            /// <summary>
            /// Slots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentoverride.html#cfn-lex-bot-intentoverride-slots
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotValueOverrideMap
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SlotValueOverrideMap>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SlotValueOverrideMap, BaseFunction>>, BaseFunction>? Slots { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentoverride.html#cfn-lex-bot-intentoverride-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class KendraConfiguration : Humidifier.Base.BaseSubResource, IHaveQueryFilterString, IHaveQueryFilterStringEnabled_Boolean, IHaveKendraIndex
        {
            /// <summary>
            /// QueryFilterString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-kendraconfiguration.html#cfn-lex-bot-kendraconfiguration-queryfilterstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryFilterString { get; set; }
            /// <summary>
            /// QueryFilterStringEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-kendraconfiguration.html#cfn-lex-bot-kendraconfiguration-queryfilterstringenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? QueryFilterStringEnabled { get; set; }
            /// <summary>
            /// KendraIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-kendraconfiguration.html#cfn-lex-bot-kendraconfiguration-kendraindex
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KendraIndex { get; set; }
        }

        public class LambdaCodeHook : Humidifier.Base.BaseSubResource, IHaveLambdaArn, IHaveCodeHookInterfaceVersion
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-lambdacodehook.html#cfn-lex-bot-lambdacodehook-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
            /// <summary>
            /// CodeHookInterfaceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-lambdacodehook.html#cfn-lex-bot-lambdacodehook-codehookinterfaceversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CodeHookInterfaceVersion { get; set; }
        }

        public class Message : Humidifier.Base.BaseSubResource, IHaveLexBotTypesCustomPayloadCustomPayload, IHaveLexBotTypesImageResponseCardImageResponseCard, IHaveLexBotTypesPlainTextMessagePlainTextMessage, IHaveLexBotTypesSSMLMessageSSMLMessage
        {
            /// <summary>
            /// CustomPayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-message.html#cfn-lex-bot-message-custompayload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPayload
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.CustomPayload, BaseFunction>? CustomPayload { get; set; }
            /// <summary>
            /// ImageResponseCard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-message.html#cfn-lex-bot-message-imageresponsecard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageResponseCard
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ImageResponseCard, BaseFunction>? ImageResponseCard { get; set; }
            /// <summary>
            /// PlainTextMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-message.html#cfn-lex-bot-message-plaintextmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PlainTextMessage
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.PlainTextMessage, BaseFunction>? PlainTextMessage { get; set; }
            /// <summary>
            /// SSMLMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-message.html#cfn-lex-bot-message-ssmlmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SSMLMessage
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SSMLMessage, BaseFunction>? SSMLMessage { get; set; }
        }

        public class MessageGroup : Humidifier.Base.BaseSubResource, IHaveLexBotTypesMessageMessage, IHaveListOfLexBotTypesMessageVariations
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-messagegroup.html#cfn-lex-bot-messagegroup-message
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.Message, BaseFunction>? Message { get; set; }
            /// <summary>
            /// Variations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-messagegroup.html#cfn-lex-bot-messagegroup-variations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Message
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.Message>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.Message, BaseFunction>>, BaseFunction>? Variations { get; set; }
        }

        public class MultipleValuesSetting : Humidifier.Base.BaseSubResource, IHaveAllowMultipleValues_Boolean
        {
            /// <summary>
            /// AllowMultipleValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-multiplevaluessetting.html#cfn-lex-bot-multiplevaluessetting-allowmultiplevalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowMultipleValues { get; set; }
        }

        public class NluImprovementSpecification : Humidifier.Base.BaseSubResource, IHaveAssistedNluMode, IHaveLexBotTypesIntentDisambiguationSettingsIntentDisambiguationSettings, IHaveEnabled_Boolean
        {
            /// <summary>
            /// AssistedNluMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-nluimprovementspecification.html#cfn-lex-bot-nluimprovementspecification-assistednlumode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssistedNluMode { get; set; }
            /// <summary>
            /// IntentDisambiguationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-nluimprovementspecification.html#cfn-lex-bot-nluimprovementspecification-intentdisambiguationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntentDisambiguationSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.IntentDisambiguationSettings, BaseFunction>? IntentDisambiguationSettings { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-nluimprovementspecification.html#cfn-lex-bot-nluimprovementspecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ObfuscationSetting : Humidifier.Base.BaseSubResource, IHaveObfuscationSettingType
        {
            /// <summary>
            /// ObfuscationSettingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-obfuscationsetting.html#cfn-lex-bot-obfuscationsetting-obfuscationsettingtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObfuscationSettingType { get; set; }
        }

        public class OpensearchConfiguration : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveDomainEndpoint, IHaveLexBotTypesExactResponseFieldsExactResponseFields, IHaveExactResponse_Boolean, IHaveStringListOfIncludeFields
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-opensearchconfiguration.html#cfn-lex-bot-opensearchconfiguration-indexname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// DomainEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-opensearchconfiguration.html#cfn-lex-bot-opensearchconfiguration-domainendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainEndpoint { get; set; }
            /// <summary>
            /// ExactResponseFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-opensearchconfiguration.html#cfn-lex-bot-opensearchconfiguration-exactresponsefields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExactResponseFields
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ExactResponseFields, BaseFunction>? ExactResponseFields { get; set; }
            /// <summary>
            /// ExactResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-opensearchconfiguration.html#cfn-lex-bot-opensearchconfiguration-exactresponse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExactResponse { get; set; }
            /// <summary>
            /// IncludeFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-opensearchconfiguration.html#cfn-lex-bot-opensearchconfiguration-includefields
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludeFields { get; set; }
        }

        public class OutputContext : Humidifier.Base.BaseSubResource, IHaveTurnsToLive_Integer, IHaveTimeToLiveInSeconds_Integer, IHaveName
        {
            /// <summary>
            /// TurnsToLive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-outputcontext.html#cfn-lex-bot-outputcontext-turnstolive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TurnsToLive { get; set; }
            /// <summary>
            /// TimeToLiveInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-outputcontext.html#cfn-lex-bot-outputcontext-timetoliveinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeToLiveInSeconds { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-outputcontext.html#cfn-lex-bot-outputcontext-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PlainTextMessage : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-plaintextmessage.html#cfn-lex-bot-plaintextmessage-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class PostDialogCodeHookInvocationSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesResponseSpecificationSuccessResponse, IHaveLexBotTypesConditionalSpecificationFailureConditional, IHaveLexBotTypesDialogStateTimeoutNextStep, IHaveLexBotTypesConditionalSpecificationSuccessConditional, IHaveLexBotTypesResponseSpecificationTimeoutResponse, IHaveLexBotTypesDialogStateSuccessNextStep, IHaveLexBotTypesResponseSpecificationFailureResponse, IHaveLexBotTypesDialogStateFailureNextStep, IHaveLexBotTypesConditionalSpecificationTimeoutConditional
        {
            /// <summary>
            /// SuccessResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-successresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? SuccessResponse { get; set; }
            /// <summary>
            /// FailureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-failureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? FailureConditional { get; set; }
            /// <summary>
            /// TimeoutNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-timeoutnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? TimeoutNextStep { get; set; }
            /// <summary>
            /// SuccessConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-successconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? SuccessConditional { get; set; }
            /// <summary>
            /// TimeoutResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-timeoutresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? TimeoutResponse { get; set; }
            /// <summary>
            /// SuccessNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-successnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? SuccessNextStep { get; set; }
            /// <summary>
            /// FailureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-failureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? FailureResponse { get; set; }
            /// <summary>
            /// FailureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-failurenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? FailureNextStep { get; set; }
            /// <summary>
            /// TimeoutConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-timeoutconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? TimeoutConditional { get; set; }
        }

        public class PostFulfillmentStatusSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesResponseSpecificationSuccessResponse, IHaveLexBotTypesConditionalSpecificationFailureConditional, IHaveLexBotTypesDialogStateTimeoutNextStep, IHaveLexBotTypesConditionalSpecificationSuccessConditional, IHaveLexBotTypesResponseSpecificationTimeoutResponse, IHaveLexBotTypesDialogStateSuccessNextStep, IHaveLexBotTypesResponseSpecificationFailureResponse, IHaveLexBotTypesDialogStateFailureNextStep, IHaveLexBotTypesConditionalSpecificationTimeoutConditional
        {
            /// <summary>
            /// SuccessResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-successresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? SuccessResponse { get; set; }
            /// <summary>
            /// FailureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-failureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? FailureConditional { get; set; }
            /// <summary>
            /// TimeoutNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-timeoutnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? TimeoutNextStep { get; set; }
            /// <summary>
            /// SuccessConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-successconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? SuccessConditional { get; set; }
            /// <summary>
            /// TimeoutResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-timeoutresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? TimeoutResponse { get; set; }
            /// <summary>
            /// SuccessNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-successnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? SuccessNextStep { get; set; }
            /// <summary>
            /// FailureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-failureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? FailureResponse { get; set; }
            /// <summary>
            /// FailureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-failurenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? FailureNextStep { get; set; }
            /// <summary>
            /// TimeoutConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-timeoutconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? TimeoutConditional { get; set; }
        }

        public class PromptAttemptSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesTextInputSpecificationTextInputSpecification, IHaveAllowInterrupt_Boolean, IHaveLexBotTypesAllowedInputTypesAllowedInputTypes, IHaveLexBotTypesAudioAndDTMFInputSpecificationAudioAndDTMFInputSpecification
        {
            /// <summary>
            /// TextInputSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptattemptspecification.html#cfn-lex-bot-promptattemptspecification-textinputspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextInputSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.TextInputSpecification, BaseFunction>? TextInputSpecification { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptattemptspecification.html#cfn-lex-bot-promptattemptspecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowInterrupt { get; set; }
            /// <summary>
            /// AllowedInputTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptattemptspecification.html#cfn-lex-bot-promptattemptspecification-allowedinputtypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AllowedInputTypes
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.AllowedInputTypes, BaseFunction>? AllowedInputTypes { get; set; }
            /// <summary>
            /// AudioAndDTMFInputSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptattemptspecification.html#cfn-lex-bot-promptattemptspecification-audioanddtmfinputspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioAndDTMFInputSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.AudioAndDTMFInputSpecification, BaseFunction>? AudioAndDTMFInputSpecification { get; set; }
        }

        public class PromptSpecification : Humidifier.Base.BaseSubResource, IHaveMaxRetries_Integer, IHaveAllowInterrupt_Boolean, IHaveMessageSelectionStrategy, IHaveListOfLexBotTypesMessageGroupMessageGroupsList, IHaveMapOfLexBotTypesPromptAttemptSpecificationPromptAttemptsSpecification
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxRetries { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowInterrupt { get; set; }
            /// <summary>
            /// MessageSelectionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-messageselectionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MessageSelectionStrategy { get; set; }
            /// <summary>
            /// MessageGroupsList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-messagegroupslist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.MessageGroup>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.MessageGroup, BaseFunction>>, BaseFunction>? MessageGroupsList { get; set; }
            /// <summary>
            /// PromptAttemptsSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-promptattemptsspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PromptAttemptSpecification
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Lex.BotTypes.PromptAttemptSpecification>, IReadOnlyDictionary<string, Union<Humidifier.Lex.BotTypes.PromptAttemptSpecification, BaseFunction>>, BaseFunction>? PromptAttemptsSpecification { get; set; }
        }

        public class QInConnectAssistantConfiguration : Humidifier.Base.BaseSubResource, IHaveAssistantArn
        {
            /// <summary>
            /// AssistantArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-qinconnectassistantconfiguration.html#cfn-lex-bot-qinconnectassistantconfiguration-assistantarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AssistantArn { get; set; }
        }

        public class QInConnectIntentConfiguration : Humidifier.Base.BaseSubResource, IHaveLexBotTypesQInConnectAssistantConfigurationQInConnectAssistantConfiguration
        {
            /// <summary>
            /// QInConnectAssistantConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-qinconnectintentconfiguration.html#cfn-lex-bot-qinconnectintentconfiguration-qinconnectassistantconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QInConnectAssistantConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.QInConnectAssistantConfiguration, BaseFunction>? QInConnectAssistantConfiguration { get; set; }
        }

        public class QnAIntentConfiguration : Humidifier.Base.BaseSubResource, IHaveLexBotTypesBedrockModelSpecificationBedrockModelConfiguration, IHaveLexBotTypesDataSourceConfigurationDataSourceConfiguration
        {
            /// <summary>
            /// BedrockModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-qnaintentconfiguration.html#cfn-lex-bot-qnaintentconfiguration-bedrockmodelconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BedrockModelSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockModelSpecification, BaseFunction>? BedrockModelConfiguration { get; set; }
            /// <summary>
            /// DataSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-qnaintentconfiguration.html#cfn-lex-bot-qnaintentconfiguration-datasourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DataSourceConfiguration
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DataSourceConfiguration, BaseFunction>? DataSourceConfiguration { get; set; }
        }

        public class QnAKendraConfiguration : Humidifier.Base.BaseSubResource, IHaveQueryFilterString, IHaveQueryFilterStringEnabled_Boolean, IHaveKendraIndex, IHaveExactResponse_Boolean
        {
            /// <summary>
            /// QueryFilterString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-qnakendraconfiguration.html#cfn-lex-bot-qnakendraconfiguration-queryfilterstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryFilterString { get; set; }
            /// <summary>
            /// QueryFilterStringEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-qnakendraconfiguration.html#cfn-lex-bot-qnakendraconfiguration-queryfilterstringenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? QueryFilterStringEnabled { get; set; }
            /// <summary>
            /// KendraIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-qnakendraconfiguration.html#cfn-lex-bot-qnakendraconfiguration-kendraindex
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KendraIndex { get; set; }
            /// <summary>
            /// ExactResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-qnakendraconfiguration.html#cfn-lex-bot-qnakendraconfiguration-exactresponse
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExactResponse { get; set; }
        }

        public class Replication : Humidifier.Base.BaseSubResource, IHaveStringListOfReplicaRegions
        {
            /// <summary>
            /// ReplicaRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-replication.html#cfn-lex-bot-replication-replicaregions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReplicaRegions { get; set; }
        }

        public class ResponseSpecification : Humidifier.Base.BaseSubResource, IHaveAllowInterrupt_Boolean, IHaveListOfLexBotTypesMessageGroupMessageGroupsList
        {
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-responsespecification.html#cfn-lex-bot-responsespecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowInterrupt { get; set; }
            /// <summary>
            /// MessageGroupsList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-responsespecification.html#cfn-lex-bot-responsespecification-messagegroupslist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.MessageGroup>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.MessageGroup, BaseFunction>>, BaseFunction>? MessageGroupsList { get; set; }
        }

        public class RuntimeSettings : Humidifier.Base.BaseSubResource, IHaveLexBotTypesSlotResolutionImprovementSpecificationSlotResolutionImprovementSpecification, IHaveLexBotTypesNluImprovementSpecificationNluImprovementSpecification
        {
            /// <summary>
            /// SlotResolutionImprovementSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-runtimesettings.html#cfn-lex-bot-runtimesettings-slotresolutionimprovementspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotResolutionImprovementSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotResolutionImprovementSpecification, BaseFunction>? SlotResolutionImprovementSpecification { get; set; }
            /// <summary>
            /// NluImprovementSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-runtimesettings.html#cfn-lex-bot-runtimesettings-nluimprovementspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NluImprovementSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.NluImprovementSpecification, BaseFunction>? NluImprovementSpecification { get; set; }
        }

        public class S3BucketLogDestination : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveLogPrefix, IHaveS3BucketArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3bucketlogdestination.html#cfn-lex-bot-s3bucketlogdestination-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// LogPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3bucketlogdestination.html#cfn-lex-bot-s3bucketlogdestination-logprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogPrefix { get; set; }
            /// <summary>
            /// S3BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3bucketlogdestination.html#cfn-lex-bot-s3bucketlogdestination-s3bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketArn { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveS3ObjectVersion, IHaveS3Bucket, IHaveS3ObjectKey
        {
            /// <summary>
            /// S3ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3location.html#cfn-lex-bot-s3location-s3objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectVersion { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3location.html#cfn-lex-bot-s3location-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3location.html#cfn-lex-bot-s3location-s3objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3ObjectKey { get; set; }
        }

        public class SSMLMessage : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-ssmlmessage.html#cfn-lex-bot-ssmlmessage-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class SampleUtterance : Humidifier.Base.BaseSubResource, IHaveUtterance
        {
            /// <summary>
            /// Utterance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sampleutterance.html#cfn-lex-bot-sampleutterance-utterance
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Utterance { get; set; }
        }

        public class SampleUtteranceGenerationSpecification : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveLexBotTypesBedrockModelSpecificationBedrockModelSpecification
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sampleutterancegenerationspecification.html#cfn-lex-bot-sampleutterancegenerationspecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// BedrockModelSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sampleutterancegenerationspecification.html#cfn-lex-bot-sampleutterancegenerationspecification-bedrockmodelspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockModelSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockModelSpecification, BaseFunction>? BedrockModelSpecification { get; set; }
        }

        public class SampleValue : Humidifier.Base.BaseSubResource, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-samplevalue.html#cfn-lex-bot-samplevalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class SentimentAnalysisSettings : Humidifier.Base.BaseSubResource, IHaveDetectSentiment_Boolean
        {
            /// <summary>
            /// DetectSentiment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sentimentanalysissettings.html#cfn-lex-bot-sentimentanalysissettings-detectsentiment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DetectSentiment { get; set; }
        }

        public class SessionAttribute : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sessionattribute.html#cfn-lex-bot-sessionattribute-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sessionattribute.html#cfn-lex-bot-sessionattribute-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Slot : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveSlotTypeName, IHaveLexBotTypesSlotValueElicitationSettingValueElicitationSetting, IHaveLexBotTypesSubSlotSettingSubSlotSetting, IHaveLexBotTypesObfuscationSettingObfuscationSetting, IHaveName, IHaveLexBotTypesMultipleValuesSettingMultipleValuesSetting
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// SlotTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-slottypename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotTypeName { get; set; }
            /// <summary>
            /// ValueElicitationSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-valueelicitationsetting
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SlotValueElicitationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotValueElicitationSetting, BaseFunction>? ValueElicitationSetting { get; set; }
            /// <summary>
            /// SubSlotSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-subslotsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SubSlotSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SubSlotSetting, BaseFunction>? SubSlotSetting { get; set; }
            /// <summary>
            /// ObfuscationSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-obfuscationsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObfuscationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ObfuscationSetting, BaseFunction>? ObfuscationSetting { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// MultipleValuesSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-multiplevaluessetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultipleValuesSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.MultipleValuesSetting, BaseFunction>? MultipleValuesSetting { get; set; }
        }

        public class SlotCaptureSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesConditionalSpecificationCaptureConditional, IHaveLexBotTypesConditionalSpecificationFailureConditional, IHaveLexBotTypesResponseSpecificationCaptureResponse, IHaveLexBotTypesDialogStateCaptureNextStep, IHaveLexBotTypesResponseSpecificationFailureResponse, IHaveLexBotTypesDialogCodeHookInvocationSettingCodeHook, IHaveLexBotTypesDialogStateFailureNextStep, IHaveLexBotTypesElicitationCodeHookInvocationSettingElicitationCodeHook
        {
            /// <summary>
            /// CaptureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-captureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? CaptureConditional { get; set; }
            /// <summary>
            /// FailureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-failureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConditionalSpecification, BaseFunction>? FailureConditional { get; set; }
            /// <summary>
            /// CaptureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-captureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? CaptureResponse { get; set; }
            /// <summary>
            /// CaptureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-capturenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? CaptureNextStep { get; set; }
            /// <summary>
            /// FailureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-failureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? FailureResponse { get; set; }
            /// <summary>
            /// CodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-codehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogCodeHookInvocationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogCodeHookInvocationSetting, BaseFunction>? CodeHook { get; set; }
            /// <summary>
            /// FailureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-failurenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DialogState, BaseFunction>? FailureNextStep { get; set; }
            /// <summary>
            /// ElicitationCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-elicitationcodehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ElicitationCodeHookInvocationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ElicitationCodeHookInvocationSetting, BaseFunction>? ElicitationCodeHook { get; set; }
        }

        public class SlotDefaultValue : Humidifier.Base.BaseSubResource, IHaveDefaultValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotdefaultvalue.html#cfn-lex-bot-slotdefaultvalue-defaultvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
        }

        public class SlotDefaultValueSpecification : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesSlotDefaultValueDefaultValueList
        {
            /// <summary>
            /// DefaultValueList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotdefaultvaluespecification.html#cfn-lex-bot-slotdefaultvaluespecification-defaultvaluelist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotDefaultValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SlotDefaultValue>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SlotDefaultValue, BaseFunction>>, BaseFunction>? DefaultValueList { get; set; }
        }

        public class SlotPriority : Humidifier.Base.BaseSubResource, IHavePriority_Integer, IHaveSlotName
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotpriority.html#cfn-lex-bot-slotpriority-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// SlotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotpriority.html#cfn-lex-bot-slotpriority-slotname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotName { get; set; }
        }

        public class SlotResolutionImprovementSpecification : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveLexBotTypesBedrockModelSpecificationBedrockModelSpecification
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotresolutionimprovementspecification.html#cfn-lex-bot-slotresolutionimprovementspecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// BedrockModelSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotresolutionimprovementspecification.html#cfn-lex-bot-slotresolutionimprovementspecification-bedrockmodelspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockModelSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.BedrockModelSpecification, BaseFunction>? BedrockModelSpecification { get; set; }
        }

        public class SlotType : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesSlotTypeValueSlotTypeValues, IHaveDescription, IHaveParentSlotTypeSignature, IHaveLexBotTypesSlotValueSelectionSettingValueSelectionSetting, IHaveLexBotTypesCompositeSlotTypeSettingCompositeSlotTypeSetting, IHaveLexBotTypesExternalSourceSettingExternalSourceSetting, IHaveName
        {
            /// <summary>
            /// SlotTypeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-slottypevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotTypeValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SlotTypeValue>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SlotTypeValue, BaseFunction>>, BaseFunction>? SlotTypeValues { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ParentSlotTypeSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-parentslottypesignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParentSlotTypeSignature { get; set; }
            /// <summary>
            /// ValueSelectionSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-valueselectionsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotValueSelectionSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotValueSelectionSetting, BaseFunction>? ValueSelectionSetting { get; set; }
            /// <summary>
            /// CompositeSlotTypeSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-compositeslottypesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CompositeSlotTypeSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.CompositeSlotTypeSetting, BaseFunction>? CompositeSlotTypeSetting { get; set; }
            /// <summary>
            /// ExternalSourceSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-externalsourcesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExternalSourceSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ExternalSourceSetting, BaseFunction>? ExternalSourceSetting { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SlotTypeValue : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesSampleValueSynonyms, IHaveLexBotTypesSampleValueSampleValue
        {
            /// <summary>
            /// Synonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottypevalue.html#cfn-lex-bot-slottypevalue-synonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SampleValue>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SampleValue, BaseFunction>>, BaseFunction>? Synonyms { get; set; }
            /// <summary>
            /// SampleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottypevalue.html#cfn-lex-bot-slottypevalue-samplevalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SampleValue
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SampleValue, BaseFunction>? SampleValue { get; set; }
        }

        public class SlotValue : Humidifier.Base.BaseSubResource, IHaveInterpretedValue
        {
            /// <summary>
            /// InterpretedValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalue.html#cfn-lex-bot-slotvalue-interpretedvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InterpretedValue { get; set; }
        }

        public class SlotValueElicitationSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesPromptSpecificationPromptSpecification, IHaveLexBotTypesWaitAndContinueSpecificationWaitAndContinueSpecification, IHaveSlotConstraint, IHaveLexBotTypesSlotCaptureSettingSlotCaptureSetting, IHaveListOfLexBotTypesSampleUtteranceSampleUtterances, IHaveLexBotTypesSlotDefaultValueSpecificationDefaultValueSpecification
        {
            /// <summary>
            /// PromptSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-promptspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.PromptSpecification, BaseFunction>? PromptSpecification { get; set; }
            /// <summary>
            /// WaitAndContinueSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-waitandcontinuespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaitAndContinueSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.WaitAndContinueSpecification, BaseFunction>? WaitAndContinueSpecification { get; set; }
            /// <summary>
            /// SlotConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-slotconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotConstraint { get; set; }
            /// <summary>
            /// SlotCaptureSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-slotcapturesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotCaptureSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotCaptureSetting, BaseFunction>? SlotCaptureSetting { get; set; }
            /// <summary>
            /// SampleUtterances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-sampleutterances
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleUtterance
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SampleUtterance>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SampleUtterance, BaseFunction>>, BaseFunction>? SampleUtterances { get; set; }
            /// <summary>
            /// DefaultValueSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-defaultvaluespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotDefaultValueSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotDefaultValueSpecification, BaseFunction>? DefaultValueSpecification { get; set; }
        }

        public class SlotValueOverride : Humidifier.Base.BaseSubResource, IHaveLexBotTypesSlotValueValue, IHaveListOfLexBotTypesSlotValueOverrideValues, IHaveShape
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverride.html#cfn-lex-bot-slotvalueoverride-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotValue
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverride.html#cfn-lex-bot-slotvalueoverride-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotValueOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SlotValueOverride>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SlotValueOverride, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverride.html#cfn-lex-bot-slotvalueoverride-shape
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Shape { get; set; }
        }

        public class SlotValueOverrideMap : Humidifier.Base.BaseSubResource, IHaveSlotName, IHaveLexBotTypesSlotValueOverrideSlotValueOverride
        {
            /// <summary>
            /// SlotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverridemap.html#cfn-lex-bot-slotvalueoverridemap-slotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotName { get; set; }
            /// <summary>
            /// SlotValueOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverridemap.html#cfn-lex-bot-slotvalueoverridemap-slotvalueoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotValueOverride
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotValueOverride, BaseFunction>? SlotValueOverride { get; set; }
        }

        public class SlotValueRegexFilter : Humidifier.Base.BaseSubResource, IHavePattern
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueregexfilter.html#cfn-lex-bot-slotvalueregexfilter-pattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
        }

        public class SlotValueSelectionSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesAdvancedRecognitionSettingAdvancedRecognitionSetting, IHaveLexBotTypesSlotValueRegexFilterRegexFilter, IHaveResolutionStrategy
        {
            /// <summary>
            /// AdvancedRecognitionSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueselectionsetting.html#cfn-lex-bot-slotvalueselectionsetting-advancedrecognitionsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedRecognitionSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.AdvancedRecognitionSetting, BaseFunction>? AdvancedRecognitionSetting { get; set; }
            /// <summary>
            /// RegexFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueselectionsetting.html#cfn-lex-bot-slotvalueselectionsetting-regexfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotValueRegexFilter
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotValueRegexFilter, BaseFunction>? RegexFilter { get; set; }
            /// <summary>
            /// ResolutionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueselectionsetting.html#cfn-lex-bot-slotvalueselectionsetting-resolutionstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResolutionStrategy { get; set; }
        }

        public class Specifications : Humidifier.Base.BaseSubResource, IHaveSlotTypeName, IHaveLexBotTypesSubSlotValueElicitationSettingValueElicitationSetting, IHaveSlotTypeId
        {
            /// <summary>
            /// SlotTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-specifications.html#cfn-lex-bot-specifications-slottypename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotTypeName { get; set; }
            /// <summary>
            /// ValueElicitationSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-specifications.html#cfn-lex-bot-specifications-valueelicitationsetting
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SubSlotValueElicitationSetting
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SubSlotValueElicitationSetting, BaseFunction>? ValueElicitationSetting { get; set; }
            /// <summary>
            /// SlotTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-specifications.html#cfn-lex-bot-specifications-slottypeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotTypeId { get; set; }
        }

        public class SpeechFoundationModel : Humidifier.Base.BaseSubResource, IHaveModelArn, IHaveVoiceId
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-speechfoundationmodel.html#cfn-lex-bot-speechfoundationmodel-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelArn { get; set; }
            /// <summary>
            /// VoiceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-speechfoundationmodel.html#cfn-lex-bot-speechfoundationmodel-voiceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VoiceId { get; set; }
        }

        public class SpeechModelConfig : Humidifier.Base.BaseSubResource, IHaveLexBotTypesDeepgramSpeechModelConfigDeepgramConfig
        {
            /// <summary>
            /// DeepgramConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-speechmodelconfig.html#cfn-lex-bot-speechmodelconfig-deepgramconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeepgramSpeechModelConfig
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.DeepgramSpeechModelConfig, BaseFunction>? DeepgramConfig { get; set; }
        }

        public class SpeechRecognitionSettings : Humidifier.Base.BaseSubResource, IHaveSpeechModelPreference, IHaveLexBotTypesSpeechModelConfigSpeechModelConfig
        {
            /// <summary>
            /// SpeechModelPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-speechrecognitionsettings.html#cfn-lex-bot-speechrecognitionsettings-speechmodelpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpeechModelPreference { get; set; }
            /// <summary>
            /// SpeechModelConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-speechrecognitionsettings.html#cfn-lex-bot-speechrecognitionsettings-speechmodelconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpeechModelConfig
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SpeechModelConfig, BaseFunction>? SpeechModelConfig { get; set; }
        }

        public class StillWaitingResponseSpecification : Humidifier.Base.BaseSubResource, IHaveListOfLexBotTypesMessageGroupMessageGroupsList, IHaveTimeoutInSeconds_Integer, IHaveAllowInterrupt_Boolean, IHaveFrequencyInSeconds_Integer
        {
            /// <summary>
            /// MessageGroupsList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-stillwaitingresponsespecification.html#cfn-lex-bot-stillwaitingresponsespecification-messagegroupslist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.MessageGroup>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.MessageGroup, BaseFunction>>, BaseFunction>? MessageGroupsList { get; set; }
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-stillwaitingresponsespecification.html#cfn-lex-bot-stillwaitingresponsespecification-timeoutinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutInSeconds { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-stillwaitingresponsespecification.html#cfn-lex-bot-stillwaitingresponsespecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AllowInterrupt { get; set; }
            /// <summary>
            /// FrequencyInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-stillwaitingresponsespecification.html#cfn-lex-bot-stillwaitingresponsespecification-frequencyinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FrequencyInSeconds { get; set; }
        }

        public class SubSlotSetting : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveMapOfLexBotTypesSpecificationsSlotSpecifications
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslotsetting.html#cfn-lex-bot-subslotsetting-expression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// SlotSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslotsetting.html#cfn-lex-bot-subslotsetting-slotspecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: Specifications
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Lex.BotTypes.Specifications>, IReadOnlyDictionary<string, Union<Humidifier.Lex.BotTypes.Specifications, BaseFunction>>, BaseFunction>? SlotSpecifications { get; set; }
        }

        public class SubSlotTypeComposition : Humidifier.Base.BaseSubResource, IHaveSlotTypeName, IHaveSlotTypeId, IHaveName
        {
            /// <summary>
            /// SlotTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslottypecomposition.html#cfn-lex-bot-subslottypecomposition-slottypename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotTypeName { get; set; }
            /// <summary>
            /// SlotTypeId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslottypecomposition.html#cfn-lex-bot-subslottypecomposition-slottypeid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlotTypeId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslottypecomposition.html#cfn-lex-bot-subslottypecomposition-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SubSlotValueElicitationSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesPromptSpecificationPromptSpecification, IHaveLexBotTypesWaitAndContinueSpecificationWaitAndContinueSpecification, IHaveListOfLexBotTypesSampleUtteranceSampleUtterances, IHaveLexBotTypesSlotDefaultValueSpecificationDefaultValueSpecification
        {
            /// <summary>
            /// PromptSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslotvalueelicitationsetting.html#cfn-lex-bot-subslotvalueelicitationsetting-promptspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.PromptSpecification, BaseFunction>? PromptSpecification { get; set; }
            /// <summary>
            /// WaitAndContinueSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslotvalueelicitationsetting.html#cfn-lex-bot-subslotvalueelicitationsetting-waitandcontinuespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaitAndContinueSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.WaitAndContinueSpecification, BaseFunction>? WaitAndContinueSpecification { get; set; }
            /// <summary>
            /// SampleUtterances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslotvalueelicitationsetting.html#cfn-lex-bot-subslotvalueelicitationsetting-sampleutterances
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleUtterance
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.SampleUtterance>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.SampleUtterance, BaseFunction>>, BaseFunction>? SampleUtterances { get; set; }
            /// <summary>
            /// DefaultValueSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-subslotvalueelicitationsetting.html#cfn-lex-bot-subslotvalueelicitationsetting-defaultvaluespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotDefaultValueSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SlotDefaultValueSpecification, BaseFunction>? DefaultValueSpecification { get; set; }
        }

        public class TestBotAliasSettings : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveListOfLexBotTypesBotAliasLocaleSettingsItemBotAliasLocaleSettings, IHaveLexBotTypesConversationLogSettingsConversationLogSettings, IHaveLexBotTypesSentimentAnalysisSettingsSentimentAnalysisSettings
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-testbotaliassettings.html#cfn-lex-bot-testbotaliassettings-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// BotAliasLocaleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-testbotaliassettings.html#cfn-lex-bot-testbotaliassettings-botaliaslocalesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BotAliasLocaleSettingsItem
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Lex.BotTypes.BotAliasLocaleSettingsItem>, IReadOnlyList<Union<Humidifier.Lex.BotTypes.BotAliasLocaleSettingsItem, BaseFunction>>, BaseFunction>? BotAliasLocaleSettings { get; set; }
            /// <summary>
            /// ConversationLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-testbotaliassettings.html#cfn-lex-bot-testbotaliassettings-conversationlogsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConversationLogSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ConversationLogSettings, BaseFunction>? ConversationLogSettings { get; set; }
            /// <summary>
            /// SentimentAnalysisSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-testbotaliassettings.html#cfn-lex-bot-testbotaliassettings-sentimentanalysissettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SentimentAnalysisSettings
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SentimentAnalysisSettings, BaseFunction>? SentimentAnalysisSettings { get; set; }
        }

        public class TextInputSpecification : Humidifier.Base.BaseSubResource, IHaveStartTimeoutMs_Integer
        {
            /// <summary>
            /// StartTimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-textinputspecification.html#cfn-lex-bot-textinputspecification-starttimeoutms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartTimeoutMs { get; set; }
        }

        public class TextLogDestination : Humidifier.Base.BaseSubResource, IHaveLexBotTypesCloudWatchLogGroupLogDestinationCloudWatch
        {
            /// <summary>
            /// CloudWatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-textlogdestination.html#cfn-lex-bot-textlogdestination-cloudwatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchLogGroupLogDestination
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.CloudWatchLogGroupLogDestination, BaseFunction>? CloudWatch { get; set; }
        }

        public class TextLogSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesTextLogDestinationDestination, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-textlogsetting.html#cfn-lex-bot-textlogsetting-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextLogDestination
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.TextLogDestination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-textlogsetting.html#cfn-lex-bot-textlogsetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class UnifiedSpeechSettings : Humidifier.Base.BaseSubResource, IHaveLexBotTypesSpeechFoundationModelSpeechFoundationModel
        {
            /// <summary>
            /// SpeechFoundationModel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-unifiedspeechsettings.html#cfn-lex-bot-unifiedspeechsettings-speechfoundationmodel
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpeechFoundationModel
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.SpeechFoundationModel, BaseFunction>? SpeechFoundationModel { get; set; }
        }

        public class VoiceSettings : Humidifier.Base.BaseSubResource, IHaveVoiceId, IHaveEngine
        {
            /// <summary>
            /// VoiceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-voicesettings.html#cfn-lex-bot-voicesettings-voiceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VoiceId { get; set; }
            /// <summary>
            /// Engine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-voicesettings.html#cfn-lex-bot-voicesettings-engine
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Engine { get; set; }
        }

        public class WaitAndContinueSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesResponseSpecificationWaitingResponse, IHaveLexBotTypesStillWaitingResponseSpecificationStillWaitingResponse, IHaveIsActive_Boolean, IHaveLexBotTypesResponseSpecificationContinueResponse
        {
            /// <summary>
            /// WaitingResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-waitandcontinuespecification.html#cfn-lex-bot-waitandcontinuespecification-waitingresponse
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? WaitingResponse { get; set; }
            /// <summary>
            /// StillWaitingResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-waitandcontinuespecification.html#cfn-lex-bot-waitandcontinuespecification-stillwaitingresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StillWaitingResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.StillWaitingResponseSpecification, BaseFunction>? StillWaitingResponse { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-waitandcontinuespecification.html#cfn-lex-bot-waitandcontinuespecification-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsActive { get; set; }
            /// <summary>
            /// ContinueResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-waitandcontinuespecification.html#cfn-lex-bot-waitandcontinuespecification-continueresponse
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Union<Humidifier.Lex.BotTypes.ResponseSpecification, BaseFunction>? ContinueResponse { get; set; }
        }
    }
}