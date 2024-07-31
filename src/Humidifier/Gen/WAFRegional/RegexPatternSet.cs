namespace Humidifier.WAFRegional
{
    using System.Collections.Generic;

    public class RegexPatternSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::WAFRegional::RegexPatternSet";
            }
        }

        /// <summary>
        /// RegexPatternStrings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-regexpatternset.html#cfn-wafregional-regexpatternset-regexpatternstrings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic RegexPatternStrings { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}