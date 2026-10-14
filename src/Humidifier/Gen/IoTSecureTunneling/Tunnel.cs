namespace Humidifier.IoTSecureTunneling
{
    using global::System.Collections.Generic;
    using TunnelTypes;

    public class Tunnel : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription
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
        public Humidifier.IoTSecureTunneling.TunnelTypes.TimeoutConfig TimeoutConfig { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsecuretunneling-tunnel.html#cfn-iotsecuretunneling-tunnel-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// DestinationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsecuretunneling-tunnel.html#cfn-iotsecuretunneling-tunnel-destinationconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DestinationConfig
        /// </summary>
        public Humidifier.IoTSecureTunneling.TunnelTypes.DestinationConfig DestinationConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsecuretunneling-tunnel.html#cfn-iotsecuretunneling-tunnel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace TunnelTypes
    {
        public class DestinationConfig : Humidifier.Base.BaseSubResource, IHaveThingName
        {
            /// <summary>
            /// Services
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsecuretunneling-tunnel-destinationconfig.html#cfn-iotsecuretunneling-tunnel-destinationconfig-services
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Services { get; set; }
            /// <summary>
            /// ThingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsecuretunneling-tunnel-destinationconfig.html#cfn-iotsecuretunneling-tunnel-destinationconfig-thingname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThingName { get; set; }
        }

        public class TimeoutConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxLifetimeTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsecuretunneling-tunnel-timeoutconfig.html#cfn-iotsecuretunneling-tunnel-timeoutconfig-maxlifetimetimeoutminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxLifetimeTimeoutMinutes { get; set; }
        }
    }
}