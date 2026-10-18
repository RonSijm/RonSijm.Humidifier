namespace Humidifier.IoTSecureTunneling
{
    using global::System.Collections.Generic;
    using TunnelTypes;

    public class Tunnel : Humidifier.Base.BaseResource, IHaveTags, IHaveIoTSecureTunnelingTunnelTypesTimeoutConfigTimeoutConfig, IHaveDescription, IHaveIoTSecureTunnelingTunnelTypesDestinationConfigDestinationConfig
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TunnelArn =  "TunnelArn" ;
            public static string TunnelId =  "TunnelId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSecureTunneling.Tunnel; }
        /// <summary>
        /// TimeoutConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsecuretunneling-tunnel.html#cfn-iotsecuretunneling-tunnel-timeoutconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: TimeoutConfig
        /// </summary>
        public Union<Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig, BaseFunction>? TimeoutConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsecuretunneling-tunnel.html#cfn-iotsecuretunneling-tunnel-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// DestinationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsecuretunneling-tunnel.html#cfn-iotsecuretunneling-tunnel-destinationconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DestinationConfig
        /// </summary>
        public Union<Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig, BaseFunction>? DestinationConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsecuretunneling-tunnel.html#cfn-iotsecuretunneling-tunnel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TunnelTypes
    {
        public class DestinationConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfServices, IHaveThingName
        {
            /// <summary>
            /// Services
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsecuretunneling-tunnel-destinationconfig.html#cfn-iotsecuretunneling-tunnel-destinationconfig-services
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Services { get; set; }
            /// <summary>
            /// ThingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsecuretunneling-tunnel-destinationconfig.html#cfn-iotsecuretunneling-tunnel-destinationconfig-thingname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingName { get; set; }
        }

        public class TimeoutConfig : Humidifier.Base.BaseSubResource, IHaveMaxLifetimeTimeoutMinutes_Integer
        {
            /// <summary>
            /// MaxLifetimeTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsecuretunneling-tunnel-timeoutconfig.html#cfn-iotsecuretunneling-tunnel-timeoutconfig-maxlifetimetimeoutminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxLifetimeTimeoutMinutes { get; set; }
        }
    }
}