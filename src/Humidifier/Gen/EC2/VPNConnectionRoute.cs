namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class VPNConnectionRoute : Humidifier.Base.BaseResource, IHaveDestinationCidrBlock
    {
        public override string AWSTypeName { get => AWS.EC2.VPNConnectionRoute; }

        /// <summary>
        /// DestinationCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnectionroute.html#cfn-ec2-vpnconnectionroute-destinationcidrblock
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DestinationCidrBlock { get; set; }

        /// <summary>
        /// VpnConnectionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnectionroute.html#cfn-ec2-vpnconnectionroute-vpnconnectionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpnConnectionId { get; set; }
    }
}