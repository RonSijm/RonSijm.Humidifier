namespace Humidifier.SES
{
    using System.Collections.Generic;
    using MailManagerRuleSetTypes;

    public class MailManagerRuleSet : Humidifier.Base.BaseResource, IHaveTags, IHaveRuleSetName
    {
        public class Attributes
        {
            public static string RuleSetId =  "RuleSetId" ;
            public static string RuleSetArn =  "RuleSetArn" ;
        }

        public override string AWSTypeName { get => AWS.SES.MailManagerRuleSet; }
        /// <summary>
        /// RuleSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerruleset.html#cfn-ses-mailmanagerruleset-rulesetname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RuleSetName { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerruleset.html#cfn-ses-mailmanagerruleset-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        [Required]
        public List<Humidifier.SES.MailManagerRuleSetTypes.Rule> Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerruleset.html#cfn-ses-mailmanagerruleset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace MailManagerRuleSetTypes
    {
        public class AddHeaderAction : Humidifier.Base.BaseSubResource, IHaveHeaderName, IHaveHeaderValue
        {
            /// <summary>
            /// HeaderValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-addheaderaction.html#cfn-ses-mailmanagerruleset-addheaderaction-headervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderValue { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-addheaderaction.html#cfn-ses-mailmanagerruleset-addheaderaction-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderName { get; set; }
        }

        public class Analysis : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Analyzer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-analysis.html#cfn-ses-mailmanagerruleset-analysis-analyzer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Analyzer { get; set; }
            /// <summary>
            /// ResultField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-analysis.html#cfn-ses-mailmanagerruleset-analysis-resultfield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResultField { get; set; }
        }

        public class ArchiveAction : Humidifier.Base.BaseSubResource, IHaveActionFailurePolicy
        {
            /// <summary>
            /// TargetArchive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-archiveaction.html#cfn-ses-mailmanagerruleset-archiveaction-targetarchive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetArchive { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-archiveaction.html#cfn-ses-mailmanagerruleset-archiveaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionFailurePolicy { get; set; }
        }

        public class DeliverToMailboxAction : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveActionFailurePolicy
        {
            /// <summary>
            /// MailboxArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertomailboxaction.html#cfn-ses-mailmanagerruleset-delivertomailboxaction-mailboxarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailboxArn { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertomailboxaction.html#cfn-ses-mailmanagerruleset-delivertomailboxaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionFailurePolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertomailboxaction.html#cfn-ses-mailmanagerruleset-delivertomailboxaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class DeliverToQBusinessAction : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveApplicationId, IHaveIndexId, IHaveActionFailurePolicy
        {
            /// <summary>
            /// IndexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertoqbusinessaction.html#cfn-ses-mailmanagerruleset-delivertoqbusinessaction-indexid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexId { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertoqbusinessaction.html#cfn-ses-mailmanagerruleset-delivertoqbusinessaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionFailurePolicy { get; set; }
            /// <summary>
            /// ApplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertoqbusinessaction.html#cfn-ses-mailmanagerruleset-delivertoqbusinessaction-applicationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationId { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertoqbusinessaction.html#cfn-ses-mailmanagerruleset-delivertoqbusinessaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class RelayAction : Humidifier.Base.BaseSubResource, IHaveActionFailurePolicy
        {
            /// <summary>
            /// Relay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-relayaction.html#cfn-ses-mailmanagerruleset-relayaction-relay
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Relay { get; set; }
            /// <summary>
            /// MailFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-relayaction.html#cfn-ses-mailmanagerruleset-relayaction-mailfrom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailFrom { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-relayaction.html#cfn-ses-mailmanagerruleset-relayaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionFailurePolicy { get; set; }
        }

        public class ReplaceRecipientAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReplaceWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-replacerecipientaction.html#cfn-ses-mailmanagerruleset-replacerecipientaction-replacewith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ReplaceWith { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rule.html#cfn-ses-mailmanagerruleset-rule-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleAction
            /// </summary>
            public List<Humidifier.SES.MailManagerRuleSetTypes.RuleAction> Actions { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rule.html#cfn-ses-mailmanagerruleset-rule-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleCondition
            /// </summary>
            public List<Humidifier.SES.MailManagerRuleSetTypes.RuleCondition> Conditions { get; set; }
            /// <summary>
            /// Unless
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rule.html#cfn-ses-mailmanagerruleset-rule-unless
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleCondition
            /// </summary>
            public List<Humidifier.SES.MailManagerRuleSetTypes.RuleCondition> Unless { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rule.html#cfn-ses-mailmanagerruleset-rule-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RuleAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AddHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-addheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AddHeaderAction
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.AddHeaderAction AddHeader { get; set; }
            /// <summary>
            /// Relay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-relay
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelayAction
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RelayAction Relay { get; set; }
            /// <summary>
            /// DeliverToMailbox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-delivertomailbox
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeliverToMailboxAction
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.DeliverToMailboxAction DeliverToMailbox { get; set; }
            /// <summary>
            /// Archive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-archive
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveAction
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.ArchiveAction Archive { get; set; }
            /// <summary>
            /// ReplaceRecipient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-replacerecipient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplaceRecipientAction
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.ReplaceRecipientAction ReplaceRecipient { get; set; }
            /// <summary>
            /// WriteToS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-writetos3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Action
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.S3Action WriteToS3 { get; set; }
            /// <summary>
            /// DeliverToQBusiness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-delivertoqbusiness
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeliverToQBusinessAction
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.DeliverToQBusinessAction DeliverToQBusiness { get; set; }
            /// <summary>
            /// Drop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-drop
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Drop { get; set; }
            /// <summary>
            /// Send
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-send
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SendAction
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.SendAction Send { get; set; }
        }

        public class RuleBooleanExpression : Humidifier.Base.BaseSubResource, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulebooleanexpression.html#cfn-ses-mailmanagerruleset-rulebooleanexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulebooleanexpression.html#cfn-ses-mailmanagerruleset-rulebooleanexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleBooleanToEvaluate
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleBooleanToEvaluate Evaluate { get; set; }
        }

        public class RuleBooleanToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulebooleantoevaluate.html#cfn-ses-mailmanagerruleset-rulebooleantoevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
        }

        public class RuleCondition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BooleanExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-booleanexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleBooleanExpression
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleBooleanExpression BooleanExpression { get; set; }
            /// <summary>
            /// VerdictExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-verdictexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleVerdictExpression
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleVerdictExpression VerdictExpression { get; set; }
            /// <summary>
            /// StringExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-stringexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleStringExpression
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleStringExpression StringExpression { get; set; }
            /// <summary>
            /// DmarcExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-dmarcexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleDmarcExpression
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleDmarcExpression DmarcExpression { get; set; }
            /// <summary>
            /// NumberExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-numberexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleNumberExpression
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleNumberExpression NumberExpression { get; set; }
            /// <summary>
            /// IpExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-ipexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleIpExpression
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleIpExpression IpExpression { get; set; }
        }

        public class RuleDmarcExpression : Humidifier.Base.BaseSubResource, IHaveValues, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruledmarcexpression.html#cfn-ses-mailmanagerruleset-ruledmarcexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruledmarcexpression.html#cfn-ses-mailmanagerruleset-ruledmarcexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class RuleIpExpression : Humidifier.Base.BaseSubResource, IHaveValues, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleipexpression.html#cfn-ses-mailmanagerruleset-ruleipexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleipexpression.html#cfn-ses-mailmanagerruleset-ruleipexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleIpToEvaluate
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleIpToEvaluate Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleipexpression.html#cfn-ses-mailmanagerruleset-ruleipexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class RuleIpToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleiptoevaluate.html#cfn-ses-mailmanagerruleset-ruleiptoevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
        }

        public class RuleNumberExpression : Humidifier.Base.BaseSubResource, IHaveValue, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulenumberexpression.html#cfn-ses-mailmanagerruleset-rulenumberexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulenumberexpression.html#cfn-ses-mailmanagerruleset-rulenumberexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleNumberToEvaluate
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleNumberToEvaluate Evaluate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulenumberexpression.html#cfn-ses-mailmanagerruleset-rulenumberexpression-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class RuleNumberToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulenumbertoevaluate.html#cfn-ses-mailmanagerruleset-rulenumbertoevaluate-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
        }

        public class RuleStringExpression : Humidifier.Base.BaseSubResource, IHaveValues, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringexpression.html#cfn-ses-mailmanagerruleset-rulestringexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringexpression.html#cfn-ses-mailmanagerruleset-rulestringexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleStringToEvaluate
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleStringToEvaluate Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringexpression.html#cfn-ses-mailmanagerruleset-rulestringexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class RuleStringToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringtoevaluate.html#cfn-ses-mailmanagerruleset-rulestringtoevaluate-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
            /// <summary>
            /// MimeHeaderAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringtoevaluate.html#cfn-ses-mailmanagerruleset-rulestringtoevaluate-mimeheaderattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MimeHeaderAttribute { get; set; }
        }

        public class RuleVerdictExpression : Humidifier.Base.BaseSubResource, IHaveValues, IHaveOperator
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdictexpression.html#cfn-ses-mailmanagerruleset-ruleverdictexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdictexpression.html#cfn-ses-mailmanagerruleset-ruleverdictexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleVerdictToEvaluate
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.RuleVerdictToEvaluate Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdictexpression.html#cfn-ses-mailmanagerruleset-ruleverdictexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class RuleVerdictToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdicttoevaluate.html#cfn-ses-mailmanagerruleset-ruleverdicttoevaluate-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Attribute { get; set; }
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdicttoevaluate.html#cfn-ses-mailmanagerruleset-ruleverdicttoevaluate-analysis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Analysis
            /// </summary>
            public Humidifier.SES.MailManagerRuleSetTypes.Analysis Analysis { get; set; }
        }

        public class S3Action : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveS3Bucket, IHaveS3Prefix, IHaveActionFailurePolicy
        {
            /// <summary>
            /// S3SseKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-s3ssekmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3SseKmsKeyId { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Bucket { get; set; }
            /// <summary>
            /// S3Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-s3prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3Prefix { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionFailurePolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class SendAction : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveActionFailurePolicy
        {
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-sendaction.html#cfn-ses-mailmanagerruleset-sendaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActionFailurePolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-sendaction.html#cfn-ses-mailmanagerruleset-sendaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }
    }
}