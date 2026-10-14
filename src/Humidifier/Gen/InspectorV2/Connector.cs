namespace Humidifier.InspectorV2
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveProvider
    {
        public class Attributes
        {
            public static string LastUpdatedAt =  "LastUpdatedAt" ;
            public static string Health =  "Health" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string ConnectorArn =  "ConnectorArn" ;
            public static string EnablementStatus =  "EnablementStatus" ;
            public static string EnablementStatusReason =  "EnablementStatusReason" ;
        }

        public override string AWSTypeName { get => AWS.InspectorV2.Connector; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-connector.html#cfn-inspectorv2-connector-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-connector.html#cfn-inspectorv2-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Provider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-connector.html#cfn-inspectorv2-connector-provider
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Provider { get; set; }

        /// <summary>
        /// ProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-connector.html#cfn-inspectorv2-connector-providerconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ProviderConfiguration
        /// </summary>
        [Required]
        public Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration ProviderConfiguration { get; set; }
    }

    namespace ConnectorTypes
    {
        public class AzureProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AwsConfigConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azureproviderconfiguration.html#cfn-inspectorv2-connector-azureproviderconfiguration-awsconfigconnectorarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AwsConfigConnectorArn { get; set; }
            /// <summary>
            /// ScopeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azureproviderconfiguration.html#cfn-inspectorv2-connector-azureproviderconfiguration-scopeconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureScopeConfigurationMap
            /// </summary>
            public Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap ScopeConfiguration { get; set; }
            /// <summary>
            /// AutoInstallVMScanner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azureproviderconfiguration.html#cfn-inspectorv2-connector-azureproviderconfiguration-autoinstallvmscanner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AutoInstallVMScanner { get; set; }
            /// <summary>
            /// AzureRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azureproviderconfiguration.html#cfn-inspectorv2-connector-azureproviderconfiguration-azureregions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AzureRegions { get; set; }
        }

        public class AzureScopeConfigurationMap : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServerlessScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azurescopeconfigurationmap.html#cfn-inspectorv2-connector-azurescopeconfigurationmap-serverlessscanning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScopeConfiguration
            /// </summary>
            public Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration ServerlessScanning { get; set; }
            /// <summary>
            /// ContainerImageScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azurescopeconfigurationmap.html#cfn-inspectorv2-connector-azurescopeconfigurationmap-containerimagescanning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScopeConfiguration
            /// </summary>
            public Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration ContainerImageScanning { get; set; }
            /// <summary>
            /// VmScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azurescopeconfigurationmap.html#cfn-inspectorv2-connector-azurescopeconfigurationmap-vmscanning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScopeConfiguration
            /// </summary>
            public Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration VmScanning { get; set; }
        }

        public class ConnectorHealth : Humidifier.Base.BaseSubResource, IHaveMessage
        {
            /// <summary>
            /// LastCheckedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-connectorhealth.html#cfn-inspectorv2-connector-connectorhealth-lastcheckedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LastCheckedAt { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-connectorhealth.html#cfn-inspectorv2-connector-connectorhealth-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Message { get; set; }
            /// <summary>
            /// ConnectorStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-connectorhealth.html#cfn-inspectorv2-connector-connectorhealth-connectorstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorStatus { get; set; }
        }

        public class ProviderConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Azure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-providerconfiguration.html#cfn-inspectorv2-connector-providerconfiguration-azure
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureProviderConfiguration
            /// </summary>
            public Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration Azure { get; set; }
        }

        public class ScopeConfiguration : Humidifier.Base.BaseSubResource, IHaveState
        {
            /// <summary>
            /// ScopeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-scopeconfiguration.html#cfn-inspectorv2-connector-scopeconfiguration-scopetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScopeType { get; set; }
            /// <summary>
            /// ScopeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-scopeconfiguration.html#cfn-inspectorv2-connector-scopeconfiguration-scopevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ScopeValues { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-scopeconfiguration.html#cfn-inspectorv2-connector-scopeconfiguration-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic State { get; set; }
            /// <summary>
            /// StateReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-scopeconfiguration.html#cfn-inspectorv2-connector-scopeconfiguration-statereason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StateReason { get; set; }
        }
    }
}