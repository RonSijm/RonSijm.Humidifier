namespace Humidifier.CloudTrail
{
    using global::System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveListOfCloudTrailChannelTypesDestinationDestinations, IHaveSource, IHaveName
    {
        public class Attributes
        {
            public static string ChannelArn =  "ChannelArn" ;
        }

        public override string AWSTypeName { get => AWS.CloudTrail.Channel; }
        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-channel.html#cfn-cloudtrail-channel-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Destination
        /// </summary>
        public Union<IReadOnlyList<Humidifier.CloudTrail.ChannelTypes.Destination>, IReadOnlyList<Union<Humidifier.CloudTrail.ChannelTypes.Destination, BaseFunction>>, BaseFunction>? Destinations { get; set; }
        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-channel.html#cfn-cloudtrail-channel-source
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudtrail-channel.html#cfn-cloudtrail-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ChannelTypes
    {
        public class Destination : Humidifier.Base.BaseSubResource, IHaveType, IHaveLocation
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-channel-destination.html#cfn-cloudtrail-channel-destination-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-channel-destination.html#cfn-cloudtrail-channel-destination-location
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }
    }
}