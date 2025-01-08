namespace Humidifier.Oam
{
    using System.Collections.Generic;
    using LinkTypes;

    public class Link : Humidifier.Base.BaseResource, IHaveResourceTypes
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
        public dynamic SinkIdentifier { get; set; }
        /// <summary>
        /// LabelTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-labeltemplate
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LabelTemplate { get; set; }

        /// <summary>
        /// ResourceTypes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-resourcetypes
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic ResourceTypes { get; set; }
        /// <summary>
        /// LinkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-linkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LinkConfiguration
        /// </summary>
        public Humidifier.Oam.LinkTypes.LinkConfiguration LinkConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-oam-link.html#cfn-oam-link-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
    }

    namespace LinkTypes
    {
        public class LinkConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LogGroupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-oam-link-linkconfiguration.html#cfn-oam-link-linkconfiguration-loggroupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinkFilter
            /// </summary>
            public Humidifier.Oam.LinkTypes.LinkFilter LogGroupConfiguration { get; set; }
            /// <summary>
            /// MetricConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-oam-link-linkconfiguration.html#cfn-oam-link-linkconfiguration-metricconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinkFilter
            /// </summary>
            public Humidifier.Oam.LinkTypes.LinkFilter MetricConfiguration { get; set; }
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
            public dynamic Filter { get; set; }
        }
    }
}