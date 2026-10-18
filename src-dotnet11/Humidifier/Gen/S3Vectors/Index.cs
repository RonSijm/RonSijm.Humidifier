namespace Humidifier.S3Vectors
{
    using global::System.Collections.Generic;
    using IndexTypes;

    public class Index : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDistanceMetric, IHaveIndexName, IHaveVectorBucketArn, IHaveVectorBucketName, IHaveS3VectorsIndexTypesEncryptionConfigurationEncryptionConfiguration, IHaveDataType, IHaveS3VectorsIndexTypesMetadataConfigurationMetadataConfiguration, IHaveDimension_Integer
    {
        public class Attributes
        {
            public static string IndexArn =  "IndexArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.S3Vectors.Index; }

        /// <summary>
        /// DistanceMetric
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-index.html#cfn-s3vectors-index-distancemetric
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DistanceMetric { get; set; }
        public Union<string, BaseFunction>? IndexName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VectorBucketArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-index.html#cfn-s3vectors-index-vectorbucketarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VectorBucketArn { get; set; }
        /// <summary>
        /// VectorBucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-index.html#cfn-s3vectors-index-vectorbucketname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? VectorBucketName { get; set; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-index.html#cfn-s3vectors-index-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.S3Vectors.IndexTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }

        /// <summary>
        /// DataType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-index.html#cfn-s3vectors-index-datatype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DataType { get; set; }
        /// <summary>
        /// MetadataConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-index.html#cfn-s3vectors-index-metadataconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: MetadataConfiguration
        /// </summary>
        public Union<Humidifier.S3Vectors.IndexTypes.MetadataConfiguration, BaseFunction>? MetadataConfiguration { get; set; }

        /// <summary>
        /// Dimension
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-index.html#cfn-s3vectors-index-dimension
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        [Required]
        public Union<int, BaseFunction>? Dimension { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-index.html#cfn-s3vectors-index-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace IndexTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveSseType
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3vectors-index-encryptionconfiguration.html#cfn-s3vectors-index-encryptionconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// SseType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3vectors-index-encryptionconfiguration.html#cfn-s3vectors-index-encryptionconfiguration-ssetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SseType { get; set; }
        }

        public class MetadataConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfNonFilterableMetadataKeys
        {
            /// <summary>
            /// NonFilterableMetadataKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3vectors-index-metadataconfiguration.html#cfn-s3vectors-index-metadataconfiguration-nonfilterablemetadatakeys
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? NonFilterableMetadataKeys { get; set; }
        }
    }
}