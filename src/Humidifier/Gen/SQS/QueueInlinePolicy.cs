namespace Humidifier.SQS
{
    using System.Collections.Generic;

    public class QueueInlinePolicy : Humidifier.Base.BaseResource, IHavePolicyDocument, IHaveQueue
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
        public dynamic PolicyDocument { get; set; }

        /// <summary>
        /// Queue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sqs-queueinlinepolicy.html#cfn-sqs-queueinlinepolicy-queue
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Queue { get; set; }
    }
}