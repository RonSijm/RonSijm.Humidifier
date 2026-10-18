namespace Humidifier.Lightsail
{
    using global::System.Collections.Generic;

    public class Alarm : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMetricName, IHaveComparisonOperator, IHaveTreatMissingData, IHaveAlarmName, IHaveStringListOfContactProtocols, IHaveMonitoredResourceName, IHaveEvaluationPeriods_Integer, IHaveNotificationEnabled_Boolean, IHaveDatapointsToAlarm_Integer, IHaveStringListOfNotificationTriggers, IHaveThreshold_Double
    {
        public class Attributes
        {
            public static string AlarmArn =  "AlarmArn" ;
            public static string State =  "State" ;
        }

        public override string AWSTypeName { get => AWS.Lightsail.Alarm; }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-metricname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MetricName { get; set; }

        /// <summary>
        /// ComparisonOperator
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-comparisonoperator
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ComparisonOperator { get; set; }
        /// <summary>
        /// TreatMissingData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-treatmissingdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TreatMissingData { get; set; }
        public Union<string, BaseFunction>? AlarmName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ContactProtocols
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-contactprotocols
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ContactProtocols { get; set; }

        /// <summary>
        /// MonitoredResourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-monitoredresourcename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MonitoredResourceName { get; set; }

        /// <summary>
        /// EvaluationPeriods
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-evaluationperiods
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? EvaluationPeriods { get; set; }
        /// <summary>
        /// NotificationEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-notificationenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NotificationEnabled { get; set; }
        /// <summary>
        /// DatapointsToAlarm
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-datapointstoalarm
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DatapointsToAlarm { get; set; }
        /// <summary>
        /// NotificationTriggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-notificationtriggers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NotificationTriggers { get; set; }

        /// <summary>
        /// Threshold
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lightsail-alarm.html#cfn-lightsail-alarm-threshold
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        [Required]
        public Union<double, BaseFunction>? Threshold { get; set; }
    }
}