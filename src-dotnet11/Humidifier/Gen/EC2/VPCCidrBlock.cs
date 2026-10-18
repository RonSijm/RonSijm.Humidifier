namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class VPCCidrBlock : Humidifier.Base.BaseResource, IHaveIpv6NetmaskLength_Integer, IHaveIpv6IpamPoolId, IHaveVpcId, IHaveIpv4NetmaskLength_Integer, IHaveIpv6CidrBlockNetworkBorderGroup, IHaveCidrBlock, IHaveIpv6Pool, IHaveIpv4IpamPoolId, IHaveIpv6CidrBlock, IHaveAmazonProvidedIpv6CidrBlock_Boolean
    {
        public class Attributes
        {
            public static string Ipv6AddressAttribute =  "Ipv6AddressAttribute" ;
            public static string IpSource =  "IpSource" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPCCidrBlock; }
        /// <summary>
        /// Ipv6NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-ipv6netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv6NetmaskLength { get; set; }
        /// <summary>
        /// Ipv6IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-ipv6ipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6IpamPoolId { get; set; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? VpcId { get; set; }
        /// <summary>
        /// Ipv4NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-ipv4netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Ipv4NetmaskLength { get; set; }
        /// <summary>
        /// Ipv6CidrBlockNetworkBorderGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-ipv6cidrblocknetworkbordergroup
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6CidrBlockNetworkBorderGroup { get; set; }
        /// <summary>
        /// CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-cidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CidrBlock { get; set; }
        /// <summary>
        /// Ipv6Pool
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-ipv6pool
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6Pool { get; set; }
        /// <summary>
        /// Ipv4IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-ipv4ipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv4IpamPoolId { get; set; }
        /// <summary>
        /// Ipv6CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-ipv6cidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Ipv6CidrBlock { get; set; }
        /// <summary>
        /// AmazonProvidedIpv6CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpccidrblock.html#cfn-ec2-vpccidrblock-amazonprovidedipv6cidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AmazonProvidedIpv6CidrBlock { get; set; }
    }
}