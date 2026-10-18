namespace Humidifier.Timestream
{
    using global::System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveTableName, IHaveTimestreamTableTypesRetentionPropertiesRetentionProperties, IHaveTimestreamTableTypesSchemaSchema, IHaveDatabaseName, IHaveTimestreamTableTypesMagneticStoreWritePropertiesMagneticStoreWriteProperties
    {
        public class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Timestream.Table; }
        public Union<string, BaseFunction>? TableName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// RetentionProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-table.html#cfn-timestream-table-retentionproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetentionProperties
        /// </summary>
        public Union<Humidifier.Timestream.TableTypes.RetentionProperties, BaseFunction>? RetentionProperties { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-table.html#cfn-timestream-table-schema
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Schema
        /// </summary>
        public Union<Humidifier.Timestream.TableTypes.Schema, BaseFunction>? Schema { get; set; }

        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-table.html#cfn-timestream-table-databasename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatabaseName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-table.html#cfn-timestream-table-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MagneticStoreWriteProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-timestream-table.html#cfn-timestream-table-magneticstorewriteproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MagneticStoreWriteProperties
        /// </summary>
        public Union<Humidifier.Timestream.TableTypes.MagneticStoreWriteProperties, BaseFunction>? MagneticStoreWriteProperties { get; set; }
    }

    namespace TableTypes
    {
        public class MagneticStoreRejectedDataLocation : Humidifier.Base.BaseSubResource, IHaveTimestreamTableTypesS3ConfigurationS3Configuration
        {
            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-magneticstorerejecteddatalocation.html#cfn-timestream-table-magneticstorerejecteddatalocation-s3configuration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Configuration
            /// </summary>
            public Union<Humidifier.Timestream.TableTypes.S3Configuration, BaseFunction>? S3Configuration { get; set; }
        }

        public class MagneticStoreWriteProperties : Humidifier.Base.BaseSubResource, IHaveEnableMagneticStoreWrites_Boolean, IHaveTimestreamTableTypesMagneticStoreRejectedDataLocationMagneticStoreRejectedDataLocation
        {
            /// <summary>
            /// EnableMagneticStoreWrites
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-magneticstorewriteproperties.html#cfn-timestream-table-magneticstorewriteproperties-enablemagneticstorewrites
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? EnableMagneticStoreWrites { get; set; }
            /// <summary>
            /// MagneticStoreRejectedDataLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-magneticstorewriteproperties.html#cfn-timestream-table-magneticstorewriteproperties-magneticstorerejecteddatalocation
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MagneticStoreRejectedDataLocation
            /// </summary>
            public Union<Humidifier.Timestream.TableTypes.MagneticStoreRejectedDataLocation, BaseFunction>? MagneticStoreRejectedDataLocation { get; set; }
        }

        public class PartitionKey : Humidifier.Base.BaseSubResource, IHaveType, IHaveEnforcementInRecord, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-partitionkey.html#cfn-timestream-table-partitionkey-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// EnforcementInRecord
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-partitionkey.html#cfn-timestream-table-partitionkey-enforcementinrecord
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EnforcementInRecord { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-partitionkey.html#cfn-timestream-table-partitionkey-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class RetentionProperties : Humidifier.Base.BaseSubResource, IHaveMagneticStoreRetentionPeriodInDays, IHaveMemoryStoreRetentionPeriodInHours
        {
            /// <summary>
            /// MagneticStoreRetentionPeriodInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-retentionproperties.html#cfn-timestream-table-retentionproperties-magneticstoreretentionperiodindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MagneticStoreRetentionPeriodInDays { get; set; }
            /// <summary>
            /// MemoryStoreRetentionPeriodInHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-retentionproperties.html#cfn-timestream-table-retentionproperties-memorystoreretentionperiodinhours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MemoryStoreRetentionPeriodInHours { get; set; }
        }

        public class S3Configuration : Humidifier.Base.BaseSubResource, IHaveBucketName, IHaveKmsKeyId, IHaveObjectKeyPrefix, IHaveEncryptionOption
        {
            /// <summary>
            /// BucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-s3configuration.html#cfn-timestream-table-s3configuration-bucketname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketName { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-s3configuration.html#cfn-timestream-table-s3configuration-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// ObjectKeyPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-s3configuration.html#cfn-timestream-table-s3configuration-objectkeyprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ObjectKeyPrefix { get; set; }
            /// <summary>
            /// EncryptionOption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-s3configuration.html#cfn-timestream-table-s3configuration-encryptionoption
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionOption { get; set; }
        }

        public class Schema : Humidifier.Base.BaseSubResource, IHaveListOfTimestreamTableTypesPartitionKeyCompositePartitionKey
        {
            /// <summary>
            /// CompositePartitionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-timestream-table-schema.html#cfn-timestream-table-schema-compositepartitionkey
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PartitionKey
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Timestream.TableTypes.PartitionKey>, IReadOnlyList<Union<Humidifier.Timestream.TableTypes.PartitionKey, BaseFunction>>, BaseFunction>? CompositePartitionKey { get; set; }
        }
    }
}