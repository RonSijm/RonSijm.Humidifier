namespace Humidifier.EC2
{
    using global::System.Collections.Generic;

    public class TrafficMirrorSession : Humidifier.Base.BaseResource, IHaveTags, IHaveTrafficMirrorTargetId, IHaveDescription, IHaveOwnerId, IHaveSessionNumber_Integer, IHaveVirtualNetworkId_Integer, IHavePacketLength_Integer, IHaveNetworkInterfaceId, IHaveTrafficMirrorFilterId
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.EC2.TrafficMirrorSession; }

        /// <summary>
        /// TrafficMirrorTargetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-trafficmirrortargetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TrafficMirrorTargetId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// OwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-ownerid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OwnerId { get; set; }

        /// <summary>
        /// SessionNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-sessionnumber
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? SessionNumber { get; set; }
        /// <summary>
        /// VirtualNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-virtualnetworkid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? VirtualNetworkId { get; set; }
        /// <summary>
        /// PacketLength
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-packetlength
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? PacketLength { get; set; }

        /// <summary>
        /// NetworkInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-networkinterfaceid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }

        /// <summary>
        /// TrafficMirrorFilterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-trafficmirrorfilterid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TrafficMirrorFilterId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorsession.html#cfn-ec2-trafficmirrorsession-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}