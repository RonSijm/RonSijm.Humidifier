namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using DeviceDefinitionVersionTypes;

    public class DeviceDefinitionVersion : Humidifier.Base.BaseResource, IHaveDeviceDefinitionId, IHaveListOfGreengrassDeviceDefinitionVersionTypesDeviceDevices
    {
        public override string AWSTypeName { get => AWS.Greengrass.DeviceDefinitionVersion; }

        /// <summary>
        /// DeviceDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-devicedefinitionversion.html#cfn-greengrass-devicedefinitionversion-devicedefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DeviceDefinitionId { get; set; }

        /// <summary>
        /// Devices
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-devicedefinitionversion.html#cfn-greengrass-devicedefinitionversion-devices
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Device
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device>, IReadOnlyList<Union<Humidifier.Greengrass.DeviceDefinitionVersionTypes.Device, BaseFunction>>, BaseFunction>? Devices { get; set; }
    }

    namespace DeviceDefinitionVersionTypes
    {
        public class Device : Humidifier.Base.BaseSubResource, IHaveSyncShadow_Boolean, IHaveThingArn, IHaveId, IHaveCertificateArn
        {
            /// <summary>
            /// SyncShadow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinitionversion-device.html#cfn-greengrass-devicedefinitionversion-device-syncshadow
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SyncShadow { get; set; }
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinitionversion-device.html#cfn-greengrass-devicedefinitionversion-device-thingarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingArn { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinitionversion-device.html#cfn-greengrass-devicedefinitionversion-device-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinitionversion-device.html#cfn-greengrass-devicedefinitionversion-device-certificatearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }
    }
}