namespace Humidifier.Redshift
{
    using global::System.Collections.Generic;

    public class SnapshotSchedule : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string AssociatedClusterCount =  "AssociatedClusterCount" ;
        }

        public override string AWSTypeName { get => AWS.Redshift.SnapshotSchedule; }
        /// <summary>
        /// ScheduleDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-snapshotschedule.html#cfn-redshift-snapshotschedule-scheduledescription
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ScheduleDescription { get; set; }

        /// <summary>
        /// ScheduleDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-snapshotschedule.html#cfn-redshift-snapshotschedule-scheduledefinitions
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ScheduleDefinitions { get; set; }

        /// <summary>
        /// ScheduleIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-snapshotschedule.html#cfn-redshift-snapshotschedule-scheduleidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ScheduleIdentifier { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-snapshotschedule.html#cfn-redshift-snapshotschedule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }
}