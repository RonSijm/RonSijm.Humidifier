namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class VPC : Humidifier.Base.BaseResource, IHaveTags, IHaveCidrBlock, IHaveIpv4NetmaskLength, IHaveIpv4IpamPoolId
    {
        public class Attributes
        {
            public static string VpcId =  "VpcId" ;
            public static string CidrBlockAssociations =  "CidrBlockAssociations" ;
            public static string CidrBlock =  "CidrBlock" ;
            public static string DefaultNetworkAcl =  "DefaultNetworkAcl" ;
            public static string Ipv6CidrBlocks =  "Ipv6CidrBlocks" ;
            public static string DefaultSecurityGroup =  "DefaultSecurityGroup" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPC; }
        /// <summary>
        /// InstanceTenancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-instancetenancy
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceTenancy { get; set; }
        /// <summary>
        /// Ipv4NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-ipv4netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Ipv4NetmaskLength { get; set; }
        /// <summary>
        /// CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-cidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CidrBlock { get; set; }
        /// <summary>
        /// Ipv4IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-ipv4ipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Ipv4IpamPoolId { get; set; }
        /// <summary>
        /// EnableDnsSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-enablednssupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableDnsSupport { get; set; }
        /// <summary>
        /// EnableDnsHostnames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-enablednshostnames
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableDnsHostnames { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-ec2-vpc-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}