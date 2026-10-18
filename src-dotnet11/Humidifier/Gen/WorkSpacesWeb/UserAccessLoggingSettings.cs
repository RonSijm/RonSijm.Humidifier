namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;

    public class UserAccessLoggingSettings : Humidifier.Base.BaseResource, IHaveTags, IHaveKinesisStreamArn
    {
        public class Attributes
        {
            public static string AssociatedPortalArns =  "AssociatedPortalArns" ;
            public static string UserAccessLoggingSettingsArn =  "UserAccessLoggingSettingsArn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesWeb.UserAccessLoggingSettings; }

        /// <summary>
        /// KinesisStreamArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-useraccessloggingsettings.html#cfn-workspacesweb-useraccessloggingsettings-kinesisstreamarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KinesisStreamArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-useraccessloggingsettings.html#cfn-workspacesweb-useraccessloggingsettings-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }
}