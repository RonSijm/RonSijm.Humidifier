namespace Humidifier.WAFRegional
{
    using global::System.Collections.Generic;

    public class RegexPatternSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveStringListOfRegexPatternStrings, IHaveName
    {
        public override string AWSTypeName { get => AWS.WAFRegional.RegexPatternSet; }

        /// <summary>
        /// RegexPatternStrings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-regexpatternset.html#cfn-wafregional-regexpatternset-regexpatternstrings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? RegexPatternStrings { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}