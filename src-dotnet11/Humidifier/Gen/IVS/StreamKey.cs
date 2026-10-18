namespace Humidifier.IVS
{
    using global::System.Collections.Generic;

    public class StreamKey : Humidifier.Base.BaseResource, IHaveTags, IHaveChannelArn
    {
        public class Attributes
        {
            public static string Value =  "Value" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVS.StreamKey; }

        /// <summary>
        /// ChannelArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-streamkey.html#cfn-ivs-streamkey-channelarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-streamkey.html#cfn-ivs-streamkey-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}