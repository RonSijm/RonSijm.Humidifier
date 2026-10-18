namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using PoolTypes;

    public class Pool : Humidifier.Base.BaseResource, IHaveTags, IHaveOptOutListName, IHaveSelfManagedOptOutsEnabled_Boolean, IHaveSharedRoutesEnabled_Boolean, IHaveStringListOfOriginationIdentities, IHaveSMSVOICEPoolTypesTwoWayTwoWay, IHaveSMSVOICEPoolTypesMandatoryKeywordsMandatoryKeywords, IHaveListOfSMSVOICEPoolTypesOptionalKeywordOptionalKeywords, IHaveDeletionProtectionEnabled_Boolean
    {
        public class Attributes
        {
            public static string PoolId =  "PoolId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.Pool; }
        /// <summary>
        /// OptOutListName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-optoutlistname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OptOutListName { get; set; }
        /// <summary>
        /// SelfManagedOptOutsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-selfmanagedoptoutsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SelfManagedOptOutsEnabled { get; set; }
        /// <summary>
        /// SharedRoutesEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-sharedroutesenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SharedRoutesEnabled { get; set; }

        /// <summary>
        /// OriginationIdentities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-originationidentities
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OriginationIdentities { get; set; }
        /// <summary>
        /// TwoWay
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-twoway
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TwoWay
        /// </summary>
        public Union<Humidifier.SMSVOICE.PoolTypes.TwoWay, BaseFunction>? TwoWay { get; set; }

        /// <summary>
        /// MandatoryKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-mandatorykeywords
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MandatoryKeywords
        /// </summary>
        [Required]
        public Union<Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords, BaseFunction>? MandatoryKeywords { get; set; }
        /// <summary>
        /// OptionalKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-optionalkeywords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OptionalKeyword
        /// </summary>
        public Union<IReadOnlyList<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword>, IReadOnlyList<Union<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword, BaseFunction>>, BaseFunction>? OptionalKeywords { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PoolTypes
    {
        public class MandatoryKeyword : Humidifier.Base.BaseSubResource, IHaveMessage
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-mandatorykeyword.html#cfn-smsvoice-pool-mandatorykeyword-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
        }

        public class MandatoryKeywords : Humidifier.Base.BaseSubResource, IHaveSMSVOICEPoolTypesMandatoryKeywordHELP, IHaveSMSVOICEPoolTypesMandatoryKeywordSTOP
        {
            /// <summary>
            /// HELP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-mandatorykeywords.html#cfn-smsvoice-pool-mandatorykeywords-help
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MandatoryKeyword
            /// </summary>
            public Union<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword, BaseFunction>? HELP { get; set; }
            /// <summary>
            /// STOP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-mandatorykeywords.html#cfn-smsvoice-pool-mandatorykeywords-stop
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MandatoryKeyword
            /// </summary>
            public Union<Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword, BaseFunction>? STOP { get; set; }
        }

        public class OptionalKeyword : Humidifier.Base.BaseSubResource, IHaveAction, IHaveKeyword, IHaveMessage
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-optionalkeyword.html#cfn-smsvoice-pool-optionalkeyword-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// Keyword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-optionalkeyword.html#cfn-smsvoice-pool-optionalkeyword-keyword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Keyword { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-optionalkeyword.html#cfn-smsvoice-pool-optionalkeyword-message
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-twoway.html#cfn-smsvoice-pool-twoway-channelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelArn { get; set; }
            /// <summary>
            /// ChannelRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-twoway.html#cfn-smsvoice-pool-twoway-channelrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelRole { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-twoway.html#cfn-smsvoice-pool-twoway-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}