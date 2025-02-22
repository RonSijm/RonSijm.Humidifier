namespace Humidifier.SES
{
    using System.Collections.Generic;
    using ReceiptRuleTypes;

    public class ReceiptRule : Humidifier.Base.BaseResource, IHaveRuleSetName
    {
        public override string AWSTypeName { get => AWS.SES.ReceiptRule; }
        /// <summary>
        /// After
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-after
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic After { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Humidifier.SES.ReceiptRuleTypes.Rule Rule { get; set; }

        /// <summary>
        /// RuleSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptrule.html#cfn-ses-receiptrule-rulesetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RuleSetName { get; set; }
    }

    namespace ReceiptRuleTypes
    {
        public class Action : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConnectAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-connectaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectAction
            /// </summary>
            public Humidifier.SES.ReceiptRuleTypes.ConnectAction ConnectAction { get; set; }
            /// <summary>
            /// BounceAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-bounceaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BounceAction
            /// </summary>
            public Humidifier.SES.ReceiptRuleTypes.BounceAction BounceAction { get; set; }
            /// <summary>
            /// S3Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-s3action
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Action
            /// </summary>
            public Humidifier.SES.ReceiptRuleTypes.S3Action S3Action { get; set; }
            /// <summary>
            /// StopAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-stopaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StopAction
            /// </summary>
            public Humidifier.SES.ReceiptRuleTypes.StopAction StopAction { get; set; }
            /// <summary>
            /// SNSAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-snsaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SNSAction
            /// </summary>
            public Humidifier.SES.ReceiptRuleTypes.SNSAction SNSAction { get; set; }
            /// <summary>
            /// WorkmailAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-workmailaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkmailAction
            /// </summary>
            public Humidifier.SES.ReceiptRuleTypes.WorkmailAction WorkmailAction { get; set; }
            /// <summary>
            /// AddHeaderAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-addheaderaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AddHeaderAction
            /// </summary>
            public Humidifier.SES.ReceiptRuleTypes.AddHeaderAction AddHeaderAction { get; set; }
            /// <summary>
            /// LambdaAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-action.html#cfn-ses-receiptrule-action-lambdaaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaAction
            /// </summary>
            public Humidifier.SES.ReceiptRuleTypes.LambdaAction LambdaAction { get; set; }
        }

        public class AddHeaderAction : Humidifier.Base.BaseSubResource, IHaveHeaderName, IHaveHeaderValue
        {
            /// <summary>
            /// HeaderValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-addheaderaction.html#cfn-ses-receiptrule-addheaderaction-headervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderValue { get; set; }
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-addheaderaction.html#cfn-ses-receiptrule-addheaderaction-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderName { get; set; }
        }

        public class BounceAction : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveTopicArn, IHaveStatusCode
        {
            /// <summary>
            /// Sender
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-sender
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Sender { get; set; }
            /// <summary>
            /// SmtpReplyCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-smtpreplycode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SmtpReplyCode { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicArn { get; set; }
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-bounceaction.html#cfn-ses-receiptrule-bounceaction-statuscode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusCode { get; set; }
        }

        public class ConnectAction : Humidifier.Base.BaseSubResource, IHaveIAMRoleARN
        {
            /// <summary>
            /// InstanceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-connectaction.html#cfn-ses-receiptrule-connectaction-instancearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceARN { get; set; }
            /// <summary>
            /// IAMRoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-connectaction.html#cfn-ses-receiptrule-connectaction-iamrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IAMRoleARN { get; set; }
        }

        public class LambdaAction : Humidifier.Base.BaseSubResource, IHaveTopicArn, IHaveFunctionArn, IHaveInvocationType
        {
            /// <summary>
            /// FunctionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-lambdaaction.html#cfn-ses-receiptrule-lambdaaction-functionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionArn { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-lambdaaction.html#cfn-ses-receiptrule-lambdaaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicArn { get; set; }
            /// <summary>
            /// InvocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-lambdaaction.html#cfn-ses-receiptrule-lambdaaction-invocationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InvocationType { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveName, IHaveEnabled, IHaveTlsPolicy
        {
            /// <summary>
            /// ScanEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-scanenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ScanEnabled { get; set; }
            /// <summary>
            /// Recipients
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-recipients
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Recipients { get; set; }
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-actions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Action
            /// </summary>
            public List<Humidifier.SES.ReceiptRuleTypes.Action> Actions { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// TlsPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-rule.html#cfn-ses-receiptrule-rule-tlspolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TlsPolicy { get; set; }
        }

        public class S3Action : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveKmsKeyArn, IHaveTopicArn, IHaveIamRoleArn, IHaveObjectKeyPrefix
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketName { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicArn { get; set; }
            /// <summary>
            /// ObjectKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-objectkeyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectKeyPrefix { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-s3action.html#cfn-ses-receiptrule-s3action-iamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamRoleArn { get; set; }
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
            public dynamic TopicArn { get; set; }
            /// <summary>
            /// Encoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-snsaction.html#cfn-ses-receiptrule-snsaction-encoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Encoding { get; set; }
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
            public dynamic Scope { get; set; }
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-stopaction.html#cfn-ses-receiptrule-stopaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicArn { get; set; }
        }

        public class WorkmailAction : Humidifier.Base.BaseSubResource, IHaveTopicArn
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-workmailaction.html#cfn-ses-receiptrule-workmailaction-topicarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TopicArn { get; set; }
            /// <summary>
            /// OrganizationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptrule-workmailaction.html#cfn-ses-receiptrule-workmailaction-organizationarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OrganizationArn { get; set; }
        }
    }
}