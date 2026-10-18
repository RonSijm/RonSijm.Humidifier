namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;
    using StackTypes;

    public class Stack : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveListOfAppStreamStackTypesStorageConnectorStorageConnectors, IHaveDeleteStorageConnectors_Boolean, IHaveStringListOfEmbedHostDomains, IHaveAppStreamStackTypesContentRedirectionContentRedirection, IHaveListOfAppStreamStackTypesUserSettingUserSettings, IHaveStringListOfAttributesToDelete, IHaveRedirectURL, IHaveAppStreamStackTypesStreamingExperienceSettingsStreamingExperienceSettings, IHaveName, IHaveFeedbackURL, IHaveAppStreamStackTypesApplicationSettingsApplicationSettings, IHaveAppStreamStackTypesAgentAccessConfigAgentAccessConfig, IHaveDisplayName, IHaveListOfAppStreamStackTypesAccessEndpointAccessEndpoints
    {
        public override string AWSTypeName { get => AWS.AppStream.Stack; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// StorageConnectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-storageconnectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StorageConnector
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppStream.StackTypes.StorageConnector>, IReadOnlyList<Union<Humidifier.AppStream.StackTypes.StorageConnector, BaseFunction>>, BaseFunction>? StorageConnectors { get; set; }
        /// <summary>
        /// DeleteStorageConnectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-deletestorageconnectors
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeleteStorageConnectors { get; set; }
        /// <summary>
        /// EmbedHostDomains
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-embedhostdomains
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EmbedHostDomains { get; set; }
        /// <summary>
        /// ContentRedirection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-contentredirection
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContentRedirection
        /// </summary>
        public Union<Humidifier.AppStream.StackTypes.ContentRedirection, BaseFunction>? ContentRedirection { get; set; }
        /// <summary>
        /// UserSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-usersettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: UserSetting
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppStream.StackTypes.UserSetting>, IReadOnlyList<Union<Humidifier.AppStream.StackTypes.UserSetting, BaseFunction>>, BaseFunction>? UserSettings { get; set; }
        /// <summary>
        /// AttributesToDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-attributestodelete
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AttributesToDelete { get; set; }
        /// <summary>
        /// RedirectURL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-redirecturl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RedirectURL { get; set; }
        /// <summary>
        /// StreamingExperienceSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-streamingexperiencesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamingExperienceSettings
        /// </summary>
        public Union<Humidifier.AppStream.StackTypes.StreamingExperienceSettings, BaseFunction>? StreamingExperienceSettings { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// FeedbackURL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-feedbackurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FeedbackURL { get; set; }
        /// <summary>
        /// ApplicationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-applicationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationSettings
        /// </summary>
        public Union<Humidifier.AppStream.StackTypes.ApplicationSettings, BaseFunction>? ApplicationSettings { get; set; }
        /// <summary>
        /// AgentAccessConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-agentaccessconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AgentAccessConfig
        /// </summary>
        public Union<Humidifier.AppStream.StackTypes.AgentAccessConfig, BaseFunction>? AgentAccessConfig { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AccessEndpoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-accessendpoints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessEndpoint
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppStream.StackTypes.AccessEndpoint>, IReadOnlyList<Union<Humidifier.AppStream.StackTypes.AccessEndpoint, BaseFunction>>, BaseFunction>? AccessEndpoints { get; set; }
    }

    namespace StackTypes
    {
        public class AccessEndpoint : Humidifier.Base.BaseSubResource, IHaveEndpointType, IHaveVpceId
        {
            /// <summary>
            /// EndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-accessendpoint.html#cfn-appstream-stack-accessendpoint-endpointtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointType { get; set; }
            /// <summary>
            /// VpceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-accessendpoint.html#cfn-appstream-stack-accessendpoint-vpceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpceId { get; set; }
        }

        public class AgentAccessConfig : Humidifier.Base.BaseSubResource, IHaveScreenResolution, IHaveScreenImageFormat, IHaveScreenshotsUploadEnabled_Boolean, IHaveUserControlMode, IHaveS3BucketArn, IHaveListOfAppStreamStackTypesAgentAccessSettingSettings
        {
            /// <summary>
            /// ScreenResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-screenresolution
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScreenResolution { get; set; }
            /// <summary>
            /// ScreenImageFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-screenimageformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScreenImageFormat { get; set; }
            /// <summary>
            /// ScreenshotsUploadEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-screenshotsuploadenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ScreenshotsUploadEnabled { get; set; }
            /// <summary>
            /// UserControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-usercontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserControlMode { get; set; }
            /// <summary>
            /// S3BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-s3bucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3BucketArn { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-settings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AgentAccessSetting
            /// </summary>
            public Union<IReadOnlyList<Humidifier.AppStream.StackTypes.AgentAccessSetting>, IReadOnlyList<Union<Humidifier.AppStream.StackTypes.AgentAccessSetting, BaseFunction>>, BaseFunction>? Settings { get; set; }
        }

        public class AgentAccessSetting : Humidifier.Base.BaseSubResource, IHavePermission, IHaveAgentAction
        {
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccesssetting.html#cfn-appstream-stack-agentaccesssetting-permission
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permission { get; set; }
            /// <summary>
            /// AgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccesssetting.html#cfn-appstream-stack-agentaccesssetting-agentaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AgentAction { get; set; }
        }

        public class ApplicationSettings : Humidifier.Base.BaseSubResource, IHaveSettingsGroup, IHaveEnabled_Boolean
        {
            /// <summary>
            /// SettingsGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-applicationsettings.html#cfn-appstream-stack-applicationsettings-settingsgroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SettingsGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-applicationsettings.html#cfn-appstream-stack-applicationsettings-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class ContentRedirection : Humidifier.Base.BaseSubResource, IHaveAppStreamStackTypesUrlRedirectionConfigHostToClient
        {
            /// <summary>
            /// HostToClient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-contentredirection.html#cfn-appstream-stack-contentredirection-hosttoclient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UrlRedirectionConfig
            /// </summary>
            public Union<Humidifier.AppStream.StackTypes.UrlRedirectionConfig, BaseFunction>? HostToClient { get; set; }
        }

        public class StorageConnector : Humidifier.Base.BaseSubResource, IHaveStringListOfDomains, IHaveResourceIdentifier, IHaveConnectorType
        {
            /// <summary>
            /// Domains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-storageconnector.html#cfn-appstream-stack-storageconnector-domains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Domains { get; set; }
            /// <summary>
            /// ResourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-storageconnector.html#cfn-appstream-stack-storageconnector-resourceidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceIdentifier { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-storageconnector.html#cfn-appstream-stack-storageconnector-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorType { get; set; }
        }

        public class StreamingExperienceSettings : Humidifier.Base.BaseSubResource, IHavePreferredProtocol
        {
            /// <summary>
            /// PreferredProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-streamingexperiencesettings.html#cfn-appstream-stack-streamingexperiencesettings-preferredprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PreferredProtocol { get; set; }
        }

        public class UrlRedirectionConfig : Humidifier.Base.BaseSubResource, IHaveEnabled_Boolean, IHaveStringListOfAllowedUrls, IHaveStringListOfDeniedUrls
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-urlredirectionconfig.html#cfn-appstream-stack-urlredirectionconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
            /// <summary>
            /// AllowedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-urlredirectionconfig.html#cfn-appstream-stack-urlredirectionconfig-allowedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedUrls { get; set; }
            /// <summary>
            /// DeniedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-urlredirectionconfig.html#cfn-appstream-stack-urlredirectionconfig-deniedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? DeniedUrls { get; set; }
        }

        public class UserSetting : Humidifier.Base.BaseSubResource, IHaveAction, IHaveMaximumLength_Integer, IHavePermission
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-usersetting.html#cfn-appstream-stack-usersetting-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Action { get; set; }
            /// <summary>
            /// MaximumLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-usersetting.html#cfn-appstream-stack-usersetting-maximumlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaximumLength { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-usersetting.html#cfn-appstream-stack-usersetting-permission
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Permission { get; set; }
        }
    }
}