namespace Humidifier.BillingConductor
{
    using global::System.Collections.Generic;
    using BillingGroupTypes;

    public class BillingGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHavePrimaryAccountId, IHaveBillingConductorBillingGroupTypesComputationPreferenceComputationPreference, IHaveBillingConductorBillingGroupTypesAccountGroupingAccountGrouping, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Size =  "Size" ;
            public static string StatusReason =  "StatusReason" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.BillingConductor.BillingGroup; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PrimaryAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-primaryaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrimaryAccountId { get; set; }

        /// <summary>
        /// ComputationPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-computationpreference
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ComputationPreference
        /// </summary>
        [Required]
        public Union<Humidifier.BillingConductor.BillingGroupTypes.ComputationPreference, BaseFunction>? ComputationPreference { get; set; }

        /// <summary>
        /// AccountGrouping
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-accountgrouping
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AccountGrouping
        /// </summary>
        [Required]
        public Union<Humidifier.BillingConductor.BillingGroupTypes.AccountGrouping, BaseFunction>? AccountGrouping { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace BillingGroupTypes
    {
        public class AccountGrouping : Humidifier.Base.BaseSubResource, IHaveResponsibilityTransferArn, IHaveStringListOfLinkedAccountIds, IHaveAutoAssociate_Boolean
        {
            /// <summary>
            /// ResponsibilityTransferArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-billinggroup-accountgrouping.html#cfn-billingconductor-billinggroup-accountgrouping-responsibilitytransferarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponsibilityTransferArn { get; set; }
            /// <summary>
            /// LinkedAccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-billinggroup-accountgrouping.html#cfn-billingconductor-billinggroup-accountgrouping-linkedaccountids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LinkedAccountIds { get; set; }
            /// <summary>
            /// AutoAssociate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-billinggroup-accountgrouping.html#cfn-billingconductor-billinggroup-accountgrouping-autoassociate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoAssociate { get; set; }
        }

        public class ComputationPreference : Humidifier.Base.BaseSubResource, IHavePricingPlanArn
        {
            /// <summary>
            /// PricingPlanArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-billinggroup-computationpreference.html#cfn-billingconductor-billinggroup-computationpreference-pricingplanarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PricingPlanArn { get; set; }
        }
    }
}