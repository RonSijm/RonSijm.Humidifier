namespace Humidifier.Detective
{
    using System.Collections.Generic;

    public class MemberInvitation : Humidifier.Base.BaseResource, IHaveMessage, IHaveMemberId, IHaveDisableEmailNotification
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
        public dynamic MemberId { get; set; }
        /// <summary>
        /// Message
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-message
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Message { get; set; }

        /// <summary>
        /// GraphArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-grapharn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic GraphArn { get; set; }
        /// <summary>
        /// DisableEmailNotification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-disableemailnotification
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DisableEmailNotification { get; set; }

        /// <summary>
        /// MemberEmailAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-detective-memberinvitation.html#cfn-detective-memberinvitation-memberemailaddress
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MemberEmailAddress { get; set; }
    }
}