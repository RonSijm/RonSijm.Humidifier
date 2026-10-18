namespace Humidifier.APS
{
    using global::System.Collections.Generic;
    using ScraperTypes;

    public class Scraper : Humidifier.Base.BaseResource, IHaveTags, IHaveAPSScraperTypesScrapeConfigurationScrapeConfiguration, IHaveAPSScraperTypesDestinationDestination, IHaveAPSScraperTypesScraperLoggingConfigurationScraperLoggingConfiguration, IHaveAlias, IHaveAPSScraperTypesRoleConfigurationRoleConfiguration, IHaveAPSScraperTypesSourceSource
    {
        public class Attributes
        {
            public static string ScraperId =  "ScraperId" ;
            public static string Arn =  "Arn" ;
            public static string RoleArn =  "RoleArn" ;
        }

        public override string AWSTypeName { get => AWS.APS.Scraper; }

        /// <summary>
        /// ScrapeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-scrapeconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ScrapeConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.APS.ScraperTypes.ScrapeConfiguration, BaseFunction>? ScrapeConfiguration { get; set; }

        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-destination
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Destination
        /// </summary>
        [Required]
        public Union<Humidifier.APS.ScraperTypes.Destination, BaseFunction>? Destination { get; set; }
        /// <summary>
        /// ScraperLoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-scraperloggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScraperLoggingConfiguration
        /// </summary>
        public Union<Humidifier.APS.ScraperTypes.ScraperLoggingConfiguration, BaseFunction>? ScraperLoggingConfiguration { get; set; }
        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-alias
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Alias { get; set; }
        /// <summary>
        /// RoleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-roleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RoleConfiguration
        /// </summary>
        public Union<Humidifier.APS.ScraperTypes.RoleConfiguration, BaseFunction>? RoleConfiguration { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-source
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Source
        /// </summary>
        [Required]
        public Union<Humidifier.APS.ScraperTypes.Source, BaseFunction>? Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace ScraperTypes
    {
        public class AmpConfiguration : Humidifier.Base.BaseSubResource, IHaveWorkspaceArn
        {
            /// <summary>
            /// WorkspaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-ampconfiguration.html#cfn-aps-scraper-ampconfiguration-workspacearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkspaceArn { get; set; }
        }

        public class CloudWatchConfiguration : Humidifier.Base.BaseSubResource, IHaveDatasetArn
        {
            /// <summary>
            /// DatasetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-cloudwatchconfiguration.html#cfn-aps-scraper-cloudwatchconfiguration-datasetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatasetArn { get; set; }
        }

        public class CloudWatchLogDestination : Humidifier.Base.BaseSubResource, IHaveLogGroupArn
        {
            /// <summary>
            /// LogGroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-cloudwatchlogdestination.html#cfn-aps-scraper-cloudwatchlogdestination-loggrouparn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogGroupArn { get; set; }
        }

        public class ComponentConfig : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfOptions
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-componentconfig.html#cfn-aps-scraper-componentconfig-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Options { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource, IHaveAPSScraperTypesCloudWatchConfigurationCloudWatchConfiguration, IHaveAPSScraperTypesAmpConfigurationAmpConfiguration
        {
            /// <summary>
            /// CloudWatchConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-destination.html#cfn-aps-scraper-destination-cloudwatchconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchConfiguration
            /// </summary>
            public Union<Humidifier.APS.ScraperTypes.CloudWatchConfiguration, BaseFunction>? CloudWatchConfiguration { get; set; }
            /// <summary>
            /// AmpConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-destination.html#cfn-aps-scraper-destination-ampconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmpConfiguration
            /// </summary>
            public Union<Humidifier.APS.ScraperTypes.AmpConfiguration, BaseFunction>? AmpConfiguration { get; set; }
        }

        public class EksConfiguration : Humidifier.Base.BaseSubResource, IHaveClusterArn, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-eksconfiguration.html#cfn-aps-scraper-eksconfiguration-clusterarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterArn { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-eksconfiguration.html#cfn-aps-scraper-eksconfiguration-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-eksconfiguration.html#cfn-aps-scraper-eksconfiguration-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }

        public class RoleConfiguration : Humidifier.Base.BaseSubResource, IHaveTargetRoleArn, IHaveSourceRoleArn
        {
            /// <summary>
            /// TargetRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-roleconfiguration.html#cfn-aps-scraper-roleconfiguration-targetrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TargetRoleArn { get; set; }
            /// <summary>
            /// SourceRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-roleconfiguration.html#cfn-aps-scraper-roleconfiguration-sourcerolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceRoleArn { get; set; }
        }

        public class ScrapeConfiguration : Humidifier.Base.BaseSubResource, IHaveConfigurationBlob
        {
            /// <summary>
            /// ConfigurationBlob
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scrapeconfiguration.html#cfn-aps-scraper-scrapeconfiguration-configurationblob
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConfigurationBlob { get; set; }
        }

        public class ScraperComponent : Humidifier.Base.BaseSubResource, IHaveType, IHaveAPSScraperTypesComponentConfigConfig
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scrapercomponent.html#cfn-aps-scraper-scrapercomponent-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scrapercomponent.html#cfn-aps-scraper-scrapercomponent-config
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentConfig
            /// </summary>
            public Union<Humidifier.APS.ScraperTypes.ComponentConfig, BaseFunction>? Config { get; set; }
        }

        public class ScraperLoggingConfiguration : Humidifier.Base.BaseSubResource, IHaveAPSScraperTypesScraperLoggingDestinationLoggingDestination, IHaveListOfAPSScraperTypesScraperComponentScraperComponents
        {
            /// <summary>
            /// LoggingDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scraperloggingconfiguration.html#cfn-aps-scraper-scraperloggingconfiguration-loggingdestination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScraperLoggingDestination
            /// </summary>
            public Union<Humidifier.APS.ScraperTypes.ScraperLoggingDestination, BaseFunction>? LoggingDestination { get; set; }
            /// <summary>
            /// ScraperComponents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scraperloggingconfiguration.html#cfn-aps-scraper-scraperloggingconfiguration-scrapercomponents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScraperComponent
            /// </summary>
            public Union<IReadOnlyList<Humidifier.APS.ScraperTypes.ScraperComponent>, IReadOnlyList<Union<Humidifier.APS.ScraperTypes.ScraperComponent, BaseFunction>>, BaseFunction>? ScraperComponents { get; set; }
        }

        public class ScraperLoggingDestination : Humidifier.Base.BaseSubResource, IHaveAPSScraperTypesCloudWatchLogDestinationCloudWatchLogs
        {
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scraperloggingdestination.html#cfn-aps-scraper-scraperloggingdestination-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogDestination
            /// </summary>
            public Union<Humidifier.APS.ScraperTypes.CloudWatchLogDestination, BaseFunction>? CloudWatchLogs { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource, IHaveAPSScraperTypesEksConfigurationEksConfiguration, IHaveAPSScraperTypesVpcConfigurationVpcConfiguration
        {
            /// <summary>
            /// EksConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-source.html#cfn-aps-scraper-source-eksconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EksConfiguration
            /// </summary>
            public Union<Humidifier.APS.ScraperTypes.EksConfiguration, BaseFunction>? EksConfiguration { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-source.html#cfn-aps-scraper-source-vpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfiguration
            /// </summary>
            public Union<Humidifier.APS.ScraperTypes.VpcConfiguration, BaseFunction>? VpcConfiguration { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSecurityGroupIds, IHaveStringListOfSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-vpcconfiguration.html#cfn-aps-scraper-vpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-vpcconfiguration.html#cfn-aps-scraper-vpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubnetIds { get; set; }
        }
    }
}