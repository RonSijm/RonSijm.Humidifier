namespace Humidifier.DevOpsAgent
{
    using global::System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePrivateConnectionName, IHaveDevOpsAgentServiceTypesServiceDetailsServiceDetails, IHaveKmsKeyArn, IHaveServiceType, IHaveExchangeUrlPrivateConnectionName, IHaveTargetUrlPrivateConnectionName, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string ServiceId =  "ServiceId" ;
            public static string AdditionalServiceDetails =  "AdditionalServiceDetails" ;
            public static string AccessibleResources =  "AccessibleResources" ;
        }

        public override string AWSTypeName { get => AWS.DevOpsAgent.Service; }
        /// <summary>
        /// PrivateConnectionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-privateconnectionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PrivateConnectionName { get; set; }
        /// <summary>
        /// ServiceDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-servicedetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceDetails
        /// </summary>
        public Union<Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails, BaseFunction>? ServiceDetails { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }

        /// <summary>
        /// ServiceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-servicetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ServiceType { get; set; }
        /// <summary>
        /// ExchangeUrlPrivateConnectionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-exchangeurlprivateconnectionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ExchangeUrlPrivateConnectionName { get; set; }
        /// <summary>
        /// TargetUrlPrivateConnectionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-targeturlprivateconnectionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? TargetUrlPrivateConnectionName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ServiceTypes
    {
        public class AdditionalServiceDetails : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesRegisteredMCPServerDetailsMCPServer, IHaveDevOpsAgentServiceTypesRegisteredServiceNowDetailsServiceNow, IHaveDevOpsAgentServiceTypesRegisteredGitHubServiceDetailsGitHub, IHaveDevOpsAgentServiceTypesRegisteredAzureIdentityDetailsAzureIdentity, IHaveDevOpsAgentServiceTypesRegisteredMCPServerGrafanaDetailsMCPServerGrafana, IHaveDevOpsAgentServiceTypesRegisteredDynatraceDetailsDynatrace, IHaveDevOpsAgentServiceTypesRegisteredMCPServerSigV4DetailsMCPServerSigV4, IHaveDevOpsAgentServiceTypesRegisteredMCPServerDetailsMCPServerSplunk, IHaveDevOpsAgentServiceTypesRegisteredNewRelicDetailsMCPServerNewRelic, IHaveDevOpsAgentServiceTypesRegisteredGitLabServiceDetailsGitLab, IHaveDevOpsAgentServiceTypesRegisteredPagerDutyDetailsPagerDuty
        {
            /// <summary>
            /// MCPServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredMCPServerDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredMCPServerDetails, BaseFunction>? MCPServer { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredServiceNowDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredServiceNowDetails, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// GitHub
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-github
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredGitHubServiceDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredGitHubServiceDetails, BaseFunction>? GitHub { get; set; }
            /// <summary>
            /// AzureIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-azureidentity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredAzureIdentityDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredAzureIdentityDetails, BaseFunction>? AzureIdentity { get; set; }
            /// <summary>
            /// MCPServerGrafana
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpservergrafana
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredMCPServerGrafanaDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredMCPServerGrafanaDetails, BaseFunction>? MCPServerGrafana { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredDynatraceDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredDynatraceDetails, BaseFunction>? Dynatrace { get; set; }
            /// <summary>
            /// MCPServerSigV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpserversigv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredMCPServerSigV4Details
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredMCPServerSigV4Details, BaseFunction>? MCPServerSigV4 { get; set; }
            /// <summary>
            /// MCPServerSplunk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpserversplunk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredMCPServerDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredMCPServerDetails, BaseFunction>? MCPServerSplunk { get; set; }
            /// <summary>
            /// MCPServerNewRelic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpservernewrelic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredNewRelicDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredNewRelicDetails, BaseFunction>? MCPServerNewRelic { get; set; }
            /// <summary>
            /// GitLab
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-gitlab
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredGitLabServiceDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredGitLabServiceDetails, BaseFunction>? GitLab { get; set; }
            /// <summary>
            /// PagerDuty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-pagerduty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredPagerDutyDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.RegisteredPagerDutyDetails, BaseFunction>? PagerDuty { get; set; }
        }

        public class ApiKeyDetails : Humidifier.Base.BaseSubResource, IHaveApiKeyHeader, IHaveApiKeyValue, IHaveApiKeyName
        {
            /// <summary>
            /// ApiKeyHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-apikeydetails.html#cfn-devopsagent-service-apikeydetails-apikeyheader
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyHeader { get; set; }
            /// <summary>
            /// ApiKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-apikeydetails.html#cfn-devopsagent-service-apikeydetails-apikeyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyValue { get; set; }
            /// <summary>
            /// ApiKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-apikeydetails.html#cfn-devopsagent-service-apikeydetails-apikeyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyName { get; set; }
        }

        public class AzureIdentityServiceDetails : Humidifier.Base.BaseSubResource, IHaveWebIdentityRoleArn, IHaveTenantId, IHaveClientId, IHaveStringListOfWebIdentityTokenAudiences
        {
            /// <summary>
            /// WebIdentityRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-azureidentityservicedetails.html#cfn-devopsagent-service-azureidentityservicedetails-webidentityrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WebIdentityRoleArn { get; set; }
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-azureidentityservicedetails.html#cfn-devopsagent-service-azureidentityservicedetails-tenantid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-azureidentityservicedetails.html#cfn-devopsagent-service-azureidentityservicedetails-clientid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// WebIdentityTokenAudiences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-azureidentityservicedetails.html#cfn-devopsagent-service-azureidentityservicedetails-webidentitytokenaudiences
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WebIdentityTokenAudiences { get; set; }
        }

        public class BearerTokenDetails : Humidifier.Base.BaseSubResource, IHaveTokenName, IHaveAuthorizationHeader, IHaveTokenValue
        {
            /// <summary>
            /// TokenName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-bearertokendetails.html#cfn-devopsagent-service-bearertokendetails-tokenname
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenName { get; set; }
            /// <summary>
            /// AuthorizationHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-bearertokendetails.html#cfn-devopsagent-service-bearertokendetails-authorizationheader
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationHeader { get; set; }
            /// <summary>
            /// TokenValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-bearertokendetails.html#cfn-devopsagent-service-bearertokendetails-tokenvalue
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenValue { get; set; }
        }

        public class DynatraceAuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesOAuthClientDetailsOAuthClientCredentials
        {
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-dynatraceauthorizationconfig.html#cfn-devopsagent-service-dynatraceauthorizationconfig-oauthclientcredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OAuthClientDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails, BaseFunction>? OAuthClientCredentials { get; set; }
        }

        public class DynatraceServiceDetails : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesDynatraceAuthorizationConfigAuthorizationConfig, IHaveAccountUrn
        {
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-dynatraceservicedetails.html#cfn-devopsagent-service-dynatraceservicedetails-authorizationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DynatraceAuthorizationConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
            /// <summary>
            /// AccountUrn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-dynatraceservicedetails.html#cfn-devopsagent-service-dynatraceservicedetails-accounturn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountUrn { get; set; }
        }

        public class GitHubAppVerificationDetails : Humidifier.Base.BaseSubResource, IHaveOrganizationName, IHaveTargetUrl, IHaveAppVariant, IHaveTokenValue
        {
            /// <summary>
            /// OrganizationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubappverificationdetails.html#cfn-devopsagent-service-githubappverificationdetails-organizationname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationName { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubappverificationdetails.html#cfn-devopsagent-service-githubappverificationdetails-targeturl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetUrl { get; set; }
            /// <summary>
            /// AppVariant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubappverificationdetails.html#cfn-devopsagent-service-githubappverificationdetails-appvariant
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppVariant { get; set; }
            /// <summary>
            /// TokenValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubappverificationdetails.html#cfn-devopsagent-service-githubappverificationdetails-tokenvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenValue { get; set; }
        }

        public class GitHubDetails : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesGitHubPatDetailsDirectAccess, IHaveDevOpsAgentServiceTypesGitHubAppVerificationDetailsAppVerification
        {
            /// <summary>
            /// DirectAccess
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubdetails.html#cfn-devopsagent-service-githubdetails-directaccess
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GitHubPatDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.GitHubPatDetails, BaseFunction>? DirectAccess { get; set; }
            /// <summary>
            /// AppVerification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubdetails.html#cfn-devopsagent-service-githubdetails-appverification
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GitHubAppVerificationDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.GitHubAppVerificationDetails, BaseFunction>? AppVerification { get; set; }
        }

        public class GitHubPatDetails : Humidifier.Base.BaseSubResource, IHaveOrganizationName, IHaveTargetUrl, IHaveTokenValue
        {
            /// <summary>
            /// OrganizationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubpatdetails.html#cfn-devopsagent-service-githubpatdetails-organizationname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrganizationName { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubpatdetails.html#cfn-devopsagent-service-githubpatdetails-targeturl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetUrl { get; set; }
            /// <summary>
            /// TokenValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-githubpatdetails.html#cfn-devopsagent-service-githubpatdetails-tokenvalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenValue { get; set; }
        }

        public class GitLabDetails : Humidifier.Base.BaseSubResource, IHaveTokenType, IHaveTargetUrl, IHaveTokenValue, IHaveGroupId
        {
            /// <summary>
            /// TokenType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-gitlabdetails.html#cfn-devopsagent-service-gitlabdetails-tokentype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenType { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-gitlabdetails.html#cfn-devopsagent-service-gitlabdetails-targeturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetUrl { get; set; }
            /// <summary>
            /// TokenValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-gitlabdetails.html#cfn-devopsagent-service-gitlabdetails-tokenvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenValue { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-gitlabdetails.html#cfn-devopsagent-service-gitlabdetails-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class MCPServerAuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesApiKeyDetailsApiKey, IHaveDevOpsAgentServiceTypesMCPServerOAuthClientCredentialsConfigOAuthClientCredentials, IHaveDevOpsAgentServiceTypesBearerTokenDetailsBearerToken
        {
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverauthorizationconfig.html#cfn-devopsagent-service-mcpserverauthorizationconfig-apikey
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiKeyDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.ApiKeyDetails, BaseFunction>? ApiKey { get; set; }
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverauthorizationconfig.html#cfn-devopsagent-service-mcpserverauthorizationconfig-oauthclientcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerOAuthClientCredentialsConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerOAuthClientCredentialsConfig, BaseFunction>? OAuthClientCredentials { get; set; }
            /// <summary>
            /// BearerToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverauthorizationconfig.html#cfn-devopsagent-service-mcpserverauthorizationconfig-bearertoken
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BearerTokenDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails, BaseFunction>? BearerToken { get; set; }
        }

        public class MCPServerDetails : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveDevOpsAgentServiceTypesMCPServerAuthorizationConfigAuthorizationConfig, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverdetails.html#cfn-devopsagent-service-mcpserverdetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverdetails.html#cfn-devopsagent-service-mcpserverdetails-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverdetails.html#cfn-devopsagent-service-mcpserverdetails-authorizationconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MCPServerAuthorizationConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverdetails.html#cfn-devopsagent-service-mcpserverdetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MCPServerGrafanaAuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesBearerTokenDetailsBearerToken
        {
            /// <summary>
            /// BearerToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanaauthorizationconfig.html#cfn-devopsagent-service-mcpservergrafanaauthorizationconfig-bearertoken
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BearerTokenDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails, BaseFunction>? BearerToken { get; set; }
        }

        public class MCPServerGrafanaDetails : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveDevOpsAgentServiceTypesMCPServerGrafanaAuthorizationConfigAuthorizationConfig, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanadetails.html#cfn-devopsagent-service-mcpservergrafanadetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanadetails.html#cfn-devopsagent-service-mcpservergrafanadetails-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanadetails.html#cfn-devopsagent-service-mcpservergrafanadetails-authorizationconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MCPServerGrafanaAuthorizationConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanadetails.html#cfn-devopsagent-service-mcpservergrafanadetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MCPServerOAuthClientCredentialsConfig : Humidifier.Base.BaseSubResource, IHaveClientName, IHaveExchangeUrl, IHaveClientSecret, IHaveStringListOfScopes, IHaveClientId, IHaveExchangeParameters_Json
        {
            /// <summary>
            /// ClientName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-clientname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientName { get; set; }
            /// <summary>
            /// ExchangeUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-exchangeurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExchangeUrl { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Scopes { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ExchangeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-exchangeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ExchangeParameters { get; set; }
        }

        public class MCPServerSigV4AuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveMcpRoleArn, IHaveRegion, IHaveService, IHaveRoleArn, IHaveStringDictionaryOfCustomHeaders
        {
            /// <summary>
            /// McpRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-mcprolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? McpRoleArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-service
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Service { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// CustomHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-customheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomHeaders { get; set; }
        }

        public class MCPServerSigV4Details : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveDevOpsAgentServiceTypesMCPServerSigV4AuthorizationConfigAuthorizationConfig, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4details.html#cfn-devopsagent-service-mcpserversigv4details-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4details.html#cfn-devopsagent-service-mcpserversigv4details-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4details.html#cfn-devopsagent-service-mcpserversigv4details-authorizationconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MCPServerSigV4AuthorizationConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4details.html#cfn-devopsagent-service-mcpserversigv4details-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class MCPServerSplunkAuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesBearerTokenDetailsBearerToken
        {
            /// <summary>
            /// BearerToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkauthorizationconfig.html#cfn-devopsagent-service-mcpserversplunkauthorizationconfig-bearertoken
            /// Required: True
            /// UpdateType: Immutable
            /// Type: BearerTokenDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails, BaseFunction>? BearerToken { get; set; }
        }

        public class MCPServerSplunkDetails : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveDevOpsAgentServiceTypesMCPServerSplunkAuthorizationConfigAuthorizationConfig, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkdetails.html#cfn-devopsagent-service-mcpserversplunkdetails-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkdetails.html#cfn-devopsagent-service-mcpserversplunkdetails-endpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkdetails.html#cfn-devopsagent-service-mcpserversplunkdetails-authorizationconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MCPServerSplunkAuthorizationConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkdetails.html#cfn-devopsagent-service-mcpserversplunkdetails-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class NewRelicApiKeyConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfAlertPolicyIds, IHaveApiKey, IHaveAccountId, IHaveStringListOfApplicationIds, IHaveRegion, IHaveStringListOfEntityGuids
        {
            /// <summary>
            /// AlertPolicyIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-alertpolicyids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AlertPolicyIds { get; set; }
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKey { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// ApplicationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-applicationids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ApplicationIds { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// EntityGuids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-entityguids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntityGuids { get; set; }
        }

        public class NewRelicAuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesNewRelicApiKeyConfigApiKey
        {
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicauthorizationconfig.html#cfn-devopsagent-service-newrelicauthorizationconfig-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NewRelicApiKeyConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig, BaseFunction>? ApiKey { get; set; }
        }

        public class NewRelicServiceDetails : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesNewRelicAuthorizationConfigAuthorizationConfig
        {
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicservicedetails.html#cfn-devopsagent-service-newrelicservicedetails-authorizationconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NewRelicAuthorizationConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
        }

        public class OAuthClientDetails : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientName, IHaveExchangeParameters_Json, IHaveClientSecret
        {
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-oauthclientdetails.html#cfn-devopsagent-service-oauthclientdetails-clientid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// ClientName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-oauthclientdetails.html#cfn-devopsagent-service-oauthclientdetails-clientname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientName { get; set; }
            /// <summary>
            /// ExchangeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-oauthclientdetails.html#cfn-devopsagent-service-oauthclientdetails-exchangeparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ExchangeParameters { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-oauthclientdetails.html#cfn-devopsagent-service-oauthclientdetails-clientsecret
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientSecret { get; set; }
        }

        public class PagerDutyAuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesOAuthClientDetailsOAuthClientCredentials
        {
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-pagerdutyauthorizationconfig.html#cfn-devopsagent-service-pagerdutyauthorizationconfig-oauthclientcredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OAuthClientDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails, BaseFunction>? OAuthClientCredentials { get; set; }
        }

        public class PagerDutyDetails : Humidifier.Base.BaseSubResource, IHaveStringListOfScopes, IHaveDevOpsAgentServiceTypesPagerDutyAuthorizationConfigAuthorizationConfig
        {
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-pagerdutydetails.html#cfn-devopsagent-service-pagerdutydetails-scopes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Scopes { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-pagerdutydetails.html#cfn-devopsagent-service-pagerdutydetails-authorizationconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: PagerDutyAuthorizationConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
        }

        public class RegisteredAzureIdentityDetails : Humidifier.Base.BaseSubResource, IHaveWebIdentityRoleArn, IHaveTenantId, IHaveClientId, IHaveStringListOfWebIdentityTokenAudiences
        {
            /// <summary>
            /// WebIdentityRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredazureidentitydetails.html#cfn-devopsagent-service-registeredazureidentitydetails-webidentityrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WebIdentityRoleArn { get; set; }
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredazureidentitydetails.html#cfn-devopsagent-service-registeredazureidentitydetails-tenantid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredazureidentitydetails.html#cfn-devopsagent-service-registeredazureidentitydetails-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// WebIdentityTokenAudiences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredazureidentitydetails.html#cfn-devopsagent-service-registeredazureidentitydetails-webidentitytokenaudiences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WebIdentityTokenAudiences { get; set; }
        }

        public class RegisteredDynatraceDetails : Humidifier.Base.BaseSubResource, IHaveAccountUrn
        {
            /// <summary>
            /// AccountUrn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registereddynatracedetails.html#cfn-devopsagent-service-registereddynatracedetails-accounturn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountUrn { get; set; }
        }

        public class RegisteredGitHubServiceDetails : Humidifier.Base.BaseSubResource, IHaveOwner, IHaveOwnerType, IHaveHostingType, IHaveTargetUrl, IHaveAppVariant, IHaveAuthMode
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgithubservicedetails.html#cfn-devopsagent-service-registeredgithubservicedetails-owner
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Owner { get; set; }
            /// <summary>
            /// OwnerType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgithubservicedetails.html#cfn-devopsagent-service-registeredgithubservicedetails-ownertype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OwnerType { get; set; }
            /// <summary>
            /// HostingType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgithubservicedetails.html#cfn-devopsagent-service-registeredgithubservicedetails-hostingtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostingType { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgithubservicedetails.html#cfn-devopsagent-service-registeredgithubservicedetails-targeturl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetUrl { get; set; }
            /// <summary>
            /// AppVariant
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgithubservicedetails.html#cfn-devopsagent-service-registeredgithubservicedetails-appvariant
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppVariant { get; set; }
            /// <summary>
            /// AuthMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgithubservicedetails.html#cfn-devopsagent-service-registeredgithubservicedetails-authmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthMode { get; set; }
        }

        public class RegisteredGitLabServiceDetails : Humidifier.Base.BaseSubResource, IHaveTokenType, IHaveTargetUrl, IHaveGroupId
        {
            /// <summary>
            /// TokenType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgitlabservicedetails.html#cfn-devopsagent-service-registeredgitlabservicedetails-tokentype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TokenType { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgitlabservicedetails.html#cfn-devopsagent-service-registeredgitlabservicedetails-targeturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetUrl { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgitlabservicedetails.html#cfn-devopsagent-service-registeredgitlabservicedetails-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GroupId { get; set; }
        }

        public class RegisteredMCPServerDetails : Humidifier.Base.BaseSubResource, IHaveAuthorizationMethod, IHaveDescription, IHaveEndpoint, IHaveApiKeyHeader, IHaveName
        {
            /// <summary>
            /// AuthorizationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-authorizationmethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationMethod { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// ApiKeyHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-apikeyheader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyHeader { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RegisteredMCPServerGrafanaDetails : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveAuthorizationMethod, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpservergrafanadetails.html#cfn-devopsagent-service-registeredmcpservergrafanadetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpservergrafanadetails.html#cfn-devopsagent-service-registeredmcpservergrafanadetails-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// AuthorizationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpservergrafanadetails.html#cfn-devopsagent-service-registeredmcpservergrafanadetails-authorizationmethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationMethod { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpservergrafanadetails.html#cfn-devopsagent-service-registeredmcpservergrafanadetails-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RegisteredMCPServerSigV4Details : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveEndpoint, IHaveMcpRoleArn, IHaveRegion, IHaveService, IHaveRoleArn, IHaveStringDictionaryOfCustomHeaders, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// McpRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-mcprolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? McpRoleArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-service
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Service { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
            /// <summary>
            /// CustomHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-customheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? CustomHeaders { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RegisteredNewRelicDetails : Humidifier.Base.BaseSubResource, IHaveAccountId, IHaveDescription, IHaveRegion
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registerednewrelicdetails.html#cfn-devopsagent-service-registerednewrelicdetails-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccountId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registerednewrelicdetails.html#cfn-devopsagent-service-registerednewrelicdetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registerednewrelicdetails.html#cfn-devopsagent-service-registerednewrelicdetails-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class RegisteredPagerDutyDetails : Humidifier.Base.BaseSubResource, IHaveStringListOfScopes
        {
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredpagerdutydetails.html#cfn-devopsagent-service-registeredpagerdutydetails-scopes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Scopes { get; set; }
        }

        public class RegisteredServiceNowDetails : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredservicenowdetails.html#cfn-devopsagent-service-registeredservicenowdetails-instanceurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
        }

        public class ServiceDetails : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesMCPServerDetailsMCPServer, IHaveDevOpsAgentServiceTypesServiceNowServiceDetailsServiceNow, IHaveDevOpsAgentServiceTypesGitHubDetailsGitHub, IHaveDevOpsAgentServiceTypesAzureIdentityServiceDetailsAzureIdentity, IHaveDevOpsAgentServiceTypesMCPServerGrafanaDetailsMCPServerGrafana, IHaveDevOpsAgentServiceTypesDynatraceServiceDetailsDynatrace, IHaveDevOpsAgentServiceTypesMCPServerSigV4DetailsMCPServerSigV4, IHaveDevOpsAgentServiceTypesMCPServerSplunkDetailsMCPServerSplunk, IHaveDevOpsAgentServiceTypesNewRelicServiceDetailsMCPServerNewRelic, IHaveDevOpsAgentServiceTypesGitLabDetailsGitLab, IHaveDevOpsAgentServiceTypesPagerDutyDetailsPagerDuty
        {
            /// <summary>
            /// MCPServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerDetails, BaseFunction>? MCPServer { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-servicenow
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServiceNowServiceDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowServiceDetails, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// GitHub
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-github
            /// Required: False
            /// UpdateType: Immutable
            /// Type: GitHubDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.GitHubDetails, BaseFunction>? GitHub { get; set; }
            /// <summary>
            /// AzureIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-azureidentity
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AzureIdentityServiceDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.AzureIdentityServiceDetails, BaseFunction>? AzureIdentity { get; set; }
            /// <summary>
            /// MCPServerGrafana
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpservergrafana
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerGrafanaDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaDetails, BaseFunction>? MCPServerGrafana { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-dynatrace
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DynatraceServiceDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.DynatraceServiceDetails, BaseFunction>? Dynatrace { get; set; }
            /// <summary>
            /// MCPServerSigV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpserversigv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerSigV4Details
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4Details, BaseFunction>? MCPServerSigV4 { get; set; }
            /// <summary>
            /// MCPServerSplunk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpserversplunk
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MCPServerSplunkDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkDetails, BaseFunction>? MCPServerSplunk { get; set; }
            /// <summary>
            /// MCPServerNewRelic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpservernewrelic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NewRelicServiceDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.NewRelicServiceDetails, BaseFunction>? MCPServerNewRelic { get; set; }
            /// <summary>
            /// GitLab
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-gitlab
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitLabDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.GitLabDetails, BaseFunction>? GitLab { get; set; }
            /// <summary>
            /// PagerDuty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-pagerduty
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PagerDutyDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.PagerDutyDetails, BaseFunction>? PagerDuty { get; set; }
        }

        public class ServiceNowAuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveDevOpsAgentServiceTypesOAuthClientDetailsOAuthClientCredentials
        {
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicenowauthorizationconfig.html#cfn-devopsagent-service-servicenowauthorizationconfig-oauthclientcredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OAuthClientDetails
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails, BaseFunction>? OAuthClientCredentials { get; set; }
        }

        public class ServiceNowServiceDetails : Humidifier.Base.BaseSubResource, IHaveInstanceUrl, IHaveDevOpsAgentServiceTypesServiceNowAuthorizationConfigAuthorizationConfig
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicenowservicedetails.html#cfn-devopsagent-service-servicenowservicedetails-instanceurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceUrl { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicenowservicedetails.html#cfn-devopsagent-service-servicenowservicedetails-authorizationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServiceNowAuthorizationConfig
            /// </summary>
            public Union<Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig, BaseFunction>? AuthorizationConfig { get; set; }
        }
    }
}