namespace Humidifier.DataBrew
{
    using global::System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveMaxRetries_Integer, IHaveProjectName, IHaveDataBrewJobTypesRecipeRecipe, IHaveEncryptionKeyArn, IHaveLogSubscription, IHaveTimeout_Integer, IHaveListOfDataBrewJobTypesDatabaseOutputDatabaseOutputs, IHaveDataBrewJobTypesOutputLocationOutputLocation, IHaveRoleArn, IHaveName, IHaveType, IHaveDatasetName, IHaveDataBrewJobTypesProfileConfigurationProfileConfiguration, IHaveListOfDataBrewJobTypesOutputOutputs, IHaveListOfDataBrewJobTypesValidationConfigurationValidationConfigurations, IHaveDataBrewJobTypesJobSampleJobSample, IHaveEncryptionMode, IHaveMaxCapacity_Integer, IHaveListOfDataBrewJobTypesDataCatalogOutputDataCatalogOutputs
    {
        public override string AWSTypeName { get => AWS.DataBrew.Job; }
        /// <summary>
        /// MaxRetries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-maxretries
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxRetries { get; set; }
        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-projectname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ProjectName { get; set; }
        /// <summary>
        /// Recipe
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-recipe
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Recipe
        /// </summary>
        public Union<Humidifier.DataBrew.JobTypes.Recipe, BaseFunction>? Recipe { get; set; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-encryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionKeyArn { get; set; }
        /// <summary>
        /// LogSubscription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-logsubscription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogSubscription { get; set; }
        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? Timeout { get; set; }
        /// <summary>
        /// DatabaseOutputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-databaseoutputs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DatabaseOutput
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataBrew.JobTypes.DatabaseOutput>, IReadOnlyList<Union<Humidifier.DataBrew.JobTypes.DatabaseOutput, BaseFunction>>, BaseFunction>? DatabaseOutputs { get; set; }
        /// <summary>
        /// OutputLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-outputlocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutputLocation
        /// </summary>
        public Union<Humidifier.DataBrew.JobTypes.OutputLocation, BaseFunction>? OutputLocation { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// DatasetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-datasetname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatasetName { get; set; }
        /// <summary>
        /// ProfileConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-profileconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProfileConfiguration
        /// </summary>
        public Union<Humidifier.DataBrew.JobTypes.ProfileConfiguration, BaseFunction>? ProfileConfiguration { get; set; }
        /// <summary>
        /// Outputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-outputs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Output
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataBrew.JobTypes.Output>, IReadOnlyList<Union<Humidifier.DataBrew.JobTypes.Output, BaseFunction>>, BaseFunction>? Outputs { get; set; }
        /// <summary>
        /// ValidationConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-validationconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ValidationConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataBrew.JobTypes.ValidationConfiguration>, IReadOnlyList<Union<Humidifier.DataBrew.JobTypes.ValidationConfiguration, BaseFunction>>, BaseFunction>? ValidationConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// JobSample
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-jobsample
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JobSample
        /// </summary>
        public Union<Humidifier.DataBrew.JobTypes.JobSample, BaseFunction>? JobSample { get; set; }
        /// <summary>
        /// EncryptionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-encryptionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? EncryptionMode { get; set; }
        /// <summary>
        /// MaxCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-maxcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? MaxCapacity { get; set; }
        /// <summary>
        /// DataCatalogOutputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-datacatalogoutputs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataCatalogOutput
        /// </summary>
        public Union<IReadOnlyList<Humidifier.DataBrew.JobTypes.DataCatalogOutput>, IReadOnlyList<Union<Humidifier.DataBrew.JobTypes.DataCatalogOutput, BaseFunction>>, BaseFunction>? DataCatalogOutputs { get; set; }
    }

    namespace JobTypes
    {
        public class AllowedStatistics : Humidifier.Base.BaseSubResource, IHaveStringListOfStatistics
        {
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-allowedstatistics.html#cfn-databrew-job-allowedstatistics-statistics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Statistics { get; set; }
        }

        public class ColumnSelector : Humidifier.Base.BaseSubResource, IHaveRegex, IHaveName
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnselector.html#cfn-databrew-job-columnselector-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Regex { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnselector.html#cfn-databrew-job-columnselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class ColumnStatisticsConfiguration : Humidifier.Base.BaseSubResource, IHaveDataBrewJobTypesStatisticsConfigurationStatistics, IHaveListOfDataBrewJobTypesColumnSelectorSelectors
        {
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnstatisticsconfiguration.html#cfn-databrew-job-columnstatisticsconfiguration-statistics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StatisticsConfiguration
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.StatisticsConfiguration, BaseFunction>? Statistics { get; set; }
            /// <summary>
            /// Selectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnstatisticsconfiguration.html#cfn-databrew-job-columnstatisticsconfiguration-selectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.JobTypes.ColumnSelector>, IReadOnlyList<Union<Humidifier.DataBrew.JobTypes.ColumnSelector, BaseFunction>>, BaseFunction>? Selectors { get; set; }
        }

        public class CsvOutputOptions : Humidifier.Base.BaseSubResource, IHaveDelimiter
        {
            /// <summary>
            /// Delimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-csvoutputoptions.html#cfn-databrew-job-csvoutputoptions-delimiter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Delimiter { get; set; }
        }

        public class DataCatalogOutput : Humidifier.Base.BaseSubResource, IHaveTableName, IHaveOverwrite_Boolean, IHaveDataBrewJobTypesS3TableOutputOptionsS3Options, IHaveDataBrewJobTypesDatabaseTableOutputOptionsDatabaseOptions, IHaveDatabaseName, IHaveCatalogId
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
            /// <summary>
            /// Overwrite
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-overwrite
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Overwrite { get; set; }
            /// <summary>
            /// S3Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-s3options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3TableOutputOptions
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.S3TableOutputOptions, BaseFunction>? S3Options { get; set; }
            /// <summary>
            /// DatabaseOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-databaseoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseTableOutputOptions
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions, BaseFunction>? DatabaseOptions { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CatalogId { get; set; }
        }

        public class DatabaseOutput : Humidifier.Base.BaseSubResource, IHaveDatabaseOutputMode, IHaveDataBrewJobTypesDatabaseTableOutputOptionsDatabaseOptions, IHaveGlueConnectionName
        {
            /// <summary>
            /// DatabaseOutputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databaseoutput.html#cfn-databrew-job-databaseoutput-databaseoutputmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DatabaseOutputMode { get; set; }
            /// <summary>
            /// DatabaseOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databaseoutput.html#cfn-databrew-job-databaseoutput-databaseoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DatabaseTableOutputOptions
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions, BaseFunction>? DatabaseOptions { get; set; }
            /// <summary>
            /// GlueConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databaseoutput.html#cfn-databrew-job-databaseoutput-glueconnectionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? GlueConnectionName { get; set; }
        }

        public class DatabaseTableOutputOptions : Humidifier.Base.BaseSubResource, IHaveDataBrewJobTypesS3LocationTempDirectory, IHaveTableName
        {
            /// <summary>
            /// TempDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databasetableoutputoptions.html#cfn-databrew-job-databasetableoutputoptions-tempdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.S3Location, BaseFunction>? TempDirectory { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databasetableoutputoptions.html#cfn-databrew-job-databasetableoutputoptions-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? TableName { get; set; }
        }

        public class EntityDetectorConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfEntityTypes, IHaveDataBrewJobTypesAllowedStatisticsAllowedStatistics
        {
            /// <summary>
            /// EntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-entitydetectorconfiguration.html#cfn-databrew-job-entitydetectorconfiguration-entitytypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? EntityTypes { get; set; }
            /// <summary>
            /// AllowedStatistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-entitydetectorconfiguration.html#cfn-databrew-job-entitydetectorconfiguration-allowedstatistics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowedStatistics
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.AllowedStatistics, BaseFunction>? AllowedStatistics { get; set; }
        }

        public class JobSample : Humidifier.Base.BaseSubResource, IHaveSize_Long, IHaveMode
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-jobsample.html#cfn-databrew-job-jobsample-size
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public Union<long, BaseFunction>? Size { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-jobsample.html#cfn-databrew-job-jobsample-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Mode { get; set; }
        }

        public class Output : Humidifier.Base.BaseSubResource, IHaveOverwrite_Boolean, IHaveFormat, IHaveMaxOutputFiles_Integer, IHaveCompressionFormat, IHaveStringListOfPartitionColumns, IHaveDataBrewJobTypesOutputFormatOptionsFormatOptions, IHaveDataBrewJobTypesS3LocationLocation
        {
            /// <summary>
            /// Overwrite
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-overwrite
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? Overwrite { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Format { get; set; }
            /// <summary>
            /// MaxOutputFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-maxoutputfiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxOutputFiles { get; set; }
            /// <summary>
            /// CompressionFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-compressionformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CompressionFormat { get; set; }
            /// <summary>
            /// PartitionColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-partitioncolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? PartitionColumns { get; set; }
            /// <summary>
            /// FormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-formatoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputFormatOptions
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.OutputFormatOptions, BaseFunction>? FormatOptions { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.S3Location, BaseFunction>? Location { get; set; }
        }

        public class OutputFormatOptions : Humidifier.Base.BaseSubResource, IHaveDataBrewJobTypesCsvOutputOptionsCsv
        {
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputformatoptions.html#cfn-databrew-job-outputformatoptions-csv
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CsvOutputOptions
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.CsvOutputOptions, BaseFunction>? Csv { get; set; }
        }

        public class OutputLocation : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveBucketOwner, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputlocation.html#cfn-databrew-job-outputlocation-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputlocation.html#cfn-databrew-job-outputlocation-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputlocation.html#cfn-databrew-job-outputlocation-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class ProfileConfiguration : Humidifier.Base.BaseSubResource, IHaveListOfDataBrewJobTypesColumnSelectorProfileColumns, IHaveDataBrewJobTypesStatisticsConfigurationDatasetStatisticsConfiguration, IHaveListOfDataBrewJobTypesColumnStatisticsConfigurationColumnStatisticsConfigurations, IHaveDataBrewJobTypesEntityDetectorConfigurationEntityDetectorConfiguration
        {
            /// <summary>
            /// ProfileColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html#cfn-databrew-job-profileconfiguration-profilecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnSelector
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.JobTypes.ColumnSelector>, IReadOnlyList<Union<Humidifier.DataBrew.JobTypes.ColumnSelector, BaseFunction>>, BaseFunction>? ProfileColumns { get; set; }
            /// <summary>
            /// DatasetStatisticsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html#cfn-databrew-job-profileconfiguration-datasetstatisticsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatisticsConfiguration
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.StatisticsConfiguration, BaseFunction>? DatasetStatisticsConfiguration { get; set; }
            /// <summary>
            /// ColumnStatisticsConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html#cfn-databrew-job-profileconfiguration-columnstatisticsconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnStatisticsConfiguration
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.JobTypes.ColumnStatisticsConfiguration>, IReadOnlyList<Union<Humidifier.DataBrew.JobTypes.ColumnStatisticsConfiguration, BaseFunction>>, BaseFunction>? ColumnStatisticsConfigurations { get; set; }
            /// <summary>
            /// EntityDetectorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html#cfn-databrew-job-profileconfiguration-entitydetectorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EntityDetectorConfiguration
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.EntityDetectorConfiguration, BaseFunction>? EntityDetectorConfiguration { get; set; }
        }

        public class Recipe : Humidifier.Base.BaseSubResource, IHaveVersion, IHaveName
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-recipe.html#cfn-databrew-job-recipe-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-recipe.html#cfn-databrew-job-recipe-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Name { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveBucketOwner, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-s3location.html#cfn-databrew-job-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-s3location.html#cfn-databrew-job-s3location-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? BucketOwner { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-s3location.html#cfn-databrew-job-s3location-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }

        public class S3TableOutputOptions : Humidifier.Base.BaseSubResource, IHaveDataBrewJobTypesS3LocationLocation
        {
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-s3tableoutputoptions.html#cfn-databrew-job-s3tableoutputoptions-location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.DataBrew.JobTypes.S3Location, BaseFunction>? Location { get; set; }
        }

        public class StatisticOverride : Humidifier.Base.BaseSubResource, IHaveStringDictionaryOfParameters, IHaveStatistic
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticoverride.html#cfn-databrew-job-statisticoverride-parameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyDictionary<string, string>, IReadOnlyDictionary<string, Union<string, BaseFunction>>, BaseFunction>? Parameters { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticoverride.html#cfn-databrew-job-statisticoverride-statistic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Statistic { get; set; }
        }

        public class StatisticsConfiguration : Humidifier.Base.BaseSubResource, IHaveStringListOfIncludedStatistics, IHaveListOfDataBrewJobTypesStatisticOverrideOverrides
        {
            /// <summary>
            /// IncludedStatistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticsconfiguration.html#cfn-databrew-job-statisticsconfiguration-includedstatistics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IncludedStatistics { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticsconfiguration.html#cfn-databrew-job-statisticsconfiguration-overrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatisticOverride
            /// </summary>
            public Union<IReadOnlyList<Humidifier.DataBrew.JobTypes.StatisticOverride>, IReadOnlyList<Union<Humidifier.DataBrew.JobTypes.StatisticOverride, BaseFunction>>, BaseFunction>? Overrides { get; set; }
        }

        public class ValidationConfiguration : Humidifier.Base.BaseSubResource, IHaveRulesetArn, IHaveValidationMode
        {
            /// <summary>
            /// RulesetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-validationconfiguration.html#cfn-databrew-job-validationconfiguration-rulesetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? RulesetArn { get; set; }
            /// <summary>
            /// ValidationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-validationconfiguration.html#cfn-databrew-job-validationconfiguration-validationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ValidationMode { get; set; }
        }
    }
}