namespace Humidifier.QuickSight
{
    using global::System.Collections.Generic;
    using ActionConnectorTypes;

    public class ActionConnector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveQuickSightActionConnectorTypesAuthConfigAuthenticationConfig, IHaveType, IHaveDescription, IHaveActionConnectorId, IHaveAwsAccountId, IHaveListOfQuickSightActionConnectorTypesResourcePermissionPermissions, IHaveVpcConnectionArn, IHaveName
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
        public Union<Humidifier.QuickSight.ActionConnectorTypes.AuthConfig, BaseFunction>? AuthenticationConfig { get; set; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ActionConnectorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-actionconnectorid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ActionConnectorId { get; set; }

        /// <summary>
        /// AwsAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-awsaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AwsAccountId { get; set; }
        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ResourcePermission
        /// </summary>
        public Union<IReadOnlyList<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission>, IReadOnlyList<Union<Humidifier.QuickSight.ActionConnectorTypes.ResourcePermission, BaseFunction>>, BaseFunction>? Permissions { get; set; }
        /// <summary>
        /// VpcConnectionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-vpcconnectionarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VpcConnectionArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-quicksight-actionconnector.html#cfn-quicksight-actionconnector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ActionConnectorTypes
    {
        public class APIKeyConnectionMetadata : Humidifier.Base.BaseSubResource, IHaveApiKey, IHaveEmail, IHaveBaseEndpoint
        {
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-apikeyconnectionmetadata.html#cfn-quicksight-actionconnector-apikeyconnectionmetadata-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKey { get; set; }
            /// <summary>
            /// Email
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-apikeyconnectionmetadata.html#cfn-quicksight-actionconnector-apikeyconnectionmetadata-email
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Email { get; set; }
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-apikeyconnectionmetadata.html#cfn-quicksight-actionconnector-apikeyconnectionmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseEndpoint { get; set; }
        }

        public class AuthConfig : Humidifier.Base.BaseSubResource, IHaveQuickSightActionConnectorTypesAuthenticationMetadataAuthenticationMetadata, IHaveAuthenticationType
        {
            /// <summary>
            /// AuthenticationMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authconfig.html#cfn-quicksight-actionconnector-authconfig-authenticationmetadata
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthenticationMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.AuthenticationMetadata, BaseFunction>? AuthenticationMetadata { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authconfig.html#cfn-quicksight-actionconnector-authconfig-authenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class AuthenticationMetadata : Humidifier.Base.BaseSubResource, IHaveQuickSightActionConnectorTypesBasicAuthConnectionMetadataBasicAuthConnectionMetadata, IHaveQuickSightActionConnectorTypesIAMConnectionMetadataIamConnectionMetadata, IHaveQuickSightActionConnectorTypesAuthorizationCodeGrantMetadataAuthorizationCodeGrantMetadata, IHaveQuickSightActionConnectorTypesClientCredentialsGrantMetadataClientCredentialsGrantMetadata, IHaveQuickSightActionConnectorTypesNoneConnectionMetadataNoneConnectionMetadata, IHaveQuickSightActionConnectorTypesAPIKeyConnectionMetadataApiKeyConnectionMetadata
        {
            /// <summary>
            /// BasicAuthConnectionMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-basicauthconnectionmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthConnectionMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.BasicAuthConnectionMetadata, BaseFunction>? BasicAuthConnectionMetadata { get; set; }
            /// <summary>
            /// IamConnectionMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-iamconnectionmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IAMConnectionMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.IAMConnectionMetadata, BaseFunction>? IamConnectionMetadata { get; set; }
            /// <summary>
            /// AuthorizationCodeGrantMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-authorizationcodegrantmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizationCodeGrantMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantMetadata, BaseFunction>? AuthorizationCodeGrantMetadata { get; set; }
            /// <summary>
            /// ClientCredentialsGrantMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-clientcredentialsgrantmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientCredentialsGrantMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantMetadata, BaseFunction>? ClientCredentialsGrantMetadata { get; set; }
            /// <summary>
            /// NoneConnectionMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-noneconnectionmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoneConnectionMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.NoneConnectionMetadata, BaseFunction>? NoneConnectionMetadata { get; set; }
            /// <summary>
            /// ApiKeyConnectionMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authenticationmetadata.html#cfn-quicksight-actionconnector-authenticationmetadata-apikeyconnectionmetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: APIKeyConnectionMetadata
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.APIKeyConnectionMetadata, BaseFunction>? ApiKeyConnectionMetadata { get; set; }
        }

        public class AuthorizationCodeGrantCredentialsDetails : Humidifier.Base.BaseSubResource, IHaveQuickSightActionConnectorTypesAuthorizationCodeGrantDetailsAuthorizationCodeGrantDetails
        {
            /// <summary>
            /// AuthorizationCodeGrantDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantcredentialsdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantcredentialsdetails-authorizationcodegrantdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AuthorizationCodeGrantDetails
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantDetails, BaseFunction>? AuthorizationCodeGrantDetails { get; set; }
        }

        public class AuthorizationCodeGrantDetails : Humidifier.Base.BaseSubResource, IHaveTokenEndpoint, IHaveClientSecret, IHaveClientId, IHaveAuthorizationEndpoint
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantdetails-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenEndpoint { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantdetails-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantdetails-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantdetails.html#cfn-quicksight-actionconnector-authorizationcodegrantdetails-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationEndpoint { get; set; }
        }

        public class AuthorizationCodeGrantMetadata : Humidifier.Base.BaseSubResource, IHaveBaseEndpoint, IHaveRedirectUrl, IHaveAuthorizationCodeGrantCredentialsSource, IHaveQuickSightActionConnectorTypesAuthorizationCodeGrantCredentialsDetailsAuthorizationCodeGrantCredentialsDetails
        {
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantmetadata.html#cfn-quicksight-actionconnector-authorizationcodegrantmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseEndpoint { get; set; }
            /// <summary>
            /// RedirectUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantmetadata.html#cfn-quicksight-actionconnector-authorizationcodegrantmetadata-redirecturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedirectUrl { get; set; }
            /// <summary>
            /// AuthorizationCodeGrantCredentialsSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantmetadata.html#cfn-quicksight-actionconnector-authorizationcodegrantmetadata-authorizationcodegrantcredentialssource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationCodeGrantCredentialsSource { get; set; }
            /// <summary>
            /// AuthorizationCodeGrantCredentialsDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-authorizationcodegrantmetadata.html#cfn-quicksight-actionconnector-authorizationcodegrantmetadata-authorizationcodegrantcredentialsdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizationCodeGrantCredentialsDetails
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.AuthorizationCodeGrantCredentialsDetails, BaseFunction>? AuthorizationCodeGrantCredentialsDetails { get; set; }
        }

        public class BasicAuthConnectionMetadata : Humidifier.Base.BaseSubResource, IHaveBaseEndpoint, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-basicauthconnectionmetadata.html#cfn-quicksight-actionconnector-basicauthconnectionmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseEndpoint { get; set; }
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-basicauthconnectionmetadata.html#cfn-quicksight-actionconnector-basicauthconnectionmetadata-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-basicauthconnectionmetadata.html#cfn-quicksight-actionconnector-basicauthconnectionmetadata-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class ClientCredentialsDetails : Humidifier.Base.BaseSubResource, IHaveQuickSightActionConnectorTypesClientCredentialsGrantDetailsClientCredentialsGrantDetails
        {
            /// <summary>
            /// ClientCredentialsGrantDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsdetails.html#cfn-quicksight-actionconnector-clientcredentialsdetails-clientcredentialsgrantdetails
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ClientCredentialsGrantDetails
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsGrantDetails, BaseFunction>? ClientCredentialsGrantDetails { get; set; }
        }

        public class ClientCredentialsGrantDetails : Humidifier.Base.BaseSubResource, IHaveTokenEndpoint, IHaveClientSecret, IHaveClientId
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantdetails.html#cfn-quicksight-actionconnector-clientcredentialsgrantdetails-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenEndpoint { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantdetails.html#cfn-quicksight-actionconnector-clientcredentialsgrantdetails-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantdetails.html#cfn-quicksight-actionconnector-clientcredentialsgrantdetails-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
        }

        public class ClientCredentialsGrantMetadata : Humidifier.Base.BaseSubResource, IHaveBaseEndpoint, IHaveClientCredentialsSource, IHaveQuickSightActionConnectorTypesClientCredentialsDetailsClientCredentialsDetails
        {
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantmetadata.html#cfn-quicksight-actionconnector-clientcredentialsgrantmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseEndpoint { get; set; }
            /// <summary>
            /// ClientCredentialsSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantmetadata.html#cfn-quicksight-actionconnector-clientcredentialsgrantmetadata-clientcredentialssource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCredentialsSource { get; set; }
            /// <summary>
            /// ClientCredentialsDetails
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-clientcredentialsgrantmetadata.html#cfn-quicksight-actionconnector-clientcredentialsgrantmetadata-clientcredentialsdetails
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ClientCredentialsDetails
            /// </summary>
            public Union<Humidifier.QuickSight.ActionConnectorTypes.ClientCredentialsDetails, BaseFunction>? ClientCredentialsDetails { get; set; }
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
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class NoneConnectionMetadata : Humidifier.Base.BaseSubResource, IHaveBaseEndpoint
        {
            /// <summary>
            /// BaseEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-noneconnectionmetadata.html#cfn-quicksight-actionconnector-noneconnectionmetadata-baseendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BaseEndpoint { get; set; }
        }

        public class ResourcePermission : Humidifier.Base.BaseSubResource, IHaveStringListOfActions, IHavePrincipal
        {
            /// <summary>
            /// Actions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-resourcepermission.html#cfn-quicksight-actionconnector-resourcepermission-actions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Actions { get; set; }
            /// <summary>
            /// Principal
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-quicksight-actionconnector-resourcepermission.html#cfn-quicksight-actionconnector-resourcepermission-principal
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Principal { get; set; }
        }
    }
}