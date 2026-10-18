namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;

    public class QueueLimitAssociation : Humidifier.Base.BaseResource, IHaveLimitId, IHaveQueueId, IHaveFarmId
    {
        public override string AWSTypeName { get => AWS.Deadline.QueueLimitAssociation; }

        /// <summary>
        /// LimitId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queuelimitassociation.html#cfn-deadline-queuelimitassociation-limitid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? LimitId { get; set; }

        /// <summary>
        /// QueueId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queuelimitassociation.html#cfn-deadline-queuelimitassociation-queueid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? QueueId { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queuelimitassociation.html#cfn-deadline-queuelimitassociation-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FarmId { get; set; }
    }
}