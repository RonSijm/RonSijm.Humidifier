namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using DatasetImportJobTypes;

    public class DatasetImportJob : Humidifier.Base.BaseResource, IHaveTags, IHavePublishAttributionMetricsToS3_Boolean, IHaveDatasetArn, IHaveImportMode, IHaveJobName, IHaveRoleArn, IHavePersonalizeDatasetImportJobTypesDataSourceDataSource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string DatasetImportJobArn =  "DatasetImportJobArn" ;
            public static string LastUpdatedDateTime =  "LastUpdatedDateTime" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.DatasetImportJob; }
        /// <summary>
        /// PublishAttributionMetricsToS3
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetimportjob.html#cfn-personalize-datasetimportjob-publishattributionmetricstos3
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? PublishAttributionMetricsToS3 { get; set; }

        /// <summary>
        /// DatasetArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetimportjob.html#cfn-personalize-datasetimportjob-datasetarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DatasetArn { get; set; }
        /// <summary>
        /// ImportMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetimportjob.html#cfn-personalize-datasetimportjob-importmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImportMode { get; set; }

        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetimportjob.html#cfn-personalize-datasetimportjob-jobname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? JobName { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetimportjob.html#cfn-personalize-datasetimportjob-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetimportjob.html#cfn-personalize-datasetimportjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }

        /// <summary>
        /// DataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datasetimportjob.html#cfn-personalize-datasetimportjob-datasource
        /// Required: True
        /// UpdateType: Immutable
        /// Type: DataSource
        /// </summary>
        [Required]
        public Union<Humidifier.Personalize.DatasetImportJobTypes.DataSource, BaseFunction>? DataSource { get; set; }
    }

    namespace DatasetImportJobTypes
    {
        public class DataSource : Humidifier.Base.BaseSubResource, IHaveDataLocation
        {
            /// <summary>
            /// DataLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-datasetimportjob-datasource.html#cfn-personalize-datasetimportjob-datasource-datalocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataLocation { get; set; }
        }
    }
}