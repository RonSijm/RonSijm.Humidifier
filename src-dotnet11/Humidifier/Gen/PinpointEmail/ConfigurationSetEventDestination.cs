namespace Humidifier.PinpointEmail
{
    using global::System.Collections.Generic;
    using ConfigurationSetEventDestinationTypes;

    public class ConfigurationSetEventDestination : Humidifier.Base.BaseResource, IHaveEventDestinationName, IHaveConfigurationSetName, IHavePinpointEmailConfigurationSetEventDestinationTypesEventDestinationEventDestination
    {
        public override string AWSTypeName { get => AWS.PinpointEmail.ConfigurationSetEventDestination; }

        /// <summary>
        /// EventDestinationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationseteventdestination.html#cfn-pinpointemail-configurationseteventdestination-eventdestinationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EventDestinationName { get; set; }

        /// <summary>
        /// ConfigurationSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationseteventdestination.html#cfn-pinpointemail-configurationseteventdestination-configurationsetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConfigurationSetName { get; set; }
        /// <summary>
        /// EventDestination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-configurationseteventdestination.html#cfn-pinpointemail-configurationseteventdestination-eventdestination
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EventDestination
        /// </summary>
        public Union<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.EventDestination, BaseFunction>? EventDestination { get; set; }
    }

    namespace ConfigurationSetEventDestinationTypes
    {
        public class CloudWatchDestination : Humidifier.Base.BaseSubResource, IHaveListOfPinpointEmailConfigurationSetEventDestinationTypesDimensionConfigurationDimensionConfigurations
        {
            /// <summary>
            /// DimensionConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-cloudwatchdestination.html#cfn-pinpointemail-configurationseteventdestination-cloudwatchdestination-dimensionconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.DimensionConfiguration>, IReadOnlyList<Union<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.DimensionConfiguration, BaseFunction>>, BaseFunction>? DimensionConfigurations { get; set; }
        }

        public class DimensionConfiguration : Humidifier.Base.BaseSubResource, IHaveDimensionValueSource, IHaveDefaultDimensionValue, IHaveDimensionName
        {
            /// <summary>
            /// DimensionValueSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-dimensionconfiguration.html#cfn-pinpointemail-configurationseteventdestination-dimensionconfiguration-dimensionvaluesource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionValueSource { get; set; }
            /// <summary>
            /// DefaultDimensionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-dimensionconfiguration.html#cfn-pinpointemail-configurationseteventdestination-dimensionconfiguration-defaultdimensionvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultDimensionValue { get; set; }
            /// <summary>
            /// DimensionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-dimensionconfiguration.html#cfn-pinpointemail-configurationseteventdestination-dimensionconfiguration-dimensionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionName { get; set; }
        }

        public class EventDestination : Humidifier.Base.BaseSubResource, IHavePinpointEmailConfigurationSetEventDestinationTypesSnsDestinationSnsDestination, IHavePinpointEmailConfigurationSetEventDestinationTypesCloudWatchDestinationCloudWatchDestination, IHaveEnabled_Boolean, IHaveStringListOfMatchingEventTypes, IHavePinpointEmailConfigurationSetEventDestinationTypesPinpointDestinationPinpointDestination, IHavePinpointEmailConfigurationSetEventDestinationTypesKinesisFirehoseDestinationKinesisFirehoseDestination
        {
            /// <summary>
            /// SnsDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-eventdestination.html#cfn-pinpointemail-configurationseteventdestination-eventdestination-snsdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnsDestination
            /// </summary>
            public Union<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.SnsDestination, BaseFunction>? SnsDestination { get; set; }
            /// <summary>
            /// CloudWatchDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-eventdestination.html#cfn-pinpointemail-configurationseteventdestination-eventdestination-cloudwatchdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchDestination
            /// </summary>
            public Union<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.CloudWatchDestination, BaseFunction>? CloudWatchDestination { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-eventdestination.html#cfn-pinpointemail-configurationseteventdestination-eventdestination-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// MatchingEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-eventdestination.html#cfn-pinpointemail-configurationseteventdestination-eventdestination-matchingeventtypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchingEventTypes { get; set; }
            /// <summary>
            /// PinpointDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-eventdestination.html#cfn-pinpointemail-configurationseteventdestination-eventdestination-pinpointdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PinpointDestination
            /// </summary>
            public Union<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.PinpointDestination, BaseFunction>? PinpointDestination { get; set; }
            /// <summary>
            /// KinesisFirehoseDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-eventdestination.html#cfn-pinpointemail-configurationseteventdestination-eventdestination-kinesisfirehosedestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseDestination
            /// </summary>
            public Union<Humidifier.PinpointEmail.ConfigurationSetEventDestinationTypes.KinesisFirehoseDestination, BaseFunction>? KinesisFirehoseDestination { get; set; }
        }

        public class KinesisFirehoseDestination : Humidifier.Base.BaseSubResource, IHaveDeliveryStreamArn, IHaveIamRoleArn
        {
            /// <summary>
            /// DeliveryStreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-kinesisfirehosedestination.html#cfn-pinpointemail-configurationseteventdestination-kinesisfirehosedestination-deliverystreamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeliveryStreamArn { get; set; }
            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-kinesisfirehosedestination.html#cfn-pinpointemail-configurationseteventdestination-kinesisfirehosedestination-iamrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamRoleArn { get; set; }
        }

        public class PinpointDestination : Humidifier.Base.BaseSubResource, IHaveApplicationArn
        {
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-pinpointdestination.html#cfn-pinpointemail-configurationseteventdestination-pinpointdestination-applicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationArn { get; set; }
        }

        public class SnsDestination : Humidifier.Base.BaseSubResource, IHaveTopicArn
        {
            /// <summary>
            /// TopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationseteventdestination-snsdestination.html#cfn-pinpointemail-configurationseteventdestination-snsdestination-topicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TopicArn { get; set; }
        }
    }
}