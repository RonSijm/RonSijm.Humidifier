namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TransitGatewayMulticastGroupMember : Humidifier.Base.BaseResource, IHaveTransitGatewayMulticastDomainId, IHaveNetworkInterfaceId, IHaveGroupIpAddress
    {
        public class Attributes
        {
            public static string GroupMember =  "GroupMember" ;
            public static string ResourceId =  "ResourceId" ;
            public static string MemberType =  "MemberType" ;
            public static string ResourceType =  "ResourceType" ;
            public static string SubnetId =  "SubnetId" ;
            public static string GroupSource =  "GroupSource" ;
            public static string TransitGatewayAttachmentId =  "TransitGatewayAttachmentId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayMulticastGroupMember; }

        /// <summary>
        /// TransitGatewayMulticastDomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastgroupmember.html#cfn-ec2-transitgatewaymulticastgroupmember-transitgatewaymulticastdomainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TransitGatewayMulticastDomainId { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastgroupmember.html#cfn-ec2-transitgatewaymulticastgroupmember-networkinterfaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }

        /// <summary>
        /// GroupIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastgroupmember.html#cfn-ec2-transitgatewaymulticastgroupmember-groupipaddress
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GroupIpAddress { get; set; }
    }
}