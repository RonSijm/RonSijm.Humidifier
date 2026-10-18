namespace Humidifier.EKS
{
    using global::System.Collections.Generic;
    using FargateProfileTypes;

    public class FargateProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStringListOfSubnets, IHaveFargateProfileName, IHaveClusterName, IHavePodExecutionRoleArn, IHaveListOfEKSFargateProfileTypesSelectorSelectors
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.EKS.FargateProfile; }
        /// <summary>
        /// Subnets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-fargateprofile.html#cfn-eks-fargateprofile-subnets
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Subnets { get; set; }
        public Union<string, BaseFunction>? FargateProfileName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-fargateprofile.html#cfn-eks-fargateprofile-clustername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ClusterName { get; set; }

        /// <summary>
        /// PodExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-fargateprofile.html#cfn-eks-fargateprofile-podexecutionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PodExecutionRoleArn { get; set; }

        /// <summary>
        /// Selectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-fargateprofile.html#cfn-eks-fargateprofile-selectors
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Selector
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.EKS.FargateProfileTypes.Selector>, IReadOnlyList<Union<Humidifier.EKS.FargateProfileTypes.Selector, BaseFunction>>, BaseFunction>? Selectors { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eks-fargateprofile.html#cfn-eks-fargateprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FargateProfileTypes
    {
        public class Label : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-fargateprofile-label.html#cfn-eks-fargateprofile-label-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-fargateprofile-label.html#cfn-eks-fargateprofile-label-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class Selector : Humidifier.Base.BaseSubResource, IHaveListOfEKSFargateProfileTypesLabelLabels, IHaveNamespace_
        {
            /// <summary>
            /// Labels
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-fargateprofile-selector.html#cfn-eks-fargateprofile-selector-labels
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Label
            /// </summary>
            public Union<IReadOnlyList<Humidifier.EKS.FargateProfileTypes.Label>, IReadOnlyList<Union<Humidifier.EKS.FargateProfileTypes.Label, BaseFunction>>, BaseFunction>? Labels { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eks-fargateprofile-selector.html#cfn-eks-fargateprofile-selector-namespace
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }
    }
}