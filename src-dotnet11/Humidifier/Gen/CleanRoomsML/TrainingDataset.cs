namespace Humidifier.CleanRoomsML
{
    using global::System.Collections.Generic;
    using TrainingDatasetTypes;

    public class TrainingDataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDescription, IHaveListOfCleanRoomsMLTrainingDatasetTypesDatasetTrainingData, IHaveRoleArn, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string TrainingDatasetArn =  "TrainingDatasetArn" ;
        }

        public override string AWSTypeName { get => AWS.CleanRoomsML.TrainingDataset; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// TrainingData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-trainingdata
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Dataset
        /// </summary>
        [Required]
        public Union<IReadOnlyList<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset>, IReadOnlyList<Union<Humidifier.CleanRoomsML.TrainingDatasetTypes.Dataset, BaseFunction>>, BaseFunction>? TrainingData { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-rolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanroomsml-trainingdataset.html#cfn-cleanroomsml-trainingdataset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }

    namespace TrainingDatasetTypes
    {
        public class ColumnSchema : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveStringListOfColumnTypes
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-columnschema.html#cfn-cleanroomsml-trainingdataset-columnschema-columnname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ColumnName { get; set; }
            /// <summary>
            /// ColumnTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-columnschema.html#cfn-cleanroomsml-trainingdataset-columnschema-columntypes
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? ColumnTypes { get; set; }
        }

        public class DataSource : Humidifier.Base.BaseSubResource, IHaveCleanRoomsMLTrainingDatasetTypesGlueDataSourceGlueDataSource
        {
            /// <summary>
            /// GlueDataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-datasource.html#cfn-cleanroomsml-trainingdataset-datasource-gluedatasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: GlueDataSource
            /// </summary>
            public Union<Humidifier.CleanRoomsML.TrainingDatasetTypes.GlueDataSource, BaseFunction>? GlueDataSource { get; set; }
        }

        public class Dataset : Humidifier.Base.BaseSubResource, IHaveType, IHaveCleanRoomsMLTrainingDatasetTypesDatasetInputConfigInputConfig
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-dataset.html#cfn-cleanroomsml-trainingdataset-dataset-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// InputConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-dataset.html#cfn-cleanroomsml-trainingdataset-dataset-inputconfig
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DatasetInputConfig
            /// </summary>
            public Union<Humidifier.CleanRoomsML.TrainingDatasetTypes.DatasetInputConfig, BaseFunction>? InputConfig { get; set; }
        }

        public class DatasetInputConfig : Humidifier.Base.BaseSubResource, IHaveListOfCleanRoomsMLTrainingDatasetTypesColumnSchemaSchema, IHaveCleanRoomsMLTrainingDatasetTypesDataSourceDataSource
        {
            /// <summary>
            /// Schema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-datasetinputconfig.html#cfn-cleanroomsml-trainingdataset-datasetinputconfig-schema
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: ColumnSchema
            /// </summary>
            public Union<IReadOnlyList<Humidifier.CleanRoomsML.TrainingDatasetTypes.ColumnSchema>, IReadOnlyList<Union<Humidifier.CleanRoomsML.TrainingDatasetTypes.ColumnSchema, BaseFunction>>, BaseFunction>? Schema { get; set; }
            /// <summary>
            /// DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-datasetinputconfig.html#cfn-cleanroomsml-trainingdataset-datasetinputconfig-datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: DataSource
            /// </summary>
            public Union<Humidifier.CleanRoomsML.TrainingDatasetTypes.DataSource, BaseFunction>? DataSource { get; set; }
        }

        public class GlueDataSource : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveDatabaseName, IHaveCatalogId
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-gluedatasource.html#cfn-cleanroomsml-trainingdataset-gluedatasource-tablename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-gluedatasource.html#cfn-cleanroomsml-trainingdataset-gluedatasource-databasename
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanroomsml-trainingdataset-gluedatasource.html#cfn-cleanroomsml-trainingdataset-gluedatasource-catalogid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }
    }
}