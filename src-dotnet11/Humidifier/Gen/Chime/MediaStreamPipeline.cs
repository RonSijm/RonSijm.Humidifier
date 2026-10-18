namespace Humidifier.Chime
{
    using global::System.Collections.Generic;
    using MediaStreamPipelineTypes;

    public class MediaStreamPipeline : Humidifier.Base.BaseResource, IHaveTags, IHaveListOfChimeMediaStreamPipelineTypesMediaStreamSinkSinks, IHaveListOfChimeMediaStreamPipelineTypesMediaStreamSourceSources
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
        public Union<IReadOnlyList<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink>, IReadOnlyList<Union<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink, BaseFunction>>, BaseFunction>? Sinks { get; set; }

        /// <summary>
        /// Sources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediastreampipeline.html#cfn-chime-mediastreampipeline-sources
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: MediaStreamSource
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource>, IReadOnlyList<Union<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource, BaseFunction>>, BaseFunction>? Sources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-chime-mediastreampipeline.html#cfn-chime-mediastreampipeline-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace MediaStreamPipelineTypes
    {
        public class MediaStreamSink : Humidifier.Base.BaseSubResource, IHaveMediaStreamType, IHaveReservedStreamCapacity_Integer, IHaveSinkArn, IHaveSinkType
        {
            /// <summary>
            /// MediaStreamType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsink.html#cfn-chime-mediastreampipeline-mediastreamsink-mediastreamtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MediaStreamType { get; set; }
            /// <summary>
            /// ReservedStreamCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsink.html#cfn-chime-mediastreampipeline-mediastreamsink-reservedstreamcapacity
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ReservedStreamCapacity { get; set; }
            /// <summary>
            /// SinkArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsink.html#cfn-chime-mediastreampipeline-mediastreamsink-sinkarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SinkArn { get; set; }
            /// <summary>
            /// SinkType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsink.html#cfn-chime-mediastreampipeline-mediastreamsink-sinktype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SinkType { get; set; }
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
            public Union<string, BaseFunction>? SourceArn { get; set; }
            /// <summary>
            /// SourceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-chime-mediastreampipeline-mediastreamsource.html#cfn-chime-mediastreampipeline-mediastreamsource-sourcetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceType { get; set; }
        }
    }
}