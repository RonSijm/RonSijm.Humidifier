namespace Humidifier.Greengrass
{
    using global::System.Collections.Generic;
    using DeviceDefinitionTypes;

    public class DeviceDefinition : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGreengrassDeviceDefinitionTypesDeviceDefinitionVersionInitialVersion, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Greengrass.DeviceDefinition; }
        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-devicedefinition.html#cfn-greengrass-devicedefinition-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DeviceDefinitionVersion
        /// </summary>
        public Union<Humidifier.Greengrass.DeviceDefinitionTypes.DeviceDefinitionVersion, BaseFunction>? InitialVersion { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-devicedefinition.html#cfn-greengrass-devicedefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DeviceDefinitionTypes
    {
        public class Device : Humidifier.Base.BaseSubResource, IHaveSyncShadow_Boolean, IHaveThingArn, IHaveId, IHaveCertificateArn
        {
            /// <summary>
            /// SyncShadow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinition-device.html#cfn-greengrass-devicedefinition-device-syncshadow
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SyncShadow { get; set; }
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinition-device.html#cfn-greengrass-devicedefinition-device-thingarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingArn { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinition-device.html#cfn-greengrass-devicedefinition-device-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinition-device.html#cfn-greengrass-devicedefinition-device-certificatearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class DeviceDefinitionVersion : Humidifier.Base.BaseSubResource, IHaveListOfGreengrassDeviceDefinitionTypesDeviceDevices
        {
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-devicedefinition-devicedefinitionversion.html#cfn-greengrass-devicedefinition-devicedefinitionversion-devices
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Device
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Greengrass.DeviceDefinitionTypes.Device>, IReadOnlyList<Union<Humidifier.Greengrass.DeviceDefinitionTypes.Device, BaseFunction>>, BaseFunction>? Devices { get; set; }
        }
    }
}