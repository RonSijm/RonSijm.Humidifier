namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription
    {
        public class Attributes
        {
            public static string ConnectorArn =  "ConnectorArn" ;
            public static string LastCheckedAt =  "LastCheckedAt" ;
            public static string EnablementStatus =  "EnablementStatus" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string Message =  "Message" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string Issues =  "Issues" ;
            public static string ConnectorStatus =  "ConnectorStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ConnectorId =  "ConnectorId" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.Connector; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-connector.html#cfn-securityhub-connector-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-connector.html#cfn-securityhub-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Provider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-connector.html#cfn-securityhub-connector-provider
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Provider
        /// </summary>
        [Required]
        public Humidifier.SecurityHub.ConnectorTypes.Provider Provider { get; set; }
    }

    namespace ConnectorTypes
    {
        public class AzureProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AWSConfigConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connector-azureproviderconfiguration.html#cfn-securityhub-connector-azureproviderconfiguration-awsconfigconnectorarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AWSConfigConnectorArn { get; set; }
            /// <summary>
            /// ScopeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connector-azureproviderconfiguration.html#cfn-securityhub-connector-azureproviderconfiguration-scopeconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureScopeConfiguration
            /// </summary>
            public Humidifier.SecurityHub.ConnectorTypes.AzureScopeConfiguration ScopeConfiguration { get; set; }
            /// <summary>
            /// AzureRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connector-azureproviderconfiguration.html#cfn-securityhub-connector-azureproviderconfiguration-azureregions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AzureRegions { get; set; }
        }

        public class AzureScopeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ScopeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connector-azurescopeconfiguration.html#cfn-securityhub-connector-azurescopeconfiguration-scopetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScopeType { get; set; }
            /// <summary>
            /// ScopeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connector-azurescopeconfiguration.html#cfn-securityhub-connector-azurescopeconfiguration-scopevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ScopeValues { get; set; }
        }

        public class HealthIssue : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connector-healthissue.html#cfn-securityhub-connector-healthissue-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connector-healthissue.html#cfn-securityhub-connector-healthissue-code
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Code { get; set; }
        }

        public class Provider : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Azure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connector-provider.html#cfn-securityhub-connector-provider-azure
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureProviderConfiguration
            /// </summary>
            public Humidifier.SecurityHub.ConnectorTypes.AzureProviderConfiguration Azure { get; set; }
        }
    }
}