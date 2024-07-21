namespace Humidifier.IoTSiteWise
{
    using System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string GatewayId =  "GatewayId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoTSiteWise::Gateway";
            }
        }

        /// <summary>
        /// GatewayCapabilitySummaries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-gatewaycapabilitysummaries
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GatewayCapabilitySummary
        /// </summary>
        public List<GatewayCapabilitySummary> GatewayCapabilitySummaries { get; set; }
        /// <summary>
        /// GatewayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-gatewayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GatewayName { get; set; }
        /// <summary>
        /// GatewayPlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-gatewayplatform
        /// Required: True
        /// UpdateType: Immutable
        /// Type: GatewayPlatform
        /// </summary>
        public GatewayPlatform GatewayPlatform { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace GatewayTypes
    {
        public class GatewayCapabilitySummary
        {
            /// <summary>
            /// CapabilityNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewaycapabilitysummary.html#cfn-iotsitewise-gateway-gatewaycapabilitysummary-capabilitynamespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapabilityNamespace { get; set; }
            /// <summary>
            /// CapabilityConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewaycapabilitysummary.html#cfn-iotsitewise-gateway-gatewaycapabilitysummary-capabilityconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapabilityConfiguration { get; set; }
        }

        public class GatewayPlatform
        {
            /// <summary>
            /// GreengrassV2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewayplatform.html#cfn-iotsitewise-gateway-gatewayplatform-greengrassv2
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GreengrassV2
            /// </summary>
            public GreengrassV2 GreengrassV2 { get; set; }
            /// <summary>
            /// Greengrass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewayplatform.html#cfn-iotsitewise-gateway-gatewayplatform-greengrass
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Greengrass
            /// </summary>
            public Greengrass Greengrass { get; set; }
            /// <summary>
            /// SiemensIE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewayplatform.html#cfn-iotsitewise-gateway-gatewayplatform-siemensie
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SiemensIE
            /// </summary>
            public SiemensIE SiemensIE { get; set; }
        }

        public class Greengrass
        {
            /// <summary>
            /// GroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-greengrass.html#cfn-iotsitewise-gateway-greengrass-grouparn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupArn { get; set; }
        }

        public class GreengrassV2
        {
            /// <summary>
            /// CoreDeviceThingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-greengrassv2.html#cfn-iotsitewise-gateway-greengrassv2-coredevicethingname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CoreDeviceThingName { get; set; }
        }

        public class SiemensIE
        {
            /// <summary>
            /// IotCoreThingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-siemensie.html#cfn-iotsitewise-gateway-siemensie-iotcorethingname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IotCoreThingName { get; set; }
        }
    }
}