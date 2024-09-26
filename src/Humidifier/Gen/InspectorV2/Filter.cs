namespace Humidifier.InspectorV2
{
    using System.Collections.Generic;
    using FilterTypes;

    public class Filter : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
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
        public dynamic Description { get; set; }

        /// <summary>
        /// FilterCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-filter.html#cfn-inspectorv2-filter-filtercriteria
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FilterCriteria
        /// </summary>
        [Required]
        public Humidifier.InspectorV2.FilterTypes.FilterCriteria FilterCriteria { get; set; }

        /// <summary>
        /// FilterAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-filter.html#cfn-inspectorv2-filter-filteraction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FilterAction { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace FilterTypes
    {
        public class DateFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EndInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-datefilter.html#cfn-inspectorv2-filter-datefilter-endinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EndInclusive { get; set; }
            /// <summary>
            /// StartInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-datefilter.html#cfn-inspectorv2-filter-datefilter-startinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StartInclusive { get; set; }
        }

        public class FilterCriteria : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-resourcetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MapFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.MapFilter> ResourceTags { get; set; }
            /// <summary>
            /// Ec2InstanceImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ec2instanceimageid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> Ec2InstanceImageId { get; set; }
            /// <summary>
            /// FirstObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-firstobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.DateFilter> FirstObservedAt { get; set; }
            /// <summary>
            /// InspectorScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-inspectorscore
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NumberFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.NumberFilter> InspectorScore { get; set; }
            /// <summary>
            /// Ec2InstanceVpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ec2instancevpcid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> Ec2InstanceVpcId { get; set; }
            /// <summary>
            /// LastObservedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-lastobservedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.DateFilter> LastObservedAt { get; set; }
            /// <summary>
            /// EcrImagePushedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagepushedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.DateFilter> EcrImagePushedAt { get; set; }
            /// <summary>
            /// EcrImageArchitecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagearchitecture
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> EcrImageArchitecture { get; set; }
            /// <summary>
            /// RelatedVulnerabilities
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-relatedvulnerabilities
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> RelatedVulnerabilities { get; set; }
            /// <summary>
            /// EcrImageTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagetags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> EcrImageTags { get; set; }
            /// <summary>
            /// VulnerabilityId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-vulnerabilityid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> VulnerabilityId { get; set; }
            /// <summary>
            /// ComponentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-componenttype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> ComponentType { get; set; }
            /// <summary>
            /// VendorSeverity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-vendorseverity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> VendorSeverity { get; set; }
            /// <summary>
            /// EcrImageRepositoryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagerepositoryname
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> EcrImageRepositoryName { get; set; }
            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-title
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> Title { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> ResourceType { get; set; }
            /// <summary>
            /// Severity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-severity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> Severity { get; set; }
            /// <summary>
            /// NetworkProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-networkprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> NetworkProtocol { get; set; }
            /// <summary>
            /// UpdatedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-updatedat
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DateFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.DateFilter> UpdatedAt { get; set; }
            /// <summary>
            /// EcrImageHash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimagehash
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> EcrImageHash { get; set; }
            /// <summary>
            /// PortRange
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-portrange
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PortRangeFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.PortRangeFilter> PortRange { get; set; }
            /// <summary>
            /// VulnerabilitySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-vulnerabilitysource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> VulnerabilitySource { get; set; }
            /// <summary>
            /// Ec2InstanceSubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ec2instancesubnetid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> Ec2InstanceSubnetId { get; set; }
            /// <summary>
            /// FindingArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-findingarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> FindingArn { get; set; }
            /// <summary>
            /// ResourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-resourceid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> ResourceId { get; set; }
            /// <summary>
            /// FindingStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-findingstatus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> FindingStatus { get; set; }
            /// <summary>
            /// VulnerablePackages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-vulnerablepackages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PackageFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.PackageFilter> VulnerablePackages { get; set; }
            /// <summary>
            /// AwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-awsaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> AwsAccountId { get; set; }
            /// <summary>
            /// ComponentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-componentid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> ComponentId { get; set; }
            /// <summary>
            /// EcrImageRegistry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-ecrimageregistry
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> EcrImageRegistry { get; set; }
            /// <summary>
            /// FindingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-filtercriteria.html#cfn-inspectorv2-filter-filtercriteria-findingtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StringFilter
            /// </summary>
            public List<Humidifier.InspectorV2.FilterTypes.StringFilter> FindingType { get; set; }
        }

        public class MapFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-mapfilter.html#cfn-inspectorv2-filter-mapfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-mapfilter.html#cfn-inspectorv2-filter-mapfilter-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-mapfilter.html#cfn-inspectorv2-filter-mapfilter-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class NumberFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LowerInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-numberfilter.html#cfn-inspectorv2-filter-numberfilter-lowerinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic LowerInclusive { get; set; }
            /// <summary>
            /// UpperInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-numberfilter.html#cfn-inspectorv2-filter-numberfilter-upperinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic UpperInclusive { get; set; }
        }

        public class PackageFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Architecture
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-architecture
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Humidifier.InspectorV2.FilterTypes.StringFilter Architecture { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-version
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Humidifier.InspectorV2.FilterTypes.StringFilter Version { get; set; }
            /// <summary>
            /// Epoch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-epoch
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NumberFilter
            /// </summary>
            public Humidifier.InspectorV2.FilterTypes.NumberFilter Epoch { get; set; }
            /// <summary>
            /// SourceLayerHash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-sourcelayerhash
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Humidifier.InspectorV2.FilterTypes.StringFilter SourceLayerHash { get; set; }
            /// <summary>
            /// Release
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-release
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Humidifier.InspectorV2.FilterTypes.StringFilter Release { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-packagefilter.html#cfn-inspectorv2-filter-packagefilter-name
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StringFilter
            /// </summary>
            public Humidifier.InspectorV2.FilterTypes.StringFilter Name { get; set; }
        }

        public class PortRangeFilter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BeginInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-portrangefilter.html#cfn-inspectorv2-filter-portrangefilter-begininclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BeginInclusive { get; set; }
            /// <summary>
            /// EndInclusive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-portrangefilter.html#cfn-inspectorv2-filter-portrangefilter-endinclusive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EndInclusive { get; set; }
        }

        public class StringFilter : Humidifier.Base.BaseSubResource, IHaveValue, IHaveComparison
        {
            /// <summary>
            /// Comparison
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-stringfilter.html#cfn-inspectorv2-filter-stringfilter-comparison
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comparison { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-filter-stringfilter.html#cfn-inspectorv2-filter-stringfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }
    }
}