namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using LoggingTypes;

    public class Logging : Humidifier.Base.BaseResource, IHaveRoleArn, IHaveAccountId
    {
        public override string AWSTypeName { get => AWS.IoT.Logging; }

        /// <summary>
        /// AccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-logging.html#cfn-iot-logging-accountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AccountId { get; set; }
        /// <summary>
        /// EventConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-logging.html#cfn-iot-logging-eventconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EventConfiguration
        /// </summary>
        public List<Humidifier.IoT.LoggingTypes.EventConfiguration> EventConfigurations { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-logging.html#cfn-iot-logging-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }

        /// <summary>
        /// DefaultLogLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-logging.html#cfn-iot-logging-defaultloglevel
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DefaultLogLevel { get; set; }
    }

    namespace LoggingTypes
    {
        public class EventConfiguration : Humidifier.Base.BaseSubResource, IHaveLogLevel, IHaveEventType, IHaveLogDestination
        {
            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-logging-eventconfiguration.html#cfn-iot-logging-eventconfiguration-eventtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EventType { get; set; }
            /// <summary>
            /// LogDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-logging-eventconfiguration.html#cfn-iot-logging-eventconfiguration-logdestination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogDestination { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-logging-eventconfiguration.html#cfn-iot-logging-eventconfiguration-loglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogLevel { get; set; }
        }
    }
}