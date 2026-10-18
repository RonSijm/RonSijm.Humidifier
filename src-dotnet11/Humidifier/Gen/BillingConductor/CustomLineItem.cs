namespace Humidifier.BillingConductor
{
    using global::System.Collections.Generic;
    using CustomLineItemTypes;

    public class CustomLineItem : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveBillingConductorCustomLineItemTypesBillingPeriodRangeBillingPeriodRange, IHaveDescription, IHaveAccountId, IHaveBillingConductorCustomLineItemTypesPresentationDetailsPresentationDetails, IHaveBillingGroupArn, IHaveComputationRule, IHaveBillingConductorCustomLineItemTypesCustomLineItemChargeDetailsCustomLineItemChargeDetails, IHaveName
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
        public Union<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange, BaseFunction>? BillingPeriodRange { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-accountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AccountId { get; set; }
        /// <summary>
        /// PresentationDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-presentationdetails
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PresentationDetails
        /// </summary>
        public Union<Humidifier.BillingConductor.CustomLineItemTypes.PresentationDetails, BaseFunction>? PresentationDetails { get; set; }

        /// <summary>
        /// BillingGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-billinggrouparn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BillingGroupArn { get; set; }
        /// <summary>
        /// ComputationRule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-computationrule
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ComputationRule { get; set; }
        /// <summary>
        /// CustomLineItemChargeDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-customlineitemchargedetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomLineItemChargeDetails
        /// </summary>
        public Union<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemChargeDetails, BaseFunction>? CustomLineItemChargeDetails { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-customlineitem.html#cfn-billingconductor-customlineitem-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CustomLineItemTypes
    {
        public class BillingPeriodRange : Humidifier.Base.BaseSubResource, IHaveExclusiveEndBillingPeriod, IHaveInclusiveStartBillingPeriod
        {
            /// <summary>
            /// ExclusiveEndBillingPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-billingperiodrange.html#cfn-billingconductor-customlineitem-billingperiodrange-exclusiveendbillingperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExclusiveEndBillingPeriod { get; set; }
            /// <summary>
            /// InclusiveStartBillingPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-billingperiodrange.html#cfn-billingconductor-customlineitem-billingperiodrange-inclusivestartbillingperiod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InclusiveStartBillingPeriod { get; set; }
        }

        public class CustomLineItemChargeDetails : Humidifier.Base.BaseSubResource, IHaveListOfBillingConductorCustomLineItemTypesLineItemFilterLineItemFilters, IHaveType, IHaveBillingConductorCustomLineItemTypesCustomLineItemPercentageChargeDetailsPercentage, IHaveBillingConductorCustomLineItemTypesCustomLineItemFlatChargeDetailsFlat
        {
            /// <summary>
            /// LineItemFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemchargedetails.html#cfn-billingconductor-customlineitem-customlineitemchargedetails-lineitemfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LineItemFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BillingConductor.CustomLineItemTypes.LineItemFilter>, IReadOnlyList<Union<Humidifier.BillingConductor.CustomLineItemTypes.LineItemFilter, BaseFunction>>, BaseFunction>? LineItemFilters { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemchargedetails.html#cfn-billingconductor-customlineitem-customlineitemchargedetails-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Percentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemchargedetails.html#cfn-billingconductor-customlineitem-customlineitemchargedetails-percentage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomLineItemPercentageChargeDetails
            /// </summary>
            public Union<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemPercentageChargeDetails, BaseFunction>? Percentage { get; set; }
            /// <summary>
            /// Flat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemchargedetails.html#cfn-billingconductor-customlineitem-customlineitemchargedetails-flat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomLineItemFlatChargeDetails
            /// </summary>
            public Union<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemFlatChargeDetails, BaseFunction>? Flat { get; set; }
        }

        public class CustomLineItemFlatChargeDetails : Humidifier.Base.BaseSubResource, IHaveChargeValue_Double
        {
            /// <summary>
            /// ChargeValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitemflatchargedetails.html#cfn-billingconductor-customlineitem-customlineitemflatchargedetails-chargevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ChargeValue { get; set; }
        }

        public class CustomLineItemPercentageChargeDetails : Humidifier.Base.BaseSubResource, IHaveStringListOfChildAssociatedResources, IHavePercentageValue_Double
        {
            /// <summary>
            /// ChildAssociatedResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitempercentagechargedetails.html#cfn-billingconductor-customlineitem-customlineitempercentagechargedetails-childassociatedresources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ChildAssociatedResources { get; set; }
            /// <summary>
            /// PercentageValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-customlineitempercentagechargedetails.html#cfn-billingconductor-customlineitem-customlineitempercentagechargedetails-percentagevalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? PercentageValue { get; set; }
        }

        public class LineItemFilter : Humidifier.Base.BaseSubResource, IHaveMatchOption, IHaveAttribute, IHaveStringListOfAttributeValues, IHaveStringListOfValues
        {
            /// <summary>
            /// MatchOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-lineitemfilter.html#cfn-billingconductor-customlineitem-lineitemfilter-matchoption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchOption { get; set; }
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-lineitemfilter.html#cfn-billingconductor-customlineitem-lineitemfilter-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
            /// <summary>
            /// AttributeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-lineitemfilter.html#cfn-billingconductor-customlineitem-lineitemfilter-attributevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttributeValues { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-lineitemfilter.html#cfn-billingconductor-customlineitem-lineitemfilter-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class PresentationDetails : Humidifier.Base.BaseSubResource, IHaveService
        {
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-customlineitem-presentationdetails.html#cfn-billingconductor-customlineitem-presentationdetails-service
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Service { get; set; }
        }
    }
}