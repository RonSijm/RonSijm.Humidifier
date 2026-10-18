namespace Humidifier.SSO
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveStatus, IHaveApplicationProviderArn, IHaveSSOApplicationTypesPortalOptionsConfigurationPortalOptions, IHaveDescription, IHaveInstanceArn, IHaveName
    {
        public class Attributes
        {
            public static string IdentityStoreArn =  "IdentityStoreArn" ;
            public static string ApplicationArn =  "ApplicationArn" ;
        }

        public override string AWSTypeName { get => AWS.SSO.Application; }
        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-application.html#cfn-sso-application-status
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Status { get; set; }

        /// <summary>
        /// ApplicationProviderArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-application.html#cfn-sso-application-applicationproviderarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ApplicationProviderArn { get; set; }
        /// <summary>
        /// PortalOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-application.html#cfn-sso-application-portaloptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PortalOptionsConfiguration
        /// </summary>
        public Union<Humidifier.SSO.ApplicationTypes.PortalOptionsConfiguration, BaseFunction>? PortalOptions { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-application.html#cfn-sso-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-application.html#cfn-sso-application-instancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sso-application.html#cfn-sso-application-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApplicationTypes
    {
        public class PortalOptionsConfiguration : Humidifier.Base.BaseSubResource, IHaveSSOApplicationTypesSignInOptionsSignInOptions, IHaveVisibility
        {
            /// <summary>
            /// SignInOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-application-portaloptionsconfiguration.html#cfn-sso-application-portaloptionsconfiguration-signinoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SignInOptions
            /// </summary>
            public Union<Humidifier.SSO.ApplicationTypes.SignInOptions, BaseFunction>? SignInOptions { get; set; }
            /// <summary>
            /// Visibility
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-application-portaloptionsconfiguration.html#cfn-sso-application-portaloptionsconfiguration-visibility
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Visibility { get; set; }
        }

        public class SignInOptions : Humidifier.Base.BaseSubResource, IHaveOrigin, IHaveApplicationUrl
        {
            /// <summary>
            /// Origin
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-application-signinoptions.html#cfn-sso-application-signinoptions-origin
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Origin { get; set; }
            /// <summary>
            /// ApplicationUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sso-application-signinoptions.html#cfn-sso-application-signinoptions-applicationurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationUrl { get; set; }
        }
    }
}