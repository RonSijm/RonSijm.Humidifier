namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;
    using GraphQLApiTypes;

    public class GraphQLApi : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveQueryDepthLimit_Integer, IHaveAppSyncGraphQLApiTypesOpenIDConnectConfigOpenIDConnectConfig, IHaveIntrospectionConfig, IHaveMergedApiExecutionRoleArn, IHaveAppSyncGraphQLApiTypesEnhancedMetricsConfigEnhancedMetricsConfig, IHaveOwnerContact, IHaveResolverCountLimit_Integer, IHaveName, IHaveListOfAppSyncGraphQLApiTypesAdditionalAuthenticationProviderAdditionalAuthenticationProviders, IHaveEnvironmentVariables_Json, IHaveApiType, IHaveAppSyncGraphQLApiTypesLambdaAuthorizerConfigLambdaAuthorizerConfig, IHaveXrayEnabled_Boolean, IHaveVisibility, IHaveAppSyncGraphQLApiTypesUserPoolConfigUserPoolConfig, IHaveAuthenticationType, IHaveAppSyncGraphQLApiTypesLogConfigLogConfig
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
        public Union<int, BaseFunction>? QueryDepthLimit { get; set; }
        /// <summary>
        /// OpenIDConnectConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-openidconnectconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OpenIDConnectConfig
        /// </summary>
        public Union<Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig, BaseFunction>? OpenIDConnectConfig { get; set; }
        /// <summary>
        /// IntrospectionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-introspectionconfig
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IntrospectionConfig { get; set; }
        /// <summary>
        /// MergedApiExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-mergedapiexecutionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MergedApiExecutionRoleArn { get; set; }
        /// <summary>
        /// EnhancedMetricsConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-enhancedmetricsconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EnhancedMetricsConfig
        /// </summary>
        public Union<Humidifier.AppSync.GraphQLApiTypes.EnhancedMetricsConfig, BaseFunction>? EnhancedMetricsConfig { get; set; }
        /// <summary>
        /// OwnerContact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-ownercontact
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? OwnerContact { get; set; }
        /// <summary>
        /// ResolverCountLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-resolvercountlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? ResolverCountLimit { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// AdditionalAuthenticationProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-additionalauthenticationproviders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AdditionalAuthenticationProvider
        /// </summary>
        public Union<IReadOnlyList<Humidifier.AppSync.GraphQLApiTypes.AdditionalAuthenticationProvider>, IReadOnlyList<Union<Humidifier.AppSync.GraphQLApiTypes.AdditionalAuthenticationProvider, BaseFunction>>, BaseFunction>? AdditionalAuthenticationProviders { get; set; }
        /// <summary>
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? EnvironmentVariables { get; set; }
        /// <summary>
        /// ApiType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-apitype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApiType { get; set; }
        /// <summary>
        /// LambdaAuthorizerConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LambdaAuthorizerConfig
        /// </summary>
        public Union<Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig, BaseFunction>? LambdaAuthorizerConfig { get; set; }
        /// <summary>
        /// XrayEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-xrayenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? XrayEnabled { get; set; }
        /// <summary>
        /// Visibility
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-visibility
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Visibility { get; set; }
        /// <summary>
        /// UserPoolConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-userpoolconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: UserPoolConfig
        /// </summary>
        public Union<Humidifier.AppSync.GraphQLApiTypes.UserPoolConfig, BaseFunction>? UserPoolConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// AuthenticationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-authenticationtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AuthenticationType { get; set; }
        /// <summary>
        /// LogConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-graphqlapi.html#cfn-appsync-graphqlapi-logconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LogConfig
        /// </summary>
        public Union<Humidifier.AppSync.GraphQLApiTypes.LogConfig, BaseFunction>? LogConfig { get; set; }
    }

    namespace GraphQLApiTypes
    {
        public class AdditionalAuthenticationProvider : Humidifier.Base.BaseSubResource, IHaveAppSyncGraphQLApiTypesOpenIDConnectConfigOpenIDConnectConfig, IHaveAppSyncGraphQLApiTypesLambdaAuthorizerConfigLambdaAuthorizerConfig, IHaveAppSyncGraphQLApiTypesCognitoUserPoolConfigUserPoolConfig, IHaveAuthenticationType
        {
            /// <summary>
            /// OpenIDConnectConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html#cfn-appsync-graphqlapi-additionalauthenticationprovider-openidconnectconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIDConnectConfig
            /// </summary>
            public Union<Humidifier.AppSync.GraphQLApiTypes.OpenIDConnectConfig, BaseFunction>? OpenIDConnectConfig { get; set; }
            /// <summary>
            /// LambdaAuthorizerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html#cfn-appsync-graphqlapi-additionalauthenticationprovider-lambdaauthorizerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaAuthorizerConfig
            /// </summary>
            public Union<Humidifier.AppSync.GraphQLApiTypes.LambdaAuthorizerConfig, BaseFunction>? LambdaAuthorizerConfig { get; set; }
            /// <summary>
            /// UserPoolConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html#cfn-appsync-graphqlapi-additionalauthenticationprovider-userpoolconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoUserPoolConfig
            /// </summary>
            public Union<Humidifier.AppSync.GraphQLApiTypes.CognitoUserPoolConfig, BaseFunction>? UserPoolConfig { get; set; }
            /// <summary>
            /// AuthenticationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-additionalauthenticationprovider.html#cfn-appsync-graphqlapi-additionalauthenticationprovider-authenticationtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthenticationType { get; set; }
        }

        public class CognitoUserPoolConfig : Humidifier.Base.BaseSubResource, IHaveAppIdClientRegex, IHaveUserPoolId, IHaveAwsRegion
        {
            /// <summary>
            /// AppIdClientRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-cognitouserpoolconfig.html#cfn-appsync-graphqlapi-cognitouserpoolconfig-appidclientregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppIdClientRegex { get; set; }
            /// <summary>
            /// UserPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-cognitouserpoolconfig.html#cfn-appsync-graphqlapi-cognitouserpoolconfig-userpoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolId { get; set; }
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-cognitouserpoolconfig.html#cfn-appsync-graphqlapi-cognitouserpoolconfig-awsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsRegion { get; set; }
        }

        public class EnhancedMetricsConfig : Humidifier.Base.BaseSubResource, IHaveOperationLevelMetricsConfig, IHaveResolverLevelMetricsBehavior, IHaveDataSourceLevelMetricsBehavior
        {
            /// <summary>
            /// OperationLevelMetricsConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-enhancedmetricsconfig.html#cfn-appsync-graphqlapi-enhancedmetricsconfig-operationlevelmetricsconfig
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OperationLevelMetricsConfig { get; set; }
            /// <summary>
            /// ResolverLevelMetricsBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-enhancedmetricsconfig.html#cfn-appsync-graphqlapi-enhancedmetricsconfig-resolverlevelmetricsbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResolverLevelMetricsBehavior { get; set; }
            /// <summary>
            /// DataSourceLevelMetricsBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-enhancedmetricsconfig.html#cfn-appsync-graphqlapi-enhancedmetricsconfig-datasourcelevelmetricsbehavior
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceLevelMetricsBehavior { get; set; }
        }

        public class LambdaAuthorizerConfig : Humidifier.Base.BaseSubResource, IHaveIdentityValidationExpression, IHaveAuthorizerUri, IHaveAuthorizerResultTtlInSeconds_Double
        {
            /// <summary>
            /// IdentityValidationExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-identityvalidationexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdentityValidationExpression { get; set; }
            /// <summary>
            /// AuthorizerUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-authorizeruri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizerUri { get; set; }
            /// <summary>
            /// AuthorizerResultTtlInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-lambdaauthorizerconfig.html#cfn-appsync-graphqlapi-lambdaauthorizerconfig-authorizerresultttlinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? AuthorizerResultTtlInSeconds { get; set; }
        }

        public class LogConfig : Humidifier.Base.BaseSubResource, IHaveCloudWatchLogsRoleArn, IHaveExcludeVerboseContent_Boolean, IHaveFieldLogLevel
        {
            /// <summary>
            /// CloudWatchLogsRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-cloudwatchlogsrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CloudWatchLogsRoleArn { get; set; }
            /// <summary>
            /// ExcludeVerboseContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-excludeverbosecontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ExcludeVerboseContent { get; set; }
            /// <summary>
            /// FieldLogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-logconfig.html#cfn-appsync-graphqlapi-logconfig-fieldloglevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? FieldLogLevel { get; set; }
        }

        public class OpenIDConnectConfig : Humidifier.Base.BaseSubResource, IHaveIssuer, IHaveClientId, IHaveAuthTTL_Double, IHaveIatTTL_Double
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html#cfn-appsync-graphqlapi-openidconnectconfig-issuer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Issuer { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html#cfn-appsync-graphqlapi-openidconnectconfig-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
            /// <summary>
            /// AuthTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html#cfn-appsync-graphqlapi-openidconnectconfig-authttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? AuthTTL { get; set; }
            /// <summary>
            /// IatTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-openidconnectconfig.html#cfn-appsync-graphqlapi-openidconnectconfig-iatttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? IatTTL { get; set; }
        }

        public class UserPoolConfig : Humidifier.Base.BaseSubResource, IHaveAppIdClientRegex, IHaveUserPoolId, IHaveAwsRegion, IHaveDefaultAction
        {
            /// <summary>
            /// AppIdClientRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-appidclientregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppIdClientRegex { get; set; }
            /// <summary>
            /// UserPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-userpoolid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserPoolId { get; set; }
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-awsregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsRegion { get; set; }
            /// <summary>
            /// DefaultAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-graphqlapi-userpoolconfig.html#cfn-appsync-graphqlapi-userpoolconfig-defaultaction
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultAction { get; set; }
        }
    }
}