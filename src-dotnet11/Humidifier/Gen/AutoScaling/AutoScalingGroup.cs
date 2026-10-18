namespace Humidifier.AutoScaling
{
    using global::System.Collections.Generic;
    using AutoScalingGroupTypes;

    public class AutoScalingGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveListOfAutoScalingAutoScalingGroupTypesLifecycleHookSpecificationLifecycleHookSpecificationList, IHaveStringListOfLoadBalancerNames, IHaveLaunchConfigurationName, IHaveServiceLinkedRoleARN, IHaveAutoScalingAutoScalingGroupTypesAvailabilityZoneImpairmentPolicyAvailabilityZoneImpairmentPolicy, IHaveStringListOfTargetGroupARNs, IHaveStringListOfAvailabilityZoneIds, IHaveCooldown, IHaveListOfAutoScalingAutoScalingGroupTypesNotificationConfigurationNotificationConfigurations, IHaveDesiredCapacity, IHaveHealthCheckGracePeriod_Integer, IHaveAutoScalingAutoScalingGroupTypesInstanceLifecyclePolicyInstanceLifecyclePolicy, IHaveDefaultInstanceWarmup_Integer, IHaveSkipZonalShiftValidation_Boolean, IHaveNewInstancesProtectedFromScaleIn_Boolean, IHaveAutoScalingAutoScalingGroupTypesLaunchTemplateSpecificationLaunchTemplate, IHaveAutoScalingAutoScalingGroupTypesMixedInstancesPolicyMixedInstancesPolicy, IHaveStringListOfVPCZoneIdentifier, IHaveListOfAutoScalingAutoScalingGroupTypesTagPropertyTags, IHaveContext, IHaveCapacityRebalance_Boolean, IHaveInstanceId, IHaveStringListOfAvailabilityZones, IHaveAutoScalingAutoScalingGroupTypesAvailabilityZoneDistributionAvailabilityZoneDistribution, IHaveListOfAutoScalingAutoScalingGroupTypesMetricsCollectionMetricsCollection, IHaveDeletionProtection, IHaveAutoScalingAutoScalingGroupTypesInstanceMaintenancePolicyInstanceMaintenancePolicy, IHaveMaxSize, IHaveMinSize, IHaveStringListOfTerminationPolicies, IHaveAutoScalingGroupName, IHaveListOfAutoScalingAutoScalingGroupTypesTrafficSourceIdentifierTrafficSources, IHaveDesiredCapacityType, IHavePlacementGroup, IHaveAutoScalingAutoScalingGroupTypesCapacityReservationSpecificationCapacityReservationSpecification, IHaveHealthCheckType, IHaveMaxInstanceLifetime_Integer
    {
        public class Attributes
        {
            public static string AutoScalingGroupARN =  "AutoScalingGroupARN" ;
        }

        public override string AWSTypeName { get => AWS.AutoScaling.AutoScalingGroup; }
        /// <summary>
        /// LifecycleHookSpecificationList
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecificationlist
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: LifecycleHookSpecification
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AutoScaling.AutoScalingGroupTypes.LifecycleHookSpecification>, IReadOnlyList<Union<Humidifier.AutoScaling.AutoScalingGroupTypes.LifecycleHookSpecification, BaseFunction>>, BaseFunction>? LifecycleHookSpecificationList { get; set; }
        /// <summary>
        /// LoadBalancerNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-loadbalancernames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LoadBalancerNames { get; set; }
        /// <summary>
        /// LaunchConfigurationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-launchconfigurationname
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LaunchConfigurationName { get; set; }
        /// <summary>
        /// ServiceLinkedRoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-servicelinkedrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceLinkedRoleARN { get; set; }
        /// <summary>
        /// AvailabilityZoneImpairmentPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AvailabilityZoneImpairmentPolicy
        /// </summary>
        public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneImpairmentPolicy, BaseFunction>? AvailabilityZoneImpairmentPolicy { get; set; }
        /// <summary>
        /// TargetGroupARNs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-targetgrouparns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetGroupARNs { get; set; }
        /// <summary>
        /// AvailabilityZoneIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-availabilityzoneids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZoneIds { get; set; }
        /// <summary>
        /// Cooldown
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-cooldown
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Cooldown { get; set; }
        /// <summary>
        /// NotificationConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-notificationconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: NotificationConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AutoScaling.AutoScalingGroupTypes.NotificationConfiguration>, IReadOnlyList<Union<Humidifier.AutoScaling.AutoScalingGroupTypes.NotificationConfiguration, BaseFunction>>, BaseFunction>? NotificationConfigurations { get; set; }
        /// <summary>
        /// DesiredCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-desiredcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DesiredCapacity { get; set; }
        /// <summary>
        /// HealthCheckGracePeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-healthcheckgraceperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? HealthCheckGracePeriod { get; set; }
        /// <summary>
        /// InstanceLifecyclePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-instancelifecyclepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceLifecyclePolicy
        /// </summary>
        public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceLifecyclePolicy, BaseFunction>? InstanceLifecyclePolicy { get; set; }
        /// <summary>
        /// DefaultInstanceWarmup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-defaultinstancewarmup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DefaultInstanceWarmup { get; set; }
        /// <summary>
        /// SkipZonalShiftValidation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-skipzonalshiftvalidation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SkipZonalShiftValidation { get; set; }
        /// <summary>
        /// NewInstancesProtectedFromScaleIn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-newinstancesprotectedfromscalein
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NewInstancesProtectedFromScaleIn { get; set; }
        /// <summary>
        /// LaunchTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-launchtemplate
        /// Required: False
        /// UpdateType: Conditional
        /// Type: LaunchTemplateSpecification
        /// </summary>
        public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification, BaseFunction>? LaunchTemplate { get; set; }
        /// <summary>
        /// MixedInstancesPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-mixedinstancespolicy
        /// Required: False
        /// UpdateType: Conditional
        /// Type: MixedInstancesPolicy
        /// </summary>
        public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.MixedInstancesPolicy, BaseFunction>? MixedInstancesPolicy { get; set; }
        /// <summary>
        /// VPCZoneIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-vpczoneidentifier
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VPCZoneIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagProperty
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AutoScaling.AutoScalingGroupTypes.TagProperty>, IReadOnlyList<Union<Humidifier.AutoScaling.AutoScalingGroupTypes.TagProperty, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Context
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-context
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Context { get; set; }
        /// <summary>
        /// CapacityRebalance
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-capacityrebalance
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? CapacityRebalance { get; set; }
        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-instanceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InstanceId { get; set; }
        /// <summary>
        /// AvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-availabilityzones
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZones { get; set; }
        /// <summary>
        /// AvailabilityZoneDistribution
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-availabilityzonedistribution
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AvailabilityZoneDistribution
        /// </summary>
        public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.AvailabilityZoneDistribution, BaseFunction>? AvailabilityZoneDistribution { get; set; }
        /// <summary>
        /// MetricsCollection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-metricscollection
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricsCollection
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AutoScaling.AutoScalingGroupTypes.MetricsCollection>, IReadOnlyList<Union<Humidifier.AutoScaling.AutoScalingGroupTypes.MetricsCollection, BaseFunction>>, BaseFunction>? MetricsCollection { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// InstanceMaintenancePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-instancemaintenancepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceMaintenancePolicy
        /// </summary>
        public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceMaintenancePolicy, BaseFunction>? InstanceMaintenancePolicy { get; set; }

        /// <summary>
        /// MaxSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-maxsize
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MaxSize { get; set; }

        /// <summary>
        /// MinSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-minsize
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MinSize { get; set; }
        /// <summary>
        /// TerminationPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-terminationpolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TerminationPolicies { get; set; }
        public Union<string, BaseFunction>? AutoScalingGroupName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// TrafficSources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-trafficsources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TrafficSourceIdentifier
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AutoScaling.AutoScalingGroupTypes.TrafficSourceIdentifier>, IReadOnlyList<Union<Humidifier.AutoScaling.AutoScalingGroupTypes.TrafficSourceIdentifier, BaseFunction>>, BaseFunction>? TrafficSources { get; set; }
        /// <summary>
        /// DesiredCapacityType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-desiredcapacitytype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DesiredCapacityType { get; set; }
        /// <summary>
        /// PlacementGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-placementgroup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PlacementGroup { get; set; }
        /// <summary>
        /// CapacityReservationSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-capacityreservationspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapacityReservationSpecification
        /// </summary>
        public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationSpecification, BaseFunction>? CapacityReservationSpecification { get; set; }
        /// <summary>
        /// HealthCheckType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-healthchecktype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? HealthCheckType { get; set; }
        /// <summary>
        /// MaxInstanceLifetime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-autoscalinggroup.html#cfn-autoscaling-autoscalinggroup-maxinstancelifetime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxInstanceLifetime { get; set; }
    }

    namespace AutoScalingGroupTypes
    {
        public class AcceleratorCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-acceleratorcountrequest.html#cfn-autoscaling-autoscalinggroup-acceleratorcountrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-acceleratorcountrequest.html#cfn-autoscaling-autoscalinggroup-acceleratorcountrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class AcceleratorTotalMemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-acceleratortotalmemorymibrequest.html#cfn-autoscaling-autoscalinggroup-acceleratortotalmemorymibrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-acceleratortotalmemorymibrequest.html#cfn-autoscaling-autoscalinggroup-acceleratortotalmemorymibrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class AvailabilityZoneDistribution : Humidifier.Base.BaseSubResource, IHaveCapacityDistributionStrategy
        {
            /// <summary>
            /// CapacityDistributionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-availabilityzonedistribution.html#cfn-autoscaling-autoscalinggroup-availabilityzonedistribution-capacitydistributionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityDistributionStrategy { get; set; }
        }

        public class AvailabilityZoneImpairmentPolicy : Humidifier.Base.BaseSubResource, IHaveZonalShiftEnabled_Boolean, IHaveImpairedZoneHealthCheckBehavior
        {
            /// <summary>
            /// ZonalShiftEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy.html#cfn-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy-zonalshiftenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ZonalShiftEnabled { get; set; }
            /// <summary>
            /// ImpairedZoneHealthCheckBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy.html#cfn-autoscaling-autoscalinggroup-availabilityzoneimpairmentpolicy-impairedzonehealthcheckbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImpairedZoneHealthCheckBehavior { get; set; }
        }

        public class BaselineEbsBandwidthMbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-baselineebsbandwidthmbpsrequest.html#cfn-autoscaling-autoscalinggroup-baselineebsbandwidthmbpsrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-baselineebsbandwidthmbpsrequest.html#cfn-autoscaling-autoscalinggroup-baselineebsbandwidthmbpsrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class BaselinePerformanceFactorsRequest : Humidifier.Base.BaseSubResource, IHaveAutoScalingAutoScalingGroupTypesCpuPerformanceFactorRequestCpu
        {
            /// <summary>
            /// Cpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-baselineperformancefactorsrequest.html#cfn-autoscaling-autoscalinggroup-baselineperformancefactorsrequest-cpu
            /// Required: False
            /// UpdateType: Conditional
            /// Type: CpuPerformanceFactorRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.CpuPerformanceFactorRequest, BaseFunction>? Cpu { get; set; }
        }

        public class CapacityReservationSpecification : Humidifier.Base.BaseSubResource, IHaveCapacityReservationPreference, IHaveAutoScalingAutoScalingGroupTypesCapacityReservationTargetCapacityReservationTarget
        {
            /// <summary>
            /// CapacityReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-capacityreservationspecification.html#cfn-autoscaling-autoscalinggroup-capacityreservationspecification-capacityreservationpreference
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityReservationPreference { get; set; }
            /// <summary>
            /// CapacityReservationTarget
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-capacityreservationspecification.html#cfn-autoscaling-autoscalinggroup-capacityreservationspecification-capacityreservationtarget
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityReservationTarget
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.CapacityReservationTarget, BaseFunction>? CapacityReservationTarget { get; set; }
        }

        public class CapacityReservationTarget : Humidifier.Base.BaseSubResource, IHaveStringListOfCapacityReservationIds, IHaveStringListOfCapacityReservationResourceGroupArns
        {
            /// <summary>
            /// CapacityReservationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-capacityreservationtarget.html#cfn-autoscaling-autoscalinggroup-capacityreservationtarget-capacityreservationids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CapacityReservationIds { get; set; }
            /// <summary>
            /// CapacityReservationResourceGroupArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-capacityreservationtarget.html#cfn-autoscaling-autoscalinggroup-capacityreservationtarget-capacityreservationresourcegrouparns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CapacityReservationResourceGroupArns { get; set; }
        }

        public class CpuPerformanceFactorRequest : Humidifier.Base.BaseSubResource, IHaveListOfAutoScalingAutoScalingGroupTypesPerformanceFactorReferenceRequestReferences
        {
            /// <summary>
            /// References
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-cpuperformancefactorrequest.html#cfn-autoscaling-autoscalinggroup-cpuperformancefactorrequest-references
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: PerformanceFactorReferenceRequest
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AutoScaling.AutoScalingGroupTypes.PerformanceFactorReferenceRequest>, IReadOnlyList<Union<Humidifier.AutoScaling.AutoScalingGroupTypes.PerformanceFactorReferenceRequest, BaseFunction>>, BaseFunction>? References { get; set; }
        }

        public class DistributionSegment : Humidifier.Base.BaseSubResource, IHaveStringListOfTargetCapacityTypes
        {
            /// <summary>
            /// TargetCapacityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-distributionsegment.html#cfn-autoscaling-autoscalinggroup-distributionsegment-targetcapacitytypes
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetCapacityTypes { get; set; }
        }

        public class InstanceLifecyclePolicy : Humidifier.Base.BaseSubResource, IHaveAutoScalingAutoScalingGroupTypesRetentionTriggersRetentionTriggers
        {
            /// <summary>
            /// RetentionTriggers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancelifecyclepolicy.html#cfn-autoscaling-autoscalinggroup-instancelifecyclepolicy-retentiontriggers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetentionTriggers
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.RetentionTriggers, BaseFunction>? RetentionTriggers { get; set; }
        }

        public class InstanceMaintenancePolicy : Humidifier.Base.BaseSubResource, IHaveMaxHealthyPercentage_Integer, IHaveMinHealthyPercentage_Integer
        {
            /// <summary>
            /// MaxHealthyPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancemaintenancepolicy.html#cfn-autoscaling-autoscalinggroup-instancemaintenancepolicy-maxhealthypercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxHealthyPercentage { get; set; }
            /// <summary>
            /// MinHealthyPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancemaintenancepolicy.html#cfn-autoscaling-autoscalinggroup-instancemaintenancepolicy-minhealthypercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinHealthyPercentage { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveStringListOfInstanceGenerations, IHaveStringListOfAcceleratorTypes, IHaveAutoScalingAutoScalingGroupTypesMemoryGiBPerVCpuRequestMemoryGiBPerVCpu, IHaveStringListOfAcceleratorManufacturers, IHaveAutoScalingAutoScalingGroupTypesVCpuCountRequestVCpuCount, IHaveLocalStorage, IHaveStringListOfCpuManufacturers, IHaveBareMetal, IHaveRequireHibernateSupport_Boolean, IHaveMaxSpotPriceAsPercentageOfOptimalOnDemandPrice_Integer, IHaveOnDemandMaxPricePercentageOverLowestPrice_Integer, IHaveAutoScalingAutoScalingGroupTypesMemoryMiBRequestMemoryMiB, IHaveStringListOfLocalStorageTypes, IHaveAutoScalingAutoScalingGroupTypesNetworkInterfaceCountRequestNetworkInterfaceCount, IHaveStringListOfExcludedInstanceTypes, IHaveStringListOfAllowedInstanceTypes, IHaveAutoScalingAutoScalingGroupTypesAcceleratorCountRequestAcceleratorCount, IHaveAutoScalingAutoScalingGroupTypesNetworkBandwidthGbpsRequestNetworkBandwidthGbps, IHaveAutoScalingAutoScalingGroupTypesBaselinePerformanceFactorsRequestBaselinePerformanceFactors, IHaveAutoScalingAutoScalingGroupTypesBaselineEbsBandwidthMbpsRequestBaselineEbsBandwidthMbps, IHaveSpotMaxPricePercentageOverLowestPrice_Integer, IHaveStringListOfAcceleratorNames, IHaveAutoScalingAutoScalingGroupTypesAcceleratorTotalMemoryMiBRequestAcceleratorTotalMemoryMiB, IHaveBurstablePerformance, IHaveAutoScalingAutoScalingGroupTypesTotalLocalStorageGBRequestTotalLocalStorageGB
        {
            /// <summary>
            /// InstanceGenerations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-instancegenerations
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceGenerations { get; set; }
            /// <summary>
            /// AcceleratorTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratortypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorTypes { get; set; }
            /// <summary>
            /// MemoryGiBPerVCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-memorygibpervcpu
            /// Required: False
            /// UpdateType: Conditional
            /// Type: MemoryGiBPerVCpuRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.MemoryGiBPerVCpuRequest, BaseFunction>? MemoryGiBPerVCpu { get; set; }
            /// <summary>
            /// AcceleratorManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratormanufacturers
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorManufacturers { get; set; }
            /// <summary>
            /// VCpuCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-vcpucount
            /// Required: True
            /// UpdateType: Conditional
            /// Type: VCpuCountRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.VCpuCountRequest, BaseFunction>? VCpuCount { get; set; }
            /// <summary>
            /// LocalStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-localstorage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocalStorage { get; set; }
            /// <summary>
            /// CpuManufacturers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-cpumanufacturers
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CpuManufacturers { get; set; }
            /// <summary>
            /// BareMetal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-baremetal
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BareMetal { get; set; }
            /// <summary>
            /// RequireHibernateSupport
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-requirehibernatesupport
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RequireHibernateSupport { get; set; }
            /// <summary>
            /// MaxSpotPriceAsPercentageOfOptimalOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-maxspotpriceaspercentageofoptimalondemandprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }
            /// <summary>
            /// OnDemandMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-ondemandmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// MemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-memorymib
            /// Required: True
            /// UpdateType: Conditional
            /// Type: MemoryMiBRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.MemoryMiBRequest, BaseFunction>? MemoryMiB { get; set; }
            /// <summary>
            /// LocalStorageTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-localstoragetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LocalStorageTypes { get; set; }
            /// <summary>
            /// NetworkInterfaceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-networkinterfacecount
            /// Required: False
            /// UpdateType: Conditional
            /// Type: NetworkInterfaceCountRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.NetworkInterfaceCountRequest, BaseFunction>? NetworkInterfaceCount { get; set; }
            /// <summary>
            /// ExcludedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-excludedinstancetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExcludedInstanceTypes { get; set; }
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-allowedinstancetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
            /// <summary>
            /// AcceleratorCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratorcount
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AcceleratorCountRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.AcceleratorCountRequest, BaseFunction>? AcceleratorCount { get; set; }
            /// <summary>
            /// NetworkBandwidthGbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-networkbandwidthgbps
            /// Required: False
            /// UpdateType: Conditional
            /// Type: NetworkBandwidthGbpsRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.NetworkBandwidthGbpsRequest, BaseFunction>? NetworkBandwidthGbps { get; set; }
            /// <summary>
            /// BaselinePerformanceFactors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-baselineperformancefactors
            /// Required: False
            /// UpdateType: Conditional
            /// Type: BaselinePerformanceFactorsRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.BaselinePerformanceFactorsRequest, BaseFunction>? BaselinePerformanceFactors { get; set; }
            /// <summary>
            /// BaselineEbsBandwidthMbps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-baselineebsbandwidthmbps
            /// Required: False
            /// UpdateType: Conditional
            /// Type: BaselineEbsBandwidthMbpsRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.BaselineEbsBandwidthMbpsRequest, BaseFunction>? BaselineEbsBandwidthMbps { get; set; }
            /// <summary>
            /// SpotMaxPricePercentageOverLowestPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-spotmaxpricepercentageoverlowestprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpotMaxPricePercentageOverLowestPrice { get; set; }
            /// <summary>
            /// AcceleratorNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratornames
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AcceleratorNames { get; set; }
            /// <summary>
            /// AcceleratorTotalMemoryMiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-acceleratortotalmemorymib
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AcceleratorTotalMemoryMiBRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.AcceleratorTotalMemoryMiBRequest, BaseFunction>? AcceleratorTotalMemoryMiB { get; set; }
            /// <summary>
            /// BurstablePerformance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-burstableperformance
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BurstablePerformance { get; set; }
            /// <summary>
            /// TotalLocalStorageGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancerequirements.html#cfn-autoscaling-autoscalinggroup-instancerequirements-totallocalstoragegb
            /// Required: False
            /// UpdateType: Conditional
            /// Type: TotalLocalStorageGBRequest
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.TotalLocalStorageGBRequest, BaseFunction>? TotalLocalStorageGB { get; set; }
        }

        public class InstancesDistribution : Humidifier.Base.BaseSubResource, IHaveOnDemandAllocationStrategy, IHaveOnDemandBaseCapacity_Integer, IHaveListOfAutoScalingAutoScalingGroupTypesDistributionSegmentDistributionSegments, IHaveOnDemandPercentageAboveBaseCapacity_Integer, IHaveSpotInstancePools_Integer, IHaveSpotAllocationStrategy, IHaveSpotMaxPrice
        {
            /// <summary>
            /// OnDemandAllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-ondemandallocationstrategy
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OnDemandAllocationStrategy { get; set; }
            /// <summary>
            /// OnDemandBaseCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-ondemandbasecapacity
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandBaseCapacity { get; set; }
            /// <summary>
            /// DistributionSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-distributionsegments
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: DistributionSegment
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AutoScaling.AutoScalingGroupTypes.DistributionSegment>, IReadOnlyList<Union<Humidifier.AutoScaling.AutoScalingGroupTypes.DistributionSegment, BaseFunction>>, BaseFunction>? DistributionSegments { get; set; }
            /// <summary>
            /// OnDemandPercentageAboveBaseCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-ondemandpercentageabovebasecapacity
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OnDemandPercentageAboveBaseCapacity { get; set; }
            /// <summary>
            /// SpotInstancePools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-spotinstancepools
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpotInstancePools { get; set; }
            /// <summary>
            /// SpotAllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-spotallocationstrategy
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpotAllocationStrategy { get; set; }
            /// <summary>
            /// SpotMaxPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-instancesdistribution.html#cfn-autoscaling-autoscalinggroup-instancesdistribution-spotmaxprice
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpotMaxPrice { get; set; }
        }

        public class LaunchTemplate : Humidifier.Base.BaseSubResource, IHaveAutoScalingAutoScalingGroupTypesLaunchTemplateSpecificationLaunchTemplateSpecification, IHaveListOfAutoScalingAutoScalingGroupTypesLaunchTemplateOverridesOverrides
        {
            /// <summary>
            /// LaunchTemplateSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplate.html#cfn-autoscaling-autoscalinggroup-launchtemplate-launchtemplatespecification
            /// Required: True
            /// UpdateType: Conditional
            /// Type: LaunchTemplateSpecification
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification, BaseFunction>? LaunchTemplateSpecification { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplate.html#cfn-autoscaling-autoscalinggroup-launchtemplate-overrides
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: LaunchTemplateOverrides
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateOverrides>, IReadOnlyList<Union<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateOverrides, BaseFunction>>, BaseFunction>? Overrides { get; set; }
        }

        public class LaunchTemplateOverrides : Humidifier.Base.BaseSubResource, IHaveAutoScalingAutoScalingGroupTypesLaunchTemplateSpecificationLaunchTemplateSpecification, IHaveWeightedCapacity, IHaveImageId, IHaveAutoScalingAutoScalingGroupTypesInstanceRequirementsInstanceRequirements, IHaveInstanceType
        {
            /// <summary>
            /// LaunchTemplateSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-launchtemplatespecification
            /// Required: False
            /// UpdateType: Conditional
            /// Type: LaunchTemplateSpecification
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplateSpecification, BaseFunction>? LaunchTemplateSpecification { get; set; }
            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-weightedcapacity
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WeightedCapacity { get; set; }
            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-imageid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageId { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-instancerequirements
            /// Required: False
            /// UpdateType: Conditional
            /// Type: InstanceRequirements
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.InstanceRequirements, BaseFunction>? InstanceRequirements { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplateoverrides.html#cfn-autoscaling-autoscalinggroup-launchtemplateoverrides-instancetype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class LaunchTemplateSpecification : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveLaunchTemplateName, IHaveLaunchTemplateId
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplatespecification.html#cfn-autoscaling-autoscalinggroup-launchtemplatespecification-version
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplatespecification.html#cfn-autoscaling-autoscalinggroup-launchtemplatespecification-launchtemplatename
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateName { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-launchtemplatespecification.html#cfn-autoscaling-autoscalinggroup-launchtemplatespecification-launchtemplateid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
        }

        public class LifecycleHookSpecification : Humidifier.Base.BaseSubResource, IHaveLifecycleHookName, IHaveLifecycleTransition, IHaveHeartbeatTimeout_Integer, IHaveNotificationMetadata, IHaveDefaultResult, IHaveNotificationTargetARN, IHaveRoleARN
        {
            /// <summary>
            /// LifecycleHookName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-lifecyclehookname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecycleHookName { get; set; }
            /// <summary>
            /// LifecycleTransition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-lifecycletransition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LifecycleTransition { get; set; }
            /// <summary>
            /// HeartbeatTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-heartbeattimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? HeartbeatTimeout { get; set; }
            /// <summary>
            /// NotificationMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-notificationmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationMetadata { get; set; }
            /// <summary>
            /// DefaultResult
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-defaultresult
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultResult { get; set; }
            /// <summary>
            /// NotificationTargetARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-notificationtargetarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationTargetARN { get; set; }
            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-lifecyclehookspecification.html#cfn-autoscaling-autoscalinggroup-lifecyclehookspecification-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleARN { get; set; }
        }

        public class MemoryGiBPerVCpuRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-memorygibpervcpurequest.html#cfn-autoscaling-autoscalinggroup-memorygibpervcpurequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-memorygibpervcpurequest.html#cfn-autoscaling-autoscalinggroup-memorygibpervcpurequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class MemoryMiBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-memorymibrequest.html#cfn-autoscaling-autoscalinggroup-memorymibrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-memorymibrequest.html#cfn-autoscaling-autoscalinggroup-memorymibrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class MetricsCollection : Humidifier.Base.BaseSubResource, IHaveStringListOfMetrics, IHaveGranularity
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-metricscollection.html#cfn-autoscaling-autoscalinggroup-metricscollection-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Metrics { get; set; }
            /// <summary>
            /// Granularity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-metricscollection.html#cfn-autoscaling-autoscalinggroup-metricscollection-granularity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Granularity { get; set; }
        }

        public class MixedInstancesPolicy : Humidifier.Base.BaseSubResource, IHaveAutoScalingAutoScalingGroupTypesInstancesDistributionInstancesDistribution, IHaveAutoScalingAutoScalingGroupTypesLaunchTemplateLaunchTemplate
        {
            /// <summary>
            /// InstancesDistribution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-mixedinstancespolicy.html#cfn-autoscaling-autoscalinggroup-mixedinstancespolicy-instancesdistribution
            /// Required: False
            /// UpdateType: Conditional
            /// Type: InstancesDistribution
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.InstancesDistribution, BaseFunction>? InstancesDistribution { get; set; }
            /// <summary>
            /// LaunchTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-mixedinstancespolicy.html#cfn-autoscaling-autoscalinggroup-mixedinstancespolicy-launchtemplate
            /// Required: True
            /// UpdateType: Conditional
            /// Type: LaunchTemplate
            /// </summary>
            public Union<Humidifier.AutoScaling.AutoScalingGroupTypes.LaunchTemplate, BaseFunction>? LaunchTemplate { get; set; }
        }

        public class NetworkBandwidthGbpsRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-networkbandwidthgbpsrequest.html#cfn-autoscaling-autoscalinggroup-networkbandwidthgbpsrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-networkbandwidthgbpsrequest.html#cfn-autoscaling-autoscalinggroup-networkbandwidthgbpsrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
        }

        public class NetworkInterfaceCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-networkinterfacecountrequest.html#cfn-autoscaling-autoscalinggroup-networkinterfacecountrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-networkinterfacecountrequest.html#cfn-autoscaling-autoscalinggroup-networkinterfacecountrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }

        public class NotificationConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfTopicARN, IHaveStringListOfNotificationTypes
        {
            /// <summary>
            /// TopicARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-notificationconfiguration.html#cfn-autoscaling-autoscalinggroup-notificationconfiguration-topicarn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TopicARN { get; set; }
            /// <summary>
            /// NotificationTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-notificationconfiguration.html#cfn-autoscaling-autoscalinggroup-notificationconfiguration-notificationtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotificationTypes { get; set; }
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
            public Union<string, BaseFunction>? InstanceFamily { get; set; }
        }

        public class RetentionTriggers : Humidifier.Base.BaseSubResource, IHaveTerminateHookAbandon
        {
            /// <summary>
            /// TerminateHookAbandon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-retentiontriggers.html#cfn-autoscaling-autoscalinggroup-retentiontriggers-terminatehookabandon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TerminateHookAbandon { get; set; }
        }

        public class TagProperty : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey, IHavePropagateAtLaunch_Boolean
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-tagproperty.html#cfn-autoscaling-autoscalinggroup-tagproperty-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-tagproperty.html#cfn-autoscaling-autoscalinggroup-tagproperty-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
            /// <summary>
            /// PropagateAtLaunch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-tagproperty.html#cfn-autoscaling-autoscalinggroup-tagproperty-propagateatlaunch
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? PropagateAtLaunch { get; set; }
        }

        public class TotalLocalStorageGBRequest : Humidifier.Base.BaseSubResource, IHaveMin_Double, IHaveMax_Double
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-totallocalstoragegbrequest.html#cfn-autoscaling-autoscalinggroup-totallocalstoragegbrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-totallocalstoragegbrequest.html#cfn-autoscaling-autoscalinggroup-totallocalstoragegbrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Max { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Identifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-trafficsourceidentifier.html#cfn-autoscaling-autoscalinggroup-trafficsourceidentifier-identifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Identifier { get; set; }
        }

        public class VCpuCountRequest : Humidifier.Base.BaseSubResource, IHaveMin_Integer, IHaveMax_Integer
        {
            /// <summary>
            /// Min
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-vcpucountrequest.html#cfn-autoscaling-autoscalinggroup-vcpucountrequest-min
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Min { get; set; }
            /// <summary>
            /// Max
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-autoscalinggroup-vcpucountrequest.html#cfn-autoscaling-autoscalinggroup-vcpucountrequest-max
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Max { get; set; }
        }
    }
}