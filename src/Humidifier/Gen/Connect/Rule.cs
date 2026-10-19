namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using RuleTypes;

    public class Rule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveInstanceArn, IHaveFunction
    {
        public class Attributes
        {
            public static string RuleArn =  "RuleArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.Rule; }

        /// <summary>
        /// Function
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-function
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Function { get; set; }

        /// <summary>
        /// TriggerEventSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-triggereventsource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RuleTriggerEventSource
        /// </summary>
        [Required]
        public Humidifier.Connect.RuleTypes.RuleTriggerEventSource TriggerEventSource { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Actions
        /// </summary>
        [Required]
        public Humidifier.Connect.RuleTypes.Actions Actions { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// PublishStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-publishstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PublishStatus { get; set; }
    }

    namespace RuleTypes
    {
        public class Actions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EventBridgeActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-eventbridgeactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EventBridgeAction
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.EventBridgeAction> EventBridgeActions { get; set; }
            /// <summary>
            /// SendInAppNotificationActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-sendinappnotificationactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SendInAppNotificationAction
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.SendInAppNotificationAction> SendInAppNotificationActions { get; set; }
            /// <summary>
            /// UpdateCaseActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-updatecaseactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UpdateCaseAction
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.UpdateCaseAction> UpdateCaseActions { get; set; }
            /// <summary>
            /// CreateCaseActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-createcaseactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CreateCaseAction
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.CreateCaseAction> CreateCaseActions { get; set; }
            /// <summary>
            /// AssignSlaActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-assignslaactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssignSlaAction
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.AssignSlaAction> AssignSlaActions { get; set; }
            /// <summary>
            /// AssignContactCategoryActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-assigncontactcategoryactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Json
            /// </summary>
            public List<dynamic> AssignContactCategoryActions { get; set; }
            /// <summary>
            /// TaskActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-taskactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TaskAction
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.TaskAction> TaskActions { get; set; }
            /// <summary>
            /// SubmitAutoEvaluationActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-submitautoevaluationactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SubmitAutoEvaluationAction
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.SubmitAutoEvaluationAction> SubmitAutoEvaluationActions { get; set; }
            /// <summary>
            /// SendNotificationActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-sendnotificationactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SendNotificationAction
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.SendNotificationAction> SendNotificationActions { get; set; }
            /// <summary>
            /// EndAssociatedTasksActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-endassociatedtasksactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Json
            /// </summary>
            public List<dynamic> EndAssociatedTasksActions { get; set; }
        }

        public class AssignSlaAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SlaAssignmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-assignslaaction.html#cfn-connect-rule-assignslaaction-slaassignmenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SlaAssignmentType { get; set; }
            /// <summary>
            /// CaseSlaConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-assignslaaction.html#cfn-connect-rule-assignslaaction-caseslaconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CaseSlaConfiguration
            /// </summary>
            public Humidifier.Connect.RuleTypes.CaseSlaConfiguration CaseSlaConfiguration { get; set; }
        }

        public class CaseSlaConfiguration : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveFieldId
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldId { get; set; }
            /// <summary>
            /// TargetSlaMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-targetslaminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic TargetSlaMinutes { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
            /// <summary>
            /// TargetFieldValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-targetfieldvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlaTargetFieldValue
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.SlaTargetFieldValue> TargetFieldValues { get; set; }
        }

        public class CreateCaseAction : Humidifier.Base.BaseSubResource, IHaveTemplateId
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-createcaseaction.html#cfn-connect-rule-createcaseaction-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Field
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.Field> Fields { get; set; }
            /// <summary>
            /// TemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-createcaseaction.html#cfn-connect-rule-createcaseaction-templateid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateId { get; set; }
        }

        public class EventBridgeAction : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-eventbridgeaction.html#cfn-connect-rule-eventbridgeaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class Field : Humidifier.Base.BaseSubResource, IHaveId
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-field.html#cfn-connect-rule-field-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldValue
            /// </summary>
            public Humidifier.Connect.RuleTypes.FieldValue Value { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-field.html#cfn-connect-rule-field-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }

        public class FieldValue : Humidifier.Base.BaseSubResource, IHaveStringValue, IHaveDoubleValue, IHaveBooleanValue
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-fieldvalue.html#cfn-connect-rule-fieldvalue-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DoubleValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-fieldvalue.html#cfn-connect-rule-fieldvalue-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic BooleanValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-fieldvalue.html#cfn-connect-rule-fieldvalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
            /// <summary>
            /// EmptyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-fieldvalue.html#cfn-connect-rule-fieldvalue-emptyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic EmptyValue { get; set; }
        }

        public class InAppNotificationRecipientType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UserTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-inappnotificationrecipienttype.html#cfn-connect-rule-inappnotificationrecipienttype-usertags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> UserTags { get; set; }
            /// <summary>
            /// UserArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-inappnotificationrecipienttype.html#cfn-connect-rule-inappnotificationrecipienttype-userarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic UserArns { get; set; }
        }

        public class NotificationContent : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DeDE
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-dede
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeDE { get; set; }
            /// <summary>
            /// PtBR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-ptbr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PtBR { get; set; }
            /// <summary>
            /// ZhCN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-zhcn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ZhCN { get; set; }
            /// <summary>
            /// IdID
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-idid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdID { get; set; }
            /// <summary>
            /// ItIT
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-itit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ItIT { get; set; }
            /// <summary>
            /// EnUS
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-enus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EnUS { get; set; }
            /// <summary>
            /// KoKR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-kokr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KoKR { get; set; }
            /// <summary>
            /// FrFR
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-frfr
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FrFR { get; set; }
            /// <summary>
            /// ZhTW
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-zhtw
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ZhTW { get; set; }
            /// <summary>
            /// EsES
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-eses
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EsES { get; set; }
            /// <summary>
            /// JaJP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationcontent.html#cfn-connect-rule-notificationcontent-jajp
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JaJP { get; set; }
        }

        public class NotificationRecipientType : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UserTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationrecipienttype.html#cfn-connect-rule-notificationrecipienttype-usertags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> UserTags { get; set; }
            /// <summary>
            /// UserArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationrecipienttype.html#cfn-connect-rule-notificationrecipienttype-userarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic UserArns { get; set; }
        }

        public class Reference : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-reference.html#cfn-connect-rule-reference-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-reference.html#cfn-connect-rule-reference-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
        }

        public class RuleTriggerEventSource : Humidifier.Base.BaseSubResource, IHaveEventSourceName
        {
            /// <summary>
            /// IntegrationAssociationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-ruletriggereventsource.html#cfn-connect-rule-ruletriggereventsource-integrationassociationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntegrationAssociationArn { get; set; }
            /// <summary>
            /// EventSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-ruletriggereventsource.html#cfn-connect-rule-ruletriggereventsource-eventsourcename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventSourceName { get; set; }
        }

        public class SendInAppNotificationAction : Humidifier.Base.BaseSubResource, IHavePriority
        {
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendinappnotificationaction.html#cfn-connect-rule-sendinappnotificationaction-content
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NotificationContent
            /// </summary>
            public Humidifier.Connect.RuleTypes.NotificationContent Content { get; set; }
            /// <summary>
            /// Priority
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendinappnotificationaction.html#cfn-connect-rule-sendinappnotificationaction-priority
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Priority { get; set; }
            /// <summary>
            /// Exclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendinappnotificationaction.html#cfn-connect-rule-sendinappnotificationaction-exclusion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InAppNotificationRecipientType
            /// </summary>
            public Humidifier.Connect.RuleTypes.InAppNotificationRecipientType Exclusion { get; set; }
            /// <summary>
            /// Recipient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendinappnotificationaction.html#cfn-connect-rule-sendinappnotificationaction-recipient
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InAppNotificationRecipientType
            /// </summary>
            public Humidifier.Connect.RuleTypes.InAppNotificationRecipientType Recipient { get; set; }
        }

        public class SendNotificationAction : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveContent, IHaveSubject
        {
            /// <summary>
            /// DeliveryMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-deliverymethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeliveryMethod { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-contenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-content
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Content { get; set; }
            /// <summary>
            /// Exclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-exclusion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationRecipientType
            /// </summary>
            public Humidifier.Connect.RuleTypes.NotificationRecipientType Exclusion { get; set; }
            /// <summary>
            /// Recipient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-recipient
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NotificationRecipientType
            /// </summary>
            public Humidifier.Connect.RuleTypes.NotificationRecipientType Recipient { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-subject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Subject { get; set; }
        }

        public class SlaTargetFieldValue : Humidifier.Base.BaseSubResource, IHaveStringValue
        {
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-slatargetfieldvalue.html#cfn-connect-rule-slatargetfieldvalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StringValue { get; set; }
        }

        public class SubmitAutoEvaluationAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EvaluationFormArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-submitautoevaluationaction.html#cfn-connect-rule-submitautoevaluationaction-evaluationformarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EvaluationFormArn { get; set; }
        }

        public class TaskAction : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveContactFlowArn
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-taskaction.html#cfn-connect-rule-taskaction-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// References
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-taskaction.html#cfn-connect-rule-taskaction-references
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: Reference
            /// </summary>
            public Dictionary<string, Humidifier.Connect.RuleTypes.Reference> References { get; set; }
            /// <summary>
            /// ContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-taskaction.html#cfn-connect-rule-taskaction-contactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactFlowArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-taskaction.html#cfn-connect-rule-taskaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class UpdateCaseAction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-updatecaseaction.html#cfn-connect-rule-updatecaseaction-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Field
            /// </summary>
            public List<Humidifier.Connect.RuleTypes.Field> Fields { get; set; }
        }
    }
}