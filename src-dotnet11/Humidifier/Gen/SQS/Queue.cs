namespace Humidifier.SQS
{
    using global::System.Collections.Generic;

    public class Queue : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveReceiveMessageWaitTimeSeconds_Integer, IHaveFifoThroughputLimit, IHaveKmsMasterKeyId, IHaveFifoQueue_Boolean, IHaveMaximumMessageSize_Integer, IHaveVisibilityTimeout_Integer, IHaveKmsDataKeyReusePeriodSeconds_Integer, IHaveRedriveAllowPolicy_Json, IHaveSqsManagedSseEnabled_Boolean, IHaveDelaySeconds_Integer, IHaveRedrivePolicy_Json, IHaveMessageRetentionPeriod_Integer, IHaveDeduplicationScope, IHaveContentBasedDeduplication_Boolean, IHaveQueueName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string QueueName =  "QueueName" ;
            public static string QueueUrl =  "QueueUrl" ;
        }

        public override string AWSTypeName { get => AWS.SQS.Queue; }
        /// <summary>
        /// ReceiveMessageWaitTimeSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-receivemessagewaittimeseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ReceiveMessageWaitTimeSeconds { get; set; }
        /// <summary>
        /// FifoThroughputLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-fifothroughputlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FifoThroughputLimit { get; set; }
        /// <summary>
        /// KmsMasterKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-kmsmasterkeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsMasterKeyId { get; set; }
        /// <summary>
        /// FifoQueue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-fifoqueue
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? FifoQueue { get; set; }
        /// <summary>
        /// MaximumMessageSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-maximummessagesize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaximumMessageSize { get; set; }
        /// <summary>
        /// VisibilityTimeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-visibilitytimeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? VisibilityTimeout { get; set; }
        /// <summary>
        /// KmsDataKeyReusePeriodSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-kmsdatakeyreuseperiodseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? KmsDataKeyReusePeriodSeconds { get; set; }
        /// <summary>
        /// RedriveAllowPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-redriveallowpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? RedriveAllowPolicy { get; set; }
        /// <summary>
        /// SqsManagedSseEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-sqsmanagedsseenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? SqsManagedSseEnabled { get; set; }
        /// <summary>
        /// DelaySeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-delayseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? DelaySeconds { get; set; }
        /// <summary>
        /// RedrivePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-redrivepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? RedrivePolicy { get; set; }
        /// <summary>
        /// MessageRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-messageretentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MessageRetentionPeriod { get; set; }
        /// <summary>
        /// DeduplicationScope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-deduplicationscope
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeduplicationScope { get; set; }
        /// <summary>
        /// ContentBasedDeduplication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-contentbaseddeduplication
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ContentBasedDeduplication { get; set; }
        public Union<string, BaseFunction>? QueueName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queue.html#cfn-sqs-queue-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}