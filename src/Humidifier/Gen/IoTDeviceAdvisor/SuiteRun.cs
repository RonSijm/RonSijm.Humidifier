namespace Humidifier.IoTDeviceAdvisor
{
    using global::System.Collections.Generic;
    using SuiteRunTypes;

    public class SuiteRun : Humidifier.Base.BaseResource, IHaveTags
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
        public dynamic SuiteDefinitionVersion { get; set; }

        /// <summary>
        /// SuiteRunConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotdeviceadvisor-suiterun.html#cfn-iotdeviceadvisor-suiterun-suiterunconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: SuiteRunConfiguration
        /// </summary>
        [Required]
        public Humidifier.IoTDeviceAdvisor.SuiteRunTypes.SuiteRunConfiguration SuiteRunConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotdeviceadvisor-suiterun.html#cfn-iotdeviceadvisor-suiterun-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }

        /// <summary>
        /// SuiteDefinitionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotdeviceadvisor-suiterun.html#cfn-iotdeviceadvisor-suiterun-suitedefinitionid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic SuiteDefinitionId { get; set; }
    }

    namespace SuiteRunTypes
    {
        public class DeviceUnderTest : Humidifier.Base.BaseSubResource, IHaveCertificateArn, IHaveThingArn
        {
            /// <summary>
            /// ThingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotdeviceadvisor-suiterun-deviceundertest.html#cfn-iotdeviceadvisor-suiterun-deviceundertest-thingarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThingArn { get; set; }
            /// <summary>
            /// CertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotdeviceadvisor-suiterun-deviceundertest.html#cfn-iotdeviceadvisor-suiterun-deviceundertest-certificatearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CertificateArn { get; set; }
        }

        public class SuiteRunConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParallelRun
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotdeviceadvisor-suiterun-suiterunconfiguration.html#cfn-iotdeviceadvisor-suiterun-suiterunconfiguration-parallelrun
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ParallelRun { get; set; }
            /// <summary>
            /// PrimaryDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotdeviceadvisor-suiterun-suiterunconfiguration.html#cfn-iotdeviceadvisor-suiterun-suiterunconfiguration-primarydevice
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DeviceUnderTest
            /// </summary>
            public Humidifier.IoTDeviceAdvisor.SuiteRunTypes.DeviceUnderTest PrimaryDevice { get; set; }
        }
    }
}