namespace Humidifier.Bedrock
{
    using global::System.Collections.Generic;
    using KnowledgeBaseTypes;

    public class KnowledgeBase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveDescription, IHaveBedrockKnowledgeBaseTypesKnowledgeBaseConfigurationKnowledgeBaseConfiguration, IHaveBedrockKnowledgeBaseTypesStorageConfigurationStorageConfiguration, IHaveRoleArn, IHaveStringDictionaryOfTags, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string KnowledgeBaseArn =  "KnowledgeBaseArn" ;
            public static string KnowledgeBaseId =  "KnowledgeBaseId" ;
            public static string FailureReasons =  "FailureReasons" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.Bedrock.KnowledgeBase; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// KnowledgeBaseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: KnowledgeBaseConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration, BaseFunction>? KnowledgeBaseConfiguration { get; set; }
        /// <summary>
        /// StorageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-storageconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StorageConfiguration
        /// </summary>
        public Union<Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration, BaseFunction>? StorageConfiguration { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace KnowledgeBaseTypes
    {
        public class AudioConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesAudioSegmentationConfigurationSegmentationConfiguration
        {
            /// <summary>
            /// SegmentationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-audioconfiguration.html#cfn-bedrock-knowledgebase-audioconfiguration-segmentationconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AudioSegmentationConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.AudioSegmentationConfiguration, BaseFunction>? SegmentationConfiguration { get; set; }
        }

        public class AudioSegmentationConfiguration : Humidifier.Base.BaseSubResource, IHaveFixedLengthDuration_Integer
        {
            /// <summary>
            /// FixedLengthDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-audiosegmentationconfiguration.html#cfn-bedrock-knowledgebase-audiosegmentationconfiguration-fixedlengthduration
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FixedLengthDuration { get; set; }
        }

        public class BedrockEmbeddingModelConfiguration : Humidifier.Base.BaseSubResource, IHaveEmbeddingDataType, IHaveListOfBedrockKnowledgeBaseTypesVideoConfigurationVideo, IHaveDimensions_Integer, IHaveModelConfiguration_Json, IHaveListOfBedrockKnowledgeBaseTypesAudioConfigurationAudio
        {
            /// <summary>
            /// EmbeddingDataType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-bedrockembeddingmodelconfiguration.html#cfn-bedrock-knowledgebase-bedrockembeddingmodelconfiguration-embeddingdatatype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmbeddingDataType { get; set; }
            /// <summary>
            /// Video
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-bedrockembeddingmodelconfiguration.html#cfn-bedrock-knowledgebase-bedrockembeddingmodelconfiguration-video
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: VideoConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.KnowledgeBaseTypes.VideoConfiguration>, IReadOnlyList<Union<Humidifier.Bedrock.KnowledgeBaseTypes.VideoConfiguration, BaseFunction>>, BaseFunction>? Video { get; set; }
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-bedrockembeddingmodelconfiguration.html#cfn-bedrock-knowledgebase-bedrockembeddingmodelconfiguration-dimensions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Dimensions { get; set; }
            /// <summary>
            /// ModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-bedrockembeddingmodelconfiguration.html#cfn-bedrock-knowledgebase-bedrockembeddingmodelconfiguration-modelconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? ModelConfiguration { get; set; }
            /// <summary>
            /// Audio
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-bedrockembeddingmodelconfiguration.html#cfn-bedrock-knowledgebase-bedrockembeddingmodelconfiguration-audio
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AudioConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.KnowledgeBaseTypes.AudioConfiguration>, IReadOnlyList<Union<Humidifier.Bedrock.KnowledgeBaseTypes.AudioConfiguration, BaseFunction>>, BaseFunction>? Audio { get; set; }
        }

        public class CuratedQuery : Humidifier.Base.BaseSubResource, IHaveNaturalLanguage, IHaveSql
        {
            /// <summary>
            /// NaturalLanguage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-curatedquery.html#cfn-bedrock-knowledgebase-curatedquery-naturallanguage
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NaturalLanguage { get; set; }
            /// <summary>
            /// Sql
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-curatedquery.html#cfn-bedrock-knowledgebase-curatedquery-sql
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Sql { get; set; }
        }

        public class EmbeddingModelConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesBedrockEmbeddingModelConfigurationBedrockEmbeddingModelConfiguration
        {
            /// <summary>
            /// BedrockEmbeddingModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-embeddingmodelconfiguration.html#cfn-bedrock-knowledgebase-embeddingmodelconfiguration-bedrockembeddingmodelconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BedrockEmbeddingModelConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration, BaseFunction>? BedrockEmbeddingModelConfiguration { get; set; }
        }

        public class KendraKnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource, IHaveKendraIndexArn
        {
            /// <summary>
            /// KendraIndexArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-kendraknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-kendraknowledgebaseconfiguration-kendraindexarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KendraIndexArn { get; set; }
        }

        public class KnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockKnowledgeBaseTypesSqlKnowledgeBaseConfigurationSqlKnowledgeBaseConfiguration, IHaveBedrockKnowledgeBaseTypesKendraKnowledgeBaseConfigurationKendraKnowledgeBaseConfiguration, IHaveBedrockKnowledgeBaseTypesVectorKnowledgeBaseConfigurationVectorKnowledgeBaseConfiguration, IHaveBedrockKnowledgeBaseTypesManagedKnowledgeBaseConfigurationManagedKnowledgeBaseConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-knowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// SqlKnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-knowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration-sqlknowledgebaseconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqlKnowledgeBaseConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.SqlKnowledgeBaseConfiguration, BaseFunction>? SqlKnowledgeBaseConfiguration { get; set; }
            /// <summary>
            /// KendraKnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-knowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration-kendraknowledgebaseconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KendraKnowledgeBaseConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.KendraKnowledgeBaseConfiguration, BaseFunction>? KendraKnowledgeBaseConfiguration { get; set; }
            /// <summary>
            /// VectorKnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-knowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration-vectorknowledgebaseconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VectorKnowledgeBaseConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration, BaseFunction>? VectorKnowledgeBaseConfiguration { get; set; }
            /// <summary>
            /// ManagedKnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-knowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration-managedknowledgebaseconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ManagedKnowledgeBaseConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.ManagedKnowledgeBaseConfiguration, BaseFunction>? ManagedKnowledgeBaseConfiguration { get; set; }
        }

        public class ManagedKnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesEmbeddingModelConfigurationEmbeddingModelConfiguration, IHaveEmbeddingModelArn, IHaveBedrockKnowledgeBaseTypesSupplementalDataStorageConfigurationSupplementalDataStorageConfiguration, IHaveBedrockKnowledgeBaseTypesManagedKnowledgeBaseServerSideEncryptionConfigurationServerSideEncryptionConfiguration, IHaveEmbeddingModelType
        {
            /// <summary>
            /// EmbeddingModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-managedknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-managedknowledgebaseconfiguration-embeddingmodelconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EmbeddingModelConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration, BaseFunction>? EmbeddingModelConfiguration { get; set; }
            /// <summary>
            /// EmbeddingModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-managedknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-managedknowledgebaseconfiguration-embeddingmodelarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmbeddingModelArn { get; set; }
            /// <summary>
            /// SupplementalDataStorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-managedknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-managedknowledgebaseconfiguration-supplementaldatastorageconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SupplementalDataStorageConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageConfiguration, BaseFunction>? SupplementalDataStorageConfiguration { get; set; }
            /// <summary>
            /// ServerSideEncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-managedknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-managedknowledgebaseconfiguration-serversideencryptionconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: ManagedKnowledgeBaseServerSideEncryptionConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.ManagedKnowledgeBaseServerSideEncryptionConfiguration, BaseFunction>? ServerSideEncryptionConfiguration { get; set; }
            /// <summary>
            /// EmbeddingModelType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-managedknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-managedknowledgebaseconfiguration-embeddingmodeltype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmbeddingModelType { get; set; }
        }

        public class ManagedKnowledgeBaseServerSideEncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-managedknowledgebaseserversideencryptionconfiguration.html#cfn-bedrock-knowledgebase-managedknowledgebaseserversideencryptionconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class MongoDbAtlasConfiguration : Humidifier.Base.BaseSubResource, IHaveEndpoint, IHaveCollectionName, IHaveVectorIndexName, IHaveBedrockKnowledgeBaseTypesMongoDbAtlasFieldMappingFieldMapping, IHaveDatabaseName, IHaveEndpointServiceName, IHaveCredentialsSecretArn, IHaveTextIndexName
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-endpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Endpoint { get; set; }
            /// <summary>
            /// CollectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-collectionname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollectionName { get; set; }
            /// <summary>
            /// VectorIndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-vectorindexname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VectorIndexName { get; set; }
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MongoDbAtlasFieldMapping
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping, BaseFunction>? FieldMapping { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// EndpointServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-endpointservicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EndpointServiceName { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsSecretArn { get; set; }
            /// <summary>
            /// TextIndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-textindexname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextIndexName { get; set; }
        }

        public class MongoDbAtlasFieldMapping : Humidifier.Base.BaseSubResource, IHaveVectorField, IHaveTextField, IHaveMetadataField
        {
            /// <summary>
            /// VectorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasfieldmapping.html#cfn-bedrock-knowledgebase-mongodbatlasfieldmapping-vectorfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VectorField { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasfieldmapping.html#cfn-bedrock-knowledgebase-mongodbatlasfieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasfieldmapping.html#cfn-bedrock-knowledgebase-mongodbatlasfieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataField { get; set; }
        }

        public class NeptuneAnalyticsConfiguration : Humidifier.Base.BaseSubResource, IHaveGraphArn, IHaveBedrockKnowledgeBaseTypesNeptuneAnalyticsFieldMappingFieldMapping
        {
            /// <summary>
            /// GraphArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-neptuneanalyticsconfiguration.html#cfn-bedrock-knowledgebase-neptuneanalyticsconfiguration-grapharn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GraphArn { get; set; }
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-neptuneanalyticsconfiguration.html#cfn-bedrock-knowledgebase-neptuneanalyticsconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: NeptuneAnalyticsFieldMapping
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsFieldMapping, BaseFunction>? FieldMapping { get; set; }
        }

        public class NeptuneAnalyticsFieldMapping : Humidifier.Base.BaseSubResource, IHaveTextField, IHaveMetadataField
        {
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-neptuneanalyticsfieldmapping.html#cfn-bedrock-knowledgebase-neptuneanalyticsfieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-neptuneanalyticsfieldmapping.html#cfn-bedrock-knowledgebase-neptuneanalyticsfieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataField { get; set; }
        }

        public class OpenSearchManagedClusterConfiguration : Humidifier.Base.BaseSubResource, IHaveDomainEndpoint, IHaveVectorIndexName, IHaveBedrockKnowledgeBaseTypesOpenSearchManagedClusterFieldMappingFieldMapping, IHaveDomainArn
        {
            /// <summary>
            /// DomainEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchmanagedclusterconfiguration.html#cfn-bedrock-knowledgebase-opensearchmanagedclusterconfiguration-domainendpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainEndpoint { get; set; }
            /// <summary>
            /// VectorIndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchmanagedclusterconfiguration.html#cfn-bedrock-knowledgebase-opensearchmanagedclusterconfiguration-vectorindexname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VectorIndexName { get; set; }
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchmanagedclusterconfiguration.html#cfn-bedrock-knowledgebase-opensearchmanagedclusterconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OpenSearchManagedClusterFieldMapping
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterFieldMapping, BaseFunction>? FieldMapping { get; set; }
            /// <summary>
            /// DomainArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchmanagedclusterconfiguration.html#cfn-bedrock-knowledgebase-opensearchmanagedclusterconfiguration-domainarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DomainArn { get; set; }
        }

        public class OpenSearchManagedClusterFieldMapping : Humidifier.Base.BaseSubResource, IHaveVectorField, IHaveTextField, IHaveMetadataField
        {
            /// <summary>
            /// VectorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchmanagedclusterfieldmapping.html#cfn-bedrock-knowledgebase-opensearchmanagedclusterfieldmapping-vectorfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VectorField { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchmanagedclusterfieldmapping.html#cfn-bedrock-knowledgebase-opensearchmanagedclusterfieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchmanagedclusterfieldmapping.html#cfn-bedrock-knowledgebase-opensearchmanagedclusterfieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataField { get; set; }
        }

        public class OpenSearchServerlessConfiguration : Humidifier.Base.BaseSubResource, IHaveCollectionArn, IHaveVectorIndexName, IHaveBedrockKnowledgeBaseTypesOpenSearchServerlessFieldMappingFieldMapping
        {
            /// <summary>
            /// CollectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessconfiguration.html#cfn-bedrock-knowledgebase-opensearchserverlessconfiguration-collectionarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollectionArn { get; set; }
            /// <summary>
            /// VectorIndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessconfiguration.html#cfn-bedrock-knowledgebase-opensearchserverlessconfiguration-vectorindexname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VectorIndexName { get; set; }
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessconfiguration.html#cfn-bedrock-knowledgebase-opensearchserverlessconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OpenSearchServerlessFieldMapping
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping, BaseFunction>? FieldMapping { get; set; }
        }

        public class OpenSearchServerlessFieldMapping : Humidifier.Base.BaseSubResource, IHaveVectorField, IHaveTextField, IHaveMetadataField
        {
            /// <summary>
            /// VectorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessfieldmapping.html#cfn-bedrock-knowledgebase-opensearchserverlessfieldmapping-vectorfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VectorField { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessfieldmapping.html#cfn-bedrock-knowledgebase-opensearchserverlessfieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessfieldmapping.html#cfn-bedrock-knowledgebase-opensearchserverlessfieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataField { get; set; }
        }

        public class PineconeConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesPineconeFieldMappingFieldMapping, IHaveCredentialsSecretArn, IHaveConnectionString, IHaveNamespace_
        {
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconeconfiguration.html#cfn-bedrock-knowledgebase-pineconeconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: PineconeFieldMapping
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping, BaseFunction>? FieldMapping { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconeconfiguration.html#cfn-bedrock-knowledgebase-pineconeconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsSecretArn { get; set; }
            /// <summary>
            /// ConnectionString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconeconfiguration.html#cfn-bedrock-knowledgebase-pineconeconfiguration-connectionstring
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ConnectionString { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconeconfiguration.html#cfn-bedrock-knowledgebase-pineconeconfiguration-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Namespace_ { get; set; }
        }

        public class PineconeFieldMapping : Humidifier.Base.BaseSubResource, IHaveTextField, IHaveMetadataField
        {
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconefieldmapping.html#cfn-bedrock-knowledgebase-pineconefieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconefieldmapping.html#cfn-bedrock-knowledgebase-pineconefieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataField { get; set; }
        }

        public class QueryGenerationColumn : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveInclusion, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationcolumn.html#cfn-bedrock-knowledgebase-querygenerationcolumn-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Inclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationcolumn.html#cfn-bedrock-knowledgebase-querygenerationcolumn-inclusion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Inclusion { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationcolumn.html#cfn-bedrock-knowledgebase-querygenerationcolumn-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class QueryGenerationConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesQueryGenerationContextGenerationContext, IHaveExecutionTimeoutSeconds_Integer
        {
            /// <summary>
            /// GenerationContext
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationconfiguration.html#cfn-bedrock-knowledgebase-querygenerationconfiguration-generationcontext
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryGenerationContext
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationContext, BaseFunction>? GenerationContext { get; set; }
            /// <summary>
            /// ExecutionTimeoutSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationconfiguration.html#cfn-bedrock-knowledgebase-querygenerationconfiguration-executiontimeoutseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? ExecutionTimeoutSeconds { get; set; }
        }

        public class QueryGenerationContext : Humidifier.Base.BaseSubResource, IHaveListOfBedrockKnowledgeBaseTypesCuratedQueryCuratedQueries, IHaveListOfBedrockKnowledgeBaseTypesQueryGenerationTableTables
        {
            /// <summary>
            /// CuratedQueries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationcontext.html#cfn-bedrock-knowledgebase-querygenerationcontext-curatedqueries
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CuratedQuery
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.KnowledgeBaseTypes.CuratedQuery>, IReadOnlyList<Union<Humidifier.Bedrock.KnowledgeBaseTypes.CuratedQuery, BaseFunction>>, BaseFunction>? CuratedQueries { get; set; }
            /// <summary>
            /// Tables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationcontext.html#cfn-bedrock-knowledgebase-querygenerationcontext-tables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueryGenerationTable
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationTable>, IReadOnlyList<Union<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationTable, BaseFunction>>, BaseFunction>? Tables { get; set; }
        }

        public class QueryGenerationTable : Humidifier.Base.BaseSubResource, IHaveDescription, IHaveInclusion, IHaveListOfBedrockKnowledgeBaseTypesQueryGenerationColumnColumns, IHaveName
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationtable.html#cfn-bedrock-knowledgebase-querygenerationtable-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// Inclusion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationtable.html#cfn-bedrock-knowledgebase-querygenerationtable-inclusion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Inclusion { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationtable.html#cfn-bedrock-knowledgebase-querygenerationtable-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueryGenerationColumn
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationColumn>, IReadOnlyList<Union<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationColumn, BaseFunction>>, BaseFunction>? Columns { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-querygenerationtable.html#cfn-bedrock-knowledgebase-querygenerationtable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RdsConfiguration : Humidifier.Base.BaseSubResource, IHaveResourceArn, IHaveTableName, IHaveBedrockKnowledgeBaseTypesRdsFieldMappingFieldMapping, IHaveDatabaseName, IHaveCredentialsSecretArn
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-resourcearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ResourceArn { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RdsFieldMapping
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping, BaseFunction>? FieldMapping { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CredentialsSecretArn { get; set; }
        }

        public class RdsFieldMapping : Humidifier.Base.BaseSubResource, IHavePrimaryKeyField, IHaveVectorField, IHaveTextField, IHaveCustomMetadataField, IHaveMetadataField
        {
            /// <summary>
            /// PrimaryKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-primarykeyfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrimaryKeyField { get; set; }
            /// <summary>
            /// VectorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-vectorfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VectorField { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TextField { get; set; }
            /// <summary>
            /// CustomMetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-custommetadatafield
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CustomMetadataField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataField { get; set; }
        }

        public class RedshiftConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesRedshiftQueryEngineConfigurationQueryEngineConfiguration, IHaveListOfBedrockKnowledgeBaseTypesRedshiftQueryEngineStorageConfigurationStorageConfigurations, IHaveBedrockKnowledgeBaseTypesQueryGenerationConfigurationQueryGenerationConfiguration
        {
            /// <summary>
            /// QueryEngineConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftconfiguration.html#cfn-bedrock-knowledgebase-redshiftconfiguration-queryengineconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RedshiftQueryEngineConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftQueryEngineConfiguration, BaseFunction>? QueryEngineConfiguration { get; set; }
            /// <summary>
            /// StorageConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftconfiguration.html#cfn-bedrock-knowledgebase-redshiftconfiguration-storageconfigurations
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: RedshiftQueryEngineStorageConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftQueryEngineStorageConfiguration>, IReadOnlyList<Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftQueryEngineStorageConfiguration, BaseFunction>>, BaseFunction>? StorageConfigurations { get; set; }
            /// <summary>
            /// QueryGenerationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftconfiguration.html#cfn-bedrock-knowledgebase-redshiftconfiguration-querygenerationconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: QueryGenerationConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.QueryGenerationConfiguration, BaseFunction>? QueryGenerationConfiguration { get; set; }
        }

        public class RedshiftProvisionedAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveDatabaseUser, IHaveUsernamePasswordSecretArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftprovisionedauthconfiguration.html#cfn-bedrock-knowledgebase-redshiftprovisionedauthconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// DatabaseUser
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftprovisionedauthconfiguration.html#cfn-bedrock-knowledgebase-redshiftprovisionedauthconfiguration-databaseuser
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseUser { get; set; }
            /// <summary>
            /// UsernamePasswordSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftprovisionedauthconfiguration.html#cfn-bedrock-knowledgebase-redshiftprovisionedauthconfiguration-usernamepasswordsecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsernamePasswordSecretArn { get; set; }
        }

        public class RedshiftProvisionedConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesRedshiftProvisionedAuthConfigurationAuthConfiguration, IHaveClusterIdentifier
        {
            /// <summary>
            /// AuthConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftprovisionedconfiguration.html#cfn-bedrock-knowledgebase-redshiftprovisionedconfiguration-authconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RedshiftProvisionedAuthConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedAuthConfiguration, BaseFunction>? AuthConfiguration { get; set; }
            /// <summary>
            /// ClusterIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftprovisionedconfiguration.html#cfn-bedrock-knowledgebase-redshiftprovisionedconfiguration-clusteridentifier
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ClusterIdentifier { get; set; }
        }

        public class RedshiftQueryEngineAwsDataCatalogStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfTableNames
        {
            /// <summary>
            /// TableNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftqueryengineawsdatacatalogstorageconfiguration.html#cfn-bedrock-knowledgebase-redshiftqueryengineawsdatacatalogstorageconfiguration-tablenames
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? TableNames { get; set; }
        }

        public class RedshiftQueryEngineConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockKnowledgeBaseTypesRedshiftProvisionedConfigurationProvisionedConfiguration, IHaveBedrockKnowledgeBaseTypesRedshiftServerlessConfigurationServerlessConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftqueryengineconfiguration.html#cfn-bedrock-knowledgebase-redshiftqueryengineconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// ProvisionedConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftqueryengineconfiguration.html#cfn-bedrock-knowledgebase-redshiftqueryengineconfiguration-provisionedconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RedshiftProvisionedConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftProvisionedConfiguration, BaseFunction>? ProvisionedConfiguration { get; set; }
            /// <summary>
            /// ServerlessConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftqueryengineconfiguration.html#cfn-bedrock-knowledgebase-redshiftqueryengineconfiguration-serverlessconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RedshiftServerlessConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessConfiguration, BaseFunction>? ServerlessConfiguration { get; set; }
        }

        public class RedshiftQueryEngineRedshiftStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseName
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftqueryengineredshiftstorageconfiguration.html#cfn-bedrock-knowledgebase-redshiftqueryengineredshiftstorageconfiguration-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
        }

        public class RedshiftQueryEngineStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockKnowledgeBaseTypesRedshiftQueryEngineRedshiftStorageConfigurationRedshiftConfiguration, IHaveBedrockKnowledgeBaseTypesRedshiftQueryEngineAwsDataCatalogStorageConfigurationAwsDataCatalogConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftqueryenginestorageconfiguration.html#cfn-bedrock-knowledgebase-redshiftqueryenginestorageconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// RedshiftConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftqueryenginestorageconfiguration.html#cfn-bedrock-knowledgebase-redshiftqueryenginestorageconfiguration-redshiftconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RedshiftQueryEngineRedshiftStorageConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftQueryEngineRedshiftStorageConfiguration, BaseFunction>? RedshiftConfiguration { get; set; }
            /// <summary>
            /// AwsDataCatalogConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftqueryenginestorageconfiguration.html#cfn-bedrock-knowledgebase-redshiftqueryenginestorageconfiguration-awsdatacatalogconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RedshiftQueryEngineAwsDataCatalogStorageConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftQueryEngineAwsDataCatalogStorageConfiguration, BaseFunction>? AwsDataCatalogConfiguration { get; set; }
        }

        public class RedshiftServerlessAuthConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveUsernamePasswordSecretArn
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftserverlessauthconfiguration.html#cfn-bedrock-knowledgebase-redshiftserverlessauthconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// UsernamePasswordSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftserverlessauthconfiguration.html#cfn-bedrock-knowledgebase-redshiftserverlessauthconfiguration-usernamepasswordsecretarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? UsernamePasswordSecretArn { get; set; }
        }

        public class RedshiftServerlessConfiguration : Humidifier.Base.BaseSubResource, IHaveWorkgroupArn, IHaveBedrockKnowledgeBaseTypesRedshiftServerlessAuthConfigurationAuthConfiguration
        {
            /// <summary>
            /// WorkgroupArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftserverlessconfiguration.html#cfn-bedrock-knowledgebase-redshiftserverlessconfiguration-workgrouparn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WorkgroupArn { get; set; }
            /// <summary>
            /// AuthConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-redshiftserverlessconfiguration.html#cfn-bedrock-knowledgebase-redshiftserverlessconfiguration-authconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RedshiftServerlessAuthConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftServerlessAuthConfiguration, BaseFunction>? AuthConfiguration { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveURI
        {
            /// <summary>
            /// URI
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-s3location.html#cfn-bedrock-knowledgebase-s3location-uri
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? URI { get; set; }
        }

        public class S3VectorsConfiguration : Humidifier.Base.BaseSubResource, IHaveIndexName, IHaveVectorBucketArn, IHaveIndexArn
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-s3vectorsconfiguration.html#cfn-bedrock-knowledgebase-s3vectorsconfiguration-indexname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexName { get; set; }
            /// <summary>
            /// VectorBucketArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-s3vectorsconfiguration.html#cfn-bedrock-knowledgebase-s3vectorsconfiguration-vectorbucketarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? VectorBucketArn { get; set; }
            /// <summary>
            /// IndexArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-s3vectorsconfiguration.html#cfn-bedrock-knowledgebase-s3vectorsconfiguration-indexarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? IndexArn { get; set; }
        }

        public class SqlKnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource, IHaveType, IHaveBedrockKnowledgeBaseTypesRedshiftConfigurationRedshiftConfiguration
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-sqlknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-sqlknowledgebaseconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// RedshiftConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-sqlknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-sqlknowledgebaseconfiguration-redshiftconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedshiftConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RedshiftConfiguration, BaseFunction>? RedshiftConfiguration { get; set; }
        }

        public class StorageConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesS3VectorsConfigurationS3VectorsConfiguration, IHaveBedrockKnowledgeBaseTypesOpenSearchManagedClusterConfigurationOpensearchManagedClusterConfiguration, IHaveBedrockKnowledgeBaseTypesOpenSearchServerlessConfigurationOpensearchServerlessConfiguration, IHaveBedrockKnowledgeBaseTypesNeptuneAnalyticsConfigurationNeptuneAnalyticsConfiguration, IHaveType, IHaveBedrockKnowledgeBaseTypesMongoDbAtlasConfigurationMongoDbAtlasConfiguration, IHaveBedrockKnowledgeBaseTypesRdsConfigurationRdsConfiguration, IHaveBedrockKnowledgeBaseTypesPineconeConfigurationPineconeConfiguration
        {
            /// <summary>
            /// S3VectorsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-s3vectorsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3VectorsConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.S3VectorsConfiguration, BaseFunction>? S3VectorsConfiguration { get; set; }
            /// <summary>
            /// OpensearchManagedClusterConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-opensearchmanagedclusterconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OpenSearchManagedClusterConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchManagedClusterConfiguration, BaseFunction>? OpensearchManagedClusterConfiguration { get; set; }
            /// <summary>
            /// OpensearchServerlessConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-opensearchserverlessconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OpenSearchServerlessConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessConfiguration, BaseFunction>? OpensearchServerlessConfiguration { get; set; }
            /// <summary>
            /// NeptuneAnalyticsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-neptuneanalyticsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: NeptuneAnalyticsConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.NeptuneAnalyticsConfiguration, BaseFunction>? NeptuneAnalyticsConfiguration { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// MongoDbAtlasConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-mongodbatlasconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MongoDbAtlasConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasConfiguration, BaseFunction>? MongoDbAtlasConfiguration { get; set; }
            /// <summary>
            /// RdsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-rdsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RdsConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.RdsConfiguration, BaseFunction>? RdsConfiguration { get; set; }
            /// <summary>
            /// PineconeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-pineconeconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PineconeConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.PineconeConfiguration, BaseFunction>? PineconeConfiguration { get; set; }
        }

        public class SupplementalDataStorageConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfBedrockKnowledgeBaseTypesSupplementalDataStorageLocationSupplementalDataStorageLocations
        {
            /// <summary>
            /// SupplementalDataStorageLocations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-supplementaldatastorageconfiguration.html#cfn-bedrock-knowledgebase-supplementaldatastorageconfiguration-supplementaldatastoragelocations
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SupplementalDataStorageLocation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageLocation>, IReadOnlyList<Union<Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageLocation, BaseFunction>>, BaseFunction>? SupplementalDataStorageLocations { get; set; }
        }

        public class SupplementalDataStorageLocation : Humidifier.Base.BaseSubResource, IHaveSupplementalDataStorageLocationType, IHaveBedrockKnowledgeBaseTypesS3LocationS3Location
        {
            /// <summary>
            /// SupplementalDataStorageLocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-supplementaldatastoragelocation.html#cfn-bedrock-knowledgebase-supplementaldatastoragelocation-supplementaldatastoragelocationtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SupplementalDataStorageLocationType { get; set; }
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-supplementaldatastoragelocation.html#cfn-bedrock-knowledgebase-supplementaldatastoragelocation-s3location
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.S3Location, BaseFunction>? S3Location { get; set; }
        }

        public class VectorKnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesEmbeddingModelConfigurationEmbeddingModelConfiguration, IHaveEmbeddingModelArn, IHaveBedrockKnowledgeBaseTypesSupplementalDataStorageConfigurationSupplementalDataStorageConfiguration
        {
            /// <summary>
            /// EmbeddingModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-vectorknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-vectorknowledgebaseconfiguration-embeddingmodelconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EmbeddingModelConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration, BaseFunction>? EmbeddingModelConfiguration { get; set; }
            /// <summary>
            /// EmbeddingModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-vectorknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-vectorknowledgebaseconfiguration-embeddingmodelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EmbeddingModelArn { get; set; }
            /// <summary>
            /// SupplementalDataStorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-vectorknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-vectorknowledgebaseconfiguration-supplementaldatastorageconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SupplementalDataStorageConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageConfiguration, BaseFunction>? SupplementalDataStorageConfiguration { get; set; }
        }

        public class VideoConfiguration : Humidifier.Base.BaseSubResource, IHaveBedrockKnowledgeBaseTypesVideoSegmentationConfigurationSegmentationConfiguration
        {
            /// <summary>
            /// SegmentationConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-videoconfiguration.html#cfn-bedrock-knowledgebase-videoconfiguration-segmentationconfiguration
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VideoSegmentationConfiguration
            /// </summary>
            public Union<Humidifier.Bedrock.KnowledgeBaseTypes.VideoSegmentationConfiguration, BaseFunction>? SegmentationConfiguration { get; set; }
        }

        public class VideoSegmentationConfiguration : Humidifier.Base.BaseSubResource, IHaveFixedLengthDuration_Integer
        {
            /// <summary>
            /// FixedLengthDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-videosegmentationconfiguration.html#cfn-bedrock-knowledgebase-videosegmentationconfiguration-fixedlengthduration
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FixedLengthDuration { get; set; }
        }
    }
}