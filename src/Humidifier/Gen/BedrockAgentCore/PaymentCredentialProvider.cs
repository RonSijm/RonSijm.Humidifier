namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using PaymentCredentialProviderTypes;

    public class PaymentCredentialProvider : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags
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
        public dynamic CredentialProviderVendor { get; set; }
        /// <summary>
        /// ProviderConfigurationInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentcredentialprovider.html#cfn-bedrockagentcore-paymentcredentialprovider-providerconfigurationinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PaymentProviderConfigurationInput
        /// </summary>
        public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.PaymentProviderConfigurationInput ProviderConfigurationInput { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentcredentialprovider.html#cfn-bedrockagentcore-paymentcredentialprovider-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace PaymentCredentialProviderTypes
    {
        public class CoinbaseCdpConfigurationInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiKeySecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-apikeysecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference ApiKeySecretConfig { get; set; }
            /// <summary>
            /// WalletSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-walletsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WalletSecret { get; set; }
            /// <summary>
            /// ApiKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-apikeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyId { get; set; }
            /// <summary>
            /// WalletSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-walletsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference WalletSecretConfig { get; set; }
            /// <summary>
            /// ApiKeySecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-apikeysecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeySecretSource { get; set; }
            /// <summary>
            /// WalletSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-walletsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WalletSecretSource { get; set; }
            /// <summary>
            /// ApiKeySecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationinput-apikeysecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeySecret { get; set; }
        }

        public class CoinbaseCdpConfigurationOutput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ApiKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-apikeyid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeyId { get; set; }
            /// <summary>
            /// WalletSecretJsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-walletsecretjsonkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WalletSecretJsonKey { get; set; }
            /// <summary>
            /// WalletSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-walletsecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretInfo
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretInfo WalletSecretArn { get; set; }
            /// <summary>
            /// ApiKeySecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-apikeysecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeySecretSource { get; set; }
            /// <summary>
            /// ApiKeySecretJsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-apikeysecretjsonkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiKeySecretJsonKey { get; set; }
            /// <summary>
            /// WalletSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-walletsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WalletSecretSource { get; set; }
            /// <summary>
            /// ApiKeySecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-coinbasecdpconfigurationoutput-apikeysecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretInfo
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretInfo ApiKeySecretArn { get; set; }
        }

        public class PaymentProviderConfigurationInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CoinbaseCdpConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationinput-coinbasecdpconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CoinbaseCdpConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.CoinbaseCdpConfigurationInput CoinbaseCdpConfiguration { get; set; }
            /// <summary>
            /// StripePrivyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationinput-stripeprivyconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StripePrivyConfigurationInput
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.StripePrivyConfigurationInput StripePrivyConfiguration { get; set; }
        }

        public class PaymentProviderConfigurationOutput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CoinbaseCdpConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationoutput-coinbasecdpconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CoinbaseCdpConfigurationOutput
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.CoinbaseCdpConfigurationOutput CoinbaseCdpConfiguration { get; set; }
            /// <summary>
            /// StripePrivyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-paymentproviderconfigurationoutput-stripeprivyconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StripePrivyConfigurationOutput
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.StripePrivyConfigurationOutput StripePrivyConfiguration { get; set; }
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
            public dynamic SecretArn { get; set; }
        }

        public class SecretReference : Humidifier.Base.BaseSubResource, IHaveSecretId
        {
            /// <summary>
            /// JsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-secretreference.html#cfn-bedrockagentcore-paymentcredentialprovider-secretreference-jsonkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JsonKey { get; set; }
            /// <summary>
            /// SecretId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-secretreference.html#cfn-bedrockagentcore-paymentcredentialprovider-secretreference-secretid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretId { get; set; }
        }

        public class StripePrivyConfigurationInput : Humidifier.Base.BaseSubResource, IHaveAppId
        {
            /// <summary>
            /// AppSecretConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-appsecretconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference AppSecretConfig { get; set; }
            /// <summary>
            /// AuthorizationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-authorizationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationId { get; set; }
            /// <summary>
            /// AuthorizationPrivateKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-authorizationprivatekey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationPrivateKey { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-authorizationprivatekeysource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationPrivateKeySource { get; set; }
            /// <summary>
            /// AppId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-appid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppId { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeyConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-authorizationprivatekeyconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SecretReference
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretReference AuthorizationPrivateKeyConfig { get; set; }
            /// <summary>
            /// AppSecret
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-appsecret
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppSecret { get; set; }
            /// <summary>
            /// AppSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationinput-appsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppSecretSource { get; set; }
        }

        public class StripePrivyConfigurationOutput : Humidifier.Base.BaseSubResource, IHaveAppId
        {
            /// <summary>
            /// AuthorizationId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-authorizationid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationId { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeySource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-authorizationprivatekeysource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationPrivateKeySource { get; set; }
            /// <summary>
            /// AppId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-appid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppId { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-authorizationprivatekeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretInfo
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretInfo AuthorizationPrivateKeyArn { get; set; }
            /// <summary>
            /// AppSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-appsecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SecretInfo
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentCredentialProviderTypes.SecretInfo AppSecretArn { get; set; }
            /// <summary>
            /// AuthorizationPrivateKeyJsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-authorizationprivatekeyjsonkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthorizationPrivateKeyJsonKey { get; set; }
            /// <summary>
            /// AppSecretJsonKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-appsecretjsonkey
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppSecretJsonKey { get; set; }
            /// <summary>
            /// AppSecretSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput.html#cfn-bedrockagentcore-paymentcredentialprovider-stripeprivyconfigurationoutput-appsecretsource
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppSecretSource { get; set; }
        }
    }
}