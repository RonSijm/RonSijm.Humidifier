namespace Humidifier.DevOpsAgent
{
    using global::System.Collections.Generic;
    using ServiceTypes;

    public class Service : Humidifier.Base.BaseResource, IHaveTags, IHaveKmsKeyArn, IHaveServiceType
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
        public dynamic PrivateConnectionName { get; set; }
        /// <summary>
        /// ServiceDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-servicedetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServiceDetails
        /// </summary>
        public Humidifier.DevOpsAgent.ServiceTypes.ServiceDetails ServiceDetails { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyArn { get; set; }

        /// <summary>
        /// ServiceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-servicetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ServiceType { get; set; }
        /// <summary>
        /// ExchangeUrlPrivateConnectionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-exchangeurlprivateconnectionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExchangeUrlPrivateConnectionName { get; set; }
        /// <summary>
        /// TargetUrlPrivateConnectionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-targeturlprivateconnectionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetUrlPrivateConnectionName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-service.html#cfn-devopsagent-service-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ServiceTypes
    {
        public class AdditionalServiceDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MCPServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredMCPServerDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredMCPServerDetails MCPServer { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredServiceNowDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredServiceNowDetails ServiceNow { get; set; }
            /// <summary>
            /// AzureIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-azureidentity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredAzureIdentityDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredAzureIdentityDetails AzureIdentity { get; set; }
            /// <summary>
            /// MCPServerGrafana
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpservergrafana
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredMCPServerGrafanaDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredMCPServerGrafanaDetails MCPServerGrafana { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-dynatrace
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredDynatraceDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredDynatraceDetails Dynatrace { get; set; }
            /// <summary>
            /// MCPServerSigV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpserversigv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredMCPServerSigV4Details
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredMCPServerSigV4Details MCPServerSigV4 { get; set; }
            /// <summary>
            /// MCPServerSplunk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpserversplunk
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredMCPServerDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredMCPServerDetails MCPServerSplunk { get; set; }
            /// <summary>
            /// MCPServerNewRelic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-mcpservernewrelic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredNewRelicDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredNewRelicDetails MCPServerNewRelic { get; set; }
            /// <summary>
            /// GitLab
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-gitlab
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredGitLabServiceDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredGitLabServiceDetails GitLab { get; set; }
            /// <summary>
            /// PagerDuty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-additionalservicedetails.html#cfn-devopsagent-service-additionalservicedetails-pagerduty
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RegisteredPagerDutyDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.RegisteredPagerDutyDetails PagerDuty { get; set; }
        }

        public class ApiKeyDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiKeyHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-apikeydetails.html#cfn-devopsagent-service-apikeydetails-apikeyheader
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyHeader { get; set; }
            /// <summary>
            /// ApiKeyValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-apikeydetails.html#cfn-devopsagent-service-apikeydetails-apikeyvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyValue { get; set; }
            /// <summary>
            /// ApiKeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-apikeydetails.html#cfn-devopsagent-service-apikeydetails-apikeyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyName { get; set; }
        }

        public class AzureIdentityServiceDetails : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveTenantId
        {
            /// <summary>
            /// WebIdentityRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-azureidentityservicedetails.html#cfn-devopsagent-service-azureidentityservicedetails-webidentityrolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebIdentityRoleArn { get; set; }
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-azureidentityservicedetails.html#cfn-devopsagent-service-azureidentityservicedetails-tenantid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-azureidentityservicedetails.html#cfn-devopsagent-service-azureidentityservicedetails-clientid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// WebIdentityTokenAudiences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-azureidentityservicedetails.html#cfn-devopsagent-service-azureidentityservicedetails-webidentitytokenaudiences
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic WebIdentityTokenAudiences { get; set; }
        }

        public class BearerTokenDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TokenName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-bearertokendetails.html#cfn-devopsagent-service-bearertokendetails-tokenname
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenName { get; set; }
            /// <summary>
            /// AuthorizationHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-bearertokendetails.html#cfn-devopsagent-service-bearertokendetails-authorizationheader
            /// Required: False
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationHeader { get; set; }
            /// <summary>
            /// TokenValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-bearertokendetails.html#cfn-devopsagent-service-bearertokendetails-tokenvalue
            /// Required: True
            /// UpdateType: Conditional
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenValue { get; set; }
        }

        public class DynatraceAuthorizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-dynatraceauthorizationconfig.html#cfn-devopsagent-service-dynatraceauthorizationconfig-oauthclientcredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OAuthClientDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails OAuthClientCredentials { get; set; }
        }

        public class DynatraceServiceDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-dynatraceservicedetails.html#cfn-devopsagent-service-dynatraceservicedetails-authorizationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DynatraceAuthorizationConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.DynatraceAuthorizationConfig AuthorizationConfig { get; set; }
            /// <summary>
            /// AccountUrn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-dynatraceservicedetails.html#cfn-devopsagent-service-dynatraceservicedetails-accounturn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountUrn { get; set; }
        }

        public class GitLabDetails : Humidifier.Base.BaseSubResource, IHaveGroupId
        {
            /// <summary>
            /// TokenType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-gitlabdetails.html#cfn-devopsagent-service-gitlabdetails-tokentype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenType { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-gitlabdetails.html#cfn-devopsagent-service-gitlabdetails-targeturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetUrl { get; set; }
            /// <summary>
            /// TokenValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-gitlabdetails.html#cfn-devopsagent-service-gitlabdetails-tokenvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenValue { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-gitlabdetails.html#cfn-devopsagent-service-gitlabdetails-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupId { get; set; }
        }

        public class MCPServerAuthorizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverauthorizationconfig.html#cfn-devopsagent-service-mcpserverauthorizationconfig-apikey
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApiKeyDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.ApiKeyDetails ApiKey { get; set; }
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverauthorizationconfig.html#cfn-devopsagent-service-mcpserverauthorizationconfig-oauthclientcredentials
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerOAuthClientCredentialsConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerOAuthClientCredentialsConfig OAuthClientCredentials { get; set; }
            /// <summary>
            /// BearerToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverauthorizationconfig.html#cfn-devopsagent-service-mcpserverauthorizationconfig-bearertoken
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BearerTokenDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails BearerToken { get; set; }
        }

        public class MCPServerDetails : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveEndpoint
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverdetails.html#cfn-devopsagent-service-mcpserverdetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverdetails.html#cfn-devopsagent-service-mcpserverdetails-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverdetails.html#cfn-devopsagent-service-mcpserverdetails-authorizationconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MCPServerAuthorizationConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerAuthorizationConfig AuthorizationConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserverdetails.html#cfn-devopsagent-service-mcpserverdetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MCPServerGrafanaAuthorizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BearerToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanaauthorizationconfig.html#cfn-devopsagent-service-mcpservergrafanaauthorizationconfig-bearertoken
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BearerTokenDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails BearerToken { get; set; }
        }

        public class MCPServerGrafanaDetails : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveEndpoint
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanadetails.html#cfn-devopsagent-service-mcpservergrafanadetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanadetails.html#cfn-devopsagent-service-mcpservergrafanadetails-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanadetails.html#cfn-devopsagent-service-mcpservergrafanadetails-authorizationconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MCPServerGrafanaAuthorizationConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaAuthorizationConfig AuthorizationConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpservergrafanadetails.html#cfn-devopsagent-service-mcpservergrafanadetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MCPServerOAuthClientCredentialsConfig : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-clientname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientName { get; set; }
            /// <summary>
            /// ExchangeUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-exchangeurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExchangeUrl { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-clientsecret
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-scopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Scopes { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ExchangeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserveroauthclientcredentialsconfig.html#cfn-devopsagent-service-mcpserveroauthclientcredentialsconfig-exchangeparameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ExchangeParameters { get; set; }
        }

        public class MCPServerSigV4AuthorizationConfig : Humidifier.Base.BaseSubResource, IHaveRoleArn, IHaveRegion, IHaveService
        {
            /// <summary>
            /// McpRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-mcprolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic McpRoleArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-service
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Service { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
            /// <summary>
            /// CustomHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4authorizationconfig.html#cfn-devopsagent-service-mcpserversigv4authorizationconfig-customheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomHeaders { get; set; }
        }

        public class MCPServerSigV4Details : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveEndpoint
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4details.html#cfn-devopsagent-service-mcpserversigv4details-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4details.html#cfn-devopsagent-service-mcpserversigv4details-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4details.html#cfn-devopsagent-service-mcpserversigv4details-authorizationconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: MCPServerSigV4AuthorizationConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4AuthorizationConfig AuthorizationConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversigv4details.html#cfn-devopsagent-service-mcpserversigv4details-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class MCPServerSplunkAuthorizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BearerToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkauthorizationconfig.html#cfn-devopsagent-service-mcpserversplunkauthorizationconfig-bearertoken
            /// Required: True
            /// UpdateType: Immutable
            /// Type: BearerTokenDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.BearerTokenDetails BearerToken { get; set; }
        }

        public class MCPServerSplunkDetails : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveEndpoint
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkdetails.html#cfn-devopsagent-service-mcpserversplunkdetails-description
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkdetails.html#cfn-devopsagent-service-mcpserversplunkdetails-endpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkdetails.html#cfn-devopsagent-service-mcpserversplunkdetails-authorizationconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MCPServerSplunkAuthorizationConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkAuthorizationConfig AuthorizationConfig { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-mcpserversplunkdetails.html#cfn-devopsagent-service-mcpserversplunkdetails-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class NewRelicApiKeyConfig : Humidifier.Base.BaseSubResource, IHaveRegion, IHaveAccountId, IHaveApiKey
        {
            /// <summary>
            /// AlertPolicyIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-alertpolicyids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AlertPolicyIds { get; set; }
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKey { get; set; }
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountId { get; set; }
            /// <summary>
            /// ApplicationIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-applicationids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ApplicationIds { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// EntityGuids
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicapikeyconfig.html#cfn-devopsagent-service-newrelicapikeyconfig-entityguids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EntityGuids { get; set; }
        }

        public class NewRelicAuthorizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicauthorizationconfig.html#cfn-devopsagent-service-newrelicauthorizationconfig-apikey
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NewRelicApiKeyConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.NewRelicApiKeyConfig ApiKey { get; set; }
        }

        public class NewRelicServiceDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-newrelicservicedetails.html#cfn-devopsagent-service-newrelicservicedetails-authorizationconfig
            /// Required: True
            /// UpdateType: Mutable
            /// Type: NewRelicAuthorizationConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.NewRelicAuthorizationConfig AuthorizationConfig { get; set; }
        }

        public class OAuthClientDetails : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveClientSecret
        {
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-oauthclientdetails.html#cfn-devopsagent-service-oauthclientdetails-clientid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// ClientName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-oauthclientdetails.html#cfn-devopsagent-service-oauthclientdetails-clientname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientName { get; set; }
            /// <summary>
            /// ExchangeParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-oauthclientdetails.html#cfn-devopsagent-service-oauthclientdetails-exchangeparameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic ExchangeParameters { get; set; }
            /// <summary>
            /// ClientSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-oauthclientdetails.html#cfn-devopsagent-service-oauthclientdetails-clientsecret
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientSecret { get; set; }
        }

        public class PagerDutyAuthorizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-pagerdutyauthorizationconfig.html#cfn-devopsagent-service-pagerdutyauthorizationconfig-oauthclientcredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OAuthClientDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails OAuthClientCredentials { get; set; }
        }

        public class PagerDutyDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-pagerdutydetails.html#cfn-devopsagent-service-pagerdutydetails-scopes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Scopes { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-pagerdutydetails.html#cfn-devopsagent-service-pagerdutydetails-authorizationconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: PagerDutyAuthorizationConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.PagerDutyAuthorizationConfig AuthorizationConfig { get; set; }
        }

        public class RegisteredAzureIdentityDetails : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveTenantId
        {
            /// <summary>
            /// WebIdentityRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredazureidentitydetails.html#cfn-devopsagent-service-registeredazureidentitydetails-webidentityrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebIdentityRoleArn { get; set; }
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredazureidentitydetails.html#cfn-devopsagent-service-registeredazureidentitydetails-tenantid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredazureidentitydetails.html#cfn-devopsagent-service-registeredazureidentitydetails-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// WebIdentityTokenAudiences
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredazureidentitydetails.html#cfn-devopsagent-service-registeredazureidentitydetails-webidentitytokenaudiences
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic WebIdentityTokenAudiences { get; set; }
        }

        public class RegisteredDynatraceDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AccountUrn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registereddynatracedetails.html#cfn-devopsagent-service-registereddynatracedetails-accounturn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountUrn { get; set; }
        }

        public class RegisteredGitLabServiceDetails : Humidifier.Base.BaseSubResource, IHaveGroupId
        {
            /// <summary>
            /// TokenType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgitlabservicedetails.html#cfn-devopsagent-service-registeredgitlabservicedetails-tokentype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TokenType { get; set; }
            /// <summary>
            /// TargetUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgitlabservicedetails.html#cfn-devopsagent-service-registeredgitlabservicedetails-targeturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetUrl { get; set; }
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredgitlabservicedetails.html#cfn-devopsagent-service-registeredgitlabservicedetails-groupid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupId { get; set; }
        }

        public class RegisteredMCPServerDetails : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveEndpoint
        {
            /// <summary>
            /// AuthorizationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-authorizationmethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationMethod { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// ApiKeyHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-apikeyheader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyHeader { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserverdetails.html#cfn-devopsagent-service-registeredmcpserverdetails-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RegisteredMCPServerGrafanaDetails : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveEndpoint
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpservergrafanadetails.html#cfn-devopsagent-service-registeredmcpservergrafanadetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpservergrafanadetails.html#cfn-devopsagent-service-registeredmcpservergrafanadetails-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// AuthorizationMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpservergrafanadetails.html#cfn-devopsagent-service-registeredmcpservergrafanadetails-authorizationmethod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationMethod { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpservergrafanadetails.html#cfn-devopsagent-service-registeredmcpservergrafanadetails-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RegisteredMCPServerSigV4Details : Humidifier.Base.BaseSubResource, IHaveName, IHaveDescription, IHaveRoleArn, IHaveRegion, IHaveEndpoint, IHaveService
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-endpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// McpRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-mcprolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic McpRoleArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
            /// <summary>
            /// Service
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-service
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Service { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
            /// <summary>
            /// CustomHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-customheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> CustomHeaders { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredmcpserversigv4details.html#cfn-devopsagent-service-registeredmcpserversigv4details-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class RegisteredNewRelicDetails : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveRegion, IHaveAccountId
        {
            /// <summary>
            /// AccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registerednewrelicdetails.html#cfn-devopsagent-service-registerednewrelicdetails-accountid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountId { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registerednewrelicdetails.html#cfn-devopsagent-service-registerednewrelicdetails-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registerednewrelicdetails.html#cfn-devopsagent-service-registerednewrelicdetails-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region { get; set; }
        }

        public class RegisteredPagerDutyDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Scopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-registeredpagerdutydetails.html#cfn-devopsagent-service-registeredpagerdutydetails-scopes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Scopes { get; set; }
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
            public dynamic InstanceUrl { get; set; }
        }

        public class ServiceDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MCPServer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpserver
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerDetails MCPServer { get; set; }
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-servicenow
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServiceNowServiceDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.ServiceNowServiceDetails ServiceNow { get; set; }
            /// <summary>
            /// AzureIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-azureidentity
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AzureIdentityServiceDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.AzureIdentityServiceDetails AzureIdentity { get; set; }
            /// <summary>
            /// MCPServerGrafana
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpservergrafana
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerGrafanaDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerGrafanaDetails MCPServerGrafana { get; set; }
            /// <summary>
            /// Dynatrace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-dynatrace
            /// Required: False
            /// UpdateType: Immutable
            /// Type: DynatraceServiceDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.DynatraceServiceDetails Dynatrace { get; set; }
            /// <summary>
            /// MCPServerSigV4
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpserversigv4
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MCPServerSigV4Details
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerSigV4Details MCPServerSigV4 { get; set; }
            /// <summary>
            /// MCPServerSplunk
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpserversplunk
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MCPServerSplunkDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.MCPServerSplunkDetails MCPServerSplunk { get; set; }
            /// <summary>
            /// MCPServerNewRelic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-mcpservernewrelic
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NewRelicServiceDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.NewRelicServiceDetails MCPServerNewRelic { get; set; }
            /// <summary>
            /// GitLab
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-gitlab
            /// Required: False
            /// UpdateType: Mutable
            /// Type: GitLabDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.GitLabDetails GitLab { get; set; }
            /// <summary>
            /// PagerDuty
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicedetails.html#cfn-devopsagent-service-servicedetails-pagerduty
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PagerDutyDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.PagerDutyDetails PagerDuty { get; set; }
        }

        public class ServiceNowAuthorizationConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OAuthClientCredentials
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicenowauthorizationconfig.html#cfn-devopsagent-service-servicenowauthorizationconfig-oauthclientcredentials
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OAuthClientDetails
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.OAuthClientDetails OAuthClientCredentials { get; set; }
        }

        public class ServiceNowServiceDetails : Humidifier.Base.BaseSubResource, IHaveInstanceUrl
        {
            /// <summary>
            /// InstanceUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicenowservicedetails.html#cfn-devopsagent-service-servicenowservicedetails-instanceurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceUrl { get; set; }
            /// <summary>
            /// AuthorizationConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-service-servicenowservicedetails.html#cfn-devopsagent-service-servicenowservicedetails-authorizationconfig
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ServiceNowAuthorizationConfig
            /// </summary>
            public Humidifier.DevOpsAgent.ServiceTypes.ServiceNowAuthorizationConfig AuthorizationConfig { get; set; }
        }
    }
}