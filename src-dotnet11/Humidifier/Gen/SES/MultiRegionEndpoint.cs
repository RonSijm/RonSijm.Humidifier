namespace Humidifier.SES
{
    using global::System.Collections.Generic;
    using MultiRegionEndpointTypes;

    public class MultiRegionEndpoint : Humidifier.Base.BaseResource, IHaveTags, IHaveSESMultiRegionEndpointTypesDetailsDetails, IHaveEndpointName
    {
        public override string AWSTypeName { get => AWS.SES.MultiRegionEndpoint; }

        /// <summary>
        /// Details
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-multiregionendpoint.html#cfn-ses-multiregionendpoint-details
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Details
        /// </summary>
        [Required]
        public Union<Humidifier.SES.MultiRegionEndpointTypes.Details, BaseFunction>? Details { get; set; }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-multiregionendpoint.html#cfn-ses-multiregionendpoint-endpointname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? EndpointName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-multiregionendpoint.html#cfn-ses-multiregionendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MultiRegionEndpointTypes
    {
        public class Details : Humidifier.Base.BaseSubResource, IHaveListOfSESMultiRegionEndpointTypesRouteDetailsItemsRouteDetails
        {
            /// <summary>
            /// RouteDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-multiregionendpoint-details.html#cfn-ses-multiregionendpoint-details-routedetails
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RouteDetailsItems
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SES.MultiRegionEndpointTypes.RouteDetailsItems>, IReadOnlyList<Union<Humidifier.SES.MultiRegionEndpointTypes.RouteDetailsItems, BaseFunction>>, BaseFunction>? RouteDetails { get; set; }
        }

        public class RouteDetailsItems : Humidifier.Base.BaseSubResource, IHaveRegion
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-multiregionendpoint-routedetailsitems.html#cfn-ses-multiregionendpoint-routedetailsitems-region
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }
    }
}