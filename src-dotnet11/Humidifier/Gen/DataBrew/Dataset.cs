namespace Humidifier.DataBrew
{
    using global::System.Collections.Generic;
    using DatasetTypes;

    public class Dataset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveDataBrewDatasetTypesInputInput, IHaveFormat, IHaveDataBrewDatasetTypesFormatOptionsFormatOptions, IHaveSource, IHaveDataBrewDatasetTypesPathOptionsPathOptions, IHaveName
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
        public Union<Humidifier.DataBrew.DatasetTypes.Input, BaseFunction>? Input { get; set; }
        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-format
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Format { get; set; }
        /// <summary>
        /// FormatOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-formatoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: FormatOptions
        /// </summary>
        public Union<Humidifier.DataBrew.DatasetTypes.FormatOptions, BaseFunction>? FormatOptions { get; set; }
        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-source
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Source { get; set; }
        /// <summary>
        /// PathOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-pathoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PathOptions
        /// </summary>
        public Union<Humidifier.DataBrew.DatasetTypes.PathOptions, BaseFunction>? PathOptions { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-dataset.html#cfn-databrew-dataset-tags
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
        public class CsvOptions : Humidifier.Base.BaseSubResource, IHaveDelimiter, IHaveHeaderRow_Boolean
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-csvoptions.html#cfn-databrew-dataset-csvoptions-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Delimiter { get; set; }
            /// <summary>
            /// HeaderRow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-csvoptions.html#cfn-databrew-dataset-csvoptions-headerrow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? HeaderRow { get; set; }
        }

        public class DataCatalogInputDefinition : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveDataBrewDatasetTypesS3LocationTempDirectory, IHaveDatabaseName, IHaveCatalogId
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html#cfn-databrew-dataset-datacataloginputdefinition-tablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// TempDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html#cfn-databrew-dataset-datacataloginputdefinition-tempdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.S3Location, BaseFunction>? TempDirectory { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html#cfn-databrew-dataset-datacataloginputdefinition-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datacataloginputdefinition.html#cfn-databrew-dataset-datacataloginputdefinition-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }

        public class DatabaseInputDefinition : Humidifier.Base.BaseSubResource, IHaveDataBrewDatasetTypesS3LocationTempDirectory, IHaveQueryString, IHaveGlueConnectionName, IHaveDatabaseTableName
        {
            /// <summary>
            /// TempDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html#cfn-databrew-dataset-databaseinputdefinition-tempdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.S3Location, BaseFunction>? TempDirectory { get; set; }
            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html#cfn-databrew-dataset-databaseinputdefinition-querystring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? QueryString { get; set; }
            /// <summary>
            /// GlueConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html#cfn-databrew-dataset-databaseinputdefinition-glueconnectionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlueConnectionName { get; set; }
            /// <summary>
            /// DatabaseTableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-databaseinputdefinition.html#cfn-databrew-dataset-databaseinputdefinition-databasetablename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseTableName { get; set; }
        }

        public class DatasetParameter : Humidifier.Base.BaseSubResource, IHaveType, IHaveDataBrewDatasetTypesDatetimeOptionsDatetimeOptions, IHaveDataBrewDatasetTypesFilterExpressionFilter, IHaveCreateColumn_Boolean, IHaveName
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Type { get; set; }
            /// <summary>
            /// DatetimeOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-datetimeoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatetimeOptions
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.DatetimeOptions, BaseFunction>? DatetimeOptions { get; set; }
            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterExpression
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.FilterExpression, BaseFunction>? Filter { get; set; }
            /// <summary>
            /// CreateColumn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-createcolumn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? CreateColumn { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datasetparameter.html#cfn-databrew-dataset-datasetparameter-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class DatetimeOptions : Humidifier.Base.BaseSubResource, IHaveLocaleCode, IHaveFormat, IHaveTimezoneOffset
        {
            /// <summary>
            /// LocaleCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datetimeoptions.html#cfn-databrew-dataset-datetimeoptions-localecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LocaleCode { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datetimeoptions.html#cfn-databrew-dataset-datetimeoptions-format
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// TimezoneOffset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-datetimeoptions.html#cfn-databrew-dataset-datetimeoptions-timezoneoffset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TimezoneOffset { get; set; }
        }

        public class ExcelOptions : Humidifier.Base.BaseSubResource, IHaveHeaderRow_Boolean, IHaveStringListOfSheetNames, IHaveIntegerListOfSheetIndexes
        {
            /// <summary>
            /// HeaderRow
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-exceloptions.html#cfn-databrew-dataset-exceloptions-headerrow
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? HeaderRow { get; set; }
            /// <summary>
            /// SheetNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-exceloptions.html#cfn-databrew-dataset-exceloptions-sheetnames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? SheetNames { get; set; }
            /// <summary>
            /// SheetIndexes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-exceloptions.html#cfn-databrew-dataset-exceloptions-sheetindexes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: Integer
            /// </summary>
            public Union<IReadOnlyList<int>, IReadOnlyList<Union<int, BaseFunction>>, BaseFunction>? SheetIndexes { get; set; }
        }

        public class FilesLimit : Humidifier.Base.BaseSubResource, IHaveOrder, IHaveOrderedBy, IHaveMaxFiles_Integer
        {
            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-fileslimit.html#cfn-databrew-dataset-fileslimit-order
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Order { get; set; }
            /// <summary>
            /// OrderedBy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-fileslimit.html#cfn-databrew-dataset-fileslimit-orderedby
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? OrderedBy { get; set; }
            /// <summary>
            /// MaxFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-fileslimit.html#cfn-databrew-dataset-fileslimit-maxfiles
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxFiles { get; set; }
        }

        public class FilterExpression : Humidifier.Base.BaseSubResource, IHaveExpression, IHaveListOfDataBrewDatasetTypesFilterValueValuesMap
        {
            /// <summary>
            /// Expression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filterexpression.html#cfn-databrew-dataset-filterexpression-expression
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Expression { get; set; }
            /// <summary>
            /// ValuesMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filterexpression.html#cfn-databrew-dataset-filterexpression-valuesmap
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterValue
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.DatasetTypes.FilterValue>, IReadOnlyList<Union<Humidifier.DataBrew.DatasetTypes.FilterValue, BaseFunction>>, BaseFunction>? ValuesMap { get; set; }
        }

        public class FilterValue : Humidifier.Base.BaseSubResource, IHaveValue, IHaveValueReference
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filtervalue.html#cfn-databrew-dataset-filtervalue-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Value { get; set; }
            /// <summary>
            /// ValueReference
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-filtervalue.html#cfn-databrew-dataset-filtervalue-valuereference
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValueReference { get; set; }
        }

        public class FormatOptions : Humidifier.Base.BaseSubResource, IHaveDataBrewDatasetTypesExcelOptionsExcel, IHaveDataBrewDatasetTypesCsvOptionsCsv, IHaveDataBrewDatasetTypesJsonOptionsJson
        {
            /// <summary>
            /// Excel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-formatoptions.html#cfn-databrew-dataset-formatoptions-excel
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ExcelOptions
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.ExcelOptions, BaseFunction>? Excel { get; set; }
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-formatoptions.html#cfn-databrew-dataset-formatoptions-csv
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CsvOptions
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.CsvOptions, BaseFunction>? Csv { get; set; }
            /// <summary>
            /// Json
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-formatoptions.html#cfn-databrew-dataset-formatoptions-json
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JsonOptions
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.JsonOptions, BaseFunction>? Json { get; set; }
        }

        public class Input : Humidifier.Base.BaseSubResource, IHaveDataBrewDatasetTypesDatabaseInputDefinitionDatabaseInputDefinition, IHaveDataBrewDatasetTypesS3LocationS3InputDefinition, IHaveDataBrewDatasetTypesMetadataMetadata, IHaveDataBrewDatasetTypesDataCatalogInputDefinitionDataCatalogInputDefinition
        {
            /// <summary>
            /// DatabaseInputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html#cfn-databrew-dataset-input-databaseinputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseInputDefinition
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.DatabaseInputDefinition, BaseFunction>? DatabaseInputDefinition { get; set; }
            /// <summary>
            /// S3InputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html#cfn-databrew-dataset-input-s3inputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.S3Location, BaseFunction>? S3InputDefinition { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html#cfn-databrew-dataset-input-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Metadata
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.Metadata, BaseFunction>? Metadata { get; set; }
            /// <summary>
            /// DataCatalogInputDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-input.html#cfn-databrew-dataset-input-datacataloginputdefinition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataCatalogInputDefinition
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.DataCatalogInputDefinition, BaseFunction>? DataCatalogInputDefinition { get; set; }
        }

        public class JsonOptions : Humidifier.Base.BaseSubResource, IHaveMultiLine_Boolean
        {
            /// <summary>
            /// MultiLine
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-jsonoptions.html#cfn-databrew-dataset-jsonoptions-multiline
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? MultiLine { get; set; }
        }

        public class Metadata : Humidifier.Base.BaseSubResource, IHaveSourceArn
        {
            /// <summary>
            /// SourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-metadata.html#cfn-databrew-dataset-metadata-sourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceArn { get; set; }
        }

        public class PathOptions : Humidifier.Base.BaseSubResource, IHaveListOfDataBrewDatasetTypesPathParameterParameters, IHaveDataBrewDatasetTypesFilterExpressionLastModifiedDateCondition, IHaveDataBrewDatasetTypesFilesLimitFilesLimit
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathoptions.html#cfn-databrew-dataset-pathoptions-parameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PathParameter
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.DatasetTypes.PathParameter>, IReadOnlyList<Union<Humidifier.DataBrew.DatasetTypes.PathParameter, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// LastModifiedDateCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathoptions.html#cfn-databrew-dataset-pathoptions-lastmodifieddatecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilterExpression
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.FilterExpression, BaseFunction>? LastModifiedDateCondition { get; set; }
            /// <summary>
            /// FilesLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathoptions.html#cfn-databrew-dataset-pathoptions-fileslimit
            /// Required: False
            /// UpdateType: Mutable
            /// Type: FilesLimit
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.FilesLimit, BaseFunction>? FilesLimit { get; set; }
        }

        public class PathParameter : Humidifier.Base.BaseSubResource, IHavePathParameterName, IHaveDataBrewDatasetTypesDatasetParameterDatasetParameter
        {
            /// <summary>
            /// PathParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathparameter.html#cfn-databrew-dataset-pathparameter-pathparametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PathParameterName { get; set; }
            /// <summary>
            /// DatasetParameter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-pathparameter.html#cfn-databrew-dataset-pathparameter-datasetparameter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DatasetParameter
            /// </summary>
            public Union<Humidifier.DataBrew.DatasetTypes.DatasetParameter, BaseFunction>? DatasetParameter { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveBucketOwner, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-s3location.html#cfn-databrew-dataset-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-s3location.html#cfn-databrew-dataset-s3location-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-dataset-s3location.html#cfn-databrew-dataset-s3location-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}