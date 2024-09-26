namespace Humidifier.BillingConductor
{
    using System.Collections.Generic;
    using CustomLineItemTypes;

    public class CustomLineItem : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveAccountId
    {
        public class Attributes
        {
            public static string CurrencyCode =  "CurrencyCode" ;
            public static string ProductCode =  "ProductCode" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string AssociationSize =  "AssociationSize" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BillingConductor.CustomLineItem; }
        /// <summary>
        /// BillingPeriodRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-billingperiodrange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BillingPeriodRange
        /// </summary>
        public Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange BillingPeriodRange { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-accountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccountId { get; set; }

        /// <summary>
        /// BillingGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-billinggrouparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic BillingGroupArn { get; set; }
        /// <summary>
        /// CustomLineItemChargeDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-customlineitemchargedetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomLineItemChargeDetails
        /// </summary>
        public Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails CustomLineItemChargeDetails { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace CustomLineItemTypes
    {
        public class BillingPeriodRange : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ExclusiveEndBillingPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-billingperiodrange.html#cfn-billingconductor-customlineitem-billingperiodrange-exclusiveendbillingperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExclusiveEndBillingPeriod { get; set; }
            /// <summary>
            /// InclusiveStartBillingPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-billingperiodrange.html#cfn-billingconductor-customlineitem-billingperiodrange-inclusivestartbillingperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InclusiveStartBillingPeriod { get; set; }
        }

        public class CustomLineItemChargeDetails : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// LineItemFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemchargedetails.html#cfn-billingconductor-customlineitem-customlineitemchargedetails-lineitemfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LineItemFilter
            /// </summary>
            public List<Humidifier.BillingConductor.CustomLineItemTypes.LineItemFilter> LineItemFilters { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemchargedetails.html#cfn-billingconductor-customlineitem-customlineitemchargedetails-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Percentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemchargedetails.html#cfn-billingconductor-customlineitem-customlineitemchargedetails-percentage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomLineItemPercentageChargeDetails
            /// </summary>
            public Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemPercentageChargeDetails Percentage { get; set; }
            /// <summary>
            /// Flat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemchargedetails.html#cfn-billingconductor-customlineitem-customlineitemchargedetails-flat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomLineItemFlatChargeDetails
            /// </summary>
            public Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemFlatChargeDetails Flat { get; set; }
        }

        public class CustomLineItemFlatChargeDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChargeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemflatchargedetails.html#cfn-billingconductor-customlineitem-customlineitemflatchargedetails-chargevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ChargeValue { get; set; }
        }

        public class CustomLineItemPercentageChargeDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ChildAssociatedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitempercentagechargedetails.html#cfn-billingconductor-customlineitem-customlineitempercentagechargedetails-childassociatedresources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ChildAssociatedResources { get; set; }
            /// <summary>
            /// PercentageValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitempercentagechargedetails.html#cfn-billingconductor-customlineitem-customlineitempercentagechargedetails-percentagevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PercentageValue { get; set; }
        }

        public class LineItemFilter : Humidifier.Base.BaseSubResource, IHaveValues, IHaveAttribute
        {
            /// <summary>
            /// MatchOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-lineitemfilter.html#cfn-billingconductor-customlineitem-lineitemfilter-matchoption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MatchOption { get; set; }
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-lineitemfilter.html#cfn-billingconductor-customlineitem-lineitemfilter-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-lineitemfilter.html#cfn-billingconductor-customlineitem-lineitemfilter-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }
    }
}