namespace Humidifier.SSMContacts
{
    using global::System.Collections.Generic;
    using RotationTypes;

    public class Rotation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSSMContactsRotationTypesRecurrenceSettingsRecurrence, IHaveTimeZoneId, IHaveStartTime, IHaveName, IHaveStringListOfContactIds
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SSMContacts.Rotation; }

        /// <summary>
        /// Recurrence
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-rotation.html#cfn-ssmcontacts-rotation-recurrence
        /// Required: True
        /// UpdateType: Mutable
        /// Type: RecurrenceSettings
        /// </summary>
        [Required]
        public Union<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings, BaseFunction>? Recurrence { get; set; }

        /// <summary>
        /// TimeZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-rotation.html#cfn-ssmcontacts-rotation-timezoneid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TimeZoneId { get; set; }

        /// <summary>
        /// StartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-rotation.html#cfn-ssmcontacts-rotation-starttime
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StartTime { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-rotation.html#cfn-ssmcontacts-rotation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// ContactIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssmcontacts-rotation.html#cfn-ssmcontacts-rotation-contactids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContactIds { get; set; }
    }

    namespace RotationTypes
    {
        public class CoverageTime : Humidifier.Base.BaseSubResource, IHaveEndTime, IHaveStartTime
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-coveragetime.html#cfn-ssmcontacts-rotation-coveragetime-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-coveragetime.html#cfn-ssmcontacts-rotation-coveragetime-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartTime { get; set; }
        }

        public class MonthlySetting : Humidifier.Base.BaseSubResource, IHaveDayOfMonth_Integer, IHaveHandOffTime
        {
            /// <summary>
            /// DayOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-monthlysetting.html#cfn-ssmcontacts-rotation-monthlysetting-dayofmonth
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DayOfMonth { get; set; }
            /// <summary>
            /// HandOffTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-monthlysetting.html#cfn-ssmcontacts-rotation-monthlysetting-handofftime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HandOffTime { get; set; }
        }

        public class RecurrenceSettings : Humidifier.Base.BaseSubResource, IHaveStringListOfDailySettings, IHaveNumberOfOnCalls_Integer, IHaveListOfSSMContactsRotationTypesShiftCoverageShiftCoverages, IHaveListOfSSMContactsRotationTypesWeeklySettingWeeklySettings, IHaveRecurrenceMultiplier_Integer, IHaveListOfSSMContactsRotationTypesMonthlySettingMonthlySettings
        {
            /// <summary>
            /// DailySettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-recurrencesettings.html#cfn-ssmcontacts-rotation-recurrencesettings-dailysettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DailySettings { get; set; }
            /// <summary>
            /// NumberOfOnCalls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-recurrencesettings.html#cfn-ssmcontacts-rotation-recurrencesettings-numberofoncalls
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfOnCalls { get; set; }
            /// <summary>
            /// ShiftCoverages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-recurrencesettings.html#cfn-ssmcontacts-rotation-recurrencesettings-shiftcoverages
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ShiftCoverage
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMContacts.RotationTypes.ShiftCoverage>, IReadOnlyList<Union<Humidifier.SSMContacts.RotationTypes.ShiftCoverage, BaseFunction>>, BaseFunction>? ShiftCoverages { get; set; }
            /// <summary>
            /// WeeklySettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-recurrencesettings.html#cfn-ssmcontacts-rotation-recurrencesettings-weeklysettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: WeeklySetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMContacts.RotationTypes.WeeklySetting>, IReadOnlyList<Union<Humidifier.SSMContacts.RotationTypes.WeeklySetting, BaseFunction>>, BaseFunction>? WeeklySettings { get; set; }
            /// <summary>
            /// RecurrenceMultiplier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-recurrencesettings.html#cfn-ssmcontacts-rotation-recurrencesettings-recurrencemultiplier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RecurrenceMultiplier { get; set; }
            /// <summary>
            /// MonthlySettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-recurrencesettings.html#cfn-ssmcontacts-rotation-recurrencesettings-monthlysettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MonthlySetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMContacts.RotationTypes.MonthlySetting>, IReadOnlyList<Union<Humidifier.SSMContacts.RotationTypes.MonthlySetting, BaseFunction>>, BaseFunction>? MonthlySettings { get; set; }
        }

        public class ShiftCoverage : Humidifier.Base.BaseSubResource, IHaveDayOfWeek, IHaveListOfSSMContactsRotationTypesCoverageTimeCoverageTimes
        {
            /// <summary>
            /// DayOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-shiftcoverage.html#cfn-ssmcontacts-rotation-shiftcoverage-dayofweek
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DayOfWeek { get; set; }
            /// <summary>
            /// CoverageTimes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-shiftcoverage.html#cfn-ssmcontacts-rotation-shiftcoverage-coveragetimes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CoverageTime
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SSMContacts.RotationTypes.CoverageTime>, IReadOnlyList<Union<Humidifier.SSMContacts.RotationTypes.CoverageTime, BaseFunction>>, BaseFunction>? CoverageTimes { get; set; }
        }

        public class WeeklySetting : Humidifier.Base.BaseSubResource, IHaveDayOfWeek, IHaveHandOffTime
        {
            /// <summary>
            /// DayOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-weeklysetting.html#cfn-ssmcontacts-rotation-weeklysetting-dayofweek
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DayOfWeek { get; set; }
            /// <summary>
            /// HandOffTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssmcontacts-rotation-weeklysetting.html#cfn-ssmcontacts-rotation-weeklysetting-handofftime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HandOffTime { get; set; }
        }
    }
}