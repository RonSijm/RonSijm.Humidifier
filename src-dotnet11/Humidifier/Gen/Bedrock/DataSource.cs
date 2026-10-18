namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDataDeletionPolicy, IHaveDescription, IHaveKnowledgeBaseId, IHaveBedrockDataSourceTypesServerSideEncryptionConfigurationServerSideEncryptionConfiguration, IHaveBedrockDataSourceTypesVectorIngestionConfigurationVectorIngestionConfiguration, IHaveBedrockDataSourceTypesDataSourceConfigurationDataSourceConfiguration, IHaveName
    {
        public class Attributes
        {
            public static string CreatedAt =  "CreatedAt" ;
            public static string DataSourceStatus =  "DataSourceStatus" ;
            public static string UpdatedAt =  "UpdatedAt" ;
            public static string FailureReasons =  "FailureReasons" ;
            public static string DataSourceId =  "DataSourceId" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.DataSource; }
        /// <summary>
        /// DataDeletionPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-datadeletionpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DataDeletionPolicy { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? KnowledgeBaseId { get; set; }
        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-serversideencryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServerSideEncryptionConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.DataSourceTypes.ServerSideEncryptionConfiguration, BaseFunction>? ServerSideEncryptionConfiguration { get; set; }
        /// <summary>
        /// VectorIngestionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-vectoringestionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VectorIngestionConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.DataSourceTypes.VectorIngestionConfiguration, BaseFunction>? VectorIngestionConfiguration { get; set; }

        /// <summary>
        /// DataSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-datasourceconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataSourceConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Bedrock.DataSourceTypes.DataSourceConfiguration, BaseFunction>? DataSourceConfiguration { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataSourceTypes
    {
        public class AudioExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveAudioExtractionStatus
        {
            /// <summary>
            /// AudioExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-audioextractionconfiguration.html#cfn-bedrock-datasource-audioextractionconfiguration-audioextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AudioExtractionStatus { get; set; }
        }

        public class BedrockDataAutomationConfiguration : Humidifier.Base.BaseSubResource, IHaveParsingModality
        {
            /// <summary>
            /// ParsingModality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockdataautomationconfiguration.html#cfn-bedrock-datasource-bedrockdataautomationconfiguration-parsingmodality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParsingModality { get; set; }
        }

        public class BedrockFoundationModelConfiguration : Humidifier.Base.BaseSubResource, IHaveModelArn, IHaveParsingModality, IHaveBedrockDataSourceTypesParsingPromptParsingPrompt
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockfoundationmodelconfiguration.html#cfn-bedrock-datasource-bedrockfoundationmodelconfiguration-modelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelArn { get; set; }
            /// <summary>
            /// ParsingModality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockfoundationmodelconfiguration.html#cfn-bedrock-datasource-bedrockfoundationmodelconfiguration-parsingmodality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParsingModality { get; set; }
            /// <summary>
            /// ParsingPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockfoundationmodelconfiguration.html#cfn-bedrock-datasource-bedrockfoundationmodelconfiguration-parsingprompt
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParsingPrompt
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ParsingPrompt, BaseFunction>? ParsingPrompt { get; set; }
        }

        public class BedrockFoundationModelContextEnrichmentConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesEnrichmentStrategyConfigurationEnrichmentStrategyConfiguration, IHaveModelArn
        {
            /// <summary>
            /// EnrichmentStrategyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockfoundationmodelcontextenrichmentconfiguration.html#cfn-bedrock-datasource-bedrockfoundationmodelcontextenrichmentconfiguration-enrichmentstrategyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: EnrichmentStrategyConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.EnrichmentStrategyConfiguration, BaseFunction>? EnrichmentStrategyConfiguration { get; set; }
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockfoundationmodelcontextenrichmentconfiguration.html#cfn-bedrock-datasource-bedrockfoundationmodelcontextenrichmentconfiguration-modelarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ModelArn { get; set; }
        }

        public class ChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveChunkingStrategy, IHaveBedrockDataSourceTypesFixedSizeChunkingConfigurationFixedSizeChunkingConfiguration, IHaveBedrockDataSourceTypesSemanticChunkingConfigurationSemanticChunkingConfiguration, IHaveBedrockDataSourceTypesHierarchicalChunkingConfigurationHierarchicalChunkingConfiguration
        {
            /// <summary>
            /// ChunkingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-chunkingstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChunkingStrategy { get; set; }
            /// <summary>
            /// FixedSizeChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-fixedsizechunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FixedSizeChunkingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.FixedSizeChunkingConfiguration, BaseFunction>? FixedSizeChunkingConfiguration { get; set; }
            /// <summary>
            /// SemanticChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-semanticchunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SemanticChunkingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.SemanticChunkingConfiguration, BaseFunction>? SemanticChunkingConfiguration { get; set; }
            /// <summary>
            /// HierarchicalChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-hierarchicalchunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HierarchicalChunkingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingConfiguration, BaseFunction>? HierarchicalChunkingConfiguration { get; set; }
        }

        public class ConfluenceCrawlerConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesCrawlFilterConfigurationFilterConfiguration
        {
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencecrawlerconfiguration.html#cfn-bedrock-datasource-confluencecrawlerconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrawlFilterConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
        }

        public class ConfluenceDataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesConfluenceSourceConfigurationSourceConfiguration, IHaveBedrockDataSourceTypesConfluenceCrawlerConfigurationCrawlerConfiguration
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencedatasourceconfiguration.html#cfn-bedrock-datasource-confluencedatasourceconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConfluenceSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ConfluenceSourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
            /// <summary>
            /// CrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencedatasourceconfiguration.html#cfn-bedrock-datasource-confluencedatasourceconfiguration-crawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceCrawlerConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ConfluenceCrawlerConfiguration, BaseFunction>? CrawlerConfiguration { get; set; }
        }

        public class ConfluenceSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveHostUrl, IHaveHostType, IHaveAuthType, IHaveCredentialsSecretArn
        {
            /// <summary>
            /// HostUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencesourceconfiguration.html#cfn-bedrock-datasource-confluencesourceconfiguration-hosturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostUrl { get; set; }
            /// <summary>
            /// HostType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencesourceconfiguration.html#cfn-bedrock-datasource-confluencesourceconfiguration-hosttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostType { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencesourceconfiguration.html#cfn-bedrock-datasource-confluencesourceconfiguration-authtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthType { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencesourceconfiguration.html#cfn-bedrock-datasource-confluencesourceconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsSecretArn { get; set; }
        }

        public class ContextEnrichmentConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockDataSourceTypesBedrockFoundationModelContextEnrichmentConfigurationBedrockFoundationModelConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-contextenrichmentconfiguration.html#cfn-bedrock-datasource-contextenrichmentconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// BedrockFoundationModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-contextenrichmentconfiguration.html#cfn-bedrock-datasource-contextenrichmentconfiguration-bedrockfoundationmodelconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BedrockFoundationModelContextEnrichmentConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelContextEnrichmentConfiguration, BaseFunction>? BedrockFoundationModelConfiguration { get; set; }
        }

        public class CrawlFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesPatternObjectFilterConfigurationPatternObjectFilter, IHaveType
        {
            /// <summary>
            /// PatternObjectFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-crawlfilterconfiguration.html#cfn-bedrock-datasource-crawlfilterconfiguration-patternobjectfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PatternObjectFilterConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration, BaseFunction>? PatternObjectFilter { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-crawlfilterconfiguration.html#cfn-bedrock-datasource-crawlfilterconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }

        public class CustomTransformationConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesIntermediateStorageIntermediateStorage, IHaveListOfBedrockDataSourceTypesTransformationTransformations
        {
            /// <summary>
            /// IntermediateStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-customtransformationconfiguration.html#cfn-bedrock-datasource-customtransformationconfiguration-intermediatestorage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntermediateStorage
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage, BaseFunction>? IntermediateStorage { get; set; }
            /// <summary>
            /// Transformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-customtransformationconfiguration.html#cfn-bedrock-datasource-customtransformationconfiguration-transformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Transformation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.DataSourceTypes.Transformation>, IReadOnlyList<Union<Humidifier.Bedrock.DataSourceTypes.Transformation, BaseFunction>>, BaseFunction>? Transformations { get; set; }
        }

        public class DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockDataSourceTypesS3DataSourceConfigurationS3Configuration, IHaveBedrockDataSourceTypesSalesforceDataSourceConfigurationSalesforceConfiguration, IHaveBedrockDataSourceTypesManagedKnowledgeBaseConnectorConfigurationManagedKnowledgeBaseConnectorConfiguration, IHaveBedrockDataSourceTypesConfluenceDataSourceConfigurationConfluenceConfiguration, IHaveBedrockDataSourceTypesSharePointDataSourceConfigurationSharePointConfiguration, IHaveBedrockDataSourceTypesWebDataSourceConfigurationWebConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-s3configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DataSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.S3DataSourceConfiguration, BaseFunction>? S3Configuration { get; set; }
            /// <summary>
            /// SalesforceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-salesforceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceDataSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.SalesforceDataSourceConfiguration, BaseFunction>? SalesforceConfiguration { get; set; }
            /// <summary>
            /// ManagedKnowledgeBaseConnectorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-managedknowledgebaseconnectorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ManagedKnowledgeBaseConnectorConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ManagedKnowledgeBaseConnectorConfiguration, BaseFunction>? ManagedKnowledgeBaseConnectorConfiguration { get; set; }
            /// <summary>
            /// ConfluenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-confluenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceDataSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ConfluenceDataSourceConfiguration, BaseFunction>? ConfluenceConfiguration { get; set; }
            /// <summary>
            /// SharePointConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-sharepointconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharePointDataSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.SharePointDataSourceConfiguration, BaseFunction>? SharePointConfiguration { get; set; }
            /// <summary>
            /// WebConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-webconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebDataSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.WebDataSourceConfiguration, BaseFunction>? WebConfiguration { get; set; }
        }

        public class DayOfMonth : Humidifier.Base.BaseSubResource, IHaveLastDayOfMonth_Json, IHaveDayNumber_Integer
        {
            /// <summary>
            /// LastDayOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-dayofmonth.html#cfn-bedrock-datasource-dayofmonth-lastdayofmonth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? LastDayOfMonth { get; set; }
            /// <summary>
            /// DayNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-dayofmonth.html#cfn-bedrock-datasource-dayofmonth-daynumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DayNumber { get; set; }
        }

        public class DeletionProtectionConfiguration : Humidifier.Base.BaseSubResource, IHaveDeletionProtectionStatus, IHaveDeletionProtectionThreshold_Integer
        {
            /// <summary>
            /// DeletionProtectionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-deletionprotectionconfiguration.html#cfn-bedrock-datasource-deletionprotectionconfiguration-deletionprotectionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DeletionProtectionStatus { get; set; }
            /// <summary>
            /// DeletionProtectionThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-deletionprotectionconfiguration.html#cfn-bedrock-datasource-deletionprotectionconfiguration-deletionprotectionthreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DeletionProtectionThreshold { get; set; }
        }

        public class EnrichmentStrategyConfiguration : Humidifier.Base.BaseSubResource, IHaveMethod
        {
            /// <summary>
            /// Method
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-enrichmentstrategyconfiguration.html#cfn-bedrock-datasource-enrichmentstrategyconfiguration-method
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Method { get; set; }
        }

        public class FixedSizeChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveOverlapPercentage_Integer, IHaveMaxTokens_Integer
        {
            /// <summary>
            /// OverlapPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-fixedsizechunkingconfiguration.html#cfn-bedrock-datasource-fixedsizechunkingconfiguration-overlappercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OverlapPercentage { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-fixedsizechunkingconfiguration.html#cfn-bedrock-datasource-fixedsizechunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokens { get; set; }
        }

        public class HierarchicalChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveOverlapTokens_Integer, IHaveListOfBedrockDataSourceTypesHierarchicalChunkingLevelConfigurationLevelConfigurations
        {
            /// <summary>
            /// OverlapTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-hierarchicalchunkingconfiguration.html#cfn-bedrock-datasource-hierarchicalchunkingconfiguration-overlaptokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OverlapTokens { get; set; }
            /// <summary>
            /// LevelConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-hierarchicalchunkingconfiguration.html#cfn-bedrock-datasource-hierarchicalchunkingconfiguration-levelconfigurations
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HierarchicalChunkingLevelConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingLevelConfiguration>, IReadOnlyList<Union<Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingLevelConfiguration, BaseFunction>>, BaseFunction>? LevelConfigurations { get; set; }
        }

        public class HierarchicalChunkingLevelConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens_Integer
        {
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-hierarchicalchunkinglevelconfiguration.html#cfn-bedrock-datasource-hierarchicalchunkinglevelconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokens { get; set; }
        }

        public class ImageExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveImageExtractionStatus
        {
            /// <summary>
            /// ImageExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-imageextractionconfiguration.html#cfn-bedrock-datasource-imageextractionconfiguration-imageextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ImageExtractionStatus { get; set; }
        }

        public class IntermediateStorage : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesS3LocationS3Location
        {
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-intermediatestorage.html#cfn-bedrock-datasource-intermediatestorage-s3location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }

        public class ManagedKnowledgeBaseConnectorConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesSyncScheduleSyncSchedule, IHaveBedrockDataSourceTypesMediaExtractionConfigurationMediaExtractionConfiguration, IHaveConnectorParameters_Json, IHaveBedrockDataSourceTypesDeletionProtectionConfigurationDeletionProtectionConfiguration
        {
            /// <summary>
            /// SyncSchedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-managedknowledgebaseconnectorconfiguration.html#cfn-bedrock-datasource-managedknowledgebaseconnectorconfiguration-syncschedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SyncSchedule
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.SyncSchedule, BaseFunction>? SyncSchedule { get; set; }
            /// <summary>
            /// MediaExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-managedknowledgebaseconnectorconfiguration.html#cfn-bedrock-datasource-managedknowledgebaseconnectorconfiguration-mediaextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MediaExtractionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.MediaExtractionConfiguration, BaseFunction>? MediaExtractionConfiguration { get; set; }
            /// <summary>
            /// ConnectorParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-managedknowledgebaseconnectorconfiguration.html#cfn-bedrock-datasource-managedknowledgebaseconnectorconfiguration-connectorparameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ConnectorParameters { get; set; }
            /// <summary>
            /// DeletionProtectionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-managedknowledgebaseconnectorconfiguration.html#cfn-bedrock-datasource-managedknowledgebaseconnectorconfiguration-deletionprotectionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DeletionProtectionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.DeletionProtectionConfiguration, BaseFunction>? DeletionProtectionConfiguration { get; set; }
        }

        public class MediaExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesVideoExtractionConfigurationVideoExtractionConfiguration, IHaveBedrockDataSourceTypesAudioExtractionConfigurationAudioExtractionConfiguration, IHaveBedrockDataSourceTypesImageExtractionConfigurationImageExtractionConfiguration
        {
            /// <summary>
            /// VideoExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-mediaextractionconfiguration.html#cfn-bedrock-datasource-mediaextractionconfiguration-videoextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoExtractionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.VideoExtractionConfiguration, BaseFunction>? VideoExtractionConfiguration { get; set; }
            /// <summary>
            /// AudioExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-mediaextractionconfiguration.html#cfn-bedrock-datasource-mediaextractionconfiguration-audioextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioExtractionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.AudioExtractionConfiguration, BaseFunction>? AudioExtractionConfiguration { get; set; }
            /// <summary>
            /// ImageExtractionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-mediaextractionconfiguration.html#cfn-bedrock-datasource-mediaextractionconfiguration-imageextractionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ImageExtractionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ImageExtractionConfiguration, BaseFunction>? ImageExtractionConfiguration { get; set; }
        }

        public class MonthlySchedule : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesDayOfMonthDayOfMonth
        {
            /// <summary>
            /// DayOfMonth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-monthlyschedule.html#cfn-bedrock-datasource-monthlyschedule-dayofmonth
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DayOfMonth
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.DayOfMonth, BaseFunction>? DayOfMonth { get; set; }
        }

        public class ParsingConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesBedrockDataAutomationConfigurationBedrockDataAutomationConfiguration, IHaveBedrockDataSourceTypesBedrockFoundationModelConfigurationBedrockFoundationModelConfiguration, IHaveParsingStrategy
        {
            /// <summary>
            /// BedrockDataAutomationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-parsingconfiguration.html#cfn-bedrock-datasource-parsingconfiguration-bedrockdataautomationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BedrockDataAutomationConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.BedrockDataAutomationConfiguration, BaseFunction>? BedrockDataAutomationConfiguration { get; set; }
            /// <summary>
            /// BedrockFoundationModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-parsingconfiguration.html#cfn-bedrock-datasource-parsingconfiguration-bedrockfoundationmodelconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BedrockFoundationModelConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration, BaseFunction>? BedrockFoundationModelConfiguration { get; set; }
            /// <summary>
            /// ParsingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-parsingconfiguration.html#cfn-bedrock-datasource-parsingconfiguration-parsingstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParsingStrategy { get; set; }
        }

        public class ParsingPrompt : Humidifier.Base.BaseSubResource, IHaveParsingPromptText
        {
            /// <summary>
            /// ParsingPromptText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-parsingprompt.html#cfn-bedrock-datasource-parsingprompt-parsingprompttext
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ParsingPromptText { get; set; }
        }

        public class PatternObjectFilter : Humidifier.Base.BaseSubResource, IHaveObjectType, IHaveStringListOfInclusionFilters, IHaveStringListOfExclusionFilters
        {
            /// <summary>
            /// ObjectType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-patternobjectfilter.html#cfn-bedrock-datasource-patternobjectfilter-objecttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectType { get; set; }
            /// <summary>
            /// InclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-patternobjectfilter.html#cfn-bedrock-datasource-patternobjectfilter-inclusionfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InclusionFilters { get; set; }
            /// <summary>
            /// ExclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-patternobjectfilter.html#cfn-bedrock-datasource-patternobjectfilter-exclusionfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExclusionFilters { get; set; }
        }

        public class PatternObjectFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockDataSourceTypesPatternObjectFilterFilters
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-patternobjectfilterconfiguration.html#cfn-bedrock-datasource-patternobjectfilterconfiguration-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PatternObjectFilter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilter>, IReadOnlyList<Union<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilter, BaseFunction>>, BaseFunction>? Filters { get; set; }
        }

        public class S3DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveBucketOwnerAccountId, IHaveStringListOfInclusionPrefixes
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketArn { get; set; }
            /// <summary>
            /// BucketOwnerAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-bucketowneraccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwnerAccountId { get; set; }
            /// <summary>
            /// InclusionPrefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-inclusionprefixes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InclusionPrefixes { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveURI
        {
            /// <summary>
            /// URI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3location.html#cfn-bedrock-datasource-s3location-uri
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? URI { get; set; }
        }

        public class SalesforceCrawlerConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesCrawlFilterConfigurationFilterConfiguration
        {
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcecrawlerconfiguration.html#cfn-bedrock-datasource-salesforcecrawlerconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrawlFilterConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
        }

        public class SalesforceDataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesSalesforceSourceConfigurationSourceConfiguration, IHaveBedrockDataSourceTypesSalesforceCrawlerConfigurationCrawlerConfiguration
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcedatasourceconfiguration.html#cfn-bedrock-datasource-salesforcedatasourceconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SalesforceSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.SalesforceSourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
            /// <summary>
            /// CrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcedatasourceconfiguration.html#cfn-bedrock-datasource-salesforcedatasourceconfiguration-crawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceCrawlerConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.SalesforceCrawlerConfiguration, BaseFunction>? CrawlerConfiguration { get; set; }
        }

        public class SalesforceSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveHostUrl, IHaveAuthType, IHaveCredentialsSecretArn
        {
            /// <summary>
            /// HostUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcesourceconfiguration.html#cfn-bedrock-datasource-salesforcesourceconfiguration-hosturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostUrl { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcesourceconfiguration.html#cfn-bedrock-datasource-salesforcesourceconfiguration-authtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthType { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcesourceconfiguration.html#cfn-bedrock-datasource-salesforcesourceconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsSecretArn { get; set; }
        }

        public class SeedUrl : Humidifier.Base.BaseSubResource, IHaveUrl
        {
            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-seedurl.html#cfn-bedrock-datasource-seedurl-url
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Url { get; set; }
        }

        public class SemanticChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveBufferSize_Integer, IHaveMaxTokens_Integer, IHaveBreakpointPercentileThreshold_Integer
        {
            /// <summary>
            /// BufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-semanticchunkingconfiguration.html#cfn-bedrock-datasource-semanticchunkingconfiguration-buffersize
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BufferSize { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-semanticchunkingconfiguration.html#cfn-bedrock-datasource-semanticchunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxTokens { get; set; }
            /// <summary>
            /// BreakpointPercentileThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-semanticchunkingconfiguration.html#cfn-bedrock-datasource-semanticchunkingconfiguration-breakpointpercentilethreshold
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? BreakpointPercentileThreshold { get; set; }
        }

        public class ServerSideEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-serversideencryptionconfiguration.html#cfn-bedrock-datasource-serversideencryptionconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class SharePointCrawlerConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesCrawlFilterConfigurationFilterConfiguration
        {
            /// <summary>
            /// FilterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointcrawlerconfiguration.html#cfn-bedrock-datasource-sharepointcrawlerconfiguration-filterconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CrawlFilterConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration, BaseFunction>? FilterConfiguration { get; set; }
        }

        public class SharePointDataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesSharePointSourceConfigurationSourceConfiguration, IHaveBedrockDataSourceTypesSharePointCrawlerConfigurationCrawlerConfiguration
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointdatasourceconfiguration.html#cfn-bedrock-datasource-sharepointdatasourceconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SharePointSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.SharePointSourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
            /// <summary>
            /// CrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointdatasourceconfiguration.html#cfn-bedrock-datasource-sharepointdatasourceconfiguration-crawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharePointCrawlerConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.SharePointCrawlerConfiguration, BaseFunction>? CrawlerConfiguration { get; set; }
        }

        public class SharePointSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfSiteUrls, IHaveHostType, IHaveTenantId, IHaveAuthType, IHaveCredentialsSecretArn, IHaveDomain
        {
            /// <summary>
            /// SiteUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-siteurls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SiteUrls { get; set; }
            /// <summary>
            /// HostType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-hosttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? HostType { get; set; }
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-tenantid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TenantId { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-authtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AuthType { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsSecretArn { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Domain { get; set; }
        }

        public class SyncSchedule : Humidifier.Base.BaseSubResource, IHaveDaily_Json, IHaveBedrockDataSourceTypesMonthlyScheduleMonthly, IHaveBedrockDataSourceTypesWeeklyScheduleWeekly
        {
            /// <summary>
            /// Daily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-syncschedule.html#cfn-bedrock-datasource-syncschedule-daily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Daily { get; set; }
            /// <summary>
            /// Monthly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-syncschedule.html#cfn-bedrock-datasource-syncschedule-monthly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MonthlySchedule
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.MonthlySchedule, BaseFunction>? Monthly { get; set; }
            /// <summary>
            /// Weekly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-syncschedule.html#cfn-bedrock-datasource-syncschedule-weekly
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WeeklySchedule
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.WeeklySchedule, BaseFunction>? Weekly { get; set; }
        }

        public class Transformation : Humidifier.Base.BaseSubResource, IHaveStepToApply, IHaveBedrockDataSourceTypesTransformationFunctionTransformationFunction
        {
            /// <summary>
            /// StepToApply
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-transformation.html#cfn-bedrock-datasource-transformation-steptoapply
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StepToApply { get; set; }
            /// <summary>
            /// TransformationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-transformation.html#cfn-bedrock-datasource-transformation-transformationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformationFunction
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.TransformationFunction, BaseFunction>? TransformationFunction { get; set; }
        }

        public class TransformationFunction : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesTransformationLambdaConfigurationTransformationLambdaConfiguration
        {
            /// <summary>
            /// TransformationLambdaConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-transformationfunction.html#cfn-bedrock-datasource-transformationfunction-transformationlambdaconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformationLambdaConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.TransformationLambdaConfiguration, BaseFunction>? TransformationLambdaConfiguration { get; set; }
        }

        public class TransformationLambdaConfiguration : Humidifier.Base.BaseSubResource, IHaveLambdaArn
        {
            /// <summary>
            /// LambdaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-transformationlambdaconfiguration.html#cfn-bedrock-datasource-transformationlambdaconfiguration-lambdaarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LambdaArn { get; set; }
        }

        public class UrlConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockDataSourceTypesSeedUrlSeedUrls
        {
            /// <summary>
            /// SeedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-urlconfiguration.html#cfn-bedrock-datasource-urlconfiguration-seedurls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SeedUrl
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.DataSourceTypes.SeedUrl>, IReadOnlyList<Union<Humidifier.Bedrock.DataSourceTypes.SeedUrl, BaseFunction>>, BaseFunction>? SeedUrls { get; set; }
        }

        public class VectorIngestionConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesParsingConfigurationParsingConfiguration, IHaveBedrockDataSourceTypesContextEnrichmentConfigurationContextEnrichmentConfiguration, IHaveBedrockDataSourceTypesCustomTransformationConfigurationCustomTransformationConfiguration, IHaveBedrockDataSourceTypesChunkingConfigurationChunkingConfiguration
        {
            /// <summary>
            /// ParsingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-vectoringestionconfiguration.html#cfn-bedrock-datasource-vectoringestionconfiguration-parsingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParsingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ParsingConfiguration, BaseFunction>? ParsingConfiguration { get; set; }
            /// <summary>
            /// ContextEnrichmentConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-vectoringestionconfiguration.html#cfn-bedrock-datasource-vectoringestionconfiguration-contextenrichmentconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContextEnrichmentConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ContextEnrichmentConfiguration, BaseFunction>? ContextEnrichmentConfiguration { get; set; }
            /// <summary>
            /// CustomTransformationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-vectoringestionconfiguration.html#cfn-bedrock-datasource-vectoringestionconfiguration-customtransformationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomTransformationConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.CustomTransformationConfiguration, BaseFunction>? CustomTransformationConfiguration { get; set; }
            /// <summary>
            /// ChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-vectoringestionconfiguration.html#cfn-bedrock-datasource-vectoringestionconfiguration-chunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ChunkingConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.ChunkingConfiguration, BaseFunction>? ChunkingConfiguration { get; set; }
        }

        public class VideoExtractionConfiguration : Humidifier.Base.BaseSubResource, IHaveVideoExtractionStatus
        {
            /// <summary>
            /// VideoExtractionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-videoextractionconfiguration.html#cfn-bedrock-datasource-videoextractionconfiguration-videoextractionstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VideoExtractionStatus { get; set; }
        }

        public class WebCrawlerConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfInclusionFilters, IHaveUserAgentHeader, IHaveBedrockDataSourceTypesWebCrawlerLimitsCrawlerLimits, IHaveStringListOfExclusionFilters, IHaveScope, IHaveUserAgent
        {
            /// <summary>
            /// InclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-inclusionfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? InclusionFilters { get; set; }
            /// <summary>
            /// UserAgentHeader
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-useragentheader
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAgentHeader { get; set; }
            /// <summary>
            /// CrawlerLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-crawlerlimits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebCrawlerLimits
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits, BaseFunction>? CrawlerLimits { get; set; }
            /// <summary>
            /// ExclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-exclusionfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ExclusionFilters { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Scope { get; set; }
            /// <summary>
            /// UserAgent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-useragent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UserAgent { get; set; }
        }

        public class WebCrawlerLimits : Humidifier.Base.BaseSubResource, IHaveRateLimit_Integer, IHaveMaxPages_Integer
        {
            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerlimits.html#cfn-bedrock-datasource-webcrawlerlimits-ratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? RateLimit { get; set; }
            /// <summary>
            /// MaxPages
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerlimits.html#cfn-bedrock-datasource-webcrawlerlimits-maxpages
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxPages { get; set; }
        }

        public class WebDataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesWebSourceConfigurationSourceConfiguration, IHaveBedrockDataSourceTypesWebCrawlerConfigurationCrawlerConfiguration
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webdatasourceconfiguration.html#cfn-bedrock-datasource-webdatasourceconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: WebSourceConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.WebSourceConfiguration, BaseFunction>? SourceConfiguration { get; set; }
            /// <summary>
            /// CrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webdatasourceconfiguration.html#cfn-bedrock-datasource-webdatasourceconfiguration-crawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebCrawlerConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.WebCrawlerConfiguration, BaseFunction>? CrawlerConfiguration { get; set; }
        }

        public class WebSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockDataSourceTypesUrlConfigurationUrlConfiguration
        {
            /// <summary>
            /// UrlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-websourceconfiguration.html#cfn-bedrock-datasource-websourceconfiguration-urlconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: UrlConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration, BaseFunction>? UrlConfiguration { get; set; }
        }

        public class WeeklySchedule : Humidifier.Base.BaseSubResource, IHaveDayOfWeek
        {
            /// <summary>
            /// DayOfWeek
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-weeklyschedule.html#cfn-bedrock-datasource-weeklyschedule-dayofweek
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DayOfWeek { get; set; }
        }
    }
}