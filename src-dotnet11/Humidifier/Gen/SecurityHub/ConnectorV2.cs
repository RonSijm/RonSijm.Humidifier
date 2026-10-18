namespace Humidifier.SecurityHub
{
    using global::System.Collections.Generic;
    using ConnectorV2Types;

    public class ConnectorV2 : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveKmsKeyArn, IHaveStringDictionaryOfTags, IHaveName, IHaveSecurityHubConnectorV2TypesProviderProvider
    {
        public class Attributes
        {
            public static string ConnectorArn =  "ConnectorArn" ;
            public static string LastCheckedAt =  "LastCheckedAt" ;
            public static string EnablementStatus =  "EnablementStatus" ;
            public static string Message =  "Message" ;
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string Issues =  "Issues" ;
            public static string ConnectorStatus =  "ConnectorStatus" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ConnectorId =  "ConnectorId" ;
            public static string EnablementStatusReason =  "EnablementStatusReason" ;
        }

        public override string AWSTypeName { get => AWS.SecurityHub.ConnectorV2; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-connectorv2.html#cfn-securityhub-connectorv2-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// KmsKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-connectorv2.html#cfn-securityhub-connectorv2-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-connectorv2.html#cfn-securityhub-connectorv2-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Provider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-connectorv2.html#cfn-securityhub-connectorv2-provider
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Provider
        /// </summary>
        [Required]
        public Union<Humidifier.SecurityHub.ConnectorV2Types.Provider, BaseFunction>? Provider { get; set; }
    }

    namespace ConnectorV2Types
    {
        public class AzureProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveAWSConfigConnectorArn, IHaveSecurityHubConnectorV2TypesAzureScopeConfigurationScopeConfiguration, IHaveStringListOfAzureRegions
        {
            /// <summary>
            /// AWSConfigConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-azureproviderconfiguration.html#cfn-securityhub-connectorv2-azureproviderconfiguration-awsconfigconnectorarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AWSConfigConnectorArn { get; set; }
            /// <summary>
            /// ScopeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-azureproviderconfiguration.html#cfn-securityhub-connectorv2-azureproviderconfiguration-scopeconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureScopeConfiguration
            /// </summary>
            public Union<Humidifier.SecurityHub.ConnectorV2Types.AzureScopeConfiguration, BaseFunction>? ScopeConfiguration { get; set; }
            /// <summary>
            /// AzureRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-azureproviderconfiguration.html#cfn-securityhub-connectorv2-azureproviderconfiguration-azureregions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AzureRegions { get; set; }
        }

        public class AzureScopeConfiguration : Humidifier.Base.BaseSubResource, IHaveScopeType, IHaveStringListOfScopeValues
        {
            /// <summary>
            /// ScopeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-azurescopeconfiguration.html#cfn-securityhub-connectorv2-azurescopeconfiguration-scopetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScopeType { get; set; }
            /// <summary>
            /// ScopeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-azurescopeconfiguration.html#cfn-securityhub-connectorv2-azurescopeconfiguration-scopevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ScopeValues { get; set; }
        }

        public class HealthIssue : Humidifier.Base.BaseSubResource, IHaveMessage, IHaveCode
        {
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-healthissue.html#cfn-securityhub-connectorv2-healthissue-message
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// Code
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-healthissue.html#cfn-securityhub-connectorv2-healthissue-code
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Code { get; set; }
        }

        public class JiraCloudProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveProjectKey
        {
            /// <summary>
            /// ProjectKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-jiracloudproviderconfiguration.html#cfn-securityhub-connectorv2-jiracloudproviderconfiguration-projectkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ProjectKey { get; set; }
        }

        public class Provider : Humidifier.Base.BaseSubResource, IHaveSecurityHubConnectorV2TypesServiceNowProviderConfigurationServiceNow, IHaveSecurityHubConnectorV2TypesAzureProviderConfigurationAzure, IHaveSecurityHubConnectorV2TypesJiraCloudProviderConfigurationJiraCloud
        {
            /// <summary>
            /// ServiceNow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-provider.html#cfn-securityhub-connectorv2-provider-servicenow
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ServiceNowProviderConfiguration
            /// </summary>
            public Union<Humidifier.SecurityHub.ConnectorV2Types.ServiceNowProviderConfiguration, BaseFunction>? ServiceNow { get; set; }
            /// <summary>
            /// Azure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-provider.html#cfn-securityhub-connectorv2-provider-azure
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AzureProviderConfiguration
            /// </summary>
            public Union<Humidifier.SecurityHub.ConnectorV2Types.AzureProviderConfiguration, BaseFunction>? Azure { get; set; }
            /// <summary>
            /// JiraCloud
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-provider.html#cfn-securityhub-connectorv2-provider-jiracloud
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JiraCloudProviderConfiguration
            /// </summary>
            public Union<Humidifier.SecurityHub.ConnectorV2Types.JiraCloudProviderConfiguration, BaseFunction>? JiraCloud { get; set; }
        }

        public class ServiceNowProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveInstanceName, IHaveSecretArn
        {
            /// <summary>
            /// InstanceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-servicenowproviderconfiguration.html#cfn-securityhub-connectorv2-servicenowproviderconfiguration-instancename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InstanceName { get; set; }
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-securityhub-connectorv2-servicenowproviderconfiguration.html#cfn-securityhub-connectorv2-servicenowproviderconfiguration-secretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SecretArn { get; set; }
        }
    }
}