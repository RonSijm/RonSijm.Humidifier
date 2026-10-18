namespace Humidifier.AccessAnalyzer
{
    using global::System.Collections.Generic;
    using ArchiveRuleTypes;

    public class ArchiveRule : Humidifier.Base.BaseResource, IHaveMapOfAccessAnalyzerArchiveRuleTypesFilterItemsFilter, IHaveAnalyzerName, IHaveRuleName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.AccessAnalyzer.ArchiveRule; }

        /// <summary>
        /// Filter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-archiverule.html#cfn-accessanalyzer-archiverule-filter
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: FilterItems
        /// </summary>
        [Required]
        public Union<IReadOnlyDictionary<string, Humidifier.AccessAnalyzer.ArchiveRuleTypes.FilterItems>, IReadOnlyDictionary<string, Union<Humidifier.AccessAnalyzer.ArchiveRuleTypes.FilterItems, BaseFunction>>, BaseFunction>? Filter { get; set; }

        /// <summary>
        /// AnalyzerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-archiverule.html#cfn-accessanalyzer-archiverule-analyzername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AnalyzerName { get; set; }

        /// <summary>
        /// RuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-accessanalyzer-archiverule.html#cfn-accessanalyzer-archiverule-rulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleName { get; set; }
    }

    namespace ArchiveRuleTypes
    {
        public class FilterItems : Humidifier.Base.BaseSubResource, IHaveExists_Boolean, IHaveStringListOfContains, IHaveStringListOfNeq, IHaveStringListOfEq
        {
            /// <summary>
            /// Exists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-archiverule-filteritems.html#cfn-accessanalyzer-archiverule-filteritems-exists
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Exists { get; set; }
            /// <summary>
            /// Contains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-archiverule-filteritems.html#cfn-accessanalyzer-archiverule-filteritems-contains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Contains { get; set; }
            /// <summary>
            /// Neq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-archiverule-filteritems.html#cfn-accessanalyzer-archiverule-filteritems-neq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Neq { get; set; }
            /// <summary>
            /// Eq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-accessanalyzer-archiverule-filteritems.html#cfn-accessanalyzer-archiverule-filteritems-eq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Eq { get; set; }
        }
    }
}