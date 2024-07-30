namespace Humidifier.MSK
{
    using System.Collections.Generic;

    public class ClusterPolicy : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string CurrentVersion =  "CurrentVersion" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::MSK::ClusterPolicy";
            }
        }

        /// <summary>
        /// Policy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-clusterpolicy.html#cfn-msk-clusterpolicy-policy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Policy { get; set; }
        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-msk-clusterpolicy.html#cfn-msk-clusterpolicy-clusterarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterArn { get; set; }
    }
}