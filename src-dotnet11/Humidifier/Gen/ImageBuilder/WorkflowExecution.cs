namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;

    public class WorkflowExecution : Humidifier.Base.BaseResource, IHaveImageBuildVersionArn
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Type =  "Type" ;
            public static string EndTime =  "EndTime" ;
            public static string WorkflowExecutionId =  "WorkflowExecutionId" ;
            public static string TotalStepCount =  "TotalStepCount" ;
            public static string TotalStepsSkipped =  "TotalStepsSkipped" ;
            public static string StartTime =  "StartTime" ;
            public static string Arn =  "Arn" ;
            public static string TotalStepsSucceeded =  "TotalStepsSucceeded" ;
            public static string WorkflowBuildVersionArn =  "WorkflowBuildVersionArn" ;
            public static string TotalStepsFailed =  "TotalStepsFailed" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.WorkflowExecution; }
        /// <summary>
        /// ImageBuildVersionArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-imagebuilder-workflowexecution.html#cfn-imagebuilder-workflowexecution-imagebuildversionarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ImageBuildVersionArn { get; set; }
    }
}