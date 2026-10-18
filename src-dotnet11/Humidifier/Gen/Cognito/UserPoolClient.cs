namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using UserPoolClientTypes;

    public class UserPoolClient : Humidifier.Base.BaseResource, IHaveCognitoUserPoolClientTypesAnalyticsConfigurationAnalyticsConfiguration, IHaveGenerateSecret_Boolean, IHaveStringListOfCallbackURLs, IHaveEnablePropagateAdditionalUserContextData_Boolean, IHaveIdTokenValidity_Integer, IHaveAuthSessionValidity_Integer, IHaveCognitoUserPoolClientTypesRefreshTokenRotationRefreshTokenRotation, IHaveStringListOfAllowedOAuthScopes, IHaveCognitoUserPoolClientTypesTokenValidityUnitsTokenValidityUnits, IHaveStringListOfReadAttributes, IHaveAllowedOAuthFlowsUserPoolClient_Boolean, IHaveDefaultRedirectURI, IHaveStringListOfSupportedIdentityProviders, IHaveClientName, IHaveUserPoolId, IHaveStringListOfAllowedOAuthFlows, IHaveStringListOfExplicitAuthFlows, IHaveStringListOfLogoutURLs, IHaveAccessTokenValidity_Integer, IHaveRefreshTokenValidity_Integer, IHaveStringListOfWriteAttributes, IHavePreventUserExistenceErrors, IHaveEnableTokenRevocation_Boolean
    {
        public class Attributes
        {
            public static string ClientSecret =  "ClientSecret" ;
            public static string ClientId =  "ClientId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Cognito.UserPoolClient; }
        /// <summary>
        /// AnalyticsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-analyticsconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnalyticsConfiguration
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolClientTypes.AnalyticsConfiguration, BaseFunction>? AnalyticsConfiguration { get; set; }
        /// <summary>
        /// GenerateSecret
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-generatesecret
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? GenerateSecret { get; set; }
        /// <summary>
        /// CallbackURLs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-callbackurls
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? CallbackURLs { get; set; }
        /// <summary>
        /// EnablePropagateAdditionalUserContextData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-enablepropagateadditionalusercontextdata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnablePropagateAdditionalUserContextData { get; set; }
        /// <summary>
        /// IdTokenValidity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-idtokenvalidity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? IdTokenValidity { get; set; }
        /// <summary>
        /// AuthSessionValidity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-authsessionvalidity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AuthSessionValidity { get; set; }
        /// <summary>
        /// RefreshTokenRotation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-refreshtokenrotation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RefreshTokenRotation
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolClientTypes.RefreshTokenRotation, BaseFunction>? RefreshTokenRotation { get; set; }
        /// <summary>
        /// AllowedOAuthScopes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-allowedoauthscopes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedOAuthScopes { get; set; }
        /// <summary>
        /// TokenValidityUnits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-tokenvalidityunits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TokenValidityUnits
        /// </summary>
        public Union<Humidifier.Cognito.UserPoolClientTypes.TokenValidityUnits, BaseFunction>? TokenValidityUnits { get; set; }
        /// <summary>
        /// ReadAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-readattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ReadAttributes { get; set; }
        /// <summary>
        /// AllowedOAuthFlowsUserPoolClient
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-allowedoauthflowsuserpoolclient
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowedOAuthFlowsUserPoolClient { get; set; }
        /// <summary>
        /// DefaultRedirectURI
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-defaultredirecturi
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultRedirectURI { get; set; }
        /// <summary>
        /// SupportedIdentityProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-supportedidentityproviders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SupportedIdentityProviders { get; set; }
        /// <summary>
        /// ClientName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-clientname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ClientName { get; set; }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? UserPoolId { get; set; }
        /// <summary>
        /// AllowedOAuthFlows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-allowedoauthflows
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AllowedOAuthFlows { get; set; }
        /// <summary>
        /// ExplicitAuthFlows
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-explicitauthflows
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExplicitAuthFlows { get; set; }
        /// <summary>
        /// LogoutURLs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-logouturls
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogoutURLs { get; set; }
        /// <summary>
        /// AccessTokenValidity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-accesstokenvalidity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? AccessTokenValidity { get; set; }
        /// <summary>
        /// RefreshTokenValidity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-refreshtokenvalidity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? RefreshTokenValidity { get; set; }
        /// <summary>
        /// WriteAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-writeattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? WriteAttributes { get; set; }
        /// <summary>
        /// PreventUserExistenceErrors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-preventuserexistenceerrors
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PreventUserExistenceErrors { get; set; }
        /// <summary>
        /// EnableTokenRevocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolclient.html#cfn-cognito-userpoolclient-enabletokenrevocation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? EnableTokenRevocation { get; set; }
    }

    namespace UserPoolClientTypes
    {
        public class AnalyticsConfiguration : Humidifier.Base.BaseSubResource, IHaveApplicationArn, IHaveUserDataShared_Boolean, IHaveExternalId, IHaveApplicationId, IHaveRoleArn
        {
            /// <summary>
            /// ApplicationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-analyticsconfiguration.html#cfn-cognito-userpoolclient-analyticsconfiguration-applicationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationArn { get; set; }
            /// <summary>
            /// UserDataShared
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-analyticsconfiguration.html#cfn-cognito-userpoolclient-analyticsconfiguration-userdatashared
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? UserDataShared { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-analyticsconfiguration.html#cfn-cognito-userpoolclient-analyticsconfiguration-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// ApplicationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-analyticsconfiguration.html#cfn-cognito-userpoolclient-analyticsconfiguration-applicationid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApplicationId { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-analyticsconfiguration.html#cfn-cognito-userpoolclient-analyticsconfiguration-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class RefreshTokenRotation : Humidifier.Base.BaseSubResource, IHaveRetryGracePeriodSeconds_Integer, IHaveFeature
        {
            /// <summary>
            /// RetryGracePeriodSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-refreshtokenrotation.html#cfn-cognito-userpoolclient-refreshtokenrotation-retrygraceperiodseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RetryGracePeriodSeconds { get; set; }
            /// <summary>
            /// Feature
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-refreshtokenrotation.html#cfn-cognito-userpoolclient-refreshtokenrotation-feature
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Feature { get; set; }
        }

        public class TokenValidityUnits : Humidifier.Base.BaseSubResource, IHaveIdToken, IHaveRefreshToken, IHaveAccessToken
        {
            /// <summary>
            /// IdToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-tokenvalidityunits.html#cfn-cognito-userpoolclient-tokenvalidityunits-idtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IdToken { get; set; }
            /// <summary>
            /// RefreshToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-tokenvalidityunits.html#cfn-cognito-userpoolclient-tokenvalidityunits-refreshtoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RefreshToken { get; set; }
            /// <summary>
            /// AccessToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-userpoolclient-tokenvalidityunits.html#cfn-cognito-userpoolclient-tokenvalidityunits-accesstoken
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AccessToken { get; set; }
        }
    }
}