namespace Humidifier.Connect
{
    using System.Collections.Generic;
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
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-connect-hoursofoperation.html#cfn-connect-hoursofoperation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
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
        public class HoursOfOperationConfig : Humidifier.Base.BaseSubResource
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

        public class HoursOfOperationOverrideConfig : Humidifier.Base.BaseSubResource
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

        public class HoursOfOperationTimeSlice : Humidifier.Base.BaseSubResource, IHaveMinutes
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

        public class OverrideTimeSlice : Humidifier.Base.BaseSubResource, IHaveMinutes
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
    }
}