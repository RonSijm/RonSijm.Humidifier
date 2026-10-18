namespace Humidifier.S3Tables
{
    using global::System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveWithoutMetadata, IHaveS3TablesTableTypesStorageClassConfigurationStorageClassConfiguration, IHaveTableName, IHaveTableBucketARN, IHaveOpenTableFormat, IHaveS3TablesTableTypesIcebergMetadataIcebergMetadata, IHaveS3TablesTableTypesCompactionCompaction, IHaveNamespace_, IHaveS3TablesTableTypesSnapshotManagementSnapshotManagement
    {
        public class Attributes
        {
            public static string VersionToken =  "VersionToken" ;
            public static string TableARN =  "TableARN" ;
            public static string WarehouseLocation =  "WarehouseLocation" ;
        }

        public override string AWSTypeName { get => AWS.S3Tables.Table; }
        /// <summary>
        /// WithoutMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-withoutmetadata
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? WithoutMetadata { get; set; }
        /// <summary>
        /// StorageClassConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-storageclassconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: StorageClassConfiguration
        /// </summary>
        public Union<Humidifier.S3Tables.TableTypes.StorageClassConfiguration, BaseFunction>? StorageClassConfiguration { get; set; }
        public Union<string, BaseFunction>? TableName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// TableBucketARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-tablebucketarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TableBucketARN { get; set; }

        /// <summary>
        /// OpenTableFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-opentableformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OpenTableFormat { get; set; }
        /// <summary>
        /// IcebergMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-icebergmetadata
        /// Required: False
        /// UpdateType: Immutable
        /// Type: IcebergMetadata
        /// </summary>
        public Union<Humidifier.S3Tables.TableTypes.IcebergMetadata, BaseFunction>? IcebergMetadata { get; set; }
        /// <summary>
        /// Compaction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-compaction
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Compaction
        /// </summary>
        public Union<Humidifier.S3Tables.TableTypes.Compaction, BaseFunction>? Compaction { get; set; }

        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-namespace
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Namespace_ { get; set; }
        /// <summary>
        /// SnapshotManagement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-snapshotmanagement
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SnapshotManagement
        /// </summary>
        public Union<Humidifier.S3Tables.TableTypes.SnapshotManagement, BaseFunction>? SnapshotManagement { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-s3tables-table.html#cfn-s3tables-table-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace TableTypes
    {
        public class Compaction : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveTargetFileSizeMB_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-compaction.html#cfn-s3tables-table-compaction-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// TargetFileSizeMB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-compaction.html#cfn-s3tables-table-compaction-targetfilesizemb
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? TargetFileSizeMB { get; set; }
        }

        public class IcebergMetadata : Humidifier.Base.BaseSubResource, IHaveS3TablesTableTypesIcebergSchemaIcebergSchema, IHaveS3TablesTableTypesIcebergSortOrderIcebergSortOrder, IHaveS3TablesTableTypesIcebergSchemaV2IcebergSchemaV2, IHaveS3TablesTableTypesIcebergPartitionSpecIcebergPartitionSpec, IHaveStringDictionaryOfTableProperties
        {
            /// <summary>
            /// IcebergSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergmetadata.html#cfn-s3tables-table-icebergmetadata-icebergschema
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IcebergSchema
            /// </summary>
            public Union<Humidifier.S3Tables.TableTypes.IcebergSchema, BaseFunction>? IcebergSchema { get; set; }
            /// <summary>
            /// IcebergSortOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergmetadata.html#cfn-s3tables-table-icebergmetadata-icebergsortorder
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IcebergSortOrder
            /// </summary>
            public Union<Humidifier.S3Tables.TableTypes.IcebergSortOrder, BaseFunction>? IcebergSortOrder { get; set; }
            /// <summary>
            /// IcebergSchemaV2
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergmetadata.html#cfn-s3tables-table-icebergmetadata-icebergschemav2
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IcebergSchemaV2
            /// </summary>
            public Union<Humidifier.S3Tables.TableTypes.IcebergSchemaV2, BaseFunction>? IcebergSchemaV2 { get; set; }
            /// <summary>
            /// IcebergPartitionSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergmetadata.html#cfn-s3tables-table-icebergmetadata-icebergpartitionspec
            /// Required: False
            /// UpdateType: Immutable
            /// Type: IcebergPartitionSpec
            /// </summary>
            public Union<Humidifier.S3Tables.TableTypes.IcebergPartitionSpec, BaseFunction>? IcebergPartitionSpec { get; set; }
            /// <summary>
            /// TableProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergmetadata.html#cfn-s3tables-table-icebergmetadata-tableproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? TableProperties { get; set; }
        }

        public class IcebergPartitionField : Humidifier.Base.BaseSubResource, IHaveSourceId_Integer, IHaveFieldId_Integer, IHaveTransform, IHaveName
        {
            /// <summary>
            /// SourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergpartitionfield.html#cfn-s3tables-table-icebergpartitionfield-sourceid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SourceId { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergpartitionfield.html#cfn-s3tables-table-icebergpartitionfield-fieldid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FieldId { get; set; }
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergpartitionfield.html#cfn-s3tables-table-icebergpartitionfield-transform
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Transform { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergpartitionfield.html#cfn-s3tables-table-icebergpartitionfield-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IcebergPartitionSpec : Humidifier.Base.BaseSubResource, IHaveListOfS3TablesTableTypesIcebergPartitionFieldFields, IHaveSpecId_Integer
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergpartitionspec.html#cfn-s3tables-table-icebergpartitionspec-fields
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: IcebergPartitionField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Tables.TableTypes.IcebergPartitionField>, IReadOnlyList<Union<Humidifier.S3Tables.TableTypes.IcebergPartitionField, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// SpecId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergpartitionspec.html#cfn-s3tables-table-icebergpartitionspec-specid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpecId { get; set; }
        }

        public class IcebergSchema : Humidifier.Base.BaseSubResource, IHaveListOfS3TablesTableTypesSchemaFieldSchemaFieldList
        {
            /// <summary>
            /// SchemaFieldList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergschema.html#cfn-s3tables-table-icebergschema-schemafieldlist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SchemaField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Tables.TableTypes.SchemaField>, IReadOnlyList<Union<Humidifier.S3Tables.TableTypes.SchemaField, BaseFunction>>, BaseFunction>? SchemaFieldList { get; set; }
        }

        public class IcebergSchemaV2 : Humidifier.Base.BaseSubResource, IHaveListOfS3TablesTableTypesSchemaV2FieldSchemaV2FieldList, IHaveSchemaV2FieldType, IHaveSchemaId_Integer, IHaveIntegerListOfIdentifierFieldIds
        {
            /// <summary>
            /// SchemaV2FieldList
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergschemav2.html#cfn-s3tables-table-icebergschemav2-schemav2fieldlist
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SchemaV2Field
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Tables.TableTypes.SchemaV2Field>, IReadOnlyList<Union<Humidifier.S3Tables.TableTypes.SchemaV2Field, BaseFunction>>, BaseFunction>? SchemaV2FieldList { get; set; }
            /// <summary>
            /// SchemaV2FieldType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergschemav2.html#cfn-s3tables-table-icebergschemav2-schemav2fieldtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaV2FieldType { get; set; }
            /// <summary>
            /// SchemaId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergschemav2.html#cfn-s3tables-table-icebergschemav2-schemaid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SchemaId { get; set; }
            /// <summary>
            /// IdentifierFieldIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergschemav2.html#cfn-s3tables-table-icebergschemav2-identifierfieldids
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? IdentifierFieldIds { get; set; }
        }

        public class IcebergSortField : Humidifier.Base.BaseSubResource, IHaveSourceId_Integer, IHaveNullOrder, IHaveTransform, IHaveDirection
        {
            /// <summary>
            /// SourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergsortfield.html#cfn-s3tables-table-icebergsortfield-sourceid
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SourceId { get; set; }
            /// <summary>
            /// NullOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergsortfield.html#cfn-s3tables-table-icebergsortfield-nullorder
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NullOrder { get; set; }
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergsortfield.html#cfn-s3tables-table-icebergsortfield-transform
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Transform { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergsortfield.html#cfn-s3tables-table-icebergsortfield-direction
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Direction { get; set; }
        }

        public class IcebergSortOrder : Humidifier.Base.BaseSubResource, IHaveListOfS3TablesTableTypesIcebergSortFieldFields, IHaveOrderId_Integer
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergsortorder.html#cfn-s3tables-table-icebergsortorder-fields
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: IcebergSortField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.S3Tables.TableTypes.IcebergSortField>, IReadOnlyList<Union<Humidifier.S3Tables.TableTypes.IcebergSortField, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// OrderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-icebergsortorder.html#cfn-s3tables-table-icebergsortorder-orderid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OrderId { get; set; }
        }

        public class SchemaField : Humidifier.Base.BaseSubResource, IHaveType, IHaveRequired_Boolean, IHaveId_Integer, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemafield.html#cfn-s3tables-table-schemafield-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemafield.html#cfn-s3tables-table-schemafield-required
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemafield.html#cfn-s3tables-table-schemafield-id
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemafield.html#cfn-s3tables-table-schemafield-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SchemaV2Field : Humidifier.Base.BaseSubResource, IHaveType_Json, IHaveRequired_Boolean, IHaveDoc, IHaveId_Integer, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemav2field.html#cfn-s3tables-table-schemav2field-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemav2field.html#cfn-s3tables-table-schemav2field-required
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// Doc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemav2field.html#cfn-s3tables-table-schemav2field-doc
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Doc { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemav2field.html#cfn-s3tables-table-schemav2field-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-schemav2field.html#cfn-s3tables-table-schemav2field-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SnapshotManagement : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveMinSnapshotsToKeep_Integer, IHaveMaxSnapshotAgeHours_Integer
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-snapshotmanagement.html#cfn-s3tables-table-snapshotmanagement-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// MinSnapshotsToKeep
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-snapshotmanagement.html#cfn-s3tables-table-snapshotmanagement-minsnapshotstokeep
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MinSnapshotsToKeep { get; set; }
            /// <summary>
            /// MaxSnapshotAgeHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-snapshotmanagement.html#cfn-s3tables-table-snapshotmanagement-maxsnapshotagehours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxSnapshotAgeHours { get; set; }
        }

        public class StorageClassConfiguration : Humidifier.Base.BaseSubResource, IHaveStorageClass
        {
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3tables-table-storageclassconfiguration.html#cfn-s3tables-table-storageclassconfiguration-storageclass
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? StorageClass { get; set; }
        }
    }
}