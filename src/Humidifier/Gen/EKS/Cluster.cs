namespace Humidifier.EKS
{
    using System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveRoleArn, IHaveVersion
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
        /// Logging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-logging
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Logging
        /// </summary>
        public Humidifier.EKS.ClusterTypes.Logging Logging { get; set; }
        /// <summary>
        /// BootstrapSelfManagedAddons
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-bootstrapselfmanagedaddons
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic BootstrapSelfManagedAddons { get; set; }
        /// <summary>
        /// ZonalShiftConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-zonalshiftconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ZonalShiftConfig
        /// </summary>
        public Humidifier.EKS.ClusterTypes.ZonalShiftConfig ZonalShiftConfig { get; set; }
        /// <summary>
        /// AccessConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-accessconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessConfig
        /// </summary>
        public Humidifier.EKS.ClusterTypes.AccessConfig AccessConfig { get; set; }
        /// <summary>
        /// EncryptionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-encryptionconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: EncryptionConfig
        /// </summary>
        public List<Humidifier.EKS.ClusterTypes.EncryptionConfig> EncryptionConfig { get; set; }
        /// <summary>
        /// KubernetesNetworkConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-kubernetesnetworkconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: KubernetesNetworkConfig
        /// </summary>
        public Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig KubernetesNetworkConfig { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// UpgradePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-upgradepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UpgradePolicy
        /// </summary>
        public Humidifier.EKS.ClusterTypes.UpgradePolicy UpgradePolicy { get; set; }
        /// <summary>
        /// Version
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-version
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Version { get; set; }
        /// <summary>
        /// OutpostConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-outpostconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: OutpostConfig
        /// </summary>
        public Humidifier.EKS.ClusterTypes.OutpostConfig OutpostConfig { get; set; }

        /// <summary>
        /// ResourcesVpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-resourcesvpcconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ResourcesVpcConfig
        /// </summary>
        [Required]
        public Humidifier.EKS.ClusterTypes.ResourcesVpcConfig ResourcesVpcConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-cluster.html#cfn-eks-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ClusterTypes
    {
        public class AccessConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthenticationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-accessconfig.html#cfn-eks-cluster-accessconfig-authenticationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthenticationMode { get; set; }
            /// <summary>
            /// BootstrapClusterCreatorAdminPermissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-accessconfig.html#cfn-eks-cluster-accessconfig-bootstrapclustercreatoradminpermissions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BootstrapClusterCreatorAdminPermissions { get; set; }
        }

        public class ClusterLogging : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnabledTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-clusterlogging.html#cfn-eks-cluster-clusterlogging-enabledtypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LoggingTypeConfig
            /// </summary>
            public List<Humidifier.EKS.ClusterTypes.LoggingTypeConfig> EnabledTypes { get; set; }
        }

        public class ControlPlanePlacement : Humidifier.Base.BaseSubResource, IHaveGroupName
        {
            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-controlplaneplacement.html#cfn-eks-cluster-controlplaneplacement-groupname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupName { get; set; }
        }

        public class EncryptionConfig : Humidifier.Base.BaseSubResource, IHaveResources
        {
            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-encryptionconfig.html#cfn-eks-cluster-encryptionconfig-resources
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Resources { get; set; }
            /// <summary>
            /// Provider
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-encryptionconfig.html#cfn-eks-cluster-encryptionconfig-provider
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Provider
            /// </summary>
            public Humidifier.EKS.ClusterTypes.Provider Provider { get; set; }
        }

        public class KubernetesNetworkConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServiceIpv4Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubernetesnetworkconfig.html#cfn-eks-cluster-kubernetesnetworkconfig-serviceipv4cidr
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceIpv4Cidr { get; set; }
            /// <summary>
            /// ServiceIpv6Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubernetesnetworkconfig.html#cfn-eks-cluster-kubernetesnetworkconfig-serviceipv6cidr
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceIpv6Cidr { get; set; }
            /// <summary>
            /// IpFamily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-kubernetesnetworkconfig.html#cfn-eks-cluster-kubernetesnetworkconfig-ipfamily
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IpFamily { get; set; }
        }

        public class Logging : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClusterLogging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-logging.html#cfn-eks-cluster-logging-clusterlogging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClusterLogging
            /// </summary>
            public Humidifier.EKS.ClusterTypes.ClusterLogging ClusterLogging { get; set; }
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
            public dynamic Type { get; set; }
        }

        public class OutpostConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OutpostArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-outpostconfig.html#cfn-eks-cluster-outpostconfig-outpostarns
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OutpostArns { get; set; }
            /// <summary>
            /// ControlPlanePlacement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-outpostconfig.html#cfn-eks-cluster-outpostconfig-controlplaneplacement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ControlPlanePlacement
            /// </summary>
            public Humidifier.EKS.ClusterTypes.ControlPlanePlacement ControlPlanePlacement { get; set; }
            /// <summary>
            /// ControlPlaneInstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-outpostconfig.html#cfn-eks-cluster-outpostconfig-controlplaneinstancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ControlPlaneInstanceType { get; set; }
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
            public dynamic KeyArn { get; set; }
        }

        public class ResourcesVpcConfig : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// EndpointPublicAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-endpointpublicaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EndpointPublicAccess { get; set; }
            /// <summary>
            /// PublicAccessCidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-publicaccesscidrs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PublicAccessCidrs { get; set; }
            /// <summary>
            /// EndpointPrivateAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-endpointprivateaccess
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EndpointPrivateAccess { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-resourcesvpcconfig.html#cfn-eks-cluster-resourcesvpcconfig-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }

        public class UpgradePolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SupportType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-upgradepolicy.html#cfn-eks-cluster-upgradepolicy-supporttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SupportType { get; set; }
        }

        public class ZonalShiftConfig : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-cluster-zonalshiftconfig.html#cfn-eks-cluster-zonalshiftconfig-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }
    }
}