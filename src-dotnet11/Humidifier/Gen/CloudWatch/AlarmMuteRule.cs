namespace Humidifier.CloudWatch
{
    using global::System.Collections.Generic;
    using AlarmMuteRuleTypes;

    public class AlarmMuteRule : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStartDate, IHaveCloudWatchAlarmMuteRuleTypesMuteTargetsMuteTargets, IHaveDescription, IHaveExpireDate, IHaveCloudWatchAlarmMuteRuleTypesRuleRule, IHaveName
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
        public Union<string, BaseFunction>? StartDate { get; set; }
        /// <summary>
        /// MuteTargets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-mutetargets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MuteTargets
        /// </summary>
        public Union<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets, BaseFunction>? MuteTargets { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// ExpireDate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-expiredate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExpireDate { get; set; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Rule
        /// </summary>
        [Required]
        public Union<Humidifier.CloudWatch.AlarmMuteRuleTypes.Rule, BaseFunction>? Rule { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-alarmmuterule.html#cfn-cloudwatch-alarmmuterule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace AlarmMuteRuleTypes
    {
        public class MuteTargets : Humidifier.Base.BaseSubResource, IHaveStringListOfAlarmNames
        {
            /// <summary>
            /// AlarmNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-mutetargets.html#cfn-cloudwatch-alarmmuterule-mutetargets-alarmnames
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AlarmNames { get; set; }
        }

        public class Rule : Humidifier.Base.BaseSubResource, IHaveCloudWatchAlarmMuteRuleTypesScheduleSchedule
        {
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-rule.html#cfn-cloudwatch-alarmmuterule-rule-schedule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Schedule
            /// </summary>
            public Union<Humidifier.CloudWatch.AlarmMuteRuleTypes.Schedule, BaseFunction>? Schedule { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveTimezone, IHaveExpression, IHaveDuration
        {
            /// <summary>
            /// Timezone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-schedule.html#cfn-cloudwatch-alarmmuterule-schedule-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Timezone { get; set; }
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-schedule.html#cfn-cloudwatch-alarmmuterule-schedule-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-alarmmuterule-schedule.html#cfn-cloudwatch-alarmmuterule-schedule-duration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Duration { get; set; }
        }
    }
}