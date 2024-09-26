namespace Humidifier.IoTWireless
{
    using System.Collections.Generic;
    using WirelessDeviceImportTaskTypes;

    public class WirelessDeviceImportTask : Humidifier.Base.BaseResource, IHaveTags, IHaveDestinationName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDate =  "CreationDate" ;
            public static string InitializedImportedDevicesCount =  "InitializedImportedDevicesCount" ;
            public static string StatusReason =  "StatusReason" ;
            public static string OnboardedImportedDevicesCount =  "OnboardedImportedDevicesCount" ;
            public static string FailedImportedDevicesCount =  "FailedImportedDevicesCount" ;
            public static string Id =  "Id" ;
            public static string PendingImportedDevicesCount =  "PendingImportedDevicesCount" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTWireless.WirelessDeviceImportTask; }

        /// <summary>
        /// DestinationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdeviceimporttask.html#cfn-iotwireless-wirelessdeviceimporttask-destinationname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DestinationName { get; set; }

        /// <summary>
        /// Sidewalk
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdeviceimporttask.html#cfn-iotwireless-wirelessdeviceimporttask-sidewalk
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Sidewalk
        /// </summary>
        [Required]
        public Humidifier.IoTWireless.WirelessDeviceImportTaskTypes.Sidewalk Sidewalk { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-wirelessdeviceimporttask.html#cfn-iotwireless-wirelessdeviceimporttask-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace WirelessDeviceImportTaskTypes
    {
        public class Sidewalk : Humidifier.Base.BaseSubResource, IHaveRole
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdeviceimporttask-sidewalk.html#cfn-iotwireless-wirelessdeviceimporttask-sidewalk-role
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// SidewalkManufacturingSn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdeviceimporttask-sidewalk.html#cfn-iotwireless-wirelessdeviceimporttask-sidewalk-sidewalkmanufacturingsn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SidewalkManufacturingSn { get; set; }
            /// <summary>
            /// DeviceCreationFile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdeviceimporttask-sidewalk.html#cfn-iotwireless-wirelessdeviceimporttask-sidewalk-devicecreationfile
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceCreationFile { get; set; }
            /// <summary>
            /// DeviceCreationFileList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-wirelessdeviceimporttask-sidewalk.html#cfn-iotwireless-wirelessdeviceimporttask-sidewalk-devicecreationfilelist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DeviceCreationFileList { get; set; }
        }
    }
}