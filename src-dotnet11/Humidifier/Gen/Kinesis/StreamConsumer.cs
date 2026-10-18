namespace Humidifier.Kinesis
{
    using global::System.Collections.Generic;

    public class StreamConsumer : Humidifier.Base.BaseResource, IHaveTags, IHaveConsumerName, IHaveStreamARN
    {
        public class Attributes
        {
            public static string ConsumerCreationTimestamp =  "ConsumerCreationTimestamp" ;
            public static string ConsumerName =  "ConsumerName" ;
            public static string ConsumerARN =  "ConsumerARN" ;
            public static string ConsumerStatus =  "ConsumerStatus" ;
            public static string StreamARN =  "StreamARN" ;
        }

        public override string AWSTypeName { get => AWS.Kinesis.StreamConsumer; }

        /// <summary>
        /// ConsumerName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-streamconsumer.html#cfn-kinesis-streamconsumer-consumername
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConsumerName { get; set; }

        /// <summary>
        /// StreamARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-streamconsumer.html#cfn-kinesis-streamconsumer-streamarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? StreamARN { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesis-streamconsumer.html#cfn-kinesis-streamconsumer-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}