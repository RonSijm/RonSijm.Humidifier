namespace Humidifier.IoTWireless
{
    using global::System.Collections.Generic;
    using MulticastGroupTypes;

    public class MulticastGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveIoTWirelessMulticastGroupTypesLoRaWANLoRaWAN, IHaveDisassociateWirelessDevice, IHaveAssociateWirelessDevice, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoTWireless.MulticastGroup; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-multicastgroup.html#cfn-iotwireless-multicastgroup-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// LoRaWAN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-multicastgroup.html#cfn-iotwireless-multicastgroup-lorawan
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LoRaWAN
        /// </summary>
        [Required]
        public Union<Humidifier.IoTWireless.MulticastGroupTypes.LoRaWAN, BaseFunction>? LoRaWAN { get; set; }
        /// <summary>
        /// DisassociateWirelessDevice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-multicastgroup.html#cfn-iotwireless-multicastgroup-disassociatewirelessdevice
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisassociateWirelessDevice { get; set; }
        /// <summary>
        /// AssociateWirelessDevice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-multicastgroup.html#cfn-iotwireless-multicastgroup-associatewirelessdevice
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssociateWirelessDevice { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotwireless-multicastgroup.html#cfn-iotwireless-multicastgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace MulticastGroupTypes
    {
        public class LoRaWAN : Humidifier.Base.BaseSubResource, IHaveNumberOfDevicesRequested_Integer, IHaveNumberOfDevicesInGroup_Integer, IHaveRfRegion, IHaveDlClass
        {
            /// <summary>
            /// NumberOfDevicesRequested
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-multicastgroup-lorawan.html#cfn-iotwireless-multicastgroup-lorawan-numberofdevicesrequested
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfDevicesRequested { get; set; }
            /// <summary>
            /// NumberOfDevicesInGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-multicastgroup-lorawan.html#cfn-iotwireless-multicastgroup-lorawan-numberofdevicesingroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfDevicesInGroup { get; set; }
            /// <summary>
            /// RfRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-multicastgroup-lorawan.html#cfn-iotwireless-multicastgroup-lorawan-rfregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RfRegion { get; set; }
            /// <summary>
            /// DlClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotwireless-multicastgroup-lorawan.html#cfn-iotwireless-multicastgroup-lorawan-dlclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DlClass { get; set; }
        }
    }
}