namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGatewayRouteTable : Humidifier.Base.BaseResource, IHaveTags, IHaveTransitGatewayId
    {
        public class Attributes
        {
            public static string TransitGatewayRouteTableId =  "TransitGatewayRouteTableId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayRouteTable; }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetable.html#cfn-ec2-transitgatewayroutetable-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetable.html#cfn-ec2-transitgatewayroutetable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}