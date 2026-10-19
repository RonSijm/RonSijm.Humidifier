namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using CapabilityTypes;

    public class Capability : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveRoleArn, IHaveClusterName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EKS.Capability; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapabilityConfiguration
        /// </summary>
        public Humidifier.EKS.CapabilityTypes.CapabilityConfiguration Configuration { get; set; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ClusterName { get; set; }

        /// <summary>
        /// DeletePropagationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-deletepropagationpolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DeletePropagationPolicy { get; set; }
        public dynamic CapabilityName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace CapabilityTypes
    {
        public class Ack : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EnableCrossNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-ack.html#cfn-eks-capability-ack-enablecrossnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableCrossNamespace { get; set; }
            /// <summary>
            /// DisabledServices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-ack.html#cfn-eks-capability-ack-disabledservices
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DisabledServices { get; set; }
        }

        public class ArgoCd : Humidifier.Base.BaseSubResource, IHaveNamespace_, IHaveServerUrl
        {
            /// <summary>
            /// ServerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-serverurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerUrl { get; set; }
            /// <summary>
            /// NetworkAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-networkaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkAccess
            /// </summary>
            public Humidifier.EKS.CapabilityTypes.NetworkAccess NetworkAccess { get; set; }
            /// <summary>
            /// AwsIdc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-awsidc
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AwsIdc
            /// </summary>
            public Humidifier.EKS.CapabilityTypes.AwsIdc AwsIdc { get; set; }
            /// <summary>
            /// RbacRoleMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-rbacrolemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ArgoCdRoleMapping
            /// </summary>
            public List<Humidifier.EKS.CapabilityTypes.ArgoCdRoleMapping> RbacRoleMappings { get; set; }
            /// <summary>
            /// EndpointPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-endpointprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndpointPrefix { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
        }

        public class ArgoCdRoleMapping : Humidifier.Base.BaseSubResource, IHaveRole
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocdrolemapping.html#cfn-eks-capability-argocdrolemapping-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role { get; set; }
            /// <summary>
            /// Identities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocdrolemapping.html#cfn-eks-capability-argocdrolemapping-identities
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SsoIdentity
            /// </summary>
            public List<Humidifier.EKS.CapabilityTypes.SsoIdentity> Identities { get; set; }
        }

        public class AwsIdc : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IdcRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-awsidc.html#cfn-eks-capability-awsidc-idcregion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdcRegion { get; set; }
            /// <summary>
            /// IdcManagedApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-awsidc.html#cfn-eks-capability-awsidc-idcmanagedapplicationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdcManagedApplicationArn { get; set; }
            /// <summary>
            /// IdcInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-awsidc.html#cfn-eks-capability-awsidc-idcinstancearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdcInstanceArn { get; set; }
        }

        public class CapabilityConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Ack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-capabilityconfiguration.html#cfn-eks-capability-capabilityconfiguration-ack
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ack
            /// </summary>
            public Humidifier.EKS.CapabilityTypes.Ack Ack { get; set; }
            /// <summary>
            /// ArgoCd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-capabilityconfiguration.html#cfn-eks-capability-capabilityconfiguration-argocd
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArgoCd
            /// </summary>
            public Humidifier.EKS.CapabilityTypes.ArgoCd ArgoCd { get; set; }
        }

        public class NetworkAccess : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// VpceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-networkaccess.html#cfn-eks-capability-networkaccess-vpceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic VpceIds { get; set; }
        }

        public class SsoIdentity : Humidifier.Base.BaseSubResource, IHaveType, IHaveId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-ssoidentity.html#cfn-eks-capability-ssoidentity-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-ssoidentity.html#cfn-eks-capability-ssoidentity-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }
    }
}