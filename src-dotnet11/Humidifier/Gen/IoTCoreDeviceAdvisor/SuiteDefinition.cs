namespace Humidifier.IoTCoreDeviceAdvisor
{
    using global::System.Collections.Generic;
    using SuiteDefinitionTypes;

    public class SuiteDefinition : Humidifier.Base.BaseResource, IHaveTags, IHaveIoTCoreDeviceAdvisorSuiteDefinitionTypesSuiteDefinitionConfigurationSuiteDefinitionConfiguration
    {
        public class Attributes
        {
            public static string SuiteDefinitionArn =  "SuiteDefinitionArn" ;
            public static string SuiteDefinitionVersion =  "SuiteDefinitionVersion" ;
            public static string SuiteDefinitionId =  "SuiteDefinitionId" ;
        }

        public override string AWSTypeName { get => AWS.IoTCoreDeviceAdvisor.SuiteDefinition; }

        /// <summary>
        /// SuiteDefinitionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotcoredeviceadvisor-suitedefinition.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: SuiteDefinitionConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration, BaseFunction>? SuiteDefinitionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotcoredeviceadvisor-suitedefinition.html#cfn-iotcoredeviceadvisor-suitedefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SuiteDefinitionTypes
    {
        public class DeviceUnderTest : Humidifier.Base.BaseSubResource, IHaveThingArn, IHaveCertificateArn
        {
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-deviceundertest.html#cfn-iotcoredeviceadvisor-suitedefinition-deviceundertest-thingarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingArn { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-deviceundertest.html#cfn-iotcoredeviceadvisor-suitedefinition-deviceundertest-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class SuiteDefinitionConfiguration : Humidifier.Base.BaseSubResource, IHaveDevicePermissionRoleArn, IHaveSuiteDefinitionName, IHaveIntendedForQualification_Boolean, IHaveListOfIoTCoreDeviceAdvisorSuiteDefinitionTypesDeviceUnderTestDevices, IHaveRootGroup
        {
            /// <summary>
            /// DevicePermissionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-devicepermissionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DevicePermissionRoleArn { get; set; }
            /// <summary>
            /// SuiteDefinitionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-suitedefinitionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SuiteDefinitionName { get; set; }
            /// <summary>
            /// IntendedForQualification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-intendedforqualification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IntendedForQualification { get; set; }
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-devices
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DeviceUnderTest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.DeviceUnderTest>, IReadOnlyList<Union<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.DeviceUnderTest, BaseFunction>>, BaseFunction>? Devices { get; set; }
            /// <summary>
            /// RootGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-rootgroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RootGroup { get; set; }
        }
    }
}