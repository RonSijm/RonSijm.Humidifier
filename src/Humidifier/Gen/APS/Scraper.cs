namespace Humidifier.APS
{
    using System.Collections.Generic;
    using ScraperTypes;

    public class Scraper : Humidifier.Base.BaseResource, IHaveTags
    {
        public class Attributes
        {
            public static string ScraperId =  "ScraperId" ;
            public static string Arn =  "Arn" ;
            public static string RoleArn =  "RoleArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::APS::Scraper";
            }
        }

        /// <summary>
        /// ScrapeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-scrapeconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ScrapeConfiguration
        /// </summary>
        public ScraperTypes.ScrapeConfiguration ScrapeConfiguration { get; set; }
        /// <summary>
        /// Destination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-destination
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Destination
        /// </summary>
        public ScraperTypes.Destination Destination { get; set; }
        /// <summary>
        /// Alias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-alias
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Alias { get; set; }
        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-aps-scraper.html#cfn-aps-scraper-source
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Source
        /// </summary>
        public ScraperTypes.Source Source { get; set; }
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
            /// UpdateType: Immutable
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
            /// UpdateType: Immutable
            /// Type: AmpConfiguration
            /// </summary>
            public ScraperTypes.AmpConfiguration AmpConfiguration { get; set; }
        }

        public class EksConfiguration : Humidifier.Base.BaseSubResource
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

        public class ScrapeConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ConfigurationBlob
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-aps-scraper-scrapeconfiguration.html#cfn-aps-scraper-scrapeconfiguration-configurationblob
            /// Required: True
            /// UpdateType: Immutable
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
            public ScraperTypes.EksConfiguration EksConfiguration { get; set; }
        }
    }
}