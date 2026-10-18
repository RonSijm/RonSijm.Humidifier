namespace Humidifier.IoTWireless
{
    using global::System.Collections.Generic;
    using NetworkAnalyzerConfigurationTypes;

    public class NetworkAnalyzerConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveIoTWirelessNetworkAnalyzerConfigurationTypesTraceContentTraceContent, IHaveStringListOfWirelessGateways, IHaveStringListOfWirelessDevices, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTWireless.NetworkAnalyzerConfiguration; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-networkanalyzerconfiguration.html#cfn-iotwireless-networkanalyzerconfiguration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// TraceContent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-networkanalyzerconfiguration.html#cfn-iotwireless-networkanalyzerconfiguration-tracecontent
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TraceContent
        /// </summary>
        public Union<Humidifier.IoTWireless.NetworkAnalyzerConfigurationTypes.TraceContent, BaseFunction>? TraceContent { get; set; }
        /// <summary>
        /// WirelessGateways
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-networkanalyzerconfiguration.html#cfn-iotwireless-networkanalyzerconfiguration-wirelessgateways
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WirelessGateways { get; set; }
        /// <summary>
        /// WirelessDevices
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-networkanalyzerconfiguration.html#cfn-iotwireless-networkanalyzerconfiguration-wirelessdevices
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WirelessDevices { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-networkanalyzerconfiguration.html#cfn-iotwireless-networkanalyzerconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace NetworkAnalyzerConfigurationTypes
    {
        public class TraceContent : Humidifier.Base.BaseSubResource, IHaveWirelessDeviceFrameInfo, IHaveLogLevel
        {
            /// <summary>
            /// WirelessDeviceFrameInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-networkanalyzerconfiguration-tracecontent.html#cfn-iotwireless-networkanalyzerconfiguration-tracecontent-wirelessdeviceframeinfo
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WirelessDeviceFrameInfo { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-networkanalyzerconfiguration-tracecontent.html#cfn-iotwireless-networkanalyzerconfiguration-tracecontent-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogLevel { get; set; }
        }
    }
}