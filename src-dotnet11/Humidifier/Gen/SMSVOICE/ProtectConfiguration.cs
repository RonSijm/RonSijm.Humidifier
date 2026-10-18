namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using ProtectConfigurationTypes;

    public class ProtectConfiguration : Humidifier.Base.BaseResource, IHaveTags, IHaveSMSVOICEProtectConfigurationTypesCountryRuleSetCountryRuleSet, IHaveDeletionProtectionEnabled_Boolean
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string ProtectConfigurationId =  "ProtectConfigurationId" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.ProtectConfiguration; }
        /// <summary>
        /// CountryRuleSet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-protectconfiguration.html#cfn-smsvoice-protectconfiguration-countryruleset
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CountryRuleSet
        /// </summary>
        public Union<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet, BaseFunction>? CountryRuleSet { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-protectconfiguration.html#cfn-smsvoice-protectconfiguration-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-protectconfiguration.html#cfn-smsvoice-protectconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ProtectConfigurationTypes
    {
        public class CountryRule : Humidifier.Base.BaseSubResource, IHaveCountryCode, IHaveProtectStatus
        {
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryrule.html#cfn-smsvoice-protectconfiguration-countryrule-countrycode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CountryCode { get; set; }
            /// <summary>
            /// ProtectStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryrule.html#cfn-smsvoice-protectconfiguration-countryrule-protectstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProtectStatus { get; set; }
        }

        public class CountryRuleSet : Humidifier.Base.BaseSubResource, IHaveListOfSMSVOICEProtectConfigurationTypesCountryRuleVOICE, IHaveListOfSMSVOICEProtectConfigurationTypesCountryRuleMMS, IHaveListOfSMSVOICEProtectConfigurationTypesCountryRuleSMS
        {
            /// <summary>
            /// VOICE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryruleset.html#cfn-smsvoice-protectconfiguration-countryruleset-voice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CountryRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule>, IReadOnlyList<Union<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule, BaseFunction>>, BaseFunction>? VOICE { get; set; }
            /// <summary>
            /// MMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryruleset.html#cfn-smsvoice-protectconfiguration-countryruleset-mms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CountryRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule>, IReadOnlyList<Union<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule, BaseFunction>>, BaseFunction>? MMS { get; set; }
            /// <summary>
            /// SMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryruleset.html#cfn-smsvoice-protectconfiguration-countryruleset-sms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CountryRule
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule>, IReadOnlyList<Union<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule, BaseFunction>>, BaseFunction>? SMS { get; set; }
        }
    }
}