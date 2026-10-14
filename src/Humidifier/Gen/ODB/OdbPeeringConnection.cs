namespace Humidifier.ODB
{
    using global::System.Collections.Generic;

    public class OdbPeeringConnection : Humidifier.Base.BaseResource, IHaveTags, IHaveDisplayName
    {
        public class Attributes
        {
            public static string OdbPeeringConnectionId =  "OdbPeeringConnectionId" ;
            public static string PeerNetworkCidrs =  "PeerNetworkCidrs" ;
            public static string OdbPeeringConnectionArn =  "OdbPeeringConnectionArn" ;
            public static string OdbNetworkArn =  "OdbNetworkArn" ;
            public static string PeerNetworkArn =  "PeerNetworkArn" ;
        }

        public override string AWSTypeName { get => AWS.ODB.OdbPeeringConnection; }
        /// <summary>
        /// AdditionalPeerNetworkCidrs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbpeeringconnection.html#cfn-odb-odbpeeringconnection-additionalpeernetworkcidrs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AdditionalPeerNetworkCidrs { get; set; }
        /// <summary>
        /// PeerNetworkRouteTableIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbpeeringconnection.html#cfn-odb-odbpeeringconnection-peernetworkroutetableids
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic PeerNetworkRouteTableIds { get; set; }
        /// <summary>
        /// OdbNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbpeeringconnection.html#cfn-odb-odbpeeringconnection-odbnetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OdbNetworkId { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbpeeringconnection.html#cfn-odb-odbpeeringconnection-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// PeerNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbpeeringconnection.html#cfn-odb-odbpeeringconnection-peernetworkid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PeerNetworkId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-odb-odbpeeringconnection.html#cfn-odb-odbpeeringconnection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}