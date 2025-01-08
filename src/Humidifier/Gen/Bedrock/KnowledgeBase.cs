namespace Humidifier.Bedrock
{
    using System.Collections.Generic;
    using KnowledgeBaseTypes;

    public class KnowledgeBase : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveDescription, IHaveRoleArn
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
        public dynamic Description { get; set; }

        /// <summary>
        /// KnowledgeBaseConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// Type: KnowledgeBaseConfiguration
        /// </summary>
        [Required]
        public Humidifier.Bedrock.KnowledgeBaseTypes.KnowledgeBaseConfiguration KnowledgeBaseConfiguration { get; set; }
        /// <summary>
        /// StorageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-storageconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StorageConfiguration
        /// </summary>
        public Humidifier.Bedrock.KnowledgeBaseTypes.StorageConfiguration StorageConfiguration { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-bedrock-knowledgebase.html#cfn-bedrock-knowledgebase-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace KnowledgeBaseTypes
    {
        public class BedrockEmbeddingModelConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-bedrockembeddingmodelconfiguration.html#cfn-bedrock-knowledgebase-bedrockembeddingmodelconfiguration-dimensions
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Dimensions { get; set; }
        }

        public class EmbeddingModelConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// BedrockEmbeddingModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-embeddingmodelconfiguration.html#cfn-bedrock-knowledgebase-embeddingmodelconfiguration-bedrockembeddingmodelconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: BedrockEmbeddingModelConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.BedrockEmbeddingModelConfiguration BedrockEmbeddingModelConfiguration { get; set; }
        }

        public class KendraKnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// KendraIndexArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-kendraknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-kendraknowledgebaseconfiguration-kendraindexarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KendraIndexArn { get; set; }
        }

        public class KnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-knowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// KendraKnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-knowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration-kendraknowledgebaseconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: KendraKnowledgeBaseConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.KendraKnowledgeBaseConfiguration KendraKnowledgeBaseConfiguration { get; set; }
            /// <summary>
            /// VectorKnowledgeBaseConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-knowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-knowledgebaseconfiguration-vectorknowledgebaseconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: VectorKnowledgeBaseConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.VectorKnowledgeBaseConfiguration VectorKnowledgeBaseConfiguration { get; set; }
        }

        public class MongoDbAtlasConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveEndpoint, IHaveCredentialsSecretArn, IHaveCollectionName, IHaveVectorIndexName
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-endpoint
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Endpoint { get; set; }
            /// <summary>
            /// CollectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-collectionname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollectionName { get; set; }
            /// <summary>
            /// VectorIndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-vectorindexname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VectorIndexName { get; set; }
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MongoDbAtlasFieldMapping
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasFieldMapping FieldMapping { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// EndpointServiceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-endpointservicename
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndpointServiceName { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasconfiguration.html#cfn-bedrock-knowledgebase-mongodbatlasconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsSecretArn { get; set; }
        }

        public class MongoDbAtlasFieldMapping : Humidifier.Base.BaseSubResource, IHaveTextField, IHaveMetadataField, IHaveVectorField
        {
            /// <summary>
            /// VectorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasfieldmapping.html#cfn-bedrock-knowledgebase-mongodbatlasfieldmapping-vectorfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VectorField { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasfieldmapping.html#cfn-bedrock-knowledgebase-mongodbatlasfieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-mongodbatlasfieldmapping.html#cfn-bedrock-knowledgebase-mongodbatlasfieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetadataField { get; set; }
        }

        public class OpenSearchServerlessConfiguration : Humidifier.Base.BaseSubResource, IHaveVectorIndexName
        {
            /// <summary>
            /// CollectionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessconfiguration.html#cfn-bedrock-knowledgebase-opensearchserverlessconfiguration-collectionarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollectionArn { get; set; }
            /// <summary>
            /// VectorIndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessconfiguration.html#cfn-bedrock-knowledgebase-opensearchserverlessconfiguration-vectorindexname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VectorIndexName { get; set; }
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessconfiguration.html#cfn-bedrock-knowledgebase-opensearchserverlessconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: OpenSearchServerlessFieldMapping
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessFieldMapping FieldMapping { get; set; }
        }

        public class OpenSearchServerlessFieldMapping : Humidifier.Base.BaseSubResource, IHaveTextField, IHaveMetadataField, IHaveVectorField
        {
            /// <summary>
            /// VectorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessfieldmapping.html#cfn-bedrock-knowledgebase-opensearchserverlessfieldmapping-vectorfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VectorField { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessfieldmapping.html#cfn-bedrock-knowledgebase-opensearchserverlessfieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-opensearchserverlessfieldmapping.html#cfn-bedrock-knowledgebase-opensearchserverlessfieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetadataField { get; set; }
        }

        public class PineconeConfiguration : Humidifier.Base.BaseSubResource, IHaveNamespace_, IHaveCredentialsSecretArn, IHaveConnectionString
        {
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconeconfiguration.html#cfn-bedrock-knowledgebase-pineconeconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: PineconeFieldMapping
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.PineconeFieldMapping FieldMapping { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconeconfiguration.html#cfn-bedrock-knowledgebase-pineconeconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsSecretArn { get; set; }
            /// <summary>
            /// ConnectionString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconeconfiguration.html#cfn-bedrock-knowledgebase-pineconeconfiguration-connectionstring
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectionString { get; set; }
            /// <summary>
            /// Namespace_
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconeconfiguration.html#cfn-bedrock-knowledgebase-pineconeconfiguration-namespace
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace_ { get; set; }
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
            public dynamic TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-pineconefieldmapping.html#cfn-bedrock-knowledgebase-pineconefieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetadataField { get; set; }
        }

        public class RdsConfiguration : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveTableName, IHaveResourceArn, IHaveCredentialsSecretArn
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-resourcearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceArn { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// FieldMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-fieldmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: RdsFieldMapping
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.RdsFieldMapping FieldMapping { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CredentialsSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsconfiguration.html#cfn-bedrock-knowledgebase-rdsconfiguration-credentialssecretarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CredentialsSecretArn { get; set; }
        }

        public class RdsFieldMapping : Humidifier.Base.BaseSubResource, IHaveTextField, IHaveMetadataField, IHaveVectorField
        {
            /// <summary>
            /// PrimaryKeyField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-primarykeyfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryKeyField { get; set; }
            /// <summary>
            /// VectorField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-vectorfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VectorField { get; set; }
            /// <summary>
            /// TextField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-textfield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextField { get; set; }
            /// <summary>
            /// MetadataField
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-rdsfieldmapping.html#cfn-bedrock-knowledgebase-rdsfieldmapping-metadatafield
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetadataField { get; set; }
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
            public dynamic URI { get; set; }
        }

        public class StorageConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// OpensearchServerlessConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-opensearchserverlessconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: OpenSearchServerlessConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.OpenSearchServerlessConfiguration OpensearchServerlessConfiguration { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// MongoDbAtlasConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-mongodbatlasconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: MongoDbAtlasConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.MongoDbAtlasConfiguration MongoDbAtlasConfiguration { get; set; }
            /// <summary>
            /// RdsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-rdsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: RdsConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.RdsConfiguration RdsConfiguration { get; set; }
            /// <summary>
            /// PineconeConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-storageconfiguration.html#cfn-bedrock-knowledgebase-storageconfiguration-pineconeconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PineconeConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.PineconeConfiguration PineconeConfiguration { get; set; }
        }

        public class SupplementalDataStorageConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SupplementalDataStorageLocations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-supplementaldatastorageconfiguration.html#cfn-bedrock-knowledgebase-supplementaldatastorageconfiguration-supplementaldatastoragelocations
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SupplementalDataStorageLocation
            /// </summary>
            public List<Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageLocation> SupplementalDataStorageLocations { get; set; }
        }

        public class SupplementalDataStorageLocation : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SupplementalDataStorageLocationType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-supplementaldatastoragelocation.html#cfn-bedrock-knowledgebase-supplementaldatastoragelocation-supplementaldatastoragelocationtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SupplementalDataStorageLocationType { get; set; }
            /// <summary>
            /// S3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-supplementaldatastoragelocation.html#cfn-bedrock-knowledgebase-supplementaldatastoragelocation-s3location
            /// Required: False
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.S3Location S3Location { get; set; }
        }

        public class VectorKnowledgeBaseConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EmbeddingModelConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-vectorknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-vectorknowledgebaseconfiguration-embeddingmodelconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EmbeddingModelConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.EmbeddingModelConfiguration EmbeddingModelConfiguration { get; set; }
            /// <summary>
            /// EmbeddingModelArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-vectorknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-vectorknowledgebaseconfiguration-embeddingmodelarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmbeddingModelArn { get; set; }
            /// <summary>
            /// SupplementalDataStorageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-bedrock-knowledgebase-vectorknowledgebaseconfiguration.html#cfn-bedrock-knowledgebase-vectorknowledgebaseconfiguration-supplementaldatastorageconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: SupplementalDataStorageConfiguration
            /// </summary>
            public Humidifier.Bedrock.KnowledgeBaseTypes.SupplementalDataStorageConfiguration SupplementalDataStorageConfiguration { get; set; }
        }
    }
}