namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using DataDeletionJobTypes;

    public class DataDeletionJob : Humidifier.Base.BaseResource, IHaveDatasetGroupArn, IHaveJobName, IHaveRoleArn, IHavePersonalizeDataDeletionJobTypesDataSourceDataSource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string DataDeletionJobArn =  "DataDeletionJobArn" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string LastUpdatedDateTime =  "LastUpdatedDateTime" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.DataDeletionJob; }
        /// <summary>
        /// DatasetGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datadeletionjob.html#cfn-personalize-datadeletionjob-datasetgrouparn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DatasetGroupArn { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datadeletionjob.html#cfn-personalize-datadeletionjob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datadeletionjob.html#cfn-personalize-datadeletionjob-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// DataSource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-datadeletionjob.html#cfn-personalize-datadeletionjob-datasource
        /// Required: False
        /// UpdateType: Immutable
        /// Type: DataSource
        /// </summary>
        public Union<Humidifier.Personalize.DataDeletionJobTypes.DataSource, BaseFunction>? DataSource { get; set; }
    }

    namespace DataDeletionJobTypes
    {
        public class DataSource : Humidifier.Base.BaseSubResource, IHaveDataLocation
        {
            /// <summary>
            /// DataLocation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-datadeletionjob-datasource.html#cfn-personalize-datadeletionjob-datasource-datalocation
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DataLocation { get; set; }
        }
    }
}