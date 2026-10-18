namespace Humidifier.Scheduler
{
    using global::System.Collections.Generic;

    public class ScheduleGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveName
    {
        public class Attributes
        {
            public static string CreationDate =  "CreationDate" ;
            public static string State =  "State" ;
            public static string LastModificationDate =  "LastModificationDate" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Scheduler.ScheduleGroup; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scheduler-schedulegroup.html#cfn-scheduler-schedulegroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}