namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class VPNConnectionRoute : Humidifier.Base.BaseResource, IHaveDestinationCidrBlock, IHaveVpnConnectionId
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
        public Union<string, BaseFunction>? DestinationCidrBlock { get; set; }

        /// <summary>
        /// VpnConnectionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconnectionroute.html#cfn-ec2-vpnconnectionroute-vpnconnectionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpnConnectionId { get; set; }
    }
}