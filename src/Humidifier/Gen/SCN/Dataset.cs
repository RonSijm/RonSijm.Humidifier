namespace Humidifier.SCN
{
    using global::System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveNamespace_, IHaveInstanceId
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
        public dynamic Description { get; set; }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-instanceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic InstanceId { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-schema
        /// Required: False
        /// UpdateType: Immutable
        /// Type: Schema
        /// </summary>
        public Humidifier.SCN.DatasetTypes.Schema Schema { get; set; }
        /// <summary>
        /// PartitionSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-partitionspec
        /// Required: False
        /// UpdateType: Immutable
        /// Type: PartitionSpec
        /// </summary>
        public Humidifier.SCN.DatasetTypes.PartitionSpec PartitionSpec { get; set; }

        /// <summary>
        /// Namespace_
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-namespace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Namespace_ { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-scn-dataset.html#cfn-scn-dataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DatasetTypes
    {
        public class DataLakeDatasetPartitionField : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Transform
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetpartitionfield.html#cfn-scn-dataset-datalakedatasetpartitionfield-transform
            /// Required: True
            /// UpdateType: Immutable
            /// Type: Transform
            /// </summary>
            public Humidifier.SCN.DatasetTypes.Transform Transform { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetpartitionfield.html#cfn-scn-dataset-datalakedatasetpartitionfield-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic Name { get; set; }
        }

        public class DataLakeDatasetSchemaField : Humidifier.Base.BaseSubResource, IHaveName, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetschemafield.html#cfn-scn-dataset-datalakedatasetschemafield-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// IsRequired
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetschemafield.html#cfn-scn-dataset-datalakedatasetschemafield-isrequired
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsRequired { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-datalakedatasetschemafield.html#cfn-scn-dataset-datalakedatasetschemafield-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class PartitionSpec : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-partitionspec.html#cfn-scn-dataset-partitionspec-fields
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DataLakeDatasetPartitionField
            /// </summary>
            public List<Humidifier.SCN.DatasetTypes.DataLakeDatasetPartitionField> Fields { get; set; }
        }

        public class Schema : Humidifier.Base.BaseSubResource, IHaveName
        {
            /// <summary>
            /// Fields
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-schema.html#cfn-scn-dataset-schema-fields
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DataLakeDatasetSchemaField
            /// </summary>
            public List<Humidifier.SCN.DatasetTypes.DataLakeDatasetSchemaField> Fields { get; set; }
            /// <summary>
            /// PrimaryKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-schema.html#cfn-scn-dataset-schema-primarykeys
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: DataLakeDatasetPrimaryKeyField
            /// </summary>
            public List<Humidifier.SCN.DatasetTypes.DataLakeDatasetPrimaryKeyField> PrimaryKeys { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-scn-dataset-schema.html#cfn-scn-dataset-schema-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
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
            public dynamic Type { get; set; }
        }
    }
}