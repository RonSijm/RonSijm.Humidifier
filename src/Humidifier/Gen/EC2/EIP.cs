namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class EIP : Humidifier.Base.BaseResource, IHaveTags, IHaveDomain, IHaveAddress, IHaveInstanceId, IHaveIpamPoolId
    {
        public class Attributes
        {
            public static string PublicIp =  "PublicIp" ;
            public static string AllocationId =  "AllocationId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.EIP; }
        /// <summary>
        /// Address
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eip.html#cfn-ec2-eip-address
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Address { get; set; }
        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eip.html#cfn-ec2-eip-instanceid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceId { get; set; }
        /// <summary>
        /// IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eip.html#cfn-ec2-eip-ipampoolid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IpamPoolId { get; set; }
        /// <summary>
        /// PublicIpv4Pool
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eip.html#cfn-ec2-eip-publicipv4pool
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PublicIpv4Pool { get; set; }
        /// <summary>
        /// TransferAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eip.html#cfn-ec2-eip-transferaddress
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransferAddress { get; set; }
        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eip.html#cfn-ec2-eip-domain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Domain { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eip.html#cfn-ec2-eip-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// NetworkBorderGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-eip.html#cfn-ec2-eip-networkbordergroup
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkBorderGroup { get; set; }
    }
}