namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using OAuth2CredentialProviderTypes;

    public class OAuth2CredentialProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCredentialProviderVendor, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesOauth2ProviderConfigInputOauth2ProviderConfigInput, IHaveName
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
        public Union<string, BaseFunction>? CredentialProviderVendor { get; set; }
        /// <summary>
        /// Oauth2ProviderConfigInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-oauth2credentialprovider.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Oauth2ProviderConfigInput
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2ProviderConfigInput, BaseFunction>? Oauth2ProviderConfigInput { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-oauth2credentialprovider.html#cfn-bedrockagentcore-oauth2credentialprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace OAuth2CredentialProviderTypes
    {
        public class AtlassianOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveClientSecret, IHaveClientId, IHaveClientSecretSource
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-atlassianoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
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
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class CustomOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesOnBehalfOfTokenExchangeConfigOnBehalfOfTokenExchangeConfig, IHaveListOfBedrockAgentCoreOAuth2CredentialProviderTypesPrivateEndpointOverridePrivateEndpointOverrides, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesPrivateKeyJwtConfigPrivateKeyJwtConfig, IHaveClientSecret, IHaveClientId, IHaveClientAuthenticationMethod, IHaveClientSecretSource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesPrivateEndpointPrivateEndpoint, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesOauth2DiscoveryOauthDiscovery
        {
            /// <summary>
            /// OnBehalfOfTokenExchangeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-onbehalfoftokenexchangeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnBehalfOfTokenExchangeConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig, BaseFunction>? OnBehalfOfTokenExchangeConfig { get; set; }
            /// <summary>
            /// PrivateEndpointOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-privateendpointoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateEndpointOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpointOverride>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpointOverride, BaseFunction>>, BaseFunction>? PrivateEndpointOverrides { get; set; }
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// PrivateKeyJwtConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-privatekeyjwtconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateKeyJwtConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig, BaseFunction>? PrivateKeyJwtConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientAuthenticationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientauthenticationmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientAuthenticationMethod { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-privateendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
            /// <summary>
            /// OauthDiscovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-customoauth2providerconfiginput-oauthdiscovery
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Oauth2Discovery
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery, BaseFunction>? OauthDiscovery { get; set; }
        }

        public class GithubOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveClientSecret, IHaveClientId, IHaveClientSecretSource
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-githuboauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
        }

        public class GoogleOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveClientSecret, IHaveClientId, IHaveClientSecretSource
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-googleoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
        }

        public class IncludedOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveTokenEndpoint, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveIssuer, IHaveClientSecret, IHaveClientId, IHaveAuthorizationEndpoint, IHaveClientSecretSource
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-tokenendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenEndpoint { get; set; }
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-authorizationendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationEndpoint { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-includedoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
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
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class LinkedinOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveClientSecret, IHaveClientId, IHaveClientSecretSource
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-linkedinoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
        }

        public class ManagedVpcResource : Humidifier.Base.BaseSubResource, IHaveRoutingDomain, IHaveVpcIdentifier, IHaveStringListOfSubnetIds, IHaveEndpointIpAddressType, IHaveStringListOfSecurityGroupIds, IHaveStringDictionaryOfTags
        {
            /// <summary>
            /// RoutingDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-routingdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoutingDomain { get; set; }
            /// <summary>
            /// VpcIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-vpcidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VpcIdentifier { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
            /// <summary>
            /// EndpointIpAddressType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-endpointipaddresstype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointIpAddressType { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-securitygroupids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-managedvpcresource.html#cfn-bedrockagentcore-oauth2credentialprovider-managedvpcresource-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        }

        public class MicrosoftOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveTenantId, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveClientSecret, IHaveClientId, IHaveClientSecretSource
        {
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-tenantid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-microsoftoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
        }

        public class Oauth2AuthorizationServerMetadata : Humidifier.Base.BaseSubResource, IHaveTokenEndpoint, IHaveStringListOfResponseTypes, IHaveIssuer, IHaveAuthorizationEndpoint
        {
            /// <summary>
            /// TokenEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata-tokenendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenEndpoint { get; set; }
            /// <summary>
            /// ResponseTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata-responsetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ResponseTypes { get; set; }
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// AuthorizationEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2authorizationservermetadata-authorizationendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationEndpoint { get; set; }
        }

        public class Oauth2Discovery : Humidifier.Base.BaseSubResource, IHaveDiscoveryUrl, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesOauth2AuthorizationServerMetadataAuthorizationServerMetadata
        {
            /// <summary>
            /// DiscoveryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2discovery.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2discovery-discoveryurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DiscoveryUrl { get; set; }
            /// <summary>
            /// AuthorizationServerMetadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2discovery.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2discovery-authorizationservermetadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Oauth2AuthorizationServerMetadata
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2AuthorizationServerMetadata, BaseFunction>? AuthorizationServerMetadata { get; set; }
        }

        public class Oauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesIncludedOauth2ProviderConfigInputIncludedOauth2ProviderConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesGoogleOauth2ProviderConfigInputGoogleOauth2ProviderConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesGithubOauth2ProviderConfigInputGithubOauth2ProviderConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesMicrosoftOauth2ProviderConfigInputMicrosoftOauth2ProviderConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSlackOauth2ProviderConfigInputSlackOauth2ProviderConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSalesforceOauth2ProviderConfigInputSalesforceOauth2ProviderConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesAtlassianOauth2ProviderConfigInputAtlassianOauth2ProviderConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesCustomOauth2ProviderConfigInputCustomOauth2ProviderConfig, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesLinkedinOauth2ProviderConfigInputLinkedinOauth2ProviderConfig
        {
            /// <summary>
            /// IncludedOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-includedoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IncludedOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.IncludedOauth2ProviderConfigInput, BaseFunction>? IncludedOauth2ProviderConfig { get; set; }
            /// <summary>
            /// GoogleOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-googleoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GoogleOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GoogleOauth2ProviderConfigInput, BaseFunction>? GoogleOauth2ProviderConfig { get; set; }
            /// <summary>
            /// GithubOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-githuboauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GithubOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.GithubOauth2ProviderConfigInput, BaseFunction>? GithubOauth2ProviderConfig { get; set; }
            /// <summary>
            /// MicrosoftOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-microsoftoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MicrosoftOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.MicrosoftOauth2ProviderConfigInput, BaseFunction>? MicrosoftOauth2ProviderConfig { get; set; }
            /// <summary>
            /// SlackOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-slackoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlackOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SlackOauth2ProviderConfigInput, BaseFunction>? SlackOauth2ProviderConfig { get; set; }
            /// <summary>
            /// SalesforceOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-salesforceoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SalesforceOauth2ProviderConfigInput, BaseFunction>? SalesforceOauth2ProviderConfig { get; set; }
            /// <summary>
            /// AtlassianOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-atlassianoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AtlassianOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.AtlassianOauth2ProviderConfigInput, BaseFunction>? AtlassianOauth2ProviderConfig { get; set; }
            /// <summary>
            /// CustomOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-customoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.CustomOauth2ProviderConfigInput, BaseFunction>? CustomOauth2ProviderConfig { get; set; }
            /// <summary>
            /// LinkedinOauth2ProviderConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfiginput-linkedinoauth2providerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinkedinOauth2ProviderConfigInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.LinkedinOauth2ProviderConfigInput, BaseFunction>? LinkedinOauth2ProviderConfig { get; set; }
        }

        public class Oauth2ProviderConfigOutput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesOnBehalfOfTokenExchangeConfigOnBehalfOfTokenExchangeConfig, IHaveListOfBedrockAgentCoreOAuth2CredentialProviderTypesPrivateEndpointOverridePrivateEndpointOverrides, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesPrivateKeyJwtConfigPrivateKeyJwtConfig, IHaveClientId, IHaveClientAuthenticationMethod, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesPrivateEndpointPrivateEndpoint, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesOauth2DiscoveryOauthDiscovery
        {
            /// <summary>
            /// OnBehalfOfTokenExchangeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-onbehalfoftokenexchangeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OnBehalfOfTokenExchangeConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.OnBehalfOfTokenExchangeConfig, BaseFunction>? OnBehalfOfTokenExchangeConfig { get; set; }
            /// <summary>
            /// PrivateEndpointOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-privateendpointoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateEndpointOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpointOverride>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpointOverride, BaseFunction>>, BaseFunction>? PrivateEndpointOverrides { get; set; }
            /// <summary>
            /// PrivateKeyJwtConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-privatekeyjwtconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateKeyJwtConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeyJwtConfig, BaseFunction>? PrivateKeyJwtConfig { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientAuthenticationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-clientauthenticationmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientAuthenticationMethod { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-privateendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
            /// <summary>
            /// OauthDiscovery
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput.html#cfn-bedrockagentcore-oauth2credentialprovider-oauth2providerconfigoutput-oauthdiscovery
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Oauth2Discovery
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.Oauth2Discovery, BaseFunction>? OauthDiscovery { get; set; }
        }

        public class OnBehalfOfTokenExchangeConfig : Humidifier.Base.BaseSubResource, IHaveGrantType, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesTokenExchangeGrantTypeConfigTokenExchangeGrantTypeConfig
        {
            /// <summary>
            /// GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-onbehalfoftokenexchangeconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-onbehalfoftokenexchangeconfig-granttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GrantType { get; set; }
            /// <summary>
            /// TokenExchangeGrantTypeConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-onbehalfoftokenexchangeconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-onbehalfoftokenexchangeconfig-tokenexchangegranttypeconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TokenExchangeGrantTypeConfig
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.TokenExchangeGrantTypeConfig, BaseFunction>? TokenExchangeGrantTypeConfig { get; set; }
        }

        public class PrivateEndpoint : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSelfManagedLatticeResourceSelfManagedLatticeResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesManagedVpcResourceManagedVpcResource
        {
            /// <summary>
            /// SelfManagedLatticeResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privateendpoint.html#cfn-bedrockagentcore-oauth2credentialprovider-privateendpoint-selfmanagedlatticeresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SelfManagedLatticeResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SelfManagedLatticeResource, BaseFunction>? SelfManagedLatticeResource { get; set; }
            /// <summary>
            /// ManagedVpcResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privateendpoint.html#cfn-bedrockagentcore-oauth2credentialprovider-privateendpoint-managedvpcresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedVpcResource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.ManagedVpcResource, BaseFunction>? ManagedVpcResource { get; set; }
        }

        public class PrivateEndpointOverride : Humidifier.Base.BaseSubResource, IHaveDomain, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesPrivateEndpointPrivateEndpoint
        {
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privateendpointoverride.html#cfn-bedrockagentcore-oauth2credentialprovider-privateendpointoverride-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
            /// <summary>
            /// PrivateEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privateendpointoverride.html#cfn-bedrockagentcore-oauth2credentialprovider-privateendpointoverride-privateendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// Type: PrivateEndpoint
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateEndpoint, BaseFunction>? PrivateEndpoint { get; set; }
        }

        public class PrivateKeyJwtConfig : Humidifier.Base.BaseSubResource, IHaveSigningAlgorithm, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesPrivateKeySourcePrivateKeySource, IHaveStringDictionaryOfAdditionalHeaderClaims, IHaveStringDictionaryOfAdditionalPayloadClaims
        {
            /// <summary>
            /// SigningAlgorithm
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig-signingalgorithm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SigningAlgorithm { get; set; }
            /// <summary>
            /// PrivateKeySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig-privatekeysource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PrivateKeySource
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.PrivateKeySource, BaseFunction>? PrivateKeySource { get; set; }
            /// <summary>
            /// AdditionalHeaderClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig-additionalheaderclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalHeaderClaims { get; set; }
            /// <summary>
            /// AdditionalPayloadClaims
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeyjwtconfig-additionalpayloadclaims
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AdditionalPayloadClaims { get; set; }
        }

        public class PrivateKeySource : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesKmsKeySourceTypeKmsKeySource
        {
            /// <summary>
            /// KmsKeySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-privatekeysource.html#cfn-bedrockagentcore-oauth2credentialprovider-privatekeysource-kmskeysource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KmsKeySourceType
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.KmsKeySourceType, BaseFunction>? KmsKeySource { get; set; }
        }

        public class SalesforceOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveClientSecret, IHaveClientId, IHaveClientSecretSource
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-salesforceoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
        }

        public class SecretReference : Humidifier.Base.BaseSubResource, IHaveJsonKey, IHaveSecretId
        {
            /// <summary>
            /// JsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-secretreference.html#cfn-bedrockagentcore-oauth2credentialprovider-secretreference-jsonkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JsonKey { get; set; }
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-secretreference.html#cfn-bedrockagentcore-oauth2credentialprovider-secretreference-secretid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretId { get; set; }
        }

        public class SelfManagedLatticeResource : Humidifier.Base.BaseSubResource, IHaveResourceConfigurationIdentifier
        {
            /// <summary>
            /// ResourceConfigurationIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-selfmanagedlatticeresource.html#cfn-bedrockagentcore-oauth2credentialprovider-selfmanagedlatticeresource-resourceconfigurationidentifier
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceConfigurationIdentifier { get; set; }
        }

        public class SlackOauth2ProviderConfigInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCoreOAuth2CredentialProviderTypesSecretReferenceClientSecretConfig, IHaveClientSecret, IHaveClientId, IHaveClientSecretSource
        {
            /// <summary>
            /// ClientSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput-clientsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.OAuth2CredentialProviderTypes.SecretReference, BaseFunction>? ClientSecretConfig { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput.html#cfn-bedrockagentcore-oauth2credentialprovider-slackoauth2providerconfiginput-clientsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecretSource { get; set; }
        }

        public class TokenExchangeGrantTypeConfig : Humidifier.Base.BaseSubResource, IHaveActorTokenContent, IHaveStringListOfActorTokenScopes
        {
            /// <summary>
            /// ActorTokenContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-tokenexchangegranttypeconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-tokenexchangegranttypeconfig-actortokencontent
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ActorTokenContent { get; set; }
            /// <summary>
            /// ActorTokenScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-oauth2credentialprovider-tokenexchangegranttypeconfig.html#cfn-bedrockagentcore-oauth2credentialprovider-tokenexchangegranttypeconfig-actortokenscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ActorTokenScopes { get; set; }
        }
    }
}