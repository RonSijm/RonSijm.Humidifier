namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using OfferingTypes;

    public class Offering : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string CurrencyCode =  "CurrencyCode" ;
            public static string OfferingArn =  "OfferingArn" ;
            public static string OfferingDescription =  "OfferingDescription" ;
            public static string Duration =  "Duration" ;
            public static string DurationUnits =  "DurationUnits" ;
            public static string PricePerUnit =  "PricePerUnit" ;
            public static string ResourceSpecification =  "ResourceSpecification" ;
            public static string PriceUnits =  "PriceUnits" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.Offering; }
    }

    namespace OfferingTypes
    {
        public class ResourceSpecification : Humidifier.Base.BaseSubResource, IHaveReservedBitrate_Integer, IHaveResourceType
        {
            /// <summary>
            /// ReservedBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-offering-resourcespecification.html#cfn-mediaconnect-offering-resourcespecification-reservedbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReservedBitrate { get; set; }
            /// <summary>
            /// ResourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-offering-resourcespecification.html#cfn-mediaconnect-offering-resourcespecification-resourcetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceType { get; set; }
        }
    }
}