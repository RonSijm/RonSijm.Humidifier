namespace Humidifier.InternetMonitor
{
    using global::System.Collections.Generic;
    using InternetEventTypes;

    public class InternetEvent : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ClientLocation =  "ClientLocation" ;
            public static string EventType =  "EventType" ;
            public static string EventStatus =  "EventStatus" ;
            public static string EventArn =  "EventArn" ;
            public static string EventId =  "EventId" ;
            public static string StartedAt =  "StartedAt" ;
            public static string EndedAt =  "EndedAt" ;
        }

        public override string AWSTypeName { get => AWS.InternetMonitor.InternetEvent; }
    }

    namespace InternetEventTypes
    {
        public class ClientLocation : Humidifier.Base.BaseSubResource, IHaveASNumber_Integer, IHaveMetro, IHaveCountry, IHaveLatitude_Double, IHaveSubdivision, IHaveCity, IHaveASName, IHaveLongitude_Double
        {
            /// <summary>
            /// ASNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-asnumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ASNumber { get; set; }
            /// <summary>
            /// Metro
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-metro
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Metro { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-country
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Country { get; set; }
            /// <summary>
            /// Latitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-latitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Latitude { get; set; }
            /// <summary>
            /// Subdivision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-subdivision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Subdivision { get; set; }
            /// <summary>
            /// City
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-city
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? City { get; set; }
            /// <summary>
            /// ASName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-asname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ASName { get; set; }
            /// <summary>
            /// Longitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-longitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Longitude { get; set; }
        }
    }
}