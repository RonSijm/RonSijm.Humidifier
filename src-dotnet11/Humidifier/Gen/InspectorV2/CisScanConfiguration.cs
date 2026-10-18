namespace Humidifier.InspectorV2
{
    using global::System.Collections.Generic;
    using CisScanConfigurationTypes;

    public class CisScanConfiguration : Humidifier.Base.BaseResource, IHaveSecurityLevel, IHaveInspectorV2CisScanConfigurationTypesScheduleSchedule, IHaveInspectorV2CisScanConfigurationTypesCisTargetsTargets, IHaveScanName, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.InspectorV2.CisScanConfiguration; }

        /// <summary>
        /// SecurityLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-securitylevel
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SecurityLevel { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        [Required]
        public Union<Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule, BaseFunction>? Schedule { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-targets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CisTargets
        /// </summary>
        [Required]
        public Union<Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets, BaseFunction>? Targets { get; set; }

        /// <summary>
        /// ScanName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-scanname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ScanName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace CisScanConfigurationTypes
    {
        public class CisTargets : Humidifier.Base.BaseSubResource, IHaveTargetResourceTags_Json, IHaveStringListOfAccountIds
        {
            /// <summary>
            /// TargetResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-cistargets.html#cfn-inspectorv2-cisscanconfiguration-cistargets-targetresourcetags
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? TargetResourceTags { get; set; }
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-cistargets.html#cfn-inspectorv2-cisscanconfiguration-cistargets-accountids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AccountIds { get; set; }
        }

        public class DailySchedule : Humidifier.Base.BaseSubResource, IHaveInspectorV2CisScanConfigurationTypesTimeStartTime
        {
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-dailyschedule.html#cfn-inspectorv2-cisscanconfiguration-dailyschedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Time
            /// </summary>
            public Union<Humidifier.InspectorV2.CisScanConfigurationTypes.Time, BaseFunction>? StartTime { get; set; }
        }

        public class MonthlySchedule : Humidifier.Base.BaseSubResource, IHaveInspectorV2CisScanConfigurationTypesTimeStartTime, IHaveDay
        {
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-monthlyschedule.html#cfn-inspectorv2-cisscanconfiguration-monthlyschedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Time
            /// </summary>
            public Union<Humidifier.InspectorV2.CisScanConfigurationTypes.Time, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-monthlyschedule.html#cfn-inspectorv2-cisscanconfiguration-monthlyschedule-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Day { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource, IHaveInspectorV2CisScanConfigurationTypesDailyScheduleDaily, IHaveInspectorV2CisScanConfigurationTypesMonthlyScheduleMonthly, IHaveInspectorV2CisScanConfigurationTypesWeeklyScheduleWeekly, IHaveOneTime_Json
        {
            /// <summary>
            /// Daily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-schedule.html#cfn-inspectorv2-cisscanconfiguration-schedule-daily
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DailySchedule
            /// </summary>
            public Union<Humidifier.InspectorV2.CisScanConfigurationTypes.DailySchedule, BaseFunction>? Daily { get; set; }
            /// <summary>
            /// Monthly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-schedule.html#cfn-inspectorv2-cisscanconfiguration-schedule-monthly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonthlySchedule
            /// </summary>
            public Union<Humidifier.InspectorV2.CisScanConfigurationTypes.MonthlySchedule, BaseFunction>? Monthly { get; set; }
            /// <summary>
            /// Weekly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-schedule.html#cfn-inspectorv2-cisscanconfiguration-schedule-weekly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WeeklySchedule
            /// </summary>
            public Union<Humidifier.InspectorV2.CisScanConfigurationTypes.WeeklySchedule, BaseFunction>? Weekly { get; set; }
            /// <summary>
            /// OneTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-schedule.html#cfn-inspectorv2-cisscanconfiguration-schedule-onetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? OneTime { get; set; }
        }

        public class Time : Humidifier.Base.BaseSubResource, IHaveTimeOfDay, IHaveTimeZone
        {
            /// <summary>
            /// TimeOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-time.html#cfn-inspectorv2-cisscanconfiguration-time-timeofday
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeOfDay { get; set; }
            /// <summary>
            /// TimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-time.html#cfn-inspectorv2-cisscanconfiguration-time-timezone
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimeZone { get; set; }
        }

        public class WeeklySchedule : Humidifier.Base.BaseSubResource, IHaveStringListOfDays, IHaveInspectorV2CisScanConfigurationTypesTimeStartTime
        {
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-weeklyschedule.html#cfn-inspectorv2-cisscanconfiguration-weeklyschedule-days
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Days { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-weeklyschedule.html#cfn-inspectorv2-cisscanconfiguration-weeklyschedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Time
            /// </summary>
            public Union<Humidifier.InspectorV2.CisScanConfigurationTypes.Time, BaseFunction>? StartTime { get; set; }
        }
    }
}