namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;

    public class Connection : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveGlobalNetworkId, IHaveDeviceId, IHaveLinkId
    {
        public class Attributes
        {
            public static string ConnectionId =  "ConnectionId" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ConnectionArn =  "ConnectionArn" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.Connection; }

        /// <summary>
        /// ConnectedDeviceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connection.html#cfn-networkmanager-connection-connecteddeviceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectedDeviceId { get; set; }
        /// <summary>
        /// ConnectedLinkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connection.html#cfn-networkmanager-connection-connectedlinkid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConnectedLinkId { get; set; }

        /// <summary>
        /// GlobalNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connection.html#cfn-networkmanager-connection-globalnetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GlobalNetworkId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connection.html#cfn-networkmanager-connection-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// DeviceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connection.html#cfn-networkmanager-connection-deviceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeviceId { get; set; }
        /// <summary>
        /// LinkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connection.html#cfn-networkmanager-connection-linkid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LinkId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-connection.html#cfn-networkmanager-connection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}