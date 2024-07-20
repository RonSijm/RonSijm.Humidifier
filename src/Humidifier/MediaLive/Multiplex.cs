namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using MultiplexTypes;

    public class Multiplex : Humidifier.Resource
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
        public MultiplexSettings MultiplexSettings { get; set; }
        /// <summary>
        /// AvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-availabilityzones
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AvailabilityZones { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MultiplexOutputDestination
        /// </summary>
        public List<MultiplexOutputDestination> Destinations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public List<Tags> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-name
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace MultiplexTypes
    {
        public class MultiplexMediaConnectOutputDestinationSettings
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

        public class MultiplexOutputDestination
        {
            /// <summary>
            /// MultiplexMediaConnectOutputDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexoutputdestination.html#cfn-medialive-multiplex-multiplexoutputdestination-multiplexmediaconnectoutputdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexMediaConnectOutputDestinationSettings
            /// </summary>
            public MultiplexMediaConnectOutputDestinationSettings MultiplexMediaConnectOutputDestinationSettings { get; set; }
        }

        public class MultiplexSettings
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

        public class Tags
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