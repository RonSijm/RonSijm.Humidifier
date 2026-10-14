namespace Humidifier.EC2
{
    using global::System.Collections.Generic;
    using InstanceEventWindowTypes;

    public class InstanceEventWindow : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveCronExpression
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
        public List<Humidifier.EC2.InstanceEventWindowTypes.TimeRange> TimeRanges { get; set; }
        /// <summary>
        /// CronExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceeventwindow.html#cfn-ec2-instanceeventwindow-cronexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CronExpression { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-instanceeventwindow.html#cfn-ec2-instanceeventwindow-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace InstanceEventWindowTypes
    {
        public class TimeRange : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StartWeekDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceeventwindow-timerange.html#cfn-ec2-instanceeventwindow-timerange-startweekday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartWeekDay { get; set; }
            /// <summary>
            /// StartHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceeventwindow-timerange.html#cfn-ec2-instanceeventwindow-timerange-starthour
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StartHour { get; set; }
            /// <summary>
            /// EndHour
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceeventwindow-timerange.html#cfn-ec2-instanceeventwindow-timerange-endhour
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EndHour { get; set; }
            /// <summary>
            /// EndWeekDay
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instanceeventwindow-timerange.html#cfn-ec2-instanceeventwindow-timerange-endweekday
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndWeekDay { get; set; }
        }
    }
}