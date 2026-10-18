namespace Humidifier.GuardDuty
{
    using global::System.Collections.Generic;

    public class Master : Humidifier.Base.BaseResource, IHaveDetectorId, IHaveMasterId, IHaveInvitationId
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
        public Union<string, BaseFunction>? DetectorId { get; set; }

        /// <summary>
        /// MasterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-master.html#cfn-guardduty-master-masterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MasterId { get; set; }
        /// <summary>
        /// InvitationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-master.html#cfn-guardduty-master-invitationid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? InvitationId { get; set; }
    }
}