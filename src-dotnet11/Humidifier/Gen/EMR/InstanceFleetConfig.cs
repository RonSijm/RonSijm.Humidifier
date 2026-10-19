namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using InstanceFleetConfigTypes;

    public class InstanceFleetConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveInstanceFleetType, IHaveTargetOnDemandCapacity_Integer, IHaveClusterId, IHaveTargetSpotCapacity_Integer, IHaveEMRInstanceFleetConfigTypesInstanceFleetProvisioningSpecificationsLaunchSpecifications, IHaveEMRInstanceFleetConfigTypesInstanceFleetResizingSpecificationsResizeSpecifications, IHaveListOfEMRInstanceFleetConfigTypesInstanceTypeConfigInstanceTypeConfigs, IHaveName
    {
        public class Attributes
        {
            public static string InstanceFleetId =  "InstanceFleetId" ;
        }

        public override string AWSTypeName { get => AWS.EMR.InstanceFleetConfig; }

        /// <summary>
        /// InstanceFleetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-instancefleettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceFleetType { get; set; }
        /// <summary>
        /// TargetOnDemandCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-targetondemandcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TargetOnDemandCapacity { get; set; }

        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterId { get; set; }
        /// <summary>
        /// TargetSpotCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-targetspotcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TargetSpotCapacity { get; set; }
        /// <summary>
        /// LaunchSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-launchspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InstanceFleetProvisioningSpecifications
        /// </summary>
        public Union<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications, BaseFunction>? LaunchSpecifications { get; set; }
        /// <summary>
        /// ResizeSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-resizespecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceFleetResizingSpecifications
        /// </summary>
        public Union<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetResizingSpecifications, BaseFunction>? ResizeSpecifications { get; set; }
        /// <summary>
        /// InstanceTypeConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-instancetypeconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InstanceTypeConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig>, IReadOnlyList<Union<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig, BaseFunction>>, BaseFunction>? InstanceTypeConfigs { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace InstanceFleetConfigTypes
    {
        public class ApplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfEMRInstanceFleetConfigTypesApplicationConfigurationConfigurations, IHaveClassification, IHaveStringDictionaryOfConfigurationProperties
        {
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-applicationconfiguration.html#cfn-emr-instancefleetconfig-applicationconfiguration-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApplicationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceFleetConfigTypes.ApplicationConfiguration>, IReadOnlyList<Union<Humidifier.EMR.InstanceFleetConfigTypes.ApplicationConfiguration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-applicationconfiguration.html#cfn-emr-instancefleetconfig-applicationconfiguration-classification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
            /// <summary>
            /// ConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-applicationconfiguration.html#cfn-emr-instancefleetconfig-applicationconfiguration-configurationproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ConfigurationProperties { get; set; }
        }

        public class EbsBlockDeviceConfig : Humidifier.Base.BaseSubResource, IHaveEMRInstanceFleetConfigTypesVolumeSpecificationVolumeSpecification, IHaveVolumesPerInstance_Integer
        {
            /// <summary>
            /// VolumeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ebsblockdeviceconfig.html#cfn-emr-instancefleetconfig-ebsblockdeviceconfig-volumespecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VolumeSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.VolumeSpecification, BaseFunction>? VolumeSpecification { get; set; }
            /// <summary>
            /// VolumesPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ebsblockdeviceconfig.html#cfn-emr-instancefleetconfig-ebsblockdeviceconfig-volumesperinstance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumesPerInstance { get; set; }
        }

        public class EbsConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfEMRInstanceFleetConfigTypesEbsBlockDeviceConfigEbsBlockDeviceConfigs, IHaveEbsOptimized_Boolean
        {
            /// <summary>
            /// EbsBlockDeviceConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ebsconfiguration.html#cfn-emr-instancefleetconfig-ebsconfiguration-ebsblockdeviceconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EbsBlockDeviceConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceFleetConfigTypes.EbsBlockDeviceConfig>, IReadOnlyList<Union<Humidifier.EMR.InstanceFleetConfigTypes.EbsBlockDeviceConfig, BaseFunction>>, BaseFunction>? EbsBlockDeviceConfigs { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ebsconfiguration.html#cfn-emr-instancefleetconfig-ebsconfiguration-ebsoptimized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
        }

        public class InstanceFleetProvisioningSpecifications : Humidifier.Base.BaseSubResource, IHaveEMRInstanceFleetConfigTypesOnDemandProvisioningSpecificationOnDemandSpecification, IHaveEMRInstanceFleetConfigTypesSpotProvisioningSpecificationSpotSpecification
        {
            /// <summary>
            /// OnDemandSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancefleetprovisioningspecifications.html#cfn-emr-instancefleetconfig-instancefleetprovisioningspecifications-ondemandspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OnDemandProvisioningSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification, BaseFunction>? OnDemandSpecification { get; set; }
            /// <summary>
            /// SpotSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancefleetprovisioningspecifications.html#cfn-emr-instancefleetconfig-instancefleetprovisioningspecifications-spotspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SpotProvisioningSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.SpotProvisioningSpecification, BaseFunction>? SpotSpecification { get; set; }
        }

        public class InstanceFleetResizingSpecifications : Humidifier.Base.BaseSubResource, IHaveEMRInstanceFleetConfigTypesSpotResizingSpecificationSpotResizeSpecification, IHaveEMRInstanceFleetConfigTypesOnDemandResizingSpecificationOnDemandResizeSpecification
        {
            /// <summary>
            /// SpotResizeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancefleetresizingspecifications.html#cfn-emr-instancefleetconfig-instancefleetresizingspecifications-spotresizespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotResizingSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.SpotResizingSpecification, BaseFunction>? SpotResizeSpecification { get; set; }
            /// <summary>
            /// OnDemandResizeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancefleetresizingspecifications.html#cfn-emr-instancefleetconfig-instancefleetresizingspecifications-ondemandresizespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandResizingSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification, BaseFunction>? OnDemandResizeSpecification { get; set; }
        }

        public class InstanceTypeConfig : Humidifier.Base.BaseSubResource, IHaveBidPrice, IHaveWeightedCapacity_Integer, IHaveEMRInstanceFleetConfigTypesEbsConfigurationEbsConfiguration, IHavePriority_Double, IHaveBidPriceAsPercentageOfOnDemandPrice_Double, IHaveCustomAmiId, IHaveListOfEMRInstanceFleetConfigTypesApplicationConfigurationConfigurations, IHaveInstanceType
        {
            /// <summary>
            /// BidPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-bidprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BidPrice { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-weightedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WeightedCapacity { get; set; }
            /// <summary>
            /// EbsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-ebsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbsConfiguration
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration, BaseFunction>? EbsConfiguration { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// BidPriceAsPercentageOfOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-bidpriceaspercentageofondemandprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BidPriceAsPercentageOfOnDemandPrice { get; set; }
            /// <summary>
            /// CustomAmiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-customamiid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomAmiId { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApplicationConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceFleetConfigTypes.ApplicationConfiguration>, IReadOnlyList<Union<Humidifier.EMR.InstanceFleetConfigTypes.ApplicationConfiguration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class OnDemandCapacityReservationOptions : Humidifier.Base.BaseSubResource, IHaveUsageStrategy, IHaveCapacityReservationResourceGroupArn, IHaveCapacityReservationPreference
        {
            /// <summary>
            /// UsageStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-emr-instancefleetconfig-ondemandcapacityreservationoptions-usagestrategy
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsageStrategy { get; set; }
            /// <summary>
            /// CapacityReservationResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-emr-instancefleetconfig-ondemandcapacityreservationoptions-capacityreservationresourcegrouparn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationResourceGroupArn { get; set; }
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-emr-instancefleetconfig-ondemandcapacityreservationoptions-capacityreservationpreference
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
        }

        public class OnDemandProvisioningSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveEMRInstanceFleetConfigTypesOnDemandCapacityReservationOptionsCapacityReservationOptions
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandprovisioningspecification.html#cfn-emr-instancefleetconfig-ondemandprovisioningspecification-allocationstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandprovisioningspecification.html#cfn-emr-instancefleetconfig-ondemandprovisioningspecification-capacityreservationoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OnDemandCapacityReservationOptions
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions, BaseFunction>? CapacityReservationOptions { get; set; }
        }

        public class OnDemandResizingSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveTimeoutDurationMinutes_Integer, IHaveEMRInstanceFleetConfigTypesOnDemandCapacityReservationOptionsCapacityReservationOptions
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandresizingspecification.html#cfn-emr-instancefleetconfig-ondemandresizingspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandresizingspecification.html#cfn-emr-instancefleetconfig-ondemandresizingspecification-timeoutdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandresizingspecification.html#cfn-emr-instancefleetconfig-ondemandresizingspecification-capacityreservationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandCapacityReservationOptions
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions, BaseFunction>? CapacityReservationOptions { get; set; }
        }

        public class SpotProvisioningSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveTimeoutDurationMinutes_Integer, IHaveTimeoutAction, IHaveBlockDurationMinutes_Integer
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotprovisioningspecification.html#cfn-emr-instancefleetconfig-spotprovisioningspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotprovisioningspecification.html#cfn-emr-instancefleetconfig-spotprovisioningspecification-timeoutdurationminutes
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
            /// <summary>
            /// TimeoutAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotprovisioningspecification.html#cfn-emr-instancefleetconfig-spotprovisioningspecification-timeoutaction
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeoutAction { get; set; }
            /// <summary>
            /// BlockDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotprovisioningspecification.html#cfn-emr-instancefleetconfig-spotprovisioningspecification-blockdurationminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BlockDurationMinutes { get; set; }
        }

        public class SpotResizingSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveTimeoutDurationMinutes_Integer
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotresizingspecification.html#cfn-emr-instancefleetconfig-spotresizingspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotresizingspecification.html#cfn-emr-instancefleetconfig-spotresizingspecification-timeoutdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
        }

        public class VolumeSpecification : Humidifier.Base.BaseSubResource, IHaveSizeInGB_Integer, IHaveVolumeType, IHaveThroughput_Integer, IHaveIops_Integer
        {
            /// <summary>
            /// SizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-volumespecification.html#cfn-emr-instancefleetconfig-volumespecification-sizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGB { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-volumespecification.html#cfn-emr-instancefleetconfig-volumespecification-volumetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-volumespecification.html#cfn-emr-instancefleetconfig-volumespecification-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-volumespecification.html#cfn-emr-instancefleetconfig-volumespecification-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
        }
    }
}