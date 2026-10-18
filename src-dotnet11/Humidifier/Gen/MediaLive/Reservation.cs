namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using ReservationTypes;

    public class Reservation : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string UsagePrice =  "UsagePrice" ;
            public static string Start =  "Start" ;
            public static string Count =  "Count" ;
            public static string Name =  "Name" ;
            public static string CurrencyCode =  "CurrencyCode" ;
            public static string RenewalSettings =  "RenewalSettings" ;
            public static string ReservationId =  "ReservationId" ;
            public static string OfferingId =  "OfferingId" ;
            public static string Tags =  "Tags" ;
            public static string FixedPrice =  "FixedPrice" ;
            public static string Duration =  "Duration" ;
            public static string DurationUnits =  "DurationUnits" ;
            public static string ResourceSpecification =  "ResourceSpecification" ;
            public static string OfferingType =  "OfferingType" ;
            public static string State =  "State" ;
            public static string OfferingDescription =  "OfferingDescription" ;
            public static string Region =  "Region" ;
            public static string End =  "End" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Reservation; }
    }

    namespace ReservationTypes
    {
        public class RenewalSettings : Humidifier.Base.BaseSubResource, IHaveRenewalCount_Integer, IHaveAutomaticRenewal
        {
            /// <summary>
            /// RenewalCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-renewalsettings.html#cfn-medialive-reservation-renewalsettings-renewalcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RenewalCount { get; set; }
            /// <summary>
            /// AutomaticRenewal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-renewalsettings.html#cfn-medialive-reservation-renewalsettings-automaticrenewal
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AutomaticRenewal { get; set; }
        }

        public class ReservationResourceSpecification : Humidifier.Base.BaseSubResource, IHaveChannelClass, IHaveCodec, IHaveVideoQuality, IHaveMaximumBitrate, IHaveSpecialFeature, IHaveResourceType, IHaveMaximumFramerate, IHaveResolution
        {
            /// <summary>
            /// ChannelClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-reservationresourcespecification.html#cfn-medialive-reservation-reservationresourcespecification-channelclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelClass { get; set; }
            /// <summary>
            /// Codec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-reservationresourcespecification.html#cfn-medialive-reservation-reservationresourcespecification-codec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Codec { get; set; }
            /// <summary>
            /// VideoQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-reservationresourcespecification.html#cfn-medialive-reservation-reservationresourcespecification-videoquality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoQuality { get; set; }
            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-reservationresourcespecification.html#cfn-medialive-reservation-reservationresourcespecification-maximumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaximumBitrate { get; set; }
            /// <summary>
            /// SpecialFeature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-reservationresourcespecification.html#cfn-medialive-reservation-reservationresourcespecification-specialfeature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SpecialFeature { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-reservationresourcespecification.html#cfn-medialive-reservation-reservationresourcespecification-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
            /// <summary>
            /// MaximumFramerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-reservationresourcespecification.html#cfn-medialive-reservation-reservationresourcespecification-maximumframerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MaximumFramerate { get; set; }
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-reservation-reservationresourcespecification.html#cfn-medialive-reservation-reservationresourcespecification-resolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Resolution { get; set; }
        }
    }
}