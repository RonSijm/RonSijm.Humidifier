namespace Humidifier.SCN
{
    using global::System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveInstanceId, IHaveSCNDatasetTypesSchemaSchema, IHaveSCNDatasetTypesPartitionSpecPartitionSpec, IHaveNamespace_, IHaveName
    {
        public class Attributes
        {
            public static string CreatedTime =  "CreatedTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName { get => AWS.SCN.Dataset; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? InstanceId { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-schema
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Schema
        /// </summary>
        public Union<Humidifier.SCN.DatasetTypes.Schema, BaseFunction>? Schema { get; set; }
        /// <summary>
        /// PartitionSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-partitionspec
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PartitionSpec
        /// </summary>
        public Union<Humidifier.SCN.DatasetTypes.PartitionSpec, BaseFunction>? PartitionSpec { get; set; }

        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-namespace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Namespace_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace DatasetTypes
    {
        public class DataLakeDatasetPartitionField : Humidifier.Base.BaseSubResource, IHaveSCNDatasetTypesTransformTransform, IHaveName
        {
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetpartitionfield.html#cfn-scn-dataset-datalakedatasetpartitionfield-transform
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Transform
            /// </summary>
            public Union<Humidifier.SCN.DatasetTypes.Transform, BaseFunction>? Transform { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetpartitionfield.html#cfn-scn-dataset-datalakedatasetpartitionfield-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DataLakeDatasetPrimaryKeyField : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetprimarykeyfield.html#cfn-scn-dataset-datalakedatasetprimarykeyfield-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DataLakeDatasetSchemaField : Humidifier.Base.BaseSubResource, IHaveType, IHaveIsRequired_Boolean, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetschemafield.html#cfn-scn-dataset-datalakedatasetschemafield-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// IsRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetschemafield.html#cfn-scn-dataset-datalakedatasetschemafield-isrequired
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? IsRequired { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetschemafield.html#cfn-scn-dataset-datalakedatasetschemafield-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class PartitionSpec : Humidifier.Base.BaseSubResource, IHaveListOfSCNDatasetTypesDataLakeDatasetPartitionFieldFields
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-partitionspec.html#cfn-scn-dataset-partitionspec-fields
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DataLakeDatasetPartitionField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SCN.DatasetTypes.DataLakeDatasetPartitionField>, IReadOnlyList<Union<Humidifier.SCN.DatasetTypes.DataLakeDatasetPartitionField, BaseFunction>>, BaseFunction>? Fields { get; set; }
        }

        public class Schema : Humidifier.Base.BaseSubResource, IHaveListOfSCNDatasetTypesDataLakeDatasetSchemaFieldFields, IHaveListOfSCNDatasetTypesDataLakeDatasetPrimaryKeyFieldPrimaryKeys, IHaveName
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-schema.html#cfn-scn-dataset-schema-fields
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DataLakeDatasetSchemaField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SCN.DatasetTypes.DataLakeDatasetSchemaField>, IReadOnlyList<Union<Humidifier.SCN.DatasetTypes.DataLakeDatasetSchemaField, BaseFunction>>, BaseFunction>? Fields { get; set; }
            /// <summary>
            /// PrimaryKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-schema.html#cfn-scn-dataset-schema-primarykeys
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DataLakeDatasetPrimaryKeyField
            /// </summary>
            public Union<IReadOnlyList<Humidifier.SCN.DatasetTypes.DataLakeDatasetPrimaryKeyField>, IReadOnlyList<Union<Humidifier.SCN.DatasetTypes.DataLakeDatasetPrimaryKeyField, BaseFunction>>, BaseFunction>? PrimaryKeys { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-schema.html#cfn-scn-dataset-schema-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class Transform : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-transform.html#cfn-scn-dataset-transform-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
        }
    }
}