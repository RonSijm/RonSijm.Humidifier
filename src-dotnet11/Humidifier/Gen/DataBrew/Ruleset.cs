namespace Humidifier.DataBrew
{
    using global::System.Collections.Generic;
    using RulesetTypes;

    public class Ruleset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveTargetArn, IHaveListOfDataBrewRulesetTypesRuleRules, IHaveName
    {
        public override string AWSTypeName { get => AWS.DataBrew.Ruleset; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-ruleset.html#cfn-databrew-ruleset-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// TargetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-ruleset.html#cfn-databrew-ruleset-targetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TargetArn { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-ruleset.html#cfn-databrew-ruleset-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.DataBrew.RulesetTypes.Rule>, IReadOnlyList<Union<Humidifier.DataBrew.RulesetTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-ruleset.html#cfn-databrew-ruleset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace RulesetTypes
    {
        public class ColumnSelector : Humidifier.Base.BaseSubResource, IHaveRegex, IHaveName
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-columnselector.html#cfn-databrew-ruleset-columnselector-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-columnselector.html#cfn-databrew-ruleset-columnselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveListOfDataBrewRulesetTypesColumnSelectorColumnSelectors, IHaveDisabled_Boolean, IHaveListOfDataBrewRulesetTypesSubstitutionValueSubstitutionMap, IHaveName, IHaveCheckExpression, IHaveDataBrewRulesetTypesThresholdThreshold
        {
            /// <summary>
            /// ColumnSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-rule.html#cfn-databrew-ruleset-rule-columnselectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.RulesetTypes.ColumnSelector>, IReadOnlyList<Union<Humidifier.DataBrew.RulesetTypes.ColumnSelector, BaseFunction>>, BaseFunction>? ColumnSelectors { get; set; }
            /// <summary>
            /// Disabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-rule.html#cfn-databrew-ruleset-rule-disabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Disabled { get; set; }
            /// <summary>
            /// SubstitutionMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-rule.html#cfn-databrew-ruleset-rule-substitutionmap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SubstitutionValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.RulesetTypes.SubstitutionValue>, IReadOnlyList<Union<Humidifier.DataBrew.RulesetTypes.SubstitutionValue, BaseFunction>>, BaseFunction>? SubstitutionMap { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-rule.html#cfn-databrew-ruleset-rule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// CheckExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-rule.html#cfn-databrew-ruleset-rule-checkexpression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CheckExpression { get; set; }
            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-rule.html#cfn-databrew-ruleset-rule-threshold
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Threshold
            /// </summary>
            public Union<Humidifier.DataBrew.RulesetTypes.Threshold, BaseFunction>? Threshold { get; set; }
        }

        public class SubstitutionValue : Humidifier.Base.BaseSubResource, IHaveValue, IHaveValueReference
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-substitutionvalue.html#cfn-databrew-ruleset-substitutionvalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// ValueReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-substitutionvalue.html#cfn-databrew-ruleset-substitutionvalue-valuereference
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueReference { get; set; }
        }

        public class Threshold : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue_Double, IHaveUnit
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-threshold.html#cfn-databrew-ruleset-threshold-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-threshold.html#cfn-databrew-ruleset-threshold-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-ruleset-threshold.html#cfn-databrew-ruleset-threshold-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
        }
    }
}