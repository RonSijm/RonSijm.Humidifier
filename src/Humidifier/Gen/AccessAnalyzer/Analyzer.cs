namespace Humidifier.AccessAnalyzer
{
    using System.Collections.Generic;
    using AnalyzerTypes;

    public class Analyzer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.AccessAnalyzer.Analyzer; }
        /// <summary>
        /// ArchiveRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-analyzer.html#cfn-accessanalyzer-analyzer-archiverules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ArchiveRule
        /// </summary>
        public List<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule> ArchiveRules { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-analyzer.html#cfn-accessanalyzer-analyzer-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        public dynamic AnalyzerName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-analyzer.html#cfn-accessanalyzer-analyzer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// AnalyzerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-analyzer.html#cfn-accessanalyzer-analyzer-analyzerconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: AnalyzerConfiguration
        /// </summary>
        public Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration AnalyzerConfiguration { get; set; }
    }

    namespace AnalyzerTypes
    {
        public class AnalysisRule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analysisrule.html#cfn-accessanalyzer-analyzer-analysisrule-exclusions
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: AnalysisRuleCriteria
            /// </summary>
            public List<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRuleCriteria> Exclusions { get; set; }
        }

        public class AnalysisRuleCriteria : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analysisrulecriteria.html#cfn-accessanalyzer-analyzer-analysisrulecriteria-accountids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AccountIds { get; set; }
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analysisrulecriteria.html#cfn-accessanalyzer-analyzer-analysisrulecriteria-resourcetags
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ResourceTags { get; set; }
        }

        public class AnalyzerConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UnusedAccessConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analyzerconfiguration.html#cfn-accessanalyzer-analyzer-analyzerconfiguration-unusedaccessconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: UnusedAccessConfiguration
            /// </summary>
            public Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration UnusedAccessConfiguration { get; set; }
        }

        public class ArchiveRule : Humidifier.Base.BaseSubResource, IHaveRuleName
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-archiverule.html#cfn-accessanalyzer-analyzer-archiverule-filter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public List<Humidifier.AccessAnalyzer.AnalyzerTypes.Filter> Filter { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-archiverule.html#cfn-accessanalyzer-analyzer-archiverule-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveProperty, IHaveEq
        {
            /// <summary>
            /// Exists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-exists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Exists { get; set; }
            /// <summary>
            /// Contains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-contains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Contains { get; set; }
            /// <summary>
            /// Neq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-neq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Neq { get; set; }
            /// <summary>
            /// Eq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-eq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Eq { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-property
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Property { get; set; }
        }

        public class UnusedAccessConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UnusedAccessAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-unusedaccessconfiguration.html#cfn-accessanalyzer-analyzer-unusedaccessconfiguration-unusedaccessage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UnusedAccessAge { get; set; }
            /// <summary>
            /// AnalysisRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-unusedaccessconfiguration.html#cfn-accessanalyzer-analyzer-unusedaccessconfiguration-analysisrule
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AnalysisRule
            /// </summary>
            public Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule AnalysisRule { get; set; }
        }
    }
}