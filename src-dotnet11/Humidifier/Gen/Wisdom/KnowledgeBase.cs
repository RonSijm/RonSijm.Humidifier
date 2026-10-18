namespace Humidifier.Wisdom
{
    using global::System.Collections.Generic;
    using KnowledgeBaseTypes;

    public class KnowledgeBase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveKnowledgeBaseType, IHaveWisdomKnowledgeBaseTypesSourceConfigurationSourceConfiguration, IHaveWisdomKnowledgeBaseTypesServerSideEncryptionConfigurationServerSideEncryptionConfiguration, IHaveWisdomKnowledgeBaseTypesVectorIngestionConfigurationVectorIngestionConfiguration, IHaveWisdomKnowledgeBaseTypesRenderingConfigurationRenderingConfiguration, IHaveName
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
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// KnowledgeBaseType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-knowledgebasetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KnowledgeBaseType { get; set; }
        /// <summary>
        /// SourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-sourceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SourceConfiguration
        /// </summary>
        public Union<Humidifier.Wisdom.KnowledgeBaseTypes.SourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-serversideencryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ServerSideEncryptionConfiguration
        /// </summary>
        public Union<Humidifier.Wisdom.KnowledgeBaseTypes.ServerSideEncryptionConfiguration, BaseFunction>? ServerSideEncryptionConfiguration { get; set; }
        /// <summary>
        /// VectorIngestionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-vectoringestionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VectorIngestionConfiguration
        /// </summary>
        public Union<Humidifier.Wisdom.KnowledgeBaseTypes.VectorIngestionConfiguration, BaseFunction>? VectorIngestionConfiguration { get; set; }
        /// <summary>
        /// RenderingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-renderingconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RenderingConfiguration
        /// </summary>
        public Union<Humidifier.Wisdom.KnowledgeBaseTypes.RenderingConfiguration, BaseFunction>? RenderingConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wisdom-knowledgebase.html#cfn-wisdom-knowledgebase-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace KnowledgeBaseTypes
    {
        public class AppIntegrationsConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfObjectFields, IHaveAppIntegrationArn
        {
            /// <summary>
            /// ObjectFields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-appintegrationsconfiguration.html#cfn-wisdom-knowledgebase-appintegrationsconfiguration-objectfields
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ObjectFields { get; set; }
            /// <summary>
            /// AppIntegrationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-appintegrationsconfiguration.html#cfn-wisdom-knowledgebase-appintegrationsconfiguration-appintegrationarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AppIntegrationArn { get; set; }
        }

        public class BedrockFoundationModelConfiguration : Humidifier.Base.BaseSubResource, IHaveModelArn, IHaveWisdomKnowledgeBaseTypesParsingPromptParsingPrompt
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-bedrockfoundationmodelconfiguration.html#cfn-wisdom-knowledgebase-bedrockfoundationmodelconfiguration-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelArn { get; set; }
            /// <summary>
            /// ParsingPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-bedrockfoundationmodelconfiguration.html#cfn-wisdom-knowledgebase-bedrockfoundationmodelconfiguration-parsingprompt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParsingPrompt
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingPrompt, BaseFunction>? ParsingPrompt { get; set; }
        }

        public class ChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveChunkingStrategy, IHaveWisdomKnowledgeBaseTypesFixedSizeChunkingConfigurationFixedSizeChunkingConfiguration, IHaveWisdomKnowledgeBaseTypesSemanticChunkingConfigurationSemanticChunkingConfiguration, IHaveWisdomKnowledgeBaseTypesHierarchicalChunkingConfigurationHierarchicalChunkingConfiguration
        {
            /// <summary>
            /// ChunkingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-chunkingconfiguration.html#cfn-wisdom-knowledgebase-chunkingconfiguration-chunkingstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChunkingStrategy { get; set; }
            /// <summary>
            /// FixedSizeChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-chunkingconfiguration.html#cfn-wisdom-knowledgebase-chunkingconfiguration-fixedsizechunkingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FixedSizeChunkingConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.FixedSizeChunkingConfiguration, BaseFunction>? FixedSizeChunkingConfiguration { get; set; }
            /// <summary>
            /// SemanticChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-chunkingconfiguration.html#cfn-wisdom-knowledgebase-chunkingconfiguration-semanticchunkingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SemanticChunkingConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.SemanticChunkingConfiguration, BaseFunction>? SemanticChunkingConfiguration { get; set; }
            /// <summary>
            /// HierarchicalChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-chunkingconfiguration.html#cfn-wisdom-knowledgebase-chunkingconfiguration-hierarchicalchunkingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HierarchicalChunkingConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingConfiguration, BaseFunction>? HierarchicalChunkingConfiguration { get; set; }
        }

        public class CrawlerLimits : Humidifier.Base.BaseSubResource, IHaveRateLimit_Double
        {
            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-crawlerlimits.html#cfn-wisdom-knowledgebase-crawlerlimits-ratelimit
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? RateLimit { get; set; }
        }

        public class FixedSizeChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveOverlapPercentage_Double, IHaveMaxTokens_Double
        {
            /// <summary>
            /// OverlapPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-fixedsizechunkingconfiguration.html#cfn-wisdom-knowledgebase-fixedsizechunkingconfiguration-overlappercentage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? OverlapPercentage { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-fixedsizechunkingconfiguration.html#cfn-wisdom-knowledgebase-fixedsizechunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTokens { get; set; }
        }

        public class HierarchicalChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveOverlapTokens_Double, IHaveListOfWisdomKnowledgeBaseTypesHierarchicalChunkingLevelConfigurationLevelConfigurations
        {
            /// <summary>
            /// OverlapTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-hierarchicalchunkingconfiguration.html#cfn-wisdom-knowledgebase-hierarchicalchunkingconfiguration-overlaptokens
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? OverlapTokens { get; set; }
            /// <summary>
            /// LevelConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-hierarchicalchunkingconfiguration.html#cfn-wisdom-knowledgebase-hierarchicalchunkingconfiguration-levelconfigurations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: HierarchicalChunkingLevelConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingLevelConfiguration>, IReadOnlyList<Union<Humidifier.Wisdom.KnowledgeBaseTypes.HierarchicalChunkingLevelConfiguration, BaseFunction>>, BaseFunction>? LevelConfigurations { get; set; }
        }

        public class HierarchicalChunkingLevelConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens_Double
        {
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-hierarchicalchunkinglevelconfiguration.html#cfn-wisdom-knowledgebase-hierarchicalchunkinglevelconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTokens { get; set; }
        }

        public class ManagedSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveWisdomKnowledgeBaseTypesWebCrawlerConfigurationWebCrawlerConfiguration
        {
            /// <summary>
            /// WebCrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-managedsourceconfiguration.html#cfn-wisdom-knowledgebase-managedsourceconfiguration-webcrawlerconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: WebCrawlerConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.WebCrawlerConfiguration, BaseFunction>? WebCrawlerConfiguration { get; set; }
        }

        public class ParsingConfiguration : Humidifier.Base.BaseSubResource, IHaveWisdomKnowledgeBaseTypesBedrockFoundationModelConfigurationBedrockFoundationModelConfiguration, IHaveParsingStrategy
        {
            /// <summary>
            /// BedrockFoundationModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-parsingconfiguration.html#cfn-wisdom-knowledgebase-parsingconfiguration-bedrockfoundationmodelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockFoundationModelConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.BedrockFoundationModelConfiguration, BaseFunction>? BedrockFoundationModelConfiguration { get; set; }
            /// <summary>
            /// ParsingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-parsingconfiguration.html#cfn-wisdom-knowledgebase-parsingconfiguration-parsingstrategy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParsingStrategy { get; set; }
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
            public Union<string, BaseFunction>? ParsingPromptText { get; set; }
        }

        public class RenderingConfiguration : Humidifier.Base.BaseSubResource, IHaveTemplateUri
        {
            /// <summary>
            /// TemplateUri
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-renderingconfiguration.html#cfn-wisdom-knowledgebase-renderingconfiguration-templateuri
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TemplateUri { get; set; }
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
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class SemanticChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveBufferSize_Double, IHaveMaxTokens_Double, IHaveBreakpointPercentileThreshold_Double
        {
            /// <summary>
            /// BufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-semanticchunkingconfiguration.html#cfn-wisdom-knowledgebase-semanticchunkingconfiguration-buffersize
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BufferSize { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-semanticchunkingconfiguration.html#cfn-wisdom-knowledgebase-semanticchunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// BreakpointPercentileThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-semanticchunkingconfiguration.html#cfn-wisdom-knowledgebase-semanticchunkingconfiguration-breakpointpercentilethreshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public Union<double, BaseFunction>? BreakpointPercentileThreshold { get; set; }
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
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
        }

        public class SourceConfiguration : Humidifier.Base.BaseSubResource, IHaveWisdomKnowledgeBaseTypesAppIntegrationsConfigurationAppIntegrations, IHaveWisdomKnowledgeBaseTypesManagedSourceConfigurationManagedSourceConfiguration
        {
            /// <summary>
            /// AppIntegrations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-sourceconfiguration.html#cfn-wisdom-knowledgebase-sourceconfiguration-appintegrations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AppIntegrationsConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.AppIntegrationsConfiguration, BaseFunction>? AppIntegrations { get; set; }
            /// <summary>
            /// ManagedSourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-sourceconfiguration.html#cfn-wisdom-knowledgebase-sourceconfiguration-managedsourceconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ManagedSourceConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.ManagedSourceConfiguration, BaseFunction>? ManagedSourceConfiguration { get; set; }
        }

        public class UrlConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfWisdomKnowledgeBaseTypesSeedUrlSeedUrls
        {
            /// <summary>
            /// SeedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-urlconfiguration.html#cfn-wisdom-knowledgebase-urlconfiguration-seedurls
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SeedUrl
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Wisdom.KnowledgeBaseTypes.SeedUrl>, IReadOnlyList<Union<Humidifier.Wisdom.KnowledgeBaseTypes.SeedUrl, BaseFunction>>, BaseFunction>? SeedUrls { get; set; }
        }

        public class VectorIngestionConfiguration : Humidifier.Base.BaseSubResource, IHaveWisdomKnowledgeBaseTypesParsingConfigurationParsingConfiguration, IHaveWisdomKnowledgeBaseTypesChunkingConfigurationChunkingConfiguration
        {
            /// <summary>
            /// ParsingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-vectoringestionconfiguration.html#cfn-wisdom-knowledgebase-vectoringestionconfiguration-parsingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParsingConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.ParsingConfiguration, BaseFunction>? ParsingConfiguration { get; set; }
            /// <summary>
            /// ChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-vectoringestionconfiguration.html#cfn-wisdom-knowledgebase-vectoringestionconfiguration-chunkingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ChunkingConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.ChunkingConfiguration, BaseFunction>? ChunkingConfiguration { get; set; }
        }

        public class WebCrawlerConfiguration : Humidifier.Base.BaseSubResource, IHaveWisdomKnowledgeBaseTypesUrlConfigurationUrlConfiguration, IHaveStringListOfInclusionFilters, IHaveWisdomKnowledgeBaseTypesCrawlerLimitsCrawlerLimits, IHaveStringListOfExclusionFilters, IHaveScope
        {
            /// <summary>
            /// UrlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-urlconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: UrlConfiguration
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.UrlConfiguration, BaseFunction>? UrlConfiguration { get; set; }
            /// <summary>
            /// InclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-inclusionfilters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InclusionFilters { get; set; }
            /// <summary>
            /// CrawlerLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-crawlerlimits
            /// Required: False
            /// UpdateType: Immutable
            /// Type: CrawlerLimits
            /// </summary>
            public Union<Humidifier.Wisdom.KnowledgeBaseTypes.CrawlerLimits, BaseFunction>? CrawlerLimits { get; set; }
            /// <summary>
            /// ExclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-exclusionfilters
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExclusionFilters { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wisdom-knowledgebase-webcrawlerconfiguration.html#cfn-wisdom-knowledgebase-webcrawlerconfiguration-scope
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
        }
    }
}