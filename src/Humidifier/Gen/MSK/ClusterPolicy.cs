namespace Humidifier.MSK
{
    using System.Collections.Generic;

    public class ClusterPolicy : Humidifier.Base.BaseResource, IHavePolicy, IHaveClusterArn
    {
        public class Attributes
        {
            public static string CurrentVersion =  "CurrentVersion" ;
        }

        public override string AWSTypeName { get => AWS.MSK.ClusterPolicy; }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-clusterpolicy.html#cfn-msk-clusterpolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public dynamic Policy { get; set; }

        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-clusterpolicy.html#cfn-msk-clusterpolicy-clusterarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterArn { get; set; }
    }
}