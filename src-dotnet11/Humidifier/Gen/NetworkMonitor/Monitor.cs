namespace Humidifier.NetworkMonitor
{
    using global::System.Collections.Generic;

    public class Monitor : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAggregationPeriod_Integer, IHaveMonitorName
    {
        public class Attributes
        {
            public static string ModifiedAt =  "ModifiedAt" ;
            public static string MonitorArn =  "MonitorArn" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.NetworkMonitor.Monitor; }
        /// <summary>
        /// AggregationPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-monitor.html#cfn-networkmonitor-monitor-aggregationperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AggregationPeriod { get; set; }
        public Union<string, BaseFunction>? MonitorName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmonitor-monitor.html#cfn-networkmonitor-monitor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}