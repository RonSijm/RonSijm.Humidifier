namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using ConnectionTypes;

    public class Connection : Humidifier.Base.BaseResource, IHaveGlueConnectionTypesConnectionInputConnectionInput, IHaveCatalogId, IHaveTags_Json
    {
        public class Attributes
        {
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Glue.Connection; }

        /// <summary>
        /// ConnectionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connection.html#cfn-glue-connection-connectioninput
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ConnectionInput
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.ConnectionTypes.ConnectionInput, BaseFunction>? ConnectionInput { get; set; }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connection.html#cfn-glue-connection-catalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CatalogId { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-connection.html#cfn-glue-connection-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? Tags { get; set; }
    }

    namespace ConnectionTypes
    {
        public class AuthenticationConfiguration : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKmsKeyArn, IHaveCustomAuthenticationCredentials_Json, IHaveGlueConnectionTypesOAuth2PropertiesOAuth2Properties, IHaveGlueConnectionTypesBasicAuthenticationCredentialsBasicAuthenticationCredentials, IHaveAuthenticationType
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-authenticationconfiguration.html#cfn-glue-connection-authenticationconfiguration-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-authenticationconfiguration.html#cfn-glue-connection-authenticationconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// CustomAuthenticationCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-authenticationconfiguration.html#cfn-glue-connection-authenticationconfiguration-customauthenticationcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? CustomAuthenticationCredentials { get; set; }
            /// <summary>
            /// OAuth2Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-authenticationconfiguration.html#cfn-glue-connection-authenticationconfiguration-oauth2properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2Properties
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypes.OAuth2Properties, BaseFunction>? OAuth2Properties { get; set; }
            /// <summary>
            /// BasicAuthenticationCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-authenticationconfiguration.html#cfn-glue-connection-authenticationconfiguration-basicauthenticationcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthenticationCredentials
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypes.BasicAuthenticationCredentials, BaseFunction>? BasicAuthenticationCredentials { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-authenticationconfiguration.html#cfn-glue-connection-authenticationconfiguration-authenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class AuthorizationCodeProperties : Humidifier.Base.BaseSubResource, IHaveAuthorizationCode, IHaveRedirectUri
        {
            /// <summary>
            /// AuthorizationCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-authorizationcodeproperties.html#cfn-glue-connection-authorizationcodeproperties-authorizationcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationCode { get; set; }
            /// <summary>
            /// RedirectUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-authorizationcodeproperties.html#cfn-glue-connection-authorizationcodeproperties-redirecturi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedirectUri { get; set; }
        }

        public class BasicAuthenticationCredentials : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-basicauthenticationcredentials.html#cfn-glue-connection-basicauthenticationcredentials-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-basicauthenticationcredentials.html#cfn-glue-connection-basicauthenticationcredentials-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class ConnectionInput : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypesAuthenticationConfigurationAuthenticationConfiguration, IHavePythonProperties_Json, IHaveSparkProperties_Json, IHaveDescription, IHaveConnectionType, IHaveStringListOfMatchCriteria, IHaveGlueConnectionTypesPhysicalConnectionRequirementsPhysicalConnectionRequirements, IHaveConnectionProperties_Json, IHaveAthenaProperties_Json, IHaveStringListOfValidateForComputeEnvironments, IHaveValidateCredentials_Boolean, IHaveName
        {
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-authenticationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthenticationConfiguration
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypes.AuthenticationConfiguration, BaseFunction>? AuthenticationConfiguration { get; set; }
            /// <summary>
            /// PythonProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-pythonproperties
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? PythonProperties { get; set; }
            /// <summary>
            /// SparkProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-sparkproperties
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SparkProperties { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ConnectionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-connectiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionType { get; set; }
            /// <summary>
            /// MatchCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-matchcriteria
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? MatchCriteria { get; set; }
            /// <summary>
            /// PhysicalConnectionRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-physicalconnectionrequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PhysicalConnectionRequirements
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypes.PhysicalConnectionRequirements, BaseFunction>? PhysicalConnectionRequirements { get; set; }
            /// <summary>
            /// ConnectionProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-connectionproperties
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ConnectionProperties { get; set; }
            /// <summary>
            /// AthenaProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-athenaproperties
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? AthenaProperties { get; set; }
            /// <summary>
            /// ValidateForComputeEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-validateforcomputeenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ValidateForComputeEnvironments { get; set; }
            /// <summary>
            /// ValidateCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-validatecredentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ValidateCredentials { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-connectioninput.html#cfn-glue-connection-connectioninput-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class OAuth2ClientApplication : Humidifier.Base.BaseSubResource, IHaveAWSManagedClientApplicationReference, IHaveUserManagedClientApplicationClientId
        {
            /// <summary>
            /// AWSManagedClientApplicationReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2clientapplication.html#cfn-glue-connection-oauth2clientapplication-awsmanagedclientapplicationreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AWSManagedClientApplicationReference { get; set; }
            /// <summary>
            /// UserManagedClientApplicationClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2clientapplication.html#cfn-glue-connection-oauth2clientapplication-usermanagedclientapplicationclientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserManagedClientApplicationClientId { get; set; }
        }

        public class OAuth2Credentials : Humidifier.Base.BaseSubResource, IHaveJwtToken, IHaveUserManagedClientApplicationClientSecret, IHaveRefreshToken, IHaveAccessToken
        {
            /// <summary>
            /// JwtToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2credentials.html#cfn-glue-connection-oauth2credentials-jwttoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JwtToken { get; set; }
            /// <summary>
            /// UserManagedClientApplicationClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2credentials.html#cfn-glue-connection-oauth2credentials-usermanagedclientapplicationclientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserManagedClientApplicationClientSecret { get; set; }
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2credentials.html#cfn-glue-connection-oauth2credentials-refreshtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2credentials.html#cfn-glue-connection-oauth2credentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
        }

        public class OAuth2Properties : Humidifier.Base.BaseSubResource, IHaveGlueConnectionTypesAuthorizationCodePropertiesAuthorizationCodeProperties, IHaveGlueConnectionTypesOAuth2ClientApplicationOAuth2ClientApplication, IHaveTokenUrl, IHaveGlueConnectionTypesOAuth2CredentialsOAuth2Credentials, IHaveOAuth2GrantType, IHaveTokenUrlParametersMap_Json
        {
            /// <summary>
            /// AuthorizationCodeProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2properties.html#cfn-glue-connection-oauth2properties-authorizationcodeproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizationCodeProperties
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypes.AuthorizationCodeProperties, BaseFunction>? AuthorizationCodeProperties { get; set; }
            /// <summary>
            /// OAuth2ClientApplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2properties.html#cfn-glue-connection-oauth2properties-oauth2clientapplication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2ClientApplication
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypes.OAuth2ClientApplication, BaseFunction>? OAuth2ClientApplication { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2properties.html#cfn-glue-connection-oauth2properties-tokenurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenUrl { get; set; }
            /// <summary>
            /// OAuth2Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2properties.html#cfn-glue-connection-oauth2properties-oauth2credentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2Credentials
            /// </summary>
            public Union<Humidifier.Glue.ConnectionTypes.OAuth2Credentials, BaseFunction>? OAuth2Credentials { get; set; }
            /// <summary>
            /// OAuth2GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2properties.html#cfn-glue-connection-oauth2properties-oauth2granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OAuth2GrantType { get; set; }
            /// <summary>
            /// TokenUrlParametersMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-oauth2properties.html#cfn-glue-connection-oauth2properties-tokenurlparametersmap
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? TokenUrlParametersMap { get; set; }
        }

        public class PhysicalConnectionRequirements : Humidifier.Base.BaseSubResource, IHaveAvailabilityZone, IHaveStringListOfSecurityGroupIdList, IHaveSubnetId
        {
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-physicalconnectionrequirements.html#cfn-glue-connection-physicalconnectionrequirements-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// SecurityGroupIdList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-physicalconnectionrequirements.html#cfn-glue-connection-physicalconnectionrequirements-securitygroupidlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIdList { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-connection-physicalconnectionrequirements.html#cfn-glue-connection-physicalconnectionrequirements-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
        }
    }
}