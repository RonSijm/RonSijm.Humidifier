namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfMediaConnectGatewayTypesGatewayNetworkNetworks, IHaveStringListOfEgressCidrBlocks, IHaveName
    {
        public class Attributes
        {
            public static string GatewayArn =  "GatewayArn" ;
            public static string GatewayState =  "GatewayState" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.Gateway; }

        /// <summary>
        /// Networks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-gateway.html#cfn-mediaconnect-gateway-networks
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: GatewayNetwork
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork>, IReadOnlyList<Union<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork, BaseFunction>>, BaseFunction>? Networks { get; set; }

        /// <summary>
        /// EgressCidrBlocks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-gateway.html#cfn-mediaconnect-gateway-egresscidrblocks
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EgressCidrBlocks { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace GatewayTypes
    {
        public class GatewayNetwork : Humidifier.Base.BaseSubResource, IHaveCidrBlock, IHaveName
        {
            /// <summary>
            /// CidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-gateway-gatewaynetwork.html#cfn-mediaconnect-gateway-gatewaynetwork-cidrblock
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CidrBlock { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-gateway-gatewaynetwork.html#cfn-mediaconnect-gateway-gatewaynetwork-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}