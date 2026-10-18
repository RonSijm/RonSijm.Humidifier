namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveGlueTableTypesTableInputTableInput, IHaveGlueTableTypesOpenTableFormatInputOpenTableFormatInput, IHaveDatabaseName, IHaveCatalogId, IHaveName
    {
        public override string AWSTypeName { get => AWS.Glue.Table; }
        /// <summary>
        /// TableInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-table.html#cfn-glue-table-tableinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TableInput
        /// </summary>
        public Union<Humidifier.Glue.TableTypes.TableInput, BaseFunction>? TableInput { get; set; }
        /// <summary>
        /// OpenTableFormatInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-table.html#cfn-glue-table-opentableformatinput
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OpenTableFormatInput
        /// </summary>
        public Union<Humidifier.Glue.TableTypes.OpenTableFormatInput, BaseFunction>? OpenTableFormatInput { get; set; }

        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-table.html#cfn-glue-table-databasename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatabaseName { get; set; }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-table.html#cfn-glue-table-catalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CatalogId { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TableTypes
    {
        public class Column : Humidifier.Base.BaseSubResource, IHaveComment, IHaveType, IHaveName
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-column.html#cfn-glue-table-column-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-column.html#cfn-glue-table-column-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-column.html#cfn-glue-table-column-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IcebergInput : Humidifier.Base.BaseSubResource, IHaveGlueTableTypesIcebergTableInputIcebergTableInput, IHaveMetadataOperation, IHaveVersion
        {
            /// <summary>
            /// IcebergTableInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-iceberginput.html#cfn-glue-table-iceberginput-icebergtableinput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IcebergTableInput
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.IcebergTableInput, BaseFunction>? IcebergTableInput { get; set; }
            /// <summary>
            /// MetadataOperation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-iceberginput.html#cfn-glue-table-iceberginput-metadataoperation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MetadataOperation { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-iceberginput.html#cfn-glue-table-iceberginput-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }

        public class IcebergPartitionField : Humidifier.Base.BaseSubResource, IHaveSourceId_Integer, IHaveFieldId_Integer, IHaveTransform, IHaveName
        {
            /// <summary>
            /// SourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergpartitionfield.html#cfn-glue-table-icebergpartitionfield-sourceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SourceId { get; set; }
            /// <summary>
            /// FieldId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergpartitionfield.html#cfn-glue-table-icebergpartitionfield-fieldid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? FieldId { get; set; }
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergpartitionfield.html#cfn-glue-table-icebergpartitionfield-transform
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Transform { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergpartitionfield.html#cfn-glue-table-icebergpartitionfield-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IcebergPartitionSpec : Humidifier.Base.BaseSubResource, IHaveListOfGlueTableTypesIcebergPartitionFieldFields, IHaveSpecId_Integer
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergpartitionspec.html#cfn-glue-table-icebergpartitionspec-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IcebergPartitionField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.TableTypes.IcebergPartitionField>, IReadOnlyList<Union<Humidifier.Glue.TableTypes.IcebergPartitionField, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// SpecId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergpartitionspec.html#cfn-glue-table-icebergpartitionspec-specid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SpecId { get; set; }
        }

        public class IcebergSchema : Humidifier.Base.BaseSubResource, IHaveType, IHaveListOfGlueTableTypesIcebergStructFieldFields, IHaveSchemaId_Integer, IHaveIntegerListOfIdentifierFieldIds
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergschema.html#cfn-glue-table-icebergschema-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergschema.html#cfn-glue-table-icebergschema-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IcebergStructField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.TableTypes.IcebergStructField>, IReadOnlyList<Union<Humidifier.Glue.TableTypes.IcebergStructField, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// SchemaId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergschema.html#cfn-glue-table-icebergschema-schemaid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SchemaId { get; set; }
            /// <summary>
            /// IdentifierFieldIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergschema.html#cfn-glue-table-icebergschema-identifierfieldids
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? IdentifierFieldIds { get; set; }
        }

        public class IcebergSortField : Humidifier.Base.BaseSubResource, IHaveSourceId_Integer, IHaveNullOrder, IHaveTransform, IHaveDirection
        {
            /// <summary>
            /// SourceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergsortfield.html#cfn-glue-table-icebergsortfield-sourceid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SourceId { get; set; }
            /// <summary>
            /// NullOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergsortfield.html#cfn-glue-table-icebergsortfield-nullorder
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NullOrder { get; set; }
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergsortfield.html#cfn-glue-table-icebergsortfield-transform
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Transform { get; set; }
            /// <summary>
            /// Direction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergsortfield.html#cfn-glue-table-icebergsortfield-direction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Direction { get; set; }
        }

        public class IcebergSortOrder : Humidifier.Base.BaseSubResource, IHaveListOfGlueTableTypesIcebergSortFieldFields, IHaveOrderId_Integer
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergsortorder.html#cfn-glue-table-icebergsortorder-fields
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: IcebergSortField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.TableTypes.IcebergSortField>, IReadOnlyList<Union<Humidifier.Glue.TableTypes.IcebergSortField, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// OrderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergsortorder.html#cfn-glue-table-icebergsortorder-orderid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? OrderId { get; set; }
        }

        public class IcebergStructField : Humidifier.Base.BaseSubResource, IHaveType, IHaveRequired_Boolean, IHaveDoc, IHaveId_Integer, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergstructfield.html#cfn-glue-table-icebergstructfield-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Required
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergstructfield.html#cfn-glue-table-icebergstructfield-required
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Required { get; set; }
            /// <summary>
            /// Doc
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergstructfield.html#cfn-glue-table-icebergstructfield-doc
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Doc { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergstructfield.html#cfn-glue-table-icebergstructfield-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergstructfield.html#cfn-glue-table-icebergstructfield-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class IcebergTableInput : Humidifier.Base.BaseSubResource, IHaveGlueTableTypesIcebergSchemaSchema, IHaveGlueTableTypesIcebergSortOrderWriteOrder, IHaveStringDictionaryOfProperties, IHaveGlueTableTypesIcebergPartitionSpecPartitionSpec, IHaveLocation
        {
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergtableinput.html#cfn-glue-table-icebergtableinput-schema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IcebergSchema
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.IcebergSchema, BaseFunction>? Schema { get; set; }
            /// <summary>
            /// WriteOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergtableinput.html#cfn-glue-table-icebergtableinput-writeorder
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IcebergSortOrder
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.IcebergSortOrder, BaseFunction>? WriteOrder { get; set; }
            /// <summary>
            /// Properties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergtableinput.html#cfn-glue-table-icebergtableinput-properties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Properties { get; set; }
            /// <summary>
            /// PartitionSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergtableinput.html#cfn-glue-table-icebergtableinput-partitionspec
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IcebergPartitionSpec
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.IcebergPartitionSpec, BaseFunction>? PartitionSpec { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-icebergtableinput.html#cfn-glue-table-icebergtableinput-location
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class OpenTableFormatInput : Humidifier.Base.BaseSubResource, IHaveGlueTableTypesIcebergInputIcebergInput
        {
            /// <summary>
            /// IcebergInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-opentableformatinput.html#cfn-glue-table-opentableformatinput-iceberginput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IcebergInput
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.IcebergInput, BaseFunction>? IcebergInput { get; set; }
        }

        public class Order : Humidifier.Base.BaseSubResource, IHaveColumn, IHaveSortOrder_Integer
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-order.html#cfn-glue-table-order-column
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Column { get; set; }
            /// <summary>
            /// SortOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-order.html#cfn-glue-table-order-sortorder
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SortOrder { get; set; }
        }

        public class SchemaId : Humidifier.Base.BaseSubResource, IHaveRegistryName, IHaveSchemaName, IHaveSchemaArn
        {
            /// <summary>
            /// RegistryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemaid.html#cfn-glue-table-schemaid-registryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistryName { get; set; }
            /// <summary>
            /// SchemaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemaid.html#cfn-glue-table-schemaid-schemaname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaName { get; set; }
            /// <summary>
            /// SchemaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemaid.html#cfn-glue-table-schemaid-schemaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaArn { get; set; }
        }

        public class SchemaReference : Humidifier.Base.BaseSubResource, IHaveSchemaVersionId, IHaveGlueTableTypesSchemaIdSchemaId, IHaveSchemaVersionNumber_Integer
        {
            /// <summary>
            /// SchemaVersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemareference.html#cfn-glue-table-schemareference-schemaversionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaVersionId { get; set; }
            /// <summary>
            /// SchemaId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemareference.html#cfn-glue-table-schemareference-schemaid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaId
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.SchemaId, BaseFunction>? SchemaId { get; set; }
            /// <summary>
            /// SchemaVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-schemareference.html#cfn-glue-table-schemareference-schemaversionnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SchemaVersionNumber { get; set; }
        }

        public class SerdeInfo : Humidifier.Base.BaseSubResource, IHaveParameters_Json, IHaveSerializationLibrary, IHaveName
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-serdeinfo.html#cfn-glue-table-serdeinfo-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// SerializationLibrary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-serdeinfo.html#cfn-glue-table-serdeinfo-serializationlibrary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SerializationLibrary { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-serdeinfo.html#cfn-glue-table-serdeinfo-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class SkewedInfo : Humidifier.Base.BaseSubResource, IHaveStringListOfSkewedColumnNames, IHaveStringListOfSkewedColumnValues, IHaveSkewedColumnValueLocationMaps_Json
        {
            /// <summary>
            /// SkewedColumnNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-skewedinfo.html#cfn-glue-table-skewedinfo-skewedcolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SkewedColumnNames { get; set; }
            /// <summary>
            /// SkewedColumnValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-skewedinfo.html#cfn-glue-table-skewedinfo-skewedcolumnvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SkewedColumnValues { get; set; }
            /// <summary>
            /// SkewedColumnValueLocationMaps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-skewedinfo.html#cfn-glue-table-skewedinfo-skewedcolumnvaluelocationmaps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SkewedColumnValueLocationMaps { get; set; }
        }

        public class StorageDescriptor : Humidifier.Base.BaseSubResource, IHaveStoredAsSubDirectories_Boolean, IHaveParameters_Json, IHaveStringListOfBucketColumns, IHaveNumberOfBuckets_Integer, IHaveOutputFormat, IHaveListOfGlueTableTypesColumnColumns, IHaveGlueTableTypesSerdeInfoSerdeInfo, IHaveListOfGlueTableTypesOrderSortColumns, IHaveCompressed_Boolean, IHaveGlueTableTypesSchemaReferenceSchemaReference, IHaveGlueTableTypesSkewedInfoSkewedInfo, IHaveInputFormat, IHaveLocation
        {
            /// <summary>
            /// StoredAsSubDirectories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-storedassubdirectories
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StoredAsSubDirectories { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// BucketColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-bucketcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BucketColumns { get; set; }
            /// <summary>
            /// NumberOfBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-numberofbuckets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfBuckets { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-outputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputFormat { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Column
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.TableTypes.Column>, IReadOnlyList<Union<Humidifier.Glue.TableTypes.Column, BaseFunction>>, BaseFunction>? Columns { get; set; }
            /// <summary>
            /// SerdeInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-serdeinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SerdeInfo
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.SerdeInfo, BaseFunction>? SerdeInfo { get; set; }
            /// <summary>
            /// SortColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-sortcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Order
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.TableTypes.Order>, IReadOnlyList<Union<Humidifier.Glue.TableTypes.Order, BaseFunction>>, BaseFunction>? SortColumns { get; set; }
            /// <summary>
            /// Compressed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-compressed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Compressed { get; set; }
            /// <summary>
            /// SchemaReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-schemareference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaReference
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.SchemaReference, BaseFunction>? SchemaReference { get; set; }
            /// <summary>
            /// SkewedInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-skewedinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SkewedInfo
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.SkewedInfo, BaseFunction>? SkewedInfo { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-inputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputFormat { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-storagedescriptor.html#cfn-glue-table-storagedescriptor-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }

        public class TableIdentifier : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveRegion, IHaveCatalogId, IHaveName
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableidentifier.html#cfn-glue-table-tableidentifier-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableidentifier.html#cfn-glue-table-tableidentifier-region
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Region { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableidentifier.html#cfn-glue-table-tableidentifier-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableidentifier.html#cfn-glue-table-tableidentifier-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class TableInput : Humidifier.Base.BaseSubResource, IHaveOwner, IHaveViewOriginalText, IHaveDescription, IHaveTableType, IHaveParameters_Json, IHaveViewExpandedText, IHaveGlueTableTypesViewDefinitionViewDefinition, IHaveGlueTableTypesStorageDescriptorStorageDescriptor, IHaveGlueTableTypesTableIdentifierTargetTable, IHaveListOfGlueTableTypesColumnPartitionKeys, IHaveRetention_Integer, IHaveName
        {
            /// <summary>
            /// Owner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-owner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Owner { get; set; }
            /// <summary>
            /// ViewOriginalText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-vieworiginaltext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewOriginalText { get; set; }
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Description { get; set; }
            /// <summary>
            /// TableType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-tabletype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableType { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// ViewExpandedText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-viewexpandedtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewExpandedText { get; set; }
            /// <summary>
            /// ViewDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-viewdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ViewDefinition
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.ViewDefinition, BaseFunction>? ViewDefinition { get; set; }
            /// <summary>
            /// StorageDescriptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-storagedescriptor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageDescriptor
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.StorageDescriptor, BaseFunction>? StorageDescriptor { get; set; }
            /// <summary>
            /// TargetTable
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-targettable
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableIdentifier
            /// </summary>
            public Union<Humidifier.Glue.TableTypes.TableIdentifier, BaseFunction>? TargetTable { get; set; }
            /// <summary>
            /// PartitionKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-partitionkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Column
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.TableTypes.Column>, IReadOnlyList<Union<Humidifier.Glue.TableTypes.Column, BaseFunction>>, BaseFunction>? PartitionKeys { get; set; }
            /// <summary>
            /// Retention
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-retention
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? Retention { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-tableinput.html#cfn-glue-table-tableinput-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ViewDefinition : Humidifier.Base.BaseSubResource, IHaveStringListOfSubObjects, IHaveIsProtected_Boolean, IHaveDefiner, IHaveListOfGlueTableTypesViewRepresentationRepresentations
        {
            /// <summary>
            /// SubObjects
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewdefinition.html#cfn-glue-table-viewdefinition-subobjects
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SubObjects { get; set; }
            /// <summary>
            /// IsProtected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewdefinition.html#cfn-glue-table-viewdefinition-isprotected
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsProtected { get; set; }
            /// <summary>
            /// Definer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewdefinition.html#cfn-glue-table-viewdefinition-definer
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Definer { get; set; }
            /// <summary>
            /// Representations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewdefinition.html#cfn-glue-table-viewdefinition-representations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ViewRepresentation
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.TableTypes.ViewRepresentation>, IReadOnlyList<Union<Humidifier.Glue.TableTypes.ViewRepresentation, BaseFunction>>, BaseFunction>? Representations { get; set; }
        }

        public class ViewRepresentation : Humidifier.Base.BaseSubResource, IHaveViewOriginalText, IHaveViewExpandedText, IHaveValidationConnection, IHaveDialect, IHaveDialectVersion
        {
            /// <summary>
            /// ViewOriginalText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewrepresentation.html#cfn-glue-table-viewrepresentation-vieworiginaltext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewOriginalText { get; set; }
            /// <summary>
            /// ViewExpandedText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewrepresentation.html#cfn-glue-table-viewrepresentation-viewexpandedtext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ViewExpandedText { get; set; }
            /// <summary>
            /// ValidationConnection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewrepresentation.html#cfn-glue-table-viewrepresentation-validationconnection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidationConnection { get; set; }
            /// <summary>
            /// Dialect
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewrepresentation.html#cfn-glue-table-viewrepresentation-dialect
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Dialect { get; set; }
            /// <summary>
            /// DialectVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-table-viewrepresentation.html#cfn-glue-table-viewrepresentation-dialectversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DialectVersion { get; set; }
        }
    }
}