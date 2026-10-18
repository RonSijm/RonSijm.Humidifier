namespace Humidifier.S3Vectors
{
    using global::System.Collections.Generic;
    using VectorBucketTypes;

    public class VectorBucket : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveVectorBucketName, IHaveS3VectorsVectorBucketTypesEncryptionConfigurationEncryptionConfiguration
    {
        public class Attributes
        {
            public static string VectorBucketArn =  "VectorBucketArn" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.S3Vectors.VectorBucket; }
        public Union<string, BaseFunction>? VectorBucketName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-vectorbucket.html#cfn-s3vectors-vectorbucket-encryptionconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public Union<Humidifier.S3Vectors.VectorBucketTypes.EncryptionConfiguration, BaseFunction>? EncryptionConfiguration { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3vectors-vectorbucket.html#cfn-s3vectors-vectorbucket-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace VectorBucketTypes
    {
        public class EncryptionConfiguration : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveSseType
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3vectors-vectorbucket-encryptionconfiguration.html#cfn-s3vectors-vectorbucket-encryptionconfiguration-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// SseType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3vectors-vectorbucket-encryptionconfiguration.html#cfn-s3vectors-vectorbucket-encryptionconfiguration-ssetype
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SseType { get; set; }
        }
    }
}