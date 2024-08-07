namespace Humidifier.IoTWireless
{
    using System.Collections.Generic;
    using WirelessGatewayTypes;

    public class WirelessGateway : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoTWireless::WirelessGateway";
            }
        }

        /// <summary>
        /// LastUplinkReceivedAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessgateway.html#cfn-iotwireless-wirelessgateway-lastuplinkreceivedat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LastUplinkReceivedAt { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessgateway.html#cfn-iotwireless-wirelessgateway-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// LoRaWAN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessgateway.html#cfn-iotwireless-wirelessgateway-lorawan
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LoRaWANGateway
        /// </summary>
        public LoRaWANGateway LoRaWAN { get; set; }
        /// <summary>
        /// ThingArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessgateway.html#cfn-iotwireless-wirelessgateway-thingarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ThingArn { get; set; }
        /// <summary>
        /// ThingName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessgateway.html#cfn-iotwireless-wirelessgateway-thingname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ThingName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessgateway.html#cfn-iotwireless-wirelessgateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessgateway.html#cfn-iotwireless-wirelessgateway-name
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace WirelessGatewayTypes
    {
        public class LoRaWANGateway
        {
            /// <summary>
            /// RfRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessgateway-lorawangateway.html#cfn-iotwireless-wirelessgateway-lorawangateway-rfregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RfRegion { get; set; }
            /// <summary>
            /// GatewayEui
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessgateway-lorawangateway.html#cfn-iotwireless-wirelessgateway-lorawangateway-gatewayeui
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GatewayEui { get; set; }
        }
    }
}