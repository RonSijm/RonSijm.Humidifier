namespace Humidifier.Location
{
    using global::System.Collections.Generic;
    using MapTypes;

    public class Map : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMapName, IHaveDescription, IHaveLocationMapTypesMapConfigurationConfiguration, IHavePricingPlan
    {
        public class Attributes
        {
            public static string CreateTime =  "CreateTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string Arn =  "Arn" ;
            public static string MapArn =  "MapArn" ;
        }

        public override string AWSTypeName { get => AWS.Location.Map; }
        public Union<string, BaseFunction>? MapName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-map.html#cfn-location-map-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-map.html#cfn-location-map-configuration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: MapConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Location.MapTypes.MapConfiguration, BaseFunction>? Configuration { get; set; }
        /// <summary>
        /// PricingPlan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-map.html#cfn-location-map-pricingplan
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PricingPlan { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-map.html#cfn-location-map-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MapTypes
    {
        public class MapConfiguration : Humidifier.Base.BaseSubResource, IHavePoliticalView, IHaveStyle, IHaveStringListOfCustomLayers
        {
            /// <summary>
            /// PoliticalView
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-map-mapconfiguration.html#cfn-location-map-mapconfiguration-politicalview
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PoliticalView { get; set; }
            /// <summary>
            /// Style
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-map-mapconfiguration.html#cfn-location-map-mapconfiguration-style
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Style { get; set; }
            /// <summary>
            /// CustomLayers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-map-mapconfiguration.html#cfn-location-map-mapconfiguration-customlayers
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CustomLayers { get; set; }
        }
    }
}