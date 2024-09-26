namespace Humidifier.S3
{
    using System.Collections.Generic;
    using MultiRegionAccessPointPolicyTypes;

    public class MultiRegionAccessPointPolicy : Humidifier.Base.BaseResource, IHavePolicy
    {
        public class Attributes
        {
            public static string PolicyStatus =  "PolicyStatus" ;
        }

        public override string AWSTypeName { get => AWS.S3.MultiRegionAccessPointPolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-multiregionaccesspointpolicy.html#cfn-s3-multiregionaccesspointpolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic Policy { get; set; }

        /// <summary>
        /// MrapName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3-multiregionaccesspointpolicy.html#cfn-s3-multiregionaccesspointpolicy-mrapname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MrapName { get; set; }
    }

    namespace MultiRegionAccessPointPolicyTypes
    {
        public class PolicyStatus : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IsPublic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-multiregionaccesspointpolicy-policystatus.html#cfn-s3-multiregionaccesspointpolicy-policystatus-ispublic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IsPublic { get; set; }
        }
    }
}