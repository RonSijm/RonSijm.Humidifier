namespace Humidifier.Billing
{
    using global::System.Collections.Generic;
    using BillingViewTypes;

    public class BillingView : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
            public static string BillingViewType =  "BillingViewType" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Billing.BillingView; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billing-billingview.html#cfn-billing-billingview-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// SourceViews
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billing-billingview.html#cfn-billing-billingview-sourceviews
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic SourceViews { get; set; }
        /// <summary>
        /// DataFilterExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billing-billingview.html#cfn-billing-billingview-datafilterexpression
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataFilterExpression
        /// </summary>
        public Humidifier.Billing.BillingViewTypes.DataFilterExpression DataFilterExpression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billing-billingview.html#cfn-billing-billingview-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace BillingViewTypes
    {
        public class DataFilterExpression : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-datafilterexpression.html#cfn-billing-billingview-datafilterexpression-timerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRange
            /// </summary>
            public Humidifier.Billing.BillingViewTypes.TimeRange TimeRange { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-datafilterexpression.html#cfn-billing-billingview-datafilterexpression-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Dimensions
            /// </summary>
            public Humidifier.Billing.BillingViewTypes.Dimensions Dimensions { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-datafilterexpression.html#cfn-billing-billingview-datafilterexpression-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Tags
            /// </summary>
            public Humidifier.Billing.BillingViewTypes.Tags Tags { get; set; }
        }

        public class Dimensions : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-dimensions.html#cfn-billing-billingview-dimensions-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-dimensions.html#cfn-billing-billingview-dimensions-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource, IHaveKey, IHaveValues
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-tags.html#cfn-billing-billingview-tags-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-tags.html#cfn-billing-billingview-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class TimeRange : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EndDateInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-timerange.html#cfn-billing-billingview-timerange-enddateinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndDateInclusive { get; set; }
            /// <summary>
            /// BeginDateInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-timerange.html#cfn-billing-billingview-timerange-begindateinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BeginDateInclusive { get; set; }
        }
    }
}