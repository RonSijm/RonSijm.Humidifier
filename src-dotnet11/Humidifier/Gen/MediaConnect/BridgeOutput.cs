namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using BridgeOutputTypes;

    public class BridgeOutput : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveBridgeArn, IHaveMediaConnectBridgeOutputTypesBridgeNetworkOutputNetworkOutput, IHaveName
    {
        public override string AWSTypeName { get => AWS.MediaConnect.BridgeOutput; }

        /// <summary>
        /// BridgeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-bridgeoutput.html#cfn-mediaconnect-bridgeoutput-bridgearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BridgeArn { get; set; }

        /// <summary>
        /// NetworkOutput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-bridgeoutput.html#cfn-mediaconnect-bridgeoutput-networkoutput
        /// Required: True
        /// UpdateType: Mutable
        /// Type: BridgeNetworkOutput
        /// </summary>
        [Required]
        public Union<Humidifier.MediaConnect.BridgeOutputTypes.BridgeNetworkOutput, BaseFunction>? NetworkOutput { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace BridgeOutputTypes
    {
        public class BridgeNetworkOutput : Humidifier.Base.BaseSubResource, IHaveNetworkName, IHavePort_Integer, IHaveIpAddress, IHaveProtocol, IHaveTtl_Integer
        {
            /// <summary>
            /// NetworkName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgeoutput-bridgenetworkoutput.html#cfn-mediaconnect-bridgeoutput-bridgenetworkoutput-networkname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkName { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgeoutput-bridgenetworkoutput.html#cfn-mediaconnect-bridgeoutput-bridgenetworkoutput-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// IpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgeoutput-bridgenetworkoutput.html#cfn-mediaconnect-bridgeoutput-bridgenetworkoutput-ipaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpAddress { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgeoutput-bridgenetworkoutput.html#cfn-mediaconnect-bridgeoutput-bridgenetworkoutput-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
            /// <summary>
            /// Ttl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgeoutput-bridgenetworkoutput.html#cfn-mediaconnect-bridgeoutput-bridgenetworkoutput-ttl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ttl { get; set; }
        }
    }
}