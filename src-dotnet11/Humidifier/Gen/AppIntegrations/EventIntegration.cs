namespace Humidifier.AppIntegrations
{
    using global::System.Collections.Generic;
    using EventIntegrationTypes;

    public class EventIntegration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveEventBridgeBus, IHaveAppIntegrationsEventIntegrationTypesEventFilterEventFilter, IHaveName
    {
        public class Attributes
        {
            public static string EventIntegrationArn =  "EventIntegrationArn" ;
        }

        public override string AWSTypeName { get => AWS.AppIntegrations.EventIntegration; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-eventintegration.html#cfn-appintegrations-eventintegration-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// EventBridgeBus
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-eventintegration.html#cfn-appintegrations-eventintegration-eventbridgebus
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EventBridgeBus { get; set; }

        /// <summary>
        /// EventFilter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-eventintegration.html#cfn-appintegrations-eventintegration-eventfilter
        /// Required: True
        /// UpdateType: Immutable
        /// Type: EventFilter
        /// </summary>
        [Required]
        public Union<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter, BaseFunction>? EventFilter { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-eventintegration.html#cfn-appintegrations-eventintegration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace EventIntegrationTypes
    {
        public class EventFilter : Humidifier.Base.BaseSubResource, IHaveSource
        {
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-eventintegration-eventfilter.html#cfn-appintegrations-eventintegration-eventfilter-source
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }
    }
}