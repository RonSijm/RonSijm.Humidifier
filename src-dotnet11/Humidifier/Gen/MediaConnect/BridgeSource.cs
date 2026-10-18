namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using BridgeSourceTypes;

    public class BridgeSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMediaConnectBridgeSourceTypesBridgeNetworkSourceNetworkSource, IHaveBridgeArn, IHaveMediaConnectBridgeSourceTypesBridgeFlowSourceFlowSource, IHaveName
    {
        public override string AWSTypeName { get => AWS.MediaConnect.BridgeSource; }
        /// <summary>
        /// NetworkSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-bridgesource.html#cfn-mediaconnect-bridgesource-networksource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BridgeNetworkSource
        /// </summary>
        public Union<Humidifier.MediaConnect.BridgeSourceTypes.BridgeNetworkSource, BaseFunction>? NetworkSource { get; set; }

        /// <summary>
        /// BridgeArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-bridgesource.html#cfn-mediaconnect-bridgesource-bridgearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? BridgeArn { get; set; }
        /// <summary>
        /// FlowSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-bridgesource.html#cfn-mediaconnect-bridgesource-flowsource
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BridgeFlowSource
        /// </summary>
        public Union<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource, BaseFunction>? FlowSource { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace BridgeSourceTypes
    {
        public class BridgeFlowSource : Humidifier.Base.BaseSubResource, IHaveMediaConnectBridgeSourceTypesVpcInterfaceAttachmentFlowVpcInterfaceAttachment, IHaveFlowArn
        {
            /// <summary>
            /// FlowVpcInterfaceAttachment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-bridgeflowsource.html#cfn-mediaconnect-bridgesource-bridgeflowsource-flowvpcinterfaceattachment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcInterfaceAttachment
            /// </summary>
            public Union<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment, BaseFunction>? FlowVpcInterfaceAttachment { get; set; }
            /// <summary>
            /// FlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-bridgeflowsource.html#cfn-mediaconnect-bridgesource-bridgeflowsource-flowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FlowArn { get; set; }
        }

        public class BridgeNetworkSource : Humidifier.Base.BaseSubResource, IHaveMediaConnectBridgeSourceTypesMulticastSourceSettingsMulticastSourceSettings, IHaveNetworkName, IHaveMulticastIp, IHavePort_Integer, IHaveProtocol
        {
            /// <summary>
            /// MulticastSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-bridgenetworksource.html#cfn-mediaconnect-bridgesource-bridgenetworksource-multicastsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MulticastSourceSettings
            /// </summary>
            public Union<Humidifier.MediaConnect.BridgeSourceTypes.MulticastSourceSettings, BaseFunction>? MulticastSourceSettings { get; set; }
            /// <summary>
            /// NetworkName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-bridgenetworksource.html#cfn-mediaconnect-bridgesource-bridgenetworksource-networkname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkName { get; set; }
            /// <summary>
            /// MulticastIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-bridgenetworksource.html#cfn-mediaconnect-bridgesource-bridgenetworksource-multicastip
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MulticastIp { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-bridgenetworksource.html#cfn-mediaconnect-bridgesource-bridgenetworksource-port
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Port { get; set; }
            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-bridgenetworksource.html#cfn-mediaconnect-bridgesource-bridgenetworksource-protocol
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Protocol { get; set; }
        }

        public class MulticastSourceSettings : Humidifier.Base.BaseSubResource, IHaveMulticastSourceIp
        {
            /// <summary>
            /// MulticastSourceIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-multicastsourcesettings.html#cfn-mediaconnect-bridgesource-multicastsourcesettings-multicastsourceip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MulticastSourceIp { get; set; }
        }

        public class VpcInterfaceAttachment : Humidifier.Base.BaseSubResource, IHaveVpcInterfaceName
        {
            /// <summary>
            /// VpcInterfaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-bridgesource-vpcinterfaceattachment.html#cfn-mediaconnect-bridgesource-vpcinterfaceattachment-vpcinterfacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcInterfaceName { get; set; }
        }
    }
}