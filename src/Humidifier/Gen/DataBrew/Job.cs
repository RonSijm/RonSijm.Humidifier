namespace Humidifier.DataBrew
{
    using System.Collections.Generic;
    using JobTypes;

    public class Job : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveType, IHaveRoleArn, IHaveMaxCapacity, IHaveTimeout, IHaveEncryptionKeyArn, IHaveDatasetName, IHaveMaxRetries, IHaveProjectName, IHaveEncryptionMode
    {
        public override string AWSTypeName { get => AWS.DataBrew.Job; }
        /// <summary>
        /// MaxRetries
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-maxretries
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxRetries { get; set; }
        /// <summary>
        /// ProjectName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-projectname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProjectName { get; set; }
        /// <summary>
        /// Recipe
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-recipe
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Recipe
        /// </summary>
        public Humidifier.DataBrew.JobTypes.Recipe Recipe { get; set; }
        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-encryptionkeyarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionKeyArn { get; set; }
        /// <summary>
        /// LogSubscription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-logsubscription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogSubscription { get; set; }
        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Timeout { get; set; }
        /// <summary>
        /// DatabaseOutputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-databaseoutputs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DatabaseOutput
        /// </summary>
        public List<Humidifier.DataBrew.JobTypes.DatabaseOutput> DatabaseOutputs { get; set; }
        /// <summary>
        /// OutputLocation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-outputlocation
        /// Required: False
        /// UpdateType: Mutable
        /// Type: OutputLocation
        /// </summary>
        public Humidifier.DataBrew.JobTypes.OutputLocation OutputLocation { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic RoleArn { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-type
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Type { get; set; }
        /// <summary>
        /// DatasetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-datasetname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatasetName { get; set; }
        /// <summary>
        /// ProfileConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-profileconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProfileConfiguration
        /// </summary>
        public Humidifier.DataBrew.JobTypes.ProfileConfiguration ProfileConfiguration { get; set; }
        /// <summary>
        /// Outputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-outputs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Output
        /// </summary>
        public List<Humidifier.DataBrew.JobTypes.Output> Outputs { get; set; }
        /// <summary>
        /// ValidationConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-validationconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ValidationConfiguration
        /// </summary>
        public List<Humidifier.DataBrew.JobTypes.ValidationConfiguration> ValidationConfigurations { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// JobSample
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-jobsample
        /// Required: False
        /// UpdateType: Mutable
        /// Type: JobSample
        /// </summary>
        public Humidifier.DataBrew.JobTypes.JobSample JobSample { get; set; }
        /// <summary>
        /// EncryptionMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-encryptionmode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionMode { get; set; }
        /// <summary>
        /// MaxCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-maxcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxCapacity { get; set; }
        /// <summary>
        /// DataCatalogOutputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-databrew-job.html#cfn-databrew-job-datacatalogoutputs
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: DataCatalogOutput
        /// </summary>
        public List<Humidifier.DataBrew.JobTypes.DataCatalogOutput> DataCatalogOutputs { get; set; }
    }

    namespace JobTypes
    {
        public class AllowedStatistics : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-allowedstatistics.html#cfn-databrew-job-allowedstatistics-statistics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Statistics { get; set; }
        }

        public class ColumnSelector : Humidifier.Base.BaseSubResource, IHaveName, IHaveRegex
        {
            /// <summary>
            /// Regex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnselector.html#cfn-databrew-job-columnselector-regex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Regex { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnselector.html#cfn-databrew-job-columnselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class ColumnStatisticsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Statistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnstatisticsconfiguration.html#cfn-databrew-job-columnstatisticsconfiguration-statistics
            /// Required: True
            /// UpdateType: Mutable
            /// Type: StatisticsConfiguration
            /// </summary>
            public Humidifier.DataBrew.JobTypes.StatisticsConfiguration Statistics { get; set; }
            /// <summary>
            /// Selectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-columnstatisticsconfiguration.html#cfn-databrew-job-columnstatisticsconfiguration-selectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnSelector
            /// </summary>
            public List<Humidifier.DataBrew.JobTypes.ColumnSelector> Selectors { get; set; }
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
            public dynamic Delimiter { get; set; }
        }

        public class DataCatalogOutput : Humidifier.Base.BaseSubResource, IHaveDatabaseName, IHaveTableName, IHaveCatalogId, IHaveOverwrite, IHaveDataBrewJobTypesDatabaseTableOutputOptionsDatabaseOptions
        {
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
            /// <summary>
            /// Overwrite
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-overwrite
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Overwrite { get; set; }
            /// <summary>
            /// S3Options
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-s3options
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3TableOutputOptions
            /// </summary>
            public Humidifier.DataBrew.JobTypes.S3TableOutputOptions S3Options { get; set; }
            /// <summary>
            /// DatabaseOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-databaseoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseTableOutputOptions
            /// </summary>
            public Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions DatabaseOptions { get; set; }
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName { get; set; }
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-datacatalogoutput.html#cfn-databrew-job-datacatalogoutput-catalogid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId { get; set; }
        }

        public class DatabaseOutput : Humidifier.Base.BaseSubResource, IHaveGlueConnectionName, IHaveDataBrewJobTypesDatabaseTableOutputOptionsDatabaseOptions
        {
            /// <summary>
            /// DatabaseOutputMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databaseoutput.html#cfn-databrew-job-databaseoutput-databaseoutputmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseOutputMode { get; set; }
            /// <summary>
            /// DatabaseOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databaseoutput.html#cfn-databrew-job-databaseoutput-databaseoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DatabaseTableOutputOptions
            /// </summary>
            public Humidifier.DataBrew.JobTypes.DatabaseTableOutputOptions DatabaseOptions { get; set; }
            /// <summary>
            /// GlueConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databaseoutput.html#cfn-databrew-job-databaseoutput-glueconnectionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GlueConnectionName { get; set; }
        }

        public class DatabaseTableOutputOptions : Humidifier.Base.BaseSubResource, IHaveTableName
        {
            /// <summary>
            /// TempDirectory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databasetableoutputoptions.html#cfn-databrew-job-databasetableoutputoptions-tempdirectory
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Humidifier.DataBrew.JobTypes.S3Location TempDirectory { get; set; }
            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-databasetableoutputoptions.html#cfn-databrew-job-databasetableoutputoptions-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName { get; set; }
        }

        public class EntityDetectorConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EntityTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-entitydetectorconfiguration.html#cfn-databrew-job-entitydetectorconfiguration-entitytypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic EntityTypes { get; set; }
            /// <summary>
            /// AllowedStatistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-entitydetectorconfiguration.html#cfn-databrew-job-entitydetectorconfiguration-allowedstatistics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AllowedStatistics
            /// </summary>
            public Humidifier.DataBrew.JobTypes.AllowedStatistics AllowedStatistics { get; set; }
        }

        public class JobSample : Humidifier.Base.BaseSubResource, IHaveMode, IHaveSize
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-jobsample.html#cfn-databrew-job-jobsample-size
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Size { get; set; }
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-jobsample.html#cfn-databrew-job-jobsample-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode { get; set; }
        }

        public class Output : Humidifier.Base.BaseSubResource, IHaveFormat, IHaveOverwrite, IHaveCompressionFormat, IHaveDataBrewJobTypesS3LocationLocation
        {
            /// <summary>
            /// Overwrite
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-overwrite
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Overwrite { get; set; }
            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format { get; set; }
            /// <summary>
            /// MaxOutputFiles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-maxoutputfiles
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxOutputFiles { get; set; }
            /// <summary>
            /// CompressionFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-compressionformat
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionFormat { get; set; }
            /// <summary>
            /// PartitionColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-partitioncolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic PartitionColumns { get; set; }
            /// <summary>
            /// FormatOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-formatoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OutputFormatOptions
            /// </summary>
            public Humidifier.DataBrew.JobTypes.OutputFormatOptions FormatOptions { get; set; }
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-output.html#cfn-databrew-job-output-location
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Humidifier.DataBrew.JobTypes.S3Location Location { get; set; }
        }

        public class OutputFormatOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Csv
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputformatoptions.html#cfn-databrew-job-outputformatoptions-csv
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CsvOutputOptions
            /// </summary>
            public Humidifier.DataBrew.JobTypes.CsvOutputOptions Csv { get; set; }
        }

        public class OutputLocation : Humidifier.Base.BaseSubResource, IHaveKey, IHaveBucket, IHaveBucketOwner
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputlocation.html#cfn-databrew-job-outputlocation-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputlocation.html#cfn-databrew-job-outputlocation-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwner { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputlocation.html#cfn-databrew-job-outputlocation-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class ProfileConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ProfileColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html#cfn-databrew-job-profileconfiguration-profilecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnSelector
            /// </summary>
            public List<Humidifier.DataBrew.JobTypes.ColumnSelector> ProfileColumns { get; set; }
            /// <summary>
            /// DatasetStatisticsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html#cfn-databrew-job-profileconfiguration-datasetstatisticsconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: StatisticsConfiguration
            /// </summary>
            public Humidifier.DataBrew.JobTypes.StatisticsConfiguration DatasetStatisticsConfiguration { get; set; }
            /// <summary>
            /// ColumnStatisticsConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html#cfn-databrew-job-profileconfiguration-columnstatisticsconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ColumnStatisticsConfiguration
            /// </summary>
            public List<Humidifier.DataBrew.JobTypes.ColumnStatisticsConfiguration> ColumnStatisticsConfigurations { get; set; }
            /// <summary>
            /// EntityDetectorConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-profileconfiguration.html#cfn-databrew-job-profileconfiguration-entitydetectorconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EntityDetectorConfiguration
            /// </summary>
            public Humidifier.DataBrew.JobTypes.EntityDetectorConfiguration EntityDetectorConfiguration { get; set; }
        }

        public class Recipe : Humidifier.Base.BaseSubResource, IHaveName, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-recipe.html#cfn-databrew-job-recipe-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-recipe.html#cfn-databrew-job-recipe-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveKey, IHaveBucket, IHaveBucketOwner
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-s3location.html#cfn-databrew-job-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// BucketOwner
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-s3location.html#cfn-databrew-job-s3location-bucketowner
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketOwner { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-s3location.html#cfn-databrew-job-s3location-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
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
            public Humidifier.DataBrew.JobTypes.S3Location Location { get; set; }
        }

        public class StatisticOverride : Humidifier.Base.BaseSubResource, IHaveStatistic
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticoverride.html#cfn-databrew-job-statisticoverride-parameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Parameters { get; set; }
            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticoverride.html#cfn-databrew-job-statisticoverride-statistic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Statistic { get; set; }
        }

        public class StatisticsConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// IncludedStatistics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticsconfiguration.html#cfn-databrew-job-statisticsconfiguration-includedstatistics
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic IncludedStatistics { get; set; }
            /// <summary>
            /// Overrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-statisticsconfiguration.html#cfn-databrew-job-statisticsconfiguration-overrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: StatisticOverride
            /// </summary>
            public List<Humidifier.DataBrew.JobTypes.StatisticOverride> Overrides { get; set; }
        }

        public class ValidationConfiguration : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// RulesetArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-validationconfiguration.html#cfn-databrew-job-validationconfiguration-rulesetarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RulesetArn { get; set; }
            /// <summary>
            /// ValidationMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-validationconfiguration.html#cfn-databrew-job-validationconfiguration-validationmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValidationMode { get; set; }
        }
    }
}