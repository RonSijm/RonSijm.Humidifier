namespace Humidifier.IoT1Click
{
    using System.Collections.Generic;

    public class Device : Humidifier.Base.BaseResource, IHaveEnabled, IHaveDeviceId
    {
        public class Attributes
        {
            public static string DeviceId =  "DeviceId" ;
            public static string Enabled =  "Enabled" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT1Click.Device; }

        /// <summary>
        /// DeviceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-device.html#cfn-iot1click-device-deviceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeviceId { get; set; }

        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot1click-device.html#cfn-iot1click-device-enabled
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public dynamic Enabled { get; set; }
    }
}