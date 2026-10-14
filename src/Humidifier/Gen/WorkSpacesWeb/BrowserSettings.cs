namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;
    using BrowserSettingsTypes;

    public class BrowserSettings : Humidifier.Base.BaseResource, IHaveTags, IHaveCustomerManagedKey
    {
        public class Attributes
        {
            public static string AssociatedPortalArns =  "AssociatedPortalArns" ;
            public static string BrowserSettingsArn =  "BrowserSettingsArn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesWeb.BrowserSettings; }
        /// <summary>
        /// BrowserPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-browserpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BrowserPolicy { get; set; }
        /// <summary>
        /// CustomerManagedKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-customermanagedkey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerManagedKey { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// WebContentFilteringPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-webcontentfilteringpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebContentFilteringPolicy
        /// </summary>
        public Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy WebContentFilteringPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace BrowserSettingsTypes
    {
        public class WebContentFilteringPolicy : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BlockedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-browsersettings-webcontentfilteringpolicy.html#cfn-workspacesweb-browsersettings-webcontentfilteringpolicy-blockedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BlockedUrls { get; set; }
            /// <summary>
            /// AllowedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-browsersettings-webcontentfilteringpolicy.html#cfn-workspacesweb-browsersettings-webcontentfilteringpolicy-allowedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedUrls { get; set; }
            /// <summary>
            /// BlockedCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-browsersettings-webcontentfilteringpolicy.html#cfn-workspacesweb-browsersettings-webcontentfilteringpolicy-blockedcategories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BlockedCategories { get; set; }
        }
    }
}