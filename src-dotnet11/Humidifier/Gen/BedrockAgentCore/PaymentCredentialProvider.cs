namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using PaymentCredentialProviderTypes;

    public class PaymentCredentialProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveCredentialProviderVendor, IHaveBedrockAgentCorePaymentCredentialProviderTypesPaymentProviderConfigurationInputProviderConfigurationInput, IHaveName
    {
        public class Attributes
        {
            public static string CredentialProviderArn =  "CredentialProviderArn" ;
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastUpdatedTime =  "LastUpdatedTime" ;
            public static string ProviderConfigurationOutput =  "ProviderConfigurationOutput" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.PaymentCredentialProvider; }

        /// <summary>
        /// CredentialProviderVendor
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentcredentialprovider.html#cfn-bedrockagentcore-paymentcredentialprovider-credentialprovidervendor
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CredentialProviderVendor { get; set; }
        /// <summary>
        /// ProviderConfigurationInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentcredentialprovider.html#cfn-bedrockagentcore-paymentcredentialprovider-providerconfigurationinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PaymentProviderConfigurationInput
        /// </summary>
        public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput, BaseFunction>? ProviderConfigurationInput { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentcredentialprovider.html#cfn-bedrockagentcore-paymentcredentialprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace PaymentCredentialProviderTypes
    {
        public class CoinbaseCdpConfigurationInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePaymentCredentialProviderTypesSecretReferenceApiKeySecretConfig, IHaveWalletSecret, IHaveApiKeyId, IHaveBedrockAgentCorePaymentCredentialProviderTypesSecretReferenceWalletSecretConfig, IHaveApiKeySecretSource, IHaveWalletSecretSource, IHaveApiKeySecret
        {
            /// <summary>
            /// ApiKeySecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-apikeysecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference, BaseFunction>? ApiKeySecretConfig { get; set; }
            /// <summary>
            /// WalletSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-walletsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WalletSecret { get; set; }
            /// <summary>
            /// ApiKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-apikeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyId { get; set; }
            /// <summary>
            /// WalletSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-walletsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference, BaseFunction>? WalletSecretConfig { get; set; }
            /// <summary>
            /// ApiKeySecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-apikeysecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeySecretSource { get; set; }
            /// <summary>
            /// WalletSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-walletsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WalletSecretSource { get; set; }
            /// <summary>
            /// ApiKeySecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-apikeysecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeySecret { get; set; }
        }

        public class CoinbaseCdpConfigurationOutput : Humidifier.Base.BaseSubResource, IHaveApiKeyId, IHaveWalletSecretJsonKey, IHaveBedrockAgentCorePaymentCredentialProviderTypesSecretInfoWalletSecretArn, IHaveApiKeySecretSource, IHaveApiKeySecretJsonKey, IHaveWalletSecretSource, IHaveBedrockAgentCorePaymentCredentialProviderTypesSecretInfoApiKeySecretArn
        {
            /// <summary>
            /// ApiKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-apikeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeyId { get; set; }
            /// <summary>
            /// WalletSecretJsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-walletsecretjsonkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WalletSecretJsonKey { get; set; }
            /// <summary>
            /// WalletSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-walletsecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretInfo
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretInfo, BaseFunction>? WalletSecretArn { get; set; }
            /// <summary>
            /// ApiKeySecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-apikeysecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeySecretSource { get; set; }
            /// <summary>
            /// ApiKeySecretJsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-apikeysecretjsonkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ApiKeySecretJsonKey { get; set; }
            /// <summary>
            /// WalletSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-walletsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WalletSecretSource { get; set; }
            /// <summary>
            /// ApiKeySecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-apikeysecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretInfo
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretInfo, BaseFunction>? ApiKeySecretArn { get; set; }
        }

        public class PaymentProviderConfigurationInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePaymentCredentialProviderTypesCoinbaseCdpConfigurationInputCoinbaseCdpConfiguration, IHaveBedrockAgentCorePaymentCredentialProviderTypesStripePrivyConfigurationInputStripePrivyConfiguration
        {
            /// <summary>
            /// CoinbaseCdpConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationinput-coinbasecdpconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CoinbaseCdpConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.CoinbaseCdpConfigurationInput, BaseFunction>? CoinbaseCdpConfiguration { get; set; }
            /// <summary>
            /// StripePrivyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationinput-stripeprivyconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StripePrivyConfigurationInput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.StripePrivyConfigurationInput, BaseFunction>? StripePrivyConfiguration { get; set; }
        }

        public class PaymentProviderConfigurationOutput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePaymentCredentialProviderTypesCoinbaseCdpConfigurationOutputCoinbaseCdpConfiguration, IHaveBedrockAgentCorePaymentCredentialProviderTypesStripePrivyConfigurationOutputStripePrivyConfiguration
        {
            /// <summary>
            /// CoinbaseCdpConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationoutput-coinbasecdpconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CoinbaseCdpConfigurationOutput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.CoinbaseCdpConfigurationOutput, BaseFunction>? CoinbaseCdpConfiguration { get; set; }
            /// <summary>
            /// StripePrivyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationoutput-stripeprivyconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StripePrivyConfigurationOutput
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.StripePrivyConfigurationOutput, BaseFunction>? StripePrivyConfiguration { get; set; }
        }

        public class SecretInfo : Humidifier.Base.BaseSubResource, IHaveSecretArn
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-secretinfo.html#cfn-bedrockagentcore-paymentcredentialprovider-secretinfo-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }

        public class SecretReference : Humidifier.Base.BaseSubResource, IHaveJsonKey, IHaveSecretId
        {
            /// <summary>
            /// JsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-secretreference.html#cfn-bedrockagentcore-paymentcredentialprovider-secretreference-jsonkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? JsonKey { get; set; }
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-secretreference.html#cfn-bedrockagentcore-paymentcredentialprovider-secretreference-secretid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretId { get; set; }
        }

        public class StripePrivyConfigurationInput : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePaymentCredentialProviderTypesSecretReferenceAppSecretConfig, IHaveAuthorizationId, IHaveAuthorizationPrivateKey, IHaveAuthorizationPrivateKeySource, IHaveAppId, IHaveBedrockAgentCorePaymentCredentialProviderTypesSecretReferenceAuthorizationPrivateKeyConfig, IHaveAppSecret, IHaveAppSecretSource
        {
            /// <summary>
            /// AppSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-appsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference, BaseFunction>? AppSecretConfig { get; set; }
            /// <summary>
            /// AuthorizationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-authorizationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationId { get; set; }
            /// <summary>
            /// AuthorizationPrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-authorizationprivatekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationPrivateKey { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-authorizationprivatekeysource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationPrivateKeySource { get; set; }
            /// <summary>
            /// AppId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-appid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppId { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-authorizationprivatekeyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference, BaseFunction>? AuthorizationPrivateKeyConfig { get; set; }
            /// <summary>
            /// AppSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-appsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppSecret { get; set; }
            /// <summary>
            /// AppSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-appsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppSecretSource { get; set; }
        }

        public class StripePrivyConfigurationOutput : Humidifier.Base.BaseSubResource, IHaveAuthorizationId, IHaveAuthorizationPrivateKeySource, IHaveAppId, IHaveBedrockAgentCorePaymentCredentialProviderTypesSecretInfoAuthorizationPrivateKeyArn, IHaveBedrockAgentCorePaymentCredentialProviderTypesSecretInfoAppSecretArn, IHaveAuthorizationPrivateKeyJsonKey, IHaveAppSecretJsonKey, IHaveAppSecretSource
        {
            /// <summary>
            /// AuthorizationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-authorizationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationId { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-authorizationprivatekeysource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationPrivateKeySource { get; set; }
            /// <summary>
            /// AppId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-appid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppId { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-authorizationprivatekeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretInfo
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretInfo, BaseFunction>? AuthorizationPrivateKeyArn { get; set; }
            /// <summary>
            /// AppSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-appsecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretInfo
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretInfo, BaseFunction>? AppSecretArn { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeyJsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-authorizationprivatekeyjsonkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthorizationPrivateKeyJsonKey { get; set; }
            /// <summary>
            /// AppSecretJsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-appsecretjsonkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppSecretJsonKey { get; set; }
            /// <summary>
            /// AppSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-appsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppSecretSource { get; set; }
        }
    }
}