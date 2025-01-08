namespace Humidifier.Pinpoint
{
    using System.Collections.Generic;
    using SegmentTypes;

    public class Segment : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDynamicTags, IHaveApplicationId
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
        public Humidifier.Pinpoint.SegmentTypes.SegmentGroups SegmentGroups { get; set; }
        /// <summary>
        /// Dimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-segment.html#cfn-pinpoint-segment-dimensions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SegmentDimensions
        /// </summary>
        public Humidifier.Pinpoint.SegmentTypes.SegmentDimensions Dimensions { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-segment.html#cfn-pinpoint-segment-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ApplicationId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-segment.html#cfn-pinpoint-segment-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace SegmentTypes
    {
        public class AttributeDimension : Humidifier.Base.BaseSubResource, IHaveValues, IHaveAttributeType
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-attributedimension.html#cfn-pinpoint-segment-attributedimension-attributetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-attributedimension.html#cfn-pinpoint-segment-attributedimension-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class Behavior : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Recency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior.html#cfn-pinpoint-segment-segmentdimensions-behavior-recency
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Recency
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.Recency Recency { get; set; }
        }

        public class Coordinates : Humidifier.Base.BaseSubResource, IHaveLatitude, IHaveLongitude
        {
            /// <summary>
            /// Latitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates-latitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Latitude { get; set; }
            /// <summary>
            /// Longitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates-longitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Longitude { get; set; }
        }

        public class Demographic : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AppVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-appversion
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.SetDimension AppVersion { get; set; }
            /// <summary>
            /// DeviceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-devicetype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.SetDimension DeviceType { get; set; }
            /// <summary>
            /// Platform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-platform
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.SetDimension Platform { get; set; }
            /// <summary>
            /// Channel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-channel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.SetDimension Channel { get; set; }
            /// <summary>
            /// Model
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-model
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.SetDimension Model { get; set; }
            /// <summary>
            /// Make
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-demographic.html#cfn-pinpoint-segment-segmentdimensions-demographic-make
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.SetDimension Make { get; set; }
        }

        public class GPSPoint : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RangeInKilometers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint-rangeinkilometers
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RangeInKilometers { get; set; }
            /// <summary>
            /// Coordinates
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location-gpspoint.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint-coordinates
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Coordinates
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.Coordinates Coordinates { get; set; }
        }

        public class Groups : Humidifier.Base.BaseSubResource, IHaveType, IHaveSourceType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html#cfn-pinpoint-segment-segmentgroups-groups-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html#cfn-pinpoint-segment-segmentgroups-groups-sourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html#cfn-pinpoint-segment-segmentgroups-groups-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SegmentDimensions
            /// </summary>
            public List<Humidifier.Pinpoint.SegmentTypes.SegmentDimensions> Dimensions { get; set; }
            /// <summary>
            /// SourceSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups.html#cfn-pinpoint-segment-segmentgroups-groups-sourcesegments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SourceSegments
            /// </summary>
            public List<Humidifier.Pinpoint.SegmentTypes.SourceSegments> SourceSegments { get; set; }
        }

        public class Location : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GPSPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location.html#cfn-pinpoint-segment-segmentdimensions-location-gpspoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GPSPoint
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.GPSPoint GPSPoint { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-location.html#cfn-pinpoint-segment-segmentdimensions-location-country
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.SetDimension Country { get; set; }
        }

        public class Recency : Humidifier.Base.BaseSubResource, IHaveDuration
        {
            /// <summary>
            /// Duration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior-recency.html#cfn-pinpoint-segment-segmentdimensions-behavior-recency-duration
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Duration { get; set; }
            /// <summary>
            /// RecencyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions-behavior-recency.html#cfn-pinpoint-segment-segmentdimensions-behavior-recency-recencytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecencyType { get; set; }
        }

        public class SegmentDimensions : Humidifier.Base.BaseSubResource, IHaveAttributes_, IHaveMetrics
        {
            /// <summary>
            /// Demographic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-demographic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Demographic
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.Demographic Demographic { get; set; }
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Metrics { get; set; }
            /// <summary>
            /// Attributes_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Attributes_ { get; set; }
            /// <summary>
            /// Behavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-behavior
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Behavior
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.Behavior Behavior { get; set; }
            /// <summary>
            /// UserAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-userattributes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic UserAttributes { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentdimensions.html#cfn-pinpoint-segment-segmentdimensions-location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Location
            /// </summary>
            public Humidifier.Pinpoint.SegmentTypes.Location Location { get; set; }
        }

        public class SegmentGroups : Humidifier.Base.BaseSubResource, IHaveInclude
        {
            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups.html#cfn-pinpoint-segment-segmentgroups-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Groups
            /// </summary>
            public List<Humidifier.Pinpoint.SegmentTypes.Groups> Groups { get; set; }
            /// <summary>
            /// Include
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups.html#cfn-pinpoint-segment-segmentgroups-include
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Include { get; set; }
        }

        public class SetDimension : Humidifier.Base.BaseSubResource, IHaveValues, IHaveDimensionType
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-setdimension.html#cfn-pinpoint-segment-setdimension-dimensiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionType { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-setdimension.html#cfn-pinpoint-segment-setdimension-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values { get; set; }
        }

        public class SourceSegments : Humidifier.Base.BaseSubResource, IHaveId, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups-sourcesegments.html#cfn-pinpoint-segment-segmentgroups-groups-sourcesegments-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-segment-segmentgroups-groups-sourcesegments.html#cfn-pinpoint-segment-segmentgroups-groups-sourcesegments-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id { get; set; }
        }
    }
}