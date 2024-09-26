namespace Humidifier.MediaConnect
{
    using System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
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
        public List<Humidifier.MediaConnect.GatewayTypes.GatewayNetwork> Networks { get; set; }

        /// <summary>
        /// EgressCidrBlocks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-gateway.html#cfn-mediaconnect-gateway-egresscidrblocks
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic EgressCidrBlocks { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace GatewayTypes
    {
        public class GatewayNetwork : Humidifier.Base.BaseSubResource, IHaveName, IHaveCidrBlock
        {
            /// <summary>
            /// CidrBlock
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-gateway-gatewaynetwork.html#cfn-mediaconnect-gateway-gatewaynetwork-cidrblock
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CidrBlock { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-gateway-gatewaynetwork.html#cfn-mediaconnect-gateway-gatewaynetwork-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }
    }
}