namespace Humidifier.MediaConnect
{
    using global::System.Collections.Generic;
    using FlowMediaStreamTypes;

    public class FlowMediaStream : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveFlowArn, IHaveMediaStreamName
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
        public dynamic MediaStreamType { get; set; }

        /// <summary>
        /// MediaStreamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-mediastreamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public dynamic MediaStreamId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// MediaStreamName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-mediastreamname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MediaStreamName { get; set; }
        /// <summary>
        /// ClockRate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-clockrate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ClockRate { get; set; }
        /// <summary>
        /// Attributes_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-attributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MediaStreamAttributes
        /// </summary>
        public Humidifier.MediaConnect.FlowMediaStreamTypes.MediaStreamAttributes Attributes_ { get; set; }
        /// <summary>
        /// VideoFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-videoformat
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VideoFormat { get; set; }

        /// <summary>
        /// FlowArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-flowarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FlowArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-mediaconnect-flowmediastream.html#cfn-mediaconnect-flowmediastream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace FlowMediaStreamTypes
    {
        public class Fmtp : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Par
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-par
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Par { get; set; }
            /// <summary>
            /// ScanMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-scanmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScanMode { get; set; }
            /// <summary>
            /// Tcs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-tcs
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Tcs { get; set; }
            /// <summary>
            /// ExactFramerate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-exactframerate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExactFramerate { get; set; }
            /// <summary>
            /// ChannelOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-channelorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelOrder { get; set; }
            /// <summary>
            /// Colorimetry
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-colorimetry
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Colorimetry { get; set; }
            /// <summary>
            /// Range
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-fmtp.html#cfn-mediaconnect-flowmediastream-fmtp-range
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Range { get; set; }
        }

        public class MediaStreamAttributes : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Fmtp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-mediastreamattributes.html#cfn-mediaconnect-flowmediastream-mediastreamattributes-fmtp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Fmtp
            /// </summary>
            public Humidifier.MediaConnect.FlowMediaStreamTypes.Fmtp Fmtp { get; set; }
            /// <summary>
            /// Lang
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flowmediastream-mediastreamattributes.html#cfn-mediaconnect-flowmediastream-mediastreamattributes-lang
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Lang { get; set; }
        }
    }
}