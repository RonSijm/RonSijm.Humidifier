namespace Humidifier.EMR
{
    using global::System.Collections.Generic;
    using InstanceFleetConfigTypes;

    public class InstanceFleetConfig : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveClusterId, IHaveTargetOnDemandCapacity, IHaveTargetSpotCapacity
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
        public dynamic InstanceFleetType { get; set; }
        /// <summary>
        /// TargetOnDemandCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-targetondemandcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TargetOnDemandCapacity { get; set; }

        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterId { get; set; }
        /// <summary>
        /// TargetSpotCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-targetspotcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic TargetSpotCapacity { get; set; }
        /// <summary>
        /// LaunchSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-launchspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InstanceFleetProvisioningSpecifications
        /// </summary>
        public Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetProvisioningSpecifications LaunchSpecifications { get; set; }
        /// <summary>
        /// ResizeSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-resizespecifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceFleetResizingSpecifications
        /// </summary>
        public Humidifier.EMR.InstanceFleetConfigTypes.InstanceFleetResizingSpecifications ResizeSpecifications { get; set; }
        /// <summary>
        /// InstanceTypeConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancefleetconfig.html#cfn-emr-instancefleetconfig-instancetypeconfigs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InstanceTypeConfig
        /// </summary>
        public List<Humidifier.EMR.InstanceFleetConfigTypes.InstanceTypeConfig> InstanceTypeConfigs { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace InstanceFleetConfigTypes
    {
        public class ApplicationConfiguration : Humidifier.Base.BaseSubResource, IHaveClassification
        {
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-applicationconfiguration.html#cfn-emr-instancefleetconfig-applicationconfiguration-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApplicationConfiguration
            /// </summary>
            public List<Humidifier.EMR.InstanceFleetConfigTypes.ApplicationConfiguration> Configurations { get; set; }
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-applicationconfiguration.html#cfn-emr-instancefleetconfig-applicationconfiguration-classification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Classification { get; set; }
            /// <summary>
            /// ConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-applicationconfiguration.html#cfn-emr-instancefleetconfig-applicationconfiguration-configurationproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ConfigurationProperties { get; set; }
        }

        public class EbsBlockDeviceConfig : Humidifier.Base.BaseSubResource, IHaveVolumesPerInstance
        {
            /// <summary>
            /// VolumeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ebsblockdeviceconfig.html#cfn-emr-instancefleetconfig-ebsblockdeviceconfig-volumespecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VolumeSpecification
            /// </summary>
            public Humidifier.EMR.InstanceFleetConfigTypes.VolumeSpecification VolumeSpecification { get; set; }
            /// <summary>
            /// VolumesPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ebsblockdeviceconfig.html#cfn-emr-instancefleetconfig-ebsblockdeviceconfig-volumesperinstance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumesPerInstance { get; set; }
        }

        public class EbsConfiguration : Humidifier.Base.BaseSubResource, IHaveEbsOptimized
        {
            /// <summary>
            /// EbsBlockDeviceConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ebsconfiguration.html#cfn-emr-instancefleetconfig-ebsconfiguration-ebsblockdeviceconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EbsBlockDeviceConfig
            /// </summary>
            public List<Humidifier.EMR.InstanceFleetConfigTypes.EbsBlockDeviceConfig> EbsBlockDeviceConfigs { get; set; }
            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ebsconfiguration.html#cfn-emr-instancefleetconfig-ebsconfiguration-ebsoptimized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EbsOptimized { get; set; }
        }

        public class InstanceFleetProvisioningSpecifications : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OnDemandSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancefleetprovisioningspecifications.html#cfn-emr-instancefleetconfig-instancefleetprovisioningspecifications-ondemandspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OnDemandProvisioningSpecification
            /// </summary>
            public Humidifier.EMR.InstanceFleetConfigTypes.OnDemandProvisioningSpecification OnDemandSpecification { get; set; }
            /// <summary>
            /// SpotSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancefleetprovisioningspecifications.html#cfn-emr-instancefleetconfig-instancefleetprovisioningspecifications-spotspecification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SpotProvisioningSpecification
            /// </summary>
            public Humidifier.EMR.InstanceFleetConfigTypes.SpotProvisioningSpecification SpotSpecification { get; set; }
        }

        public class InstanceFleetResizingSpecifications : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SpotResizeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancefleetresizingspecifications.html#cfn-emr-instancefleetconfig-instancefleetresizingspecifications-spotresizespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotResizingSpecification
            /// </summary>
            public Humidifier.EMR.InstanceFleetConfigTypes.SpotResizingSpecification SpotResizeSpecification { get; set; }
            /// <summary>
            /// OnDemandResizeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancefleetresizingspecifications.html#cfn-emr-instancefleetconfig-instancefleetresizingspecifications-ondemandresizespecification
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandResizingSpecification
            /// </summary>
            public Humidifier.EMR.InstanceFleetConfigTypes.OnDemandResizingSpecification OnDemandResizeSpecification { get; set; }
        }

        public class InstanceTypeConfig : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHavePriority, IHaveWeightedCapacity, IHaveCustomAmiId, IHaveBidPrice, IHaveBidPriceAsPercentageOfOnDemandPrice
        {
            /// <summary>
            /// BidPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-bidprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BidPrice { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-weightedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WeightedCapacity { get; set; }
            /// <summary>
            /// EbsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-ebsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbsConfiguration
            /// </summary>
            public Humidifier.EMR.InstanceFleetConfigTypes.EbsConfiguration EbsConfiguration { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// BidPriceAsPercentageOfOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-bidpriceaspercentageofondemandprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BidPriceAsPercentageOfOnDemandPrice { get; set; }
            /// <summary>
            /// CustomAmiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-customamiid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomAmiId { get; set; }
            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ApplicationConfiguration
            /// </summary>
            public List<Humidifier.EMR.InstanceFleetConfigTypes.ApplicationConfiguration> Configurations { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-instancetypeconfig.html#cfn-emr-instancefleetconfig-instancetypeconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class OnDemandCapacityReservationOptions : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference, IHaveUsageStrategy, IHaveCapacityReservationResourceGroupArn
        {
            /// <summary>
            /// UsageStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-emr-instancefleetconfig-ondemandcapacityreservationoptions-usagestrategy
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic UsageStrategy { get; set; }
            /// <summary>
            /// CapacityReservationResourceGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-emr-instancefleetconfig-ondemandcapacityreservationoptions-capacityreservationresourcegrouparn
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityReservationResourceGroupArn { get; set; }
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandcapacityreservationoptions.html#cfn-emr-instancefleetconfig-ondemandcapacityreservationoptions-capacityreservationpreference
            /// Required: False
            /// UpdateType: Conditional
            /// Type: dynamic
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityReservationPreference { get; set; }
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
            public dynamic AllocationStrategy { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandprovisioningspecification.html#cfn-emr-instancefleetconfig-ondemandprovisioningspecification-capacityreservationoptions
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OnDemandCapacityReservationOptions
            /// </summary>
            public Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions CapacityReservationOptions { get; set; }
        }

        public class OnDemandResizingSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveTimeoutDurationMinutes, IHaveEMRInstanceFleetConfigTypesOnDemandCapacityReservationOptionsCapacityReservationOptions
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandresizingspecification.html#cfn-emr-instancefleetconfig-ondemandresizingspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllocationStrategy { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandresizingspecification.html#cfn-emr-instancefleetconfig-ondemandresizingspecification-timeoutdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutDurationMinutes { get; set; }
            /// <summary>
            /// CapacityReservationOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-ondemandresizingspecification.html#cfn-emr-instancefleetconfig-ondemandresizingspecification-capacityreservationoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnDemandCapacityReservationOptions
            /// </summary>
            public Humidifier.EMR.InstanceFleetConfigTypes.OnDemandCapacityReservationOptions CapacityReservationOptions { get; set; }
        }

        public class SpotProvisioningSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveTimeoutDurationMinutes, IHaveBlockDurationMinutes, IHaveTimeoutAction
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotprovisioningspecification.html#cfn-emr-instancefleetconfig-spotprovisioningspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllocationStrategy { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotprovisioningspecification.html#cfn-emr-instancefleetconfig-spotprovisioningspecification-timeoutdurationminutes
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutDurationMinutes { get; set; }
            /// <summary>
            /// TimeoutAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotprovisioningspecification.html#cfn-emr-instancefleetconfig-spotprovisioningspecification-timeoutaction
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeoutAction { get; set; }
            /// <summary>
            /// BlockDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotprovisioningspecification.html#cfn-emr-instancefleetconfig-spotprovisioningspecification-blockdurationminutes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BlockDurationMinutes { get; set; }
        }

        public class SpotResizingSpecification : Humidifier.Base.BaseSubResource, IHaveAllocationStrategy, IHaveTimeoutDurationMinutes
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotresizingspecification.html#cfn-emr-instancefleetconfig-spotresizingspecification-allocationstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllocationStrategy { get; set; }
            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-spotresizingspecification.html#cfn-emr-instancefleetconfig-spotresizingspecification-timeoutdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutDurationMinutes { get; set; }
        }

        public class VolumeSpecification : Humidifier.Base.BaseSubResource, IHaveIops, IHaveVolumeType, IHaveThroughput, IHaveSizeInGB
        {
            /// <summary>
            /// SizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-volumespecification.html#cfn-emr-instancefleetconfig-volumespecification-sizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInGB { get; set; }
            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-volumespecification.html#cfn-emr-instancefleetconfig-volumespecification-volumetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType { get; set; }
            /// <summary>
            /// Throughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-volumespecification.html#cfn-emr-instancefleetconfig-volumespecification-throughput
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Throughput { get; set; }
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-instancefleetconfig-volumespecification.html#cfn-emr-instancefleetconfig-volumespecification-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Iops { get; set; }
        }
    }
}