namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using MultiplexTypes;

    public class Multiplex : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveMediaLiveMultiplexTypesMultiplexSettingsMultiplexSettings, IHaveStringListOfAvailabilityZones, IHaveListOfMediaLiveMultiplexTypesMultiplexOutputDestinationDestinations, IHaveListOfMediaLiveMultiplexTypesTagsTags, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string ProgramCount =  "ProgramCount" ;
            public static string PipelinesRunningCount =  "PipelinesRunningCount" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.Multiplex; }

        /// <summary>
        /// MultiplexSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-multiplexsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MultiplexSettings
        /// </summary>
        [Required]
        public Union<Humidifier.MediaLive.MultiplexTypes.MultiplexSettings, BaseFunction>? MultiplexSettings { get; set; }

        /// <summary>
        /// AvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-availabilityzones
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        [Required]
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AvailabilityZones { get; set; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MultiplexOutputDestination
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination>, IReadOnlyList<Union<Humidifier.MediaLive.MultiplexTypes.MultiplexOutputDestination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-multiplex.html#cfn-medialive-multiplex-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.MultiplexTypes.Tags>, IReadOnlyList<Union<Humidifier.MediaLive.MultiplexTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace MultiplexTypes
    {
        public class MultiplexMediaConnectOutputDestinationSettings : Humidifier.Base.BaseSubResource, IHaveEntitlementArn
        {
            /// <summary>
            /// EntitlementArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexmediaconnectoutputdestinationsettings.html#cfn-medialive-multiplex-multiplexmediaconnectoutputdestinationsettings-entitlementarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EntitlementArn { get; set; }
        }

        public class MultiplexOutputDestination : Humidifier.Base.BaseSubResource, IHaveMediaLiveMultiplexTypesMultiplexMediaConnectOutputDestinationSettingsMultiplexMediaConnectOutputDestinationSettings
        {
            /// <summary>
            /// MultiplexMediaConnectOutputDestinationSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexoutputdestination.html#cfn-medialive-multiplex-multiplexoutputdestination-multiplexmediaconnectoutputdestinationsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexMediaConnectOutputDestinationSettings
            /// </summary>
            public Union<Humidifier.MediaLive.MultiplexTypes.MultiplexMediaConnectOutputDestinationSettings, BaseFunction>? MultiplexMediaConnectOutputDestinationSettings { get; set; }
        }

        public class MultiplexSettings : Humidifier.Base.BaseSubResource, IHaveTransportStreamBitrate_Integer, IHaveMaximumVideoBufferDelayMilliseconds_Integer, IHaveTransportStreamId_Integer, IHaveTransportStreamReservedBitrate_Integer
        {
            /// <summary>
            /// TransportStreamBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexsettings.html#cfn-medialive-multiplex-multiplexsettings-transportstreambitrate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransportStreamBitrate { get; set; }
            /// <summary>
            /// MaximumVideoBufferDelayMilliseconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexsettings.html#cfn-medialive-multiplex-multiplexsettings-maximumvideobufferdelaymilliseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumVideoBufferDelayMilliseconds { get; set; }
            /// <summary>
            /// TransportStreamId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexsettings.html#cfn-medialive-multiplex-multiplexsettings-transportstreamid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransportStreamId { get; set; }
            /// <summary>
            /// TransportStreamReservedBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-multiplexsettings.html#cfn-medialive-multiplex-multiplexsettings-transportstreamreservedbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TransportStreamReservedBitrate { get; set; }
        }

        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-tags.html#cfn-medialive-multiplex-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-multiplex-tags.html#cfn-medialive-multiplex-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}