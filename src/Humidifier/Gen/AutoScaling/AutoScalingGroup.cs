namespace Humidifier.AutoScaling
{
    using System.Collections.Generic;
    using AutoScalingGroupTypes;

    public class AutoScalingGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveInstanceId, IHaveMinSize, IHaveMaxSize, IHaveAvailabilityZones, IHaveContext, IHaveAutoScalingGroupName, IHaveCooldown, IHaveDesiredCapacity, IHaveLaunchConfigurationName, IHavePlacementGroup
    {
        public override string AWSTypeName { get => AWS.AutoScaling.AutoScalingGroup; }
        /// <summary>
        /// LifecycleHookSpecificationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecificationlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LifecycleHookSpecification
        /// </summary>
        public List<Humidifier.AutoScaling.AutoScalingGroupTypes.LifecycleHookSpecification> LifecycleHookSpecificationList { get; set; }
        /// <summary>
        /// LoadBalancerNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-loadbalancernames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic LoadBalancerNames { get; set; }
        /// <summary>
        /// LaunchConfigurationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-launchconfigurationname
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic LaunchConfigurationName { get; set; }
        /// <summary>
        /// ServiceLinkedRoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-servicelinkedrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceLinkedRoleARN { get; set; }
        /// <summary>
        /// AvailabilityZoneImpairmentPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AvailabilityZoneImpairmentPolicy
        /// </summary>
        public Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneImpairmentPolicy AvailabilityZoneImpairmentPolicy { get; set; }
        /// <summary>
        /// TargetGroupARNs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-targetgrouparns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic TargetGroupARNs { get; set; }
        /// <summary>
        /// Cooldown
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-cooldown
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cooldown { get; set; }
        /// <summary>
        /// NotificationConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-notificationconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotificationConfiguration
        /// </summary>
        public List<Humidifier.AutoScaling.AutoScalingGroupTypes.NotificationConfiguration> NotificationConfigurations { get; set; }
        /// <summary>
        /// DesiredCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-desiredcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DesiredCapacity { get; set; }
        /// <summary>
        /// HealthCheckGracePeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-healthcheckgraceperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic HealthCheckGracePeriod { get; set; }
        /// <summary>
        /// DefaultInstanceWarmup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-defaultinstancewarmup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic DefaultInstanceWarmup { get; set; }
        /// <summary>
        /// SkipZonalShiftValidation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-skipzonalshiftvalidation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic SkipZonalShiftValidation { get; set; }
        /// <summary>
        /// NewInstancesProtectedFromScaleIn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-newinstancesprotectedfromscalein
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic NewInstancesProtectedFromScaleIn { get; set; }
        /// <summary>
        /// LaunchTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-launchtemplate
        /// Required: False
        /// UpdateType: Conditional
        /// Type: LaunchTemplateSpecification
        /// </summary>
        public Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification LaunchTemplate { get; set; }
        /// <summary>
        /// MixedInstancesPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-mixedinstancespolicy
        /// Required: False
        /// UpdateType: Conditional
        /// Type: MixedInstancesPolicy
        /// </summary>
        public Humidifier.AutoScaling.AutoScalingGroupTypes.MixedInstancesPolicy MixedInstancesPolicy { get; set; }
        /// <summary>
        /// VPCZoneIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-vpczoneidentifier
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic VPCZoneIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagProperty
        /// </summary>
        public List<Humidifier.AutoScaling.AutoScalingGroupTypes.TagProperty> Tags { get; set; }
        /// <summary>
        /// Context
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-context
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Context { get; set; }
        /// <summary>
        /// CapacityRebalance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-capacityrebalance
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CapacityRebalance { get; set; }
        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-instanceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceId { get; set; }
        /// <summary>
        /// AvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-availabilityzones
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AvailabilityZones { get; set; }
        /// <summary>
        /// AvailabilityZoneDistribution
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-availabilityzonedistribution
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AvailabilityZoneDistribution
        /// </summary>
        public Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneDistribution AvailabilityZoneDistribution { get; set; }
        /// <summary>
        /// MetricsCollection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-metricscollection
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricsCollection
        /// </summary>
        public List<Humidifier.AutoScaling.AutoScalingGroupTypes.MetricsCollection> MetricsCollection { get; set; }
        /// <summary>
        /// InstanceMaintenancePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-instancemaintenancepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceMaintenancePolicy
        /// </summary>
        public Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceMaintenancePolicy InstanceMaintenancePolicy { get; set; }

        /// <summary>
        /// MaxSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-maxsize
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MaxSize { get; set; }

        /// <summary>
        /// MinSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-minsize
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MinSize { get; set; }
        /// <summary>
        /// TerminationPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-terminationpolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic TerminationPolicies { get; set; }
        public dynamic AutoScalingGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TrafficSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-trafficsources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TrafficSourceIdentifier
        /// </summary>
        public List<Humidifier.AutoScaling.AutoScalingGroupTypes.TrafficSourceIdentifier> TrafficSources { get; set; }
        /// <summary>
        /// DesiredCapacityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-desiredcapacitytype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DesiredCapacityType { get; set; }
        /// <summary>
        /// PlacementGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-placementgroup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PlacementGroup { get; set; }
        /// <summary>
        /// CapacityReservationSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-capacityreservationspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityReservationSpecification
        /// </summary>
        public Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationSpecification CapacityReservationSpecification { get; set; }
        /// <summary>
        /// HealthCheckType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-healthchecktype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic HealthCheckType { get; set; }
        /// <summary>
        /// MaxInstanceLifetime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-maxinstancelifetime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxInstanceLifetime { get; set; }
    }

    namespace AutoScalingGroupTypes
    {
        public class AcceleratorCountRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-acceleratorcountrequest.html#cfn-autoscaling-autoscalinggroup-acceleratorcountrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-acceleratorcountrequest.html#cfn-autoscaling-autoscalinggroup-acceleratorcountrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class AcceleratorTotalMemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-acceleratortotalmemorymibrequest.html#cfn-autoscaling-autoscalinggroup-acceleratortotalmemorymibrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-acceleratortotalmemorymibrequest.html#cfn-autoscaling-autoscalinggroup-acceleratortotalmemorymibrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class AvailabilityZoneDistribution : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CapacityDistributionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-availabilityzonedistribution.html#cfn-autoscaling-autoscalinggroup-availabilityzonedistribution-capacitydistributionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityDistributionStrategy { get; set; }
        }

        public class AvailabilityZoneImpairmentPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ZonalShiftEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy.html#cfn-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy-zonalshiftenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ZonalShiftEnabled { get; set; }
            /// <summary>
            /// ImpairedZoneHealthCheckBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy.html#cfn-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy-impairedzonehealthcheckbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImpairedZoneHealthCheckBehavior { get; set; }
        }

        public class BaselineEbsBandwidthMbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-baselineebsbandwidthmbpsrequest.html#cfn-autoscaling-autoscalinggroup-baselineebsbandwidthmbpsrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-baselineebsbandwidthmbpsrequest.html#cfn-autoscaling-autoscalinggroup-baselineebsbandwidthmbpsrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class BaselinePerformanceFactorsRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-baselineperformancefactorsrequest.html#cfn-autoscaling-autoscalinggroup-baselineperformancefactorsrequest-cpu
            /// Required: False
            /// UpdateType: Conditional
            /// Type: CpuPerformanceFactorRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.CpuPerformanceFactorRequest Cpu { get; set; }
        }

        public class CapacityReservationSpecification : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-capacityreservationspecification.html#cfn-autoscaling-autoscalinggroup-capacityreservationspecification-capacityreservationpreference
            /// Required: True
            /// UpdateType: Mutable
            /// Type: dynamic
            /// PrimitiveType: String
            /// </summary>
            public dynamic CapacityReservationPreference { get; set; }
            /// <summary>
            /// CapacityReservationTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-capacityreservationspecification.html#cfn-autoscaling-autoscalinggroup-capacityreservationspecification-capacityreservationtarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityReservationTarget
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget CapacityReservationTarget { get; set; }
        }

        public class CapacityReservationTarget : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CapacityReservationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-capacityreservationtarget.html#cfn-autoscaling-autoscalinggroup-capacityreservationtarget-capacityreservationids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CapacityReservationIds { get; set; }
            /// <summary>
            /// CapacityReservationResourceGroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-capacityreservationtarget.html#cfn-autoscaling-autoscalinggroup-capacityreservationtarget-capacityreservationresourcegrouparns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CapacityReservationResourceGroupArns { get; set; }
        }

        public class CpuPerformanceFactorRequest : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// References
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-cpuperformancefactorrequest.html#cfn-autoscaling-autoscalinggroup-cpuperformancefactorrequest-references
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: PerformanceFactorReferenceRequest
            /// </summary>
            public List<Humidifier.AutoScaling.AutoScalingGroupTypes.PerformanceFactorReferenceRequest> References { get; set; }
        }

        public class InstanceMaintenancePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaxHealthyPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancemaintenancepolicy.html#cfn-autoscaling-autoscalinggroup-instancemaintenancepolicy-maxhealthypercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxHealthyPercentage { get; set; }
            /// <summary>
            /// MinHealthyPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancemaintenancepolicy.html#cfn-autoscaling-autoscalinggroup-instancemaintenancepolicy-minhealthypercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinHealthyPercentage { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveAcceleratorTypes, IHaveExcludedInstanceTypes, IHaveAllowedInstanceTypes, IHaveInstanceGenerations, IHaveAcceleratorManufacturers, IHaveLocalStorage, IHaveCpuManufacturers, IHaveBareMetal, IHaveRequireHibernateSupport, IHaveMaxSpotPriceAsPercentageOfOptimalOnDemandPrice, IHaveOnDemandMaxPricePercentageOverLowestPrice, IHaveLocalStorageTypes, IHaveSpotMaxPricePercentageOverLowestPrice, IHaveAcceleratorNames, IHaveBurstablePerformance
        {
            /// <summary>
            /// InstanceGenerations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-instancegenerations
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InstanceGenerations { get; set; }
            /// <summary>
            /// AcceleratorTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratortypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AcceleratorTypes { get; set; }
            /// <summary>
            /// MemoryGiBPerVCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-memorygibpervcpu
            /// Required: False
            /// UpdateType: Conditional
            /// Type: MemoryGiBPerVCpuRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.MemoryGiBPerVCpuRequest MemoryGiBPerVCpu { get; set; }
            /// <summary>
            /// AcceleratorManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratormanufacturers
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AcceleratorManufacturers { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-vcpucount
            /// Required: True
            /// UpdateType: Conditional
            /// Type: VCpuCountRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.VCpuCountRequest VCpuCount { get; set; }
            /// <summary>
            /// LocalStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-localstorage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocalStorage { get; set; }
            /// <summary>
            /// CpuManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-cpumanufacturers
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CpuManufacturers { get; set; }
            /// <summary>
            /// BareMetal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-baremetal
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic BareMetal { get; set; }
            /// <summary>
            /// RequireHibernateSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-requirehibernatesupport
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RequireHibernateSupport { get; set; }
            /// <summary>
            /// MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-maxspotpriceaspercentageofoptimalondemandprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }
            /// <summary>
            /// OnDemandMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-ondemandmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OnDemandMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-memorymib
            /// Required: True
            /// UpdateType: Conditional
            /// Type: MemoryMiBRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.MemoryMiBRequest MemoryMiB { get; set; }
            /// <summary>
            /// LocalStorageTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-localstoragetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic LocalStorageTypes { get; set; }
            /// <summary>
            /// NetworkInterfaceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-networkinterfacecount
            /// Required: False
            /// UpdateType: Conditional
            /// Type: NetworkInterfaceCountRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.NetworkInterfaceCountRequest NetworkInterfaceCount { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-excludedinstancetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-allowedinstancetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedInstanceTypes { get; set; }
            /// <summary>
            /// AcceleratorCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratorcount
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AcceleratorCountRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.AcceleratorCountRequest AcceleratorCount { get; set; }
            /// <summary>
            /// NetworkBandwidthGbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-networkbandwidthgbps
            /// Required: False
            /// UpdateType: Conditional
            /// Type: NetworkBandwidthGbpsRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.NetworkBandwidthGbpsRequest NetworkBandwidthGbps { get; set; }
            /// <summary>
            /// BaselinePerformanceFactors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-baselineperformancefactors
            /// Required: False
            /// UpdateType: Conditional
            /// Type: BaselinePerformanceFactorsRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.BaselinePerformanceFactorsRequest BaselinePerformanceFactors { get; set; }
            /// <summary>
            /// BaselineEbsBandwidthMbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-baselineebsbandwidthmbps
            /// Required: False
            /// UpdateType: Conditional
            /// Type: BaselineEbsBandwidthMbpsRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.BaselineEbsBandwidthMbpsRequest BaselineEbsBandwidthMbps { get; set; }
            /// <summary>
            /// SpotMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-spotmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SpotMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// AcceleratorNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratornames
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AcceleratorNames { get; set; }
            /// <summary>
            /// AcceleratorTotalMemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratortotalmemorymib
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AcceleratorTotalMemoryMiBRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.AcceleratorTotalMemoryMiBRequest AcceleratorTotalMemoryMiB { get; set; }
            /// <summary>
            /// BurstablePerformance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-burstableperformance
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic BurstablePerformance { get; set; }
            /// <summary>
            /// TotalLocalStorageGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-totallocalstoragegb
            /// Required: False
            /// UpdateType: Conditional
            /// Type: TotalLocalStorageGBRequest
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.TotalLocalStorageGBRequest TotalLocalStorageGB { get; set; }
        }

        public class InstancesDistribution : Humidifier.Base.BaseSubResource, IHaveOnDemandAllocationStrategy
        {
            /// <summary>
            /// OnDemandAllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-ondemandallocationstrategy
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnDemandAllocationStrategy { get; set; }
            /// <summary>
            /// OnDemandBaseCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-ondemandbasecapacity
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OnDemandBaseCapacity { get; set; }
            /// <summary>
            /// OnDemandPercentageAboveBaseCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-ondemandpercentageabovebasecapacity
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OnDemandPercentageAboveBaseCapacity { get; set; }
            /// <summary>
            /// SpotInstancePools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-spotinstancepools
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SpotInstancePools { get; set; }
            /// <summary>
            /// SpotAllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-spotallocationstrategy
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpotAllocationStrategy { get; set; }
            /// <summary>
            /// SpotMaxPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-spotmaxprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpotMaxPrice { get; set; }
        }

        public class LaunchTemplate : Humidifier.Base.BaseSubResource, IHaveAutoScalingAutoScalingGroupTypesLaunchTemplateSpecificationLaunchTemplateSpecification
        {
            /// <summary>
            /// LaunchTemplateSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplate.html#cfn-autoscaling-autoscalinggroup-launchtemplate-launchtemplatespecification
            /// Required: True
            /// UpdateType: Conditional
            /// Type: LaunchTemplateSpecification
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification LaunchTemplateSpecification { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplate.html#cfn-autoscaling-autoscalinggroup-launchtemplate-overrides
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: LaunchTemplateOverrides
            /// </summary>
            public List<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateOverrides> Overrides { get; set; }
        }

        public class LaunchTemplateOverrides : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveWeightedCapacity, IHaveAutoScalingAutoScalingGroupTypesLaunchTemplateSpecificationLaunchTemplateSpecification
        {
            /// <summary>
            /// LaunchTemplateSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-launchtemplatespecification
            /// Required: False
            /// UpdateType: Conditional
            /// Type: LaunchTemplateSpecification
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification LaunchTemplateSpecification { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-weightedcapacity
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic WeightedCapacity { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-instancerequirements
            /// Required: False
            /// UpdateType: Conditional
            /// Type: InstanceRequirements
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceRequirements InstanceRequirements { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-instancetype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class LaunchTemplateSpecification : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveLaunchTemplateName, IHaveLaunchTemplateId
        {
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplatespecification.html#cfn-autoscaling-autoscalinggroup-launchtemplatespecification-launchtemplatename
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchTemplateName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplatespecification.html#cfn-autoscaling-autoscalinggroup-launchtemplatespecification-version
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplatespecification.html#cfn-autoscaling-autoscalinggroup-launchtemplatespecification-launchtemplateid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchTemplateId { get; set; }
        }

        public class LifecycleHookSpecification : Humidifier.Base.BaseSubResource, IHaveRoleARN, IHaveLifecycleHookName, IHaveLifecycleTransition, IHaveHeartbeatTimeout, IHaveNotificationMetadata, IHaveDefaultResult, IHaveNotificationTargetARN
        {
            /// <summary>
            /// LifecycleHookName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-lifecyclehookname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LifecycleHookName { get; set; }
            /// <summary>
            /// LifecycleTransition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-lifecycletransition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LifecycleTransition { get; set; }
            /// <summary>
            /// HeartbeatTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-heartbeattimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HeartbeatTimeout { get; set; }
            /// <summary>
            /// NotificationMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-notificationmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotificationMetadata { get; set; }
            /// <summary>
            /// DefaultResult
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-defaultresult
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultResult { get; set; }
            /// <summary>
            /// NotificationTargetARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-notificationtargetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NotificationTargetARN { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN { get; set; }
        }

        public class MemoryGiBPerVCpuRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-memorygibpervcpurequest.html#cfn-autoscaling-autoscalinggroup-memorygibpervcpurequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-memorygibpervcpurequest.html#cfn-autoscaling-autoscalinggroup-memorygibpervcpurequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class MemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-memorymibrequest.html#cfn-autoscaling-autoscalinggroup-memorymibrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-memorymibrequest.html#cfn-autoscaling-autoscalinggroup-memorymibrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class MetricsCollection : Humidifier.Base.BaseSubResource, IHaveGranularity, IHaveMetrics
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-metricscollection.html#cfn-autoscaling-autoscalinggroup-metricscollection-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Metrics { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-metricscollection.html#cfn-autoscaling-autoscalinggroup-metricscollection-granularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Granularity { get; set; }
        }

        public class MixedInstancesPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// InstancesDistribution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-mixedinstancespolicy.html#cfn-autoscaling-autoscalinggroup-mixedinstancespolicy-instancesdistribution
            /// Required: False
            /// UpdateType: Conditional
            /// Type: InstancesDistribution
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.InstancesDistribution InstancesDistribution { get; set; }
            /// <summary>
            /// LaunchTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-mixedinstancespolicy.html#cfn-autoscaling-autoscalinggroup-mixedinstancespolicy-launchtemplate
            /// Required: True
            /// UpdateType: Conditional
            /// Type: LaunchTemplate
            /// </summary>
            public Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplate LaunchTemplate { get; set; }
        }

        public class NetworkBandwidthGbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-networkbandwidthgbpsrequest.html#cfn-autoscaling-autoscalinggroup-networkbandwidthgbpsrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-networkbandwidthgbpsrequest.html#cfn-autoscaling-autoscalinggroup-networkbandwidthgbpsrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class NetworkInterfaceCountRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-networkinterfacecountrequest.html#cfn-autoscaling-autoscalinggroup-networkinterfacecountrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-networkinterfacecountrequest.html#cfn-autoscaling-autoscalinggroup-networkinterfacecountrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class NotificationConfiguration : Humidifier.Base.BaseSubResource, IHaveTopicARN
        {
            /// <summary>
            /// TopicARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-notificationconfiguration.html#cfn-autoscaling-autoscalinggroup-notificationconfiguration-topicarn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TopicARN { get; set; }
            /// <summary>
            /// NotificationTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-notificationconfiguration.html#cfn-autoscaling-autoscalinggroup-notificationconfiguration-notificationtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NotificationTypes { get; set; }
        }

        public class PerformanceFactorReferenceRequest : Humidifier.Base.BaseSubResource, IHaveInstanceFamily
        {
            /// <summary>
            /// InstanceFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-performancefactorreferencerequest.html#cfn-autoscaling-autoscalinggroup-performancefactorreferencerequest-instancefamily
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceFamily { get; set; }
        }

        public class TagProperty : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-tagproperty.html#cfn-autoscaling-autoscalinggroup-tagproperty-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-tagproperty.html#cfn-autoscaling-autoscalinggroup-tagproperty-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
            /// <summary>
            /// PropagateAtLaunch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-tagproperty.html#cfn-autoscaling-autoscalinggroup-tagproperty-propagateatlaunch
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic PropagateAtLaunch { get; set; }
        }

        public class TotalLocalStorageGBRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-totallocalstoragegbrequest.html#cfn-autoscaling-autoscalinggroup-totallocalstoragegbrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-totallocalstoragegbrequest.html#cfn-autoscaling-autoscalinggroup-totallocalstoragegbrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Max { get; set; }
        }

        public class TrafficSourceIdentifier : Humidifier.Base.BaseSubResource, IHaveType, IHaveIdentifier
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-trafficsourceidentifier.html#cfn-autoscaling-autoscalinggroup-trafficsourceidentifier-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-trafficsourceidentifier.html#cfn-autoscaling-autoscalinggroup-trafficsourceidentifier-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Identifier { get; set; }
        }

        public class VCpuCountRequest : Humidifier.Base.BaseSubResource, IHaveMin, IHaveMax
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-vcpucountrequest.html#cfn-autoscaling-autoscalinggroup-vcpucountrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-vcpucountrequest.html#cfn-autoscaling-autoscalinggroup-vcpucountrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Max { get; set; }
        }
    }
}