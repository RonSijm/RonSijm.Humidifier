namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;
    using BrowserSettingsTypes;

    public class BrowserSettings : Humidifier.Base.BaseResource, IHaveTags, IHaveBrowserPolicy, IHaveCustomerManagedKey, IHaveStringDictionaryOfAdditionalEncryptionContext, IHaveWorkSpacesWebBrowserSettingsTypesWebContentFilteringPolicyWebContentFilteringPolicy
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
        public Union<string, BaseFunction>? BrowserPolicy { get; set; }
        /// <summary>
        /// CustomerManagedKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-customermanagedkey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CustomerManagedKey { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// WebContentFilteringPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-webcontentfilteringpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebContentFilteringPolicy
        /// </summary>
        public Union<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy, BaseFunction>? WebContentFilteringPolicy { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-browsersettings.html#cfn-workspacesweb-browsersettings-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BrowserSettingsTypes
    {
        public class WebContentFilteringPolicy : Humidifier.Base.BaseSubResource, IHaveStringListOfBlockedUrls, IHaveStringListOfAllowedUrls, IHaveStringListOfBlockedCategories
        {
            /// <summary>
            /// BlockedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-browsersettings-webcontentfilteringpolicy.html#cfn-workspacesweb-browsersettings-webcontentfilteringpolicy-blockedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BlockedUrls { get; set; }
            /// <summary>
            /// AllowedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-browsersettings-webcontentfilteringpolicy.html#cfn-workspacesweb-browsersettings-webcontentfilteringpolicy-allowedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedUrls { get; set; }
            /// <summary>
            /// BlockedCategories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-browsersettings-webcontentfilteringpolicy.html#cfn-workspacesweb-browsersettings-webcontentfilteringpolicy-blockedcategories
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BlockedCategories { get; set; }
        }
    }
}