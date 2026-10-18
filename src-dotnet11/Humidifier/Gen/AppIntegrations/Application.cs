namespace Humidifier.AppIntegrations
{
    using global::System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAppIntegrationsApplicationTypesApplicationSourceConfigApplicationSourceConfig, IHaveApplicationType, IHaveDescription, IHaveAppIntegrationsApplicationTypesIframeConfigIframeConfig, IHaveInitializationTimeout_Integer, IHaveAppIntegrationsApplicationTypesApplicationConfigApplicationConfig, IHaveStringListOfPermissions, IHaveIsService_Boolean, IHaveNamespace_, IHaveName
    {
        public class Attributes
        {
            public static string ApplicationArn =  "ApplicationArn" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.AppIntegrations.Application; }

        /// <summary>
        /// ApplicationSourceConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-applicationsourceconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ApplicationSourceConfig
        /// </summary>
        [Required]
        public Union<Humidifier.AppIntegrations.ApplicationTypes.ApplicationSourceConfig, BaseFunction>? ApplicationSourceConfig { get; set; }
        /// <summary>
        /// ApplicationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-applicationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApplicationType { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// IframeConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-iframeconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: IframeConfig
        /// </summary>
        public Union<Humidifier.AppIntegrations.ApplicationTypes.IframeConfig, BaseFunction>? IframeConfig { get; set; }
        /// <summary>
        /// InitializationTimeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-initializationtimeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? InitializationTimeout { get; set; }
        /// <summary>
        /// ApplicationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-applicationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationConfig
        /// </summary>
        public Union<Humidifier.AppIntegrations.ApplicationTypes.ApplicationConfig, BaseFunction>? ApplicationConfig { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        /// <summary>
        /// IsService
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-isservice
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? IsService { get; set; }

        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-namespace
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Namespace_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appintegrations-application.html#cfn-appintegrations-application-tags
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
        public class ApplicationConfig : Humidifier.Base.BaseSubResource, IHaveAppIntegrationsApplicationTypesContactHandlingContactHandling
        {
            /// <summary>
            /// ContactHandling
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-application-applicationconfig.html#cfn-appintegrations-application-applicationconfig-contacthandling
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContactHandling
            /// </summary>
            public Union<Humidifier.AppIntegrations.ApplicationTypes.ContactHandling, BaseFunction>? ContactHandling { get; set; }
        }

        public class ApplicationSourceConfig : Humidifier.Base.BaseSubResource, IHaveAppIntegrationsApplicationTypesExternalUrlConfigExternalUrlConfig
        {
            /// <summary>
            /// ExternalUrlConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-application-applicationsourceconfig.html#cfn-appintegrations-application-applicationsourceconfig-externalurlconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ExternalUrlConfig
            /// </summary>
            public Union<Humidifier.AppIntegrations.ApplicationTypes.ExternalUrlConfig, BaseFunction>? ExternalUrlConfig { get; set; }
        }

        public class ContactHandling : Humidifier.Base.BaseSubResource, IHaveScope
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-application-contacthandling.html#cfn-appintegrations-application-contacthandling-scope
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
        }

        public class ExternalUrlConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfApprovedOrigins, IHaveAccessUrl
        {
            /// <summary>
            /// ApprovedOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-application-externalurlconfig.html#cfn-appintegrations-application-externalurlconfig-approvedorigins
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ApprovedOrigins { get; set; }
            /// <summary>
            /// AccessUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-application-externalurlconfig.html#cfn-appintegrations-application-externalurlconfig-accessurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessUrl { get; set; }
        }

        public class IframeConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfAllow, IHaveStringListOfSandbox
        {
            /// <summary>
            /// Allow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-application-iframeconfig.html#cfn-appintegrations-application-iframeconfig-allow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Allow { get; set; }
            /// <summary>
            /// Sandbox
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appintegrations-application-iframeconfig.html#cfn-appintegrations-application-iframeconfig-sandbox
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Sandbox { get; set; }
        }
    }
}