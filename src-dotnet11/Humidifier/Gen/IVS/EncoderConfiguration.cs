namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using EncoderConfigurationTypes;

    public class EncoderConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIVSEncoderConfigurationTypesVideoVideo, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVS.EncoderConfiguration; }
        /// <summary>
        /// Video
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-encoderconfiguration.html#cfn-ivs-encoderconfiguration-video
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Video
        /// </summary>
        public Union<Humidifier.IVS.EncoderConfigurationTypes.Video, BaseFunction>? Video { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-encoderconfiguration.html#cfn-ivs-encoderconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace EncoderConfigurationTypes
    {
        public class Video : Humidifier.Base.BaseSubResource, IHaveFramerate_Double, IHaveHeight_Integer, IHaveBitrate_Integer, IHaveWidth_Integer
        {
            /// <summary>
            /// Framerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-encoderconfiguration-video.html#cfn-ivs-encoderconfiguration-video-framerate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Framerate { get; set; }
            /// <summary>
            /// Height
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-encoderconfiguration-video.html#cfn-ivs-encoderconfiguration-video-height
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Height { get; set; }
            /// <summary>
            /// Bitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-encoderconfiguration-video.html#cfn-ivs-encoderconfiguration-video-bitrate
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Bitrate { get; set; }
            /// <summary>
            /// Width
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-encoderconfiguration-video.html#cfn-ivs-encoderconfiguration-video-width
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Width { get; set; }
        }
    }
}