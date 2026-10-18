namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using AppInstanceBotTypes;

    public class AppInstanceBot : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveChimeAppInstanceBotTypesConfigurationConfiguration, IHaveMetadata, IHaveAppInstanceArn, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string LastUpdatedTimestamp =  "LastUpdatedTimestamp" ;
            public static string AppInstanceBotArn =  "AppInstanceBotArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.AppInstanceBot; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstancebot.html#cfn-chime-appinstancebot-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Configuration
        /// </summary>
        [Required]
        public Union<Humidifier.Chime.AppInstanceBotTypes.Configuration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// Metadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstancebot.html#cfn-chime-appinstancebot-metadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Metadata { get; set; }

        /// <summary>
        /// AppInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstancebot.html#cfn-chime-appinstancebot-appinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AppInstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-appinstancebot.html#cfn-chime-appinstancebot-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AppInstanceBotTypes
    {
        public class Configuration : Humidifier.Base.BaseSubResource, IHaveChimeAppInstanceBotTypesLexConfigurationLex
        {
            /// <summary>
            /// Lex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstancebot-configuration.html#cfn-chime-appinstancebot-configuration-lex
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LexConfiguration
            /// </summary>
            public Union<Humidifier.Chime.AppInstanceBotTypes.LexConfiguration, BaseFunction>? Lex { get; set; }
        }

        public class InvokedBy : Humidifier.Base.BaseSubResource, IHaveStandardMessages, IHaveTargetedMessages
        {
            /// <summary>
            /// StandardMessages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstancebot-invokedby.html#cfn-chime-appinstancebot-invokedby-standardmessages
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StandardMessages { get; set; }
            /// <summary>
            /// TargetedMessages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstancebot-invokedby.html#cfn-chime-appinstancebot-invokedby-targetedmessages
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetedMessages { get; set; }
        }

        public class LexConfiguration : Humidifier.Base.BaseSubResource, IHaveLexBotAliasArn, IHaveChimeAppInstanceBotTypesInvokedByInvokedBy, IHaveLocaleId, IHaveRespondsTo, IHaveWelcomeIntent
        {
            /// <summary>
            /// LexBotAliasArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstancebot-lexconfiguration.html#cfn-chime-appinstancebot-lexconfiguration-lexbotaliasarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LexBotAliasArn { get; set; }
            /// <summary>
            /// InvokedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstancebot-lexconfiguration.html#cfn-chime-appinstancebot-lexconfiguration-invokedby
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InvokedBy
            /// </summary>
            public Union<Humidifier.Chime.AppInstanceBotTypes.InvokedBy, BaseFunction>? InvokedBy { get; set; }
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstancebot-lexconfiguration.html#cfn-chime-appinstancebot-lexconfiguration-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocaleId { get; set; }
            /// <summary>
            /// RespondsTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstancebot-lexconfiguration.html#cfn-chime-appinstancebot-lexconfiguration-respondsto
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RespondsTo { get; set; }
            /// <summary>
            /// WelcomeIntent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-appinstancebot-lexconfiguration.html#cfn-chime-appinstancebot-lexconfiguration-welcomeintent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WelcomeIntent { get; set; }
        }
    }
}