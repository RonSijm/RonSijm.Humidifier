namespace Humidifier.IoT
{
    using System.Collections.Generic;

    public class ScheduledAudit : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDayOfWeek, IHaveFrequency, IHaveDayOfMonth
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
        public dynamic DayOfWeek { get; set; }

        /// <summary>
        /// TargetCheckNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-targetchecknames
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic TargetCheckNames { get; set; }
        public dynamic ScheduledAuditName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DayOfMonth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-dayofmonth
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DayOfMonth { get; set; }

        /// <summary>
        /// Frequency
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-frequency
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Frequency { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-scheduledaudit.html#cfn-iot-scheduledaudit-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}