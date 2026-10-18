namespace Humidifier.AppFlow
{
    using global::System.Collections.Generic;
    using ConnectorProfileTypes;

    public class ConnectorProfile : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveConnectorLabel, IHaveConnectorProfileName, IHaveKMSArn, IHaveConnectorType, IHaveConnectionMode, IHaveAppFlowConnectorProfileTypesConnectorProfileConfigConnectorProfileConfig
    {
        public class Attributes
        {
            public static string CredentialsArn =  "CredentialsArn" ;
            public static string ConnectorProfileArn =  "ConnectorProfileArn" ;
        }

        public override string AWSTypeName { get => AWS.AppFlow.ConnectorProfile; }
        /// <summary>
        /// ConnectorLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-connectorlabel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ConnectorLabel { get; set; }
        public Union<string, BaseFunction>? ConnectorProfileName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// KMSArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-kmsarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KMSArn { get; set; }

        /// <summary>
        /// ConnectorType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-connectortype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectorType { get; set; }

        /// <summary>
        /// ConnectionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-connectionmode
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectionMode { get; set; }
        /// <summary>
        /// ConnectorProfileConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appflow-connectorprofile.html#cfn-appflow-connectorprofile-connectorprofileconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ConnectorProfileConfig
        /// </summary>
        public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileConfig, BaseFunction>? ConnectorProfileConfig { get; set; }
    }

    namespace ConnectorProfileTypes
    {
        public class AmplitudeConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveSecretKey, IHaveApiKey
        {
            /// <summary>
            /// SecretKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-amplitudeconnectorprofilecredentials.html#cfn-appflow-connectorprofile-amplitudeconnectorprofilecredentials-secretkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretKey { get; set; }
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-amplitudeconnectorprofilecredentials.html#cfn-appflow-connectorprofile-amplitudeconnectorprofilecredentials-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKey { get; set; }
        }

        public class ApiKeyCredentials : Humidifier.Base.BaseSubResource, IHaveApiSecretKey, IHaveApiKey
        {
            /// <summary>
            /// ApiSecretKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-apikeycredentials.html#cfn-appflow-connectorprofile-apikeycredentials-apisecretkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiSecretKey { get; set; }
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-apikeycredentials.html#cfn-appflow-connectorprofile-apikeycredentials-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKey { get; set; }
        }

        public class BasicAuthCredentials : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-basicauthcredentials.html#cfn-appflow-connectorprofile-basicauthcredentials-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-basicauthcredentials.html#cfn-appflow-connectorprofile-basicauthcredentials-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class ConnectorOAuthRequest : Humidifier.Base.BaseSubResource, IHaveAuthCode, IHaveRedirectUri
        {
            /// <summary>
            /// AuthCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectoroauthrequest.html#cfn-appflow-connectorprofile-connectoroauthrequest-authcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthCode { get; set; }
            /// <summary>
            /// RedirectUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectoroauthrequest.html#cfn-appflow-connectorprofile-connectoroauthrequest-redirecturi
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RedirectUri { get; set; }
        }

        public class ConnectorProfileConfig : Humidifier.Base.BaseSubResource, IHaveAppFlowConnectorProfileTypesConnectorProfileCredentialsConnectorProfileCredentials, IHaveAppFlowConnectorProfileTypesConnectorProfilePropertiesConnectorProfileProperties
        {
            /// <summary>
            /// ConnectorProfileCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileconfig.html#cfn-appflow-connectorprofile-connectorprofileconfig-connectorprofilecredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileCredentials, BaseFunction>? ConnectorProfileCredentials { get; set; }
            /// <summary>
            /// ConnectorProfileProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileconfig.html#cfn-appflow-connectorprofile-connectorprofileconfig-connectorprofileproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorProfileProperties, BaseFunction>? ConnectorProfileProperties { get; set; }
        }

        public class ConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveAppFlowConnectorProfileTypesAmplitudeConnectorProfileCredentialsAmplitude, IHaveAppFlowConnectorProfileTypesGoogleAnalyticsConnectorProfileCredentialsGoogleAnalytics, IHaveAppFlowConnectorProfileTypesServiceNowConnectorProfileCredentialsServiceNow, IHaveAppFlowConnectorProfileTypesCustomConnectorProfileCredentialsCustomConnector, IHaveAppFlowConnectorProfileTypesSAPODataConnectorProfileCredentialsSAPOData, IHaveAppFlowConnectorProfileTypesPardotConnectorProfileCredentialsPardot, IHaveAppFlowConnectorProfileTypesVeevaConnectorProfileCredentialsVeeva, IHaveAppFlowConnectorProfileTypesTrendmicroConnectorProfileCredentialsTrendmicro, IHaveAppFlowConnectorProfileTypesDatadogConnectorProfileCredentialsDatadog, IHaveAppFlowConnectorProfileTypesMarketoConnectorProfileCredentialsMarketo, IHaveAppFlowConnectorProfileTypesRedshiftConnectorProfileCredentialsRedshift, IHaveAppFlowConnectorProfileTypesSingularConnectorProfileCredentialsSingular, IHaveAppFlowConnectorProfileTypesSlackConnectorProfileCredentialsSlack, IHaveAppFlowConnectorProfileTypesSnowflakeConnectorProfileCredentialsSnowflake, IHaveAppFlowConnectorProfileTypesDynatraceConnectorProfileCredentialsDynatrace, IHaveAppFlowConnectorProfileTypesZendeskConnectorProfileCredentialsZendesk, IHaveAppFlowConnectorProfileTypesInforNexusConnectorProfileCredentialsInforNexus, IHaveAppFlowConnectorProfileTypesSalesforceConnectorProfileCredentialsSalesforce
        {
            /// <summary>
            /// Amplitude
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-amplitude
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmplitudeConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.AmplitudeConnectorProfileCredentials, BaseFunction>? Amplitude { get; set; }
            /// <summary>
            /// GoogleAnalytics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-googleanalytics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GoogleAnalyticsConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.GoogleAnalyticsConnectorProfileCredentials, BaseFunction>? GoogleAnalytics { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileCredentials, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// CustomConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-customconnector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.CustomConnectorProfileCredentials, BaseFunction>? CustomConnector { get; set; }
            /// <summary>
            /// SAPOData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-sapodata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SAPODataConnectorProfileCredentials, BaseFunction>? SAPOData { get; set; }
            /// <summary>
            /// Pardot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-pardot
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PardotConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.PardotConnectorProfileCredentials, BaseFunction>? Pardot { get; set; }
            /// <summary>
            /// Veeva
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-veeva
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VeevaConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileCredentials, BaseFunction>? Veeva { get; set; }
            /// <summary>
            /// Trendmicro
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-trendmicro
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TrendmicroConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.TrendmicroConnectorProfileCredentials, BaseFunction>? Trendmicro { get; set; }
            /// <summary>
            /// Datadog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-datadog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatadogConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileCredentials, BaseFunction>? Datadog { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarketoConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileCredentials, BaseFunction>? Marketo { get; set; }
            /// <summary>
            /// Redshift
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-redshift
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileCredentials, BaseFunction>? Redshift { get; set; }
            /// <summary>
            /// Singular
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-singular
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SingularConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SingularConnectorProfileCredentials, BaseFunction>? Singular { get; set; }
            /// <summary>
            /// Slack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-slack
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlackConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SlackConnectorProfileCredentials, BaseFunction>? Slack { get; set; }
            /// <summary>
            /// Snowflake
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-snowflake
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnowflakeConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileCredentials, BaseFunction>? Snowflake { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynatraceConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileCredentials, BaseFunction>? Dynatrace { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZendeskConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileCredentials, BaseFunction>? Zendesk { get; set; }
            /// <summary>
            /// InforNexus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-infornexus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InforNexusConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileCredentials, BaseFunction>? InforNexus { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofilecredentials.html#cfn-appflow-connectorprofile-connectorprofilecredentials-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceConnectorProfileCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileCredentials, BaseFunction>? Salesforce { get; set; }
        }

        public class ConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveAppFlowConnectorProfileTypesServiceNowConnectorProfilePropertiesServiceNow, IHaveAppFlowConnectorProfileTypesCustomConnectorProfilePropertiesCustomConnector, IHaveAppFlowConnectorProfileTypesSAPODataConnectorProfilePropertiesSAPOData, IHaveAppFlowConnectorProfileTypesPardotConnectorProfilePropertiesPardot, IHaveAppFlowConnectorProfileTypesVeevaConnectorProfilePropertiesVeeva, IHaveAppFlowConnectorProfileTypesDatadogConnectorProfilePropertiesDatadog, IHaveAppFlowConnectorProfileTypesMarketoConnectorProfilePropertiesMarketo, IHaveAppFlowConnectorProfileTypesRedshiftConnectorProfilePropertiesRedshift, IHaveAppFlowConnectorProfileTypesSlackConnectorProfilePropertiesSlack, IHaveAppFlowConnectorProfileTypesSnowflakeConnectorProfilePropertiesSnowflake, IHaveAppFlowConnectorProfileTypesDynatraceConnectorProfilePropertiesDynatrace, IHaveAppFlowConnectorProfileTypesZendeskConnectorProfilePropertiesZendesk, IHaveAppFlowConnectorProfileTypesInforNexusConnectorProfilePropertiesInforNexus, IHaveAppFlowConnectorProfileTypesSalesforceConnectorProfilePropertiesSalesforce
        {
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ServiceNowConnectorProfileProperties, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// CustomConnector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-customconnector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.CustomConnectorProfileProperties, BaseFunction>? CustomConnector { get; set; }
            /// <summary>
            /// SAPOData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-sapodata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SAPODataConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SAPODataConnectorProfileProperties, BaseFunction>? SAPOData { get; set; }
            /// <summary>
            /// Pardot
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-pardot
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PardotConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.PardotConnectorProfileProperties, BaseFunction>? Pardot { get; set; }
            /// <summary>
            /// Veeva
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-veeva
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VeevaConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.VeevaConnectorProfileProperties, BaseFunction>? Veeva { get; set; }
            /// <summary>
            /// Datadog
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-datadog
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatadogConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.DatadogConnectorProfileProperties, BaseFunction>? Datadog { get; set; }
            /// <summary>
            /// Marketo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-marketo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MarketoConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.MarketoConnectorProfileProperties, BaseFunction>? Marketo { get; set; }
            /// <summary>
            /// Redshift
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-redshift
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.RedshiftConnectorProfileProperties, BaseFunction>? Redshift { get; set; }
            /// <summary>
            /// Slack
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-slack
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SlackConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SlackConnectorProfileProperties, BaseFunction>? Slack { get; set; }
            /// <summary>
            /// Snowflake
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-snowflake
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SnowflakeConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SnowflakeConnectorProfileProperties, BaseFunction>? Snowflake { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DynatraceConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.DynatraceConnectorProfileProperties, BaseFunction>? Dynatrace { get; set; }
            /// <summary>
            /// Zendesk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-zendesk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ZendeskConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ZendeskConnectorProfileProperties, BaseFunction>? Zendesk { get; set; }
            /// <summary>
            /// InforNexus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-infornexus
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InforNexusConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.InforNexusConnectorProfileProperties, BaseFunction>? InforNexus { get; set; }
            /// <summary>
            /// Salesforce
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-connectorprofileproperties.html#cfn-appflow-connectorprofile-connectorprofileproperties-salesforce
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceConnectorProfileProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.SalesforceConnectorProfileProperties, BaseFunction>? Salesforce { get; set; }
        }

        public class CustomAuthCredentials : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfCredentialsMap, IHaveCustomAuthenticationType
        {
            /// <summary>
            /// CredentialsMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customauthcredentials.html#cfn-appflow-connectorprofile-customauthcredentials-credentialsmap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CredentialsMap { get; set; }
            /// <summary>
            /// CustomAuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customauthcredentials.html#cfn-appflow-connectorprofile-customauthcredentials-customauthenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomAuthenticationType { get; set; }
        }

        public class CustomConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveAppFlowConnectorProfileTypesBasicAuthCredentialsBasic, IHaveAppFlowConnectorProfileTypesApiKeyCredentialsApiKey, IHaveAppFlowConnectorProfileTypesOAuth2CredentialsOauth2, IHaveAppFlowConnectorProfileTypesCustomAuthCredentialsCustom, IHaveAuthenticationType
        {
            /// <summary>
            /// Basic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customconnectorprofilecredentials.html#cfn-appflow-connectorprofile-customconnectorprofilecredentials-basic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.BasicAuthCredentials, BaseFunction>? Basic { get; set; }
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customconnectorprofilecredentials.html#cfn-appflow-connectorprofile-customconnectorprofilecredentials-apikey
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiKeyCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ApiKeyCredentials, BaseFunction>? ApiKey { get; set; }
            /// <summary>
            /// Oauth2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customconnectorprofilecredentials.html#cfn-appflow-connectorprofile-customconnectorprofilecredentials-oauth2
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2Credentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials, BaseFunction>? Oauth2 { get; set; }
            /// <summary>
            /// Custom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customconnectorprofilecredentials.html#cfn-appflow-connectorprofile-customconnectorprofilecredentials-custom
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomAuthCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.CustomAuthCredentials, BaseFunction>? Custom { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customconnectorprofilecredentials.html#cfn-appflow-connectorprofile-customconnectorprofilecredentials-authenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class CustomConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveAppFlowConnectorProfileTypesOAuth2PropertiesOAuth2Properties, IHaveStringDictionaryOfProfileProperties
        {
            /// <summary>
            /// OAuth2Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customconnectorprofileproperties.html#cfn-appflow-connectorprofile-customconnectorprofileproperties-oauth2properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2Properties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Properties, BaseFunction>? OAuth2Properties { get; set; }
            /// <summary>
            /// ProfileProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-customconnectorprofileproperties.html#cfn-appflow-connectorprofile-customconnectorprofileproperties-profileproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? ProfileProperties { get; set; }
        }

        public class DatadogConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveApplicationKey, IHaveApiKey
        {
            /// <summary>
            /// ApplicationKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-datadogconnectorprofilecredentials.html#cfn-appflow-connectorprofile-datadogconnectorprofilecredentials-applicationkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationKey { get; set; }
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-datadogconnectorprofilecredentials.html#cfn-appflow-connectorprofile-datadogconnectorprofilecredentials-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKey { get; set; }
        }

        public class DatadogConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-datadogconnectorprofileproperties.html#cfn-appflow-connectorprofile-datadogconnectorprofileproperties-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }

        public class DynatraceConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveApiToken
        {
            /// <summary>
            /// ApiToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-dynatraceconnectorprofilecredentials.html#cfn-appflow-connectorprofile-dynatraceconnectorprofilecredentials-apitoken
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiToken { get; set; }
        }

        public class DynatraceConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-dynatraceconnectorprofileproperties.html#cfn-appflow-connectorprofile-dynatraceconnectorprofileproperties-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }

        public class GoogleAnalyticsConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveRefreshToken, IHaveClientSecret, IHaveAccessToken, IHaveClientId, IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestConnectorOAuthRequest
        {
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials.html#cfn-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials-refreshtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials.html#cfn-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials.html#cfn-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials.html#cfn-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ConnectorOAuthRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials.html#cfn-appflow-connectorprofile-googleanalyticsconnectorprofilecredentials-connectoroauthrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOAuthRequest
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest, BaseFunction>? ConnectorOAuthRequest { get; set; }
        }

        public class InforNexusConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveAccessKeyId, IHaveUserId, IHaveSecretAccessKey, IHaveDatakey
        {
            /// <summary>
            /// AccessKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-infornexusconnectorprofilecredentials.html#cfn-appflow-connectorprofile-infornexusconnectorprofilecredentials-accesskeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessKeyId { get; set; }
            /// <summary>
            /// UserId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-infornexusconnectorprofilecredentials.html#cfn-appflow-connectorprofile-infornexusconnectorprofilecredentials-userid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserId { get; set; }
            /// <summary>
            /// SecretAccessKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-infornexusconnectorprofilecredentials.html#cfn-appflow-connectorprofile-infornexusconnectorprofilecredentials-secretaccesskey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretAccessKey { get; set; }
            /// <summary>
            /// Datakey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-infornexusconnectorprofilecredentials.html#cfn-appflow-connectorprofile-infornexusconnectorprofilecredentials-datakey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Datakey { get; set; }
        }

        public class InforNexusConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-infornexusconnectorprofileproperties.html#cfn-appflow-connectorprofile-infornexusconnectorprofileproperties-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }

        public class MarketoConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveClientSecret, IHaveAccessToken, IHaveClientId, IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestConnectorOAuthRequest
        {
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-marketoconnectorprofilecredentials.html#cfn-appflow-connectorprofile-marketoconnectorprofilecredentials-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-marketoconnectorprofilecredentials.html#cfn-appflow-connectorprofile-marketoconnectorprofilecredentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-marketoconnectorprofilecredentials.html#cfn-appflow-connectorprofile-marketoconnectorprofilecredentials-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ConnectorOAuthRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-marketoconnectorprofilecredentials.html#cfn-appflow-connectorprofile-marketoconnectorprofilecredentials-connectoroauthrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOAuthRequest
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest, BaseFunction>? ConnectorOAuthRequest { get; set; }
        }

        public class MarketoConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-marketoconnectorprofileproperties.html#cfn-appflow-connectorprofile-marketoconnectorprofileproperties-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }

        public class OAuth2Credentials : Humidifier.Base.BaseSubResource, IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestOAuthRequest, IHaveClientId, IHaveRefreshToken, IHaveClientSecret, IHaveAccessToken
        {
            /// <summary>
            /// OAuthRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauth2credentials.html#cfn-appflow-connectorprofile-oauth2credentials-oauthrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOAuthRequest
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest, BaseFunction>? OAuthRequest { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauth2credentials.html#cfn-appflow-connectorprofile-oauth2credentials-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauth2credentials.html#cfn-appflow-connectorprofile-oauth2credentials-refreshtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauth2credentials.html#cfn-appflow-connectorprofile-oauth2credentials-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauth2credentials.html#cfn-appflow-connectorprofile-oauth2credentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
        }

        public class OAuth2Properties : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfTokenUrlCustomProperties, IHaveTokenUrl, IHaveOAuth2GrantType
        {
            /// <summary>
            /// TokenUrlCustomProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauth2properties.html#cfn-appflow-connectorprofile-oauth2properties-tokenurlcustomproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TokenUrlCustomProperties { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauth2properties.html#cfn-appflow-connectorprofile-oauth2properties-tokenurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenUrl { get; set; }
            /// <summary>
            /// OAuth2GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauth2properties.html#cfn-appflow-connectorprofile-oauth2properties-oauth2granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OAuth2GrantType { get; set; }
        }

        public class OAuthCredentials : Humidifier.Base.BaseSubResource, IHaveRefreshToken, IHaveAccessToken, IHaveClientSecret, IHaveClientId, IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestConnectorOAuthRequest
        {
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauthcredentials.html#cfn-appflow-connectorprofile-oauthcredentials-refreshtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauthcredentials.html#cfn-appflow-connectorprofile-oauthcredentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauthcredentials.html#cfn-appflow-connectorprofile-oauthcredentials-clientsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauthcredentials.html#cfn-appflow-connectorprofile-oauthcredentials-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ConnectorOAuthRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauthcredentials.html#cfn-appflow-connectorprofile-oauthcredentials-connectoroauthrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOAuthRequest
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest, BaseFunction>? ConnectorOAuthRequest { get; set; }
        }

        public class OAuthProperties : Humidifier.Base.BaseSubResource, IHaveAuthCodeUrl, IHaveTokenUrl, IHaveStringListOfOAuthScopes
        {
            /// <summary>
            /// AuthCodeUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauthproperties.html#cfn-appflow-connectorprofile-oauthproperties-authcodeurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthCodeUrl { get; set; }
            /// <summary>
            /// TokenUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauthproperties.html#cfn-appflow-connectorprofile-oauthproperties-tokenurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenUrl { get; set; }
            /// <summary>
            /// OAuthScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-oauthproperties.html#cfn-appflow-connectorprofile-oauthproperties-oauthscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OAuthScopes { get; set; }
        }

        public class PardotConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveRefreshToken, IHaveAccessToken, IHaveClientCredentialsArn, IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestConnectorOAuthRequest
        {
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-pardotconnectorprofilecredentials.html#cfn-appflow-connectorprofile-pardotconnectorprofilecredentials-refreshtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-pardotconnectorprofilecredentials.html#cfn-appflow-connectorprofile-pardotconnectorprofilecredentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
            /// <summary>
            /// ClientCredentialsArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-pardotconnectorprofilecredentials.html#cfn-appflow-connectorprofile-pardotconnectorprofilecredentials-clientcredentialsarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCredentialsArn { get; set; }
            /// <summary>
            /// ConnectorOAuthRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-pardotconnectorprofilecredentials.html#cfn-appflow-connectorprofile-pardotconnectorprofilecredentials-connectoroauthrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOAuthRequest
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest, BaseFunction>? ConnectorOAuthRequest { get; set; }
        }

        public class PardotConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl, IHaveIsSandboxEnvironment_Boolean, IHaveBusinessUnitId
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-pardotconnectorprofileproperties.html#cfn-appflow-connectorprofile-pardotconnectorprofileproperties-instanceurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
            /// <summary>
            /// IsSandboxEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-pardotconnectorprofileproperties.html#cfn-appflow-connectorprofile-pardotconnectorprofileproperties-issandboxenvironment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsSandboxEnvironment { get; set; }
            /// <summary>
            /// BusinessUnitId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-pardotconnectorprofileproperties.html#cfn-appflow-connectorprofile-pardotconnectorprofileproperties-businessunitid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BusinessUnitId { get; set; }
        }

        public class RedshiftConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofilecredentials.html#cfn-appflow-connectorprofile-redshiftconnectorprofilecredentials-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofilecredentials.html#cfn-appflow-connectorprofile-redshiftconnectorprofilecredentials-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class RedshiftConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveDatabaseUrl, IHaveBucketName, IHaveIsRedshiftServerless_Boolean, IHaveDataApiRoleArn, IHaveDatabaseName, IHaveWorkgroupName, IHaveBucketPrefix, IHaveClusterIdentifier, IHaveRoleArn
        {
            /// <summary>
            /// DatabaseUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-databaseurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseUrl { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// IsRedshiftServerless
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-isredshiftserverless
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsRedshiftServerless { get; set; }
            /// <summary>
            /// DataApiRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-dataapirolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataApiRoleArn { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// WorkgroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-workgroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkgroupName { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
            /// <summary>
            /// ClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-clusteridentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterIdentifier { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class SAPODataConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveAppFlowConnectorProfileTypesBasicAuthCredentialsBasicAuthCredentials, IHaveAppFlowConnectorProfileTypesOAuthCredentialsOAuthCredentials
        {
            /// <summary>
            /// BasicAuthCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofilecredentials.html#cfn-appflow-connectorprofile-sapodataconnectorprofilecredentials-basicauthcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.BasicAuthCredentials, BaseFunction>? BasicAuthCredentials { get; set; }
            /// <summary>
            /// OAuthCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofilecredentials.html#cfn-appflow-connectorprofile-sapodataconnectorprofilecredentials-oauthcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthCredentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.OAuthCredentials, BaseFunction>? OAuthCredentials { get; set; }
        }

        public class SAPODataConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveApplicationServicePath, IHaveApplicationHostUrl, IHaveAppFlowConnectorProfileTypesOAuthPropertiesOAuthProperties, IHaveDisableSSO_Boolean, IHaveLogonLanguage, IHavePrivateLinkServiceName, IHavePortNumber_Integer, IHaveClientNumber
        {
            /// <summary>
            /// ApplicationServicePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofileproperties.html#cfn-appflow-connectorprofile-sapodataconnectorprofileproperties-applicationservicepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationServicePath { get; set; }
            /// <summary>
            /// ApplicationHostUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofileproperties.html#cfn-appflow-connectorprofile-sapodataconnectorprofileproperties-applicationhosturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationHostUrl { get; set; }
            /// <summary>
            /// OAuthProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofileproperties.html#cfn-appflow-connectorprofile-sapodataconnectorprofileproperties-oauthproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuthProperties
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.OAuthProperties, BaseFunction>? OAuthProperties { get; set; }
            /// <summary>
            /// DisableSSO
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofileproperties.html#cfn-appflow-connectorprofile-sapodataconnectorprofileproperties-disablesso
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? DisableSSO { get; set; }
            /// <summary>
            /// LogonLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofileproperties.html#cfn-appflow-connectorprofile-sapodataconnectorprofileproperties-logonlanguage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogonLanguage { get; set; }
            /// <summary>
            /// PrivateLinkServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofileproperties.html#cfn-appflow-connectorprofile-sapodataconnectorprofileproperties-privatelinkservicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateLinkServiceName { get; set; }
            /// <summary>
            /// PortNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofileproperties.html#cfn-appflow-connectorprofile-sapodataconnectorprofileproperties-portnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? PortNumber { get; set; }
            /// <summary>
            /// ClientNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-sapodataconnectorprofileproperties.html#cfn-appflow-connectorprofile-sapodataconnectorprofileproperties-clientnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientNumber { get; set; }
        }

        public class SalesforceConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveJwtToken, IHaveRefreshToken, IHaveAccessToken, IHaveClientCredentialsArn, IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestConnectorOAuthRequest, IHaveOAuth2GrantType
        {
            /// <summary>
            /// JwtToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofilecredentials.html#cfn-appflow-connectorprofile-salesforceconnectorprofilecredentials-jwttoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JwtToken { get; set; }
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofilecredentials.html#cfn-appflow-connectorprofile-salesforceconnectorprofilecredentials-refreshtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofilecredentials.html#cfn-appflow-connectorprofile-salesforceconnectorprofilecredentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
            /// <summary>
            /// ClientCredentialsArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofilecredentials.html#cfn-appflow-connectorprofile-salesforceconnectorprofilecredentials-clientcredentialsarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientCredentialsArn { get; set; }
            /// <summary>
            /// ConnectorOAuthRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofilecredentials.html#cfn-appflow-connectorprofile-salesforceconnectorprofilecredentials-connectoroauthrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOAuthRequest
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest, BaseFunction>? ConnectorOAuthRequest { get; set; }
            /// <summary>
            /// OAuth2GrantType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofilecredentials.html#cfn-appflow-connectorprofile-salesforceconnectorprofilecredentials-oauth2granttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OAuth2GrantType { get; set; }
        }

        public class SalesforceConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl, IHaveisSandboxEnvironment_Boolean, IHaveusePrivateLinkForMetadataAndAuthorization_Boolean
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofileproperties.html#cfn-appflow-connectorprofile-salesforceconnectorprofileproperties-instanceurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
            /// <summary>
            /// isSandboxEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofileproperties.html#cfn-appflow-connectorprofile-salesforceconnectorprofileproperties-issandboxenvironment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? isSandboxEnvironment { get; set; }
            /// <summary>
            /// usePrivateLinkForMetadataAndAuthorization
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-salesforceconnectorprofileproperties.html#cfn-appflow-connectorprofile-salesforceconnectorprofileproperties-useprivatelinkformetadataandauthorization
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? usePrivateLinkForMetadataAndAuthorization { get; set; }
        }

        public class ServiceNowConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveUsername, IHaveAppFlowConnectorProfileTypesOAuth2CredentialsOAuth2Credentials, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-servicenowconnectorprofilecredentials.html#cfn-appflow-connectorprofile-servicenowconnectorprofilecredentials-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// OAuth2Credentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-servicenowconnectorprofilecredentials.html#cfn-appflow-connectorprofile-servicenowconnectorprofilecredentials-oauth2credentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OAuth2Credentials
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.OAuth2Credentials, BaseFunction>? OAuth2Credentials { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-servicenowconnectorprofilecredentials.html#cfn-appflow-connectorprofile-servicenowconnectorprofilecredentials-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class ServiceNowConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-servicenowconnectorprofileproperties.html#cfn-appflow-connectorprofile-servicenowconnectorprofileproperties-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }

        public class SingularConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveApiKey
        {
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-singularconnectorprofilecredentials.html#cfn-appflow-connectorprofile-singularconnectorprofilecredentials-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKey { get; set; }
        }

        public class SlackConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveClientSecret, IHaveAccessToken, IHaveClientId, IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestConnectorOAuthRequest
        {
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-slackconnectorprofilecredentials.html#cfn-appflow-connectorprofile-slackconnectorprofilecredentials-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-slackconnectorprofilecredentials.html#cfn-appflow-connectorprofile-slackconnectorprofilecredentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-slackconnectorprofilecredentials.html#cfn-appflow-connectorprofile-slackconnectorprofilecredentials-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ConnectorOAuthRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-slackconnectorprofilecredentials.html#cfn-appflow-connectorprofile-slackconnectorprofilecredentials-connectoroauthrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOAuthRequest
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest, BaseFunction>? ConnectorOAuthRequest { get; set; }
        }

        public class SlackConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-slackconnectorprofileproperties.html#cfn-appflow-connectorprofile-slackconnectorprofileproperties-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }

        public class SnowflakeConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofilecredentials.html#cfn-appflow-connectorprofile-snowflakeconnectorprofilecredentials-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofilecredentials.html#cfn-appflow-connectorprofile-snowflakeconnectorprofilecredentials-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class SnowflakeConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveWarehouse, IHaveBucketName, IHavePrivateLinkServiceName, IHaveStage, IHaveRegion, IHaveBucketPrefix, IHaveAccountName
        {
            /// <summary>
            /// Warehouse
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofileproperties.html#cfn-appflow-connectorprofile-snowflakeconnectorprofileproperties-warehouse
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Warehouse { get; set; }
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofileproperties.html#cfn-appflow-connectorprofile-snowflakeconnectorprofileproperties-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// PrivateLinkServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofileproperties.html#cfn-appflow-connectorprofile-snowflakeconnectorprofileproperties-privatelinkservicename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrivateLinkServiceName { get; set; }
            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofileproperties.html#cfn-appflow-connectorprofile-snowflakeconnectorprofileproperties-stage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Stage { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofileproperties.html#cfn-appflow-connectorprofile-snowflakeconnectorprofileproperties-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// BucketPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofileproperties.html#cfn-appflow-connectorprofile-snowflakeconnectorprofileproperties-bucketprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketPrefix { get; set; }
            /// <summary>
            /// AccountName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-snowflakeconnectorprofileproperties.html#cfn-appflow-connectorprofile-snowflakeconnectorprofileproperties-accountname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountName { get; set; }
        }

        public class TrendmicroConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveApiSecretKey
        {
            /// <summary>
            /// ApiSecretKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-trendmicroconnectorprofilecredentials.html#cfn-appflow-connectorprofile-trendmicroconnectorprofilecredentials-apisecretkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiSecretKey { get; set; }
        }

        public class VeevaConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveUsername, IHavePassword
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-veevaconnectorprofilecredentials.html#cfn-appflow-connectorprofile-veevaconnectorprofilecredentials-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Username { get; set; }
            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-veevaconnectorprofilecredentials.html#cfn-appflow-connectorprofile-veevaconnectorprofilecredentials-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Password { get; set; }
        }

        public class VeevaConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-veevaconnectorprofileproperties.html#cfn-appflow-connectorprofile-veevaconnectorprofileproperties-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }

        public class ZendeskConnectorProfileCredentials : Humidifier.Base.BaseSubResource, IHaveClientSecret, IHaveAccessToken, IHaveClientId, IHaveAppFlowConnectorProfileTypesConnectorOAuthRequestConnectorOAuthRequest
        {
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-zendeskconnectorprofilecredentials.html#cfn-appflow-connectorprofile-zendeskconnectorprofilecredentials-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-zendeskconnectorprofilecredentials.html#cfn-appflow-connectorprofile-zendeskconnectorprofilecredentials-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-zendeskconnectorprofilecredentials.html#cfn-appflow-connectorprofile-zendeskconnectorprofilecredentials-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ConnectorOAuthRequest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-zendeskconnectorprofilecredentials.html#cfn-appflow-connectorprofile-zendeskconnectorprofilecredentials-connectoroauthrequest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectorOAuthRequest
            /// </summary>
            public Union<Humidifier.AppFlow.ConnectorProfileTypes.ConnectorOAuthRequest, BaseFunction>? ConnectorOAuthRequest { get; set; }
        }

        public class ZendeskConnectorProfileProperties : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-zendeskconnectorprofileproperties.html#cfn-appflow-connectorprofile-zendeskconnectorprofileproperties-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }
    }
}