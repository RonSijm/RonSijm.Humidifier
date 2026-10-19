namespace Humidifier.InspectorV2
{
    using global::System.Collections.Generic;
    using FilterTypes;

    public class Filter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveInspectorV2FilterTypesFilterCriteriaFilterCriteria, IHaveFilterAction, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.InspectorV2.Filter; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-filter.html#cfn-inspectorv2-filter-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// FilterCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-filter.html#cfn-inspectorv2-filter-filtercriteria
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FilterCriteria
        /// </summary>
        [Required]
        public Union<Humidifier.InspectorV2.FilterTypes.FilterCriteria, BaseFunction>? FilterCriteria { get; set; }

        /// <summary>
        /// FilterAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-filter.html#cfn-inspectorv2-filter-filteraction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FilterAction { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-filter.html#cfn-inspectorv2-filter-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace FilterTypes
    {
        public class DateFilter : Humidifier.Base.BaseSubResource, IHaveEndInclusive_Long, IHaveStartInclusive_Long
        {
            /// <summary>
            /// EndInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-datefilter.html#cfn-inspectorv2-filter-datefilter-endinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? EndInclusive { get; set; }
            /// <summary>
            /// StartInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-datefilter.html#cfn-inspectorv2-filter-datefilter-startinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? StartInclusive { get; set; }
        }

        public class FilterCriteria : Humidifier.Base.BaseSubResource, IHaveListOfInspectorV2FilterTypesMapFilterResourceTags, IHaveListOfInspectorV2FilterTypesStringFilterEc2InstanceImageId, IHaveListOfInspectorV2FilterTypesDateFilterFirstObservedAt, IHaveListOfInspectorV2FilterTypesNumberFilterInspectorScore, IHaveListOfInspectorV2FilterTypesStringFilterEc2InstanceVpcId, IHaveListOfInspectorV2FilterTypesStringFilterLambdaFunctionName, IHaveListOfInspectorV2FilterTypesStringFilterLambdaFunctionRuntime, IHaveListOfInspectorV2FilterTypesDateFilterLastObservedAt, IHaveListOfInspectorV2FilterTypesDateFilterEcrImagePushedAt, IHaveListOfInspectorV2FilterTypesStringFilterLambdaFunctionLayers, IHaveListOfInspectorV2FilterTypesStringFilterFixAvailable, IHaveListOfInspectorV2FilterTypesStringFilterExploitAvailable, IHaveListOfInspectorV2FilterTypesStringFilterEcrImageArchitecture, IHaveListOfInspectorV2FilterTypesStringFilterRelatedVulnerabilities, IHaveListOfInspectorV2FilterTypesStringFilterEcrImageTags, IHaveListOfInspectorV2FilterTypesStringFilterVulnerabilityId, IHaveListOfInspectorV2FilterTypesStringFilterComponentType, IHaveListOfInspectorV2FilterTypesStringFilterLambdaFunctionExecutionRoleArn, IHaveListOfInspectorV2FilterTypesStringFilterVendorSeverity, IHaveListOfInspectorV2FilterTypesStringFilterCodeVulnerabilityDetectorTags, IHaveListOfInspectorV2FilterTypesStringFilterCodeVulnerabilityDetectorName, IHaveListOfInspectorV2FilterTypesStringFilterEcrImageRepositoryName, IHaveListOfInspectorV2FilterTypesStringFilterTitle, IHaveListOfInspectorV2FilterTypesStringFilterResourceType, IHaveListOfInspectorV2FilterTypesStringFilterSeverity, IHaveListOfInspectorV2FilterTypesNumberFilterEcrImageInUseCount, IHaveListOfInspectorV2FilterTypesStringFilterNetworkProtocol, IHaveListOfInspectorV2FilterTypesDateFilterUpdatedAt, IHaveListOfInspectorV2FilterTypesStringFilterCodeVulnerabilityFilePath, IHaveListOfInspectorV2FilterTypesStringFilterEcrImageHash, IHaveListOfInspectorV2FilterTypesDateFilterLambdaFunctionLastModifiedAt, IHaveListOfInspectorV2FilterTypesPortRangeFilterPortRange, IHaveListOfInspectorV2FilterTypesStringFilterVulnerabilitySource, IHaveListOfInspectorV2FilterTypesStringFilterEc2InstanceSubnetId, IHaveListOfInspectorV2FilterTypesStringFilterFindingArn, IHaveListOfInspectorV2FilterTypesStringFilterResourceId, IHaveListOfInspectorV2FilterTypesStringFilterFindingStatus, IHaveListOfInspectorV2FilterTypesPackageFilterVulnerablePackages, IHaveListOfInspectorV2FilterTypesStringFilterAwsAccountId, IHaveListOfInspectorV2FilterTypesNumberFilterEpssScore, IHaveListOfInspectorV2FilterTypesStringFilterComponentId, IHaveListOfInspectorV2FilterTypesStringFilterEcrImageRegistry, IHaveListOfInspectorV2FilterTypesStringFilterFindingType
        {
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-resourcetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.MapFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.MapFilter, BaseFunction>>, BaseFunction>? ResourceTags { get; set; }
            /// <summary>
            /// Ec2InstanceImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ec2instanceimageid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? Ec2InstanceImageId { get; set; }
            /// <summary>
            /// FirstObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-firstobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.DateFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.DateFilter, BaseFunction>>, BaseFunction>? FirstObservedAt { get; set; }
            /// <summary>
            /// InspectorScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-inspectorscore
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.NumberFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.NumberFilter, BaseFunction>>, BaseFunction>? InspectorScore { get; set; }
            /// <summary>
            /// Ec2InstanceVpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ec2instancevpcid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? Ec2InstanceVpcId { get; set; }
            /// <summary>
            /// LambdaFunctionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-lambdafunctionname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? LambdaFunctionName { get; set; }
            /// <summary>
            /// LambdaFunctionRuntime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-lambdafunctionruntime
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? LambdaFunctionRuntime { get; set; }
            /// <summary>
            /// LastObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-lastobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.DateFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.DateFilter, BaseFunction>>, BaseFunction>? LastObservedAt { get; set; }
            /// <summary>
            /// EcrImagePushedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagepushedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.DateFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.DateFilter, BaseFunction>>, BaseFunction>? EcrImagePushedAt { get; set; }
            /// <summary>
            /// LambdaFunctionLayers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-lambdafunctionlayers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? LambdaFunctionLayers { get; set; }
            /// <summary>
            /// FixAvailable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-fixavailable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? FixAvailable { get; set; }
            /// <summary>
            /// ExploitAvailable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-exploitavailable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? ExploitAvailable { get; set; }
            /// <summary>
            /// EcrImageArchitecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagearchitecture
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? EcrImageArchitecture { get; set; }
            /// <summary>
            /// RelatedVulnerabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-relatedvulnerabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? RelatedVulnerabilities { get; set; }
            /// <summary>
            /// EcrImageTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? EcrImageTags { get; set; }
            /// <summary>
            /// VulnerabilityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-vulnerabilityid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? VulnerabilityId { get; set; }
            /// <summary>
            /// ComponentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-componenttype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? ComponentType { get; set; }
            /// <summary>
            /// LambdaFunctionExecutionRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-lambdafunctionexecutionrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? LambdaFunctionExecutionRoleArn { get; set; }
            /// <summary>
            /// VendorSeverity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-vendorseverity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? VendorSeverity { get; set; }
            /// <summary>
            /// CodeVulnerabilityDetectorTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-codevulnerabilitydetectortags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? CodeVulnerabilityDetectorTags { get; set; }
            /// <summary>
            /// CodeVulnerabilityDetectorName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-codevulnerabilitydetectorname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? CodeVulnerabilityDetectorName { get; set; }
            /// <summary>
            /// EcrImageRepositoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagerepositoryname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? EcrImageRepositoryName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? Title { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// Severity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-severity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? Severity { get; set; }
            /// <summary>
            /// EcrImageInUseCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimageinusecount
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.NumberFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.NumberFilter, BaseFunction>>, BaseFunction>? EcrImageInUseCount { get; set; }
            /// <summary>
            /// NetworkProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-networkprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? NetworkProtocol { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.DateFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.DateFilter, BaseFunction>>, BaseFunction>? UpdatedAt { get; set; }
            /// <summary>
            /// CodeVulnerabilityFilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-codevulnerabilityfilepath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? CodeVulnerabilityFilePath { get; set; }
            /// <summary>
            /// EcrImageHash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagehash
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? EcrImageHash { get; set; }
            /// <summary>
            /// LambdaFunctionLastModifiedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-lambdafunctionlastmodifiedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.DateFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.DateFilter, BaseFunction>>, BaseFunction>? LambdaFunctionLastModifiedAt { get; set; }
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-portrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRangeFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.PortRangeFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.PortRangeFilter, BaseFunction>>, BaseFunction>? PortRange { get; set; }
            /// <summary>
            /// VulnerabilitySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-vulnerabilitysource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? VulnerabilitySource { get; set; }
            /// <summary>
            /// Ec2InstanceSubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ec2instancesubnetid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? Ec2InstanceSubnetId { get; set; }
            /// <summary>
            /// FindingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-findingarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? FindingArn { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-resourceid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? ResourceId { get; set; }
            /// <summary>
            /// FindingStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-findingstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? FindingStatus { get; set; }
            /// <summary>
            /// VulnerablePackages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-vulnerablepackages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PackageFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.PackageFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.PackageFilter, BaseFunction>>, BaseFunction>? VulnerablePackages { get; set; }
            /// <summary>
            /// AwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-awsaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? AwsAccountId { get; set; }
            /// <summary>
            /// EpssScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-epssscore
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.NumberFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.NumberFilter, BaseFunction>>, BaseFunction>? EpssScore { get; set; }
            /// <summary>
            /// ComponentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-componentid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? ComponentId { get; set; }
            /// <summary>
            /// EcrImageRegistry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimageregistry
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? EcrImageRegistry { get; set; }
            /// <summary>
            /// FindingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-findingtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.InspectorV2.FilterTypes.StringFilter>, IReadOnlyList<Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>>, BaseFunction>? FindingType { get; set; }
        }

        public class MapFilter : Humidifier.Base.BaseSubResource, IHaveComparison, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-mapfilter.html#cfn-inspectorv2-filter-mapfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-mapfilter.html#cfn-inspectorv2-filter-mapfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-mapfilter.html#cfn-inspectorv2-filter-mapfilter-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class NumberFilter : Humidifier.Base.BaseSubResource, IHaveLowerInclusive_Double, IHaveUpperInclusive_Double
        {
            /// <summary>
            /// LowerInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-numberfilter.html#cfn-inspectorv2-filter-numberfilter-lowerinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? LowerInclusive { get; set; }
            /// <summary>
            /// UpperInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-numberfilter.html#cfn-inspectorv2-filter-numberfilter-upperinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? UpperInclusive { get; set; }
        }

        public class PackageFilter : Humidifier.Base.BaseSubResource, IHaveInspectorV2FilterTypesStringFilterFilePath, IHaveInspectorV2FilterTypesStringFilterArchitecture, IHaveInspectorV2FilterTypesStringFilterVersion, IHaveInspectorV2FilterTypesNumberFilterEpoch, IHaveInspectorV2FilterTypesStringFilterSourceLayerHash, IHaveInspectorV2FilterTypesStringFilterSourceLambdaLayerArn, IHaveInspectorV2FilterTypesStringFilterRelease, IHaveInspectorV2FilterTypesStringFilterName
        {
            /// <summary>
            /// FilePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-filepath
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>? FilePath { get; set; }
            /// <summary>
            /// Architecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-architecture
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>? Architecture { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-version
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Epoch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-epoch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFilter
            /// </summary>
            public Union<Humidifier.InspectorV2.FilterTypes.NumberFilter, BaseFunction>? Epoch { get; set; }
            /// <summary>
            /// SourceLayerHash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-sourcelayerhash
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>? SourceLayerHash { get; set; }
            /// <summary>
            /// SourceLambdaLayerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-sourcelambdalayerarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>? SourceLambdaLayerArn { get; set; }
            /// <summary>
            /// Release
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-release
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>? Release { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-name
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Union<Humidifier.InspectorV2.FilterTypes.StringFilter, BaseFunction>? Name { get; set; }
        }

        public class PortRangeFilter : Humidifier.Base.BaseSubResource, IHaveBeginInclusive_Integer, IHaveEndInclusive_Integer
        {
            /// <summary>
            /// BeginInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-portrangefilter.html#cfn-inspectorv2-filter-portrangefilter-begininclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BeginInclusive { get; set; }
            /// <summary>
            /// EndInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-portrangefilter.html#cfn-inspectorv2-filter-portrangefilter-endinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndInclusive { get; set; }
        }

        public class StringFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveComparison
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-stringfilter.html#cfn-inspectorv2-filter-stringfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-stringfilter.html#cfn-inspectorv2-filter-stringfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comparison { get; set; }
        }
    }
}