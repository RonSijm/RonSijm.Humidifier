namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using ConnectionTypeTypes;

    public class ConnectionType : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveConnectionType_, IHaveGlueConnectionTypeTypesConnectorAuthenticationConfigurationConnectorAuthenticationConfiguration, IHaveGlueConnectionTypeTypesConnectionPropertiesConfigurationConnectionProperties, IHaveGlueConnectionTypeTypesRestConfigurationRestConfiguration, IHaveIntegrationType
    {
        public class Attributes
        {
            public static string ConnectionTypeArn =  "ConnectionTypeArn" ;
        }

        public override string AWSTypeName { get => AWS.Glue.ConnectionType; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ConnectionType_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-connectiontype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectionType_ { get; set; }
        /// <summary>
        /// ConnectorAuthenticationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-connectorauthenticationconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectorAuthenticationConfiguration
        /// </summary>
        public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorAuthenticationConfiguration, BaseFunction>? ConnectorAuthenticationConfiguration { get; set; }
        /// <summary>
        /// ConnectionProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-connectionproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectionPropertiesConfiguration
        /// </summary>
        public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectionPropertiesConfiguration, BaseFunction>? ConnectionProperties { get; set; }

        /// <summary>
        /// RestConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-restconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RestConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.ConnectionTypeTypes.RestConfiguration, BaseFunction>? RestConfiguration { get; set; }
        /// <summary>
        /// IntegrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-integrationtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IntegrationType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ConnectionTypeTypes
    {
        public class BasicAuthenticationProperties : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesSecretConnectorPropertyUsername, IHaveGlueConnectionTypeTypesSecretConnectorPropertyPassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-basicauthenticationproperties.html#cfn-glue-connectiontype-basicauthenticationproperties-username
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-basicauthenticationproperties.html#cfn-glue-connectiontype-basicauthenticationproperties-password
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty, BaseFunction>? Password { get; set; }
        }

        public class BetweenConfiguration : Humidifier.Base.BaseSubResource, IHaveLowBoundKey, IHaveHighBoundKey, IHaveTemplate
        {
            /// <summary>
            /// LowBoundKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-betweenconfiguration.html#cfn-glue-connectiontype-betweenconfiguration-lowboundkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LowBoundKey { get; set; }
            /// <summary>
            /// HighBoundKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-betweenconfiguration.html#cfn-glue-connectiontype-betweenconfiguration-highboundkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HighBoundKey { get; set; }
            /// <summary>
            /// Template
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-betweenconfiguration.html#cfn-glue-connectiontype-betweenconfiguration-template
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Template { get; set; }
        }

        public class ClientCredentialsProperties : Humidifier.Base.BaseSubResource, IHaveContentType, IHaveGlueConnectionTypeTypesConnectorPropertyScope, IHaveRequestMethod, IHaveGlueConnectionTypeTypesSecretConnectorPropertyClientSecret, IHaveGlueConnectionTypeTypesConnectorPropertyTokenUrl, IHaveGlueConnectionTypeTypesSecretConnectorPropertyClientId, IHaveListOfGlueConnectionTypeTypesConnectorPropertyTokenUrlParameters
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-scope
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequestMethod { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-clientsecret
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-tokenurl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? TokenUrl { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-clientid
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// TokenUrlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-tokenurlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty>, IReadOnlyList<Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>>, BaseFunction>? TokenUrlParameters { get; set; }
        }

        public class ConnectionPropertiesConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfGlueConnectionTypeTypesConnectorPropertyAdditionalRequestParameters, IHaveGlueConnectionTypeTypesConnectorPropertyUrl
        {
            /// <summary>
            /// AdditionalRequestParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectionpropertiesconfiguration.html#cfn-glue-connectiontype-connectionpropertiesconfiguration-additionalrequestparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty>, IReadOnlyList<Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>>, BaseFunction>? AdditionalRequestParameters { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectionpropertiesconfiguration.html#cfn-glue-connectiontype-connectionpropertiesconfiguration-url
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? Url { get; set; }
        }

        public class ConnectorAuthenticationConfiguration : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesCustomAuthenticationPropertiesCustomAuthenticationProperties, IHaveGlueConnectionTypeTypesConnectorOAuth2PropertiesOAuth2Properties, IHaveStringListOfAuthenticationTypes, IHaveGlueConnectionTypeTypesBasicAuthenticationPropertiesBasicAuthenticationProperties
        {
            /// <summary>
            /// CustomAuthenticationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthenticationconfiguration.html#cfn-glue-connectiontype-connectorauthenticationconfiguration-customauthenticationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CustomAuthenticationProperties
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.CustomAuthenticationProperties, BaseFunction>? CustomAuthenticationProperties { get; set; }
            /// <summary>
            /// OAuth2Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthenticationconfiguration.html#cfn-glue-connectiontype-connectorauthenticationconfiguration-oauth2properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorOAuth2Properties
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorOAuth2Properties, BaseFunction>? OAuth2Properties { get; set; }
            /// <summary>
            /// AuthenticationTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthenticationconfiguration.html#cfn-glue-connectiontype-connectorauthenticationconfiguration-authenticationtypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AuthenticationTypes { get; set; }
            /// <summary>
            /// BasicAuthenticationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthenticationconfiguration.html#cfn-glue-connectiontype-connectorauthenticationconfiguration-basicauthenticationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BasicAuthenticationProperties
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.BasicAuthenticationProperties, BaseFunction>? BasicAuthenticationProperties { get; set; }
        }

        public class ConnectorAuthorizationCodeProperties : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesConnectorPropertyAuthorizationCodeUrl, IHaveGlueConnectionTypeTypesConnectorPropertyAuthorizationCode, IHaveContentType, IHaveGlueConnectionTypeTypesConnectorPropertyScope, IHaveRequestMethod, IHaveGlueConnectionTypeTypesSecretConnectorPropertyClientSecret, IHaveGlueConnectionTypeTypesConnectorPropertyTokenUrl, IHaveGlueConnectionTypeTypesSecretConnectorPropertyClientId, IHaveGlueConnectionTypeTypesConnectorPropertyRedirectUri, IHaveGlueConnectionTypeTypesConnectorPropertyPrompt, IHaveListOfGlueConnectionTypeTypesConnectorPropertyTokenUrlParameters
        {
            /// <summary>
            /// AuthorizationCodeUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-authorizationcodeurl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? AuthorizationCodeUrl { get; set; }
            /// <summary>
            /// AuthorizationCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-authorizationcode
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? AuthorizationCode { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-scope
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequestMethod { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-clientsecret
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-tokenurl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? TokenUrl { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-clientid
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// RedirectUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-redirecturi
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? RedirectUri { get; set; }
            /// <summary>
            /// Prompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-prompt
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? Prompt { get; set; }
            /// <summary>
            /// TokenUrlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-tokenurlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty>, IReadOnlyList<Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>>, BaseFunction>? TokenUrlParameters { get; set; }
        }

        public class ConnectorOAuth2Properties : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesConnectorAuthorizationCodePropertiesAuthorizationCodeProperties, IHaveGlueConnectionTypeTypesClientCredentialsPropertiesClientCredentialsProperties, IHaveGlueConnectionTypeTypesJWTBearerPropertiesJWTBearerProperties, IHaveOAuth2GrantType
        {
            /// <summary>
            /// AuthorizationCodeProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectoroauth2properties.html#cfn-glue-connectiontype-connectoroauth2properties-authorizationcodeproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorAuthorizationCodeProperties
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorAuthorizationCodeProperties, BaseFunction>? AuthorizationCodeProperties { get; set; }
            /// <summary>
            /// ClientCredentialsProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectoroauth2properties.html#cfn-glue-connectiontype-connectoroauth2properties-clientcredentialsproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClientCredentialsProperties
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ClientCredentialsProperties, BaseFunction>? ClientCredentialsProperties { get; set; }
            /// <summary>
            /// JWTBearerProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectoroauth2properties.html#cfn-glue-connectiontype-connectoroauth2properties-jwtbearerproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: JWTBearerProperties
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.JWTBearerProperties, BaseFunction>? JWTBearerProperties { get; set; }
            /// <summary>
            /// OAuth2GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectoroauth2properties.html#cfn-glue-connectiontype-connectoroauth2properties-oauth2granttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OAuth2GrantType { get; set; }
        }

        public class ConnectorProperty : Humidifier.Base.BaseSubResource, IHaveDefaultValue, IHaveStringListOfAllowedValues, IHaveRequired_Boolean, IHavePropertyLocation, IHaveKeyOverride, IHavePropertyType, IHaveName
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-allowedvalues
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedValues { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-required
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// PropertyLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-propertylocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyLocation { get; set; }
            /// <summary>
            /// KeyOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-keyoverride
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyOverride { get; set; }
            /// <summary>
            /// PropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-propertytype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class CursorConfiguration : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesExtractedParameterLimitParameter, IHaveGlueConnectionTypeTypesExtractedParameterNextPage
        {
            /// <summary>
            /// LimitParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-cursorconfiguration.html#cfn-glue-connectiontype-cursorconfiguration-limitparameter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ExtractedParameter
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter, BaseFunction>? LimitParameter { get; set; }
            /// <summary>
            /// NextPage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-cursorconfiguration.html#cfn-glue-connectiontype-cursorconfiguration-nextpage
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ExtractedParameter
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter, BaseFunction>? NextPage { get; set; }
        }

        public class CustomAuthenticationProperties : Humidifier.Base.BaseSubResource, IHaveListOfGlueConnectionTypeTypesSecretConnectorPropertyAuthenticationParameters
        {
            /// <summary>
            /// AuthenticationParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-customauthenticationproperties.html#cfn-glue-connectiontype-customauthenticationproperties-authenticationparameters
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SecretConnectorProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty>, IReadOnlyList<Union<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty, BaseFunction>>, BaseFunction>? AuthenticationParameters { get; set; }
        }

        public class EntityConfiguration : Humidifier.Base.BaseSubResource, IHaveMapOfGlueConnectionTypeTypesFieldDefinitionSchema, IHaveGlueConnectionTypeTypesSourceConfigurationSourceConfiguration
        {
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-entityconfiguration.html#cfn-glue-connectiontype-entityconfiguration-schema
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: FieldDefinition
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Glue.ConnectionTypeTypes.FieldDefinition>, IReadOnlyDictionary<string, Union<Humidifier.Glue.ConnectionTypeTypes.FieldDefinition, BaseFunction>>, BaseFunction>? Schema { get; set; }
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-entityconfiguration.html#cfn-glue-connectiontype-entityconfiguration-sourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
        }

        public class ExtractedParameter : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesResponseExtractionMappingValue, IHaveDefaultValue, IHavePropertyLocation, IHaveKey
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-extractedparameter.html#cfn-glue-connectiontype-extractedparameter-value
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResponseExtractionMapping
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping, BaseFunction>? Value { get; set; }
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-extractedparameter.html#cfn-glue-connectiontype-extractedparameter-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultValue { get; set; }
            /// <summary>
            /// PropertyLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-extractedparameter.html#cfn-glue-connectiontype-extractedparameter-propertylocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyLocation { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-extractedparameter.html#cfn-glue-connectiontype-extractedparameter-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class FieldDefinition : Humidifier.Base.BaseSubResource, IHaveFieldDataType, IHaveIsQueryable_Boolean, IHaveResponseDateFormat, IHaveIsNullable_Boolean, IHaveGlueConnectionTypeTypesFilterOverridesFilterOverrides, IHaveIsPartitionable_Boolean, IHaveIsOrderable_Boolean, IHaveName
        {
            /// <summary>
            /// FieldDataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-fielddatatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldDataType { get; set; }
            /// <summary>
            /// IsQueryable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-isqueryable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsQueryable { get; set; }
            /// <summary>
            /// ResponseDateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-responsedateformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResponseDateFormat { get; set; }
            /// <summary>
            /// IsNullable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-isnullable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsNullable { get; set; }
            /// <summary>
            /// FilterOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-filteroverrides
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FilterOverrides
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.FilterOverrides, BaseFunction>? FilterOverrides { get; set; }
            /// <summary>
            /// IsPartitionable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-ispartitionable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsPartitionable { get; set; }
            /// <summary>
            /// IsOrderable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-isorderable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsOrderable { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class FilterConfiguration : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesBetweenConfigurationBetweenConfiguration, IHaveGlueConnectionTypeTypesFilterStringConfigurationFilterStringConfiguration, IHaveStripQuotes_Boolean, IHaveFilterMode, IHaveStringDictionaryOfOperatorMappings, IHaveDateTimeFormat
        {
            /// <summary>
            /// BetweenConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-betweenconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BetweenConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration, BaseFunction>? BetweenConfiguration { get; set; }
            /// <summary>
            /// FilterStringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-filterstringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FilterStringConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.FilterStringConfiguration, BaseFunction>? FilterStringConfiguration { get; set; }
            /// <summary>
            /// StripQuotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-stripquotes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StripQuotes { get; set; }
            /// <summary>
            /// FilterMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-filtermode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FilterMode { get; set; }
            /// <summary>
            /// OperatorMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-operatormappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? OperatorMappings { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-datetimeformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateTimeFormat { get; set; }
        }

        public class FilterOverrides : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesBetweenConfigurationBetweenConfiguration, IHaveStringDictionaryOfOperatorMappings, IHaveFieldName, IHaveDateTimeFormat
        {
            /// <summary>
            /// BetweenConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filteroverrides.html#cfn-glue-connectiontype-filteroverrides-betweenconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BetweenConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration, BaseFunction>? BetweenConfiguration { get; set; }
            /// <summary>
            /// OperatorMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filteroverrides.html#cfn-glue-connectiontype-filteroverrides-operatormappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? OperatorMappings { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filteroverrides.html#cfn-glue-connectiontype-filteroverrides-fieldname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldName { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filteroverrides.html#cfn-glue-connectiontype-filteroverrides-datetimeformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DateTimeFormat { get; set; }
        }

        public class FilterStringConfiguration : Humidifier.Base.BaseSubResource, IHaveQuoteCharacter, IHaveQueryParameterName, IHaveQuoteStringValues_Boolean
        {
            /// <summary>
            /// QuoteCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterstringconfiguration.html#cfn-glue-connectiontype-filterstringconfiguration-quotecharacter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QuoteCharacter { get; set; }
            /// <summary>
            /// QueryParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterstringconfiguration.html#cfn-glue-connectiontype-filterstringconfiguration-queryparametername
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryParameterName { get; set; }
            /// <summary>
            /// QuoteStringValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterstringconfiguration.html#cfn-glue-connectiontype-filterstringconfiguration-quotestringvalues
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? QuoteStringValues { get; set; }
        }

        public class JWTBearerProperties : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesSecretConnectorPropertyJwtToken, IHaveContentType, IHaveRequestMethod, IHaveGlueConnectionTypeTypesConnectorPropertyTokenUrl, IHaveListOfGlueConnectionTypeTypesConnectorPropertyTokenUrlParameters
        {
            /// <summary>
            /// JwtToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-jwttoken
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty, BaseFunction>? JwtToken { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentType { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequestMethod { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-tokenurl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>? TokenUrl { get; set; }
            /// <summary>
            /// TokenUrlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-tokenurlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty>, IReadOnlyList<Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>>, BaseFunction>? TokenUrlParameters { get; set; }
        }

        public class OffsetConfiguration : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesExtractedParameterLimitParameter, IHaveGlueConnectionTypeTypesExtractedParameterOffsetParameter
        {
            /// <summary>
            /// LimitParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-offsetconfiguration.html#cfn-glue-connectiontype-offsetconfiguration-limitparameter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ExtractedParameter
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter, BaseFunction>? LimitParameter { get; set; }
            /// <summary>
            /// OffsetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-offsetconfiguration.html#cfn-glue-connectiontype-offsetconfiguration-offsetparameter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ExtractedParameter
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter, BaseFunction>? OffsetParameter { get; set; }
        }

        public class PaginationConfiguration : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesCursorConfigurationCursorConfiguration, IHaveGlueConnectionTypeTypesOffsetConfigurationOffsetConfiguration
        {
            /// <summary>
            /// CursorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-paginationconfiguration.html#cfn-glue-connectiontype-paginationconfiguration-cursorconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CursorConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.CursorConfiguration, BaseFunction>? CursorConfiguration { get; set; }
            /// <summary>
            /// OffsetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-paginationconfiguration.html#cfn-glue-connectiontype-paginationconfiguration-offsetconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OffsetConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.OffsetConfiguration, BaseFunction>? OffsetConfiguration { get; set; }
        }

        public class ResponseConfiguration : Humidifier.Base.BaseSubResource, IHaveResultPath, IHaveErrorPath
        {
            /// <summary>
            /// ResultPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-responseconfiguration.html#cfn-glue-connectiontype-responseconfiguration-resultpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResultPath { get; set; }
            /// <summary>
            /// ErrorPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-responseconfiguration.html#cfn-glue-connectiontype-responseconfiguration-errorpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ErrorPath { get; set; }
        }

        public class ResponseExtractionMapping : Humidifier.Base.BaseSubResource, IHaveHeaderKey, IHaveContentPath
        {
            /// <summary>
            /// HeaderKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-responseextractionmapping.html#cfn-glue-connectiontype-responseextractionmapping-headerkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HeaderKey { get; set; }
            /// <summary>
            /// ContentPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-responseextractionmapping.html#cfn-glue-connectiontype-responseextractionmapping-contentpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ContentPath { get; set; }
        }

        public class RestConfiguration : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypeTypesValidationEndpointConfigurationValidationEndpointConfiguration, IHaveGlueConnectionTypeTypesSourceConfigurationGlobalSourceConfiguration, IHaveMapOfGlueConnectionTypeTypesEntityConfigurationEntityConfigurations
        {
            /// <summary>
            /// ValidationEndpointConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-restconfiguration.html#cfn-glue-connectiontype-restconfiguration-validationendpointconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ValidationEndpointConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ValidationEndpointConfiguration, BaseFunction>? ValidationEndpointConfiguration { get; set; }
            /// <summary>
            /// GlobalSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-restconfiguration.html#cfn-glue-connectiontype-restconfiguration-globalsourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.SourceConfiguration, BaseFunction>? GlobalSourceConfiguration { get; set; }
            /// <summary>
            /// EntityConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-restconfiguration.html#cfn-glue-connectiontype-restconfiguration-entityconfigurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: EntityConfiguration
            /// </summary>
            public Union<IReadOnlyDictionary<string, Humidifier.Glue.ConnectionTypeTypes.EntityConfiguration>, IReadOnlyDictionary<string, Union<Humidifier.Glue.ConnectionTypeTypes.EntityConfiguration, BaseFunction>>, BaseFunction>? EntityConfigurations { get; set; }
        }

        public class SecretConnectorProperty : Humidifier.Base.BaseSubResource, IHaveKeyOverride, IHavePropertyType, IHaveRequired_Boolean, IHavePropertyLocation, IHaveName
        {
            /// <summary>
            /// KeyOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-keyoverride
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KeyOverride { get; set; }
            /// <summary>
            /// PropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-propertytype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyType { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-required
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// PropertyLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-propertylocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PropertyLocation { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveRequestPath, IHaveGlueConnectionTypeTypesResponseConfigurationResponseConfiguration, IHaveGlueConnectionTypeTypesFilterConfigurationFilterConfiguration, IHaveRequestMethod, IHaveGlueConnectionTypeTypesPaginationConfigurationPaginationConfiguration, IHaveListOfGlueConnectionTypeTypesConnectorPropertyRequestParameters
        {
            /// <summary>
            /// RequestPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-requestpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequestPath { get; set; }
            /// <summary>
            /// ResponseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-responseconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResponseConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.ResponseConfiguration, BaseFunction>? ResponseConfiguration { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FilterConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.FilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequestMethod { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PaginationConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypeTypes.PaginationConfiguration, BaseFunction>? PaginationConfiguration { get; set; }
            /// <summary>
            /// RequestParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-requestparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty>, IReadOnlyList<Union<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty, BaseFunction>>, BaseFunction>? RequestParameters { get; set; }
        }

        public class ValidationEndpointConfiguration : Humidifier.Base.BaseSubResource, IHaveRequestPath, IHaveRequestMethod
        {
            /// <summary>
            /// RequestPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-validationendpointconfiguration.html#cfn-glue-connectiontype-validationendpointconfiguration-requestpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequestPath { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-validationendpointconfiguration.html#cfn-glue-connectiontype-validationendpointconfiguration-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RequestMethod { get; set; }
        }
    }
}