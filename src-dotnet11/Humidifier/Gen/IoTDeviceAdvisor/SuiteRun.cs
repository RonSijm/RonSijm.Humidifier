namespace Humidifier.IoTDeviceAdvisor
{
    using global::System.Collections.Generic;
    using SuiteRunTypes;

    public class SuiteRun : Humidifier.Base.BaseResource, IHaveTags, IHaveSuiteDefinitionVersion, IHaveIoTDeviceAdvisorSuiteRunTypesSuiteRunConfigurationSuiteRunConfiguration, IHaveSuiteDefinitionId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string SuiteRunId =  "SuiteRunId" ;
            public static string StartTime =  "StartTime" ;
            public static string SuiteRunArn =  "SuiteRunArn" ;
        }

        public override string AWSTypeName { get => AWS.IoTDeviceAdvisor.SuiteRun; }
        /// <summary>
        /// SuiteDefinitionVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotdeviceadvisor-suiterun.html#cfn-iotdeviceadvisor-suiterun-suitedefinitionversion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SuiteDefinitionVersion { get; set; }

        /// <summary>
        /// SuiteRunConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotdeviceadvisor-suiterun.html#cfn-iotdeviceadvisor-suiterun-suiterunconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SuiteRunConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration, BaseFunction>? SuiteRunConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotdeviceadvisor-suiterun.html#cfn-iotdeviceadvisor-suiterun-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// SuiteDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotdeviceadvisor-suiterun.html#cfn-iotdeviceadvisor-suiterun-suitedefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SuiteDefinitionId { get; set; }
    }

    namespace SuiteRunTypes
    {
        public class DeviceUnderTest : Humidifier.Base.BaseSubResource, IHaveThingArn, IHaveCertificateArn
        {
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotdeviceadvisor-suiterun-deviceundertest.html#cfn-iotdeviceadvisor-suiterun-deviceundertest-thingarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ThingArn { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotdeviceadvisor-suiterun-deviceundertest.html#cfn-iotdeviceadvisor-suiterun-deviceundertest-certificatearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CertificateArn { get; set; }
        }

        public class SuiteRunConfiguration : Humidifier.Base.BaseSubResource, IHaveParallelRun_Boolean, IHaveIoTDeviceAdvisorSuiteRunTypesDeviceUnderTestPrimaryDevice
        {
            /// <summary>
            /// ParallelRun
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotdeviceadvisor-suiterun-suiterunconfiguration.html#cfn-iotdeviceadvisor-suiterun-suiterunconfiguration-parallelrun
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ParallelRun { get; set; }
            /// <summary>
            /// PrimaryDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotdeviceadvisor-suiterun-suiterunconfiguration.html#cfn-iotdeviceadvisor-suiterun-suiterunconfiguration-primarydevice
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DeviceUnderTest
            /// </summary>
            public Union<Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest, BaseFunction>? PrimaryDevice { get; set; }
        }
    }
}