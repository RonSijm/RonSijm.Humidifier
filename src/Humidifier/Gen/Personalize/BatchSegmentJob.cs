namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using BatchSegmentJobTypes;

    public class BatchSegmentJob : Humidifier.Base.BaseResource, IHaveTags, IHaveRoleArn, IHaveJobName
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
        public Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobInput JobInput { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobName { get; set; }
        /// <summary>
        /// SolutionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-solutionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SolutionVersionArn { get; set; }
        /// <summary>
        /// NumResults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-numresults
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic NumResults { get; set; }
        /// <summary>
        /// JobOutput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-joboutput
        /// Required: False
        /// UpdateType: Immutable
        /// Type: BatchSegmentJobOutput
        /// </summary>
        public Humidifier.Personalize.BatchSegmentJobTypes.BatchSegmentJobOutput JobOutput { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchsegmentjob.html#cfn-personalize-batchsegmentjob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
    }

    namespace BatchSegmentJobTypes
    {
        public class BatchSegmentJobInput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-batchsegmentjob-batchsegmentjobinput.html#cfn-personalize-batchsegmentjob-batchsegmentjobinput-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataConfig
            /// </summary>
            public Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig S3DataSource { get; set; }
        }

        public class BatchSegmentJobOutput : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// S3DataDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-batchsegmentjob-batchsegmentjoboutput.html#cfn-personalize-batchsegmentjob-batchsegmentjoboutput-s3datadestination
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataConfig
            /// </summary>
            public Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig S3DataDestination { get; set; }
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
            public dynamic Path { get; set; }
        }
    }
}