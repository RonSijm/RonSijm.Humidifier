namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using HoursOfOperationTypes;

    public class HoursOfOperation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTimeZone, IHaveDescription, IHaveListOfConnectHoursOfOperationTypesHoursOfOperationConfigConfig, IHaveInstanceArn, IHaveListOfConnectHoursOfOperationTypesHoursOfOperationsIdentifierChildHoursOfOperations, IHaveListOfConnectHoursOfOperationTypesHoursOfOperationsIdentifierParentHoursOfOperations, IHaveListOfConnectHoursOfOperationTypesHoursOfOperationOverrideHoursOfOperationOverrides, IHaveName
    {
        public class Attributes
        {
            public static string HoursOfOperationArn =  "HoursOfOperationArn" ;
        }

        public override string AWSTypeName { get => AWS.Connect.HoursOfOperation; }

        /// <summary>
        /// TimeZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-timezone
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TimeZone { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Config
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-config
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HoursOfOperationConfig
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig>, IReadOnlyList<Union<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig, BaseFunction>>, BaseFunction>? Config { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// ChildHoursOfOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-childhoursofoperations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HoursOfOperationsIdentifier
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier>, IReadOnlyList<Union<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier, BaseFunction>>, BaseFunction>? ChildHoursOfOperations { get; set; }
        /// <summary>
        /// ParentHoursOfOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-parenthoursofoperations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HoursOfOperationsIdentifier
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier>, IReadOnlyList<Union<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier, BaseFunction>>, BaseFunction>? ParentHoursOfOperations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// HoursOfOperationOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-hoursofoperationoverrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HoursOfOperationOverride
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride>, IReadOnlyList<Union<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride, BaseFunction>>, BaseFunction>? HoursOfOperationOverrides { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace HoursOfOperationTypes
    {
        public class HoursOfOperationConfig : Humidifier.Base.BaseSubResource, IHaveConnectHoursOfOperationTypesHoursOfOperationTimeSliceEndTime, IHaveConnectHoursOfOperationTypesHoursOfOperationTimeSliceStartTime, IHaveDay
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationconfig.html#cfn-connect-hoursofoperation-hoursofoperationconfig-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HoursOfOperationTimeSlice
            /// </summary>
            public Union<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationconfig.html#cfn-connect-hoursofoperation-hoursofoperationconfig-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HoursOfOperationTimeSlice
            /// </summary>
            public Union<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationconfig.html#cfn-connect-hoursofoperation-hoursofoperationconfig-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Day { get; set; }
        }

        public class HoursOfOperationOverride : Humidifier.Base.BaseSubResource, IHaveConnectHoursOfOperationTypesRecurrenceConfigRecurrenceConfig, IHaveHoursOfOperationOverrideId, IHaveListOfConnectHoursOfOperationTypesHoursOfOperationOverrideConfigOverrideConfig, IHaveOverrideType, IHaveEffectiveFrom, IHaveOverrideName, IHaveOverrideDescription, IHaveEffectiveTill
        {
            /// <summary>
            /// RecurrenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-recurrenceconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RecurrenceConfig
            /// </summary>
            public Union<Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig, BaseFunction>? RecurrenceConfig { get; set; }
            /// <summary>
            /// HoursOfOperationOverrideId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-hoursofoperationoverrideid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HoursOfOperationOverrideId { get; set; }
            /// <summary>
            /// OverrideConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-overrideconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HoursOfOperationOverrideConfig
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverrideConfig>, IReadOnlyList<Union<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverrideConfig, BaseFunction>>, BaseFunction>? OverrideConfig { get; set; }
            /// <summary>
            /// OverrideType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-overridetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OverrideType { get; set; }
            /// <summary>
            /// EffectiveFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-effectivefrom
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EffectiveFrom { get; set; }
            /// <summary>
            /// OverrideName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-overridename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OverrideName { get; set; }
            /// <summary>
            /// OverrideDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-overridedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OverrideDescription { get; set; }
            /// <summary>
            /// EffectiveTill
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-effectivetill
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EffectiveTill { get; set; }
        }

        public class HoursOfOperationOverrideConfig : Humidifier.Base.BaseSubResource, IHaveConnectHoursOfOperationTypesOverrideTimeSliceEndTime, IHaveConnectHoursOfOperationTypesOverrideTimeSliceStartTime, IHaveDay
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverrideconfig.html#cfn-connect-hoursofoperation-hoursofoperationoverrideconfig-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OverrideTimeSlice
            /// </summary>
            public Union<Humidifier.Connect.HoursOfOperationTypes.OverrideTimeSlice, BaseFunction>? EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverrideconfig.html#cfn-connect-hoursofoperation-hoursofoperationoverrideconfig-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OverrideTimeSlice
            /// </summary>
            public Union<Humidifier.Connect.HoursOfOperationTypes.OverrideTimeSlice, BaseFunction>? StartTime { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverrideconfig.html#cfn-connect-hoursofoperation-hoursofoperationoverrideconfig-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Day { get; set; }
        }

        public class HoursOfOperationTimeSlice : Humidifier.Base.BaseSubResource, IHaveHours_Integer, IHaveMinutes_Integer
        {
            /// <summary>
            /// Hours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationtimeslice.html#cfn-connect-hoursofoperation-hoursofoperationtimeslice-hours
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Hours { get; set; }
            /// <summary>
            /// Minutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationtimeslice.html#cfn-connect-hoursofoperation-hoursofoperationtimeslice-minutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Minutes { get; set; }
        }

        public class HoursOfOperationsIdentifier : Humidifier.Base.BaseSubResource, IHaveId, IHaveName
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationsidentifier.html#cfn-connect-hoursofoperation-hoursofoperationsidentifier-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationsidentifier.html#cfn-connect-hoursofoperation-hoursofoperationsidentifier-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OverrideTimeSlice : Humidifier.Base.BaseSubResource, IHaveHours_Integer, IHaveMinutes_Integer
        {
            /// <summary>
            /// Hours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-overridetimeslice.html#cfn-connect-hoursofoperation-overridetimeslice-hours
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Hours { get; set; }
            /// <summary>
            /// Minutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-overridetimeslice.html#cfn-connect-hoursofoperation-overridetimeslice-minutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Minutes { get; set; }
        }

        public class RecurrenceConfig : Humidifier.Base.BaseSubResource, IHaveConnectHoursOfOperationTypesRecurrencePatternRecurrencePattern
        {
            /// <summary>
            /// RecurrencePattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrenceconfig.html#cfn-connect-hoursofoperation-recurrenceconfig-recurrencepattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RecurrencePattern
            /// </summary>
            public Union<Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern, BaseFunction>? RecurrencePattern { get; set; }
        }

        public class RecurrencePattern : Humidifier.Base.BaseSubResource, IHaveFrequency, IHaveIntegerListOfByWeekdayOccurrence, IHaveIntegerListOfByMonthDay, IHaveInterval_Integer, IHaveIntegerListOfByMonth
        {
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-frequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Frequency { get; set; }
            /// <summary>
            /// ByWeekdayOccurrence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-byweekdayoccurrence
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? ByWeekdayOccurrence { get; set; }
            /// <summary>
            /// ByMonthDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-bymonthday
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? ByMonthDay { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Interval { get; set; }
            /// <summary>
            /// ByMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-bymonth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? ByMonth { get; set; }
        }
    }
}