namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using ReceiptRuleTypes;

    public class ReceiptRule : Humidifier.Base.BaseResource, IHaveAfter, IHaveSESReceiptRuleTypesRuleRule, IHaveRuleSetName
    {
        public class Attributes
        {
            public static string RuleName =  "RuleName" ;
        }

        public override string AWSTypeName { get => AWS.SES.ReceiptRule; }
        /// <summary>
        /// After
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-after
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? After { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Union<Humidifier.SES.ReceiptRuleTypes.Rule, BaseFunction>? Rule { get; set; }

        /// <summary>
        /// RuleSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-rulesetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleSetName { get; set; }
    }

    namespace ReceiptRuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveSESReceiptRuleTypesConnectActionConnectAction, IHaveSESReceiptRuleTypesBounceActionBounceAction, IHaveSESReceiptRuleTypesS3ActionS3Action, IHaveSESReceiptRuleTypesStopActionStopAction, IHaveSESReceiptRuleTypesSNSActionSNSAction, IHaveSESReceiptRuleTypesWorkmailActionWorkmailAction, IHaveSESReceiptRuleTypesAddHeaderActionAddHeaderAction, IHaveSESReceiptRuleTypesLambdaActionLambdaAction
        {
            /// <summary>
            /// ConnectAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-connectaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectAction
            /// </summary>
            public Union<Humidifier.SES.ReceiptRuleTypes.ConnectAction, BaseFunction>? ConnectAction { get; set; }
            /// <summary>
            /// BounceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-bounceaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BounceAction
            /// </summary>
            public Union<Humidifier.SES.ReceiptRuleTypes.BounceAction, BaseFunction>? BounceAction { get; set; }
            /// <summary>
            /// S3Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-s3action
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Action
            /// </summary>
            public Union<Humidifier.SES.ReceiptRuleTypes.S3Action, BaseFunction>? S3Action { get; set; }
            /// <summary>
            /// StopAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-stopaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StopAction
            /// </summary>
            public Union<Humidifier.SES.ReceiptRuleTypes.StopAction, BaseFunction>? StopAction { get; set; }
            /// <summary>
            /// SNSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-snsaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SNSAction
            /// </summary>
            public Union<Humidifier.SES.ReceiptRuleTypes.SNSAction, BaseFunction>? SNSAction { get; set; }
            /// <summary>
            /// WorkmailAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-workmailaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkmailAction
            /// </summary>
            public Union<Humidifier.SES.ReceiptRuleTypes.WorkmailAction, BaseFunction>? WorkmailAction { get; set; }
            /// <summary>
            /// AddHeaderAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-addheaderaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AddHeaderAction
            /// </summary>
            public Union<Humidifier.SES.ReceiptRuleTypes.AddHeaderAction, BaseFunction>? AddHeaderAction { get; set; }
            /// <summary>
            /// LambdaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-lambdaaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaAction
            /// </summary>
            public Union<Humidifier.SES.ReceiptRuleTypes.LambdaAction, BaseFunction>? LambdaAction { get; set; }
        }

        public class AddHeaderAction : Humidifier.Base.BaseSubResource, IHaveHeaderValue, IHaveHeaderName
        {
            /// <summary>
            /// HeaderValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-addheaderaction.html#cfn-ses-receiptrule-addheaderaction-headervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderValue { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-addheaderaction.html#cfn-ses-receiptrule-addheaderaction-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderName { get; set; }
        }

        public class BounceAction : Humidifier.Base.BaseSubResource, IHaveSender, IHaveSmtpReplyCode, IHaveMessage, IHaveTopicArn, IHaveStatusCode
        {
            /// <summary>
            /// Sender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-sender
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Sender { get; set; }
            /// <summary>
            /// SmtpReplyCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-smtpreplycode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SmtpReplyCode { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-statuscode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
        }

        public class ConnectAction : Humidifier.Base.BaseSubResource, IHaveInstanceARN, IHaveIAMRoleARN
        {
            /// <summary>
            /// InstanceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-connectaction.html#cfn-ses-receiptrule-connectaction-instancearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceARN { get; set; }
            /// <summary>
            /// IAMRoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-connectaction.html#cfn-ses-receiptrule-connectaction-iamrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IAMRoleARN { get; set; }
        }

        public class LambdaAction : Humidifier.Base.BaseSubResource, IHaveFunctionArn, IHaveTopicArn, IHaveInvocationType
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-lambdaaction.html#cfn-ses-receiptrule-lambdaaction-functionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FunctionArn { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-lambdaaction.html#cfn-ses-receiptrule-lambdaaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-lambdaaction.html#cfn-ses-receiptrule-lambdaaction-invocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InvocationType { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveScanEnabled_Boolean, IHaveStringListOfRecipients, IHaveListOfSESReceiptRuleTypesActionActions, IHaveEnabled_Boolean, IHaveName, IHaveTlsPolicy
        {
            /// <summary>
            /// ScanEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-scanenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ScanEnabled { get; set; }
            /// <summary>
            /// Recipients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-recipients
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Recipients { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Action
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SES.ReceiptRuleTypes.Action>, IReadOnlyList<Union<Humidifier.SES.ReceiptRuleTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// TlsPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-tlspolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TlsPolicy { get; set; }
        }

        public class S3Action : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveKmsKeyArn, IHaveTopicArn, IHaveObjectKeyPrefix, IHaveIamRoleArn
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
            /// <summary>
            /// ObjectKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-objectkeyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectKeyPrefix { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-iamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamRoleArn { get; set; }
        }

        public class SNSAction : Humidifier.Base.BaseSubResource, IHaveTopicArn, IHaveEncoding
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-snsaction.html#cfn-ses-receiptrule-snsaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
            /// <summary>
            /// Encoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-snsaction.html#cfn-ses-receiptrule-snsaction-encoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Encoding { get; set; }
        }

        public class StopAction : Humidifier.Base.BaseSubResource, IHaveScope, IHaveTopicArn
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-stopaction.html#cfn-ses-receiptrule-stopaction-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-stopaction.html#cfn-ses-receiptrule-stopaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
        }

        public class WorkmailAction : Humidifier.Base.BaseSubResource, IHaveTopicArn, IHaveOrganizationArn
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-workmailaction.html#cfn-ses-receiptrule-workmailaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
            /// <summary>
            /// OrganizationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-workmailaction.html#cfn-ses-receiptrule-workmailaction-organizationarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationArn { get; set; }
        }
    }
}