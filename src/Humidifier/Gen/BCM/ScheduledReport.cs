namespace Humidifier.BCM
{
    using global::System.Collections.Generic;
    using ScheduledReportTypes;

    public class ScheduledReport : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
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
        public Humidifier.BCM.ScheduledReportTypes.ScheduleConfig ScheduleConfig { get; set; }
        /// <summary>
        /// WidgetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-widgetids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic WidgetIds { get; set; }

        /// <summary>
        /// ScheduledReportExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-scheduledreportexecutionrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ScheduledReportExecutionRoleArn { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// WidgetDateRangeOverride
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-widgetdaterangeoverride
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DateTimeRange
        /// </summary>
        public Humidifier.BCM.ScheduledReportTypes.DateTimeRange WidgetDateRangeOverride { get; set; }

        /// <summary>
        /// DashboardArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-dashboardarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DashboardArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bcm-scheduledreport.html#cfn-bcm-scheduledreport-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ScheduledReportTypes
    {
        public class DateTimeRange : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-datetimerange.html#cfn-bcm-scheduledreport-datetimerange-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeValue
            /// </summary>
            public Humidifier.BCM.ScheduledReportTypes.DateTimeValue EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-datetimerange.html#cfn-bcm-scheduledreport-datetimerange-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DateTimeValue
            /// </summary>
            public Humidifier.BCM.ScheduledReportTypes.DateTimeValue StartTime { get; set; }
        }

        public class DateTimeValue : Humidifier.Base.BaseSubResource, IHaveType, IHaveValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-datetimevalue.html#cfn-bcm-scheduledreport-datetimevalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-datetimevalue.html#cfn-bcm-scheduledreport-datetimevalue-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class HealthStatus : Humidifier.Base.BaseSubResource, IHaveStatusCode
        {
            /// <summary>
            /// StatusCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-healthstatus.html#cfn-bcm-scheduledreport-healthstatus-statuscode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StatusCode { get; set; }
            /// <summary>
            /// LastRefreshedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-healthstatus.html#cfn-bcm-scheduledreport-healthstatus-lastrefreshedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastRefreshedAt { get; set; }
        }

        public class ScheduleConfig : Humidifier.Base.BaseSubResource, IHaveState, IHaveScheduleExpression
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleconfig.html#cfn-bcm-scheduledreport-scheduleconfig-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression { get; set; }
            /// <summary>
            /// SchedulePeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleconfig.html#cfn-bcm-scheduledreport-scheduleconfig-scheduleperiod
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchedulePeriod
            /// </summary>
            public Humidifier.BCM.ScheduledReportTypes.SchedulePeriod SchedulePeriod { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleconfig.html#cfn-bcm-scheduledreport-scheduleconfig-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// ScheduleExpressionTimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleconfig.html#cfn-bcm-scheduledreport-scheduleconfig-scheduleexpressiontimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpressionTimeZone { get; set; }
        }

        public class SchedulePeriod : Humidifier.Base.BaseSubResource, IHaveStartTime, IHaveEndTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleperiod.html#cfn-bcm-scheduledreport-scheduleperiod-endtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bcm-scheduledreport-scheduleperiod.html#cfn-bcm-scheduledreport-scheduleperiod-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime { get; set; }
        }
    }
}