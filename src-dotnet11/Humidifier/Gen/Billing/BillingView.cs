namespace Humidifier.Billing
{
    using global::System.Collections.Generic;
    using BillingViewTypes;

    public class BillingView : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveStringListOfSourceViews, IHaveBillingBillingViewTypesDataFilterExpressionDataFilterExpression, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// SourceViews
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billing-billingview.html#cfn-billing-billingview-sourceviews
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SourceViews { get; set; }
        /// <summary>
        /// DataFilterExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billing-billingview.html#cfn-billing-billingview-datafilterexpression
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataFilterExpression
        /// </summary>
        public Union<Humidifier.Billing.BillingViewTypes.DataFilterExpression, BaseFunction>? DataFilterExpression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billing-billingview.html#cfn-billing-billingview-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace BillingViewTypes
    {
        public class DataFilterExpression : Humidifier.Base.BaseSubResource, IHaveBillingBillingViewTypesTimeRangeTimeRange, IHaveBillingBillingViewTypesDimensionsDimensions, IHaveBillingBillingViewTypesTagsTags
        {
            /// <summary>
            /// TimeRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-datafilterexpression.html#cfn-billing-billingview-datafilterexpression-timerange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TimeRange
            /// </summary>
            public Union<Humidifier.Billing.BillingViewTypes.TimeRange, BaseFunction>? TimeRange { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-datafilterexpression.html#cfn-billing-billingview-datafilterexpression-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Dimensions
            /// </summary>
            public Union<Humidifier.Billing.BillingViewTypes.Dimensions, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-datafilterexpression.html#cfn-billing-billingview-datafilterexpression-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Tags
            /// </summary>
            public Union<Humidifier.Billing.BillingViewTypes.Tags, BaseFunction>? Tags { get; set; }
        }

        public class Dimensions : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-dimensions.html#cfn-billing-billingview-dimensions-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-dimensions.html#cfn-billing-billingview-dimensions-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveKey
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-tags.html#cfn-billing-billingview-tags-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-tags.html#cfn-billing-billingview-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class TimeRange : Humidifier.Base.BaseSubResource, IHaveEndDateInclusive, IHaveBeginDateInclusive
        {
            /// <summary>
            /// EndDateInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-timerange.html#cfn-billing-billingview-timerange-enddateinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndDateInclusive { get; set; }
            /// <summary>
            /// BeginDateInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billing-billingview-timerange.html#cfn-billing-billingview-timerange-begindateinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BeginDateInclusive { get; set; }
        }
    }
}