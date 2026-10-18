namespace Humidifier.SageMaker
{
    using global::System.Collections.Generic;
    using PipelineExecutionTypes;

    public class PipelineExecution : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string LastModifiedBy =  "LastModifiedBy" ;
            public static string CreatedBy =  "CreatedBy" ;
            public static string PipelineName =  "PipelineName" ;
            public static string PipelineVersionId =  "PipelineVersionId" ;
            public static string PipelineArn =  "PipelineArn" ;
            public static string PipelineExecutionDescription =  "PipelineExecutionDescription" ;
            public static string ParallelismConfiguration =  "ParallelismConfiguration" ;
            public static string PipelineExecutionArn =  "PipelineExecutionArn" ;
            public static string PipelineExecutionStatus =  "PipelineExecutionStatus" ;
            public static string PipelineExecutionId =  "PipelineExecutionId" ;
            public static string CreationTime =  "CreationTime" ;
            public static string LastModifiedTime =  "LastModifiedTime" ;
            public static string Tags =  "Tags" ;
            public static string PipelineExecutionDisplayName =  "PipelineExecutionDisplayName" ;
        }

        public override string AWSTypeName { get => AWS.SageMaker.PipelineExecution; }
    }

    namespace PipelineExecutionTypes
    {
        public class IamIdentity : Humidifier.Base.BaseSubResource, IHaveSourceIdentity, IHavePrincipalId, IHaveArn
        {
            /// <summary>
            /// SourceIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipelineexecution-iamidentity.html#cfn-sagemaker-pipelineexecution-iamidentity-sourceidentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? SourceIdentity { get; set; }
            /// <summary>
            /// PrincipalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipelineexecution-iamidentity.html#cfn-sagemaker-pipelineexecution-iamidentity-principalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? PrincipalId { get; set; }
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipelineexecution-iamidentity.html#cfn-sagemaker-pipelineexecution-iamidentity-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Arn { get; set; }
        }

        public class ParallelismConfiguration : Humidifier.Base.BaseSubResource, IHaveMaxParallelExecutionSteps_Integer
        {
            /// <summary>
            /// MaxParallelExecutionSteps
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipelineexecution-parallelismconfiguration.html#cfn-sagemaker-pipelineexecution-parallelismconfiguration-maxparallelexecutionsteps
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? MaxParallelExecutionSteps { get; set; }
        }

        public class UserContext : Humidifier.Base.BaseSubResource, IHaveSageMakerPipelineExecutionTypesIamIdentityIamIdentity
        {
            /// <summary>
            /// IamIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-pipelineexecution-usercontext.html#cfn-sagemaker-pipelineexecution-usercontext-iamidentity
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamIdentity
            /// </summary>
            public Union<Humidifier.SageMaker.PipelineExecutionTypes.IamIdentity, BaseFunction>? IamIdentity { get; set; }
        }
    }
}