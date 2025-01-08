namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class LocalGatewayRouteTableVirtualInterfaceGroupAssociation : Humidifier.Base.BaseResource, IHaveTags, IHaveLocalGatewayRouteTableId, IHaveLocalGatewayVirtualInterfaceGroupId
    {
        public class Attributes
        {
            public static string OwnerId =  "OwnerId" ;
            public static string LocalGatewayId =  "LocalGatewayId" ;
            public static string State =  "State" ;
            public static string LocalGatewayRouteTableVirtualInterfaceGroupAssociationId =  "LocalGatewayRouteTableVirtualInterfaceGroupAssociationId" ;
            public static string LocalGatewayRouteTableArn =  "LocalGatewayRouteTableArn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.LocalGatewayRouteTableVirtualInterfaceGroupAssociation; }

        /// <summary>
        /// LocalGatewayRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevirtualinterfacegroupassociation.html#cfn-ec2-localgatewayroutetablevirtualinterfacegroupassociation-localgatewayroutetableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocalGatewayRouteTableId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevirtualinterfacegroupassociation.html#cfn-ec2-localgatewayroutetablevirtualinterfacegroupassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// LocalGatewayVirtualInterfaceGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevirtualinterfacegroupassociation.html#cfn-ec2-localgatewayroutetablevirtualinterfacegroupassociation-localgatewayvirtualinterfacegroupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocalGatewayVirtualInterfaceGroupId { get; set; }
    }
}