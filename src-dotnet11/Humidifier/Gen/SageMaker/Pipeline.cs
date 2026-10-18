namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using PipelineTypes;

    public class Pipeline : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHavePipelineName, IHaveSageMakerPipelineTypesParallelismConfigurationParallelismConfiguration, IHavePipelineDescription, IHavePipelineDisplayName, IHaveSageMakerPipelineTypesPipelineDefinitionPipelineDefinition, IHaveRoleArn, IHaveDescription
    {
        public override string AWSTypeName { get => AWS.SageMaker.Pipeline; }
        public Union<string, BaseFunction>? PipelineName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// ParallelismConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-parallelismconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ParallelismConfiguration
        /// </summary>
        public Union<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration, BaseFunction>? ParallelismConfiguration { get; set; }
        /// <summary>
        /// PipelineDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-pipelinedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PipelineDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => PipelineDescription; set => PipelineDescription = value; }
        /// <summary>
        /// PipelineDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-pipelinedisplayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PipelineDisplayName { get; set; }

        /// <summary>
        /// PipelineDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-pipelinedefinition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PipelineDefinition
        /// </summary>
        [Required]
        public Union<Humidifier.SageMaker.PipelineTypes.PipelineDefinition, BaseFunction>? PipelineDefinition { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace PipelineTypes
    {
        public class ParallelismConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxParallelExecutionSteps_Integer
        {
            /// <summary>
            /// MaxParallelExecutionSteps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-parallelismconfiguration.html#cfn-sagemaker-pipeline-parallelismconfiguration-maxparallelexecutionsteps
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxParallelExecutionSteps { get; set; }
        }

        public class PipelineDefinition : Humidifier.Base.BaseSubResource, IHavePipelineDefinitionBody, IHaveSageMakerPipelineTypesS3LocationPipelineDefinitionS3Location
        {
            /// <summary>
            /// PipelineDefinitionBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-pipelinedefinition.html#cfn-sagemaker-pipeline-pipelinedefinition-pipelinedefinitionbody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PipelineDefinitionBody { get; set; }
            /// <summary>
            /// PipelineDefinitionS3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-pipelinedefinition.html#cfn-sagemaker-pipeline-pipelinedefinition-pipelinedefinitions3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public Union<Humidifier.SageMaker.PipelineTypes.S3Location, BaseFunction>? PipelineDefinitionS3Location { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveBucket, IHaveVersion, IHaveETag, IHaveKey
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-s3location.html#cfn-sagemaker-pipeline-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-s3location.html#cfn-sagemaker-pipeline-s3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
            /// <summary>
            /// ETag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-s3location.html#cfn-sagemaker-pipeline-s3location-etag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ETag { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-s3location.html#cfn-sagemaker-pipeline-s3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Key { get; set; }
        }
    }
}