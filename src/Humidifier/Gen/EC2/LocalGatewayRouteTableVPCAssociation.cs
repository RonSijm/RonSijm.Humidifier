namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class LocalGatewayRouteTableVPCAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveVpcId, IHaveLocalGatewayRouteTableId
    {
        public class Attributes
        {
            public static string LocalGatewayId =  "LocalGatewayId" ;
            public static string State =  "State" ;
            public static string LocalGatewayRouteTableVpcAssociationId =  "LocalGatewayRouteTableVpcAssociationId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.LocalGatewayRouteTableVPCAssociation; }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevpcassociation.html#cfn-ec2-localgatewayroutetablevpcassociation-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VpcId { get; set; }

        /// <summary>
        /// LocalGatewayRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevpcassociation.html#cfn-ec2-localgatewayroutetablevpcassociation-localgatewayroutetableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocalGatewayRouteTableId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevpcassociation.html#cfn-ec2-localgatewayroutetablevpcassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}