namespace Humidifier.IoTSiteWise
{
    using System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public class Attributes
        {
            public static string GatewayId =  "GatewayId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Gateway; }
        /// <summary>
        /// GatewayCapabilitySummaries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-gatewaycapabilitysummaries
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GatewayCapabilitySummary
        /// </summary>
        public List<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary> GatewayCapabilitySummaries { get; set; }
        public dynamic GatewayName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// GatewayPlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-gatewayplatform
        /// Required: True
        /// UpdateType: Immutable
        /// Type: GatewayPlatform
        /// </summary>
        [Required]
        public Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform GatewayPlatform { get; set; }
        /// <summary>
        /// GatewayVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-gatewayversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GatewayVersion { get; set; }
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
        public class GatewayCapabilitySummary : Humidifier.Base.BaseSubResource
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

        public class GatewayPlatform : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GreengrassV2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewayplatform.html#cfn-iotsitewise-gateway-gatewayplatform-greengrassv2
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GreengrassV2
            /// </summary>
            public Humidifier.IoTSiteWise.GatewayTypes.GreengrassV2 GreengrassV2 { get; set; }
            /// <summary>
            /// SiemensIE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewayplatform.html#cfn-iotsitewise-gateway-gatewayplatform-siemensie
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SiemensIE
            /// </summary>
            public Humidifier.IoTSiteWise.GatewayTypes.SiemensIE SiemensIE { get; set; }
        }

        public class GreengrassV2 : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CoreDeviceThingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-greengrassv2.html#cfn-iotsitewise-gateway-greengrassv2-coredevicethingname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CoreDeviceThingName { get; set; }
            /// <summary>
            /// CoreDeviceOperatingSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-greengrassv2.html#cfn-iotsitewise-gateway-greengrassv2-coredeviceoperatingsystem
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CoreDeviceOperatingSystem { get; set; }
        }

        public class SiemensIE : Humidifier.Base.BaseSubResource
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