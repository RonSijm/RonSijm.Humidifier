namespace Humidifier.BedrockAgentCore
{
    using global::System.Collections.Generic;
    using PaymentConnectorTypes;

    public class PaymentConnector : Humidifier.Base.BaseResource, IHaveDescription, IHaveConnectorType
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
        public dynamic Description { get; set; }

        /// <summary>
        /// ConnectorType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-connectortype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectorType { get; set; }

        /// <summary>
        /// ConnectorName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-connectorname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ConnectorName { get; set; }

        /// <summary>
        /// PaymentManagerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-paymentmanagerid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic PaymentManagerId { get; set; }
        /// <summary>
        /// CredentialProviderConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-credentialproviderconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CredentialsProviderConfiguration
        /// </summary>
        public List<Humidifier.BedrockAgentCore.PaymentConnectorTypes.CredentialsProviderConfiguration> CredentialProviderConfigurations { get; set; }
        /// <summary>
        /// ProvisionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrockagentcore-paymentconnector.html#cfn-bedrockagentcore-paymentconnector-provisionmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProvisionMode { get; set; }
    }

    namespace PaymentConnectorTypes
    {
        public class CredentialsProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CoinbaseCDP
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentconnector-credentialsproviderconfiguration.html#cfn-bedrockagentcore-paymentconnector-credentialsproviderconfiguration-coinbasecdp
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaymentCredentialProviderConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration CoinbaseCDP { get; set; }
            /// <summary>
            /// StripePrivy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentconnector-credentialsproviderconfiguration.html#cfn-bedrockagentcore-paymentconnector-credentialsproviderconfiguration-stripeprivy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PaymentCredentialProviderConfiguration
            /// </summary>
            public Humidifier.BedrockAgentCore.PaymentConnectorTypes.PaymentCredentialProviderConfiguration StripePrivy { get; set; }
        }

        public class PaymentCredentialProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CredentialProviderArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrockagentcore-paymentconnector-paymentcredentialproviderconfiguration.html#cfn-bedrockagentcore-paymentconnector-paymentcredentialproviderconfiguration-credentialproviderarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialProviderArn { get; set; }
        }
    }
}