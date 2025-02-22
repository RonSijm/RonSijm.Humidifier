namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class ClientVpnRoute : Humidifier.Base.BaseResource, IHaveDescription, IHaveDestinationCidrBlock, IHaveClientVpnEndpointId
    {
        public override string AWSTypeName { get => AWS.EC2.ClientVpnRoute; }

        /// <summary>
        /// ClientVpnEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnroute.html#cfn-ec2-clientvpnroute-clientvpnendpointid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClientVpnEndpointId { get; set; }

        /// <summary>
        /// TargetVpcSubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnroute.html#cfn-ec2-clientvpnroute-targetvpcsubnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TargetVpcSubnetId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnroute.html#cfn-ec2-clientvpnroute-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DestinationCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnroute.html#cfn-ec2-clientvpnroute-destinationcidrblock
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DestinationCidrBlock { get; set; }
    }
}