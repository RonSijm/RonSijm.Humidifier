namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using TopicRuleDestinationTypes;

    public class TopicRuleDestination : Humidifier.Base.BaseResource, IHaveStatus
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
        public dynamic Status { get; set; }
        /// <summary>
        /// HttpUrlProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicruledestination.html#cfn-iot-topicruledestination-httpurlproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: HttpUrlDestinationSummary
        /// </summary>
        public Humidifier.IoT.TopicRuleDestinationTypes.HttpUrlDestinationSummary HttpUrlProperties { get; set; }
        /// <summary>
        /// VpcProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicruledestination.html#cfn-iot-topicruledestination-vpcproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcDestinationProperties
        /// </summary>
        public Humidifier.IoT.TopicRuleDestinationTypes.VpcDestinationProperties VpcProperties { get; set; }
        /// <summary>
        /// InfluxDBProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-topicruledestination.html#cfn-iot-topicruledestination-influxdbproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InfluxDBDestinationProperties
        /// </summary>
        public Humidifier.IoT.TopicRuleDestinationTypes.InfluxDBDestinationProperties InfluxDBProperties { get; set; }
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
            public dynamic ConfirmationUrl { get; set; }
        }

        public class InfluxDBDestinationProperties : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveSecretId, IHaveSecretKey
        {
            /// <summary>
            /// SecretKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-secretkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretKey { get; set; }
            /// <summary>
            /// InfluxDBVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-influxdbversion
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InfluxDBVersion { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-endpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// SecretType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-secrettype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretType { get; set; }
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-influxdbdestinationproperties.html#cfn-iot-topicruledestination-influxdbdestinationproperties-secretid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretId { get; set; }
        }

        public class VpcDestinationProperties : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveSubnetIds, IHaveVpcId, IHaveSecurityGroups
        {
            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html#cfn-iot-topicruledestination-vpcdestinationproperties-securitygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups { get; set; }
            /// <summary>
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html#cfn-iot-topicruledestination-vpcdestinationproperties-vpcid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html#cfn-iot-topicruledestination-vpcdestinationproperties-subnetids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicruledestination-vpcdestinationproperties.html#cfn-iot-topicruledestination-vpcdestinationproperties-rolearn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }
    }
}