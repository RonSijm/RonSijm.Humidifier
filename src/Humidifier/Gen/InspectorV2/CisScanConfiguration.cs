namespace Humidifier.InspectorV2
{
    using System.Collections.Generic;
    using CisScanConfigurationTypes;

    public class CisScanConfiguration : Humidifier.Base.BaseResource
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
        public dynamic SecurityLevel { get; set; }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        [Required]
        public Humidifier.InspectorV2.CisScanConfigurationTypes.Schedule Schedule { get; set; }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-targets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CisTargets
        /// </summary>
        [Required]
        public Humidifier.InspectorV2.CisScanConfigurationTypes.CisTargets Targets { get; set; }

        /// <summary>
        /// ScanName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-scanname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ScanName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-cisscanconfiguration.html#cfn-inspectorv2-cisscanconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace CisScanConfigurationTypes
    {
        public class CisTargets : Humidifier.Base.BaseSubResource, IHaveAccountIds
        {
            /// <summary>
            /// TargetResourceTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-cistargets.html#cfn-inspectorv2-cisscanconfiguration-cistargets-targetresourcetags
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic TargetResourceTags { get; set; }
            /// <summary>
            /// AccountIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-cistargets.html#cfn-inspectorv2-cisscanconfiguration-cistargets-accountids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AccountIds { get; set; }
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
            public Humidifier.InspectorV2.CisScanConfigurationTypes.Time StartTime { get; set; }
        }

        public class MonthlySchedule : Humidifier.Base.BaseSubResource, IHaveDay, IHaveInspectorV2CisScanConfigurationTypesTimeStartTime
        {
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-monthlyschedule.html#cfn-inspectorv2-cisscanconfiguration-monthlyschedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Time
            /// </summary>
            public Humidifier.InspectorV2.CisScanConfigurationTypes.Time StartTime { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-monthlyschedule.html#cfn-inspectorv2-cisscanconfiguration-monthlyschedule-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Day { get; set; }
        }

        public class Schedule : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Daily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-schedule.html#cfn-inspectorv2-cisscanconfiguration-schedule-daily
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DailySchedule
            /// </summary>
            public Humidifier.InspectorV2.CisScanConfigurationTypes.DailySchedule Daily { get; set; }
            /// <summary>
            /// Monthly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-schedule.html#cfn-inspectorv2-cisscanconfiguration-schedule-monthly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonthlySchedule
            /// </summary>
            public Humidifier.InspectorV2.CisScanConfigurationTypes.MonthlySchedule Monthly { get; set; }
            /// <summary>
            /// Weekly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-schedule.html#cfn-inspectorv2-cisscanconfiguration-schedule-weekly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WeeklySchedule
            /// </summary>
            public Humidifier.InspectorV2.CisScanConfigurationTypes.WeeklySchedule Weekly { get; set; }
            /// <summary>
            /// OneTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-schedule.html#cfn-inspectorv2-cisscanconfiguration-schedule-onetime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic OneTime { get; set; }
        }

        public class Time : Humidifier.Base.BaseSubResource, IHaveTimeZone, IHaveTimeOfDay
        {
            /// <summary>
            /// TimeOfDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-time.html#cfn-inspectorv2-cisscanconfiguration-time-timeofday
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeOfDay { get; set; }
            /// <summary>
            /// TimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-time.html#cfn-inspectorv2-cisscanconfiguration-time-timezone
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeZone { get; set; }
        }

        public class WeeklySchedule : Humidifier.Base.BaseSubResource, IHaveDays, IHaveInspectorV2CisScanConfigurationTypesTimeStartTime
        {
            /// <summary>
            /// Days
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-weeklyschedule.html#cfn-inspectorv2-cisscanconfiguration-weeklyschedule-days
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Days { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-cisscanconfiguration-weeklyschedule.html#cfn-inspectorv2-cisscanconfiguration-weeklyschedule-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Time
            /// </summary>
            public Humidifier.InspectorV2.CisScanConfigurationTypes.Time StartTime { get; set; }
        }
    }
}