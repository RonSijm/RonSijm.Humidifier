namespace Humidifier.AppSync
{
    using System.Collections.Generic;
    using GraphQLApiTypes;

    public class GraphQLApi : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveVisibility, IHaveAuthenticationType, IHaveOwnerContact, IHaveAppSyncGraphQLApiTypesOpenIDConnectConfigOpenIDConnectConfig, IHaveAppSyncGraphQLApiTypesLambdaAuthorizerConfigLambdaAuthorizerConfig
    {
        public class Attributes
        {
            public static string RealtimeUrl =  "RealtimeUrl" ;
            public static string GraphQLUrl =  "GraphQLUrl" ;
            public static string GraphQLDns =  "GraphQLDns" ;
            public static string RealtimeDns =  "RealtimeDns" ;
            public static string Arn =  "Arn" ;
            public static string ApiId =  "ApiId" ;
            public static string GraphQLEndpointArn =  "GraphQLEndpointArn" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.GraphQLApi; }
        /// <summary>
        /// QueryDepthLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-querydepthlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic QueryDepthLimit { get; set; }
        /// <summary>
        /// OpenIDConnectConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-openidconnectconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OpenIDConnectConfig
        /// </summary>
        public Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig OpenIDConnectConfig { get; set; }
        /// <summary>
        /// IntrospectionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-introspectionconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IntrospectionConfig { get; set; }
        /// <summary>
        /// MergedApiExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-mergedapiexecutionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MergedApiExecutionRoleArn { get; set; }
        /// <summary>
        /// EnhancedMetricsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-enhancedmetricsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EnhancedMetricsConfig
        /// </summary>
        public Humidifier.AppSync.GraphQLApiTypes.EnhancedMetricsConfig EnhancedMetricsConfig { get; set; }
        /// <summary>
        /// OwnerContact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-ownercontact
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OwnerContact { get; set; }
        /// <summary>
        /// ResolverCountLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-resolvercountlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ResolverCountLimit { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AdditionalAuthenticationProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-additionalauthenticationproviders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdditionalAuthenticationProvider
        /// </summary>
        public List<Humidifier.AppSync.GraphQLApiTypes.AdditionalAuthenticationProvider> AdditionalAuthenticationProviders { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic EnvironmentVariables { get; set; }
        /// <summary>
        /// ApiType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-apitype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApiType { get; set; }
        /// <summary>
        /// LambdaAuthorizerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LambdaAuthorizerConfig
        /// </summary>
        public Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig LambdaAuthorizerConfig { get; set; }
        /// <summary>
        /// XrayEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-xrayenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic XrayEnabled { get; set; }
        /// <summary>
        /// Visibility
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-visibility
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Visibility { get; set; }
        /// <summary>
        /// UserPoolConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-userpoolconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserPoolConfig
        /// </summary>
        public Humidifier.AppSync.GraphQLApiTypes.UserPoolConfig UserPoolConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// AuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-authenticationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AuthenticationType { get; set; }
        /// <summary>
        /// LogConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-logconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfig
        /// </summary>
        public Humidifier.AppSync.GraphQLApiTypes.LogConfig LogConfig { get; set; }
    }

    namespace GraphQLApiTypes
    {
        public class AdditionalAuthenticationProvider : Humidifier.Base.BaseSubResource, IHaveAuthenticationType, IHaveAppSyncGraphQLApiTypesOpenIDConnectConfigOpenIDConnectConfig, IHaveAppSyncGraphQLApiTypesLambdaAuthorizerConfigLambdaAuthorizerConfig
        {
            /// <summary>
            /// OpenIDConnectConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html#cfn-appsync-graphqlapi-additionalauthenticationprovider-openidconnectconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIDConnectConfig
            /// </summary>
            public Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig OpenIDConnectConfig { get; set; }
            /// <summary>
            /// LambdaAuthorizerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html#cfn-appsync-graphqlapi-additionalauthenticationprovider-lambdaauthorizerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaAuthorizerConfig
            /// </summary>
            public Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig LambdaAuthorizerConfig { get; set; }
            /// <summary>
            /// UserPoolConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html#cfn-appsync-graphqlapi-additionalauthenticationprovider-userpoolconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoUserPoolConfig
            /// </summary>
            public Humidifier.AppSync.GraphQLApiTypes.CognitoUserPoolConfig UserPoolConfig { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html#cfn-appsync-graphqlapi-additionalauthenticationprovider-authenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthenticationType { get; set; }
        }

        public class CognitoUserPoolConfig : Humidifier.Base.BaseSubResource, IHaveUserPoolId, IHaveAwsRegion, IHaveAppIdClientRegex
        {
            /// <summary>
            /// AppIdClientRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-cognitouserpoolconfig.html#cfn-appsync-graphqlapi-cognitouserpoolconfig-appidclientregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppIdClientRegex { get; set; }
            /// <summary>
            /// UserPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-cognitouserpoolconfig.html#cfn-appsync-graphqlapi-cognitouserpoolconfig-userpoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserPoolId { get; set; }
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-cognitouserpoolconfig.html#cfn-appsync-graphqlapi-cognitouserpoolconfig-awsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsRegion { get; set; }
        }

        public class EnhancedMetricsConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// OperationLevelMetricsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-enhancedmetricsconfig.html#cfn-appsync-graphqlapi-enhancedmetricsconfig-operationlevelmetricsconfig
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OperationLevelMetricsConfig { get; set; }
            /// <summary>
            /// ResolverLevelMetricsBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-enhancedmetricsconfig.html#cfn-appsync-graphqlapi-enhancedmetricsconfig-resolverlevelmetricsbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResolverLevelMetricsBehavior { get; set; }
            /// <summary>
            /// DataSourceLevelMetricsBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-enhancedmetricsconfig.html#cfn-appsync-graphqlapi-enhancedmetricsconfig-datasourcelevelmetricsbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataSourceLevelMetricsBehavior { get; set; }
        }

        public class LambdaAuthorizerConfig : Humidifier.Base.BaseSubResource, IHaveIdentityValidationExpression, IHaveAuthorizerUri, IHaveAuthorizerResultTtlInSeconds
        {
            /// <summary>
            /// IdentityValidationExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-identityvalidationexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdentityValidationExpression { get; set; }
            /// <summary>
            /// AuthorizerUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-authorizeruri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizerUri { get; set; }
            /// <summary>
            /// AuthorizerResultTtlInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-authorizerresultttlinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic AuthorizerResultTtlInSeconds { get; set; }
        }

        public class LogConfig : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogsRoleArn
        {
            /// <summary>
            /// CloudWatchLogsRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-cloudwatchlogsrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudWatchLogsRoleArn { get; set; }
            /// <summary>
            /// ExcludeVerboseContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-excludeverbosecontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ExcludeVerboseContent { get; set; }
            /// <summary>
            /// FieldLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-fieldloglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FieldLogLevel { get; set; }
        }

        public class OpenIDConnectConfig : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveIssuer, IHaveAuthTTL, IHaveIatTTL
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html#cfn-appsync-graphqlapi-openidconnectconfig-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html#cfn-appsync-graphqlapi-openidconnectconfig-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// AuthTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html#cfn-appsync-graphqlapi-openidconnectconfig-authttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic AuthTTL { get; set; }
            /// <summary>
            /// IatTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html#cfn-appsync-graphqlapi-openidconnectconfig-iatttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IatTTL { get; set; }
        }

        public class UserPoolConfig : Humidifier.Base.BaseSubResource, IHaveUserPoolId, IHaveAwsRegion, IHaveAppIdClientRegex, IHaveDefaultAction
        {
            /// <summary>
            /// AppIdClientRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-appidclientregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppIdClientRegex { get; set; }
            /// <summary>
            /// UserPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-userpoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserPoolId { get; set; }
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-awsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsRegion { get; set; }
            /// <summary>
            /// DefaultAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-defaultaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultAction { get; set; }
        }
    }
}