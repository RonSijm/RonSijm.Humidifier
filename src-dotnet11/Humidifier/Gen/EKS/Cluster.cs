namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveForce_Boolean, IHaveEKSClusterTypesAccessConfigAccessConfig, IHaveListOfEKSClusterTypesEncryptionConfigEncryptionConfig, IHaveEKSClusterTypesKubernetesNetworkConfigKubernetesNetworkConfig, IHaveName, IHaveVersion, IHaveEKSClusterTypesControlPlaneScalingConfigControlPlaneScalingConfig, IHaveEKSClusterTypesOutpostConfigOutpostConfig, IHaveEKSClusterTypesLoggingLogging, IHaveEKSClusterTypesRollbackConfigRollbackConfig, IHaveEKSClusterTypesComputeConfigComputeConfig, IHaveEKSClusterTypesStorageConfigStorageConfig, IHaveBootstrapSelfManagedAddons_Boolean, IHaveEKSClusterTypesKubeApiServerConfigKubeApiServerConfig, IHaveActiveCertificateAuthorityId, IHaveDeletionProtection_Boolean, IHaveEKSClusterTypesZonalShiftConfigZonalShiftConfig, IHaveRoleArn, IHaveEKSClusterTypesKubeControllerManagerConfigKubeControllerManagerConfig, IHaveEKSClusterTypesUpgradePolicyUpgradePolicy, IHaveEKSClusterTypesRemoteNetworkConfigRemoteNetworkConfig, IHaveEKSClusterTypesCertificateAuthorityCertificateAuthority, IHaveEKSClusterTypesKubeSchedulerConfigKubeSchedulerConfig, IHaveEKSClusterTypesResourcesVpcConfigResourcesVpcConfig
    {
        public class Attributes
        {
            public static string Endpoint =  "Endpoint" ;
            public static string ClusterSecurityGroupId =  "ClusterSecurityGroupId" ;
            public static string EncryptionConfigKeyArn =  "EncryptionConfigKeyArn" ;
            public static string Id =  "Id" ;
            public static string CertificateAuthorityData =  "CertificateAuthorityData" ;
            public static string Arn =  "Arn" ;
            public static string OpenIdConnectIssuerUrl =  "OpenIdConnectIssuerUrl" ;
        }

        public override string AWSTypeName { get => AWS.EKS.Cluster; }
        /// <summary>
        /// Force
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-force
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? Force { get; set; }
        /// <summary>
        /// AccessConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-accessconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.AccessConfig, BaseFunction>? AccessConfig { get; set; }
        /// <summary>
        /// EncryptionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-encryptionconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: EncryptionConfig
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EKS.ClusterTypes.EncryptionConfig>, IReadOnlyList<Union<Humidifier.EKS.ClusterTypes.EncryptionConfig, BaseFunction>>, BaseFunction>? EncryptionConfig { get; set; }
        /// <summary>
        /// KubernetesNetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-kubernetesnetworkconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KubernetesNetworkConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig, BaseFunction>? KubernetesNetworkConfig { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Version
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-version
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Version { get; set; }
        /// <summary>
        /// ControlPlaneScalingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-controlplanescalingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ControlPlaneScalingConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.ControlPlaneScalingConfig, BaseFunction>? ControlPlaneScalingConfig { get; set; }
        /// <summary>
        /// OutpostConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-outpostconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OutpostConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.OutpostConfig, BaseFunction>? OutpostConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Logging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-logging
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Logging
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.Logging, BaseFunction>? Logging { get; set; }
        /// <summary>
        /// RollbackConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-rollbackconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RollbackConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.RollbackConfig, BaseFunction>? RollbackConfig { get; set; }
        /// <summary>
        /// ComputeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-computeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ComputeConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.ComputeConfig, BaseFunction>? ComputeConfig { get; set; }
        /// <summary>
        /// StorageConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-storageconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StorageConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.StorageConfig, BaseFunction>? StorageConfig { get; set; }
        /// <summary>
        /// BootstrapSelfManagedAddons
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-bootstrapselfmanagedaddons
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? BootstrapSelfManagedAddons { get; set; }
        /// <summary>
        /// KubeApiServerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-kubeapiserverconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KubeApiServerConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.KubeApiServerConfig, BaseFunction>? KubeApiServerConfig { get; set; }
        /// <summary>
        /// ActiveCertificateAuthorityId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-activecertificateauthorityid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ActiveCertificateAuthorityId { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// ZonalShiftConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-zonalshiftconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ZonalShiftConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.ZonalShiftConfig, BaseFunction>? ZonalShiftConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// KubeControllerManagerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-kubecontrollermanagerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KubeControllerManagerConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.KubeControllerManagerConfig, BaseFunction>? KubeControllerManagerConfig { get; set; }
        /// <summary>
        /// UpgradePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-upgradepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UpgradePolicy
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.UpgradePolicy, BaseFunction>? UpgradePolicy { get; set; }
        /// <summary>
        /// RemoteNetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-remotenetworkconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RemoteNetworkConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.RemoteNetworkConfig, BaseFunction>? RemoteNetworkConfig { get; set; }
        /// <summary>
        /// CertificateAuthority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-certificateauthority
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CertificateAuthority
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.CertificateAuthority, BaseFunction>? CertificateAuthority { get; set; }
        /// <summary>
        /// KubeSchedulerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-kubeschedulerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KubeSchedulerConfig
        /// </summary>
        public Union<Humidifier.EKS.ClusterTypes.KubeSchedulerConfig, BaseFunction>? KubeSchedulerConfig { get; set; }

        /// <summary>
        /// ResourcesVpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-resourcesvpcconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ResourcesVpcConfig
        /// </summary>
        [Required]
        public Union<Humidifier.EKS.ClusterTypes.ResourcesVpcConfig, BaseFunction>? ResourcesVpcConfig { get; set; }
    }

    namespace ClusterTypes
    {
        public class AccessConfig : Humidifier.Base.BaseSubResource, IHaveAuthenticationMode, IHaveBootstrapClusterCreatorAdminPermissions_Boolean
        {
            /// <summary>
            /// AuthenticationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-accessconfig.html#cfn-eks-cluster-accessconfig-authenticationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationMode { get; set; }
            /// <summary>
            /// BootstrapClusterCreatorAdminPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-accessconfig.html#cfn-eks-cluster-accessconfig-bootstrapclustercreatoradminpermissions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BootstrapClusterCreatorAdminPermissions { get; set; }
        }

        public class ActiveCertificateAuthority : Humidifier.Base.BaseSubResource, IHaveActivatedBy, IHaveId
        {
            /// <summary>
            /// ActivatedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-activecertificateauthority.html#cfn-eks-cluster-activecertificateauthority-activatedby
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActivatedBy { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-activecertificateauthority.html#cfn-eks-cluster-activecertificateauthority-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class BlockStorage : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-blockstorage.html#cfn-eks-cluster-blockstorage-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class CertificateAuthority : Humidifier.Base.BaseSubResource, IHaveEKSClusterTypesActiveCertificateAuthorityActive, IHaveData
        {
            /// <summary>
            /// Active
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-certificateauthority.html#cfn-eks-cluster-certificateauthority-active
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ActiveCertificateAuthority
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.ActiveCertificateAuthority, BaseFunction>? Active { get; set; }
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-certificateauthority.html#cfn-eks-cluster-certificateauthority-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Data { get; set; }
        }

        public class ClusterLogging : Humidifier.Base.BaseSubResource, IHaveListOfEKSClusterTypesLoggingTypeConfigEnabledTypes
        {
            /// <summary>
            /// EnabledTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-clusterlogging.html#cfn-eks-cluster-clusterlogging-enabledtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LoggingTypeConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.ClusterTypes.LoggingTypeConfig>, IReadOnlyList<Union<Humidifier.EKS.ClusterTypes.LoggingTypeConfig, BaseFunction>>, BaseFunction>? EnabledTypes { get; set; }
        }

        public class ComputeConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfNodePools, IHaveNodeRoleArn, IHaveEnabled_Boolean
        {
            /// <summary>
            /// NodePools
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-computeconfig.html#cfn-eks-cluster-computeconfig-nodepools
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NodePools { get; set; }
            /// <summary>
            /// NodeRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-computeconfig.html#cfn-eks-cluster-computeconfig-noderolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NodeRoleArn { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-computeconfig.html#cfn-eks-cluster-computeconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ControlPlanePlacement : Humidifier.Base.BaseSubResource, IHaveGroupName, IHaveSpreadLevel
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-controlplaneplacement.html#cfn-eks-cluster-controlplaneplacement-groupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupName { get; set; }
            /// <summary>
            /// SpreadLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-controlplaneplacement.html#cfn-eks-cluster-controlplaneplacement-spreadlevel
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpreadLevel { get; set; }
        }

        public class ControlPlaneScalingConfig : Humidifier.Base.BaseSubResource, IHaveTier
        {
            /// <summary>
            /// Tier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-controlplanescalingconfig.html#cfn-eks-cluster-controlplanescalingconfig-tier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tier { get; set; }
        }

        public class ElasticLoadBalancing : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-elasticloadbalancing.html#cfn-eks-cluster-elasticloadbalancing-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class EncryptionConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfResources, IHaveEKSClusterTypesProviderProvider
        {
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-encryptionconfig.html#cfn-eks-cluster-encryptionconfig-resources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Resources { get; set; }
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-encryptionconfig.html#cfn-eks-cluster-encryptionconfig-provider
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Provider
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.Provider, BaseFunction>? Provider { get; set; }
        }

        public class EtcdPlacement : Humidifier.Base.BaseSubResource, IHaveSpreadLevel
        {
            /// <summary>
            /// SpreadLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-etcdplacement.html#cfn-eks-cluster-etcdplacement-spreadlevel
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpreadLevel { get; set; }
        }

        public class HorizontalPodAutoscalerControllerConfig : Humidifier.Base.BaseSubResource, IHaveHorizontalPodAutoscalerSyncPeriod
        {
            /// <summary>
            /// HorizontalPodAutoscalerSyncPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-horizontalpodautoscalercontrollerconfig.html#cfn-eks-cluster-horizontalpodautoscalercontrollerconfig-horizontalpodautoscalersyncperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HorizontalPodAutoscalerSyncPeriod { get; set; }
        }

        public class KubeApiServerConfig : Humidifier.Base.BaseSubResource, IHaveEKSClusterTypesServiceNodePortRangeServiceNodePortRange, IHaveEventTtl
        {
            /// <summary>
            /// ServiceNodePortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubeapiserverconfig.html#cfn-eks-cluster-kubeapiserverconfig-servicenodeportrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNodePortRange
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.ServiceNodePortRange, BaseFunction>? ServiceNodePortRange { get; set; }
            /// <summary>
            /// EventTtl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubeapiserverconfig.html#cfn-eks-cluster-kubeapiserverconfig-eventttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventTtl { get; set; }
        }

        public class KubeControllerManagerConfig : Humidifier.Base.BaseSubResource, IHaveEKSClusterTypesPodGcControllerConfigPodGcControllerConfig, IHaveEKSClusterTypesHorizontalPodAutoscalerControllerConfigHorizontalPodAutoscalerControllerConfig
        {
            /// <summary>
            /// PodGcControllerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubecontrollermanagerconfig.html#cfn-eks-cluster-kubecontrollermanagerconfig-podgccontrollerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PodGcControllerConfig
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.PodGcControllerConfig, BaseFunction>? PodGcControllerConfig { get; set; }
            /// <summary>
            /// HorizontalPodAutoscalerControllerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubecontrollermanagerconfig.html#cfn-eks-cluster-kubecontrollermanagerconfig-horizontalpodautoscalercontrollerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HorizontalPodAutoscalerControllerConfig
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.HorizontalPodAutoscalerControllerConfig, BaseFunction>? HorizontalPodAutoscalerControllerConfig { get; set; }
        }

        public class KubeSchedulerConfig : Humidifier.Base.BaseSubResource, IHaveEKSClusterTypesNodeResourcesFitConfigNodeResourcesFit
        {
            /// <summary>
            /// NodeResourcesFit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubeschedulerconfig.html#cfn-eks-cluster-kubeschedulerconfig-noderesourcesfit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NodeResourcesFitConfig
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig, BaseFunction>? NodeResourcesFit { get; set; }
        }

        public class KubernetesNetworkConfig : Humidifier.Base.BaseSubResource, IHaveServiceIpv4Cidr, IHaveServiceIpv6Cidr, IHaveIpFamily, IHaveEKSClusterTypesElasticLoadBalancingElasticLoadBalancing
        {
            /// <summary>
            /// ServiceIpv4Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubernetesnetworkconfig.html#cfn-eks-cluster-kubernetesnetworkconfig-serviceipv4cidr
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceIpv4Cidr { get; set; }
            /// <summary>
            /// ServiceIpv6Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubernetesnetworkconfig.html#cfn-eks-cluster-kubernetesnetworkconfig-serviceipv6cidr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceIpv6Cidr { get; set; }
            /// <summary>
            /// IpFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubernetesnetworkconfig.html#cfn-eks-cluster-kubernetesnetworkconfig-ipfamily
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IpFamily { get; set; }
            /// <summary>
            /// ElasticLoadBalancing
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubernetesnetworkconfig.html#cfn-eks-cluster-kubernetesnetworkconfig-elasticloadbalancing
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ElasticLoadBalancing
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing, BaseFunction>? ElasticLoadBalancing { get; set; }
        }

        public class Logging : Humidifier.Base.BaseSubResource, IHaveEKSClusterTypesClusterLoggingClusterLogging
        {
            /// <summary>
            /// ClusterLogging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-logging.html#cfn-eks-cluster-logging-clusterlogging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterLogging
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.ClusterLogging, BaseFunction>? ClusterLogging { get; set; }
        }

        public class LoggingTypeConfig : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-loggingtypeconfig.html#cfn-eks-cluster-loggingtypeconfig-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class NodeResourcesFitConfig : Humidifier.Base.BaseSubResource, IHaveEKSClusterTypesScoringStrategyScoringStrategy
        {
            /// <summary>
            /// ScoringStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-noderesourcesfitconfig.html#cfn-eks-cluster-noderesourcesfitconfig-scoringstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScoringStrategy
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.ScoringStrategy, BaseFunction>? ScoringStrategy { get; set; }
        }

        public class OutpostConfig : Humidifier.Base.BaseSubResource, IHaveEKSClusterTypesEtcdPlacementEtcdPlacement, IHaveStringListOfOutpostArns, IHaveEKSClusterTypesControlPlanePlacementControlPlanePlacement, IHaveEtcdInstanceType, IHaveControlPlaneInstanceType
        {
            /// <summary>
            /// EtcdPlacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-outpostconfig.html#cfn-eks-cluster-outpostconfig-etcdplacement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EtcdPlacement
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.EtcdPlacement, BaseFunction>? EtcdPlacement { get; set; }
            /// <summary>
            /// OutpostArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-outpostconfig.html#cfn-eks-cluster-outpostconfig-outpostarns
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OutpostArns { get; set; }
            /// <summary>
            /// ControlPlanePlacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-outpostconfig.html#cfn-eks-cluster-outpostconfig-controlplaneplacement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ControlPlanePlacement
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.ControlPlanePlacement, BaseFunction>? ControlPlanePlacement { get; set; }
            /// <summary>
            /// EtcdInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-outpostconfig.html#cfn-eks-cluster-outpostconfig-etcdinstancetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EtcdInstanceType { get; set; }
            /// <summary>
            /// ControlPlaneInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-outpostconfig.html#cfn-eks-cluster-outpostconfig-controlplaneinstancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ControlPlaneInstanceType { get; set; }
        }

        public class PodGcControllerConfig : Humidifier.Base.BaseSubResource, IHaveTerminatedPodGcThreshold_Integer
        {
            /// <summary>
            /// TerminatedPodGcThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-podgccontrollerconfig.html#cfn-eks-cluster-podgccontrollerconfig-terminatedpodgcthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TerminatedPodGcThreshold { get; set; }
        }

        public class Provider : Humidifier.Base.BaseSubResource, IHaveKeyArn
        {
            /// <summary>
            /// KeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-provider.html#cfn-eks-cluster-provider-keyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyArn { get; set; }
        }

        public class RemoteNetworkConfig : Humidifier.Base.BaseSubResource, IHaveListOfEKSClusterTypesRemoteNodeNetworkRemoteNodeNetworks, IHaveListOfEKSClusterTypesRemotePodNetworkRemotePodNetworks
        {
            /// <summary>
            /// RemoteNodeNetworks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-remotenetworkconfig.html#cfn-eks-cluster-remotenetworkconfig-remotenodenetworks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RemoteNodeNetwork
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.ClusterTypes.RemoteNodeNetwork>, IReadOnlyList<Union<Humidifier.EKS.ClusterTypes.RemoteNodeNetwork, BaseFunction>>, BaseFunction>? RemoteNodeNetworks { get; set; }
            /// <summary>
            /// RemotePodNetworks
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-remotenetworkconfig.html#cfn-eks-cluster-remotenetworkconfig-remotepodnetworks
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RemotePodNetwork
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.ClusterTypes.RemotePodNetwork>, IReadOnlyList<Union<Humidifier.EKS.ClusterTypes.RemotePodNetwork, BaseFunction>>, BaseFunction>? RemotePodNetworks { get; set; }
        }

        public class RemoteNodeNetwork : Humidifier.Base.BaseSubResource, IHaveStringListOfCidrs
        {
            /// <summary>
            /// Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-remotenodenetwork.html#cfn-eks-cluster-remotenodenetwork-cidrs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cidrs { get; set; }
        }

        public class RemotePodNetwork : Humidifier.Base.BaseSubResource, IHaveStringListOfCidrs
        {
            /// <summary>
            /// Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-remotepodnetwork.html#cfn-eks-cluster-remotepodnetwork-cidrs
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cidrs { get; set; }
        }

        public class ResourceWeight : Humidifier.Base.BaseSubResource, IHaveWeight_Integer, IHaveName
        {
            /// <summary>
            /// Weight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourceweight.html#cfn-eks-cluster-resourceweight-weight
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Weight { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourceweight.html#cfn-eks-cluster-resourceweight-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ResourcesVpcConfig : Humidifier.Base.BaseSubResource, IHaveEndpointPublicAccess_Boolean, IHaveControlPlaneEgressMode, IHaveStringListOfPublicAccessCidrs, IHaveEndpointPrivateAccess_Boolean, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// EndpointPublicAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-endpointpublicaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EndpointPublicAccess { get; set; }
            /// <summary>
            /// ControlPlaneEgressMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-controlplaneegressmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ControlPlaneEgressMode { get; set; }
            /// <summary>
            /// PublicAccessCidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-publicaccesscidrs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PublicAccessCidrs { get; set; }
            /// <summary>
            /// EndpointPrivateAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-endpointprivateaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EndpointPrivateAccess { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class RollbackConfig : Humidifier.Base.BaseSubResource, IHaveTimeoutMinutes_Integer
        {
            /// <summary>
            /// TimeoutMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-rollbackconfig.html#cfn-eks-cluster-rollbackconfig-timeoutminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TimeoutMinutes { get; set; }
        }

        public class ScoringStrategy : Humidifier.Base.BaseSubResource, IHaveType, IHaveListOfEKSClusterTypesResourceWeightResources
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-scoringstrategy.html#cfn-eks-cluster-scoringstrategy-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-scoringstrategy.html#cfn-eks-cluster-scoringstrategy-resources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourceWeight
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.ClusterTypes.ResourceWeight>, IReadOnlyList<Union<Humidifier.EKS.ClusterTypes.ResourceWeight, BaseFunction>>, BaseFunction>? Resources { get; set; }
        }

        public class ServiceNodePortRange : Humidifier.Base.BaseSubResource, IHaveMinPort_Integer, IHaveMaxPort_Integer
        {
            /// <summary>
            /// MinPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-servicenodeportrange.html#cfn-eks-cluster-servicenodeportrange-minport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinPort { get; set; }
            /// <summary>
            /// MaxPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-servicenodeportrange.html#cfn-eks-cluster-servicenodeportrange-maxport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPort { get; set; }
        }

        public class StorageConfig : Humidifier.Base.BaseSubResource, IHaveEKSClusterTypesBlockStorageBlockStorage
        {
            /// <summary>
            /// BlockStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-storageconfig.html#cfn-eks-cluster-storageconfig-blockstorage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockStorage
            /// </summary>
            public Union<Humidifier.EKS.ClusterTypes.BlockStorage, BaseFunction>? BlockStorage { get; set; }
        }

        public class UpgradePolicy : Humidifier.Base.BaseSubResource, IHaveSupportType
        {
            /// <summary>
            /// SupportType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-upgradepolicy.html#cfn-eks-cluster-upgradepolicy-supporttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SupportType { get; set; }
        }

        public class ZonalShiftConfig : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-zonalshiftconfig.html#cfn-eks-cluster-zonalshiftconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }
    }
}