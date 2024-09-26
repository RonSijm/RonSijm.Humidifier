namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class IPAMPoolCidr : Humidifier.Base.BaseResource, IHaveCidr
    {
        public class Attributes
        {
            public static string IpamPoolCidrId =  "IpamPoolCidrId" ;
            public static string State =  "State" ;
        }

        public override string AWSTypeName { get => AWS.EC2.IPAMPoolCidr; }
        /// <summary>
        /// Cidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampoolcidr.html#cfn-ec2-ipampoolcidr-cidr
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cidr { get; set; }
        /// <summary>
        /// NetmaskLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampoolcidr.html#cfn-ec2-ipampoolcidr-netmasklength
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic NetmaskLength { get; set; }

        /// <summary>
        /// IpamPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-ipampoolcidr.html#cfn-ec2-ipampoolcidr-ipampoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic IpamPoolId { get; set; }
    }
}