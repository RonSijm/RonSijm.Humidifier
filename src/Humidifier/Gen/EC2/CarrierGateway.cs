namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class CarrierGateway : Humidifier.Base.BaseResource, IHaveTags, IHaveVpcId
    {
        public class Attributes
        {
            public static string OwnerId =  "OwnerId" ;
            public static string State =  "State" ;
            public static string CarrierGatewayId =  "CarrierGatewayId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.CarrierGateway; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-carriergateway.html#cfn-ec2-carriergateway-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpcId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-carriergateway.html#cfn-ec2-carriergateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}