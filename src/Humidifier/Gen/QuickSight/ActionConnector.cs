namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using ActionConnectorTypes;

    public class ActionConnector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveType, IHaveAwsAccountId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string EnabledActions =  "EnabledActions" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.QuickSight.ActionConnector; }

        /// <summary>
        /// AuthenticationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-authenticationconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: AuthConfig
        /// </summary>
        [Required]
        public Humidifier.QuickSight.ActionConnectorTypes.AuthConfig AuthenticationConfig { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// ActionConnectorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-actionconnectorid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ActionConnectorId { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public List<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission> Permissions { get; set; }
        /// <summary>
        /// VpcConnectionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-vpcconnectionarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcConnectionArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ActionConnectorTypes
    {
        public class APIKeyConnectionMetadata : Humidifier.Base.BaseSubResource, IHaveEmail, IHaveApiKey
        {
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-apikeyconnectionmetadata.html#cfn-quicksight-actionconnector-apikeyconnectionmetadata-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKey { get; set; }
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-apikeyconnectionmetadata.html#cfn-quicksight-actionconnector-apikeyconnectionmetadata-email
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Email { get; set; }
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-apikeyconnectionmetadata.html#cfn-quicksight-actionconnector-apikeyconnectionmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseEndpoint { get; set; }
        }

        public class AuthConfig : Humidifier.Base.BaseSubResource, IHaveAuthenticationType
        {
            /// <summary>
            /// AuthenticationMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authconfig.html#cfn-quicksight-actionconnector-authconfig-authenticationmetadata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthenticationMetadata
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata AuthenticationMetadata { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authconfig.html#cfn-quicksight-actionconnector-authconfig-authenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthenticationType { get; set; }
        }

        public class AuthenticationMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BasicAuthConnectionMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-basicauthconnectionmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthConnectionMetadata
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.BasicAuthConnectionMetadata BasicAuthConnectionMetadata { get; set; }
            /// <summary>
            /// IamConnectionMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-iamconnectionmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IAMConnectionMetadata
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.IAMConnectionMetadata IamConnectionMetadata { get; set; }
            /// <summary>
            /// AuthorizationCodeGrantMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-authorizationcodegrantmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizationCodeGrantMetadata
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantMetadata AuthorizationCodeGrantMetadata { get; set; }
            /// <summary>
            /// ClientCredentialsGrantMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-clientcredentialsgrantmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientCredentialsGrantMetadata
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantMetadata ClientCredentialsGrantMetadata { get; set; }
            /// <summary>
            /// NoneConnectionMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-noneconnectionmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoneConnectionMetadata
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.NoneConnectionMetadata NoneConnectionMetadata { get; set; }
            /// <summary>
            /// ApiKeyConnectionMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-apikeyconnectionmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: APIKeyConnectionMetadata
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.APIKeyConnectionMetadata ApiKeyConnectionMetadata { get; set; }
        }

        public class AuthorizationCodeGrantCredentialsDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthorizationCodeGrantDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantcredentialsdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantcredentialsdetails-authorizationcodegrantdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthorizationCodeGrantDetails
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails AuthorizationCodeGrantDetails { get; set; }
        }

        public class AuthorizationCodeGrantDetails : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret, IHaveAuthorizationEndpoint, IHaveTokenEndpoint
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantdetails-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpoint { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantdetails-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantdetails-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantdetails-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationEndpoint { get; set; }
        }

        public class AuthorizationCodeGrantMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantmetadata.html#cfn-quicksight-actionconnector-authorizationcodegrantmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseEndpoint { get; set; }
            /// <summary>
            /// RedirectUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantmetadata.html#cfn-quicksight-actionconnector-authorizationcodegrantmetadata-redirecturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RedirectUrl { get; set; }
            /// <summary>
            /// AuthorizationCodeGrantCredentialsSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantmetadata.html#cfn-quicksight-actionconnector-authorizationcodegrantmetadata-authorizationcodegrantcredentialssource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationCodeGrantCredentialsSource { get; set; }
            /// <summary>
            /// AuthorizationCodeGrantCredentialsDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantmetadata.html#cfn-quicksight-actionconnector-authorizationcodegrantmetadata-authorizationcodegrantcredentialsdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizationCodeGrantCredentialsDetails
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails AuthorizationCodeGrantCredentialsDetails { get; set; }
        }

        public class BasicAuthConnectionMetadata : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-basicauthconnectionmetadata.html#cfn-quicksight-actionconnector-basicauthconnectionmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseEndpoint { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-basicauthconnectionmetadata.html#cfn-quicksight-actionconnector-basicauthconnectionmetadata-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-basicauthconnectionmetadata.html#cfn-quicksight-actionconnector-basicauthconnectionmetadata-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Password { get; set; }
        }

        public class ClientCredentialsDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ClientCredentialsGrantDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsdetails.html#cfn-quicksight-actionconnector-clientcredentialsdetails-clientcredentialsgrantdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClientCredentialsGrantDetails
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails ClientCredentialsGrantDetails { get; set; }
        }

        public class ClientCredentialsGrantDetails : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret, IHaveTokenEndpoint
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantdetails.html#cfn-quicksight-actionconnector-clientcredentialsgrantdetails-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpoint { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantdetails.html#cfn-quicksight-actionconnector-clientcredentialsgrantdetails-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantdetails.html#cfn-quicksight-actionconnector-clientcredentialsgrantdetails-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
        }

        public class ClientCredentialsGrantMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantmetadata.html#cfn-quicksight-actionconnector-clientcredentialsgrantmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseEndpoint { get; set; }
            /// <summary>
            /// ClientCredentialsSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantmetadata.html#cfn-quicksight-actionconnector-clientcredentialsgrantmetadata-clientcredentialssource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientCredentialsSource { get; set; }
            /// <summary>
            /// ClientCredentialsDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantmetadata.html#cfn-quicksight-actionconnector-clientcredentialsgrantmetadata-clientcredentialsdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientCredentialsDetails
            /// </summary>
            public Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails ClientCredentialsDetails { get; set; }
        }

        public class IAMConnectionMetadata : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-iamconnectionmetadata.html#cfn-quicksight-actionconnector-iamconnectionmetadata-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class NoneConnectionMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-noneconnectionmetadata.html#cfn-quicksight-actionconnector-noneconnectionmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BaseEndpoint { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHavePrincipal, IHaveActions
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-resourcepermission.html#cfn-quicksight-actionconnector-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-resourcepermission.html#cfn-quicksight-actionconnector-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Principal { get; set; }
        }
    }
}