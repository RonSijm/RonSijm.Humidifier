namespace Humidifier.GroundStation
{
    using global::System.Collections.Generic;
    using SatelliteTypes;

    public class Satellite : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string GroundStations =  "GroundStations" ;
            public static string CurrentEphemeris =  "CurrentEphemeris" ;
            public static string SatelliteId =  "SatelliteId" ;
            public static string Arn =  "Arn" ;
            public static string NoradSatelliteID =  "NoradSatelliteID" ;
            public static string Tags =  "Tags" ;
        }

        public override string AWSTypeName { get => AWS.GroundStation.Satellite; }
    }

    namespace SatelliteTypes
    {
        public class EphemerisMetaData : Humidifier.Base.BaseSubResource, IHaveEpoch, IHaveSource
        {
            /// <summary>
            /// Epoch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-satellite-ephemerismetadata.html#cfn-groundstation-satellite-ephemerismetadata-epoch
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Epoch { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-groundstation-satellite-ephemerismetadata.html#cfn-groundstation-satellite-ephemerismetadata-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Source { get; set; }
        }
    }
}