namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using LaunchTemplateTypes;

    public class LaunchTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveLaunchTemplateName, IHaveEC2LaunchTemplateTypesLaunchTemplateDataLaunchTemplateData, IHaveVersionDescription, IHaveListOfEC2LaunchTemplateTypesLaunchTemplateTagSpecificationTagSpecifications
    {
        public class Attributes
        {
            public static string LatestVersionNumber =  "LatestVersionNumber" ;
            public static string LaunchTemplateId =  "LaunchTemplateId" ;
            public static string DefaultVersionNumber =  "DefaultVersionNumber" ;
        }

        public override string AWSTypeName { get => AWS.EC2.LaunchTemplate; }
        public Union<string, BaseFunction>? LaunchTemplateName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// LaunchTemplateData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-launchtemplate.html#cfn-ec2-launchtemplate-launchtemplatedata
        /// Required: True
        /// UpdateType: Mutable
        /// Type: LaunchTemplateData
        /// </summary>
        [Required]
        public Union<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateData, BaseFunction>? LaunchTemplateData { get; set; }
        /// <summary>
        /// VersionDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-launchtemplate.html#cfn-ec2-launchtemplate-versiondescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VersionDescription { get; set; }
        /// <summary>
        /// TagSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-launchtemplate.html#cfn-ec2-launchtemplate-tagspecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LaunchTemplateTagSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.LaunchTemplateTagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
    }

    namespace LaunchTemplateTypes
    {
        public class AcceleratorCount : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-acceleratorcount.html#cfn-ec2-launchtemplate-acceleratorcount-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-acceleratorcount.html#cfn-ec2-launchtemplate-acceleratorcount-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class AcceleratorTotalMemoryMiB : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-acceleratortotalmemorymib.html#cfn-ec2-launchtemplate-acceleratortotalmemorymib-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-acceleratortotalmemorymib.html#cfn-ec2-launchtemplate-acceleratortotalmemorymib-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class BaselineEbsBandwidthMbps : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-baselineebsbandwidthmbps.html#cfn-ec2-launchtemplate-baselineebsbandwidthmbps-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-baselineebsbandwidthmbps.html#cfn-ec2-launchtemplate-baselineebsbandwidthmbps-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class BaselinePerformanceFactors : Humidifier.Base.BaseSubResource, IHaveEC2LaunchTemplateTypesCpuCpu
        {
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-baselineperformancefactors.html#cfn-ec2-launchtemplate-baselineperformancefactors-cpu
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Cpu
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.Cpu, BaseFunction>? Cpu { get; set; }
        }

        public class BlockDeviceMapping : Humidifier.Base.BaseSubResource, IHaveEC2LaunchTemplateTypesEbsEbs, IHaveNoDevice, IHaveVirtualName, IHaveDeviceName
        {
            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-blockdevicemapping.html#cfn-ec2-launchtemplate-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ebs
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.Ebs, BaseFunction>? Ebs { get; set; }
            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-blockdevicemapping.html#cfn-ec2-launchtemplate-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NoDevice { get; set; }
            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-blockdevicemapping.html#cfn-ec2-launchtemplate-blockdevicemapping-virtualname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VirtualName { get; set; }
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-blockdevicemapping.html#cfn-ec2-launchtemplate-blockdevicemapping-devicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeviceName { get; set; }
        }

        public class CapacityReservationSpecification : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference, IHaveEC2LaunchTemplateTypesCapacityReservationTargetCapacityReservationTarget
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-capacityreservationspecification.html#cfn-ec2-launchtemplate-capacityreservationspecification-capacityreservationpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
            /// <summary>
            /// CapacityReservationTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-capacityreservationspecification.html#cfn-ec2-launchtemplate-capacityreservationspecification-capacityreservationtarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityReservationTarget
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationTarget, BaseFunction>? CapacityReservationTarget { get; set; }
        }

        public class CapacityReservationTarget : Humidifier.Base.BaseSubResource, IHaveCapacityReservationResourceGroupArn, IHaveCapacityReservationId
        {
            /// <summary>
            /// CapacityReservationResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-capacityreservationtarget.html#cfn-ec2-launchtemplate-capacityreservationtarget-capacityreservationresourcegrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationResourceGroupArn { get; set; }
            /// <summary>
            /// CapacityReservationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-capacityreservationtarget.html#cfn-ec2-launchtemplate-capacityreservationtarget-capacityreservationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationId { get; set; }
        }

        public class ConnectionTrackingSpecification : Humidifier.Base.BaseSubResource, IHaveUdpTimeout_Integer, IHaveTcpEstablishedTimeout_Integer, IHaveUdpStreamTimeout_Integer
        {
            /// <summary>
            /// UdpTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-connectiontrackingspecification.html#cfn-ec2-launchtemplate-connectiontrackingspecification-udptimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UdpTimeout { get; set; }
            /// <summary>
            /// TcpEstablishedTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-connectiontrackingspecification.html#cfn-ec2-launchtemplate-connectiontrackingspecification-tcpestablishedtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TcpEstablishedTimeout { get; set; }
            /// <summary>
            /// UdpStreamTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-connectiontrackingspecification.html#cfn-ec2-launchtemplate-connectiontrackingspecification-udpstreamtimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UdpStreamTimeout { get; set; }
        }

        public class Cpu : Humidifier.Base.BaseSubResource, IHaveListOfEC2LaunchTemplateTypesReferenceReferences
        {
            /// <summary>
            /// References
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-cpu.html#cfn-ec2-launchtemplate-cpu-references
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Reference
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.Reference>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.Reference, BaseFunction>>, BaseFunction>? References { get; set; }
        }

        public class CpuOptions : Humidifier.Base.BaseSubResource, IHaveThreadsPerCore_Integer, IHaveAmdSevSnp, IHaveNestedVirtualization, IHaveCoreCount_Integer
        {
            /// <summary>
            /// ThreadsPerCore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-cpuoptions.html#cfn-ec2-launchtemplate-cpuoptions-threadspercore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ThreadsPerCore { get; set; }
            /// <summary>
            /// AmdSevSnp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-cpuoptions.html#cfn-ec2-launchtemplate-cpuoptions-amdsevsnp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AmdSevSnp { get; set; }
            /// <summary>
            /// NestedVirtualization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-cpuoptions.html#cfn-ec2-launchtemplate-cpuoptions-nestedvirtualization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NestedVirtualization { get; set; }
            /// <summary>
            /// CoreCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-cpuoptions.html#cfn-ec2-launchtemplate-cpuoptions-corecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CoreCount { get; set; }
        }

        public class CreditSpecification : Humidifier.Base.BaseSubResource, IHaveCpuCredits
        {
            /// <summary>
            /// CpuCredits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-creditspecification.html#cfn-ec2-launchtemplate-creditspecification-cpucredits
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CpuCredits { get; set; }
        }

        public class Ebs : Humidifier.Base.BaseSubResource, IHaveSnapshotId, IHaveVolumeType, IHaveKmsKeyId, IHaveEncrypted_Boolean, IHaveEbsCardIndex_Integer, IHaveThroughput_Integer, IHaveIops_Integer, IHaveVolumeInitializationRate_Integer, IHaveVolumeSize_Integer, IHaveDeleteOnTermination_Boolean
        {
            /// <summary>
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-snapshotid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SnapshotId { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-volumetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-encrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Encrypted { get; set; }
            /// <summary>
            /// EbsCardIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-ebscardindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EbsCardIndex { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// VolumeInitializationRate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-volumeinitializationrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeInitializationRate { get; set; }
            /// <summary>
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-volumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumeSize { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ebs.html#cfn-ec2-launchtemplate-ebs-deleteontermination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
        }

        public class EnaSrdSpecification : Humidifier.Base.BaseSubResource, IHaveEnaSrdEnabled_Boolean, IHaveEC2LaunchTemplateTypesEnaSrdUdpSpecificationEnaSrdUdpSpecification
        {
            /// <summary>
            /// EnaSrdEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-enasrdspecification.html#cfn-ec2-launchtemplate-enasrdspecification-enasrdenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnaSrdEnabled { get; set; }
            /// <summary>
            /// EnaSrdUdpSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-enasrdspecification.html#cfn-ec2-launchtemplate-enasrdspecification-enasrdudpspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnaSrdUdpSpecification
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.EnaSrdUdpSpecification, BaseFunction>? EnaSrdUdpSpecification { get; set; }
        }

        public class EnaSrdUdpSpecification : Humidifier.Base.BaseSubResource, IHaveEnaSrdUdpEnabled_Boolean
        {
            /// <summary>
            /// EnaSrdUdpEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-enasrdudpspecification.html#cfn-ec2-launchtemplate-enasrdudpspecification-enasrdudpenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnaSrdUdpEnabled { get; set; }
        }

        public class EnclaveOptions : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-enclaveoptions.html#cfn-ec2-launchtemplate-enclaveoptions-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class HibernationOptions : Humidifier.Base.BaseSubResource, IHaveConfigured_Boolean
        {
            /// <summary>
            /// Configured
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-hibernationoptions.html#cfn-ec2-launchtemplate-hibernationoptions-configured
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Configured { get; set; }
        }

        public class IamInstanceProfile : Humidifier.Base.BaseSubResource, IHaveArn, IHaveName
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-iaminstanceprofile.html#cfn-ec2-launchtemplate-iaminstanceprofile-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-iaminstanceprofile.html#cfn-ec2-launchtemplate-iaminstanceprofile-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class InstanceMarketOptions : Humidifier.Base.BaseSubResource, IHaveEC2LaunchTemplateTypesSpotOptionsSpotOptions, IHaveMarketType
        {
            /// <summary>
            /// SpotOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancemarketoptions.html#cfn-ec2-launchtemplate-instancemarketoptions-spotoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.SpotOptions, BaseFunction>? SpotOptions { get; set; }
            /// <summary>
            /// MarketType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancemarketoptions.html#cfn-ec2-launchtemplate-instancemarketoptions-markettype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MarketType { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveStringListOfInstanceGenerations, IHaveEC2LaunchTemplateTypesMemoryGiBPerVCpuMemoryGiBPerVCpu, IHaveStringListOfAcceleratorTypes, IHaveEC2LaunchTemplateTypesVCpuCountVCpuCount, IHaveStringListOfAcceleratorManufacturers, IHaveLocalStorage, IHaveStringListOfCpuManufacturers, IHaveBareMetal, IHaveRequireHibernateSupport_Boolean, IHaveMaxSpotPriceAsPercentageOfOptimalOnDemandPrice_Integer, IHaveOnDemandMaxPricePercentageOverLowestPrice_Integer, IHaveEC2LaunchTemplateTypesMemoryMiBMemoryMiB, IHaveStringListOfLocalStorageTypes, IHaveEC2LaunchTemplateTypesNetworkInterfaceCountNetworkInterfaceCount, IHaveStringListOfExcludedInstanceTypes, IHaveStringListOfAllowedInstanceTypes, IHaveEC2LaunchTemplateTypesAcceleratorCountAcceleratorCount, IHaveEC2LaunchTemplateTypesNetworkBandwidthGbpsNetworkBandwidthGbps, IHaveEC2LaunchTemplateTypesBaselinePerformanceFactorsBaselinePerformanceFactors, IHaveSpotMaxPricePercentageOverLowestPrice_Integer, IHaveEC2LaunchTemplateTypesBaselineEbsBandwidthMbpsBaselineEbsBandwidthMbps, IHaveStringListOfAcceleratorNames, IHaveEC2LaunchTemplateTypesAcceleratorTotalMemoryMiBAcceleratorTotalMemoryMiB, IHaveBurstablePerformance, IHaveEC2LaunchTemplateTypesTotalLocalStorageGBTotalLocalStorageGB
        {
            /// <summary>
            /// InstanceGenerations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-instancegenerations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceGenerations { get; set; }
            /// <summary>
            /// MemoryGiBPerVCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-memorygibpervcpu
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryGiBPerVCpu
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.MemoryGiBPerVCpu, BaseFunction>? MemoryGiBPerVCpu { get; set; }
            /// <summary>
            /// AcceleratorTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-acceleratortypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorTypes { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-vcpucount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VCpuCount
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.VCpuCount, BaseFunction>? VCpuCount { get; set; }
            /// <summary>
            /// AcceleratorManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-acceleratormanufacturers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorManufacturers { get; set; }
            /// <summary>
            /// LocalStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-localstorage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalStorage { get; set; }
            /// <summary>
            /// CpuManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-cpumanufacturers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CpuManufacturers { get; set; }
            /// <summary>
            /// BareMetal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-baremetal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BareMetal { get; set; }
            /// <summary>
            /// RequireHibernateSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-requirehibernatesupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireHibernateSupport { get; set; }
            /// <summary>
            /// MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-maxspotpriceaspercentageofoptimalondemandprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }
            /// <summary>
            /// OnDemandMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-ondemandmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-memorymib
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryMiB
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.MemoryMiB, BaseFunction>? MemoryMiB { get; set; }
            /// <summary>
            /// LocalStorageTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-localstoragetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LocalStorageTypes { get; set; }
            /// <summary>
            /// NetworkInterfaceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-networkinterfacecount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkInterfaceCount
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.NetworkInterfaceCount, BaseFunction>? NetworkInterfaceCount { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-excludedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-allowedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
            /// <summary>
            /// AcceleratorCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-acceleratorcount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorCount
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.AcceleratorCount, BaseFunction>? AcceleratorCount { get; set; }
            /// <summary>
            /// NetworkBandwidthGbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-networkbandwidthgbps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkBandwidthGbps
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.NetworkBandwidthGbps, BaseFunction>? NetworkBandwidthGbps { get; set; }
            /// <summary>
            /// BaselinePerformanceFactors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-baselineperformancefactors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BaselinePerformanceFactors
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.BaselinePerformanceFactors, BaseFunction>? BaselinePerformanceFactors { get; set; }
            /// <summary>
            /// SpotMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-spotmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpotMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// BaselineEbsBandwidthMbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-baselineebsbandwidthmbps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BaselineEbsBandwidthMbps
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.BaselineEbsBandwidthMbps, BaseFunction>? BaselineEbsBandwidthMbps { get; set; }
            /// <summary>
            /// AcceleratorNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-acceleratornames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorNames { get; set; }
            /// <summary>
            /// AcceleratorTotalMemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-acceleratortotalmemorymib
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorTotalMemoryMiB
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.AcceleratorTotalMemoryMiB, BaseFunction>? AcceleratorTotalMemoryMiB { get; set; }
            /// <summary>
            /// BurstablePerformance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-burstableperformance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BurstablePerformance { get; set; }
            /// <summary>
            /// TotalLocalStorageGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-instancerequirements.html#cfn-ec2-launchtemplate-instancerequirements-totallocalstoragegb
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalLocalStorageGB
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.TotalLocalStorageGB, BaseFunction>? TotalLocalStorageGB { get; set; }
        }

        public class Ipv4PrefixSpecification : Humidifier.Base.BaseSubResource, IHaveIpv4Prefix
        {
            /// <summary>
            /// Ipv4Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ipv4prefixspecification.html#cfn-ec2-launchtemplate-ipv4prefixspecification-ipv4prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv4Prefix { get; set; }
        }

        public class Ipv6Add : Humidifier.Base.BaseSubResource, IHaveIpv6Address
        {
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ipv6add.html#cfn-ec2-launchtemplate-ipv6add-ipv6address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Address { get; set; }
        }

        public class Ipv6PrefixSpecification : Humidifier.Base.BaseSubResource, IHaveIpv6Prefix
        {
            /// <summary>
            /// Ipv6Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-ipv6prefixspecification.html#cfn-ec2-launchtemplate-ipv6prefixspecification-ipv6prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ipv6Prefix { get; set; }
        }

        public class LaunchTemplateData : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveListOfEC2LaunchTemplateTypesTagSpecificationTagSpecifications, IHaveEC2LaunchTemplateTypesNetworkPerformanceOptionsNetworkPerformanceOptions, IHaveUserData, IHaveListOfEC2LaunchTemplateTypesBlockDeviceMappingBlockDeviceMappings, IHaveEC2LaunchTemplateTypesMaintenanceOptionsMaintenanceOptions, IHaveEC2LaunchTemplateTypesIamInstanceProfileIamInstanceProfile, IHaveKernelId, IHaveEbsOptimized_Boolean, IHaveEC2LaunchTemplateTypesPlacementPlacement, IHaveListOfEC2LaunchTemplateTypesNetworkInterfaceNetworkInterfaces, IHaveEC2LaunchTemplateTypesEnclaveOptionsEnclaveOptions, IHaveImageId, IHaveInstanceType, IHaveEC2LaunchTemplateTypesMonitoringMonitoring, IHaveEC2LaunchTemplateTypesHibernationOptionsHibernationOptions, IHaveEC2LaunchTemplateTypesMetadataOptionsMetadataOptions, IHaveListOfEC2LaunchTemplateTypesLicenseSpecificationLicenseSpecifications, IHaveInstanceInitiatedShutdownBehavior, IHaveDisableApiStop_Boolean, IHaveEC2LaunchTemplateTypesCpuOptionsCpuOptions, IHaveEC2LaunchTemplateTypesPrivateDnsNameOptionsPrivateDnsNameOptions, IHaveStringListOfSecurityGroupIds, IHaveKeyName, IHaveDisableApiTermination_Boolean, IHaveEC2LaunchTemplateTypesInstanceMarketOptionsInstanceMarketOptions, IHaveEC2LaunchTemplateTypesInstanceRequirementsInstanceRequirements, IHaveRamDiskId, IHaveEC2LaunchTemplateTypesCapacityReservationSpecificationCapacityReservationSpecification, IHaveEC2LaunchTemplateTypesCreditSpecificationCreditSpecification
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// TagSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-tagspecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.TagSpecification>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.TagSpecification, BaseFunction>>, BaseFunction>? TagSpecifications { get; set; }
            /// <summary>
            /// NetworkPerformanceOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-networkperformanceoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkPerformanceOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.NetworkPerformanceOptions, BaseFunction>? NetworkPerformanceOptions { get; set; }
            /// <summary>
            /// UserData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-userdata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserData { get; set; }
            /// <summary>
            /// BlockDeviceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-blockdevicemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BlockDeviceMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.BlockDeviceMapping>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.BlockDeviceMapping, BaseFunction>>, BaseFunction>? BlockDeviceMappings { get; set; }
            /// <summary>
            /// MaintenanceOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-maintenanceoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaintenanceOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.MaintenanceOptions, BaseFunction>? MaintenanceOptions { get; set; }
            /// <summary>
            /// IamInstanceProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-iaminstanceprofile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamInstanceProfile
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.IamInstanceProfile, BaseFunction>? IamInstanceProfile { get; set; }
            /// <summary>
            /// KernelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-kernelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KernelId { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-ebsoptimized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-placement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Placement
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.Placement, BaseFunction>? Placement { get; set; }
            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-networkinterfaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NetworkInterface
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.NetworkInterface>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.NetworkInterface, BaseFunction>>, BaseFunction>? NetworkInterfaces { get; set; }
            /// <summary>
            /// EnclaveOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-enclaveoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnclaveOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.EnclaveOptions, BaseFunction>? EnclaveOptions { get; set; }
            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-imageid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageId { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-monitoring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Monitoring
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.Monitoring, BaseFunction>? Monitoring { get; set; }
            /// <summary>
            /// HibernationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-hibernationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HibernationOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.HibernationOptions, BaseFunction>? HibernationOptions { get; set; }
            /// <summary>
            /// MetadataOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-metadataoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetadataOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.MetadataOptions, BaseFunction>? MetadataOptions { get; set; }
            /// <summary>
            /// LicenseSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-licensespecifications
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LicenseSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.LicenseSpecification>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.LicenseSpecification, BaseFunction>>, BaseFunction>? LicenseSpecifications { get; set; }
            /// <summary>
            /// InstanceInitiatedShutdownBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-instanceinitiatedshutdownbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceInitiatedShutdownBehavior { get; set; }
            /// <summary>
            /// DisableApiStop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-disableapistop
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableApiStop { get; set; }
            /// <summary>
            /// CpuOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-cpuoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CpuOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.CpuOptions, BaseFunction>? CpuOptions { get; set; }
            /// <summary>
            /// PrivateDnsNameOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-privatednsnameoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateDnsNameOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.PrivateDnsNameOptions, BaseFunction>? PrivateDnsNameOptions { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-keyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyName { get; set; }
            /// <summary>
            /// DisableApiTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-disableapitermination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableApiTermination { get; set; }
            /// <summary>
            /// InstanceMarketOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-instancemarketoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceMarketOptions
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.InstanceMarketOptions, BaseFunction>? InstanceMarketOptions { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-instancerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceRequirements
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.InstanceRequirements, BaseFunction>? InstanceRequirements { get; set; }
            /// <summary>
            /// RamDiskId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-ramdiskid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RamDiskId { get; set; }
            /// <summary>
            /// CapacityReservationSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-capacityreservationspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityReservationSpecification
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.CapacityReservationSpecification, BaseFunction>? CapacityReservationSpecification { get; set; }
            /// <summary>
            /// CreditSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatedata.html#cfn-ec2-launchtemplate-launchtemplatedata-creditspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CreditSpecification
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.CreditSpecification, BaseFunction>? CreditSpecification { get; set; }
        }

        public class LaunchTemplateTagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatetagspecification.html#cfn-ec2-launchtemplate-launchtemplatetagspecification-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-launchtemplatetagspecification.html#cfn-ec2-launchtemplate-launchtemplatetagspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class LicenseSpecification : Humidifier.Base.BaseSubResource, IHaveLicenseConfigurationArn
        {
            /// <summary>
            /// LicenseConfigurationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-licensespecification.html#cfn-ec2-launchtemplate-licensespecification-licenseconfigurationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LicenseConfigurationArn { get; set; }
        }

        public class MaintenanceOptions : Humidifier.Base.BaseSubResource, IHaveAutoRecovery
        {
            /// <summary>
            /// AutoRecovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-maintenanceoptions.html#cfn-ec2-launchtemplate-maintenanceoptions-autorecovery
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoRecovery { get; set; }
        }

        public class MemoryGiBPerVCpu : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-memorygibpervcpu.html#cfn-ec2-launchtemplate-memorygibpervcpu-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-memorygibpervcpu.html#cfn-ec2-launchtemplate-memorygibpervcpu-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class MemoryMiB : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-memorymib.html#cfn-ec2-launchtemplate-memorymib-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-memorymib.html#cfn-ec2-launchtemplate-memorymib-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class MetadataOptions : Humidifier.Base.BaseSubResource, IHaveHttpPutResponseHopLimit_Integer, IHaveHttpTokens, IHaveHttpProtocolIpv6, IHaveInstanceMetadataTags, IHaveHttpEndpoint
        {
            /// <summary>
            /// HttpPutResponseHopLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-metadataoptions.html#cfn-ec2-launchtemplate-metadataoptions-httpputresponsehoplimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HttpPutResponseHopLimit { get; set; }
            /// <summary>
            /// HttpTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-metadataoptions.html#cfn-ec2-launchtemplate-metadataoptions-httptokens
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpTokens { get; set; }
            /// <summary>
            /// HttpProtocolIpv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-metadataoptions.html#cfn-ec2-launchtemplate-metadataoptions-httpprotocolipv6
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpProtocolIpv6 { get; set; }
            /// <summary>
            /// InstanceMetadataTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-metadataoptions.html#cfn-ec2-launchtemplate-metadataoptions-instancemetadatatags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceMetadataTags { get; set; }
            /// <summary>
            /// HttpEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-metadataoptions.html#cfn-ec2-launchtemplate-metadataoptions-httpendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HttpEndpoint { get; set; }
        }

        public class Monitoring : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-monitoring.html#cfn-ec2-launchtemplate-monitoring-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class NetworkBandwidthGbps : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkbandwidthgbps.html#cfn-ec2-launchtemplate-networkbandwidthgbps-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkbandwidthgbps.html#cfn-ec2-launchtemplate-networkbandwidthgbps-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class NetworkInterface : Humidifier.Base.BaseSubResource, IHaveDescription, IHavePrivateIpAddress, IHaveListOfEC2LaunchTemplateTypesPrivateIpAddPrivateIpAddresses, IHaveSecondaryPrivateIpAddressCount_Integer, IHaveIpv6PrefixCount_Integer, IHaveListOfEC2LaunchTemplateTypesIpv4PrefixSpecificationIpv4Prefixes, IHaveDeviceIndex_Integer, IHavePrimaryIpv6_Boolean, IHaveIpv4PrefixCount_Integer, IHaveEnaQueueCount_Integer, IHaveListOfEC2LaunchTemplateTypesIpv6PrefixSpecificationIpv6Prefixes, IHaveSubnetId, IHaveListOfEC2LaunchTemplateTypesIpv6AddIpv6Addresses, IHaveAssociatePublicIpAddress_Boolean, IHaveNetworkInterfaceId, IHaveNetworkCardIndex_Integer, IHaveInterfaceType, IHaveAssociateCarrierIpAddress_Boolean, IHaveEC2LaunchTemplateTypesEnaSrdSpecificationEnaSrdSpecification, IHaveIpv6AddressCount_Integer, IHaveStringListOfGroups, IHaveDeleteOnTermination_Boolean, IHaveEC2LaunchTemplateTypesConnectionTrackingSpecificationConnectionTrackingSpecification
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-privateipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// PrivateIpAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-privateipaddresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateIpAdd
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.PrivateIpAdd>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.PrivateIpAdd, BaseFunction>>, BaseFunction>? PrivateIpAddresses { get; set; }
            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-secondaryprivateipaddresscount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SecondaryPrivateIpAddressCount { get; set; }
            /// <summary>
            /// Ipv6PrefixCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-ipv6prefixcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv6PrefixCount { get; set; }
            /// <summary>
            /// Ipv4Prefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-ipv4prefixes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Ipv4PrefixSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.Ipv4PrefixSpecification>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.Ipv4PrefixSpecification, BaseFunction>>, BaseFunction>? Ipv4Prefixes { get; set; }
            /// <summary>
            /// DeviceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-deviceindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DeviceIndex { get; set; }
            /// <summary>
            /// PrimaryIpv6
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-primaryipv6
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PrimaryIpv6 { get; set; }
            /// <summary>
            /// Ipv4PrefixCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-ipv4prefixcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv4PrefixCount { get; set; }
            /// <summary>
            /// EnaQueueCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-enaqueuecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EnaQueueCount { get; set; }
            /// <summary>
            /// Ipv6Prefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-ipv6prefixes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Ipv6PrefixSpecification
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.Ipv6PrefixSpecification>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.Ipv6PrefixSpecification, BaseFunction>>, BaseFunction>? Ipv6Prefixes { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
            /// <summary>
            /// Ipv6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-ipv6addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Ipv6Add
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EC2.LaunchTemplateTypes.Ipv6Add>, IReadOnlyList<Union<Humidifier.EC2.LaunchTemplateTypes.Ipv6Add, BaseFunction>>, BaseFunction>? Ipv6Addresses { get; set; }
            /// <summary>
            /// AssociatePublicIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-associatepublicipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AssociatePublicIpAddress { get; set; }
            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NetworkInterfaceId { get; set; }
            /// <summary>
            /// NetworkCardIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-networkcardindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NetworkCardIndex { get; set; }
            /// <summary>
            /// InterfaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-interfacetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InterfaceType { get; set; }
            /// <summary>
            /// AssociateCarrierIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-associatecarrieripaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AssociateCarrierIpAddress { get; set; }
            /// <summary>
            /// EnaSrdSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-enasrdspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnaSrdSpecification
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.EnaSrdSpecification, BaseFunction>? EnaSrdSpecification { get; set; }
            /// <summary>
            /// Ipv6AddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-ipv6addresscount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Ipv6AddressCount { get; set; }
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Groups { get; set; }
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-deleteontermination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DeleteOnTermination { get; set; }
            /// <summary>
            /// ConnectionTrackingSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterface.html#cfn-ec2-launchtemplate-networkinterface-connectiontrackingspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionTrackingSpecification
            /// </summary>
            public Union<Humidifier.EC2.LaunchTemplateTypes.ConnectionTrackingSpecification, BaseFunction>? ConnectionTrackingSpecification { get; set; }
        }

        public class NetworkInterfaceCount : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterfacecount.html#cfn-ec2-launchtemplate-networkinterfacecount-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkinterfacecount.html#cfn-ec2-launchtemplate-networkinterfacecount-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class NetworkPerformanceOptions : Humidifier.Base.BaseSubResource, IHaveBandwidthWeighting
        {
            /// <summary>
            /// BandwidthWeighting
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-networkperformanceoptions.html#cfn-ec2-launchtemplate-networkperformanceoptions-bandwidthweighting
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BandwidthWeighting { get; set; }
        }

        public class Placement : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveTenancy, IHaveSpreadDomain, IHavePartitionNumber_Integer, IHaveAvailabilityZone, IHaveAffinity, IHaveHostId, IHaveHostResourceGroupArn, IHaveGroupId
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-groupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// Tenancy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-tenancy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tenancy { get; set; }
            /// <summary>
            /// SpreadDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-spreaddomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpreadDomain { get; set; }
            /// <summary>
            /// PartitionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-partitionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PartitionNumber { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// Affinity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-affinity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Affinity { get; set; }
            /// <summary>
            /// HostId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-hostid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostId { get; set; }
            /// <summary>
            /// HostResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-hostresourcegrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostResourceGroupArn { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-placement.html#cfn-ec2-launchtemplate-placement-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class PrivateDnsNameOptions : Humidifier.Base.BaseSubResource, IHaveEnableResourceNameDnsARecord_Boolean, IHaveHostnameType, IHaveEnableResourceNameDnsAAAARecord_Boolean
        {
            /// <summary>
            /// EnableResourceNameDnsARecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privatednsnameoptions.html#cfn-ec2-launchtemplate-privatednsnameoptions-enableresourcenamednsarecord
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResourceNameDnsARecord { get; set; }
            /// <summary>
            /// HostnameType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privatednsnameoptions.html#cfn-ec2-launchtemplate-privatednsnameoptions-hostnametype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostnameType { get; set; }
            /// <summary>
            /// EnableResourceNameDnsAAAARecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privatednsnameoptions.html#cfn-ec2-launchtemplate-privatednsnameoptions-enableresourcenamednsaaaarecord
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableResourceNameDnsAAAARecord { get; set; }
        }

        public class PrivateIpAdd : Humidifier.Base.BaseSubResource, IHavePrivateIpAddress, IHavePrimary_Boolean
        {
            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html#cfn-ec2-launchtemplate-privateipadd-privateipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateIpAddress { get; set; }
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-privateipadd.html#cfn-ec2-launchtemplate-privateipadd-primary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Primary { get; set; }
        }

        public class Reference : Humidifier.Base.BaseSubResource, IHaveInstanceFamily
        {
            /// <summary>
            /// InstanceFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-reference.html#cfn-ec2-launchtemplate-reference-instancefamily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceFamily { get; set; }
        }

        public class SpotOptions : Humidifier.Base.BaseSubResource, IHaveSpotInstanceType, IHaveInstanceInterruptionBehavior, IHaveMaxPrice, IHaveBlockDurationMinutes_Integer, IHaveValidUntil
        {
            /// <summary>
            /// SpotInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-spotoptions.html#cfn-ec2-launchtemplate-spotoptions-spotinstancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpotInstanceType { get; set; }
            /// <summary>
            /// InstanceInterruptionBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-spotoptions.html#cfn-ec2-launchtemplate-spotoptions-instanceinterruptionbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceInterruptionBehavior { get; set; }
            /// <summary>
            /// MaxPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-spotoptions.html#cfn-ec2-launchtemplate-spotoptions-maxprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaxPrice { get; set; }
            /// <summary>
            /// BlockDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-spotoptions.html#cfn-ec2-launchtemplate-spotoptions-blockdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BlockDurationMinutes { get; set; }
            /// <summary>
            /// ValidUntil
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-spotoptions.html#cfn-ec2-launchtemplate-spotoptions-validuntil
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidUntil { get; set; }
        }

        public class TagSpecification : Humidifier.Base.BaseSubResource, IHaveTags, IHaveResourceType
        {
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-tagspecification.html#cfn-ec2-launchtemplate-tagspecification-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-tagspecification.html#cfn-ec2-launchtemplate-tagspecification-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class TotalLocalStorageGB : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-totallocalstoragegb.html#cfn-ec2-launchtemplate-totallocalstoragegb-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-totallocalstoragegb.html#cfn-ec2-launchtemplate-totallocalstoragegb-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class VCpuCount : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-vcpucount.html#cfn-ec2-launchtemplate-vcpucount-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-launchtemplate-vcpucount.html#cfn-ec2-launchtemplate-vcpucount-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }
    }
}