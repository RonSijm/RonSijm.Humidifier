namespace Humidifier.Cognito
{
    using global::System.Collections.Generic;
    using IdentityPoolTypes;

    public class IdentityPool : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveCognitoIdentityPoolTypesPushSyncPushSync, IHaveListOfCognitoIdentityPoolTypesCognitoIdentityProviderCognitoIdentityProviders, IHaveCognitoEvents_Json, IHaveDeveloperProviderName, IHaveCognitoIdentityPoolTypesCognitoStreamsCognitoStreams, IHaveIdentityPoolName, IHaveSupportedLoginProviders_Json, IHaveAllowUnauthenticatedIdentities_Boolean, IHaveTagListOfIdentityPoolTags, IHaveStringListOfSamlProviderARNs, IHaveStringListOfOpenIdConnectProviderARNs, IHaveAllowClassicFlow_Boolean
    {
        public class Attributes
        {
            public static string Id =  "Id" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Cognito.IdentityPool; }
        /// <summary>
        /// PushSync
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-pushsync
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PushSync
        /// </summary>
        public Union<Humidifier.Cognito.IdentityPoolTypes.PushSync, BaseFunction>? PushSync { get; set; }
        /// <summary>
        /// CognitoIdentityProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-cognitoidentityproviders
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CognitoIdentityProvider
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider>, IReadOnlyList<Union<Humidifier.Cognito.IdentityPoolTypes.CognitoIdentityProvider, BaseFunction>>, BaseFunction>? CognitoIdentityProviders { get; set; }
        /// <summary>
        /// CognitoEvents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-cognitoevents
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? CognitoEvents { get; set; }
        /// <summary>
        /// DeveloperProviderName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-developerprovidername
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeveloperProviderName { get; set; }
        /// <summary>
        /// CognitoStreams
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-cognitostreams
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CognitoStreams
        /// </summary>
        public Union<Humidifier.Cognito.IdentityPoolTypes.CognitoStreams, BaseFunction>? CognitoStreams { get; set; }
        public Union<string, BaseFunction>? IdentityPoolName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// SupportedLoginProviders
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-supportedloginproviders
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? SupportedLoginProviders { get; set; }

        /// <summary>
        /// AllowUnauthenticatedIdentities
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-allowunauthenticatedidentities
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        [Required]
        public Union<bool, BaseFunction>? AllowUnauthenticatedIdentities { get; set; }
        /// <summary>
        /// IdentityPoolTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-identitypooltags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? IdentityPoolTags { get; set; }
        /// <summary>
        /// SamlProviderARNs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-samlproviderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SamlProviderARNs { get; set; }
        /// <summary>
        /// OpenIdConnectProviderARNs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-openidconnectproviderarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? OpenIdConnectProviderARNs { get; set; }
        /// <summary>
        /// AllowClassicFlow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-identitypool.html#cfn-cognito-identitypool-allowclassicflow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? AllowClassicFlow { get; set; }
    }

    namespace IdentityPoolTypes
    {
        public class CognitoIdentityProvider : Humidifier.Base.BaseSubResource, IHaveServerSideTokenCheck_Boolean, IHaveProviderName, IHaveClientId
        {
            /// <summary>
            /// ServerSideTokenCheck
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitoidentityprovider.html#cfn-cognito-identitypool-cognitoidentityprovider-serversidetokencheck
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? ServerSideTokenCheck { get; set; }
            /// <summary>
            /// ProviderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitoidentityprovider.html#cfn-cognito-identitypool-cognitoidentityprovider-providername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProviderName { get; set; }
            /// <summary>
            /// ClientId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitoidentityprovider.html#cfn-cognito-identitypool-cognitoidentityprovider-clientid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClientId { get; set; }
        }

        public class CognitoStreams : Humidifier.Base.BaseSubResource, IHaveStreamingStatus, IHaveStreamName, IHaveRoleArn
        {
            /// <summary>
            /// StreamingStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitostreams.html#cfn-cognito-identitypool-cognitostreams-streamingstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamingStatus { get; set; }
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitostreams.html#cfn-cognito-identitypool-cognitostreams-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StreamName { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-cognitostreams.html#cfn-cognito-identitypool-cognitostreams-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }

        public class PushSync : Humidifier.Base.BaseSubResource, IHaveStringListOfApplicationArns, IHaveRoleArn
        {
            /// <summary>
            /// ApplicationArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-pushsync.html#cfn-cognito-identitypool-pushsync-applicationarns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ApplicationArns { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cognito-identitypool-pushsync.html#cfn-cognito-identitypool-pushsync-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RoleArn { get; set; }
        }
    }
}