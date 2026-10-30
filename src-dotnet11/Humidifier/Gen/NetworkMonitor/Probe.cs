namespace Humidifier.NetworkMonitor
{
    using global::System.Collections.Generic;

    public class Probe : Humidifier.Base.BaseResource, IHaveTags, IHaveDestination, IHaveSourceArn, IHaveMonitorName, IHavePacketSize_Integer, IHaveProtocol, IHaveDestinationPort_Integer
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string VpcId =  "VpcId" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string AddressFamily =  "AddressFamily" ;
            public static string ProbeId =  "ProbeId" ;
            public static string ProbeArn =  "ProbeArn" ;
        }

        public override string AWSTypeName { get => AWS.NetworkMonitor.Probe; }

        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-probe.html#cfn-networkmonitor-probe-destination
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Destination { get; set; }

        /// <summary>
        /// SourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-probe.html#cfn-networkmonitor-probe-sourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SourceArn { get; set; }

        /// <summary>
        /// MonitorName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-probe.html#cfn-networkmonitor-probe-monitorname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MonitorName { get; set; }
        /// <summary>
        /// PacketSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-probe.html#cfn-networkmonitor-probe-packetsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? PacketSize { get; set; }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-probe.html#cfn-networkmonitor-probe-protocol
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Protocol { get; set; }
        /// <summary>
        /// DestinationPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-probe.html#cfn-networkmonitor-probe-destinationport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DestinationPort { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-probe.html#cfn-networkmonitor-probe-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}