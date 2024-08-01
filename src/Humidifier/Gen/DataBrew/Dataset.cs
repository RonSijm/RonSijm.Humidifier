namespace Humidifier.DataBrew
{
    using System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags
    {
        public override string AWSTypeName { get => AWS.DataBrew.Dataset; }

        /// <summary>
        /// Input
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-input
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Input
        /// </summary>
        [Required]
        public DatasetTypes.Input Input { get; set; }
        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-format
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Format { get; set; }
        /// <summary>
        /// FormatOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-formatoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FormatOptions
        /// </summary>
        public DatasetTypes.FormatOptions FormatOptions { get; set; }
        /// <summary>
        /// PathOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-pathoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PathOptions
        /// </summary>
        public DatasetTypes.PathOptions PathOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace DatasetTypes
    {
        public class CsvOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-csvoptions.html#cfn-databrew-dataset-csvoptions-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Delimiter { get; set; }
            /// <summary>
            /// HeaderRow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-csvoptions.html#cfn-databrew-dataset-csvoptions-headerrow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic HeaderRow { get; set; }
        }

        public class DataCatalogInputDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html#cfn-databrew-dataset-datacataloginputdefinition-tablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// TempDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html#cfn-databrew-dataset-datacataloginputdefinition-tempdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public DatasetTypes.S3Location TempDirectory { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html#cfn-databrew-dataset-datacataloginputdefinition-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html#cfn-databrew-dataset-datacataloginputdefinition-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
        }

        public class DatabaseInputDefinition : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// TempDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html#cfn-databrew-dataset-databaseinputdefinition-tempdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public DatasetTypes.S3Location TempDirectory { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html#cfn-databrew-dataset-databaseinputdefinition-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic QueryString { get; set; }
            /// <summary>
            /// GlueConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html#cfn-databrew-dataset-databaseinputdefinition-glueconnectionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlueConnectionName { get; set; }
            /// <summary>
            /// DatabaseTableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html#cfn-databrew-dataset-databaseinputdefinition-databasetablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseTableName { get; set; }
        }

        public class DatasetParameter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// DatetimeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-datetimeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatetimeOptions
            /// </summary>
            public DatasetTypes.DatetimeOptions DatetimeOptions { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterExpression
            /// </summary>
            public DatasetTypes.FilterExpression Filter { get; set; }
            /// <summary>
            /// CreateColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-createcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CreateColumn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class DatetimeOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// LocaleCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datetimeoptions.html#cfn-databrew-dataset-datetimeoptions-localecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LocaleCode { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datetimeoptions.html#cfn-databrew-dataset-datetimeoptions-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// TimezoneOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datetimeoptions.html#cfn-databrew-dataset-datetimeoptions-timezoneoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimezoneOffset { get; set; }
        }

        public class ExcelOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// HeaderRow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-exceloptions.html#cfn-databrew-dataset-exceloptions-headerrow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic HeaderRow { get; set; }
            /// <summary>
            /// SheetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-exceloptions.html#cfn-databrew-dataset-exceloptions-sheetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SheetNames { get; set; }
            /// <summary>
            /// SheetIndexes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-exceloptions.html#cfn-databrew-dataset-exceloptions-sheetindexes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public List<int> SheetIndexes { get; set; }
        }

        public class FilesLimit : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-fileslimit.html#cfn-databrew-dataset-fileslimit-order
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Order { get; set; }
            /// <summary>
            /// OrderedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-fileslimit.html#cfn-databrew-dataset-fileslimit-orderedby
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OrderedBy { get; set; }
            /// <summary>
            /// MaxFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-fileslimit.html#cfn-databrew-dataset-fileslimit-maxfiles
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxFiles { get; set; }
        }

        public class FilterExpression : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filterexpression.html#cfn-databrew-dataset-filterexpression-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Expression { get; set; }
            /// <summary>
            /// ValuesMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filterexpression.html#cfn-databrew-dataset-filterexpression-valuesmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterValue
            /// </summary>
            public List<DatasetTypes.FilterValue> ValuesMap { get; set; }
        }

        public class FilterValue : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filtervalue.html#cfn-databrew-dataset-filtervalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value { get; set; }
            /// <summary>
            /// ValueReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filtervalue.html#cfn-databrew-dataset-filtervalue-valuereference
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValueReference { get; set; }
        }

        public class FormatOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Excel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-formatoptions.html#cfn-databrew-dataset-formatoptions-excel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExcelOptions
            /// </summary>
            public DatasetTypes.ExcelOptions Excel { get; set; }
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-formatoptions.html#cfn-databrew-dataset-formatoptions-csv
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CsvOptions
            /// </summary>
            public DatasetTypes.CsvOptions Csv { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-formatoptions.html#cfn-databrew-dataset-formatoptions-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonOptions
            /// </summary>
            public DatasetTypes.JsonOptions Json { get; set; }
        }

        public class Input : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// DatabaseInputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html#cfn-databrew-dataset-input-databaseinputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseInputDefinition
            /// </summary>
            public DatasetTypes.DatabaseInputDefinition DatabaseInputDefinition { get; set; }
            /// <summary>
            /// S3InputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html#cfn-databrew-dataset-input-s3inputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public DatasetTypes.S3Location S3InputDefinition { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html#cfn-databrew-dataset-input-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Metadata
            /// </summary>
            public DatasetTypes.Metadata Metadata { get; set; }
            /// <summary>
            /// DataCatalogInputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html#cfn-databrew-dataset-input-datacataloginputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataCatalogInputDefinition
            /// </summary>
            public DatasetTypes.DataCatalogInputDefinition DataCatalogInputDefinition { get; set; }
        }

        public class JsonOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MultiLine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-jsonoptions.html#cfn-databrew-dataset-jsonoptions-multiline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic MultiLine { get; set; }
        }

        public class Metadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-metadata.html#cfn-databrew-dataset-metadata-sourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceArn { get; set; }
        }

        public class PathOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathoptions.html#cfn-databrew-dataset-pathoptions-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PathParameter
            /// </summary>
            public List<DatasetTypes.PathParameter> Parameters { get; set; }
            /// <summary>
            /// LastModifiedDateCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathoptions.html#cfn-databrew-dataset-pathoptions-lastmodifieddatecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterExpression
            /// </summary>
            public DatasetTypes.FilterExpression LastModifiedDateCondition { get; set; }
            /// <summary>
            /// FilesLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathoptions.html#cfn-databrew-dataset-pathoptions-fileslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilesLimit
            /// </summary>
            public DatasetTypes.FilesLimit FilesLimit { get; set; }
        }

        public class PathParameter : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// PathParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathparameter.html#cfn-databrew-dataset-pathparameter-pathparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PathParameterName { get; set; }
            /// <summary>
            /// DatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathparameter.html#cfn-databrew-dataset-pathparameter-datasetparameter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DatasetParameter
            /// </summary>
            public DatasetTypes.DatasetParameter DatasetParameter { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-s3location.html#cfn-databrew-dataset-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-s3location.html#cfn-databrew-dataset-s3location-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}