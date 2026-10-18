namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using GatewayTypes;

    public class Gateway : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfIoTSiteWiseGatewayTypesGatewayCapabilitySummaryGatewayCapabilitySummaries, IHaveGatewayName, IHaveIoTSiteWiseGatewayTypesGatewayPlatformGatewayPlatform, IHaveGatewayVersion
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
        public Union<IReadOnlyList<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary>, IReadOnlyList<Union<Humidifier.IoTSiteWise.GatewayTypes.GatewayCapabilitySummary, BaseFunction>>, BaseFunction>? GatewayCapabilitySummaries { get; set; }
        public Union<string, BaseFunction>? GatewayName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// GatewayPlatform
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-gatewayplatform
        /// Required: True
        /// UpdateType: Immutable
        /// Type: GatewayPlatform
        /// </summary>
        [Required]
        public Union<Humidifier.IoTSiteWise.GatewayTypes.GatewayPlatform, BaseFunction>? GatewayPlatform { get; set; }
        /// <summary>
        /// GatewayVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-gatewayversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? GatewayVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-gateway.html#cfn-iotsitewise-gateway-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace GatewayTypes
    {
        public class GatewayCapabilitySummary : Humidifier.Base.BaseSubResource, IHaveCapabilityNamespace, IHaveCapabilityConfiguration
        {
            /// <summary>
            /// CapabilityNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewaycapabilitysummary.html#cfn-iotsitewise-gateway-gatewaycapabilitysummary-capabilitynamespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapabilityNamespace { get; set; }
            /// <summary>
            /// CapabilityConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewaycapabilitysummary.html#cfn-iotsitewise-gateway-gatewaycapabilitysummary-capabilityconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapabilityConfiguration { get; set; }
        }

        public class GatewayPlatform : Humidifier.Base.BaseSubResource, IHaveIoTSiteWiseGatewayTypesGreengrassV2GreengrassV2, IHaveIoTSiteWiseGatewayTypesSiemensIESiemensIE
        {
            /// <summary>
            /// GreengrassV2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewayplatform.html#cfn-iotsitewise-gateway-gatewayplatform-greengrassv2
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GreengrassV2
            /// </summary>
            public Union<Humidifier.IoTSiteWise.GatewayTypes.GreengrassV2, BaseFunction>? GreengrassV2 { get; set; }
            /// <summary>
            /// SiemensIE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-gatewayplatform.html#cfn-iotsitewise-gateway-gatewayplatform-siemensie
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SiemensIE
            /// </summary>
            public Union<Humidifier.IoTSiteWise.GatewayTypes.SiemensIE, BaseFunction>? SiemensIE { get; set; }
        }

        public class GreengrassV2 : Humidifier.Base.BaseSubResource, IHaveCoreDeviceThingName, IHaveCoreDeviceOperatingSystem
        {
            /// <summary>
            /// CoreDeviceThingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-greengrassv2.html#cfn-iotsitewise-gateway-greengrassv2-coredevicethingname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CoreDeviceThingName { get; set; }
            /// <summary>
            /// CoreDeviceOperatingSystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-greengrassv2.html#cfn-iotsitewise-gateway-greengrassv2-coredeviceoperatingsystem
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CoreDeviceOperatingSystem { get; set; }
        }

        public class SiemensIE : Humidifier.Base.BaseSubResource, IHaveIotCoreThingName
        {
            /// <summary>
            /// IotCoreThingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-gateway-siemensie.html#cfn-iotsitewise-gateway-siemensie-iotcorethingname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IotCoreThingName { get; set; }
        }
    }
}