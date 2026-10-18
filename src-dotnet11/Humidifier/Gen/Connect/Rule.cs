namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using RuleTypes;

    public class Rule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveFunction, IHaveConnectRuleTypesRuleTriggerEventSourceTriggerEventSource, IHaveConnectRuleTypesActionsActions, IHaveInstanceArn, IHaveName, IHavePublishStatus
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
        public Union<string, BaseFunction>? Function { get; set; }

        /// <summary>
        /// TriggerEventSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-triggereventsource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RuleTriggerEventSource
        /// </summary>
        [Required]
        public Union<Humidifier.Connect.RuleTypes.RuleTriggerEventSource, BaseFunction>? TriggerEventSource { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Actions
        /// </summary>
        [Required]
        public Union<Humidifier.Connect.RuleTypes.Actions, BaseFunction>? Actions { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// PublishStatus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-rule.html#cfn-connect-rule-publishstatus
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PublishStatus { get; set; }
    }

    namespace RuleTypes
    {
        public class Actions : Humidifier.Base.BaseSubResource, IHaveListOfConnectRuleTypesEventBridgeActionEventBridgeActions, IHaveListOfConnectRuleTypesUpdateCaseActionUpdateCaseActions, IHaveListOfConnectRuleTypesCreateCaseActionCreateCaseActions, IHaveListOfConnectRuleTypesAssignSlaActionAssignSlaActions, IHaveJsonListOfAssignContactCategoryActions, IHaveListOfConnectRuleTypesTaskActionTaskActions, IHaveListOfConnectRuleTypesSubmitAutoEvaluationActionSubmitAutoEvaluationActions, IHaveListOfConnectRuleTypesSendNotificationActionSendNotificationActions, IHaveJsonListOfEndAssociatedTasksActions
        {
            /// <summary>
            /// EventBridgeActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-eventbridgeactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EventBridgeAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.EventBridgeAction>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.EventBridgeAction, BaseFunction>>, BaseFunction>? EventBridgeActions { get; set; }
            /// <summary>
            /// UpdateCaseActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-updatecaseactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: UpdateCaseAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.UpdateCaseAction>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.UpdateCaseAction, BaseFunction>>, BaseFunction>? UpdateCaseActions { get; set; }
            /// <summary>
            /// CreateCaseActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-createcaseactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CreateCaseAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.CreateCaseAction>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.CreateCaseAction, BaseFunction>>, BaseFunction>? CreateCaseActions { get; set; }
            /// <summary>
            /// AssignSlaActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-assignslaactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AssignSlaAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.AssignSlaAction>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.AssignSlaAction, BaseFunction>>, BaseFunction>? AssignSlaActions { get; set; }
            /// <summary>
            /// AssignContactCategoryActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-assigncontactcategoryactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Json
            /// </summary>
            public Union<IReadOnlyList<object>, IReadOnlyList<Union<object, BaseFunction>>, BaseFunction>? AssignContactCategoryActions { get; set; }
            /// <summary>
            /// TaskActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-taskactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TaskAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.TaskAction>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.TaskAction, BaseFunction>>, BaseFunction>? TaskActions { get; set; }
            /// <summary>
            /// SubmitAutoEvaluationActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-submitautoevaluationactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SubmitAutoEvaluationAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.SubmitAutoEvaluationAction>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.SubmitAutoEvaluationAction, BaseFunction>>, BaseFunction>? SubmitAutoEvaluationActions { get; set; }
            /// <summary>
            /// SendNotificationActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-sendnotificationactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SendNotificationAction
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.SendNotificationAction>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.SendNotificationAction, BaseFunction>>, BaseFunction>? SendNotificationActions { get; set; }
            /// <summary>
            /// EndAssociatedTasksActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-actions.html#cfn-connect-rule-actions-endassociatedtasksactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Json
            /// </summary>
            public Union<IReadOnlyList<object>, IReadOnlyList<Union<object, BaseFunction>>, BaseFunction>? EndAssociatedTasksActions { get; set; }
        }

        public class AssignSlaAction : Humidifier.Base.BaseSubResource, IHaveSlaAssignmentType, IHaveConnectRuleTypesCaseSlaConfigurationCaseSlaConfiguration
        {
            /// <summary>
            /// SlaAssignmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-assignslaaction.html#cfn-connect-rule-assignslaaction-slaassignmenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SlaAssignmentType { get; set; }
            /// <summary>
            /// CaseSlaConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-assignslaaction.html#cfn-connect-rule-assignslaaction-caseslaconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CaseSlaConfiguration
            /// </summary>
            public Union<Humidifier.Connect.RuleTypes.CaseSlaConfiguration, BaseFunction>? CaseSlaConfiguration { get; set; }
        }

        public class CaseSlaConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveFieldId, IHaveTargetSlaMinutes_Double, IHaveName, IHaveListOfConnectRuleTypesSlaTargetFieldValueTargetFieldValues
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldId { get; set; }
            /// <summary>
            /// TargetSlaMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-targetslaminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? TargetSlaMinutes { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
            /// <summary>
            /// TargetFieldValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-caseslaconfiguration.html#cfn-connect-rule-caseslaconfiguration-targetfieldvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SlaTargetFieldValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.SlaTargetFieldValue>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.SlaTargetFieldValue, BaseFunction>>, BaseFunction>? TargetFieldValues { get; set; }
        }

        public class CreateCaseAction : Humidifier.Base.BaseSubResource, IHaveListOfConnectRuleTypesFieldFields, IHaveTemplateId
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-createcaseaction.html#cfn-connect-rule-createcaseaction-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Field
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.Field>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.Field, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// TemplateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-createcaseaction.html#cfn-connect-rule-createcaseaction-templateid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateId { get; set; }
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
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Field : Humidifier.Base.BaseSubResource, IHaveConnectRuleTypesFieldValueValue, IHaveId
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-field.html#cfn-connect-rule-field-value
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldValue
            /// </summary>
            public Union<Humidifier.Connect.RuleTypes.FieldValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-field.html#cfn-connect-rule-field-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }

        public class FieldValue : Humidifier.Base.BaseSubResource, IHaveDoubleValue_Double, IHaveBooleanValue_Boolean, IHaveStringValue, IHaveEmptyValue_Json
        {
            /// <summary>
            /// DoubleValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-fieldvalue.html#cfn-connect-rule-fieldvalue-doublevalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? DoubleValue { get; set; }
            /// <summary>
            /// BooleanValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-fieldvalue.html#cfn-connect-rule-fieldvalue-booleanvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? BooleanValue { get; set; }
            /// <summary>
            /// StringValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-fieldvalue.html#cfn-connect-rule-fieldvalue-stringvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StringValue { get; set; }
            /// <summary>
            /// EmptyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-fieldvalue.html#cfn-connect-rule-fieldvalue-emptyvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? EmptyValue { get; set; }
        }

        public class NotificationRecipientType : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfUserTags, IHaveStringListOfUserArns
        {
            /// <summary>
            /// UserTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationrecipienttype.html#cfn-connect-rule-notificationrecipienttype-usertags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? UserTags { get; set; }
            /// <summary>
            /// UserArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-notificationrecipienttype.html#cfn-connect-rule-notificationrecipienttype-userarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? UserArns { get; set; }
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
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-reference.html#cfn-connect-rule-reference-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
        }

        public class RuleTriggerEventSource : Humidifier.Base.BaseSubResource, IHaveIntegrationAssociationArn, IHaveEventSourceName
        {
            /// <summary>
            /// IntegrationAssociationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-ruletriggereventsource.html#cfn-connect-rule-ruletriggereventsource-integrationassociationarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntegrationAssociationArn { get; set; }
            /// <summary>
            /// EventSourceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-ruletriggereventsource.html#cfn-connect-rule-ruletriggereventsource-eventsourcename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EventSourceName { get; set; }
        }

        public class SendNotificationAction : Humidifier.Base.BaseSubResource, IHaveDeliveryMethod, IHaveContentType, IHaveContent, IHaveConnectRuleTypesNotificationRecipientTypeExclusion, IHaveConnectRuleTypesNotificationRecipientTypeRecipient, IHaveSubject
        {
            /// <summary>
            /// DeliveryMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-deliverymethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryMethod { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-contenttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// Content
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-content
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Content { get; set; }
            /// <summary>
            /// Exclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-exclusion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationRecipientType
            /// </summary>
            public Union<Humidifier.Connect.RuleTypes.NotificationRecipientType, BaseFunction>? Exclusion { get; set; }
            /// <summary>
            /// Recipient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-recipient
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NotificationRecipientType
            /// </summary>
            public Union<Humidifier.Connect.RuleTypes.NotificationRecipientType, BaseFunction>? Recipient { get; set; }
            /// <summary>
            /// Subject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-sendnotificationaction.html#cfn-connect-rule-sendnotificationaction-subject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subject { get; set; }
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
            public Union<string, BaseFunction>? StringValue { get; set; }
        }

        public class SubmitAutoEvaluationAction : Humidifier.Base.BaseSubResource, IHaveEvaluationFormArn
        {
            /// <summary>
            /// EvaluationFormArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-submitautoevaluationaction.html#cfn-connect-rule-submitautoevaluationaction-evaluationformarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EvaluationFormArn { get; set; }
        }

        public class TaskAction : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveMapOfConnectRuleTypesReferenceReferences, IHaveContactFlowArn, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-taskaction.html#cfn-connect-rule-taskaction-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// References
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-taskaction.html#cfn-connect-rule-taskaction-references
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: Reference
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Connect.RuleTypes.Reference>, IReadOnlyDictionary<string, Union<Humidifier.Connect.RuleTypes.Reference, BaseFunction>>, BaseFunction>? References { get; set; }
            /// <summary>
            /// ContactFlowArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-taskaction.html#cfn-connect-rule-taskaction-contactflowarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContactFlowArn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-taskaction.html#cfn-connect-rule-taskaction-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class UpdateCaseAction : Humidifier.Base.BaseSubResource, IHaveListOfConnectRuleTypesFieldFields
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-rule-updatecaseaction.html#cfn-connect-rule-updatecaseaction-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Field
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.RuleTypes.Field>, IReadOnlyList<Union<Humidifier.Connect.RuleTypes.Field, BaseFunction>>, BaseFunction>? Fields { get; set; }
        }
    }
}