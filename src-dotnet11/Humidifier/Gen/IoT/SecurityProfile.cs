namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using SecurityProfileTypes;

    public class SecurityProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfIoTSecurityProfileTypesMetricToRetainAdditionalMetricsToRetainV2, IHaveIoTSecurityProfileTypesMetricsExportConfigMetricsExportConfig, IHaveSecurityProfileDescription, IHaveListOfIoTSecurityProfileTypesBehaviorBehaviors, IHaveSecurityProfileName, IHaveMapOfIoTSecurityProfileTypesAlertTargetAlertTargets, IHaveStringListOfTargetArns, IHaveDescription
    {
        public class Attributes
        {
            public static string SecurityProfileArn =  "SecurityProfileArn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.SecurityProfile; }
        /// <summary>
        /// AdditionalMetricsToRetainV2
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-securityprofile.html#cfn-iot-securityprofile-additionalmetricstoretainv2
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricToRetain
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoT.SecurityProfileTypes.MetricToRetain>, IReadOnlyList<Union<Humidifier.IoT.SecurityProfileTypes.MetricToRetain, BaseFunction>>, BaseFunction>? AdditionalMetricsToRetainV2 { get; set; }
        /// <summary>
        /// MetricsExportConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-securityprofile.html#cfn-iot-securityprofile-metricsexportconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MetricsExportConfig
        /// </summary>
        public Union<Humidifier.IoT.SecurityProfileTypes.MetricsExportConfig, BaseFunction>? MetricsExportConfig { get; set; }
        /// <summary>
        /// SecurityProfileDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-securityprofile.html#cfn-iot-securityprofile-securityprofiledescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SecurityProfileDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => SecurityProfileDescription; set => SecurityProfileDescription = value; }
        /// <summary>
        /// Behaviors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-securityprofile.html#cfn-iot-securityprofile-behaviors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Behavior
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoT.SecurityProfileTypes.Behavior>, IReadOnlyList<Union<Humidifier.IoT.SecurityProfileTypes.Behavior, BaseFunction>>, BaseFunction>? Behaviors { get; set; }
        public Union<string, BaseFunction>? SecurityProfileName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AlertTargets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-securityprofile.html#cfn-iot-securityprofile-alerttargets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// ItemType: AlertTarget
        /// </summary>
        public Union<IReadOnlyDictionary<string, Humidifier.IoT.SecurityProfileTypes.AlertTarget>, IReadOnlyDictionary<string, Union<Humidifier.IoT.SecurityProfileTypes.AlertTarget, BaseFunction>>, BaseFunction>? AlertTargets { get; set; }
        /// <summary>
        /// TargetArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-securityprofile.html#cfn-iot-securityprofile-targetarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TargetArns { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-securityprofile.html#cfn-iot-securityprofile-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace SecurityProfileTypes
    {
        public class AlertTarget : Humidifier.Base.BaseSubResource, IHaveAlertTargetArn, IHaveRoleArn
        {
            /// <summary>
            /// AlertTargetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-alerttarget.html#cfn-iot-securityprofile-alerttarget-alerttargetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AlertTargetArn { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-alerttarget.html#cfn-iot-securityprofile-alerttarget-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class Behavior : Humidifier.Base.BaseSubResource, IHaveExportMetric_Boolean, IHaveSuppressAlerts_Boolean, IHaveMetric, IHaveIoTSecurityProfileTypesBehaviorCriteriaCriteria, IHaveIoTSecurityProfileTypesMetricDimensionMetricDimension, IHaveName
        {
            /// <summary>
            /// ExportMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behavior.html#cfn-iot-securityprofile-behavior-exportmetric
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExportMetric { get; set; }
            /// <summary>
            /// SuppressAlerts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behavior.html#cfn-iot-securityprofile-behavior-suppressalerts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? SuppressAlerts { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behavior.html#cfn-iot-securityprofile-behavior-metric
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// Criteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behavior.html#cfn-iot-securityprofile-behavior-criteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BehaviorCriteria
            /// </summary>
            public Union<Humidifier.IoT.SecurityProfileTypes.BehaviorCriteria, BaseFunction>? Criteria { get; set; }
            /// <summary>
            /// MetricDimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behavior.html#cfn-iot-securityprofile-behavior-metricdimension
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricDimension
            /// </summary>
            public Union<Humidifier.IoT.SecurityProfileTypes.MetricDimension, BaseFunction>? MetricDimension { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behavior.html#cfn-iot-securityprofile-behavior-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class BehaviorCriteria : Humidifier.Base.BaseSubResource, IHaveComparisonOperator, IHaveIoTSecurityProfileTypesMachineLearningDetectionConfigMlDetectionConfig, IHaveIoTSecurityProfileTypesMetricValueValue, IHaveIoTSecurityProfileTypesStatisticalThresholdStatisticalThreshold, IHaveDurationSeconds_Integer, IHaveConsecutiveDatapointsToAlarm_Integer, IHaveConsecutiveDatapointsToClear_Integer
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behaviorcriteria.html#cfn-iot-securityprofile-behaviorcriteria-comparisonoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComparisonOperator { get; set; }
            /// <summary>
            /// MlDetectionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behaviorcriteria.html#cfn-iot-securityprofile-behaviorcriteria-mldetectionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MachineLearningDetectionConfig
            /// </summary>
            public Union<Humidifier.IoT.SecurityProfileTypes.MachineLearningDetectionConfig, BaseFunction>? MlDetectionConfig { get; set; }
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behaviorcriteria.html#cfn-iot-securityprofile-behaviorcriteria-value
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricValue
            /// </summary>
            public Union<Humidifier.IoT.SecurityProfileTypes.MetricValue, BaseFunction>? Value { get; set; }
            /// <summary>
            /// StatisticalThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behaviorcriteria.html#cfn-iot-securityprofile-behaviorcriteria-statisticalthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatisticalThreshold
            /// </summary>
            public Union<Humidifier.IoT.SecurityProfileTypes.StatisticalThreshold, BaseFunction>? StatisticalThreshold { get; set; }
            /// <summary>
            /// DurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behaviorcriteria.html#cfn-iot-securityprofile-behaviorcriteria-durationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DurationSeconds { get; set; }
            /// <summary>
            /// ConsecutiveDatapointsToAlarm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behaviorcriteria.html#cfn-iot-securityprofile-behaviorcriteria-consecutivedatapointstoalarm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConsecutiveDatapointsToAlarm { get; set; }
            /// <summary>
            /// ConsecutiveDatapointsToClear
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-behaviorcriteria.html#cfn-iot-securityprofile-behaviorcriteria-consecutivedatapointstoclear
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ConsecutiveDatapointsToClear { get; set; }
        }

        public class MachineLearningDetectionConfig : Humidifier.Base.BaseSubResource, IHaveConfidenceLevel
        {
            /// <summary>
            /// ConfidenceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-machinelearningdetectionconfig.html#cfn-iot-securityprofile-machinelearningdetectionconfig-confidencelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfidenceLevel { get; set; }
        }

        public class MetricDimension : Humidifier.Base.BaseSubResource, IHaveOperator, IHaveDimensionName
        {
            /// <summary>
            /// Operator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricdimension.html#cfn-iot-securityprofile-metricdimension-operator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Operator { get; set; }
            /// <summary>
            /// DimensionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricdimension.html#cfn-iot-securityprofile-metricdimension-dimensionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionName { get; set; }
        }

        public class MetricToRetain : Humidifier.Base.BaseSubResource, IHaveExportMetric_Boolean, IHaveMetric, IHaveIoTSecurityProfileTypesMetricDimensionMetricDimension
        {
            /// <summary>
            /// ExportMetric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metrictoretain.html#cfn-iot-securityprofile-metrictoretain-exportmetric
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExportMetric { get; set; }
            /// <summary>
            /// Metric
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metrictoretain.html#cfn-iot-securityprofile-metrictoretain-metric
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Metric { get; set; }
            /// <summary>
            /// MetricDimension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metrictoretain.html#cfn-iot-securityprofile-metrictoretain-metricdimension
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricDimension
            /// </summary>
            public Union<Humidifier.IoT.SecurityProfileTypes.MetricDimension, BaseFunction>? MetricDimension { get; set; }
        }

        public class MetricValue : Humidifier.Base.BaseSubResource, IHaveDoubleListOfNumbers, IHaveNumber_Double, IHaveIntegerListOfPorts, IHaveCount, IHaveStringListOfStrings, IHaveStringListOfCidrs
        {
            /// <summary>
            /// Numbers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricvalue.html#cfn-iot-securityprofile-metricvalue-numbers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Double
            /// </summary>
            public Union<IReadOnlyList<double>, IReadOnlyList<Union<double, BaseFunction>>, BaseFunction>? Numbers { get; set; }
            /// <summary>
            /// Number
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricvalue.html#cfn-iot-securityprofile-metricvalue-number
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Number { get; set; }
            /// <summary>
            /// Ports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricvalue.html#cfn-iot-securityprofile-metricvalue-ports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? Ports { get; set; }
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricvalue.html#cfn-iot-securityprofile-metricvalue-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Count { get; set; }
            /// <summary>
            /// Strings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricvalue.html#cfn-iot-securityprofile-metricvalue-strings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Strings { get; set; }
            /// <summary>
            /// Cidrs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricvalue.html#cfn-iot-securityprofile-metricvalue-cidrs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Cidrs { get; set; }
        }

        public class MetricsExportConfig : Humidifier.Base.BaseSubResource, IHaveMqttTopic, IHaveRoleArn
        {
            /// <summary>
            /// MqttTopic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricsexportconfig.html#cfn-iot-securityprofile-metricsexportconfig-mqtttopic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MqttTopic { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-metricsexportconfig.html#cfn-iot-securityprofile-metricsexportconfig-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class StatisticalThreshold : Humidifier.Base.BaseSubResource, IHaveStatistic
        {
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-securityprofile-statisticalthreshold.html#cfn-iot-securityprofile-statisticalthreshold-statistic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statistic { get; set; }
        }
    }
}