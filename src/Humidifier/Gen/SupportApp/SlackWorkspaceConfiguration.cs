namespace Humidifier.SupportApp
{
    using System.Collections.Generic;

    public class SlackWorkspaceConfiguration : Humidifier.Base.BaseResource, IHaveTeamId, IHaveVersionId
    {
        public override string AWSTypeName { get => AWS.SupportApp.SlackWorkspaceConfiguration; }
        /// <summary>
        /// VersionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackworkspaceconfiguration.html#cfn-supportapp-slackworkspaceconfiguration-versionid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VersionId { get; set; }

        /// <summary>
        /// TeamId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-supportapp-slackworkspaceconfiguration.html#cfn-supportapp-slackworkspaceconfiguration-teamid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic TeamId { get; set; }
    }
}