namespace Humidifier.WellArchitected
{
    using global::System.Collections.Generic;
    using WorkloadTypes;

    public class Workload : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveArchitecturalDesign, IHaveDescription, IHaveReviewOwner, IHaveStringListOfAccountIds, IHaveStringListOfNonAwsRegions, IHaveIndustryType, IHaveIndustry, IHaveStringListOfAwsRegions, IHaveWorkloadName, IHaveEnvironment, IHaveWellArchitectedWorkloadTypesDiscoveryConfigDiscoveryConfig, IHaveNotes, IHaveListOfWellArchitectedWorkloadTypesTagsItemsTags, IHaveStringListOfLenses
    {
        public class Attributes
        {
            public static string WorkloadId =  "WorkloadId" ;
            public static string ImprovementStatus =  "ImprovementStatus" ;
            public static string WorkloadArn =  "WorkloadArn" ;
        }

        public override string AWSTypeName { get => AWS.WellArchitected.Workload; }
        /// <summary>
        /// ArchitecturalDesign
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-architecturaldesign
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ArchitecturalDesign { get; set; }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ReviewOwner
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-reviewowner
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ReviewOwner { get; set; }
        /// <summary>
        /// AccountIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-accountids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccountIds { get; set; }
        /// <summary>
        /// NonAwsRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-nonawsregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NonAwsRegions { get; set; }
        /// <summary>
        /// IndustryType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-industrytype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IndustryType { get; set; }
        /// <summary>
        /// Industry
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-industry
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Industry { get; set; }
        /// <summary>
        /// AwsRegions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-awsregions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AwsRegions { get; set; }
        public Union<string, BaseFunction>? WorkloadName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-environment
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Environment { get; set; }
        /// <summary>
        /// DiscoveryConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-discoveryconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DiscoveryConfig
        /// </summary>
        public Union<Humidifier.WellArchitected.WorkloadTypes.DiscoveryConfig, BaseFunction>? DiscoveryConfig { get; set; }
        /// <summary>
        /// Notes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-notes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Notes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public Union<IReadOnlyList<Humidifier.WellArchitected.WorkloadTypes.TagsItems>, IReadOnlyList<Union<Humidifier.WellArchitected.WorkloadTypes.TagsItems, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// Lenses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wellarchitected-workload.html#cfn-wellarchitected-workload-lenses
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Lenses { get; set; }
    }

    namespace WorkloadTypes
    {
        public class DiscoveryConfig : Humidifier.Base.BaseSubResource, IHaveTrustedAdvisorIntegrationStatus, IHaveStringListOfWorkloadResourceDefinition
        {
            /// <summary>
            /// TrustedAdvisorIntegrationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-workload-discoveryconfig.html#cfn-wellarchitected-workload-discoveryconfig-trustedadvisorintegrationstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrustedAdvisorIntegrationStatus { get; set; }
            /// <summary>
            /// WorkloadResourceDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-workload-discoveryconfig.html#cfn-wellarchitected-workload-discoveryconfig-workloadresourcedefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WorkloadResourceDefinition { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-workload-tagsitems.html#cfn-wellarchitected-workload-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wellarchitected-workload-tagsitems.html#cfn-wellarchitected-workload-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}