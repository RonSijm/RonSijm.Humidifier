namespace Humidifier.ECS
{
    using global::System.Collections.Generic;
    using CapacityProviderTypes;

    public class CapacityProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveECSCapacityProviderTypesAutoScalingGroupProviderAutoScalingGroupProvider, IHaveClusterName, IHaveName, IHaveECSCapacityProviderTypesManagedInstancesProviderManagedInstancesProvider
    {
        public override string AWSTypeName { get => AWS.ECS.CapacityProvider; }
        /// <summary>
        /// AutoScalingGroupProvider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-capacityprovider.html#cfn-ecs-capacityprovider-autoscalinggroupprovider
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoScalingGroupProvider
        /// </summary>
        public Union<Humidifier.ECS.CapacityProviderTypes.AutoScalingGroupProvider, BaseFunction>? AutoScalingGroupProvider { get; set; }
        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-capacityprovider.html#cfn-ecs-capacityprovider-clustername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClusterName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-capacityprovider.html#cfn-ecs-capacityprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ManagedInstancesProvider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecs-capacityprovider.html#cfn-ecs-capacityprovider-managedinstancesprovider
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ManagedInstancesProvider
        /// </summary>
        public Union<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesProvider, BaseFunction>? ManagedInstancesProvider { get; set; }
    }

    namespace CapacityProviderTypes
    {
        public class AcceleratorCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-acceleratorcountrequest.html#cfn-ecs-capacityprovider-acceleratorcountrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-acceleratorcountrequest.html#cfn-ecs-capacityprovider-acceleratorcountrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class AcceleratorTotalMemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-acceleratortotalmemorymibrequest.html#cfn-ecs-capacityprovider-acceleratortotalmemorymibrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-acceleratortotalmemorymibrequest.html#cfn-ecs-capacityprovider-acceleratortotalmemorymibrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class AutoRepairConfiguration : Humidifier.Base.BaseSubResource, IHaveActionsStatus
        {
            /// <summary>
            /// ActionsStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-autorepairconfiguration.html#cfn-ecs-capacityprovider-autorepairconfiguration-actionsstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionsStatus { get; set; }
        }

        public class AutoScalingGroupProvider : Humidifier.Base.BaseSubResource, IHaveECSCapacityProviderTypesManagedScalingManagedScaling, IHaveAutoScalingGroupArn, IHaveManagedTerminationProtection, IHaveManagedDraining
        {
            /// <summary>
            /// ManagedScaling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-autoscalinggroupprovider.html#cfn-ecs-capacityprovider-autoscalinggroupprovider-managedscaling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedScaling
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.ManagedScaling, BaseFunction>? ManagedScaling { get; set; }
            /// <summary>
            /// AutoScalingGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-autoscalinggroupprovider.html#cfn-ecs-capacityprovider-autoscalinggroupprovider-autoscalinggrouparn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutoScalingGroupArn { get; set; }
            /// <summary>
            /// ManagedTerminationProtection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-autoscalinggroupprovider.html#cfn-ecs-capacityprovider-autoscalinggroupprovider-managedterminationprotection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedTerminationProtection { get; set; }
            /// <summary>
            /// ManagedDraining
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-autoscalinggroupprovider.html#cfn-ecs-capacityprovider-autoscalinggroupprovider-manageddraining
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedDraining { get; set; }
        }

        public class BaselineEbsBandwidthMbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-baselineebsbandwidthmbpsrequest.html#cfn-ecs-capacityprovider-baselineebsbandwidthmbpsrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-baselineebsbandwidthmbpsrequest.html#cfn-ecs-capacityprovider-baselineebsbandwidthmbpsrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class CapacityReservationRequest : Humidifier.Base.BaseSubResource, IHaveReservationGroupArn, IHaveReservationPreference
        {
            /// <summary>
            /// ReservationGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-capacityreservationrequest.html#cfn-ecs-capacityprovider-capacityreservationrequest-reservationgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReservationGroupArn { get; set; }
            /// <summary>
            /// ReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-capacityreservationrequest.html#cfn-ecs-capacityprovider-capacityreservationrequest-reservationpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReservationPreference { get; set; }
        }

        public class InfrastructureOptimization : Humidifier.Base.BaseSubResource, IHaveScaleInAfter_Integer
        {
            /// <summary>
            /// ScaleInAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-infrastructureoptimization.html#cfn-ecs-capacityprovider-infrastructureoptimization-scaleinafter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleInAfter { get; set; }
        }

        public class InstanceLaunchTemplate : Humidifier.Base.BaseSubResource, IHaveEc2InstanceProfileArn, IHaveCapacityOptionType, IHaveFipsEnabled_Boolean, IHaveInstanceMetadataTagsPropagation_Boolean, IHaveECSCapacityProviderTypesManagedInstancesStorageConfigurationStorageConfiguration, IHaveECSCapacityProviderTypesManagedInstancesNetworkConfigurationNetworkConfiguration, IHaveECSCapacityProviderTypesInstanceRequirementsRequestInstanceRequirements, IHaveECSCapacityProviderTypesCapacityReservationRequestCapacityReservations, IHaveECSCapacityProviderTypesManagedInstancesLocalStorageConfigurationLocalStorageConfiguration, IHaveMonitoring
        {
            /// <summary>
            /// Ec2InstanceProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-ec2instanceprofilearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ec2InstanceProfileArn { get; set; }
            /// <summary>
            /// CapacityOptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-capacityoptiontype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityOptionType { get; set; }
            /// <summary>
            /// FipsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-fipsenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FipsEnabled { get; set; }
            /// <summary>
            /// InstanceMetadataTagsPropagation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-instancemetadatatagspropagation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InstanceMetadataTagsPropagation { get; set; }
            /// <summary>
            /// StorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-storageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedInstancesStorageConfiguration
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesStorageConfiguration, BaseFunction>? StorageConfiguration { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-networkconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ManagedInstancesNetworkConfiguration
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesNetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-instancerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceRequirementsRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.InstanceRequirementsRequest, BaseFunction>? InstanceRequirements { get; set; }
            /// <summary>
            /// CapacityReservations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-capacityreservations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityReservationRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.CapacityReservationRequest, BaseFunction>? CapacityReservations { get; set; }
            /// <summary>
            /// LocalStorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-localstorageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedInstancesLocalStorageConfiguration
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesLocalStorageConfiguration, BaseFunction>? LocalStorageConfiguration { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancelaunchtemplate.html#cfn-ecs-capacityprovider-instancelaunchtemplate-monitoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Monitoring { get; set; }
        }

        public class InstanceRequirementsRequest : Humidifier.Base.BaseSubResource, IHaveStringListOfLocalStorageTypes, IHaveStringListOfInstanceGenerations, IHaveECSCapacityProviderTypesNetworkInterfaceCountRequestNetworkInterfaceCount, IHaveECSCapacityProviderTypesMemoryGiBPerVCpuRequestMemoryGiBPerVCpu, IHaveStringListOfAcceleratorTypes, IHaveECSCapacityProviderTypesVCpuCountRangeRequestVCpuCount, IHaveStringListOfExcludedInstanceTypes, IHaveStringListOfAcceleratorManufacturers, IHaveStringListOfAllowedInstanceTypes, IHaveLocalStorage, IHaveStringListOfCpuManufacturers, IHaveECSCapacityProviderTypesNetworkBandwidthGbpsRequestNetworkBandwidthGbps, IHaveECSCapacityProviderTypesAcceleratorCountRequestAcceleratorCount, IHaveBareMetal, IHaveRequireHibernateSupport_Boolean, IHaveMaxSpotPriceAsPercentageOfOptimalOnDemandPrice_Integer, IHaveSpotMaxPricePercentageOverLowestPrice_Integer, IHaveECSCapacityProviderTypesBaselineEbsBandwidthMbpsRequestBaselineEbsBandwidthMbps, IHaveOnDemandMaxPricePercentageOverLowestPrice_Integer, IHaveStringListOfAcceleratorNames, IHaveECSCapacityProviderTypesAcceleratorTotalMemoryMiBRequestAcceleratorTotalMemoryMiB, IHaveBurstablePerformance, IHaveECSCapacityProviderTypesMemoryMiBRequestMemoryMiB, IHaveECSCapacityProviderTypesTotalLocalStorageGBRequestTotalLocalStorageGB
        {
            /// <summary>
            /// LocalStorageTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-localstoragetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LocalStorageTypes { get; set; }
            /// <summary>
            /// InstanceGenerations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-instancegenerations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceGenerations { get; set; }
            /// <summary>
            /// NetworkInterfaceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-networkinterfacecount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkInterfaceCountRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.NetworkInterfaceCountRequest, BaseFunction>? NetworkInterfaceCount { get; set; }
            /// <summary>
            /// MemoryGiBPerVCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-memorygibpervcpu
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemoryGiBPerVCpuRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.MemoryGiBPerVCpuRequest, BaseFunction>? MemoryGiBPerVCpu { get; set; }
            /// <summary>
            /// AcceleratorTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-acceleratortypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorTypes { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-vcpucount
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VCpuCountRangeRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.VCpuCountRangeRequest, BaseFunction>? VCpuCount { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-excludedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// AcceleratorManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-acceleratormanufacturers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorManufacturers { get; set; }
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-allowedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
            /// <summary>
            /// LocalStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-localstorage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalStorage { get; set; }
            /// <summary>
            /// CpuManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-cpumanufacturers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CpuManufacturers { get; set; }
            /// <summary>
            /// NetworkBandwidthGbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-networkbandwidthgbps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkBandwidthGbpsRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.NetworkBandwidthGbpsRequest, BaseFunction>? NetworkBandwidthGbps { get; set; }
            /// <summary>
            /// AcceleratorCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-acceleratorcount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorCountRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.AcceleratorCountRequest, BaseFunction>? AcceleratorCount { get; set; }
            /// <summary>
            /// BareMetal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-baremetal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BareMetal { get; set; }
            /// <summary>
            /// RequireHibernateSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-requirehibernatesupport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireHibernateSupport { get; set; }
            /// <summary>
            /// MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-maxspotpriceaspercentageofoptimalondemandprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }
            /// <summary>
            /// SpotMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-spotmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpotMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// BaselineEbsBandwidthMbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-baselineebsbandwidthmbps
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BaselineEbsBandwidthMbpsRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.BaselineEbsBandwidthMbpsRequest, BaseFunction>? BaselineEbsBandwidthMbps { get; set; }
            /// <summary>
            /// OnDemandMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-ondemandmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// AcceleratorNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-acceleratornames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorNames { get; set; }
            /// <summary>
            /// AcceleratorTotalMemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-acceleratortotalmemorymib
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorTotalMemoryMiBRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.AcceleratorTotalMemoryMiBRequest, BaseFunction>? AcceleratorTotalMemoryMiB { get; set; }
            /// <summary>
            /// BurstablePerformance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-burstableperformance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BurstablePerformance { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-memorymib
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MemoryMiBRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.MemoryMiBRequest, BaseFunction>? MemoryMiB { get; set; }
            /// <summary>
            /// TotalLocalStorageGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-instancerequirementsrequest.html#cfn-ecs-capacityprovider-instancerequirementsrequest-totallocalstoragegb
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TotalLocalStorageGBRequest
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.TotalLocalStorageGBRequest, BaseFunction>? TotalLocalStorageGB { get; set; }
        }

        public class ManagedInstancesLocalStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveUseLocalStorage_Boolean
        {
            /// <summary>
            /// UseLocalStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstanceslocalstorageconfiguration.html#cfn-ecs-capacityprovider-managedinstanceslocalstorageconfiguration-uselocalstorage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UseLocalStorage { get; set; }
        }

        public class ManagedInstancesNetworkConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveStringListOfSubnets
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstancesnetworkconfiguration.html#cfn-ecs-capacityprovider-managedinstancesnetworkconfiguration-securitygroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstancesnetworkconfiguration.html#cfn-ecs-capacityprovider-managedinstancesnetworkconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        }

        public class ManagedInstancesProvider : Humidifier.Base.BaseSubResource, IHaveInfrastructureRoleArn, IHaveECSCapacityProviderTypesAutoRepairConfigurationAutoRepairConfiguration, IHavePropagateTags, IHaveECSCapacityProviderTypesInfrastructureOptimizationInfrastructureOptimization, IHaveECSCapacityProviderTypesInstanceLaunchTemplateInstanceLaunchTemplate
        {
            /// <summary>
            /// InfrastructureRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstancesprovider.html#cfn-ecs-capacityprovider-managedinstancesprovider-infrastructurerolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InfrastructureRoleArn { get; set; }
            /// <summary>
            /// AutoRepairConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstancesprovider.html#cfn-ecs-capacityprovider-managedinstancesprovider-autorepairconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoRepairConfiguration
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.AutoRepairConfiguration, BaseFunction>? AutoRepairConfiguration { get; set; }
            /// <summary>
            /// PropagateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstancesprovider.html#cfn-ecs-capacityprovider-managedinstancesprovider-propagatetags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropagateTags { get; set; }
            /// <summary>
            /// InfrastructureOptimization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstancesprovider.html#cfn-ecs-capacityprovider-managedinstancesprovider-infrastructureoptimization
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InfrastructureOptimization
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.InfrastructureOptimization, BaseFunction>? InfrastructureOptimization { get; set; }
            /// <summary>
            /// InstanceLaunchTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstancesprovider.html#cfn-ecs-capacityprovider-managedinstancesprovider-instancelaunchtemplate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InstanceLaunchTemplate
            /// </summary>
            public Union<Humidifier.ECS.CapacityProviderTypes.InstanceLaunchTemplate, BaseFunction>? InstanceLaunchTemplate { get; set; }
        }

        public class ManagedInstancesStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageSizeGiB_Integer
        {
            /// <summary>
            /// StorageSizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedinstancesstorageconfiguration.html#cfn-ecs-capacityprovider-managedinstancesstorageconfiguration-storagesizegib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageSizeGiB { get; set; }
        }

        public class ManagedScaling : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveMinimumScalingStepSize_Integer, IHaveInstanceWarmupPeriod_Integer, IHaveTargetCapacity_Integer, IHaveMaximumScalingStepSize_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedscaling.html#cfn-ecs-capacityprovider-managedscaling-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// MinimumScalingStepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedscaling.html#cfn-ecs-capacityprovider-managedscaling-minimumscalingstepsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinimumScalingStepSize { get; set; }
            /// <summary>
            /// InstanceWarmupPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedscaling.html#cfn-ecs-capacityprovider-managedscaling-instancewarmupperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? InstanceWarmupPeriod { get; set; }
            /// <summary>
            /// TargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedscaling.html#cfn-ecs-capacityprovider-managedscaling-targetcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetCapacity { get; set; }
            /// <summary>
            /// MaximumScalingStepSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-managedscaling.html#cfn-ecs-capacityprovider-managedscaling-maximumscalingstepsize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumScalingStepSize { get; set; }
        }

        public class MemoryGiBPerVCpuRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-memorygibpervcpurequest.html#cfn-ecs-capacityprovider-memorygibpervcpurequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-memorygibpervcpurequest.html#cfn-ecs-capacityprovider-memorygibpervcpurequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class MemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-memorymibrequest.html#cfn-ecs-capacityprovider-memorymibrequest-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-memorymibrequest.html#cfn-ecs-capacityprovider-memorymibrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class NetworkBandwidthGbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-networkbandwidthgbpsrequest.html#cfn-ecs-capacityprovider-networkbandwidthgbpsrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-networkbandwidthgbpsrequest.html#cfn-ecs-capacityprovider-networkbandwidthgbpsrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class NetworkInterfaceCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-networkinterfacecountrequest.html#cfn-ecs-capacityprovider-networkinterfacecountrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-networkinterfacecountrequest.html#cfn-ecs-capacityprovider-networkinterfacecountrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class TotalLocalStorageGBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-totallocalstoragegbrequest.html#cfn-ecs-capacityprovider-totallocalstoragegbrequest-min
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-totallocalstoragegbrequest.html#cfn-ecs-capacityprovider-totallocalstoragegbrequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class VCpuCountRangeRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-vcpucountrangerequest.html#cfn-ecs-capacityprovider-vcpucountrangerequest-min
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-capacityprovider-vcpucountrangerequest.html#cfn-ecs-capacityprovider-vcpucountrangerequest-max
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }
    }
}