namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using PipelineTypes;

    public class Pipeline : Humidifier.Resource, IHaveTags
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::Pipeline";
            }
        }

        /// <summary>
        /// PipelineName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-pipelinename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PipelineName { get; set; }
        /// <summary>
        /// ParallelismConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-parallelismconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ParallelismConfiguration
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration { get; set; }
        /// <summary>
        /// PipelineDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-pipelinedescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PipelineDescription { get; set; }
        /// <summary>
        /// PipelineDisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-pipelinedisplayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PipelineDisplayName { get; set; }
        /// <summary>
        /// PipelineDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-pipelinedefinition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: PipelineDefinition
        /// </summary>
        public PipelineDefinition PipelineDefinition { get; set; }
        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-pipeline.html#cfn-sagemaker-pipeline-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace PipelineTypes
    {
        public class ParallelismConfiguration
        {
            /// <summary>
            /// MaxParallelExecutionSteps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-parallelismconfiguration.html#cfn-sagemaker-pipeline-parallelismconfiguration-maxparallelexecutionsteps
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxParallelExecutionSteps { get; set; }
        }

        public class PipelineDefinition
        {
            /// <summary>
            /// PipelineDefinitionBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-pipelinedefinition.html#cfn-sagemaker-pipeline-pipelinedefinition-pipelinedefinitionbody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PipelineDefinitionBody { get; set; }
            /// <summary>
            /// PipelineDefinitionS3Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-pipelinedefinition.html#cfn-sagemaker-pipeline-pipelinedefinition-pipelinedefinitions3location
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Location
            /// </summary>
            public S3Location PipelineDefinitionS3Location { get; set; }
        }

        public class S3Location
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-s3location.html#cfn-sagemaker-pipeline-s3location-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-s3location.html#cfn-sagemaker-pipeline-s3location-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version { get; set; }
            /// <summary>
            /// ETag
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-s3location.html#cfn-sagemaker-pipeline-s3location-etag
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ETag { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipeline-s3location.html#cfn-sagemaker-pipeline-s3location-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }
    }
}