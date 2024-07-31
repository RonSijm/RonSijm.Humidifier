namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using MultiplexTypes;

    public class Multiplex : Humidifier.Base.BaseResource, IHaveImpliedResourceName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string ProgramCount =  "ProgramCount" ;
            public static string PipelinesRunningCount =  "PipelinesRunningCount" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::MediaLive::Multiplex";
            }
        }

        /// <summary>
        /// MultiplexSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-multiplexsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MultiplexSettings
        /// </summary>
        [Required]
        public MultiplexTypes.MultiplexSettings MultiplexSettings { get; set; }

        /// <summary>
        /// AvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-availabilityzones
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public dynamic AvailabilityZones { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MultiplexOutputDestination
        /// </summary>
        public List<MultiplexTypes.MultiplexOutputDestination> Destinations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public List<MultiplexTypes.Tags> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace MultiplexTypes
    {
        public class MultiplexMediaConnectOutputDestinationSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EntitlementArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexmediaconnectoutputdestinationsettings.html#cfn-medialive-multiplex-multiplexmediaconnectoutputdestinationsettings-entitlementarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EntitlementArn { get; set; }
        }

        public class MultiplexOutputDestination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MultiplexMediaConnectOutputDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexoutputdestination.html#cfn-medialive-multiplex-multiplexoutputdestination-multiplexmediaconnectoutputdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexMediaConnectOutputDestinationSettings
            /// </summary>
            public MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings MultiplexMediaConnectOutputDestinationSettings { get; set; }
        }

        public class MultiplexSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TransportStreamBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexsettings.html#cfn-medialive-multiplex-multiplexsettings-transportstreambitrate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransportStreamBitrate { get; set; }
            /// <summary>
            /// MaximumVideoBufferDelayMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexsettings.html#cfn-medialive-multiplex-multiplexsettings-maximumvideobufferdelaymilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumVideoBufferDelayMilliseconds { get; set; }
            /// <summary>
            /// TransportStreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexsettings.html#cfn-medialive-multiplex-multiplexsettings-transportstreamid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransportStreamId { get; set; }
            /// <summary>
            /// TransportStreamReservedBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexsettings.html#cfn-medialive-multiplex-multiplexsettings-transportstreamreservedbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransportStreamReservedBitrate { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-tags.html#cfn-medialive-multiplex-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-tags.html#cfn-medialive-multiplex-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}