namespace Humidifier.MediaLive
{
    using global::System.Collections.Generic;
    using ChannelPlacementGroupTypes;

    public class ChannelPlacementGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveClusterId, IHaveStringListOfNodes, IHaveListOfMediaLiveChannelPlacementGroupTypesTagsTags, IHaveName
    {
        public class Attributes
        {
            public static string State =  "State" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Channels =  "Channels" ;
        }

        public override string AWSTypeName { get => AWS.MediaLive.ChannelPlacementGroup; }
        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channelplacementgroup.html#cfn-medialive-channelplacementgroup-clusterid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClusterId { get; set; }
        /// <summary>
        /// Nodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channelplacementgroup.html#cfn-medialive-channelplacementgroup-nodes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Nodes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channelplacementgroup.html#cfn-medialive-channelplacementgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public Union<IReadOnlyList<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags>, IReadOnlyList<Union<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ChannelPlacementGroupTypes
    {
        public class Tags : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channelplacementgroup-tags.html#cfn-medialive-channelplacementgroup-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channelplacementgroup-tags.html#cfn-medialive-channelplacementgroup-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}