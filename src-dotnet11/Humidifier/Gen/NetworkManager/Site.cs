namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;
    using SiteTypes;

    public class Site : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveGlobalNetworkId, IHaveNetworkManagerSiteTypesLocationLocation
    {
        public class Attributes
        {
            public static string SiteId =  "SiteId" ;
            public static string SiteArn =  "SiteArn" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.Site; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-site.html#cfn-networkmanager-site-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// GlobalNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-site.html#cfn-networkmanager-site-globalnetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GlobalNetworkId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-site.html#cfn-networkmanager-site-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-site.html#cfn-networkmanager-site-location
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Location
        /// </summary>
        public Union<Humidifier.NetworkManager.SiteTypes.Location, BaseFunction>? Location { get; set; }
    }

    namespace SiteTypes
    {
        public class Location : Humidifier.Base.BaseSubResource, IHaveAddress, IHaveLatitude, IHaveLongitude
        {
            /// <summary>
            /// Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-site-location.html#cfn-networkmanager-site-location-address
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Address { get; set; }
            /// <summary>
            /// Latitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-site-location.html#cfn-networkmanager-site-location-latitude
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Latitude { get; set; }
            /// <summary>
            /// Longitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-site-location.html#cfn-networkmanager-site-location-longitude
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Longitude { get; set; }
        }
    }
}