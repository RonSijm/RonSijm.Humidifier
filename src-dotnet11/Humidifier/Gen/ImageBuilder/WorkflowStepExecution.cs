namespace Humidifier.ImageBuilder
{
    using global::System.Collections.Generic;

    public class WorkflowStepExecution : Humidifier.Base.BaseResource
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string Action =  "Action" ;
            public static string EndTime =  "EndTime" ;
            public static string WorkflowExecutionId =  "WorkflowExecutionId" ;
            public static string StartTime =  "StartTime" ;
            public static string Name =  "Name" ;
            public static string TimeoutSeconds =  "TimeoutSeconds" ;
            public static string ImageBuildVersionArn =  "ImageBuildVersionArn" ;
            public static string Outputs =  "Outputs" ;
            public static string Inputs =  "Inputs" ;
            public static string StepExecutionId =  "StepExecutionId" ;
            public static string WorkflowBuildVersionArn =  "WorkflowBuildVersionArn" ;
            public static string OnFailure =  "OnFailure" ;
        }

        public override string AWSTypeName { get => AWS.ImageBuilder.WorkflowStepExecution; }
    }
}