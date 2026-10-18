namespace Humidifier.QLDB
{
    using global::System.Collections.Generic;
    using StreamTypes;

    public class Stream : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveInclusiveStartTime, IHaveStreamName, IHaveQLDBStreamTypesKinesisConfigurationKinesisConfiguration, IHaveExclusiveEndTime, IHaveLedgerName, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QLDB.Stream; }

        /// <summary>
        /// InclusiveStartTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qldb-stream.html#cfn-qldb-stream-inclusivestarttime
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InclusiveStartTime { get; set; }
        public Union<string, BaseFunction>? StreamName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// KinesisConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qldb-stream.html#cfn-qldb-stream-kinesisconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KinesisConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.QLDB.StreamTypes.KinesisConfiguration, BaseFunction>? KinesisConfiguration { get; set; }
        /// <summary>
        /// ExclusiveEndTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qldb-stream.html#cfn-qldb-stream-exclusiveendtime
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExclusiveEndTime { get; set; }

        /// <summary>
        /// LedgerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qldb-stream.html#cfn-qldb-stream-ledgername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LedgerName { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qldb-stream.html#cfn-qldb-stream-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qldb-stream.html#cfn-qldb-stream-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace StreamTypes
    {
        public class KinesisConfiguration : Humidifier.Base.BaseSubResource, IHaveAggregationEnabled_Boolean, IHaveStreamArn
        {
            /// <summary>
            /// AggregationEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qldb-stream-kinesisconfiguration.html#cfn-qldb-stream-kinesisconfiguration-aggregationenabled
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AggregationEnabled { get; set; }
            /// <summary>
            /// StreamArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qldb-stream-kinesisconfiguration.html#cfn-qldb-stream-kinesisconfiguration-streamarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamArn { get; set; }
        }
    }
}