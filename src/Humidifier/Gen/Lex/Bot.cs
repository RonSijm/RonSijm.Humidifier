namespace Humidifier.Lex
{
    using System.Collections.Generic;
    using BotTypes;

    public class Bot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveRoleArn, IHaveIdleSessionTTLInSeconds
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
        public dynamic Description { get; set; }
        /// <summary>
        /// AutoBuildBotLocales
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-autobuildbotlocales
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoBuildBotLocales { get; set; }
        /// <summary>
        /// BotLocales
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-botlocales
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BotLocale
        /// </summary>
        public List<Humidifier.Lex.BotTypes.BotLocale> BotLocales { get; set; }

        /// <summary>
        /// IdleSessionTTLInSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-idlesessionttlinseconds
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic IdleSessionTTLInSeconds { get; set; }
        /// <summary>
        /// BotFileS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-botfiles3location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3Location
        /// </summary>
        public Humidifier.Lex.BotTypes.S3Location BotFileS3Location { get; set; }
        /// <summary>
        /// Replication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-replication
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Replication
        /// </summary>
        public Humidifier.Lex.BotTypes.Replication Replication { get; set; }
        /// <summary>
        /// TestBotAliasSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-testbotaliassettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TestBotAliasSettings
        /// </summary>
        public Humidifier.Lex.BotTypes.TestBotAliasSettings TestBotAliasSettings { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// BotTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-bottags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> BotTags { get; set; }
        /// <summary>
        /// TestBotAliasTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-testbotaliastags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> TestBotAliasTags { get; set; }

        /// <summary>
        /// DataPrivacy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-bot.html#cfn-lex-bot-dataprivacy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataPrivacy
        /// </summary>
        [Required]
        public Humidifier.Lex.BotTypes.DataPrivacy DataPrivacy { get; set; }
    }

    namespace BotTypes
    {
        public class AdvancedRecognitionSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AudioRecognitionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-advancedrecognitionsetting.html#cfn-lex-bot-advancedrecognitionsetting-audiorecognitionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AudioRecognitionStrategy { get; set; }
        }

        public class AllowedInputTypes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowDTMFInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-allowedinputtypes.html#cfn-lex-bot-allowedinputtypes-allowdtmfinput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowDTMFInput { get; set; }
            /// <summary>
            /// AllowAudioInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-allowedinputtypes.html#cfn-lex-bot-allowedinputtypes-allowaudioinput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowAudioInput { get; set; }
        }

        public class AudioAndDTMFInputSpecification : Humidifier.Base.BaseSubResource, IHaveStartTimeoutMs
        {
            /// <summary>
            /// DTMFSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audioanddtmfinputspecification.html#cfn-lex-bot-audioanddtmfinputspecification-dtmfspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DTMFSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.DTMFSpecification DTMFSpecification { get; set; }
            /// <summary>
            /// AudioSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audioanddtmfinputspecification.html#cfn-lex-bot-audioanddtmfinputspecification-audiospecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.AudioSpecification AudioSpecification { get; set; }
            /// <summary>
            /// StartTimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audioanddtmfinputspecification.html#cfn-lex-bot-audioanddtmfinputspecification-starttimeoutms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StartTimeoutMs { get; set; }
        }

        public class AudioLogDestination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiologdestination.html#cfn-lex-bot-audiologdestination-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3BucketLogDestination
            /// </summary>
            public Humidifier.Lex.BotTypes.S3BucketLogDestination S3Bucket { get; set; }
        }

        public class AudioLogSetting : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiologsetting.html#cfn-lex-bot-audiologsetting-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AudioLogDestination
            /// </summary>
            public Humidifier.Lex.BotTypes.AudioLogDestination Destination { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiologsetting.html#cfn-lex-bot-audiologsetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class AudioSpecification : Humidifier.Base.BaseSubResource, IHaveEndTimeoutMs
        {
            /// <summary>
            /// EndTimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiospecification.html#cfn-lex-bot-audiospecification-endtimeoutms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EndTimeoutMs { get; set; }
            /// <summary>
            /// MaxLengthMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-audiospecification.html#cfn-lex-bot-audiospecification-maxlengthms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxLengthMs { get; set; }
        }

        public class BotAliasLocaleSettings : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// CodeHookSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botaliaslocalesettings.html#cfn-lex-bot-botaliaslocalesettings-codehookspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeHookSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.CodeHookSpecification CodeHookSpecification { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botaliaslocalesettings.html#cfn-lex-bot-botaliaslocalesettings-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class BotAliasLocaleSettingsItem : Humidifier.Base.BaseSubResource, IHaveLocaleId
        {
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botaliaslocalesettingsitem.html#cfn-lex-bot-botaliaslocalesettingsitem-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocaleId { get; set; }
            /// <summary>
            /// BotAliasLocaleSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botaliaslocalesettingsitem.html#cfn-lex-bot-botaliaslocalesettingsitem-botaliaslocalesetting
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BotAliasLocaleSettings
            /// </summary>
            public Humidifier.Lex.BotTypes.BotAliasLocaleSettings BotAliasLocaleSetting { get; set; }
        }

        public class BotLocale : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveLocaleId
        {
            /// <summary>
            /// NluConfidenceThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-nluconfidencethreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic NluConfidenceThreshold { get; set; }
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocaleId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// CustomVocabulary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-customvocabulary
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomVocabulary
            /// </summary>
            public Humidifier.Lex.BotTypes.CustomVocabulary CustomVocabulary { get; set; }
            /// <summary>
            /// SlotTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-slottypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotType
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SlotType> SlotTypes { get; set; }
            /// <summary>
            /// Intents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-intents
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Intent
            /// </summary>
            public List<Humidifier.Lex.BotTypes.Intent> Intents { get; set; }
            /// <summary>
            /// VoiceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-botlocale.html#cfn-lex-bot-botlocale-voicesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VoiceSettings
            /// </summary>
            public Humidifier.Lex.BotTypes.VoiceSettings VoiceSettings { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-button.html#cfn-lex-bot-button-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
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
            public dynamic CloudWatchLogGroupArn { get; set; }
            /// <summary>
            /// LogPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-cloudwatchloggrouplogdestination.html#cfn-lex-bot-cloudwatchloggrouplogdestination-logprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogPrefix { get; set; }
        }

        public class CodeHookSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LambdaCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-codehookspecification.html#cfn-lex-bot-codehookspecification-lambdacodehook
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LambdaCodeHook
            /// </summary>
            public Humidifier.Lex.BotTypes.LambdaCodeHook LambdaCodeHook { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExpressionString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-condition.html#cfn-lex-bot-condition-expressionstring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExpressionString { get; set; }
        }

        public class ConditionalBranch : Humidifier.Base.BaseSubResource, IHaveName, IHaveLexBotTypesDialogStateNextStep, IHaveLexBotTypesResponseSpecificationResponse
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalbranch.html#cfn-lex-bot-conditionalbranch-condition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Condition
            /// </summary>
            public Humidifier.Lex.BotTypes.Condition Condition { get; set; }
            /// <summary>
            /// Response
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalbranch.html#cfn-lex-bot-conditionalbranch-response
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification Response { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalbranch.html#cfn-lex-bot-conditionalbranch-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// NextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalbranch.html#cfn-lex-bot-conditionalbranch-nextstep
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState NextStep { get; set; }
        }

        public class ConditionalSpecification : Humidifier.Base.BaseSubResource, IHaveIsActive
        {
            /// <summary>
            /// DefaultBranch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalspecification.html#cfn-lex-bot-conditionalspecification-defaultbranch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultConditionalBranch
            /// </summary>
            public Humidifier.Lex.BotTypes.DefaultConditionalBranch DefaultBranch { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalspecification.html#cfn-lex-bot-conditionalspecification-isactive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsActive { get; set; }
            /// <summary>
            /// ConditionalBranches
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conditionalspecification.html#cfn-lex-bot-conditionalspecification-conditionalbranches
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConditionalBranch
            /// </summary>
            public List<Humidifier.Lex.BotTypes.ConditionalBranch> ConditionalBranches { get; set; }
        }

        public class ConversationLogSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TextLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conversationlogsettings.html#cfn-lex-bot-conversationlogsettings-textlogsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextLogSetting
            /// </summary>
            public List<Humidifier.Lex.BotTypes.TextLogSetting> TextLogSettings { get; set; }
            /// <summary>
            /// AudioLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-conversationlogsettings.html#cfn-lex-bot-conversationlogsettings-audiologsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioLogSetting
            /// </summary>
            public List<Humidifier.Lex.BotTypes.AudioLogSetting> AudioLogSettings { get; set; }
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
            public dynamic Value { get; set; }
        }

        public class CustomVocabulary : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomVocabularyItems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-customvocabulary.html#cfn-lex-bot-customvocabulary-customvocabularyitems
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomVocabularyItem
            /// </summary>
            public List<Humidifier.Lex.BotTypes.CustomVocabularyItem> CustomVocabularyItems { get; set; }
        }

        public class CustomVocabularyItem : Humidifier.Base.BaseSubResource, IHaveWeight, IHaveDisplayAs
        {
            /// <summary>
            /// DisplayAs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-customvocabularyitem.html#cfn-lex-bot-customvocabularyitem-displayas
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DisplayAs { get; set; }
            /// <summary>
            /// Phrase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-customvocabularyitem.html#cfn-lex-bot-customvocabularyitem-phrase
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Phrase { get; set; }
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-customvocabularyitem.html#cfn-lex-bot-customvocabularyitem-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Weight { get; set; }
        }

        public class DTMFSpecification : Humidifier.Base.BaseSubResource, IHaveMaxLength, IHaveEndTimeoutMs
        {
            /// <summary>
            /// DeletionCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dtmfspecification.html#cfn-lex-bot-dtmfspecification-deletioncharacter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeletionCharacter { get; set; }
            /// <summary>
            /// EndTimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dtmfspecification.html#cfn-lex-bot-dtmfspecification-endtimeoutms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EndTimeoutMs { get; set; }
            /// <summary>
            /// EndCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dtmfspecification.html#cfn-lex-bot-dtmfspecification-endcharacter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndCharacter { get; set; }
            /// <summary>
            /// MaxLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dtmfspecification.html#cfn-lex-bot-dtmfspecification-maxlength
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxLength { get; set; }
        }

        public class DataPrivacy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChildDirected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dataprivacy.html#cfn-lex-bot-dataprivacy-childdirected
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ChildDirected { get; set; }
        }

        public class DefaultConditionalBranch : Humidifier.Base.BaseSubResource, IHaveLexBotTypesDialogStateNextStep, IHaveLexBotTypesResponseSpecificationResponse
        {
            /// <summary>
            /// Response
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-defaultconditionalbranch.html#cfn-lex-bot-defaultconditionalbranch-response
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification Response { get; set; }
            /// <summary>
            /// NextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-defaultconditionalbranch.html#cfn-lex-bot-defaultconditionalbranch-nextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState NextStep { get; set; }
        }

        public class DialogAction : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogaction.html#cfn-lex-bot-dialogaction-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// SlotToElicit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogaction.html#cfn-lex-bot-dialogaction-slottoelicit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlotToElicit { get; set; }
            /// <summary>
            /// SuppressNextMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogaction.html#cfn-lex-bot-dialogaction-suppressnextmessage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SuppressNextMessage { get; set; }
        }

        public class DialogCodeHookInvocationSetting : Humidifier.Base.BaseSubResource, IHaveIsActive, IHaveEnableCodeHookInvocation, IHaveInvocationLabel
        {
            /// <summary>
            /// EnableCodeHookInvocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehookinvocationsetting.html#cfn-lex-bot-dialogcodehookinvocationsetting-enablecodehookinvocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableCodeHookInvocation { get; set; }
            /// <summary>
            /// InvocationLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehookinvocationsetting.html#cfn-lex-bot-dialogcodehookinvocationsetting-invocationlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationLabel { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehookinvocationsetting.html#cfn-lex-bot-dialogcodehookinvocationsetting-isactive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsActive { get; set; }
            /// <summary>
            /// PostCodeHookSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehookinvocationsetting.html#cfn-lex-bot-dialogcodehookinvocationsetting-postcodehookspecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PostDialogCodeHookInvocationSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.PostDialogCodeHookInvocationSpecification PostCodeHookSpecification { get; set; }
        }

        public class DialogCodeHookSetting : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogcodehooksetting.html#cfn-lex-bot-dialogcodehooksetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class DialogState : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DialogAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogstate.html#cfn-lex-bot-dialogstate-dialogaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogAction
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogAction DialogAction { get; set; }
            /// <summary>
            /// SessionAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogstate.html#cfn-lex-bot-dialogstate-sessionattributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SessionAttribute
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SessionAttribute> SessionAttributes { get; set; }
            /// <summary>
            /// Intent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-dialogstate.html#cfn-lex-bot-dialogstate-intent
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntentOverride
            /// </summary>
            public Humidifier.Lex.BotTypes.IntentOverride Intent { get; set; }
        }

        public class ElicitationCodeHookInvocationSetting : Humidifier.Base.BaseSubResource, IHaveEnableCodeHookInvocation, IHaveInvocationLabel
        {
            /// <summary>
            /// EnableCodeHookInvocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-elicitationcodehookinvocationsetting.html#cfn-lex-bot-elicitationcodehookinvocationsetting-enablecodehookinvocation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableCodeHookInvocation { get; set; }
            /// <summary>
            /// InvocationLabel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-elicitationcodehookinvocationsetting.html#cfn-lex-bot-elicitationcodehookinvocationsetting-invocationlabel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationLabel { get; set; }
        }

        public class ExternalSourceSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GrammarSlotTypeSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-externalsourcesetting.html#cfn-lex-bot-externalsourcesetting-grammarslottypesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrammarSlotTypeSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.GrammarSlotTypeSetting GrammarSlotTypeSetting { get; set; }
        }

        public class FulfillmentCodeHookSetting : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveIsActive
        {
            /// <summary>
            /// PostFulfillmentStatusSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentcodehooksetting.html#cfn-lex-bot-fulfillmentcodehooksetting-postfulfillmentstatusspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PostFulfillmentStatusSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.PostFulfillmentStatusSpecification PostFulfillmentStatusSpecification { get; set; }
            /// <summary>
            /// FulfillmentUpdatesSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentcodehooksetting.html#cfn-lex-bot-fulfillmentcodehooksetting-fulfillmentupdatesspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FulfillmentUpdatesSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.FulfillmentUpdatesSpecification FulfillmentUpdatesSpecification { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentcodehooksetting.html#cfn-lex-bot-fulfillmentcodehooksetting-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsActive { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentcodehooksetting.html#cfn-lex-bot-fulfillmentcodehooksetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class FulfillmentStartResponseSpecification : Humidifier.Base.BaseSubResource, IHaveAllowInterrupt
        {
            /// <summary>
            /// DelayInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentstartresponsespecification.html#cfn-lex-bot-fulfillmentstartresponsespecification-delayinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DelayInSeconds { get; set; }
            /// <summary>
            /// MessageGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentstartresponsespecification.html#cfn-lex-bot-fulfillmentstartresponsespecification-messagegroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public List<Humidifier.Lex.BotTypes.MessageGroup> MessageGroups { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentstartresponsespecification.html#cfn-lex-bot-fulfillmentstartresponsespecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowInterrupt { get; set; }
        }

        public class FulfillmentUpdateResponseSpecification : Humidifier.Base.BaseSubResource, IHaveAllowInterrupt, IHaveFrequencyInSeconds
        {
            /// <summary>
            /// MessageGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdateresponsespecification.html#cfn-lex-bot-fulfillmentupdateresponsespecification-messagegroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public List<Humidifier.Lex.BotTypes.MessageGroup> MessageGroups { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdateresponsespecification.html#cfn-lex-bot-fulfillmentupdateresponsespecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowInterrupt { get; set; }
            /// <summary>
            /// FrequencyInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdateresponsespecification.html#cfn-lex-bot-fulfillmentupdateresponsespecification-frequencyinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FrequencyInSeconds { get; set; }
        }

        public class FulfillmentUpdatesSpecification : Humidifier.Base.BaseSubResource, IHaveTimeoutInSeconds, IHaveActive
        {
            /// <summary>
            /// UpdateResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdatesspecification.html#cfn-lex-bot-fulfillmentupdatesspecification-updateresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FulfillmentUpdateResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.FulfillmentUpdateResponseSpecification UpdateResponse { get; set; }
            /// <summary>
            /// Active
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdatesspecification.html#cfn-lex-bot-fulfillmentupdatesspecification-active
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Active { get; set; }
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdatesspecification.html#cfn-lex-bot-fulfillmentupdatesspecification-timeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutInSeconds { get; set; }
            /// <summary>
            /// StartResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-fulfillmentupdatesspecification.html#cfn-lex-bot-fulfillmentupdatesspecification-startresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FulfillmentStartResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.FulfillmentStartResponseSpecification StartResponse { get; set; }
        }

        public class GrammarSlotTypeSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-grammarslottypesetting.html#cfn-lex-bot-grammarslottypesetting-source
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GrammarSlotTypeSource
            /// </summary>
            public Humidifier.Lex.BotTypes.GrammarSlotTypeSource Source { get; set; }
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
            public dynamic KmsKeyArn { get; set; }
            /// <summary>
            /// S3BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-grammarslottypesource.html#cfn-lex-bot-grammarslottypesource-s3bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketName { get; set; }
            /// <summary>
            /// S3ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-grammarslottypesource.html#cfn-lex-bot-grammarslottypesource-s3objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3ObjectKey { get; set; }
        }

        public class ImageResponseCard : Humidifier.Base.BaseSubResource, IHaveTitle, IHaveImageUrl, IHaveSubtitle
        {
            /// <summary>
            /// Subtitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-imageresponsecard.html#cfn-lex-bot-imageresponsecard-subtitle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Subtitle { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-imageresponsecard.html#cfn-lex-bot-imageresponsecard-title
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title { get; set; }
            /// <summary>
            /// ImageUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-imageresponsecard.html#cfn-lex-bot-imageresponsecard-imageurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageUrl { get; set; }
            /// <summary>
            /// Buttons
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-imageresponsecard.html#cfn-lex-bot-imageresponsecard-buttons
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Button
            /// </summary>
            public List<Humidifier.Lex.BotTypes.Button> Buttons { get; set; }
        }

        public class InitialResponseSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesDialogStateNextStep, IHaveLexBotTypesDialogCodeHookInvocationSettingCodeHook, IHaveLexBotTypesConditionalSpecificationConditional
        {
            /// <summary>
            /// CodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-initialresponsesetting.html#cfn-lex-bot-initialresponsesetting-codehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogCodeHookInvocationSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogCodeHookInvocationSetting CodeHook { get; set; }
            /// <summary>
            /// InitialResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-initialresponsesetting.html#cfn-lex-bot-initialresponsesetting-initialresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification InitialResponse { get; set; }
            /// <summary>
            /// Conditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-initialresponsesetting.html#cfn-lex-bot-initialresponsesetting-conditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification Conditional { get; set; }
            /// <summary>
            /// NextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-initialresponsesetting.html#cfn-lex-bot-initialresponsesetting-nextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState NextStep { get; set; }
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
            public dynamic Name { get; set; }
        }

        public class Intent : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ParentIntentSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-parentintentsignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParentIntentSignature { get; set; }
            /// <summary>
            /// InitialResponseSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-initialresponsesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InitialResponseSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.InitialResponseSetting InitialResponseSetting { get; set; }
            /// <summary>
            /// FulfillmentCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-fulfillmentcodehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FulfillmentCodeHookSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.FulfillmentCodeHookSetting FulfillmentCodeHook { get; set; }
            /// <summary>
            /// IntentConfirmationSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-intentconfirmationsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntentConfirmationSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.IntentConfirmationSetting IntentConfirmationSetting { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// Slots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-slots
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Slot
            /// </summary>
            public List<Humidifier.Lex.BotTypes.Slot> Slots { get; set; }
            /// <summary>
            /// DialogCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-dialogcodehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogCodeHookSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogCodeHookSetting DialogCodeHook { get; set; }
            /// <summary>
            /// InputContexts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-inputcontexts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InputContext
            /// </summary>
            public List<Humidifier.Lex.BotTypes.InputContext> InputContexts { get; set; }
            /// <summary>
            /// KendraConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-kendraconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KendraConfiguration
            /// </summary>
            public Humidifier.Lex.BotTypes.KendraConfiguration KendraConfiguration { get; set; }
            /// <summary>
            /// IntentClosingSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-intentclosingsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IntentClosingSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.IntentClosingSetting IntentClosingSetting { get; set; }
            /// <summary>
            /// OutputContexts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-outputcontexts
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputContext
            /// </summary>
            public List<Humidifier.Lex.BotTypes.OutputContext> OutputContexts { get; set; }
            /// <summary>
            /// SlotPriorities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-slotpriorities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotPriority
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SlotPriority> SlotPriorities { get; set; }
            /// <summary>
            /// SampleUtterances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intent.html#cfn-lex-bot-intent-sampleutterances
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleUtterance
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SampleUtterance> SampleUtterances { get; set; }
        }

        public class IntentClosingSetting : Humidifier.Base.BaseSubResource, IHaveIsActive, IHaveLexBotTypesDialogStateNextStep, IHaveLexBotTypesConditionalSpecificationConditional
        {
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentclosingsetting.html#cfn-lex-bot-intentclosingsetting-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsActive { get; set; }
            /// <summary>
            /// ClosingResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentclosingsetting.html#cfn-lex-bot-intentclosingsetting-closingresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification ClosingResponse { get; set; }
            /// <summary>
            /// Conditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentclosingsetting.html#cfn-lex-bot-intentclosingsetting-conditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification Conditional { get; set; }
            /// <summary>
            /// NextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentclosingsetting.html#cfn-lex-bot-intentclosingsetting-nextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState NextStep { get; set; }
        }

        public class IntentConfirmationSetting : Humidifier.Base.BaseSubResource, IHaveIsActive, IHaveLexBotTypesConditionalSpecificationFailureConditional, IHaveLexBotTypesResponseSpecificationFailureResponse, IHaveLexBotTypesDialogStateFailureNextStep, IHaveLexBotTypesDialogCodeHookInvocationSettingCodeHook, IHaveLexBotTypesPromptSpecificationPromptSpecification, IHaveLexBotTypesElicitationCodeHookInvocationSettingElicitationCodeHook
        {
            /// <summary>
            /// PromptSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-promptspecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PromptSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.PromptSpecification PromptSpecification { get; set; }
            /// <summary>
            /// ConfirmationResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-confirmationresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification ConfirmationResponse { get; set; }
            /// <summary>
            /// DeclinationConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-declinationconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification DeclinationConditional { get; set; }
            /// <summary>
            /// FailureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-failureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification FailureConditional { get; set; }
            /// <summary>
            /// ConfirmationConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-confirmationconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification ConfirmationConditional { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsActive { get; set; }
            /// <summary>
            /// FailureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-failureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification FailureResponse { get; set; }
            /// <summary>
            /// CodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-codehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogCodeHookInvocationSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogCodeHookInvocationSetting CodeHook { get; set; }
            /// <summary>
            /// DeclinationNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-declinationnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState DeclinationNextStep { get; set; }
            /// <summary>
            /// ElicitationCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-elicitationcodehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ElicitationCodeHookInvocationSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.ElicitationCodeHookInvocationSetting ElicitationCodeHook { get; set; }
            /// <summary>
            /// ConfirmationNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-confirmationnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState ConfirmationNextStep { get; set; }
            /// <summary>
            /// FailureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-failurenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState FailureNextStep { get; set; }
            /// <summary>
            /// DeclinationResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentconfirmationsetting.html#cfn-lex-bot-intentconfirmationsetting-declinationresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification DeclinationResponse { get; set; }
        }

        public class IntentOverride : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Slots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentoverride.html#cfn-lex-bot-intentoverride-slots
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotValueOverrideMap
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SlotValueOverrideMap> Slots { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-intentoverride.html#cfn-lex-bot-intentoverride-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class KendraConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QueryFilterString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-kendraconfiguration.html#cfn-lex-bot-kendraconfiguration-queryfilterstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryFilterString { get; set; }
            /// <summary>
            /// QueryFilterStringEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-kendraconfiguration.html#cfn-lex-bot-kendraconfiguration-queryfilterstringenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic QueryFilterStringEnabled { get; set; }
            /// <summary>
            /// KendraIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-kendraconfiguration.html#cfn-lex-bot-kendraconfiguration-kendraindex
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KendraIndex { get; set; }
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
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// CodeHookInterfaceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-lambdacodehook.html#cfn-lex-bot-lambdacodehook-codehookinterfaceversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodeHookInterfaceVersion { get; set; }
        }

        public class Message : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomPayload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-message.html#cfn-lex-bot-message-custompayload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomPayload
            /// </summary>
            public Humidifier.Lex.BotTypes.CustomPayload CustomPayload { get; set; }
            /// <summary>
            /// ImageResponseCard
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-message.html#cfn-lex-bot-message-imageresponsecard
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageResponseCard
            /// </summary>
            public Humidifier.Lex.BotTypes.ImageResponseCard ImageResponseCard { get; set; }
            /// <summary>
            /// PlainTextMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-message.html#cfn-lex-bot-message-plaintextmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PlainTextMessage
            /// </summary>
            public Humidifier.Lex.BotTypes.PlainTextMessage PlainTextMessage { get; set; }
            /// <summary>
            /// SSMLMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-message.html#cfn-lex-bot-message-ssmlmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SSMLMessage
            /// </summary>
            public Humidifier.Lex.BotTypes.SSMLMessage SSMLMessage { get; set; }
        }

        public class MessageGroup : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-messagegroup.html#cfn-lex-bot-messagegroup-message
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Humidifier.Lex.BotTypes.Message Message { get; set; }
            /// <summary>
            /// Variations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-messagegroup.html#cfn-lex-bot-messagegroup-variations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Message
            /// </summary>
            public List<Humidifier.Lex.BotTypes.Message> Variations { get; set; }
        }

        public class MultipleValuesSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AllowMultipleValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-multiplevaluessetting.html#cfn-lex-bot-multiplevaluessetting-allowmultiplevalues
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowMultipleValues { get; set; }
        }

        public class ObfuscationSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ObfuscationSettingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-obfuscationsetting.html#cfn-lex-bot-obfuscationsetting-obfuscationsettingtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObfuscationSettingType { get; set; }
        }

        public class OutputContext : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// TurnsToLive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-outputcontext.html#cfn-lex-bot-outputcontext-turnstolive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TurnsToLive { get; set; }
            /// <summary>
            /// TimeToLiveInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-outputcontext.html#cfn-lex-bot-outputcontext-timetoliveinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeToLiveInSeconds { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-outputcontext.html#cfn-lex-bot-outputcontext-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic Value { get; set; }
        }

        public class PostDialogCodeHookInvocationSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesConditionalSpecificationFailureConditional, IHaveLexBotTypesResponseSpecificationFailureResponse, IHaveLexBotTypesDialogStateFailureNextStep, IHaveLexBotTypesResponseSpecificationSuccessResponse, IHaveLexBotTypesDialogStateTimeoutNextStep, IHaveLexBotTypesConditionalSpecificationSuccessConditional, IHaveLexBotTypesResponseSpecificationTimeoutResponse, IHaveLexBotTypesDialogStateSuccessNextStep, IHaveLexBotTypesConditionalSpecificationTimeoutConditional
        {
            /// <summary>
            /// SuccessResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-successresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification SuccessResponse { get; set; }
            /// <summary>
            /// FailureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-failureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification FailureConditional { get; set; }
            /// <summary>
            /// TimeoutNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-timeoutnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState TimeoutNextStep { get; set; }
            /// <summary>
            /// SuccessConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-successconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification SuccessConditional { get; set; }
            /// <summary>
            /// TimeoutResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-timeoutresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification TimeoutResponse { get; set; }
            /// <summary>
            /// SuccessNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-successnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState SuccessNextStep { get; set; }
            /// <summary>
            /// FailureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-failureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification FailureResponse { get; set; }
            /// <summary>
            /// FailureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-failurenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState FailureNextStep { get; set; }
            /// <summary>
            /// TimeoutConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postdialogcodehookinvocationspecification.html#cfn-lex-bot-postdialogcodehookinvocationspecification-timeoutconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification TimeoutConditional { get; set; }
        }

        public class PostFulfillmentStatusSpecification : Humidifier.Base.BaseSubResource, IHaveLexBotTypesConditionalSpecificationFailureConditional, IHaveLexBotTypesResponseSpecificationFailureResponse, IHaveLexBotTypesDialogStateFailureNextStep, IHaveLexBotTypesResponseSpecificationSuccessResponse, IHaveLexBotTypesDialogStateTimeoutNextStep, IHaveLexBotTypesConditionalSpecificationSuccessConditional, IHaveLexBotTypesResponseSpecificationTimeoutResponse, IHaveLexBotTypesDialogStateSuccessNextStep, IHaveLexBotTypesConditionalSpecificationTimeoutConditional
        {
            /// <summary>
            /// SuccessResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-successresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification SuccessResponse { get; set; }
            /// <summary>
            /// FailureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-failureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification FailureConditional { get; set; }
            /// <summary>
            /// TimeoutNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-timeoutnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState TimeoutNextStep { get; set; }
            /// <summary>
            /// SuccessConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-successconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification SuccessConditional { get; set; }
            /// <summary>
            /// TimeoutResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-timeoutresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification TimeoutResponse { get; set; }
            /// <summary>
            /// SuccessNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-successnextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState SuccessNextStep { get; set; }
            /// <summary>
            /// FailureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-failureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification FailureResponse { get; set; }
            /// <summary>
            /// FailureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-failurenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState FailureNextStep { get; set; }
            /// <summary>
            /// TimeoutConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-postfulfillmentstatusspecification.html#cfn-lex-bot-postfulfillmentstatusspecification-timeoutconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification TimeoutConditional { get; set; }
        }

        public class PromptAttemptSpecification : Humidifier.Base.BaseSubResource, IHaveAllowInterrupt
        {
            /// <summary>
            /// TextInputSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptattemptspecification.html#cfn-lex-bot-promptattemptspecification-textinputspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TextInputSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.TextInputSpecification TextInputSpecification { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptattemptspecification.html#cfn-lex-bot-promptattemptspecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowInterrupt { get; set; }
            /// <summary>
            /// AllowedInputTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptattemptspecification.html#cfn-lex-bot-promptattemptspecification-allowedinputtypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AllowedInputTypes
            /// </summary>
            public Humidifier.Lex.BotTypes.AllowedInputTypes AllowedInputTypes { get; set; }
            /// <summary>
            /// AudioAndDTMFInputSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptattemptspecification.html#cfn-lex-bot-promptattemptspecification-audioanddtmfinputspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioAndDTMFInputSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.AudioAndDTMFInputSpecification AudioAndDTMFInputSpecification { get; set; }
        }

        public class PromptSpecification : Humidifier.Base.BaseSubResource, IHaveMaxRetries, IHaveAllowInterrupt
        {
            /// <summary>
            /// MaxRetries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-maxretries
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxRetries { get; set; }
            /// <summary>
            /// MessageGroupsList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-messagegroupslist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public List<Humidifier.Lex.BotTypes.MessageGroup> MessageGroupsList { get; set; }
            /// <summary>
            /// PromptAttemptsSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-promptattemptsspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: PromptAttemptSpecification
            /// </summary>
            public Dictionary<string, Humidifier.Lex.BotTypes.PromptAttemptSpecification> PromptAttemptsSpecification { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowInterrupt { get; set; }
            /// <summary>
            /// MessageSelectionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-promptspecification.html#cfn-lex-bot-promptspecification-messageselectionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageSelectionStrategy { get; set; }
        }

        public class Replication : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReplicaRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-replication.html#cfn-lex-bot-replication-replicaregions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ReplicaRegions { get; set; }
        }

        public class ResponseSpecification : Humidifier.Base.BaseSubResource, IHaveAllowInterrupt
        {
            /// <summary>
            /// MessageGroupsList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-responsespecification.html#cfn-lex-bot-responsespecification-messagegroupslist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public List<Humidifier.Lex.BotTypes.MessageGroup> MessageGroupsList { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-responsespecification.html#cfn-lex-bot-responsespecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowInterrupt { get; set; }
        }

        public class S3BucketLogDestination : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveS3BucketArn, IHaveLogPrefix
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3bucketlogdestination.html#cfn-lex-bot-s3bucketlogdestination-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
            /// <summary>
            /// LogPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3bucketlogdestination.html#cfn-lex-bot-s3bucketlogdestination-logprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogPrefix { get; set; }
            /// <summary>
            /// S3BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3bucketlogdestination.html#cfn-lex-bot-s3bucketlogdestination-s3bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketArn { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveS3Bucket, IHaveS3ObjectVersion, IHaveS3ObjectKey
        {
            /// <summary>
            /// S3ObjectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3location.html#cfn-lex-bot-s3location-s3objectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3ObjectVersion { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3location.html#cfn-lex-bot-s3location-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Bucket { get; set; }
            /// <summary>
            /// S3ObjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-s3location.html#cfn-lex-bot-s3location-s3objectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3ObjectKey { get; set; }
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
            public dynamic Value { get; set; }
        }

        public class SampleUtterance : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Utterance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sampleutterance.html#cfn-lex-bot-sampleutterance-utterance
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Utterance { get; set; }
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
            public dynamic Value { get; set; }
        }

        public class SentimentAnalysisSettings : Humidifier.Base.BaseSubResource, IHaveDetectSentiment
        {
            /// <summary>
            /// DetectSentiment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sentimentanalysissettings.html#cfn-lex-bot-sentimentanalysissettings-detectsentiment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DetectSentiment { get; set; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-sessionattribute.html#cfn-lex-bot-sessionattribute-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class Slot : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// SlotTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-slottypename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlotTypeName { get; set; }
            /// <summary>
            /// ValueElicitationSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-valueelicitationsetting
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SlotValueElicitationSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.SlotValueElicitationSetting ValueElicitationSetting { get; set; }
            /// <summary>
            /// ObfuscationSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-obfuscationsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ObfuscationSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.ObfuscationSetting ObfuscationSetting { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// MultipleValuesSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slot.html#cfn-lex-bot-slot-multiplevaluessetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultipleValuesSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.MultipleValuesSetting MultipleValuesSetting { get; set; }
        }

        public class SlotCaptureSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesConditionalSpecificationFailureConditional, IHaveLexBotTypesResponseSpecificationFailureResponse, IHaveLexBotTypesDialogStateFailureNextStep, IHaveLexBotTypesDialogCodeHookInvocationSettingCodeHook, IHaveLexBotTypesElicitationCodeHookInvocationSettingElicitationCodeHook
        {
            /// <summary>
            /// CaptureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-captureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification CaptureConditional { get; set; }
            /// <summary>
            /// FailureConditional
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-failureconditional
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConditionalSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ConditionalSpecification FailureConditional { get; set; }
            /// <summary>
            /// CaptureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-captureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification CaptureResponse { get; set; }
            /// <summary>
            /// CaptureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-capturenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState CaptureNextStep { get; set; }
            /// <summary>
            /// FailureResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-failureresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification FailureResponse { get; set; }
            /// <summary>
            /// CodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-codehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogCodeHookInvocationSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogCodeHookInvocationSetting CodeHook { get; set; }
            /// <summary>
            /// FailureNextStep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-failurenextstep
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DialogState
            /// </summary>
            public Humidifier.Lex.BotTypes.DialogState FailureNextStep { get; set; }
            /// <summary>
            /// ElicitationCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotcapturesetting.html#cfn-lex-bot-slotcapturesetting-elicitationcodehook
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ElicitationCodeHookInvocationSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.ElicitationCodeHookInvocationSetting ElicitationCodeHook { get; set; }
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
            public dynamic DefaultValue { get; set; }
        }

        public class SlotDefaultValueSpecification : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DefaultValueList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotdefaultvaluespecification.html#cfn-lex-bot-slotdefaultvaluespecification-defaultvaluelist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotDefaultValue
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SlotDefaultValue> DefaultValueList { get; set; }
        }

        public class SlotPriority : Humidifier.Base.BaseSubResource, IHavePriority, IHaveSlotName
        {
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotpriority.html#cfn-lex-bot-slotpriority-priority
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// SlotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotpriority.html#cfn-lex-bot-slotpriority-slotname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlotName { get; set; }
        }

        public class SlotType : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription
        {
            /// <summary>
            /// SlotTypeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-slottypevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotTypeValue
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SlotTypeValue> SlotTypeValues { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// ParentSlotTypeSignature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-parentslottypesignature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParentSlotTypeSignature { get; set; }
            /// <summary>
            /// ValueSelectionSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-valueselectionsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotValueSelectionSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.SlotValueSelectionSetting ValueSelectionSetting { get; set; }
            /// <summary>
            /// ExternalSourceSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-externalsourcesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExternalSourceSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.ExternalSourceSetting ExternalSourceSetting { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottype.html#cfn-lex-bot-slottype-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SlotTypeValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Synonyms
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottypevalue.html#cfn-lex-bot-slottypevalue-synonyms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleValue
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SampleValue> Synonyms { get; set; }
            /// <summary>
            /// SampleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slottypevalue.html#cfn-lex-bot-slottypevalue-samplevalue
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SampleValue
            /// </summary>
            public Humidifier.Lex.BotTypes.SampleValue SampleValue { get; set; }
        }

        public class SlotValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InterpretedValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalue.html#cfn-lex-bot-slotvalue-interpretedvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InterpretedValue { get; set; }
        }

        public class SlotValueElicitationSetting : Humidifier.Base.BaseSubResource, IHaveLexBotTypesPromptSpecificationPromptSpecification
        {
            /// <summary>
            /// PromptSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-promptspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PromptSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.PromptSpecification PromptSpecification { get; set; }
            /// <summary>
            /// WaitAndContinueSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-waitandcontinuespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WaitAndContinueSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.WaitAndContinueSpecification WaitAndContinueSpecification { get; set; }
            /// <summary>
            /// SlotConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-slotconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlotConstraint { get; set; }
            /// <summary>
            /// SlotCaptureSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-slotcapturesetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotCaptureSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.SlotCaptureSetting SlotCaptureSetting { get; set; }
            /// <summary>
            /// SampleUtterances
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-sampleutterances
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SampleUtterance
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SampleUtterance> SampleUtterances { get; set; }
            /// <summary>
            /// DefaultValueSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueelicitationsetting.html#cfn-lex-bot-slotvalueelicitationsetting-defaultvaluespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotDefaultValueSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.SlotDefaultValueSpecification DefaultValueSpecification { get; set; }
        }

        public class SlotValueOverride : Humidifier.Base.BaseSubResource, IHaveShape
        {
            /// <summary>
            /// Shape
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverride.html#cfn-lex-bot-slotvalueoverride-shape
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Shape { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverride.html#cfn-lex-bot-slotvalueoverride-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotValue
            /// </summary>
            public Humidifier.Lex.BotTypes.SlotValue Value { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverride.html#cfn-lex-bot-slotvalueoverride-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlotValueOverride
            /// </summary>
            public List<Humidifier.Lex.BotTypes.SlotValueOverride> Values { get; set; }
        }

        public class SlotValueOverrideMap : Humidifier.Base.BaseSubResource, IHaveSlotName
        {
            /// <summary>
            /// SlotName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverridemap.html#cfn-lex-bot-slotvalueoverridemap-slotname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlotName { get; set; }
            /// <summary>
            /// SlotValueOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueoverridemap.html#cfn-lex-bot-slotvalueoverridemap-slotvalueoverride
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotValueOverride
            /// </summary>
            public Humidifier.Lex.BotTypes.SlotValueOverride SlotValueOverride { get; set; }
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
            public dynamic Pattern { get; set; }
        }

        public class SlotValueSelectionSetting : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdvancedRecognitionSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueselectionsetting.html#cfn-lex-bot-slotvalueselectionsetting-advancedrecognitionsetting
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AdvancedRecognitionSetting
            /// </summary>
            public Humidifier.Lex.BotTypes.AdvancedRecognitionSetting AdvancedRecognitionSetting { get; set; }
            /// <summary>
            /// RegexFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueselectionsetting.html#cfn-lex-bot-slotvalueselectionsetting-regexfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlotValueRegexFilter
            /// </summary>
            public Humidifier.Lex.BotTypes.SlotValueRegexFilter RegexFilter { get; set; }
            /// <summary>
            /// ResolutionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-slotvalueselectionsetting.html#cfn-lex-bot-slotvalueselectionsetting-resolutionstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResolutionStrategy { get; set; }
        }

        public class StillWaitingResponseSpecification : Humidifier.Base.BaseSubResource, IHaveTimeoutInSeconds, IHaveAllowInterrupt, IHaveFrequencyInSeconds
        {
            /// <summary>
            /// MessageGroupsList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-stillwaitingresponsespecification.html#cfn-lex-bot-stillwaitingresponsespecification-messagegroupslist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MessageGroup
            /// </summary>
            public List<Humidifier.Lex.BotTypes.MessageGroup> MessageGroupsList { get; set; }
            /// <summary>
            /// TimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-stillwaitingresponsespecification.html#cfn-lex-bot-stillwaitingresponsespecification-timeoutinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutInSeconds { get; set; }
            /// <summary>
            /// AllowInterrupt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-stillwaitingresponsespecification.html#cfn-lex-bot-stillwaitingresponsespecification-allowinterrupt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AllowInterrupt { get; set; }
            /// <summary>
            /// FrequencyInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-stillwaitingresponsespecification.html#cfn-lex-bot-stillwaitingresponsespecification-frequencyinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FrequencyInSeconds { get; set; }
        }

        public class TestBotAliasSettings : Humidifier.Base.BaseSubResource, IHaveDescription
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-testbotaliassettings.html#cfn-lex-bot-testbotaliassettings-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// BotAliasLocaleSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-testbotaliassettings.html#cfn-lex-bot-testbotaliassettings-botaliaslocalesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BotAliasLocaleSettingsItem
            /// </summary>
            public List<Humidifier.Lex.BotTypes.BotAliasLocaleSettingsItem> BotAliasLocaleSettings { get; set; }
            /// <summary>
            /// ConversationLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-testbotaliassettings.html#cfn-lex-bot-testbotaliassettings-conversationlogsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConversationLogSettings
            /// </summary>
            public Humidifier.Lex.BotTypes.ConversationLogSettings ConversationLogSettings { get; set; }
            /// <summary>
            /// SentimentAnalysisSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-testbotaliassettings.html#cfn-lex-bot-testbotaliassettings-sentimentanalysissettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SentimentAnalysisSettings
            /// </summary>
            public Humidifier.Lex.BotTypes.SentimentAnalysisSettings SentimentAnalysisSettings { get; set; }
        }

        public class TextInputSpecification : Humidifier.Base.BaseSubResource, IHaveStartTimeoutMs
        {
            /// <summary>
            /// StartTimeoutMs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-textinputspecification.html#cfn-lex-bot-textinputspecification-starttimeoutms
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StartTimeoutMs { get; set; }
        }

        public class TextLogDestination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudWatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-textlogdestination.html#cfn-lex-bot-textlogdestination-cloudwatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchLogGroupLogDestination
            /// </summary>
            public Humidifier.Lex.BotTypes.CloudWatchLogGroupLogDestination CloudWatch { get; set; }
        }

        public class TextLogSetting : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-textlogsetting.html#cfn-lex-bot-textlogsetting-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextLogDestination
            /// </summary>
            public Humidifier.Lex.BotTypes.TextLogDestination Destination { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-textlogsetting.html#cfn-lex-bot-textlogsetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class VoiceSettings : Humidifier.Base.BaseSubResource, IHaveEngine
        {
            /// <summary>
            /// VoiceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-voicesettings.html#cfn-lex-bot-voicesettings-voiceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VoiceId { get; set; }
            /// <summary>
            /// Engine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-voicesettings.html#cfn-lex-bot-voicesettings-engine
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Engine { get; set; }
        }

        public class WaitAndContinueSpecification : Humidifier.Base.BaseSubResource, IHaveIsActive
        {
            /// <summary>
            /// WaitingResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-waitandcontinuespecification.html#cfn-lex-bot-waitandcontinuespecification-waitingresponse
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification WaitingResponse { get; set; }
            /// <summary>
            /// StillWaitingResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-waitandcontinuespecification.html#cfn-lex-bot-waitandcontinuespecification-stillwaitingresponse
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StillWaitingResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.StillWaitingResponseSpecification StillWaitingResponse { get; set; }
            /// <summary>
            /// IsActive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-waitandcontinuespecification.html#cfn-lex-bot-waitandcontinuespecification-isactive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsActive { get; set; }
            /// <summary>
            /// ContinueResponse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-bot-waitandcontinuespecification.html#cfn-lex-bot-waitandcontinuespecification-continueresponse
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ResponseSpecification
            /// </summary>
            public Humidifier.Lex.BotTypes.ResponseSpecification ContinueResponse { get; set; }
        }
    }
}