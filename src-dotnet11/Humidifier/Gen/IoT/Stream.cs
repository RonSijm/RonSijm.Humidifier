namespace Humidifier.IoT
{
    using global::System.Collections.Generic;
    using StreamTypes;

    public class Stream : Humidifier.Base.BaseResource, IHaveTags, IHaveStreamId, IHaveDescription, IHaveListOfIoTStreamTypesStreamFileFiles, IHaveRoleArn
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string StreamVersion =  "StreamVersion" ;
        }

        public override string AWSTypeName { get => AWS.IoT.Stream; }

        /// <summary>
        /// StreamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-stream.html#cfn-iot-stream-streamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StreamId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-stream.html#cfn-iot-stream-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Files
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-stream.html#cfn-iot-stream-files
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StreamFile
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.IoT.StreamTypes.StreamFile>, IReadOnlyList<Union<Humidifier.IoT.StreamTypes.StreamFile, BaseFunction>>, BaseFunction>? Files { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-stream.html#cfn-iot-stream-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-stream.html#cfn-iot-stream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace StreamTypes
    {
        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveVersion, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-stream-s3location.html#cfn-iot-stream-s3location-bucket
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-stream-s3location.html#cfn-iot-stream-s3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-stream-s3location.html#cfn-iot-stream-s3location-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class StreamFile : Humidifier.Base.BaseSubResource, IHaveFileId_Integer, IHaveIoTStreamTypesS3LocationS3Location
        {
            /// <summary>
            /// FileId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-stream-streamfile.html#cfn-iot-stream-streamfile-fileid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FileId { get; set; }
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-stream-streamfile.html#cfn-iot-stream-streamfile-s3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.IoT.StreamTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }
    }
}