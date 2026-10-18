namespace Humidifier.Batch
{
    using global::System.Collections.Generic;
    using ComputeEnvironmentTypes;

    public class ComputeEnvironment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveContext, IHaveUnmanagedvCpus_Integer, IHaveType, IHaveBatchComputeEnvironmentTypesUpdatePolicyUpdatePolicy, IHaveReplaceComputeEnvironment_Boolean, IHaveServiceRole, IHaveBatchComputeEnvironmentTypesEksConfigurationEksConfiguration, IHaveComputeEnvironmentName, IHaveBatchComputeEnvironmentTypesComputeResourcesComputeResources, IHaveState, IHaveBatchComputeEnvironmentTypesEcsSettingsEcsSettings, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string ComputeEnvironmentArn =  "ComputeEnvironmentArn" ;
        }

        public override string AWSTypeName { get => AWS.Batch.ComputeEnvironment; }
        /// <summary>
        /// Context
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-context
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Context { get; set; }
        /// <summary>
        /// UnmanagedvCpus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-unmanagedvcpus
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? UnmanagedvCpus { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// UpdatePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-updatepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UpdatePolicy
        /// </summary>
        public Union<Humidifier.Batch.ComputeEnvironmentTypes.UpdatePolicy, BaseFunction>? UpdatePolicy { get; set; }
        /// <summary>
        /// ReplaceComputeEnvironment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-replacecomputeenvironment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ReplaceComputeEnvironment { get; set; }
        /// <summary>
        /// ServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-servicerole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceRole { get; set; }
        /// <summary>
        /// EksConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-eksconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EksConfiguration
        /// </summary>
        public Union<Humidifier.Batch.ComputeEnvironmentTypes.EksConfiguration, BaseFunction>? EksConfiguration { get; set; }
        public Union<string, BaseFunction>? ComputeEnvironmentName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ComputeResources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-computeresources
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ComputeResources
        /// </summary>
        public Union<Humidifier.Batch.ComputeEnvironmentTypes.ComputeResources, BaseFunction>? ComputeResources { get; set; }
        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? State { get; set; }
        /// <summary>
        /// EcsSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-ecssettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EcsSettings
        /// </summary>
        public Union<Humidifier.Batch.ComputeEnvironmentTypes.EcsSettings, BaseFunction>? EcsSettings { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-computeenvironment.html#cfn-batch-computeenvironment-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ComputeEnvironmentTypes
    {
        public class CapacityReservations : Humidifier.Base.BaseSubResource, IHaveReservationGroupArn, IHaveReservationPreference
        {
            /// <summary>
            /// ReservationGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-capacityreservations.html#cfn-batch-computeenvironment-capacityreservations-reservationgrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReservationGroupArn { get; set; }
            /// <summary>
            /// ReservationPreference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-capacityreservations.html#cfn-batch-computeenvironment-capacityreservations-reservationpreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ReservationPreference { get; set; }
        }

        public class ComputeResources : Humidifier.Base.BaseSubResource, IHaveBatchComputeEnvironmentTypesComputeScalingPolicyScalingPolicy, IHaveSpotIamFleetRole, IHaveMaxvCpus_Integer, IHaveStringDictionaryOfCapacityTags, IHaveListOfBatchComputeEnvironmentTypesEc2ConfigurationObjectEc2Configuration, IHaveBidPercentage_Integer, IHaveStringListOfSecurityGroupIds, IHaveAllocationStrategy, IHaveStringListOfSubnets, IHaveType, IHaveMinvCpus_Integer, IHaveUpdateToLatestImageVersion_Boolean, IHaveBatchComputeEnvironmentTypesLaunchTemplateSpecificationLaunchTemplate, IHaveImageId, IHaveInstanceRole, IHaveStringListOfInstanceTypes, IHaveEc2KeyPair, IHavePlacementGroup, IHaveStringDictionaryOfTags, IHaveDesiredvCpus_Integer, IHaveBatchComputeEnvironmentTypesManagedInstancesProviderManagedInstancesProvider
        {
            /// <summary>
            /// ScalingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-scalingpolicy
            /// Required: False
            /// UpdateType: Conditional
            /// Type: ComputeScalingPolicy
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.ComputeScalingPolicy, BaseFunction>? ScalingPolicy { get; set; }
            /// <summary>
            /// SpotIamFleetRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-spotiamfleetrole
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpotIamFleetRole { get; set; }
            /// <summary>
            /// MaxvCpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-maxvcpus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxvCpus { get; set; }
            /// <summary>
            /// CapacityTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-capacitytags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CapacityTags { get; set; }
            /// <summary>
            /// Ec2Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-ec2configuration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: Ec2ConfigurationObject
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Batch.ComputeEnvironmentTypes.Ec2ConfigurationObject>, IReadOnlyList<Union<Humidifier.Batch.ComputeEnvironmentTypes.Ec2ConfigurationObject, BaseFunction>>, BaseFunction>? Ec2Configuration { get; set; }
            /// <summary>
            /// BidPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-bidpercentage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BidPercentage { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-securitygroupids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-allocationstrategy
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AllocationStrategy { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-subnets
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-type
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// MinvCpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-minvcpus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinvCpus { get; set; }
            /// <summary>
            /// UpdateToLatestImageVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-updatetolatestimageversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UpdateToLatestImageVersion { get; set; }
            /// <summary>
            /// LaunchTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-launchtemplate
            /// Required: False
            /// UpdateType: Conditional
            /// Type: LaunchTemplateSpecification
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecification, BaseFunction>? LaunchTemplate { get; set; }
            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-imageid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageId { get; set; }
            /// <summary>
            /// InstanceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-instancerole
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceRole { get; set; }
            /// <summary>
            /// InstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-instancetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InstanceTypes { get; set; }
            /// <summary>
            /// Ec2KeyPair
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-ec2keypair
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ec2KeyPair { get; set; }
            /// <summary>
            /// PlacementGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-placementgroup
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PlacementGroup { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-tags
            /// Required: False
            /// UpdateType: Conditional
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
            /// <summary>
            /// DesiredvCpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-desiredvcpus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DesiredvCpus { get; set; }
            /// <summary>
            /// ManagedInstancesProvider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computeresources.html#cfn-batch-computeenvironment-computeresources-managedinstancesprovider
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedInstancesProvider
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesProvider, BaseFunction>? ManagedInstancesProvider { get; set; }
        }

        public class ComputeScalingPolicy : Humidifier.Base.BaseSubResource, IHaveMinScaleDownDelayMinutes_Integer
        {
            /// <summary>
            /// MinScaleDownDelayMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-computescalingpolicy.html#cfn-batch-computeenvironment-computescalingpolicy-minscaledowndelayminutes
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinScaleDownDelayMinutes { get; set; }
        }

        public class Ec2ConfigurationObject : Humidifier.Base.BaseSubResource, IHaveImageIdOverride, IHaveImageKubernetesVersion, IHaveBatchImageStatus, IHaveImageType
        {
            /// <summary>
            /// ImageIdOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-ec2configurationobject.html#cfn-batch-computeenvironment-ec2configurationobject-imageidoverride
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageIdOverride { get; set; }
            /// <summary>
            /// ImageKubernetesVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-ec2configurationobject.html#cfn-batch-computeenvironment-ec2configurationobject-imagekubernetesversion
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageKubernetesVersion { get; set; }
            /// <summary>
            /// BatchImageStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-ec2configurationobject.html#cfn-batch-computeenvironment-ec2configurationobject-batchimagestatus
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BatchImageStatus { get; set; }
            /// <summary>
            /// ImageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-ec2configurationobject.html#cfn-batch-computeenvironment-ec2configurationobject-imagetype
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageType { get; set; }
        }

        public class EcsSettings : Humidifier.Base.BaseSubResource, IHaveContainerInsights
        {
            /// <summary>
            /// ContainerInsights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-ecssettings.html#cfn-batch-computeenvironment-ecssettings-containerinsights
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContainerInsights { get; set; }
        }

        public class EksAccessEntry : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveDesiredState
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-eksaccessentry.html#cfn-batch-computeenvironment-eksaccessentry-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// DesiredState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-eksaccessentry.html#cfn-batch-computeenvironment-eksaccessentry-desiredstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DesiredState { get; set; }
        }

        public class EksConfiguration : Humidifier.Base.BaseSubResource, IHaveEksClusterArn, IHaveBatchComputeEnvironmentTypesEksAccessEntryAccessEntry, IHaveKubernetesNamespace
        {
            /// <summary>
            /// EksClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-eksconfiguration.html#cfn-batch-computeenvironment-eksconfiguration-eksclusterarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EksClusterArn { get; set; }
            /// <summary>
            /// AccessEntry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-eksconfiguration.html#cfn-batch-computeenvironment-eksconfiguration-accessentry
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EksAccessEntry
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.EksAccessEntry, BaseFunction>? AccessEntry { get; set; }
            /// <summary>
            /// KubernetesNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-eksconfiguration.html#cfn-batch-computeenvironment-eksconfiguration-kubernetesnamespace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KubernetesNamespace { get; set; }
        }

        public class InfrastructureOptimization : Humidifier.Base.BaseSubResource, IHaveScaleInAfter_Integer
        {
            /// <summary>
            /// ScaleInAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-infrastructureoptimization.html#cfn-batch-computeenvironment-infrastructureoptimization-scaleinafter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ScaleInAfter { get; set; }
        }

        public class InstanceLaunchTemplate : Humidifier.Base.BaseSubResource, IHaveEc2InstanceProfileArn, IHaveCapacityOptionType, IHaveFipsEnabled_Boolean, IHaveInstanceMetadataTagsPropagation_Boolean, IHaveBatchComputeEnvironmentTypesManagedInstancesStorageConfigurationStorageConfiguration, IHaveBatchComputeEnvironmentTypesManagedInstancesNetworkConfigurationNetworkConfiguration, IHaveBatchComputeEnvironmentTypesInstanceRequirementsInstanceRequirements, IHaveBatchComputeEnvironmentTypesCapacityReservationsCapacityReservations, IHaveMonitoring, IHaveBatchComputeEnvironmentTypesManagedInstancesLocalStorageConfigurationLocalStorageConfiguration
        {
            /// <summary>
            /// Ec2InstanceProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-ec2instanceprofilearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Ec2InstanceProfileArn { get; set; }
            /// <summary>
            /// CapacityOptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-capacityoptiontype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CapacityOptionType { get; set; }
            /// <summary>
            /// FipsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-fipsenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? FipsEnabled { get; set; }
            /// <summary>
            /// InstanceMetadataTagsPropagation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-instancemetadatatagspropagation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? InstanceMetadataTagsPropagation { get; set; }
            /// <summary>
            /// StorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-storageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedInstancesStorageConfiguration
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesStorageConfiguration, BaseFunction>? StorageConfiguration { get; set; }
            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-networkconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ManagedInstancesNetworkConfiguration
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesNetworkConfiguration, BaseFunction>? NetworkConfiguration { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-instancerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceRequirements
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.InstanceRequirements, BaseFunction>? InstanceRequirements { get; set; }
            /// <summary>
            /// CapacityReservations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-capacityreservations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacityReservations
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.CapacityReservations, BaseFunction>? CapacityReservations { get; set; }
            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-monitoring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Monitoring { get; set; }
            /// <summary>
            /// LocalStorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancelaunchtemplate.html#cfn-batch-computeenvironment-instancelaunchtemplate-localstorageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedInstancesLocalStorageConfiguration
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesLocalStorageConfiguration, BaseFunction>? LocalStorageConfiguration { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveStringListOfAllowedInstanceTypes
        {
            /// <summary>
            /// AllowedInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-instancerequirements.html#cfn-batch-computeenvironment-instancerequirements-allowedinstancetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedInstanceTypes { get; set; }
        }

        public class LaunchTemplateSpecification : Humidifier.Base.BaseSubResource, IHaveUserdataType, IHaveLaunchTemplateName, IHaveVersion, IHaveListOfBatchComputeEnvironmentTypesLaunchTemplateSpecificationOverrideOverrides, IHaveLaunchTemplateId
        {
            /// <summary>
            /// UserdataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html#cfn-batch-computeenvironment-launchtemplatespecification-userdatatype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserdataType { get; set; }
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html#cfn-batch-computeenvironment-launchtemplatespecification-launchtemplatename
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html#cfn-batch-computeenvironment-launchtemplatespecification-version
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html#cfn-batch-computeenvironment-launchtemplatespecification-overrides
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: LaunchTemplateSpecificationOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecificationOverride>, IReadOnlyList<Union<Humidifier.Batch.ComputeEnvironmentTypes.LaunchTemplateSpecificationOverride, BaseFunction>>, BaseFunction>? Overrides { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecification.html#cfn-batch-computeenvironment-launchtemplatespecification-launchtemplateid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
        }

        public class LaunchTemplateSpecificationOverride : Humidifier.Base.BaseSubResource, IHaveStringListOfTargetInstanceTypes, IHaveUserdataType, IHaveLaunchTemplateName, IHaveVersion, IHaveLaunchTemplateId
        {
            /// <summary>
            /// TargetInstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecificationoverride.html#cfn-batch-computeenvironment-launchtemplatespecificationoverride-targetinstancetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetInstanceTypes { get; set; }
            /// <summary>
            /// UserdataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecificationoverride.html#cfn-batch-computeenvironment-launchtemplatespecificationoverride-userdatatype
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserdataType { get; set; }
            /// <summary>
            /// LaunchTemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecificationoverride.html#cfn-batch-computeenvironment-launchtemplatespecificationoverride-launchtemplatename
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateName { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecificationoverride.html#cfn-batch-computeenvironment-launchtemplatespecificationoverride-version
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// LaunchTemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-launchtemplatespecificationoverride.html#cfn-batch-computeenvironment-launchtemplatespecificationoverride-launchtemplateid
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LaunchTemplateId { get; set; }
        }

        public class ManagedInstancesLocalStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveUseLocalStorage_Boolean
        {
            /// <summary>
            /// UseLocalStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-managedinstanceslocalstorageconfiguration.html#cfn-batch-computeenvironment-managedinstanceslocalstorageconfiguration-uselocalstorage
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-managedinstancesnetworkconfiguration.html#cfn-batch-computeenvironment-managedinstancesnetworkconfiguration-securitygroups
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-managedinstancesnetworkconfiguration.html#cfn-batch-computeenvironment-managedinstancesnetworkconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        }

        public class ManagedInstancesProvider : Humidifier.Base.BaseSubResource, IHaveInfrastructureRoleArn, IHavePropagateTags, IHaveBatchComputeEnvironmentTypesInfrastructureOptimizationInfrastructureOptimization, IHaveBatchComputeEnvironmentTypesInstanceLaunchTemplateInstanceLaunchTemplate
        {
            /// <summary>
            /// InfrastructureRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-managedinstancesprovider.html#cfn-batch-computeenvironment-managedinstancesprovider-infrastructurerolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InfrastructureRoleArn { get; set; }
            /// <summary>
            /// PropagateTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-managedinstancesprovider.html#cfn-batch-computeenvironment-managedinstancesprovider-propagatetags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropagateTags { get; set; }
            /// <summary>
            /// InfrastructureOptimization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-managedinstancesprovider.html#cfn-batch-computeenvironment-managedinstancesprovider-infrastructureoptimization
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InfrastructureOptimization
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.InfrastructureOptimization, BaseFunction>? InfrastructureOptimization { get; set; }
            /// <summary>
            /// InstanceLaunchTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-managedinstancesprovider.html#cfn-batch-computeenvironment-managedinstancesprovider-instancelaunchtemplate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InstanceLaunchTemplate
            /// </summary>
            public Union<Humidifier.Batch.ComputeEnvironmentTypes.InstanceLaunchTemplate, BaseFunction>? InstanceLaunchTemplate { get; set; }
        }

        public class ManagedInstancesStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageSizeGiB_Integer
        {
            /// <summary>
            /// StorageSizeGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-managedinstancesstorageconfiguration.html#cfn-batch-computeenvironment-managedinstancesstorageconfiguration-storagesizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StorageSizeGiB { get; set; }
        }

        public class UpdatePolicy : Humidifier.Base.BaseSubResource, IHaveJobExecutionTimeoutMinutes_Integer, IHaveTerminateJobsOnUpdate_Boolean
        {
            /// <summary>
            /// JobExecutionTimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-updatepolicy.html#cfn-batch-computeenvironment-updatepolicy-jobexecutiontimeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? JobExecutionTimeoutMinutes { get; set; }
            /// <summary>
            /// TerminateJobsOnUpdate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-computeenvironment-updatepolicy.html#cfn-batch-computeenvironment-updatepolicy-terminatejobsonupdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? TerminateJobsOnUpdate { get; set; }
        }
    }
}