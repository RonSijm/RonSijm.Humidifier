namespace Humidifier.StorageGateway
{
    using global::System.Collections.Generic;
    using DeviceTypes;

    public class Device : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string GatewayARN =  "GatewayARN" ;
            public static string VTLDeviceARN =  "VTLDeviceARN" ;
            public static string VTLDeviceProductIdentifier =  "VTLDeviceProductIdentifier" ;
            public static string DeviceiSCSIAttributes =  "DeviceiSCSIAttributes" ;
            public static string VTLDeviceVendor =  "VTLDeviceVendor" ;
            public static string VTLDeviceType =  "VTLDeviceType" ;
            public static string GatewayId =  "GatewayId" ;
            public static string VTLDeviceName =  "VTLDeviceName" ;
        }

        public override string AWSTypeName { get => AWS.StorageGateway.Device; }
    }

    namespace DeviceTypes
    {
        public class DeviceiSCSIAttributes : Humidifier.Base.BaseSubResource, IHaveNetworkInterfaceId
        {
            /// <summary>
            /// NetworkInterfacePort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-device-deviceiscsiattributes.html#cfn-storagegateway-device-deviceiscsiattributes-networkinterfaceport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NetworkInterfacePort { get; set; }
            /// <summary>
            /// ChapEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-device-deviceiscsiattributes.html#cfn-storagegateway-device-deviceiscsiattributes-chapenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ChapEnabled { get; set; }
            /// <summary>
            /// TargetARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-device-deviceiscsiattributes.html#cfn-storagegateway-device-deviceiscsiattributes-targetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetARN { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-storagegateway-device-deviceiscsiattributes.html#cfn-storagegateway-device-deviceiscsiattributes-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceId { get; set; }
        }
    }
}