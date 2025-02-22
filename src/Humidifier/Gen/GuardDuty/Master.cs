namespace Humidifier.GuardDuty
{
    using System.Collections.Generic;

    public class Master : Humidifier.Base.BaseResource, IHaveDetectorId, IHaveInvitationId
    {
        public override string AWSTypeName { get => AWS.GuardDuty.Master; }

        /// <summary>
        /// DetectorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-master.html#cfn-guardduty-master-detectorid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DetectorId { get; set; }

        /// <summary>
        /// MasterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-master.html#cfn-guardduty-master-masterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MasterId { get; set; }
        /// <summary>
        /// InvitationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-master.html#cfn-guardduty-master-invitationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InvitationId { get; set; }
    }
}