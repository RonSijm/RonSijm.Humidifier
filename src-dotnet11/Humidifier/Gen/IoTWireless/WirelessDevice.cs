namespace Humidifier.IoTWireless
{
    using global::System.Collections.Generic;
    using WirelessDeviceTypes;

    public class WirelessDevice : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveLastUplinkReceivedAt, IHavePositioning, IHaveType, IHaveDescription, IHaveIoTWirelessWirelessDeviceTypesLoRaWANDeviceLoRaWAN, IHaveDestinationName, IHaveThingArn, IHaveName
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string ThingName =  "ThingName" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTWireless.WirelessDevice; }
        /// <summary>
        /// LastUplinkReceivedAt
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html#cfn-iotwireless-wirelessdevice-lastuplinkreceivedat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LastUplinkReceivedAt { get; set; }
        /// <summary>
        /// Positioning
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html#cfn-iotwireless-wirelessdevice-positioning
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Positioning { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html#cfn-iotwireless-wirelessdevice-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html#cfn-iotwireless-wirelessdevice-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// LoRaWAN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html#cfn-iotwireless-wirelessdevice-lorawan
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoRaWANDevice
        /// </summary>
        public Union<Humidifier.IoTWireless.WirelessDeviceTypes.LoRaWANDevice, BaseFunction>? LoRaWAN { get; set; }

        /// <summary>
        /// DestinationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html#cfn-iotwireless-wirelessdevice-destinationname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DestinationName { get; set; }
        /// <summary>
        /// ThingArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html#cfn-iotwireless-wirelessdevice-thingarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ThingArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdevice.html#cfn-iotwireless-wirelessdevice-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace WirelessDeviceTypes
    {
        public class AbpV10x : Humidifier.Base.BaseSubResource, IHaveIoTWirelessWirelessDeviceTypesSessionKeysAbpV10xSessionKeys, IHaveDevAddr
        {
            /// <summary>
            /// SessionKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-abpv10x.html#cfn-iotwireless-wirelessdevice-abpv10x-sessionkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SessionKeysAbpV10x
            /// </summary>
            public Union<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV10x, BaseFunction>? SessionKeys { get; set; }
            /// <summary>
            /// DevAddr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-abpv10x.html#cfn-iotwireless-wirelessdevice-abpv10x-devaddr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DevAddr { get; set; }
        }

        public class AbpV11 : Humidifier.Base.BaseSubResource, IHaveIoTWirelessWirelessDeviceTypesSessionKeysAbpV11SessionKeys, IHaveDevAddr
        {
            /// <summary>
            /// SessionKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-abpv11.html#cfn-iotwireless-wirelessdevice-abpv11-sessionkeys
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SessionKeysAbpV11
            /// </summary>
            public Union<Humidifier.IoTWireless.WirelessDeviceTypes.SessionKeysAbpV11, BaseFunction>? SessionKeys { get; set; }
            /// <summary>
            /// DevAddr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-abpv11.html#cfn-iotwireless-wirelessdevice-abpv11-devaddr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DevAddr { get; set; }
        }

        public class Application : Humidifier.Base.BaseSubResource, IHaveType, IHaveFPort_Integer, IHaveDestinationName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-application.html#cfn-iotwireless-wirelessdevice-application-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// FPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-application.html#cfn-iotwireless-wirelessdevice-application-fport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FPort { get; set; }
            /// <summary>
            /// DestinationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-application.html#cfn-iotwireless-wirelessdevice-application-destinationname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationName { get; set; }
        }

        public class FPorts : Humidifier.Base.BaseSubResource, IHaveListOfIoTWirelessWirelessDeviceTypesApplicationApplications
        {
            /// <summary>
            /// Applications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-fports.html#cfn-iotwireless-wirelessdevice-fports-applications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Application
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTWireless.WirelessDeviceTypes.Application>, IReadOnlyList<Union<Humidifier.IoTWireless.WirelessDeviceTypes.Application, BaseFunction>>, BaseFunction>? Applications { get; set; }
        }

        public class LoRaWANDevice : Humidifier.Base.BaseSubResource, IHaveIoTWirelessWirelessDeviceTypesAbpV10xAbpV10x, IHaveIoTWirelessWirelessDeviceTypesFPortsFPorts, IHaveIoTWirelessWirelessDeviceTypesOtaaV11OtaaV11, IHaveIoTWirelessWirelessDeviceTypesAbpV11AbpV11, IHaveDeviceProfileId, IHaveDevEui, IHaveIoTWirelessWirelessDeviceTypesOtaaV10xOtaaV10x, IHaveServiceProfileId
        {
            /// <summary>
            /// AbpV10x
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html#cfn-iotwireless-wirelessdevice-lorawandevice-abpv10x
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbpV10x
            /// </summary>
            public Union<Humidifier.IoTWireless.WirelessDeviceTypes.AbpV10x, BaseFunction>? AbpV10x { get; set; }
            /// <summary>
            /// FPorts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html#cfn-iotwireless-wirelessdevice-lorawandevice-fports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FPorts
            /// </summary>
            public Union<Humidifier.IoTWireless.WirelessDeviceTypes.FPorts, BaseFunction>? FPorts { get; set; }
            /// <summary>
            /// OtaaV11
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html#cfn-iotwireless-wirelessdevice-lorawandevice-otaav11
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OtaaV11
            /// </summary>
            public Union<Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV11, BaseFunction>? OtaaV11 { get; set; }
            /// <summary>
            /// AbpV11
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html#cfn-iotwireless-wirelessdevice-lorawandevice-abpv11
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbpV11
            /// </summary>
            public Union<Humidifier.IoTWireless.WirelessDeviceTypes.AbpV11, BaseFunction>? AbpV11 { get; set; }
            /// <summary>
            /// DeviceProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html#cfn-iotwireless-wirelessdevice-lorawandevice-deviceprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceProfileId { get; set; }
            /// <summary>
            /// DevEui
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html#cfn-iotwireless-wirelessdevice-lorawandevice-deveui
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DevEui { get; set; }
            /// <summary>
            /// OtaaV10x
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html#cfn-iotwireless-wirelessdevice-lorawandevice-otaav10x
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OtaaV10x
            /// </summary>
            public Union<Humidifier.IoTWireless.WirelessDeviceTypes.OtaaV10x, BaseFunction>? OtaaV10x { get; set; }
            /// <summary>
            /// ServiceProfileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-lorawandevice.html#cfn-iotwireless-wirelessdevice-lorawandevice-serviceprofileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceProfileId { get; set; }
        }

        public class OtaaV10x : Humidifier.Base.BaseSubResource, IHaveAppEui, IHaveAppKey
        {
            /// <summary>
            /// AppEui
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-otaav10x.html#cfn-iotwireless-wirelessdevice-otaav10x-appeui
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppEui { get; set; }
            /// <summary>
            /// AppKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-otaav10x.html#cfn-iotwireless-wirelessdevice-otaav10x-appkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppKey { get; set; }
        }

        public class OtaaV11 : Humidifier.Base.BaseSubResource, IHaveNwkKey, IHaveAppKey, IHaveJoinEui
        {
            /// <summary>
            /// NwkKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-otaav11.html#cfn-iotwireless-wirelessdevice-otaav11-nwkkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NwkKey { get; set; }
            /// <summary>
            /// AppKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-otaav11.html#cfn-iotwireless-wirelessdevice-otaav11-appkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppKey { get; set; }
            /// <summary>
            /// JoinEui
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-otaav11.html#cfn-iotwireless-wirelessdevice-otaav11-joineui
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JoinEui { get; set; }
        }

        public class SessionKeysAbpV10x : Humidifier.Base.BaseSubResource, IHaveAppSKey, IHaveNwkSKey
        {
            /// <summary>
            /// AppSKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv10x.html#cfn-iotwireless-wirelessdevice-sessionkeysabpv10x-appskey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppSKey { get; set; }
            /// <summary>
            /// NwkSKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv10x.html#cfn-iotwireless-wirelessdevice-sessionkeysabpv10x-nwkskey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NwkSKey { get; set; }
        }

        public class SessionKeysAbpV11 : Humidifier.Base.BaseSubResource, IHaveFNwkSIntKey, IHaveAppSKey, IHaveSNwkSIntKey, IHaveNwkSEncKey
        {
            /// <summary>
            /// FNwkSIntKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv11.html#cfn-iotwireless-wirelessdevice-sessionkeysabpv11-fnwksintkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FNwkSIntKey { get; set; }
            /// <summary>
            /// AppSKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv11.html#cfn-iotwireless-wirelessdevice-sessionkeysabpv11-appskey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppSKey { get; set; }
            /// <summary>
            /// SNwkSIntKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv11.html#cfn-iotwireless-wirelessdevice-sessionkeysabpv11-snwksintkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SNwkSIntKey { get; set; }
            /// <summary>
            /// NwkSEncKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdevice-sessionkeysabpv11.html#cfn-iotwireless-wirelessdevice-sessionkeysabpv11-nwksenckey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NwkSEncKey { get; set; }
        }
    }
}