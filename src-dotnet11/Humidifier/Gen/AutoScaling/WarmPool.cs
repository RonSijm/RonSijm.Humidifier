namespace Humidifier.AutoScaling
{
    using global::System.Collections.Generic;
    using WarmPoolTypes;

    public class WarmPool : Humidifier.Base.BaseResource, IHaveMinSize_Integer, IHaveMaxGroupPreparedCapacity_Integer, IHaveAutoScalingGroupName, IHavePoolState, IHaveAutoScalingWarmPoolTypesInstanceReusePolicyInstanceReusePolicy
    {
        public override string AWSTypeName { get => AWS.AutoScaling.WarmPool; }
        /// <summary>
        /// MinSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-minsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinSize { get; set; }
        /// <summary>
        /// MaxGroupPreparedCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-maxgrouppreparedcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxGroupPreparedCapacity { get; set; }

        /// <summary>
        /// AutoScalingGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-autoscalinggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AutoScalingGroupName { get; set; }
        /// <summary>
        /// PoolState
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-poolstate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PoolState { get; set; }
        /// <summary>
        /// InstanceReusePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-autoscaling-warmpool.html#cfn-autoscaling-warmpool-instancereusepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InstanceReusePolicy
        /// </summary>
        public Union<Humidifier.AutoScaling.WarmPoolTypes.InstanceReusePolicy, BaseFunction>? InstanceReusePolicy { get; set; }
    }

    namespace WarmPoolTypes
    {
        public class InstanceReusePolicy : Humidifier.Base.BaseSubResource, IHaveReuseOnScaleIn_Boolean
        {
            /// <summary>
            /// ReuseOnScaleIn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-warmpool-instancereusepolicy.html#cfn-autoscaling-warmpool-instancereusepolicy-reuseonscalein
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ReuseOnScaleIn { get; set; }
        }
    }
}