namespace Humidifier.SMSVOICE
{
    using global::System.Collections.Generic;

    public class SenderId : Humidifier.Base.BaseResource, IHaveTags, IHaveSenderId_, IHaveDeletionProtectionEnabled_Boolean, IHaveIsoCountryCode
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SMSVOICE.SenderId; }

        /// <summary>
        /// SenderId_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-senderid.html#cfn-smsvoice-senderid-senderid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SenderId_ { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-senderid.html#cfn-smsvoice-senderid-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// IsoCountryCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-senderid.html#cfn-smsvoice-senderid-isocountrycode
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IsoCountryCode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-smsvoice-senderid.html#cfn-smsvoice-senderid-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}