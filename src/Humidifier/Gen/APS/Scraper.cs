namespace Humidifier.APS
{
    using global::System.Collections.Generic;
    using ScraperTypes;

    public class Scraper : Humidifier.Base.BaseResource, IHaveTags, IHaveAlias
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
        public Humidifier.APS.ScraperTypes.ScrapeConfiguration ScrapeConfiguration { get; set; }

        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-destination
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Destination
        /// </summary>
        [Required]
        public Humidifier.APS.ScraperTypes.Destination Destination { get; set; }
        /// <summary>
        /// ScraperLoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-scraperloggingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ScraperLoggingConfiguration
        /// </summary>
        public Humidifier.APS.ScraperTypes.ScraperLoggingConfiguration ScraperLoggingConfiguration { get; set; }
        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-alias
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Alias { get; set; }
        /// <summary>
        /// RoleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-roleconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RoleConfiguration
        /// </summary>
        public Humidifier.APS.ScraperTypes.RoleConfiguration RoleConfiguration { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-source
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Source
        /// </summary>
        [Required]
        public Humidifier.APS.ScraperTypes.Source Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace ScraperTypes
    {
        public class AmpConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WorkspaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-ampconfiguration.html#cfn-aps-scraper-ampconfiguration-workspacearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WorkspaceArn { get; set; }
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
            public dynamic DatasetArn { get; set; }
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
            public dynamic LogGroupArn { get; set; }
        }

        public class ComponentConfig : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-componentconfig.html#cfn-aps-scraper-componentconfig-options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Options { get; set; }
        }

        public class Destination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudWatchConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-destination.html#cfn-aps-scraper-destination-cloudwatchconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchConfiguration
            /// </summary>
            public Humidifier.APS.ScraperTypes.CloudWatchConfiguration CloudWatchConfiguration { get; set; }
            /// <summary>
            /// AmpConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-destination.html#cfn-aps-scraper-destination-ampconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AmpConfiguration
            /// </summary>
            public Humidifier.APS.ScraperTypes.AmpConfiguration AmpConfiguration { get; set; }
        }

        public class EksConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds, IHaveClusterArn
        {
            /// <summary>
            /// ClusterArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-eksconfiguration.html#cfn-aps-scraper-eksconfiguration-clusterarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterArn { get; set; }
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-eksconfiguration.html#cfn-aps-scraper-eksconfiguration-securitygroupids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-eksconfiguration.html#cfn-aps-scraper-eksconfiguration-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }

        public class RoleConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TargetRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-roleconfiguration.html#cfn-aps-scraper-roleconfiguration-targetrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetRoleArn { get; set; }
            /// <summary>
            /// SourceRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-roleconfiguration.html#cfn-aps-scraper-roleconfiguration-sourcerolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceRoleArn { get; set; }
        }

        public class ScrapeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConfigurationBlob
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scrapeconfiguration.html#cfn-aps-scraper-scrapeconfiguration-configurationblob
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConfigurationBlob { get; set; }
        }

        public class ScraperComponent : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scrapercomponent.html#cfn-aps-scraper-scrapercomponent-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Config
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scrapercomponent.html#cfn-aps-scraper-scrapercomponent-config
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ComponentConfig
            /// </summary>
            public Humidifier.APS.ScraperTypes.ComponentConfig Config { get; set; }
        }

        public class ScraperLoggingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LoggingDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scraperloggingconfiguration.html#cfn-aps-scraper-scraperloggingconfiguration-loggingdestination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScraperLoggingDestination
            /// </summary>
            public Humidifier.APS.ScraperTypes.ScraperLoggingDestination LoggingDestination { get; set; }
            /// <summary>
            /// ScraperComponents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scraperloggingconfiguration.html#cfn-aps-scraper-scraperloggingconfiguration-scrapercomponents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScraperComponent
            /// </summary>
            public List<Humidifier.APS.ScraperTypes.ScraperComponent> ScraperComponents { get; set; }
        }

        public class ScraperLoggingDestination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CloudWatchLogs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scraperloggingdestination.html#cfn-aps-scraper-scraperloggingdestination-cloudwatchlogs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLogDestination
            /// </summary>
            public Humidifier.APS.ScraperTypes.CloudWatchLogDestination CloudWatchLogs { get; set; }
        }

        public class Source : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EksConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-source.html#cfn-aps-scraper-source-eksconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EksConfiguration
            /// </summary>
            public Humidifier.APS.ScraperTypes.EksConfiguration EksConfiguration { get; set; }
            /// <summary>
            /// VpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-source.html#cfn-aps-scraper-source-vpcconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VpcConfiguration
            /// </summary>
            public Humidifier.APS.ScraperTypes.VpcConfiguration VpcConfiguration { get; set; }
        }

        public class VpcConfiguration : Humidifier.Base.BaseSubResource, IHaveSecurityGroupIds, IHaveSubnetIds
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-vpcconfiguration.html#cfn-aps-scraper-vpcconfiguration-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-vpcconfiguration.html#cfn-aps-scraper-vpcconfiguration-subnetids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }
    }
}