namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
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
        /// RestrictedInstanceGroupsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-restrictedinstancegroupsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RestrictedInstanceGroupsConfig
        /// </summary>
        public Humidifier.SageMaker.ClusterTypes.RestrictedInstanceGroupsConfig RestrictedInstanceGroupsConfig { get; set; }
        /// <summary>
        /// NodeProvisioningMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-nodeprovisioningmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NodeProvisioningMode { get; set; }
        /// <summary>
        /// InstanceGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-instancegroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ClusterInstanceGroup
        /// </summary>
        public List<Humidifier.SageMaker.ClusterTypes.ClusterInstanceGroup> InstanceGroups { get; set; }
        /// <summary>
        /// RestrictedInstanceGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-restrictedinstancegroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ClusterRestrictedInstanceGroup
        /// </summary>
        public List<Humidifier.SageMaker.ClusterTypes.ClusterRestrictedInstanceGroup> RestrictedInstanceGroups { get; set; }
        public dynamic ClusterName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Orchestrator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-orchestrator
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Orchestrator
        /// </summary>
        public Humidifier.SageMaker.ClusterTypes.Orchestrator Orchestrator { get; set; }
        /// <summary>
        /// AutoScaling
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-autoscaling
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ClusterAutoScalingConfig
        /// </summary>
        public Humidifier.SageMaker.ClusterTypes.ClusterAutoScalingConfig AutoScaling { get; set; }
        /// <summary>
        /// ClusterRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-clusterrole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterRole { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// TieredStorageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-cluster.html#cfn-sagemaker-cluster-tieredstorageconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TieredStorageConfig
        /// </summary>
        public Humidifier.SageMaker.ClusterTypes.TieredStorageConfig TieredStorageConfig { get; set; }
    }

    namespace ClusterTypes
    {
        public class AlarmDetails : Humidifier.Base.BaseSubResource, IHaveAlarmName
        {
            /// <summary>
            /// AlarmName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-alarmdetails.html#cfn-sagemaker-cluster-alarmdetails-alarmname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AlarmName { get; set; }
        }

        public class AutoPatchConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PatchingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-autopatchconfig.html#cfn-sagemaker-cluster-autopatchconfig-patchingstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PatchingStrategy { get; set; }
            /// <summary>
            /// PatchSchedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-autopatchconfig.html#cfn-sagemaker-cluster-autopatchconfig-patchschedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PatchSchedule
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.PatchSchedule PatchSchedule { get; set; }
            /// <summary>
            /// DeploymentConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-autopatchconfig.html#cfn-sagemaker-cluster-autopatchconfig-deploymentconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeploymentConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.DeploymentConfig DeploymentConfig { get; set; }
        }

        public class CapacitySizeConfig : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-capacitysizeconfig.html#cfn-sagemaker-cluster-capacitysizeconfig-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-capacitysizeconfig.html#cfn-sagemaker-cluster-capacitysizeconfig-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class ClusterAccountingDatabase : Humidifier.Base.BaseSubResource, IHaveName, IHavePort, IHaveSecretArn, IHaveEndpoint
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusteraccountingdatabase.html#cfn-sagemaker-cluster-clusteraccountingdatabase-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusteraccountingdatabase.html#cfn-sagemaker-cluster-clusteraccountingdatabase-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusteraccountingdatabase.html#cfn-sagemaker-cluster-clusteraccountingdatabase-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Port { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusteraccountingdatabase.html#cfn-sagemaker-cluster-clusteraccountingdatabase-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ClusterAutoScalingConfig : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterautoscalingconfig.html#cfn-sagemaker-cluster-clusterautoscalingconfig-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// AutoScalerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterautoscalingconfig.html#cfn-sagemaker-cluster-clusterautoscalingconfig-autoscalertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AutoScalerType { get; set; }
        }

        public class ClusterCapacityRequirements : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Spot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clustercapacityrequirements.html#cfn-sagemaker-cluster-clustercapacityrequirements-spot
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Spot { get; set; }
            /// <summary>
            /// OnDemand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clustercapacityrequirements.html#cfn-sagemaker-cluster-clustercapacityrequirements-ondemand
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic OnDemand { get; set; }
        }

        public class ClusterEbsVolumeConfig : Humidifier.Base.BaseSubResource, IHaveVolumeSizeInGB, IHaveVolumeKmsKeyId
        {
            /// <summary>
            /// VolumeSizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterebsvolumeconfig.html#cfn-sagemaker-cluster-clusterebsvolumeconfig-volumesizeingb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSizeInGB { get; set; }
            /// <summary>
            /// VolumeKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterebsvolumeconfig.html#cfn-sagemaker-cluster-clusterebsvolumeconfig-volumekmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeKmsKeyId { get; set; }
            /// <summary>
            /// RootVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterebsvolumeconfig.html#cfn-sagemaker-cluster-clusterebsvolumeconfig-rootvolume
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic RootVolume { get; set; }
        }

        public class ClusterFsxLustreConfig : Humidifier.Base.BaseSubResource, IHaveDnsName, IHaveMountPath
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterfsxlustreconfig.html#cfn-sagemaker-cluster-clusterfsxlustreconfig-mountpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MountPath { get; set; }
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterfsxlustreconfig.html#cfn-sagemaker-cluster-clusterfsxlustreconfig-dnsname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsName { get; set; }
            /// <summary>
            /// MountName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterfsxlustreconfig.html#cfn-sagemaker-cluster-clusterfsxlustreconfig-mountname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MountName { get; set; }
        }

        public class ClusterFsxOpenZfsConfig : Humidifier.Base.BaseSubResource, IHaveDnsName, IHaveMountPath
        {
            /// <summary>
            /// MountPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterfsxopenzfsconfig.html#cfn-sagemaker-cluster-clusterfsxopenzfsconfig-mountpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MountPath { get; set; }
            /// <summary>
            /// DnsName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterfsxopenzfsconfig.html#cfn-sagemaker-cluster-clusterfsxopenzfsconfig-dnsname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DnsName { get; set; }
        }

        public class ClusterInstanceGroup : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveInstanceCount, IHaveExecutionRole, IHaveImageId, IHaveThreadsPerCore, IHaveMinInstanceCount
        {
            /// <summary>
            /// SlurmConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-slurmconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterSlurmConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterSlurmConfig SlurmConfig { get; set; }
            /// <summary>
            /// CapacityRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-capacityrequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterCapacityRequirements
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterCapacityRequirements CapacityRequirements { get; set; }
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
            /// KubernetesConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-kubernetesconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterKubernetesConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterKubernetesConfig KubernetesConfig { get; set; }
            /// <summary>
            /// NetworkInterface
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-networkinterface
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterNetworkInterface
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterNetworkInterface NetworkInterface { get; set; }
            /// <summary>
            /// LifeCycleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-lifecycleconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterLifeCycleConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterLifeCycleConfig LifeCycleConfig { get; set; }
            /// <summary>
            /// TrainingPlanArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-trainingplanarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrainingPlanArn { get; set; }
            /// <summary>
            /// ThreadsPerCore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-threadspercore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThreadsPerCore { get; set; }
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
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-imageid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageId { get; set; }
            /// <summary>
            /// CurrentCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-currentcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CurrentCount { get; set; }
            /// <summary>
            /// ScheduledUpdateConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-scheduledupdateconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScheduledUpdateConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ScheduledUpdateConfig ScheduledUpdateConfig { get; set; }
            /// <summary>
            /// InstanceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-instancerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InstanceRequirements
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.InstanceRequirements InstanceRequirements { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// AutoPatchConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-autopatchconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoPatchConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.AutoPatchConfig AutoPatchConfig { get; set; }
            /// <summary>
            /// ImageReleaseVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-imagereleaseversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageReleaseVersion { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRole { get; set; }
            /// <summary>
            /// MinInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancegroup.html#cfn-sagemaker-cluster-clusterinstancegroup-mininstancecount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinInstanceCount { get; set; }
        }

        public class ClusterInstanceStorageConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FsxLustreConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancestorageconfig.html#cfn-sagemaker-cluster-clusterinstancestorageconfig-fsxlustreconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterFsxLustreConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterFsxLustreConfig FsxLustreConfig { get; set; }
            /// <summary>
            /// EbsVolumeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancestorageconfig.html#cfn-sagemaker-cluster-clusterinstancestorageconfig-ebsvolumeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterEbsVolumeConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterEbsVolumeConfig EbsVolumeConfig { get; set; }
            /// <summary>
            /// FsxOpenZfsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterinstancestorageconfig.html#cfn-sagemaker-cluster-clusterinstancestorageconfig-fsxopenzfsconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterFsxOpenZfsConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterFsxOpenZfsConfig FsxOpenZfsConfig { get; set; }
        }

        public class ClusterKubernetesConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Labels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterkubernetesconfig.html#cfn-sagemaker-cluster-clusterkubernetesconfig-labels
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Labels { get; set; }
            /// <summary>
            /// Taints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterkubernetesconfig.html#cfn-sagemaker-cluster-clusterkubernetesconfig-taints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ClusterKubernetesTaint
            /// </summary>
            public List<Humidifier.SageMaker.ClusterTypes.ClusterKubernetesTaint> Taints { get; set; }
        }

        public class ClusterKubernetesTaint : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey, IHaveEffect
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterkubernetestaint.html#cfn-sagemaker-cluster-clusterkubernetestaint-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Effect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterkubernetestaint.html#cfn-sagemaker-cluster-clusterkubernetestaint-effect
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Effect { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterkubernetestaint.html#cfn-sagemaker-cluster-clusterkubernetestaint-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class ClusterLifeCycleConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OnInitComplete
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterlifecycleconfig.html#cfn-sagemaker-cluster-clusterlifecycleconfig-oninitcomplete
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnInitComplete { get; set; }
            /// <summary>
            /// SourceS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterlifecycleconfig.html#cfn-sagemaker-cluster-clusterlifecycleconfig-sources3uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceS3Uri { get; set; }
            /// <summary>
            /// OnCreate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterlifecycleconfig.html#cfn-sagemaker-cluster-clusterlifecycleconfig-oncreate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OnCreate { get; set; }
        }

        public class ClusterNetworkInterface : Humidifier.Base.BaseSubResource, IHaveInterfaceType
        {
            /// <summary>
            /// InterfaceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusternetworkinterface.html#cfn-sagemaker-cluster-clusternetworkinterface-interfacetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InterfaceType { get; set; }
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

        public class ClusterOrchestratorSlurmConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SlurmConfigStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterorchestratorslurmconfig.html#cfn-sagemaker-cluster-clusterorchestratorslurmconfig-slurmconfigstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlurmConfigStrategy { get; set; }
            /// <summary>
            /// AccountingDatabase
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterorchestratorslurmconfig.html#cfn-sagemaker-cluster-clusterorchestratorslurmconfig-accountingdatabase
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterAccountingDatabase
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase AccountingDatabase { get; set; }
        }

        public class ClusterRestrictedInstanceGroup : Humidifier.Base.BaseSubResource, IHaveInstanceType, IHaveInstanceCount, IHaveExecutionRole, IHaveThreadsPerCore
        {
            /// <summary>
            /// OverrideVpcConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-overridevpcconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VpcConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.VpcConfig OverrideVpcConfig { get; set; }
            /// <summary>
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-instancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount { get; set; }
            /// <summary>
            /// OnStartDeepHealthChecks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-onstartdeephealthchecks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OnStartDeepHealthChecks { get; set; }
            /// <summary>
            /// EnvironmentConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-environmentconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EnvironmentConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.EnvironmentConfig EnvironmentConfig { get; set; }
            /// <summary>
            /// InstanceGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-instancegroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceGroupName { get; set; }
            /// <summary>
            /// InstanceStorageConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-instancestorageconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ClusterInstanceStorageConfig
            /// </summary>
            public List<Humidifier.SageMaker.ClusterTypes.ClusterInstanceStorageConfig> InstanceStorageConfigs { get; set; }
            /// <summary>
            /// CurrentCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-currentcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CurrentCount { get; set; }
            /// <summary>
            /// TrainingPlanArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-trainingplanarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TrainingPlanArn { get; set; }
            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType { get; set; }
            /// <summary>
            /// ThreadsPerCore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-threadspercore
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThreadsPerCore { get; set; }
            /// <summary>
            /// ExecutionRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterrestrictedinstancegroup.html#cfn-sagemaker-cluster-clusterrestrictedinstancegroup-executionrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExecutionRole { get; set; }
        }

        public class ClusterSlurmConfig : Humidifier.Base.BaseSubResource, IHaveNodeType
        {
            /// <summary>
            /// PartitionNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterslurmconfig.html#cfn-sagemaker-cluster-clusterslurmconfig-partitionnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PartitionNames { get; set; }
            /// <summary>
            /// NodeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-clusterslurmconfig.html#cfn-sagemaker-cluster-clusterslurmconfig-nodetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NodeType { get; set; }
        }

        public class DeploymentConfig : Humidifier.Base.BaseSubResource, IHaveWaitIntervalInSeconds
        {
            /// <summary>
            /// AutoRollbackConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-deploymentconfig.html#cfn-sagemaker-cluster-deploymentconfig-autorollbackconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AlarmDetails
            /// </summary>
            public List<Humidifier.SageMaker.ClusterTypes.AlarmDetails> AutoRollbackConfiguration { get; set; }
            /// <summary>
            /// WaitIntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-deploymentconfig.html#cfn-sagemaker-cluster-deploymentconfig-waitintervalinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WaitIntervalInSeconds { get; set; }
            /// <summary>
            /// RollingUpdatePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-deploymentconfig.html#cfn-sagemaker-cluster-deploymentconfig-rollingupdatepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RollingUpdatePolicy
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.RollingUpdatePolicy RollingUpdatePolicy { get; set; }
        }

        public class EnvironmentConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FSxLustreConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-environmentconfig.html#cfn-sagemaker-cluster-environmentconfig-fsxlustreconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FSxLustreConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.FSxLustreConfig FSxLustreConfig { get; set; }
        }

        public class FSxLustreConfig : Humidifier.Base.BaseSubResource, IHaveSizeInGiB
        {
            /// <summary>
            /// SizeInGiB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-fsxlustreconfig.html#cfn-sagemaker-cluster-fsxlustreconfig-sizeingib
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInGiB { get; set; }
            /// <summary>
            /// PerUnitStorageThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-fsxlustreconfig.html#cfn-sagemaker-cluster-fsxlustreconfig-perunitstoragethroughput
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PerUnitStorageThroughput { get; set; }
        }

        public class InstanceRequirements : Humidifier.Base.BaseSubResource, IHaveInstanceTypes
        {
            /// <summary>
            /// InstanceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-instancerequirements.html#cfn-sagemaker-cluster-instancerequirements-instancetypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InstanceTypes { get; set; }
        }

        public class Orchestrator : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Slurm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-orchestrator.html#cfn-sagemaker-cluster-orchestrator-slurm
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterOrchestratorSlurmConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorSlurmConfig Slurm { get; set; }
            /// <summary>
            /// Eks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-orchestrator.html#cfn-sagemaker-cluster-orchestrator-eks
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClusterOrchestratorEksConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.ClusterOrchestratorEksConfig Eks { get; set; }
        }

        public class PatchSchedule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// NextPatchDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-patchschedule.html#cfn-sagemaker-cluster-patchschedule-nextpatchdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NextPatchDate { get; set; }
        }

        public class RestrictedInstanceGroupsConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SharedEnvironmentConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-restrictedinstancegroupsconfig.html#cfn-sagemaker-cluster-restrictedinstancegroupsconfig-sharedenvironmentconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SharedEnvironmentConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.SharedEnvironmentConfig SharedEnvironmentConfig { get; set; }
        }

        public class RollingUpdatePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MaximumBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-rollingupdatepolicy.html#cfn-sagemaker-cluster-rollingupdatepolicy-maximumbatchsize
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CapacitySizeConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig MaximumBatchSize { get; set; }
            /// <summary>
            /// RollbackMaximumBatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-rollingupdatepolicy.html#cfn-sagemaker-cluster-rollingupdatepolicy-rollbackmaximumbatchsize
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CapacitySizeConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.CapacitySizeConfig RollbackMaximumBatchSize { get; set; }
        }

        public class ScheduledUpdateConfig : Humidifier.Base.BaseSubResource, IHaveScheduleExpression
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-scheduledupdateconfig.html#cfn-sagemaker-cluster-scheduledupdateconfig-scheduleexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression { get; set; }
            /// <summary>
            /// DeploymentConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-scheduledupdateconfig.html#cfn-sagemaker-cluster-scheduledupdateconfig-deploymentconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeploymentConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.DeploymentConfig DeploymentConfig { get; set; }
        }

        public class SharedEnvironmentConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FSxLustreDeletionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-sharedenvironmentconfig.html#cfn-sagemaker-cluster-sharedenvironmentconfig-fsxlustredeletionpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FSxLustreDeletionPolicy { get; set; }
            /// <summary>
            /// FSxLustreConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-sharedenvironmentconfig.html#cfn-sagemaker-cluster-sharedenvironmentconfig-fsxlustreconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FSxLustreConfig
            /// </summary>
            public Humidifier.SageMaker.ClusterTypes.FSxLustreConfig FSxLustreConfig { get; set; }
        }

        public class TieredStorageConfig : Humidifier.Base.BaseSubResource, IHaveMode
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-tieredstorageconfig.html#cfn-sagemaker-cluster-tieredstorageconfig-mode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
            /// <summary>
            /// InstanceMemoryAllocationPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-cluster-tieredstorageconfig.html#cfn-sagemaker-cluster-tieredstorageconfig-instancememoryallocationpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceMemoryAllocationPercentage { get; set; }
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