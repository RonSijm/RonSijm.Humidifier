namespace Humidifier.CE
{
    using global::System.Collections.Generic;
    using CostCategoryTypes;

    public class CostCategory : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDefaultValue, IHaveSplitChargeRules, IHaveRuleVersion, IHaveRules, IHaveListOfCECostCategoryTypesResourceTagTags, IHaveName
    {
        public class Attributes
        {
            public static string EffectiveStart =  "EffectiveStart" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CE.CostCategory; }
        /// <summary>
        /// DefaultValue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html#cfn-ce-costcategory-defaultvalue
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultValue { get; set; }
        /// <summary>
        /// SplitChargeRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html#cfn-ce-costcategory-splitchargerules
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SplitChargeRules { get; set; }

        /// <summary>
        /// RuleVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html#cfn-ce-costcategory-ruleversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleVersion { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html#cfn-ce-costcategory-rules
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html#cfn-ce-costcategory-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourceTag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CE.CostCategoryTypes.ResourceTag>, IReadOnlyList<Union<Humidifier.CE.CostCategoryTypes.ResourceTag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace CostCategoryTypes
    {
        public class ResourceTag : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-costcategory-resourcetag.html#cfn-ce-costcategory-resourcetag-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ce-costcategory-resourcetag.html#cfn-ce-costcategory-resourcetag-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}