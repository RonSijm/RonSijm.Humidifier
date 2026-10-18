namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;

    public class QueueFleetAssociation : Humidifier.Base.BaseResource, IHaveFleetId, IHaveQueueId, IHaveFarmId
    {
        public override string AWSTypeName { get => AWS.Deadline.QueueFleetAssociation; }

        /// <summary>
        /// FleetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queuefleetassociation.html#cfn-deadline-queuefleetassociation-fleetid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FleetId { get; set; }

        /// <summary>
        /// QueueId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queuefleetassociation.html#cfn-deadline-queuefleetassociation-queueid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? QueueId { get; set; }

        /// <summary>
        /// FarmId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-queuefleetassociation.html#cfn-deadline-queuefleetassociation-farmid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? FarmId { get; set; }
    }
}