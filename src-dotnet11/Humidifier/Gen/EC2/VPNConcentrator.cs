namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class VPNConcentrator : Humidifier.Base.BaseResource, IHaveTags, IHaveTransitGatewayId, IHaveType
    {
        public class Attributes
        {
            public static string VpnConcentratorId =  "VpnConcentratorId" ;
            public static string TransitGatewayAttachmentId =  "TransitGatewayAttachmentId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.VPNConcentrator; }
        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconcentrator.html#cfn-ec2-vpnconcentrator-transitgatewayid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TransitGatewayId { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconcentrator.html#cfn-ec2-vpnconcentrator-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpnconcentrator.html#cfn-ec2-vpnconcentrator-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}