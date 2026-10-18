namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using DeviceTypes;

    public class Device : Humidifier.Base.BaseResource, IHaveTags, IHaveDeviceFleetName, IHaveSageMakerDeviceTypesDeviceDevice_
    {
        public override string AWSTypeName { get => AWS.SageMaker.Device; }

        /// <summary>
        /// DeviceFleetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-device.html#cfn-sagemaker-device-devicefleetname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DeviceFleetName { get; set; }
        /// <summary>
        /// Device_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-device.html#cfn-sagemaker-device-device
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Device
        /// </summary>
        public Union<Humidifier.SageMaker.DeviceTypes.Device, BaseFunction>? Device_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-device.html#cfn-sagemaker-device-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace DeviceTypes
    {
        public class Device : Humidifier.Base.BaseSubResource, IHaveIotThingName, IHaveDescription, IHaveDeviceName
        {
            /// <summary>
            /// IotThingName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-device-device.html#cfn-sagemaker-device-device-iotthingname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IotThingName { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-device-device.html#cfn-sagemaker-device-device-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-device-device.html#cfn-sagemaker-device-device-devicename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }
    }
}