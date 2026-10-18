namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using PhoneNumberTypes;

    public class PhoneNumber : Humidifier.Base.BaseResource, IHaveTags, IHaveOptOutListName, IHaveSelfManagedOptOutsEnabled_Boolean, IHaveNumberType, IHaveSMSVOICEPhoneNumberTypesTwoWayTwoWay, IHaveStringListOfNumberCapabilities, IHaveSMSVOICEPhoneNumberTypesMandatoryKeywordsMandatoryKeywords, IHaveListOfSMSVOICEPhoneNumberTypesOptionalKeywordOptionalKeywords, IHaveDeletionProtectionEnabled_Boolean, IHaveIsoCountryCode
    {
        public class Attributes
        {
            public static string PhoneNumber =  "PhoneNumber" ;
            public static string PhoneNumberId =  "PhoneNumberId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.PhoneNumber; }
        /// <summary>
        /// OptOutListName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-optoutlistname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OptOutListName { get; set; }
        /// <summary>
        /// SelfManagedOptOutsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-selfmanagedoptoutsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SelfManagedOptOutsEnabled { get; set; }

        /// <summary>
        /// NumberType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-numbertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NumberType { get; set; }
        /// <summary>
        /// TwoWay
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-twoway
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TwoWay
        /// </summary>
        public Union<Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay, BaseFunction>? TwoWay { get; set; }

        /// <summary>
        /// NumberCapabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-numbercapabilities
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NumberCapabilities { get; set; }

        /// <summary>
        /// MandatoryKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-mandatorykeywords
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MandatoryKeywords
        /// </summary>
        [Required]
        public Union<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords, BaseFunction>? MandatoryKeywords { get; set; }
        /// <summary>
        /// OptionalKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-optionalkeywords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OptionalKeyword
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword>, IReadOnlyList<Union<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword, BaseFunction>>, BaseFunction>? OptionalKeywords { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// IsoCountryCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-isocountrycode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IsoCountryCode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PhoneNumberTypes
    {
        public class MandatoryKeyword : Humidifier.Base.BaseSubResource, IHaveMessage
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-mandatorykeyword.html#cfn-smsvoice-phonenumber-mandatorykeyword-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
        }

        public class MandatoryKeywords : Humidifier.Base.BaseSubResource, IHaveSMSVOICEPhoneNumberTypesMandatoryKeywordHELP, IHaveSMSVOICEPhoneNumberTypesMandatoryKeywordSTOP
        {
            /// <summary>
            /// HELP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-mandatorykeywords.html#cfn-smsvoice-phonenumber-mandatorykeywords-help
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MandatoryKeyword
            /// </summary>
            public Union<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword, BaseFunction>? HELP { get; set; }
            /// <summary>
            /// STOP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-mandatorykeywords.html#cfn-smsvoice-phonenumber-mandatorykeywords-stop
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MandatoryKeyword
            /// </summary>
            public Union<Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword, BaseFunction>? STOP { get; set; }
        }

        public class OptionalKeyword : Humidifier.Base.BaseSubResource, IHaveAction, IHaveKeyword, IHaveMessage
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-optionalkeyword.html#cfn-smsvoice-phonenumber-optionalkeyword-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Keyword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-optionalkeyword.html#cfn-smsvoice-phonenumber-optionalkeyword-keyword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Keyword { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-optionalkeyword.html#cfn-smsvoice-phonenumber-optionalkeyword-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
        }

        public class TwoWay : Humidifier.Base.BaseSubResource, IHaveChannelArn, IHaveChannelRole, IHaveEnabled_Boolean
        {
            /// <summary>
            /// ChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-twoway.html#cfn-smsvoice-phonenumber-twoway-channelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelArn { get; set; }
            /// <summary>
            /// ChannelRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-twoway.html#cfn-smsvoice-phonenumber-twoway-channelrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelRole { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-twoway.html#cfn-smsvoice-phonenumber-twoway-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}