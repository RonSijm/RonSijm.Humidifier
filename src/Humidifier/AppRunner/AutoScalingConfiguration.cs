namespace Humidifier.AppRunner
{
    using System.Collections.Generic;

    public class AutoScalingConfiguration : Humidifier.Resource, IHaveTags
    {
        public class Attributes
        {
            public static string AutoScalingConfigurationRevision =  "AutoScalingConfigurationRevision" ;
            public static string AutoScalingConfigurationArn =  "AutoScalingConfigurationArn" ;
            public static string Latest =  "Latest" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppRunner::AutoScalingConfiguration";
            }
        }

        /// <summary>
        /// MinSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-minsize
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MinSize { get; set; }
        /// <summary>
        /// MaxConcurrency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-maxconcurrency
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxConcurrency { get; set; }
        /// <summary>
        /// AutoScalingConfigurationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-autoscalingconfigurationname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoScalingConfigurationName { get; set; }
        /// <summary>
        /// MaxSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-maxsize
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxSize { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apprunner-autoscalingconfiguration.html#cfn-apprunner-autoscalingconfiguration-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}