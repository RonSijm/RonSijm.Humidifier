namespace Humidifier.ApplicationAutoScaling
{
    using global::System.Collections.Generic;
    using ScalableTargetTypes;

    public class ScalableTarget : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfApplicationAutoScalingScalableTargetTypesScheduledActionScheduledActions, IHaveResourceId, IHaveServiceNamespace, IHaveScalableDimension, IHaveApplicationAutoScalingScalableTargetTypesSuspendedStateSuspendedState, IHaveMinCapacity_Integer, IHaveRoleARN, IHaveMaxCapacity_Integer
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.ApplicationAutoScaling.ScalableTarget; }
        /// <summary>
        /// ScheduledActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scheduledactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ScheduledAction
        /// </summary>
        public Union<IReadOnlyList<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction>, IReadOnlyList<Union<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction, BaseFunction>>, BaseFunction>? ScheduledActions { get; set; }

        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-resourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResourceId { get; set; }

        /// <summary>
        /// ServiceNamespace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-servicenamespace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceNamespace { get; set; }

        /// <summary>
        /// ScalableDimension
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scalabledimension
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ScalableDimension { get; set; }
        /// <summary>
        /// SuspendedState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-suspendedstate
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SuspendedState
        /// </summary>
        public Union<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState, BaseFunction>? SuspendedState { get; set; }

        /// <summary>
        /// MinCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-mincapacity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MinCapacity { get; set; }
        /// <summary>
        /// RoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleARN { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// MaxCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-maxcapacity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MaxCapacity { get; set; }
    }

    namespace ScalableTargetTypes
    {
        public class ScalableTargetAction : Humidifier.Base.BaseSubResource, IHaveMinCapacity_Integer, IHaveMaxCapacity_Integer
        {
            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scalabletargetaction.html#cfn-applicationautoscaling-scalabletarget-scalabletargetaction-mincapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinCapacity { get; set; }
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scalabletargetaction.html#cfn-applicationautoscaling-scalabletarget-scalabletargetaction-maxcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxCapacity { get; set; }
        }

        public class ScheduledAction : Humidifier.Base.BaseSubResource, IHaveTimezone, IHaveScheduledActionName, IHaveEndTime_Timestamp, IHaveSchedule, IHaveStartTime_Timestamp, IHaveApplicationAutoScalingScalableTargetTypesScalableTargetActionScalableTargetAction
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scheduledaction.html#cfn-applicationautoscaling-scalabletarget-scheduledaction-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timezone { get; set; }
            /// <summary>
            /// ScheduledActionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scheduledaction.html#cfn-applicationautoscaling-scalabletarget-scheduledaction-scheduledactionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduledActionName { get; set; }
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scheduledaction.html#cfn-applicationautoscaling-scalabletarget-scheduledaction-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Timestamp
            /// </summary>
            public Union<System.DateTime, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scheduledaction.html#cfn-applicationautoscaling-scalabletarget-scheduledaction-schedule
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Schedule { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scheduledaction.html#cfn-applicationautoscaling-scalabletarget-scheduledaction-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Timestamp
            /// </summary>
            public Union<System.DateTime, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// ScalableTargetAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-scheduledaction.html#cfn-applicationautoscaling-scalabletarget-scheduledaction-scalabletargetaction
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScalableTargetAction
            /// </summary>
            public Union<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction, BaseFunction>? ScalableTargetAction { get; set; }
        }

        public class SuspendedState : Humidifier.Base.BaseSubResource, IHaveDynamicScalingOutSuspended_Boolean, IHaveScheduledScalingSuspended_Boolean, IHaveDynamicScalingInSuspended_Boolean
        {
            /// <summary>
            /// DynamicScalingOutSuspended
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-suspendedstate.html#cfn-applicationautoscaling-scalabletarget-suspendedstate-dynamicscalingoutsuspended
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DynamicScalingOutSuspended { get; set; }
            /// <summary>
            /// ScheduledScalingSuspended
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-suspendedstate.html#cfn-applicationautoscaling-scalabletarget-suspendedstate-scheduledscalingsuspended
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ScheduledScalingSuspended { get; set; }
            /// <summary>
            /// DynamicScalingInSuspended
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-applicationautoscaling-scalabletarget-suspendedstate.html#cfn-applicationautoscaling-scalabletarget-suspendedstate-dynamicscalinginsuspended
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DynamicScalingInSuspended { get; set; }
        }
    }
}