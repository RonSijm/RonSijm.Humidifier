namespace Humidifier.AppStream
{
    using global::System.Collections.Generic;
    using StackTypes;

    public class Stack : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveDisplayName, IHaveAttributesToDelete
    {
        public override string AWSTypeName { get => AWS.AppStream.Stack; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// StorageConnectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-storageconnectors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StorageConnector
        /// </summary>
        public List<Humidifier.AppStream.StackTypes.StorageConnector> StorageConnectors { get; set; }
        /// <summary>
        /// DeleteStorageConnectors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-deletestorageconnectors
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeleteStorageConnectors { get; set; }
        /// <summary>
        /// StorageConnectorAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-storageconnectorauthentication
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StorageConnectorAuthentication { get; set; }
        /// <summary>
        /// EmbedHostDomains
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-embedhostdomains
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic EmbedHostDomains { get; set; }
        /// <summary>
        /// ContentRedirection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-contentredirection
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContentRedirection
        /// </summary>
        public Humidifier.AppStream.StackTypes.ContentRedirection ContentRedirection { get; set; }
        /// <summary>
        /// UserSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-usersettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: UserSetting
        /// </summary>
        public List<Humidifier.AppStream.StackTypes.UserSetting> UserSettings { get; set; }
        /// <summary>
        /// AttributesToDelete
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-attributestodelete
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic AttributesToDelete { get; set; }
        /// <summary>
        /// RedirectURL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-redirecturl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RedirectURL { get; set; }
        /// <summary>
        /// StreamingExperienceSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-streamingexperiencesettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamingExperienceSettings
        /// </summary>
        public Humidifier.AppStream.StackTypes.StreamingExperienceSettings StreamingExperienceSettings { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// FeedbackURL
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-feedbackurl
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FeedbackURL { get; set; }
        /// <summary>
        /// ApplicationSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-applicationsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationSettings
        /// </summary>
        public Humidifier.AppStream.StackTypes.ApplicationSettings ApplicationSettings { get; set; }
        /// <summary>
        /// AgentAccessConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-agentaccessconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AgentAccessConfig
        /// </summary>
        public Humidifier.AppStream.StackTypes.AgentAccessConfig AgentAccessConfig { get; set; }
        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        /// <summary>
        /// AccessEndpoints
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-stack.html#cfn-appstream-stack-accessendpoints
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AccessEndpoint
        /// </summary>
        public List<Humidifier.AppStream.StackTypes.AccessEndpoint> AccessEndpoints { get; set; }
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
            public dynamic EndpointType { get; set; }
            /// <summary>
            /// VpceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-accessendpoint.html#cfn-appstream-stack-accessendpoint-vpceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpceId { get; set; }
        }

        public class AgentAccessConfig : Humidifier.Base.BaseSubResource, IHaveS3BucketArn
        {
            /// <summary>
            /// ScreenResolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-screenresolution
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScreenResolution { get; set; }
            /// <summary>
            /// ScreenImageFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-screenimageformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScreenImageFormat { get; set; }
            /// <summary>
            /// ScreenshotsUploadEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-screenshotsuploadenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ScreenshotsUploadEnabled { get; set; }
            /// <summary>
            /// UserControlMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-usercontrolmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserControlMode { get; set; }
            /// <summary>
            /// S3BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-s3bucketarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BucketArn { get; set; }
            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccessconfig.html#cfn-appstream-stack-agentaccessconfig-settings
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AgentAccessSetting
            /// </summary>
            public List<Humidifier.AppStream.StackTypes.AgentAccessSetting> Settings { get; set; }
        }

        public class AgentAccessSetting : Humidifier.Base.BaseSubResource, IHavePermission
        {
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccesssetting.html#cfn-appstream-stack-agentaccesssetting-permission
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Permission { get; set; }
            /// <summary>
            /// AgentAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-agentaccesssetting.html#cfn-appstream-stack-agentaccesssetting-agentaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AgentAction { get; set; }
        }

        public class ApplicationSettings : Humidifier.Base.BaseSubResource, IHaveEnabled, IHaveSettingsGroup
        {
            /// <summary>
            /// SettingsGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-applicationsettings.html#cfn-appstream-stack-applicationsettings-settingsgroup
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SettingsGroup { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-applicationsettings.html#cfn-appstream-stack-applicationsettings-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
        }

        public class ContentRedirection : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HostToClient
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-contentredirection.html#cfn-appstream-stack-contentredirection-hosttoclient
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UrlRedirectionConfig
            /// </summary>
            public Humidifier.AppStream.StackTypes.UrlRedirectionConfig HostToClient { get; set; }
        }

        public class StorageConnector : Humidifier.Base.BaseSubResource, IHaveResourceIdentifier, IHaveConnectorType, IHaveDomains
        {
            /// <summary>
            /// Domains
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-storageconnector.html#cfn-appstream-stack-storageconnector-domains
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Domains { get; set; }
            /// <summary>
            /// ResourceIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-storageconnector.html#cfn-appstream-stack-storageconnector-resourceidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceIdentifier { get; set; }
            /// <summary>
            /// ConnectorType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-storageconnector.html#cfn-appstream-stack-storageconnector-connectortype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorType { get; set; }
        }

        public class StreamingExperienceSettings : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PreferredProtocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-streamingexperiencesettings.html#cfn-appstream-stack-streamingexperiencesettings-preferredprotocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PreferredProtocol { get; set; }
        }

        public class UrlRedirectionConfig : Humidifier.Base.BaseSubResource, IHaveEnabled
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-urlredirectionconfig.html#cfn-appstream-stack-urlredirectionconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled { get; set; }
            /// <summary>
            /// AllowedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-urlredirectionconfig.html#cfn-appstream-stack-urlredirectionconfig-allowedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedUrls { get; set; }
            /// <summary>
            /// DeniedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-urlredirectionconfig.html#cfn-appstream-stack-urlredirectionconfig-deniedurls
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic DeniedUrls { get; set; }
        }

        public class UserSetting : Humidifier.Base.BaseSubResource, IHaveAction, IHavePermission, IHaveMaximumLength
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-usersetting.html#cfn-appstream-stack-usersetting-action
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action { get; set; }
            /// <summary>
            /// MaximumLength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-usersetting.html#cfn-appstream-stack-usersetting-maximumlength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumLength { get; set; }
            /// <summary>
            /// Permission
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-stack-usersetting.html#cfn-appstream-stack-usersetting-permission
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Permission { get; set; }
        }
    }
}