namespace Humidifier.Kinesis
{
    using global::System.Collections.Generic;
    using StreamTypes;

    public class Stream : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveKinesisStreamTypesStreamModeDetailsStreamModeDetails, IHaveKinesisStreamTypesStreamEncryptionStreamEncryption, IHaveWarmThroughputMiBps_Integer, IHaveMaxRecordSizeInKiB_Integer, IHaveRetentionPeriodHours_Integer, IHaveStringListOfDesiredShardLevelMetrics, IHaveRecordDistributionStrategy, IHaveName, IHaveShardCount_Integer
    {
        public class Attributes
        {
            public static string WarmThroughputObject =  "WarmThroughputObject" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.Kinesis.Stream; }
        /// <summary>
        /// StreamModeDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-streammodedetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamModeDetails
        /// </summary>
        public Union<Humidifier.Kinesis.StreamTypes.StreamModeDetails, BaseFunction>? StreamModeDetails { get; set; }
        /// <summary>
        /// StreamEncryption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-streamencryption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamEncryption
        /// </summary>
        public Union<Humidifier.Kinesis.StreamTypes.StreamEncryption, BaseFunction>? StreamEncryption { get; set; }
        /// <summary>
        /// WarmThroughputMiBps
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-warmthroughputmibps
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? WarmThroughputMiBps { get; set; }
        /// <summary>
        /// MaxRecordSizeInKiB
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-maxrecordsizeinkib
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxRecordSizeInKiB { get; set; }
        /// <summary>
        /// RetentionPeriodHours
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-retentionperiodhours
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RetentionPeriodHours { get; set; }
        /// <summary>
        /// DesiredShardLevelMetrics
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-desiredshardlevelmetrics
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DesiredShardLevelMetrics { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// RecordDistributionStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-recorddistributionstrategy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RecordDistributionStrategy { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ShardCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-stream.html#cfn-kinesis-stream-shardcount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ShardCount { get; set; }
    }

    namespace StreamTypes
    {
        public class StreamEncryption : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveKeyId
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-stream-streamencryption.html#cfn-kinesis-stream-streamencryption-encryptiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// KeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-stream-streamencryption.html#cfn-kinesis-stream-streamencryption-keyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyId { get; set; }
        }

        public class StreamModeDetails : Humidifier.Base.BaseSubResource, IHaveStreamMode
        {
            /// <summary>
            /// StreamMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-stream-streammodedetails.html#cfn-kinesis-stream-streammodedetails-streammode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamMode { get; set; }
        }

        public class WarmThroughputObject : Humidifier.Base.BaseSubResource, IHaveCurrentMiBps_Integer, IHaveTargetMiBps_Integer
        {
            /// <summary>
            /// CurrentMiBps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-stream-warmthroughputobject.html#cfn-kinesis-stream-warmthroughputobject-currentmibps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? CurrentMiBps { get; set; }
            /// <summary>
            /// TargetMiBps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesis-stream-warmthroughputobject.html#cfn-kinesis-stream-warmthroughputobject-targetmibps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetMiBps { get; set; }
        }
    }
}