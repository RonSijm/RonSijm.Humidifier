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
        public class ClientLocation : Humidifier.Base.BaseSubResource, IHaveLatitude, IHaveLongitude, IHaveCountry
        {
            /// <summary>
            /// ASNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-asnumber
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ASNumber { get; set; }
            /// <summary>
            /// Metro
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-metro
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Metro { get; set; }
            /// <summary>
            /// Country
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-country
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Country { get; set; }
            /// <summary>
            /// Latitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-latitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Latitude { get; set; }
            /// <summary>
            /// Subdivision
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-subdivision
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Subdivision { get; set; }
            /// <summary>
            /// City
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-city
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic City { get; set; }
            /// <summary>
            /// ASName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-asname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ASName { get; set; }
            /// <summary>
            /// Longitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-internetmonitor-internetevent-clientlocation.html#cfn-internetmonitor-internetevent-clientlocation-longitude
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Longitude { get; set; }
        }
    }
}