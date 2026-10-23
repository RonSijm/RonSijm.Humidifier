namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ComputeQuotaTypes;

    public class ComputeQuota : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveClusterArn, IHaveSageMakerComputeQuotaTypesComputeQuotaTargetComputeQuotaTarget, IHaveDescription, IHaveSageMakerComputeQuotaTypesComputeQuotaConfigComputeQuotaConfig, IHaveActivationState, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ComputeQuotaArn =  "ComputeQuotaArn" ;
            public static string ComputeQuotaId =  "ComputeQuotaId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string ComputeQuotaVersion =  "ComputeQuotaVersion" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.ComputeQuota; }

        /// <summary>
        /// ClusterArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-clusterarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterArn { get; set; }

        /// <summary>
        /// ComputeQuotaTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-computequotatarget
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ComputeQuotaTarget
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget, BaseFunction>? ComputeQuotaTarget { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ComputeQuotaConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-computequotaconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ComputeQuotaConfig
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig, BaseFunction>? ComputeQuotaConfig { get; set; }
        /// <summary>
        /// ActivationState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-activationstate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ActivationState { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ComputeQuotaTypes
    {
        public class AcceleratorPartitionConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveCount_Integer
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-acceleratorpartitionconfig.html#cfn-sagemaker-computequota-acceleratorpartitionconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-acceleratorpartitionconfig.html#cfn-sagemaker-computequota-acceleratorpartitionconfig-count
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
        }

        public class ComputeQuotaConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerComputeQuotaTypesResourceSharingConfigResourceSharingConfig, IHaveListOfSageMakerComputeQuotaTypesComputeQuotaResourceConfigComputeQuotaResources, IHavePreemptTeamTasks
        {
            /// <summary>
            /// ResourceSharingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaconfig.html#cfn-sagemaker-computequota-computequotaconfig-resourcesharingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSharingConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig, BaseFunction>? ResourceSharingConfig { get; set; }
            /// <summary>
            /// ComputeQuotaResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaconfig.html#cfn-sagemaker-computequota-computequotaconfig-computequotaresources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ComputeQuotaResourceConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaResourceConfig>, IReadOnlyList<Union<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaResourceConfig, BaseFunction>>, BaseFunction>? ComputeQuotaResources { get; set; }
            /// <summary>
            /// PreemptTeamTasks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaconfig.html#cfn-sagemaker-computequota-computequotaconfig-preemptteamtasks
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreemptTeamTasks { get; set; }
        }

        public class ComputeQuotaResourceConfig : Humidifier.Base.BaseSubResource, IHaveSageMakerComputeQuotaTypesAcceleratorPartitionConfigAcceleratorPartition, IHaveVCpu_Double, IHaveCount_Integer, IHaveMemoryInGiB_Double, IHaveAccelerators_Integer, IHaveInstanceType
        {
            /// <summary>
            /// AcceleratorPartition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-acceleratorpartition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorPartitionConfig
            /// </summary>
            public Union<Humidifier.SageMaker.ComputeQuotaTypes.AcceleratorPartitionConfig, BaseFunction>? AcceleratorPartition { get; set; }
            /// <summary>
            /// VCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-vcpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? VCpu { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Count { get; set; }
            /// <summary>
            /// MemoryInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-memoryingib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MemoryInGiB { get; set; }
            /// <summary>
            /// Accelerators
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-accelerators
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Accelerators { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceType { get; set; }
        }

        public class ComputeQuotaTarget : Humidifier.Base.BaseSubResource, IHaveTeamName, IHaveFairShareWeight_Integer
        {
            /// <summary>
            /// TeamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotatarget.html#cfn-sagemaker-computequota-computequotatarget-teamname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TeamName { get; set; }
            /// <summary>
            /// FairShareWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotatarget.html#cfn-sagemaker-computequota-computequotatarget-fairshareweight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FairShareWeight { get; set; }
        }

        public class ResourceSharingConfig : Humidifier.Base.BaseSubResource, IHaveBorrowLimit_Integer, IHaveStrategy, IHaveListOfSageMakerComputeQuotaTypesComputeQuotaResourceConfigAbsoluteBorrowLimits
        {
            /// <summary>
            /// BorrowLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-resourcesharingconfig.html#cfn-sagemaker-computequota-resourcesharingconfig-borrowlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BorrowLimit { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-resourcesharingconfig.html#cfn-sagemaker-computequota-resourcesharingconfig-strategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Strategy { get; set; }
            /// <summary>
            /// AbsoluteBorrowLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-resourcesharingconfig.html#cfn-sagemaker-computequota-resourcesharingconfig-absoluteborrowlimits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ComputeQuotaResourceConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaResourceConfig>, IReadOnlyList<Union<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaResourceConfig, BaseFunction>>, BaseFunction>? AbsoluteBorrowLimits { get; set; }
        }
    }
}