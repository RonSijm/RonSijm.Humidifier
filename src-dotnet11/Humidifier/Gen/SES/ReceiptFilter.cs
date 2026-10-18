namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using ReceiptFilterTypes;

    public class ReceiptFilter : Humidifier.Base.BaseResource, IHaveSESReceiptFilterTypesFilterFilter
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.SES.ReceiptFilter; }

        /// <summary>
        /// Filter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptfilter.html#cfn-ses-receiptfilter-filter
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Filter
        /// </summary>
        [Required]
        public Union<Humidifier.SES.ReceiptFilterTypes.Filter, BaseFunction>? Filter { get; set; }
    }

    namespace ReceiptFilterTypes
    {
        public class Filter : Humidifier.Base.BaseSubResource, IHaveSESReceiptFilterTypesIpFilterIpFilter, IHaveName
        {
            /// <summary>
            /// IpFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-filter.html#cfn-ses-receiptfilter-filter-ipfilter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: IpFilter
            /// </summary>
            public Union<Humidifier.SES.ReceiptFilterTypes.IpFilter, BaseFunction>? IpFilter { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-filter.html#cfn-ses-receiptfilter-filter-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IpFilter : Humidifier.Base.BaseSubResource, IHavePolicy, IHaveCidr
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-ipfilter.html#cfn-ses-receiptfilter-ipfilter-policy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Policy { get; set; }
            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-ipfilter.html#cfn-ses-receiptfilter-ipfilter-cidr
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Cidr { get; set; }
        }
    }
}