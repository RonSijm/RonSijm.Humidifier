namespace Humidifier.Batch
{
    using global::System.Collections.Generic;
    using SchedulingPolicyTypes;

    public class SchedulingPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveBatchSchedulingPolicyTypesQuotaSharePolicyQuotaSharePolicy, IHaveBatchSchedulingPolicyTypesFairsharePolicyFairsharePolicy, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Batch.SchedulingPolicy; }
        /// <summary>
        /// QuotaSharePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-schedulingpolicy.html#cfn-batch-schedulingpolicy-quotasharepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QuotaSharePolicy
        /// </summary>
        public Union<Humidifier.Batch.SchedulingPolicyTypes.QuotaSharePolicy, BaseFunction>? QuotaSharePolicy { get; set; }
        /// <summary>
        /// FairsharePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-schedulingpolicy.html#cfn-batch-schedulingpolicy-fairsharepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FairsharePolicy
        /// </summary>
        public Union<Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy, BaseFunction>? FairsharePolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-schedulingpolicy.html#cfn-batch-schedulingpolicy-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SchedulingPolicyTypes
    {
        public class FairsharePolicy : Humidifier.Base.BaseSubResource, IHaveListOfBatchSchedulingPolicyTypesShareAttributesShareDistribution, IHaveShareDecaySeconds_Double, IHaveComputeReservation_Double
        {
            /// <summary>
            /// ShareDistribution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-fairsharepolicy.html#cfn-batch-schedulingpolicy-fairsharepolicy-sharedistribution
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ShareAttributes
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Batch.SchedulingPolicyTypes.ShareAttributes>, IReadOnlyList<Union<Humidifier.Batch.SchedulingPolicyTypes.ShareAttributes, BaseFunction>>, BaseFunction>? ShareDistribution { get; set; }
            /// <summary>
            /// ShareDecaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-fairsharepolicy.html#cfn-batch-schedulingpolicy-fairsharepolicy-sharedecayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ShareDecaySeconds { get; set; }
            /// <summary>
            /// ComputeReservation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-fairsharepolicy.html#cfn-batch-schedulingpolicy-fairsharepolicy-computereservation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? ComputeReservation { get; set; }
        }

        public class QuotaSharePolicy : Humidifier.Base.BaseSubResource, IHaveIdleResourceAssignmentStrategy
        {
            /// <summary>
            /// IdleResourceAssignmentStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-quotasharepolicy.html#cfn-batch-schedulingpolicy-quotasharepolicy-idleresourceassignmentstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdleResourceAssignmentStrategy { get; set; }
        }

        public class ShareAttributes : Humidifier.Base.BaseSubResource, IHaveWeightFactor_Double, IHaveShareIdentifier
        {
            /// <summary>
            /// WeightFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-shareattributes.html#cfn-batch-schedulingpolicy-shareattributes-weightfactor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? WeightFactor { get; set; }
            /// <summary>
            /// ShareIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-shareattributes.html#cfn-batch-schedulingpolicy-shareattributes-shareidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ShareIdentifier { get; set; }
        }
    }
}