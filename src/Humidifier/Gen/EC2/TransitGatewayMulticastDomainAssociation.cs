namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGatewayMulticastDomainAssociation : Humidifier.Base.BaseResource, IHaveSubnetId, IHaveTransitGatewayAttachmentId, IHaveTransitGatewayMulticastDomainId
    {
        public class Attributes
        {
            public static string ResourceId =  "ResourceId" ;
            public static string State =  "State" ;
            public static string ResourceType =  "ResourceType" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayMulticastDomainAssociation; }

        /// <summary>
        /// TransitGatewayMulticastDomainId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastdomainassociation.html#cfn-ec2-transitgatewaymulticastdomainassociation-transitgatewaymulticastdomainid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayMulticastDomainId { get; set; }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastdomainassociation.html#cfn-ec2-transitgatewaymulticastdomainassociation-subnetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SubnetId { get; set; }

        /// <summary>
        /// TransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewaymulticastdomainassociation.html#cfn-ec2-transitgatewaymulticastdomainassociation-transitgatewayattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayAttachmentId { get; set; }
    }
}