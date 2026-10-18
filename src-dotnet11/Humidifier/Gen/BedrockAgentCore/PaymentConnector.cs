namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using PaymentConnectorTypes;

    public class PaymentConnector : Humidifier.Base.BaseResource, IHaveDescription, IHaveConnectorType, IHaveConnectorName, IHavePaymentManagerId, IHaveListOfBedrockAgentCorePaymentConnectorTypesCredentialsProviderConfigurationCredentialProviderConfigurations, IHaveProvisionMode
    {
        public class Attributes
        {
            public static string AuthorizationUrl =  "AuthorizationUrl" ;
            public static string ConnectorCreatedAt =  "ConnectorCreatedAt" ;
            public static string ConnectorLastUpdatedAt =  "ConnectorLastUpdatedAt" ;
            public static string PaymentConnectorId =  "PaymentConnectorId" ;
            public static string ConnectorStatus =  "ConnectorStatus" ;
            public static string PaymentConnectorArn =  "PaymentConnectorArn" ;
        }

        public override string AWSTypeName { get => AWS.BedrockAgentCore.PaymentConnector; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// ConnectorType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-connectortype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectorType { get; set; }

        /// <summary>
        /// ConnectorName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-connectorname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ConnectorName { get; set; }

        /// <summary>
        /// PaymentManagerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-paymentmanagerid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PaymentManagerId { get; set; }
        /// <summary>
        /// CredentialProviderConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-credentialproviderconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CredentialsProviderConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration>, IReadOnlyList<Union<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration, BaseFunction>>, BaseFunction>? CredentialProviderConfigurations { get; set; }
        /// <summary>
        /// ProvisionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-provisionmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProvisionMode { get; set; }
    }

    namespace PaymentConnectorTypes
    {
        public class CredentialsProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockAgentCorePaymentConnectorTypesPaymentCredentialProviderConfigurationCoinbaseCDP, IHaveBedrockAgentCorePaymentConnectorTypesPaymentCredentialProviderConfigurationStripePrivy
        {
            /// <summary>
            /// CoinbaseCDP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentconnector-credentialsproviderconfiguration.html#cfn-bedrockagentcore-paymentconnector-credentialsproviderconfiguration-coinbasecdp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaymentCredentialProviderConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration, BaseFunction>? CoinbaseCDP { get; set; }
            /// <summary>
            /// StripePrivy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentconnector-credentialsproviderconfiguration.html#cfn-bedrockagentcore-paymentconnector-credentialsproviderconfiguration-stripeprivy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaymentCredentialProviderConfiguration
            /// </summary>
            public Union<Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration, BaseFunction>? StripePrivy { get; set; }
        }

        public class PaymentCredentialProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveCredentialProviderArn
        {
            /// <summary>
            /// CredentialProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentconnector-paymentcredentialproviderconfiguration.html#cfn-bedrockagentcore-paymentconnector-paymentcredentialproviderconfiguration-credentialproviderarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialProviderArn { get; set; }
        }
    }
}