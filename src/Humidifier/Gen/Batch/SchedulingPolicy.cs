namespace Humidifier.Batch
{
    using System.Collections.Generic;
    using SchedulingPolicyTypes;

    public class SchedulingPolicy : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Batch.SchedulingPolicy; }
        /// <summary>
        /// FairsharePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-schedulingpolicy.html#cfn-batch-schedulingpolicy-fairsharepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FairsharePolicy
        /// </summary>
        public Humidifier.Batch.SchedulingPolicyTypes.FairsharePolicy FairsharePolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-schedulingpolicy.html#cfn-batch-schedulingpolicy-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace SchedulingPolicyTypes
    {
        public class FairsharePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ShareDistribution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-fairsharepolicy.html#cfn-batch-schedulingpolicy-fairsharepolicy-sharedistribution
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ShareAttributes
            /// </summary>
            public List<Humidifier.Batch.SchedulingPolicyTypes.ShareAttributes> ShareDistribution { get; set; }
            /// <summary>
            /// ShareDecaySeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-fairsharepolicy.html#cfn-batch-schedulingpolicy-fairsharepolicy-sharedecayseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ShareDecaySeconds { get; set; }
            /// <summary>
            /// ComputeReservation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-fairsharepolicy.html#cfn-batch-schedulingpolicy-fairsharepolicy-computereservation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ComputeReservation { get; set; }
        }

        public class ShareAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WeightFactor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-shareattributes.html#cfn-batch-schedulingpolicy-shareattributes-weightfactor
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic WeightFactor { get; set; }
            /// <summary>
            /// ShareIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-schedulingpolicy-shareattributes.html#cfn-batch-schedulingpolicy-shareattributes-shareidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ShareIdentifier { get; set; }
        }
    }
}