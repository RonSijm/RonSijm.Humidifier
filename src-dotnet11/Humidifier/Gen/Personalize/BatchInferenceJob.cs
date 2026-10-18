namespace Humidifier.Personalize
{
    using global::System.Collections.Generic;
    using BatchInferenceJobTypes;

    public class BatchInferenceJob : Humidifier.Base.BaseResource, IHaveTags, IHavePersonalizeBatchInferenceJobTypesBatchInferenceJobInputJobInput, IHaveBatchInferenceJobMode, IHaveJobName, IHaveSolutionVersionArn, IHaveNumResults_Integer, IHavePersonalizeBatchInferenceJobTypesBatchInferenceJobOutputJobOutput, IHaveRoleArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationDateTime =  "CreationDateTime" ;
            public static string BatchInferenceJobArn =  "BatchInferenceJobArn" ;
            public static string LastUpdatedDateTime =  "LastUpdatedDateTime" ;
        }

        public override string AWSTypeName { get => AWS.Personalize.BatchInferenceJob; }
        /// <summary>
        /// JobInput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchinferencejob.html#cfn-personalize-batchinferencejob-jobinput
        /// Required: False
        /// UpdateType: Immutable
        /// Type: BatchInferenceJobInput
        /// </summary>
        public Union<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobInput, BaseFunction>? JobInput { get; set; }
        /// <summary>
        /// BatchInferenceJobMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchinferencejob.html#cfn-personalize-batchinferencejob-batchinferencejobmode
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? BatchInferenceJobMode { get; set; }
        /// <summary>
        /// JobName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchinferencejob.html#cfn-personalize-batchinferencejob-jobname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? JobName { get; set; }
        /// <summary>
        /// SolutionVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchinferencejob.html#cfn-personalize-batchinferencejob-solutionversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SolutionVersionArn { get; set; }
        /// <summary>
        /// NumResults
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchinferencejob.html#cfn-personalize-batchinferencejob-numresults
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? NumResults { get; set; }
        /// <summary>
        /// JobOutput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchinferencejob.html#cfn-personalize-batchinferencejob-joboutput
        /// Required: False
        /// UpdateType: Immutable
        /// Type: BatchInferenceJobOutput
        /// </summary>
        public Union<Humidifier.Personalize.BatchInferenceJobTypes.BatchInferenceJobOutput, BaseFunction>? JobOutput { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchinferencejob.html#cfn-personalize-batchinferencejob-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-personalize-batchinferencejob.html#cfn-personalize-batchinferencejob-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace BatchInferenceJobTypes
    {
        public class BatchInferenceJobInput : Humidifier.Base.BaseSubResource, IHavePersonalizeBatchInferenceJobTypesS3DataConfigS3DataSource
        {
            /// <summary>
            /// S3DataSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-batchinferencejob-batchinferencejobinput.html#cfn-personalize-batchinferencejob-batchinferencejobinput-s3datasource
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataConfig
            /// </summary>
            public Union<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig, BaseFunction>? S3DataSource { get; set; }
        }

        public class BatchInferenceJobOutput : Humidifier.Base.BaseSubResource, IHavePersonalizeBatchInferenceJobTypesS3DataConfigS3DataDestination
        {
            /// <summary>
            /// S3DataDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-batchinferencejob-batchinferencejoboutput.html#cfn-personalize-batchinferencejob-batchinferencejoboutput-s3datadestination
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3DataConfig
            /// </summary>
            public Union<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig, BaseFunction>? S3DataDestination { get; set; }
        }

        public class S3DataConfig : Humidifier.Base.BaseSubResource, IHavePath
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-personalize-batchinferencejob-s3dataconfig.html#cfn-personalize-batchinferencejob-s3dataconfig-path
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Path { get; set; }
        }
    }
}