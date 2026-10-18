namespace Humidifier.IoTWireless
{
    using global::System.Collections.Generic;
    using FuotaTaskTypes;

    public class FuotaTask : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveFirmwareUpdateImage, IHaveDescription, IHaveIoTWirelessFuotaTaskTypesLoRaWANLoRaWAN, IHaveFirmwareUpdateRole, IHaveAssociateMulticastGroup, IHaveDisassociateWirelessDevice, IHaveDisassociateMulticastGroup, IHaveAssociateWirelessDevice, IHaveName
    {
        public class Attributes
        {
            public static string FuotaTaskStatus =  "FuotaTaskStatus" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTWireless.FuotaTask; }

        /// <summary>
        /// FirmwareUpdateImage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-firmwareupdateimage
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FirmwareUpdateImage { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// LoRaWAN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-lorawan
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LoRaWAN
        /// </summary>
        [Required]
        public Union<Humidifier.IoTWireless.FuotaTaskTypes.LoRaWAN, BaseFunction>? LoRaWAN { get; set; }

        /// <summary>
        /// FirmwareUpdateRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-firmwareupdaterole
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FirmwareUpdateRole { get; set; }
        /// <summary>
        /// AssociateMulticastGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-associatemulticastgroup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssociateMulticastGroup { get; set; }
        /// <summary>
        /// DisassociateWirelessDevice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-disassociatewirelessdevice
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisassociateWirelessDevice { get; set; }
        /// <summary>
        /// DisassociateMulticastGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-disassociatemulticastgroup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisassociateMulticastGroup { get; set; }
        /// <summary>
        /// AssociateWirelessDevice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-associatewirelessdevice
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssociateWirelessDevice { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-fuotatask.html#cfn-iotwireless-fuotatask-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FuotaTaskTypes
    {
        public class LoRaWAN : Humidifier.Base.BaseSubResource, IHaveRfRegion, IHaveStartTime
        {
            /// <summary>
            /// RfRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-fuotatask-lorawan.html#cfn-iotwireless-fuotatask-lorawan-rfregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RfRegion { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-fuotatask-lorawan.html#cfn-iotwireless-fuotatask-lorawan-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }
    }
}