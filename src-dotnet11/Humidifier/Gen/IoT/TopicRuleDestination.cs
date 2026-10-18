namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using TopicRuleDestinationTypes;

    public class TopicRuleDestination : Humidifier.Base.BaseResource, IHaveStatus, IHaveIoTTopicRuleDestinationTypesHttpUrlDestinationSummaryHttpUrlProperties, IHaveIoTTopicRuleDestinationTypesVpcDestinationPropertiesVpcProperties, IHaveIoTTopicRuleDestinationTypesInfluxDBDestinationPropertiesInfluxDBProperties
    {
        public class Attributes
        {
            public static string StatusReason =  "StatusReason" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IoT.TopicRuleDestination; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicruledestination.html#cfn-iot-topicruledestination-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }
        /// <summary>
        /// HttpUrlProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicruledestination.html#cfn-iot-topicruledestination-httpurlproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: HttpUrlDestinationSummary
        /// </summary>
        public Union<Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary, BaseFunction>? HttpUrlProperties { get; set; }
        /// <summary>
        /// VpcProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicruledestination.html#cfn-iot-topicruledestination-vpcproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcDestinationProperties
        /// </summary>
        public Union<Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties, BaseFunction>? VpcProperties { get; set; }
        /// <summary>
        /// InfluxDBProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicruledestination.html#cfn-iot-topicruledestination-influxdbproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InfluxDBDestinationProperties
        /// </summary>
        public Union<Humidifier.IoT.TopicRuleDestinationTypes.InfluxDBDestinationProperties, BaseFunction>? InfluxDBProperties { get; set; }
    }

    namespace TopicRuleDestinationTypes
    {
        public class HttpUrlDestinationSummary : Humidifier.Base.BaseSubResource, IHaveConfirmationUrl
        {
            /// <summary>
            /// ConfirmationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-httpurldestinationsummary.html#cfn-iot-topicruledestination-httpurldestinationsummary-confirmationurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfirmationUrl { get; set; }
        }

        public class InfluxDBDestinationProperties : Humidifier.Base.BaseSubResource, IHaveSecretKey, IHaveInfluxDBVersion, IHaveEndpoint, IHaveSecretType, IHaveSecretId
        {
            /// <summary>
            /// SecretKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-secretkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretKey { get; set; }
            /// <summary>
            /// InfluxDBVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-influxdbversion
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InfluxDBVersion { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-endpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// SecretType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-secrettype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretType { get; set; }
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-secretid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretId { get; set; }
        }

        public class VpcDestinationProperties : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroups, IHaveVpcId, IHaveStringListOfSubnetIds, IHaveRoleArn
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html#cfn-iot-topicruledestination-vpcdestinationproperties-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroups { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html#cfn-iot-topicruledestination-vpcdestinationproperties-vpcid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcId { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html#cfn-iot-topicruledestination-vpcdestinationproperties-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html#cfn-iot-topicruledestination-vpcdestinationproperties-rolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}