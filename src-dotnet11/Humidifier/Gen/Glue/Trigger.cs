namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using TriggerTypes;

    public class Trigger : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveType, IHaveStartOnCreation_Boolean, IHaveDescription, IHaveListOfGlueTriggerTypesActionActions, IHaveGlueTriggerTypesEventBatchingConditionEventBatchingCondition, IHaveWorkflowName, IHaveSchedule, IHaveTags_Json, IHaveName, IHaveGlueTriggerTypesPredicatePredicate
    {
        public override string AWSTypeName { get => AWS.Glue.Trigger; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// StartOnCreation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-startoncreation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? StartOnCreation { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Actions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-actions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Action
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Glue.TriggerTypes.Action>, IReadOnlyList<Union<Humidifier.Glue.TriggerTypes.Action, BaseFunction>>, BaseFunction>? Actions { get; set; }
        /// <summary>
        /// EventBatchingCondition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-eventbatchingcondition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EventBatchingCondition
        /// </summary>
        public Union<Humidifier.Glue.TriggerTypes.EventBatchingCondition, BaseFunction>? EventBatchingCondition { get; set; }
        /// <summary>
        /// WorkflowName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-workflowname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WorkflowName { get; set; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Predicate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-trigger.html#cfn-glue-trigger-predicate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Predicate
        /// </summary>
        public Union<Humidifier.Glue.TriggerTypes.Predicate, BaseFunction>? Predicate { get; set; }
    }

    namespace TriggerTypes
    {
        public class Action : Humidifier.Base.BaseSubResource, IHaveGlueTriggerTypesNotificationPropertyNotificationProperty, IHaveCrawlerName, IHaveTimeout_Integer, IHaveJobName, IHaveArguments_Json, IHaveSecurityConfiguration
        {
            /// <summary>
            /// NotificationProperty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html#cfn-glue-trigger-action-notificationproperty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationProperty
            /// </summary>
            public Union<Humidifier.Glue.TriggerTypes.NotificationProperty, BaseFunction>? NotificationProperty { get; set; }
            /// <summary>
            /// CrawlerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html#cfn-glue-trigger-action-crawlername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrawlerName { get; set; }
            /// <summary>
            /// Timeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html#cfn-glue-trigger-action-timeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Timeout { get; set; }
            /// <summary>
            /// JobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html#cfn-glue-trigger-action-jobname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobName { get; set; }
            /// <summary>
            /// Arguments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html#cfn-glue-trigger-action-arguments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Arguments { get; set; }
            /// <summary>
            /// SecurityConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-action.html#cfn-glue-trigger-action-securityconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecurityConfiguration { get; set; }
        }

        public class Condition : Humidifier.Base.BaseSubResource, IHaveCrawlerName, IHaveState, IHaveCrawlState, IHaveLogicalOperator, IHaveJobName
        {
            /// <summary>
            /// CrawlerName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-crawlername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrawlerName { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// CrawlState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-crawlstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CrawlState { get; set; }
            /// <summary>
            /// LogicalOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-logicaloperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalOperator { get; set; }
            /// <summary>
            /// JobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-condition.html#cfn-glue-trigger-condition-jobname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JobName { get; set; }
        }

        public class EventBatchingCondition : Humidifier.Base.BaseSubResource, IHaveBatchSize_Integer, IHaveBatchWindow_Integer
        {
            /// <summary>
            /// BatchSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-eventbatchingcondition.html#cfn-glue-trigger-eventbatchingcondition-batchsize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchSize { get; set; }
            /// <summary>
            /// BatchWindow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-eventbatchingcondition.html#cfn-glue-trigger-eventbatchingcondition-batchwindow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BatchWindow { get; set; }
        }

        public class NotificationProperty : Humidifier.Base.BaseSubResource, IHaveNotifyDelayAfter_Integer
        {
            /// <summary>
            /// NotifyDelayAfter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-notificationproperty.html#cfn-glue-trigger-notificationproperty-notifydelayafter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NotifyDelayAfter { get; set; }
        }

        public class Predicate : Humidifier.Base.BaseSubResource, IHaveLogical, IHaveListOfGlueTriggerTypesConditionConditions
        {
            /// <summary>
            /// Logical
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-predicate.html#cfn-glue-trigger-predicate-logical
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Logical { get; set; }
            /// <summary>
            /// Conditions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-trigger-predicate.html#cfn-glue-trigger-predicate-conditions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Condition
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.TriggerTypes.Condition>, IReadOnlyList<Union<Humidifier.Glue.TriggerTypes.Condition, BaseFunction>>, BaseFunction>? Conditions { get; set; }
        }
    }
}