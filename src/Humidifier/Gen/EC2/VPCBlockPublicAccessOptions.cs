namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class VPCBlockPublicAccessOptions : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string AccountId =  "AccountId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCBlockPublicAccessOptions; }

        /// <summary>
        /// InternetGatewayBlockMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcblockpublicaccessoptions.html#cfn-ec2-vpcblockpublicaccessoptions-internetgatewayblockmode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InternetGatewayBlockMode { get; set; }
    }
}