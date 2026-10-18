namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using MailManagerRuleSetTypes;

    public class MailManagerRuleSet : Humidifier.Base.BaseResource, IHaveTags, IHaveRuleSetName, IHaveListOfSESMailManagerRuleSetTypesRuleRules
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
        public Union<string, BaseFunction>? RuleSetName { get; set; }

        /// <summary>
        /// Rules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerruleset.html#cfn-ses-mailmanagerruleset-rules
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Rule
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.SES.MailManagerRuleSetTypes.Rule>, IReadOnlyList<Union<Humidifier.SES.MailManagerRuleSetTypes.Rule, BaseFunction>>, BaseFunction>? Rules { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-mailmanagerruleset.html#cfn-ses-mailmanagerruleset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MailManagerRuleSetTypes
    {
        public class AddHeaderAction : Humidifier.Base.BaseSubResource, IHaveHeaderValue, IHaveHeaderName
        {
            /// <summary>
            /// HeaderValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-addheaderaction.html#cfn-ses-mailmanagerruleset-addheaderaction-headervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderValue { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-addheaderaction.html#cfn-ses-mailmanagerruleset-addheaderaction-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
        }

        public class Analysis : Humidifier.Base.BaseSubResource, IHaveAnalyzer, IHaveResultField
        {
            /// <summary>
            /// Analyzer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-analysis.html#cfn-ses-mailmanagerruleset-analysis-analyzer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Analyzer { get; set; }
            /// <summary>
            /// ResultField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-analysis.html#cfn-ses-mailmanagerruleset-analysis-resultfield
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResultField { get; set; }
        }

        public class ArchiveAction : Humidifier.Base.BaseSubResource, IHaveTargetArchive, IHaveActionFailurePolicy
        {
            /// <summary>
            /// TargetArchive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-archiveaction.html#cfn-ses-mailmanagerruleset-archiveaction-targetarchive
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetArchive { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-archiveaction.html#cfn-ses-mailmanagerruleset-archiveaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
        }

        public class BounceAction : Humidifier.Base.BaseSubResource, IHaveSender, IHaveSmtpReplyCode, IHaveDiagnosticMessage, IHaveMessage, IHaveActionFailurePolicy, IHaveStatusCode, IHaveRoleArn
        {
            /// <summary>
            /// Sender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-bounceaction.html#cfn-ses-mailmanagerruleset-bounceaction-sender
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Sender { get; set; }
            /// <summary>
            /// SmtpReplyCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-bounceaction.html#cfn-ses-mailmanagerruleset-bounceaction-smtpreplycode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SmtpReplyCode { get; set; }
            /// <summary>
            /// DiagnosticMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-bounceaction.html#cfn-ses-mailmanagerruleset-bounceaction-diagnosticmessage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiagnosticMessage { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-bounceaction.html#cfn-ses-mailmanagerruleset-bounceaction-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-bounceaction.html#cfn-ses-mailmanagerruleset-bounceaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-bounceaction.html#cfn-ses-mailmanagerruleset-bounceaction-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-bounceaction.html#cfn-ses-mailmanagerruleset-bounceaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class DeliverToMailboxAction : Humidifier.Base.BaseSubResource, IHaveMailboxArn, IHaveActionFailurePolicy, IHaveRoleArn
        {
            /// <summary>
            /// MailboxArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertomailboxaction.html#cfn-ses-mailmanagerruleset-delivertomailboxaction-mailboxarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailboxArn { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertomailboxaction.html#cfn-ses-mailmanagerruleset-delivertomailboxaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertomailboxaction.html#cfn-ses-mailmanagerruleset-delivertomailboxaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class DeliverToQBusinessAction : Humidifier.Base.BaseSubResource, IHaveIndexId, IHaveActionFailurePolicy, IHaveApplicationId, IHaveRoleArn
        {
            /// <summary>
            /// IndexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertoqbusinessaction.html#cfn-ses-mailmanagerruleset-delivertoqbusinessaction-indexid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexId { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertoqbusinessaction.html#cfn-ses-mailmanagerruleset-delivertoqbusinessaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
            /// <summary>
            /// ApplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertoqbusinessaction.html#cfn-ses-mailmanagerruleset-delivertoqbusinessaction-applicationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationId { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-delivertoqbusinessaction.html#cfn-ses-mailmanagerruleset-delivertoqbusinessaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class InvokeLambdaAction : Humidifier.Base.BaseSubResource, IHaveFunctionArn, IHaveRetryTimeMinutes_Integer, IHaveInvocationType, IHaveActionFailurePolicy, IHaveRoleArn
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-invokelambdaaction.html#cfn-ses-mailmanagerruleset-invokelambdaaction-functionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionArn { get; set; }
            /// <summary>
            /// RetryTimeMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-invokelambdaaction.html#cfn-ses-mailmanagerruleset-invokelambdaaction-retrytimeminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetryTimeMinutes { get; set; }
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-invokelambdaaction.html#cfn-ses-mailmanagerruleset-invokelambdaaction-invocationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationType { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-invokelambdaaction.html#cfn-ses-mailmanagerruleset-invokelambdaaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-invokelambdaaction.html#cfn-ses-mailmanagerruleset-invokelambdaaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class RelayAction : Humidifier.Base.BaseSubResource, IHaveRelay, IHaveMailFrom, IHaveActionFailurePolicy
        {
            /// <summary>
            /// Relay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-relayaction.html#cfn-ses-mailmanagerruleset-relayaction-relay
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Relay { get; set; }
            /// <summary>
            /// MailFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-relayaction.html#cfn-ses-mailmanagerruleset-relayaction-mailfrom
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MailFrom { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-relayaction.html#cfn-ses-mailmanagerruleset-relayaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
        }

        public class ReplaceRecipientAction : Humidifier.Base.BaseSubResource, IHaveStringListOfReplaceWith
        {
            /// <summary>
            /// ReplaceWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-replacerecipientaction.html#cfn-ses-mailmanagerruleset-replacerecipientaction-replacewith
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReplaceWith { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveListOfSESMailManagerRuleSetTypesRuleActionActions, IHaveListOfSESMailManagerRuleSetTypesRuleConditionConditions, IHaveListOfSESMailManagerRuleSetTypesRuleConditionUnless, IHaveName
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rule.html#cfn-ses-mailmanagerruleset-rule-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SES.MailManagerRuleSetTypes.RuleAction>, IReadOnlyList<Union<Humidifier.SES.MailManagerRuleSetTypes.RuleAction, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rule.html#cfn-ses-mailmanagerruleset-rule-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SES.MailManagerRuleSetTypes.RuleCondition>, IReadOnlyList<Union<Humidifier.SES.MailManagerRuleSetTypes.RuleCondition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
            /// <summary>
            /// Unless
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rule.html#cfn-ses-mailmanagerruleset-rule-unless
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RuleCondition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SES.MailManagerRuleSetTypes.RuleCondition>, IReadOnlyList<Union<Humidifier.SES.MailManagerRuleSetTypes.RuleCondition, BaseFunction>>, BaseFunction>? Unless { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rule.html#cfn-ses-mailmanagerruleset-rule-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RuleAction : Humidifier.Base.BaseSubResource, IHaveSESMailManagerRuleSetTypesAddHeaderActionAddHeader, IHaveSESMailManagerRuleSetTypesRelayActionRelay, IHaveSESMailManagerRuleSetTypesDeliverToMailboxActionDeliverToMailbox, IHaveSESMailManagerRuleSetTypesArchiveActionArchive, IHaveSESMailManagerRuleSetTypesReplaceRecipientActionReplaceRecipient, IHaveSESMailManagerRuleSetTypesS3ActionWriteToS3, IHaveSESMailManagerRuleSetTypesSnsActionPublishToSns, IHaveSESMailManagerRuleSetTypesBounceActionBounce, IHaveSESMailManagerRuleSetTypesDeliverToQBusinessActionDeliverToQBusiness, IHaveDrop_Json, IHaveSESMailManagerRuleSetTypesSendActionSend, IHaveSESMailManagerRuleSetTypesInvokeLambdaActionInvokeLambda
        {
            /// <summary>
            /// AddHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-addheader
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AddHeaderAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.AddHeaderAction, BaseFunction>? AddHeader { get; set; }
            /// <summary>
            /// Relay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-relay
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RelayAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RelayAction, BaseFunction>? Relay { get; set; }
            /// <summary>
            /// DeliverToMailbox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-delivertomailbox
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeliverToMailboxAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.DeliverToMailboxAction, BaseFunction>? DeliverToMailbox { get; set; }
            /// <summary>
            /// Archive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-archive
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ArchiveAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.ArchiveAction, BaseFunction>? Archive { get; set; }
            /// <summary>
            /// ReplaceRecipient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-replacerecipient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ReplaceRecipientAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.ReplaceRecipientAction, BaseFunction>? ReplaceRecipient { get; set; }
            /// <summary>
            /// WriteToS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-writetos3
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Action
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.S3Action, BaseFunction>? WriteToS3 { get; set; }
            /// <summary>
            /// PublishToSns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-publishtosns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnsAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.SnsAction, BaseFunction>? PublishToSns { get; set; }
            /// <summary>
            /// Bounce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-bounce
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BounceAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.BounceAction, BaseFunction>? Bounce { get; set; }
            /// <summary>
            /// DeliverToQBusiness
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-delivertoqbusiness
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeliverToQBusinessAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.DeliverToQBusinessAction, BaseFunction>? DeliverToQBusiness { get; set; }
            /// <summary>
            /// Drop
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-drop
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Drop { get; set; }
            /// <summary>
            /// Send
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-send
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SendAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.SendAction, BaseFunction>? Send { get; set; }
            /// <summary>
            /// InvokeLambda
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleaction.html#cfn-ses-mailmanagerruleset-ruleaction-invokelambda
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InvokeLambdaAction
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.InvokeLambdaAction, BaseFunction>? InvokeLambda { get; set; }
        }

        public class RuleBooleanExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerRuleSetTypesRuleBooleanToEvaluateEvaluate
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulebooleanexpression.html#cfn-ses-mailmanagerruleset-rulebooleanexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulebooleanexpression.html#cfn-ses-mailmanagerruleset-rulebooleanexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleBooleanToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleBooleanToEvaluate, BaseFunction>? Evaluate { get; set; }
        }

        public class RuleBooleanToEvaluate : Humidifier.Base.BaseSubResource, IHaveSESMailManagerRuleSetTypesRuleIsInAddressListIsInAddressList, IHaveAttribute, IHaveSESMailManagerRuleSetTypesAnalysisAnalysis
        {
            /// <summary>
            /// IsInAddressList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulebooleantoevaluate.html#cfn-ses-mailmanagerruleset-rulebooleantoevaluate-isinaddresslist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleIsInAddressList
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleIsInAddressList, BaseFunction>? IsInAddressList { get; set; }
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulebooleantoevaluate.html#cfn-ses-mailmanagerruleset-rulebooleantoevaluate-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulebooleantoevaluate.html#cfn-ses-mailmanagerruleset-rulebooleantoevaluate-analysis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Analysis
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.Analysis, BaseFunction>? Analysis { get; set; }
        }

        public class RuleCondition : Humidifier.Base.BaseSubResource, IHaveSESMailManagerRuleSetTypesRuleBooleanExpressionBooleanExpression, IHaveSESMailManagerRuleSetTypesRuleNumberExpressionNumberExpression, IHaveSESMailManagerRuleSetTypesRuleIpExpressionIpExpression, IHaveSESMailManagerRuleSetTypesRuleVerdictExpressionVerdictExpression, IHaveSESMailManagerRuleSetTypesRuleStringExpressionStringExpression, IHaveSESMailManagerRuleSetTypesRuleDmarcExpressionDmarcExpression
        {
            /// <summary>
            /// BooleanExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-booleanexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleBooleanExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleBooleanExpression, BaseFunction>? BooleanExpression { get; set; }
            /// <summary>
            /// NumberExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-numberexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleNumberExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleNumberExpression, BaseFunction>? NumberExpression { get; set; }
            /// <summary>
            /// IpExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-ipexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleIpExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleIpExpression, BaseFunction>? IpExpression { get; set; }
            /// <summary>
            /// VerdictExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-verdictexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleVerdictExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleVerdictExpression, BaseFunction>? VerdictExpression { get; set; }
            /// <summary>
            /// StringExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-stringexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleStringExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleStringExpression, BaseFunction>? StringExpression { get; set; }
            /// <summary>
            /// DmarcExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulecondition.html#cfn-ses-mailmanagerruleset-rulecondition-dmarcexpression
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RuleDmarcExpression
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleDmarcExpression, BaseFunction>? DmarcExpression { get; set; }
        }

        public class RuleDmarcExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveStringListOfValues
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruledmarcexpression.html#cfn-ses-mailmanagerruleset-ruledmarcexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruledmarcexpression.html#cfn-ses-mailmanagerruleset-ruledmarcexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class RuleIpExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerRuleSetTypesRuleIpToEvaluateEvaluate, IHaveStringListOfValues
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleipexpression.html#cfn-ses-mailmanagerruleset-ruleipexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleipexpression.html#cfn-ses-mailmanagerruleset-ruleipexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleIpToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleIpToEvaluate, BaseFunction>? Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleipexpression.html#cfn-ses-mailmanagerruleset-ruleipexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
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
            public Union<string, BaseFunction>? Attribute { get; set; }
        }

        public class RuleIsInAddressList : Humidifier.Base.BaseSubResource, IHaveAttribute, IHaveStringListOfAddressLists
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleisinaddresslist.html#cfn-ses-mailmanagerruleset-ruleisinaddresslist-attribute
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
            /// <summary>
            /// AddressLists
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleisinaddresslist.html#cfn-ses-mailmanagerruleset-ruleisinaddresslist-addresslists
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AddressLists { get; set; }
        }

        public class RuleNumberExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerRuleSetTypesRuleNumberToEvaluateEvaluate, IHaveValue_Double
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulenumberexpression.html#cfn-ses-mailmanagerruleset-rulenumberexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulenumberexpression.html#cfn-ses-mailmanagerruleset-rulenumberexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleNumberToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleNumberToEvaluate, BaseFunction>? Evaluate { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulenumberexpression.html#cfn-ses-mailmanagerruleset-rulenumberexpression-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Value { get; set; }
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
            public Union<string, BaseFunction>? Attribute { get; set; }
        }

        public class RuleStringExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerRuleSetTypesRuleStringToEvaluateEvaluate, IHaveStringListOfValues
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringexpression.html#cfn-ses-mailmanagerruleset-rulestringexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringexpression.html#cfn-ses-mailmanagerruleset-rulestringexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleStringToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleStringToEvaluate, BaseFunction>? Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringexpression.html#cfn-ses-mailmanagerruleset-rulestringexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class RuleStringToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute, IHaveMimeHeaderAttribute, IHaveSESMailManagerRuleSetTypesAnalysisAnalysis, IHaveClientCertificateAttribute
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringtoevaluate.html#cfn-ses-mailmanagerruleset-rulestringtoevaluate-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
            /// <summary>
            /// MimeHeaderAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringtoevaluate.html#cfn-ses-mailmanagerruleset-rulestringtoevaluate-mimeheaderattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MimeHeaderAttribute { get; set; }
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringtoevaluate.html#cfn-ses-mailmanagerruleset-rulestringtoevaluate-analysis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Analysis
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.Analysis, BaseFunction>? Analysis { get; set; }
            /// <summary>
            /// ClientCertificateAttribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-rulestringtoevaluate.html#cfn-ses-mailmanagerruleset-rulestringtoevaluate-clientcertificateattribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCertificateAttribute { get; set; }
        }

        public class RuleVerdictExpression : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveSESMailManagerRuleSetTypesRuleVerdictToEvaluateEvaluate, IHaveStringListOfValues
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdictexpression.html#cfn-ses-mailmanagerruleset-ruleverdictexpression-operator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// Evaluate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdictexpression.html#cfn-ses-mailmanagerruleset-ruleverdictexpression-evaluate
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RuleVerdictToEvaluate
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.RuleVerdictToEvaluate, BaseFunction>? Evaluate { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdictexpression.html#cfn-ses-mailmanagerruleset-ruleverdictexpression-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class RuleVerdictToEvaluate : Humidifier.Base.BaseSubResource, IHaveAttribute, IHaveSESMailManagerRuleSetTypesAnalysisAnalysis
        {
            /// <summary>
            /// Attribute
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdicttoevaluate.html#cfn-ses-mailmanagerruleset-ruleverdicttoevaluate-attribute
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Attribute { get; set; }
            /// <summary>
            /// Analysis
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-ruleverdicttoevaluate.html#cfn-ses-mailmanagerruleset-ruleverdicttoevaluate-analysis
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Analysis
            /// </summary>
            public Union<Humidifier.SES.MailManagerRuleSetTypes.Analysis, BaseFunction>? Analysis { get; set; }
        }

        public class S3Action : Humidifier.Base.BaseSubResource, IHaveS3SseKmsKeyId, IHaveS3Bucket, IHaveS3Prefix, IHaveActionFailurePolicy, IHaveRoleArn
        {
            /// <summary>
            /// S3SseKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-s3ssekmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3SseKmsKeyId { get; set; }
            /// <summary>
            /// S3Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-s3bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Bucket { get; set; }
            /// <summary>
            /// S3Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-s3prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Prefix { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-s3action.html#cfn-ses-mailmanagerruleset-s3action-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SendAction : Humidifier.Base.BaseSubResource, IHaveActionFailurePolicy, IHaveRoleArn
        {
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-sendaction.html#cfn-ses-mailmanagerruleset-sendaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-sendaction.html#cfn-ses-mailmanagerruleset-sendaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SnsAction : Humidifier.Base.BaseSubResource, IHaveTopicArn, IHaveEncoding, IHaveActionFailurePolicy, IHaveRoleArn, IHavePayloadType
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-snsaction.html#cfn-ses-mailmanagerruleset-snsaction-topicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
            /// <summary>
            /// Encoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-snsaction.html#cfn-ses-mailmanagerruleset-snsaction-encoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Encoding { get; set; }
            /// <summary>
            /// ActionFailurePolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-snsaction.html#cfn-ses-mailmanagerruleset-snsaction-actionfailurepolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActionFailurePolicy { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-snsaction.html#cfn-ses-mailmanagerruleset-snsaction-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// PayloadType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-mailmanagerruleset-snsaction.html#cfn-ses-mailmanagerruleset-snsaction-payloadtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PayloadType { get; set; }
        }
    }
}