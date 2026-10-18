namespace Humidifier.AccessAnalyzer
{
    using global::System.Collections.Generic;
    using AnalyzerTypes;

    public class Analyzer : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfAccessAnalyzerAnalyzerTypesArchiveRuleArchiveRules, IHaveType, IHaveAnalyzerName, IHaveAccessAnalyzerAnalyzerTypesAnalyzerConfigurationAnalyzerConfiguration
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
        public Union<IReadOnlyList<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule>, IReadOnlyList<Union<Humidifier.AccessAnalyzer.AnalyzerTypes.ArchiveRule, BaseFunction>>, BaseFunction>? ArchiveRules { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-analyzer.html#cfn-accessanalyzer-analyzer-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        public Union<string, BaseFunction>? AnalyzerName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-analyzer.html#cfn-accessanalyzer-analyzer-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AnalyzerConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-analyzer.html#cfn-accessanalyzer-analyzer-analyzerconfiguration
        /// Required: False
        /// UpdateType: Conditional
        /// Type: AnalyzerConfiguration
        /// </summary>
        public Union<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalyzerConfiguration, BaseFunction>? AnalyzerConfiguration { get; set; }
    }

    namespace AnalyzerTypes
    {
        public class AnalysisRule : Humidifier.Base.BaseSubResource, IHaveListOfAccessAnalyzerAnalyzerTypesAnalysisRuleCriteriaExclusions
        {
            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analysisrule.html#cfn-accessanalyzer-analyzer-analysisrule-exclusions
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: AnalysisRuleCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRuleCriteria>, IReadOnlyList<Union<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRuleCriteria, BaseFunction>>, BaseFunction>? Exclusions { get; set; }
        }

        public class AnalysisRuleCriteria : Humidifier.Base.BaseSubResource, IHaveStringListOfAccountIds, IHaveResourceTags_Json
        {
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analysisrulecriteria.html#cfn-accessanalyzer-analyzer-analysisrulecriteria-accountids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccountIds { get; set; }
            /// <summary>
            /// ResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analysisrulecriteria.html#cfn-accessanalyzer-analyzer-analysisrulecriteria-resourcetags
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ResourceTags { get; set; }
        }

        public class AnalyzerConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessAnalyzerAnalyzerTypesInternalAccessConfigurationInternalAccessConfiguration, IHaveAccessAnalyzerAnalyzerTypesUnusedAccessConfigurationUnusedAccessConfiguration
        {
            /// <summary>
            /// InternalAccessConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analyzerconfiguration.html#cfn-accessanalyzer-analyzer-analyzerconfiguration-internalaccessconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: InternalAccessConfiguration
            /// </summary>
            public Union<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessConfiguration, BaseFunction>? InternalAccessConfiguration { get; set; }
            /// <summary>
            /// UnusedAccessConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-analyzerconfiguration.html#cfn-accessanalyzer-analyzer-analyzerconfiguration-unusedaccessconfiguration
            /// Required: False
            /// UpdateType: Conditional
            /// Type: UnusedAccessConfiguration
            /// </summary>
            public Union<Humidifier.AccessAnalyzer.AnalyzerTypes.UnusedAccessConfiguration, BaseFunction>? UnusedAccessConfiguration { get; set; }
        }

        public class ArchiveRule : Humidifier.Base.BaseSubResource, IHaveListOfAccessAnalyzerAnalyzerTypesFilterFilter, IHaveRuleName
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-archiverule.html#cfn-accessanalyzer-analyzer-archiverule-filter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Filter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AccessAnalyzer.AnalyzerTypes.Filter>, IReadOnlyList<Union<Humidifier.AccessAnalyzer.AnalyzerTypes.Filter, BaseFunction>>, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-archiverule.html#cfn-accessanalyzer-analyzer-archiverule-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuleName { get; set; }
        }

        public class Filter : Humidifier.Base.BaseSubResource, IHaveExists_Boolean, IHaveStringListOfContains, IHaveStringListOfNeq, IHaveStringListOfEq, IHaveProperty
        {
            /// <summary>
            /// Exists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-exists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Exists { get; set; }
            /// <summary>
            /// Contains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-contains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Contains { get; set; }
            /// <summary>
            /// Neq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-neq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Neq { get; set; }
            /// <summary>
            /// Eq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-eq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Eq { get; set; }
            /// <summary>
            /// Property
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-filter.html#cfn-accessanalyzer-analyzer-filter-property
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Property { get; set; }
        }

        public class InternalAccessAnalysisRule : Humidifier.Base.BaseSubResource, IHaveListOfAccessAnalyzerAnalyzerTypesInternalAccessAnalysisRuleCriteriaInclusions
        {
            /// <summary>
            /// Inclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-internalaccessanalysisrule.html#cfn-accessanalyzer-analyzer-internalaccessanalysisrule-inclusions
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// ItemType: InternalAccessAnalysisRuleCriteria
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRuleCriteria>, IReadOnlyList<Union<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRuleCriteria, BaseFunction>>, BaseFunction>? Inclusions { get; set; }
        }

        public class InternalAccessAnalysisRuleCriteria : Humidifier.Base.BaseSubResource, IHaveStringListOfResourceTypes, IHaveStringListOfAccountIds, IHaveStringListOfResourceArns
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-internalaccessanalysisrulecriteria.html#cfn-accessanalyzer-analyzer-internalaccessanalysisrulecriteria-resourcetypes
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-internalaccessanalysisrulecriteria.html#cfn-accessanalyzer-analyzer-internalaccessanalysisrulecriteria-accountids
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccountIds { get; set; }
            /// <summary>
            /// ResourceArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-internalaccessanalysisrulecriteria.html#cfn-accessanalyzer-analyzer-internalaccessanalysisrulecriteria-resourcearns
            /// Required: False
            /// UpdateType: Conditional
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceArns { get; set; }
        }

        public class InternalAccessConfiguration : Humidifier.Base.BaseSubResource, IHaveAccessAnalyzerAnalyzerTypesInternalAccessAnalysisRuleInternalAccessAnalysisRule
        {
            /// <summary>
            /// InternalAccessAnalysisRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-internalaccessconfiguration.html#cfn-accessanalyzer-analyzer-internalaccessconfiguration-internalaccessanalysisrule
            /// Required: False
            /// UpdateType: Conditional
            /// Type: InternalAccessAnalysisRule
            /// </summary>
            public Union<Humidifier.AccessAnalyzer.AnalyzerTypes.InternalAccessAnalysisRule, BaseFunction>? InternalAccessAnalysisRule { get; set; }
        }

        public class UnusedAccessConfiguration : Humidifier.Base.BaseSubResource, IHaveUnusedAccessAge_Integer, IHaveAccessAnalyzerAnalyzerTypesAnalysisRuleAnalysisRule
        {
            /// <summary>
            /// UnusedAccessAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-unusedaccessconfiguration.html#cfn-accessanalyzer-analyzer-unusedaccessconfiguration-unusedaccessage
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UnusedAccessAge { get; set; }
            /// <summary>
            /// AnalysisRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-analyzer-unusedaccessconfiguration.html#cfn-accessanalyzer-analyzer-unusedaccessconfiguration-analysisrule
            /// Required: False
            /// UpdateType: Conditional
            /// Type: AnalysisRule
            /// </summary>
            public Union<Humidifier.AccessAnalyzer.AnalyzerTypes.AnalysisRule, BaseFunction>? AnalysisRule { get; set; }
        }
    }
}