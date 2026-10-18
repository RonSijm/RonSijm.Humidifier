namespace Humidifier.Pinpoint
{
    using global::System.Collections.Generic;
    using SegmentTypes;

    public class Segment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHavePinpointSegmentTypesSegmentGroupsSegmentGroups, IHavePinpointSegmentTypesSegmentDimensionsDimensions, IHaveApplicationId, IHaveTags_Json, IHaveName
    {
        public class Attributes
        {
            public static string SegmentId =  "SegmentId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Pinpoint.Segment; }
        /// <summary>
        /// SegmentGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-segment.html#cfn-pinpoint-segment-segmentgroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SegmentGroups
        /// </summary>
        public Union<Humidifier.Pinpoint.SegmentTypes.SegmentGroups, BaseFunction>? SegmentGroups { get; set; }
        /// <summary>
        /// Dimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-segment.html#cfn-pinpoint-segment-dimensions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SegmentDimensions
        /// </summary>
        public Union<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions, BaseFunction>? Dimensions { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-segment.html#cfn-pinpoint-segment-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-segment.html#cfn-pinpoint-segment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace SegmentTypes
    {
        public class AttributeDimension : Humidifier.Base.BaseSubResource, IHaveAttributeType, IHaveStringListOfValues
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-attributedimension.html#cfn-pinpoint-segment-attributedimension-attributetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AttributeType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-attributedimension.html#cfn-pinpoint-segment-attributedimension-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class Behavior : Humidifier.Base.BaseSubResource, IHavePinpointSegmentTypesRecencyRecency
        {
            /// <summary>
            /// Recency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior.html#cfn-pinpoint-segment-segmentdimensions-behavior-recency
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Recency
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.Recency, BaseFunction>? Recency { get; set; }
        }

        public class Coordinates : Humidifier.Base.BaseSubResource, IHaveLatitude_Double, IHaveLongitude_Double
        {
            /// <summary>
            /// Latitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates-latitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Latitude { get; set; }
            /// <summary>
            /// Longitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates-longitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Longitude { get; set; }
        }

        public class Demographic : Humidifier.Base.BaseSubResource, IHavePinpointSegmentTypesSetDimensionAppVersion, IHavePinpointSegmentTypesSetDimensionDeviceType, IHavePinpointSegmentTypesSetDimensionPlatform, IHavePinpointSegmentTypesSetDimensionChannel, IHavePinpointSegmentTypesSetDimensionModel, IHavePinpointSegmentTypesSetDimensionMake
        {
            /// <summary>
            /// AppVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-appversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.SetDimension, BaseFunction>? AppVersion { get; set; }
            /// <summary>
            /// DeviceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-devicetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.SetDimension, BaseFunction>? DeviceType { get; set; }
            /// <summary>
            /// Platform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-platform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.SetDimension, BaseFunction>? Platform { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-channel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.SetDimension, BaseFunction>? Channel { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-model
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.SetDimension, BaseFunction>? Model { get; set; }
            /// <summary>
            /// Make
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-make
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.SetDimension, BaseFunction>? Make { get; set; }
        }

        public class GPSPoint : Humidifier.Base.BaseSubResource, IHaveRangeInKilometers_Double, IHavePinpointSegmentTypesCoordinatesCoordinates
        {
            /// <summary>
            /// RangeInKilometers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint-rangeinkilometers
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RangeInKilometers { get; set; }
            /// <summary>
            /// Coordinates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Coordinates
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.Coordinates, BaseFunction>? Coordinates { get; set; }
        }

        public class Groups : Humidifier.Base.BaseSubResource, IHaveType, IHaveSourceType, IHaveListOfPinpointSegmentTypesSegmentDimensionsDimensions, IHaveListOfPinpointSegmentTypesSourceSegmentsSourceSegments
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html#cfn-pinpoint-segment-segmentgroups-groups-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html#cfn-pinpoint-segment-segmentgroups-groups-sourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html#cfn-pinpoint-segment-segmentgroups-groups-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SegmentDimensions
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions>, IReadOnlyList<Union<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions, BaseFunction>>, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// SourceSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html#cfn-pinpoint-segment-segmentgroups-groups-sourcesegments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SourceSegments
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pinpoint.SegmentTypes.SourceSegments>, IReadOnlyList<Union<Humidifier.Pinpoint.SegmentTypes.SourceSegments, BaseFunction>>, BaseFunction>? SourceSegments { get; set; }
        }

        public class Location : Humidifier.Base.BaseSubResource, IHavePinpointSegmentTypesGPSPointGPSPoint, IHavePinpointSegmentTypesSetDimensionCountry
        {
            /// <summary>
            /// GPSPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GPSPoint
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.GPSPoint, BaseFunction>? GPSPoint { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location.html#cfn-pinpoint-segment-segmentdimensions-location-country
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.SetDimension, BaseFunction>? Country { get; set; }
        }

        public class Recency : Humidifier.Base.BaseSubResource, IHaveDuration, IHaveRecencyType
        {
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior-recency.html#cfn-pinpoint-segment-segmentdimensions-behavior-recency-duration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Duration { get; set; }
            /// <summary>
            /// RecencyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior-recency.html#cfn-pinpoint-segment-segmentdimensions-behavior-recency-recencytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RecencyType { get; set; }
        }

        public class SegmentDimensions : Humidifier.Base.BaseSubResource, IHavePinpointSegmentTypesDemographicDemographic, IHaveMetrics_Json, IHaveAttributes__Json, IHavePinpointSegmentTypesBehaviorBehavior, IHaveUserAttributes_Json, IHavePinpointSegmentTypesLocationLocation
        {
            /// <summary>
            /// Demographic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-demographic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Demographic
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.Demographic, BaseFunction>? Demographic { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Metrics { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Attributes_ { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Behavior
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.Behavior, BaseFunction>? Behavior { get; set; }
            /// <summary>
            /// UserAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-userattributes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? UserAttributes { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Location
            /// </summary>
            public Union<Humidifier.Pinpoint.SegmentTypes.Location, BaseFunction>? Location { get; set; }
        }

        public class SegmentGroups : Humidifier.Base.BaseSubResource, IHaveListOfPinpointSegmentTypesGroupsGroups, IHaveInclude
        {
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups.html#cfn-pinpoint-segment-segmentgroups-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Groups
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Pinpoint.SegmentTypes.Groups>, IReadOnlyList<Union<Humidifier.Pinpoint.SegmentTypes.Groups, BaseFunction>>, BaseFunction>? Groups { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups.html#cfn-pinpoint-segment-segmentgroups-include
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Include { get; set; }
        }

        public class SetDimension : Humidifier.Base.BaseSubResource, IHaveDimensionType, IHaveStringListOfValues
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-setdimension.html#cfn-pinpoint-segment-setdimension-dimensiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DimensionType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-setdimension.html#cfn-pinpoint-segment-setdimension-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class SourceSegments : Humidifier.Base.BaseSubResource, IHaveVersion_Integer, IHaveId
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups-sourcesegments.html#cfn-pinpoint-segment-segmentgroups-groups-sourcesegments-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups-sourcesegments.html#cfn-pinpoint-segment-segmentgroups-groups-sourcesegments-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
        }
    }
}