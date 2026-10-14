namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaPipelineKinesisVideoStreamPoolTypes;

    public class MediaPipelineKinesisVideoStreamPool : Humidifier.Base.BaseResource, IHavePoolName
    {
        public class Attributes
        {
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string PoolId =  "PoolId" ;
            public static string PoolStatus =  "PoolStatus" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.MediaPipelineKinesisVideoStreamPool; }

        /// <summary>
        /// PoolName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediapipelinekinesisvideostreampool.html#cfn-chime-mediapipelinekinesisvideostreampool-poolname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PoolName { get; set; }

        /// <summary>
        /// StreamConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediapipelinekinesisvideostreampool.html#cfn-chime-mediapipelinekinesisvideostreampool-streamconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: StreamConfiguration
        /// </summary>
        [Required]
        public Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.StreamConfiguration StreamConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediapipelinekinesisvideostreampool.html#cfn-chime-mediapipelinekinesisvideostreampool-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: TagsItems
        /// </summary>
        public List<Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.TagsItems> Tags { get; set; }
    }

    namespace MediaPipelineKinesisVideoStreamPoolTypes
    {
        public class StreamConfiguration : Humidifier.Base.BaseSubResource, IHaveRegion
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediapipelinekinesisvideostreampool-streamconfiguration.html#cfn-chime-mediapipelinekinesisvideostreampool-streamconfiguration-region
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// DataRetentionInHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediapipelinekinesisvideostreampool-streamconfiguration.html#cfn-chime-mediapipelinekinesisvideostreampool-streamconfiguration-dataretentioninhours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DataRetentionInHours { get; set; }
        }

        public class TagsItems : Humidifier.Base.BaseSubResource, IHaveValue, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediapipelinekinesisvideostreampool-tagsitems.html#cfn-chime-mediapipelinekinesisvideostreampool-tagsitems-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediapipelinekinesisvideostreampool-tagsitems.html#cfn-chime-mediapipelinekinesisvideostreampool-tagsitems-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}