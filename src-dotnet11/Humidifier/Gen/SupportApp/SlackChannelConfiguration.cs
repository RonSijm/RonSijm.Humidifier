namespace Humidifier.SupportApp
{
    using global::System.Collections.Generic;

    public class SlackChannelConfiguration : Humidifier.Base.BaseResource, IHaveChannelName, IHaveNotifyOnAddCorrespondenceToCase_Boolean, IHaveChannelRoleArn, IHaveNotifyOnResolveCase_Boolean, IHaveNotifyOnCaseSeverity, IHaveTeamId, IHaveChannelId, IHaveNotifyOnCreateOrReopenCase_Boolean
    {
        public override string AWSTypeName { get => AWS.SupportApp.SlackChannelConfiguration; }
        /// <summary>
        /// ChannelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackchannelconfiguration.html#cfn-supportapp-slackchannelconfiguration-channelname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ChannelName { get; set; }
        /// <summary>
        /// NotifyOnAddCorrespondenceToCase
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackchannelconfiguration.html#cfn-supportapp-slackchannelconfiguration-notifyonaddcorrespondencetocase
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NotifyOnAddCorrespondenceToCase { get; set; }

        /// <summary>
        /// ChannelRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackchannelconfiguration.html#cfn-supportapp-slackchannelconfiguration-channelrolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelRoleArn { get; set; }
        /// <summary>
        /// NotifyOnResolveCase
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackchannelconfiguration.html#cfn-supportapp-slackchannelconfiguration-notifyonresolvecase
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NotifyOnResolveCase { get; set; }

        /// <summary>
        /// NotifyOnCaseSeverity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackchannelconfiguration.html#cfn-supportapp-slackchannelconfiguration-notifyoncaseseverity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? NotifyOnCaseSeverity { get; set; }

        /// <summary>
        /// TeamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackchannelconfiguration.html#cfn-supportapp-slackchannelconfiguration-teamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TeamId { get; set; }

        /// <summary>
        /// ChannelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackchannelconfiguration.html#cfn-supportapp-slackchannelconfiguration-channelid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ChannelId { get; set; }
        /// <summary>
        /// NotifyOnCreateOrReopenCase
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackchannelconfiguration.html#cfn-supportapp-slackchannelconfiguration-notifyoncreateorreopencase
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? NotifyOnCreateOrReopenCase { get; set; }
    }
}