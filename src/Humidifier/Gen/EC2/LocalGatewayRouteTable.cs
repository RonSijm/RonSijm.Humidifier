namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class LocalGatewayRouteTable : Humidifier.Base.BaseResource, IHaveTags, IHaveMode, IHaveLocalGatewayId
    {
        public class Attributes
        {
            public static string OwnerId =  "OwnerId" ;
            public static string State =  "State" ;
            public static string OutpostArn =  "OutpostArn" ;
            public static string LocalGatewayRouteTableId =  "LocalGatewayRouteTableId" ;
            public static string LocalGatewayRouteTableArn =  "LocalGatewayRouteTableArn" ;
        }

        public override string AWSTypeName { get => AWS.EC2.LocalGatewayRouteTable; }

        /// <summary>
        /// LocalGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetable.html#cfn-ec2-localgatewayroutetable-localgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic LocalGatewayId { get; set; }
        /// <summary>
        /// Mode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetable.html#cfn-ec2-localgatewayroutetable-mode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Mode { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetable.html#cfn-ec2-localgatewayroutetable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}