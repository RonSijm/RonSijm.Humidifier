namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using InstanceFleetConfigTypes;

    public class InstanceFleetConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveClusterId, IHaveInstanceFleetType, IHaveListOfEMRInstanceFleetConfigTypesInstanceTypeConfigInstanceTypeConfigs, IHaveEMRInstanceFleetConfigTypesInstanceFleetProvisioningSpecificationsLaunchSpecifications, IHaveName, IHaveEMRInstanceFleetConfigTypesInstanceFleetResizingSpecificationsResizeSpecifications, IHaveTargetOnDemandCapacity_Integer, IHaveTargetSpotCapacity_Integer
    {
        public override string AWSTypeName { get => AWS.EMR.InstanceFleetConfig; }

        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterId { get; set; }

        /// <summary>
        /// InstanceFleetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancefleettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceFleetType { get; set; }
        /// <summary>
        /// InstanceTypeConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InstanceTypeConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig>, IReadOnlyList<Union<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig, BaseFunction>>, BaseFunction>? InstanceTypeConfigs { get; set; }
        /// <summary>
        /// LaunchSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-launchspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InstanceFleetProvisioningSpecifications
        /// </summary>
        public Union<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications, BaseFunction>? LaunchSpecifications { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ResizeSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-resizespecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceFleetResizingSpecifications
        /// </summary>
        public Union<Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetResizingSpecifications, BaseFunction>? ResizeSpecifications { get; set; }
        /// <summary>
        /// TargetOnDemandCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetondemandcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TargetOnDemandCapacity { get; set; }
        /// <summary>
        /// TargetSpotCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetspotcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? TargetSpotCapacity { get; set; }
    }

    namespace InstanceFleetConfigTypes
    {
        public class Configuration : Humidifier.Base.BaseSubResource, IHaveClassification, IHaveStringDictionaryOfConfigurationProperties, IHaveListOfEMRInstanceFleetConfigTypesConfigurationConfigurations
        {
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-configuration.html#cfn-elasticmapreduce-instancefleetconfig-configuration-classification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
            /// <summary>
            /// ConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-configuration.html#cfn-elasticmapreduce-instancefleetconfig-configuration-configurationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ConfigurationProperties { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-configuration.html#cfn-elasticmapreduce-instancefleetconfig-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceFleetConfigTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMR.InstanceFleetConfigTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
        }

        public class EbsBlockDeviceConfig : Humidifier.Base.BaseSubResource, IHaveEMRInstanceFleetConfigTypesVolumeSpecificationVolumeSpecification, IHaveVolumesPerInstance_Integer
        {
            /// <summary>
            /// VolumeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig.html#cfn-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig-volumespecification
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VolumeSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.VolumeSpecification, BaseFunction>? VolumeSpecification { get; set; }
            /// <summary>
            /// VolumesPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig.html#cfn-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig-volumesperinstance
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? VolumesPerInstance { get; set; }
        }

        public class EbsConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfEMRInstanceFleetConfigTypesEbsBlockDeviceConfigEbsBlockDeviceConfigs, IHaveEbsOptimized_Boolean
        {
            /// <summary>
            /// EbsBlockDeviceConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsconfiguration.html#cfn-elasticmapreduce-instancefleetconfig-ebsconfiguration-ebsblockdeviceconfigs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EbsBlockDeviceConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceFleetConfigTypes.EbsBlockDeviceConfig>, IReadOnlyList<Union<Humidifier.EMR.InstanceFleetConfigTypes.EbsBlockDeviceConfig, BaseFunction>>, BaseFunction>? EbsBlockDeviceConfigs { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsconfiguration.html#cfn-elasticmapreduce-instancefleetconfig-ebsconfiguration-ebsoptimized
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EbsOptimized { get; set; }
        }

        public class InstanceFleetProvisioningSpecifications : Humidifier.Base.BaseSubResource, IHaveEMRInstanceFleetConfigTypesOnDemandProvisioningSpecificationOnDemandSpecification, IHaveEMRInstanceFleetConfigTypesSpotProvisioningSpecificationSpotSpecification
        {
            /// <summary>
            /// OnDemandSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications.html#cfn-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications-ondemandspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandProvisioningSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification, BaseFunction>? OnDemandSpecification { get; set; }
            /// <summary>
            /// SpotSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications.html#cfn-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications-spotspecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotProvisioningSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.SpotProvisioningSpecification, BaseFunction>? SpotSpecification { get; set; }
        }

        public class InstanceFleetResizingSpecifications : Humidifier.Base.BaseSubResource, IHaveEMRInstanceFleetConfigTypesOnDemandResizingSpecificationOnDemandResizeSpecification, IHaveEMRInstanceFleetConfigTypesSpotResizingSpecificationSpotResizeSpecification
        {
            /// <summary>
            /// OnDemandResizeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetresizingspecifications.html#cfn-elasticmapreduce-instancefleetconfig-instancefleetresizingspecifications-ondemandresizespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandResizingSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification, BaseFunction>? OnDemandResizeSpecification { get; set; }
            /// <summary>
            /// SpotResizeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetresizingspecifications.html#cfn-elasticmapreduce-instancefleetconfig-instancefleetresizingspecifications-spotresizespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotResizingSpecification
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.SpotResizingSpecification, BaseFunction>? SpotResizeSpecification { get; set; }
        }

        public class InstanceTypeConfig : Humidifier.Base.BaseSubResource, IHaveBidPrice, IHaveBidPriceAsPercentageOfOnDemandPrice_Double, IHaveListOfEMRInstanceFleetConfigTypesConfigurationConfigurations, IHaveCustomAmiId, IHaveEMRInstanceFleetConfigTypesEbsConfigurationEbsConfiguration, IHaveInstanceType, IHavePriority_Double, IHaveWeightedCapacity_Integer
        {
            /// <summary>
            /// BidPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-bidprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BidPrice { get; set; }
            /// <summary>
            /// BidPriceAsPercentageOfOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-bidpriceaspercentageofondemandprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BidPriceAsPercentageOfOnDemandPrice { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EMR.InstanceFleetConfigTypes.Configuration>, IReadOnlyList<Union<Humidifier.EMR.InstanceFleetConfigTypes.Configuration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
            /// <summary>
            /// CustomAmiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-customamiid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomAmiId { get; set; }
            /// <summary>
            /// EbsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-ebsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbsConfiguration
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration, BaseFunction>? EbsConfiguration { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Priority { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-weightedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? WeightedCapacity { get; set; }
        }

        public class OnDemandCapacityReservationOptions : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference, IHaveCapacityReservationResourceGroupArn, IHaveUsageStrategy
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-elasticmapreduce-instancefleetconfig-ondemandcapacityreservationoptions-capacityreservationpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
            /// <summary>
            /// CapacityReservationResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-elasticmapreduce-instancefleetconfig-ondemandcapacityreservationoptions-capacityreservationresourcegrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationResourceGroupArn { get; set; }
            /// <summary>
            /// UsageStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-elasticmapreduce-instancefleetconfig-ondemandcapacityreservationoptions-usagestrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsageStrategy { get; set; }
        }

        public class OnDemandProvisioningSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveEMRInstanceFleetConfigTypesOnDemandCapacityReservationOptionsCapacityReservationOptions
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ondemandprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-ondemandprovisioningspecification-allocationstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ondemandprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-ondemandprovisioningspecification-capacityreservationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandCapacityReservationOptions
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions, BaseFunction>? CapacityReservationOptions { get; set; }
        }

        public class OnDemandResizingSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveEMRInstanceFleetConfigTypesOnDemandCapacityReservationOptionsCapacityReservationOptions, IHaveTimeoutDurationMinutes_Integer
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ondemandresizingspecification.html#cfn-elasticmapreduce-instancefleetconfig-ondemandresizingspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ondemandresizingspecification.html#cfn-elasticmapreduce-instancefleetconfig-ondemandresizingspecification-capacityreservationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandCapacityReservationOptions
            /// </summary>
            public Union<Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions, BaseFunction>? CapacityReservationOptions { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ondemandresizingspecification.html#cfn-elasticmapreduce-instancefleetconfig-ondemandresizingspecification-timeoutdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
        }

        public class SpotProvisioningSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveBlockDurationMinutes_Integer, IHaveTimeoutAction, IHaveTimeoutDurationMinutes_Integer
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotprovisioningspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// BlockDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotprovisioningspecification-blockdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BlockDurationMinutes { get; set; }
            /// <summary>
            /// TimeoutAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotprovisioningspecification-timeoutaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeoutAction { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotprovisioningspecification-timeoutdurationminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
        }

        public class SpotResizingSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveTimeoutDurationMinutes_Integer
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotresizingspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotresizingspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotresizingspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotresizingspecification-timeoutdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutDurationMinutes { get; set; }
        }

        public class VolumeSpecification : Humidifier.Base.BaseSubResource, IHaveIops_Integer, IHaveSizeInGB_Integer, IHaveThroughput_Integer, IHaveVolumeType
        {
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-volumespecification.html#cfn-elasticmapreduce-instancefleetconfig-volumespecification-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Iops { get; set; }
            /// <summary>
            /// SizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-volumespecification.html#cfn-elasticmapreduce-instancefleetconfig-volumespecification-sizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SizeInGB { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-volumespecification.html#cfn-elasticmapreduce-instancefleetconfig-volumespecification-throughput
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Throughput { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-volumespecification.html#cfn-elasticmapreduce-instancefleetconfig-volumespecification-volumetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VolumeType { get; set; }
        }
    }
}