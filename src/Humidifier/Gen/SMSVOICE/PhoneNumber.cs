namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using PhoneNumberTypes;

    public class PhoneNumber : Humidifier.Base.BaseResource, IHaveTags, IHaveDeletionProtectionEnabled
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
        public dynamic OptOutListName { get; set; }
        /// <summary>
        /// SelfManagedOptOutsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-selfmanagedoptoutsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SelfManagedOptOutsEnabled { get; set; }

        /// <summary>
        /// NumberType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-numbertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NumberType { get; set; }
        /// <summary>
        /// TwoWay
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-twoway
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TwoWay
        /// </summary>
        public Humidifier.SMSVOICE.PhoneNumberTypes.TwoWay TwoWay { get; set; }

        /// <summary>
        /// NumberCapabilities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-numbercapabilities
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic NumberCapabilities { get; set; }

        /// <summary>
        /// MandatoryKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-mandatorykeywords
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MandatoryKeywords
        /// </summary>
        [Required]
        public Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeywords MandatoryKeywords { get; set; }
        /// <summary>
        /// OptionalKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-optionalkeywords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OptionalKeyword
        /// </summary>
        public List<Humidifier.SMSVOICE.PhoneNumberTypes.OptionalKeyword> OptionalKeywords { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// IsoCountryCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-isocountrycode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IsoCountryCode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-phonenumber.html#cfn-smsvoice-phonenumber-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
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
            public dynamic Message { get; set; }
        }

        public class MandatoryKeywords : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HELP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-mandatorykeywords.html#cfn-smsvoice-phonenumber-mandatorykeywords-help
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MandatoryKeyword
            /// </summary>
            public Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword HELP { get; set; }
            /// <summary>
            /// STOP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-mandatorykeywords.html#cfn-smsvoice-phonenumber-mandatorykeywords-stop
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MandatoryKeyword
            /// </summary>
            public Humidifier.SMSVOICE.PhoneNumberTypes.MandatoryKeyword STOP { get; set; }
        }

        public class OptionalKeyword : Humidifier.Base.BaseSubResource, IHaveAction, IHaveMessage
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-optionalkeyword.html#cfn-smsvoice-phonenumber-optionalkeyword-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// Keyword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-optionalkeyword.html#cfn-smsvoice-phonenumber-optionalkeyword-keyword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Keyword { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-optionalkeyword.html#cfn-smsvoice-phonenumber-optionalkeyword-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
        }

        public class TwoWay : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// ChannelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-twoway.html#cfn-smsvoice-phonenumber-twoway-channelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelArn { get; set; }
            /// <summary>
            /// ChannelRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-twoway.html#cfn-smsvoice-phonenumber-twoway-channelrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelRole { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-phonenumber-twoway.html#cfn-smsvoice-phonenumber-twoway-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }
    }
}