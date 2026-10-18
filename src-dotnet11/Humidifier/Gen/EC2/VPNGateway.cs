namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class VPNGateway : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHaveAmazonSideAsn_Long
    {
        public class Attributes
        {
            public static string VPNGatewayId =  "VPNGatewayId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPNGateway; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpngateway.html#cfn-ec2-vpngateway-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// AmazonSideAsn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpngateway.html#cfn-ec2-vpngateway-amazonsideasn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Long
        /// </summary>
        public Union<long, BaseFunction>? AmazonSideAsn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpngateway.html#cfn-ec2-vpngateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}