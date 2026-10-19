namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using CapabilityTypes;

    public class Capability : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveEKSCapabilityTypesCapabilityConfigurationConfiguration, IHaveClusterName, IHaveDeletePropagationPolicy, IHaveCapabilityName, IHaveRoleArn
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
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CapabilityConfiguration
        /// </summary>
        public Union<Humidifier.EKS.CapabilityTypes.CapabilityConfiguration, BaseFunction>? Configuration { get; set; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterName { get; set; }

        /// <summary>
        /// DeletePropagationPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-deletepropagationpolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DeletePropagationPolicy { get; set; }
        public Union<string, BaseFunction>? CapabilityName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-capability.html#cfn-eks-capability-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CapabilityTypes
    {
        public class Ack : Humidifier.Base.BaseSubResource, IHaveEnableCrossNamespace_Boolean, IHaveStringListOfDisabledServices
        {
            /// <summary>
            /// EnableCrossNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-ack.html#cfn-eks-capability-ack-enablecrossnamespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableCrossNamespace { get; set; }
            /// <summary>
            /// DisabledServices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-ack.html#cfn-eks-capability-ack-disabledservices
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DisabledServices { get; set; }
        }

        public class ArgoCd : Humidifier.Base.BaseSubResource, IHaveServerUrl, IHaveEKSCapabilityTypesNetworkAccessNetworkAccess, IHaveEKSCapabilityTypesAwsIdcAwsIdc, IHaveListOfEKSCapabilityTypesArgoCdRoleMappingRbacRoleMappings, IHaveEndpointPrefix, IHaveNamespace_
        {
            /// <summary>
            /// ServerUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-serverurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerUrl { get; set; }
            /// <summary>
            /// NetworkAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-networkaccess
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkAccess
            /// </summary>
            public Union<Humidifier.EKS.CapabilityTypes.NetworkAccess, BaseFunction>? NetworkAccess { get; set; }
            /// <summary>
            /// AwsIdc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-awsidc
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AwsIdc
            /// </summary>
            public Union<Humidifier.EKS.CapabilityTypes.AwsIdc, BaseFunction>? AwsIdc { get; set; }
            /// <summary>
            /// RbacRoleMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-rbacrolemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ArgoCdRoleMapping
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.CapabilityTypes.ArgoCdRoleMapping>, IReadOnlyList<Union<Humidifier.EKS.CapabilityTypes.ArgoCdRoleMapping, BaseFunction>>, BaseFunction>? RbacRoleMappings { get; set; }
            /// <summary>
            /// EndpointPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-endpointprefix
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointPrefix { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocd.html#cfn-eks-capability-argocd-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class ArgoCdRoleMapping : Humidifier.Base.BaseSubResource, IHaveRole, IHaveListOfEKSCapabilityTypesSsoIdentityIdentities
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocdrolemapping.html#cfn-eks-capability-argocdrolemapping-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Role { get; set; }
            /// <summary>
            /// Identities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-argocdrolemapping.html#cfn-eks-capability-argocdrolemapping-identities
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SsoIdentity
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.CapabilityTypes.SsoIdentity>, IReadOnlyList<Union<Humidifier.EKS.CapabilityTypes.SsoIdentity, BaseFunction>>, BaseFunction>? Identities { get; set; }
        }

        public class AwsIdc : Humidifier.Base.BaseSubResource, IHaveIdcRegion, IHaveIdcManagedApplicationArn, IHaveIdcInstanceArn
        {
            /// <summary>
            /// IdcRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-awsidc.html#cfn-eks-capability-awsidc-idcregion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdcRegion { get; set; }
            /// <summary>
            /// IdcManagedApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-awsidc.html#cfn-eks-capability-awsidc-idcmanagedapplicationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdcManagedApplicationArn { get; set; }
            /// <summary>
            /// IdcInstanceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-awsidc.html#cfn-eks-capability-awsidc-idcinstancearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdcInstanceArn { get; set; }
        }

        public class CapabilityConfiguration : Humidifier.Base.BaseSubResource, IHaveEKSCapabilityTypesAckAck, IHaveEKSCapabilityTypesArgoCdArgoCd
        {
            /// <summary>
            /// Ack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-capabilityconfiguration.html#cfn-eks-capability-capabilityconfiguration-ack
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Ack
            /// </summary>
            public Union<Humidifier.EKS.CapabilityTypes.Ack, BaseFunction>? Ack { get; set; }
            /// <summary>
            /// ArgoCd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-capabilityconfiguration.html#cfn-eks-capability-capabilityconfiguration-argocd
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArgoCd
            /// </summary>
            public Union<Humidifier.EKS.CapabilityTypes.ArgoCd, BaseFunction>? ArgoCd { get; set; }
        }

        public class NetworkAccess : Humidifier.Base.BaseSubResource, IHaveStringListOfVpceIds
        {
            /// <summary>
            /// VpceIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-networkaccess.html#cfn-eks-capability-networkaccess-vpceids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VpceIds { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-capability-ssoidentity.html#cfn-eks-capability-ssoidentity-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }
    }
}