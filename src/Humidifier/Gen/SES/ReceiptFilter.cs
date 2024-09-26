namespace Humidifier.SES
{
    using System.Collections.Generic;
    using ReceiptFilterTypes;

    public class ReceiptFilter : Humidifier.Base.BaseResource
    {
        public override string AWSTypeName { get => AWS.SES.ReceiptFilter; }

        /// <summary>
        /// Filter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptfilter.html#cfn-ses-receiptfilter-filter
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Filter
        /// </summary>
        [Required]
        public Humidifier.SES.ReceiptFilterTypes.Filter Filter { get; set; }
    }

    namespace ReceiptFilterTypes
    {
        public class Filter : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// IpFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-filter.html#cfn-ses-receiptfilter-filter-ipfilter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IpFilter
            /// </summary>
            public Humidifier.SES.ReceiptFilterTypes.IpFilter IpFilter { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-filter.html#cfn-ses-receiptfilter-filter-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class IpFilter : Humidifier.Base.BaseSubResource, IHavePolicy, IHaveCidr
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-ipfilter.html#cfn-ses-receiptfilter-ipfilter-policy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Policy { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-ipfilter.html#cfn-ses-receiptfilter-ipfilter-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr { get; set; }
        }
    }
}