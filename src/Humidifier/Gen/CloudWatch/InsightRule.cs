namespace Humidifier.CloudWatch
{
    using System.Collections.Generic;
    using InsightRuleTypes;

    public class InsightRule : Humidifier.Base.BaseResource, IHaveRuleName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string RuleName =  "RuleName" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.InsightRule; }

        /// <summary>
        /// RuleState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-insightrule.html#cfn-cloudwatch-insightrule-rulestate
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuleState { get; set; }

        /// <summary>
        /// RuleBody
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-insightrule.html#cfn-cloudwatch-insightrule-rulebody
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuleBody { get; set; }

        /// <summary>
        /// RuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-insightrule.html#cfn-cloudwatch-insightrule-rulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuleName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-insightrule.html#cfn-cloudwatch-insightrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Tags
        /// </summary>
        public Humidifier.CloudWatch.InsightRuleTypes.Tags Tags { get; set; }
    }

    namespace InsightRuleTypes
    {
        public class Tags : Humidifier.Base.BaseSubResource
        {
        }
    }
}