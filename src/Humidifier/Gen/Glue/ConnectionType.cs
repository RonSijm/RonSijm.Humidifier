namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using ConnectionTypeTypes;

    public class ConnectionType : Humidifier.Base.BaseResource, IHaveTags, IHaveDescription, IHaveIntegrationType
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
        public dynamic Description { get; set; }

        /// <summary>
        /// ConnectionType_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-connectiontype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectionType_ { get; set; }
        /// <summary>
        /// ConnectorAuthenticationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-connectorauthenticationconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectorAuthenticationConfiguration
        /// </summary>
        public Humidifier.Glue.ConnectionTypeTypes.ConnectorAuthenticationConfiguration ConnectorAuthenticationConfiguration { get; set; }
        /// <summary>
        /// ConnectionProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-connectionproperties
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectionPropertiesConfiguration
        /// </summary>
        public Humidifier.Glue.ConnectionTypeTypes.ConnectionPropertiesConfiguration ConnectionProperties { get; set; }

        /// <summary>
        /// RestConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-restconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: RestConfiguration
        /// </summary>
        [Required]
        public Humidifier.Glue.ConnectionTypeTypes.RestConfiguration RestConfiguration { get; set; }
        /// <summary>
        /// IntegrationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-integrationtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IntegrationType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connectiontype.html#cfn-glue-connectiontype-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ConnectionTypeTypes
    {
        public class BasicAuthenticationProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-basicauthenticationproperties.html#cfn-glue-connectiontype-basicauthenticationproperties-username
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-basicauthenticationproperties.html#cfn-glue-connectiontype-basicauthenticationproperties-password
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty Password { get; set; }
        }

        public class BetweenConfiguration : Humidifier.Base.BaseSubResource, IHaveTemplate
        {
            /// <summary>
            /// LowBoundKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-betweenconfiguration.html#cfn-glue-connectiontype-betweenconfiguration-lowboundkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LowBoundKey { get; set; }
            /// <summary>
            /// HighBoundKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-betweenconfiguration.html#cfn-glue-connectiontype-betweenconfiguration-highboundkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HighBoundKey { get; set; }
            /// <summary>
            /// Template
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-betweenconfiguration.html#cfn-glue-connectiontype-betweenconfiguration-template
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Template { get; set; }
        }

        public class ClientCredentialsProperties : Humidifier.Base.BaseSubResource, IHaveContentType
        {
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-scope
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty Scope { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RequestMethod { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-clientsecret
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty ClientSecret { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-tokenurl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty TokenUrl { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-clientid
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty ClientId { get; set; }
            /// <summary>
            /// TokenUrlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-clientcredentialsproperties.html#cfn-glue-connectiontype-clientcredentialsproperties-tokenurlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public List<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> TokenUrlParameters { get; set; }
        }

        public class ConnectionPropertiesConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AdditionalRequestParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectionpropertiesconfiguration.html#cfn-glue-connectiontype-connectionpropertiesconfiguration-additionalrequestparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public List<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> AdditionalRequestParameters { get; set; }
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectionpropertiesconfiguration.html#cfn-glue-connectiontype-connectionpropertiesconfiguration-url
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty Url { get; set; }
        }

        public class ConnectorAuthenticationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CustomAuthenticationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthenticationconfiguration.html#cfn-glue-connectiontype-connectorauthenticationconfiguration-customauthenticationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CustomAuthenticationProperties
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.CustomAuthenticationProperties CustomAuthenticationProperties { get; set; }
            /// <summary>
            /// OAuth2Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthenticationconfiguration.html#cfn-glue-connectiontype-connectorauthenticationconfiguration-oauth2properties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorOAuth2Properties
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorOAuth2Properties OAuth2Properties { get; set; }
            /// <summary>
            /// AuthenticationTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthenticationconfiguration.html#cfn-glue-connectiontype-connectorauthenticationconfiguration-authenticationtypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AuthenticationTypes { get; set; }
            /// <summary>
            /// BasicAuthenticationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthenticationconfiguration.html#cfn-glue-connectiontype-connectorauthenticationconfiguration-basicauthenticationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BasicAuthenticationProperties
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.BasicAuthenticationProperties BasicAuthenticationProperties { get; set; }
        }

        public class ConnectorAuthorizationCodeProperties : Humidifier.Base.BaseSubResource, IHaveContentType
        {
            /// <summary>
            /// AuthorizationCodeUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-authorizationcodeurl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty AuthorizationCodeUrl { get; set; }
            /// <summary>
            /// AuthorizationCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-authorizationcode
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty AuthorizationCode { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-scope
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty Scope { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RequestMethod { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-clientsecret
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty ClientSecret { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-tokenurl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty TokenUrl { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-clientid
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty ClientId { get; set; }
            /// <summary>
            /// RedirectUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-redirecturi
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty RedirectUri { get; set; }
            /// <summary>
            /// Prompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-prompt
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty Prompt { get; set; }
            /// <summary>
            /// TokenUrlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorauthorizationcodeproperties.html#cfn-glue-connectiontype-connectorauthorizationcodeproperties-tokenurlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public List<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> TokenUrlParameters { get; set; }
        }

        public class ConnectorOAuth2Properties : Humidifier.Base.BaseSubResource, IHaveOAuth2GrantType
        {
            /// <summary>
            /// AuthorizationCodeProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectoroauth2properties.html#cfn-glue-connectiontype-connectoroauth2properties-authorizationcodeproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorAuthorizationCodeProperties
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorAuthorizationCodeProperties AuthorizationCodeProperties { get; set; }
            /// <summary>
            /// ClientCredentialsProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectoroauth2properties.html#cfn-glue-connectiontype-connectoroauth2properties-clientcredentialsproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ClientCredentialsProperties
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ClientCredentialsProperties ClientCredentialsProperties { get; set; }
            /// <summary>
            /// JWTBearerProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectoroauth2properties.html#cfn-glue-connectiontype-connectoroauth2properties-jwtbearerproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: JWTBearerProperties
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.JWTBearerProperties JWTBearerProperties { get; set; }
            /// <summary>
            /// OAuth2GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectoroauth2properties.html#cfn-glue-connectiontype-connectoroauth2properties-oauth2granttype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OAuth2GrantType { get; set; }
        }

        public class ConnectorProperty : Humidifier.Base.BaseSubResource, IHaveName, IHaveDefaultValue, IHaveRequired, IHaveAllowedValues
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// AllowedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-allowedvalues
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedValues { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-required
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Required { get; set; }
            /// <summary>
            /// PropertyLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-propertylocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyLocation { get; set; }
            /// <summary>
            /// KeyOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-keyoverride
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyOverride { get; set; }
            /// <summary>
            /// PropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-propertytype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyType { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-connectorproperty.html#cfn-glue-connectiontype-connectorproperty-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class CursorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LimitParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-cursorconfiguration.html#cfn-glue-connectiontype-cursorconfiguration-limitparameter
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ExtractedParameter
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter LimitParameter { get; set; }
            /// <summary>
            /// NextPage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-cursorconfiguration.html#cfn-glue-connectiontype-cursorconfiguration-nextpage
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ExtractedParameter
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter NextPage { get; set; }
        }

        public class CustomAuthenticationProperties : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthenticationParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-customauthenticationproperties.html#cfn-glue-connectiontype-customauthenticationproperties-authenticationparameters
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SecretConnectorProperty
            /// </summary>
            public List<Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty> AuthenticationParameters { get; set; }
        }

        public class EntityConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-entityconfiguration.html#cfn-glue-connectiontype-entityconfiguration-schema
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: FieldDefinition
            /// </summary>
            public Dictionary<string, Humidifier.Glue.ConnectionTypeTypes.FieldDefinition> Schema { get; set; }
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-entityconfiguration.html#cfn-glue-connectiontype-entityconfiguration-sourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SourceConfiguration SourceConfiguration { get; set; }
        }

        public class ExtractedParameter : Humidifier.Base.BaseSubResource, IHaveKey, IHaveDefaultValue
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-extractedparameter.html#cfn-glue-connectiontype-extractedparameter-value
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResponseExtractionMapping
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ResponseExtractionMapping Value { get; set; }
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-extractedparameter.html#cfn-glue-connectiontype-extractedparameter-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// PropertyLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-extractedparameter.html#cfn-glue-connectiontype-extractedparameter-propertylocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyLocation { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-extractedparameter.html#cfn-glue-connectiontype-extractedparameter-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class FieldDefinition : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// FieldDataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-fielddatatype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldDataType { get; set; }
            /// <summary>
            /// IsQueryable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-isqueryable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsQueryable { get; set; }
            /// <summary>
            /// ResponseDateFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-responsedateformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResponseDateFormat { get; set; }
            /// <summary>
            /// IsNullable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-isnullable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsNullable { get; set; }
            /// <summary>
            /// FilterOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-filteroverrides
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FilterOverrides
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.FilterOverrides FilterOverrides { get; set; }
            /// <summary>
            /// IsPartitionable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-ispartitionable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsPartitionable { get; set; }
            /// <summary>
            /// IsOrderable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-isorderable
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsOrderable { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-fielddefinition.html#cfn-glue-connectiontype-fielddefinition-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class FilterConfiguration : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat
        {
            /// <summary>
            /// BetweenConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-betweenconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BetweenConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration BetweenConfiguration { get; set; }
            /// <summary>
            /// FilterStringConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-filterstringconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FilterStringConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.FilterStringConfiguration FilterStringConfiguration { get; set; }
            /// <summary>
            /// StripQuotes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-stripquotes
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic StripQuotes { get; set; }
            /// <summary>
            /// FilterMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-filtermode
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterMode { get; set; }
            /// <summary>
            /// OperatorMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-operatormappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> OperatorMappings { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterconfiguration.html#cfn-glue-connectiontype-filterconfiguration-datetimeformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class FilterOverrides : Humidifier.Base.BaseSubResource, IHaveDateTimeFormat, IHaveFieldName
        {
            /// <summary>
            /// BetweenConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filteroverrides.html#cfn-glue-connectiontype-filteroverrides-betweenconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BetweenConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration BetweenConfiguration { get; set; }
            /// <summary>
            /// OperatorMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filteroverrides.html#cfn-glue-connectiontype-filteroverrides-operatormappings
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> OperatorMappings { get; set; }
            /// <summary>
            /// FieldName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filteroverrides.html#cfn-glue-connectiontype-filteroverrides-fieldname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldName { get; set; }
            /// <summary>
            /// DateTimeFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filteroverrides.html#cfn-glue-connectiontype-filteroverrides-datetimeformat
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DateTimeFormat { get; set; }
        }

        public class FilterStringConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// QuoteCharacter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterstringconfiguration.html#cfn-glue-connectiontype-filterstringconfiguration-quotecharacter
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QuoteCharacter { get; set; }
            /// <summary>
            /// QueryParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterstringconfiguration.html#cfn-glue-connectiontype-filterstringconfiguration-queryparametername
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryParameterName { get; set; }
            /// <summary>
            /// QuoteStringValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-filterstringconfiguration.html#cfn-glue-connectiontype-filterstringconfiguration-quotestringvalues
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic QuoteStringValues { get; set; }
        }

        public class JWTBearerProperties : Humidifier.Base.BaseSubResource, IHaveContentType
        {
            /// <summary>
            /// JwtToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-jwttoken
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SecretConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SecretConnectorProperty JwtToken { get; set; }
            /// <summary>
            /// ContentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-contenttype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentType { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RequestMethod { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-tokenurl
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ConnectorProperty
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty TokenUrl { get; set; }
            /// <summary>
            /// TokenUrlParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-jwtbearerproperties.html#cfn-glue-connectiontype-jwtbearerproperties-tokenurlparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public List<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> TokenUrlParameters { get; set; }
        }

        public class OffsetConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LimitParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-offsetconfiguration.html#cfn-glue-connectiontype-offsetconfiguration-limitparameter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ExtractedParameter
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter LimitParameter { get; set; }
            /// <summary>
            /// OffsetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-offsetconfiguration.html#cfn-glue-connectiontype-offsetconfiguration-offsetparameter
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ExtractedParameter
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ExtractedParameter OffsetParameter { get; set; }
        }

        public class PaginationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CursorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-paginationconfiguration.html#cfn-glue-connectiontype-paginationconfiguration-cursorconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CursorConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.CursorConfiguration CursorConfiguration { get; set; }
            /// <summary>
            /// OffsetConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-paginationconfiguration.html#cfn-glue-connectiontype-paginationconfiguration-offsetconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OffsetConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.OffsetConfiguration OffsetConfiguration { get; set; }
        }

        public class ResponseConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ResultPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-responseconfiguration.html#cfn-glue-connectiontype-responseconfiguration-resultpath
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResultPath { get; set; }
            /// <summary>
            /// ErrorPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-responseconfiguration.html#cfn-glue-connectiontype-responseconfiguration-errorpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorPath { get; set; }
        }

        public class ResponseExtractionMapping : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeaderKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-responseextractionmapping.html#cfn-glue-connectiontype-responseextractionmapping-headerkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderKey { get; set; }
            /// <summary>
            /// ContentPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-responseextractionmapping.html#cfn-glue-connectiontype-responseextractionmapping-contentpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentPath { get; set; }
        }

        public class RestConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ValidationEndpointConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-restconfiguration.html#cfn-glue-connectiontype-restconfiguration-validationendpointconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ValidationEndpointConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ValidationEndpointConfiguration ValidationEndpointConfiguration { get; set; }
            /// <summary>
            /// GlobalSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-restconfiguration.html#cfn-glue-connectiontype-restconfiguration-globalsourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SourceConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.SourceConfiguration GlobalSourceConfiguration { get; set; }
            /// <summary>
            /// EntityConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-restconfiguration.html#cfn-glue-connectiontype-restconfiguration-entityconfigurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// ItemType: EntityConfiguration
            /// </summary>
            public Dictionary<string, Humidifier.Glue.ConnectionTypeTypes.EntityConfiguration> EntityConfigurations { get; set; }
        }

        public class SecretConnectorProperty : Humidifier.Base.BaseSubResource, IHaveName, IHaveRequired
        {
            /// <summary>
            /// KeyOverride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-keyoverride
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyOverride { get; set; }
            /// <summary>
            /// PropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-propertytype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyType { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-required
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Required { get; set; }
            /// <summary>
            /// PropertyLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-propertylocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PropertyLocation { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-secretconnectorproperty.html#cfn-glue-connectiontype-secretconnectorproperty-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RequestPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-requestpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RequestPath { get; set; }
            /// <summary>
            /// ResponseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-responseconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ResponseConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.ResponseConfiguration ResponseConfiguration { get; set; }
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FilterConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.FilterConfiguration FilterConfiguration { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RequestMethod { get; set; }
            /// <summary>
            /// PaginationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-paginationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PaginationConfiguration
            /// </summary>
            public Humidifier.Glue.ConnectionTypeTypes.PaginationConfiguration PaginationConfiguration { get; set; }
            /// <summary>
            /// RequestParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-sourceconfiguration.html#cfn-glue-connectiontype-sourceconfiguration-requestparameters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ConnectorProperty
            /// </summary>
            public List<Humidifier.Glue.ConnectionTypeTypes.ConnectorProperty> RequestParameters { get; set; }
        }

        public class ValidationEndpointConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RequestPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-validationendpointconfiguration.html#cfn-glue-connectiontype-validationendpointconfiguration-requestpath
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RequestPath { get; set; }
            /// <summary>
            /// RequestMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connectiontype-validationendpointconfiguration.html#cfn-glue-connectiontype-validationendpointconfiguration-requestmethod
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RequestMethod { get; set; }
        }
    }
}