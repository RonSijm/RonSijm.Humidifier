namespace Humidifier.Glue
{
    using global::System.Collections.Generic;
    using PartitionTypes;

    public class Partition : Humidifier.Base.BaseResource, IHaveTableName, IHaveDatabaseName, IHaveCatalogId, IHaveGluePartitionTypesPartitionInputPartitionInput
    {
        public class Attributes
        {
            public static string IdentifierPartitionInputValues =  "IdentifierPartitionInputValues" ;
        }

        public override string AWSTypeName { get => AWS.Glue.Partition; }

        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-partition.html#cfn-glue-partition-tablename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? TableName { get; set; }

        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-partition.html#cfn-glue-partition-databasename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatabaseName { get; set; }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-partition.html#cfn-glue-partition-catalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? CatalogId { get; set; }

        /// <summary>
        /// PartitionInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-partition.html#cfn-glue-partition-partitioninput
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PartitionInput
        /// </summary>
        [Required]
        public Union<Humidifier.Glue.PartitionTypes.PartitionInput, BaseFunction>? PartitionInput { get; set; }
    }

    namespace PartitionTypes
    {
        public class Column : Humidifier.Base.BaseSubResource, IHaveComment, IHaveType, IHaveName
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-column.html#cfn-glue-partition-column-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Comment { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-column.html#cfn-glue-partition-column-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-column.html#cfn-glue-partition-column-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Order : Humidifier.Base.BaseSubResource, IHaveColumn, IHaveSortOrder_Integer
        {
            /// <summary>
            /// Column
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-order.html#cfn-glue-partition-order-column
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Column { get; set; }
            /// <summary>
            /// SortOrder
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-order.html#cfn-glue-partition-order-sortorder
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SortOrder { get; set; }
        }

        public class PartitionInput : Humidifier.Base.BaseSubResource, IHaveParameters_Json, IHaveGluePartitionTypesStorageDescriptorStorageDescriptor, IHaveStringListOfValues
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-partitioninput.html#cfn-glue-partition-partitioninput-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// StorageDescriptor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-partitioninput.html#cfn-glue-partition-partitioninput-storagedescriptor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StorageDescriptor
            /// </summary>
            public Union<Humidifier.Glue.PartitionTypes.StorageDescriptor, BaseFunction>? StorageDescriptor { get; set; }
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-partitioninput.html#cfn-glue-partition-partitioninput-values
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Values { get; set; }
        }

        public class SchemaId : Humidifier.Base.BaseSubResource, IHaveRegistryName, IHaveSchemaName, IHaveSchemaArn
        {
            /// <summary>
            /// RegistryName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-schemaid.html#cfn-glue-partition-schemaid-registryname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RegistryName { get; set; }
            /// <summary>
            /// SchemaName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-schemaid.html#cfn-glue-partition-schemaid-schemaname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaName { get; set; }
            /// <summary>
            /// SchemaArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-schemaid.html#cfn-glue-partition-schemaid-schemaarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaArn { get; set; }
        }

        public class SchemaReference : Humidifier.Base.BaseSubResource, IHaveSchemaVersionId, IHaveGluePartitionTypesSchemaIdSchemaId, IHaveSchemaVersionNumber_Integer
        {
            /// <summary>
            /// SchemaVersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-schemareference.html#cfn-glue-partition-schemareference-schemaversionid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SchemaVersionId { get; set; }
            /// <summary>
            /// SchemaId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-schemareference.html#cfn-glue-partition-schemareference-schemaid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaId
            /// </summary>
            public Union<Humidifier.Glue.PartitionTypes.SchemaId, BaseFunction>? SchemaId { get; set; }
            /// <summary>
            /// SchemaVersionNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-schemareference.html#cfn-glue-partition-schemareference-schemaversionnumber
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-serdeinfo.html#cfn-glue-partition-serdeinfo-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// SerializationLibrary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-serdeinfo.html#cfn-glue-partition-serdeinfo-serializationlibrary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SerializationLibrary { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-serdeinfo.html#cfn-glue-partition-serdeinfo-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SkewedColumnNames { get; set; }
            /// <summary>
            /// SkewedColumnValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnvalues
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SkewedColumnValues { get; set; }
            /// <summary>
            /// SkewedColumnValueLocationMaps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-skewedinfo.html#cfn-glue-partition-skewedinfo-skewedcolumnvaluelocationmaps
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? SkewedColumnValueLocationMaps { get; set; }
        }

        public class StorageDescriptor : Humidifier.Base.BaseSubResource, IHaveStoredAsSubDirectories_Boolean, IHaveParameters_Json, IHaveStringListOfBucketColumns, IHaveNumberOfBuckets_Integer, IHaveOutputFormat, IHaveListOfGluePartitionTypesColumnColumns, IHaveGluePartitionTypesSerdeInfoSerdeInfo, IHaveListOfGluePartitionTypesOrderSortColumns, IHaveCompressed_Boolean, IHaveGluePartitionTypesSchemaReferenceSchemaReference, IHaveGluePartitionTypesSkewedInfoSkewedInfo, IHaveInputFormat, IHaveLocation
        {
            /// <summary>
            /// StoredAsSubDirectories
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-storedassubdirectories
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? StoredAsSubDirectories { get; set; }
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public Union<object, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// BucketColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-bucketcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? BucketColumns { get; set; }
            /// <summary>
            /// NumberOfBuckets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-numberofbuckets
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? NumberOfBuckets { get; set; }
            /// <summary>
            /// OutputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-outputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OutputFormat { get; set; }
            /// <summary>
            /// Columns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-columns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Column
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.PartitionTypes.Column>, IReadOnlyList<Union<Humidifier.Glue.PartitionTypes.Column, BaseFunction>>, BaseFunction>? Columns { get; set; }
            /// <summary>
            /// SerdeInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-serdeinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SerdeInfo
            /// </summary>
            public Union<Humidifier.Glue.PartitionTypes.SerdeInfo, BaseFunction>? SerdeInfo { get; set; }
            /// <summary>
            /// SortColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-sortcolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Order
            /// </summary>
            public Union<IReadOnlyList<Humidifier.Glue.PartitionTypes.Order>, IReadOnlyList<Union<Humidifier.Glue.PartitionTypes.Order, BaseFunction>>, BaseFunction>? SortColumns { get; set; }
            /// <summary>
            /// Compressed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-compressed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Compressed { get; set; }
            /// <summary>
            /// SchemaReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-schemareference
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SchemaReference
            /// </summary>
            public Union<Humidifier.Glue.PartitionTypes.SchemaReference, BaseFunction>? SchemaReference { get; set; }
            /// <summary>
            /// SkewedInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-skewedinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SkewedInfo
            /// </summary>
            public Union<Humidifier.Glue.PartitionTypes.SkewedInfo, BaseFunction>? SkewedInfo { get; set; }
            /// <summary>
            /// InputFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-inputformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? InputFormat { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-partition-storagedescriptor.html#cfn-glue-partition-storagedescriptor-location
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Location { get; set; }
        }
    }
}