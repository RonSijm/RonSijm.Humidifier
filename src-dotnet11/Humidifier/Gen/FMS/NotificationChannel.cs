namespace Humidifier.FMS
{
    using global::System.Collections.Generic;

    public class NotificationChannel : Humidifier.Base.BaseResource, IHaveSnsTopicArn, IHaveSnsRoleName
    {
        public override string AWSTypeName { get => AWS.FMS.NotificationChannel; }

        /// <summary>
        /// SnsTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-notificationchannel.html#cfn-fms-notificationchannel-snstopicarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SnsTopicArn { get; set; }

        /// <summary>
        /// SnsRoleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-fms-notificationchannel.html#cfn-fms-notificationchannel-snsrolename
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SnsRoleName { get; set; }
    }
}