namespace Humidifier.Detective
{
    using global::System.Collections.Generic;

    public class MemberInvitation : Humidifier.Base.BaseResource, IHaveMemberId, IHaveMessage, IHaveGraphArn, IHaveDisableEmailNotification_Boolean, IHaveMemberEmailAddress
    {
        public override string AWSTypeName { get => AWS.Detective.MemberInvitation; }

        /// <summary>
        /// MemberId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-memberid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MemberId { get; set; }
        /// <summary>
        /// Message
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-message
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Message { get; set; }

        /// <summary>
        /// GraphArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-grapharn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GraphArn { get; set; }
        /// <summary>
        /// DisableEmailNotification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-disableemailnotification
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DisableEmailNotification { get; set; }

        /// <summary>
        /// MemberEmailAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-memberemailaddress
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? MemberEmailAddress { get; set; }
    }
}