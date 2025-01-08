namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using DataSourceTypes;

    public class DataSource : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveKnowledgeBaseId
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
        public dynamic DataDeletionPolicy { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// KnowledgeBaseId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-knowledgebaseid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic KnowledgeBaseId { get; set; }
        /// <summary>
        /// ServerSideEncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-serversideencryptionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ServerSideEncryptionConfiguration
        /// </summary>
        public Humidifier.Bedrock.DataSourceTypes.ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }
        /// <summary>
        /// VectorIngestionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-vectoringestionconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VectorIngestionConfiguration
        /// </summary>
        public Humidifier.Bedrock.DataSourceTypes.VectorIngestionConfiguration VectorIngestionConfiguration { get; set; }

        /// <summary>
        /// DataSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-datasource.html#cfn-bedrock-datasource-datasourceconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataSourceConfiguration
        /// </summary>
        [Required]
        public Humidifier.Bedrock.DataSourceTypes.DataSourceConfiguration DataSourceConfiguration { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DataSourceTypes
    {
        public class BedrockDataAutomationConfiguration : Humidifier.Base.BaseSubResource, IHaveParsingModality
        {
            /// <summary>
            /// ParsingModality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockdataautomationconfiguration.html#cfn-bedrock-datasource-bedrockdataautomationconfiguration-parsingmodality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParsingModality { get; set; }
        }

        public class BedrockFoundationModelConfiguration : Humidifier.Base.BaseSubResource, IHaveModelArn, IHaveParsingModality
        {
            /// <summary>
            /// ModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockfoundationmodelconfiguration.html#cfn-bedrock-datasource-bedrockfoundationmodelconfiguration-modelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelArn { get; set; }
            /// <summary>
            /// ParsingModality
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockfoundationmodelconfiguration.html#cfn-bedrock-datasource-bedrockfoundationmodelconfiguration-parsingmodality
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParsingModality { get; set; }
            /// <summary>
            /// ParsingPrompt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-bedrockfoundationmodelconfiguration.html#cfn-bedrock-datasource-bedrockfoundationmodelconfiguration-parsingprompt
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParsingPrompt
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.ParsingPrompt ParsingPrompt { get; set; }
        }

        public class ChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveChunkingStrategy
        {
            /// <summary>
            /// ChunkingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-chunkingstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChunkingStrategy { get; set; }
            /// <summary>
            /// FixedSizeChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-fixedsizechunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: FixedSizeChunkingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.FixedSizeChunkingConfiguration FixedSizeChunkingConfiguration { get; set; }
            /// <summary>
            /// SemanticChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-semanticchunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SemanticChunkingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.SemanticChunkingConfiguration SemanticChunkingConfiguration { get; set; }
            /// <summary>
            /// HierarchicalChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-chunkingconfiguration.html#cfn-bedrock-datasource-chunkingconfiguration-hierarchicalchunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: HierarchicalChunkingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingConfiguration HierarchicalChunkingConfiguration { get; set; }
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
            public Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration FilterConfiguration { get; set; }
        }

        public class ConfluenceDataSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencedatasourceconfiguration.html#cfn-bedrock-datasource-confluencedatasourceconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ConfluenceSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.ConfluenceSourceConfiguration SourceConfiguration { get; set; }
            /// <summary>
            /// CrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencedatasourceconfiguration.html#cfn-bedrock-datasource-confluencedatasourceconfiguration-crawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceCrawlerConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.ConfluenceCrawlerConfiguration CrawlerConfiguration { get; set; }
        }

        public class ConfluenceSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveAuthType, IHaveCredentialsSecretArn, IHaveHostUrl, IHaveHostType
        {
            /// <summary>
            /// HostUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencesourceconfiguration.html#cfn-bedrock-datasource-confluencesourceconfiguration-hosturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostUrl { get; set; }
            /// <summary>
            /// HostType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencesourceconfiguration.html#cfn-bedrock-datasource-confluencesourceconfiguration-hosttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostType { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencesourceconfiguration.html#cfn-bedrock-datasource-confluencesourceconfiguration-authtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthType { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-confluencesourceconfiguration.html#cfn-bedrock-datasource-confluencesourceconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsSecretArn { get; set; }
        }

        public class CrawlFilterConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-crawlfilterconfiguration.html#cfn-bedrock-datasource-crawlfilterconfiguration-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// PatternObjectFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-crawlfilterconfiguration.html#cfn-bedrock-datasource-crawlfilterconfiguration-patternobjectfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PatternObjectFilterConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.PatternObjectFilterConfiguration PatternObjectFilter { get; set; }
        }

        public class CustomTransformationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IntermediateStorage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-customtransformationconfiguration.html#cfn-bedrock-datasource-customtransformationconfiguration-intermediatestorage
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IntermediateStorage
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.IntermediateStorage IntermediateStorage { get; set; }
            /// <summary>
            /// Transformations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-customtransformationconfiguration.html#cfn-bedrock-datasource-customtransformationconfiguration-transformations
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Transformation
            /// </summary>
            public List<Humidifier.Bedrock.DataSourceTypes.Transformation> Transformations { get; set; }
        }

        public class DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-s3configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DataSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.S3DataSourceConfiguration S3Configuration { get; set; }
            /// <summary>
            /// SalesforceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-salesforceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceDataSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.SalesforceDataSourceConfiguration SalesforceConfiguration { get; set; }
            /// <summary>
            /// ConfluenceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-confluenceconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConfluenceDataSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.ConfluenceDataSourceConfiguration ConfluenceConfiguration { get; set; }
            /// <summary>
            /// SharePointConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-sharepointconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharePointDataSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.SharePointDataSourceConfiguration SharePointConfiguration { get; set; }
            /// <summary>
            /// WebConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-datasourceconfiguration.html#cfn-bedrock-datasource-datasourceconfiguration-webconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebDataSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.WebDataSourceConfiguration WebConfiguration { get; set; }
        }

        public class FixedSizeChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveOverlapPercentage
        {
            /// <summary>
            /// OverlapPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-fixedsizechunkingconfiguration.html#cfn-bedrock-datasource-fixedsizechunkingconfiguration-overlappercentage
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OverlapPercentage { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-fixedsizechunkingconfiguration.html#cfn-bedrock-datasource-fixedsizechunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
        }

        public class HierarchicalChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveOverlapTokens
        {
            /// <summary>
            /// OverlapTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-hierarchicalchunkingconfiguration.html#cfn-bedrock-datasource-hierarchicalchunkingconfiguration-overlaptokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic OverlapTokens { get; set; }
            /// <summary>
            /// LevelConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-hierarchicalchunkingconfiguration.html#cfn-bedrock-datasource-hierarchicalchunkingconfiguration-levelconfigurations
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: HierarchicalChunkingLevelConfiguration
            /// </summary>
            public List<Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingLevelConfiguration> LevelConfigurations { get; set; }
        }

        public class HierarchicalChunkingLevelConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens
        {
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-hierarchicalchunkinglevelconfiguration.html#cfn-bedrock-datasource-hierarchicalchunkinglevelconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
        }

        public class IntermediateStorage : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-intermediatestorage.html#cfn-bedrock-datasource-intermediatestorage-s3location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.S3Location S3Location { get; set; }
        }

        public class ParsingConfiguration : Humidifier.Base.BaseSubResource, IHaveParsingStrategy
        {
            /// <summary>
            /// BedrockDataAutomationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-parsingconfiguration.html#cfn-bedrock-datasource-parsingconfiguration-bedrockdataautomationconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BedrockDataAutomationConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.BedrockDataAutomationConfiguration BedrockDataAutomationConfiguration { get; set; }
            /// <summary>
            /// BedrockFoundationModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-parsingconfiguration.html#cfn-bedrock-datasource-parsingconfiguration-bedrockfoundationmodelconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BedrockFoundationModelConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.BedrockFoundationModelConfiguration BedrockFoundationModelConfiguration { get; set; }
            /// <summary>
            /// ParsingStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-parsingconfiguration.html#cfn-bedrock-datasource-parsingconfiguration-parsingstrategy
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParsingStrategy { get; set; }
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
            public dynamic ParsingPromptText { get; set; }
        }

        public class PatternObjectFilter : Humidifier.Base.BaseSubResource, IHaveInclusionFilters, IHaveExclusionFilters
        {
            /// <summary>
            /// ObjectType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-patternobjectfilter.html#cfn-bedrock-datasource-patternobjectfilter-objecttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ObjectType { get; set; }
            /// <summary>
            /// InclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-patternobjectfilter.html#cfn-bedrock-datasource-patternobjectfilter-inclusionfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionFilters { get; set; }
            /// <summary>
            /// ExclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-patternobjectfilter.html#cfn-bedrock-datasource-patternobjectfilter-exclusionfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionFilters { get; set; }
        }

        public class PatternObjectFilterConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Filters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-patternobjectfilterconfiguration.html#cfn-bedrock-datasource-patternobjectfilterconfiguration-filters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PatternObjectFilter
            /// </summary>
            public List<Humidifier.Bedrock.DataSourceTypes.PatternObjectFilter> Filters { get; set; }
        }

        public class S3DataSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketArn, IHaveInclusionPrefixes
        {
            /// <summary>
            /// BucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketArn { get; set; }
            /// <summary>
            /// BucketOwnerAccountId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-bucketowneraccountid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwnerAccountId { get; set; }
            /// <summary>
            /// InclusionPrefixes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-s3datasourceconfiguration.html#cfn-bedrock-datasource-s3datasourceconfiguration-inclusionprefixes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionPrefixes { get; set; }
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
            public dynamic URI { get; set; }
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
            public Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration FilterConfiguration { get; set; }
        }

        public class SalesforceDataSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcedatasourceconfiguration.html#cfn-bedrock-datasource-salesforcedatasourceconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SalesforceSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.SalesforceSourceConfiguration SourceConfiguration { get; set; }
            /// <summary>
            /// CrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcedatasourceconfiguration.html#cfn-bedrock-datasource-salesforcedatasourceconfiguration-crawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SalesforceCrawlerConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.SalesforceCrawlerConfiguration CrawlerConfiguration { get; set; }
        }

        public class SalesforceSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveAuthType, IHaveCredentialsSecretArn, IHaveHostUrl
        {
            /// <summary>
            /// HostUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcesourceconfiguration.html#cfn-bedrock-datasource-salesforcesourceconfiguration-hosturl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostUrl { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcesourceconfiguration.html#cfn-bedrock-datasource-salesforcesourceconfiguration-authtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthType { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-salesforcesourceconfiguration.html#cfn-bedrock-datasource-salesforcesourceconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsSecretArn { get; set; }
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
            public dynamic Url { get; set; }
        }

        public class SemanticChunkingConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxTokens, IHaveBufferSize, IHaveBreakpointPercentileThreshold
        {
            /// <summary>
            /// BufferSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-semanticchunkingconfiguration.html#cfn-bedrock-datasource-semanticchunkingconfiguration-buffersize
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BufferSize { get; set; }
            /// <summary>
            /// MaxTokens
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-semanticchunkingconfiguration.html#cfn-bedrock-datasource-semanticchunkingconfiguration-maxtokens
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxTokens { get; set; }
            /// <summary>
            /// BreakpointPercentileThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-semanticchunkingconfiguration.html#cfn-bedrock-datasource-semanticchunkingconfiguration-breakpointpercentilethreshold
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BreakpointPercentileThreshold { get; set; }
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
            public dynamic KmsKeyArn { get; set; }
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
            public Humidifier.Bedrock.DataSourceTypes.CrawlFilterConfiguration FilterConfiguration { get; set; }
        }

        public class SharePointDataSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointdatasourceconfiguration.html#cfn-bedrock-datasource-sharepointdatasourceconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SharePointSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.SharePointSourceConfiguration SourceConfiguration { get; set; }
            /// <summary>
            /// CrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointdatasourceconfiguration.html#cfn-bedrock-datasource-sharepointdatasourceconfiguration-crawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SharePointCrawlerConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.SharePointCrawlerConfiguration CrawlerConfiguration { get; set; }
        }

        public class SharePointSourceConfiguration : Humidifier.Base.BaseSubResource, IHaveDomain, IHaveAuthType, IHaveCredentialsSecretArn, IHaveHostType, IHaveTenantId
        {
            /// <summary>
            /// SiteUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-siteurls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SiteUrls { get; set; }
            /// <summary>
            /// HostType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-hosttype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostType { get; set; }
            /// <summary>
            /// TenantId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-tenantid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TenantId { get; set; }
            /// <summary>
            /// AuthType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-authtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AuthType { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsSecretArn { get; set; }
            /// <summary>
            /// Domain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-sharepointsourceconfiguration.html#cfn-bedrock-datasource-sharepointsourceconfiguration-domain
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Domain { get; set; }
        }

        public class Transformation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// StepToApply
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-transformation.html#cfn-bedrock-datasource-transformation-steptoapply
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StepToApply { get; set; }
            /// <summary>
            /// TransformationFunction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-transformation.html#cfn-bedrock-datasource-transformation-transformationfunction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformationFunction
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.TransformationFunction TransformationFunction { get; set; }
        }

        public class TransformationFunction : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TransformationLambdaConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-transformationfunction.html#cfn-bedrock-datasource-transformationfunction-transformationlambdaconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: TransformationLambdaConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.TransformationLambdaConfiguration TransformationLambdaConfiguration { get; set; }
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
            public dynamic LambdaArn { get; set; }
        }

        public class UrlConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SeedUrls
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-urlconfiguration.html#cfn-bedrock-datasource-urlconfiguration-seedurls
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: SeedUrl
            /// </summary>
            public List<Humidifier.Bedrock.DataSourceTypes.SeedUrl> SeedUrls { get; set; }
        }

        public class VectorIngestionConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ParsingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-vectoringestionconfiguration.html#cfn-bedrock-datasource-vectoringestionconfiguration-parsingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ParsingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.ParsingConfiguration ParsingConfiguration { get; set; }
            /// <summary>
            /// CustomTransformationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-vectoringestionconfiguration.html#cfn-bedrock-datasource-vectoringestionconfiguration-customtransformationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomTransformationConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.CustomTransformationConfiguration CustomTransformationConfiguration { get; set; }
            /// <summary>
            /// ChunkingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-vectoringestionconfiguration.html#cfn-bedrock-datasource-vectoringestionconfiguration-chunkingconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ChunkingConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.ChunkingConfiguration ChunkingConfiguration { get; set; }
        }

        public class WebCrawlerConfiguration : Humidifier.Base.BaseSubResource, IHaveScope, IHaveInclusionFilters, IHaveExclusionFilters
        {
            /// <summary>
            /// InclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-inclusionfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic InclusionFilters { get; set; }
            /// <summary>
            /// CrawlerLimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-crawlerlimits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebCrawlerLimits
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.WebCrawlerLimits CrawlerLimits { get; set; }
            /// <summary>
            /// ExclusionFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-exclusionfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ExclusionFilters { get; set; }
            /// <summary>
            /// Scope
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerconfiguration.html#cfn-bedrock-datasource-webcrawlerconfiguration-scope
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scope { get; set; }
        }

        public class WebCrawlerLimits : Humidifier.Base.BaseSubResource, IHaveRateLimit
        {
            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webcrawlerlimits.html#cfn-bedrock-datasource-webcrawlerlimits-ratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RateLimit { get; set; }
        }

        public class WebDataSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webdatasourceconfiguration.html#cfn-bedrock-datasource-webdatasourceconfiguration-sourceconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: WebSourceConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.WebSourceConfiguration SourceConfiguration { get; set; }
            /// <summary>
            /// CrawlerConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-webdatasourceconfiguration.html#cfn-bedrock-datasource-webdatasourceconfiguration-crawlerconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: WebCrawlerConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.WebCrawlerConfiguration CrawlerConfiguration { get; set; }
        }

        public class WebSourceConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// UrlConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-datasource-websourceconfiguration.html#cfn-bedrock-datasource-websourceconfiguration-urlconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: UrlConfiguration
            /// </summary>
            public Humidifier.Bedrock.DataSourceTypes.UrlConfiguration UrlConfiguration { get; set; }
        }
    }
}