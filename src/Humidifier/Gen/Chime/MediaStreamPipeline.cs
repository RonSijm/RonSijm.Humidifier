namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaStreamPipelineTypes;

    public class MediaStreamPipeline : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string UpdatedTimestamp =  "UpdatedTimestamp" ;
            public static string CreatedTimestamp =  "CreatedTimestamp" ;
            public static string MediaPipelineId =  "MediaPipelineId" ;
            public static string MediaPipelineArn =  "MediaPipelineArn" ;
        }

        public override string AWSTypeName { get => AWS.Chime.MediaStreamPipeline; }

        /// <summary>
        /// Sinks
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediastreampipeline.html#cfn-chime-mediastreampipeline-sinks
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MediaStreamSink
        /// </summary>
        [Required]
        public List<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> Sinks { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediastreampipeline.html#cfn-chime-mediastreampipeline-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MediaStreamSource
        /// </summary>
        [Required]
        public List<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediastreampipeline.html#cfn-chime-mediastreampipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace MediaStreamPipelineTypes
    {
        public class MediaStreamSink : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MediaStreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsink.html#cfn-chime-mediastreampipeline-mediastreamsink-mediastreamtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaStreamType { get; set; }
            /// <summary>
            /// ReservedStreamCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsink.html#cfn-chime-mediastreampipeline-mediastreamsink-reservedstreamcapacity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReservedStreamCapacity { get; set; }
            /// <summary>
            /// SinkArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsink.html#cfn-chime-mediastreampipeline-mediastreamsink-sinkarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SinkArn { get; set; }
            /// <summary>
            /// SinkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsink.html#cfn-chime-mediastreampipeline-mediastreamsink-sinktype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SinkType { get; set; }
        }

        public class MediaStreamSource : Humidifier.Base.BaseSubResource, IHaveSourceArn, IHaveSourceType
        {
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsource.html#cfn-chime-mediastreampipeline-mediastreamsource-sourcearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceArn { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsource.html#cfn-chime-mediastreampipeline-mediastreamsource-sourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceType { get; set; }
        }
    }
}