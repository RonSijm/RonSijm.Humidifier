namespace Humidifier.SES
{
    using System.Collections.Generic;

    public class ReceiptRuleSet : Humidifier.Base.BaseResource, IHaveRuleSetName
    {
        public override string AWSTypeName { get => AWS.SES.ReceiptRuleSet; }
        /// <summary>
        /// RuleSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptruleset.html#cfn-ses-receiptruleset-rulesetname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RuleSetName { get; set; }
    }
}