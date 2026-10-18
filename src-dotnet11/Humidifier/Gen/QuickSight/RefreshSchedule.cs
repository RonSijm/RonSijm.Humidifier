namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using RefreshScheduleTypes;

    public class RefreshSchedule : Humidifier.Base.BaseResource, IHaveQuickSightRefreshScheduleTypesRefreshScheduleMapSchedule, IHaveAwsAccountId, IHaveDataSetId
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.RefreshSchedule; }
        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-refreshschedule.html#cfn-quicksight-refreshschedule-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RefreshScheduleMap
        /// </summary>
        public Union<Humidifier.QuickSight.RefreshScheduleTypes.RefreshScheduleMap, BaseFunction>? Schedule { get; set; }
        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-refreshschedule.html#cfn-quicksight-refreshschedule-awsaccountid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// DataSetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-refreshschedule.html#cfn-quicksight-refreshschedule-datasetid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataSetId { get; set; }
    }

    namespace RefreshScheduleTypes
    {
        public class RefreshOnDay : Humidifier.Base.BaseSubResource, IHaveDayOfWeek, IHaveDayOfMonth
        {
            /// <summary>
            /// DayOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-refreshonday.html#cfn-quicksight-refreshschedule-refreshonday-dayofweek
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DayOfWeek { get; set; }
            /// <summary>
            /// DayOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-refreshonday.html#cfn-quicksight-refreshschedule-refreshonday-dayofmonth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DayOfMonth { get; set; }
        }

        public class RefreshScheduleMap : Humidifier.Base.BaseSubResource, IHaveStartAfterDateTime, IHaveScheduleId, IHaveQuickSightRefreshScheduleTypesScheduleFrequencyScheduleFrequency, IHaveRefreshType
        {
            /// <summary>
            /// StartAfterDateTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-refreshschedulemap.html#cfn-quicksight-refreshschedule-refreshschedulemap-startafterdatetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartAfterDateTime { get; set; }
            /// <summary>
            /// ScheduleId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-refreshschedulemap.html#cfn-quicksight-refreshschedule-refreshschedulemap-scheduleid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScheduleId { get; set; }
            /// <summary>
            /// ScheduleFrequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-refreshschedulemap.html#cfn-quicksight-refreshschedule-refreshschedulemap-schedulefrequency
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScheduleFrequency
            /// </summary>
            public Union<Humidifier.QuickSight.RefreshScheduleTypes.ScheduleFrequency, BaseFunction>? ScheduleFrequency { get; set; }
            /// <summary>
            /// RefreshType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-refreshschedulemap.html#cfn-quicksight-refreshschedule-refreshschedulemap-refreshtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshType { get; set; }
        }

        public class ScheduleFrequency : Humidifier.Base.BaseSubResource, IHaveTimeZone, IHaveQuickSightRefreshScheduleTypesRefreshOnDayRefreshOnDay, IHaveTimeOfTheDay, IHaveInterval
        {
            /// <summary>
            /// TimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-schedulefrequency.html#cfn-quicksight-refreshschedule-schedulefrequency-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeZone { get; set; }
            /// <summary>
            /// RefreshOnDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-schedulefrequency.html#cfn-quicksight-refreshschedule-schedulefrequency-refreshonday
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RefreshOnDay
            /// </summary>
            public Union<Humidifier.QuickSight.RefreshScheduleTypes.RefreshOnDay, BaseFunction>? RefreshOnDay { get; set; }
            /// <summary>
            /// TimeOfTheDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-schedulefrequency.html#cfn-quicksight-refreshschedule-schedulefrequency-timeoftheday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeOfTheDay { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-refreshschedule-schedulefrequency.html#cfn-quicksight-refreshschedule-schedulefrequency-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Interval { get; set; }
        }
    }
}