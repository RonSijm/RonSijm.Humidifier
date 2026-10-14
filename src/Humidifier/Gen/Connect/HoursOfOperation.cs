namespace Humidifier.Connect
{
    using global::System.Collections.Generic;
    using HoursOfOperationTypes;

    public class HoursOfOperation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveInstanceArn, IHaveTimeZone
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
        public dynamic TimeZone { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Config
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-config
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HoursOfOperationConfig
        /// </summary>
        [Required]
        public List<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> Config { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-instancearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceArn { get; set; }
        /// <summary>
        /// ChildHoursOfOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-childhoursofoperations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HoursOfOperationsIdentifier
        /// </summary>
        public List<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier> ChildHoursOfOperations { get; set; }
        /// <summary>
        /// ParentHoursOfOperations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-parenthoursofoperations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HoursOfOperationsIdentifier
        /// </summary>
        public List<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationsIdentifier> ParentHoursOfOperations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// HoursOfOperationOverrides
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-hoursofoperationoverrides
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: HoursOfOperationOverride
        /// </summary>
        public List<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverride> HoursOfOperationOverrides { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace HoursOfOperationTypes
    {
        public class HoursOfOperationConfig : Humidifier.Base.BaseSubResource, IHaveDay
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationconfig.html#cfn-connect-hoursofoperation-hoursofoperationconfig-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HoursOfOperationTimeSlice
            /// </summary>
            public Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationconfig.html#cfn-connect-hoursofoperation-hoursofoperationconfig-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: HoursOfOperationTimeSlice
            /// </summary>
            public Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationTimeSlice StartTime { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationconfig.html#cfn-connect-hoursofoperation-hoursofoperationconfig-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Day { get; set; }
        }

        public class HoursOfOperationOverride : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RecurrenceConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-recurrenceconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RecurrenceConfig
            /// </summary>
            public Humidifier.Connect.HoursOfOperationTypes.RecurrenceConfig RecurrenceConfig { get; set; }
            /// <summary>
            /// HoursOfOperationOverrideId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-hoursofoperationoverrideid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HoursOfOperationOverrideId { get; set; }
            /// <summary>
            /// OverrideConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-overrideconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HoursOfOperationOverrideConfig
            /// </summary>
            public List<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationOverrideConfig> OverrideConfig { get; set; }
            /// <summary>
            /// OverrideType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-overridetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverrideType { get; set; }
            /// <summary>
            /// EffectiveFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-effectivefrom
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EffectiveFrom { get; set; }
            /// <summary>
            /// OverrideName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-overridename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverrideName { get; set; }
            /// <summary>
            /// OverrideDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-overridedescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OverrideDescription { get; set; }
            /// <summary>
            /// EffectiveTill
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverride.html#cfn-connect-hoursofoperation-hoursofoperationoverride-effectivetill
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EffectiveTill { get; set; }
        }

        public class HoursOfOperationOverrideConfig : Humidifier.Base.BaseSubResource, IHaveDay
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverrideconfig.html#cfn-connect-hoursofoperation-hoursofoperationoverrideconfig-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OverrideTimeSlice
            /// </summary>
            public Humidifier.Connect.HoursOfOperationTypes.OverrideTimeSlice EndTime { get; set; }
            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverrideconfig.html#cfn-connect-hoursofoperation-hoursofoperationoverrideconfig-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OverrideTimeSlice
            /// </summary>
            public Humidifier.Connect.HoursOfOperationTypes.OverrideTimeSlice StartTime { get; set; }
            /// <summary>
            /// Day
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationoverrideconfig.html#cfn-connect-hoursofoperation-hoursofoperationoverrideconfig-day
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Day { get; set; }
        }

        public class HoursOfOperationTimeSlice : Humidifier.Base.BaseSubResource, IHaveMinutes, IHaveHours
        {
            /// <summary>
            /// Hours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationtimeslice.html#cfn-connect-hoursofoperation-hoursofoperationtimeslice-hours
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Hours { get; set; }
            /// <summary>
            /// Minutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationtimeslice.html#cfn-connect-hoursofoperation-hoursofoperationtimeslice-minutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Minutes { get; set; }
        }

        public class HoursOfOperationsIdentifier : Humidifier.Base.BaseSubResource, IHaveName, IHaveId
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationsidentifier.html#cfn-connect-hoursofoperation-hoursofoperationsidentifier-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-hoursofoperationsidentifier.html#cfn-connect-hoursofoperation-hoursofoperationsidentifier-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class OverrideTimeSlice : Humidifier.Base.BaseSubResource, IHaveMinutes, IHaveHours
        {
            /// <summary>
            /// Hours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-overridetimeslice.html#cfn-connect-hoursofoperation-overridetimeslice-hours
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Hours { get; set; }
            /// <summary>
            /// Minutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-overridetimeslice.html#cfn-connect-hoursofoperation-overridetimeslice-minutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Minutes { get; set; }
        }

        public class RecurrenceConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RecurrencePattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrenceconfig.html#cfn-connect-hoursofoperation-recurrenceconfig-recurrencepattern
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RecurrencePattern
            /// </summary>
            public Humidifier.Connect.HoursOfOperationTypes.RecurrencePattern RecurrencePattern { get; set; }
        }

        public class RecurrencePattern : Humidifier.Base.BaseSubResource, IHaveInterval, IHaveFrequency
        {
            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-frequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Frequency { get; set; }
            /// <summary>
            /// ByWeekdayOccurrence
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-byweekdayoccurrence
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> ByWeekdayOccurrence { get; set; }
            /// <summary>
            /// ByMonthDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-bymonthday
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> ByMonthDay { get; set; }
            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-interval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Interval { get; set; }
            /// <summary>
            /// ByMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-connect-hoursofoperation-recurrencepattern.html#cfn-connect-hoursofoperation-recurrencepattern-bymonth
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> ByMonth { get; set; }
        }
    }
}