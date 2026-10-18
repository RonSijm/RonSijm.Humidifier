namespace Humidifier.Location
{
    using global::System.Collections.Generic;
    using PlaceIndexTypes;

    public class PlaceIndex : Humidifier.Base.BaseResource, IHaveTags, IHaveIndexName, IHaveDescription, IHavePricingPlan, IHaveLocationPlaceIndexTypesDataSourceConfigurationDataSourceConfiguration, IHaveDataSource
    {
        public class Attributes
        {
            public static string IndexArn =  "IndexArn" ;
            public static string CreateTime =  "CreateTime" ;
            public static string UpdateTime =  "UpdateTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Location.PlaceIndex; }

        /// <summary>
        /// IndexName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-placeindex.html#cfn-location-placeindex-indexname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IndexName { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-placeindex.html#cfn-location-placeindex-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// PricingPlan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-placeindex.html#cfn-location-placeindex-pricingplan
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PricingPlan { get; set; }
        /// <summary>
        /// DataSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-placeindex.html#cfn-location-placeindex-datasourceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: DataSourceConfiguration
        /// </summary>
        public Union<Humidifier.Location.PlaceIndexTypes.DataSourceConfiguration, BaseFunction>? DataSourceConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-placeindex.html#cfn-location-placeindex-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// DataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-location-placeindex.html#cfn-location-placeindex-datasource
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataSource { get; set; }
    }

    namespace PlaceIndexTypes
    {
        public class DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveIntendedUse
        {
            /// <summary>
            /// IntendedUse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-location-placeindex-datasourceconfiguration.html#cfn-location-placeindex-datasourceconfiguration-intendeduse
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IntendedUse { get; set; }
        }
    }
}