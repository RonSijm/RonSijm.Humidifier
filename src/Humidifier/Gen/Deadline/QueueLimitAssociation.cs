namespace Humidifier.Deadline
{
    using System.Collections.Generic;

    public class QueueLimitAssociation : Humidifier.Base.BaseResource, IHaveFarmId, IHaveQueueId
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
        public dynamic LimitId { get; set; }

        /// <summary>
        /// QueueId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queuelimitassociation.html#cfn-deadline-queuelimitassociation-queueid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic QueueId { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queuelimitassociation.html#cfn-deadline-queuelimitassociation-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic FarmId { get; set; }
    }
}