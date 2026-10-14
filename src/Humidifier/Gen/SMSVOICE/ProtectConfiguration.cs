namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using ProtectConfigurationTypes;

    public class ProtectConfiguration : Humidifier.Base.BaseResource, IHaveTags, IHaveDeletionProtectionEnabled
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
        public Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRuleSet CountryRuleSet { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-protectconfiguration.html#cfn-smsvoice-protectconfiguration-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-protectconfiguration.html#cfn-smsvoice-protectconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ProtectConfigurationTypes
    {
        public class CountryRule : Humidifier.Base.BaseSubResource, IHaveCountryCode
        {
            /// <summary>
            /// CountryCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryrule.html#cfn-smsvoice-protectconfiguration-countryrule-countrycode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CountryCode { get; set; }
            /// <summary>
            /// ProtectStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryrule.html#cfn-smsvoice-protectconfiguration-countryrule-protectstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProtectStatus { get; set; }
        }

        public class CountryRuleSet : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VOICE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryruleset.html#cfn-smsvoice-protectconfiguration-countryruleset-voice
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CountryRule
            /// </summary>
            public List<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule> VOICE { get; set; }
            /// <summary>
            /// MMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryruleset.html#cfn-smsvoice-protectconfiguration-countryruleset-mms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CountryRule
            /// </summary>
            public List<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule> MMS { get; set; }
            /// <summary>
            /// SMS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-protectconfiguration-countryruleset.html#cfn-smsvoice-protectconfiguration-countryruleset-sms
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CountryRule
            /// </summary>
            public List<Humidifier.SMSVOICE.ProtectConfigurationTypes.CountryRule> SMS { get; set; }
        }
    }
}