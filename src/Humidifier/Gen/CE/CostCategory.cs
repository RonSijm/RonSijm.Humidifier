namespace Humidifier.CE
{
    using System.Collections.Generic;

    public class CostCategory : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDefaultValue
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
        public dynamic DefaultValue { get; set; }
        /// <summary>
        /// SplitChargeRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html#cfn-ce-costcategory-splitchargerules
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SplitChargeRules { get; set; }

        /// <summary>
        /// RuleVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html#cfn-ce-costcategory-ruleversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuleVersion { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ce-costcategory.html#cfn-ce-costcategory-rules
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Rules { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}