namespace Humidifier.ObservabilityAdmin
{
    using global::System.Collections.Generic;
    using OrganizationCentralizationRuleTypes;

    public class OrganizationCentralizationRule : Humidifier.Base.BaseResource, IHaveTags, IHaveObservabilityAdminOrganizationCentralizationRuleTypesCentralizationRuleRule, IHaveRuleName
    {
        public class Attributes
        {
            public static string RuleArn =  "RuleArn" ;
        }

        public override string AWSTypeName { get => AWS.ObservabilityAdmin.OrganizationCentralizationRule; }

        /// <summary>
        /// Rule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-organizationcentralizationrule.html#cfn-observabilityadmin-organizationcentralizationrule-rule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CentralizationRule
        /// </summary>
        [Required]
        public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRule, BaseFunction>? Rule { get; set; }

        /// <summary>
        /// RuleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-organizationcentralizationrule.html#cfn-observabilityadmin-organizationcentralizationrule-rulename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RuleName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-observabilityadmin-organizationcentralizationrule.html#cfn-observabilityadmin-organizationcentralizationrule-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace OrganizationCentralizationRuleTypes
    {
        public class CentralizationRule : Humidifier.Base.BaseSubResource, IHaveObservabilityAdminOrganizationCentralizationRuleTypesCentralizationRuleDestinationDestination, IHaveObservabilityAdminOrganizationCentralizationRuleTypesCentralizationRuleSourceSource
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationrule.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationrule-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CentralizationRuleDestination
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRuleDestination, BaseFunction>? Destination { get; set; }
            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationrule.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationrule-source
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CentralizationRuleSource
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.CentralizationRuleSource, BaseFunction>? Source { get; set; }
        }

        public class CentralizationRuleDestination : Humidifier.Base.BaseSubResource, IHaveAccount, IHaveObservabilityAdminOrganizationCentralizationRuleTypesDestinationLogsConfigurationDestinationLogsConfiguration, IHaveRegion, IHaveObservabilityAdminOrganizationCentralizationRuleTypesDestinationMetricsConfigurationDestinationMetricsConfiguration
        {
            /// <summary>
            /// Account
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationruledestination.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationruledestination-account
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Account { get; set; }
            /// <summary>
            /// DestinationLogsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationruledestination.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationruledestination-destinationlogsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DestinationLogsConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.DestinationLogsConfiguration, BaseFunction>? DestinationLogsConfiguration { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationruledestination.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationruledestination-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// DestinationMetricsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationruledestination.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationruledestination-destinationmetricsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DestinationMetricsConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.DestinationMetricsConfiguration, BaseFunction>? DestinationMetricsConfiguration { get; set; }
        }

        public class CentralizationRuleSource : Humidifier.Base.BaseSubResource, IHaveScope, IHaveObservabilityAdminOrganizationCentralizationRuleTypesSourceMetricsConfigurationSourceMetricsConfiguration, IHaveObservabilityAdminOrganizationCentralizationRuleTypesSourceLogsConfigurationSourceLogsConfiguration, IHaveStringListOfRegions
        {
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationrulesource.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationrulesource-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// SourceMetricsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationrulesource.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationrulesource-sourcemetricsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceMetricsConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceMetricsConfiguration, BaseFunction>? SourceMetricsConfiguration { get; set; }
            /// <summary>
            /// SourceLogsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationrulesource.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationrulesource-sourcelogsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SourceLogsConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.SourceLogsConfiguration, BaseFunction>? SourceLogsConfiguration { get; set; }
            /// <summary>
            /// Regions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-centralizationrulesource.html#cfn-observabilityadmin-organizationcentralizationrule-centralizationrulesource-regions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Regions { get; set; }
        }

        public class DestinationLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveObservabilityAdminOrganizationCentralizationRuleTypesLogGroupNameConfigurationLogGroupNameConfiguration, IHaveObservabilityAdminOrganizationCentralizationRuleTypesLogsEncryptionConfigurationLogsEncryptionConfiguration, IHaveObservabilityAdminOrganizationCentralizationRuleTypesTagPropagationConfigurationTagPropagationConfiguration, IHaveObservabilityAdminOrganizationCentralizationRuleTypesLogsBackupConfigurationBackupConfiguration
        {
            /// <summary>
            /// LogGroupNameConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-destinationlogsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-destinationlogsconfiguration-loggroupnameconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogGroupNameConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogGroupNameConfiguration, BaseFunction>? LogGroupNameConfiguration { get; set; }
            /// <summary>
            /// LogsEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-destinationlogsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-destinationlogsconfiguration-logsencryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogsEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsEncryptionConfiguration, BaseFunction>? LogsEncryptionConfiguration { get; set; }
            /// <summary>
            /// TagPropagationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-destinationlogsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-destinationlogsconfiguration-tagpropagationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TagPropagationConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.TagPropagationConfiguration, BaseFunction>? TagPropagationConfiguration { get; set; }
            /// <summary>
            /// BackupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-destinationlogsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-destinationlogsconfiguration-backupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LogsBackupConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.LogsBackupConfiguration, BaseFunction>? BackupConfiguration { get; set; }
        }

        public class DestinationMetricsConfiguration : Humidifier.Base.BaseSubResource, IHaveObservabilityAdminOrganizationCentralizationRuleTypesMetricsBackupConfigurationBackupConfiguration
        {
            /// <summary>
            /// BackupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-destinationmetricsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-destinationmetricsconfiguration-backupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MetricsBackupConfiguration
            /// </summary>
            public Union<Humidifier.ObservabilityAdmin.OrganizationCentralizationRuleTypes.MetricsBackupConfiguration, BaseFunction>? BackupConfiguration { get; set; }
        }

        public class LogGroupNameConfiguration : Humidifier.Base.BaseSubResource, IHaveLogGroupNamePattern
        {
            /// <summary>
            /// LogGroupNamePattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-loggroupnameconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-loggroupnameconfiguration-loggroupnamepattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupNamePattern { get; set; }
        }

        public class LogsBackupConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveRegion
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-logsbackupconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-logsbackupconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-logsbackupconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-logsbackupconfiguration-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class LogsEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveEncryptionScope, IHaveEncryptionStrategy, IHaveEncryptionConflictResolutionStrategy
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-logsencryptionconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-logsencryptionconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// EncryptionScope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-logsencryptionconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-logsencryptionconfiguration-encryptionscope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionScope { get; set; }
            /// <summary>
            /// EncryptionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-logsencryptionconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-logsencryptionconfiguration-encryptionstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionStrategy { get; set; }
            /// <summary>
            /// EncryptionConflictResolutionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-logsencryptionconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-logsencryptionconfiguration-encryptionconflictresolutionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionConflictResolutionStrategy { get; set; }
        }

        public class MetricsBackupConfiguration : Humidifier.Base.BaseSubResource, IHaveRegion
        {
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-metricsbackupconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-metricsbackupconfiguration-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
        }

        public class SourceLogsConfiguration : Humidifier.Base.BaseSubResource, IHaveEncryptedLogGroupStrategy, IHaveDataSourceSelectionCriteria, IHaveLogGroupSelectionCriteria
        {
            /// <summary>
            /// EncryptedLogGroupStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-sourcelogsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-sourcelogsconfiguration-encryptedloggroupstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptedLogGroupStrategy { get; set; }
            /// <summary>
            /// DataSourceSelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-sourcelogsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-sourcelogsconfiguration-datasourceselectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataSourceSelectionCriteria { get; set; }
            /// <summary>
            /// LogGroupSelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-sourcelogsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-sourcelogsconfiguration-loggroupselectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupSelectionCriteria { get; set; }
        }

        public class SourceMetricsConfiguration : Humidifier.Base.BaseSubResource, IHaveMetricsSelectionCriteria
        {
            /// <summary>
            /// MetricsSelectionCriteria
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-sourcemetricsconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-sourcemetricsconfiguration-metricsselectioncriteria
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetricsSelectionCriteria { get; set; }
        }

        public class TagPropagationConfiguration : Humidifier.Base.BaseSubResource, IHaveTagConflictResolutionStrategy, IHaveDestinationRoleArn
        {
            /// <summary>
            /// TagConflictResolutionStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-tagpropagationconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-tagpropagationconfiguration-tagconflictresolutionstrategy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TagConflictResolutionStrategy { get; set; }
            /// <summary>
            /// DestinationRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-observabilityadmin-organizationcentralizationrule-tagpropagationconfiguration.html#cfn-observabilityadmin-organizationcentralizationrule-tagpropagationconfiguration-destinationrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationRoleArn { get; set; }
        }
    }
}