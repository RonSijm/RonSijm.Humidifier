namespace Humidifier.CleanRoomsML
{
    using System.Collections.Generic;
    using TrainingDatasetTypes;

    public class TrainingDataset : Humidifier.Resource, IHaveTags, IHaveDescription
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TrainingDatasetArn =  "TrainingDatasetArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CleanRoomsML::TrainingDataset";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// TrainingData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-trainingdata
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Dataset
        /// </summary>
        public List<Dataset> TrainingData { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name { get; set; }
    }

    namespace TrainingDatasetTypes
    {
        public class ColumnSchema
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-columnschema.html#cfn-cleanroomsml-trainingdataset-columnschema-columnname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// ColumnTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-columnschema.html#cfn-cleanroomsml-trainingdataset-columnschema-columntypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ColumnTypes { get; set; }
        }

        public class DataSource
        {
            /// <summary>
            /// GlueDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-datasource.html#cfn-cleanroomsml-trainingdataset-datasource-gluedatasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: GlueDataSource
            /// </summary>
            public GlueDataSource GlueDataSource { get; set; }
        }

        public class Dataset
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-dataset.html#cfn-cleanroomsml-trainingdataset-dataset-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// InputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-dataset.html#cfn-cleanroomsml-trainingdataset-dataset-inputconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DatasetInputConfig
            /// </summary>
            public DatasetInputConfig InputConfig { get; set; }
        }

        public class DatasetInputConfig
        {
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-datasetinputconfig.html#cfn-cleanroomsml-trainingdataset-datasetinputconfig-schema
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ColumnSchema
            /// </summary>
            public List<ColumnSchema> Schema { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-datasetinputconfig.html#cfn-cleanroomsml-trainingdataset-datasetinputconfig-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataSource
            /// </summary>
            public DataSource DataSource { get; set; }
        }

        public class GlueDataSource
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-gluedatasource.html#cfn-cleanroomsml-trainingdataset-gluedatasource-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-gluedatasource.html#cfn-cleanroomsml-trainingdataset-gluedatasource-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-gluedatasource.html#cfn-cleanroomsml-trainingdataset-gluedatasource-catalogid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
        }
    }
}