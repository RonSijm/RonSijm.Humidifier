namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class LocalGatewayRoute : Humidifier.Base.BaseResource, IHaveNetworkInterfaceId, IHaveDestinationCidrBlock, IHaveLocalGatewayRouteTableId, IHaveLocalGatewayVirtualInterfaceGroupId
    {
        public class Attributes
        {
            public static string Type =  "Type" ;
            public static string State =  "State" ;
        }

        public override string AWSTypeName { get => AWS.EC2.LocalGatewayRoute; }

        /// <summary>
        /// LocalGatewayRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroute.html#cfn-ec2-localgatewayroute-localgatewayroutetableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocalGatewayRouteTableId { get; set; }

        /// <summary>
        /// DestinationCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroute.html#cfn-ec2-localgatewayroute-destinationcidrblock
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DestinationCidrBlock { get; set; }
        /// <summary>
        /// NetworkInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroute.html#cfn-ec2-localgatewayroute-networkinterfaceid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkInterfaceId { get; set; }
        /// <summary>
        /// LocalGatewayVirtualInterfaceGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroute.html#cfn-ec2-localgatewayroute-localgatewayvirtualinterfacegroupid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LocalGatewayVirtualInterfaceGroupId { get; set; }
    }
}