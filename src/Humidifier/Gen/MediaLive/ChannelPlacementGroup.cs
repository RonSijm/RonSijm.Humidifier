namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using ChannelPlacementGroupTypes;

    public class ChannelPlacementGroup : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveClusterId, IHaveNodes
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
        public dynamic ClusterId { get; set; }
        /// <summary>
        /// Nodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channelplacementgroup.html#cfn-medialive-channelplacementgroup-nodes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Nodes { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channelplacementgroup.html#cfn-medialive-channelplacementgroup-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public List<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
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
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channelplacementgroup-tags.html#cfn-medialive-channelplacementgroup-tags-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}