namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using ReservationTypes;

    public class Reservation : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string ReservationState =  "ReservationState" ;
            public static string Start =  "Start" ;
            public static string Duration =  "Duration" ;
            public static string DurationUnits =  "DurationUnits" ;
            public static string ResourceSpecification =  "ResourceSpecification" ;
            public static string PriceUnits =  "PriceUnits" ;
            public static string CurrencyCode =  "CurrencyCode" ;
            public static string ReservationArn =  "ReservationArn" ;
            public static string OfferingArn =  "OfferingArn" ;
            public static string OfferingDescription =  "OfferingDescription" ;
            public static string ReservationName =  "ReservationName" ;
            public static string End =  "End" ;
            public static string PricePerUnit =  "PricePerUnit" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.Reservation; }
    }

    namespace ReservationTypes
    {
        public class ResourceSpecification : Humidifier.Base.BaseSubResource, IHaveResourceType
        {
            /// <summary>
            /// ReservedBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-reservation-resourcespecification.html#cfn-mediaconnect-reservation-resourcespecification-reservedbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReservedBitrate { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-reservation-resourcespecification.html#cfn-mediaconnect-reservation-resourcespecification-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
        }
    }
}