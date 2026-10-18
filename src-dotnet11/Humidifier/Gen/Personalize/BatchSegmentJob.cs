namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using BatchSegmentJobTypes;

    public class BatchSegmentJob : Humidifier.Base.BaseResource, IHaveTags, IHavePersonalizeBatchSegmentJobTypesBatchSegmentJobInputJobInput, IHaveJobName, IHaveSolutionVersionArn, IHaveNumResults_Integer, IHavePersonalizeBatchSegmentJobTypesBatchSegmentJobOutputJobOutput, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string BatchSegmentJobArn =  "BatchSegmentJobArn" ;
            public static string LastUpdatedDateTime =  "LastUpdatedDateTime" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.BatchSegmentJob; }
        /// <summary>
        /// JobInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-jobinput
        /// Required: False
        /// UpdateType: Immutable
        /// Type: BatchSegmentJobInput
        /// </summary>
        public Union<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput, BaseFunction>? JobInput { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }
        /// <summary>
        /// SolutionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-solutionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SolutionVersionArn { get; set; }
        /// <summary>
        /// NumResults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-numresults
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NumResults { get; set; }
        /// <summary>
        /// JobOutput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-joboutput
        /// Required: False
        /// UpdateType: Immutable
        /// Type: BatchSegmentJobOutput
        /// </summary>
        public Union<Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput, BaseFunction>? JobOutput { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BatchSegmentJobTypes
    {
        public class BatchSegmentJobInput : Humidifier.Base.BaseSubResource, IHavePersonalizeBatchSegmentJobTypesS3DataConfigS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-batchsegmentjob-batchsegmentjobinput.html#cfn-personalize-batchsegmentjob-batchsegmentjobinput-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataConfig
            /// </summary>
            public Union<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig, BaseFunction>? S3DataSource { get; set; }
        }

        public class BatchSegmentJobOutput : Humidifier.Base.BaseSubResource, IHavePersonalizeBatchSegmentJobTypesS3DataConfigS3DataDestination
        {
            /// <summary>
            /// S3DataDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-batchsegmentjob-batchsegmentjoboutput.html#cfn-personalize-batchsegmentjob-batchsegmentjoboutput-s3datadestination
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataConfig
            /// </summary>
            public Union<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig, BaseFunction>? S3DataDestination { get; set; }
        }

        public class S3DataConfig : Humidifier.Base.BaseSubResource, IHavePath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-batchsegmentjob-s3dataconfig.html#cfn-personalize-batchsegmentjob-s3dataconfig-path
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
        }
    }
}