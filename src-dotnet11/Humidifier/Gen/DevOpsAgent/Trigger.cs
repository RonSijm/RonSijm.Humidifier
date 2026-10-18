namespace Humidifier.DevOpsAgent
{
    using global::System.Collections.Generic;
    using TriggerTypes;

    public class Trigger : Humidifier.Base.BaseResource, IHaveDevOpsAgentTriggerTypesConditionCondition, IHaveStatus, IHaveType, IHaveAction_Json, IHaveAgentSpaceId
    {
        public class Attributes
        {
            public static string TriggerId =  "TriggerId" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DevOpsAgent.Trigger; }

        /// <summary>
        /// Condition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-trigger.html#cfn-devopsagent-trigger-condition
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Condition
        /// </summary>
        [Required]
        public Union<Humidifier.DevOpsAgent.TriggerTypes.Condition, BaseFunction>? Condition { get; set; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-trigger.html#cfn-devopsagent-trigger-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-trigger.html#cfn-devopsagent-trigger-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-trigger.html#cfn-devopsagent-trigger-action
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? Action { get; set; }

        /// <summary>
        /// AgentSpaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-trigger.html#cfn-devopsagent-trigger-agentspaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AgentSpaceId { get; set; }
    }

    namespace TriggerTypes
    {
        public class Condition : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentTriggerTypesScheduleSchedule
        {
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-trigger-condition.html#cfn-devopsagent-trigger-condition-schedule
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Schedule
            /// </summary>
            public Union<Humidifier.DevOpsAgent.TriggerTypes.Schedule, BaseFunction>? Schedule { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveExpression
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-trigger-schedule.html#cfn-devopsagent-trigger-schedule-expression
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
        }
    }
}