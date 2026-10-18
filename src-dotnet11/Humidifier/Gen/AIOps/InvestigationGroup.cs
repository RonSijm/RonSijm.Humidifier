namespace Humidifier.AIOps
{
    using global::System.Collections.Generic;
    using InvestigationGroupTypes;

    public class InvestigationGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveRetentionInDays_Integer, IHaveListOfAIOpsInvestigationGroupTypesCrossAccountConfigurationCrossAccountConfigurations, IHaveInvestigationGroupPolicy, IHaveListOfAIOpsInvestigationGroupTypesChatbotNotificationChannelChatbotNotificationChannels, IHaveIsCloudTrailEventHistoryEnabled_Boolean, IHaveStringListOfTagKeyBoundaries, IHaveAIOpsInvestigationGroupTypesEncryptionConfigMapEncryptionConfig, IHaveRoleArn, IHaveName
    {
        public class Attributes
        {
            public static string LastModifiedBy =  "LastModifiedBy" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string LastModifiedAt =  "LastModifiedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AIOps.InvestigationGroup; }
        /// <summary>
        /// RetentionInDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-retentionindays
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RetentionInDays { get; set; }
        /// <summary>
        /// CrossAccountConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-crossaccountconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CrossAccountConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AIOps.InvestigationGroupTypes.CrossAccountConfiguration>, IReadOnlyList<Union<Humidifier.AIOps.InvestigationGroupTypes.CrossAccountConfiguration, BaseFunction>>, BaseFunction>? CrossAccountConfigurations { get; set; }
        /// <summary>
        /// InvestigationGroupPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-investigationgrouppolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InvestigationGroupPolicy { get; set; }
        /// <summary>
        /// ChatbotNotificationChannels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-chatbotnotificationchannels
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ChatbotNotificationChannel
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AIOps.InvestigationGroupTypes.ChatbotNotificationChannel>, IReadOnlyList<Union<Humidifier.AIOps.InvestigationGroupTypes.ChatbotNotificationChannel, BaseFunction>>, BaseFunction>? ChatbotNotificationChannels { get; set; }
        /// <summary>
        /// IsCloudTrailEventHistoryEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-iscloudtraileventhistoryenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsCloudTrailEventHistoryEnabled { get; set; }
        /// <summary>
        /// TagKeyBoundaries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-tagkeyboundaries
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TagKeyBoundaries { get; set; }
        /// <summary>
        /// EncryptionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-encryptionconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EncryptionConfigMap
        /// </summary>
        public Union<Humidifier.AIOps.InvestigationGroupTypes.EncryptionConfigMap, BaseFunction>? EncryptionConfig { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aiops-investigationgroup.html#cfn-aiops-investigationgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace InvestigationGroupTypes
    {
        public class ChatbotNotificationChannel : Humidifier.Base.BaseSubResource, IHaveSNSTopicArn, IHaveStringListOfChatConfigurationArns
        {
            /// <summary>
            /// SNSTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aiops-investigationgroup-chatbotnotificationchannel.html#cfn-aiops-investigationgroup-chatbotnotificationchannel-snstopicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SNSTopicArn { get; set; }
            /// <summary>
            /// ChatConfigurationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aiops-investigationgroup-chatbotnotificationchannel.html#cfn-aiops-investigationgroup-chatbotnotificationchannel-chatconfigurationarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ChatConfigurationArns { get; set; }
        }

        public class CrossAccountConfiguration : Humidifier.Base.BaseSubResource, IHaveSourceRoleArn
        {
            /// <summary>
            /// SourceRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aiops-investigationgroup-crossaccountconfiguration.html#cfn-aiops-investigationgroup-crossaccountconfiguration-sourcerolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceRoleArn { get; set; }
        }

        public class EncryptionConfigMap : Humidifier.Base.BaseSubResource, IHaveEncryptionConfigurationType, IHaveKmsKeyId
        {
            /// <summary>
            /// EncryptionConfigurationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aiops-investigationgroup-encryptionconfigmap.html#cfn-aiops-investigationgroup-encryptionconfigmap-encryptionconfigurationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionConfigurationType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aiops-investigationgroup-encryptionconfigmap.html#cfn-aiops-investigationgroup-encryptionconfigmap-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }
    }
}