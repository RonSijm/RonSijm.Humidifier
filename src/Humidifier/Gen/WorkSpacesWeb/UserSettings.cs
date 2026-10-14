namespace Humidifier.WorkSpacesWeb
{
    using global::System.Collections.Generic;
    using UserSettingsTypes;

    public class UserSettings : Humidifier.Base.BaseResource, IHaveTags, IHaveCustomerManagedKey
    {
        public class Attributes
        {
            public static string AssociatedPortalArns =  "AssociatedPortalArns" ;
            public static string UserSettingsArn =  "UserSettingsArn" ;
        }

        public override string AWSTypeName { get => AWS.WorkSpacesWeb.UserSettings; }
        /// <summary>
        /// IdleDisconnectTimeoutInMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-idledisconnecttimeoutinminutes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic IdleDisconnectTimeoutInMinutes { get; set; }
        /// <summary>
        /// DeepLinkAllowed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-deeplinkallowed
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeepLinkAllowed { get; set; }
        /// <summary>
        /// WebAuthnAllowed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-webauthnallowed
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic WebAuthnAllowed { get; set; }

        /// <summary>
        /// PrintAllowed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-printallowed
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PrintAllowed { get; set; }

        /// <summary>
        /// CopyAllowed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-copyallowed
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CopyAllowed { get; set; }

        /// <summary>
        /// DownloadAllowed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-downloadallowed
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic DownloadAllowed { get; set; }
        /// <summary>
        /// ToolbarConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-toolbarconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ToolbarConfiguration
        /// </summary>
        public Humidifier.WorkSpacesWeb.UserSettingsTypes.ToolbarConfiguration ToolbarConfiguration { get; set; }

        /// <summary>
        /// UploadAllowed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-uploadallowed
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic UploadAllowed { get; set; }
        /// <summary>
        /// CustomerManagedKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-customermanagedkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomerManagedKey { get; set; }
        /// <summary>
        /// AdditionalEncryptionContext
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-additionalencryptioncontext
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> AdditionalEncryptionContext { get; set; }
        /// <summary>
        /// DisconnectTimeoutInMinutes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-disconnecttimeoutinminutes
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic DisconnectTimeoutInMinutes { get; set; }
        /// <summary>
        /// CookieSynchronizationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-cookiesynchronizationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CookieSynchronizationConfiguration
        /// </summary>
        public Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration CookieSynchronizationConfiguration { get; set; }

        /// <summary>
        /// PasteAllowed
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-pasteallowed
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PasteAllowed { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// BrandingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspacesweb-usersettings.html#cfn-workspacesweb-usersettings-brandingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BrandingConfiguration
        /// </summary>
        public Humidifier.WorkSpacesWeb.UserSettingsTypes.BrandingConfiguration BrandingConfiguration { get; set; }
    }

    namespace UserSettingsTypes
    {
        public class BrandingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// FaviconMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-faviconmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageMetadata
            /// </summary>
            public Humidifier.WorkSpacesWeb.UserSettingsTypes.ImageMetadata FaviconMetadata { get; set; }
            /// <summary>
            /// TermsOfService
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-termsofservice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TermsOfService { get; set; }
            /// <summary>
            /// ColorTheme
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-colortheme
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorTheme { get; set; }
            /// <summary>
            /// LocalizedStrings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-localizedstrings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// ItemType: LocalizedBrandingStrings
            /// </summary>
            public Dictionary<string, Humidifier.WorkSpacesWeb.UserSettingsTypes.LocalizedBrandingStrings> LocalizedStrings { get; set; }
            /// <summary>
            /// Wallpaper
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-wallpaper
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Wallpaper { get; set; }
            /// <summary>
            /// WallpaperMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-wallpapermetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageMetadata
            /// </summary>
            public Humidifier.WorkSpacesWeb.UserSettingsTypes.ImageMetadata WallpaperMetadata { get; set; }
            /// <summary>
            /// LogoMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-logometadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageMetadata
            /// </summary>
            public Humidifier.WorkSpacesWeb.UserSettingsTypes.ImageMetadata LogoMetadata { get; set; }
            /// <summary>
            /// Favicon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-favicon
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Favicon { get; set; }
            /// <summary>
            /// Logo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-brandingconfiguration.html#cfn-workspacesweb-usersettings-brandingconfiguration-logo
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Logo { get; set; }
        }

        public class CookieSpecification : Humidifier.Base.BaseSubResource, IHaveName, IHavePath, IHaveDomain
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-cookiespecification.html#cfn-workspacesweb-usersettings-cookiespecification-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-cookiespecification.html#cfn-workspacesweb-usersettings-cookiespecification-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Domain { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-cookiespecification.html#cfn-workspacesweb-usersettings-cookiespecification-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CookieSynchronizationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Blocklist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-cookiesynchronizationconfiguration.html#cfn-workspacesweb-usersettings-cookiesynchronizationconfiguration-blocklist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CookieSpecification
            /// </summary>
            public List<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSpecification> Blocklist { get; set; }
            /// <summary>
            /// Allowlist
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-cookiesynchronizationconfiguration.html#cfn-workspacesweb-usersettings-cookiesynchronizationconfiguration-allowlist
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CookieSpecification
            /// </summary>
            public List<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSpecification> Allowlist { get; set; }
        }

        public class ImageMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LastUploadTimestamp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-imagemetadata.html#cfn-workspacesweb-usersettings-imagemetadata-lastuploadtimestamp
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastUploadTimestamp { get; set; }
            /// <summary>
            /// MimeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-imagemetadata.html#cfn-workspacesweb-usersettings-imagemetadata-mimetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MimeType { get; set; }
            /// <summary>
            /// FileExtension
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-imagemetadata.html#cfn-workspacesweb-usersettings-imagemetadata-fileextension
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FileExtension { get; set; }
        }

        public class LocalizedBrandingStrings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LoginButtonText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-localizedbrandingstrings.html#cfn-workspacesweb-usersettings-localizedbrandingstrings-loginbuttontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoginButtonText { get; set; }
            /// <summary>
            /// BrowserTabTitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-localizedbrandingstrings.html#cfn-workspacesweb-usersettings-localizedbrandingstrings-browsertabtitle
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BrowserTabTitle { get; set; }
            /// <summary>
            /// LoginTitle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-localizedbrandingstrings.html#cfn-workspacesweb-usersettings-localizedbrandingstrings-logintitle
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoginTitle { get; set; }
            /// <summary>
            /// ContactButtonText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-localizedbrandingstrings.html#cfn-workspacesweb-usersettings-localizedbrandingstrings-contactbuttontext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactButtonText { get; set; }
            /// <summary>
            /// LoginDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-localizedbrandingstrings.html#cfn-workspacesweb-usersettings-localizedbrandingstrings-logindescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoginDescription { get; set; }
            /// <summary>
            /// LoadingText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-localizedbrandingstrings.html#cfn-workspacesweb-usersettings-localizedbrandingstrings-loadingtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoadingText { get; set; }
            /// <summary>
            /// WelcomeText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-localizedbrandingstrings.html#cfn-workspacesweb-usersettings-localizedbrandingstrings-welcometext
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WelcomeText { get; set; }
            /// <summary>
            /// ContactLink
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-localizedbrandingstrings.html#cfn-workspacesweb-usersettings-localizedbrandingstrings-contactlink
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContactLink { get; set; }
        }

        public class ToolbarConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ToolbarType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-toolbarconfiguration.html#cfn-workspacesweb-usersettings-toolbarconfiguration-toolbartype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ToolbarType { get; set; }
            /// <summary>
            /// HiddenToolbarItems
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-toolbarconfiguration.html#cfn-workspacesweb-usersettings-toolbarconfiguration-hiddentoolbaritems
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic HiddenToolbarItems { get; set; }
            /// <summary>
            /// MaxDisplayResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-toolbarconfiguration.html#cfn-workspacesweb-usersettings-toolbarconfiguration-maxdisplayresolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaxDisplayResolution { get; set; }
            /// <summary>
            /// VisualMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspacesweb-usersettings-toolbarconfiguration.html#cfn-workspacesweb-usersettings-toolbarconfiguration-visualmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VisualMode { get; set; }
        }
    }
}