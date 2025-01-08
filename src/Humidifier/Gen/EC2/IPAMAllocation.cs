namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class IPAMAllocation : Humidifier.Base.BaseResource, IHaveDescription, IHaveCidr, IHaveIpamPoolId, IHaveNetmaskLength
    {
        public class Attributes
        {
            public static string IpamPoolAllocationId =  "IpamPoolAllocationId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMAllocation; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamallocation.html#cfn-ec2-ipamallocation-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Cidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamallocation.html#cfn-ec2-ipamallocation-cidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cidr { get; set; }
        /// <summary>
        /// NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamallocation.html#cfn-ec2-ipamallocation-netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic NetmaskLength { get; set; }

        /// <summary>
        /// IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipamallocation.html#cfn-ec2-ipamallocation-ipampoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpamPoolId { get; set; }
    }
}