namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using FlowMediaStreamTypes;

    public class FlowMediaStream : Humidifier.Base.BaseResource, IHaveTags, IHaveMediaStreamType, IHaveMediaStreamId_Integer, IHaveDescription, IHaveMediaStreamName, IHaveClockRate_Integer, IHaveMediaConnectFlowMediaStreamTypesMediaStreamAttributesAttributes_, IHaveVideoFormat, IHaveFlowArn
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Fmt =  "Fmt" ;
        }

        public override string AWSTypeName { get => AWS.MediaConnect.FlowMediaStream; }

        /// <summary>
        /// MediaStreamType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-mediastreamtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MediaStreamType { get; set; }

        /// <summary>
        /// MediaStreamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-mediastreamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? MediaStreamId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// MediaStreamName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-mediastreamname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MediaStreamName { get; set; }
        /// <summary>
        /// ClockRate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-clockrate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ClockRate { get; set; }
        /// <summary>
        /// Attributes_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-attributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MediaStreamAttributes
        /// </summary>
        public Union<Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes, BaseFunction>? Attributes_ { get; set; }
        /// <summary>
        /// VideoFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-videoformat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VideoFormat { get; set; }

        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-flowarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FlowArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace FlowMediaStreamTypes
    {
        public class Fmtp : Humidifier.Base.BaseSubResource, IHavePar, IHaveScanMode, IHaveTcs, IHaveExactFramerate, IHaveChannelOrder, IHaveColorimetry, IHaveRange
        {
            /// <summary>
            /// Par
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-par
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Par { get; set; }
            /// <summary>
            /// ScanMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-scanmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScanMode { get; set; }
            /// <summary>
            /// Tcs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-tcs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Tcs { get; set; }
            /// <summary>
            /// ExactFramerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-exactframerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExactFramerate { get; set; }
            /// <summary>
            /// ChannelOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-channelorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChannelOrder { get; set; }
            /// <summary>
            /// Colorimetry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-colorimetry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Colorimetry { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-range
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Range { get; set; }
        }

        public class MediaStreamAttributes : Humidifier.Base.BaseSubResource, IHaveMediaConnectFlowMediaStreamTypesFmtpFmtp, IHaveLang
        {
            /// <summary>
            /// Fmtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-mediastreamattributes.html#cfn-mediaconnect-flowmediastream-mediastreamattributes-fmtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Fmtp
            /// </summary>
            public Union<Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp, BaseFunction>? Fmtp { get; set; }
            /// <summary>
            /// Lang
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-mediastreamattributes.html#cfn-mediaconnect-flowmediastream-mediastreamattributes-lang
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Lang { get; set; }
        }
    }
}