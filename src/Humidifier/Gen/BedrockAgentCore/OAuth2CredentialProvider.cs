namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using OAuth2CredentialProviderTypes;

    public class OAuth2CredentialProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string CredentialProviderArn =  "CredentialProviderArn" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string ClientSecretSource =  "ClientSecretSource" ;
            public static string CallbackUrl =  "CallbackUrl" ;
            public static string ClientSecretArn =  "ClientSecretArn" ;
            public static string Status =  "Status" ;
            public static string ClientSecretJsonKey =  "ClientSecretJsonKey" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string Oauth2ProviderConfigOutput =  "Oauth2ProviderConfigOutput" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.OAuth2CredentialProvider; }

        /// <summary>
        /// CredentialProviderVendor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-oauth2credentialprovider.html#cfn-bedrockagentcore-oauth2credentialprovider-credentialprovidervendor
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic CredentialProviderVendor { get; set; }
        /// <summary>
        /// Oauth2ProviderConfigInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-oauth2credentialprovider.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Oauth2ProviderConfigInput
        /// </summary>
        public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput Oauth2ProviderConfigInput { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-oauth2credentialprovider.html#cfn-bedrockagentcore-oauth2credentialprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace OAuth2CredentialProviderTypes
    {
        public class AtlassianOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
        }

        public class ClientSecretArn : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-clientsecretarn.html#cfn-bedrockagentcore-oauth2credentialprovider-clientsecretarn-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn { get; set; }
        }

        public class CustomOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// OnBehalfOfTokenExchangeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-onbehalfoftokenexchangeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnBehalfOfTokenExchangeConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig OnBehalfOfTokenExchangeConfig { get; set; }
            /// <summary>
            /// PrivateEndpointOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-privateendpointoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateEndpointOverride
            /// </summary>
            public List<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpointOverride> PrivateEndpointOverrides { get; set; }
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// PrivateKeyJwtConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-privatekeyjwtconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateKeyJwtConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig PrivateKeyJwtConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientAuthenticationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientauthenticationmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientAuthenticationMethod { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-privateendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpoint PrivateEndpoint { get; set; }
            /// <summary>
            /// OauthDiscovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-oauthdiscovery
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Oauth2Discovery
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery OauthDiscovery { get; set; }
        }

        public class GithubOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
        }

        public class GoogleOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
        }

        public class IncludedOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret, IHaveIssuer, IHaveAuthorizationEndpoint, IHaveTokenEndpoint
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-tokenendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpoint { get; set; }
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-authorizationendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationEndpoint { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
        }

        public class KmsKeySourceType : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-kmskeysourcetype.html#cfn-bedrockagentcore-oauth2credentialprovider-kmskeysourcetype-kmskeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
        }

        public class LinkedinOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
        }

        public class ManagedVpcResource : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds, IHaveVpcIdentifier
        {
            /// <summary>
            /// RoutingDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-routingdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoutingDomain { get; set; }
            /// <summary>
            /// VpcIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-vpcidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcIdentifier { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
            /// <summary>
            /// EndpointIpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-endpointipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndpointIpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Tags { get; set; }
        }

        public class MicrosoftOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret, IHaveTenantId
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-tenantid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
        }

        public class Oauth2AuthorizationServerMetadata : Humidifier.Base.BaseSubResource, IHaveIssuer, IHaveAuthorizationEndpoint, IHaveTokenEndpoint
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenEndpoint { get; set; }
            /// <summary>
            /// ResponseTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata-responsetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResponseTypes { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationEndpoint { get; set; }
        }

        public class Oauth2Discovery : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2discovery.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2discovery-discoveryurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DiscoveryUrl { get; set; }
            /// <summary>
            /// AuthorizationServerMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2discovery.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2discovery-authorizationservermetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Oauth2AuthorizationServerMetadata
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata AuthorizationServerMetadata { get; set; }
        }

        public class Oauth2ProviderConfigInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IncludedOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-includedoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IncludedOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.IncludedOauth2ProviderConfigInput IncludedOauth2ProviderConfig { get; set; }
            /// <summary>
            /// GoogleOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-googleoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GoogleOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GoogleOauth2ProviderConfigInput GoogleOauth2ProviderConfig { get; set; }
            /// <summary>
            /// GithubOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-githuboauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GithubOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GithubOauth2ProviderConfigInput GithubOauth2ProviderConfig { get; set; }
            /// <summary>
            /// MicrosoftOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-microsoftoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrosoftOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.MicrosoftOauth2ProviderConfigInput MicrosoftOauth2ProviderConfig { get; set; }
            /// <summary>
            /// SlackOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-slackoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlackOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SlackOauth2ProviderConfigInput SlackOauth2ProviderConfig { get; set; }
            /// <summary>
            /// SalesforceOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-salesforceoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SalesforceOauth2ProviderConfigInput SalesforceOauth2ProviderConfig { get; set; }
            /// <summary>
            /// AtlassianOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-atlassianoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AtlassianOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.AtlassianOauth2ProviderConfigInput AtlassianOauth2ProviderConfig { get; set; }
            /// <summary>
            /// CustomOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-customoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.CustomOauth2ProviderConfigInput CustomOauth2ProviderConfig { get; set; }
            /// <summary>
            /// LinkedinOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-linkedinoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinkedinOauth2ProviderConfigInput
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.LinkedinOauth2ProviderConfigInput LinkedinOauth2ProviderConfig { get; set; }
        }

        public class Oauth2ProviderConfigOutput : Humidifier.Base.BaseSubResource, IHaveClientId
        {
            /// <summary>
            /// OnBehalfOfTokenExchangeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-onbehalfoftokenexchangeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnBehalfOfTokenExchangeConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig OnBehalfOfTokenExchangeConfig { get; set; }
            /// <summary>
            /// PrivateEndpointOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-privateendpointoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateEndpointOverride
            /// </summary>
            public List<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpointOverride> PrivateEndpointOverrides { get; set; }
            /// <summary>
            /// PrivateKeyJwtConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-privatekeyjwtconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateKeyJwtConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig PrivateKeyJwtConfig { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientAuthenticationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-clientauthenticationmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientAuthenticationMethod { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-privateendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpoint PrivateEndpoint { get; set; }
            /// <summary>
            /// OauthDiscovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-oauthdiscovery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Oauth2Discovery
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery OauthDiscovery { get; set; }
        }

        public class OnBehalfOfTokenExchangeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-onbehalfoftokenexchangeconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-onbehalfoftokenexchangeconfig-granttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GrantType { get; set; }
            /// <summary>
            /// TokenExchangeGrantTypeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-onbehalfoftokenexchangeconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-onbehalfoftokenexchangeconfig-tokenexchangegranttypeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TokenExchangeGrantTypeConfig
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig TokenExchangeGrantTypeConfig { get; set; }
        }

        public class PrivateEndpoint : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SelfManagedLatticeResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privateendpoint.html#cfn-bedrockagentcore-oauth2credentialprovider-privateendpoint-selfmanagedlatticeresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedLatticeResource
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SelfManagedLatticeResource SelfManagedLatticeResource { get; set; }
            /// <summary>
            /// ManagedVpcResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privateendpoint.html#cfn-bedrockagentcore-oauth2credentialprovider-privateendpoint-managedvpcresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedVpcResource
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.ManagedVpcResource ManagedVpcResource { get; set; }
        }

        public class PrivateEndpointOverride : Humidifier.Base.BaseSubResource, IHaveDomain
        {
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privateendpointoverride.html#cfn-bedrockagentcore-oauth2credentialprovider-privateendpointoverride-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Domain { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privateendpointoverride.html#cfn-bedrockagentcore-oauth2credentialprovider-privateendpointoverride-privateendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpoint PrivateEndpoint { get; set; }
        }

        public class PrivateKeyJwtConfig : Humidifier.Base.BaseSubResource, IHaveSigningAlgorithm
        {
            /// <summary>
            /// SigningAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig-signingalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SigningAlgorithm { get; set; }
            /// <summary>
            /// PrivateKeySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig-privatekeysource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateKeySource
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource PrivateKeySource { get; set; }
            /// <summary>
            /// AdditionalHeaderClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig-additionalheaderclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> AdditionalHeaderClaims { get; set; }
            /// <summary>
            /// AdditionalPayloadClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig-additionalpayloadclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> AdditionalPayloadClaims { get; set; }
        }

        public class PrivateKeySource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KmsKeySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeysource.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeysource-kmskeysource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KmsKeySourceType
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType KmsKeySource { get; set; }
        }

        public class SalesforceOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
        }

        public class SecretReference : Humidifier.Base.BaseSubResource, IHaveSecretId
        {
            /// <summary>
            /// JsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-secretreference.html#cfn-bedrockagentcore-oauth2credentialprovider-secretreference-jsonkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JsonKey { get; set; }
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-secretreference.html#cfn-bedrockagentcore-oauth2credentialprovider-secretreference-secretid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretId { get; set; }
        }

        public class SelfManagedLatticeResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResourceConfigurationIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-selfmanagedlatticeresource.html#cfn-bedrockagentcore-oauth2credentialprovider-selfmanagedlatticeresource-resourceconfigurationidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceConfigurationIdentifier { get; set; }
        }

        public class SlackOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecretSource { get; set; }
        }

        public class TokenExchangeGrantTypeConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ActorTokenContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-tokenexchangegranttypeconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-tokenexchangegranttypeconfig-actortokencontent
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ActorTokenContent { get; set; }
            /// <summary>
            /// ActorTokenScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-tokenexchangegranttypeconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-tokenexchangegranttypeconfig-actortokenscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ActorTokenScopes { get; set; }
        }
    }
}