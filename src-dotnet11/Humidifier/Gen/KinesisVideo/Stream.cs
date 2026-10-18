namespace Humidifier.KinesisVideo
{
    using global::System.Collections.Generic;
    using StreamTypes;

    public class Stream : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKinesisVideoStreamTypesStreamStorageConfigurationStreamStorageConfiguration, IHaveKmsKeyId, IHaveMediaType, IHaveDataRetentionInHours_Integer, IHaveName, IHaveDeviceName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.KinesisVideo.Stream; }
        /// <summary>
        /// StreamStorageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisvideo-stream.html#cfn-kinesisvideo-stream-streamstorageconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamStorageConfiguration
        /// </summary>
        public Union<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration, BaseFunction>? StreamStorageConfiguration { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisvideo-stream.html#cfn-kinesisvideo-stream-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// MediaType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisvideo-stream.html#cfn-kinesisvideo-stream-mediatype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MediaType { get; set; }
        /// <summary>
        /// DataRetentionInHours
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisvideo-stream.html#cfn-kinesisvideo-stream-dataretentioninhours
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DataRetentionInHours { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisvideo-stream.html#cfn-kinesisvideo-stream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// DeviceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisvideo-stream.html#cfn-kinesisvideo-stream-devicename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeviceName { get; set; }
    }

    namespace StreamTypes
    {
        public class StreamStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveDefaultStorageTier
        {
            /// <summary>
            /// DefaultStorageTier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisvideo-stream-streamstorageconfiguration.html#cfn-kinesisvideo-stream-streamstorageconfiguration-defaultstoragetier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultStorageTier { get; set; }
        }
    }
}