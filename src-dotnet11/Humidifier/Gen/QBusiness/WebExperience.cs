namespace Humidifier.QBusiness
{
    using global::System.Collections.Generic;
    using WebExperienceTypes;

    public class WebExperience : Humidifier.Base.BaseResource, IHaveTags, IHaveStringListOfOrigins, IHaveSubtitle, IHaveQBusinessWebExperienceTypesCustomizationConfigurationCustomizationConfiguration, IHaveSamplePromptsControlMode, IHaveTitle, IHaveQBusinessWebExperienceTypesIdentityProviderConfigurationIdentityProviderConfiguration, IHaveWelcomeMessage, IHaveApplicationId, IHaveRoleArn, IHaveQBusinessWebExperienceTypesBrowserExtensionConfigurationBrowserExtensionConfiguration
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string WebExperienceId =  "WebExperienceId" ;
            public static string DefaultEndpoint =  "DefaultEndpoint" ;
            public static string WebExperienceArn =  "WebExperienceArn" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.QBusiness.WebExperience; }
        /// <summary>
        /// Origins
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-origins
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Origins { get; set; }
        /// <summary>
        /// Subtitle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-subtitle
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subtitle { get; set; }
        /// <summary>
        /// CustomizationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-customizationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CustomizationConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.WebExperienceTypes.CustomizationConfiguration, BaseFunction>? CustomizationConfiguration { get; set; }
        /// <summary>
        /// SamplePromptsControlMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-samplepromptscontrolmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SamplePromptsControlMode { get; set; }
        /// <summary>
        /// Title
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-title
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Title { get; set; }
        /// <summary>
        /// IdentityProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-identityproviderconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IdentityProviderConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration, BaseFunction>? IdentityProviderConfiguration { get; set; }
        /// <summary>
        /// WelcomeMessage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-welcomemessage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WelcomeMessage { get; set; }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationId { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// BrowserExtensionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-qbusiness-webexperience.html#cfn-qbusiness-webexperience-browserextensionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BrowserExtensionConfiguration
        /// </summary>
        public Union<Humidifier.QBusiness.WebExperienceTypes.BrowserExtensionConfiguration, BaseFunction>? BrowserExtensionConfiguration { get; set; }
    }

    namespace WebExperienceTypes
    {
        public class BrowserExtensionConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfEnabledBrowserExtensions
        {
            /// <summary>
            /// EnabledBrowserExtensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-browserextensionconfiguration.html#cfn-qbusiness-webexperience-browserextensionconfiguration-enabledbrowserextensions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EnabledBrowserExtensions { get; set; }
        }

        public class CustomizationConfiguration : Humidifier.Base.BaseSubResource, IHaveFaviconUrl, IHaveFontUrl, IHaveCustomCSSUrl, IHaveLogoUrl
        {
            /// <summary>
            /// FaviconUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-customizationconfiguration.html#cfn-qbusiness-webexperience-customizationconfiguration-faviconurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FaviconUrl { get; set; }
            /// <summary>
            /// FontUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-customizationconfiguration.html#cfn-qbusiness-webexperience-customizationconfiguration-fonturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FontUrl { get; set; }
            /// <summary>
            /// CustomCSSUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-customizationconfiguration.html#cfn-qbusiness-webexperience-customizationconfiguration-customcssurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomCSSUrl { get; set; }
            /// <summary>
            /// LogoUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-customizationconfiguration.html#cfn-qbusiness-webexperience-customizationconfiguration-logourl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogoUrl { get; set; }
        }

        public class IdentityProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveQBusinessWebExperienceTypesOpenIDConnectProviderConfigurationOpenIDConnectConfiguration, IHaveQBusinessWebExperienceTypesSamlProviderConfigurationSamlConfiguration
        {
            /// <summary>
            /// OpenIDConnectConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-identityproviderconfiguration.html#cfn-qbusiness-webexperience-identityproviderconfiguration-openidconnectconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIDConnectProviderConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.WebExperienceTypes.OpenIDConnectProviderConfiguration, BaseFunction>? OpenIDConnectConfiguration { get; set; }
            /// <summary>
            /// SamlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-identityproviderconfiguration.html#cfn-qbusiness-webexperience-identityproviderconfiguration-samlconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SamlProviderConfiguration
            /// </summary>
            public Union<Humidifier.QBusiness.WebExperienceTypes.SamlProviderConfiguration, BaseFunction>? SamlConfiguration { get; set; }
        }

        public class OpenIDConnectProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretsArn, IHaveSecretsRole
        {
            /// <summary>
            /// SecretsArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-openidconnectproviderconfiguration.html#cfn-qbusiness-webexperience-openidconnectproviderconfiguration-secretsarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsArn { get; set; }
            /// <summary>
            /// SecretsRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-openidconnectproviderconfiguration.html#cfn-qbusiness-webexperience-openidconnectproviderconfiguration-secretsrole
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretsRole { get; set; }
        }

        public class SamlProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveAuthenticationUrl
        {
            /// <summary>
            /// AuthenticationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-qbusiness-webexperience-samlproviderconfiguration.html#cfn-qbusiness-webexperience-samlproviderconfiguration-authenticationurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationUrl { get; set; }
        }
    }
}