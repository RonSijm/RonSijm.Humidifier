namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using AccessEntryTypes;

    public class AccessEntry : Humidifier.Base.BaseResource, IHaveTags, IHaveType, IHavePrincipalArn, IHaveStringListOfKubernetesGroups, IHaveUsername, IHaveClusterName, IHaveListOfEKSAccessEntryTypesAccessPolicyAccessPolicies
    {
        public class Attributes
        {
            public static string AccessEntryArn =  "AccessEntryArn" ;
        }

        public override string AWSTypeName { get => AWS.EKS.AccessEntry; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-accessentry.html#cfn-eks-accessentry-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// PrincipalArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-accessentry.html#cfn-eks-accessentry-principalarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PrincipalArn { get; set; }
        /// <summary>
        /// KubernetesGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-accessentry.html#cfn-eks-accessentry-kubernetesgroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? KubernetesGroups { get; set; }
        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-accessentry.html#cfn-eks-accessentry-username
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Username { get; set; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-accessentry.html#cfn-eks-accessentry-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterName { get; set; }
        /// <summary>
        /// AccessPolicies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-accessentry.html#cfn-eks-accessentry-accesspolicies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessPolicy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EKS.AccessEntryTypes.AccessPolicy>, IReadOnlyList<Union<Humidifier.EKS.AccessEntryTypes.AccessPolicy, BaseFunction>>, BaseFunction>? AccessPolicies { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-accessentry.html#cfn-eks-accessentry-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace AccessEntryTypes
    {
        public class AccessPolicy : Humidifier.Base.BaseSubResource, IHavePolicyArn, IHaveEKSAccessEntryTypesAccessScopeAccessScope
        {
            /// <summary>
            /// PolicyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-accessentry-accesspolicy.html#cfn-eks-accessentry-accesspolicy-policyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PolicyArn { get; set; }
            /// <summary>
            /// AccessScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-accessentry-accesspolicy.html#cfn-eks-accessentry-accesspolicy-accessscope
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AccessScope
            /// </summary>
            public Union<Humidifier.EKS.AccessEntryTypes.AccessScope, BaseFunction>? AccessScope { get; set; }
        }

        public class AccessScope : Humidifier.Base.BaseSubResource, IHaveStringListOfNamespaces, IHaveType
        {
            /// <summary>
            /// Namespaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-accessentry-accessscope.html#cfn-eks-accessentry-accessscope-namespaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Namespaces { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-accessentry-accessscope.html#cfn-eks-accessentry-accessscope-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }
    }
}