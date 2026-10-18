namespace Humidifier.Oam
{
    using global::System.Collections.Generic;
    using LinkTypes;

    public class Link : Humidifier.Base.BaseResource, IHaveSinkIdentifier, IHaveLabelTemplate, IHaveStringListOfResourceTypes, IHaveOamLinkTypesLinkConfigurationLinkConfiguration, IHaveStringDictionaryOfTags
    {
        public class Attributes
        {
            public static string Label =  "Label" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Oam.Link; }

        /// <summary>
        /// SinkIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-sinkidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SinkIdentifier { get; set; }
        /// <summary>
        /// LabelTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-labeltemplate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LabelTemplate { get; set; }

        /// <summary>
        /// ResourceTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-resourcetypes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResourceTypes { get; set; }
        /// <summary>
        /// LinkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-linkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LinkConfiguration
        /// </summary>
        public Union<Humidifier.Oam.LinkTypes.LinkConfiguration, BaseFunction>? LinkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LinkTypes
    {
        public class LinkConfiguration : Humidifier.Base.BaseSubResource, IHaveOamLinkTypesLinkFilterLogGroupConfiguration, IHaveOamLinkTypesLinkFilterMetricConfiguration
        {
            /// <summary>
            /// LogGroupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-oam-link-linkconfiguration.html#cfn-oam-link-linkconfiguration-loggroupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinkFilter
            /// </summary>
            public Union<Humidifier.Oam.LinkTypes.LinkFilter, BaseFunction>? LogGroupConfiguration { get; set; }
            /// <summary>
            /// MetricConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-oam-link-linkconfiguration.html#cfn-oam-link-linkconfiguration-metricconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinkFilter
            /// </summary>
            public Union<Humidifier.Oam.LinkTypes.LinkFilter, BaseFunction>? MetricConfiguration { get; set; }
        }

        public class LinkFilter : Humidifier.Base.BaseSubResource, IHaveFilter
        {
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-oam-link-linkfilter.html#cfn-oam-link-linkfilter-filter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Filter { get; set; }
        }
    }
}