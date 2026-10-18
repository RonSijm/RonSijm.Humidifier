namespace Humidifier.DataZone
{
    using global::System.Collections.Generic;
    using ConnectionTypes;

    public class Connection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveProjectIdentifier, IHaveDescription, IHaveEnvironmentIdentifier, IHaveScope, IHaveDataZoneConnectionTypesConnectionPropertiesInputProps, IHaveListOfDataZoneConnectionTypesConnectionConfigurationConfigurations, IHaveDataZoneConnectionTypesAwsLocationAwsLocation, IHaveEnableTrustedIdentityPropagation_Boolean, IHaveName, IHaveDomainIdentifier
    {
        public class Attributes
        {
            public static string DomainUnitId =  "DomainUnitId" ;
            public static string ConnectionId =  "ConnectionId" ;
            public static string EnvironmentId =  "EnvironmentId" ;
            public static string Type =  "Type" ;
            public static string DomainId =  "DomainId" ;
            public static string ProjectId =  "ProjectId" ;
            public static string EnvironmentUserRole =  "EnvironmentUserRole" ;
        }

        public override string AWSTypeName { get => AWS.DataZone.Connection; }
        /// <summary>
        /// ProjectIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-projectidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// EnvironmentIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-environmentidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EnvironmentIdentifier { get; set; }
        /// <summary>
        /// Scope
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-scope
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Scope { get; set; }
        /// <summary>
        /// Props
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-props
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectionPropertiesInput
        /// </summary>
        public Union<Humidifier.DataZone.ConnectionTypes.ConnectionPropertiesInput, BaseFunction>? Props { get; set; }
        /// <summary>
        /// Configurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-configurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConnectionConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration>, IReadOnlyList<Union<Humidifier.DataZone.ConnectionTypes.ConnectionConfiguration, BaseFunction>>, BaseFunction>? Configurations { get; set; }
        /// <summary>
        /// AwsLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-awslocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AwsLocation
        /// </summary>
        public Union<Humidifier.DataZone.ConnectionTypes.AwsLocation, BaseFunction>? AwsLocation { get; set; }
        /// <summary>
        /// EnableTrustedIdentityPropagation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-enabletrustedidentitypropagation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableTrustedIdentityPropagation { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// DomainIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datazone-connection.html#cfn-datazone-connection-domainidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DomainIdentifier { get; set; }
    }

    namespace ConnectionTypes
    {
        public class AmazonQPropertiesInput : Humidifier.Base.BaseSubResource, IHaveIsEnabled_Boolean, IHaveProfileArn, IHaveAuthMode
        {
            /// <summary>
            /// IsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-amazonqpropertiesinput.html#cfn-datazone-connection-amazonqpropertiesinput-isenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsEnabled { get; set; }
            /// <summary>
            /// ProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-amazonqpropertiesinput.html#cfn-datazone-connection-amazonqpropertiesinput-profilearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProfileArn { get; set; }
            /// <summary>
            /// AuthMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-amazonqpropertiesinput.html#cfn-datazone-connection-amazonqpropertiesinput-authmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthMode { get; set; }
        }

        public class AthenaPropertiesInput : Humidifier.Base.BaseSubResource, IHaveWorkgroupName
        {
            /// <summary>
            /// WorkgroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-athenapropertiesinput.html#cfn-datazone-connection-athenapropertiesinput-workgroupname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkgroupName { get; set; }
        }

        public class AuthenticationConfigurationInput : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveKmsKeyArn, IHaveDataZoneConnectionTypesOAuth2PropertiesOAuth2Properties, IHaveStringDictionaryOfCustomAuthenticationCredentials, IHaveDataZoneConnectionTypesBasicAuthenticationCredentialsBasicAuthenticationCredentials, IHaveAuthenticationType
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-authenticationconfigurationinput.html#cfn-datazone-connection-authenticationconfigurationinput-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-authenticationconfigurationinput.html#cfn-datazone-connection-authenticationconfigurationinput-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// OAuth2Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-authenticationconfigurationinput.html#cfn-datazone-connection-authenticationconfigurationinput-oauth2properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2Properties
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.OAuth2Properties, BaseFunction>? OAuth2Properties { get; set; }
            /// <summary>
            /// CustomAuthenticationCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-authenticationconfigurationinput.html#cfn-datazone-connection-authenticationconfigurationinput-customauthenticationcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomAuthenticationCredentials { get; set; }
            /// <summary>
            /// BasicAuthenticationCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-authenticationconfigurationinput.html#cfn-datazone-connection-authenticationconfigurationinput-basicauthenticationcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthenticationCredentials
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.BasicAuthenticationCredentials, BaseFunction>? BasicAuthenticationCredentials { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-authenticationconfigurationinput.html#cfn-datazone-connection-authenticationconfigurationinput-authenticationtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class AuthorizationCodeProperties : Humidifier.Base.BaseSubResource, IHaveAuthorizationCode, IHaveRedirectUri
        {
            /// <summary>
            /// AuthorizationCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-authorizationcodeproperties.html#cfn-datazone-connection-authorizationcodeproperties-authorizationcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationCode { get; set; }
            /// <summary>
            /// RedirectUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-authorizationcodeproperties.html#cfn-datazone-connection-authorizationcodeproperties-redirecturi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedirectUri { get; set; }
        }

        public class AwsLocation : Humidifier.Base.BaseSubResource, IHaveAwsRegion, IHaveAccessRole, IHaveAwsAccountId, IHaveIamConnectionId
        {
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-awslocation.html#cfn-datazone-connection-awslocation-awsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsRegion { get; set; }
            /// <summary>
            /// AccessRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-awslocation.html#cfn-datazone-connection-awslocation-accessrole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessRole { get; set; }
            /// <summary>
            /// AwsAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-awslocation.html#cfn-datazone-connection-awslocation-awsaccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsAccountId { get; set; }
            /// <summary>
            /// IamConnectionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-awslocation.html#cfn-datazone-connection-awslocation-iamconnectionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IamConnectionId { get; set; }
        }

        public class BasicAuthenticationCredentials : Humidifier.Base.BaseSubResource, IHaveUserName, IHavePassword
        {
            /// <summary>
            /// UserName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-basicauthenticationcredentials.html#cfn-datazone-connection-basicauthenticationcredentials-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserName { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-basicauthenticationcredentials.html#cfn-datazone-connection-basicauthenticationcredentials-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class ConnectionConfiguration : Humidifier.Base.BaseSubResource, IHaveClassification, IHaveStringDictionaryOfProperties
        {
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionconfiguration.html#cfn-datazone-connection-connectionconfiguration-classification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Classification { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionconfiguration.html#cfn-datazone-connection-connectionconfiguration-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
        }

        public class ConnectionPropertiesInput : Humidifier.Base.BaseSubResource, IHaveWorkflowsServerlessProperties_Json, IHaveDataZoneConnectionTypesIamPropertiesInputIamProperties, IHaveDataZoneConnectionTypesHyperPodPropertiesInputHyperPodProperties, IHaveDataZoneConnectionTypesSparkGluePropertiesInputSparkGlueProperties, IHaveDataZoneConnectionTypesMlflowPropertiesInputMlflowProperties, IHaveDataZoneConnectionTypesAthenaPropertiesInputAthenaProperties, IHaveDataZoneConnectionTypesRedshiftPropertiesInputRedshiftProperties, IHaveDataZoneConnectionTypesWorkflowsMwaaPropertiesInputWorkflowsMwaaProperties, IHaveDataZoneConnectionTypesAmazonQPropertiesInputAmazonQProperties, IHaveDataZoneConnectionTypesS3PropertiesInputS3Properties, IHaveDataZoneConnectionTypesSparkEmrPropertiesInputSparkEmrProperties, IHaveDataZoneConnectionTypesLakehousePropertiesInputLakehouseProperties, IHaveDataZoneConnectionTypesGluePropertiesInputGlueProperties
        {
            /// <summary>
            /// WorkflowsServerlessProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-workflowsserverlessproperties
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? WorkflowsServerlessProperties { get; set; }
            /// <summary>
            /// IamProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-iamproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamPropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.IamPropertiesInput, BaseFunction>? IamProperties { get; set; }
            /// <summary>
            /// HyperPodProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-hyperpodproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HyperPodPropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.HyperPodPropertiesInput, BaseFunction>? HyperPodProperties { get; set; }
            /// <summary>
            /// SparkGlueProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-sparkglueproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SparkGluePropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.SparkGluePropertiesInput, BaseFunction>? SparkGlueProperties { get; set; }
            /// <summary>
            /// MlflowProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-mlflowproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MlflowPropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.MlflowPropertiesInput, BaseFunction>? MlflowProperties { get; set; }
            /// <summary>
            /// AthenaProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-athenaproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AthenaPropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.AthenaPropertiesInput, BaseFunction>? AthenaProperties { get; set; }
            /// <summary>
            /// RedshiftProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-redshiftproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftPropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.RedshiftPropertiesInput, BaseFunction>? RedshiftProperties { get; set; }
            /// <summary>
            /// WorkflowsMwaaProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-workflowsmwaaproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WorkflowsMwaaPropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.WorkflowsMwaaPropertiesInput, BaseFunction>? WorkflowsMwaaProperties { get; set; }
            /// <summary>
            /// AmazonQProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-amazonqproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmazonQPropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.AmazonQPropertiesInput, BaseFunction>? AmazonQProperties { get; set; }
            /// <summary>
            /// S3Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-s3properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3PropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.S3PropertiesInput, BaseFunction>? S3Properties { get; set; }
            /// <summary>
            /// SparkEmrProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-sparkemrproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SparkEmrPropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.SparkEmrPropertiesInput, BaseFunction>? SparkEmrProperties { get; set; }
            /// <summary>
            /// LakehouseProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-lakehouseproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LakehousePropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.LakehousePropertiesInput, BaseFunction>? LakehouseProperties { get; set; }
            /// <summary>
            /// GlueProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-connectionpropertiesinput.html#cfn-datazone-connection-connectionpropertiesinput-glueproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GluePropertiesInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.GluePropertiesInput, BaseFunction>? GlueProperties { get; set; }
        }

        public class GlueConnectionInput : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfPythonProperties, IHaveDataZoneConnectionTypesAuthenticationConfigurationInputAuthenticationConfiguration, IHaveStringDictionaryOfSparkProperties, IHaveDescription, IHaveConnectionType, IHaveMatchCriteria, IHaveDataZoneConnectionTypesPhysicalConnectionRequirementsPhysicalConnectionRequirements, IHaveStringDictionaryOfConnectionProperties, IHaveStringDictionaryOfAthenaProperties, IHaveStringListOfValidateForComputeEnvironments, IHaveValidateCredentials_Boolean, IHaveName
        {
            /// <summary>
            /// PythonProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-pythonproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? PythonProperties { get; set; }
            /// <summary>
            /// AuthenticationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-authenticationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthenticationConfigurationInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.AuthenticationConfigurationInput, BaseFunction>? AuthenticationConfiguration { get; set; }
            /// <summary>
            /// SparkProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-sparkproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? SparkProperties { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// ConnectionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-connectiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionType { get; set; }
            /// <summary>
            /// MatchCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-matchcriteria
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MatchCriteria { get; set; }
            /// <summary>
            /// PhysicalConnectionRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-physicalconnectionrequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PhysicalConnectionRequirements
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.PhysicalConnectionRequirements, BaseFunction>? PhysicalConnectionRequirements { get; set; }
            /// <summary>
            /// ConnectionProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-connectionproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ConnectionProperties { get; set; }
            /// <summary>
            /// AthenaProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-athenaproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? AthenaProperties { get; set; }
            /// <summary>
            /// ValidateForComputeEnvironments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-validateforcomputeenvironments
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ValidateForComputeEnvironments { get; set; }
            /// <summary>
            /// ValidateCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-validatecredentials
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ValidateCredentials { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueconnectioninput.html#cfn-datazone-connection-glueconnectioninput-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class GlueOAuth2Credentials : Humidifier.Base.BaseSubResource, IHaveUserManagedClientApplicationClientSecret, IHaveJwtToken, IHaveRefreshToken, IHaveAccessToken
        {
            /// <summary>
            /// UserManagedClientApplicationClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueoauth2credentials.html#cfn-datazone-connection-glueoauth2credentials-usermanagedclientapplicationclientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserManagedClientApplicationClientSecret { get; set; }
            /// <summary>
            /// JwtToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueoauth2credentials.html#cfn-datazone-connection-glueoauth2credentials-jwttoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JwtToken { get; set; }
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueoauth2credentials.html#cfn-datazone-connection-glueoauth2credentials-refreshtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-glueoauth2credentials.html#cfn-datazone-connection-glueoauth2credentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
        }

        public class GluePropertiesInput : Humidifier.Base.BaseSubResource, IHaveDataZoneConnectionTypesGlueConnectionInputGlueConnectionInput
        {
            /// <summary>
            /// GlueConnectionInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-gluepropertiesinput.html#cfn-datazone-connection-gluepropertiesinput-glueconnectioninput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueConnectionInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput, BaseFunction>? GlueConnectionInput { get; set; }
        }

        public class HyperPodPropertiesInput : Humidifier.Base.BaseSubResource, IHaveClusterName
        {
            /// <summary>
            /// ClusterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-hyperpodpropertiesinput.html#cfn-datazone-connection-hyperpodpropertiesinput-clustername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterName { get; set; }
        }

        public class IamPropertiesInput : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveGlueLineageSyncEnabled_Boolean
        {
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-iampropertiesinput.html#cfn-datazone-connection-iampropertiesinput-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// GlueLineageSyncEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-iampropertiesinput.html#cfn-datazone-connection-iampropertiesinput-gluelineagesyncenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? GlueLineageSyncEnabled { get; set; }
        }

        public class LakehousePropertiesInput : Humidifier.Base.BaseSubResource, IHaveGlueLineageSyncEnabled_Boolean
        {
            /// <summary>
            /// GlueLineageSyncEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-lakehousepropertiesinput.html#cfn-datazone-connection-lakehousepropertiesinput-gluelineagesyncenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? GlueLineageSyncEnabled { get; set; }
        }

        public class LineageSyncSchedule : Humidifier.Base.BaseSubResource, IHaveSchedule
        {
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-lineagesyncschedule.html#cfn-datazone-connection-lineagesyncschedule-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Schedule { get; set; }
        }

        public class MlflowPropertiesInput : Humidifier.Base.BaseSubResource, IHaveTrackingServerArn
        {
            /// <summary>
            /// TrackingServerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-mlflowpropertiesinput.html#cfn-datazone-connection-mlflowpropertiesinput-trackingserverarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrackingServerArn { get; set; }
        }

        public class OAuth2ClientApplication : Humidifier.Base.BaseSubResource, IHaveAWSManagedClientApplicationReference, IHaveUserManagedClientApplicationClientId
        {
            /// <summary>
            /// AWSManagedClientApplicationReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-oauth2clientapplication.html#cfn-datazone-connection-oauth2clientapplication-awsmanagedclientapplicationreference
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AWSManagedClientApplicationReference { get; set; }
            /// <summary>
            /// UserManagedClientApplicationClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-oauth2clientapplication.html#cfn-datazone-connection-oauth2clientapplication-usermanagedclientapplicationclientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserManagedClientApplicationClientId { get; set; }
        }

        public class OAuth2Properties : Humidifier.Base.BaseSubResource, IHaveDataZoneConnectionTypesAuthorizationCodePropertiesAuthorizationCodeProperties, IHaveDataZoneConnectionTypesOAuth2ClientApplicationOAuth2ClientApplication, IHaveTokenUrl, IHaveDataZoneConnectionTypesGlueOAuth2CredentialsOAuth2Credentials, IHaveOAuth2GrantType, IHaveStringDictionaryOfTokenUrlParametersMap
        {
            /// <summary>
            /// AuthorizationCodeProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-oauth2properties.html#cfn-datazone-connection-oauth2properties-authorizationcodeproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AuthorizationCodeProperties
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.AuthorizationCodeProperties, BaseFunction>? AuthorizationCodeProperties { get; set; }
            /// <summary>
            /// OAuth2ClientApplication
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-oauth2properties.html#cfn-datazone-connection-oauth2properties-oauth2clientapplication
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2ClientApplication
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.OAuth2ClientApplication, BaseFunction>? OAuth2ClientApplication { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-oauth2properties.html#cfn-datazone-connection-oauth2properties-tokenurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenUrl { get; set; }
            /// <summary>
            /// OAuth2Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-oauth2properties.html#cfn-datazone-connection-oauth2properties-oauth2credentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GlueOAuth2Credentials
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.GlueOAuth2Credentials, BaseFunction>? OAuth2Credentials { get; set; }
            /// <summary>
            /// OAuth2GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-oauth2properties.html#cfn-datazone-connection-oauth2properties-oauth2granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OAuth2GrantType { get; set; }
            /// <summary>
            /// TokenUrlParametersMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-oauth2properties.html#cfn-datazone-connection-oauth2properties-tokenurlparametersmap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TokenUrlParametersMap { get; set; }
        }

        public class PhysicalConnectionRequirements : Humidifier.Base.BaseSubResource, IHaveStringListOfSubnetIdList, IHaveAvailabilityZone, IHaveStringListOfSecurityGroupIdList, IHaveSubnetId
        {
            /// <summary>
            /// SubnetIdList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-physicalconnectionrequirements.html#cfn-datazone-connection-physicalconnectionrequirements-subnetidlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIdList { get; set; }
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-physicalconnectionrequirements.html#cfn-datazone-connection-physicalconnectionrequirements-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AvailabilityZone { get; set; }
            /// <summary>
            /// SecurityGroupIdList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-physicalconnectionrequirements.html#cfn-datazone-connection-physicalconnectionrequirements-securitygroupidlist
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIdList { get; set; }
            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-physicalconnectionrequirements.html#cfn-datazone-connection-physicalconnectionrequirements-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SubnetId { get; set; }
        }

        public class RedshiftCredentials : Humidifier.Base.BaseSubResource, IHaveSecretArn, IHaveDataZoneConnectionTypesUsernamePasswordUsernamePassword
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftcredentials.html#cfn-datazone-connection-redshiftcredentials-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
            /// <summary>
            /// UsernamePassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftcredentials.html#cfn-datazone-connection-redshiftcredentials-usernamepassword
            /// Required: False
            /// UpdateType: Mutable
            /// Type: UsernamePassword
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.UsernamePassword, BaseFunction>? UsernamePassword { get; set; }
        }

        public class RedshiftLineageSyncConfigurationInput : Humidifier.Base.BaseSubResource, IHaveDataZoneConnectionTypesLineageSyncScheduleSchedule, IHaveEnabled_Boolean
        {
            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftlineagesyncconfigurationinput.html#cfn-datazone-connection-redshiftlineagesyncconfigurationinput-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LineageSyncSchedule
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.LineageSyncSchedule, BaseFunction>? Schedule { get; set; }
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftlineagesyncconfigurationinput.html#cfn-datazone-connection-redshiftlineagesyncconfigurationinput-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Enabled { get; set; }
        }

        public class RedshiftPropertiesInput : Humidifier.Base.BaseSubResource, IHaveDataZoneConnectionTypesRedshiftStoragePropertiesStorage, IHavePort_Double, IHaveDatabaseName, IHaveHost, IHaveDataZoneConnectionTypesRedshiftCredentialsCredentials, IHaveDataZoneConnectionTypesRedshiftLineageSyncConfigurationInputLineageSync
        {
            /// <summary>
            /// Storage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftpropertiesinput.html#cfn-datazone-connection-redshiftpropertiesinput-storage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftStorageProperties
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.RedshiftStorageProperties, BaseFunction>? Storage { get; set; }
            /// <summary>
            /// Port
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftpropertiesinput.html#cfn-datazone-connection-redshiftpropertiesinput-port
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? Port { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftpropertiesinput.html#cfn-datazone-connection-redshiftpropertiesinput-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftpropertiesinput.html#cfn-datazone-connection-redshiftpropertiesinput-host
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Host { get; set; }
            /// <summary>
            /// Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftpropertiesinput.html#cfn-datazone-connection-redshiftpropertiesinput-credentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftCredentials
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.RedshiftCredentials, BaseFunction>? Credentials { get; set; }
            /// <summary>
            /// LineageSync
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftpropertiesinput.html#cfn-datazone-connection-redshiftpropertiesinput-lineagesync
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftLineageSyncConfigurationInput
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.RedshiftLineageSyncConfigurationInput, BaseFunction>? LineageSync { get; set; }
        }

        public class RedshiftStorageProperties : Humidifier.Base.BaseSubResource, IHaveClusterName, IHaveWorkgroupName
        {
            /// <summary>
            /// ClusterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftstorageproperties.html#cfn-datazone-connection-redshiftstorageproperties-clustername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterName { get; set; }
            /// <summary>
            /// WorkgroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-redshiftstorageproperties.html#cfn-datazone-connection-redshiftstorageproperties-workgroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkgroupName { get; set; }
        }

        public class S3PropertiesInput : Humidifier.Base.BaseSubResource, IHaveS3Uri, IHaveS3AccessGrantLocationId, IHaveRegisterS3AccessGrantLocation_Boolean
        {
            /// <summary>
            /// S3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-s3propertiesinput.html#cfn-datazone-connection-s3propertiesinput-s3uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3Uri { get; set; }
            /// <summary>
            /// S3AccessGrantLocationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-s3propertiesinput.html#cfn-datazone-connection-s3propertiesinput-s3accessgrantlocationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? S3AccessGrantLocationId { get; set; }
            /// <summary>
            /// RegisterS3AccessGrantLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-s3propertiesinput.html#cfn-datazone-connection-s3propertiesinput-registers3accessgrantlocation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? RegisterS3AccessGrantLocation { get; set; }
        }

        public class SparkEmrPropertiesInput : Humidifier.Base.BaseSubResource, IHaveComputeArn, IHaveTrustedCertificatesS3Uri, IHaveLogUri, IHaveJavaVirtualEnv, IHavePythonVirtualEnv, IHaveRuntimeRole, IHaveInstanceProfileArn, IHaveManagedEndpointArn
        {
            /// <summary>
            /// ComputeArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkemrpropertiesinput.html#cfn-datazone-connection-sparkemrpropertiesinput-computearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ComputeArn { get; set; }
            /// <summary>
            /// TrustedCertificatesS3Uri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkemrpropertiesinput.html#cfn-datazone-connection-sparkemrpropertiesinput-trustedcertificatess3uri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TrustedCertificatesS3Uri { get; set; }
            /// <summary>
            /// LogUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkemrpropertiesinput.html#cfn-datazone-connection-sparkemrpropertiesinput-loguri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogUri { get; set; }
            /// <summary>
            /// JavaVirtualEnv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkemrpropertiesinput.html#cfn-datazone-connection-sparkemrpropertiesinput-javavirtualenv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JavaVirtualEnv { get; set; }
            /// <summary>
            /// PythonVirtualEnv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkemrpropertiesinput.html#cfn-datazone-connection-sparkemrpropertiesinput-pythonvirtualenv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PythonVirtualEnv { get; set; }
            /// <summary>
            /// RuntimeRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkemrpropertiesinput.html#cfn-datazone-connection-sparkemrpropertiesinput-runtimerole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RuntimeRole { get; set; }
            /// <summary>
            /// InstanceProfileArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkemrpropertiesinput.html#cfn-datazone-connection-sparkemrpropertiesinput-instanceprofilearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceProfileArn { get; set; }
            /// <summary>
            /// ManagedEndpointArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkemrpropertiesinput.html#cfn-datazone-connection-sparkemrpropertiesinput-managedendpointarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ManagedEndpointArn { get; set; }
        }

        public class SparkGlueArgs : Humidifier.Base.BaseSubResource, IHaveConnection
        {
            /// <summary>
            /// Connection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkglueargs.html#cfn-datazone-connection-sparkglueargs-connection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Connection { get; set; }
        }

        public class SparkGluePropertiesInput : Humidifier.Base.BaseSubResource, IHaveWorkerType, IHaveDataZoneConnectionTypesSparkGlueArgsAdditionalArgs, IHaveJavaVirtualEnv, IHaveGlueVersion, IHavePythonVirtualEnv, IHaveIdleTimeout_Double, IHaveGlueConnectionName, IHaveNumberOfWorkers_Double
        {
            /// <summary>
            /// WorkerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkgluepropertiesinput.html#cfn-datazone-connection-sparkgluepropertiesinput-workertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkerType { get; set; }
            /// <summary>
            /// AdditionalArgs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkgluepropertiesinput.html#cfn-datazone-connection-sparkgluepropertiesinput-additionalargs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SparkGlueArgs
            /// </summary>
            public Union<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs, BaseFunction>? AdditionalArgs { get; set; }
            /// <summary>
            /// JavaVirtualEnv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkgluepropertiesinput.html#cfn-datazone-connection-sparkgluepropertiesinput-javavirtualenv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JavaVirtualEnv { get; set; }
            /// <summary>
            /// GlueVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkgluepropertiesinput.html#cfn-datazone-connection-sparkgluepropertiesinput-glueversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlueVersion { get; set; }
            /// <summary>
            /// PythonVirtualEnv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkgluepropertiesinput.html#cfn-datazone-connection-sparkgluepropertiesinput-pythonvirtualenv
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PythonVirtualEnv { get; set; }
            /// <summary>
            /// IdleTimeout
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkgluepropertiesinput.html#cfn-datazone-connection-sparkgluepropertiesinput-idletimeout
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IdleTimeout { get; set; }
            /// <summary>
            /// GlueConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkgluepropertiesinput.html#cfn-datazone-connection-sparkgluepropertiesinput-glueconnectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlueConnectionName { get; set; }
            /// <summary>
            /// NumberOfWorkers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-sparkgluepropertiesinput.html#cfn-datazone-connection-sparkgluepropertiesinput-numberofworkers
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? NumberOfWorkers { get; set; }
        }

        public class UsernamePassword : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-usernamepassword.html#cfn-datazone-connection-usernamepassword-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-usernamepassword.html#cfn-datazone-connection-usernamepassword-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class WorkflowsMwaaPropertiesInput : Humidifier.Base.BaseSubResource, IHaveMwaaEnvironmentName
        {
            /// <summary>
            /// MwaaEnvironmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datazone-connection-workflowsmwaapropertiesinput.html#cfn-datazone-connection-workflowsmwaapropertiesinput-mwaaenvironmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MwaaEnvironmentName { get; set; }
        }
    }
}