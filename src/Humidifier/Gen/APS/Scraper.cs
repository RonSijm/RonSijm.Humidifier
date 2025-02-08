namespace Humidifier.APS
{
    using System.Collections.Generic;
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
        public List<Tag> Tags { get; set; }
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

        public class Destination : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AmpConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-destination.html#cfn-aps-scraper-destination-ampconfiguration
            /// Required: True
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

        public class Source : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EksConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-source.html#cfn-aps-scraper-source-eksconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: EksConfiguration
            /// </summary>
            public Humidifier.APS.ScraperTypes.EksConfiguration EksConfiguration { get; set; }
        }
    }
}