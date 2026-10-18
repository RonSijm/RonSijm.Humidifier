namespace Humidifier.SQS
{
    using global::System.Collections.Generic;

    public class QueueInlinePolicy : Humidifier.Base.BaseResource, IHavePolicyDocument_Json, IHaveQueue
    {
        public override string AWSTypeName { get => AWS.SQS.QueueInlinePolicy; }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queueinlinepolicy.html#cfn-sqs-queueinlinepolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        [Required]
        public Union<object, BaseFunction>? PolicyDocument { get; set; }

        /// <summary>
        /// Queue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queueinlinepolicy.html#cfn-sqs-queueinlinepolicy-queue
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Queue { get; set; }
    }
}