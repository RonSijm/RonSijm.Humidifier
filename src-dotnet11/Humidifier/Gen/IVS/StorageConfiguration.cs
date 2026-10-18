namespace Humidifier.IVS
{
    using global::System.Collections.Generic;
    using StorageConfigurationTypes;

    public class StorageConfiguration : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveIVSStorageConfigurationTypesS3StorageConfigurationS3, IHaveName
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.IVS.StorageConfiguration; }

        /// <summary>
        /// S3
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-storageconfiguration.html#cfn-ivs-storageconfiguration-s3
        /// Required: True
        /// UpdateType: Immutable
        /// Type: S3StorageConfiguration
        /// </summary>
        [Required]
        public Union<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration, BaseFunction>? S3 { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ivs-storageconfiguration.html#cfn-ivs-storageconfiguration-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace StorageConfigurationTypes
    {
        public class S3StorageConfiguration : Humidifier.Base.BaseSubResource, IHaveBucketName
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ivs-storageconfiguration-s3storageconfiguration.html#cfn-ivs-storageconfiguration-s3storageconfiguration-bucketname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
        }
    }
}