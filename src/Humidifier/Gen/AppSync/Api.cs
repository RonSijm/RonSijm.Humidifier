namespace Humidifier.AppSync
{
    using System.Collections.Generic;
    using ApiTypes;

    public class Api : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
    {
        public class Attributes
        {
            public static string ApiArn =  "ApiArn" ;
            public static string Dns =  "Dns" ;
            public static string ApiId =  "ApiId" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.Api; }
        /// <summary>
        /// OwnerContact
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-api.html#cfn-appsync-api-ownercontact
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OwnerContact { get; set; }
        /// <summary>
        /// EventConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-api.html#cfn-appsync-api-eventconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EventConfig
        /// </summary>
        public Humidifier.AppSync.ApiTypes.EventConfig EventConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-api.html#cfn-appsync-api-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApiTypes
    {
        public class AuthMode : Humidifier.Base.BaseSubResource, IHaveAuthType
        {
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-authmode.html#cfn-appsync-api-authmode-authtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthType { get; set; }
        }

        public class AuthProvider : Humidifier.Base.BaseSubResource, IHaveAuthType
        {
            /// <summary>
            /// OpenIDConnectConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-authprovider.html#cfn-appsync-api-authprovider-openidconnectconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenIDConnectConfig
            /// </summary>
            public Humidifier.AppSync.ApiTypes.OpenIDConnectConfig OpenIDConnectConfig { get; set; }
            /// <summary>
            /// CognitoConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-authprovider.html#cfn-appsync-api-authprovider-cognitoconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CognitoConfig
            /// </summary>
            public Humidifier.AppSync.ApiTypes.CognitoConfig CognitoConfig { get; set; }
            /// <summary>
            /// LambdaAuthorizerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-authprovider.html#cfn-appsync-api-authprovider-lambdaauthorizerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaAuthorizerConfig
            /// </summary>
            public Humidifier.AppSync.ApiTypes.LambdaAuthorizerConfig LambdaAuthorizerConfig { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-authprovider.html#cfn-appsync-api-authprovider-authtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthType { get; set; }
        }

        public class CognitoConfig : Humidifier.Base.BaseSubResource, IHaveUserPoolId, IHaveAwsRegion
        {
            /// <summary>
            /// AppIdClientRegex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-cognitoconfig.html#cfn-appsync-api-cognitoconfig-appidclientregex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppIdClientRegex { get; set; }
            /// <summary>
            /// UserPoolId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-cognitoconfig.html#cfn-appsync-api-cognitoconfig-userpoolid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserPoolId { get; set; }
            /// <summary>
            /// AwsRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-cognitoconfig.html#cfn-appsync-api-cognitoconfig-awsregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsRegion { get; set; }
        }

        public class DnsMap : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Http
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-dnsmap.html#cfn-appsync-api-dnsmap-http
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Http { get; set; }
            /// <summary>
            /// Realtime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-dnsmap.html#cfn-appsync-api-dnsmap-realtime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Realtime { get; set; }
        }

        public class EventConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AuthProviders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-eventconfig.html#cfn-appsync-api-eventconfig-authproviders
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AuthProvider
            /// </summary>
            public List<Humidifier.AppSync.ApiTypes.AuthProvider> AuthProviders { get; set; }
            /// <summary>
            /// ConnectionAuthModes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-eventconfig.html#cfn-appsync-api-eventconfig-connectionauthmodes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AuthMode
            /// </summary>
            public List<Humidifier.AppSync.ApiTypes.AuthMode> ConnectionAuthModes { get; set; }
            /// <summary>
            /// DefaultPublishAuthModes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-eventconfig.html#cfn-appsync-api-eventconfig-defaultpublishauthmodes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AuthMode
            /// </summary>
            public List<Humidifier.AppSync.ApiTypes.AuthMode> DefaultPublishAuthModes { get; set; }
            /// <summary>
            /// DefaultSubscribeAuthModes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-eventconfig.html#cfn-appsync-api-eventconfig-defaultsubscribeauthmodes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AuthMode
            /// </summary>
            public List<Humidifier.AppSync.ApiTypes.AuthMode> DefaultSubscribeAuthModes { get; set; }
            /// <summary>
            /// LogConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-eventconfig.html#cfn-appsync-api-eventconfig-logconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventLogConfig
            /// </summary>
            public Humidifier.AppSync.ApiTypes.EventLogConfig LogConfig { get; set; }
        }

        public class EventLogConfig : Humidifier.Base.BaseSubResource, IHaveLogLevel
        {
            /// <summary>
            /// CloudWatchLogsRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-eventlogconfig.html#cfn-appsync-api-eventlogconfig-cloudwatchlogsrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudWatchLogsRoleArn { get; set; }
            /// <summary>
            /// LogLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-eventlogconfig.html#cfn-appsync-api-eventlogconfig-loglevel
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogLevel { get; set; }
        }

        public class LambdaAuthorizerConfig : Humidifier.Base.BaseSubResource, IHaveIdentityValidationExpression, IHaveAuthorizerUri, IHaveAuthorizerResultTtlInSeconds
        {
            /// <summary>
            /// IdentityValidationExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-lambdaauthorizerconfig.html#cfn-appsync-api-lambdaauthorizerconfig-identityvalidationexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IdentityValidationExpression { get; set; }
            /// <summary>
            /// AuthorizerUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-lambdaauthorizerconfig.html#cfn-appsync-api-lambdaauthorizerconfig-authorizeruri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizerUri { get; set; }
            /// <summary>
            /// AuthorizerResultTtlInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-lambdaauthorizerconfig.html#cfn-appsync-api-lambdaauthorizerconfig-authorizerresultttlinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AuthorizerResultTtlInSeconds { get; set; }
        }

        public class OpenIDConnectConfig : Humidifier.Base.BaseSubResource, IHaveClientId, IHaveIssuer
        {
            /// <summary>
            /// Issuer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-openidconnectconfig.html#cfn-appsync-api-openidconnectconfig-issuer
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Issuer { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-openidconnectconfig.html#cfn-appsync-api-openidconnectconfig-clientid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClientId { get; set; }
            /// <summary>
            /// AuthTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-openidconnectconfig.html#cfn-appsync-api-openidconnectconfig-authttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic AuthTTL { get; set; }
            /// <summary>
            /// IatTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-api-openidconnectconfig.html#cfn-appsync-api-openidconnectconfig-iatttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic IatTTL { get; set; }
        }
    }
}