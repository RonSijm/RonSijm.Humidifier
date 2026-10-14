namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;
    using PoolTypes;

    public class Pool : Humidifier.Base.BaseResource, IHaveTags, IHaveDeletionProtectionEnabled
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
        public dynamic OptOutListName { get; set; }
        /// <summary>
        /// SelfManagedOptOutsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-selfmanagedoptoutsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SelfManagedOptOutsEnabled { get; set; }
        /// <summary>
        /// SharedRoutesEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-sharedroutesenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SharedRoutesEnabled { get; set; }

        /// <summary>
        /// OriginationIdentities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-originationidentities
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic OriginationIdentities { get; set; }
        /// <summary>
        /// TwoWay
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-twoway
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TwoWay
        /// </summary>
        public Humidifier.SMSVOICE.PoolTypes.TwoWay TwoWay { get; set; }

        /// <summary>
        /// MandatoryKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-mandatorykeywords
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MandatoryKeywords
        /// </summary>
        [Required]
        public Humidifier.SMSVOICE.PoolTypes.MandatoryKeywords MandatoryKeywords { get; set; }
        /// <summary>
        /// OptionalKeywords
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-optionalkeywords
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OptionalKeyword
        /// </summary>
        public List<Humidifier.SMSVOICE.PoolTypes.OptionalKeyword> OptionalKeywords { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-pool.html#cfn-smsvoice-pool-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
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
            public dynamic Message { get; set; }
        }

        public class MandatoryKeywords : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HELP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-mandatorykeywords.html#cfn-smsvoice-pool-mandatorykeywords-help
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MandatoryKeyword
            /// </summary>
            public Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword HELP { get; set; }
            /// <summary>
            /// STOP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-mandatorykeywords.html#cfn-smsvoice-pool-mandatorykeywords-stop
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MandatoryKeyword
            /// </summary>
            public Humidifier.SMSVOICE.PoolTypes.MandatoryKeyword STOP { get; set; }
        }

        public class OptionalKeyword : Humidifier.Base.BaseSubResource, IHaveAction, IHaveMessage
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-optionalkeyword.html#cfn-smsvoice-pool-optionalkeyword-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// Keyword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-optionalkeyword.html#cfn-smsvoice-pool-optionalkeyword-keyword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Keyword { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-optionalkeyword.html#cfn-smsvoice-pool-optionalkeyword-message
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-twoway.html#cfn-smsvoice-pool-twoway-channelarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelArn { get; set; }
            /// <summary>
            /// ChannelRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-twoway.html#cfn-smsvoice-pool-twoway-channelrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelRole { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-smsvoice-pool-twoway.html#cfn-smsvoice-pool-twoway-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }
    }
}