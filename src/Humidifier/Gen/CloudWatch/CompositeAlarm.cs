namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using CompositeAlarmTypes;

    public class CompositeAlarm : Humidifier.Base.BaseResource, IHaveTags, IHaveAlarmName, IHaveOKActions, IHaveAlarmActions, IHaveActionsEnabled, IHaveAlarmDescription, IHaveInsufficientDataActions
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.CompositeAlarm; }
        /// <summary>
        /// ActionsSuppressorWaitPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-actionssuppressorwaitperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ActionsSuppressorWaitPeriod { get; set; }
        /// <summary>
        /// AlarmActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AlarmActions { get; set; }
        /// <summary>
        /// ActionsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-actionsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic ActionsEnabled { get; set; }
        /// <summary>
        /// AlarmName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AlarmName { get; set; }
        /// <summary>
        /// AlarmDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AlarmDescription { get; set; }
        /// <summary>
        /// ActionsSuppressor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-actionssuppressor
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ActionsSuppressor { get; set; }

        /// <summary>
        /// AlarmRule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-alarmrule
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AlarmRule { get; set; }
        /// <summary>
        /// InsufficientDataActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-insufficientdataactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic InsufficientDataActions { get; set; }
        /// <summary>
        /// ActionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-actionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ActionConfiguration
        /// </summary>
        public Humidifier.CloudWatch.CompositeAlarmTypes.ActionConfiguration ActionConfiguration { get; set; }
        /// <summary>
        /// OKActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-okactions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic OKActions { get; set; }
        /// <summary>
        /// ActionsSuppressorExtensionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-actionssuppressorextensionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ActionsSuppressorExtensionPeriod { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-compositealarm.html#cfn-cloudwatch-compositealarm-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace CompositeAlarmTypes
    {
        public class ActionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AlarmTagsPropagation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-compositealarm-actionconfiguration.html#cfn-cloudwatch-compositealarm-actionconfiguration-alarmtagspropagation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AlarmTagsPropagation
            /// </summary>
            public Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation AlarmTagsPropagation { get; set; }
        }

        public class AlarmTagsPropagation : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// IncludedTagKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-compositealarm-alarmtagspropagation.html#cfn-cloudwatch-compositealarm-alarmtagspropagation-includedtagkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedTagKeys { get; set; }
            /// <summary>
            /// ExcludedTagKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-compositealarm-alarmtagspropagation.html#cfn-cloudwatch-compositealarm-alarmtagspropagation-excludedtagkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExcludedTagKeys { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-compositealarm-alarmtagspropagation.html#cfn-cloudwatch-compositealarm-alarmtagspropagation-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }
    }
}