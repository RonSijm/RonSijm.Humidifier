namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class SubnetCidrBlock : Humidifier.Base.BaseResource, IHaveIpv6NetmaskLength_Integer, IHaveIpv6IpamPoolId, IHaveSubnetId, IHaveIpv6CidrBlock
    {
        public class Attributes
        {
            public static string Ipv6AddressAttribute =  "Ipv6AddressAttribute" ;
            public static string IpSource =  "IpSource" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.SubnetCidrBlock; }
        /// <summary>
        /// Ipv6NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html#cfn-ec2-subnetcidrblock-ipv6netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv6NetmaskLength { get; set; }
        /// <summary>
        /// Ipv6IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html#cfn-ec2-subnetcidrblock-ipv6ipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6IpamPoolId { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html#cfn-ec2-subnetcidrblock-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SubnetId { get; set; }
        /// <summary>
        /// Ipv6CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnetcidrblock.html#cfn-ec2-subnetcidrblock-ipv6cidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6CidrBlock { get; set; }
    }
}