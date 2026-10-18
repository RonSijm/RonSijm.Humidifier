namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using AddonTypes;

    public class Addon : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveEKSAddonTypesNamespaceConfigNamespaceConfig, IHavePreserveOnDelete_Boolean, IHaveAddonVersion, IHaveServiceAccountRoleArn, IHaveClusterName, IHaveAddonName, IHaveListOfEKSAddonTypesPodIdentityAssociationPodIdentityAssociations, IHaveResolveConflicts, IHaveConfigurationValues
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EKS.Addon; }
        /// <summary>
        /// NamespaceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-namespaceconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: NamespaceConfig
        /// </summary>
        public Union<Humidifier.EKS.AddonTypes.NamespaceConfig, BaseFunction>? NamespaceConfig { get; set; }
        /// <summary>
        /// PreserveOnDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-preserveondelete
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PreserveOnDelete { get; set; }
        /// <summary>
        /// AddonVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-addonversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AddonVersion { get; set; }
        /// <summary>
        /// ServiceAccountRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-serviceaccountrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServiceAccountRoleArn { get; set; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterName { get; set; }
        public Union<string, BaseFunction>? AddonName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// PodIdentityAssociations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-podidentityassociations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: PodIdentityAssociation
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EKS.AddonTypes.PodIdentityAssociation>, IReadOnlyList<Union<Humidifier.EKS.AddonTypes.PodIdentityAssociation, BaseFunction>>, BaseFunction>? PodIdentityAssociations { get; set; }
        /// <summary>
        /// ResolveConflicts
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-resolveconflicts
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ResolveConflicts { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// ConfigurationValues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-addon.html#cfn-eks-addon-configurationvalues
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConfigurationValues { get; set; }
    }

    namespace AddonTypes
    {
        public class NamespaceConfig : Humidifier.Base.BaseSubResource, IHaveNamespace_
        {
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-addon-namespaceconfig.html#cfn-eks-addon-namespaceconfig-namespace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class PodIdentityAssociation : Humidifier.Base.BaseSubResource, IHaveServiceAccount, IHaveRoleArn
        {
            /// <summary>
            /// ServiceAccount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-addon-podidentityassociation.html#cfn-eks-addon-podidentityassociation-serviceaccount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServiceAccount { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-addon-podidentityassociation.html#cfn-eks-addon-podidentityassociation-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}