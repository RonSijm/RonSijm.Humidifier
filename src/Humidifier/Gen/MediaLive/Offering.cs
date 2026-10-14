namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using OfferingTypes;

    public class Offering : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string UsagePrice =  "UsagePrice" ;
            public static string Duration =  "Duration" ;
            public static string DurationUnits =  "DurationUnits" ;
            public static string ResourceSpecification =  "ResourceSpecification" ;
            public static string CurrencyCode =  "CurrencyCode" ;
            public static string OfferingType =  "OfferingType" ;
            public static string OfferingDescription =  "OfferingDescription" ;
            public static string Region =  "Region" ;
            public static string Arn =  "Arn" ;
            public static string OfferingId =  "OfferingId" ;
            public static string FixedPrice =  "FixedPrice" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Offering; }
    }

    namespace OfferingTypes
    {
        public class ReservationResourceSpecification : Humidifier.Base.BaseSubResource, IHaveResourceType, IHaveResolution, IHaveMaximumBitrate
        {
            /// <summary>
            /// ChannelClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-offering-reservationresourcespecification.html#cfn-medialive-offering-reservationresourcespecification-channelclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelClass { get; set; }
            /// <summary>
            /// Codec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-offering-reservationresourcespecification.html#cfn-medialive-offering-reservationresourcespecification-codec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Codec { get; set; }
            /// <summary>
            /// VideoQuality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-offering-reservationresourcespecification.html#cfn-medialive-offering-reservationresourcespecification-videoquality
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VideoQuality { get; set; }
            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-offering-reservationresourcespecification.html#cfn-medialive-offering-reservationresourcespecification-maximumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaximumBitrate { get; set; }
            /// <summary>
            /// SpecialFeature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-offering-reservationresourcespecification.html#cfn-medialive-offering-reservationresourcespecification-specialfeature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpecialFeature { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-offering-reservationresourcespecification.html#cfn-medialive-offering-reservationresourcespecification-resourcetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceType { get; set; }
            /// <summary>
            /// MaximumFramerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-offering-reservationresourcespecification.html#cfn-medialive-offering-reservationresourcespecification-maximumframerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaximumFramerate { get; set; }
            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-offering-reservationresourcespecification.html#cfn-medialive-offering-reservationresourcespecification-resolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resolution { get; set; }
        }
    }
}