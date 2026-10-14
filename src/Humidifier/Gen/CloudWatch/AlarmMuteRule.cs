namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using AlarmMuteRuleTypes;

    public class AlarmMuteRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveStartDate
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string LastUpdatedTimestamp =  "LastUpdatedTimestamp" ;
            public static string Arn =  "Arn" ;
            public static string MuteType =  "MuteType" ;
        }

        public override string AWSTypeName { get => AWS.CloudWatch.AlarmMuteRule; }
        /// <summary>
        /// StartDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-startdate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StartDate { get; set; }
        /// <summary>
        /// MuteTargets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-mutetargets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MuteTargets
        /// </summary>
        public Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets MuteTargets { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// ExpireDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-expiredate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExpireDate { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule Rule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AlarmMuteRuleTypes
    {
        public class MuteTargets : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AlarmNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-mutetargets.html#cfn-cloudwatch-alarmmuterule-mutetargets-alarmnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AlarmNames { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-rule.html#cfn-cloudwatch-alarmmuterule-rule-schedule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Schedule
            /// </summary>
            public Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule Schedule { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveTimezone, IHaveDuration
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-schedule.html#cfn-cloudwatch-alarmmuterule-schedule-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Timezone { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-schedule.html#cfn-cloudwatch-alarmmuterule-schedule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-schedule.html#cfn-cloudwatch-alarmmuterule-schedule-duration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Duration { get; set; }
        }
    }
}