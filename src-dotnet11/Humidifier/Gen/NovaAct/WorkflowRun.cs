namespace Humidifier.NovaAct
{
    using global::System.Collections.Generic;

    public class WorkflowRun : Humidifier.Base.BaseResource, IHaveWorkflowDefinitionName, IHaveLogGroupName, IHaveModelId
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string StartedAt =  "StartedAt" ;
            public static string WorkflowRunArn =  "WorkflowRunArn" ;
            public static string WorkflowRunId =  "WorkflowRunId" ;
        }

        public override string AWSTypeName { get => AWS.NovaAct.WorkflowRun; }

        /// <summary>
        /// WorkflowDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-novaact-workflowrun.html#cfn-novaact-workflowrun-workflowdefinitionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? WorkflowDefinitionName { get; set; }
        /// <summary>
        /// LogGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-novaact-workflowrun.html#cfn-novaact-workflowrun-loggroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? LogGroupName { get; set; }

        /// <summary>
        /// ModelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-novaact-workflowrun.html#cfn-novaact-workflowrun-modelid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ModelId { get; set; }
    }
}