namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;

    public class NotifyConfiguration : Humidifier.Base.BaseResource, IHaveTags, IHavePoolId, IHaveStringListOfEnabledChannels, IHaveDefaultTemplateId, IHaveDisplayName, IHaveUseCase, IHaveStringListOfEnabledCountries, IHaveDeletionProtectionEnabled_Boolean
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
        public Union<string, BaseFunction>? PoolId { get; set; }

        /// <summary>
        /// EnabledChannels
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-enabledchannels
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledChannels { get; set; }
        /// <summary>
        /// DefaultTemplateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-defaulttemplateid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultTemplateId { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-displayname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// UseCase
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-usecase
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UseCase { get; set; }
        /// <summary>
        /// EnabledCountries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-enabledcountries
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledCountries { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-notifyconfiguration.html#cfn-smsvoice-notifyconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}