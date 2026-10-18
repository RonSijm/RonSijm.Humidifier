namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using InstanceEventWindowTypes;

    public class InstanceEventWindow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfEC2InstanceEventWindowTypesTimeRangeTimeRanges, IHaveCronExpression, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string Arn =  "Arn" ;
            public static string InstanceEventWindowId =  "InstanceEventWindowId" ;
        }

        public override string AWSTypeName { get => AWS.EC2.InstanceEventWindow; }
        /// <summary>
        /// TimeRanges
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceeventwindow.html#cfn-ec2-instanceeventwindow-timeranges
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TimeRange
        /// </summary>
        public Union<IReadOnlyList<Humidifier.EC2.InstanceEventWindowTypes.TimeRange>, IReadOnlyList<Union<Humidifier.EC2.InstanceEventWindowTypes.TimeRange, BaseFunction>>, BaseFunction>? TimeRanges { get; set; }
        /// <summary>
        /// CronExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceeventwindow.html#cfn-ec2-instanceeventwindow-cronexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CronExpression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceeventwindow.html#cfn-ec2-instanceeventwindow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace InstanceEventWindowTypes
    {
        public class TimeRange : Humidifier.Base.BaseSubResource, IHaveStartWeekDay, IHaveStartHour_Integer, IHaveEndHour_Integer, IHaveEndWeekDay
        {
            /// <summary>
            /// StartWeekDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceeventwindow-timerange.html#cfn-ec2-instanceeventwindow-timerange-startweekday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StartWeekDay { get; set; }
            /// <summary>
            /// StartHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceeventwindow-timerange.html#cfn-ec2-instanceeventwindow-timerange-starthour
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? StartHour { get; set; }
            /// <summary>
            /// EndHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceeventwindow-timerange.html#cfn-ec2-instanceeventwindow-timerange-endhour
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? EndHour { get; set; }
            /// <summary>
            /// EndWeekDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceeventwindow-timerange.html#cfn-ec2-instanceeventwindow-timerange-endweekday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndWeekDay { get; set; }
        }
    }
}