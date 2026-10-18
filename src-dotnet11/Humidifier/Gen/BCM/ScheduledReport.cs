namespace Humidifier.BCM
{
    using global::System.Collections.Generic;
    using ScheduledReportTypes;

    public class ScheduledReport : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveBCMScheduledReportTypesScheduleConfigScheduleConfig, IHaveStringListOfWidgetIds, IHaveScheduledReportExecutionRoleArn, IHaveDescription, IHaveBCMScheduledReportTypesDateTimeRangeWidgetDateRangeOverride, IHaveDashboardArn, IHaveName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string HealthStatus =  "HealthStatus" ;
            public static string Arn =  "Arn" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.BCM.ScheduledReport; }

        /// <summary>
        /// ScheduleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-scheduleconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ScheduleConfig
        /// </summary>
        [Required]
        public Union<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig, BaseFunction>? ScheduleConfig { get; set; }
        /// <summary>
        /// WidgetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-widgetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WidgetIds { get; set; }

        /// <summary>
        /// ScheduledReportExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-scheduledreportexecutionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ScheduledReportExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// WidgetDateRangeOverride
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-widgetdaterangeoverride
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DateTimeRange
        /// </summary>
        public Union<Humidifier.BCM.ScheduledReportTypes.DateTimeRange, BaseFunction>? WidgetDateRangeOverride { get; set; }

        /// <summary>
        /// DashboardArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-dashboardarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DashboardArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ScheduledReportTypes
    {
        public class DateTimeRange : Humidifier.Base.BaseSubResource, IHaveBCMScheduledReportTypesDateTimeValueEndTime, IHaveBCMScheduledReportTypesDateTimeValueStartTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-datetimerange.html#cfn-bcm-scheduledreport-datetimerange-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeValue
            /// </summary>
            public Union<Humidifier.BCM.ScheduledReportTypes.DateTimeValue, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-datetimerange.html#cfn-bcm-scheduledreport-datetimerange-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeValue
            /// </summary>
            public Union<Humidifier.BCM.ScheduledReportTypes.DateTimeValue, BaseFunction>? StartTime { get; set; }
        }

        public class DateTimeValue : Humidifier.Base.BaseSubResource, IHaveValue, IHaveType
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-datetimevalue.html#cfn-bcm-scheduledreport-datetimevalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-datetimevalue.html#cfn-bcm-scheduledreport-datetimevalue-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class HealthStatus : Humidifier.Base.BaseSubResource, IHaveStatusCode, IHaveLastRefreshedAt
        {
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-healthstatus.html#cfn-bcm-scheduledreport-healthstatus-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StatusCode { get; set; }
            /// <summary>
            /// LastRefreshedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-healthstatus.html#cfn-bcm-scheduledreport-healthstatus-lastrefreshedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastRefreshedAt { get; set; }
        }

        public class ScheduleConfig : Humidifier.Base.BaseSubResource, IHaveScheduleExpression, IHaveBCMScheduledReportTypesSchedulePeriodSchedulePeriod, IHaveState, IHaveScheduleExpressionTimeZone
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleconfig.html#cfn-bcm-scheduledreport-scheduleconfig-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpression { get; set; }
            /// <summary>
            /// SchedulePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleconfig.html#cfn-bcm-scheduledreport-scheduleconfig-scheduleperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchedulePeriod
            /// </summary>
            public Union<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod, BaseFunction>? SchedulePeriod { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleconfig.html#cfn-bcm-scheduledreport-scheduleconfig-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// ScheduleExpressionTimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleconfig.html#cfn-bcm-scheduledreport-scheduleconfig-scheduleexpressiontimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleExpressionTimeZone { get; set; }
        }

        public class SchedulePeriod : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleperiod.html#cfn-bcm-scheduledreport-scheduleperiod-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleperiod.html#cfn-bcm-scheduledreport-scheduleperiod-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }
    }
}