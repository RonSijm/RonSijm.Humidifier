namespace Humidifier.InspectorV2
{
    using global::System.Collections.Generic;
    using ConnectorTypes;

    public class Connector : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveName, IHaveProvider, IHaveInspectorV2ConnectorTypesProviderConfigurationProviderConfiguration
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
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-connector.html#cfn-inspectorv2-connector-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Provider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-connector.html#cfn-inspectorv2-connector-provider
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Provider { get; set; }

        /// <summary>
        /// ProviderConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-inspectorv2-connector.html#cfn-inspectorv2-connector-providerconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ProviderConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.InspectorV2.ConnectorTypes.ProviderConfiguration, BaseFunction>? ProviderConfiguration { get; set; }
    }

    namespace ConnectorTypes
    {
        public class AzureProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveAwsConfigConnectorArn, IHaveInspectorV2ConnectorTypesAzureScopeConfigurationMapScopeConfiguration, IHaveAutoInstallVMScanner_Boolean, IHaveStringListOfAzureRegions
        {
            /// <summary>
            /// AwsConfigConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azureproviderconfiguration.html#cfn-inspectorv2-connector-azureproviderconfiguration-awsconfigconnectorarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AwsConfigConnectorArn { get; set; }
            /// <summary>
            /// ScopeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azureproviderconfiguration.html#cfn-inspectorv2-connector-azureproviderconfiguration-scopeconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureScopeConfigurationMap
            /// </summary>
            public Union<Humidifier.InspectorV2.ConnectorTypes.AzureScopeConfigurationMap, BaseFunction>? ScopeConfiguration { get; set; }
            /// <summary>
            /// AutoInstallVMScanner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azureproviderconfiguration.html#cfn-inspectorv2-connector-azureproviderconfiguration-autoinstallvmscanner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AutoInstallVMScanner { get; set; }
            /// <summary>
            /// AzureRegions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azureproviderconfiguration.html#cfn-inspectorv2-connector-azureproviderconfiguration-azureregions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AzureRegions { get; set; }
        }

        public class AzureScopeConfigurationMap : Humidifier.Base.BaseSubResource, IHaveInspectorV2ConnectorTypesScopeConfigurationServerlessScanning, IHaveInspectorV2ConnectorTypesScopeConfigurationContainerImageScanning, IHaveInspectorV2ConnectorTypesScopeConfigurationVmScanning
        {
            /// <summary>
            /// ServerlessScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azurescopeconfigurationmap.html#cfn-inspectorv2-connector-azurescopeconfigurationmap-serverlessscanning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScopeConfiguration
            /// </summary>
            public Union<Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration, BaseFunction>? ServerlessScanning { get; set; }
            /// <summary>
            /// ContainerImageScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azurescopeconfigurationmap.html#cfn-inspectorv2-connector-azurescopeconfigurationmap-containerimagescanning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScopeConfiguration
            /// </summary>
            public Union<Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration, BaseFunction>? ContainerImageScanning { get; set; }
            /// <summary>
            /// VmScanning
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-azurescopeconfigurationmap.html#cfn-inspectorv2-connector-azurescopeconfigurationmap-vmscanning
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ScopeConfiguration
            /// </summary>
            public Union<Humidifier.InspectorV2.ConnectorTypes.ScopeConfiguration, BaseFunction>? VmScanning { get; set; }
        }

        public class ConnectorHealth : Humidifier.Base.BaseSubResource, IHaveLastCheckedAt, IHaveMessage, IHaveConnectorStatus
        {
            /// <summary>
            /// LastCheckedAt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-connectorhealth.html#cfn-inspectorv2-connector-connectorhealth-lastcheckedat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LastCheckedAt { get; set; }
            /// <summary>
            /// Message
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-connectorhealth.html#cfn-inspectorv2-connector-connectorhealth-message
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Message { get; set; }
            /// <summary>
            /// ConnectorStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-connectorhealth.html#cfn-inspectorv2-connector-connectorhealth-connectorstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectorStatus { get; set; }
        }

        public class ProviderConfiguration : Humidifier.Base.BaseSubResource, IHaveInspectorV2ConnectorTypesAzureProviderConfigurationAzure
        {
            /// <summary>
            /// Azure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-providerconfiguration.html#cfn-inspectorv2-connector-providerconfiguration-azure
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AzureProviderConfiguration
            /// </summary>
            public Union<Humidifier.InspectorV2.ConnectorTypes.AzureProviderConfiguration, BaseFunction>? Azure { get; set; }
        }

        public class ScopeConfiguration : Humidifier.Base.BaseSubResource, IHaveScopeType, IHaveStringListOfScopeValues, IHaveState, IHaveStateReason
        {
            /// <summary>
            /// ScopeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-scopeconfiguration.html#cfn-inspectorv2-connector-scopeconfiguration-scopetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ScopeType { get; set; }
            /// <summary>
            /// ScopeValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-scopeconfiguration.html#cfn-inspectorv2-connector-scopeconfiguration-scopevalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ScopeValues { get; set; }
            /// <summary>
            /// State
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-scopeconfiguration.html#cfn-inspectorv2-connector-scopeconfiguration-state
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? State { get; set; }
            /// <summary>
            /// StateReason
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-inspectorv2-connector-scopeconfiguration.html#cfn-inspectorv2-connector-scopeconfiguration-statereason
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StateReason { get; set; }
        }
    }
}