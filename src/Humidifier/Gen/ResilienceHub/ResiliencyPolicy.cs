namespace Humidifier.ResilienceHub
{
    using System.Collections.Generic;
    using ResiliencyPolicyTypes;

    public class ResiliencyPolicy : Humidifier.Base.BaseResource, IHavePolicyName, IHaveTier, IHavePolicyDescription
    {
        public class Attributes
        {
            public static string PolicyArn =  "PolicyArn" ;
        }

        public override string AWSTypeName { get => AWS.ResilienceHub.ResiliencyPolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-resiliencypolicy.html#cfn-resiliencehub-resiliencypolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PolicyMap
        /// </summary>
        [Required]
        public Humidifier.ResilienceHub.ResiliencyPolicyTypes.PolicyMap Policy { get; set; }
        /// <summary>
        /// PolicyDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-resiliencypolicy.html#cfn-resiliencehub-resiliencypolicy-policydescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PolicyDescription { get; set; }

        /// <summary>
        /// Tier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-resiliencypolicy.html#cfn-resiliencehub-resiliencypolicy-tier
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Tier { get; set; }

        /// <summary>
        /// PolicyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-resiliencypolicy.html#cfn-resiliencehub-resiliencypolicy-policyname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PolicyName { get; set; }
        /// <summary>
        /// DataLocationConstraint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-resiliencypolicy.html#cfn-resiliencehub-resiliencypolicy-datalocationconstraint
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataLocationConstraint { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-resiliencehub-resiliencypolicy.html#cfn-resiliencehub-resiliencypolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace ResiliencyPolicyTypes
    {
        public class FailurePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RpoInSecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-resiliencypolicy-failurepolicy.html#cfn-resiliencehub-resiliencypolicy-failurepolicy-rpoinsecs
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RpoInSecs { get; set; }
            /// <summary>
            /// RtoInSecs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-resiliencypolicy-failurepolicy.html#cfn-resiliencehub-resiliencypolicy-failurepolicy-rtoinsecs
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RtoInSecs { get; set; }
        }

        public class PolicyMap : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AZ
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-resiliencypolicy-policymap.html#cfn-resiliencehub-resiliencypolicy-policymap-az
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FailurePolicy
            /// </summary>
            public Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy AZ { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-resiliencypolicy-policymap.html#cfn-resiliencehub-resiliencypolicy-policymap-region
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FailurePolicy
            /// </summary>
            public Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy Region { get; set; }
            /// <summary>
            /// Hardware
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-resiliencypolicy-policymap.html#cfn-resiliencehub-resiliencypolicy-policymap-hardware
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FailurePolicy
            /// </summary>
            public Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy Hardware { get; set; }
            /// <summary>
            /// Software
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resiliencehub-resiliencypolicy-policymap.html#cfn-resiliencehub-resiliencypolicy-policymap-software
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FailurePolicy
            /// </summary>
            public Humidifier.ResilienceHub.ResiliencyPolicyTypes.FailurePolicy Software { get; set; }
        }
    }
}