namespace Humidifier.IoTCoreDeviceAdvisor
{
    using System.Collections.Generic;
    using SuiteDefinitionTypes;

    public class SuiteDefinition : Humidifier.Base.BaseResource, IHaveTags
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
        public Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.SuiteDefinitionConfiguration SuiteDefinitionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotcoredeviceadvisor-suitedefinition.html#cfn-iotcoredeviceadvisor-suitedefinition-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace SuiteDefinitionTypes
    {
        public class DeviceUnderTest : Humidifier.Base.BaseSubResource, IHaveCertificateArn, IHaveThingArn
        {
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-deviceundertest.html#cfn-iotcoredeviceadvisor-suitedefinition-deviceundertest-thingarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThingArn { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-deviceundertest.html#cfn-iotcoredeviceadvisor-suitedefinition-deviceundertest-certificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class SuiteDefinitionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DevicePermissionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-devicepermissionrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DevicePermissionRoleArn { get; set; }
            /// <summary>
            /// SuiteDefinitionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-suitedefinitionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SuiteDefinitionName { get; set; }
            /// <summary>
            /// IntendedForQualification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-intendedforqualification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IntendedForQualification { get; set; }
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-devices
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DeviceUnderTest
            /// </summary>
            public List<Humidifier.IoTCoreDeviceAdvisor.SuiteDefinitionTypes.DeviceUnderTest> Devices { get; set; }
            /// <summary>
            /// RootGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration.html#cfn-iotcoredeviceadvisor-suitedefinition-suitedefinitionconfiguration-rootgroup
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RootGroup { get; set; }
        }
    }
}