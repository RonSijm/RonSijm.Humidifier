namespace Humidifier.Lex
{
    using System.Collections.Generic;
    using BotAliasTypes;

    public class BotAlias : Humidifier.Resource, IHaveDescription
    {
        public class Attributes
        {
            public static string BotAliasStatus =  "BotAliasStatus" ;
            public static string Arn =  "Arn" ;
            public static string BotAliasId =  "BotAliasId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Lex::BotAlias";
            }
        }

        /// <summary>
        /// BotVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botalias.html#cfn-lex-botalias-botversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BotVersion { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botalias.html#cfn-lex-botalias-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// BotId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botalias.html#cfn-lex-botalias-botid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BotId { get; set; }
        /// <summary>
        /// BotAliasLocaleSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botalias.html#cfn-lex-botalias-botaliaslocalesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: BotAliasLocaleSettingsItem
        /// </summary>
        public List<BotAliasLocaleSettingsItem> BotAliasLocaleSettings { get; set; }
        /// <summary>
        /// ConversationLogSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botalias.html#cfn-lex-botalias-conversationlogsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConversationLogSettings
        /// </summary>
        public ConversationLogSettings ConversationLogSettings { get; set; }
        /// <summary>
        /// SentimentAnalysisSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botalias.html#cfn-lex-botalias-sentimentanalysissettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SentimentAnalysisSettings
        /// </summary>
        public SentimentAnalysisSettings SentimentAnalysisSettings { get; set; }
        /// <summary>
        /// BotAliasName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botalias.html#cfn-lex-botalias-botaliasname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BotAliasName { get; set; }
        /// <summary>
        /// BotAliasTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lex-botalias.html#cfn-lex-botalias-botaliastags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> BotAliasTags { get; set; }
    }

    namespace BotAliasTypes
    {
        public class AudioLogDestination
        {
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-audiologdestination.html#cfn-lex-botalias-audiologdestination-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3BucketLogDestination
            /// </summary>
            public S3BucketLogDestination S3Bucket { get; set; }
        }

        public class AudioLogSetting
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-audiologsetting.html#cfn-lex-botalias-audiologsetting-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AudioLogDestination
            /// </summary>
            public AudioLogDestination Destination { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-audiologsetting.html#cfn-lex-botalias-audiologsetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class BotAliasLocaleSettings
        {
            /// <summary>
            /// CodeHookSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-botaliaslocalesettings.html#cfn-lex-botalias-botaliaslocalesettings-codehookspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CodeHookSpecification
            /// </summary>
            public CodeHookSpecification CodeHookSpecification { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-botaliaslocalesettings.html#cfn-lex-botalias-botaliaslocalesettings-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class BotAliasLocaleSettingsItem
        {
            /// <summary>
            /// LocaleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-botaliaslocalesettingsitem.html#cfn-lex-botalias-botaliaslocalesettingsitem-localeid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocaleId { get; set; }
            /// <summary>
            /// BotAliasLocaleSetting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-botaliaslocalesettingsitem.html#cfn-lex-botalias-botaliaslocalesettingsitem-botaliaslocalesetting
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BotAliasLocaleSettings
            /// </summary>
            public BotAliasLocaleSettings BotAliasLocaleSetting { get; set; }
        }

        public class CloudWatchLogGroupLogDestination
        {
            /// <summary>
            /// CloudWatchLogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-cloudwatchloggrouplogdestination.html#cfn-lex-botalias-cloudwatchloggrouplogdestination-cloudwatchloggrouparn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudWatchLogGroupArn { get; set; }
            /// <summary>
            /// LogPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-cloudwatchloggrouplogdestination.html#cfn-lex-botalias-cloudwatchloggrouplogdestination-logprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogPrefix { get; set; }
        }

        public class CodeHookSpecification
        {
            /// <summary>
            /// LambdaCodeHook
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-codehookspecification.html#cfn-lex-botalias-codehookspecification-lambdacodehook
            /// Required: True
            /// UpdateType: Mutable
            /// Type: LambdaCodeHook
            /// </summary>
            public LambdaCodeHook LambdaCodeHook { get; set; }
        }

        public class ConversationLogSettings
        {
            /// <summary>
            /// TextLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-conversationlogsettings.html#cfn-lex-botalias-conversationlogsettings-textlogsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TextLogSetting
            /// </summary>
            public List<TextLogSetting> TextLogSettings { get; set; }
            /// <summary>
            /// AudioLogSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-conversationlogsettings.html#cfn-lex-botalias-conversationlogsettings-audiologsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioLogSetting
            /// </summary>
            public List<AudioLogSetting> AudioLogSettings { get; set; }
        }

        public class LambdaCodeHook
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-lambdacodehook.html#cfn-lex-botalias-lambdacodehook-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaArn { get; set; }
            /// <summary>
            /// CodeHookInterfaceVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-lambdacodehook.html#cfn-lex-botalias-lambdacodehook-codehookinterfaceversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CodeHookInterfaceVersion { get; set; }
        }

        public class S3BucketLogDestination
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-s3bucketlogdestination.html#cfn-lex-botalias-s3bucketlogdestination-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
            /// <summary>
            /// LogPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-s3bucketlogdestination.html#cfn-lex-botalias-s3bucketlogdestination-logprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogPrefix { get; set; }
            /// <summary>
            /// S3BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-s3bucketlogdestination.html#cfn-lex-botalias-s3bucketlogdestination-s3bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketArn { get; set; }
        }

        public class SentimentAnalysisSettings
        {
            /// <summary>
            /// DetectSentiment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-sentimentanalysissettings.html#cfn-lex-botalias-sentimentanalysissettings-detectsentiment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DetectSentiment { get; set; }
        }

        public class TextLogDestination
        {
            /// <summary>
            /// CloudWatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-textlogdestination.html#cfn-lex-botalias-textlogdestination-cloudwatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchLogGroupLogDestination
            /// </summary>
            public CloudWatchLogGroupLogDestination CloudWatch { get; set; }
        }

        public class TextLogSetting
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-textlogsetting.html#cfn-lex-botalias-textlogsetting-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TextLogDestination
            /// </summary>
            public TextLogDestination Destination { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lex-botalias-textlogsetting.html#cfn-lex-botalias-textlogsetting-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }
    }
}