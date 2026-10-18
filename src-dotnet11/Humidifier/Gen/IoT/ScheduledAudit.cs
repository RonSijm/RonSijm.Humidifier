namespace Humidifier.IoT
{
    using global::System.Collections.Generic;

    public class ScheduledAudit : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDayOfWeek, IHaveStringListOfTargetCheckNames, IHaveScheduledAuditName, IHaveDayOfMonth, IHaveFrequency
    {
        public class Attributes
        {
            public static string ScheduledAuditArn =  "ScheduledAuditArn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.ScheduledAudit; }
        /// <summary>
        /// DayOfWeek
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-dayofweek
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DayOfWeek { get; set; }

        /// <summary>
        /// TargetCheckNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-targetchecknames
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetCheckNames { get; set; }
        public Union<string, BaseFunction>? ScheduledAuditName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DayOfMonth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-dayofmonth
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DayOfMonth { get; set; }

        /// <summary>
        /// Frequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-frequency
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Frequency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}