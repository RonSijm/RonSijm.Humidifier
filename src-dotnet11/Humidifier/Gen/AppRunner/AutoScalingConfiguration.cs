namespace Humidifier.AppRunner
{
    using global::System.Collections.Generic;

    public class AutoScalingConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMinSize_Integer, IHaveMaxConcurrency_Integer, IHaveAutoScalingConfigurationName, IHaveMaxSize_Integer
    {
        public class Attributes
        {
            public static string AutoScalingConfigurationRevision =  "AutoScalingConfigurationRevision" ;
            public static string AutoScalingConfigurationArn =  "AutoScalingConfigurationArn" ;
            public static string Latest =  "Latest" ;
        }

        public override string AWSTypeName { get => AWS.AppRunner.AutoScalingConfiguration; }
        /// <summary>
        /// MinSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-minsize
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MinSize { get; set; }
        /// <summary>
        /// MaxConcurrency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-maxconcurrency
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxConcurrency { get; set; }
        public Union<string, BaseFunction>? AutoScalingConfigurationName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// MaxSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-maxsize
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxSize { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}