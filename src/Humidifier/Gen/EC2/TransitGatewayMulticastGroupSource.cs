namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGatewayMulticastGroupSource : Humidifier.Base.BaseResource, IHaveNetworkInterfaceId, IHaveTransitGatewayMulticastDomainId, IHaveGroupIpAddress
    {
        public class Attributes
        {
            public static string GroupMember =  "GroupMember" ;
            public static string ResourceId =  "ResourceId" ;
            public static string SourceType =  "SourceType" ;
            public static string ResourceType =  "ResourceType" ;
            public static string SubnetId =  "SubnetId" ;
            public static string GroupSource =  "GroupSource" ;
            public static string TransitGatewayAttachmentId =  "TransitGatewayAttachmentId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayMulticastGroupSource; }

        /// <summary>
        /// TransitGatewayMulticastDomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastgroupsource.html#cfn-ec2-transitgatewaymulticastgroupsource-transitgatewaymulticastdomainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayMulticastDomainId { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastgroupsource.html#cfn-ec2-transitgatewaymulticastgroupsource-networkinterfaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic NetworkInterfaceId { get; set; }

        /// <summary>
        /// GroupIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastgroupsource.html#cfn-ec2-transitgatewaymulticastgroupsource-groupipaddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GroupIpAddress { get; set; }
    }
}