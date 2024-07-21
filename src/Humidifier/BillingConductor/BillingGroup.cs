namespace Humidifier.BillingConductor
{
    using System.Collections.Generic;
    using BillingGroupTypes;

    public class BillingGroup : Humidifier.Resource, IHaveTags, IHaveDescription
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

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::BillingConductor::BillingGroup";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// PrimaryAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-primaryaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PrimaryAccountId { get; set; }
        /// <summary>
        /// ComputationPreference
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-computationpreference
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ComputationPreference
        /// </summary>
        public ComputationPreference ComputationPreference { get; set; }
        /// <summary>
        /// AccountGrouping
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-accountgrouping
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AccountGrouping
        /// </summary>
        public AccountGrouping AccountGrouping { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-billingconductor-billinggroup.html#cfn-billingconductor-billinggroup-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace BillingGroupTypes
    {
        public class AccountGrouping
        {
            /// <summary>
            /// LinkedAccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-billinggroup-accountgrouping.html#cfn-billingconductor-billinggroup-accountgrouping-linkedaccountids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LinkedAccountIds { get; set; }
            /// <summary>
            /// AutoAssociate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-billinggroup-accountgrouping.html#cfn-billingconductor-billinggroup-accountgrouping-autoassociate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoAssociate { get; set; }
        }

        public class ComputationPreference
        {
            /// <summary>
            /// PricingPlanArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-billingconductor-billinggroup-computationpreference.html#cfn-billingconductor-billinggroup-computationpreference-pricingplanarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PricingPlanArn { get; set; }
        }
    }
}