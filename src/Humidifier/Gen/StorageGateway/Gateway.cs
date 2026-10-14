namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string Ec2InstanceId =  "Ec2InstanceId" ;
            public static string GatewayARN =  "GatewayARN" ;
            public static string GatewayNetworkInterfaces =  "GatewayNetworkInterfaces" ;
            public static string GatewayState =  "GatewayState" ;
            public static string Ec2InstanceRegion =  "Ec2InstanceRegion" ;
            public static string EndpointType =  "EndpointType" ;
            public static string GatewayId =  "GatewayId" ;
            public static string HostEnvironment =  "HostEnvironment" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.StorageGateway.Gateway; }

        /// <summary>
        /// GatewayTimezone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-gateway.html#cfn-storagegateway-gateway-gatewaytimezone
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GatewayTimezone { get; set; }
        /// <summary>
        /// GatewayType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-gateway.html#cfn-storagegateway-gateway-gatewaytype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GatewayType { get; set; }

        /// <summary>
        /// GatewayRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-storagegateway-gateway.html#cfn-storagegateway-gateway-gatewayregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GatewayRegion { get; set; }
        public dynamic GatewayName { get => GivenName; set => GivenName = value; }
    }

    namespace GatewayTypes
    {
        public class NetworkInterface : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ipv4Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-gateway-networkinterface.html#cfn-storagegateway-gateway-networkinterface-ipv4address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ipv4Address { get; set; }
        }
    }
}