namespace Humidifier.Wisdom
{
    using System.Collections.Generic;
    using KnowledgeBaseTypes;

    public class KnowledgeBase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string KnowledgeBaseArn =  "KnowledgeBaseArn" ;
            public static string KnowledgeBaseId =  "KnowledgeBaseId" ;
        }

        public override string AWSTypeName { get => AWS.Wisdom.KnowledgeBase; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// KnowledgeBaseType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-knowledgebasetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KnowledgeBaseType { get; set; }
        /// <summary>
        /// SourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-sourceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SourceConfiguration
        /// </summary>
        public Humidifier.Wisdom.KnowledgeBaseTypes.SourceConfiguration SourceConfiguration { get; set; }
        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-serversideencryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ServerSideEncryptionConfiguration
        /// </summary>
        public Humidifier.Wisdom.KnowledgeBaseTypes.ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }
        /// <summary>
        /// VectorIngestionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-vectoringestionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VectorIngestionConfiguration
        /// </summary>
        public Humidifier.Wisdom.KnowledgeBaseTypes.VectorIngestionConfiguration VectorIngestionConfiguration { get; set; }
        /// <summary>
        /// RenderingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-renderingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RenderingConfiguration
        /// </summary>
        public Humidifier.Wisdom.KnowledgeBaseTypes.RenderingConfiguration RenderingConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace KnowledgeBaseTypes
    {
        public class AppIntegrationsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ObjectFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-appintegrationsconfiguration.html#cfn-wisdom-knowledgebase-appintegrationsconfiguration-objectfields
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ObjectFields { get; set; }
            /// <summary>
            /// AppIntegrationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-appintegrationsconfiguration.html#cfn-wisdom-knowledgebase-appintegrationsconfiguration-appintegrationarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AppIntegrationArn { get; set; }
        }

        public class BedrockFoundationModelConfiguration : Humidifier.Base.BaseSubResource, IHaveModelArn
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-bedrockfoundationmodelconfiguration.html#cfn-wisdom-knowledgebase-bedrockfoundationmodelconfiguration-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelArn { get; set; }
            /// <summary>
            /// ParsingPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-bedrockfoundationmodelconfiguration.html#cfn-wisdom-knowledgebase-bedrockfoundationmodelconfiguration-parsingprompt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParsingPrompt
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt ParsingPrompt { get; set; }
        }

        public class ChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveChunkingStrategy
        {
            /// <summary>
            /// ChunkingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-chunkingconfiguration.html#cfn-wisdom-knowledgebase-chunkingconfiguration-chunkingstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChunkingStrategy { get; set; }
            /// <summary>
            /// FixedSizeChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-chunkingconfiguration.html#cfn-wisdom-knowledgebase-chunkingconfiguration-fixedsizechunkingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FixedSizeChunkingConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.FixedSizeChunkingConfiguration FixedSizeChunkingConfiguration { get; set; }
            /// <summary>
            /// SemanticChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-chunkingconfiguration.html#cfn-wisdom-knowledgebase-chunkingconfiguration-semanticchunkingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticChunkingConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.SemanticChunkingConfiguration SemanticChunkingConfiguration { get; set; }
            /// <summary>
            /// HierarchicalChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-chunkingconfiguration.html#cfn-wisdom-knowledgebase-chunkingconfiguration-hierarchicalchunkingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HierarchicalChunkingConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingConfiguration HierarchicalChunkingConfiguration { get; set; }
        }

        public class CrawlerLimits : Humidifier.Base.BaseSubResource, IHaveRateLimit
        {
            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-crawlerlimits.html#cfn-wisdom-knowledgebase-crawlerlimits-ratelimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RateLimit { get; set; }
        }

        public class FixedSizeChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveOverlapPercentage
        {
            /// <summary>
            /// OverlapPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-fixedsizechunkingconfiguration.html#cfn-wisdom-knowledgebase-fixedsizechunkingconfiguration-overlappercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic OverlapPercentage { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-fixedsizechunkingconfiguration.html#cfn-wisdom-knowledgebase-fixedsizechunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxTokens { get; set; }
        }

        public class HierarchicalChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveOverlapTokens
        {
            /// <summary>
            /// OverlapTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-hierarchicalchunkingconfiguration.html#cfn-wisdom-knowledgebase-hierarchicalchunkingconfiguration-overlaptokens
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic OverlapTokens { get; set; }
            /// <summary>
            /// LevelConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-hierarchicalchunkingconfiguration.html#cfn-wisdom-knowledgebase-hierarchicalchunkingconfiguration-levelconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HierarchicalChunkingLevelConfiguration
            /// </summary>
            public List<Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingLevelConfiguration> LevelConfigurations { get; set; }
        }

        public class HierarchicalChunkingLevelConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens
        {
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-hierarchicalchunkinglevelconfiguration.html#cfn-wisdom-knowledgebase-hierarchicalchunkinglevelconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxTokens { get; set; }
        }

        public class ManagedSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// WebCrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-managedsourceconfiguration.html#cfn-wisdom-knowledgebase-managedsourceconfiguration-webcrawlerconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: WebCrawlerConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration WebCrawlerConfiguration { get; set; }
        }

        public class ParsingConfiguration : Humidifier.Base.BaseSubResource, IHaveParsingStrategy
        {
            /// <summary>
            /// BedrockFoundationModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-parsingconfiguration.html#cfn-wisdom-knowledgebase-parsingconfiguration-bedrockfoundationmodelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockFoundationModelConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration BedrockFoundationModelConfiguration { get; set; }
            /// <summary>
            /// ParsingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-parsingconfiguration.html#cfn-wisdom-knowledgebase-parsingconfiguration-parsingstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParsingStrategy { get; set; }
        }

        public class ParsingPrompt : Humidifier.Base.BaseSubResource, IHaveParsingPromptText
        {
            /// <summary>
            /// ParsingPromptText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-parsingprompt.html#cfn-wisdom-knowledgebase-parsingprompt-parsingprompttext
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParsingPromptText { get; set; }
        }

        public class RenderingConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TemplateUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-renderingconfiguration.html#cfn-wisdom-knowledgebase-renderingconfiguration-templateuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateUri { get; set; }
        }

        public class SeedUrl : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-seedurl.html#cfn-wisdom-knowledgebase-seedurl-url
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url { get; set; }
        }

        public class SemanticChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveBufferSize, IHaveBreakpointPercentileThreshold
        {
            /// <summary>
            /// BufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-semanticchunkingconfiguration.html#cfn-wisdom-knowledgebase-semanticchunkingconfiguration-buffersize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BufferSize { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-semanticchunkingconfiguration.html#cfn-wisdom-knowledgebase-semanticchunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// BreakpointPercentileThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-semanticchunkingconfiguration.html#cfn-wisdom-knowledgebase-semanticchunkingconfiguration-breakpointpercentilethreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BreakpointPercentileThreshold { get; set; }
        }

        public class ServerSideEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyId
        {
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-serversideencryptionconfiguration.html#cfn-wisdom-knowledgebase-serversideencryptionconfiguration-kmskeyid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// AppIntegrations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-sourceconfiguration.html#cfn-wisdom-knowledgebase-sourceconfiguration-appintegrations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AppIntegrationsConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration AppIntegrations { get; set; }
            /// <summary>
            /// ManagedSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-sourceconfiguration.html#cfn-wisdom-knowledgebase-sourceconfiguration-managedsourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ManagedSourceConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.ManagedSourceConfiguration ManagedSourceConfiguration { get; set; }
        }

        public class UrlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SeedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-urlconfiguration.html#cfn-wisdom-knowledgebase-urlconfiguration-seedurls
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SeedUrl
            /// </summary>
            public List<Humidifier.Wisdom.KnowledgeBaseTypes.SeedUrl> SeedUrls { get; set; }
        }

        public class VectorIngestionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParsingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-vectoringestionconfiguration.html#cfn-wisdom-knowledgebase-vectoringestionconfiguration-parsingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParsingConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.ParsingConfiguration ParsingConfiguration { get; set; }
            /// <summary>
            /// ChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-vectoringestionconfiguration.html#cfn-wisdom-knowledgebase-vectoringestionconfiguration-chunkingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChunkingConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.ChunkingConfiguration ChunkingConfiguration { get; set; }
        }

        public class WebCrawlerConfiguration : Humidifier.Base.BaseSubResource, IHaveScope, IHaveInclusionFilters, IHaveExclusionFilters
        {
            /// <summary>
            /// UrlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-urlconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: UrlConfiguration
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration UrlConfiguration { get; set; }
            /// <summary>
            /// InclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-inclusionfilters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionFilters { get; set; }
            /// <summary>
            /// CrawlerLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-crawlerlimits
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CrawlerLimits
            /// </summary>
            public Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits CrawlerLimits { get; set; }
            /// <summary>
            /// ExclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-exclusionfilters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionFilters { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-scope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
        }
    }
}