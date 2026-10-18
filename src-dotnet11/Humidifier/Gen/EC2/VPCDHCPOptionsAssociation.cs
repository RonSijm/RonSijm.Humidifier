namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class VPCDHCPOptionsAssociation : Humidifier.Base.BaseResource, IHaveVpcId, IHaveDhcpOptionsId
    {
        public override string AWSTypeName { get => AWS.EC2.VPCDHCPOptionsAssociation; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcdhcpoptionsassociation.html#cfn-ec2-vpcdhcpoptionsassociation-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }

        /// <summary>
        /// DhcpOptionsId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcdhcpoptionsassociation.html#cfn-ec2-vpcdhcpoptionsassociation-dhcpoptionsid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DhcpOptionsId { get; set; }
    }
}