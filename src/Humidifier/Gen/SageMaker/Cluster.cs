namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveClusterName
    {
        public class Attributes
        {
            public static string ClusterArn =  "ClusterArn" ;
            public static string CreationTime =  "CreationTime" ;
            public static string FailureMessage =  "FailureMessage" ;
            public static string ClusterStatus =  "ClusterStatus" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.Cluster; }
        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public Humidifier.SageMaker.ClusterTypes.VpcConfig VpcConfig { get; set; }
        /// <summary>
        /// NodeRecovery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-noderecovery
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NodeRecovery { get; set; }

        /// <summary>
        /// InstanceGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-instancegroups
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ClusterInstanceGroup
        /// </summary>
        [Required]
        public List<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> InstanceGroups { get; set; }
        public dynamic ClusterName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Orchestrator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-orchestrator
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Orchestrator
        /// </summary>
        public Humidifier.SageMaker.ClusterTypes.Orchestrator Orchestrator { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ClusterTypes
    {
        public class ClusterEbsVolumeConfig : Humidifier.Base.BaseSubResource, IHaveVolumeSizeInGB
        {
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterebsvolumeconfig.html#cfn-sagemaker-cluster-clusterebsvolumeconfig-volumesizeingb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGB { get; set; }
        }

        public class ClusterInstanceGroup : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveInstanceCount, IHaveExecutionRole, IHaveThreadsPerCore
        {
            /// <summary>
            /// OverrideVpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-overridevpcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.VpcConfig OverrideVpcConfig { get; set; }
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-instancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// OnStartDeepHealthChecks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-onstartdeephealthchecks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OnStartDeepHealthChecks { get; set; }
            /// <summary>
            /// InstanceGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-instancegroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceGroupName { get; set; }
            /// <summary>
            /// InstanceStorageConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-instancestorageconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ClusterInstanceStorageConfig
            /// </summary>
            public List<Humidifier.SageMaker.ClusterTypes.ClusterInstanceStorageConfig> InstanceStorageConfigs { get; set; }
            /// <summary>
            /// CurrentCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-currentcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CurrentCount { get; set; }
            /// <summary>
            /// LifeCycleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-lifecycleconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClusterLifeCycleConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig LifeCycleConfig { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// ThreadsPerCore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-threadspercore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThreadsPerCore { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRole { get; set; }
        }

        public class ClusterInstanceStorageConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EbsVolumeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancestorageconfig.html#cfn-sagemaker-cluster-clusterinstancestorageconfig-ebsvolumeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterEbsVolumeConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterEbsVolumeConfig EbsVolumeConfig { get; set; }
        }

        public class ClusterLifeCycleConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterlifecycleconfig.html#cfn-sagemaker-cluster-clusterlifecycleconfig-sources3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceS3Uri { get; set; }
            /// <summary>
            /// OnCreate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterlifecycleconfig.html#cfn-sagemaker-cluster-clusterlifecycleconfig-oncreate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnCreate { get; set; }
        }

        public class ClusterOrchestratorEksConfig : Humidifier.Base.BaseSubResource, IHaveClusterArn
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterorchestratoreksconfig.html#cfn-sagemaker-cluster-clusterorchestratoreksconfig-clusterarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterArn { get; set; }
        }

        public class Orchestrator : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Eks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-orchestrator.html#cfn-sagemaker-cluster-orchestrator-eks
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ClusterOrchestratorEksConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig Eks { get; set; }
        }

        public class VpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnets
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-vpcconfig.html#cfn-sagemaker-cluster-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-vpcconfig.html#cfn-sagemaker-cluster-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets { get; set; }
        }
    }
}