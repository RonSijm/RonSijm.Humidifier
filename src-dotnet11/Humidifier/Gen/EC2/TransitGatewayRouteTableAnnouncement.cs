namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TransitGatewayRouteTableAnnouncement : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string TransitGatewayRouteTableAnnouncementId =  "TransitGatewayRouteTableAnnouncementId" ;
            public static string TransitGatewayRouteTableId =  "TransitGatewayRouteTableId" ;
            public static string TransitGatewayId =  "TransitGatewayId" ;
            public static string CoreNetworkId =  "CoreNetworkId" ;
            public static string PeerTransitGatewayId =  "PeerTransitGatewayId" ;
            public static string PeerCoreNetworkId =  "PeerCoreNetworkId" ;
            public static string State =  "State" ;
            public static string PeeringAttachmentId =  "PeeringAttachmentId" ;
            public static string AnnouncementDirection =  "AnnouncementDirection" ;
            public static string CreationTime =  "CreationTime" ;
            public static string Arn =  "Arn" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TransitGatewayRouteTableAnnouncement; }
    }
}