namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using ComputeQuotaTypes;

    public class ComputeQuota : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveClusterArn, IHaveActivationState
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
        public dynamic ClusterArn { get; set; }

        /// <summary>
        /// ComputeQuotaTarget
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-computequotatarget
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ComputeQuotaTarget
        /// </summary>
        [Required]
        public Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaTarget ComputeQuotaTarget { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ComputeQuotaConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-computequotaconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ComputeQuotaConfig
        /// </summary>
        [Required]
        public Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaConfig ComputeQuotaConfig { get; set; }
        /// <summary>
        /// ActivationState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-activationstate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ActivationState { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-computequota.html#cfn-sagemaker-computequota-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ComputeQuotaTypes
    {
        public class AcceleratorPartitionConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveCount
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-acceleratorpartitionconfig.html#cfn-sagemaker-computequota-acceleratorpartitionconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-acceleratorpartitionconfig.html#cfn-sagemaker-computequota-acceleratorpartitionconfig-count
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Count { get; set; }
        }

        public class ComputeQuotaConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceSharingConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaconfig.html#cfn-sagemaker-computequota-computequotaconfig-resourcesharingconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ResourceSharingConfig
            /// </summary>
            public Humidifier.SageMaker.ComputeQuotaTypes.ResourceSharingConfig ResourceSharingConfig { get; set; }
            /// <summary>
            /// ComputeQuotaResources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaconfig.html#cfn-sagemaker-computequota-computequotaconfig-computequotaresources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ComputeQuotaResourceConfig
            /// </summary>
            public List<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaResourceConfig> ComputeQuotaResources { get; set; }
            /// <summary>
            /// PreemptTeamTasks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaconfig.html#cfn-sagemaker-computequota-computequotaconfig-preemptteamtasks
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreemptTeamTasks { get; set; }
        }

        public class ComputeQuotaResourceConfig : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveCount
        {
            /// <summary>
            /// AcceleratorPartition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-acceleratorpartition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AcceleratorPartitionConfig
            /// </summary>
            public Humidifier.SageMaker.ComputeQuotaTypes.AcceleratorPartitionConfig AcceleratorPartition { get; set; }
            /// <summary>
            /// VCpu
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-vcpu
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic VCpu { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Count { get; set; }
            /// <summary>
            /// MemoryInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-memoryingib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MemoryInGiB { get; set; }
            /// <summary>
            /// Accelerators
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-accelerators
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Accelerators { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotaresourceconfig.html#cfn-sagemaker-computequota-computequotaresourceconfig-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
        }

        public class ComputeQuotaTarget : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TeamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotatarget.html#cfn-sagemaker-computequota-computequotatarget-teamname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TeamName { get; set; }
            /// <summary>
            /// FairShareWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-computequotatarget.html#cfn-sagemaker-computequota-computequotatarget-fairshareweight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FairShareWeight { get; set; }
        }

        public class ResourceSharingConfig : Humidifier.Base.BaseSubResource, IHaveStrategy
        {
            /// <summary>
            /// BorrowLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-resourcesharingconfig.html#cfn-sagemaker-computequota-resourcesharingconfig-borrowlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BorrowLimit { get; set; }
            /// <summary>
            /// Strategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-resourcesharingconfig.html#cfn-sagemaker-computequota-resourcesharingconfig-strategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Strategy { get; set; }
            /// <summary>
            /// AbsoluteBorrowLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-computequota-resourcesharingconfig.html#cfn-sagemaker-computequota-resourcesharingconfig-absoluteborrowlimits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ComputeQuotaResourceConfig
            /// </summary>
            public List<Humidifier.SageMaker.ComputeQuotaTypes.ComputeQuotaResourceConfig> AbsoluteBorrowLimits { get; set; }
        }
    }
}