namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using ApiKeyCredentialProviderTypes;

    public class ApiKeyCredentialProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveBedrockAgentCoreApiKeyCredentialProviderTypesSecretReferenceApiKeySecretConfig, IHaveApiKey, IHaveApiKeySecretSource, IHaveName
    {
        public class Attributes
        {
            public static string CredentialProviderArn =  "CredentialProviderArn" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string ApiKeySecretJsonKey =  "ApiKeySecretJsonKey" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string ApiKeySecretArn =  "ApiKeySecretArn" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.ApiKeyCredentialProvider; }
        /// <summary>
        /// ApiKeySecretConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-apikeycredentialprovider.html#cfn-bedrockagentcore-apikeycredentialprovider-apikeysecretconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SecretReference
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.ApiKeyCredentialProviderTypes.SecretReference, BaseFunction>? ApiKeySecretConfig { get; set; }
        /// <summary>
        /// ApiKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-apikeycredentialprovider.html#cfn-bedrockagentcore-apikeycredentialprovider-apikey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApiKey { get; set; }
        /// <summary>
        /// ApiKeySecretSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-apikeycredentialprovider.html#cfn-bedrockagentcore-apikeycredentialprovider-apikeysecretsource
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ApiKeySecretSource { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-apikeycredentialprovider.html#cfn-bedrockagentcore-apikeycredentialprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace ApiKeyCredentialProviderTypes
    {
        public class ApiKeySecretArn : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-apikeycredentialprovider-apikeysecretarn.html#cfn-bedrockagentcore-apikeycredentialprovider-apikeysecretarn-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class SecretReference : Humidifier.Base.BaseSubResource, IHaveSecretId, IHaveJsonKey
        {
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-apikeycredentialprovider-secretreference.html#cfn-bedrockagentcore-apikeycredentialprovider-secretreference-secretid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretId { get; set; }
            /// <summary>
            /// JsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-apikeycredentialprovider-secretreference.html#cfn-bedrockagentcore-apikeycredentialprovider-secretreference-jsonkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JsonKey { get; set; }
        }
    }
}