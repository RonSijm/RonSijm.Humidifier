namespace Humidifier.AutoScaling
{
    using global::System.Collections.Generic;

    public class LifecycleHook : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveLifecycleHookName, IHaveLifecycleTransition, IHaveAutoScalingGroupName, IHaveHeartbeatTimeout_Integer, IHaveNotificationMetadata, IHaveDefaultResult, IHaveNotificationTargetARN, IHaveRoleARN
    {
        public override string AWSTypeName { get => AWS.AutoScaling.LifecycleHook; }
        public Union<string, BaseFunction>? LifecycleHookName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// LifecycleTransition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-lifecyclehook.html#cfn-autoscaling-lifecyclehook-lifecycletransition
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LifecycleTransition { get; set; }

        /// <summary>
        /// AutoScalingGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-lifecyclehook.html#cfn-autoscaling-lifecyclehook-autoscalinggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AutoScalingGroupName { get; set; }
        /// <summary>
        /// HeartbeatTimeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-lifecyclehook.html#cfn-autoscaling-lifecyclehook-heartbeattimeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? HeartbeatTimeout { get; set; }
        /// <summary>
        /// NotificationMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-lifecyclehook.html#cfn-autoscaling-lifecyclehook-notificationmetadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotificationMetadata { get; set; }
        /// <summary>
        /// DefaultResult
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-lifecyclehook.html#cfn-autoscaling-lifecyclehook-defaultresult
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultResult { get; set; }
        /// <summary>
        /// NotificationTargetARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-lifecyclehook.html#cfn-autoscaling-lifecyclehook-notificationtargetarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? NotificationTargetARN { get; set; }
        /// <summary>
        /// RoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-lifecyclehook.html#cfn-autoscaling-lifecyclehook-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleARN { get; set; }
    }
}