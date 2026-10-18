namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using FleetMetricTypes;

    public class FleetMetric : Humidifier.Base.BaseResource, IHaveTags, IHaveIndexName, IHaveMetricName, IHaveDescription, IHaveQueryString, IHavePeriod_Integer, IHaveQueryVersion, IHaveUnit, IHaveIoTFleetMetricTypesAggregationTypeAggregationType, IHaveAggregationField
    {
        public class Attributes
        {
            public static string MetricArn =  "MetricArn" ;
            public static string CreationDate =  "CreationDate" ;
            public static string LastModifiedDate =  "LastModifiedDate" ;
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName { get => AWS.IoT.FleetMetric; }
        /// <summary>
        /// IndexName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-indexname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IndexName { get; set; }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-metricname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MetricName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// QueryString
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-querystring
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? QueryString { get; set; }
        /// <summary>
        /// Period
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-period
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Period { get; set; }
        /// <summary>
        /// QueryVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-queryversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? QueryVersion { get; set; }
        /// <summary>
        /// Unit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-unit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Unit { get; set; }
        /// <summary>
        /// AggregationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-aggregationtype
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AggregationType
        /// </summary>
        public Union<Humidifier.IoT.FleetMetricTypes.AggregationType, BaseFunction>? AggregationType { get; set; }
        /// <summary>
        /// AggregationField
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-aggregationfield
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AggregationField { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-fleetmetric.html#cfn-iot-fleetmetric-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FleetMetricTypes
    {
        public class AggregationType : Humidifier.Base.BaseSubResource, IHaveStringListOfValues, IHaveName
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-fleetmetric-aggregationtype.html#cfn-iot-fleetmetric-aggregationtype-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-fleetmetric-aggregationtype.html#cfn-iot-fleetmetric-aggregationtype-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }
    }
}