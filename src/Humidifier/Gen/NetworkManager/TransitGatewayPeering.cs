namespace Humidifier.NetworkManager
{
    using System.Collections.Generic;

    public class TransitGatewayPeering : Humidifier.Base.BaseResource, IHaveTags, IHaveCoreNetworkId, IHaveTransitGatewayArn
    {
        public class Attributes
        {
            public static string ResourceArn =  "ResourceArn" ;
            public static string PeeringType =  "PeeringType" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string PeeringId =  "PeeringId" ;
            public static string TransitGatewayPeeringAttachmentId =  "TransitGatewayPeeringAttachmentId" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
            public static string CoreNetworkArn =  "CoreNetworkArn" ;
            public static string EdgeLocation =  "EdgeLocation" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.TransitGatewayPeering; }

        /// <summary>
        /// CoreNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewaypeering.html#cfn-networkmanager-transitgatewaypeering-corenetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CoreNetworkId { get; set; }

        /// <summary>
        /// TransitGatewayArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewaypeering.html#cfn-networkmanager-transitgatewaypeering-transitgatewayarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TransitGatewayArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-transitgatewaypeering.html#cfn-networkmanager-transitgatewaypeering-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}