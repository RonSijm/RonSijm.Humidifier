namespace Humidifier.EventsV2
{
    using global::System.Collections.Generic;
    using EventSourceTypes;

    public class EventSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveEventsV2EventSourceTypesEventSourceConfigurationConfiguration, IHaveName, IHaveEventBusArn
    {
        public class Attributes
        {
            public static string Revoked =  "Revoked" ;
            public static string State =  "State" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string EventSourceArn =  "EventSourceArn" ;
        }

        public override string AWSTypeName { get => AWS.EventsV2.EventSource; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventsource.html#cfn-eventsv2-eventsource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventsource.html#cfn-eventsv2-eventsource-configuration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: EventSourceConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventsource.html#cfn-eventsv2-eventsource-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// EventBusArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-eventsv2-eventsource.html#cfn-eventsv2-eventsource-eventbusarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EventBusArn { get; set; }
    }

    namespace EventSourceTypes
    {
        public class AwsServiceEventsConfiguration : Humidifier.Base.BaseSubResource, IHaveAwsService, IHavePattern, IHaveEventsV2EventSourceTypesOnFailureConfigurationOnFailureConfiguration
        {
            /// <summary>
            /// AwsService
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-awsserviceeventsconfiguration.html#cfn-eventsv2-eventsource-awsserviceeventsconfiguration-awsservice
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsService { get; set; }
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-awsserviceeventsconfiguration.html#cfn-eventsv2-eventsource-awsserviceeventsconfiguration-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
            /// <summary>
            /// OnFailureConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-awsserviceeventsconfiguration.html#cfn-eventsv2-eventsource-awsserviceeventsconfiguration-onfailureconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnFailureConfiguration
            /// </summary>
            public Union<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration, BaseFunction>? OnFailureConfiguration { get; set; }
        }

        public class EventSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveEventsV2EventSourceTypesAwsServiceEventsConfigurationAwsServiceEventsConfiguration, IHaveEventsV2EventSourceTypesPartnerEventsConfigurationPartnerEventsConfiguration
        {
            /// <summary>
            /// AwsServiceEventsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-eventsourceconfiguration.html#cfn-eventsv2-eventsource-eventsourceconfiguration-awsserviceeventsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsServiceEventsConfiguration
            /// </summary>
            public Union<Humidifier.EventsV2.EventSourceTypes.AwsServiceEventsConfiguration, BaseFunction>? AwsServiceEventsConfiguration { get; set; }
            /// <summary>
            /// PartnerEventsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-eventsourceconfiguration.html#cfn-eventsv2-eventsource-eventsourceconfiguration-partnereventsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PartnerEventsConfiguration
            /// </summary>
            public Union<Humidifier.EventsV2.EventSourceTypes.PartnerEventsConfiguration, BaseFunction>? PartnerEventsConfiguration { get; set; }
        }

        public class OnFailureConfiguration : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-onfailureconfiguration.html#cfn-eventsv2-eventsource-onfailureconfiguration-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class PartnerEventsConfiguration : Humidifier.Base.BaseSubResource, IHavePattern, IHaveEventsV2EventSourceTypesOnFailureConfigurationOnFailureConfiguration, IHavePartnerEventSourceArn, IHavePartnerBusKmsKeyIdentifier
        {
            /// <summary>
            /// Pattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-partnereventsconfiguration.html#cfn-eventsv2-eventsource-partnereventsconfiguration-pattern
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Pattern { get; set; }
            /// <summary>
            /// OnFailureConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-partnereventsconfiguration.html#cfn-eventsv2-eventsource-partnereventsconfiguration-onfailureconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnFailureConfiguration
            /// </summary>
            public Union<Humidifier.EventsV2.EventSourceTypes.OnFailureConfiguration, BaseFunction>? OnFailureConfiguration { get; set; }
            /// <summary>
            /// PartnerEventSourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-partnereventsconfiguration.html#cfn-eventsv2-eventsource-partnereventsconfiguration-partnereventsourcearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartnerEventSourceArn { get; set; }
            /// <summary>
            /// PartnerBusKmsKeyIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-eventsv2-eventsource-partnereventsconfiguration.html#cfn-eventsv2-eventsource-partnereventsconfiguration-partnerbuskmskeyidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PartnerBusKmsKeyIdentifier { get; set; }
        }
    }
}