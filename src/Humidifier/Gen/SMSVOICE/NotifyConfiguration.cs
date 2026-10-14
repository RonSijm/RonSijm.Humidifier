namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;

    public class NotifyConfiguration : Humidifier.Base.BaseResource, IHaveTags, IHaveDisplayName, IHaveDeletionProtectionEnabled
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string NotifyConfigurationId =  "NotifyConfigurationId" ;
            public static string Tier =  "Tier" ;
            public static string TierUpgradeStatus =  "TierUpgradeStatus" ;
            public static string NotifyConfigurationArn =  "NotifyConfigurationArn" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.NotifyConfiguration; }
        /// <summary>
        /// PoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-poolid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PoolId { get; set; }

        /// <summary>
        /// EnabledChannels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-enabledchannels
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic EnabledChannels { get; set; }
        /// <summary>
        /// DefaultTemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-defaulttemplateid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultTemplateId { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-displayname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DisplayName { get; set; }

        /// <summary>
        /// UseCase
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-usecase
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic UseCase { get; set; }
        /// <summary>
        /// EnabledCountries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-enabledcountries
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic EnabledCountries { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}